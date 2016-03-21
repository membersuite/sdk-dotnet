using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    [DataContract]
    public class ElectronicCheck : ElectronicPaymentManifest
    {
        [DataMember]
        public string BankAccountNumber { get; set; }

        [DataMember]
        public string RoutingNumber { get; set; }

        [DataMember]
        public BankAccountType BankAccountType { get; set; }

        [DataMember]
        public Address BillingAddress { get; set; }

        [DataMember]
        public string NameOnAccount { get; set; }

        public override OrderPaymentMethod OrderPaymentMethod
        {
            get { return OrderPaymentMethod.ElectronicCheck; }
        }

        public override string AccountNumber
        {
            get { return BankAccountNumber; }
        }

        public override string Validate()
        {
            if (string.IsNullOrWhiteSpace(BankAccountNumber))
                return "No account number is specified for the electronic check.";
            if (string.IsNullOrWhiteSpace(RoutingNumber))
                return "No ABA/routing number is specified for the electronic check.";

            return null;
        }

        public override string ToString()
        {
            if (BankAccountNumber == null || BankAccountNumber.Length < 4) return "eCheck w/o Bank account";
            return string.Format("{0} ending in xx{1}",
                "Electronic Check", BankAccountNumber.Substring(BankAccountNumber.Length - 4, 4));
        }
    }
}