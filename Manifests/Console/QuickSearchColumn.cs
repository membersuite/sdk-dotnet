using System;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Manifests.Console
{
    [Serializable]
    public class QuickSearchColumn
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string DisplayName { get; set; }

        [XmlAttribute]
        public int Width { get; set; }
    }
}