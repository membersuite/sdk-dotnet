using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Searching
{
    /// <summary>
    /// Specified output options for a search
    /// </summary>
    [Serializable]
    [DataContract]
    public class SearchOutputColumn
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

            if (DisplayName != null)
                hashCode += DisplayName.GetHashCode();

            hashCode += AggregateFunction.GetHashCode();

            return hashCode;
        }

        /// <summary>
        /// Gets or sets the name of the output field
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute()]
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        [XmlAttribute()]
        [DataMember]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the aggregate function.
        /// </summary>
        /// <value>The aggregate function.</value>
        [XmlAttribute()]
        [DataMember]
        public SearchOuputAggregate AggregateFunction { get; set; }

        [XmlAttribute()]
        [DataMember]
        public int ColumnWidth { get; set; }

        [XmlAttribute()]
        [DataMember]
        public bool Hidden { get; set; }

        public SearchOutputColumn Clone()
        {
            return new SearchOutputColumn
                       {
                           AggregateFunction = AggregateFunction,
                           ColumnWidth = ColumnWidth,
                           DisplayName = DisplayName,
                           Hidden = Hidden,
                           Name = Name
                       };
        }

        public override string ToString()
        {
            if (Name == null) return base.ToString();
            if (DisplayName == null) return Name;

            return string.Format("{0} <{1}>", DisplayName, Name );
            
        }
    }
}
