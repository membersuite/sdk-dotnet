using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Manifests.Console
{
    /// <summary>
    ///     Defines available quick searches
    /// </summary>
    [Serializable]
    public class QuickSearch
    {
        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        [XmlAttribute]
        public string DisplayName { get; set; }

        public string ViewCommand { get; set; }

        /// <summary>
        ///     Gets or sets the columns.
        /// </summary>
        /// <value>The columns.</value>
        [XmlArrayItem("Column")]
        public List<QuickSearchColumn> Columns { get; set; }
    }
}