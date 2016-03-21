using System.Collections.Generic;
using MemberSuite.SDK.Manifests.Console;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Results
{
    /// <summary>
    /// </summary>
    /// <remarks></remarks>
    public class
        LoginResult
    {
        /// <summary>
        ///     Gets or sets the session token.
        /// </summary>
        /// <value>The session token.</value>
        /// <remarks></remarks>
        public string SessionID { get; set; }

        /// <summary>
        ///     Gets or sets the user.
        /// </summary>
        /// <value>The user.</value>
        /// <remarks></remarks>
        public MemberSuiteObject User { get; set; }

        /// <summary>
        ///     Gets or sets the accessible entities, if this is a portal login.
        /// </summary>
        /// <value>The accessible entities.</value>
        /// <remarks></remarks>
        public List<AccessibleEntity> AccessibleEntities { get; set; }

        /// <summary>
        ///     Gets or sets the portal user, if this was a portal login
        /// </summary>
        /// <value>The portal user.</value>
        /// <remarks></remarks>
        public MemberSuiteObject PortalUser { get; set; }

        /// <summary>
        ///     Gets or sets the portal entity, if this was a portal login
        /// </summary>
        /// <value>The portal entity.</value>
        /// <remarks></remarks>
        public MemberSuiteObject PortalEntity { get; set; }

        /// <summary>
        ///     Gets or sets the association.
        /// </summary>
        /// <value>The association.</value>
        /// <remarks></remarks>
        public MemberSuiteObject Association { get; set; }

        /// <summary>
        ///     Gets or sets the console metadata.
        /// </summary>
        /// <value>The console metadata.</value>
        /// <remarks></remarks>
        public ConsoleMetadata ConsoleMetadata { get; set; }

        /// <summary>
        ///     Gets or sets the user preferences.
        /// </summary>
        /// <value>The user preferences.</value>
        /// <remarks></remarks>
        public msUserPreferencesContainer UserPreferences { get; set; }

        public string Locale { get; set; }

        /// <summary>
        ///     Gets or sets the key chain.
        /// </summary>
        /// <value>The key chain.</value>
        /// <remarks></remarks>
        public KeyChain KeyChain { get; set; }

        /// <summary>
        ///     A token that you can use, along with the username, to automatically log in
        ///     to the system
        /// </summary>
        /// <value>The auto login has.</value>
        /// <remarks></remarks>
        public string AutoLoginHash { get; set; }

        /// <summary>
        ///     Gets or sets the member suite version.
        /// </summary>
        /// <value>The member suite version.</value>
        /// <remarks></remarks>
        public MemberSuiteVersion MemberSuiteVersion { get; set; }

        /// <summary>
        ///     Gets or sets the customer.
        /// </summary>
        /// <value>The customer.</value>
        /// <remarks></remarks>
        public MemberSuiteObject Customer { get; set; }

        /// <summary>
        /// </summary>
        /// <remarks></remarks>
        public class AccessibleEntity
        {
            /// <summary>
            ///     Gets or sets the ID.
            /// </summary>
            /// <value>The ID.</value>
            /// <remarks></remarks>
            public string ID { get; set; }

            /// <summary>
            ///     Gets or sets the name.
            /// </summary>
            /// <value>The name.</value>
            /// <remarks></remarks>
            public string Name { get; set; }

            /// <summary>
            ///     Gets or sets the type.
            /// </summary>
            /// <value>The type.</value>
            /// <remarks></remarks>
            public string Type { get; set; }
        }
    }
}