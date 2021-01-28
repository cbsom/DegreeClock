using System;
using System.Drawing;
using System.Windows.Forms;

namespace DegreeClock
{
    public enum TimeNotation
    {
        DegTimeTime,
        DegTimeLong,
        DegTimeShort,
        RegTimeLong,
        RegTimeShort,
        RegTime24Long,
        RegTime24Short
    }

    public partial class frmSettings : Form
    {
        private readonly string _origLocation = Properties.Settings.Default.LocationName;
        public frmSettings()
        {
            InitializeComponent();

            this.cmbLocations.DataSource = Program.LocationsList;
            this.LoadFromSettings();
            this.cmbDegTimeLabelFormat.SelectedIndexChanged += SettingChanged;
            this.cmbRegTimeLabelFormat.SelectedIndexChanged += SettingChanged;
            this.cmbTitleBarFormat.SelectedIndexChanged += SettingChanged;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            this.cmbThemes.DataSource = Theme.Themes;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //If the entered text is not a valid location, go back to the original value
            if (!(this.cmbLocations.SelectedItem is Calendar.Location))
            {
                Properties.Settings.Default.LocationName = this._origLocation;
            }

            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            this.SettingChanged(sender, e);
            this.DialogResult = DialogResult.Cancel;
        }

        private void ChangeBackColor(object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            this.colorDialog1.Color = btn.BackColor;
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btn.BackColor = this.colorDialog1.Color;
                SetForeColorByBackColor(btn);
                this.SettingChanged(sender, e);
            }            
        }
        
