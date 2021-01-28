using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Calendar;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DegreeClock
{
    public partial class frmMain : Form
    {
        #region Private Fields
        private Brush _circleBrush,
            _dayBrush,
            _currTimeBrush,
            _clockNumbersBrush,
            _clockHoursBrush,
            _degreeNumbers,
            _currentDegreeNumber;

        private Pen _currTimeLinePen,
            _degreeLines;
        private Font _degreeNumbersFont,
            _clockNumbersFont;
        private Font _clockHoursFont;
        private readonly StringFormat _stringFormat = new StringFormat(StringFormatFlags.FitBlackBox)
        {
            Alignment = StringAlignment.Center
        };
        private RectangleF _surfaceRect;
        private PointF _centerPoint;
        private float _lineLength;
        private bool _needsRefresh = true;
        private DegreeTime _currDegTime;
        private DateTime _currRegTime;
        private SunTimes _sunTime;
        #endregion

        #region Public Properties
        public Location GeoLocation
        {
            get
            {
                return this._sunTime?.Location;
            }
            set
            {
                if (this._sunTime != null)
                    this._sunTime.Location = value;
            }
        }
        #endregion

        #region Base Overrides
        //Double buffers everything
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                // Turn on WS_EX_COMPOSITED
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        protected override void OnControlAdded(ControlEventArgs e)
        {
            SubscribeEvents(e.Control);
            base.OnControlAdded(e);
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            UnsubscribeEvents(e.Control);
            base.OnControlRemoved(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            bool isTransparent = Properties.Settings.Default.TransparentBackground;
            if (!isTransparent)
            {
                base.OnPaintBackground(e);
            }
        }

        #endregion

        #region Constructors
        public frmMain()
        {
            InitializeComponent();

            var wa = Screen.FromControl(this).WorkingArea;
            if (Properties.Settings.Default.TransparentBackground)
            {
                this.Location = new Point(wa.Width - this.Width, (wa.Height / 2) - (this.Height / 2));
            }
            else
            {
                //Fill the height of the working area
                this.Height = wa.Height;

                //After resize, make sure the panel is square
                var max = Math.Max(this.pnlClockDisplay.Width, this.pnlClockDisplay.Height);

                this.Width = max + (this.Width - this.pnlClockDisplay.Width);
                this.Height = max + (this.Height - this.pnlClockDisplay.Height);

                this.Location = new Point((wa.Width / 2) - (this.Width / 2), wa.Top);
            }

            this.GetFromSettings();

        }
        #endregion

        #region Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            SetDoubleBuffered(this.pnlClockDisplay);
            this.SetRectangleSizes();
            var name = Properties.Settings.Default.LocationName;
            this._currRegTime = DateTime.Now;
            this._sunTime = new SunTimes(this._currRegTime,
                Program.LocationsList.FirstOrDefault(l => l.Name == name));
            this._currDegTime = new DegreeTime(this._currRegTime.TimeOfDay);

            this.FormBorderStyle = Properties.Settings.Default.HideWindowBorder ?
                    FormBorderStyle.None : FormBorderStyle.Sizable;
            this.ShowInTaskbar = !Properties.Settings.Default.HideWindowBorder;

            if (Properties.Settings.Default.HideWindowBorder)
            {
                Task.Factory.StartNew(() =>
                {
                    Thread.Sleep(5000);
                    this.Invoke(new Action(() =>
                    {
                        this.pictureBox1.Visible = false;
                        this.notifyIcon1.Visible = true;
                    }));
                });
            }
        }


        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (this.pnlClockDisplay.Width != this.pnlClockDisplay.Height)
            {
                var max = Math.Max(this.pnlClockDisplay.Width, this.pnlClockDisplay.Height);
                this.Width = max + (this.Width - this.pnlClockDisplay.Width);
                this.Height = max + (this.Height - this.pnlClockDisplay.Height);
            }
            this.SetRectangleSizes();
            this._needsRefresh = true;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.chooseLocationToolStripMenuItem_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this._currRegTime = DateTime.Now;
            this._currDegTime = new DegreeTime(this._currRegTime.TimeOfDay);
            this.label1.Text = this.GetDegTimeLabelText();
            this.label2.Text = this.GetRegTimeLabelText();
            this.Text = this.GetTitleText();
            if ((this._needsRefresh || this._currDegTime.Seconds == 0))
            {
                this.pnlClockDisplay.Invalidate();
            }
        }

        private void pnlClockDisplay_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Process.GetCurrentProcess().ProcessorAffinity = (IntPtr)1;
            if (g.SmoothingMode != System.Drawing.Drawing2D.SmoothingMode.HighQuality)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            }
            this.DrawClockFace(g, this._currDegTime.Degrees);
            this._needsRefresh = false;
        }

        private void chooseLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmSettings
            {
                Owner = this
            };
            if (f.ShowDialog() != DialogResult.None)
            {
                this.Reload();
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void control_ControlAdded(object sender, ControlEventArgs e)
        {
            SubscribeEvents(e.Control);
        }

        private void control_ControlRemoved(object sender, ControlEventArgs e)
        {
            UnsubscribeEvents(e.Control);
        }
        #endregion

        #region Internal Functions
        internal void GetFromSettings()
        {
            if (this.GeoLocation == null || (this.GeoLocation.Name != Properties.Settings.Default.LocationName))
            {
                var name = Properties.Settings.Default.LocationName;
                this.GeoLocation = Program.LocationsList.FirstOrDefault(l => l.Name == name);
            }
            this._circleBrush = new SolidBrush(Properties.Settings.Default.NightColor);
            this._dayBrush = new SolidBrush(Properties.Settings.Default.DayColor);
            this._currTimeBrush = new SolidBrush(Color.FromArgb(50, Properties.Settings.Default.TimePassedColor));
            this._clockNumbersBrush = new SolidBrush(Color.FromArgb(100, Properties.Settings.Default.ClockNumbersColor));
            this._clockHoursBrush = new SolidBrush(Properties.Settings.Default.ClockHoursColor);
            this._currTimeLinePen = new Pen(Properties.Settings.Default.CurrentTimeLine, 1.8f);
            this._degreeNumbers = new SolidBrush(Properties.Settings.Default.DegreeNumbersColor);
            this._degreeLines = new Pen(Properties.Settings.Default.DegreeLinesColor, 0.2f);
            this._currentDegreeNumber = new SolidBrush(Properties.Settings.Default.CurrentDegreeNumberColor);
            this._degreeNumbersFont = Properties.Settings.Default.DegreeNumbersFont;
            this._clockNumbersFont = Properties.Settings.Default.ClockNumbersFont;
            this._clockHoursFont = Properties.Settings.Default.ClockHoursFont;
            Font lblFont = Properties.Settings.Default.TimeTextFont;
            this.label1.Font = lblFont;
            this.label2.Font = lblFont;
            this.label1.Visible = Properties.Settings.Default.ShowDegTime;
            this.label2.Visible = Properties.Settings.Default.ShowRegTime;

            if (Properties.Settings.Default.ShowRegTime ^ Properties.Settings.Default.ShowDegTime)
            {
                var l = Properties.Settings.Default.ShowDegTime ? this.label1 : this.label2;
                l.Width = this.Width;
                l.Font = new Font(lblFont.FontFamily, 22, FontStyle.Bold, GraphicsUnit.Point);
                l.Left = 0;
                l.TextAlign = ContentAlignment.BottomCenter;
                l.Refresh();
            }
            else
            {
                this.label1.Width = (this.Width / 2) - 10;
                this.label1.Left = 0;
                this.label1.TextAlign = ContentAlignment.MiddleLeft;
                this.label2.Width = this.label1.Width;
                this.label2.Left = this.label1.Width;
                this.label2.TextAlign = ContentAlignment.MiddleRight;
                this.label2.Font = lblFont;
            }
            this.pictureBox1.Visible = !Properties.Settings.Default.HideWindowBorder;
            this.notifyIcon1.Visible = Properties.Settings.Default.HideWindowBorder;
            this.FormBorderStyle = Properties.Settings.Default.HideWindowBorder ?
                    FormBorderStyle.None : FormBorderStyle.Sizable;
            this.ShowInTaskbar = !Properties.Settings.Default.HideWindowBorder;
            if (Properties.Settings.Default.TransparentBackground)
            {
                this.AllowTransparency = true;
                this.TransparencyKey = Properties.Settings.Default.FormBackgroundColor;
            }
        }
        /// <summary>
        /// Refreshes GUI from app settings
        /// </summary>
        internal void Reload()
        {
            this.GetFromSettings();
            this.pnlClockDisplay.Invalidate();
        }
        #endregion

        #region Private Static Functions
        private static PointF GetPointOnCircle(double angleInDegrees, PointF centerPoint, double lineLength)
        {
            double angle = (angleInDegrees * Math.PI) / 180;
            var x = centerPoint.X + Math.Cos(angle) * lineLength;
            var y = centerPoint.Y + Math.Sin(angle) * lineLength;

            return new PointF((float)x, (float)y);
        }

        public static void SetDoubleBuffered(Control c)
        {
            //Taxes: Remote Desktop Connection and painting
            //http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
            if (SystemInformation.TerminalServerSession)
                return;

            PropertyInfo aProp =
                  typeof(Control).GetProperty(
                        "DoubleBuffered",
                        BindingFlags.NonPublic |
                        BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }
        #endregion

        #region Private Instance Functions      
        private void SetRectangleSizes()
        {
            var r = this.pnlClockDisplay.DisplayRectangle;
            float w = r.Width * 0.8f,
                  h = r.Height * 0.8f,
                  x = (r.Width - w) / 2f,
                  y = (r.Height - h) / 2f;

            this._surfaceRect = new RectangleF(x, y, w, h);
            this._centerPoint = new PointF(r.Width / 2, r.Height / 2);
            this._lineLength = (w / 2) + 20;
        }

        private void DrawClockFace(Graphics g, int curDeg)
        {
            float width = this.pnlClockDisplay.DisplayRectangle.Width * 0.95f;

            g.Clear(this.BackColor);
            this.DrawClockBackground(g);

            if (Properties.Settings.Default.ShowCurrentTimeLine)
            {
                g.DrawLine(this._currTimeLinePen, this._centerPoint,
                    GetPointOnCircle(this._currDegTime.GetFullDegrees() - 90, this._centerPoint, this._lineLength));
            }

            for (int i = 0; i < 360; i += 5)
            {
                this.DrawSingleDegree(g, curDeg, width, i);
            }
        }

        private void DrawSingleDegree(Graphics g, int curDeg, float width, int degree)
        {
            if (Properties.Settings.Default.ShowDegreeLines)
            {
                //The degree lines - each 5 degrees gets a line
                g.DrawLine(this._degreeLines, this._centerPoint,
                        GetPointOnCircle(degree - 90, this._centerPoint, this._lineLength + 5));
            }

            if (Properties.Settings.Default.ShowDegreeNumbers)
            {
                //Degree Numbers:
                //To correctly position and center the string after the line, 
                //we need to know this size of its box
                string str = degree.ToString();
                PointF point = GetPointOnCircle(degree - 90, this._centerPoint, width / 2);
                SizeF textSize = g.MeasureString(str, this._degreeNumbersFont, point, this._stringFormat);

                //Draw the degree numbers
                g.DrawString(degree.ToString(),
                    this._degreeNumbersFont,
                    (degree == curDeg ? this._currentDegreeNumber : this._degreeNumbers),
                    new PointF(point.X - textSize.Width / 2, point.Y - (textSize.Height / 2)));
            }
            if (Properties.Settings.Default.ShowCurrentTime)
            {
                //Hour clock number:
                if (degree % 15 == 0)
                {
                    string str = (degree > 0 ? degree / 15 : degree).ToString();
                    PointF point = GetPointOnCircle(degree - 90, this._centerPoint, (width / 2) - 25);
                    SizeF textSize = g.MeasureString(str, this._clockHoursFont, point, this._stringFormat);
                    g.DrawString(str,
                        this._clockHoursFont,
                        this._clockHoursBrush,
                        new PointF(point.X - textSize.Width / 2, point.Y - (textSize.Height / 2)));
                }
                else if (Properties.Settings.Default.ShowCurrentTimeMinutes)
                {
                    //Minute clock numbers: one at the 20 minute mark, and one at the 40
                    string str = (((degree * 4) % 60) % 40 == 0 ? 40 : 20).ToString();
                    PointF point = GetPointOnCircle(degree - 90, this._centerPoint, (width / 2) - 20);
                    SizeF textSize = g.MeasureString(str, this._clockNumbersFont, point, this._stringFormat);
                    g.DrawString(str,
                        this._clockNumbersFont,
                        this._clockNumbersBrush,
                        new PointF(point.X - textSize.Width / 2, point.Y - (textSize.Height / 2)));
                }
            }
        }

        private void DrawClockBackground(Graphics g)
        {
            g.FillEllipse(Properties.Settings.Default.ShowNight ? this._circleBrush : this._dayBrush,
                this._surfaceRect);

            if (Properties.Settings.Default.ShowDay && Properties.Settings.Default.ShowNight && this._sunTime.Location != null)
            {
                this._sunTime.Date = this._currRegTime;

                var suntimes = this._sunTime.GetSunTimes();
                var sunrise = new DegreeTime(suntimes[0].ToTimeSpan());
                var sunset = new DegreeTime(suntimes[1].ToTimeSpan());

                g.FillPie(this._dayBrush, this._surfaceRect.X, this._surfaceRect.Y, this._surfaceRect.Width, this._surfaceRect.Height,
                                (float)sunrise.GetFullDegrees() - 90, (float)(sunset.GetFullDegrees() - sunrise.GetFullDegrees()));
            }
            if (Properties.Settings.Default.ShowCurrentTimeFill)
            {
                g.FillPie(this._currTimeBrush, this._surfaceRect.X + 5,
                    this._surfaceRect.Y + 5, this._surfaceRect.Width - 10,
                    this._surfaceRect.Height - 10, 270, (float)this._currDegTime.GetFullDegrees());
            }
        }

        private string GetDegTimeLabelText()
        {
            string txt = "";
            if (Properties.Settings.Default.ShowWordsDegTime)
                txt += "DegTime: ";
            switch (Properties.Settings.Default.DegTimeLabelNotation)
            {
                case TimeNotation.DegTimeTime:
                    txt += this._currDegTime.ToString();
                    break;
                case TimeNotation.DegTimeShort:
                    txt += this._currDegTime.ToShortString();
                    break;
                case TimeNotation.DegTimeLong:
                default:
                    txt += this._currDegTime.ToMediumString();
                    break;
            }
            return txt;
        }

        private string GetRegTimeLabelText()
        {
            string txt = "";

            if (Properties.Settings.Default.ShowWordsRegTime)
                txt += "RegTime: ";
            var n = Properties.Settings.Default.RegTimeLabelNotation;
            switch (n)
            {
                case TimeNotation.RegTimeLong:
                    txt += this._currRegTime.ToString("h:mm:ss tt");
                    break;
                case TimeNotation.RegTimeShort:
                    txt += this._currRegTime.ToString("h:mm tt");
                    break;
                case TimeNotation.RegTime24Short:
                    txt += this._currRegTime.ToString("HH:mm");
                    break;
                case TimeNotation.RegTime24Long:
                default:
                    txt += this._currRegTime.ToString("HH:mm:ss");
                    break;
            }
            return txt;
        }

        private string GetTitleText()
        {
            string txt = "Degree Clock";
            if (Properties.Settings.Default.ShowTimeInTitleBar)
            {
                txt += " - ";

                switch (Properties.Settings.Default.TitleBarNotation)
                {
                    case TimeNotation.DegTimeTime:
                        txt += this._currDegTime.ToString();
                        break;
                    case TimeNotation.DegTimeLong:
                        txt += this._currDegTime.ToMediumString();
                        break;
                    case TimeNotation.RegTimeLong:
                        txt += this._currRegTime.ToString("h:mm:ss tt");
                        break;
                    case TimeNotation.RegTimeShort:
                        txt += this._currRegTime.ToString("h:mm tt");
                        break;
                    case TimeNotation.RegTime24Long:
                        txt += this._currRegTime.ToString("HH:mm:ss");
                        break;
                    case TimeNotation.RegTime24Short:
                        txt += this._currRegTime.ToString("HH:mm");
                        break;
                    case TimeNotation.DegTimeShort:
                    default:
                        txt += this._currDegTime.ToShortString();
                        break;
                }
            }
            return txt;
        }
        private void SubscribeEvents(Control control)
        {
            control.ControlAdded += new ControlEventHandler(control_ControlAdded);
            control.ControlRemoved += new ControlEventHandler(control_ControlRemoved);

            foreach (Control innerControl in control.Controls)
            {
                SubscribeEvents(innerControl);
            }
        }

        private void UnsubscribeEvents(Control control)
        {
            control.ControlAdded -= new ControlEventHandler(control_ControlAdded);
            control.ControlRemoved -= new ControlEventHandler(control_ControlRemoved);

            foreach (Control innerControl in control.Controls)
            {
                UnsubscribeEvents(innerControl);
            }
        }
        #endregion
    }
}
