using System.Runtime.Serialization;
using System.ServiceModel.Channels;
using System.Xml;

namespace MemberSuite.SDK.Concierge
{
    //SIMPLE POCO objects to make the XML as simple as possible for PHP developers. (no generic classes)
    [DataContract(Namespace = "http://membersuite.com/schemas")]
    public abstract class ConciergeMessageHeader
    {
        public const string HeaderNamespace = "http://membersuite.com/schemas";

        [DataMember]
        public string BrowserId { get; set; }
     
        [DataMember]
        public string SessionId { get; set; }

        protected static T GetConciergeMessageHeader<T>(string headerName, Message request)
            where T : ConciergeMessageHeader
        {
            T result = null;

            try
            {
                result = request.Headers.GetHeader<T>(headerName,
                                                      HeaderNamespace);
            }
            catch
            {
                return null;
            }

            return result;
        }
    }

}
