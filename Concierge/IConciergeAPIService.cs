using System;
using System.Collections.Generic;
using System.ServiceModel;
using MemberSuite.SDK.DuplicateDetection;
using MemberSuite.SDK.Jobs;
using MemberSuite.SDK.Manifests.Command;
using MemberSuite.SDK.Manifests.Command.Views;
using MemberSuite.SDK.Manifests.Console;
using MemberSuite.SDK.Manifests.CustomField;
using MemberSuite.SDK.Manifests.Reporting;
using MemberSuite.SDK.Manifests.Searching;
using MemberSuite.SDK.Results;
using MemberSuite.SDK.Searching;
using MemberSuite.SDK.Types;
using MemberSuite.SDK.Types.KPIs;

namespace MemberSuite.SDK.Concierge
{

    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    [ServiceContract(Namespace = "http://membersuite.com/contracts")]
    public interface IConciergeAPIService : IDisposable
    {
        #region Security

        /// <summary>
        /// Uses the URL of a portal to locate portal information.
        /// </summary>
        /// <param name="hostName">The url to review. Be sure to exclude protocol headers (i.e., use customername.customer,com without the http:// or https://)</param>
        /// <returns>The portal information for associated URL.</returns>
        /// <type>Security</type>
        /// <remarks>This method is useful in a situation where you don't necessarily know the association that is
        /// usingthe portal - for instance, if you're writing generic code intended to be used by more than one instance
        /// of a MemberSuite. MemberSuite assigns each customer a unique URL for thier portal; furthermore, customers have
        /// the ability to indicate a "custom" portal URL. Based on this information, you can read the incoming HTTP request
        /// information to determine the URL being referenced, and then pass the URL to this funciton. If you don't have the
        /// URL, but have the portal ID, then use <service name="RetrievePortalInformationByID"/></remarks>
        [OperationContract]
        ConciergeResult<PortalInformation> RetrievePortalInformationByUrl(string hostName);


        /// <summary>
        /// Retrieves information about a customer's portal settings by the ID ofthe association
        /// </summary>
        /// <returns>The portal information for the logging in portal user.</returns>
        /// <type>Security</type>
        /// <remarks>There is no parameter, because the ID of the currently logged in association is used. Based on the currently logged
        /// in association, a packet ofinformation useful for configuring the portal is returned.</remarks>
        [OperationContract]
        ConciergeResult<PortalInformation> RetrievePortalInformationByID();

        /// <summary>
        /// Gets the access level of a specific record forthe current logged in user
        /// </summary>
        /// <param name="recordID">The ID of the record to examine</param>
        /// <returns>An <enum name="SecurityLockAccessLevel"/> value representing the access that the current logged
        /// in user has to the specified record.</returns>
        /// <remarks>When you're using record level security, this method allows you to determine whether the logged in
        /// user has access to a record <i>without</i> having to load the record.</remarks>
        [OperationContract]
        ConciergeResult<SecurityLockAccessLevel> GetRecordPermission(string recordID);

        /// <summary>
        /// Logs in a user with the username and password.
        /// </summary>
        /// <param name="userName">Username/login.</param>
        /// <param name="password">The password for the user.</param>
        /// <param name="loginDestination">The ID of the association that the user should be logged into. If no ID is specified, then the logic is as follows:
        /// <ul type="Numbered">
        /// 		<li>If the <domainobject name="User.LastAssociation"/> is set, then that association is used for login</li>
        /// 		<li>If the user is a <domainobject name="CustomerUser"/>, then the first association for that customer will be used as the login destination</li>
        /// 		<li>If none of the above are true, then no association set set for the logged in user, and any functions that require a logged in association
        /// will not work until an association is chosed.</li>
        /// 	</ul></param>
        /// <returns></returns>
        /// <type>Security</type>
        /// <remarks>This method is intended to be run for console users - if you are attempting to login a <domainboject name="PortalUser"/>,
        /// then refer to <service name="LoginToPortal"/>.</remarks>
        [OperationContract]
        ConciergeResult<LoginResult> Login(string userName, string password, string loginDestination);

        /// <summary>
        /// Resets the password for a specified user.
        /// </summary>
        /// <param name="userID">The ID of the user whose password you need to reset</param>
        /// <param name="newPassword">The new password</param>
        /// <returns>Returns a <object name="ConciergeResult"/> indicating whether or not the operation was successful.</returns>
        /// <type>Security</type>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult ResetPassword(string userID, string newPassword);

        /// <summary>
        /// Sends a welcome email to a portal user
        /// </summary>
        /// <param name="portalUserId">The ID of the portal user</param>
        /// <param name="emailAddress">The email to send the welcome to.</param>
        /// <returns></returns>
        /// <type>Security</type>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult SendWelcomePortalUserEmail(string portalUserId, string emailAddress);

        /// <summary>
        /// Sends a forgotten password email to a portal user
        /// </summary>
        /// <param name="portalUserName">The ID of the portal user</param>
        /// <param name="nextUrl">The URL that the user should be sent to <i>after</i> they reset their password.</param>
        /// <returns></returns>
        /// <type>Security</type>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult SendForgottenPortalPasswordEmail(string portalUserName, string nextUrl);

        /// <summary>
        /// Retrieves the portal user associated with an <domainobject name="Entity"/>, or creates it if none
        /// exists.
        /// </summary>
        /// <param name="entityId">The entity being examined</param>
        /// <returns>The portal</returns>
        /// <type>Security</type>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<msPortalUser> GetOrCreatePortalUserForEntity(string entityId);

        /// <summary>
        /// Searches the and get or create portal user.
        /// </summary>
        /// <param name="loginIDOrEmail">The login ID or email.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<msPortalUser> SearchAndGetOrCreatePortalUser(string loginIDOrEmail);

        /// <summary>
        /// Allows for a login with a saved hash, allowing for "auto-login" and
        /// "remember-me" operations
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="hash">The hash to use.</param>
        /// <returns>Returns the LoginResult corresponding to the logged in user, or a ConciergeResult with Success set to false
        /// if the login was unsuccessful.</returns>
        /// <type>Security</type>
        /// <remarks>When you run the <service name="Login"/> method, you are given a hash via <object name="LoginResult.AutoLoginHash"/></remarks>
        [OperationContract]
        ConciergeResult<LoginResult> LoginWithHash(string userName, string hash);


        /// <summary>
        /// Allows you to log a portal user into MemberSuite using a saved hash
        /// </summary>
        /// <param name="portalUserName">The portal user's login ID/name</param>
        /// <param name="hash">The hash</param>
        /// <returns>Success=true if the login is successful.</returns>
        /// <type>Security</type>
        /// <remarks>When ever you login, an <object name="LoginResult.AutoLoginHash"/> is returned. You
        /// can store this hash awway and allow the user to login automaticlaly in the future.</remarks>
        [OperationContract]
        ConciergeResult<LoginResult> LoginPortalUserWithHash(string portalUserName, string hash);

        /// <summary>
        /// Logs a portal user into an association
        /// </summary>
        /// <param name="portalUserName">The user name of the portal user</param>
        /// <param name="portalPassword">The password of the portal user</param>
        /// <returns></returns>
        /// <type>Security</type>
        /// <remarks>This method does <i>not</i> require a X.509 certificate because the password of the user is provided</remarks>
        [OperationContract]
        ConciergeResult<LoginResult> LoginToPortal(string portalUserName, string portalPassword);

        /// <summary>
        /// Creates the temporary access key.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <param name="secretAccessKey">The secret access key.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> CreateTemporaryAccessKey(string userName, string password, byte[] secretAccessKey);

        /// <summary>
        /// Creates the temporary access key with hash.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="hash">The hash.</param>
        /// <param name="secretAccessKey">The secret access key.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> CreateTemporaryAccessKeyWithHash(string userName, string hash, byte[] secretAccessKey);

        /// <summary>
        /// Creates the portal security token.
        /// </summary>
        /// <param name="portalUserName">Name of the portal user.</param>
        /// <param name="signingCertificateId">The signing certificate id.</param>
        /// <param name="signature">The signature.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<byte[]> CreatePortalSecurityToken(string portalUserName, string signingCertificateId,
                                                          byte[] signature);

        /// <summary>
        /// Creates the console security token.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="signingCertificateId">The signing certificate id.</param>
        /// <param name="signature">The signature.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<byte[]> CreateConsoleSecurityToken(string userId, string signingCertificateId, byte[] signature);

        /// <summary>
        /// Logins the with token.
        /// </summary>
        /// <param name="securityToken">The security token.</param>
        /// <param name="signingCertificateId">The signing certificate id.</param>
        /// <param name="signature">The signature.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<LoginResult> LoginWithToken(byte[] securityToken, string signingCertificateId, byte[] signature);

        /// <summary>
        /// Changes the password of the current logged in user
        /// </summary>
        /// <param name="oldPassword">The old password</param>
        /// <param name="newPassword">The new password to change</param>
        /// <returns>Returns Success=false if the old password does not authenticate; otherwise returns Success=true.</returns>
        /// <type>Security</type>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult ChangePassword(string oldPassword, string newPassword);

        /// <summary>
        /// Switches from one association to another
        /// </summary>
        /// <returns>Success=true if the switch was successful; otherwise Success=false;</returns>
        /// <type>Security</type>
        /// <remarks>Even though the association Id is included in the header of each API call, you <i>must</i> call this
        /// method if you are changing from one association to another.</remarks>
        [OperationContract]
        ConciergeResult<LoginResult> SwitchAssociation();

        /// <summary>
        /// Logs the currently logged in user out of MemberSuite
        /// </summary>
        /// <returns></returns>
        /// <type>Security</type>
        /// <remarks></remarks>
        [OperationContract]
        LoginResult Logout();

        /// <summary>
        /// Records that a particular record was accessed
        /// </summary>
        /// <param name="recordID">The record that has been access</param>
        /// <param name="cmd">The command used to access it</param>
        /// <returns></returns>
        /// <remarks>This method will automatically update the Recent Items list of the currently logged in user
        /// with the specified record. If the record is locked, then this method will automatically generate an audit log indicating
        /// that the record was viewed.</remarks>
        [OperationContract]
        ConciergeResult<List<CommandShortcut>> RecordRecordAccess(string recordID, CommandShortcut cmd);

        /// <summary>
        /// Records an error that has occurred in your system
        /// </summary>
        /// <param name="description">A description of the error</param>
        /// <returns></returns>
        /// <remarks>This method will write an <domainobject name="AuditLog"/> out to the currently logged in association's instance of type <enum type="AuditLogType.Error"/>.
        /// Use this method when you only need to log a generic error/description. If you need finer control over the audit log that
        /// is written, then you should use <service name="RecordErrorAuditLog"/>.</remarks>
        [OperationContract]
        ConciergeResult RecordError(string description);

