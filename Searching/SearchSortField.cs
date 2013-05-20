using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Searching
{
    [Serializable]
    [DataContract]
    public class SearchSortColumn
    {

        /// <summary>
        /// Calculates the search hint
        /// </summary>
        /// <returns></returns>
        /// <remarks> These are items in the class that change how the resultant query is run.</remarks>
        public int CalculateSearchHint()
        {
            int hashCode = 0;
            if (Name != null)
                hashCode += Name.GetHashCode();

            hashCode += IsDescending.GetHashCode();

            return hashCode;
        }
        /// <summary>
        /// Gets or sets the name of the field
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute()]
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is descending.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is descending; otherwise, <c>false</c>.
        /// </value>
        [XmlAttribute()]
        [DataMember]
        public bool IsDescending { get; set; }

        public SearchSortColumn Clone()
        {
            return new SearchSortColumn
                       {
                           Name = Name,
                           IsDescending = IsDescending
                       };
        }
    }
}
