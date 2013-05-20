using System.Collections.Generic;
using System.Xml.Serialization;
using MemberSuite.SDK.Manifests;
using System;

namespace MemberSuite.SDK.DuplicateDetection
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("DuplicateDetectionRule", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [Serializable]
    public class DuplicateDetectionRule : MetadataBase
    {
        public DuplicateDetectionRule()
        {
            Fields = new List<DetectionField>();
        }
      
        /// <summary>
        /// Gets or sets the type of object
        /// this rule applies to.
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; set; }
        public List<DetectionField> Fields { get; set; }

        

     
    }
}