        /// <summary>
        /// Records an error that has occurred in your system with a full audit log
        /// </summary>
        /// <param name="msoErrorAuditLog">The audit log to save</param>
        /// <returns></returns>
        /// <type>Database</type>
        /// <remarks>This method differs from <service name="RecordError"/> in that you have the opportunity to persist a full
        /// <objcet name="AuditLog"/>. Because audit logs are not persistable by default, you must use this method to write one
        /// to the database. Also - the audit log you specify here must be of type <enum name="AuditLogType.Error"/>.</remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> RecordErrorAuditLog(MemberSuiteObject msoErrorAuditLog);


        /// <summary>
        /// Allows you to record the progress of a <object name="CustomJob"/>.
        /// </summary>
        /// <param name="jobID">The ID of the job you would like to update</param>
        /// <param name="additionalLogText">The additional log text to append to thelog</param>
        /// <param name="newStatus">The new status to assign to the job, if applicable</param>
        /// <returns></returns>
        /// <type>Database</type>
        /// <remarks><p>Because the <domainobject name="CustomJob"/>is persistable, you are free to create and save them.  However,
        /// you may find instances in which a job log is extremely long - say, when processing 10,000 records - and loading the
        ///   <domainobject name="CustomJob"/> record, appending a line, and saving it throug the UI will prove to be inefficient. This
        /// method circumvents this process by using an optimized database write that eliminates the need to load the job from the system.
        ///   </p>
        ///   <p>Additionally, you can change the status at the same time you are recording progress. The keeps you from having to load
        /// the entire job, plus the log, from the database simple to flip the status to <enum name="JobStatus.Completed"/>. This is optional
        /// and usually done only when the job is complete, or when the job encounters an error.</p></remarks>
        [OperationContract]
        ConciergeResult RecordJobProgress(string jobID, string additionalLogText, JobStatus? newStatus);

        /// <summary>
        /// Returns a list of all users that can access the logged in association
        /// </summary>
        /// <returns>A list of users that can access the logged in association</returns>
        /// <type>Security</type>
        /// <remarks>This method will determine all <domainobject name="CustomerUser"/> records that have access to the
        /// currently logging in association. An example of where this is useful is providing a list of users that can be
        /// assigned to a <domainobject name="Task"/> or <domainobject name="Activity"/>.</remarks>
        [OperationContract]
        ConciergeResult<List<MemberSuiteObject>> GetAllUsersThanCanAccessCurrentAssociation();

        /// <summary>
        /// Returns a <oject name="LoginResult"/> for the currently logged in user and association.
        /// </summary>
        /// <returns></returns>
        /// <type>Security</type>
        /// <remarks>This is usually the first command you run to establish a session and learn about
        /// the currently logged in user and association. See the code samples for usage techniques.</remarks>
        [OperationContract]
        ConciergeResult<LoginResult> WhoAmI();

        /// <summary>
        /// Returns a list of all entities that an entity can access
        /// </summary>
        /// <param name="entityId">The entity to query</param>
        /// <returns></returns>
        /// <type>Security</type>
        /// <remarks>An <domainobject name="Entity"/> in MemberSuite can often access other entities, usually via a
        /// <domainobject name="Relationship"/> where the <domainobject name="RelationshipType.EnablePortalManagement"/> is
        /// set to true. Call this method if you need to determine what other entities an entity can login as.</remarks>
        [OperationContract]
        ConciergeResult<List<LoginResult.AccessibleEntity>> GetAccessibleEntitiesForEntity(string entityId);

        #endregion

        #region Metadata

        /// <summary>
        /// Gets the association configuration information
        /// </summary><type>Metadata</type>
        /// <returns></returns>
        /// <remarks>All association-level configuration is stored in a single <domainobject name="AssociationConfigurationContainer"/>. This method
        /// allows you to easily retrive this information for the logged in asociation.</remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> GetAssociationConfiguration();

        /// <summary>
        /// Adds a favorite command to a user preferences account.
        /// </summary><type>Metadata</type>
        /// <param name="cmd">The command to add.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<CommandShortcut>> AddFavorite(CommandShortcut cmd);

        /// <summary>
        /// Gets user preferences.
        /// </summary><type>Metadata</type>
        /// <returns></returns>
        /// <remarks>This method will retrieve a <domainobject name="UserPreferencesContainer"/> for the current logged in user.
        /// Note that a user may only have one such set of preferences.</remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> GetUserPreferences();

        /// <summary>
        /// Gets the definition for a command.
        /// </summary><type>Metadata</type>
        /// <param name="commandName">Name of the command.</param>
        /// <returns></returns>
        /// <remarks>For a user interface command, this method returns the command definition XML.</remarks>
        [OperationContract]
        ConciergeResult<CommandDefinition> GetCommandDefinition(string commandName);

        /// <summary>
        /// Gets all commands with a partial definition
        /// </summary><type>Metadata</type>
        /// <returns></returns>
        /// <remarks>The service is important because it lets the UI make decisions about
        /// whether a command is a popup or not, or what the name is, without
        /// having to actually call the API.</remarks>
        [OperationContract]
        ConciergeResult<List<PartialCommandDefinition>> GetAllCommands();

        /// <summary>
        /// Gets the console metadata for the currently logged in user.
        /// </summary><type>Metadata</type>
        /// <returns></returns>
        /// <remarks>This is used internally by MemberSuite to get tabs, keychain security, etc.</remarks>
        [OperationContract]
        ConciergeResult<ConsoleMetadata> GetConsoleMetadata();


        /// <summary>
        /// Describes an object, including it's parent types, fields, and field definitions
        /// </summary><type>Metadata</type>
        /// <param name="objectType">The type of object to describe. Custom objects are allowed as a parameter.</param>
        /// <returns></returns>
        /// <remarks>This method allows you to learn how an object is structure for the logged in association. Since
        /// an association can create custom fields, or modify built-in fields, it's important to get the
        /// <object name="ClassMetadata"/> for an object before constructing the object. One of the most important
        /// reasons is that the <object name="ClassMetadata"/> specifies default values for objects that are created.</remarks>
        [OperationContract]
        ConciergeResult<ClassMetadata> DescribeObject(string objectType);

        /// <summary>
        /// Describes the object built in fields.
        /// </summary><type>Metadata</type>
        /// <param name="objectType">Type of the object.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<ClassMetadata> DescribeObjectBuiltInFields(string objectType);

        /// <summary>
        /// Gets the default dashboard for the logged in user.
        /// </summary><type>Metadata</type>
        /// <param name="nameOfCommand">The name of command.</param>
        /// <param name="context"  optional="true">The context.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<DashboardMetadata> GetDefaultDashboard(string nameOfCommand, string context);

        //[OperationContract]
        // This is an unncessary (and large) service, I think ConciergeResult<List<ClassMetadata>> DescribeAllObjects();

        /// <summary>
        /// Gets the default data entry page layout for the specified object.
        /// </summary><type>Metadata</type>
        /// <param name="objectType">Type of the object.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<DataEntryViewMetadata> GetDefaultDataEntryPageLayout(string objectType);

        /// <summary>
        /// Gets the default portal page layout for the specified object.
        /// </summary><type>Metadata</type>
        /// <param name="objectType">Type of the object.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<DataEntryViewMetadata> GetDefaultPortalPageLayout(string objectType);


        /// <summary>
        /// Gets the default 360 page layout for the specified object.
        /// </summary><type>Metadata</type>
        /// <param name="objectType">Type of the object.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<Data360ViewMetadata> GetDefaultData360PageLayout(string objectType);

        /// <summary>
        /// Updates the class metadata for the specified object type/
        /// </summary><type>Metadata</type>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="metadataToSave">The metadata to save.</param>
        /// <returns></returns>
        /// <remarks>Use this method to update built-in fields for an object.</remarks>
        [OperationContract]
        ConciergeResult UpdateClassMetadata(string objectType, ClassMetadataOverride metadataToSave);

        /// <summary>
        /// Lists all  objects in the system, including custom objects
        /// </summary><type>Metadata</type>
        /// <param name="includeAbstract">if set to <c>true</c> abstract objects are included in the list.</param>
        /// <param name="baseObjectType" optional="true">Type of the base object to use. Leave this as null for all objects.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<PartialObjectDefinition>> ListAllObjects(bool includeAbstract, string baseObjectType);

        /// <summary>
        /// Determines the type of the object based on the object ID.
        /// </summary><type>Metadata</type>
        /// <param name="objectID">The object ID to interrogate</param>
        /// <returns></returns>
        /// <remarks>MemberSuite can easily tell what type an object is, and what association it belongs to, based on it's ID. Call
        /// this method if you have an object ID, and need to know what type it is. This method will also properly return
        /// custom objects by name.</remarks>
        [OperationContract]
        ConciergeResult<string> DetermineObjectType(string objectID);

        /// <summary>
        /// Updates the custom field definition, optionally updating page layouts at the same time.
        /// </summary><type>Metadata</type>
        /// <param name="packet">The custom field creation packet to use for the update.</param>
        /// <returns></returns>
        /// <remarks>While you can save custom fields directly via the <domainobject name="CustomField"/> class, often
        /// you want to place the fields directly on page layouts at the same time you save them. This method allows you
        /// to do this.</remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> UpdateCustomField(CustomFieldCreationPacket packet);

        /// <summary>
        /// Updates the tabs for the currently logged in user.
        /// </summary><type>Metadata</type>
        /// <param name="newTabs">The new tabs.</param>
        /// <returns></returns>
        /// <remarks>This method will clear out any existing tabs and replace them with the tabs specified. Pass in an empty list
        /// to clear out the current user's custom tabs.</remarks>
        [OperationContract]
        ConciergeResult UpdateTabs(List<Tab> newTabs);

        /// <summary>
        /// Updates the preferences for the current user.
        /// </summary><type>Metadata</type>
        /// <param name="preferences">The preferences to update.</param>
        /// <returns></returns>
        /// <remarks>This method will only act on preferences listed in the parameters; submitting an empty list
        /// will do nothing. User preferences are custom settings defined by the UI; you should feel free to use
        /// this method to store application-specific preferences for users, provided you use a suitable namespace
        /// to avoid collision of preference keys. In other words, you should have a preference named <b>acme.it.customwork.defaultPage</b>,
        /// instead of just <b>defaultPage.</b></remarks>
        [OperationContract]
        ConciergeResult UpdatePreferences(List<NameValueStringPair> preferences);

