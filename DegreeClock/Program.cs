﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Calendar;

namespace DegreeClock
{
    static class Program
    {
        internal static List<Location> LocationsList;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadLocations();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Properties.Settings.Default.NeedsUpgrade)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.NeedsUpgrade = false;
                Properties.Settings.Default.Save();
            }

            Application.Run(new frmMain());
        }

        /// </summary>
        internal static void LoadLocations()
        {
            LocationsList = new List<Location>();
            using (var ms = new System.IO.StringReader(Properties.Resources.LocationsList))
            {
                var settings = new System.Xml.XmlReaderSettings() { IgnoreWhitespace = true };
                using (var xr = System.Xml.XmlReader.Create(ms, settings))
                {
                    while (xr.ReadToFollowing("L"))
                    {
                        string name = xr.GetAttribute("N").Trim();
                        int timeZone;
                        int elevation = 0;
                        double latitude;
                        double longitute;
                        string timeZoneName = null;

                        xr.ReadToDescendant("T");
                        timeZone = xr.ReadElementContentAsInt("T", "");
                        if (xr.Name == "E")
                        {
                            elevation = xr.ReadElementContentAsInt("E", "");
                        }

                        latitude = xr.ReadElementContentAsDouble("LT", "");
                        longitute = xr.ReadElementContentAsDouble("LN", "");

                        if (xr.Name == "TZN")
                        {
                            timeZoneName = xr.ReadElementContentAsString("TZN", "");
                        }
                        LocationsList.Add(new Location(name, timeZone, latitude, longitute)
                        {
                            Elevation = elevation,                            
                            TimeZoneName = timeZoneName
                        });
                        LocationsList.Sort((a, b) => String.Compare(a.Name, b.Name));
                    }
                    xr.Close();
                }
                ms.Close();
            }
        }
    }
}
