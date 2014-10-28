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
    public class SavedPaymentInfo : ElectronicPaymentManifest 
    {
        [DataMember]
        public string SavedPaymentMethodID { get; set; }

        public string SavedPaymentMethodName { get; set; }

        public override string Validate()
        {
            return null;
        }

        public override OrderPaymentMethod OrderPaymentMethod
        {
            get { return Types.OrderPaymentMethod.SavedPaymentMethod; }
        }

        

        public override string AccountNumber
        {
            get { return SavedPaymentMethodID; }
        }

        public override string ToString()
        {
            return SavedPaymentMethodName ?? "Saved payment method";
        }
    }
}
