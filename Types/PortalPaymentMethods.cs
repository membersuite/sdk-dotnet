using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class PortalPaymentMethods
    {
        [DataMember]
        public bool AllowEChecks { get; set; }
        
        [DataMember]
        public bool AllowAmericanExpress { get; set; }

        [DataMember]
        public bool AllowVisa { get; set; }

        [DataMember]
        public bool AllowMastercard { get; set; }

        [DataMember]
        public bool AllowDiscover { get; set; }

        [DataMember]
        public bool AllowOtherCards { get; set; }

        [DataMember]
        public bool AllowBillMeLater { get; set; }

        [DataMember]
        public bool AllowPayrollDeduction { get; set; }

        [DataMember]
        public List<string> Messages { get; set; }

        [DataMember]
        public List<NameValueStringPair> SavedPaymentMethods { get; set; }

        [DataMember]
        public SavePaymentMethodSetting DefaultSettingForSavingPaymentMethods { get; set; }

        public bool AllowCreditCardPayments
        {
            get { return AllowAmericanExpress || AllowVisa || AllowMastercard || AllowDiscover || AllowOtherCards; }
        }

        public void AddMessage(string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                if (Messages == null) Messages = new List<string>();
                Messages.Add(message);
            }
        }

        public bool AllowCreditCardType(CreditCardType cType)
        {
            switch (cType)
            {
                case CreditCardType.AmericanExpress:
                    return AllowAmericanExpress;

                case CreditCardType.MasterCard:
                    return AllowMastercard;

                case CreditCardType.Visa:
                    return AllowVisa;

                case CreditCardType.Discover:
                    return AllowDiscover;

                default:
                    return AllowOtherCards;

            }
        }

        public void AddSavedPaymentMethod(string methodName, string methodID )
        {
            if (SavedPaymentMethods == null)
                SavedPaymentMethods = new List<NameValueStringPair>();

            SavedPaymentMethods.Add(new NameValueStringPair(methodName, methodID));
        }
    }
}