        /// <summary>
        /// Updates the association settings for the current association.
        /// </summary><type>Metadata</type>
        /// <param name="newSettings">The new settings.</param>
        /// <returns></returns>
        /// <obsolete>This methid is obsolete and should not be used. Use <service name="SetConfigurationSetting"/> instead.</obsolete>
        [OperationContract]
        ConciergeResult UpdateAssociationSettings(List<NameValueStringPair> newSettings);

        /// <summary>
        /// Executes a search for a 360 screen.
        /// </summary><type>Metadata</type>
        /// <param name="primarySearch">The primary search.</param>
        /// <param name="oneClicks">The one clicks.</param>
        /// <returns></returns>
        /// <remarks>This method is used by the MemberSuite UI to execute a parallel search set for the 360 screen. The <param name="primarySearch"/> is
        /// the main record being looked for, and the <param name="oneClicks"/> are the related queries. The API will attempt to
        /// execute these queries in parallel for better performance than executing them in serial. Additionally, the <object name="Date360Packet"/> 
        /// returned will have information that will aid in creating a 360 screen of your own, including whether any relevent relationship types
        /// exist, or any custom objects tied to the target type should be displayed.</remarks>
        [OperationContract]
        ConciergeResult<Data360Packet> Get360Packet(Search primarySearch, List<Search> oneClicks);


        #endregion

        #region Database

        /// <summary>
        /// Saves the specified MemberSuite object to the database.
        /// </summary><type>Database</type>
        /// <param name="objectToSave">The object to save.</param>
        /// <returns></returns>
        /// <remarks>This method will save the object and generate an audit log. Note that the audit log generation is queued
        /// and may appear several seconds after the actual save.</remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> Save(MemberSuiteObject objectToSave);

        /// <summary>
        /// Gets a record with the specified id.
        /// </summary><type>Database</type>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> Get(string id);

        /// <summary>
        /// Queries the specified object type.
        /// </summary><type>Database</type>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="whereClause">The where clause.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="startIndex">The start index.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <obsolete>Query is an obsolete service call; use GetObjectsBySearch instead. This method will be removed in July 2012.</obsolete>
        [OperationContract]
        [Obsolete("Query is an obsolete service call; use GetObjectsBySearch instead. This method will be removed in May 2012.")]
        ConciergeResult<QueryResult> Query(string objectType, string whereClause, string orderBy, int startIndex);

        /// <summary>
        /// Gets an object from the database by search.
        /// </summary><type>Database</type>
        /// <param name="searchToUse">The search to use.</param>
        /// <param name="fieldToUseAsObjectIdentifier" optional="true">The field to use as object identifier.</param>
        /// <returns></returns>
        /// <remarks>
        /// <p>
        /// Very often, you'll need to return an object not by it's ID, but by an arbitrary search criteria. Use this method
        /// when you need to get a single object back from the database based on a criteria. Use <service name="GetObjectsBySearch"/>
        /// when you need to retrieve multiple objects.
        /// </p>
        /// <p>Note that you can achieve the same result by running <service name="ExecuteMSQL"/> with the <B>OBJECT()</B> parameter. For example:
        /// <code>select OBJECT() from Individual where Email='operations@membersuite.com'</code>
        /// <p>The above code would pull the first object with the specified email address.</p>
        /// </p>
        /// <p>You may not always want to use the ID field as the basis for getting the object. For instance, in the example above,
        /// you might want to pull the primary organization. Use the <param name="fieldToUseAsObjectIdentifier"/> to indicate what field
        /// the API should use to pull the object. For instance, specifiying <b>PrimaryOrganization</b> as the <param name="fieldToUseAsObjectIdentifier"/>
        /// would return an Organization, not the Individual. By default, the system will assume you want to use <B>ID</B>, if you don't specify a parameter.
        /// </p>
        ///  </remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> GetObjectBySearch(Search searchToUse, string fieldToUseAsObjectIdentifier);

        /// <summary>
        /// Gets multiple objects from the database by search.
        /// </summary><type>Database</type>
        /// <param name="searchToUse">The search to use.</param>
        /// <param name="fieldToUseAsObjectIdentifier">The field to use as object identifier.</param>
        /// <param name="startRecord">The start record.</param>
        /// <param name="maximumNumberOfRecordsToReturn">The maximum number of records to return.</param>
        /// <returns></returns>
        /// <remarks>
        /// <p>
        /// Very often, you'll need to return objects not by their ID, but by an arbitrary search criteria. Use this method
        /// when you need to get objects back from the database based on a criteria. Use <service name="GetObjectBySearch"/>
        /// when you need to retrieve a single object.
        /// </p>
        /// <p>Note that you can achieve the same result by running <service name="ExecuteMSQL"/> with the <B>OBJECTS()</B> parameter. For example:
        /// <pre>
        /// <code>select OBJECTS() from Individual where Email='operations@membersuite.com'</code>
        /// </pre>
        /// <p>The above code would pull the all objects with the specified email address.</p>
        /// </p>
        /// <p>You may not always want to use the ID field as the basis for getting the object. For instance, in the example above,
        /// you might want to pull the primary organization. Use the <paramref name="fieldToUseAsObjectIdentifier"/> to indicate what field
        /// the API should use to pull the object. For instance, specifying <b>PrimaryOrganization</b> as the <paramref name="fieldToUseAsObjectIdentifier"/>
        /// would return an Organization, not the Individual. By default, the system will assume you want to use <B>ID</B>, if you don't specify a parameter.
        /// </p></remarks>
        [OperationContract]
        ConciergeResult<ObjectSearchResult> GetObjectsBySearch(Search searchToUse, string fieldToUseAsObjectIdentifier, int startRecord, int? maximumNumberOfRecordsToReturn);


        /// <summary>
        /// Queries the single.
        /// </summary><type>Database</type>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="whereClause">The where clause.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <obsolete>Query is an obsolete service call; use GetObjectsBySearch instead. This method will be removed in July 2012.</obsolete>
        [OperationContract]
        [Obsolete("QuerySingle is an obsolete service call; use GetObjectBySearch instead. This method will be removed in May 2012.")]
        ConciergeResult<MemberSuiteObject> QuerySingle(string objectType, string whereClause);

        /// <summary>
        /// Provides a url to be used to download a file from the database.
        /// </summary><type>Database</type>
        /// <param name="fileID">The file ID.</param>
        /// <returns></returns>
        /// <remarks>Once you have this URL, you can use methods in your language to actually download the file from the specified ID.</remarks>
        [OperationContract]
        ConciergeResult<string> DownloadFile(string fileID);

        /// <summary>
        /// Gets the name of an object.
        /// </summary><type>Database</type>
        /// <param name="recordID">The record ID.</param>
        /// <returns></returns>
        /// <remarks>This method is optimized to quickly return the name of a specific object from the database. It's faster than downloading the
        /// entire object. Use <service name="GetNames"/> to pull multiple names.</remarks>
        [OperationContract]
        ConciergeResult<string> GetName(string recordID);

        /// <summary>
        /// Gets the names of specific objects from the database.
        /// </summary><type>Database</type>
        /// <param name="recordID">The record ID.</param>
        /// <returns>A list of names. If a record cannot be found, a null entry will be placed in the list.</returns>
        /// <remarks>This method is optimized to quickly return the name of a specific objects from the database. It's faster than downloading the
        /// entire object. Use <service name="GetName"/> to pull a single name.</remarks>
        [OperationContract]
        ConciergeResult<List<string>> GetNames(List<string> recordID);

        /// <summary>
        /// Gets all auto number seeds.
        /// </summary><type>Database</type>
        /// <returns></returns>
        /// <remarks>Auto-number seeds are the LocalID seeds for objects in the database that have a MemberSuite-generated numeric ID. This
        /// methods gives a list of all such seeds.</remarks>
        [OperationContract]
        ConciergeResult<List<AutoNumberSeedInfo>> GetAllAutoNumberSeeds();

        /// <summary>
        /// Deletes a record with the specified id.
        /// </summary><type>Database</type>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult Delete(string id);

        /// <summary>
        /// Gets the auto number seed info for a specific object.
        /// </summary><type>Database</type>
        /// <param name="objectName">Name of the object.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<AutoNumberSeedInfo> GetAutoNumberSeedInfo(string objectName);

        /// <summary>
        /// Updates the auto number seed for the specified object.
        /// </summary><type>Database</type>
        /// <param name="objectName">Name of the object.</param>
        /// <param name="newSeed">The new seed.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult UpdateAutoNumberSeed(string objectName, long newSeed);

        /// <summary>
        /// Performs a mass update of system records
        /// </summary><type>Database</type>
        /// <param name="recordType">Type of the record.</param>
        /// <param name="recordIdentifiers">The record identifiers.</param>
        /// <param name="msoNewValues">The new values.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult MassUpdate(string recordType, List<string> recordIdentifiers, MemberSuiteObject msoNewValues);

        /// <summary>
        /// Performs a mass delete of system records
        /// </summary><type>Database</type>
        /// <param name="recordType">Type of the record.</param>
        /// <param name="recordIdentifiers">The record identifiers.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult MassDelete(string recordType, List<string> recordIdentifiers);

        /// <summary>
        /// Masses the assign entitlements.
        /// </summary><type>Database</type>
        /// <param name="msoEntitlement">The entitlement.</param>
        /// <param name="idsToAssign">The ids to assign.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult MassAssignEntitlements(MemberSuiteObject msoEntitlement, List<string> idsToAssign);

        #endregion

        #region Seach Service


        /// <summary>
        /// Describes a search.
        /// </summary><type>Search</type>
        /// <param name="searchType">Type of the search.</param>
        /// <param name="searchContext" optional="true">The search context.</param>
        /// <returns></returns>
        /// <remarks>Describing a search lists all of the fields and relevant information for a search type. The <param name="searchContext"/> is optional
        /// and should only be used in cases where a contextual search is relevant (for instance, searching for <domainobject name="EventRegistration"/>
        /// in the context of an <domainobject name="Event"/></remarks>
        [OperationContract]
        ConciergeResult<SearchManifest> DescribeSearch(string searchType, string searchContext);

        /// <summary>
        /// Gets the search field metadata from full path.
        /// </summary><type>Search</type>
        /// <param name="searchType">Type of the search.</param>
        /// <param name="searchContext">The search context.</param>
        /// <param name="fieldFullPaths">The field full paths.</param>
        /// <returns></returns>
        /// <remarks>This method allows you to quick extract field metadata from a search "path". For instance, if you were looking up
        /// <B>Individual.PrimaryOrganization.ParentOrganization__rtg.TaxID__c</B>, you might need to quickly pull the field metadata
        /// for this field without needed to run a full <service name="DescribeCompiledSearch"/>. In such a case, use this method.</remarks>
        [OperationContract]
        ConciergeResult<List<FieldMetadata>> GetSearchFieldMetadataFromFullPath(string searchType, string searchContext,
                                                              List<string> fieldFullPaths);

