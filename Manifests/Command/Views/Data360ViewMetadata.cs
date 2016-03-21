using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MemberSuite.SDK.Searching;

namespace MemberSuite.SDK.Manifests.Command.Views
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("Data360ViewMetadata", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [Serializable]
    [DataContract]
    public class Data360ViewMetadata : ISectionLayoutMetadata
    {
        /// <summary>
        ///     Gets or sets the additional fields that should always be loaded
        /// </summary>
        /// <value>The additional fields.</value>
        [XmlArrayItem("Field")]
        [DataMember]
        public List<string> AdditionalFields { get; set; }

        [DataMember]
        public string DefaultOneClick { get; set; }

        /// <summary>
        ///     Gets or sets the searches for this 360 layout
        /// </summary>
        /// <value>The searches.</value>
        [XmlArrayItem("Search")]
        [DataMember]
        public List<Search> Searches { get; set; }

        [DataMember]
        public bool DisableAjax { get; set; }

        [DataMember]
        public string SelectedSection { get; set; }

        [DataMember]
        public string Name { get; set; }

        [XmlArrayItem("Section")]
        [DataMember]
        public List<ViewMetadata.ControlSection> Sections { get; set; }

        public void Clean()
        {
            if (Sections != null)
            {
                // first, let's assign numbers if they are not there
                for (var i = 0; i < Sections.Count; i++)
                    if (Sections[i].DisplayOrder == default(int))
                        Sections[i].DisplayOrder = (i + 1)*10;

                // now sort
                Sections.Sort((x, y) => x.DisplayOrder.CompareTo(y.DisplayOrder));

                // now, set them to what they should be
                for (var i = 0; i < Sections.Count; i++)
                    Sections[i].DisplayOrder = (i + 1)*10;
            }

            if (Searches != null)
                foreach (var s in Searches)
                    if (string.IsNullOrWhiteSpace(s.ID))
                        s.ID = Guid.NewGuid().ToString();
        }

        public bool ContainsField(string fieldName)
        {
            if (Sections == null)
                return false;

            foreach (var sec in Sections)
                if (sec.ContainsField(fieldName))
                    return true;

            return false;
        }

        public string DetermineDefaultOneClick()
        {
            var defaultOneClick = DefaultOneClick;

            if (!string.IsNullOrWhiteSpace(defaultOneClick) && !
                Searches.Exists(
                    s =>
                        s.ID == defaultOneClick || s.Type == defaultOneClick))
                defaultOneClick = null; // it's not there, so it's null

            if (defaultOneClick == null) // assign it
            {
                defaultOneClick = Searches[0].ID;

                if (Searches.Count > 1 && defaultOneClick.Contains("AuditLogs")) // don't start with the audit!!
                    defaultOneClick = Searches[1].ID;

                return defaultOneClick;
            }

            return defaultOneClick;
        }
    }
}