using System;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Searching.Operations
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    public class IsLessThanOrEqual : IsGreaterThan
    {
        public override bool IsNegative
        {
            get { return true; }
        }
    }
}