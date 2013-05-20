using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MemberSuite.SDK.Manifests.Searching;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Results
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public class QueryResult
    {
        /// <summary>
        /// Gets or sets the result objects.
        /// </summary>
        /// <value>The table.</value>
        /// <remarks></remarks>
        public List<MemberSuiteObject> Objects { get; set; }

        /// <summary>
        /// Gets or sets the total object count, not the count of objects being returned
        /// </summary>
        /// <value>The total row count.</value>
        /// <remarks>Very often the objects being returned will be a subset of the total objects - the TotalObjectCount count
        /// allows you to know how many objects there are, actually</remarks>
        public int TotalObjectCount { get; set; }
    }
}
