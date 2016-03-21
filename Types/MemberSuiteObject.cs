// ***********************************************************************
// Assembly         : MemberSuite.SDK
// Author           : Andrew
// Created          : 09-13-2012
//
// Last Modified By : Andrew
// Last Modified On : 02-26-2013
// ***********************************************************************
// <copyright file="MemberSuiteObject.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using MemberSuite.SDK.Concierge;
using MemberSuite.SDK.DataLoader;
using MemberSuite.SDK.DuplicateDetection;
using MemberSuite.SDK.Manifests;
using MemberSuite.SDK.Manifests.Command;
using MemberSuite.SDK.Manifests.Command.Views;
using MemberSuite.SDK.Manifests.Console;
using MemberSuite.SDK.Results;
using MemberSuite.SDK.Searching;

using MemberSuite.SDK.Utilities;
using Spring.Core;
using Spring.Expressions;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    ///     Represents a set of name/value pairs that represent an object
    /// </summary>
    [KnownType("registerKnownTypes")]
    [Serializable]
    [DataContract]
    public class MemberSuiteObject : IPropertyOrFieldNodeOverrideable, ICustomTypeDescriptor
    {
        [ThreadStatic] public static TimeZoneInfo CurrentTimeZone;

        /// <summary>
        ///     Initializes a new instance of the <see cref="MemberSuiteObject" /> class.
        /// </summary>
        public MemberSuiteObject()
        {
            Fields = new MemberSuiteFieldsDictionary();
            ParentTypes = new List<string>();
        }

        //public T To<T>() where T : msAggregate, new()
        //{
        //    T mso = new T();

        //    mso._absorb(this);
        //    return mso;

        //}

        /// <summary>
        ///     Initializes a new instance of the <see cref="MemberSuiteObject" /> class,
        ///     using the fields in the absorbing object
        /// </summary>
        /// <param name="msObjectToAbsorb">The ms object to absorb.</param>
        public MemberSuiteObject(MemberSuiteObject msObjectToAbsorb)
        {
            _absorb(msObjectToAbsorb);
        }

        /// <summary>
        ///     Gets or sets the fields.
        /// </summary>
        /// <value>The fields.</value>
        [DataMember]
        public MemberSuiteFieldsDictionary Fields { get; protected set; }

        /// <summary>
        ///     Gets or sets the type of Member Suite object that this represents
        /// </summary>
        /// <value>The type.</value>
        [DataMember]
        public string ClassType { get; set; }

        /// <summary>
        ///     Gets or sets the parent types.
        /// </summary>
        /// <value>The parent types.</value>
        [DataMember]
        public List<string> ParentTypes { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="System.Object" /> with the specified field name.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>System.Object.</returns>
        public object this[string fieldName]
        {
            get { return ResolveExpression(fieldName); }
            set { SetValue(fieldName, value); }
        }

        /// <summary>
        ///     Gets the property or field accessor.
        /// </summary>
        /// <param name="memberName">Name of the member.</param>
        /// <returns>IValueAccessor.</returns>
        public IValueAccessor GetPropertyOrFieldAccessor(string memberName)
        {
            return new MemberSuiteObjectValueAccessor(memberName);
        }

        public static TimeZoneInfo GetCurrentTimeZone()
        {
            return CurrentTimeZone ?? TimeZoneInfo.Local;
        }

        /// <summary>
        ///     _absorbs the specified ms object to absorb.
        /// </summary>
        /// <param name="msObjectToAbsorb">The ms object to absorb.</param>
        /// <exception cref="SDKException">MemberSuite Object of type '{0}' cannot absorb an object of type '{1}'</exception>
        private void _absorb(MemberSuiteObject msObjectToAbsorb)
        {
            if (msObjectToAbsorb == null) return; // nothing to absorb

            if (ClassType != null && ClassType != msObjectToAbsorb.ClassType)
                throw new SDKException("MemberSuite Object of type '{0}' cannot absorb an object of type '{1}'",
                    ClassType, msObjectToAbsorb.ClassType);
            ClassType = msObjectToAbsorb.ClassType;
            Fields = msObjectToAbsorb.Fields;
        }

        /// <summary>
        ///     Safely the get value.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>System.Object.</returns>
        public object SafeGetValue(string fieldName)
        {
            if (!Fields.ContainsKey(fieldName))
                return null;

            return Fields[fieldName];
        }

        /// <summary>
        ///     Safely the get value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>``0.</returns>
        public T SafeGetValue<T>(string fieldName)
        {
            var obj = SafeGetValue(fieldName);
            if (obj == null)
                return default(T);

            if (typeof (T).IsEnum)
            {
                if (obj is int)
                    return (T) obj;

                if (obj is string)
                    return ((string) obj).ToEnum<T>();
            }

            return obj is T ? (T) obj : default(T);
        }

        /// <summary>
        ///     Checks to see whether the domain object represented by this member suite object exists in the database
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public bool ExistsInDatabase()
        {
            var timestamp = SafeGetValue<string>("SystemTimestamp");
            //var id = SafeGetValue<string>("ID");
            return timestamp != null; //&& id != null;
        }

        /// <summary>
        ///     Froms the class metadata.
        /// </summary>
        /// <param name="classMetadata">The class metadata.</param>
        /// <returns>MemberSuiteObject.</returns>
        public static MemberSuiteObject FromClassMetadata(ClassMetadata classMetadata)
        {
            var mso = new MemberSuiteObject();
            mso.ClassType = classMetadata.Name;
            mso.ParentTypes = classMetadata.ParentTypes;

            foreach (var field in classMetadata.Fields)
            {
                if (field.Name == null)
                    //throw new ApplicationException("Null field name found - this should not happen.");
                    continue;
                if (mso.Fields.ContainsKey(field.Name))
                    /*throw new ApplicationException(string.Format("Field '{0}' for object type '{1}' was specified more than once.",
                        field.Name, classMetadata.Name));*/
                    continue;

                mso.Fields.Add(field.Name, getValidDefaultValue(field.DataType, field.DefaultValue));
            }

            return mso;
        }

        /// <summary>
        ///     Froms the data row.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <returns>MemberSuiteObject.</returns>
        public static MemberSuiteObject FromDataRow(DataRow dataRow)
        {
            var result = new MemberSuiteObject();
            foreach (DataColumn column in dataRow.Table.Columns)
            {
                if (column.DataType == typeof (Guid))
                {
                    result[column.ColumnName] = dataRow[column] == DBNull.Value ? null : dataRow[column].ToString();
                    continue;
                }

                result[column.ColumnName] = dataRow[column] == DBNull.Value ? null : dataRow[column];
            }

            return result;
        }

        /// <summary>
        ///     Gets the valid default value - checking to make sure that a valid default value is specified for
        ///     the data type.
        /// </summary>
        /// <param name="dataType">Type of the data.</param>
        /// <param name="defaultVal">The default val.</param>
        /// <returns>System.Object.</returns>
        private static object getValidDefaultValue(FieldDataType dataType, object defaultVal)
        {
            if (defaultVal == null)
            {
                if (dataType == FieldDataType.Boolean)
                    return false;

                return null; // easy
            }

            try
            {
                switch (dataType)
                {
                    case FieldDataType.Text:
                    case FieldDataType.Email:
                    case FieldDataType.HtmlText:
                    case FieldDataType.LargeText:
                    case FieldDataType.PhoneNumber:
                    case FieldDataType.Url:
                    case FieldDataType.Reference:
                    case FieldDataType.Type:
                        return Convert.ToString(defaultVal);

                    case FieldDataType.Enum:
                        return Convert.ToInt32(defaultVal); //it should be an int in the UI

                    case FieldDataType.Boolean:

                        return Convert.ToBoolean(defaultVal);

                    case FieldDataType.Date:
                    case FieldDataType.Time:
                    case FieldDataType.DateTime:
                        if (Equals(defaultVal, "@@Now"))
                            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, GetCurrentTimeZone());

                        if (Equals(defaultVal, "@@Today"))
                            return DateTime.Today;

                        return Convert.ToDateTime(defaultVal);

                    case FieldDataType.Decimal:
                    case FieldDataType.Percentage:
                    case FieldDataType.Money:
                        return Convert.ToDecimal(defaultVal);


                    case FieldDataType.Integer:
                        return Convert.ToInt32(defaultVal);

                    case FieldDataType.List:
                        return new List<string> {Convert.ToString(defaultVal)};
                }
            }
            catch
            {
// swallow the exception
            }

            return null;
        }

        #region Type Members

        /// <summary>
        ///     Determines whether [is subclass of] [the specified type].
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns><c>true</c> if [is subclass of] [the specified type]; otherwise, <c>false</c>.</returns>
        public bool IsSubclassOf(string type)
        {
            return ParentTypes.Contains(type);
        }

        #endregion

        /// <summary>
        ///     Clones this instance.
        /// </summary>
        /// <returns>MemberSuiteObject.</returns>
        public MemberSuiteObject Clone()
        {
            var mso = new MemberSuiteObject {ClassType = ClassType, ParentTypes = ParentTypes};
            mso.Fields = new MemberSuiteFieldsDictionary();
            foreach (var item in Fields)
                mso.Fields[item.Key] = item.Value;
            return mso;
        }

        /// <summary>
        ///     Takes an object that is of a type derived from MS Object and converts it to a pure membersuite object
        /// </summary>
        /// <param name="memberSuiteObject">The member suite object.</param>
        /// <returns>MemberSuiteObject.</returns>
        public static MemberSuiteObject ConvertToMemberSuiteObject(MemberSuiteObject memberSuiteObject)
        {
            if (memberSuiteObject == null) return null;
            //if (memberSuiteObject.GetType() == typeof(MemberSuiteObject)) return memberSuiteObject; // no conversion necessary

            var clone = memberSuiteObject.Clone();

            var newValues = new Dictionary<string, object>();
            // now go through and find any lists
            if (clone.Fields != null)
                foreach (var entry in clone.Fields)
                {
                    if (entry.Value == null || !typeof (IEnumerable).IsAssignableFrom(entry.Value.GetType()))
                        continue;

                    var genericArgs = entry.Value.GetType().GetGenericArguments();
                    if (genericArgs.Length == 0)
                        continue;

                    if (genericArgs[0].IsSubclassOf(typeof (MemberSuiteObject))) // we have to clone all of these
                    {
                        var objects = new List<MemberSuiteObject>();
                        foreach (var listEntry in (IEnumerable) entry.Value)
                            objects.Add(ConvertToMemberSuiteObject((MemberSuiteObject) listEntry));

                        newValues[entry.Key] = objects; // set the new value
                    }
                }

            foreach (var newEntry in newValues)
                clone.Fields[newEntry.Key] = newEntry.Value;

            return clone;
        }

        #region Custom Property Descriptor

        /// <summary>
        ///     Class MemberSuiteObjectFieldDescriptor
        /// </summary>
        public class MemberSuiteObjectFieldDescriptor : PropertyDescriptor
        {
            /// <summary>
            ///     The _field
            /// </summary>
            private readonly string _field;

            /// <summary>
            ///     Initializes a new instance of the <see cref="MemberSuiteObjectFieldDescriptor" /> class.
            /// </summary>
            /// <param name="field">The field.</param>
            public MemberSuiteObjectFieldDescriptor(string field)
                : base(field,
                    null)
            {
                _field = field;
            }

            /// <summary>
            ///     When overridden in a derived class, gets the type of the component this property is bound to.
            /// </summary>
            /// <value>The type of the component.</value>
            /// <returns>
            ///     A <see cref="T:System.Type" /> that represents the type of component this property is bound to. When the
            ///     <see cref="M:System.ComponentModel.PropertyDescriptor.GetValue(System.Object)" /> or
            ///     <see cref="M:System.ComponentModel.PropertyDescriptor.SetValue(System.Object,System.Object)" /> methods are
            ///     invoked, the object specified might be an instance of this type.
            /// </returns>
            public override Type ComponentType
            {
                get { return typeof (MemberSuiteObject); }
            }

            /// <summary>
            ///     When overridden in a derived class, gets a value indicating whether this property is read-only.
            /// </summary>
            /// <value><c>true</c> if this instance is read only; otherwise, <c>false</c>.</value>
            /// <exception cref="System.NotImplementedException"></exception>
            /// <returns>true if the property is read-only; otherwise, false.</returns>
            public override bool IsReadOnly
            {
                get { throw new NotImplementedException(); }
            }

            /// <summary>
            ///     When overridden in a derived class, gets the type of the property.
            /// </summary>
            /// <value>The type of the property.</value>
            /// <exception cref="System.NotImplementedException"></exception>
            /// <returns>A <see cref="T:System.Type" /> that represents the type of the property.</returns>
            public override Type PropertyType
            {
                get { throw new NotImplementedException(); }
            }

            /// <summary>
            ///     When overridden in a derived class, returns whether resetting an object changes its value.
            /// </summary>
            /// <param name="component">The component to test for reset capability.</param>
            /// <returns>true if resetting the component changes its value; otherwise, false.</returns>
            /// <exception cref="System.NotImplementedException"></exception>
            public override bool CanResetValue(object component)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            ///     When overridden in a derived class, gets the current value of the property on a component.
            /// </summary>
            /// <param name="component">The component with the property for which to retrieve the value.</param>
            /// <returns>The value of a property for a given component.</returns>
            public override object GetValue(object component)
            {
                var mso = component as MemberSuiteObject;
                if (mso != null)
                    return mso.SafeGetValue(_field);

                return null;
            }

            /// <summary>
            ///     When overridden in a derived class, resets the value for this property of the component to the default value.
            /// </summary>
            /// <param name="component">The component with the property value that is to be reset to the default value.</param>
            /// <exception cref="System.NotImplementedException"></exception>
            public override void ResetValue(object component)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            ///     When overridden in a derived class, sets the value of the component to a different value.
            /// </summary>
            /// <param name="component">The component with the property value that is to be set.</param>
            /// <param name="value">The new value.</param>
            public override void SetValue(object component, object value)
            {
                var mso = component as MemberSuiteObject;
                if (mso != null)
                    mso[_field] = value;
            }

            /// <summary>
            ///     When overridden in a derived class, determines a value indicating whether the value of this property needs to be
            ///     persisted.
            /// </summary>
            /// <param name="component">The component with the property to be examined for persistence.</param>
            /// <returns>true if the property should be persisted; otherwise, false.</returns>
            /// <exception cref="System.NotImplementedException"></exception>
            public override bool ShouldSerializeValue(object component)
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Expressions and Such

        /// <summary>
        ///     Resolves the expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>System.Object.</returns>
        public object ResolveExpression(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return null;

            if (expression == "ClassName" || expression == "ClassType")
                return ClassType;

            if (expression.Substring(0, 1).IsNumeric())
                return null;

            object o = null;
            try
            {
                o = SpringExpression.GetValue(this, expression);
            }
            catch (NullValueInNestedPathException) // this is okay
            {
            }

            // ok, return what we've got
            return o;
        }


        /// <summary>
        ///     Determines whether this instance can add the specified object
        /// </summary>
        /// <param name="newValue">The new value.</param>
        /// <returns><c>true</c> if this instance can add the specified o; otherwise, <c>false</c>.</returns>
        public static bool CanAdd(object newValue)
        {
            if (newValue == null)
                return true;

            if (newValue.GetType().IsSubclassOf(typeof (MemberSuiteObject)))
                return true;

            if (typeof (IEnumerable).IsAssignableFrom(newValue.GetType()))
            {
                var args = newValue.GetType().GetGenericArguments();
                if (args.Length > 0 && args[0].IsSubclassOf(typeof (MemberSuiteObject)))
                    return true; // good to go
            }

            return _allowedTypeCache.ContainsKey(newValue.GetType());
        }

        /// <summary>
        ///     Sets the value, swallowing any exceptions.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="newValue">The new value.</param>
        /// <returns>True if value was set successfully</returns>
        /// <exception cref="SDKException">Unable to add type '{0}' to a MemberSuite object - it cannot be serialized.</exception>
        public bool SetValue(string expression, object newValue)
        {
            if (newValue == DBNull.Value)
                newValue = null;

            if (!CanAdd(newValue))
                throw new SDKException("Unable to add type '{0}' to a MemberSuite object - it cannot be serialized.",
                    newValue.GetType());

            if (string.IsNullOrEmpty(expression))
                return false;

            // optimization - Parse is expensive, let's avoid it if we can
            if (
                !Regex.IsMatch(expression, RegularExpressions.CharactersThatNecessitateSpringRegex,
                    RegexOptions.Compiled))
            {
                Fields[expression] = newValue;
                return true;
            }


            // get the expression
            try
            {
                var expr = SpringExpression.GetExpressionFor(expression);
                expr.SetValue(this, Fields, newValue);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Static Methods

        /// <summary>
        ///     Initializes static members of the <see cref="MemberSuiteObject" /> class.
        /// </summary>
        static MemberSuiteObject()
        {
            initialize();
        }


        /// <summary>
        ///     Initializes this instance.
        /// </summary>
        /// <exception cref="System.ApplicationException">Type specified multiple times:  + t</exception>
        private static void initialize()
        {
            _allowedTypeCache = new Dictionary<Type, bool>();

            foreach (var t in registerKnownTypes())
            {
                if (_allowedTypeCache.ContainsKey(t))
                    throw new ApplicationException("Type specified multiple times: " + t);
                _allowedTypeCache.Add(t, true);
            }
        }

        /// <summary>
        ///     The _allowed type cache
        /// </summary>
        private static Dictionary<Type, bool> _allowedTypeCache;

        /// <summary>
        ///     Registers the known types.
        /// </summary>
        /// <returns>List{Type}.</returns>
        public static List<Type> registerKnownTypes()
        {
            var allowableTypes = new List<Type>();

            allowableTypes.Add(typeof (string));
            allowableTypes.Add(typeof (int));
            allowableTypes.Add(typeof (short));
            allowableTypes.Add(typeof (long));
            allowableTypes.Add(typeof (bool));
            allowableTypes.Add(typeof (double));
            allowableTypes.Add(typeof (decimal));
            allowableTypes.Add(typeof (float));
            allowableTypes.Add(typeof (DateTime));
            allowableTypes.Add(typeof (SavedPaymentMethodType));
            allowableTypes.Add(typeof (SavePaymentMethodSetting));
            allowableTypes.Add(typeof (BillingRunActivityType));
            allowableTypes.Add(typeof (SubscriptionFeeType));
            allowableTypes.Add(typeof (TenantLevel));
            allowableTypes.Add(typeof (RealtorSubscriptionType));
            allowableTypes.Add(typeof (RelevantAnnouncementType));
            allowableTypes.Add(typeof (DataExportFormat));
            allowableTypes.Add(typeof (DataEntryViewMetadata));
            allowableTypes.Add(typeof (Data360ViewMetadata));
            allowableTypes.Add(typeof(CreditMemoPaymentOverageBehavior));
            allowableTypes.Add(typeof(PaymentProcessorResponse));
            allowableTypes.Add(typeof (CustomerStatus));
            allowableTypes.Add(typeof (ClassMetadataOverride));
            allowableTypes.Add(typeof (RevenueRecognitionScheduleType));
            allowableTypes.Add(typeof(AdressTypeGeographicalRegionSetting));
            
            allowableTypes.Add(typeof (FileFolderType));
            allowableTypes.Add(typeof (FieldMetadataOverride));
            allowableTypes.Add(typeof (CommandPreferences));
            allowableTypes.Add(typeof (FieldMetadata));
            allowableTypes.Add(typeof (Address));
            allowableTypes.Add(typeof (SecurityLock));
            allowableTypes.Add(typeof (RecommendationStatus));
            allowableTypes.Add(typeof (DataImportProgressPhase));
            allowableTypes.Add(typeof (TermType));
            allowableTypes.Add(typeof (CreditCard));
            allowableTypes.Add(typeof (ElectronicCheck));

            allowableTypes.Add(typeof (OrderPayload));
            allowableTypes.Add(typeof (OrderPayloadEntitlementAdjustments));


            allowableTypes.Add(typeof (SealedValue));
            allowableTypes.Add(typeof (BatchType));
            allowableTypes.Add(typeof (NameValuePair));
            allowableTypes.Add(typeof (NameValueStringPair));
            allowableTypes.Add(typeof (RelationshipMultiplicity));
            allowableTypes.Add(typeof (DisplayTarget));
            allowableTypes.Add(typeof (MemberSuiteFile));
            
            allowableTypes.Add(typeof (ExtensionServiceTransport));

            allowableTypes.Add(typeof (TriggerType));
            allowableTypes.Add(typeof (AuditLogType));
            allowableTypes.Add(typeof (KeyChain));
            allowableTypes.Add(typeof (EmailTemplate));
            allowableTypes.Add(typeof (ClassMetadata));
            allowableTypes.Add(typeof (OrderPaymentMethod));
            allowableTypes.Add(typeof (List<string>));
            allowableTypes.Add(typeof (List<NameValuePair>));
            allowableTypes.Add(typeof (List<NameValueStringPair>));
            allowableTypes.Add(typeof (List<CommandShortcut>));
            allowableTypes.Add(typeof (IntegrationLinkTargetType));
            allowableTypes.Add(typeof (Search));
            allowableTypes.Add(typeof (Tab));
            allowableTypes.Add(typeof (AssociationType));
            allowableTypes.Add(typeof (ConsolePortalOptions));
            allowableTypes.Add(typeof(ConsoleMetadata));
            allowableTypes.Add(typeof (IndexedQuickSearchUsage));

            allowableTypes.Add(typeof (List<MemberSuiteObject>));
            allowableTypes.Add(typeof (FinancialRecurrenceTemplate));

            allowableTypes.Add(typeof (DiscussionPostStatus));
            allowableTypes.Add(typeof (JobPostingStatus));
            allowableTypes.Add(typeof (Quarter));
            allowableTypes.Add(typeof (PortalAccessibility));
            allowableTypes.Add(typeof (Month));
            allowableTypes.Add(typeof (FieldDataType));
            allowableTypes.Add(typeof (SearchOperationGroupType));
            allowableTypes.Add(typeof (GLAccountType));
            allowableTypes.Add(typeof (SecurityLockAccessLevel));
            allowableTypes.Add(typeof (ShippingCalculationMethod));
            allowableTypes.Add(typeof (MailMergeOutputFormat));
            allowableTypes.Add(typeof (TaskStatus));

            allowableTypes.Add(typeof (BillingRunMemberStatus));
            allowableTypes.Add(typeof (BillingAction));
            allowableTypes.Add(typeof (BillingCycleProductAction));
            allowableTypes.Add(typeof (BillingRunStatus));
            allowableTypes.Add(typeof (BillingRunMode));
            allowableTypes.Add(typeof (RecurrenceType));
            allowableTypes.Add(typeof (FieldDisplayType));
            allowableTypes.Add(typeof(LogiServerInformation));
            allowableTypes.Add(typeof (RelativeDateTimeUnitType));
            allowableTypes.Add(typeof (RelativeDateTimeReferencePointType));
            allowableTypes.Add(typeof (PaymentLineItemType));
            allowableTypes.Add(typeof (PaymentMethod));
            allowableTypes.Add(typeof(List<PaymentMethod>));
            allowableTypes.Add(typeof (Language));
            allowableTypes.Add(typeof (CustomObjectPortalFormAccessMode));
            allowableTypes.Add(typeof (BatchStatus));
            allowableTypes.Add(typeof (ViewMetadata.ReportLinkType));
            allowableTypes.Add(typeof (CommandDefinition.CommandDisplayType));
            allowableTypes.Add(typeof (DuplicateDetectionMatchMode));
            allowableTypes.Add(typeof (OrderStatus));
            allowableTypes.Add(typeof (SearchOuputAggregate));
            
            allowableTypes.Add(typeof (BillingScheduleEntryStatus));
            
            allowableTypes.Add(typeof(InventoryCostingMethod));
            allowableTypes.Add(typeof (CommitteeMembershipType));
            allowableTypes.Add(typeof (DiscountCodeApplication));
 
            allowableTypes.Add(typeof(LinkedCancellationBehavior));
            allowableTypes.Add(typeof(PaymentCaptureTimingBehavior));
            allowableTypes.Add(typeof(BankReconciliationStatus));
            allowableTypes.Add(typeof(RefundType));
            allowableTypes.Add(typeof(RefundInvoiceInstructions));
            allowableTypes.Add(typeof(CreditType));
            allowableTypes.Add(typeof(DefaultBatchAssignmentRuleTarget));
            allowableTypes.Add(typeof(ReturnRequestStatus));
            allowableTypes.Add(typeof(COGSEntryType));
            allowableTypes.Add(typeof(OrderCancellationRefundInstructions));
       

            allowableTypes.Add(typeof (EventRegistrationMode));
            allowableTypes.Add(typeof (ExpirationType));
            allowableTypes.Add(typeof (FieldType));
            allowableTypes.Add(typeof (OrderLineItemType));
            allowableTypes.Add(typeof (ProductLinkageType));
            allowableTypes.Add(typeof (PackagedProductPricingMethod));
            allowableTypes.Add(typeof (SourceCodeType));
            allowableTypes.Add(typeof (InvoiceAdjustmentPaymentAction));
            allowableTypes.Add(typeof (ConciergeErrorCode));
            allowableTypes.Add(typeof (CreditCardType));
            allowableTypes.Add(typeof (BatchDownloadMethod));
            allowableTypes.Add(typeof (FinancialSoftwarePackage));
            allowableTypes.Add(typeof (CustomerType));
            allowableTypes.Add(typeof (ActivationTerms));
            allowableTypes.Add(typeof (ChapterMode));
            allowableTypes.Add(typeof (SectionMode));
            allowableTypes.Add(typeof (ResumeCollectionMode));
            allowableTypes.Add(typeof (AssociationStatus));
            allowableTypes.Add(typeof (BillingScheduleStatus));
            allowableTypes.Add(typeof (JobPostingAccess));
            allowableTypes.Add(typeof (CertificationProgramType));
            allowableTypes.Add(typeof (JudgeScoreVisibilityMode));
            allowableTypes.Add(typeof (TaxCalculationMode));
            allowableTypes.Add(typeof (JobStatus));
            allowableTypes.Add(typeof (EventLocationRoomCategory));
            allowableTypes.Add(typeof (CustomFieldType));
            allowableTypes.Add(typeof (GiftType));
            allowableTypes.Add(typeof (ExhibitorRegistrationMode));
            allowableTypes.Add(typeof (HistoricalTransactionType));
            allowableTypes.Add(typeof (AutomatedProcessRecurrence));
            allowableTypes.Add(typeof (AutomatedProcessRecurrenceType));
            allowableTypes.Add(typeof (AutomatedProcessRecurrenceEndType));
            allowableTypes.Add(typeof (CustomFieldValueHolder));
            allowableTypes.Add(typeof (byte[]));
            allowableTypes.Add(typeof (PortalLinkType));
            allowableTypes.Add(typeof (SearchSpecificationOverride));
            allowableTypes.Add(typeof(UmbrellaProductDemographicAssignment));
            
            allowableTypes.Add(typeof (RecurringProductAvailabilityType));

            allowableTypes.Add(typeof (DuesBillingType));
            allowableTypes.Add(typeof (DuesCycleBatchMemberType));

            allowableTypes.Add(typeof (MemberSuiteFieldsDictionary));
            allowableTypes.Add(typeof (ColumnMetadataDictionary));
            allowableTypes.Add(typeof (WriteOffMethod));

            allowableTypes.Add(typeof (WriteOffInvoicesJobManifest));
            allowableTypes.Add(typeof (OpportunityStageType));
            
            allowableTypes.Add(typeof (ChapterPostalCodeMappingMode));
            allowableTypes.Add(typeof (SubscriptionFulfillmentStatus));
            allowableTypes.Add(typeof (GenericJobType));
            allowableTypes.Add(typeof (GiftStatus));
            allowableTypes.Add(typeof (SubledgerEntryItemType));
            allowableTypes.Add(typeof (GiftReceiptStatus));
            allowableTypes.Add(typeof (GiftAcknowledgmentStatus));

            allowableTypes.Add(typeof (VolunteerScreeningStatus));
            allowableTypes.Add(typeof (VolunteerTypeAssignmentStatus));
            allowableTypes.Add(typeof (DaysOfWeek));
            allowableTypes.Add(typeof (VolunteerTraitMatchMode));
            allowableTypes.Add(typeof (CertificationsSelfReportingMode));

            allowableTypes.Add(typeof (IsolationLevel));

            
            allowableTypes.Add(typeof (NRDSAssociationStatus));
            allowableTypes.Add(typeof (NRDSAssociationType));
            allowableTypes.Add(typeof (NRDSDemographicPaymentCodeType));
            allowableTypes.Add(typeof (NRDSEducationDeliveryMethodType));
            allowableTypes.Add(typeof (NRDSEducationPaymentCodeType));
            allowableTypes.Add(typeof (NRDSEducationTestMailingAddressType));
            allowableTypes.Add(typeof (NRDSEducationTestStatus));
            allowableTypes.Add(typeof (NRDSFinancialContributionType));
            allowableTypes.Add(typeof (NRDSFinancialSource));
            allowableTypes.Add(typeof (NRDSMemberGender));
            allowableTypes.Add(typeof (NRDSMemberPreferredFax));
            allowableTypes.Add(typeof (NRDSMemberAddressType));
            allowableTypes.Add(typeof (NRDSMemberPreferredPhone));
            allowableTypes.Add(typeof (NRDSMemberStatus));
            allowableTypes.Add(typeof (NRDSMemberSupplementalStatus));
            allowableTypes.Add(typeof (NRDSMemberType));
            allowableTypes.Add(typeof (NRDSOfficeBranchType));
            allowableTypes.Add(typeof (NRDSOfficeStatus));
            allowableTypes.Add(typeof (NRDSPrimaryIndicator));

            allowableTypes.Add(typeof (EngagementCyclePeriodicity));

            allowableTypes.Add(typeof(NoSqlAttributeType));
            allowableTypes.Add(typeof(NoSqlTableLifespan));
            allowableTypes.Add(typeof(LongRunningTaskStatus));
            allowableTypes.Add(typeof(BankAccountType));

            return allowableTypes;
        }

        #endregion

        #region ICustomTypeDescriptor Members

        /// <summary>
        ///     Returns a collection of custom attributes for this instance of a component.
        /// </summary>
        /// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> containing the attributes for this object.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public AttributeCollection GetAttributes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Returns the class name of this instance of a component.
        /// </summary>
        /// <returns>The class name of the object, or null if the class does not have a name.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public string GetClassName()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Returns the name of this instance of a component.
        /// </summary>
        /// <returns>The name of the object, or null if the object does not have a name.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public string GetComponentName()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Returns a type converter for this instance of a component.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.ComponentModel.TypeConverter" /> that is the converter for this object, or null if there
        ///     is no <see cref="T:System.ComponentModel.TypeConverter" /> for this object.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public TypeConverter GetConverter()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Returns the default event for this instance of a component.
        /// </summary>
        /// <returns>
        ///     An <see cref="T:System.ComponentModel.EventDescriptor" /> that represents the default event for this object,
        ///     or null if this object does not have events.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public EventDescriptor GetDefaultEvent()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Returns the default property for this instance of a component.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.ComponentModel.PropertyDescriptor" /> that represents the default property for this
        ///     object, or null if this object does not have properties.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public PropertyDescriptor GetDefaultProperty()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Returns an editor of the specified type for this instance of a component.
        /// </summary>
        /// <param name="editorBaseType">A <see cref="T:System.Type" /> that represents the editor for this object.</param>
        /// <returns>
        ///     An <see cref="T:System.Object" /> of the specified type that is the editor for this object, or null if the
        ///     editor cannot be found.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object GetEditor(Type editorBaseType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Returns the events for this instance of a component using the specified attribute array as a filter.
        /// </summary>
        /// <param name="attributes">An array of type <see cref="T:System.Attribute" /> that is used as a filter.</param>
        /// <returns>
        ///     An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> that represents the filtered events for
        ///     this component instance.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Returns the events for this instance of a component.
        /// </summary>
        /// <returns>
        ///     An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> that represents the events for this
        ///     component instance.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public EventDescriptorCollection GetEvents()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Returns the properties for this instance of a component using the attribute array as a filter.
        /// </summary>
        /// <param name="attributes">An array of type <see cref="T:System.Attribute" /> that is used as a filter.</param>
        /// <returns>
        ///     A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> that represents the filtered properties
        ///     for this component instance.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Returns the properties for this instance of a component.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> that represents the properties for this
        ///     component instance.
        /// </returns>
        public PropertyDescriptorCollection GetProperties()
        {
            var properties = new PropertyDescriptor[Fields.Count];

            var i = 0;
            foreach (var field in Fields)
                properties[i++] = new MemberSuiteObjectFieldDescriptor(field.Key);

            return new PropertyDescriptorCollection(properties);
        }

        /// <summary>
        ///     Returns an object that contains the property described by the specified property descriptor.
        /// </summary>
        /// <param name="pd">
        ///     A <see cref="T:System.ComponentModel.PropertyDescriptor" /> that represents the property whose owner
        ///     is to be found.
        /// </param>
        /// <returns>An <see cref="T:System.Object" /> that represents the owner of the specified property.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    /// <summary>
    ///     Class MemberSuiteObjectExtensions
    /// </summary>
    public static class MemberSuiteObjectExtensions
    {
        /// <summary>
        ///     Converts to.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listOfMemberSuiteObjects">The list of member suite objects.</param>
        /// <returns>List{``0}.</returns>
        /// <exception cref="System.Exception">no contructor found for  + typeof(T).FullName</exception>
        public static List<T> ConvertTo<T>(this List<MemberSuiteObject> listOfMemberSuiteObjects)
            where T : msDomainObject
        {
            if (listOfMemberSuiteObjects == null)
                return null;

            var ci = typeof (T).GetConstructor(new[] {typeof (MemberSuiteObject)});
            if (ci == null) throw new Exception("no contructor found for " + typeof (T).FullName);

            var newList = new List<T>();
            foreach (var mso in listOfMemberSuiteObjects)
                newList.Add(mso.ConvertTo<T>());

            return newList;
        }

        /// <summary>
        ///     Converts to.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mso">The mso.</param>
        /// <returns>``0.</returns>
        public static T ConvertTo<T>(this MemberSuiteObject mso) where T : msDomainObject
        {
            return (T) ConvertTo(mso, typeof (T));
        }

        /// <summary>
        ///     Converts to.
        /// </summary>
        /// <param name="mso">The mso.</param>
        /// <param name="t">The t.</param>
        /// <returns>MemberSuiteObject.</returns>
        /// <exception cref="System.Exception">no contructor found for  + t.FullName</exception>
        public static MemberSuiteObject ConvertTo(this MemberSuiteObject mso, Type t)
        {
            if (mso == null) return null;

            var ci = t.GetConstructor(new[] {typeof (MemberSuiteObject)});
            if (ci == null) throw new Exception("no contructor found for " + t.FullName);


            var newMSO = (MemberSuiteObject) ci.Invoke(new object[] {mso});

            // change out the lists
            foreach (var pi in t.GetProperties())
            {
                if (typeof (IEnumerable).IsAssignableFrom(pi.PropertyType))
                {
                    var genericArgs = pi.PropertyType.GetGenericArguments();
                    if (genericArgs.Length > 0 && genericArgs[0].IsSubclassOf(typeof (MemberSuiteObject)))
                    {
                        // let's create a new list

                        //!!! Important! Don't use Container in any shared code. Shared code is used by API and JES as well as Console and Portal.
                        // Console and Portal are not configured to use Container!
                        //IList newList = (IList)MemberSuite.Container.GetOrCreateInstance(typeof(List<>).MakeGenericType(genericArgs[0]));

                        var newList = (IList) Activator.CreateInstance(typeof (List<>).MakeGenericType(genericArgs[0]));


                        var oldList = newMSO[pi.Name] as IEnumerable;

                        if (oldList != null)
                            foreach (MemberSuiteObject msoOld in oldList)
                                newList.Add(msoOld.ConvertTo(genericArgs[0]));

                        newMSO[pi.Name] = newList; // swap out the list
                    }
                }
            }

            newMSO.ClassType = mso.ClassType; // make sure the old class type is kept

            if (mso.ParentTypes != null)
            {
                // copy over parent types
                newMSO.ParentTypes = new List<string>();
                newMSO.ParentTypes.AddRange(mso.ParentTypes);
            }
            return newMSO;
        }
    }
}