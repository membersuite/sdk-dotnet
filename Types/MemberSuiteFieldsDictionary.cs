using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [CollectionDataContract(Name = "MemberSuiteFieldsDictionary", KeyName = "Key", ValueName = "Value",
        ItemName = "KeyValueOfstringanyType")]
    public class MemberSuiteFieldsDictionary : Dictionary<string, object>
    {
        public MemberSuiteFieldsDictionary()
        {
        }

        protected MemberSuiteFieldsDictionary(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}