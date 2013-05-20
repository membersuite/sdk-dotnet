using System;
using System.Text.RegularExpressions;

namespace MemberSuite.SDK.Utilities
{
    public static class TimeZoneUtils
    {
        private static Regex _firstLetterBreaker = new Regex(@"(\w)\w+", RegexOptions.Compiled);
        public static String GetTimeZoneAbbreviatedTime(DateTime dt, TimeZoneInfo tzi)
        {
            if (tzi == null) throw new ArgumentNullException("tzi");
            String sName = tzi.IsDaylightSavingTime(dt) ? tzi.DaylightName : tzi.StandardName;

            var matches = _firstLetterBreaker.Matches(sName);
            string abbrev = "";
            foreach (Match m in matches)
                abbrev += m.Groups[1].Value;

            return abbrev;
        }

    }
}
