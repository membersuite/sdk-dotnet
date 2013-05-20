// ***********************************************************************
// Assembly         : MemberSuite.SDK
// Author           : Andrew
// Created          : 09-13-2012
//
// Last Modified By : Andrew
// Last Modified On : 09-13-2012
// ***********************************************************************
// <copyright file="CommandDefinition.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MemberSuite.SDK.Manifests.Resource;
using MemberSuite.SDK.Searching;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Manifests.Command{
    /// <summary>
    /// Class CommandDefinition
    /// </summary>
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("CommandDefinition", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]

    [Serializable]
    [DataContract]
    public class CommandDefinition 
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
        /// Gets or sets the class.
        /// </summary>
        /// <value>The class.</value>
        [DataMember]
        public string Class { get; set; }

        /// <summary>
        /// Gets or sets the expected type of the context.
        /// </summary>
        /// <value>The expected type of the context.</value>
        [DataMember]
        public string ExpectedContextType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow null context].
        /// </summary>
        /// <value><c>true</c> if [allow null context]; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool AllowNullContext { get; set; }

        /// <summary>
        /// Gets or sets the redirect.
        /// </summary>
        /// <value>The redirect.</value>
        [DataMember]
        public string Redirect { get; set; }

        /// <summary>
        /// Gets or sets the redirect target.
        /// </summary>
        /// <value>The redirect target.</value>
        [DataMember]
        public DisplayTarget RedirectTarget { get; set; }

        /// <summary>
        /// Gets or sets the target object of the command, if applicable.
        /// </summary>
        /// <value>The target object.</value>
        [DataMember]
        public string TargetObject { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow anonymous user].
        /// </summary>
        /// <value><c>true</c> if [allow anonymous user]; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool AllowAnonymousUser { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [requires command session].
        /// </summary>
        /// <value><c>true</c> if [requires command session]; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool RequiresCommandSession { get; set; }

        /// <summary>
        /// Gets or sets the objects to persist in command session.
        /// </summary>
        /// <value>The objects to persist in command session.</value>
        [XmlArrayItem("Object")]
        [DataMember]
        public List<ObjectToPersist> ObjectsToPersistInCommandSession { get; set; }

        /// <summary>
        /// Gets or sets the requires permission.
        /// </summary>
        /// <value>The requires permission.</value>
        [DataMember]
        public string RequiresPermission { get; set; }

        /// <summary>
        /// Gets or sets the display type.
        /// </summary>
        /// <value>The display type.</value>
         [DataMember]
        public CommandDisplayType DisplayType { get; set; }

         /// <summary>
         /// Gets or sets the objects to create.
         /// </summary>
         /// <value>The objects to create.</value>
        [XmlArrayItem("Object")]
        [DataMember]
        public List<ObjectToCreate> ObjectsToCreate { get; set; }



        /// <summary>
        /// Gets or sets the data model bindings.
        /// </summary>
        /// <value>The data model bindings.</value>
        [DataMember]
        public List<DataModelBinding> DataModelBindings { get; set; }

        /// <summary>
        /// Gets or sets the searches.
        /// </summary>
        /// <value>The searches.</value>
        [XmlArrayItem("Search")]
        [DataMember]
        public List<Search> Searches { get; set; }
        /// <summary>
        /// Gets or sets the workflow.
        /// </summary>
        /// <value>The workflow.</value>
        [DataMember]
        public CommandWorkflow Workflow { get; set; }


        /// <summary>
        /// Gets or sets the context-sensitive quick searches.
        /// </summary>
        /// <value>The quick searches.</value>
        [XmlArrayItem("QuickSearch")]
        [DataMember]
        public List<NameValueStringPair> QuickSearches { get; set; }

        /// <summary>
        /// Gets or sets the views.
        /// </summary>
        /// <value>The views.</value>
        [XmlArrayItem("View")]
        [DataMember]
        public List<ViewMetadata> Views { get; set; }

        /// <summary>
        /// Gets or sets the resources.
        /// </summary>
        /// <value>The resources.</value>
        [XmlArrayItem("Resource")]
        [DataMember]
        public List<StringResource> Resources { get; set; }

        /// <summary>
        /// Class ObjectToCreate
        /// </summary>
        [Serializable]
        [DataContract]
        public class ObjectToCreate 
        {
            /// <summary>
            /// Gets or sets the type.
            /// </summary>
            /// <value>The type.</value>
            [XmlAttribute]
            [DataMember]
            public string Type { get; set; }

            /// <summary>
            /// Gets or sets the name in model.
            /// </summary>
            /// <value>The name in model.</value>
            [XmlAttribute]
            [DataMember]
            public string NameInModel { get; set; }
        }

        /// <summary>
        /// Class ObjectToPersist
        /// </summary>
        [Serializable]
        [DataContract]
        public class ObjectToPersist
        {
            /// <summary>
            /// Gets or sets the name in model.
            /// </summary>
            /// <value>The name in model.</value>
            [XmlAttribute]
            [DataMember]
            public string NameInModel { get; set; }

            /// <summary>
            /// Gets or sets a flag indicating if the object should be encrypted before persisted in the NoSQL db.
            /// </summary>
            /// <value><c>true</c> if encrypt; otherwise, <c>false</c>.</value>
            [XmlAttribute]
            [DataMember]
            public bool Encrypt { get; set; }
        }

        /// <summary>
        /// Defines how the view show response to state transitions
        /// </summary>
        [Serializable]
        [DataContract]
        public class CommandWorkflow
        {
            /// <summary>
            /// Gets or sets the states.
            /// </summary>
            /// <value>The states.</value>
            [XmlArrayItem("State")]
            [DataMember]
            public List<CommandWorkflowState> States { get; set; } 

        }

        /// <summary>
        /// Class CommandWorkflowState
        /// </summary>
        [Serializable]
        [DataContract]
        public class CommandWorkflowState
        {
            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>The name.</value>
            [XmlAttribute]
            [DataMember]
            public string Name { get; set; }


            /// <summary>
            /// Gets or sets the transitions.
            /// </summary>
            /// <value>The transitions.</value>
            [XmlElement("Transition")]
            [DataMember]
            public List<CommandWorkflowStateTransitition> Transitions { get; set; }
        }

        /// <summary>
        /// Class CommandWorkflowStateTransitition
        /// </summary>
        [Serializable]
        [DataContract]
        public class CommandWorkflowStateTransitition
        {
            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>The name.</value>
            [XmlAttribute]
            [DataMember]
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets to state.
            /// </summary>
            /// <value>To state.</value>
            [XmlAttribute]
            [DataMember]
            public string ToState { get; set; }

            /// <summary>
            /// Gets or sets to command.
            /// </summary>
            /// <value>To command.</value>
            [XmlAttribute]
            [DataMember]
            public string ToCommand { get; set; }

            /// <summary>
            /// Gets or sets to command context.
            /// </summary>
            /// <value>To command context.</value>
            [XmlAttribute]
            [DataMember]
            public string ToCommandContext{ get; set; }

            /// <summary>
            /// Gets or sets to command arg1.
            /// </summary>
            /// <value>To command arg1.</value>
            [XmlAttribute]
            [DataMember]
            public string ToCommandArg1 { get; set; }

            /// <summary>
            /// Gets or sets to command arg2.
            /// </summary>
            /// <value>To command arg2.</value>
            [XmlAttribute]
            [DataMember]
            public string ToCommandArg2 { get; set; }

            /// <summary>
            /// Gets or sets to command arg3.
            /// </summary>
            /// <value>To command arg3.</value>
            [XmlAttribute]
            [DataMember]
            public string ToCommandArg3 { get; set; }

            /// <summary>
            /// Gets or sets to command arg4.
            /// </summary>
            /// <value>To command arg4.</value>
            [XmlAttribute]
            [DataMember]
            public string ToCommandArg4 { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether [transfer command session].
            /// </summary>
            /// <value><c>true</c> if [transfer command session]; otherwise, <c>false</c>.</value>
            [XmlAttribute]
            [DataMember]
            public bool TransferCommandSession { get; set; }

        }

        /// <summary>
        /// Enum CommandDisplayType
        /// </summary>
        public enum CommandDisplayType 
        {
            /// <summary>
            /// The normal
            /// </summary>
            Normal = 0,

            /// <summary>
            /// The popup small
            /// </summary>
            PopupSmall = 1,

            /// <summary>
            /// The popup large
            /// </summary>
            PopupLarge= 2,

            /// <summary>
            /// The popup large extra wide
            /// </summary>
            PopupLargeExtraWide =3
        }

        /// <summary>
        /// Class DataModelBinding
        /// </summary>
        [Serializable]
        [DataContract]
        public class DataModelBinding
        {
            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>The name.</value>
            [XmlAttribute]
            [DataMember]
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the property.
            /// </summary>
            /// <value>The property.</value>
            [XmlAttribute]
            [DataMember]
            public string Property { get; set; }

            /// <summary>
            /// Gets or sets the expression.
            /// </summary>
            /// <value>The expression.</value>
            [XmlAttribute]
            [DataMember]
            public string Expression { get; set; }
        }
      
    }

    //public class SearchShortcut
    //{
    //    public SearchShortcut()
    //    {
            
    //        OutputFields = new List<SearchShortcutOutputField>();
    //        SortFields = new List<SearchShortcutSortField>();
    //        Criteria = new List<SearchShortcutCriteria>();
    //    }

    //    [XmlAttribute]
    //    public string ID { get; set; }

    //    /// <summary>
    //    /// Gets or sets a value indicating whether [unique result].
    //    /// </summary>
    //    /// <value><c>true</c> if [unique result]; otherwise, <c>false</c>.</value>
    //    /// <remarks>If true, the first row is put into the data source</remarks>
    //    [XmlAttribute]
    //    public bool UniqueResult{ get; set; }
         

    //    [XmlAttribute]
    //    public string Type { get; set; }

    //    [XmlArrayItem("Criterion")]
    //    public List<SearchShortcutCriteria> Criteria { get; set; }

    //    [XmlArrayItem("Field")]
    //    public List<SearchShortcutOutputField> OutputFields { get; set; }

    //    [XmlArrayItem("SortBy")]
    //    public List<SearchShortcutSortField> SortFields { get; set; }

    //    [XmlAttribute]
    //    public string Label { get; set; }

    //    [XmlArrayItem("Command")]
    //    public List<CommandShortcut> RowLevelCommands { get; set; }

    //    [XmlAttribute]
    //    public string Context { get; set; }

    //    public void AddCriteria(string fieldName, string fieldOperation, string value)
    //    {
    //    }

    //    public class SearchShortcutCriteria
    //    {
    //        [XmlAttribute]
    //        public string Field { get; set; }
    //        [XmlAttribute]
    //        public string Operation { get; set; }
    //        [XmlAttribute]
    //        public string Value { get; set; }
    //    }

    //    public class SearchShortcutOutputField
    //    {
    //        [XmlAttribute]
    //        public string Name { get; set; }
    //        [XmlAttribute]
    //        public string Label { get; set; }

    //        [XmlAttribute]
    //        public bool Hidden { get; set; }
    //    }

    //    public class SearchShortcutSortField
    //    {

    //        [XmlAttribute()]
    //        public string Name { get; set; }


    //        [XmlAttribute()]
    //        public bool IsDescending { get; set; }
    //    }
    //}

}