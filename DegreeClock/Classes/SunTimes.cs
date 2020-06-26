using System;

namespace Calendar
{
    /// <summary>
    /// Computes the daily sun times.
    /// </summary>
    /// <remarks>Most of the astronomical mathematical calculations were directly adapted from the excellent
    /// calendar calculation in C# Copyright © by Ulrich and Ziporah Greve (2005)</remarks>
    public class SunTimes
    {
        #region properties

        /// <summary>
        /// The Location at which to calculate the SunTimes for
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// The date for which to calculate the SunTimes for
        /// </summary>
        public DateTime Date { get; set; }

        #endregion properties

        #region constructors

        /// <summary>
        /// Create a new SunTimes instance for the given day and Location
        /// </summary>
        /// <param name="d"></param>
        /// <param name="loc"></param>
        public SunTimes(DateTime d, Location loc)
        {
            this.Date = d;
            this.Location = loc;
        }
        #endregion constructors

        #region public instance functions
        /// <summary>
        /// Gets an array of two HourMinute structures. The first is the time of sunrise for the current date and location and the second is the time of sunset.
        /// </summary>
        /// <param name="considerElevation">If true, will calculate the times at the Elevation of the Location. 
        /// Otherwise, will calculate for an elevation of 0</param>
        /// <returns></returns>
        public HourMinute[] GetSunTimes(bool considerElevation = true)
        {
            return SunTimes.GetSunTimes(this.Date, this.Location, considerElevation);
        }

        #endregion public instance functions

        #region Astronomical Calculations

        /// <summary>
        /// Gets an array of two HourMinute structures.
        /// The first is the time of sunrise for the given date and location and the second is the time of sunset.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="location"></param>
        /// <param name="considerElevation">If true, will calculate the times at the Elevation of the Location. 
        /// Otherwise, will calculate for an elevation of 0</param>
        /// <returns></returns>
        public static HourMinute[] GetSunTimes(DateTime date, Location location, bool considerElevation = true)
        {
            HourMinute sunrise = HourMinute.NoValue, sunset = HourMinute.NoValue;
            if (location == null)
            {
                return new HourMinute[] { sunrise, sunset };
            }

            int day = GetDayOfYear(date);
            double zeninthDeg = 90, zenithMin = 50, lonHour = 0, longitude = 0, latitude = 0, cosLat = 0, sinLat = 0, cosZen = 0, sinDec = 0, cosDec = 0,
                xmRise = 0, xmSet = 0, xlRise = 0, xlSet = 0, aRise = 0, aSet = 0, ahrRise = 0, ahrSet = 0,
                hRise = 0, hSet = 0, tRise = 0, tSet = 0, utRise = 0, utSet = 0, earthRadius = 6356900,
                zenithAtElevation = DegToDec(zeninthDeg, zenithMin) + RadToDeg(Math.Acos(earthRadius / (earthRadius +
                    (considerElevation ? location.Elevation : 0))));

            zeninthDeg = Math.Floor(zenithAtElevation);
            zenithMin = (zenithAtElevation - Math.Floor(zenithAtElevation)) * 60;
            cosZen = Math.Cos(0.01745 * DegToDec(zeninthDeg, zenithMin));
            longitude = DegToDec(location.LongitudeDegrees, location.LongitudeMinutes) *
                (location.LongitudeType == Location.LongitudeTypes.West ? 1 : -1);
            lonHour = longitude / 15;
            latitude = DegToDec(location.LatitudeDegrees, location.LatitudeMinutes) *
                (location.LatitudeType == Location.LatitudeTypes.North ? 1 : -1);
            cosLat = Math.Cos(0.01745 * latitude);
            sinLat = Math.Sin(0.01745 * latitude);
            tRise = day + (6 + lonHour) / 24;
            tSet = day + (18 + lonHour) / 24;
            xmRise = M(tRise);
            xlRise = L(xmRise);
            xmSet = M(tSet);
            xlSet = L(xmSet);
            aRise = 57.29578 * Math.Atan(0.91746 * Math.Tan(0.01745 * xlRise));
            aSet = 57.29578 * Math.Atan(0.91746 * Math.Tan(0.01745 * xlSet));
            if (Math.Abs(aRise + 360 - xlRise) > 90)
            {
                aRise += 180;
            }
            if (aRise > 360)
            {
                aRise -= 360;
            }
            if (Math.Abs(aSet + 360 - xlSet) > 90)
            {
                aSet += 180;
            }
            if (aSet > 360)
            {
                aSet -= 360;
            }
            ahrRise = aRise / 15;
            sinDec = 0.39782 * Math.Sin(0.01745 * xlRise);
            cosDec = Math.Sqrt(1 - sinDec * sinDec);
            hRise = (cosZen - sinDec * sinLat) / (cosDec * cosLat);
            ahrSet = aSet / 15;
            sinDec = 0.39782 * Math.Sin(0.01745 * xlSet);
            cosDec = Math.Sqrt(1 - sinDec * sinDec);
            hSet = (cosZen - sinDec * sinLat) / (cosDec * cosLat);
            if (Math.Abs(hRise) <= 1)
            {
                hRise = 57.29578 * Math.Acos(hRise);
                utRise = ((360 - hRise) / 15) + ahrRise + Adj(tRise) + lonHour;
                sunrise = TimeAdj(utRise + location.TimeZone, date, location);
                while (sunrise.Hour > 12)
                {
                    sunrise.Hour -= 12;
                }
            }

            if (Math.Abs(hSet) <= 1)
            {
                hSet = 57.29578 * Math.Acos(hSet);
                utSet = (hRise / 15) + ahrSet + Adj(tSet) + lonHour;
                sunset = TimeAdj(utSet + location.TimeZone, date, location);
                while (sunset.Hour < 12)
                {
                    sunset.Hour += 12;
                }
            }

            return new HourMinute[] { sunrise, sunset };
        }

        private static double Adj(double x)
        {
            return (-0.06571 * x - 6.62);
        }

        private static double DegToDec(double deg, double min)
        {
            return (deg + min / 60);
        }

        private static int GetDayOfYear(DateTime date)
        {
            int[] monCount = { 0, 1, 32, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335, 366 };
            if ((date.Month > 2) && (IsSecularLeapYear(date.Year)))
            {
                return monCount[date.Month] + date.Day + 1;
            }
            else
            {
                return monCount[date.Month] + date.Day;
            }
        }

        private static bool IsSecularLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            if (year % 100 != 0)
            {
                if (year % 4 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static double L(double x)
        {
            return (x + 1.916 * Math.Sin(0.01745 * x) + 0.02 * Math.Sin(2 * 0.01745 * x) + 282.565);
        }

        private static double M(double x)
        {
            return (0.9856 * x - 3.251);
        }

        private static double RadToDeg(double rad)
        {
            return 57.29578 * rad;
        }

        private static HourMinute TimeAdj(double time, DateTime date, Location location)
        {
            int hour, min;

            if (time < 0)
            {
                time += 24;
            }

            hour = (int)(Math.Truncate(Math.Floor(time)));
            min = (int)(Math.Truncate(Math.Floor((time - hour) * 60d + 0.5)));

            if (min >= 60)
            {
                hour += 1;
                min -= 60;
            }

            if (hour > 24)
            {
                hour -= 24;
            }

            HourMinute hm = new HourMinute { Hour = hour, Minute = min };

            if (DST.IsDateTimeDST(date.Date.AddHours(hour), location))
            {
                hm += 60;
            }

            return hm;
        }

        #endregion Astronomical Calculations
    }
}