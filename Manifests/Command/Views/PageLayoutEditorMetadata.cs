using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Manifests.Command.Views
{
    [Serializable]
    [DataContract]
    public class PageLayoutEditorMetadata
    {
        [DataMember]
        public bool AllowSectionCreationAndRemoval { get; set; }

        [DataMember]
        public bool ShowAddAdditionalOutputFieldsLink { get; set; }

        [DataMember]
        public bool ShowAddSeperatorLink { get; set; }

        [DataMember]
        public bool AllowFieldRelabeling { get; set; }
    }
}
