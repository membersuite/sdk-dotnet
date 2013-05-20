using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Manifests.Command
{
    /// <summary>
    /// Represents a partial command definition - for use by the UI 
    /// in deciding how and when to display commands.
    /// </summary>
    [Serializable]
    [DataContract]
    public class PartialCommandDefinition
    {
        /// <summary>
        /// Gets or sets the name of the command
        /// </summary>
        /// <value>The name.</value>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        [DataMember]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is popup.
        /// </summary>
        /// <value><c>true</c> if this instance is popup; otherwise, <c>false</c>.</value>
        [DataMember]
        public CommandDefinition.CommandDisplayType DisplayType { get; set; }

        [DataMember]
        public string FirstView { get; set; }

      
    }
}
