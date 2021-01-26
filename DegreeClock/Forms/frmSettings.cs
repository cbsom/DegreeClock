using System;
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
        private string _origLocation = Properties.Settings.Default.LocationName;
        public frmSettings()
        {
            InitializeComponent();

            this.cmbLocations.DataSource = Program.LocationsList;
            this.LoadFromSettings();
            this.cmbDegTimeLabelFormat.SelectedIndexChanged += SettingChanged;
            this.cmbRegTimeLabelFormat.SelectedIndexChanged += SettingChanged;
            this.cmbTitleBarFormat.SelectedIndexChanged += SettingChanged;
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
            this.DialogResult = DialogResult.Cancel;
        }

        private void ChangeBackColor(object sender, EventArgs e)
        {
            this.colorDialog1.Color = ((Button)sender).BackColor;
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = this.colorDialog1.Color;
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
            ((frmMain)this.Owner).GetFromSettings();
            ((frmMain)this.Owner).pnlClockDisplay.Invalidate();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (this.cmbThemes.Text)
            {
                case "Default - Light Windowed":
                    var location = Properties.Settings.Default.LocationName;
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.LocationName = location;
                    Properties.Settings.Default.Save();
                    this.ReloadSettings();
                    break;
                case "Dark Windowless":
                    Properties.Settings.Default.DayColor = Properties.DarkWindowlessTheme.Default.DayColor;
                    Properties.Settings.Default.NightColor = Properties.DarkWindowlessTheme.Default.NightColor;
                    Properties.Settings.Default.TimePassedColor = Properties.DarkWindowlessTheme.Default.TimePassedColor;
                    Properties.Settings.Default.CurrentTimeLine = Properties.DarkWindowlessTheme.Default.CurrentTimeLine;
                    Properties.Settings.Default.FormBackgroundColor = Properties.DarkWindowlessTheme.Default.FormBackgroundColor;
                    Properties.Settings.Default.TimeTextColor = Properties.DarkWindowlessTheme.Default.TimeTextColor;
                    Properties.Settings.Default.TimeTextFont = Properties.DarkWindowlessTheme.Default.TimeTextFont;
                    Properties.Settings.Default.DegreeNumbersColor = Properties.DarkWindowlessTheme.Default.DegreeNumbersColor;
                    Properties.Settings.Default.DegreeNumbersFont = Properties.DarkWindowlessTheme.Default.DegreeNumbersFont;
                    Properties.Settings.Default.DegreeLinesColor = Properties.DarkWindowlessTheme.Default.DegreeLinesColor;
                    Properties.Settings.Default.CurrentDegreeNumberColor = Properties.DarkWindowlessTheme.Default.CurrentDegreeNumberColor;
                    Properties.Settings.Default.ClockNumbersFont = Properties.DarkWindowlessTheme.Default.ClockNumbersFont;
                    Properties.Settings.Default.ClockNumbersColor = Properties.DarkWindowlessTheme.Default.ClockNumbersColor;
                    Properties.Settings.Default.ClockHoursColor = Properties.DarkWindowlessTheme.Default.ClockHoursColor;
                    Properties.Settings.Default.ClockHoursFont = Properties.DarkWindowlessTheme.Default.ClockHoursFont;
                    Properties.Settings.Default.ShowCurrentTimeFill = Properties.DarkWindowlessTheme.Default.ShowCurrentTimeFill;
                    Properties.Settings.Default.ShowRegTime = Properties.DarkWindowlessTheme.Default.ShowRegTime;
                    Properties.Settings.Default.ShowDegTime = Properties.DarkWindowlessTheme.Default.ShowDegTime;
                    Properties.Settings.Default.ShowDegreeNumbers = Properties.DarkWindowlessTheme.Default.ShowDegreeNumbers;
                    Properties.Settings.Default.ShowWordsDegTime = Properties.DarkWindowlessTheme.Default.ShowWordsDegTime;
                    Properties.Settings.Default.ShowWordsRegTime = Properties.DarkWindowlessTheme.Default.ShowWordsRegTime;
                    Properties.Settings.Default.DegTimeLabelNotation = Properties.DarkWindowlessTheme.Default.DegTimeLabelNotation;
                    Properties.Settings.Default.RegTimeLabelNotation = Properties.DarkWindowlessTheme.Default.RegTimeLabelNotation;
                    Properties.Settings.Default.TitleBarNotation = Properties.DarkWindowlessTheme.Default.TitleBarNotation;
                    Properties.Settings.Default.ShowTimeInTitleBar = Properties.DarkWindowlessTheme.Default.ShowTimeInTitleBar;
                    Properties.Settings.Default.ShowDegreeLines = Properties.DarkWindowlessTheme.Default.ShowDegreeLines;
                    Properties.Settings.Default.HideWindowBorder = Properties.DarkWindowlessTheme.Default.HideWindowBorder;
                    Properties.Settings.Default.TransparentBackground= Properties.DarkWindowlessTheme.Default.TransparentBackground;
                    Properties.Settings.Default.Save();
                    this.ReloadSettings();
                    break;
                case "Transparent Dark Windowless":
                    Properties.Settings.Default.DayColor = Properties.TransparentForDarkWindowlessTheme.Default.DayColor;
                    Properties.Settings.Default.NightColor = Properties.TransparentForDarkWindowlessTheme.Default.NightColor;
                    Properties.Settings.Default.TimePassedColor = Properties.TransparentForDarkWindowlessTheme.Default.TimePassedColor;
                    Properties.Settings.Default.CurrentTimeLine = Properties.TransparentForDarkWindowlessTheme.Default.CurrentTimeLine;
                    Properties.Settings.Default.FormBackgroundColor = Properties.TransparentForDarkWindowlessTheme.Default.FormBackgroundColor;
                    Properties.Settings.Default.TimeTextColor = Properties.TransparentForDarkWindowlessTheme.Default.TimeTextColor;
                    Properties.Settings.Default.TimeTextFont = Properties.TransparentForDarkWindowlessTheme.Default.TimeTextFont;
                    Properties.Settings.Default.DegreeNumbersColor = Properties.TransparentForDarkWindowlessTheme.Default.DegreeNumbersColor;
                    Properties.Settings.Default.DegreeNumbersFont = Properties.TransparentForDarkWindowlessTheme.Default.DegreeNumbersFont;
                    Properties.Settings.Default.DegreeLinesColor = Properties.TransparentForDarkWindowlessTheme.Default.DegreeLinesColor;
                    Properties.Settings.Default.CurrentDegreeNumberColor = Properties.TransparentForDarkWindowlessTheme.Default.CurrentDegreeNumberColor;
                    Properties.Settings.Default.ClockNumbersFont = Properties.TransparentForDarkWindowlessTheme.Default.ClockNumbersFont;
                    Properties.Settings.Default.ClockNumbersColor = Properties.TransparentForDarkWindowlessTheme.Default.ClockNumbersColor;
                    Properties.Settings.Default.ClockHoursColor = Properties.TransparentForDarkWindowlessTheme.Default.ClockHoursColor;
                    Properties.Settings.Default.ClockHoursFont = Properties.TransparentForDarkWindowlessTheme.Default.ClockHoursFont;
                    Properties.Settings.Default.ShowCurrentTimeFill = Properties.TransparentForDarkWindowlessTheme.Default.ShowCurrentTimeFill;
                    Properties.Settings.Default.ShowRegTime = Properties.TransparentForDarkWindowlessTheme.Default.ShowRegTime;
                    Properties.Settings.Default.ShowDegTime = Properties.TransparentForDarkWindowlessTheme.Default.ShowDegTime;
                    Properties.Settings.Default.ShowDegreeNumbers = Properties.TransparentForDarkWindowlessTheme.Default.ShowDegreeNumbers;
                    Properties.Settings.Default.ShowWordsDegTime = Properties.TransparentForDarkWindowlessTheme.Default.ShowWordsDegTime;
                    Properties.Settings.Default.ShowWordsRegTime = Properties.TransparentForDarkWindowlessTheme.Default.ShowWordsRegTime;
                    Properties.Settings.Default.DegTimeLabelNotation = Properties.TransparentForDarkWindowlessTheme.Default.DegTimeLabelNotation;
                    Properties.Settings.Default.RegTimeLabelNotation = Properties.TransparentForDarkWindowlessTheme.Default.RegTimeLabelNotation;
                    Properties.Settings.Default.TitleBarNotation = Properties.TransparentForDarkWindowlessTheme.Default.TitleBarNotation;
                    Properties.Settings.Default.ShowTimeInTitleBar = Properties.TransparentForDarkWindowlessTheme.Default.ShowTimeInTitleBar;
                    Properties.Settings.Default.ShowDegreeLines = Properties.TransparentForDarkWindowlessTheme.Default.ShowDegreeLines;
                    Properties.Settings.Default.HideWindowBorder = Properties.TransparentForDarkWindowlessTheme.Default.HideWindowBorder;
                    Properties.Settings.Default.TransparentBackground = Properties.TransparentForDarkWindowlessTheme.Default.TransparentBackground;
                    Properties.Settings.Default.Save();
                    this.ReloadSettings();
                    break;
                case "Light Windowless":
                    Properties.Settings.Default.DayColor = Properties.LightWindowless.Default.DayColor;
                    Properties.Settings.Default.NightColor = Properties.LightWindowless.Default.NightColor;
                    Properties.Settings.Default.TimePassedColor = Properties.LightWindowless.Default.TimePassedColor;
                    Properties.Settings.Default.CurrentTimeLine = Properties.LightWindowless.Default.CurrentTimeLine;
                    Properties.Settings.Default.FormBackgroundColor = Properties.LightWindowless.Default.FormBackgroundColor;
                    Properties.Settings.Default.TimeTextColor = Properties.LightWindowless.Default.TimeTextColor;
                    Properties.Settings.Default.TimeTextFont = Properties.LightWindowless.Default.TimeTextFont;
                    Properties.Settings.Default.DegreeNumbersColor = Properties.LightWindowless.Default.DegreeNumbersColor;
                    Properties.Settings.Default.DegreeNumbersFont = Properties.LightWindowless.Default.DegreeNumbersFont;
                    Properties.Settings.Default.DegreeLinesColor = Properties.LightWindowless.Default.DegreeLinesColor;
                    Properties.Settings.Default.CurrentDegreeNumberColor = Properties.LightWindowless.Default.CurrentDegreeNumberColor;
                    Properties.Settings.Default.ClockNumbersFont = Properties.LightWindowless.Default.ClockNumbersFont;
                    Properties.Settings.Default.ClockNumbersColor = Properties.LightWindowless.Default.ClockNumbersColor;
                    Properties.Settings.Default.ClockHoursColor = Properties.LightWindowless.Default.ClockHoursColor;
                    Properties.Settings.Default.ClockHoursFont = Properties.LightWindowless.Default.ClockHoursFont;
                    Properties.Settings.Default.ShowCurrentTimeFill = Properties.LightWindowless.Default.ShowCurrentTimeFill;
                    Properties.Settings.Default.ShowRegTime = Properties.LightWindowless.Default.ShowRegTime;
                    Properties.Settings.Default.ShowDegTime = Properties.LightWindowless.Default.ShowDegTime;
                    Properties.Settings.Default.ShowDegreeNumbers = Properties.LightWindowless.Default.ShowDegreeNumbers;
                    Properties.Settings.Default.ShowWordsDegTime = Properties.LightWindowless.Default.ShowWordsDegTime;
                    Properties.Settings.Default.ShowWordsRegTime = Properties.LightWindowless.Default.ShowWordsRegTime;
                    Properties.Settings.Default.DegTimeLabelNotation = Properties.LightWindowless.Default.DegTimeLabelNotation;
                    Properties.Settings.Default.RegTimeLabelNotation = Properties.LightWindowless.Default.RegTimeLabelNotation;
                    Properties.Settings.Default.TitleBarNotation = Properties.LightWindowless.Default.TitleBarNotation;
                    Properties.Settings.Default.ShowTimeInTitleBar = Properties.LightWindowless.Default.ShowTimeInTitleBar;
                    Properties.Settings.Default.ShowDegreeLines = Properties.LightWindowless.Default.ShowDegreeLines;
                    Properties.Settings.Default.HideWindowBorder = Properties.LightWindowless.Default.HideWindowBorder;
                    Properties.Settings.Default.TransparentBackground = Properties.LightWindowless.Default.TransparentBackground;
                    Properties.Settings.Default.Save();
                    this.ReloadSettings();
                    break;
            }
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
    }
}

