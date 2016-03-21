using System;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Searching.Operations
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    public class Keyword : SearchOperation
    {
        public override void Accept(ISearchObjectVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}