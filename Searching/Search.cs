using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using MemberSuite.SDK.Manifests.Searching;
using MemberSuite.SDK.Searching.Operations;
using MemberSuite.SDK.Types;
using MemberSuite.SDK.Utilities;

namespace MemberSuite.SDK.Searching
{
    /// <summary>
    ///     Encapsulates all of the elements of a MemberSuite "search" - used by the
    ///     search engine to execute a search upon a search type.
    /// </summary>
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("Search", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]

    #region XML Includes

    [KnownType("registerKnownTypes")]
    [XmlInclude(typeof (WhereClause))]
    [XmlInclude(typeof (Contains))]
    [XmlInclude(typeof (DoesNotContain))]
    [XmlInclude(typeof (ContainsOneOfTheFollowing))]
    [XmlInclude(typeof (DoesNotContainOneOfTheFollowing))]
    [XmlInclude(typeof (Equals))]
    [XmlInclude(typeof (DoesNotEqual))]
    [XmlInclude(typeof (IsBlank))]
    [XmlInclude(typeof (IsNotBlank))]
    [XmlInclude(typeof (IsBetween))]
    [XmlInclude(typeof (IsNotBetween))]
    [XmlInclude(typeof (IsOneOfTheFollowing))]
    [XmlInclude(typeof (IsNotOneOfTheFollowing))]
    [XmlInclude(typeof (Keyword))]
    [XmlInclude(typeof (NoKeyword))]
    [XmlInclude(typeof (SpecialOperation))]
    [XmlInclude(typeof (IsGreaterThan))]
    [XmlInclude(typeof (IsGreaterThanOrEqualTo))]
    [XmlInclude(typeof (IsLessThan))]
    [XmlInclude(typeof (IsLessThanOrEqual))]
    [XmlInclude(typeof (RelativeDateTime))]
    [XmlInclude(typeof (RelativeDateTimeReferencePointType))]
    [XmlInclude(typeof (RelativeDateTimeUnitType))]
    [XmlInclude(typeof (StartsWith))]
    [XmlInclude(typeof (DoesNotStartWith))]
    [XmlInclude(typeof (EndsWith))]
    [XmlInclude(typeof (DoesNotEndWith))]
    [XmlInclude(typeof (EndsWithOneOfTheFollowing))]
    [XmlInclude(typeof (DoesNotEndWithOneOfTheFollowing))]
    [XmlInclude(typeof (StartsWithOneOfTheFollowing))]
    [XmlInclude(typeof (DoesNotStartWithOneOfTheFollowing))]

    #endregion

    [Serializable]
    [DataContract]
    public class Search : SearchOperationGroup, IMemberSuiteComponent
    {
        public Search()
        {
            OutputColumns = new List<SearchOutputColumn>();
            SortColumns = new List<SearchSortColumn>();
        }

        public Search(string type)
            : this()
        {
            Type = type;
        }

        //public Search(IsolationLevel isolationLevel)
        //    : this()
        //{
        //    IsolationLevel = isolationLevel;
        //}

        //public Search(IsolationLevel isolationLevel, string type)
        //    : this()
        //{
        //    Type = type;
        //    IsolationLevel = isolationLevel;
        //}

        //public Search(string type, string whereClause)
        //    : this(type)
        //{

        //    this.Criteria.Add(new WhereClause() { Clause = whereClause });
        //}

        /// <summary>
        ///     Gets or sets the type of search - i.e., Individual, Events, etc.
        /// </summary>
        /// <value>The type.</value>
        /// <remarks>The type must match up with a known Search Specification.</remarks>
        [DataMember]
        [XmlAttribute]
        public string Type { get; set; }

        [DataMember]
        [XmlAttribute]
        public string Context { get; set; }

        [DataMember]
        [XmlAttribute]
        public string CountField { get; set; }

        /// <summary>
        ///     INTERNAL USE ONLY - gets or set a search hint that allows the search engine to bypass
        ///     search construction and metadata retrieval
        /// </summary>
        /// <value>The search hint.</value>
        [DataMember]
        [XmlAttribute]
        public string Module { get; set; }

        [DataMember]
        [XmlAttribute]
        public bool UniqueResult { get; set; }

        [DataMember]
        [XmlAttribute]
        public bool ConsistentRead { get; set; }

        /// <summary>
        ///     Gets or sets the output columns.
        /// </summary>
        /// <value>The output columns.</value>
        [DataMember]
        [XmlArray("OutputColumns")]
        [XmlArrayItem("Column")]
        public List<SearchOutputColumn> OutputColumns { get; set; }

        /// <summary>
        ///     Gets or sets the sort fields.
        /// </summary>
        /// <value>The sort fields.</value>
        [DataMember]
        [XmlArray("SortColumns")]
        [XmlArrayItem("Column")]
        public List<SearchSortColumn> SortColumns { get; set; }

        /// <summary>
        ///     Gets or sets the type of the output.
        /// </summary>
        /// <value>The type of the output.</value>
        [DataMember]
        public string OutputFormat { get; set; }

        /// <summary>
        ///     Gets or sets the top N records to get.
        /// </summary>
        /// <value>The top number of rows to retrieve.</value>
        [DataMember]
        public int? TopN { get; set; }

