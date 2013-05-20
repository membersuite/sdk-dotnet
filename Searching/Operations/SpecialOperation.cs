using System.Xml.Serialization;

namespace MemberSuite.SDK.Searching.Operations
{
    /// <summary>
    /// Represents an operation that is specific to a search - that is, handled by a 
    /// SearchRunner directly. Example - Has Register For Event, Was Member In '{0}' year, etc, 
    /// </summary>
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [System.Serializable]
    public class SpecialOperation : SearchOperation
    {
        public override void Accept(ISearchObjectVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}