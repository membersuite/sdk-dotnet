using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Results
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public class ObjectSearchResult
    {
        /// <summary>
        /// Gets or sets the objects.
        /// </summary>
        /// <value>The objects.</value>
        /// <remarks></remarks>
        public List<MemberSuiteObject> Objects { get; set; }
        /// <summary>
        /// Gets or sets the total row count.
        /// </summary>
        /// <value>The total row count.</value>
        /// <remarks></remarks>
        public int TotalRowCount { get; set; }
    }
}
