using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Manifests.Command
{
    [Serializable]
    [DataContract]
    public class PartialReportDefinition
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Category { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string ExpectedContextType { get; set; }
    }

    [Serializable]
    [DataContract]
    public class ReportDefinition
    {
        [DataMember]
        public bool IsRaw { get; set; }
        
        [DataMember]
        public string ReportDefinitionXml { get; set; }
    }
}
