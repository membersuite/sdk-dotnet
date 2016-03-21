using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Manifests.Console
{
    [Serializable]
    [DataContract]
    public class Tab : CommandShortcut
    {
        public Tab()
        {
            Commands = new List<CommandShortcut>();
        }

        [XmlArrayItem("Command")]
        [DataMember]
        public List<CommandShortcut> Commands { get; set; }

        [XmlAttribute]
        [DataMember]
        public bool IsActive { get; set; }
    }
}