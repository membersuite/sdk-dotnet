using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MemberSuite.SDK.Concierge;
using MemberSuite.SDK.Results;
using MemberSuite.SDK.Searching;

namespace MemberSuite.SDK.Utilities
{
    public static class SearchUtilities
    {
        /// <summary>
        /// Makes the necessary calls to the API to get all search results,
        /// since the API restricts the number of results that can come back in a search
        /// </summary>
        /// <param name="api">The API.</param>
        /// <param name="searchToRun">The search to run.</param>
        /// <returns></returns>
        /// <remarks>Use this wisely, as the resulting data table will be in memory and could grow large 
        /// depending on the search</remarks>
        public static SearchResult SearchAll(IConciergeAPIService api, Search searchToRun)
        {
            if (api == null) throw new ArgumentNullException("api");
            if (searchToRun == null) throw new ArgumentNullException("searchToRun");

            // let's get that first search result
            SearchResult sr = api.ExecuteSearch(searchToRun, 0, null).ResultValue;

            while (sr.Table.Rows.Count < sr.TotalRowCount)
            {
                // run the search again, starting from where we left off
                var intermediateResult = api.ExecuteSearch(searchToRun,
                    sr.Table.Rows.Count, null).ResultValue.Table;

                // now, take all the result,s add them to the table
                foreach (DataRow dr in intermediateResult.Rows)
                    sr.Table.ImportRow(dr); // bring the row over
            }

            return sr;
        }

    }
}
