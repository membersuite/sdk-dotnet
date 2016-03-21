using System;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Searching.Operations
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    public class NoKeyword : Keyword
    {
        public override bool IsNegative
        {
            get { return true; }
        }

        public override void Accept(ISearchObjectVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}