        /// <summary>
        /// Executes a search.
        /// </summary><type>Search</type>
        /// <param name="searchToExecute">The search to execute.</param>
        /// <param name="startRecord">The start record.</param>
        /// <param name="maximumNumberOfRecordsToReturn" optional="true">The maximum number of records to return.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<SearchResult> ExecuteSearch(Search searchToExecute, int startRecord, int? maximumNumberOfRecordsToReturn);

        /// <summary>
        /// Executes the MSQL statement.
        /// </summary><type>Search</type>
        /// <param name="msqlStatement">The MSQL statement.</param>
        /// <param name="startRecord">The start record.</param>
        /// <param name="maximumNumberOfRecordsToReturn" optional="true">The maximum number of records to return.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MSQLResult> ExecuteMSQL(string msqlStatement, int startRecord, int? maximumNumberOfRecordsToReturn);

        /// <summary>
        /// Converts the specified MQL to a search object.
        /// </summary><type>Search</type>
        /// <param name="msqlStatement">The MSQL statement.</param>
        /// <returns></returns>
        /// <remarks>Lots of methods take a Search object, not MSQL, and so you can use this method to take a simple MSQL script and convert
        /// it to a bona fide search object for consumption by various Concierge services.</remarks>
        [OperationContract]
        ConciergeResult<Search> ConvertMQLToSearch(string msqlStatement);

        /// <summary>
        /// Executes multiple searches in parallel.
        /// </summary><type>Search</type>
        /// <param name="searchesToExecute">The searches to execute.</param>
        /// <param name="startRecord">The start record.</param>
        /// <param name="maximumNumberOfRecordsToReturn" optional="true">The maximum number of records to return.</param>
        /// <returns></returns>
        /// <remarks>This method will run multiple searches in parallel and return the result. It is designed to be faster than running
        /// the searches in multiple API calls.</remarks>
        [OperationContract]
        ConciergeResult<List<SearchResult>> ExecuteSearches(List<Search> searchesToExecute, int startRecord, int? maximumNumberOfRecordsToReturn);

        /// <summary>
        /// Describes a compiled search, including any references fields that are cross-object.
        /// </summary><type>Search</type>
        /// <param name="searchToInspect">The search to inspect.</param>
        /// <returns></returns>
        /// <remarks>Once a search is created, it may contain cross-object fields. For example, this output column will return the primary
        /// organizations name on an invoice:
        /// <p> <pre><code>BillTo.PrimaryOrganization.Name</code></pre></p>
        /// When running <service name="DescribeSearch"/>, you'll only get the fields defined for that search. Because there's an infinite combination of
        /// cross-object search possibilities, you'll want to call this method when describing <i>a specific search,</i> as opposed to the base search.
        /// </remarks>
        [OperationContract]
        ConciergeResult<SearchManifest> DescribeCompiledSearch(Search searchToInspect);
        /// <summary>
        /// Describes multiple compiled searches as once.
        /// </summary><type>Search</type>
        /// <param name="searchesToInspect">The searches to describe.</param>
        /// <returns></returns>
        /// <remarks>See <service name="DescribeCompiledSearch"/> for more information on search description.</remarks>
        [OperationContract]
        ConciergeResult<List<SearchManifest>> DescribeCompiledSearches(List<Search> searchesToInspect);

        /// <summary>
        /// Gets a list of all built in searches.
        /// </summary><type>Search</type>
        /// <param name="searchType">Type of the search.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<NameValuePair>> GetBuiltInSearches(string searchType);

        /// <summary>
        /// Loads a specific built in search by name.
        /// </summary><type>Search</type>
        /// <param name="searchName">Name of the search.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<BuiltInSearch> LoadBuiltInSearch(string searchName);

