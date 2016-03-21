using System.Runtime.Serialization;
using System.ServiceModel.Channels;

namespace MemberSuite.SDK.Concierge
{
    //SIMPLE POCO objects to make the XML as simple as possible for PHP developers. (no generic classes)
    [DataContract(Namespace = "http://membersuite.com/schemas")]
    public class ConciergeResponseHeader : ConciergeMessageHeader
    {
        public const string HeaderName = "ConciergeResponseHeader";

        public static ConciergeResponseHeader GetConciergeResponseHeader(Message request)
        {
            return GetConciergeMessageHeader<ConciergeResponseHeader>(HeaderName, request);
        }
    }
}