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
    [XmlInclude(typeof(CreditCard))]
    [XmlInclude(typeof(ElectronicCheck))]
    [XmlInclude(typeof(SavedPaymentInfo))]
    [KnownType(typeof(CreditCard))]
    [KnownType(typeof(ElectronicCheck))]
    [KnownType(typeof(SavedPaymentInfo))]
    public abstract class ElectronicPaymentManifest : IMemberSuiteComponent
    {
        public abstract string Validate();
        public abstract OrderPaymentMethod OrderPaymentMethod { get; }
        
        public abstract string AccountNumber { get; }


        /// <summary>
        /// If true, will save electronic payment info
        /// </summary>
        [DataMember]
        public bool SavePaymentMethod { get; set; }

        public PaymentMethod PaymentMethod  
        {
            get
            {
                if (OrderPaymentMethod == Types.OrderPaymentMethod.None)
                    throw new ApplicationException("Cannot convert order payment method of None");
                return (PaymentMethod) Enum.Parse(typeof (PaymentMethod), OrderPaymentMethod.ToString()); }
             
        }

        public ElectronicPaymentManifest Clone()
        {
            return (ElectronicPaymentManifest) this.MemberwiseClone();
        }
    }
}
