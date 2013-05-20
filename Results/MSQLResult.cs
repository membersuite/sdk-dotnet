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
    [DataContract]
    public class MSQLResult  
    {
        /// <summary>
        /// Gets or sets the search result.
        /// </summary>
        /// <value>The search result.</value>
        /// <remarks></remarks>
        [DataMember]
        public SearchResult SearchResult { get; set; }

        /// <summary>
        /// Gets or sets the single object.
        /// </summary>
        /// <value>The single object.</value>
        /// <remarks></remarks>
        [DataMember]
        public MemberSuiteObject SingleObject { get; set; }

        /// <summary>
        /// Gets or sets the object search result.
        /// </summary>
        /// <value>The object search result.</value>
        /// <remarks></remarks>
        [DataMember]
        public ObjectSearchResult ObjectSearchResult { get; set; }

    }
}
