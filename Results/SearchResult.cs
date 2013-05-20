using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using MemberSuite.SDK.Manifests.Searching;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Results
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    [DataContract]
    [Serializable]
    public class SearchResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult"/> class.
        /// </summary>
        /// <remarks></remarks>
        public SearchResult()
        {
            ColumnMetadata = new ColumnMetadataDictionary();
        }


        /// <summary>
        /// Gets or sets the table.
        /// </summary>
        /// <value>The table.</value>
        /// <remarks></remarks>
        [DataMember]
        public DataTable Table { get; set; }

        /// <summary>
        /// Gets or sets the total row count, not the row count of rows in the table
        /// </summary>
        /// <value>The total row count.</value>
        /// <remarks>Very often the table will be a subset of the total rows - the row count
        /// allows you to know how many rows there are, actually</remarks>
        [DataMember]
        public int TotalRowCount { get; set; }

        /// <summary>
        /// Gets or sets the data types for the output fields, so that the
        /// user interface knows how to render them
        /// </summary>
        /// <value>The data types.</value>
        /// <remarks></remarks>
        [DataMember]
        public ColumnMetadataDictionary ColumnMetadata { get; set; }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>The ID.</value>
        /// <remarks></remarks>
        [DataMember]
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        /// <remarks></remarks>
        [DataMember]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the search manifest.
        /// </summary>
        /// <value>The search manifest.</value>
        /// <remarks></remarks>
        [DataMember]
        public SearchManifest SearchManifest { get; set; }
    }
}
