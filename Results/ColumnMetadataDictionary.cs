using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Results
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    [Serializable]
    [CollectionDataContract(Name = "ColumnMetadataDictionary", KeyName = "Key", ValueName = "Value", ItemName = "KeyValueOfstringFieldMetadata")]
    public class ColumnMetadataDictionary : Dictionary<string, FieldMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnMetadataDictionary"/> class.
        /// </summary>
        /// <remarks></remarks>
        public ColumnMetadataDictionary() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnMetadataDictionary"/> class.
        /// </summary>
        /// <param name="info">The info.</param>
        /// <param name="context">The context.</param>
        /// <remarks></remarks>
        protected ColumnMetadataDictionary(SerializationInfo info, StreamingContext context) : base(info, context) { }       
    }
}
