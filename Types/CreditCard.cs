using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class CreditCard
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
    }
}