        /// <summary>
        /// Executes a search that has a file output, such as Excel, CSV, or XML.
        /// </summary><type>Search</type>
        /// <param name="searchToExecute">The search to execute.</param>
        /// <param name="searchOutputType">Type of the search output.</param>
        /// <param name="abortIfZeroResults">if set to <c>true</c>, this method will return nothing if there are zero results in the result set..</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> ExecuteSearchWithFileOutput(Search searchToExecute,
            string searchOutputType, bool abortIfZeroResults);

        /// <summary>
        /// Executes a "quick search" against an object.
        /// </summary><type>Search</type>
        /// <param name="searchType">Type of the search.</param>
        /// <param name="searchContext">The search context.</param>
        /// <param name="queryText">The query text.</param>
        /// <param name="startRecord">The start record.</param>
        /// <param name="maximumNumberOfRecordsToReturn" optional="true">The maximum number of records to return.</param>
        /// <returns></returns>
        /// <remarks>This is used throughout the MemberSuite UI for the Ajax combo boxes that must look up a record. This method will
        /// respect the quick search settings for a given object, and execute a quick search against it and return results.</remarks>
        [OperationContract]
        ConciergeResult<SearchResult> QuickSearch(string searchType, string searchContext, string queryText, int startRecord, int? maximumNumberOfRecordsToReturn);

        /// <summary>
        /// Generates a quick search.
        /// </summary><type>Search</type>
        /// <param name="searchText">The search text.</param>
        /// <param name="searchContext" optional="true">The search context.</param>
        /// <param name="queryText">The query text.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<Search> GenerateQuickSearch(string searchText, string searchContext, string queryText);

        /// <summary>
        /// Finds all searches that can be the target of an email blast
        /// </summary><type>Search</type>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<NameValueStringPair>> GetPotentialEmailBlastRecipients();

        /// <summary>
        /// Gets a list of all searches in the system, filtered (optionally) by module
        /// </summary>
        /// <param name="moduleToFilterBy"></param>
        /// <returns></returns>
        [OperationContract]
        ConciergeResult<List<PartialSearchDefinition>> ListAllSearches( string moduleToFilterBy );

        /// <summary>
        /// Generates sysem SQL for a search - system administrators only
        /// </summary>
        /// <param name="searchToConvert"></param>
        /// <returns></returns>
        [OperationContract]
        ConciergeResult<string> GetRawSQLForSearch(Search searchToConvert);

        #endregion

        #region GIS Service

        /// <summary>
        /// Gets the zip codes within specified radius by zip.
        /// </summary>
        /// <type>GIS</type>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="radiusInMiles">The radius in miles.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<ZipCodeRadius>> GetZipCodesWithinSpecifiedRadiusByZip(string zipCode, int radiusInMiles);

        /// <summary>
        /// Gets the state of the zip codes within specified radius by city.
        /// </summary>
        /// <type>GIS</type>
        /// <param name="city">The city.</param>
        /// <param name="twoLetterState">State of the two letter.</param>
        /// <param name="radiusInMiles">The radius in miles.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<ZipCodeRadius>> GetZipCodesWithinSpecifiedRadiusByCityState(string city,
                                                                                         string twoLetterState,
                                                                                         int radiusInMiles);

        #endregion

        #region Messaging

        /// <summary>
        /// Previews an email blast.
        /// </summary><type>Messaging</type>
        /// <param name="templateToUse">The template to use.</param>
        /// <param name="search">The search.</param>
        /// <param name="destinationEmail">The destination email.</param>
        /// <param name="count">The number of records to merge for the preview. The maximum value is ten (10) - if you specify less than 1 or more than
        /// 10, 10 will be used.</param>
        /// <remarks></remarks>
        [OperationContract]
        void PreviewEmailBlast(EmailTemplate templateToUse, Search search, string destinationEmail, int count);


        /// <summary>
        /// Retrieves an email template from the database by name (for built in templates), or ID (for custom templates.
        /// </summary><type>Messaging</type>
        /// <param name="nameOrIDOfTemplate">The name or ID of the template to retrieve.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<EmailTemplate> GetEmailTemplate(string nameOrIDOfTemplate);

        /// <summary>
        /// Sends an email through MemberSuite
        /// </summary><type>Messaging</type>
        /// <param name="emailTemplateNameOrID">Name or ID of the email template.</param>
        /// <param name="targets">The targets to send to. This will be a list of IDs, and will depend on the target type of
        /// the specified email template.</param>
        /// <param name="overrideEmailAddress" optional="true">You can optionally override the email address and send the message to 
        /// a specific address.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult SendEmail(string emailTemplateNameOrID, List<string> targets, string overrideEmailAddress);

        /// <summary>
        /// Sends a customized email template out to multiple targets.
        /// </summary><type>Messaging</type>
        /// <param name="template">The email template.</param>
        ///<param name="targets">The targets to send to. This will be a list of IDs, and will depend on the target type of
        /// the specified email template.</param>
        /// <param name="overrideEmailAddress" optional="true">You can optionally override the email address and send the message to 
        /// a specific address.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult SendCustomizedEmail(EmailTemplate template, List<string> targets, string overrideEmailAddress);


        /// <summary>
        /// Gets all built-in email templates in the system. 
        /// </summary><type>Messaging</type>
        /// <returns></returns>
        /// <remarks>Even thought this method only returns built-in email templates, it <i>will</i> respect any
        /// overrides saved of the built-in templates. So if the logged in association customized the Welcome email, you'll get
        /// the customized version, not the original, built-in version.</remarks>
        [OperationContract]
        ConciergeResult<List<EmailTemplate>> GetAllEmailTemplates();




        #endregion

        #region Data Quality
        /// <summary>
        /// Validates an address.
        /// </summary><type>Data Quality</type>
        /// <param name="addressToValidate">The address to validate.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        AddressValidationResult ValidateAddress(Address addressToValidate);

        /// <summary>
        /// Populates the city state from postal code.
        /// </summary><type>Data Quality</type>
        /// <param name="addressToProcess">The address to process.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        AddressValidationResult PopulateCityStateFromPostalCode(Address addressToProcess);


        /// <summary>
        /// Finds the potential duplicates.
        /// </summary><type>Data Quality</type>
        /// <param name="mso">The.</param>
        /// <param name="ruleIDs">The rule IDs.</param>
        /// <param name="spec">The search spec to use.</param>
        /// <param name="startRecord">The start record.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<SearchResult> FindPotentialDuplicates(MemberSuiteObject mso, List<string> ruleIDs, Search spec, int startRecord, int? pageSize);

        //  [OperationContract]
        //SearchResult FindAllPotentialDuplicates(string objectType, List<string> ruleIDs, Search spec, int startRecord, int? pageSize);

        /// <summary>
        /// Gets the default duplicate detection rules.
        /// </summary><type>Data Quality</type>
        /// <param name="recordType">Type of the record.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<DuplicateDetectionRule>> GetDefaultDuplicateDetectionRules(string recordType);

        /// <summary>
        /// Merges two records together, overriding the target with specified source fields
        /// </summary><type>Data Quality</type>
        /// <param name="source">The source record.</param>
        /// <param name="destination">The destination record.</param>
        /// <param name="sourceFieldsToUse" optional="true">The source fields to use. These will override the corresponding fields in the destination</param>
        /// <returns></returns>
        /// <remarks>Though most commonly used for Individuals/Organizations, you can merge any record types in MemberSuite. All linked objects
        /// will move over to the destination object, and the source object will be deleted. Any fields specified in the <param name="sourceFieldsToUse"/> 
        /// will be copied to the destination.</remarks>
        [OperationContract]
        ConciergeResult Merge(string source, string destination, List<string> sourceFieldsToUse);

        /// <summary>
        /// Validates multiple addresses at once.
        /// </summary><type>Data Quality</type>
        /// <param name="entityIdentifiers">The IDs of the entities to validate.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<BulkAddressValidationReport> ValidateMultipleAddresses(List<string> entityIdentifiers);

        [OperationContract]
        ConciergeResult<int> MassUpdateAddressStates(string oldStateValue, string newStateValue);
        [OperationContract]
        ConciergeResult<int> MassUpdateAddressCountries(string oldCountryValue, string newCountryValue);
        #endregion

        #region Reporting
        /// <summary>
        /// Renders a reportin PDF format
        /// </summary><type>Reporting</type>
        /// <param name="manifest">The report manifest.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> RenderReport(ReportManifest manifest);

        /// <summary>
        /// Loads the report definition from the database
        /// </summary><type>Reporting</type>
        /// <param name="manifest">The manifest.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<ReportDefinition> LoadReportDefinition(ReportManifest manifest);

        /// <summary>
        /// Lists all built-in reports in MemberSuite.
        /// </summary><type>Reporting</type>
        /// <returns></returns>
        /// <remarks>This method will not pull custom reports - use a query if you need to get these reports as well.</remarks>
        [OperationContract]
        ConciergeResult<List<PartialReportDefinition>> ListAllReports();

        /// <summary>
        /// Gets the report information for a specific report.
        /// </summary><type>Reporting</type>
        /// <param name="reportName">Name of the report.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<PartialReportDefinition> GetReportInformation(string reportName);

        /// <summary>
        /// Gets all charts in MemberSuite.
        /// </summary><type>Reporting</type>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<ChartDefinition>> GetAllCharts();

        /// <summary>
        /// Gets all KPIs.
        /// </summary><type>Reporting</type>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<KPIDefinition>> GetAllKPIDefinitions();

        /// <summary>
        /// Gets all Widget definitions for built-in widgets..
        /// </summary><type>Reporting</type>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<WidgetDefinition>> GetAllWidgetDefinitions();

        /// <summary>
        /// Builds/renders a specific chart.
        /// </summary><type>Reporting</type>
        /// <param name="chartName">Name of the chart.</param>
        /// <param name="context" optional="true">The context.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<ChartManifest> BuildChart(string chartName, string context);

        /// <summary>
        /// Runs the KPIs.
        /// </summary><type>Reporting</type>
        /// <param name="kpisToRun">The kpis to run.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<KPI>> GetKPIs(List<NameValueStringPair> kpisToRun);

        #endregion

        #region Integration

        /// <summary>
        /// Pings the extension service to see if it is operational.
        /// </summary><type>Integration</type>
        /// <param name="msoService">The service.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult PingExtensionService(MemberSuiteObject msoService);

        /// <summary>
        /// Executes a mail merge, and optionally creates an activity.
        /// </summary><type>Integration</type>
        /// <param name="searchToUse">The search to use.</param>
        /// <param name="mailMergeTemplate">The mail merge template.</param>
        /// <param name="outputFormat">The output format.</param>
        /// <param name="createActivity"  optional="true">if set to <c>true</c> [create activity].</param>
        /// <param name="activityTypeID" optional="true">The activity type ID.</param>
        /// <param name="activityMemo" optional="true">The activity memo.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> ExecuteMailMerge(Search searchToUse, string mailMergeTemplate, MailMergeOutputFormat outputFormat, bool createActivity,
            string activityTypeID, string activityMemo);

        /// <summary>
        /// Sets a configuration setting.
        /// </summary><type>Integration</type>
        /// <param name="ns">The namespace of the configuration setting.</param>
        /// <param name="name">Name of the configuration setting.</param>
        /// <param name="value">The configuration setting value.</param>
        /// <param name="description">The description of the configuration setting</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult SetConfigurationSetting(string ns, string name, string value, string description);

        /// <summary>
        /// Gets a configuration setting by namespace/name.
        /// </summary><type>Integration</type>
        /// <param name="ns">The namespace of the configuration setting.</param>
        /// <param name="settingName">The name of the configuration setting.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> GetConfigurationSetting(string ns, string settingName);

        /// <summary>
        /// Gets all configuration settings for a specific namespace.
        /// </summary><type>Integration</type>
        /// <param name="ns" optional="true">The namespace. If left blank, all settings are returned.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<NameValuePair>> GetAllConfigurationSettings(string ns);

        #endregion

        #region Provisioning

        /// <summary>
        /// Gets the available association templates that can be used to create a new association
        /// </summary><type>Provisioning</type>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<NameValueStringPair>> GetAvailableAssociationTemplates();

        /// <summary>
        /// Provisions an association.
        /// </summary><type>Provisioning</type>
        /// <param name="sourceAssociationID">The source association ID.</param>
        /// <param name="msoAssociation">The association.</param>
        /// <param name="confirmationEmail">The confirmation email.</param>
        /// <param name="includeData">if set to <c>true</c> [include data].</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> ProvisionAssociation(string sourceAssociationID, MemberSuiteObject msoAssociation,
            string confirmationEmail, bool includeData);

        /// <summary>
        /// Moves an association to a different database
        /// </summary>
        /// <param name="sourceAssociationID">The source association ID.</param>
        /// <param name="destinationDatabase">The destination database.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult MoveAssociation(string sourceAssociationID, string destinationDatabase);

        /// <summary>
        /// Obliterates the association.
        /// </summary><type>Provisioning</type>
        /// <param name="associationID">The association ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult ObliterateAssociation(string associationID);

        /// <summary>
        /// Returns all the database servers available in the system
        /// </summary><type>Provisioning</type>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<DatabaseServer>> GetDatabaseServers();

        #endregion

        #region Diagnostics

        /// <summary>
        /// Gets the concierge API version.
        /// </summary><type>Diagnostics</type>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteVersion> GetConciergeAPIVersion();

        /// <summary>
        /// Flushes all caches for the current logging in association.
        /// </summary><type>Diagnostics</type>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult FlushCaches();
        #endregion

        #region Financial
        /// <summary>
        /// Saves the fiscal year.
        /// </summary><type>Financial</type>
        /// <param name="msFiscalYear">The fiscal year.</param>
        /// <param name="numberOfPeriods">The number of periods.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> SaveFiscalYear(MemberSuiteObject msFiscalYear, int numberOfPeriods);

        /// <summary>
        /// Saves a batch.
        /// </summary><type>Financial</type>
        /// <param name="msBatch">The batch to save.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> SaveBatch(MemberSuiteObject msBatch);

        /// <summary>
        /// Saves a credit.
        /// </summary><type>Financial</type>
        /// <param name="msCredit">The credit.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> SaveCredit(MemberSuiteObject msCredit);

        /// <summary>
        /// Voids a credit.
        /// </summary><type>Financial</type>
        /// <param name="creditID">The credit ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult VoidCredit(string creditID);

        /// <summary>
        /// Gets the related payments for an invoice.
        /// </summary><type>Financial</type>
        /// <param name="invoiceID">The invoice ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<MemberSuiteObject>> GetRelatedPaymentsForInvoice(string invoiceID);

        /// <summary>
        /// Gets all open batches that are accessible to the currently logged in user.
        /// </summary><type>Financial</type>
        /// <returns></returns>
        /// <remarks>Because batches can have security rules attach to them, you'll want to use this method to ensure
        /// that only batches that are accessible to the current user are retrieved.</remarks>
        [OperationContract]
        ConciergeResult<List<MemberSuiteObject>> GetOpenBatches();

        /// <summary>
        /// Creates and processes an invoice.
        /// </summary><type>Financial</type>
        /// <param name="msInvoice">The invoice to process.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> CreateInvoice(MemberSuiteObject msInvoice);

        /// <summary>
        /// Processes a write-off.
        /// </summary><type>Financial</type>
        /// <param name="msWriteOff">The write off.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> ProcessWriteOff(MemberSuiteObject msWriteOff);

        /// <summary>
        /// Voids a write off.
        /// </summary><type>Financial</type>
        /// <param name="writeOffID">The write off ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult VoidWriteOff(string writeOffID);

        /// <summary>
        /// Deletes a write off.
        /// </summary><type>Financial</type>
        /// <param name="writeOffID">The write off ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult DeleteWriteOff(string writeOffID);

        /// <summary>
        /// Writes off multiple invoices.
        /// </summary><type>Financial</type>
        /// <param name="msWriteOffTemplate">The write off to use as a template for successive write offs.</param>
        /// <param name="invoicesToWriteOff">The invoices to write off.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> WriteOffMultipleInvoices(MemberSuiteObject msWriteOffTemplate,
            List<string> invoicesToWriteOff);

        /// <summary>
        /// Adjusts the specified invoice.
        /// </summary><type>Financial</type>
        /// <param name="msInvoice">The invoice to adjust</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> AdjustInvoice(MemberSuiteObject msInvoice);

        /// <summary>
        /// Processes a refund.
        /// </summary><type>Financial</type>
        /// <param name="refund">The refund to process</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> ProcessRefund(MemberSuiteObject refund);

        /// <summary>
        /// Gets all products in batch.
        /// </summary><type>Financial</type>
        /// <param name="batchIDs">The batch IDs to check</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<string>> GetAllProductsInBatch(List<string> batchIDs);

        /// <summary>
        /// Adjusts a refund.
        /// </summary><type>Financial</type>
        /// <param name="refund">The refund.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> AdjustRefund(MemberSuiteObject refund);

        /// <summary>
        /// Wipes all pro forma invoices from the system that are dated prior to the specified date.
        /// </summary><type>Financial</type>
        /// <param name="wipeInvoicesBefore">The cutoff date to use.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult WipeProFormaInvoices(DateTime? wipeInvoicesBefore, DateTime? wipeInvoicesAfter);

        /// <summary>
        /// Cancels an invoice.
        /// </summary><type>Financial</type>
        /// <param name="invoiceID">The invoice ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult CancelInvoice(string invoiceID);

        /// <summary>
        /// Posts a batch.
        /// </summary><type>Financial</type>
        /// <param name="batchIDs">The batch Ids.</param>
        /// <param name="newBatchForProFormaInvoices" optional="true">The new batch for pro forma invoices.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<BatchPostingResult>> PostBatches(List<string> batchIDs, string newBatchForProFormaInvoices);

        /// <summary>
        /// Changes the batch of one or more financial transactions
        /// </summary><type>Financial</type>
        /// <param name="targetBatchID">The target batch ID.</param>
        /// <param name="transactionsToChange">The transactions to change.</param>
        /// <returns></returns>
        /// <remarks>Because you can't modify transactions directly using the database services, this method
        /// makes it easy to move transactions from one batch to another en masse</remarks>
        [OperationContract]
        ConciergeResult ChangeBatch(string targetBatchID, List<string> transactionsToChange);

        /// <summary>
        /// Unposts one or more batches.
        /// </summary><type>Financial</type>
        /// <param name="batchIDs">The batch Ids.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult UnPostBatches(List<string> batchIDs);


        /// <summary>
        /// Downloads one or more batches.
        /// </summary><type>Financial</type>
        /// <param name="batchIDs">The batch I ds.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> DownloadBatches(List<string> batchIDs);

        /// <summary>
        /// Gets a batch readiness report to determine whether or not the specified batches can be posted.
        /// </summary><type>Financial</type>
        /// <param name="batches">The batch IDs to examine.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<BatchReadinessReport> GenerateBatchReadinessReport(List<string> batches);

        /// <summary>
        /// Records a payment.
        /// </summary><type>Financial</type>
        /// <param name="paymentToRecord">The payment to record.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> RecordPayment(MemberSuiteObject paymentToRecord);

        /// <summary>
        /// Processes a credit card payment.
        /// </summary><type>Financial</type>
        /// <param name="paymentToRecord">The payment to record.</param>
        /// <param name="creditCardToProcess">The credit card to process.</param>
        /// <param name="antiDuplicationKey">The anti duplication key.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<PaymentProcessorResponse> ProcessCreditCardPayment(MemberSuiteObject paymentToRecord, CreditCard creditCardToProcess, string antiDuplicationKey);

        /// <summary>
        /// Adjusts a payment.
        /// </summary><type>Financial</type>
        /// <param name="paymentToAdjust">The payment to adjust.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> AdjustPayment(MemberSuiteObject paymentToAdjust);

        /// <summary>
        /// Processes an invoice adjustment.
        /// </summary><type>Financial</type>
        /// <param name="msInvoiceAdjustment">The invoice adjustment.</param>
        /// <param name="paymentAdjustmentInstructions"  optional="true">The payment adjustment instructions.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> ProcessInvoiceAdjustment(MemberSuiteObject msInvoiceAdjustment, List<PaymentAdjustmentInstruction> paymentAdjustmentInstructions);


        /// <summary>
        /// Refunds a payment.
        /// </summary><type>Financial</type>
        /// <param name="paymentID">The payment ID.</param>
        /// <param name="batchID">The batch ID.</param>
        /// <param name="instructions">The instructions on how to process refunds.</param>
        /// <param name="memo" optional="true">The memo.</param>
        /// <param name="autoGenerateRefund">if set to <c>true</c> [auto generate refund].</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<PaymentProcessorResponse> RefundPayment(string paymentID, string batchID,
            List<PaymentAdjustmentInstruction> instructions, string memo, bool autoGenerateRefund);

        /// <summary>
        /// Reverses a payment.
        /// </summary><type>Financial</type>
        /// <param name="paymentID">The payment ID.</param>
        /// <param name="batchID">The batch ID.</param>
        /// <param name="instructions">The instructions.</param>
        /// <param name="memo">The memo.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> ReversePayment(string paymentID, string batchID,
            List<PaymentAdjustmentInstruction> instructions, string memo);


        /// <summary>
        /// Voids a payment.
        /// </summary><type>Financial</type>
        /// <param name="paymentID">The payment ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<PaymentProcessorResponse> VoidPayment(string paymentID);

        /// <summary>
        /// Edits a revenue recognition schedule.
        /// </summary><type>Financial</type>
        /// <param name="revenueRecognitionSchedule">The revenue recognition schedule to edit.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> EditRevenueRecognitionSchedule(MemberSuiteObject revenueRecognitionSchedule);

        /// <summary>
        /// Edits a billing schedule.
        /// </summary><type>Financial</type>
        /// <param name="billingSchedule">The billing schedule to edit.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> EditBillingSchedule(MemberSuiteObject billingSchedule);


        /// <summary>
        /// Cancels a billing schedule.
        /// </summary><type>Financial</type>
        /// <param name="billingScheduleId">The billing schedule ID to cancel.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> CancelBillingSchedule(string billingScheduleId);

        /// <summary>
        /// Processes the billing schedule entry.
        /// </summary><type>Financial</type>
        /// <param name="scheduleID">The schedule ID.</param>
        /// <param name="date">The date to use for processing. All entries on this date will be processed</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<PaymentProcessorResponse> ProcessBillingScheduleEntry(string scheduleID, DateTime date);

        /// <summary>
        /// Recognizes the deferral revenue for a fiscal period.
        /// </summary><type>Financial</type>
        /// <param name="fiscalYearID">The fiscal year ID.</param>
        /// <param name="periodNumber">The period number.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult RecognizeDeferralRevenue(string fiscalYearID, int periodNumber);

        /// <summary>
        /// Closes a fiscal period.
        /// </summary><type>Financial</type>
        /// <param name="fiscalYearID">The fiscal year ID.</param>
        /// <param name="periodNumber">The period number.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult ClosePeriod(string fiscalYearID, int periodNumber);

        /// <summary>
        /// Reopens a fiscal period.
        /// </summary><type>Financial</type>
        /// <param name="fiscalYearID">The fiscal year ID.</param>
        /// <param name="periodNumber">The period number.</param>
        /// <param name="deleteRecognizedRevenue">if set to <c>true</c> [delete recognized revenue].</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult ReopenFiscalPeriod(string fiscalYearID, int periodNumber, bool deleteRecognizedRevenue);

        /// <summary>
        /// Describes the products, adding in the product information and price for
        /// the customer specified.
        /// </summary><type>Financial</type>
        /// <param name="entityID" optional="true">The entity ID.</param>
        /// <param name="productsToDescribe">The products to describe.</param>
        /// <returns></returns>
        /// <remarks>Since products have custom pricing rules, the price will be different depending on the
        /// purchaser of the product. This method will list pricing for a specific purchase, or if <param name="entityID"/> is left null, 
        /// an anonymous purchaser.</remarks>
        [OperationContract]
        ConciergeResult<List<ProductInfo>> DescribeProducts(string entityID, List<string> productsToDescribe);

        #endregion

        #region Order Processing

        /// <summary>
        /// Calculates the expiration date for a given product and reference date
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="referenceDate"></param>
        /// <returns></returns>
        [OperationContract]
        ConciergeResult<DateTime?> CalculateExpirationDate(string productID, DateTime referenceDate);
        

        /// <summary>
        /// Voids the specified order.
        /// </summary><type>Order Processing</type>
        /// <param name="orderID">The order ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult VoidOrder(string orderID);

        /// <summary>
        /// Gets the order form questions for a given order based on the products in the order
        /// </summary><type>Order Processing</type>
        /// <param name="order">The order.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<ControlMetadata>> GetOrderForm(MemberSuiteObject order);

        /// <summary>
        /// Gets the order form for a product.
        /// </summary><type>Order Processing</type>
        /// <param name="productID">The product ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<ControlMetadata>> GetOrderFormForProduct(string productID);
        
        /// <summary>
        /// Processes an order.
        /// </summary><type>Order Processing</type>
        /// <param name="msOrderToProcess">The order to process.</param>
        /// <param name="antiDuplicationKey"  optional="true">The anti duplication key. This optional value can be passed to the order system to
        /// ensure that the order can't be dupliated by the user pressing a Submit button twice. This ID can be any string, and if the
        /// same ID is used more than once, the order will not be processed</param>
        /// <returns>A workflow tracing ID that can be passed to <service name="CheckLongRunningTaskStatus"/> to determine
        /// when the order completes.</returns>
        /// <remarks>Order processing uses a queued model, so this method will return immediately even though the order is 
        /// not processed immediately. Ping the <service name="CheckLongRunningTaskStatus"/> to see when the order is completed.</remarks>
        [OperationContract]
        ConciergeResult<string> ProcessOrder(MemberSuiteObject msOrderToProcess, string antiDuplicationKey);

        /// <summary>
        /// Checks the status of a long running task such as order processing.
        /// </summary><type>Order Processing</type>
        /// <param name="taskTracingID">The task tracing ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> CheckLongRunningTaskStatus(string taskTracingID);

        /// <summary>
        /// Edits a record, but only updates specific, eligible fields
        /// </summary><type>Order Processing</type>
        /// <param name="msoOrder">The order.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> SaveDetails(MemberSuiteObject msoOrder);

        /// <summary>
        /// Updates the order billing info.
        /// </summary>
        /// <param name="orderID">The order ID.</param>
        /// <param name="ccNumber">The cc number.</param>
        /// <param name="ccvCode">The CCV code.</param>
        /// <param name="expDate">The exp date.</param>
        /// <param name="billingAddress">The billing address.</param>
        /// <returns></returns>
        /// <type>Order Processing</type>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult UpdateOrderBillingInfo(string orderID, string ccNumber, string ccvCode,
            DateTime? expDate, Address billingAddress);

        /// <summary>
        /// Allows modification of billing information on an invoice even if it is already posted.
        /// </summary><type>Order Processing</type>
        /// <param name="invoiceID">The invoice ID.</param>
        /// <param name="poNumber">The po number.</param>
        /// <param name="billingEmailAddress">The billing email address.</param>
        /// <param name="billingAddress">The billing address.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult UpdateInvoiceBillingInfo(string invoiceID, string poNumber, string billingEmailAddress, Address billingAddress);

        /// <summary>
        /// Adjusts an order.
        /// </summary><type>Order Processing</type>
        /// <param name="msOrderToAdjust">The order to adjust.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> AdjustOrder(MemberSuiteObject msOrderToAdjust);


        /// <summary>
        /// Processes a return.
        /// </summary><type>Order Processing</type>
        /// <param name="msReturn">The return.</param>
        /// <param name="autoGenerateRefunds">if set to <c>true</c> [auto generate refunds].</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult ProcessReturn(MemberSuiteObject msReturn, bool autoGenerateRefunds);

        /// <summary>
        /// Saves a fulfillment batch.
        /// </summary><type>Order Processing</type>
        /// <param name="msoFulfillmentBatch">The fulfillment batch.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> SaveFulfillmentBatch(MemberSuiteObject msoFulfillmentBatch);

        /// <summary>
        /// Processes a fulfillment batch.
        /// </summary><type>Order Processing</type>
        /// <param name="fulfillmentBatchID">The fulfillment batch ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult ProcessFulfillmentBatch(string fulfillmentBatchID);

        /// <summary>
        /// Generates a renewal order for a membership/subscription
        /// </summary><type>Order Processing</type>
        /// <param name="targetID">The target ID o the membership/subscription.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> GenerateRenewalOrder(string targetID);

        //[OperationContract]
        //ConciergeResult UpdateStockItemInventory(string inventoryID, decimal quantityOnOrder, decimal? reorderPoint);

        /// <summary>
        /// Fulfills an order.
        /// </summary><type>Order Processing</type>
        /// <param name="orderID">The order ID.</param>
        /// <param name="itemsToFulfill">The items to fulfill.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult FulfillOrder(string orderID, List<string> itemsToFulfill);

        /// <summary>
        /// Ships an order.
        /// </summary><type>Order Processing</type>
        /// <param name="orderID">The order ID.</param>
        /// <param name="itemsToShip">The items to ship.</param>
        /// <param name="shipDate">The ship date.</param>
        /// <param name="shippingMethod">The shipping method.</param>
        /// <param name="trackingNumber">The tracking number.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult ShipOrder(string orderID, List<string> itemsToShip, DateTime shipDate, string shippingMethod, string trackingNumber);

        /// <summary>
        /// Bills an order.
        /// </summary><type>Order Processing</type>
        /// <param name="orderID">The order ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult BillOrder(string orderID);


        /// <summary>
        /// Pre-processes an order
        /// </summary><type>Order Processing</type>
        /// <param name="msOrderToFinalize">The order to pre-process.</param>
        /// <returns></returns>
        /// <remarks>Once a customer adds a bunch of products to their card, the system needs to determine what the prices for those products are,
        /// if any taxes or shipping charges need to be added, and what additional products need to be added. This process is known as <i>Pre-Processing</i>.
        /// You'll want to preprocess an order before passing it to <service name="ProcessOrder"/>.</remarks>
        [OperationContract]
        ConciergeResult<PreProcessedOrderPacket> PreProcessOrder(MemberSuiteObject msOrderToFinalize);

        /// <summary>
        /// Processes an inventory transaction.
        /// </summary><type>Order Processing</type>
        /// <param name="inventoryTransaction">The inventory transaction.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> ProcessInventoryTransaction(MemberSuiteObject inventoryTransaction);


        #endregion

        #region Advertising

        /// <summary>
        /// Generates the insertion order invoices.
        /// </summary><type>Advertising</type>
        /// <param name="issueId">The issue id.</param>
        /// <param name="batchName">Name of the batch.</param>
        /// <param name="invoiceTermsId">The invoice terms id.</param>
        /// <param name="searchToUse">The search to use.</param>
        /// <param name="automaticallyEmailInvoices">if set to <c>true</c> [automatically email invoices].</param>
        /// <param name="jobStatusNotificationEmail">The job status notification email.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> GenerateInsertionOrderInvoices(string issueId, string batchName,
                                                               string invoiceTermsId, Search searchToUse,
                                                               bool automaticallyEmailInvoices,
                                                               string jobStatusNotificationEmail);

        #endregion

        #region Membership

        /// <summary>
        /// Processes membership renewals.
        /// </summary><type>Membership</type>
        /// <param name="membershipOrganizationID">The membership organization ID.</param>
        /// <param name="batchID">The batch ID.</param>
        /// <param name="renewalBatchName">Name of the batch.</param>
        /// <param name="searchToUse">The search to use.</param>
        /// <param name="sendOutEmails">if set to <c>true</c> [send out emails].</param>
        /// <param name="jobStatusNotificationEmail">The job status notification email.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> ProcessRenewals(string membershipOrganizationID,
           string batchID, string renewalBatchName, Search searchToUse, bool sendOutEmails, string jobStatusNotificationEmail);

    

        /// <summary>
        /// Gets the primary membership for an entity
        /// </summary><type>Membership</type>
        /// <param name="membershipOrganizationID">The membership organization ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> GetPrimaryMembership(string membershipOrganizationID, string entityID);

        /// <summary>
        /// Gets the default chapter product for a specific membership type
        /// </summary><type>Membership</type>
        /// <param name="membershipTypeID">The membership type ID.</param>
        /// <param name="chapterID">The chapter ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> GetDefaultChapterProduct(string membershipTypeID, string chapterID);

        /// <summary>
        /// Gets the default section product for a specific membership type.
        /// </summary><type>Membership</type>
        /// <param name="membershipTypeID">The membership type ID.</param>
        /// <param name="sectionID">The section ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> GetDefaultSectionProduct(string membershipTypeID, string sectionID);

        /// <summary>
        /// Gets the applicable membership dues products for a customer.
        /// </summary><type>Membership</type>
        /// <param name="membershipOrganizationID">The membership organization ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<MembershipProductInfo>> GetApplicableMembershipDuesProducts(string membershipOrganizationID, string entityID);

        /// <summary>
        /// Drops the specified memberships.
        /// </summary><type>Membership</type>
        /// <param name="searchToUseForDrop">The search to use for the drop.</param>
        /// <param name="terminationReasonID">The termination reason ID.</param>
        /// <param name="newStatusID">The new status ID.</param>
        /// <param name="terminationDate">The termination date.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult DropMemberships(Search searchToUseForDrop, string terminationReasonID, string newStatusID, DateTime terminationDate);

        /// <summary>
        /// Gets the type of the applicable chapters for membership.
        /// </summary><type>Membership</type>
        /// <param name="membershipTypeID">The membership type ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<NameValueStringPair>> GetApplicableChaptersForMembershipType(string membershipTypeID);

        /// <summary>
        /// Suggests a chapter based on postal code mappings.
        /// </summary><type>Membership</type>
        /// <param name="membershipOrganizationID">The membership organization ID.</param>
        /// <param name="potentialMemberID">The potential member ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> SuggestChapter(string membershipOrganizationID, string potentialMemberID);

      
        #endregion

        #region Events

        /// <summary>
        /// Gets the applicable registration fees for a given event.
        /// </summary><type>Events</type>
        /// <param name="eventID">The event ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<EventRegistrationProductInfo>> GetApplicableRegistrationFees(string eventID, string entityID);

        /// <summary>
        /// Gets the event manifest, including sessions, guest reg types, etc
        /// </summary><type>Events</type>
        /// <param name="eventID">The event ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <param name="registrationFeeID">The registration fee ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<EventManifest> GetEventManifest(string eventID, string entityID, string registrationFeeID);

        /// <summary>
        /// Clones the event.
        /// </summary><type>Events</type>
        /// <param name="srcEventID">The source event ID.</param>
        /// <param name="msoNewEventValues">The new event values.</param>
        /// <param name="includeConfirmationEmails">if set to <c>true</c> [include confirmation emails].</param>
        /// <param name="includeRegistrationFees">if set to <c>true</c> [include registration fees].</param>
        /// <param name="includeRegistrationQuestions">if set to <c>true</c> [include registration questions].</param>
        /// <param name="includeEventMerchandise">if set to <c>true</c> [include event merchandise].</param>
        /// <param name="includeSupplementalInformationLinks">if set to <c>true</c> [include supplemental information links].</param>
        /// <param name="includeSessionTracks">if set to <c>true</c> [include session tracks].</param>
        /// <param name="includeSessionTimeslots">if set to <c>true</c> [include session timeslots].</param>
        /// <param name="includeSponsorshipInformation">if set to <c>true</c> [include sponsorship information].</param>
        /// <param name="includeResources"> </param>
        /// <param name="includeRooms"> </param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> CloneEvent(string srcEventID, MemberSuiteObject msoNewEventValues,
                                                        bool includeConfirmationEmails,
                                                        bool includeRegistrationFees,
                                                        bool includeRegistrationQuestions,
                                                        bool includeEventMerchandise,
                                                        bool includeSupplementalInformationLinks,
                                                        bool includeSessionTracks,
                                                        bool includeSessionTimeslots,
                                                        bool includeSponsorshipInformation,
                                                        bool includeResources,
                                                        bool includeRooms);

        /// <summary>
        /// Transfers a registration from one event to another, performing all relevant accounting operations.
        /// </summary><type>Events</type>
        /// <param name="sourceRegistrationID">The source registration ID.</param>
        /// <param name="destinationRegistrationFee">The destination registration fee.</param>
        /// <param name="batchToUse">The batch to use.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> TransferRegistration(string sourceRegistrationID, string destinationRegistrationFee,
            string batchToUse);

        /// <summary>
        /// Moves all unmigrated abstracts to competition as competition entries, so they can be judged.
        /// </summary>
        /// <param name="competitionID">The competition ID.</param>
        /// <returns>ConciergeResult{MemberSuiteObject}.</returns>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> MoveAbstractsToCompetition( string competitionID );

        #endregion

        #region Awards and Competitions

        /// <summary>
        /// Gets the competition entry information.
        /// </summary><type>Awards & Competitions</type>
        /// <param name="competitionId">The competition id.</param>
        /// <param name="entityId">The entity id.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<CompetitionEntryInformation> GetCompetitionEntryInformation(string competitionId, string entityId);

        #endregion

        #region CareerCenter

        /// <summary>
        /// Applies a resume to a job posting.
        /// </summary><type>Career Center</type>
        /// <param name="jobPostingID">The job posting ID.</param>
        /// <param name="resumeID">The resume ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult ApplyToJobPosting(string jobPostingID, string resumeID);

        /// <summary>
        /// Gets a resume as HTML.
        /// </summary><type>Career Center</type>
        /// <param name="resumeID">The resume ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> GetResumeAsHtml(string resumeID);

        #endregion

        #region Prospects

        /// <summary>
        /// Converts a lead into an organization/contact
        /// </summary><type>Prospects</type>
        /// <param name="leadID">The lead ID.</param>
        /// <param name="newOwnerID">The new owner ID.</param>
        /// <param name="sendEmailToNewOwner">if set to <c>true</c> [send email to new owner].</param>
        /// <param name="entityNameOrID">The entity name or ID.</param>
        /// <param name="createIndividualRecord">if set to <c>true</c> [create individual record].</param>
        /// <param name="relationshipTypeID">The relationship type ID.</param>
        /// <param name="opportunityNameOrID">The opportunity name or ID.</param>
        /// <param name="msoFollowUpActivity">The follow up activity.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> ConvertLead(string leadID,
            string newOwnerID,
            bool sendEmailToNewOwner,
            string entityNameOrID,
            bool createIndividualRecord,
            string relationshipTypeID,
            string opportunityNameOrID, MemberSuiteObject msoFollowUpActivity);
        #endregion

        #region Fundraising

        /// <summary>
        /// Generates a single donor acknowledgment letter.
        /// </summary><type>Fundraising</type>
        /// <param name="GiftID">The Gift ID.</param>
        /// <param name="logActivity">if set to <c>true</c> [log activity].</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> GenerateDonorAcknowledgmentLetter(string GiftID, bool logActivity);

        /// <summary>
        /// Generates multiple donor acknowledgment letters, and returns a zip file
        /// </summary><type>Fundraising</type>
        /// <param name="listOfGifts">The list of gifts.</param>
        /// <param name="logActivity">if set to <c>true</c> [log activity].</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> GenerateDonorAcknowledgmentLetters(List<string> listOfGifts, bool logActivity);

        /// <summary>
        /// Generates the donor receipt.
        /// </summary><type>Fundraising</type>
        /// <param name="GiftID">The gift ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> GenerateDonorReceipt(string GiftID);


        /// <summary>
        /// Generates donor receipts.
        /// </summary><type>Fundraising</type>
        /// <param name="listOfGifts">The list of gifts.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> GenerateDonorReceipts(List<string> listOfGifts);

        /// <summary>
        /// Creates a gift.
        /// </summary><type>Fundraising</type>
        /// <param name="msoGiftToCreate">The gift to create.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> CreateGift(MemberSuiteObject msoGiftToCreate);

        /// <summary>
        /// Edits the gift.
        /// </summary><type>Fundraising</type>
        /// <param name="msoGiftToEdit">The gift to edit.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> EditGift(MemberSuiteObject msoGiftToEdit);

        /// <summary>
        /// Voids the gift.
        /// </summary><type>Fundraising</type>
        /// <param name="giftIdToVoid">The gift id to void.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult VoidGift(string giftIdToVoid);

        /// <summary>
        /// Processes the specified premiums.
        /// </summary><type>Fundraising</type>
        /// <param name="giftToProcess">The gift to process.</param>
        /// <param name="batchID">The batch ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> ProcessPremiums(string giftToProcess, string batchID);
        #endregion

        #region Exhibits

        /// <summary>
        /// Gets the available exhibitor registration windows for a particular show/entity
        /// </summary><type>Exhibits</type>
        /// <param name="showID">The show ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<ExhibitorRegistrationPermissionPacket> GetAvailableExhibitorRegistrationWindows(string showID, string entityID);

        /// <summary>
        /// Gets the avaialble exhibit booths.
        /// </summary><type>Exhibits</type>
        /// <param name="showID">The show ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<ExhibitBoothInfo>> GetAvaialbleExhibitBooths(string showID, string entityID);

        /// <summary>
        /// Retrieves the exhibit record for a specific show/entity, or creates one if none exists
        /// </summary><type>Exhibits</type>
        /// <param name="showID">The show ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> RetrieveOrCreateExhibitorRecord(string showID, string entityID);

        /// <summary>
        /// Retrieves the accessible exhibitor records for a specific entity.
        /// </summary><type>Exhibits</type>
        /// <param name="showID">The show ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns></returns>
        /// <remarks>Use this method to determine what exhibitor records a individual/organization can access based on their relationships.</remarks>
        [OperationContract]
        ConciergeResult<List<NameValueStringPair>> RetrieveAccessibleExhibitorRecords(string showID, string entityID);

        /// <summary>
        /// Checks for an exhibitor contact restriction.
        /// </summary><type>Exhibits</type>
        /// <param name="exhibitorID">The exhibitor ID.</param>
        /// <param name="contactTypeID">The contact type ID.</param>
        /// <returns>The Exhibitor Contact Restriction object if one exists; if no restriction is in place, this returns null.</returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> CheckForExhibitorContactRestriction(string exhibitorID, string contactTypeID);
        #endregion

        #region Subscriptions

        /// <summary>
        /// Fulfills the subscriptions in the system based on the manifest.
        /// </summary><type>Subscriptions</type>
        /// <param name="jobManifest">The job manifest.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult FulfillSubscriptions(SubscriptionFulfillmentJobManifest jobManifest);

        /// <summary>
        /// Renews the subscriptions in the system based on the manifest.
        /// </summary><type>Subscriptions</type>
        /// <param name="jobManifest">The job manifest.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult RenewSubscriptions(SubscriptionRenewalJobManifest jobManifest);
        #endregion

        #region Volunteers

        /// <summary>
        /// Matches up volunteers to a specified job occurrence
        /// </summary><type>Volunteers</type>
        /// <param name="jobOccurrenceID">The job occurrence ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<VolunteerMatch>> MatchVolunteersToJobOccurrences(string jobOccurrenceID);

        /// <summary>
        /// Matches up job occurrences to a volunteer
        /// </summary><type>Volunteers</type>
        /// <param name="volunteerID">The volunteer ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<List<VolunteerMatch>> MatchJobOccurrencesToVolunteer(string volunteerID);

        #endregion

        #region Documents

        /// <summary>
        /// Gets the file cabinet for a specified target, and creates one if it doesn't exist
        /// </summary><type>Documents</type>
        /// <param name="targetID">The target ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> GetFileCabinetRootFolder(string targetID);

        /// <summary>
        /// Describes a file folder.
        /// </summary><type>Documents</type>
        /// <param name="folderID">The folder ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<FolderInfo> DescribeFolder(string folderID);

        /// <summary>
        /// Deletes a folder tree.
        /// </summary><type>Documents</type>
        /// <param name="folderID">The folder ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult DeleteFolderTree(string folderID);

        /// <summary>
        /// Searches for files within folder.
        /// </summary><type>Documents</type>
        /// <param name="folderID">The folder ID.</param>
        /// <param name="textToSearch">The text to search.</param>
        /// <param name="startRecord">The start record.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<SearchResult> SearchForFilesWithinFolder(string folderID, string textToSearch, int startRecord, int? pageSize);

        /// <summary>
        /// Searches for files globally.
        /// </summary><type>Documents</type>
        /// <param name="textToSearch">The text to search.</param>
        /// <param name="startRecord">The start record.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<SearchResult> SearchForFilesGlobally(string textToSearch, int startRecord, int? pageSize);
        #endregion

        #region Portal

        /// <summary>
        /// Gets the accessible portal forms.
        /// </summary><type>Portal</type>
        /// <param name="entityID">The entity ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<PortalFormsManifest> GetAccessiblePortalForms(string entityID);

        /// <summary>
        /// Describes the portal form.
        /// </summary><type>Portal</type>
        /// <param name="formID">The form ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<PortalFormInfo> DescribePortalForm(string formID, string entityID);

        /// <summary>
        /// Checks for an entitlement.
        /// </summary><type>Portal</type>
        /// <param name="type">The type.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<EntitlementReport> CheckEntitlement(string type, string entityID, string context);

        /// <summary>
        /// Adjusts the entitlement quantity for an entity/entititlement type.
        /// </summary><type>Portal</type>
        /// <param name="entityID">The entity ID.</param>
        /// <param name="typeOfEntitlement">The type of entitlement.</param>
        /// <param name="context">The context.</param>
        /// <param name="amountToAdjust">The amount to adjust.</param>
        /// <returns></returns>
        /// <remarks>This method will find the first available entitlement, and adjust the quantity. Use
        /// a negative value to adjust it downward. If it cannot find an entitlement or a specified context/type, it
        /// will create one with the adjusted value.</remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> AdjustEntitlementAvailableQuantity(string entityID, string typeOfEntitlement, string context, decimal amountToAdjust);

        /// <summary>
        /// Gets all of the entitlements for an entity
        /// </summary><type>Portal</type>
        /// <param name="entityID">The entity ID.</param>
        /// <param name="type">(Optional) the type of entitlement you'e looking for. If null, then all entitlements are returned.</param>
        /// <returns></returns>
        /// <remarks>This method will properly "collapse" entitlements and return one record for each
        /// entitlement type/context. In other words, if you have two job posting entitlements, the system
        /// will only return one record, with the combined quantity/quantity available. That's why you want
        /// to call this method, rather than just running a search.</remarks>
        [OperationContract]
        ConciergeResult<List<EntitlementReport>> ListEntitlements(string entityID, string type);

        /// <summary>
        /// Gets the portal URL.
        /// </summary><type>Portal</type>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<string> GetPortalUrl();

        #endregion

        /// <summary>
        /// Gets the appropriate rate card.
        /// </summary>
        /// <param name="issueId">The issue id.</param>
        /// <param name="advertiserId">The advertiser id.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> GetAppropriateRateCard(string issueId, string advertiserId);

        #region Discussions

        /// <summary>
        /// Gets the DiscussionBoard for a specified target, and creates one if it doesn't exist
        /// </summary><type>Discussions</type>
        /// <param name="targetID">The target ID.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [OperationContract]
        ConciergeResult<MemberSuiteObject> GetDiscussionBoard(string targetID);

        /// <summary>
        /// Sends the Discussion Topic Subscription Post Notice to each Entity who has subscribed to the topic notifying them that the specified post is now available
        /// </summary>
        /// <param name="discussionPostId">The Discussion Post to notify subscribed Entities about</param>
        /// <returns></returns>
        [OperationContract]
        ConciergeResult SendEmailsToSubscribedEntities(string discussionPostId);

        #endregion

        [OperationContract]
        ConciergeResult ModifyAndSendOutRenewalInvoices(string overrideEmail, string orderID);

        /// <summary>
        /// Gets the association that a specific object belongs to
        /// </summary>
        /// <param name="objectID">The object ID to examine</param>
        /// <returns></returns>
        [OperationContract]
        ConciergeResult<string> GetAssociationFromObjectIdentifier(string objectID);
    }
}
