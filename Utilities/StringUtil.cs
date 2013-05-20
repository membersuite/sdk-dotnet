using System;

namespace MemberSuite.SDK.Utilities
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringUtil
    {
        public static string PadBase64String(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            int len = value.Length % 4;
            if (len > 0)
                return value.PadRight(value.Length + (4 - len), '=');

            return value;
        }

        /// <summary>
        /// Determines whether the specified s is numeric.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>
        /// 	<c>true</c> if the specified s is numeric; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNumeric(this string s)
        {
            int i;
            return int.TryParse(s, out i);
        }

        /// <summary>
        /// Formats the string, guaranteeing that no exception occurs
        /// </summary>
        /// <param name="msg">The MSG.</param>
        /// <param name="args">The args.</param>
        /// <returns></returns>
        public static string SafeFormat(string msg, params object[] args)
        {
            
            string formattedMsg ;

            try
            {
                formattedMsg = string.Format(msg, args);
            }
            catch (Exception)
            {
                formattedMsg = msg + "(with format exception)";
            }
            
            return formattedMsg;
            

        }

        public static T ToEnum<T>(this string stringToParse)
        {
            if (String.IsNullOrEmpty(stringToParse))
                return default(T);

            return (T)Enum.Parse(typeof(T), stringToParse);
        }


        /// <summary>
        /// Trims the string array.
        /// </summary>
        /// <param name="arrayToTrim">The array to trim.</param>
        /// <returns></returns>
        public static string[] TrimStringArray(string[] arrayToTrim)
        {
            for (int i = 0; i < arrayToTrim.Length; i++)
                arrayToTrim[i] = arrayToTrim[i].Trim();
             
            return arrayToTrim;
        }

        public static bool IsNullOrEmpty(string stringToExamine)
        {
            return stringToExamine == null || stringToExamine.Trim().Length == 0;
        }

        public static bool IsGuid(this string stringToExamine)
        {
            try
            {
                new Guid(stringToExamine);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}