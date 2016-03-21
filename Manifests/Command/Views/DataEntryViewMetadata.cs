using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Manifests.Command.Views
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("DataEntryViewMetadata", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [Serializable]
    [DataContract]
    public class DataEntryViewMetadata : MetadataBase, ISectionLayoutMetadata
    {
        [DataMember]
        public string LeftColumnHeader { get; set; }

        [DataMember]
        public string RightColumnHeader { get; set; }

        [XmlArrayItem("Step")]
        [DataMember]
        public List<StepDef> Steps { get; set; }

        [DataMember]
        public UsefulTipsDef UsefulTips { get; set; }

        [DataMember]
        public bool HideLeftColumn { get; set; }

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
        }

        public bool ContainsField(string fieldName)
        {
            return FindControlByDataSourceExpression(fieldName) != null;
        }

        /// <summary>
        ///     Checks to see if a particular field is used in this metadata
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns></returns>
        public ControlMetadata FindControlByDataSourceExpression(string fieldName)
        {
            if (Sections == null)
                return null;

            ControlMetadata cm;
            foreach (var section in Sections)
            {
                if (section.LeftControls != null)
                {
                    cm = section.LeftControls.Find(c => c.DataSourceExpression == fieldName);
                    if (cm != null) return cm;
                }

                if (section.RightControls != null)
                {
                    cm = section.RightControls.Find(c => c.DataSourceExpression == fieldName);
                    if (cm != null) return cm;
                }
            }

            return null;
        }

        /// <summary>
        ///     Checks to see if a particular field is used in this metadata
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns></returns>
        public ControlMetadata FindControlByID(string fieldName)
        {
            if (Sections == null)
                return null;

            ControlMetadata cm;
            foreach (var section in Sections)
            {
                if (section.LeftControls != null)
                {
                    cm = section.LeftControls.Find(c => c.ID == fieldName);
                    if (cm != null) return cm;
                }

                if (section.RightControls != null)
                {
                    cm = section.RightControls.Find(c => c.ID == fieldName);
                    if (cm != null) return cm;
                }
            }

            return null;
        }

        /// <summary>
        ///     Checks to see if a particular field is used in this metadata
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns></returns>
        public ControlMetadata RemoveControlByID(string fieldName)
        {
            if (Sections == null)
                return null;

            ControlMetadata cm;
            foreach (var section in Sections)
            {
                if (section.LeftControls != null)
                {
                    cm = section.LeftControls.Find(c => c.ID == fieldName);
                    if (cm != null) section.LeftControls.Remove(cm);
                }

                if (section.RightControls != null)
                {
                    cm = section.RightControls.Find(c => c.ID == fieldName);
                    if (cm != null) section.RightControls.Remove(cm);
                }
            }

            return null;
        }

        /// <summary>
        ///     Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///     <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (Sections == null || Sections.Count == 0) return true;

            foreach (var s in Sections)
                if (!s.IsEmpty())
                    return false;

            return true; // nothing there
        }

        [Serializable]
        [DataContract]
        public class UsefulTipsDef
        {
            [XmlAttribute]
            [DataMember]
            public bool Show { get; set; }

            [XmlAttribute]
            [DataMember]
            public string Label { get; set; }

            [XmlArrayItem("Tip")]
            [DataMember]
            public List<CommandShortcut> Tips { get; set; }
        }

        [Serializable]
        [DataContract]
        public class StepDef : CommandShortcut
        {
            [XmlAttribute]
            [DataMember]
            public bool IsCurrent { get; set; }
        }
    }
}