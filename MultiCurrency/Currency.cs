using System;
using System.Globalization;

namespace MemberSuite.SDK.MultiCurrency
{
    public struct Currency : IFormattable, IComparable, IComparable<Currency>
    {
        public Currency(decimal amount, string currencyCode) : this()
        {
          
            Amount = Math.Round( amount,2, MidpointRounding.AwayFromZero );

            if (currencyCode != null)
            {
                Code = currencyCode.ToUpper();
                if (!CurrencyManager.IsValidCurrencyCode(Code))
                    throw new InvalidCurrencyCodeException(Code);
            }
        }

        public static Currency Dispense(decimal amount, string currencyCode)
        {
            return new Currency(amount, currencyCode);
        }

        



        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        public decimal Amount { get; private set; }

        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        /// <value>The code.</value>
        public string Code { get; private set; }

        

         
        
        #region Equals/GetHashCode

        /* We don't need to override equals/gethascode because the structs equality actually IS the
         * equality of Amount and Code
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            // we can compare decimals
            if (obj is decimal)
                return Amount.Equals((decimal) obj);

            // now, the two are equal if the amount is equal, and the code is equal
            var currencyToCompare = (Currency)obj;

            // same amounts?
            if (Amount != currencyToCompare.Amount)
                return false;

            // same currency code?
            if (!string.Equals(Code, currencyToCompare.Code, StringComparison.CurrentCultureIgnoreCase))
                return false;

            // good - we don't care about amount in base currency

            return true;
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode() + Code.GetHashCode();
        }

         */

        #endregion
        #region Comparable
        public int CompareTo(object obj)
        {

            return this.CompareTo((Currency)obj);
        }

        public int CompareTo(Currency other)
        {
            if (Code != other.Code)
                throw new IncompatibleCurrencyComparisonException();

            return Amount.CompareTo(other.Amount);
        }
        


        #endregion

        #region ToString

      

        public override string ToString()
        {
            return this.ToString("S", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null)
                format = "S";

            switch (format.ToUpperInvariant())
            {
                case "S":   // show with code
                    return string.Format("{0} {1}",
                        Amount, Code);
                case "C":   // show with symbol
                    return string.Format("{0}{1}", CurrencyManager.GetSymbolFor(Code), Amount);

                default:
                    throw new FormatException("Unknown formatting code " + format);
            }
        }

        #endregion

        #region Operator Overloads

        public static bool operator ==(Currency a, Currency b)
        {
            // If both are null, or both are same instance, return true.
            return a.Equals(b);
        }

        public static bool operator !=(Currency a, Currency b)
        {
            // If both are null, or both are same instance, return true.
            return ! a.Equals(b);
        }

        public static Currency operator +(Currency a, Currency b)
        {
            // If both are null, or both are same instance, return true.
            string codeToUse = a.Code ?? b.Code;
            
            if ( a.Code != null && b.Code != null && a.Code != b.Code)
                throw new IncompatibleCurrencyComparisonException();

            return Currency.Dispense(a.Amount + b.Amount, codeToUse);
        }

        public static Currency operator -(Currency a, Currency b)
        {
            // If both are null, or both are same instance, return true.
            string codeToUse = a.Code ?? b.Code;

            if (a.Code != null && b.Code != null && a.Code != b.Code)
                throw new IncompatibleCurrencyComparisonException();
            
            return Currency.Dispense(a.Amount - b.Amount, codeToUse);
        }

        //public static Currency operator *(Currency a, Currency b)
        //{
        //    // If both are null, or both are same instance, return true.
        //    string codeToUse = a.Code ?? b.Code;

        //    if (a.Code != null && b.Code != null && a.Code != b.Code)
        //        throw new IncompatibleCurrencyComparisonException();

        //    return Currency.Dispense(a.Amount * b.Amount, codeToUse, a.AmountInBaseCurrency * b.AmountInBaseCurrency);
        //}

        public static Currency operator *(Currency a, decimal b)
        {
           
            return Currency.Dispense(a.Amount * b, a.Code);
        }

        public static decimal operator /(Currency a, Currency b)
        {
            // If both are null, or both are same instance, return true.
            if (a.Code != null && b.Code != null && a.Code != b.Code)
                throw new IncompatibleCurrencyComparisonException();

            return a.Amount / b.Amount;
        }

        public static Currency operator /(Currency a, decimal b)
        { 

            return Currency.Dispense(a.Amount / b, a.Code);
        }

        public static bool operator >(Currency a, Currency b)
        {
            // If both are null, or both are same instance, return true.
            if (a.Code != b.Code)
                throw new IncompatibleCurrencyComparisonException();

            return a.CompareTo(b) > 0;
        }

        public static bool operator >=(Currency a, Currency b)
        {
            // If both are null, or both are same instance, return true.
            if (a.Code != b.Code)
                throw new IncompatibleCurrencyComparisonException();

            return a.CompareTo(b) >= 0;
        }


        public static bool operator <(Currency a, Currency b)
        {
            // If both are null, or both are same instance, return true.
            if (a.Code != b.Code)
                throw new IncompatibleCurrencyComparisonException();

            return a.CompareTo(b) < 0;
        }

        public static bool operator <=(Currency a, Currency b)
        {
            // If both are null, or both are same instance, return true.
            if (a.Code != b.Code)
                throw new IncompatibleCurrencyComparisonException();

            return a.CompareTo(b) <= 0;
        }
        #endregion

        /// <summary>
        /// Creates another currency object with same code, but different amount
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <returns>Currency.</returns>
        public Currency Copy(decimal amount)
        {
            return Currency.Dispense(amount, Code);
        }


        /// <summary>
        /// Creates another currency object with same amount, but different code
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <returns>Currency.</returns>
        public Currency Copy( string newCode )
        {
            return Currency.Dispense(Amount, newCode);
        }

        public bool IsZero()
        {
            return Amount == 0;
        }

        /// <summary>
        /// Determines whether this instance is valid.
        /// </summary>
        /// <returns><c>true</c> if this instance is valid; otherwise, <c>false</c>.</returns>
        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Code);
        }

        public static Currency Dollars(decimal dollarAmount)
        {
            return Currency.Dispense(dollarAmount, "USD");
        }

    }
}
