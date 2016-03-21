using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    public class NoSqlTableDefinition
    {
        public NoSqlTableDefinition()
        {

        }

        public NoSqlTableDefinition(Dictionary<string, object> members)
        {
            Name = members["Name"] as string;
            HashKey = members["HashKey"] as string;

            if (members.ContainsKey("RangeKey"))
                RangeKey = members["RangeKey"] as string;

            if (members.ContainsKey("ReadThroughput"))
                ReadThroughput = members["ReadThroughput"] as int? ?? 0;

            if (members.ContainsKey("WriteThroughput"))
                WriteThroughput = members["WriteThroughput"] as int? ?? 0;

            if (members.ContainsKey("WeekendReadThroughput"))
                ReadThroughput = members["WeekendReadThroughput"] as int? ?? 0;

            if (members.ContainsKey("WeekendWriteThroughput"))
                WriteThroughput = members["WeekendWriteThroughput"] as int? ?? 0;

            if (members.ContainsKey("HashKeyType"))
                HashKeyType = (NoSqlAttributeType) members["HashKeyType"];
            
            if (members.ContainsKey("RangeKeyType"))
                RangeKeyType = (NoSqlAttributeType)members["RangeKeyType"];

            if (members.ContainsKey("Lifespan"))
                Lifespan = (NoSqlTableLifespan)members["Lifespan"];
        }

        [XmlAttribute]
        public string Name { get; set; }

        public string HashKey { get; set; }

        public NoSqlAttributeType HashKeyType { get; set; }

        public string RangeKey { get; set; }

        public NoSqlAttributeType RangeKeyType { get; set; }

        public int ReadThroughput { get; set; }

        public int WriteThroughput { get; set; }

        public int WeekendReadThroughput { get; set; }

        public int WeekendWriteThroughput { get; set; }

        public NoSqlTableLifespan Lifespan { get; set; }

        public Dictionary<string, object> ConvertMembersToDictionary()
        {
            Dictionary<string, object> result = new Dictionary<string, object>
            {
                {"Name", Name},
                {"HashKey", HashKey},
                {"HashKeyType", HashKeyType},
                {"RangeKey", RangeKey},
                {"RangeKeyType", RangeKeyType},
                {"ReadThroughput", ReadThroughput},
                {"WriteThroughput", WriteThroughput},
                {"WeekendReadThroughput", ReadThroughput},
                {"WeekendWriteThroughput", WriteThroughput},
                {"Lifespan", Lifespan}
            };

            return result;
        }

        public NoSqlTableDefinition Clone()
        {
            Dictionary<string, object> attributes = ConvertMembersToDictionary();
            return new NoSqlTableDefinition(attributes);
        }
    }
}