        /// <summary>
        ///     Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        [XmlAttribute]
        [DataMember]
        public string Label { get; set; }

        [XmlArrayItem("Command")]
        [DataMember]
        public List<CommandShortcut> RowLevelCommands { get; set; }

        [XmlArrayItem("Command")]
        [DataMember]
        public List<CommandShortcut> Commands { get; set; }

        //public IsolationLevel? IsolationLevel { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="Search" /> is override.
        ///     For one-clicks in 360 metadata, this forces the system to use the specified search
        /// </summary>
        /// <value>
        ///     <c>true</c> if override; otherwise, <c>false</c>.
        /// </value>
        [XmlAttribute]
        [DataMember]
        public bool Override { get; set; }

        public string CalculateSearchHint()
        {
            var context = "";
            var type = Type;
            if (type != null)
                type = type.ToLower();

            // hack - we only care about context for Event and Competition Entries!
            if (Context != null)
            {
                if (string.Equals(Type, "RegistrationBase", StringComparison.CurrentCultureIgnoreCase) ||
                    string.Equals(Type, "EventRegistration", StringComparison.CurrentCultureIgnoreCase) ||
                    string.Equals(Type, "SessionRegistration", StringComparison.CurrentCultureIgnoreCase) ||
                    string.Equals(Type, "CompetitionEntry", StringComparison.CurrentCultureIgnoreCase))
                    context = Context.ToLower();

                // hack - we need to hint differently for this particular search type
                // this is an OPTIMIZATION, which is why it's necessary
                if (string.Equals(Type, "RelationshipsForARecord", StringComparison.CurrentCultureIgnoreCase))
                    context = Context.Substring(9, 4);
            }

            return string.Format("{0}|{1}|{2}", type, context, CalculateSearchHashCode());
        }

        public override int CalculateSearchHashCode()
        {
            var hashCode = base.CalculateSearchHashCode();

            hashCode += UniqueResult.GetHashCode();

            if (Type != null)
                hashCode += Type.GetHashCode();

            if (OutputColumns != null)
                OutputColumns.ForEach(x => hashCode += x.CalculateSearchHint());

            if (SortColumns != null)
                SortColumns.ForEach(x => hashCode += x.CalculateSearchHint());

            if(Criteria != null)
                Criteria.ForEach(x => hashCode += x.CalculateSearchHashCode());

            return hashCode;
        }

        /// <summary>
        ///     Generates a default search based on the manifest.
        /// </summary>
        /// <param name="searchManifest">The search manifest.</param>
        /// <returns></returns>
        public static Search FromManifest(SearchManifest searchManifest)
        {
            if (searchManifest == null) throw new ArgumentNullException("searchManifest");

            var s = new Search();
            s.Type = searchManifest.SearchType;
            s.Context = searchManifest.SearchContext;


            if (searchManifest.DefaultSelectedFields != null)
                foreach (var f in searchManifest.DefaultSelectedFields)
                    s.OutputColumns.Add(f.Clone());

            if (searchManifest.DefaultSortFieds != null)
                foreach (var sf in searchManifest.DefaultSortFieds)
                    s.SortColumns.Add(sf.Clone());

            return s;
        }

        public static Type[] registerKnownTypes()
        {
            var types = new List<Type>();

            types.Add(typeof (List<SearchOutputColumn>));

            foreach (var t in Assembly.GetExecutingAssembly().GetTypes())
                if (t.IsSubclassOf(typeof (SearchOperation)))
                    types.Add(t);

            types.Add(typeof (RelativeDateTime));
            types.Add(typeof (RelativeDateTimeReferencePointType));
            types.Add(typeof (RelativeDateTimeUnitType));
            return types.ToArray();
        }

        /// <summary>
        ///     Takes an order by string (i.e., FirstName DESC, ID) and
        ///     converts it to sortcolumns
        /// </summary>
        /// <param name="orderBy">The order by.</param>
        public void ParseOrderBy(string orderBy)
        {
            if (orderBy == null)
                return;

            if (SortColumns == null)
                SortColumns = new List<SearchSortColumn>();
            foreach (Match m in Regex.Matches(orderBy, RegularExpressions.OrderByParserRegex, RegexOptions.Compiled))
            {
                var ss = new SearchSortColumn();
                ss.Name = m.Groups[1].Value.Trim();

                ss.IsDescending = m.Groups[2].Success; // then there's a count match, because DESC was matched
                SortColumns.Add(ss);
            }
        }

        /// <summary>
        ///     Clones this instance.
        /// </summary>
        /// <returns></returns>
        public Search Clone()
        {
            return Binary.Deserialize<Search>(Binary.Serialize(this));
        }

        public void AddOutputColumn(string columnName)
        {
            OutputColumns.Add(new SearchOutputColumn {Name = columnName});
        }

        public override string ToString()
        {
            return string.Format("Search of type '{0}' with ID '{1}'", Type, ID);
        }

        #region Syntactic Sugar

        public void AddCriteria(SearchOperation op)
        {
            Criteria.Add(op);
        }

        public void AddSortColumn(string columnName)
        {
            AddSortColumn(columnName, false);
        }

        public void AddSortColumn(string columnName, bool isDescending)
        {
            SortColumns.Add(new SearchSortColumn {Name = columnName, IsDescending = isDescending});
        }

        #endregion
    }
}