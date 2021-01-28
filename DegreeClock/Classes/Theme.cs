using System.Drawing;

namespace DegreeClock
{
    public class Theme
    {
        public string Name;
        public Color DayColor;
        public Color NightColor;
        public Color TimePassedColor;
        public Color CurrentTimeLine;
        public Color FormBackgroundColor;
        public Color TimeTextColor;
        public Font TimeTextFont;
        public Color DegreeNumbersColor;
        public Font DegreeNumbersFont;
        public Color DegreeLinesColor;
        public Color CurrentDegreeNumberColor;
        public Font ClockNumbersFont;
        public Color ClockNumbersColor;
        public Color ClockHoursColor;
        public Font ClockHoursFont;
        public bool ShowCurrentTimeFill;
        public bool ShowRegTime;
        public bool ShowDegTime;
        public bool ShowDegreeNumbers;
        public bool ShowWordsDegTime;
        public bool ShowWordsRegTime;
        public TimeNotation DegTimeLabelNotation;
        public TimeNotation RegTimeLabelNotation;
        public TimeNotation TitleBarNotation;
        public bool ShowTimeInTitleBar;
        public bool ShowDegreeLines;
        public bool HideWindowBorder;
        public bool ShowWindowBorder;
        public bool TransparentBackground;

        public override string ToString()
        {
            return this.Name;
        }

        public static Theme DefaultLight = new Theme
        {
            Name = "Default Light",
            DayColor = Color.White,
            NightColor = Color.Silver,
            TimePassedColor = Color.Maroon,
            CurrentTimeLine = Color.Red,
            FormBackgroundColor = Color.Gainsboro,
            TimeTextColor = Color.Red,
            TimeTextFont = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point),
            DegreeNumbersColor = Color.FromArgb(165, 165, 165),
            DegreeNumbersFont = new Font("Tahoma", 7F, FontStyle.Regular, GraphicsUnit.Point),
            DegreeLinesColor = Color.WhiteSmoke,
            CurrentDegreeNumberColor = Color.Red,
            ClockNumbersFont = new Font("Tahoma", 7F, FontStyle.Regular, GraphicsUnit.Point),
            ClockNumbersColor = Color.RosyBrown,
            ClockHoursColor = Color.RosyBrown,
            ClockHoursFont = new Font("Tahoma", 7F, FontStyle.Bold, GraphicsUnit.Point),
            ShowCurrentTimeFill = true,
            ShowRegTime = true,
            ShowDegTime = true,
            ShowDegreeNumbers = true,
            ShowWordsDegTime = true,
            ShowWordsRegTime = true,
            DegTimeLabelNotation = TimeNotation.DegTimeLong,
            RegTimeLabelNotation = TimeNotation.RegTime24Long,
            TitleBarNotation = TimeNotation.DegTimeShort,
            ShowTimeInTitleBar = true,
            ShowDegreeLines = true,
            HideWindowBorder = false,
            ShowWindowBorder = true,
            TransparentBackground = false
        };

