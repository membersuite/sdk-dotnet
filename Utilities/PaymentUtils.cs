using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Utilities
{
    public static class PaymentUtils
    {

        public static CreditCardType? DetectCreditCardType(string creditCardNumber)
        {
            if (creditCardNumber == null) return null;
            int cardLen = creditCardNumber.Length;

            if (cardLen < 4)			// Must be at least 4 digits
                return null;

            string firstdig = creditCardNumber.Substring(0, 1);
            string seconddig = creditCardNumber.Substring(1, 1);
            string first4digs = creditCardNumber.Substring(0, 4);

            if ((cardLen == 16 || cardLen == 13) && firstdig == "4")
            {
                return CreditCardType.Visa;
            }
            
            if (cardLen == 15 && firstdig == "3" && ("47".IndexOf(seconddig) >= 0))
            {
                return CreditCardType.AmericanExpress;
            }
            
            if (cardLen == 16 && firstdig == "5" && ("12345".IndexOf(seconddig) >= 0))
            {
                return CreditCardType.MasterCard;
            }
            
            if (cardLen == 16 && first4digs == "6011")
            {
                return CreditCardType.Discover;
            }
            
            
            if (cardLen == 14 && firstdig == "3"  && ("068".IndexOf(seconddig)>=0))
            {
                return CreditCardType.DinersClub;
            }

            //per Andrew return "Other" so the credit card will be processed and the gateway will determine if it is a valid type
            return CreditCardType.Other;
			

        }
    }
}
