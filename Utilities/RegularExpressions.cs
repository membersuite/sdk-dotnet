using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MemberSuite.SDK.Utilities
{
    /// <summary>
    /// 
    /// </summary>
    public static class RegularExpressions
    {

        public const string EmailRegEx = @"^([a-zA-Z0-9'_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+ *$";
        public static string MultipleEmail = @"^(([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+( )*(;|,)?( )*)+$";

        public static Regex GuidRegex = new Regex("^[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}$");

        public static string FormatWebSiteAsUrl(string urlToFormat)
        {
            if (String.IsNullOrWhiteSpace(urlToFormat)) return null;

           
            if (urlToFormat.Contains("://")) //it's already a URI, so leave it
                return urlToFormat ;

            return "http://" + urlToFormat;
        }

        public static string GetQueryString(NameValueCollection queryStringParameters, IEnumerable<string> parametersToRemove)
        {
            string result = "?";

            if (queryStringParameters == null)
                return result;

            foreach (var param in parametersToRemove)
            {
                queryStringParameters.Remove(param);
            }

            if (queryStringParameters.Count == 0)
                return result;

            return queryStringParameters.Cast<string>().Aggregate(result, (current, parameter) => string.Format("{0}{1}={2}&", current, parameter, queryStringParameters[parameter]));
        }

        /// <summary>
        /// Gets the friendly, formatted name of a bunched together noun
        /// </summary>
        /// <param name="variableName">Name of the variable.</param>
        /// <returns></returns>
        public static string GetFriendlyName(string variableName)
        {
            if (variableName == null)
                return null;

            return Regex.Replace(variableName, "([A-Z])", " $1").Trim()
                .Replace( "G L A", "GL A")
                .Replace("A P I", "API")
                .Replace("C O G S", "COGS")
                .Replace("C E U", "CEU")
                .Replace("C R M", "CRM")
                .Replace("Y T D", "YTD")
                .Replace("I D", "ID");

        }

        /// <summary>
        /// Gets the friendly, formatted plural name of a bunched together noun
        /// </summary>
        /// <param name="variableName">Name of the variable.</param>
        /// <returns></returns>
        public static string GetFriendlyPluralName(string variableName)
        {
            if (variableName == null)
                return null;

            string name = GetFriendlyName(variableName);
            return MakePlural(name);
        }

        /// <summary>
        /// Gets the name of the safe field.
        /// </summary>
        /// <param name="fieldName">Name of the original field.</param>
        /// <returns></returns>
        public static string GetSafeFieldName(string fieldName)
        {
            if (fieldName == null)
                return null;

            return GetSafeFieldName(fieldName, false).Trim();
        }

        public static string GetSafeFieldName(string fieldName, bool canBeginWithNumber)
        {
            return GetSafeFieldName(fieldName, canBeginWithNumber, false);
        }

        public static string GetSafeFieldName(string fieldName, bool canBeginWithNumber, bool ignorePeriods)
        {
            if ( String.IsNullOrEmpty( fieldName ))
                return fieldName;

            if (!canBeginWithNumber)
            {
                char firstLetter = fieldName[0];

                if (
                    firstLetter == '0' ||
                    firstLetter == '1' ||
                    firstLetter == '2' ||
                    firstLetter == '3' ||
                    firstLetter == '4' ||
                    firstLetter == '5' ||
                    firstLetter == '6' ||
                    firstLetter == '7' ||
                    firstLetter == '8' ||
                    firstLetter == '9'
                    )
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
                .Replace("%", "_");
                
        }

        public static string MakePlural(string name)
        {
            if ( name.EndsWith( "ch" )  || name.EndsWith("s") )
                name += "es";
            else if (name.EndsWith("y") && !name.EndsWith("ay"))
                name = name.Substring(0, name.Length - 1) + "ies";
            else
                name += "s";

            return name;
        }

        private static readonly Regex _phoneNumberRegex = new Regex(@"\d",
            RegexOptions.Compiled);

        public static string CleanPhoneNumber(string phoneNumber)
        {
              
            if (phoneNumber == null) return null;
            var matches = _phoneNumberRegex.Matches(phoneNumber);
            if ( matches.Count != 10 ) return phoneNumber;  // don't even bother

            phoneNumber = String.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",
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
            // else Commenting out via MS-1030
                //phoneNumber = string.Format("({0}) {1}-{2} ext. {3}", m.Groups[1].Value, m.Groups[2].Value, m.Groups[3].Value,
                //    m.Groups[4].Value);
                

            return phoneNumber;
        
        }

        public static string ReplaceNonEnglishCharacters(string sourceString)
        {
            //Use string builder because there's going to be multiple replacements on the same string
            //and they're case sensitive - better performance than string.replace or regex.replace
            StringBuilder result = new StringBuilder(sourceString);

            //Lowercase a
            result.Replace('à', 'a');
            result.Replace('á', 'a');
            result.Replace('â', 'a');
            result.Replace('ã', 'a');
            result.Replace('ä', 'a');
            result.Replace('å', 'a');
            result.Replace('æ', 'a');

            //Uppercase A
            result.Replace('À', 'A');
            result.Replace('Á', 'A');
            result.Replace('Â', 'A');
            result.Replace('Ä', 'A');
            result.Replace('Ã', 'A');
            result.Replace('Å', 'A');
            result.Replace('Æ', 'A');

            //Lowercase e
            result.Replace('è', 'e');
            result.Replace('é', 'e');
            result.Replace('ê', 'e');
            result.Replace('ë', 'e');

            //Uppercase E
            result.Replace('È', 'E');
            result.Replace('É', 'E');
            result.Replace('Ê', 'E');
            result.Replace('Ë', 'E');

            //Lowercase i
            result.Replace('ì', 'i');
            result.Replace('í', 'i');
            result.Replace('î', 'i');
            result.Replace('ï', 'i');

            //Uppercase I
            result.Replace('Ì', 'I');
            result.Replace('Í', 'I');
            result.Replace('Î', 'I');
            result.Replace('Ï', 'I');

            //Lowercase o
            result.Replace('ò', 'o');
            result.Replace('ó', 'o');
            result.Replace('ô', 'o');
            result.Replace('õ', 'o');
            result.Replace('ö', 'o');
            result.Replace('œ', 'o');
            result.Replace('ø', 'o');

            //Uppercase O
            result.Replace('Ò', 'O');
            result.Replace('Ó', 'O');
            result.Replace('Ô', 'O');
            result.Replace('Õ', 'O');
            result.Replace('Ö', 'O');
            result.Replace('Œ', 'O');
            result.Replace('Ø', 'O');

            //Lowercase u
            result.Replace('ù', 'u');
            result.Replace('ú', 'u');
            result.Replace('û', 'u');
            result.Replace('ü', 'u');

            //Uppercase U
            result.Replace('Ù', 'U');
            result.Replace('Ú', 'U');
            result.Replace('Û', 'U');
            result.Replace('Ü', 'U');

            //Lowercase y
            result.Replace('ý', 'y');
            result.Replace('ÿ', 'y');

            //Uppercase Y
            result.Replace('Ý', 'Y');
            result.Replace('Ÿ', 'Y');

            //Lowercase n
            result.Replace('ñ', 'n');

            //Uppercase N
            result.Replace('Ñ', 'N');

            //Lowercase c
            result.Replace('ç', 'c');

            //Uppercase C
            result.Replace('Ç', 'C');

            //Lowercase d
            result.Replace('ð', 'd');

            //Uppercase D
            result.Replace('Ð', 'D');

            //Lowercase s
            result.Replace('ß', 's');
            result.Replace('š', 's');

            //?
            result.Replace('¿', '?');

            //!
            result.Replace('¡', '!');

            return result.ToString();
        }

        public static Regex InvalidFileCharacters = new Regex(@"[?:\\/*""<>|\.,]"); 
    }
}
