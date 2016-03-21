using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    [DataContract]
    public class NonElectronicPayment : ElectronicPaymentManifest
    {
        public OrderPaymentMethod _OrderPaymentMethod;
        public string ReferenceNumber { get; set; }

        public override OrderPaymentMethod OrderPaymentMethod
        {
            get { return _OrderPaymentMethod; }
        }

        public override string AccountNumber
        {
            get { return null; }
        }

        public override string Validate()
        {
            return null;
        }

        public override string ToString()
        {
            return _OrderPaymentMethod.ToString();
        }
    }
}