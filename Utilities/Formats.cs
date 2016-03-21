using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MemberSuite.SDK.Utilities
{
    public static class Formats
    {
        public static string GetSafeFieldName(string format, params object[] parms)
        {
            return GetSafeFieldName(string.Format(format, parms));
        }

        public static string GetSafeFieldName(string fieldName)
        {
            return fieldName == null ? null : GetSafeFieldName(fieldName, false).Trim();
        }

        public static string GetSafeFieldName(string fieldName, bool canBeginWithNumber)
        {
            return GetSafeFieldName(fieldName, canBeginWithNumber, false);
        }

        public static string GetSafeFieldName(string fieldName, bool canBeginWithNumber, bool ignorePeriods)
        {
            if (string.IsNullOrEmpty(fieldName))
                return fieldName;

            if (!canBeginWithNumber)
            {
                var firstLetter = fieldName[0];

                if ("0123456789".Any(x => x == firstLetter))
                    fieldName = "F_" + fieldName;
            }

            if (!ignorePeriods)
                fieldName = fieldName.Replace(".", "_");

            return fieldName
                .Replace(" ", "_")
                .Replace("-", "_")
                .Replace("*", "_")
                .Replace("/", "_")
                .Replace("(", "_")
                .Replace(")", "_")
                .Replace("#", "")
                .Replace(":", "_")
                .Replace("&", "_")
                .Replace("'", "_")
                .Replace("?", "_")
                .Replace("+", "_")
                .Replace(",", "_")
                .Replace("\"", "_")
                .Replace("%", "_")
                .Replace("’", "_");
        }

        public static string MakePlural(string name)
        {
            if (name.EndsWith("ch") || name.EndsWith("s"))
                name += "es";
            else if (name.EndsWith("y") && !name.EndsWith("ay"))
                name = name.Substring(0, name.Length - 1) + "ies";
            else
                name += "s";

            return name;
        }

        public static string ReplaceNonEnglishCharacters(string sourceString)
        {
            var result = new StringBuilder(sourceString);

            // The following characters are not replaceable via the Normalize operation.  They were previously intentionally coded
            // in this method so we are carrying this over to ensure they are still excluded.
            result.Replace('æ', 'a').Replace('Æ', 'A').Replace('œ', 'o').Replace('ø', 'o').Replace('Œ', 'O');
            result.Replace('Ø', 'O').Replace('ð', 'd').Replace('Ð', 'D').Replace('ß', 's');
            result.Replace('ł', 'l').Replace('Ł', 'L').Replace('¿', '?').Replace('¡', '!');
            result.Replace('\u2018', '\'').Replace('\u2019', '\'').Replace('\u201c', '\"').Replace('\u201d', '\"');
                // These characters are the Word style single and double quotes

            // This should get the remaining "extended ascii" accented
            return new StringBuilder().Append(result.ToString().Normalize(NormalizationForm.FormKD)
                .Where(x => x < 255)
                .ToArray()).ToString();
        }

        public static string GetFriendlyPluralName(string variableName)
        {
            if (variableName == null)
                return null;

            var name = GetFriendlyName(variableName);
            return MakePlural(name);
        }

        public static string GetFriendlyName(string variableName)
        {
            if (variableName == null)
                return null;

            return Regex.Replace(variableName, "([A-Z])", " $1").Trim()
                .Replace("G L A", "GL A")
                .Replace("A P I", "API")
                .Replace("C O G S", "COGS")
                .Replace("C E U", "CEU")
                .Replace("C R M", "CRM")
                .Replace("Y T D", "YTD")
                .Replace("I D", "ID")
                .Replace("M I P", "MIP")
                .Replace("N R D S", "NRDS");
        }

        public static string GetQueryString(NameValueCollection queryStringParameters,
            IEnumerable<string> parametersToRemove)
        {
            const string RESULT = "?";

            if (queryStringParameters == null)
                return RESULT;

            foreach (var param in parametersToRemove)
            {
                queryStringParameters.Remove(param);
            }

            if (queryStringParameters.Count == 0)
                return RESULT;

            return queryStringParameters.Cast<string>()
                .Aggregate(RESULT,
                    (current, parameter) =>
                        string.Format("{0}{1}={2}&", current, parameter, queryStringParameters[parameter]));
        }

        public static string FormatWebSiteAsUrl(string urlToFormat)
        {
            if (string.IsNullOrWhiteSpace(urlToFormat))
                return null;

            if (urlToFormat.Contains("://")) //it's already a URI, so leave it
                return urlToFormat;

            return "http://" + urlToFormat;
        }

        public static string CleanPhoneNumber(string phoneNumber)
        {
            if (phoneNumber == null)
                return null;

            var matches = Regex.Matches(phoneNumber, RegularExpressions.PhoneNumberRegex, RegexOptions.Compiled);
            if (matches.Count != 10)
                return phoneNumber; // don't even bother

            phoneNumber = string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",
                matches[0].Groups[0].Value,
                matches[1].Groups[0].Value,
                matches[2].Groups[0].Value,
                matches[3].Groups[0].Value,
                matches[4].Groups[0].Value,
                matches[5].Groups[0].Value,
                matches[6].Groups[0].Value,
                matches[7].Groups[0].Value,
                matches[8].Groups[0].Value,
                matches[9].Groups[0].Value);

            return phoneNumber;
        }
    }
}