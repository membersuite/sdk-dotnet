using System;
using System.Runtime.Serialization;
using System.ServiceModel.Channels;

namespace MemberSuite.SDK.Concierge
{
    //SIMPLE POCO objects to make the XML as simple as possible for PHP developers. (no generic classes)
    [DataContract(Namespace = "http://membersuite.com/schemas")]
    public class ConciergeRequestHeader : ConciergeMessageHeader
    {
        public const string HeaderName = "ConciergeRequestHeader";

        [DataMember]
        public string AccessKeyId { get; set; }

        [DataMember]
        public string Signature { get; set; }

        [DataMember]
        public string AssociationId { get; set; }

        public static ConciergeRequestHeader GetConciergeRequestHeader(Message request)
        {
            return GetConciergeMessageHeader<ConciergeRequestHeader>(HeaderName, request);
        }
    }
}