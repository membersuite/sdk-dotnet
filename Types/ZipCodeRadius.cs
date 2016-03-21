using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class ZipCodeRadius
    {
        [DataMember]
        public string ZipCode { get; set; }

        [DataMember]
        public double Longitude { get; set; }

        [DataMember]
        public double Latitude { get; set; }

        [DataMember]
        public decimal DistanceFromTarget { get; set; }
    }
}