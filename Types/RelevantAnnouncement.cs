using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class RelevantAnnouncement
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public string AnnouncementText { get; set; }

        [DataMember]
        public RelevantAnnouncementType AnnouncementType { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    [Serializable]
    public enum RelevantAnnouncementType
    {
        SystemWide
    }
}