using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    [DataContract(Name = "WriteOffInvoicesJobManifest")]
    public class WriteOffInvoicesJobManifest
    {
        public DateTime Date { get; set; }
        public WriteOffMethod Method { get; set; }
        public string WriteOfGLAccount { get; set; }
        public string Memo { get; set; }
        public string Batch { get; set; }

    
    }
}