using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MemberSuite.SDK.Manifests;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    ///     Holds all of the information describing an object
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("ClassMetadata", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [DataContract]
    public class ClassMetadata : MetadataBase
    {
        public ClassMetadata()
        {
            Fields = new List<FieldMetadata>();
            Createable = true;
            Updateable = true;
            Deletable = true;
            CanBeCachedForEntireAssociation = true; // by default
        }

        /// <summary>
        ///     Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        [DataMember]
        public string Label { get; set; }

        /// <summary>
        ///     Gets or sets the label plural.
        /// </summary>
        /// <value>The label plural.</value>
        [DataMember]
        public string LabelPlural { get; set; }

        /// <summary>
        ///     Gets or sets the module that this class belongs to
        /// </summary>
        /// <value>The module.</value>
        [DataMember]
        public string Module { get; set; }

        /// <summary>
        ///     Gets or sets the fields.
        /// </summary>
        /// <value>The fields.</value>
        [DataMember]
        public List<FieldMetadata> Fields { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="ClassMetadata" /> is createable.
        /// </summary>
        /// <value><c>true</c> if createable; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool Createable { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="ClassMetadata" /> is updateable.
        /// </summary>
        /// <value><c>true</c> if updateable; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool Updateable { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="ClassMetadata" /> is deletable.
        /// </summary>
        /// <value><c>true</c> if deletable; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool Deletable { get; set; }

        /// <summary>
        ///     Gets or sets the parent types.
        /// </summary>
        /// <value>The parent types.</value>
        [DataMember]
        public List<string> ParentTypes { get; set; }

        [DataMember]
        public List<ValidationRule> ValidationRules { get; set; }

        [DataMember]
        public List<FieldCalculationRule> FieldCalculationRules { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is abstract.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is abstract; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsAbstract { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is securable.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is securable; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsSecurable { get; set; }

        public bool IsCustom
        {
            get { return !string.IsNullOrEmpty(CustomObjectID); }
        }

        [DataMember]
        public string CustomObjectID { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance can be cached for entire association.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance can be cached for entire association; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool CanBeCachedForEntireAssociation { get; set; }

        #region Methods

        /// <summary>
        ///     Makes a copy of this object
        /// </summary>
        /// <returns></returns>
        public ClassMetadata Clone()
        {
            var meta = (ClassMetadata) MemberwiseClone();

            if (Fields != null) // we'll clear this
            {
                meta.Fields = new List<FieldMetadata>();

                foreach (var entry in Fields)
                    meta.Fields.Add(entry.Clone()); // clone this too
            }

            return meta;
        }

        /// <summary>
        ///     Generates the field dictionary, for convience applications
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, FieldMetadata> GenerateFieldDictionary()
        {
            var dic = new Dictionary<string, FieldMetadata>();

            if (Fields != null)
                foreach (var field in Fields)
                    dic[field.Name] = field;

            return dic;
        }

        #endregion
    }
}