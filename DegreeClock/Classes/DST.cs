using System;

namespace Calendar
{
    public static class DST
    {
        #region Public Methods      
        /// <summary>
        /// Determines if the given Gregorian date and time is within the rules for DST.
        /// If no time zone info is available, the current system is used.
        /// </summary>
        /// <param name="date">The Gregorian date</param>
        /// <param name="location">Where in the world?</param>
        /// <returns>True if the given date and time is DST for the given location, otherwise False.</returns>
        public static bool IsDateTimeDST(DateTime date, Location location = null)
        {
            var tzi = location != null && location.TimeZoneInfo != null ?
                location.TimeZoneInfo : TimeZoneInfo.Local;
            return tzi.IsAmbiguousTime(date) || tzi.IsDaylightSavingTime(date);
        }
        #endregion Public Methods

    }
}