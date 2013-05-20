using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Manifests.Command.Views
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("TabularDataViewMetadata", Namespace = "http://membersuite.com/schemas/",
       IsNullable = false)]
    [Serializable]
    [DataContract]
    public class TabularDataViewMetadata
    {
        public TabularDataViewMetadata()
        {
            CommandSections = new List<ViewMetadata.ControlSection>();
            Fields = new List<FieldMetadata>();
        }


        [DataMember]
        public bool RenderInEditMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show checkboxes].
        /// </summary>
        /// <value><c>true</c> if [show checkboxes]; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool ShowCheckboxes { get; set; }

        [DataMember]
        public string IDColumn { get; set; }

        [DataMember]
        public bool DisablePaging { get; set; }

        [XmlArrayItem("Command")]
        [DataMember]
        public List<CommandShortcut> RowLevelCommands { get; set; }

        [DataMember]
        public int RowLevelCommandWidth { get; set; }

        [XmlArrayItem("Field")]
        [DataMember]
        public List<FieldMetadata> Fields { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        [XmlElement]
        [DataMember]
        public string EditInstructionText { get; set; }

        [XmlArrayItem("Section")]
        [DataMember]
        public List<ViewMetadata.ControlSection> CommandSections { get; set; }

       
    }
}
