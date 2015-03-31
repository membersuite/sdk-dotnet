using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MemberSuite.SDK.Manifests;
using MemberSuite.SDK.Searching;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    /// Represents a template for an email that can be sent
    /// </summary>
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("EmailTemplate", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [Serializable]
    [DataContract]
    public class EmailTemplate : MetadataBase
    {
        [DataMember]
        public string SenderID { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public string SearchType { get; set; }

        [DataMember]
        public string BaseObject { get; set; }

        [DataMember]
        public string SearchContext { get; set; }

        [DataMember]
        public string FromName { get; set; }

        [DataMember]
        public string To { get; set; }

        [DataMember]
        public string Cc { get; set; }

        [DataMember]
        public string Bcc { get; set; }

        [DataMember]
        public string Subject { get; set; }

        [DataMember]
        public string HtmlBody { get; set; }

        [DataMember]
        public string TextBody { get; set; }

        [DataMember]
        public string ReplyTo { get; set; }

        [XmlArrayItem("Property")]
        [DataMember]
        public List<NameValueStringPair> ProcessingOptions { get; set; }

        [XmlArrayItem("Search")]
        [DataMember]
        public List<Search> SubSearches { get; set; }

        public static bool IsEmpty(EmailTemplate template)
        {
            if (template == null) return true;
            if (template.HtmlBody == null) return true;
            if (template.HtmlBody.Trim() == string.Empty) return true;
            return false;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="EmailTemplate"/> is disabled.
        /// </summary>
        /// <value><c>true</c> if disable; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool Disabled { get; set; }
    }
}
