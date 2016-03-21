using System;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Searching.Operations
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    public class IsNotBetween : IsBetween
    {
        public override bool IsNegative
        {
            get { return true; }
        }
    }
}