        private void ChangeForeColor(object sender, EventArgs e)
        {
            this.colorDialog1.Color = ((Button)sender).ForeColor;
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).ForeColor = this.colorDialog1.Color;
                this.SettingChanged(sender, e);
            }
        }

        private void ChooseFont(object sender, EventArgs e)
        {
            this.fontDialog1.Font = ((Button)sender).Font;
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).Font = this.fontDialog1.Font;
                this.SettingChanged(sender, e);
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to reset to defaults and lose all customization?", "Reset all Defaults", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                this.ReloadSettings();
            }
        }
        private void LoadFromSettings()
        {
            if (Properties.Settings.Default.ShowDegTime)
            {
                switch (Properties.Settings.Default.DegTimeLabelNotation)
                {
                    case TimeNotation.DegTimeTime:
                        this.cmbDegTimeLabelFormat.SelectedIndex = 0;
                        break;
                    case TimeNotation.DegTimeShort:
                        this.cmbDegTimeLabelFormat.SelectedIndex = 2;
                        break;
                    case TimeNotation.DegTimeLong:
                    default:
                        this.cmbDegTimeLabelFormat.SelectedIndex = 1;
                        break;
                }
            }
            else
            {
                this.cmbDegTimeLabelFormat.SelectedIndex = 3;
            }

            if (Properties.Settings.Default.ShowRegTime)
            {
                switch (Properties.Settings.Default.RegTimeLabelNotation)
                {
                    case TimeNotation.RegTimeLong:
                        this.cmbRegTimeLabelFormat.SelectedIndex = 0;
                        break;
                    case TimeNotation.RegTimeShort:
                        this.cmbRegTimeLabelFormat.SelectedIndex = 1;
                        break;
                    case TimeNotation.RegTime24Short:
                        this.cmbRegTimeLabelFormat.SelectedIndex = 3;
                        break;
                    case TimeNotation.RegTime24Long:
                    default:
                        this.cmbRegTimeLabelFormat.SelectedIndex = 2;
                        break;
                }
            }
            else
            {
                this.cmbRegTimeLabelFormat.SelectedIndex = 4;
            }

            if (Properties.Settings.Default.ShowTimeInTitleBar)
            {
                switch (Properties.Settings.Default.TitleBarNotation)
                {
                    case TimeNotation.DegTimeTime:
                        this.cmbTitleBarFormat.SelectedIndex = 0;
                        break;
                    case TimeNotation.DegTimeLong:
                        this.cmbTitleBarFormat.SelectedIndex = 1;
                        break;
                    case TimeNotation.DegTimeShort:
                        this.cmbTitleBarFormat.SelectedIndex = 2;
                        break;
                    case TimeNotation.RegTimeLong:
                        this.cmbTitleBarFormat.SelectedIndex = 3;
                        break;
                    case TimeNotation.RegTimeShort:
                        this.cmbTitleBarFormat.SelectedIndex = 4;
                        break;
                    case TimeNotation.RegTime24Long:
                        this.cmbTitleBarFormat.SelectedIndex = 5;
                        break;
                    case TimeNotation.RegTime24Short:
                        this.cmbTitleBarFormat.SelectedIndex = 6;
                        break;
                    default:
                        this.cmbTitleBarFormat.SelectedIndex = 2;
                        break;
                }
            }
            else
            {
                this.cmbTitleBarFormat.SelectedIndex = 7;
            }

            SetForeColorByBackColor(this.btnBackgroundColor);
            SetForeColorByBackColor(this.btnDayBackgroundColor);
        }


        private void SettingChanged(object sender, EventArgs e)
        {
            switch (this.cmbDegTimeLabelFormat.SelectedIndex)
            {
                case 0:
                    Properties.Settings.Default.ShowDegTime = true;
                    Properties.Settings.Default.DegTimeLabelNotation = TimeNotation.DegTimeTime;
                    break;
                case 2:
                    Properties.Settings.Default.ShowDegTime = true;
                    Properties.Settings.Default.DegTimeLabelNotation = TimeNotation.DegTimeShort;
                    break;
                case 3:
                    Properties.Settings.Default.ShowDegTime = false;
                    break;
                case 1:
                default:
                    Properties.Settings.Default.ShowDegTime = true;
                    Properties.Settings.Default.DegTimeLabelNotation = TimeNotation.DegTimeLong;
                    break;
            }

            switch (this.cmbRegTimeLabelFormat.SelectedIndex)
            {
                case 0:
                    Properties.Settings.Default.ShowRegTime = true;
                    Properties.Settings.Default.RegTimeLabelNotation = TimeNotation.RegTimeLong;
                    break;
                case 1:
                    Properties.Settings.Default.ShowRegTime = true;
                    Properties.Settings.Default.RegTimeLabelNotation = TimeNotation.RegTimeShort;
                    break;
                case 3:
                    Properties.Settings.Default.ShowRegTime = true;
                    Properties.Settings.Default.RegTimeLabelNotation = TimeNotation.RegTime24Short;
                    break;
                case 4:
                    Properties.Settings.Default.ShowRegTime = false;
                    break;
                case 2:
                default:
                    Properties.Settings.Default.ShowRegTime = true;
                    Properties.Settings.Default.RegTimeLabelNotation = TimeNotation.RegTime24Long;
                    break;
            }

            switch (this.cmbTitleBarFormat.SelectedIndex)
            {
                case 0:
                    Properties.Settings.Default.ShowTimeInTitleBar = true;
                    Properties.Settings.Default.TitleBarNotation = TimeNotation.DegTimeTime;
                    break;
                case 1:
                    Properties.Settings.Default.ShowTimeInTitleBar = true;
                    Properties.Settings.Default.TitleBarNotation = TimeNotation.DegTimeLong;
                    break;
                case 3:
                    Properties.Settings.Default.ShowTimeInTitleBar = true;
                    Properties.Settings.Default.TitleBarNotation = TimeNotation.RegTimeLong;
                    break;
                case 4:
                    Properties.Settings.Default.ShowTimeInTitleBar = true;
                    Properties.Settings.Default.TitleBarNotation = TimeNotation.RegTimeShort;
                    break;
                case 5:
                    Properties.Settings.Default.ShowTimeInTitleBar = true;
                    Properties.Settings.Default.TitleBarNotation = TimeNotation.RegTime24Long;
                    break;
                case 6:
                    Properties.Settings.Default.ShowTimeInTitleBar = true;
                    Properties.Settings.Default.TitleBarNotation = TimeNotation.RegTime24Short;
                    break;
                case 7:
                    Properties.Settings.Default.ShowTimeInTitleBar = false;
                    break;
                case 2:
                default:
                    Properties.Settings.Default.ShowTimeInTitleBar = true;
                    Properties.Settings.Default.TitleBarNotation = TimeNotation.DegTimeShort;
                    break;
            }
            ((frmMain)this.Owner).Reload();
        }

        private void button17_Click(object sender, EventArgs e)
        {            
            Theme theme = (Theme)this.cmbThemes.SelectedItem;
            Properties.Settings.Default.DayColor = theme.DayColor;
            Properties.Settings.Default.NightColor = theme.NightColor;
            Properties.Settings.Default.TimePassedColor = theme.TimePassedColor;
            Properties.Settings.Default.CurrentTimeLine = theme.CurrentTimeLine;
            Properties.Settings.Default.FormBackgroundColor = theme.FormBackgroundColor;
            Properties.Settings.Default.TimeTextColor = theme.TimeTextColor;
            Properties.Settings.Default.TimeTextFont = theme.TimeTextFont;
            Properties.Settings.Default.DegreeNumbersColor = theme.DegreeNumbersColor;
            Properties.Settings.Default.DegreeNumbersFont = theme.DegreeNumbersFont;
            Properties.Settings.Default.DegreeLinesColor = theme.DegreeLinesColor;
            Properties.Settings.Default.CurrentDegreeNumberColor = theme.CurrentDegreeNumberColor;
            Properties.Settings.Default.ClockNumbersFont = theme.ClockNumbersFont;
            Properties.Settings.Default.ClockNumbersColor = theme.ClockNumbersColor;
            Properties.Settings.Default.ClockHoursColor = theme.ClockHoursColor;
            Properties.Settings.Default.ClockHoursFont = theme.ClockHoursFont;
            Properties.Settings.Default.ShowCurrentTimeFill = theme.ShowCurrentTimeFill;
            Properties.Settings.Default.ShowRegTime = theme.ShowRegTime;
            Properties.Settings.Default.ShowDegTime = theme.ShowDegTime;
            Properties.Settings.Default.ShowDegreeNumbers = theme.ShowDegreeNumbers;
            Properties.Settings.Default.ShowWordsDegTime = theme.ShowWordsDegTime;
            Properties.Settings.Default.ShowWordsRegTime = theme.ShowWordsRegTime;
            Properties.Settings.Default.DegTimeLabelNotation = theme.DegTimeLabelNotation;
            Properties.Settings.Default.RegTimeLabelNotation = theme.RegTimeLabelNotation;
            Properties.Settings.Default.TitleBarNotation = theme.TitleBarNotation;
            Properties.Settings.Default.ShowTimeInTitleBar = theme.ShowTimeInTitleBar;
            Properties.Settings.Default.ShowDegreeLines = theme.ShowDegreeLines;
            Properties.Settings.Default.HideWindowBorder = theme.HideWindowBorder;
            Properties.Settings.Default.TransparentBackground = theme.TransparentBackground;                        
            this.ReloadSettings();
            this.SettingChanged(sender, e);
        }

        private void ReloadSettings()
        {
            this.cmbDegTimeLabelFormat.SelectedIndexChanged -= SettingChanged;
            this.cmbRegTimeLabelFormat.SelectedIndexChanged -= SettingChanged;
            this.cmbTitleBarFormat.SelectedIndexChanged -= SettingChanged;

            this.LoadFromSettings();

            this.cmbDegTimeLabelFormat.SelectedIndexChanged += SettingChanged;
            this.cmbRegTimeLabelFormat.SelectedIndexChanged += SettingChanged;
            this.cmbTitleBarFormat.SelectedIndexChanged += SettingChanged;
        }

        private static void SetForeColorByBackColor(Button btn)
        {
            btn.ForeColor = btn.BackColor.GetBrightness() < 0.5 ? Color.White : Color.Black;
        }

    }
}

