using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
      [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    [DataContract]
    public class NonElectronicPayment : ElectronicPaymentManifest 
    {
        public override string Validate()
        {
            return null; 
        }

        public string ReferenceNumber { get; set; }

        public OrderPaymentMethod _OrderPaymentMethod;
        

        public override OrderPaymentMethod OrderPaymentMethod
        {
            get { return _OrderPaymentMethod; }
        }

         
        public override string AccountNumber
        {
            get { return null; }
        }

        public override string ToString()
        {
            return _OrderPaymentMethod.ToString();
        }
    }
}