        public static Theme DefaultDark = new Theme
        {
            Name = "Default Dark",
            DayColor = Color.Black,
            NightColor = Color.FromArgb(36, 36, 36),
            TimePassedColor = Color.FromArgb(193, 193, 255),
            CurrentTimeLine = Color.Maroon,
            FormBackgroundColor = Color.Black,
            TimeTextColor = Color.FromArgb(128, 128, 255),
            TimeTextFont = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point),
            DegreeNumbersColor = Color.FromArgb(64, 64, 128),
            DegreeNumbersFont = new Font("Tahoma", 7F, FontStyle.Regular, GraphicsUnit.Point),
            DegreeLinesColor = Color.FromArgb(128, 128, 192),
            CurrentDegreeNumberColor = Color.Red,
            ClockNumbersFont = new Font("Tahoma", 7F, FontStyle.Regular, GraphicsUnit.Point),
            ClockNumbersColor = Color.RosyBrown,
            ClockHoursColor = Color.FromArgb(128, 128, 192),
            ClockHoursFont = new Font("Tahoma", 7F, FontStyle.Bold, GraphicsUnit.Point),
            ShowCurrentTimeFill = true,
            ShowRegTime = true,
            ShowDegTime = true,
            ShowDegreeNumbers = true,
            ShowWordsDegTime = true,
            ShowWordsRegTime = true,
            DegTimeLabelNotation = TimeNotation.DegTimeLong,
            RegTimeLabelNotation = TimeNotation.RegTime24Long,
            TitleBarNotation = TimeNotation.DegTimeShort,
            ShowTimeInTitleBar = true,
            ShowDegreeLines = true,
            HideWindowBorder = false,
            ShowWindowBorder = true,
            TransparentBackground = false
        };

        public static Theme DarkWindowless = new Theme
        {
            Name = "Dark Windowless",
            DayColor = Color.Black,
            NightColor = Color.FromArgb(36, 36, 36),
            TimePassedColor = Color.FromArgb(193, 193, 255),
            CurrentTimeLine = Color.Maroon,
            FormBackgroundColor = Color.Black,
            TimeTextColor = Color.FromArgb(128, 128, 255),
            TimeTextFont = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point),
            DegreeNumbersColor = Color.FromArgb(64, 64, 128),
            DegreeNumbersFont = new Font("Tahoma", 7F, FontStyle.Regular, GraphicsUnit.Point),
            DegreeLinesColor = Color.FromArgb(128, 128, 192),
            CurrentDegreeNumberColor = Color.Red,
            ClockNumbersFont = new Font("Tahoma", 7F, FontStyle.Regular, GraphicsUnit.Point),
            ClockNumbersColor = Color.RosyBrown,
            ClockHoursColor = Color.FromArgb(128, 128, 192),
            ClockHoursFont = new Font("Tahoma", 7F, FontStyle.Bold, GraphicsUnit.Point),
            ShowCurrentTimeFill = false,
            ShowRegTime = true,
            ShowDegTime = true,
            ShowDegreeNumbers = true,
            ShowWordsDegTime = false,
            ShowWordsRegTime = false,
            DegTimeLabelNotation = TimeNotation.DegTimeLong,
            RegTimeLabelNotation = TimeNotation.RegTime24Long,
            TitleBarNotation = TimeNotation.DegTimeShort,
            ShowTimeInTitleBar = false,
            ShowDegreeLines = false,
            HideWindowBorder = true,
            ShowWindowBorder = false,
            TransparentBackground = false
        };

        public static Theme TransparentDarkWindowless = new Theme
        {
            Name = "Transparent Dark Windowless",
            DayColor = Color.Transparent,
            NightColor = Color.FromArgb(75, 36, 36, 36),
            TimePassedColor = Color.FromArgb(193, 193, 255),
            CurrentTimeLine = Color.Maroon,
            FormBackgroundColor = Color.Black,
            TimeTextColor = Color.FromArgb(128, 128, 255),
            TimeTextFont = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point),
            DegreeNumbersColor = Color.FromArgb(64, 64, 128),
            DegreeNumbersFont = new Font("Tahoma", 7F, FontStyle.Regular, GraphicsUnit.Point),
            DegreeLinesColor = Color.FromArgb(128, 128, 192),
            CurrentDegreeNumberColor = Color.Red,
            ClockNumbersFont = new Font("Tahoma", 7F, FontStyle.Regular, GraphicsUnit.Point),
            ClockNumbersColor = Color.RosyBrown,
            ClockHoursColor = Color.FromArgb(128, 128, 192),
            ClockHoursFont = new Font("Tahoma", 7F, FontStyle.Bold, GraphicsUnit.Point),
            ShowCurrentTimeFill = false,
            ShowRegTime = true,
            ShowDegTime = true,
            ShowDegreeNumbers = true,
            ShowWordsDegTime = false,
            ShowWordsRegTime = false,
            DegTimeLabelNotation = TimeNotation.DegTimeLong,
            RegTimeLabelNotation = TimeNotation.RegTime24Long,
            TitleBarNotation = TimeNotation.DegTimeShort,
            ShowTimeInTitleBar = false,
            ShowDegreeLines = false,
            HideWindowBorder = true,
            ShowWindowBorder = false,
            TransparentBackground = true
        };

        public static Theme LightWindowless = new Theme
        {
            Name = "Light Windowless",
            DayColor = Color.White,
            NightColor = Color.FromArgb(240, 240, 240),
            TimePassedColor = Color.FromArgb(193, 193, 255),
            CurrentTimeLine = Color.Red,
            FormBackgroundColor = Color.White,
            TimeTextColor = Color.FromArgb(128, 128, 255),
            TimeTextFont = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point),
            DegreeNumbersColor = Color.FromArgb(64, 64, 128),
            DegreeNumbersFont = new Font("Tahoma", 7F, FontStyle.Regular, GraphicsUnit.Point),
            DegreeLinesColor = Color.FromArgb(128, 128, 192),
            CurrentDegreeNumberColor = Color.Red,
            ClockNumbersFont = new Font("Tahoma", 7F, FontStyle.Regular, GraphicsUnit.Point),
            ClockNumbersColor = Color.RosyBrown,
            ClockHoursColor = Color.FromArgb(128, 128, 192),
            ClockHoursFont = new Font("Tahoma", 7F, FontStyle.Bold, GraphicsUnit.Point),
            ShowCurrentTimeFill = true,
            ShowRegTime = true,
            ShowDegTime = true,
            ShowDegreeNumbers = true,
            ShowWordsDegTime = false,
            ShowWordsRegTime = false,
            DegTimeLabelNotation = TimeNotation.DegTimeLong,
            RegTimeLabelNotation = TimeNotation.RegTime24Long,
            TitleBarNotation = TimeNotation.DegTimeShort,
            ShowTimeInTitleBar = false,
            ShowDegreeLines = false,
            HideWindowBorder = true,
            ShowWindowBorder = false,
            TransparentBackground = false
        };

        public static Theme TransparentLightWindowless = new Theme
        {
            Name = "Transparent Light Windowless",
            DayColor = Color.Transparent,
            NightColor = Color.FromArgb(75, 240, 240, 240),
            TimePassedColor = Color.FromArgb(193, 193, 255),
            CurrentTimeLine = Color.Red,
            FormBackgroundColor = Color.White,
            TimeTextColor = Color.FromArgb(128, 128, 255),
            TimeTextFont = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point),
            DegreeNumbersColor = Color.FromArgb(64, 64, 128),
            DegreeNumbersFont = new Font("Tahoma", 7F, FontStyle.Regular, GraphicsUnit.Point),
            DegreeLinesColor = Color.FromArgb(128, 128, 192),
            CurrentDegreeNumberColor = Color.Red,
            ClockNumbersFont = new Font("Tahoma", 7F, FontStyle.Regular, GraphicsUnit.Point),
            ClockNumbersColor = Color.RosyBrown,
            ClockHoursColor = Color.FromArgb(128, 128, 192),
            ClockHoursFont = new Font("Tahoma", 7F, FontStyle.Bold, GraphicsUnit.Point),
            ShowCurrentTimeFill = false,
            ShowRegTime = true,
            ShowDegTime = true,
            ShowDegreeNumbers = true,
            ShowWordsDegTime = false,
            ShowWordsRegTime = false,
            DegTimeLabelNotation = TimeNotation.DegTimeLong,
            RegTimeLabelNotation = TimeNotation.RegTime24Long,
            TitleBarNotation = TimeNotation.DegTimeShort,
            ShowTimeInTitleBar = false,
            ShowDegreeLines = false,
            HideWindowBorder = true,
            ShowWindowBorder = false,
            TransparentBackground = true
        };

        public static Theme[] Themes =
        {
            DefaultLight,
            DefaultDark,
            DarkWindowless,
            TransparentDarkWindowless,
            LightWindowless,
            TransparentLightWindowless
        };
    }
}
