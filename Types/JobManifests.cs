using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    [DataContract(Name = "WriteOffInvoicesJobManifest")]
    public class WriteOffInvoicesJobManifest
    {
        public WriteOffInvoicesJobManifest()
        {
        }


       

        public msWriteOff ToMemberSuiteObject()
        {
            var mso = new msWriteOff();
            mso.Date = Date;
            mso.Method = Method;
            mso.WriteOffGLAccount = WriteOfGLAccount;
            mso.Memo = Memo;
            mso.Batch = Batch;

            return mso;
        }

        public DateTime Date { get; set; }
        public WriteOffMethod Method { get; set; }
        public string WriteOfGLAccount { get; set; }
        public string Memo { get; set; }
        public string Batch { get; set; }
    }
}
