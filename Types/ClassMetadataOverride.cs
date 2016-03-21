// ***********************************************************************
// Assembly         : MemberSuite.SDK
// Author           : Andrew
// Created          : 09-13-2012
//
// Last Modified By : Andrew
// Last Modified On : 09-13-2012
// ***********************************************************************
// <copyright file="ClassMetadataOverride.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    ///     Class ClassMetadataOverride
    /// </summary>
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("ClassMetadataOverride", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [Serializable]
    [DataContract]
    public class ClassMetadataOverride
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ClassMetadataOverride" /> class.
        /// </summary>
        public ClassMetadataOverride()
        {
            Fields = new List<FieldMetadataOverride>();
        }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [DataMember]
        public string Name { get; set; }

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
        [XmlArrayItem("Field")]
        [DataMember]
        public List<FieldMetadataOverride> Fields { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this is createable.
        /// </summary>
        /// <value><c>true</c> if createable; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool? Createable { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this is updateable.
        /// </summary>
        /// <value><c>true</c> if updateable; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool? Updateable { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this is deletable.
        /// </summary>
        /// <value><c>true</c> if deletable; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool? Deletable { get; set; }

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
        ///     Gets or sets a value indicating whether this instance is securable.
        /// </summary>
        /// <value><c>null</c> if [is securable] contains no value, <c>true</c> if [is securable]; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool? IsSecurable { get; set; }

        /// <summary>
        ///     Gets or sets the validation rules.
        /// </summary>
        /// <value>The validation rules.</value>
        [DataMember]
        public List<ValidationRule> ValidationRules { get; set; }

        /// <summary>
        ///     Gets or sets the field calculation rules.
        /// </summary>
        /// <value>The field calculation rules.</value>
        [DataMember]
        public List<FieldCalculationRule> FieldCalculationRules { get; set; }
    }
}