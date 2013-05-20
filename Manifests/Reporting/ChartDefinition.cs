using System.Runtime.Serialization;

namespace MemberSuite.SDK.Manifests.Reporting
{
    [System.Serializable]
    [DataContract]
    public class ChartDefinition
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Label { get; set; }

        [DataMember]
        public string ExpectedContext { get; set; }

        [DataMember]
        public bool AllowNullContext { get; set; }
    }
}
