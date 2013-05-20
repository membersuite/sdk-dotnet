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
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the additional fields that should always be loaded
        /// </summary>
        /// <value>The additional fields.</value>
        [XmlArrayItem("Field")]
        [DataMember]
        public List<string> AdditionalFields { get; set; }

        [DataMember]
        public string DefaultOneClick { get; set; }

        [XmlArrayItem("Section")]
        [DataMember]
        public List<ViewMetadata.ControlSection> Sections { get; set; }

        /// <summary>
        /// Gets or sets the searches for this 360 layout
        /// </summary>
        /// <value>The searches.</value>
        [XmlArrayItem("Search")]
        [DataMember]
        public List<Search> Searches { get; set; }


        public bool ContainsField(string fieldName)
        {
            if (Sections == null)
                return false;

            foreach (var sec in Sections)
                if (sec.ContainsField(fieldName))
                    return true;

            return false;
        }

        public void Clean()
        {
            if (Sections != null)
            {
                // first, let's assign numbers if they are not there
                for (int i = 0; i < Sections.Count; i++)
                    if (Sections[i].DisplayOrder == default(int))
                        Sections[i].DisplayOrder = (i + 1) * 10;

                // now sort
                Sections.Sort((x, y) => x.DisplayOrder.CompareTo(y.DisplayOrder));

                // now, set them to what they should be
                for (int i = 0; i < Sections.Count; i++)
                    Sections[i].DisplayOrder = (i + 1) * 10;

                }

            if (Searches != null)
                foreach (var s in Searches)
                    if (string.IsNullOrWhiteSpace(s.ID))
                        s.ID = Guid.NewGuid().ToString();
        }
    }
}
