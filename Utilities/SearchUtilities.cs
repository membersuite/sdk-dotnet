using System;
using System.Data;
using MemberSuite.SDK.Concierge;
using MemberSuite.SDK.Results;
using MemberSuite.SDK.Searching;

namespace MemberSuite.SDK.Utilities
{
    public static class SearchUtilities
    {
        /// <summary>
        ///     Makes the necessary calls to the API to get all search results,
        ///     since the API restricts the number of results that can come back in a search
        /// </summary>
        /// <param name="api">The API.</param>
        /// <param name="searchToRun">The search to run.</param>
        /// <returns></returns>
        /// <remarks>
        ///     Use this wisely, as the resulting data table will be in memory and could grow large
        ///     depending on the search
        /// </remarks>
        public static SearchResult SearchAll(IConciergeAPIService api, Search searchToRun)
        {
            if (api == null) throw new ArgumentNullException("api");
            if (searchToRun == null) throw new ArgumentNullException("searchToRun");

            // let's get that first search result
            var conciergeResult = api.ExecuteSearch(searchToRun, 0, null);

            if (!conciergeResult.Success)
                throw new ApplicationException(conciergeResult.FirstErrorMessage);

            var sr = conciergeResult.ResultValue;

            while (sr.Table.Rows.Count < sr.TotalRowCount)
            {
                // run the search again, starting from where we left off
                var intermediateExecuteSearchResult = api.ExecuteSearch(searchToRun,
                    sr.Table.Rows.Count, null);

                if (!intermediateExecuteSearchResult.Success)
                    throw new ApplicationException(intermediateExecuteSearchResult.FirstErrorMessage);

                var intermediateResult = intermediateExecuteSearchResult.ResultValue.Table;

                // now, take all the result,s add them to the table
                foreach (DataRow dr in intermediateResult.Rows)
                    sr.Table.ImportRow(dr); // bring the row over
            }

            return sr;
        }
    }
}