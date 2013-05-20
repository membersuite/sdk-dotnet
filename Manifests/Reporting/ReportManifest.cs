using System.Runtime.Serialization;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Manifests.Reporting
{
    [System.Serializable]
    [DataContract]
    public class ReportManifest
    {
        public ReportManifest()
        {
            Parameters = new SerializableDictionary<string, object>();
        }


        [DataMember]
        public string ReportSpecificationName { get; set; }

        [DataMember]
        public SerializableDictionary<string, object> Parameters { get; set; }
    }
}
