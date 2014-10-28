using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    [DataContract]
    public class ShippingCarrierServicesInfo
    {
        [DataMember]
        public string ShippingCarrierAccount { get; set; }

        [DataMember]
        public List<ShippingCarrierService> Services { get; set; } 
    }

    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    [DataContract]
    public class ShippingCarrierService
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Value { get; set; }
    }
}
