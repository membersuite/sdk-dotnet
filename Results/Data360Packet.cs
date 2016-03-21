using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Results
{
    /// <summary>
    /// </summary>
    /// <remarks></remarks>
    [Serializable]
    [DataContract]
    public class Data360Packet
    {
        /// <summary>
        ///     Gets or sets a value indicating whether this instance has mail merge.
        /// </summary>
        /// <value><c>true</c> if this instance has mail merge; otherwise, <c>false</c>.</value>
        /// <remarks></remarks>
        [DataMember]
        public bool HasMailMerge { get; set; }

        /// <summary>
        ///     Gets or sets the applicable relationship types.
        /// </summary>
        /// <value>The applicable relationship types.</value>
        /// <remarks></remarks>
        [DataMember]
        public List<MemberSuiteObject> ApplicableRelationshipTypes { get; set; }

        /// <summary>
        ///     Gets or sets the applicable custom objects.
        /// </summary>
        /// <value>The applicable custom objects.</value>
        /// <remarks></remarks>
        [DataMember]
        public List<MemberSuiteObject> ApplicableCustomObjects { get; set; }

        /// <summary>
        ///     Gets or sets the integration links.
        /// </summary>
        /// <value>The integration links.</value>
        /// <remarks></remarks>
        [DataMember]
        public List<MemberSuiteObject> IntegrationLinks { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance can email.
        /// </summary>
        /// <value><c>true</c> if this instance can email; otherwise, <c>false</c>.</value>
        /// <remarks></remarks>
        [DataMember]
        public bool CanEmail { get; set; }
    }
}