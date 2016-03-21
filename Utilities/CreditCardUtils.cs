using System;
using System.Collections;
using System.Text.RegularExpressions;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Utilities
{
    public static class CreditCardUtils
    {
        public static void GetCardInfoFromToken(string token, out CreditCardType cardType, out string lastDigits)
        {
            cardType = CreditCardType.Other;
            lastDigits = string.Empty;
            var gc = Regex.Match(token, RegularExpressions.CardTokenizedTestRegex, RegexOptions.Compiled).Groups;
            var group = gc["CardType"];
            if (group.Success)
                Enum.TryParse<CreditCardType>(group.Value, true, out cardType);

            group = gc["LastDigits"];
            if (group.Success)
            {
                lastDigits = group.Value;
            }
        }

        public static CreditCardType? GetCardTypeFromNumber(string cardNum)
        {
            if (cardNum == null) return null;

            //Compare the supplied card number with the regex
            //pattern and get reference regex named groups
            var gc =
                Regex.Match(cardNum.Replace(" ", "").Replace("-", ""), RegularExpressions.CardTestRegex,
                    RegexOptions.Compiled).Groups;

            //Compare each card type to the named groups to 
            //determine which card type the number matches
            if (gc["Amex"].Success)
            {
                return CreditCardType.AmericanExpress;
            }
            if (gc[CreditCardType.MasterCard.ToString()].Success)
            {
                return CreditCardType.MasterCard;
            }
            if (gc[CreditCardType.Visa.ToString()].Success)
            {
                return CreditCardType.Visa;
            }
            if (gc[CreditCardType.Discover.ToString()].Success)
            {
                return CreditCardType.Discover;
            }
            //Card type is not supported by our system, return null
            //(You can modify this code to support more (or less)
            // card types as it pertains to your application)
            return null;
        }
    }
}