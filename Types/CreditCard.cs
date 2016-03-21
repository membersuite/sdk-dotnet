using System.Linq;
using MemberSuite.SDK.Utilities;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    [DataContract]
    public class CreditCard : ElectronicPaymentManifest
    {
        [DataMember]
        public string NameOnCard { get; set; }

        [DataMember]
        public string CardNumber { get; set; }

        [DataMember]
        public DateTime CardExpirationDate { get; set; }

        [DataMember]
        public Address BillingAddress { get; set; }

        [DataMember]
        public string CCVCode { get; set; }

        public override OrderPaymentMethod OrderPaymentMethod
        {
            get { return OrderPaymentMethod.CreditCard; }
        }

        public override string AccountNumber
        {
            get { return CardNumber; }
        }

        public override string Validate()
        {
            if (string.IsNullOrWhiteSpace(CardNumber)) 
                return "No card number is specified for the credit card.";

            if (CardExpirationDate == default(DateTime)) 
                return "No expiration date is specified for the credit card.";

            //MS-4951
            //The UI uses the month/year picker which will always set the day of month to 1
            //But that doesn't indicate an expired card if we're later in the same month
            //if ((CardExpirationDate.Day > 1 && CardExpirationDate < ConciergeContext.Today) ||
            //    (CardExpirationDate.Month < ConciergeContext.Today.Month && CardExpirationDate.Year < ConciergeContext.Today.Year))
            //    return "The credit card expiration date has passed";

            var expirationDate = new DateTime(CardExpirationDate.Year, CardExpirationDate.Month, 1).AddMonths(1).AddDays(-1);
            if (expirationDate < DateTime.Today.Date)
                return "The credit card expiration date has passed";

            return null;
        }

        public override string ToString()
        {
            CreditCardType cardType;
            string cardLastFiveDigits = null;
            if (CardNumber.Contains('|'))
                CreditCardUtils.GetCardInfoFromToken(CardNumber, out cardType, out cardLastFiveDigits);
            else
            {
                var type = CreditCardUtils.GetCardTypeFromNumber(CardNumber);
                cardType = type ?? CreditCardType.Other;

                if (CardNumber != null && CardNumber.Length > 4)
                    cardLastFiveDigits = CardNumber.Substring(CardNumber.Length - 4, 4);
            }

            return string.Format("{0} ending in xx{1} - expires {2:MM/yyyy}",
                Formats.GetFriendlyName(cardType.ToString()), cardLastFiveDigits, CardExpirationDate);
        }
    }
}
