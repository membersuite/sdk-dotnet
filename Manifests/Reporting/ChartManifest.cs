using System.Data;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Manifests.Reporting
{
    [System.Serializable]
    [DataContract]
    public class ChartManifest
    {
        [DataMember]
        public string Label { get; set; }

        [DataMember]
        public DataTable DataSource { get; set; }

        [DataMember]
        public string ChartDefinition { get; set; }
    }
}
