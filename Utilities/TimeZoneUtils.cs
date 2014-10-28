using System;
using System.Text.RegularExpressions;

namespace MemberSuite.SDK.Utilities
{
    public static class TimeZoneUtils
    {
        public static String GetTimeZoneAbbreviatedTime(DateTime dt, TimeZoneInfo tzi)
        {
            if (tzi == null) throw new ArgumentNullException("tzi");
            String sName = tzi.IsDaylightSavingTime(dt) ? tzi.DaylightName : tzi.StandardName;

            var matches = Regex.Matches(sName, RegularExpressions.FirstLetterBreakerRegex, RegexOptions.Compiled);
            string abbrev = "";
            foreach (Match m in matches)
                abbrev += m.Groups[1].Value;

            return abbrev;
        }

    }
}
