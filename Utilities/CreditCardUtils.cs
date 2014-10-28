using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Utilities
{
    public static class CreditCardUtils
    {
        public static CreditCardType? GetCardTypeFromNumber(string cardNum)
        {
            if (cardNum == null) return null;
            //Create new instance of Regex comparer with our
            //credit card regex patter
            

            //Compare the supplied card number with the regex
            //pattern and get reference regex named groups
            GroupCollection gc = Regex.Match(cardNum.Replace(" ", "").Replace("-", ""), RegularExpressions.CardTestRegex, RegexOptions.Compiled).Groups;

            //Compare each card type to the named groups to 
            //determine which card type the number matches
            if (gc["Amex"].Success)
            {
                return CreditCardType.AmericanExpress;
            }
            else if (gc[CreditCardType.MasterCard.ToString()].Success)
            {
                return CreditCardType.MasterCard;
            }
            else if (gc[CreditCardType.Visa.ToString()].Success)
            {
                return CreditCardType.Visa;
            }
            else if (gc[CreditCardType.Discover.ToString()].Success)
            {
                return CreditCardType.Discover;
            }
            else
            {
                //Card type is not supported by our system, return null
                //(You can modify this code to support more (or less)
                // card types as it pertains to your application)
                return null;
            }
        }
    }
}
