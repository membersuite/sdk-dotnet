using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("CustomFieldValueHolder", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [DataContract]
    public class CustomFieldValueHolder
    {
        // NOTE THIS NAME IS IMPORTANT!
        // Because it ends in _ID, the data loader client will read it as a reference. If you rename it without ending in _ID,
        // no data imports will work!!
        [DataMember]
        public string Field_ID { get; set; }

        [DataMember]
        public string FieldName { get; set; }

        [DataMember]
        public int? IntegerValue { get; set; }

        [DataMember]
        public decimal? DecimalValue { get; set; }

        [DataMember]
        public string ReferenceValue {get;set;}

        [DataMember]
        public string StringValue { get; set; }

        [DataMember]
        public DateTime? DateTimeValue { get; set; }

        [DataMember]
        public List<string> ListValue { get; set; }

        [DataMember]
        public bool? BooleanValue { get; set; }

        public object GetValue()
        {
            if (IntegerValue != null) return IntegerValue;
            if (DecimalValue != null) return DecimalValue;
            if (ReferenceValue != null) return ReferenceValue;
            if (StringValue != null) return StringValue;
            if (DateTimeValue != null) return DateTimeValue;
            if (BooleanValue != null) return BooleanValue;
            if (ListValue != null && ListValue.Count >0) return ListValue;

            return null;
        }

    }
}
