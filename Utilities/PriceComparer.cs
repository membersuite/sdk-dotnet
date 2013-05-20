using System;
using System.Collections.Generic;
using System.Globalization;

namespace MemberSuite.SDK.Utilities
{
    public class PriceComparer : IComparer<string>
    {
        #region Fields

        private NumberFormatInfo _formatInfo;

        #endregion

        #region Properties

        public NumberFormatInfo FormatInfo
        {
            get { return _formatInfo; }
        }

        #endregion

        #region Constructors

        public PriceComparer() : this(NumberFormatInfo.CurrentInfo)
        {
        }

        public PriceComparer(NumberFormatInfo formatInfo)
        {
            _formatInfo = formatInfo;
        }

        #endregion

        #region IComparer Implementation

        public int Compare(string x, string y)
        {
            //Check the types and for null/empty strings
            if (string.IsNullOrWhiteSpace(x) && string.IsNullOrWhiteSpace(y))
                return 0;

            if (string.IsNullOrWhiteSpace(x))
                return -1;

            if (string.IsNullOrWhiteSpace(y))
                return 1;

            //Put all strings that don't start with a price at the beginning of the list
            bool sp1 = StartsWithPrice(x, FormatInfo);
            bool sp2 = StartsWithPrice(y, FormatInfo);

            if (sp1 && !sp2) return 1;
            if (!sp1 && sp2) return -1;
            if (!sp1) return 0; //If sp1 is false then sp2 has to be false also because we would already have returned if it wasn't

            //They both start with a digit or the currency symbol
            decimal d1 = getPrice(x, FormatInfo);
            decimal d2 = getPrice(y, FormatInfo);

            return d1.CompareTo(d2);
        }

        #endregion

        #region Methods

        public static bool StartsWithPrice(string s)
        {
            return StartsWithPrice(s, NumberFormatInfo.CurrentInfo);
        }

        public static bool StartsWithPrice(string s, NumberFormatInfo nfo)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;

            if (s.StartsWith(nfo.CurrencySymbol))
                return true;

            return Char.IsDigit(s, 0);
        }

        private static decimal getPrice(string s, NumberFormatInfo nfo)
        {
            int lastIndexOfPrice = getLastIndexOfPrice(s, nfo);

            if (lastIndexOfPrice < 0)
                return default(decimal);

            string priceString = s.Substring(0, lastIndexOfPrice + 1);
            decimal result;


            if (decimal.TryParse(priceString, NumberStyles.Any, CultureInfo.CurrentCulture, out result))
                return result;

            return default(decimal);
        }

        private static int getLastIndexOfPrice(string s, NumberFormatInfo nfo)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (subStringEquals(s, i, nfo.CurrencySymbol))
                {
                    i += nfo.CurrencySymbol.Length;
                    continue;
                }

                if (subStringEquals(s, i, nfo.CurrencyGroupSeparator))
                {
                    i += nfo.CurrencyGroupSeparator.Length;
                    continue;
                }

                if (subStringEquals(s, i, nfo.CurrencyDecimalSeparator))
                {
                    i += nfo.CurrencyDecimalSeparator.Length;
                    continue;
                }

                if (!Char.IsDigit(s[i]))
                    return i - 1;
            }

            return s.Length - 1;
        }

        private static bool subStringEquals(string s, int startIndex, string substring)
        {
            return startIndex + substring.Length <= s.Length && s.Substring(startIndex, substring.Length) == substring;
        }

        #endregion
    }
}
