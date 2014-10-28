using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    /// Class designed to override field metadata
    /// </summary>
    [Serializable]
    [DataContract]
    public class FieldMetadataOverride
    {
        public FieldMetadataOverride()
        {
            PickListEntries = null;
            
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute]
        [DataMember]
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        [XmlAttribute]
        [DataMember]
        public string Label { get; set; }

          /// <summary>
        /// Gets or sets the type of the data.
        /// </summary>
        /// <value>The type of the data.</value>
        [XmlIgnore]
        [DataMember]
        public FieldDataType? DataType { get; set; }

        [XmlAttribute]
        [DataMember]
        public virtual string Namespace { get; set; }

        [XmlAttribute]
        [DataMember]
        public string PortalPrompt { get; set; }

        [XmlAttribute]
        [DataMember]
        public string HelpText { get; set; }

        /// <summary>
        /// Gets or sets the display type.
        /// </summary>
        /// <value>The display type.</value>
        [XmlIgnore]
        [DataMember]
        public FieldDisplayType? DisplayType { get; set; }

        /// <summary>
        /// If this is a pick list object, contains the entries that should be in the picklist
        /// </summary>
        [XmlArray("PickListEntries", IsNullable=true )]
        [XmlArrayItem("PickListEntry")]
        [DataMember]
        public List<PickListEntry> PickListEntries { get; set; }

        [XmlAttribute]
        [DataMember]
        public string NullValueLabel { get; set; }

        /// <summary>
        /// Gets or sets the lookup table ID to pull acceptable values from.
        /// </summary>
        /// <value>The lookup table ID.</value>
        [XmlAttribute]
        [DataMember]
        public string LookupTableID { get; set; }

        /// <summary>
        /// Gets or sets the type of the reference, if this is a reference type
        /// </summary>
        /// <value>The type of the reference.</value>
        [XmlAttribute]
        [DataMember]
        public string ReferenceType { get; set; }

        [XmlAttribute]
        [DataMember]
        public string ReferenceContext { get; set; }

        // Attribute is defined below via the workaround
        [XmlIgnore]
        [DataMember]
        public bool? IsRequired { get; set; }

        // Attribute is defined below via the workaround
        [XmlIgnore]
        [DataMember]
        public bool? IsRequiredInPortal { get; set; }

        [XmlIgnore]
        [DataMember]
        public PortalAccessibility? PortalAccessibility { get; set; }

        [XmlAttribute]
        [DataMember]
        public string DefaultValue { get; set; }

        [XmlIgnore]
        [DataMember]
        public bool? IsSealed { get; set; }

        [XmlIgnore]
        [DataMember]
        public bool? IsReadOnly { get; set; }

        [XmlIgnore]
        [DataMember]
        public bool? DoNotDescribe { get; set; }

        [XmlIgnore]
        [DataMember]
        public bool? SuppressDefaultValue { get; set; }

        [DataMember]
        public SecurityLock SecurityLock { get; set; }
    
        #region Serializatioon Workarounds

        // In .NET you can't serialize a Nullable to an attribute

        [XmlAttribute( "DataType" )]
        public string FieldDataTypeString
        {
            get { return DataType != null ? DataType.ToString() : null; }
            set
            {
                FieldDataType fieldDataType;
                DataType = Enum.TryParse(value, out fieldDataType) ? fieldDataType : default(FieldDataType?);
            }
        }

        [XmlAttribute("IsSealed")]
        public string IsSealedString
        {
            get { return IsSealed != null ? IsSealed.ToString() : null; }
            set
            {
                if (value == null)
                {
                    IsSealed = null;
                    return;
                }

                try
                {
                    IsSealed = Convert.ToBoolean(value);
                }
                catch
                {
                    IsSealed = null;
                }
            }
        }
        [XmlAttribute("DisplayType")]
        public string FieldDisplayTypeString
        {
            get { return DisplayType != null ? DisplayType.ToString() : null; }
            set
            {
                FieldDisplayType fieldDisplayType;
                DisplayType = Enum.TryParse(value, out fieldDisplayType) ? fieldDisplayType : default(FieldDisplayType?);
            }
        }


        [XmlAttribute("IsRequired")]
        public string IsRequiredString
        {
            get { return IsRequired != null ? IsRequired.ToString() : null; }
            set
            {
                if (value == null)
                {
                    IsRequired = null;
                    return;
                }

                try
                {
                    IsRequired = Convert.ToBoolean(value);
                }
                catch
                {
                    IsRequired = null;
                }
            }
        }

        [XmlAttribute("IsRequiredInPortal")]
        public string IsRequiredInPortalString
        {
            get { return IsRequiredInPortal != null ? IsRequiredInPortal.ToString() : null; }
            set
            {
                if (value == null)
                {
                    IsRequiredInPortal = null;
                    return;
                }

                try
                {
                    IsRequiredInPortal = Convert.ToBoolean(value);
                }
                catch
                {
                    IsRequiredInPortal = null;
                }
            }
        }

        [XmlAttribute("PortalAccessibility")]
        public string PortalAccessibilityString
        {
            get { return PortalAccessibility != null ? PortalAccessibility.ToString() : null; }
            set
            {
                PortalAccessibility portalAccessibility;
                PortalAccessibility = Enum.TryParse(value, out portalAccessibility) ? portalAccessibility : default(PortalAccessibility?);
            }
        }

        [XmlAttribute("DoNotDescribe")]
        public string DoNotDescribeString
        {
            get { return DoNotDescribe != null ? DoNotDescribe.ToString() : null; }
            set
            {
                if (value == null)
                {
                    DoNotDescribe = null;
                    return;
                }

                try
                {
                    DoNotDescribe = Convert.ToBoolean(value);
                }
                catch
                {
                    DoNotDescribe = null;
                }
            }
        }

        [XmlAttribute("IsReadOnly")]
        public string IsReadOnlyString
        {
            get { return IsReadOnly != null ? IsReadOnly.ToString() : null; }
            set
            {
                if (value == null)
                {
                    IsReadOnly = null;
                    return;
                }

                try
                {
                    IsReadOnly = Convert.ToBoolean(value);
                }
                catch
                {
                    IsReadOnly = null;
                }
            }
        }

        public bool ShouldSerializePickListEntries()
        {
            return PickListEntries != null && PickListEntries.Count > 0;
        }


        public bool ShouldSerializeSecurityLock()
        {
            return SecurityLock != null && SecurityLock.Participants != null && SecurityLock.Participants.Count > 0;
        }


        #endregion

        /// <summary>
        /// Overrides the specified original field.
        /// </summary>
        /// <param name="originalField">The original field.</param>
        public void Override(FieldMetadata originalField)
        {
            if (DataType != null)
                originalField.DataType = DataType.Value;

            if (DisplayType != null)
                originalField.DisplayType = DisplayType.Value;

            if (Label != null)
                originalField.Label = Label;

            if (ReferenceType != null)
                originalField.ReferenceType = ReferenceType;

            if (IsRequired != null)
                originalField.IsRequired = IsRequired.Value;

            if (IsRequiredInPortal != null)
                originalField.IsRequiredInPortal = IsRequiredInPortal.Value;

            if (DefaultValue != null)
                originalField.DefaultValue = DefaultValue;

            if (IsSealed != null)
                originalField.IsSealed = IsSealed.Value;

            if (IsReadOnly != null)
                originalField.IsReadOnly = IsReadOnly.Value;

            if (DoNotDescribe != null)
                originalField.DoNotDescribe = DoNotDescribe.Value;

            if (PortalPrompt != null)
                originalField.PortalPrompt = PortalPrompt;

            if(PortalAccessibility != null)
                originalField.PortalAccessibility = PortalAccessibility.Value;

            if (HelpText != null)
                originalField.HelpText = HelpText;

            if (PickListEntries != null && PickListEntries.Count > 0)
            {
                if (originalField.PickListEntries == null)
                    originalField.PickListEntries = new List<PickListEntry>();
                originalField.PickListEntries.AddRange(PickListEntries);
            }

            if (LookupTableID != null)
                originalField.LookupTableID = LookupTableID;

            if (NullValueLabel != null)
                originalField.NullValueLabel = NullValueLabel;

            if (Namespace != null)
                originalField.Namespace = Namespace;

            if (SuppressDefaultValue != null)
                originalField.SuppressDefaultValue = SuppressDefaultValue.Value;

            originalField.IsOverriden = true;
        }
    }

}
