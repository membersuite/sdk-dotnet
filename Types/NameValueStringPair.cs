using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    public struct NameValueStringPair
    {
        public NameValueStringPair(string name, string val)
        {
            _name = name;
            _value = val;
        }

        private string _name;
        private string _value;

        [XmlAttribute]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [XmlText]
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public override string ToString()
        {
            return _value != null ? _value.ToString() : null;
        }
    }

    public class NameValueStringPairNameComparer : IEqualityComparer<NameValueStringPair>
    {
       

        #region IEqualityComparer<NameValueStringPair> Members

        public bool Equals(NameValueStringPair x, NameValueStringPair y)
        {
            return string.Equals(x.Name, y.Name, StringComparison.CurrentCultureIgnoreCase );
        }

        public int GetHashCode(NameValueStringPair obj)
        {
            return obj.Name.GetHashCode();
        }

        #endregion
    }
}
