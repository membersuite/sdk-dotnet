// ***********************************************************************
// Assembly         : MemberSuite.SDK
// Author           : Andrew
// Created          : 09-13-2012
//
// Last Modified By : Andrew
// Last Modified On : 09-13-2012
// ***********************************************************************
// <copyright file="FieldMetadata.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using MemberSuite.SDK.Utilities;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    /// Represents everything about a "field", or in the .NET world, a property, on
    /// an object
    /// </summary>
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    [DataContract(Name = "FieldMetadata")]
    public class FieldMetadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldMetadata"/> class.
        /// </summary>
        public FieldMetadata()
        {
            PickListEntries = new List<PickListEntry>();
            Type = FieldType.BuiltIn;
            Sortable = true; // by default
            Displayable = true;
            AccessLevel = SecurityLockAccessLevel.ReadWrite;
            Precision = 2;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute]
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        [XmlAttribute]
        [DataMember]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the portal prompt.
        /// </summary>
        /// <value>The portal prompt.</value>
        [XmlAttribute]
        [DataMember]
        public string PortalPrompt { get; set; }

        /// <summary>
        /// Gets or sets the help text.
        /// </summary>
        /// <value>The help text.</value>
        [XmlAttribute]
        [DataMember]
        public string HelpText { get; set; }

        /// <summary>
        /// Gets or sets the namespace.
        /// </summary>
        /// <value>The namespace.</value>
        [XmlAttribute]
        [DataMember]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or sets the portal accessibility.
        /// </summary>
        /// <value>The portal accessibility.</value>
        [XmlAttribute]
        [DataMember]
        public PortalAccessibility PortalAccessibility { get; set; }

        /// <summary>
        /// Gets or sets the type of field
        /// </summary>
        /// <value>The type.</value>
        [XmlAttribute]
        [DataMember]
        public FieldType Type { get; set; }

        /// <summary>
        /// Gets or sets the type of the data.
        /// </summary>
        /// <value>The type of the data.</value>
        [XmlAttribute]
        [DataMember]
        public FieldDataType DataType { get; set; }

        /// <summary>
        /// Gets or sets the display type.
        /// </summary>
        /// <value>The display type.</value>
        [XmlAttribute]
        [DataMember]
        public FieldDisplayType DisplayType { get; set; }

        /// <summary>
        /// Gets or sets the width of the column.
        /// </summary>
        /// <value>The width of the column.</value>
        [XmlIgnore]
        [DataMember]
        public int? ColumnWidth { get; set; }

        /// <summary>
        /// Gets or sets the null value label.
        /// </summary>
        /// <value>The null value label.</value>
        [XmlAttribute]
        [DataMember]
        public string NullValueLabel { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [XmlAttribute]
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// The _declaring type
        /// </summary>
        private string _declaringType;

        /// <summary>
        /// Gets or sets the type that this field is declared on
        /// </summary>
        /// <value>The type of the declaring.</value>
        [XmlAttribute]
        [DataMember]
        public string DeclaringType
        {
            get
            {
                if (_declaringType == null)
                    return Name; // this
                return _declaringType;
            }
            set { _declaringType = value; }
        }

        /// <summary>
        /// Gets or sets the lookup table ID.
        /// </summary>
        /// <value>The lookup table ID.</value>
        [XmlAttribute]
        [DataMember]
        public string LookupTableID { get; set; }

        /// <summary>
        /// Gets or sets the extension service ID that will populate this record (dropdowns/ajax combobox only)
        /// </summary>
        /// <value>The extension service ID.</value>
        [XmlAttribute]
        [DataMember]
        public string ExtensionServiceID { get; set; }

        /// <summary>
        /// Gets or sets the relationship type ID.
        /// </summary>
        /// <value>The relationship type ID.</value>
        [XmlAttribute]
        [DataMember]
        public string RelationshipTypeID { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FieldMetadata" /> is sortable.
        /// </summary>
        /// <value><c>true</c> if sortable; otherwise, <c>false</c>.</value>
        [XmlAttribute]
        [DataMember]
        public bool Sortable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FieldMetadata" /> is displayable.
        /// </summary>
        /// <value><c>true</c> if displayable; otherwise, <c>false</c>.</value>
        [XmlAttribute]
        [DataMember]
        public bool Displayable { get; set; }

        /// <summary>
        /// Gets or sets the default value.
        /// </summary>
        /// <value>The default value.</value>
        [XmlAttribute]
        [DataMember]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets the minimum value.
        /// </summary>
        /// <value>The minimum value.</value>
        [XmlAttribute]
        [DataMember]
        public string MinimumValue { get; set; }

        /// <summary>
        /// Gets or sets the maximum value.
        /// </summary>
        /// <value>The maximum value.</value>
        [XmlAttribute]
        [DataMember]
        public string MaximumValue { get; set; }

        /// <summary>
        /// If this is a pick list object, contains the entries that should be in the picklist
        /// </summary>
        /// <value>The pick list entries.</value>
        [XmlArray("PickListEntries")]
        [XmlArrayItem("PickListEntry")]
        [DataMember]
        public List<PickListEntry> PickListEntries { get; set; }

        /// <summary>
        /// Gets or sets the type of the reference, if this is a reference type
        /// </summary>
        /// <value>The type of the reference.</value>
        [XmlAttribute]
        [DataMember]
        public string ReferenceType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is required.
        /// </summary>
        /// <value><c>true</c> if this instance is required; otherwise, <c>false</c>.</value>
        [XmlAttribute]
        [DataMember]
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is required in portal.
        /// </summary>
        /// <value><c>true</c> if this instance is required in portal; otherwise, <c>false</c>.</value>
        [XmlAttribute]
        [DataMember]
        public bool IsRequiredInPortal { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is sealed.
        /// </summary>
        /// <value><c>true</c> if this instance is sealed; otherwise, <c>false</c>.</value>
        [XmlAttribute]
        [DataMember]
        public bool IsSealed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is read only.
        /// </summary>
        /// <value><c>true</c> if this instance is read only; otherwise, <c>false</c>.</value>
        [XmlAttribute]
        [DataMember]
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the access level.
        /// </summary>
        /// <value>The access level.</value>
        [XmlAttribute]
        [DataMember]
        public SecurityLockAccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [do not describe].
        /// </summary>
        /// <value><c>true</c> if [do not describe]; otherwise, <c>false</c>.</value>
        [XmlAttribute]
        [DataMember]
        public bool DoNotDescribe { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is overriden.
        /// </summary>
        /// <value><c>true</c> if this instance is overriden; otherwise, <c>false</c>.</value>
        [XmlIgnore]
        [DataMember]
        public bool IsOverriden { get; set; }

        /// <summary>
        /// Gets or sets the custom field ID.
        /// </summary>
        /// <value>The custom field ID.</value>
        [XmlAttribute]
        [DataMember]
        public string CustomFieldID { get; set; }

        /// <summary>
        /// Gets or sets the reference type context.
        /// </summary>
        /// <value>The reference type context.</value>
        [XmlAttribute]
        [DataMember]
        public string ReferenceTypeContext { get; set; }

        /// <summary>
        /// Gets or sets the type of the metadata.
        /// </summary>
        /// <value>The type of the metadata.</value>
        [XmlAttribute]
        [DataMember]
        public string MetadataType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [do not convert time to UTC].
        /// </summary>
        /// <value><c>true</c> if [do not convert time to UTC]; otherwise, <c>false</c>.</value>
        [XmlAttribute]
        [DataMember]
        public bool DoNotConvertTimeToUTC { get; set; }

        /// <summary>
        /// The number of digits available after the decimal point.  Applies to fields with a FieldDataType of Decimal only.
        /// </summary>
        /// <value>The precision.</value>
        [XmlAttribute]
        [DataMember]
        public int Precision { get; set; }

        /// <summary>
        /// Suppresses default value assignment
        /// </summary>
        [XmlAttribute]
        [DataMember]
        public bool SuppressDefaultValue { get; set; }

        [XmlAttribute]
        [DataMember]
        public string StartingYear { get; set; }

        [XmlAttribute]
        [DataMember]
        public string EndingYear { get; set; }


        #region Methods

        /// <summary>
        /// Makes a copy of this object
        /// </summary>
        /// <returns>FieldMetadata.</returns>
        public FieldMetadata Clone()
        {
            FieldMetadata meta = (FieldMetadata) MemberwiseClone();

            meta.PickListEntries = new List<PickListEntry>();
            if (PickListEntries != null)
                foreach (PickListEntry pe in PickListEntries)
                    meta.PickListEntries.Add(pe.Clone());


            return meta;
        }

        #endregion

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return string.Format("{0} <{1}>", Name, DataType);
        }


        /// <summary>
        /// Parses the specified list of pick list entries.
        /// </summary>
        /// <param name="listOfPickListEntries">The list of pick list entries.</param>
        /// <returns>List{PickListEntry}.</returns>
        public static List<PickListEntry> Parse(string listOfPickListEntries)
        {
            List<PickListEntry> entries = new List<PickListEntry>();
            if (listOfPickListEntries == null)
                return entries;

            string[] parts = listOfPickListEntries.Split('\n');

            // let's iterate through each entry
            foreach (string pickListEntry in parts)
            {
                // can we match to the regular expression?
                Match m = Regex.Match(pickListEntry, RegularExpressions.ParserRegex, RegexOptions.Compiled);

                // nope, keep it moving
                if (!m.Success)
                    continue;

                // yep - let's create a new entry
                PickListEntry pe = new PickListEntry();

                pe.Text = m.Groups[1].Value;
                pe.Value = m.Groups[2].Value;

                if (String.IsNullOrEmpty(pe.Value))
                    pe.Value = pe.Text; // if no value specified

                if (String.IsNullOrEmpty(pe.Text.Trim())) // nothing to do
                    continue;
                pe.Text = pe.Text.Trim();
                pe.Value = pe.Value.Trim();


                List<string> dependencyFields = new List<string>();
                string includedFields = m.Groups[3].Value;
                if (!String.IsNullOrEmpty(includedFields))
                    dependencyFields.AddRange(StringUtil.TrimStringArray(includedFields.Split('|')));

                string excludedFields = m.Groups[4].Value;
                if (!String.IsNullOrEmpty(excludedFields))
                {
                    dependencyFields.Clear();
                    pe.InvertCascadingDependency = true;
                    dependencyFields.AddRange(StringUtil.TrimStringArray(excludedFields.Split('|')));
                }

                // now - add them
                if (pe.CascadingDropDownParentValues == null)
                    pe.CascadingDropDownParentValues = new List<string>();
                foreach (string dField in dependencyFields)
                {
                    if (String.IsNullOrEmpty(dField))
                        continue;
                    pe.CascadingDropDownParentValues.Add(dField);
                }

                entries.Add(pe);
            }

            return entries;
        }


        /// <summary>
        /// Converts a list of pick list entries to a string
        /// </summary>
        /// <returns>System.String.</returns>
        public string ToPickListEntriesString()
        {
            var entries = PickListEntries;

            if (entries == null || entries.Count == 0)
                return null;


            // fire up the builder!
            StringBuilder sb = new StringBuilder();

            // go through each entry, adding a line
            foreach (var entry in entries)
            {
                if (entry.WasFromLookupTable)
                    continue; // we don't want to show those

                string entryLine;
                if (entry.Text == entry.Value || String.IsNullOrEmpty(entry.Value))
                    entryLine = entry.Text; // just add the raw text
                else
                    entryLine = string.Format("{0}|{1}", entry.Text, entry.Value); // separate text|value

                if (entry.CascadingDropDownParentValues != null && entry.CascadingDropDownParentValues.Count > 0)
                {
                    StringBuilder sbCacascadingFields = new StringBuilder();
                    foreach (string cascadingField in entry.CascadingDropDownParentValues)
                        sbCacascadingFields.AppendFormat("{0}|", cascadingField);

                    if (!entry.InvertCascadingDependency)
                        entryLine = string.Format("{0}[{1}]", entryLine, sbCacascadingFields.ToString().TrimEnd('|'));
                    else
                        entryLine = string.Format("{0}{{{1}}}", entryLine, sbCacascadingFields.ToString().TrimEnd('|'));
                }

                sb.AppendLine(entryLine);
            }

            return sb.ToString();
        }


        /// <summary>
        /// Gets the type for.
        /// </summary>
        /// <param name="dataType">Type of the data.</param>
        /// <returns>Type.</returns>
        public static Type GetTypeFor(FieldDataType dataType)
        {

            switch (dataType)
            {
                case FieldDataType.Text:
                case FieldDataType.LargeText:
                case FieldDataType.HtmlText:
                case FieldDataType.Email:
                case FieldDataType.PhoneNumber:
                case FieldDataType.Url:
                case FieldDataType.Type:
                    return typeof (string);

                case FieldDataType.Address:
                    return typeof (Address);

                case FieldDataType.Boolean:
                    return typeof (bool);

                case FieldDataType.Integer:
                    return typeof (int);

                case FieldDataType.Enum:
                    return typeof (int);

                case FieldDataType.Decimal:
                case FieldDataType.Money:
                case FieldDataType.Percentage:
                    return typeof (decimal);

                case FieldDataType.Image:
                case FieldDataType.Document:
                case FieldDataType.Binary:
                case FieldDataType.Timestamp:
                    return typeof (byte[]);

                case FieldDataType.Time:
                case FieldDataType.Date:
                case FieldDataType.DateTime:
                    return typeof (DateTime);

                case FieldDataType.List:
                    return typeof (List<string>);

                default:
                    return typeof (string);
            }
        }

        /// <summary>
        /// Gets an "empty" value for a specific data type
        /// </summary>
        /// <param name="dataType">Type of the data.</param>
        /// <returns>System.Object.</returns>
        public static object GetEmptyValueFor(FieldDataType dataType)
        {
            switch (dataType)
            {
                case FieldDataType.Text:
                case FieldDataType.LargeText:
                case FieldDataType.HtmlText:
                case FieldDataType.Email:
                case FieldDataType.PhoneNumber:
                case FieldDataType.Url:
                case FieldDataType.Type:
                    return string.Empty;

                case FieldDataType.Address:
                    return new Address();

                case FieldDataType.Boolean:
                    return false;

                case FieldDataType.Integer:
                case FieldDataType.Enum:
                case FieldDataType.Decimal:
                case FieldDataType.Money:
                case FieldDataType.Percentage:
                    return 0;

                case FieldDataType.Image:
                case FieldDataType.Document:
                case FieldDataType.Binary:
                case FieldDataType.Timestamp:
                    return new byte[0];

                case FieldDataType.Time:
                case FieldDataType.Date:
                case FieldDataType.DateTime:
                    return DateTime.Now;

                case FieldDataType.List:
                    return new List<string>();

                default:
                    return string.Empty;
            }

        }

        [DataMember]
        public string ApplicableType { get; set; }

        public static bool IsReferenceable(FieldDataType typeToCheck)
        {
            return typeToCheck == FieldDataType.Reference || typeToCheck == FieldDataType.Document ||
                   typeToCheck == FieldDataType.Image;
        }
    }

}
