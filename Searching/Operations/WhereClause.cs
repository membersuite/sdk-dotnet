using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Searching.Operations
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [System.Serializable]
    [DataContract]
    public class WhereClause : SearchOperation
    {
        /// <summary>
        /// Gets or sets the clause.
        /// </summary>
        /// <value>The clause.</value>
        [DataMember]
        public string Clause { get; set; }

        public override void Accept(ISearchObjectVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}