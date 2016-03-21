using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlInclude(typeof (List<string>))]
    public struct NameValuePair
    {
        private string _name;
        private object _value;

        public NameValuePair(string name, object val)
        {
            _name = name;
            _value = val;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public object Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public override string ToString()
        {
            return _value != null ? _value.ToString() : null;
        }
    }
}