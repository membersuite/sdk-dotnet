using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Manifests.Reporting
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("WidgetDefinition", Namespace = "http://membersuite.com/schemas/",
       IsNullable = false)]
    [Serializable]
    [DataContract]
    public class WidgetDefinition : MetadataBase 
    {

        [XmlAttribute]
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public string Label { get; set; }

        [DataMember]
        public string Control { get; set; }

        [DataMember]
        public string Category { get; set; }

        [DataMember]
        public string Icon { get; set; }

        [DataMember]
        public bool Collapsed { get; set; }

        [DataMember]
        public bool DefaultOnLeftSide { get; set; }

        [XmlArrayItem("Property")]
        [DataMember]
        public List<NameValueStringPair> Properties;

        public string GetProperty(string propertyName)
        {
            if (Properties == null)
                return null;

            var p = Properties.Find(f1 => f1.Name == propertyName);

            return p.Value;

        }

        public void SetProperty(string name, string val)
        {
            if (Properties == null)
                Properties = new List<NameValueStringPair>();

            Properties.RemoveAll(n => string.Equals(n.Name, name, StringComparison.CurrentCultureIgnoreCase));
            Properties.Add(new NameValueStringPair(name, val));
        }
    }
}
