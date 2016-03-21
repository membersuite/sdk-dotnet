using System;

namespace MemberSuite.SDK.Utilities
{
    /// <summary>
    ///     Common DateTime Methods.
    /// </summary>
    public enum Quarter
    {
        First = 1,
        Second = 2,
        Third = 3,
        Fourth = 4
    }

    public enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }

    public class DateUtils
    {
        #region Quarters

        public static DateTime GetStartOfQuarter(int Year, Quarter Qtr)
        {
            if (Qtr == Quarter.First) // 1st Quarter = January 1 to March 31
                return new DateTime(Year, 1, 1, 0, 0, 0, 0);
            if (Qtr == Quarter.Second) // 2nd Quarter = April 1 to June 30
                return new DateTime(Year, 4, 1, 0, 0, 0, 0);
            if (Qtr == Quarter.Third) // 3rd Quarter = July 1 to September 30
                return new DateTime(Year, 7, 1, 0, 0, 0, 0);
            return new DateTime(Year, 10, 1, 0, 0, 0, 0);
        }

        public static DateTime GetEndOfQuarter(int Year, Quarter Qtr)
        {
            if (Qtr == Quarter.First) // 1st Quarter = January 1 to March 31
                return new DateTime(Year, 3,
                    DateTime.DaysInMonth(Year, 3), 23, 59, 59, 999);
            if (Qtr == Quarter.Second) // 2nd Quarter = April 1 to June 30
                return new DateTime(Year, 6,
                    DateTime.DaysInMonth(Year, 6), 23, 59, 59, 999);
            if (Qtr == Quarter.Third) // 3rd Quarter = July 1 to September 30
                return new DateTime(Year, 9,
                    DateTime.DaysInMonth(Year, 9), 23, 59, 59, 999);
            return new DateTime(Year, 12,
                DateTime.DaysInMonth(Year, 12), 23, 59, 59, 999);
        }

        public static Quarter GetQuarter(Month Month)
        {
            if (Month <= Month.March)
                // 1st Quarter = January 1 to March 31
                return Quarter.First;
            if ((Month >= Month.April) && (Month <= Month.June))
                // 2nd Quarter = April 1 to June 30
                return Quarter.Second;
            if ((Month >= Month.July) && (Month <= Month.September))
                // 3rd Quarter = July 1 to September 30
                return Quarter.Third;
            return Quarter.Fourth;
        }

        public static DateTime GetEndOfLastQuarter()
        {
            if ((Month) DateTime.Now.Month <= Month.March)
                //go to last quarter of previous year
                return GetEndOfQuarter(DateTime.Now.Year - 1, Quarter.Fourth);
            return GetEndOfQuarter(DateTime.Now.Year,
                GetQuarter((Month) DateTime.Now.Month));
        }

        public static DateTime GetStartOfLastQuarter()
        {
            if ((Month) DateTime.Now.Month <= Month.March)
                //go to last quarter of previous year
                return GetStartOfQuarter(DateTime.Now.Year - 1, Quarter.Fourth);
            return GetStartOfQuarter(DateTime.Now.Year,
                GetQuarter((Month) DateTime.Now.Month));
        }

        public static DateTime GetStartOfCurrentQuarter()
        {
            return GetStartOfQuarter(DateTime.Now.Year,
                GetQuarter((Month) DateTime.Now.Month));
        }

        public static DateTime GetEndOfCurrentQuarter()
        {
            return GetEndOfQuarter(DateTime.Now.Year,
                GetQuarter((Month) DateTime.Now.Month));
        }

        #endregion

        #region Weeks

        public static DateTime GetStartOfLastWeek()
        {
            var DaysToSubtract = (int) DateTime.Now.DayOfWeek + 7;
            var dt =
                DateTime.Now.Subtract(TimeSpan.FromDays(DaysToSubtract));
            return new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0);
        }

        public static DateTime GetEndOfLastWeek()
        {
            var dt = GetStartOfLastWeek().AddDays(6);
            return new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59, 999);
        }

        public static DateTime GetStartOfCurrentWeek()
        {
            var DaysToSubtract = (int) DateTime.Now.DayOfWeek;
            var dt =
                DateTime.Now.Subtract(TimeSpan.FromDays(DaysToSubtract));
            return new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0);
        }

        public static DateTime GetEndOfCurrentWeek()
        {
            var dt = GetStartOfCurrentWeek().AddDays(6);
            return new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59, 999);
        }

        #endregion

        #region Months

        public static DateTime GetStartOfMonth(Month Month, int Year)
        {
            return new DateTime(Year, (int) Month, 1, 0, 0, 0, 0);
        }

        public static DateTime GetEndOfMonth(Month Month, int Year)
        {
            return new DateTime(Year, (int) Month,
                DateTime.DaysInMonth(Year, (int) Month), 23, 59, 59, 999);
        }

        /// <summary>
        ///     Gets the number of months in between two dates, irrespective of the day
        /// </summary>
        /// <param name="firstDate">The first date.</param>
        /// <param name="secondDate">The second date.</param>
        /// <returns>System.Int32.</returns>
        public static int GetMonthDiff(DateTime firstDate, DateTime secondDate)
        {
            return ((secondDate.Year - firstDate.Year)*12) + secondDate.Month - firstDate.Month;
        }

        #endregion

        #region Years

        public static DateTime GetStartOfYear(int Year)
        {
            return new DateTime(Year, 1, 1, 0, 0, 0, 0);
        }

        public static DateTime GetEndOfYear(int Year)
        {
            return new DateTime(Year, 12,
                DateTime.DaysInMonth(Year, 12), 23, 59, 59, 999);
        }

        public static DateTime GetStartOfLastYear()
        {
            return GetStartOfYear(DateTime.Now.Year - 1);
        }

        public static DateTime GetEndOfLastYear()
        {
            return GetEndOfYear(DateTime.Now.Year - 1);
        }

        public static DateTime GetStartOfCurrentYear()
        {
            return GetStartOfYear(DateTime.Now.Year);
        }

        public static DateTime GetEndOfCurrentYear()
        {
            return GetEndOfYear(DateTime.Now.Year);
        }

        #endregion

        #region Days

        public static DateTime GetStartOfDay(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);
        }

        public static DateTime GetEndOfDay(DateTime date)
        {
            return new DateTime(date.Year, date.Month,
                date.Day, 23, 59, 59, 999);
        }

        #endregion
    }
}