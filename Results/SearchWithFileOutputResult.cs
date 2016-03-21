using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using MemberSuite.SDK.Searching;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Results
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    /// 
    [DataContract]
    [Serializable]
    public class SearchWithFileOutputResult
    {
        /// <summary>
        /// The search result file
        /// </summary>
        /// <value>The objects.</value>
        /// <remarks></remarks>
        [DataMember]
        public byte[] Output { get; set; }

        /// <summary>
        /// Gets or sets the total row count, not the row count of rows in the table
        /// </summary>
        /// <value>The total row count.</value>
        /// <remarks>Very often the table will be a subset of the total rows - the row count
        /// allows you to know how many rows there are, actually</remarks>
        [DataMember]
        public int TotalRowCount { get; set; }


        [DataMember]
        public string OutputFileName { get; set; }
    }
}
