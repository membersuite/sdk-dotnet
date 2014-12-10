using System;
using System.Collections.Generic;

namespace MemberSuite.SDK.Types {

[Serializable]
public class msDomainObject : MemberSuiteObject {
public const string CLASS_NAME = "DomainObject";
public  static class FIELDS {
}
public msDomainObject() : base() {
ClassType = "DomainObject";
}
public msDomainObject( MemberSuiteObject msObj) : base(msObj) {}
}
[Serializable]
public class msAggregate : msDomainObject {
public new const string CLASS_NAME = "Aggregate";
public new  static class FIELDS {
public const string ID = "ID";
public const string Name = "Name";
public const string Keywords = "Keywords";
public const string LastModifiedBy = "LastModifiedBy";
public const string LastModifiedDate = "LastModifiedDate";
public const string CreatedDate = "CreatedDate";
public const string CreatedBy = "CreatedBy";
public const string LockedForDeletion = "LockedForDeletion";
public const string IsConfiguration = "IsConfiguration";
public const string IsSealed = "IsSealed";
public const string SystemTimestamp = "SystemTimestamp";
}
public msAggregate() : base() {
ClassType = "Aggregate";
}
public msAggregate( MemberSuiteObject msObj) : base(msObj) {}
public System.String ID {
get { return SafeGetValue<System.String>("ID");}
set { this["ID"] = value;}
}

public System.String Name {
get { return SafeGetValue<System.String>("Name");}
set { this["Name"] = value;}
}

public System.String Keywords {
get { return SafeGetValue<System.String>("Keywords");}
set { this["Keywords"] = value;}
}

public System.String LastModifiedBy {
get { return SafeGetValue<System.String>("LastModifiedBy");}
set { this["LastModifiedBy"] = value;}
}

public System.DateTime LastModifiedDate {
get { return SafeGetValue<System.DateTime>("LastModifiedDate");}
set { this["LastModifiedDate"] = value;}
}

public System.DateTime CreatedDate {
get { return SafeGetValue<System.DateTime>("CreatedDate");}
set { this["CreatedDate"] = value;}
}

public System.String CreatedBy {
get { return SafeGetValue<System.String>("CreatedBy");}
set { this["CreatedBy"] = value;}
}

public System.Boolean LockedForDeletion {
get { return SafeGetValue<System.Boolean>("LockedForDeletion");}
set { this["LockedForDeletion"] = value;}
}

public System.Boolean IsConfiguration {
get { return SafeGetValue<System.Boolean>("IsConfiguration");}
set { this["IsConfiguration"] = value;}
}

public System.Boolean IsSealed {
get { return SafeGetValue<System.Boolean>("IsSealed");}
set { this["IsSealed"] = value;}
}

public System.String SystemTimestamp {
get { return SafeGetValue<System.String>("SystemTimestamp");}
set { this["SystemTimestamp"] = value;}
}

}
[Serializable]
public class msAssociationDomainObject : msAggregate {
public new const string CLASS_NAME = "AssociationDomainObject";
public new  static class FIELDS {
public const string SecurityLock = "SecurityLock";
}
public msAssociationDomainObject() : base() {
ClassType = "AssociationDomainObject";
}
public msAssociationDomainObject( MemberSuiteObject msObj) : base(msObj) {}
public MemberSuite.SDK.Types.SecurityLock SecurityLock {
get { return SafeGetValue<MemberSuite.SDK.Types.SecurityLock>("SecurityLock");}
set { this["SecurityLock"] = value;}
}

}
[Serializable]
public class msConfigurationAssociationDomainObject : msAssociationDomainObject {
public new const string CLASS_NAME = "ConfigurationAssociationDomainObject";
public new  static class FIELDS {
public const string IsActive = "IsActive";
}
public msConfigurationAssociationDomainObject() : base() {
ClassType = "ConfigurationAssociationDomainObject";
}
public msConfigurationAssociationDomainObject( MemberSuiteObject msObj) : base(msObj) {}
public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

}
[Serializable]
public class msAccountingProject : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "AccountingProject";
public new  static class FIELDS {
public const string Description = "Description";
public const string BusinessUnit = "BusinessUnit";
public const string Code = "Code";
public const string EndDate = "EndDate";
}
public msAccountingProject() : base() {
ClassType = "AccountingProject";
}
public msAccountingProject( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccountingProject FromClassMetadata(ClassMetadata meta){return new msAccountingProject(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.DateTime? EndDate {
get { return SafeGetValue<System.DateTime?>("EndDate");}
set { this["EndDate"] = value;}
}

}
[Serializable]
public class msLocallyIdentifiableAssociationDomainObject : msAssociationDomainObject {
public new const string CLASS_NAME = "LocallyIdentifiableAssociationDomainObject";
public new  static class FIELDS {
public const string LocalID = "LocalID";
}
public msLocallyIdentifiableAssociationDomainObject() : base() {
ClassType = "LocallyIdentifiableAssociationDomainObject";
}
public msLocallyIdentifiableAssociationDomainObject( MemberSuiteObject msObj) : base(msObj) {}
public System.Int64? LocalID {
get { return SafeGetValue<System.Int64?>("LocalID");}
set { this["LocalID"] = value;}
}

}
[Serializable]
public class msBatch : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "Batch";
public new  static class FIELDS {
public const string IsDefault = "IsDefault";
public const string Description = "Description";
public const string DatePosted = "DatePosted";
public const string DateClosed = "DateClosed";
public const string DateExported = "DateExported";
public const string ClosedBy = "ClosedBy";
public const string PostedBy = "PostedBy";
public const string FiscalYear = "FiscalYear";
public const string FiscalPeriod = "FiscalPeriod";
public const string Type = "Type";
public const string BusinessUnit = "BusinessUnit";
public const string Status = "Status";
public const string DateVerified = "DateVerified";
public const string Date = "Date";
public const string ControlTotal = "ControlTotal";
public const string ControlCount = "ControlCount";
public const string RestrictAccess = "RestrictAccess";
public const string SecurityRoles = "SecurityRoles";
public const string UserGroups = "UserGroups";
}
public msBatch() : base() {
ClassType = "Batch";
SecurityRoles = new System.Collections.Generic.List<System.String>();
UserGroups = new System.Collections.Generic.List<System.String>();
}
public msBatch( MemberSuiteObject msObj) : base(msObj) {}
 public static new msBatch FromClassMetadata(ClassMetadata meta){return new msBatch(MemberSuiteObject.FromClassMetadata(meta));}
public System.Boolean IsDefault {
get { return SafeGetValue<System.Boolean>("IsDefault");}
set { this["IsDefault"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.DateTime? DatePosted {
get { return SafeGetValue<System.DateTime?>("DatePosted");}
set { this["DatePosted"] = value;}
}

public System.DateTime? DateClosed {
get { return SafeGetValue<System.DateTime?>("DateClosed");}
set { this["DateClosed"] = value;}
}

public System.DateTime? DateExported {
get { return SafeGetValue<System.DateTime?>("DateExported");}
set { this["DateExported"] = value;}
}

public System.String ClosedBy {
get { return SafeGetValue<System.String>("ClosedBy");}
set { this["ClosedBy"] = value;}
}

public System.String PostedBy {
get { return SafeGetValue<System.String>("PostedBy");}
set { this["PostedBy"] = value;}
}

public System.String FiscalYear {
get { return SafeGetValue<System.String>("FiscalYear");}
set { this["FiscalYear"] = value;}
}

public System.Int32 FiscalPeriod {
get { return SafeGetValue<System.Int32>("FiscalPeriod");}
set { this["FiscalPeriod"] = value;}
}

public MemberSuite.SDK.Types.BatchType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.BatchType>("Type");}
set { this["Type"] = value;}
}

public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public MemberSuite.SDK.Types.BatchStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.BatchStatus>("Status");}
set { this["Status"] = value;}
}

public System.DateTime? DateVerified {
get { return SafeGetValue<System.DateTime?>("DateVerified");}
set { this["DateVerified"] = value;}
}

public System.DateTime Date {
get { return SafeGetValue<System.DateTime>("Date");}
set { this["Date"] = value;}
}

public System.Decimal? ControlTotal {
get { return SafeGetValue<System.Decimal?>("ControlTotal");}
set { this["ControlTotal"] = value;}
}

public System.Int32? ControlCount {
get { return SafeGetValue<System.Int32?>("ControlCount");}
set { this["ControlCount"] = value;}
}

public System.Boolean RestrictAccess {
get { return SafeGetValue<System.Boolean>("RestrictAccess");}
set { this["RestrictAccess"] = value;}
}

public System.Collections.Generic.List<System.String> SecurityRoles {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("SecurityRoles");}
set { this["SecurityRoles"] = value;}
}

public System.Collections.Generic.List<System.String> UserGroups {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("UserGroups");}
set { this["UserGroups"] = value;}
}

}
[Serializable]
public class msBatchMember : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "BatchMember";
public new  static class FIELDS {
public const string Date = "Date";
public const string Memo = "Memo";
public const string Batch = "Batch";
public const string IsVoid = "IsVoid";
public const string SourceCode = "SourceCode";
public const string MediaCode = "MediaCode";
}
public msBatchMember() : base() {
ClassType = "BatchMember";
}
public msBatchMember( MemberSuiteObject msObj) : base(msObj) {}
public System.DateTime Date {
get { return SafeGetValue<System.DateTime>("Date");}
set { this["Date"] = value;}
}

public System.String Memo {
get { return SafeGetValue<System.String>("Memo");}
set { this["Memo"] = value;}
}

public System.String Batch {
get { return SafeGetValue<System.String>("Batch");}
set { this["Batch"] = value;}
}

public System.Boolean IsVoid {
get { return SafeGetValue<System.Boolean>("IsVoid");}
set { this["IsVoid"] = value;}
}

public System.String SourceCode {
get { return SafeGetValue<System.String>("SourceCode");}
set { this["SourceCode"] = value;}
}

public System.String MediaCode {
get { return SafeGetValue<System.String>("MediaCode");}
set { this["MediaCode"] = value;}
}

}
[Serializable]
public class msFinancialSchedule : msAssociationDomainObject {
public new const string CLASS_NAME = "FinancialSchedule";
public new  static class FIELDS {
public const string IsSuspended = "IsSuspended";
}
public msFinancialSchedule() : base() {
ClassType = "FinancialSchedule";
}
public msFinancialSchedule( MemberSuiteObject msObj) : base(msObj) {}
public System.Boolean IsSuspended {
get { return SafeGetValue<System.Boolean>("IsSuspended");}
set { this["IsSuspended"] = value;}
}

}
[Serializable]
public class msBillingSchedule : msFinancialSchedule {
public new const string CLASS_NAME = "BillingSchedule";
public new  static class FIELDS {
public const string Entries = "Entries";
public const string Status = "Status";
public const string OrderLineItemID = "OrderLineItemID";
public const string Order = "Order";
public const string Notes = "Notes";
}
public msBillingSchedule() : base() {
ClassType = "BillingSchedule";
Entries = new System.Collections.Generic.List<msBillingScheduleEntry>();
}
public msBillingSchedule( MemberSuiteObject msObj) : base(msObj) {}
 public static new msBillingSchedule FromClassMetadata(ClassMetadata meta){return new msBillingSchedule(MemberSuiteObject.FromClassMetadata(meta));}
public System.Collections.Generic.List<msBillingScheduleEntry> Entries {
get { return SafeGetValue<System.Collections.Generic.List<msBillingScheduleEntry>>("Entries");}
set { this["Entries"] = value;}
}

public MemberSuite.SDK.Types.BillingScheduleStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.BillingScheduleStatus>("Status");}
set { this["Status"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msAggregateChild : msDomainObject {
public new const string CLASS_NAME = "AggregateChild";
public new  static class FIELDS {
}
public msAggregateChild() : base() {
ClassType = "AggregateChild";
}
public msAggregateChild( MemberSuiteObject msObj) : base(msObj) {}
}
[Serializable]
public class msFinancialScheduleEntry : msAggregateChild {
public new const string CLASS_NAME = "FinancialScheduleEntry";
public new  static class FIELDS {
public const string EntryID = "EntryID";
public const string DateProcessed = "DateProcessed";
public const string Date = "Date";
public const string Amount = "Amount";
}
public msFinancialScheduleEntry() : base() {
ClassType = "FinancialScheduleEntry";
}
public msFinancialScheduleEntry( MemberSuiteObject msObj) : base(msObj) {}
 public static new msFinancialScheduleEntry FromClassMetadata(ClassMetadata meta){return new msFinancialScheduleEntry(MemberSuiteObject.FromClassMetadata(meta));}
public System.String EntryID {
get { return SafeGetValue<System.String>("EntryID");}
set { this["EntryID"] = value;}
}

public System.DateTime? DateProcessed {
get { return SafeGetValue<System.DateTime?>("DateProcessed");}
set { this["DateProcessed"] = value;}
}

public System.DateTime Date {
get { return SafeGetValue<System.DateTime>("Date");}
set { this["Date"] = value;}
}

public System.Decimal Amount {
get { return SafeGetValue<System.Decimal>("Amount");}
set { this["Amount"] = value;}
}

}
[Serializable]
public class msBillingScheduleEntry : msFinancialScheduleEntry {
public new const string CLASS_NAME = "BillingScheduleEntry";
public new  static class FIELDS {
public const string Status = "Status";
public const string IsPerpetual = "IsPerpetual";
public const string Message = "Message";
public const string Invoice = "Invoice";
public const string Payment = "Payment";
}
public msBillingScheduleEntry() : base() {
ClassType = "BillingScheduleEntry";
}
public msBillingScheduleEntry( MemberSuiteObject msObj) : base(msObj) {}
 public static new msBillingScheduleEntry FromClassMetadata(ClassMetadata meta){return new msBillingScheduleEntry(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.BillingScheduleEntryStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.BillingScheduleEntryStatus>("Status");}
set { this["Status"] = value;}
}

public System.Boolean IsPerpetual {
get { return SafeGetValue<System.Boolean>("IsPerpetual");}
set { this["IsPerpetual"] = value;}
}

public System.String Message {
get { return SafeGetValue<System.String>("Message");}
set { this["Message"] = value;}
}

public System.String Invoice {
get { return SafeGetValue<System.String>("Invoice");}
set { this["Invoice"] = value;}
}

public System.String Payment {
get { return SafeGetValue<System.String>("Payment");}
set { this["Payment"] = value;}
}

}
[Serializable]
public class msBillingTemplate : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "BillingTemplate";
public new  static class FIELDS {
public const string Description = "Description";
public const string GenerateEntireInvoiceUpFront = "GenerateEntireInvoiceUpFront";
public const string RecurrenceTemplate = "RecurrenceTemplate";
}
public msBillingTemplate() : base() {
ClassType = "BillingTemplate";
}
public msBillingTemplate( MemberSuiteObject msObj) : base(msObj) {}
 public static new msBillingTemplate FromClassMetadata(ClassMetadata meta){return new msBillingTemplate(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Boolean GenerateEntireInvoiceUpFront {
get { return SafeGetValue<System.Boolean>("GenerateEntireInvoiceUpFront");}
set { this["GenerateEntireInvoiceUpFront"] = value;}
}

public MemberSuite.SDK.Types.FinancialRecurrenceTemplate RecurrenceTemplate {
get { return SafeGetValue<MemberSuite.SDK.Types.FinancialRecurrenceTemplate>("RecurrenceTemplate");}
set { this["RecurrenceTemplate"] = value;}
}

}
[Serializable]
public class msBusinessUnit : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "BusinessUnit";
public new  static class FIELDS {
public const string Description = "Description";
public const string COGSPolicy = "COGSPolicy";
public const string DefaultGLAccounts = "DefaultGLAccounts";
public const string ARAccount = "ARAccount";
public const string RevenueAccount = "RevenueAccount";
public const string DeferredRevenueAccount = "DeferredRevenueAccount";
public const string LiabilityAccount = "LiabilityAccount";
public const string WriteOffAccount = "WriteOffAccount";
public const string OverpaymentAccount = "OverpaymentAccount";
public const string CashAccount = "CashAccount";
public const string InventoryAccount = "InventoryAccount";
public const string COGSAccount = "COGSAccount";
public const string DisplayAddress = "DisplayAddress";
public const string GenerateInvoicesOnZeroDollarOrders = "GenerateInvoicesOnZeroDollarOrders";
public const string Logo = "Logo";
public const string DefaultInvoiceType = "DefaultInvoiceType";
public const string WriteOffMethod = "WriteOffMethod";
public const string AccountingMethod = "AccountingMethod";
public const string FinancialSoftwarePackage = "FinancialSoftwarePackage";
public const string BatchDownloadMethod = "BatchDownloadMethod";
public const string InvoiceReport = "InvoiceReport";
public const string PaymentReceiptReport = "PaymentReceiptReport";
public const string VerifyControlValuesWhenPostingBatches = "VerifyControlValuesWhenPostingBatches";
public const string QuickBooksOnlineCompanyID = "QuickBooksOnlineCompanyID";
public const string QuickBooksOnlineAppToken = "QuickBooksOnlineAppToken";
public const string CashPaymentMethodCashAccount = "CashPaymentMethodCashAccount";
public const string CheckPaymentMethodCashAccount = "CheckPaymentMethodCashAccount";
public const string MoneyOrderPaymentMethodCashAccount = "MoneyOrderPaymentMethodCashAccount";
public const string CashiersCheckPaymentMethodCashAccount = "CashiersCheckPaymentMethodCashAccount";
public const string PurchaseOrderPaymentMethodCashAccount = "PurchaseOrderPaymentMethodCashAccount";
public const string PayrollDeductionPaymentMethodCashAccount = "PayrollDeductionPaymentMethodCashAccount";
public const string OtherPaymentMethodCashAccount = "OtherPaymentMethodCashAccount";
public const string IsDefault = "IsDefault";
}
public msBusinessUnit() : base() {
ClassType = "BusinessUnit";
DefaultGLAccounts = new System.Collections.Generic.List<msDefaultGLAccountProfile>();
}
public msBusinessUnit( MemberSuiteObject msObj) : base(msObj) {}
 public static new msBusinessUnit FromClassMetadata(ClassMetadata meta){return new msBusinessUnit(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public MemberSuite.SDK.Types.COGSPolicy COGSPolicy {
get { return SafeGetValue<MemberSuite.SDK.Types.COGSPolicy>("COGSPolicy");}
set { this["COGSPolicy"] = value;}
}

public System.Collections.Generic.List<msDefaultGLAccountProfile> DefaultGLAccounts {
get { return SafeGetValue<System.Collections.Generic.List<msDefaultGLAccountProfile>>("DefaultGLAccounts");}
set { this["DefaultGLAccounts"] = value;}
}

public System.String ARAccount {
get { return SafeGetValue<System.String>("ARAccount");}
set { this["ARAccount"] = value;}
}

public System.String RevenueAccount {
get { return SafeGetValue<System.String>("RevenueAccount");}
set { this["RevenueAccount"] = value;}
}

public System.String DeferredRevenueAccount {
get { return SafeGetValue<System.String>("DeferredRevenueAccount");}
set { this["DeferredRevenueAccount"] = value;}
}

public System.String LiabilityAccount {
get { return SafeGetValue<System.String>("LiabilityAccount");}
set { this["LiabilityAccount"] = value;}
}

public System.String WriteOffAccount {
get { return SafeGetValue<System.String>("WriteOffAccount");}
set { this["WriteOffAccount"] = value;}
}

public System.String OverpaymentAccount {
get { return SafeGetValue<System.String>("OverpaymentAccount");}
set { this["OverpaymentAccount"] = value;}
}

public System.String CashAccount {
get { return SafeGetValue<System.String>("CashAccount");}
set { this["CashAccount"] = value;}
}

public System.String InventoryAccount {
get { return SafeGetValue<System.String>("InventoryAccount");}
set { this["InventoryAccount"] = value;}
}

public System.String COGSAccount {
get { return SafeGetValue<System.String>("COGSAccount");}
set { this["COGSAccount"] = value;}
}

public System.String DisplayAddress {
get { return SafeGetValue<System.String>("DisplayAddress");}
set { this["DisplayAddress"] = value;}
}

public System.Boolean GenerateInvoicesOnZeroDollarOrders {
get { return SafeGetValue<System.Boolean>("GenerateInvoicesOnZeroDollarOrders");}
set { this["GenerateInvoicesOnZeroDollarOrders"] = value;}
}

public System.String Logo {
get { return SafeGetValue<System.String>("Logo");}
set { this["Logo"] = value;}
}

public System.String DefaultInvoiceType {
get { return SafeGetValue<System.String>("DefaultInvoiceType");}
set { this["DefaultInvoiceType"] = value;}
}

public MemberSuite.SDK.Types.WriteOffMethod WriteOffMethod {
get { return SafeGetValue<MemberSuite.SDK.Types.WriteOffMethod>("WriteOffMethod");}
set { this["WriteOffMethod"] = value;}
}

public MemberSuite.SDK.Types.AccountingMethod AccountingMethod {
get { return SafeGetValue<MemberSuite.SDK.Types.AccountingMethod>("AccountingMethod");}
set { this["AccountingMethod"] = value;}
}

public MemberSuite.SDK.Types.FinancialSoftwarePackage FinancialSoftwarePackage {
get { return SafeGetValue<MemberSuite.SDK.Types.FinancialSoftwarePackage>("FinancialSoftwarePackage");}
set { this["FinancialSoftwarePackage"] = value;}
}

public MemberSuite.SDK.Types.BatchDownloadMethod BatchDownloadMethod {
get { return SafeGetValue<MemberSuite.SDK.Types.BatchDownloadMethod>("BatchDownloadMethod");}
set { this["BatchDownloadMethod"] = value;}
}

public System.String InvoiceReport {
get { return SafeGetValue<System.String>("InvoiceReport");}
set { this["InvoiceReport"] = value;}
}

public System.String PaymentReceiptReport {
get { return SafeGetValue<System.String>("PaymentReceiptReport");}
set { this["PaymentReceiptReport"] = value;}
}

public System.Boolean VerifyControlValuesWhenPostingBatches {
get { return SafeGetValue<System.Boolean>("VerifyControlValuesWhenPostingBatches");}
set { this["VerifyControlValuesWhenPostingBatches"] = value;}
}

public System.String QuickBooksOnlineCompanyID {
get { return SafeGetValue<System.String>("QuickBooksOnlineCompanyID");}
set { this["QuickBooksOnlineCompanyID"] = value;}
}

public System.String QuickBooksOnlineAppToken {
get { return SafeGetValue<System.String>("QuickBooksOnlineAppToken");}
set { this["QuickBooksOnlineAppToken"] = value;}
}

public System.String CashPaymentMethodCashAccount {
get { return SafeGetValue<System.String>("CashPaymentMethodCashAccount");}
set { this["CashPaymentMethodCashAccount"] = value;}
}

public System.String CheckPaymentMethodCashAccount {
get { return SafeGetValue<System.String>("CheckPaymentMethodCashAccount");}
set { this["CheckPaymentMethodCashAccount"] = value;}
}

public System.String MoneyOrderPaymentMethodCashAccount {
get { return SafeGetValue<System.String>("MoneyOrderPaymentMethodCashAccount");}
set { this["MoneyOrderPaymentMethodCashAccount"] = value;}
}

public System.String CashiersCheckPaymentMethodCashAccount {
get { return SafeGetValue<System.String>("CashiersCheckPaymentMethodCashAccount");}
set { this["CashiersCheckPaymentMethodCashAccount"] = value;}
}

public System.String PurchaseOrderPaymentMethodCashAccount {
get { return SafeGetValue<System.String>("PurchaseOrderPaymentMethodCashAccount");}
set { this["PurchaseOrderPaymentMethodCashAccount"] = value;}
}

public System.String PayrollDeductionPaymentMethodCashAccount {
get { return SafeGetValue<System.String>("PayrollDeductionPaymentMethodCashAccount");}
set { this["PayrollDeductionPaymentMethodCashAccount"] = value;}
}

public System.String OtherPaymentMethodCashAccount {
get { return SafeGetValue<System.String>("OtherPaymentMethodCashAccount");}
set { this["OtherPaymentMethodCashAccount"] = value;}
}

public System.Boolean IsDefault {
get { return SafeGetValue<System.Boolean>("IsDefault");}
set { this["IsDefault"] = value;}
}

}
[Serializable]
public class msDefaultGLAccountProfile : msAggregateChild {
public new const string CLASS_NAME = "DefaultGLAccountProfile";
public new  static class FIELDS {
public const string ProductType = "ProductType";
public const string ARAccount = "ARAccount";
public const string RevenueAccount = "RevenueAccount";
public const string DeferredRevenueAccount = "DeferredRevenueAccount";
public const string LiabilityAccount = "LiabilityAccount";
public const string WriteOffAccount = "WriteOffAccount";
public const string OverpaymentAccount = "OverpaymentAccount";
}
public msDefaultGLAccountProfile() : base() {
ClassType = "DefaultGLAccountProfile";
}
public msDefaultGLAccountProfile( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDefaultGLAccountProfile FromClassMetadata(ClassMetadata meta){return new msDefaultGLAccountProfile(MemberSuiteObject.FromClassMetadata(meta));}
public System.String ProductType {
get { return SafeGetValue<System.String>("ProductType");}
set { this["ProductType"] = value;}
}

public System.String ARAccount {
get { return SafeGetValue<System.String>("ARAccount");}
set { this["ARAccount"] = value;}
}

public System.String RevenueAccount {
get { return SafeGetValue<System.String>("RevenueAccount");}
set { this["RevenueAccount"] = value;}
}

public System.String DeferredRevenueAccount {
get { return SafeGetValue<System.String>("DeferredRevenueAccount");}
set { this["DeferredRevenueAccount"] = value;}
}

public System.String LiabilityAccount {
get { return SafeGetValue<System.String>("LiabilityAccount");}
set { this["LiabilityAccount"] = value;}
}

public System.String WriteOffAccount {
get { return SafeGetValue<System.String>("WriteOffAccount");}
set { this["WriteOffAccount"] = value;}
}

public System.String OverpaymentAccount {
get { return SafeGetValue<System.String>("OverpaymentAccount");}
set { this["OverpaymentAccount"] = value;}
}

}
[Serializable]
public class msProduct : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "Product";
public new  static class FIELDS {
public const string Code = "Code";
public const string IsActive = "IsActive";
public const string BusinessUnit = "BusinessUnit";
public const string Category = "Category";
public const string DisplayOrder = "DisplayOrder";
public const string Description = "Description";
public const string ConfirmationEmail = "ConfirmationEmail";
public const string SellOnline = "SellOnline";
public const string SellFrom = "SellFrom";
public const string SellUntil = "SellUntil";
public const string NewUntil = "NewUntil";
public const string Price = "Price";
public const string AllowCustomersToPayLater = "AllowCustomersToPayLater";
public const string MemberPrice = "MemberPrice";
public const string UseSpecialPricesOnly = "UseSpecialPricesOnly";
public const string DisplayPriceAs = "DisplayPriceAs";
public const string TrackInventory = "TrackInventory";
public const string Weight = "Weight";
public const string AllowBackOrders = "AllowBackOrders";
public const string EligibleForShippingCharges = "EligibleForShippingCharges";
public const string Taxable = "Taxable";
public const string TaxTable = "TaxTable";
public const string ProrationTable = "ProrationTable";
public const string SpecialPrices = "SpecialPrices";
public const string PurchaseRestrictions = "PurchaseRestrictions";
public const string LinkedProducts = "LinkedProducts";
public const string LinkedEntitlements = "LinkedEntitlements";
public const string Project = "Project";
public const string ARAccount = "ARAccount";
public const string RevenueAccount = "RevenueAccount";
public const string DeferredRevenueAccount = "DeferredRevenueAccount";
public const string WriteOffAccount = "WriteOffAccount";
public const string InventoryAccount = "InventoryAccount";
public const string COGSAccount = "COGSAccount";
public const string RevenueSplits = "RevenueSplits";
public const string CEUCredits = "CEUCredits";
public const string RevenueRecognitionTemplate = "RevenueRecognitionTemplate";
public const string Vendor = "Vendor";
public const string BillingTemplate = "BillingTemplate";
public const string DefaultWarehouse = "DefaultWarehouse";
public const string ShowOnMembershipForm = "ShowOnMembershipForm";
public const string UseShipToForPriceCalculation = "UseShipToForPriceCalculation";
public const string Image = "Image";
public const string ReorderPoint = "ReorderPoint";
public const string RealtorCategory = "RealtorCategory";
}
public msProduct() : base() {
ClassType = "Product";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msProduct( MemberSuiteObject msObj) : base(msObj) {}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public System.String Category {
get { return SafeGetValue<System.String>("Category");}
set { this["Category"] = value;}
}

public System.Int32? DisplayOrder {
get { return SafeGetValue<System.Int32?>("DisplayOrder");}
set { this["DisplayOrder"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String ConfirmationEmail {
get { return SafeGetValue<System.String>("ConfirmationEmail");}
set { this["ConfirmationEmail"] = value;}
}

public System.Boolean SellOnline {
get { return SafeGetValue<System.Boolean>("SellOnline");}
set { this["SellOnline"] = value;}
}

public System.DateTime? SellFrom {
get { return SafeGetValue<System.DateTime?>("SellFrom");}
set { this["SellFrom"] = value;}
}

public System.DateTime? SellUntil {
get { return SafeGetValue<System.DateTime?>("SellUntil");}
set { this["SellUntil"] = value;}
}

public System.DateTime? NewUntil {
get { return SafeGetValue<System.DateTime?>("NewUntil");}
set { this["NewUntil"] = value;}
}

public System.Decimal Price {
get { return SafeGetValue<System.Decimal>("Price");}
set { this["Price"] = value;}
}

public System.Boolean AllowCustomersToPayLater {
get { return SafeGetValue<System.Boolean>("AllowCustomersToPayLater");}
set { this["AllowCustomersToPayLater"] = value;}
}

public System.Decimal? MemberPrice {
get { return SafeGetValue<System.Decimal?>("MemberPrice");}
set { this["MemberPrice"] = value;}
}

public System.Boolean UseSpecialPricesOnly {
get { return SafeGetValue<System.Boolean>("UseSpecialPricesOnly");}
set { this["UseSpecialPricesOnly"] = value;}
}

public System.String DisplayPriceAs {
get { return SafeGetValue<System.String>("DisplayPriceAs");}
set { this["DisplayPriceAs"] = value;}
}

public System.Boolean TrackInventory {
get { return SafeGetValue<System.Boolean>("TrackInventory");}
set { this["TrackInventory"] = value;}
}

public System.Decimal? Weight {
get { return SafeGetValue<System.Decimal?>("Weight");}
set { this["Weight"] = value;}
}

public System.Boolean AllowBackOrders {
get { return SafeGetValue<System.Boolean>("AllowBackOrders");}
set { this["AllowBackOrders"] = value;}
}

public System.Boolean EligibleForShippingCharges {
get { return SafeGetValue<System.Boolean>("EligibleForShippingCharges");}
set { this["EligibleForShippingCharges"] = value;}
}

public System.Boolean Taxable {
get { return SafeGetValue<System.Boolean>("Taxable");}
set { this["Taxable"] = value;}
}

public System.String TaxTable {
get { return SafeGetValue<System.String>("TaxTable");}
set { this["TaxTable"] = value;}
}

public System.String ProrationTable {
get { return SafeGetValue<System.String>("ProrationTable");}
set { this["ProrationTable"] = value;}
}

public System.Collections.Generic.List<msSpecialPrice> SpecialPrices {
get { return SafeGetValue<System.Collections.Generic.List<msSpecialPrice>>("SpecialPrices");}
set { this["SpecialPrices"] = value;}
}

public System.Collections.Generic.List<msPurchaseRestriction> PurchaseRestrictions {
get { return SafeGetValue<System.Collections.Generic.List<msPurchaseRestriction>>("PurchaseRestrictions");}
set { this["PurchaseRestrictions"] = value;}
}

public System.Collections.Generic.List<msProductLinkage> LinkedProducts {
get { return SafeGetValue<System.Collections.Generic.List<msProductLinkage>>("LinkedProducts");}
set { this["LinkedProducts"] = value;}
}

public System.Collections.Generic.List<msLinkedEntitlement> LinkedEntitlements {
get { return SafeGetValue<System.Collections.Generic.List<msLinkedEntitlement>>("LinkedEntitlements");}
set { this["LinkedEntitlements"] = value;}
}

public System.String Project {
get { return SafeGetValue<System.String>("Project");}
set { this["Project"] = value;}
}

public System.String ARAccount {
get { return SafeGetValue<System.String>("ARAccount");}
set { this["ARAccount"] = value;}
}

public System.String RevenueAccount {
get { return SafeGetValue<System.String>("RevenueAccount");}
set { this["RevenueAccount"] = value;}
}

public System.String DeferredRevenueAccount {
get { return SafeGetValue<System.String>("DeferredRevenueAccount");}
set { this["DeferredRevenueAccount"] = value;}
}

public System.String WriteOffAccount {
get { return SafeGetValue<System.String>("WriteOffAccount");}
set { this["WriteOffAccount"] = value;}
}

public System.String InventoryAccount {
get { return SafeGetValue<System.String>("InventoryAccount");}
set { this["InventoryAccount"] = value;}
}

public System.String COGSAccount {
get { return SafeGetValue<System.String>("COGSAccount");}
set { this["COGSAccount"] = value;}
}

public System.Collections.Generic.List<msRevenueSplit> RevenueSplits {
get { return SafeGetValue<System.Collections.Generic.List<msRevenueSplit>>("RevenueSplits");}
set { this["RevenueSplits"] = value;}
}

public System.Collections.Generic.List<msLinkedCEUCredit> CEUCredits {
get { return SafeGetValue<System.Collections.Generic.List<msLinkedCEUCredit>>("CEUCredits");}
set { this["CEUCredits"] = value;}
}

public System.String RevenueRecognitionTemplate {
get { return SafeGetValue<System.String>("RevenueRecognitionTemplate");}
set { this["RevenueRecognitionTemplate"] = value;}
}

public System.String Vendor {
get { return SafeGetValue<System.String>("Vendor");}
set { this["Vendor"] = value;}
}

public System.String BillingTemplate {
get { return SafeGetValue<System.String>("BillingTemplate");}
set { this["BillingTemplate"] = value;}
}

public System.String DefaultWarehouse {
get { return SafeGetValue<System.String>("DefaultWarehouse");}
set { this["DefaultWarehouse"] = value;}
}

public System.Boolean ShowOnMembershipForm {
get { return SafeGetValue<System.Boolean>("ShowOnMembershipForm");}
set { this["ShowOnMembershipForm"] = value;}
}

public System.Boolean UseShipToForPriceCalculation {
get { return SafeGetValue<System.Boolean>("UseShipToForPriceCalculation");}
set { this["UseShipToForPriceCalculation"] = value;}
}

public System.String Image {
get { return SafeGetValue<System.String>("Image");}
set { this["Image"] = value;}
}

public System.Decimal? ReorderPoint {
get { return SafeGetValue<System.Decimal?>("ReorderPoint");}
set { this["ReorderPoint"] = value;}
}

public MemberSuite.SDK.Types.RealtorProductCategory RealtorCategory {
get { return SafeGetValue<MemberSuite.SDK.Types.RealtorProductCategory>("RealtorCategory");}
set { this["RealtorCategory"] = value;}
}

}
[Serializable]
public class msCancellationFee : msProduct {
public new const string CLASS_NAME = "CancellationFee";
public new  static class FIELDS {
}
public msCancellationFee() : base() {
ClassType = "CancellationFee";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msCancellationFee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCancellationFee FromClassMetadata(ClassMetadata meta){return new msCancellationFee(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msCredit : msBatchMember {
public new const string CLASS_NAME = "Credit";
public new  static class FIELDS {
public const string BillTo = "BillTo";
public const string InvoiceAdjustment = "InvoiceAdjustment";
public const string Invoice = "Invoice";
public const string ExpenseAccount = "ExpenseAccount";
public const string LiabilityAccount = "LiabilityAccount";
public const string UseFrom = "UseFrom";
public const string UseThrough = "UseThrough";
public const string Notes = "Notes";
public const string Total = "Total";
public const string AmountUsed = "AmountUsed";
}
public msCredit() : base() {
ClassType = "Credit";
}
public msCredit( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCredit FromClassMetadata(ClassMetadata meta){return new msCredit(MemberSuiteObject.FromClassMetadata(meta));}
public System.String BillTo {
get { return SafeGetValue<System.String>("BillTo");}
set { this["BillTo"] = value;}
}

public System.String InvoiceAdjustment {
get { return SafeGetValue<System.String>("InvoiceAdjustment");}
set { this["InvoiceAdjustment"] = value;}
}

public System.String Invoice {
get { return SafeGetValue<System.String>("Invoice");}
set { this["Invoice"] = value;}
}

public System.String ExpenseAccount {
get { return SafeGetValue<System.String>("ExpenseAccount");}
set { this["ExpenseAccount"] = value;}
}

public System.String LiabilityAccount {
get { return SafeGetValue<System.String>("LiabilityAccount");}
set { this["LiabilityAccount"] = value;}
}

public System.DateTime? UseFrom {
get { return SafeGetValue<System.DateTime?>("UseFrom");}
set { this["UseFrom"] = value;}
}

public System.DateTime? UseThrough {
get { return SafeGetValue<System.DateTime?>("UseThrough");}
set { this["UseThrough"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Decimal Total {
get { return SafeGetValue<System.Decimal>("Total");}
set { this["Total"] = value;}
}

public System.Decimal AmountUsed {
get { return SafeGetValue<System.Decimal>("AmountUsed");}
set { this["AmountUsed"] = value;}
}

}
[Serializable]
public class msExpense : msAssociationDomainObject {
public new const string CLASS_NAME = "Expense";
public new  static class FIELDS {
public const string Type = "Type";
public const string Date = "Date";
public const string Amount = "Amount";
public const string Description = "Description";
}
public msExpense() : base() {
ClassType = "Expense";
}
public msExpense( MemberSuiteObject msObj) : base(msObj) {}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.DateTime Date {
get { return SafeGetValue<System.DateTime>("Date");}
set { this["Date"] = value;}
}

public System.Decimal Amount {
get { return SafeGetValue<System.Decimal>("Amount");}
set { this["Amount"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msConfigurableType : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "ConfigurableType";
public new  static class FIELDS {
public const string Description = "Description";
public const string Code = "Code";
public const string DisplayOrder = "DisplayOrder";
public const string IsDefault = "IsDefault";
}
public msConfigurableType() : base() {
ClassType = "ConfigurableType";
}
public msConfigurableType( MemberSuiteObject msObj) : base(msObj) {}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.Int32? DisplayOrder {
get { return SafeGetValue<System.Int32?>("DisplayOrder");}
set { this["DisplayOrder"] = value;}
}

public System.Boolean IsDefault {
get { return SafeGetValue<System.Boolean>("IsDefault");}
set { this["IsDefault"] = value;}
}

}
[Serializable]
public class msExpenseType : msConfigurableType {
public new const string CLASS_NAME = "ExpenseType";
public new  static class FIELDS {
}
public msExpenseType() : base() {
ClassType = "ExpenseType";
}
public msExpenseType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExpenseType FromClassMetadata(ClassMetadata meta){return new msExpenseType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msCustomizableAssociationDomainObject : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "CustomizableAssociationDomainObject";
public new  static class FIELDS {
}
public msCustomizableAssociationDomainObject() : base() {
ClassType = "CustomizableAssociationDomainObject";
}
public msCustomizableAssociationDomainObject( MemberSuiteObject msObj) : base(msObj) {}
}
[Serializable]
public class msHistoricalTransaction : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "HistoricalTransaction";
public new  static class FIELDS {
public const string Date = "Date";
public const string Type = "Type";
public const string Memo = "Memo";
public const string Owner = "Owner";
public const string Order = "Order";
public const string Total = "Total";
public const string LineItems = "LineItems";
public const string ReferenceNumber = "ReferenceNumber";
public const string Notes = "Notes";
}
public msHistoricalTransaction() : base() {
ClassType = "HistoricalTransaction";
LineItems = new System.Collections.Generic.List<msHistoricalTransactionLineItem>();
}
public msHistoricalTransaction( MemberSuiteObject msObj) : base(msObj) {}
 public static new msHistoricalTransaction FromClassMetadata(ClassMetadata meta){return new msHistoricalTransaction(MemberSuiteObject.FromClassMetadata(meta));}
public System.DateTime Date {
get { return SafeGetValue<System.DateTime>("Date");}
set { this["Date"] = value;}
}

public MemberSuite.SDK.Types.HistoricalTransactionType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.HistoricalTransactionType>("Type");}
set { this["Type"] = value;}
}

public System.String Memo {
get { return SafeGetValue<System.String>("Memo");}
set { this["Memo"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.Decimal Total {
get { return SafeGetValue<System.Decimal>("Total");}
set { this["Total"] = value;}
}

public System.Collections.Generic.List<msHistoricalTransactionLineItem> LineItems {
get { return SafeGetValue<System.Collections.Generic.List<msHistoricalTransactionLineItem>>("LineItems");}
set { this["LineItems"] = value;}
}

public System.String ReferenceNumber {
get { return SafeGetValue<System.String>("ReferenceNumber");}
set { this["ReferenceNumber"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msHistoricalTransactionLineItem : msAggregateChild {
public new const string CLASS_NAME = "HistoricalTransactionLineItem";
public new  static class FIELDS {
public const string Quantity = "Quantity";
public const string UnitPrice = "UnitPrice";
public const string Description = "Description";
public const string Total = "Total";
}
public msHistoricalTransactionLineItem() : base() {
ClassType = "HistoricalTransactionLineItem";
}
public msHistoricalTransactionLineItem( MemberSuiteObject msObj) : base(msObj) {}
 public static new msHistoricalTransactionLineItem FromClassMetadata(ClassMetadata meta){return new msHistoricalTransactionLineItem(MemberSuiteObject.FromClassMetadata(meta));}
public System.Decimal Quantity {
get { return SafeGetValue<System.Decimal>("Quantity");}
set { this["Quantity"] = value;}
}

public System.Decimal UnitPrice {
get { return SafeGetValue<System.Decimal>("UnitPrice");}
set { this["UnitPrice"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Decimal Total {
get { return SafeGetValue<System.Decimal>("Total");}
set { this["Total"] = value;}
}

}
[Serializable]
public class msInvoiceAdjustment : msBatchMember {
public new const string CLASS_NAME = "InvoiceAdjustment";
public new  static class FIELDS {
public const string Invoice = "Invoice";
public const string Total = "Total";
public const string LineItems = "LineItems";
}
public msInvoiceAdjustment() : base() {
ClassType = "InvoiceAdjustment";
LineItems = new System.Collections.Generic.List<msInvoiceAdjustmentLineItem>();
}
public msInvoiceAdjustment( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInvoiceAdjustment FromClassMetadata(ClassMetadata meta){return new msInvoiceAdjustment(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Invoice {
get { return SafeGetValue<System.String>("Invoice");}
set { this["Invoice"] = value;}
}

public System.Decimal Total {
get { return SafeGetValue<System.Decimal>("Total");}
set { this["Total"] = value;}
}

public System.Collections.Generic.List<msInvoiceAdjustmentLineItem> LineItems {
get { return SafeGetValue<System.Collections.Generic.List<msInvoiceAdjustmentLineItem>>("LineItems");}
set { this["LineItems"] = value;}
}

}
[Serializable]
public class msInvoiceAdjustmentLineItem : msAggregateChild {
public new const string CLASS_NAME = "InvoiceAdjustmentLineItem";
public new  static class FIELDS {
public const string InvoiceLineItemID = "InvoiceLineItemID";
public const string Description = "Description";
public const string Total = "Total";
}
public msInvoiceAdjustmentLineItem() : base() {
ClassType = "InvoiceAdjustmentLineItem";
}
public msInvoiceAdjustmentLineItem( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInvoiceAdjustmentLineItem FromClassMetadata(ClassMetadata meta){return new msInvoiceAdjustmentLineItem(MemberSuiteObject.FromClassMetadata(meta));}
public System.String InvoiceLineItemID {
get { return SafeGetValue<System.String>("InvoiceLineItemID");}
set { this["InvoiceLineItemID"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Decimal Total {
get { return SafeGetValue<System.Decimal>("Total");}
set { this["Total"] = value;}
}

}
[Serializable]
public class msFiscalYear : msAssociationDomainObject {
public new const string CLASS_NAME = "FiscalYear";
public new  static class FIELDS {
public const string Year = "Year";
public const string BusinessUnit = "BusinessUnit";
public const string IsClosed = "IsClosed";
public const string ClosedBy = "ClosedBy";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string Periods = "Periods";
}
public msFiscalYear() : base() {
ClassType = "FiscalYear";
Periods = new System.Collections.Generic.List<msFiscalPeriod>();
}
public msFiscalYear( MemberSuiteObject msObj) : base(msObj) {}
 public static new msFiscalYear FromClassMetadata(ClassMetadata meta){return new msFiscalYear(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int32 Year {
get { return SafeGetValue<System.Int32>("Year");}
set { this["Year"] = value;}
}

public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public System.Boolean IsClosed {
get { return SafeGetValue<System.Boolean>("IsClosed");}
set { this["IsClosed"] = value;}
}

public System.String ClosedBy {
get { return SafeGetValue<System.String>("ClosedBy");}
set { this["ClosedBy"] = value;}
}

public System.DateTime StartDate {
get { return SafeGetValue<System.DateTime>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime EndDate {
get { return SafeGetValue<System.DateTime>("EndDate");}
set { this["EndDate"] = value;}
}

public System.Collections.Generic.List<msFiscalPeriod> Periods {
get { return SafeGetValue<System.Collections.Generic.List<msFiscalPeriod>>("Periods");}
set { this["Periods"] = value;}
}

}
[Serializable]
public class msFiscalPeriod : msAggregateChild {
public new const string CLASS_NAME = "FiscalPeriod";
public new  static class FIELDS {
public const string Name = "Name";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string IsClosed = "IsClosed";
}
public msFiscalPeriod() : base() {
ClassType = "FiscalPeriod";
}
public msFiscalPeriod( MemberSuiteObject msObj) : base(msObj) {}
 public static new msFiscalPeriod FromClassMetadata(ClassMetadata meta){return new msFiscalPeriod(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Name {
get { return SafeGetValue<System.String>("Name");}
set { this["Name"] = value;}
}

public System.DateTime StartDate {
get { return SafeGetValue<System.DateTime>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime EndDate {
get { return SafeGetValue<System.DateTime>("EndDate");}
set { this["EndDate"] = value;}
}

public System.Boolean IsClosed {
get { return SafeGetValue<System.Boolean>("IsClosed");}
set { this["IsClosed"] = value;}
}

}
[Serializable]
public class msInvoiceType : msConfigurableType {
public new const string CLASS_NAME = "InvoiceType";
public new  static class FIELDS {
public const string CustomReport = "CustomReport";
}
public msInvoiceType() : base() {
ClassType = "InvoiceType";
}
public msInvoiceType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInvoiceType FromClassMetadata(ClassMetadata meta){return new msInvoiceType(MemberSuiteObject.FromClassMetadata(meta));}
public System.String CustomReport {
get { return SafeGetValue<System.String>("CustomReport");}
set { this["CustomReport"] = value;}
}

}
[Serializable]
public class msLegacyProduct : msProduct {
public new const string CLASS_NAME = "LegacyProduct";
public new  static class FIELDS {
}
public msLegacyProduct() : base() {
ClassType = "LegacyProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msLegacyProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLegacyProduct FromClassMetadata(ClassMetadata meta){return new msLegacyProduct(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msMerchantAccount : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "MerchantAccount";
public new  static class FIELDS {
public const string Description = "Description";
public const string BusinessUnit = "BusinessUnit";
public const string CashAccount = "CashAccount";
public const string IsDefault = "IsDefault";
public const string DefaultBatch = "DefaultBatch";
public const string CutOffHour = "CutOffHour";
public const string TermsOfService = "TermsOfService";
public const string IsExternalAccount = "IsExternalAccount";
public const string Chapter = "Chapter";
public const string OrganizationalLayer = "OrganizationalLayer";
public const string Section = "Section";
}
public msMerchantAccount() : base() {
ClassType = "MerchantAccount";
}
public msMerchantAccount( MemberSuiteObject msObj) : base(msObj) {}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public System.String CashAccount {
get { return SafeGetValue<System.String>("CashAccount");}
set { this["CashAccount"] = value;}
}

public System.Boolean IsDefault {
get { return SafeGetValue<System.Boolean>("IsDefault");}
set { this["IsDefault"] = value;}
}

public System.String DefaultBatch {
get { return SafeGetValue<System.String>("DefaultBatch");}
set { this["DefaultBatch"] = value;}
}

public System.Int32 CutOffHour {
get { return SafeGetValue<System.Int32>("CutOffHour");}
set { this["CutOffHour"] = value;}
}

public System.String TermsOfService {
get { return SafeGetValue<System.String>("TermsOfService");}
set { this["TermsOfService"] = value;}
}

public System.Boolean IsExternalAccount {
get { return SafeGetValue<System.Boolean>("IsExternalAccount");}
set { this["IsExternalAccount"] = value;}
}

public System.String Chapter {
get { return SafeGetValue<System.String>("Chapter");}
set { this["Chapter"] = value;}
}

public System.String OrganizationalLayer {
get { return SafeGetValue<System.String>("OrganizationalLayer");}
set { this["OrganizationalLayer"] = value;}
}

public System.String Section {
get { return SafeGetValue<System.String>("Section");}
set { this["Section"] = value;}
}

}
[Serializable]
public class msTermsOfServiceAgreement : msAssociationDomainObject {
public new const string CLASS_NAME = "TermsOfServiceAgreement";
public new  static class FIELDS {
public const string Individual = "Individual";
public const string Version = "Version";
public const string AgreementDate = "AgreementDate";
public const string AcknowledgmentText = "AcknowledgmentText";
}
public msTermsOfServiceAgreement() : base() {
ClassType = "TermsOfServiceAgreement";
}
public msTermsOfServiceAgreement( MemberSuiteObject msObj) : base(msObj) {}
public System.String Individual {
get { return SafeGetValue<System.String>("Individual");}
set { this["Individual"] = value;}
}

public System.String Version {
get { return SafeGetValue<System.String>("Version");}
set { this["Version"] = value;}
}

public System.DateTime AgreementDate {
get { return SafeGetValue<System.DateTime>("AgreementDate");}
set { this["AgreementDate"] = value;}
}

public System.String AcknowledgmentText {
get { return SafeGetValue<System.String>("AcknowledgmentText");}
set { this["AcknowledgmentText"] = value;}
}

}
[Serializable]
public class msMerchantAccountTermsOfServiceAgreement : msTermsOfServiceAgreement {
public new const string CLASS_NAME = "MerchantAccountTermsOfServiceAgreement";
public new  static class FIELDS {
}
public msMerchantAccountTermsOfServiceAgreement() : base() {
ClassType = "MerchantAccountTermsOfServiceAgreement";
}
public msMerchantAccountTermsOfServiceAgreement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMerchantAccountTermsOfServiceAgreement FromClassMetadata(ClassMetadata meta){return new msMerchantAccountTermsOfServiceAgreement(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msMiscellaneousProduct : msProduct {
public new const string CLASS_NAME = "MiscellaneousProduct";
public new  static class FIELDS {
}
public msMiscellaneousProduct() : base() {
ClassType = "MiscellaneousProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msMiscellaneousProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMiscellaneousProduct FromClassMetadata(ClassMetadata meta){return new msMiscellaneousProduct(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAuthorizeNetMerchantAccount : msMerchantAccount {
public new const string CLASS_NAME = "AuthorizeNetMerchantAccount";
public new  static class FIELDS {
public const string MerchantLoginID = "MerchantLoginID";
public const string TransactionKey = "TransactionKey";
}
public msAuthorizeNetMerchantAccount() : base() {
ClassType = "AuthorizeNetMerchantAccount";
}
public msAuthorizeNetMerchantAccount( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAuthorizeNetMerchantAccount FromClassMetadata(ClassMetadata meta){return new msAuthorizeNetMerchantAccount(MemberSuiteObject.FromClassMetadata(meta));}
public System.String MerchantLoginID {
get { return SafeGetValue<System.String>("MerchantLoginID");}
set { this["MerchantLoginID"] = value;}
}

public System.String TransactionKey {
get { return SafeGetValue<System.String>("TransactionKey");}
set { this["TransactionKey"] = value;}
}

}
[Serializable]
public class msEnarMerchantAccount : msMerchantAccount {
public new const string CLASS_NAME = "EnarMerchantAccount";
public new  static class FIELDS {
public const string Partner = "Partner";
public const string UserName = "UserName";
public const string Password = "Password";
public const string MerchantLoginID = "MerchantLoginID";
}
public msEnarMerchantAccount() : base() {
ClassType = "EnarMerchantAccount";
}
public msEnarMerchantAccount( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEnarMerchantAccount FromClassMetadata(ClassMetadata meta){return new msEnarMerchantAccount(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Partner {
get { return SafeGetValue<System.String>("Partner");}
set { this["Partner"] = value;}
}

public System.String UserName {
get { return SafeGetValue<System.String>("UserName");}
set { this["UserName"] = value;}
}

public System.String Password {
get { return SafeGetValue<System.String>("Password");}
set { this["Password"] = value;}
}

public System.String MerchantLoginID {
get { return SafeGetValue<System.String>("MerchantLoginID");}
set { this["MerchantLoginID"] = value;}
}

}
[Serializable]
public class msPayFlowProMerchantAccount : msMerchantAccount {
public new const string CLASS_NAME = "PayFlowProMerchantAccount";
public new  static class FIELDS {
public const string MerchantLoginID = "MerchantLoginID";
public const string Partner = "Partner";
public const string Password = "Password";
}
public msPayFlowProMerchantAccount() : base() {
ClassType = "PayFlowProMerchantAccount";
}
public msPayFlowProMerchantAccount( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPayFlowProMerchantAccount FromClassMetadata(ClassMetadata meta){return new msPayFlowProMerchantAccount(MemberSuiteObject.FromClassMetadata(meta));}
public System.String MerchantLoginID {
get { return SafeGetValue<System.String>("MerchantLoginID");}
set { this["MerchantLoginID"] = value;}
}

public System.String Partner {
get { return SafeGetValue<System.String>("Partner");}
set { this["Partner"] = value;}
}

public System.String Password {
get { return SafeGetValue<System.String>("Password");}
set { this["Password"] = value;}
}

}
[Serializable]
public class msPayPalMerchantAccount : msMerchantAccount {
public new const string CLASS_NAME = "PayPalMerchantAccount";
public new  static class FIELDS {
public const string UserName = "UserName";
public const string Password = "Password";
public const string APISignature = "APISignature";
}
public msPayPalMerchantAccount() : base() {
ClassType = "PayPalMerchantAccount";
}
public msPayPalMerchantAccount( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPayPalMerchantAccount FromClassMetadata(ClassMetadata meta){return new msPayPalMerchantAccount(MemberSuiteObject.FromClassMetadata(meta));}
public System.String UserName {
get { return SafeGetValue<System.String>("UserName");}
set { this["UserName"] = value;}
}

public System.String Password {
get { return SafeGetValue<System.String>("Password");}
set { this["Password"] = value;}
}

public System.String APISignature {
get { return SafeGetValue<System.String>("APISignature");}
set { this["APISignature"] = value;}
}

}
[Serializable]
public class msPortalPaymentRule : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "PortalPaymentRule";
public new  static class FIELDS {
public const string EvaluationOrder = "EvaluationOrder";
public const string CustomerType = "CustomerType";
public const string IndividualType = "IndividualType";
public const string OrganizationType = "OrganizationType";
public const string IsMember = "IsMember";
public const string MembershipOrganization = "MembershipOrganization";
public const string MembershipType = "MembershipType";
public const string MembershipStatus = "MembershipStatus";
public const string Customers = "Customers";
public const string Minimum = "Minimum";
public const string Maximum = "Maximum";
public const string Message = "Message";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string AllowEChecks = "AllowEChecks";
public const string AllowAmericanExpress = "AllowAmericanExpress";
public const string AllowVisa = "AllowVisa";
public const string AllowMastercard = "AllowMastercard";
public const string AllowDiscover = "AllowDiscover";
public const string AllowOtherCards = "AllowOtherCards";
public const string AllowBillMeLater = "AllowBillMeLater";
public const string AllowPayrollDeduction = "AllowPayrollDeduction";
public const string DefaultSettingForSavingPaymentMethods = "DefaultSettingForSavingPaymentMethods";
}
public msPortalPaymentRule() : base() {
ClassType = "PortalPaymentRule";
}
public msPortalPaymentRule( MemberSuiteObject msObj) : base(msObj) {}
public System.Int32 EvaluationOrder {
get { return SafeGetValue<System.Int32>("EvaluationOrder");}
set { this["EvaluationOrder"] = value;}
}

public MemberSuite.SDK.Types.CustomerType CustomerType {
get { return SafeGetValue<MemberSuite.SDK.Types.CustomerType>("CustomerType");}
set { this["CustomerType"] = value;}
}

public System.String IndividualType {
get { return SafeGetValue<System.String>("IndividualType");}
set { this["IndividualType"] = value;}
}

public System.String OrganizationType {
get { return SafeGetValue<System.String>("OrganizationType");}
set { this["OrganizationType"] = value;}
}

public System.Boolean IsMember {
get { return SafeGetValue<System.Boolean>("IsMember");}
set { this["IsMember"] = value;}
}

public System.String MembershipOrganization {
get { return SafeGetValue<System.String>("MembershipOrganization");}
set { this["MembershipOrganization"] = value;}
}

public System.String MembershipType {
get { return SafeGetValue<System.String>("MembershipType");}
set { this["MembershipType"] = value;}
}

public System.String MembershipStatus {
get { return SafeGetValue<System.String>("MembershipStatus");}
set { this["MembershipStatus"] = value;}
}

public System.String Customers {
get { return SafeGetValue<System.String>("Customers");}
set { this["Customers"] = value;}
}

public System.Decimal? Minimum {
get { return SafeGetValue<System.Decimal?>("Minimum");}
set { this["Minimum"] = value;}
}

public System.Decimal? Maximum {
get { return SafeGetValue<System.Decimal?>("Maximum");}
set { this["Maximum"] = value;}
}

public System.String Message {
get { return SafeGetValue<System.String>("Message");}
set { this["Message"] = value;}
}

public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? EndDate {
get { return SafeGetValue<System.DateTime?>("EndDate");}
set { this["EndDate"] = value;}
}

public System.Boolean AllowEChecks {
get { return SafeGetValue<System.Boolean>("AllowEChecks");}
set { this["AllowEChecks"] = value;}
}

public System.Boolean AllowAmericanExpress {
get { return SafeGetValue<System.Boolean>("AllowAmericanExpress");}
set { this["AllowAmericanExpress"] = value;}
}

public System.Boolean AllowVisa {
get { return SafeGetValue<System.Boolean>("AllowVisa");}
set { this["AllowVisa"] = value;}
}

public System.Boolean AllowMastercard {
get { return SafeGetValue<System.Boolean>("AllowMastercard");}
set { this["AllowMastercard"] = value;}
}

public System.Boolean AllowDiscover {
get { return SafeGetValue<System.Boolean>("AllowDiscover");}
set { this["AllowDiscover"] = value;}
}

public System.Boolean AllowOtherCards {
get { return SafeGetValue<System.Boolean>("AllowOtherCards");}
set { this["AllowOtherCards"] = value;}
}

public System.Boolean AllowBillMeLater {
get { return SafeGetValue<System.Boolean>("AllowBillMeLater");}
set { this["AllowBillMeLater"] = value;}
}

public System.Boolean AllowPayrollDeduction {
get { return SafeGetValue<System.Boolean>("AllowPayrollDeduction");}
set { this["AllowPayrollDeduction"] = value;}
}

public MemberSuite.SDK.Types.SavePaymentMethodSetting DefaultSettingForSavingPaymentMethods {
get { return SafeGetValue<MemberSuite.SDK.Types.SavePaymentMethodSetting>("DefaultSettingForSavingPaymentMethods");}
set { this["DefaultSettingForSavingPaymentMethods"] = value;}
}

}
[Serializable]
public class msPortalAccountPaymentRule : msPortalPaymentRule {
public new const string CLASS_NAME = "PortalAccountPaymentRule";
public new  static class FIELDS {
}
public msPortalAccountPaymentRule() : base() {
ClassType = "PortalAccountPaymentRule";
}
public msPortalAccountPaymentRule( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPortalAccountPaymentRule FromClassMetadata(ClassMetadata meta){return new msPortalAccountPaymentRule(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msProductCategory : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "ProductCategory";
public new  static class FIELDS {
public const string ProductType = "ProductType";
}
public msProductCategory() : base() {
ClassType = "ProductCategory";
}
public msProductCategory( MemberSuiteObject msObj) : base(msObj) {}
 public static new msProductCategory FromClassMetadata(ClassMetadata meta){return new msProductCategory(MemberSuiteObject.FromClassMetadata(meta));}
public System.String ProductType {
get { return SafeGetValue<System.String>("ProductType");}
set { this["ProductType"] = value;}
}

}
[Serializable]
public class msRefund : msBatchMember {
public new const string CLASS_NAME = "Refund";
public new  static class FIELDS {
public const string RefundTo = "RefundTo";
public const string RefundAddress = "RefundAddress";
public const string CheckNumber = "CheckNumber";
public const string CheckDate = "CheckDate";
public const string TransactionID = "TransactionID";
public const string Paid = "Paid";
public const string LineItems = "LineItems";
public const string Notes = "Notes";
public const string PostToSubLedger = "PostToSubLedger";
public const string Total = "Total";
}
public msRefund() : base() {
ClassType = "Refund";
LineItems = new System.Collections.Generic.List<msRefundLineItem>();
}
public msRefund( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRefund FromClassMetadata(ClassMetadata meta){return new msRefund(MemberSuiteObject.FromClassMetadata(meta));}
public System.String RefundTo {
get { return SafeGetValue<System.String>("RefundTo");}
set { this["RefundTo"] = value;}
}

public MemberSuite.SDK.Types.Address RefundAddress {
get { return SafeGetValue<MemberSuite.SDK.Types.Address>("RefundAddress");}
set { this["RefundAddress"] = value;}
}

public System.String CheckNumber {
get { return SafeGetValue<System.String>("CheckNumber");}
set { this["CheckNumber"] = value;}
}

public System.DateTime? CheckDate {
get { return SafeGetValue<System.DateTime?>("CheckDate");}
set { this["CheckDate"] = value;}
}

public System.String TransactionID {
get { return SafeGetValue<System.String>("TransactionID");}
set { this["TransactionID"] = value;}
}

public System.Boolean Paid {
get { return SafeGetValue<System.Boolean>("Paid");}
set { this["Paid"] = value;}
}

public System.Collections.Generic.List<msRefundLineItem> LineItems {
get { return SafeGetValue<System.Collections.Generic.List<msRefundLineItem>>("LineItems");}
set { this["LineItems"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Boolean PostToSubLedger {
get { return SafeGetValue<System.Boolean>("PostToSubLedger");}
set { this["PostToSubLedger"] = value;}
}

public System.Decimal Total {
get { return SafeGetValue<System.Decimal>("Total");}
set { this["Total"] = value;}
}

}
[Serializable]
public class msRefundLineItem : msAggregateChild {
public new const string CLASS_NAME = "RefundLineItem";
public new  static class FIELDS {
public const string Credit = "Credit";
public const string Amount = "Amount";
}
public msRefundLineItem() : base() {
ClassType = "RefundLineItem";
}
public msRefundLineItem( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRefundLineItem FromClassMetadata(ClassMetadata meta){return new msRefundLineItem(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Credit {
get { return SafeGetValue<System.String>("Credit");}
set { this["Credit"] = value;}
}

public System.Decimal Amount {
get { return SafeGetValue<System.Decimal>("Amount");}
set { this["Amount"] = value;}
}

}
[Serializable]
public class msSpecialPrice : msAggregateChild {
public new const string CLASS_NAME = "SpecialPrice";
public new  static class FIELDS {
public const string EvaluationOrder = "EvaluationOrder";
public const string Member = "Member";
public const string MinimumQuantity = "MinimumQuantity";
public const string MaximumQuantity = "MaximumQuantity";
public const string Price = "Price";
public const string CustomerType = "CustomerType";
public const string IndividualType = "IndividualType";
public const string OrganizationType = "OrganizationType";
public const string MembershipOrganization = "MembershipOrganization";
public const string MembershipType = "MembershipType";
public const string MembershipStatus = "MembershipStatus";
public const string Code = "Code";
public const string Formula = "Formula";
public const string ConditionFormula = "ConditionFormula";
public const string Low = "Low";
public const string High = "High";
public const string Step = "Step";
public const string PriceCap = "PriceCap";
public const string Increment = "Increment";
public const string DiscountCode = "DiscountCode";
}
public msSpecialPrice() : base() {
ClassType = "SpecialPrice";
}
public msSpecialPrice( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSpecialPrice FromClassMetadata(ClassMetadata meta){return new msSpecialPrice(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int32 EvaluationOrder {
get { return SafeGetValue<System.Int32>("EvaluationOrder");}
set { this["EvaluationOrder"] = value;}
}

public System.Boolean Member {
get { return SafeGetValue<System.Boolean>("Member");}
set { this["Member"] = value;}
}

public System.Decimal? MinimumQuantity {
get { return SafeGetValue<System.Decimal?>("MinimumQuantity");}
set { this["MinimumQuantity"] = value;}
}

public System.Decimal? MaximumQuantity {
get { return SafeGetValue<System.Decimal?>("MaximumQuantity");}
set { this["MaximumQuantity"] = value;}
}

public System.Decimal Price {
get { return SafeGetValue<System.Decimal>("Price");}
set { this["Price"] = value;}
}

public MemberSuite.SDK.Types.CustomerType CustomerType {
get { return SafeGetValue<MemberSuite.SDK.Types.CustomerType>("CustomerType");}
set { this["CustomerType"] = value;}
}

public System.String IndividualType {
get { return SafeGetValue<System.String>("IndividualType");}
set { this["IndividualType"] = value;}
}

public System.String OrganizationType {
get { return SafeGetValue<System.String>("OrganizationType");}
set { this["OrganizationType"] = value;}
}

public System.String MembershipOrganization {
get { return SafeGetValue<System.String>("MembershipOrganization");}
set { this["MembershipOrganization"] = value;}
}

public System.String MembershipType {
get { return SafeGetValue<System.String>("MembershipType");}
set { this["MembershipType"] = value;}
}

public System.String MembershipStatus {
get { return SafeGetValue<System.String>("MembershipStatus");}
set { this["MembershipStatus"] = value;}
}

public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String Formula {
get { return SafeGetValue<System.String>("Formula");}
set { this["Formula"] = value;}
}

public System.String ConditionFormula {
get { return SafeGetValue<System.String>("ConditionFormula");}
set { this["ConditionFormula"] = value;}
}

public System.Decimal? Low {
get { return SafeGetValue<System.Decimal?>("Low");}
set { this["Low"] = value;}
}

public System.Decimal? High {
get { return SafeGetValue<System.Decimal?>("High");}
set { this["High"] = value;}
}

public System.Decimal? Step {
get { return SafeGetValue<System.Decimal?>("Step");}
set { this["Step"] = value;}
}

public System.Decimal? PriceCap {
get { return SafeGetValue<System.Decimal?>("PriceCap");}
set { this["PriceCap"] = value;}
}

public System.Decimal? Increment {
get { return SafeGetValue<System.Decimal?>("Increment");}
set { this["Increment"] = value;}
}

public System.String DiscountCode {
get { return SafeGetValue<System.String>("DiscountCode");}
set { this["DiscountCode"] = value;}
}

}
[Serializable]
public class msWriteOff : msBatchMember {
public new const string CLASS_NAME = "WriteOff";
public new  static class FIELDS {
public const string Total = "Total";
public const string Invoice = "Invoice";
public const string Customer = "Customer";
public const string AccountsReceivableGLCode = "AccountsReceivableGLCode";
public const string Method = "Method";
public const string Notes = "Notes";
public const string LineItems = "LineItems";
public const string WriteOffGLAccount = "WriteOffGLAccount";
}
public msWriteOff() : base() {
ClassType = "WriteOff";
LineItems = new System.Collections.Generic.List<msWriteOffLineItem>();
}
public msWriteOff( MemberSuiteObject msObj) : base(msObj) {}
 public static new msWriteOff FromClassMetadata(ClassMetadata meta){return new msWriteOff(MemberSuiteObject.FromClassMetadata(meta));}
public System.Decimal Total {
get { return SafeGetValue<System.Decimal>("Total");}
set { this["Total"] = value;}
}

public System.String Invoice {
get { return SafeGetValue<System.String>("Invoice");}
set { this["Invoice"] = value;}
}

public System.String Customer {
get { return SafeGetValue<System.String>("Customer");}
set { this["Customer"] = value;}
}

public System.String AccountsReceivableGLCode {
get { return SafeGetValue<System.String>("AccountsReceivableGLCode");}
set { this["AccountsReceivableGLCode"] = value;}
}

public MemberSuite.SDK.Types.WriteOffMethod Method {
get { return SafeGetValue<MemberSuite.SDK.Types.WriteOffMethod>("Method");}
set { this["Method"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Collections.Generic.List<msWriteOffLineItem> LineItems {
get { return SafeGetValue<System.Collections.Generic.List<msWriteOffLineItem>>("LineItems");}
set { this["LineItems"] = value;}
}

public System.String WriteOffGLAccount {
get { return SafeGetValue<System.String>("WriteOffGLAccount");}
set { this["WriteOffGLAccount"] = value;}
}

}
[Serializable]
public class msSalesOrderLineItem : msAggregateChild {
public new const string CLASS_NAME = "SalesOrderLineItem";
public new  static class FIELDS {
public const string Product = "Product";
public const string Quantity = "Quantity";
public const string UnitPrice = "UnitPrice";
public const string Description = "Description";
public const string Total = "Total";
}
public msSalesOrderLineItem() : base() {
ClassType = "SalesOrderLineItem";
}
public msSalesOrderLineItem( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSalesOrderLineItem FromClassMetadata(ClassMetadata meta){return new msSalesOrderLineItem(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Product {
get { return SafeGetValue<System.String>("Product");}
set { this["Product"] = value;}
}

public System.Decimal Quantity {
get { return SafeGetValue<System.Decimal>("Quantity");}
set { this["Quantity"] = value;}
}

public System.Decimal UnitPrice {
get { return SafeGetValue<System.Decimal>("UnitPrice");}
set { this["UnitPrice"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Decimal Total {
get { return SafeGetValue<System.Decimal>("Total");}
set { this["Total"] = value;}
}

}
[Serializable]
public class msWriteOffLineItem : msSalesOrderLineItem {
public new const string CLASS_NAME = "WriteOffLineItem";
public new  static class FIELDS {
public const string InvoiceLineItemID = "InvoiceLineItemID";
}
public msWriteOffLineItem() : base() {
ClassType = "WriteOffLineItem";
}
public msWriteOffLineItem( MemberSuiteObject msObj) : base(msObj) {}
 public static new msWriteOffLineItem FromClassMetadata(ClassMetadata meta){return new msWriteOffLineItem(MemberSuiteObject.FromClassMetadata(meta));}
public System.String InvoiceLineItemID {
get { return SafeGetValue<System.String>("InvoiceLineItemID");}
set { this["InvoiceLineItemID"] = value;}
}

}
[Serializable]
public class msAccreditation : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Accreditation";
public new  static class FIELDS {
public const string Organization = "Organization";
public const string Status = "Status";
public const string EffectiveDate = "EffectiveDate";
public const string PaidThruDate = "PaidThruDate";
public const string RenewalDate = "RenewalDate";
public const string TerminationDate = "TerminationDate";
public const string ApplicationDate = "ApplicationDate";
public const string ExpirationDate = "ExpirationDate";
public const string Program = "Program";
public const string Notes = "Notes";
public const string CommissionMembers = "CommissionMembers";
}
public msAccreditation() : base() {
ClassType = "Accreditation";
CommissionMembers = new System.Collections.Generic.List<msAccreditationAssignedCommissionMember>();
}
public msAccreditation( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditation FromClassMetadata(ClassMetadata meta){return new msAccreditation(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Organization {
get { return SafeGetValue<System.String>("Organization");}
set { this["Organization"] = value;}
}

public System.String Status {
get { return SafeGetValue<System.String>("Status");}
set { this["Status"] = value;}
}

public System.DateTime? EffectiveDate {
get { return SafeGetValue<System.DateTime?>("EffectiveDate");}
set { this["EffectiveDate"] = value;}
}

public System.DateTime? PaidThruDate {
get { return SafeGetValue<System.DateTime?>("PaidThruDate");}
set { this["PaidThruDate"] = value;}
}

public System.DateTime? RenewalDate {
get { return SafeGetValue<System.DateTime?>("RenewalDate");}
set { this["RenewalDate"] = value;}
}

public System.DateTime? TerminationDate {
get { return SafeGetValue<System.DateTime?>("TerminationDate");}
set { this["TerminationDate"] = value;}
}

public System.DateTime? ApplicationDate {
get { return SafeGetValue<System.DateTime?>("ApplicationDate");}
set { this["ApplicationDate"] = value;}
}

public System.DateTime? ExpirationDate {
get { return SafeGetValue<System.DateTime?>("ExpirationDate");}
set { this["ExpirationDate"] = value;}
}

public System.String Program {
get { return SafeGetValue<System.String>("Program");}
set { this["Program"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Collections.Generic.List<msAccreditationAssignedCommissionMember> CommissionMembers {
get { return SafeGetValue<System.Collections.Generic.List<msAccreditationAssignedCommissionMember>>("CommissionMembers");}
set { this["CommissionMembers"] = value;}
}

}
[Serializable]
public class msAccreditationAssignedCommissionMember : msAggregateChild {
public new const string CLASS_NAME = "AccreditationAssignedCommissionMember";
public new  static class FIELDS {
public const string Role = "Role";
public const string Member = "Member";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string Notes = "Notes";
}
public msAccreditationAssignedCommissionMember() : base() {
ClassType = "AccreditationAssignedCommissionMember";
}
public msAccreditationAssignedCommissionMember( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationAssignedCommissionMember FromClassMetadata(ClassMetadata meta){return new msAccreditationAssignedCommissionMember(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Role {
get { return SafeGetValue<System.String>("Role");}
set { this["Role"] = value;}
}

public System.String Member {
get { return SafeGetValue<System.String>("Member");}
set { this["Member"] = value;}
}

public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? EndDate {
get { return SafeGetValue<System.DateTime?>("EndDate");}
set { this["EndDate"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msAccreditationAppeal : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "AccreditationAppeal";
public new  static class FIELDS {
public const string Accreditation = "Accreditation";
public const string Status = "Status";
public const string Type = "Type";
public const string SubmittedBy = "SubmittedBy";
public const string SubmissionDate = "SubmissionDate";
public const string ResolutionDate = "ResolutionDate";
public const string Notes = "Notes";
}
public msAccreditationAppeal() : base() {
ClassType = "AccreditationAppeal";
}
public msAccreditationAppeal( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationAppeal FromClassMetadata(ClassMetadata meta){return new msAccreditationAppeal(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Accreditation {
get { return SafeGetValue<System.String>("Accreditation");}
set { this["Accreditation"] = value;}
}

public System.String Status {
get { return SafeGetValue<System.String>("Status");}
set { this["Status"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String SubmittedBy {
get { return SafeGetValue<System.String>("SubmittedBy");}
set { this["SubmittedBy"] = value;}
}

public System.DateTime? SubmissionDate {
get { return SafeGetValue<System.DateTime?>("SubmissionDate");}
set { this["SubmissionDate"] = value;}
}

public System.DateTime? ResolutionDate {
get { return SafeGetValue<System.DateTime?>("ResolutionDate");}
set { this["ResolutionDate"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msAccreditationAppealStatus : msConfigurableType {
public new const string CLASS_NAME = "AccreditationAppealStatus";
public new  static class FIELDS {
}
public msAccreditationAppealStatus() : base() {
ClassType = "AccreditationAppealStatus";
}
public msAccreditationAppealStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationAppealStatus FromClassMetadata(ClassMetadata meta){return new msAccreditationAppealStatus(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAccreditationFee : msProduct {
public new const string CLASS_NAME = "AccreditationFee";
public new  static class FIELDS {
public const string AccreditationProgram = "AccreditationProgram";
}
public msAccreditationFee() : base() {
ClassType = "AccreditationFee";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msAccreditationFee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationFee FromClassMetadata(ClassMetadata meta){return new msAccreditationFee(MemberSuiteObject.FromClassMetadata(meta));}
public System.String AccreditationProgram {
get { return SafeGetValue<System.String>("AccreditationProgram");}
set { this["AccreditationProgram"] = value;}
}

}
[Serializable]
public class msAccreditationProgram : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "AccreditationProgram";
public new  static class FIELDS {
public const string Code = "Code";
public const string Description = "Description";
}
public msAccreditationProgram() : base() {
ClassType = "AccreditationProgram";
}
public msAccreditationProgram( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationProgram FromClassMetadata(ClassMetadata meta){return new msAccreditationProgram(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msAccreditationReport : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "AccreditationReport";
public new  static class FIELDS {
public const string Accreditation = "Accreditation";
public const string Type = "Type";
public const string Status = "Status";
public const string File = "File";
public const string Date = "Date";
public const string Notes = "Notes";
}
public msAccreditationReport() : base() {
ClassType = "AccreditationReport";
}
public msAccreditationReport( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationReport FromClassMetadata(ClassMetadata meta){return new msAccreditationReport(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Accreditation {
get { return SafeGetValue<System.String>("Accreditation");}
set { this["Accreditation"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Status {
get { return SafeGetValue<System.String>("Status");}
set { this["Status"] = value;}
}

public System.String File {
get { return SafeGetValue<System.String>("File");}
set { this["File"] = value;}
}

public System.DateTime? Date {
get { return SafeGetValue<System.DateTime?>("Date");}
set { this["Date"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msAccreditationReportStatus : msConfigurableType {
public new const string CLASS_NAME = "AccreditationReportStatus";
public new  static class FIELDS {
}
public msAccreditationReportStatus() : base() {
ClassType = "AccreditationReportStatus";
}
public msAccreditationReportStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationReportStatus FromClassMetadata(ClassMetadata meta){return new msAccreditationReportStatus(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAccreditationReportType : msConfigurableType {
public new const string CLASS_NAME = "AccreditationReportType";
public new  static class FIELDS {
}
public msAccreditationReportType() : base() {
ClassType = "AccreditationReportType";
}
public msAccreditationReportType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationReportType FromClassMetadata(ClassMetadata meta){return new msAccreditationReportType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAccreditationSiteVisitExpense : msExpense {
public new const string CLASS_NAME = "AccreditationSiteVisitExpense";
public new  static class FIELDS {
public const string SiteVisit = "SiteVisit";
}
public msAccreditationSiteVisitExpense() : base() {
ClassType = "AccreditationSiteVisitExpense";
}
public msAccreditationSiteVisitExpense( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationSiteVisitExpense FromClassMetadata(ClassMetadata meta){return new msAccreditationSiteVisitExpense(MemberSuiteObject.FromClassMetadata(meta));}
public System.String SiteVisit {
get { return SafeGetValue<System.String>("SiteVisit");}
set { this["SiteVisit"] = value;}
}

}
[Serializable]
public class msAccreditationSiteVisitStatus : msConfigurableType {
public new const string CLASS_NAME = "AccreditationSiteVisitStatus";
public new  static class FIELDS {
}
public msAccreditationSiteVisitStatus() : base() {
ClassType = "AccreditationSiteVisitStatus";
}
public msAccreditationSiteVisitStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationSiteVisitStatus FromClassMetadata(ClassMetadata meta){return new msAccreditationSiteVisitStatus(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAccreditationStatus : msConfigurableType {
public new const string CLASS_NAME = "AccreditationStatus";
public new  static class FIELDS {
}
public msAccreditationStatus() : base() {
ClassType = "AccreditationStatus";
}
public msAccreditationStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationStatus FromClassMetadata(ClassMetadata meta){return new msAccreditationStatus(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAccreditationSiteVisit : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "AccreditationSiteVisit";
public new  static class FIELDS {
public const string Accreditation = "Accreditation";
public const string Type = "Type";
public const string Status = "Status";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string Notes = "Notes";
public const string TeamMembers = "TeamMembers";
}
public msAccreditationSiteVisit() : base() {
ClassType = "AccreditationSiteVisit";
TeamMembers = new System.Collections.Generic.List<msAccreditationAssignedCommissionMember>();
}
public msAccreditationSiteVisit( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationSiteVisit FromClassMetadata(ClassMetadata meta){return new msAccreditationSiteVisit(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Accreditation {
get { return SafeGetValue<System.String>("Accreditation");}
set { this["Accreditation"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Status {
get { return SafeGetValue<System.String>("Status");}
set { this["Status"] = value;}
}

public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? EndDate {
get { return SafeGetValue<System.DateTime?>("EndDate");}
set { this["EndDate"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Collections.Generic.List<msAccreditationAssignedCommissionMember> TeamMembers {
get { return SafeGetValue<System.Collections.Generic.List<msAccreditationAssignedCommissionMember>>("TeamMembers");}
set { this["TeamMembers"] = value;}
}

}
[Serializable]
public class msAccreditationSiteVisitType : msConfigurableType {
public new const string CLASS_NAME = "AccreditationSiteVisitType";
public new  static class FIELDS {
}
public msAccreditationSiteVisitType() : base() {
ClassType = "AccreditationSiteVisitType";
}
public msAccreditationSiteVisitType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationSiteVisitType FromClassMetadata(ClassMetadata meta){return new msAccreditationSiteVisitType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAccreditationCommissionMember : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "AccreditationCommissionMember";
public new  static class FIELDS {
public const string Individual = "Individual";
}
public msAccreditationCommissionMember() : base() {
ClassType = "AccreditationCommissionMember";
}
public msAccreditationCommissionMember( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationCommissionMember FromClassMetadata(ClassMetadata meta){return new msAccreditationCommissionMember(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Individual {
get { return SafeGetValue<System.String>("Individual");}
set { this["Individual"] = value;}
}

}
[Serializable]
public class msAccreditationCommissionMemberRole : msConfigurableType {
public new const string CLASS_NAME = "AccreditationCommissionMemberRole";
public new  static class FIELDS {
}
public msAccreditationCommissionMemberRole() : base() {
ClassType = "AccreditationCommissionMemberRole";
}
public msAccreditationCommissionMemberRole( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationCommissionMemberRole FromClassMetadata(ClassMetadata meta){return new msAccreditationCommissionMemberRole(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAccreditationTeamEvaluation : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "AccreditationTeamEvaluation";
public new  static class FIELDS {
public const string Accreditation = "Accreditation";
public const string SubmittedBy = "SubmittedBy";
public const string SubmissionDate = "SubmissionDate";
public const string Notes = "Notes";
}
public msAccreditationTeamEvaluation() : base() {
ClassType = "AccreditationTeamEvaluation";
}
public msAccreditationTeamEvaluation( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationTeamEvaluation FromClassMetadata(ClassMetadata meta){return new msAccreditationTeamEvaluation(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Accreditation {
get { return SafeGetValue<System.String>("Accreditation");}
set { this["Accreditation"] = value;}
}

public System.String SubmittedBy {
get { return SafeGetValue<System.String>("SubmittedBy");}
set { this["SubmittedBy"] = value;}
}

public System.DateTime? SubmissionDate {
get { return SafeGetValue<System.DateTime?>("SubmissionDate");}
set { this["SubmissionDate"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msAccreditationAppealType : msConfigurableType {
public new const string CLASS_NAME = "AccreditationAppealType";
public new  static class FIELDS {
}
public msAccreditationAppealType() : base() {
ClassType = "AccreditationAppealType";
}
public msAccreditationAppealType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAccreditationAppealType FromClassMetadata(ClassMetadata meta){return new msAccreditationAppealType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAdPosition : msConfigurableType {
public new const string CLASS_NAME = "AdPosition";
public new  static class FIELDS {
}
public msAdPosition() : base() {
ClassType = "AdPosition";
}
public msAdPosition( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAdPosition FromClassMetadata(ClassMetadata meta){return new msAdPosition(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAdSize : msConfigurableType {
public new const string CLASS_NAME = "AdSize";
public new  static class FIELDS {
}
public msAdSize() : base() {
ClassType = "AdSize";
}
public msAdSize( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAdSize FromClassMetadata(ClassMetadata meta){return new msAdSize(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAdvertisingContract : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "AdvertisingContract";
public new  static class FIELDS {
public const string Publication = "Publication";
public const string Agency = "Agency";
public const string Advertiser = "Advertiser";
public const string BillTo = "BillTo";
public const string BillingAddress = "BillingAddress";
public const string RateCard = "RateCard";
public const string ContactName = "ContactName";
public const string ContactPhone = "ContactPhone";
public const string ContactEmail = "ContactEmail";
public const string SignatureDate = "SignatureDate";
public const string ReceivedDate = "ReceivedDate";
public const string TermStart = "TermStart";
public const string TermEnd = "TermEnd";
public const string NumberOfPlacements = "NumberOfPlacements";
public const string Notes = "Notes";
}
public msAdvertisingContract() : base() {
ClassType = "AdvertisingContract";
}
public msAdvertisingContract( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAdvertisingContract FromClassMetadata(ClassMetadata meta){return new msAdvertisingContract(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Publication {
get { return SafeGetValue<System.String>("Publication");}
set { this["Publication"] = value;}
}

public System.String Agency {
get { return SafeGetValue<System.String>("Agency");}
set { this["Agency"] = value;}
}

public System.String Advertiser {
get { return SafeGetValue<System.String>("Advertiser");}
set { this["Advertiser"] = value;}
}

public System.String BillTo {
get { return SafeGetValue<System.String>("BillTo");}
set { this["BillTo"] = value;}
}

public MemberSuite.SDK.Types.Address BillingAddress {
get { return SafeGetValue<MemberSuite.SDK.Types.Address>("BillingAddress");}
set { this["BillingAddress"] = value;}
}

public System.String RateCard {
get { return SafeGetValue<System.String>("RateCard");}
set { this["RateCard"] = value;}
}

public System.String ContactName {
get { return SafeGetValue<System.String>("ContactName");}
set { this["ContactName"] = value;}
}

public System.String ContactPhone {
get { return SafeGetValue<System.String>("ContactPhone");}
set { this["ContactPhone"] = value;}
}

public System.String ContactEmail {
get { return SafeGetValue<System.String>("ContactEmail");}
set { this["ContactEmail"] = value;}
}

public System.DateTime? SignatureDate {
get { return SafeGetValue<System.DateTime?>("SignatureDate");}
set { this["SignatureDate"] = value;}
}

public System.DateTime? ReceivedDate {
get { return SafeGetValue<System.DateTime?>("ReceivedDate");}
set { this["ReceivedDate"] = value;}
}

public System.DateTime? TermStart {
get { return SafeGetValue<System.DateTime?>("TermStart");}
set { this["TermStart"] = value;}
}

public System.DateTime TermEnd {
get { return SafeGetValue<System.DateTime>("TermEnd");}
set { this["TermEnd"] = value;}
}

public System.Int32 NumberOfPlacements {
get { return SafeGetValue<System.Int32>("NumberOfPlacements");}
set { this["NumberOfPlacements"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msAdvertisingContractStatus : msConfigurableType {
public new const string CLASS_NAME = "AdvertisingContractStatus";
public new  static class FIELDS {
}
public msAdvertisingContractStatus() : base() {
ClassType = "AdvertisingContractStatus";
}
public msAdvertisingContractStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAdvertisingContractStatus FromClassMetadata(ClassMetadata meta){return new msAdvertisingContractStatus(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAdvertisingProduct : msProduct {
public new const string CLASS_NAME = "AdvertisingProduct";
public new  static class FIELDS {
}
public msAdvertisingProduct() : base() {
ClassType = "AdvertisingProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msAdvertisingProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAdvertisingProduct FromClassMetadata(ClassMetadata meta){return new msAdvertisingProduct(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAgency : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Agency";
public new  static class FIELDS {
public const string Organization = "Organization";
public const string Notes = "Notes";
public const string Discount = "Discount";
}
public msAgency() : base() {
ClassType = "Agency";
}
public msAgency( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAgency FromClassMetadata(ClassMetadata meta){return new msAgency(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Organization {
get { return SafeGetValue<System.String>("Organization");}
set { this["Organization"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Decimal Discount {
get { return SafeGetValue<System.Decimal>("Discount");}
set { this["Discount"] = value;}
}

}
[Serializable]
public class msClassifiedAd : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "ClassifiedAd";
public new  static class FIELDS {
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
public const string Type = "Type";
public const string Owner = "Owner";
public const string Issue = "Issue";
public const string Ad = "Ad";
public const string Notes = "Notes";
}
public msClassifiedAd() : base() {
ClassType = "ClassifiedAd";
}
public msClassifiedAd( MemberSuiteObject msObj) : base(msObj) {}
 public static new msClassifiedAd FromClassMetadata(ClassMetadata meta){return new msClassifiedAd(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String Issue {
get { return SafeGetValue<System.String>("Issue");}
set { this["Issue"] = value;}
}

public System.String Ad {
get { return SafeGetValue<System.String>("Ad");}
set { this["Ad"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msClassifiedAdType : msConfigurableType {
public new const string CLASS_NAME = "ClassifiedAdType";
public new  static class FIELDS {
}
public msClassifiedAdType() : base() {
ClassType = "ClassifiedAdType";
}
public msClassifiedAdType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msClassifiedAdType FromClassMetadata(ClassMetadata meta){return new msClassifiedAdType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msInsertionOrder : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "InsertionOrder";
public new  static class FIELDS {
public const string Date = "Date";
public const string Contract = "Contract";
public const string Advertiser = "Advertiser";
public const string Agency = "Agency";
public const string RateCard = "RateCard";
public const string Issue = "Issue";
public const string BillTo = "BillTo";
public const string BillingAddress = "BillingAddress";
public const string SpecialInstructions = "SpecialInstructions";
public const string Color = "Color";
public const string Position = "Position";
public const string Size = "Size";
public const string BaseRate = "BaseRate";
public const string PurchaseOrderNumber = "PurchaseOrderNumber";
public const string Invoice = "Invoice";
public const string ContactName = "ContactName";
public const string ContactPhone = "ContactPhone";
public const string ContactEmail = "ContactEmail";
public const string UploadedMaterials = "UploadedMaterials";
public const string MaterialsReceivedDate = "MaterialsReceivedDate";
public const string MaterialsReturnedDate = "MaterialsReturnedDate";
public const string MaterialsNotes = "MaterialsNotes";
public const string RequiresTearSheet = "RequiresTearSheet";
public const string PageNumber = "PageNumber";
public const string GroupID = "GroupID";
}
public msInsertionOrder() : base() {
ClassType = "InsertionOrder";
}
public msInsertionOrder( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInsertionOrder FromClassMetadata(ClassMetadata meta){return new msInsertionOrder(MemberSuiteObject.FromClassMetadata(meta));}
public System.DateTime Date {
get { return SafeGetValue<System.DateTime>("Date");}
set { this["Date"] = value;}
}

public System.String Contract {
get { return SafeGetValue<System.String>("Contract");}
set { this["Contract"] = value;}
}

public System.String Advertiser {
get { return SafeGetValue<System.String>("Advertiser");}
set { this["Advertiser"] = value;}
}

public System.String Agency {
get { return SafeGetValue<System.String>("Agency");}
set { this["Agency"] = value;}
}

public System.String RateCard {
get { return SafeGetValue<System.String>("RateCard");}
set { this["RateCard"] = value;}
}

public System.String Issue {
get { return SafeGetValue<System.String>("Issue");}
set { this["Issue"] = value;}
}

public System.String BillTo {
get { return SafeGetValue<System.String>("BillTo");}
set { this["BillTo"] = value;}
}

public MemberSuite.SDK.Types.Address BillingAddress {
get { return SafeGetValue<MemberSuite.SDK.Types.Address>("BillingAddress");}
set { this["BillingAddress"] = value;}
}

public System.String SpecialInstructions {
get { return SafeGetValue<System.String>("SpecialInstructions");}
set { this["SpecialInstructions"] = value;}
}

public System.String Color {
get { return SafeGetValue<System.String>("Color");}
set { this["Color"] = value;}
}

public System.String Position {
get { return SafeGetValue<System.String>("Position");}
set { this["Position"] = value;}
}

public System.String Size {
get { return SafeGetValue<System.String>("Size");}
set { this["Size"] = value;}
}

public System.Decimal BaseRate {
get { return SafeGetValue<System.Decimal>("BaseRate");}
set { this["BaseRate"] = value;}
}

public System.String PurchaseOrderNumber {
get { return SafeGetValue<System.String>("PurchaseOrderNumber");}
set { this["PurchaseOrderNumber"] = value;}
}

public System.String Invoice {
get { return SafeGetValue<System.String>("Invoice");}
set { this["Invoice"] = value;}
}

public System.String ContactName {
get { return SafeGetValue<System.String>("ContactName");}
set { this["ContactName"] = value;}
}

public System.String ContactPhone {
get { return SafeGetValue<System.String>("ContactPhone");}
set { this["ContactPhone"] = value;}
}

public System.String ContactEmail {
get { return SafeGetValue<System.String>("ContactEmail");}
set { this["ContactEmail"] = value;}
}

public System.String UploadedMaterials {
get { return SafeGetValue<System.String>("UploadedMaterials");}
set { this["UploadedMaterials"] = value;}
}

public System.DateTime? MaterialsReceivedDate {
get { return SafeGetValue<System.DateTime?>("MaterialsReceivedDate");}
set { this["MaterialsReceivedDate"] = value;}
}

public System.DateTime? MaterialsReturnedDate {
get { return SafeGetValue<System.DateTime?>("MaterialsReturnedDate");}
set { this["MaterialsReturnedDate"] = value;}
}

public System.String MaterialsNotes {
get { return SafeGetValue<System.String>("MaterialsNotes");}
set { this["MaterialsNotes"] = value;}
}

public System.Boolean RequiresTearSheet {
get { return SafeGetValue<System.Boolean>("RequiresTearSheet");}
set { this["RequiresTearSheet"] = value;}
}

public System.Int32? PageNumber {
get { return SafeGetValue<System.Int32?>("PageNumber");}
set { this["PageNumber"] = value;}
}

public System.String GroupID {
get { return SafeGetValue<System.String>("GroupID");}
set { this["GroupID"] = value;}
}

}
[Serializable]
public class msInsertionOrderInvoiceBatch : msAssociationDomainObject {
public new const string CLASS_NAME = "InsertionOrderInvoiceBatch";
public new  static class FIELDS {
public const string Issue = "Issue";
public const string Terms = "Terms";
public const string AutomaticallyEmailInvoices = "AutomaticallyEmailInvoices";
public const string Status = "Status";
public const string CompletionDate = "CompletionDate";
public const string SearchToUse = "SearchToUse";
public const string InvoiceBatch = "InvoiceBatch";
}
public msInsertionOrderInvoiceBatch() : base() {
ClassType = "InsertionOrderInvoiceBatch";
}
public msInsertionOrderInvoiceBatch( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInsertionOrderInvoiceBatch FromClassMetadata(ClassMetadata meta){return new msInsertionOrderInvoiceBatch(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Issue {
get { return SafeGetValue<System.String>("Issue");}
set { this["Issue"] = value;}
}

public System.String Terms {
get { return SafeGetValue<System.String>("Terms");}
set { this["Terms"] = value;}
}

public System.Boolean AutomaticallyEmailInvoices {
get { return SafeGetValue<System.Boolean>("AutomaticallyEmailInvoices");}
set { this["AutomaticallyEmailInvoices"] = value;}
}

public MemberSuite.SDK.Types.JobStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.JobStatus>("Status");}
set { this["Status"] = value;}
}

public System.DateTime? CompletionDate {
get { return SafeGetValue<System.DateTime?>("CompletionDate");}
set { this["CompletionDate"] = value;}
}

public MemberSuite.SDK.Searching.Search SearchToUse {
get { return SafeGetValue<MemberSuite.SDK.Searching.Search>("SearchToUse");}
set { this["SearchToUse"] = value;}
}

public System.String InvoiceBatch {
get { return SafeGetValue<System.String>("InvoiceBatch");}
set { this["InvoiceBatch"] = value;}
}

}
[Serializable]
public class msIssue : msAssociationDomainObject {
public new const string CLASS_NAME = "Issue";
public new  static class FIELDS {
public const string Publication = "Publication";
public const string OpenDate = "OpenDate";
public const string CloseDate = "CloseDate";
public const string PrinterDate = "PrinterDate";
public const string PublishDate = "PublishDate";
public const string RateCard = "RateCard";
public const string IsClosed = "IsClosed";
public const string Notes = "Notes";
public const string InvoiceBatch = "InvoiceBatch";
public const string UsePublicationSizes = "UsePublicationSizes";
public const string Sizes = "Sizes";
public const string UsePublicationPositions = "UsePublicationPositions";
public const string Positions = "Positions";
public const string UsePublicationColors = "UsePublicationColors";
public const string Colors = "Colors";
public const string BudgetedSales = "BudgetedSales";
}
public msIssue() : base() {
ClassType = "Issue";
Sizes = new System.Collections.Generic.List<System.String>();
Positions = new System.Collections.Generic.List<System.String>();
Colors = new System.Collections.Generic.List<System.String>();
}
public msIssue( MemberSuiteObject msObj) : base(msObj) {}
 public static new msIssue FromClassMetadata(ClassMetadata meta){return new msIssue(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Publication {
get { return SafeGetValue<System.String>("Publication");}
set { this["Publication"] = value;}
}

public System.DateTime? OpenDate {
get { return SafeGetValue<System.DateTime?>("OpenDate");}
set { this["OpenDate"] = value;}
}

public System.DateTime? CloseDate {
get { return SafeGetValue<System.DateTime?>("CloseDate");}
set { this["CloseDate"] = value;}
}

public System.DateTime? PrinterDate {
get { return SafeGetValue<System.DateTime?>("PrinterDate");}
set { this["PrinterDate"] = value;}
}

public System.DateTime? PublishDate {
get { return SafeGetValue<System.DateTime?>("PublishDate");}
set { this["PublishDate"] = value;}
}

public System.String RateCard {
get { return SafeGetValue<System.String>("RateCard");}
set { this["RateCard"] = value;}
}

public System.Boolean IsClosed {
get { return SafeGetValue<System.Boolean>("IsClosed");}
set { this["IsClosed"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.String InvoiceBatch {
get { return SafeGetValue<System.String>("InvoiceBatch");}
set { this["InvoiceBatch"] = value;}
}

public System.Boolean UsePublicationSizes {
get { return SafeGetValue<System.Boolean>("UsePublicationSizes");}
set { this["UsePublicationSizes"] = value;}
}

public System.Collections.Generic.List<System.String> Sizes {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Sizes");}
set { this["Sizes"] = value;}
}

public System.Boolean UsePublicationPositions {
get { return SafeGetValue<System.Boolean>("UsePublicationPositions");}
set { this["UsePublicationPositions"] = value;}
}

public System.Collections.Generic.List<System.String> Positions {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Positions");}
set { this["Positions"] = value;}
}

public System.Boolean UsePublicationColors {
get { return SafeGetValue<System.Boolean>("UsePublicationColors");}
set { this["UsePublicationColors"] = value;}
}

public System.Collections.Generic.List<System.String> Colors {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Colors");}
set { this["Colors"] = value;}
}

public System.Decimal? BudgetedSales {
get { return SafeGetValue<System.Decimal?>("BudgetedSales");}
set { this["BudgetedSales"] = value;}
}

}
[Serializable]
public class msPublication : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "Publication";
public new  static class FIELDS {
public const string Code = "Code";
public const string BusinessUnit = "BusinessUnit";
public const string DisplayOrder = "DisplayOrder";
public const string Description = "Description";
public const string Type = "Type";
public const string VisibleInPortal = "VisibleInPortal";
public const string Image = "Image";
public const string Sizes = "Sizes";
public const string Positions = "Positions";
public const string Colors = "Colors";
public const string InsertionOrderInvoiceType = "InsertionOrderInvoiceType";
public const string SubscriptionInvoiceType = "SubscriptionInvoiceType";
}
public msPublication() : base() {
ClassType = "Publication";
Sizes = new System.Collections.Generic.List<System.String>();
Positions = new System.Collections.Generic.List<System.String>();
Colors = new System.Collections.Generic.List<System.String>();
}
public msPublication( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPublication FromClassMetadata(ClassMetadata meta){return new msPublication(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public System.Int32 DisplayOrder {
get { return SafeGetValue<System.Int32>("DisplayOrder");}
set { this["DisplayOrder"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.Boolean VisibleInPortal {
get { return SafeGetValue<System.Boolean>("VisibleInPortal");}
set { this["VisibleInPortal"] = value;}
}

public System.String Image {
get { return SafeGetValue<System.String>("Image");}
set { this["Image"] = value;}
}

public System.Collections.Generic.List<System.String> Sizes {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Sizes");}
set { this["Sizes"] = value;}
}

public System.Collections.Generic.List<System.String> Positions {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Positions");}
set { this["Positions"] = value;}
}

public System.Collections.Generic.List<System.String> Colors {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Colors");}
set { this["Colors"] = value;}
}

public System.String InsertionOrderInvoiceType {
get { return SafeGetValue<System.String>("InsertionOrderInvoiceType");}
set { this["InsertionOrderInvoiceType"] = value;}
}

public System.String SubscriptionInvoiceType {
get { return SafeGetValue<System.String>("SubscriptionInvoiceType");}
set { this["SubscriptionInvoiceType"] = value;}
}

}
[Serializable]
public class msPublicationType : msConfigurableType {
public new const string CLASS_NAME = "PublicationType";
public new  static class FIELDS {
}
public msPublicationType() : base() {
ClassType = "PublicationType";
}
public msPublicationType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPublicationType FromClassMetadata(ClassMetadata meta){return new msPublicationType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msRateCard : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "RateCard";
public new  static class FIELDS {
public const string Entries = "Entries";
public const string Terms = "Terms";
public const string Publication = "Publication";
public const string Product = "Product";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string Notes = "Notes";
}
public msRateCard() : base() {
ClassType = "RateCard";
Entries = new System.Collections.Generic.List<msRateCardEntry>();
}
public msRateCard( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRateCard FromClassMetadata(ClassMetadata meta){return new msRateCard(MemberSuiteObject.FromClassMetadata(meta));}
public System.Collections.Generic.List<msRateCardEntry> Entries {
get { return SafeGetValue<System.Collections.Generic.List<msRateCardEntry>>("Entries");}
set { this["Entries"] = value;}
}

public System.String Terms {
get { return SafeGetValue<System.String>("Terms");}
set { this["Terms"] = value;}
}

public System.String Publication {
get { return SafeGetValue<System.String>("Publication");}
set { this["Publication"] = value;}
}

public System.String Product {
get { return SafeGetValue<System.String>("Product");}
set { this["Product"] = value;}
}

public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? EndDate {
get { return SafeGetValue<System.DateTime?>("EndDate");}
set { this["EndDate"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msRateCardEntry : msAggregateChild {
public new const string CLASS_NAME = "RateCardEntry";
public new  static class FIELDS {
public const string Size = "Size";
public const string Color = "Color";
public const string Position = "Position";
public const string Frequency = "Frequency";
public const string Rate = "Rate";
}
public msRateCardEntry() : base() {
ClassType = "RateCardEntry";
}
public msRateCardEntry( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRateCardEntry FromClassMetadata(ClassMetadata meta){return new msRateCardEntry(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Size {
get { return SafeGetValue<System.String>("Size");}
set { this["Size"] = value;}
}

public System.String Color {
get { return SafeGetValue<System.String>("Color");}
set { this["Color"] = value;}
}

public System.String Position {
get { return SafeGetValue<System.String>("Position");}
set { this["Position"] = value;}
}

public System.Int32 Frequency {
get { return SafeGetValue<System.Int32>("Frequency");}
set { this["Frequency"] = value;}
}

public System.Decimal Rate {
get { return SafeGetValue<System.Decimal>("Rate");}
set { this["Rate"] = value;}
}

}
[Serializable]
public class msAdType : msConfigurableType {
public new const string CLASS_NAME = "AdType";
public new  static class FIELDS {
}
public msAdType() : base() {
ClassType = "AdType";
}
public msAdType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAdType FromClassMetadata(ClassMetadata meta){return new msAdType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAdColor : msConfigurableType {
public new const string CLASS_NAME = "AdColor";
public new  static class FIELDS {
}
public msAdColor() : base() {
ClassType = "AdColor";
}
public msAdColor( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAdColor FromClassMetadata(ClassMetadata meta){return new msAdColor(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msSalesRep : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "SalesRep";
public new  static class FIELDS {
public const string Individual = "Individual";
public const string DefaultCommission = "DefaultCommission";
public const string Notes = "Notes";
}
public msSalesRep() : base() {
ClassType = "SalesRep";
}
public msSalesRep( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSalesRep FromClassMetadata(ClassMetadata meta){return new msSalesRep(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Individual {
get { return SafeGetValue<System.String>("Individual");}
set { this["Individual"] = value;}
}

public System.Decimal DefaultCommission {
get { return SafeGetValue<System.Decimal>("DefaultCommission");}
set { this["DefaultCommission"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msAward : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Award";
public new  static class FIELDS {
public const string Description = "Description";
public const string Type = "Type";
public const string IsActive = "IsActive";
public const string CreateRecipientPageLayout = "CreateRecipientPageLayout";
public const string EditRecipientPageLayout = "EditRecipientPageLayout";
public const string ViewRecipientPageLayout = "ViewRecipientPageLayout";
public const string PortalRecipientPageLayout = "PortalRecipientPageLayout";
}
public msAward() : base() {
ClassType = "Award";
}
public msAward( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAward FromClassMetadata(ClassMetadata meta){return new msAward(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.String CreateRecipientPageLayout {
get { return SafeGetValue<System.String>("CreateRecipientPageLayout");}
set { this["CreateRecipientPageLayout"] = value;}
}

public System.String EditRecipientPageLayout {
get { return SafeGetValue<System.String>("EditRecipientPageLayout");}
set { this["EditRecipientPageLayout"] = value;}
}

public System.String ViewRecipientPageLayout {
get { return SafeGetValue<System.String>("ViewRecipientPageLayout");}
set { this["ViewRecipientPageLayout"] = value;}
}

public System.String PortalRecipientPageLayout {
get { return SafeGetValue<System.String>("PortalRecipientPageLayout");}
set { this["PortalRecipientPageLayout"] = value;}
}

}
[Serializable]
public class msAwardRecipient : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "AwardRecipient";
public new  static class FIELDS {
public const string Award = "Award";
public const string Recipient = "Recipient";
public const string Period = "Period";
public const string Date = "Date";
public const string Status = "Status";
public const string Designation = "Designation";
public const string CompetitionEntry = "CompetitionEntry";
public const string Notes = "Notes";
}
public msAwardRecipient() : base() {
ClassType = "AwardRecipient";
}
public msAwardRecipient( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAwardRecipient FromClassMetadata(ClassMetadata meta){return new msAwardRecipient(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Award {
get { return SafeGetValue<System.String>("Award");}
set { this["Award"] = value;}
}

public System.String Recipient {
get { return SafeGetValue<System.String>("Recipient");}
set { this["Recipient"] = value;}
}

public System.String Period {
get { return SafeGetValue<System.String>("Period");}
set { this["Period"] = value;}
}

public System.DateTime? Date {
get { return SafeGetValue<System.DateTime?>("Date");}
set { this["Date"] = value;}
}

public System.String Status {
get { return SafeGetValue<System.String>("Status");}
set { this["Status"] = value;}
}

public System.String Designation {
get { return SafeGetValue<System.String>("Designation");}
set { this["Designation"] = value;}
}

public System.String CompetitionEntry {
get { return SafeGetValue<System.String>("CompetitionEntry");}
set { this["CompetitionEntry"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msAwardeeStatus : msConfigurableType {
public new const string CLASS_NAME = "AwardeeStatus";
public new  static class FIELDS {
public const string NamePlural = "NamePlural";
}
public msAwardeeStatus() : base() {
ClassType = "AwardeeStatus";
}
public msAwardeeStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAwardeeStatus FromClassMetadata(ClassMetadata meta){return new msAwardeeStatus(MemberSuiteObject.FromClassMetadata(meta));}
public System.String NamePlural {
get { return SafeGetValue<System.String>("NamePlural");}
set { this["NamePlural"] = value;}
}

}
[Serializable]
public class msAwardPeriod : msAssociationDomainObject {
public new const string CLASS_NAME = "AwardPeriod";
public new  static class FIELDS {
public const string Award = "Award";
public const string AwardDate = "AwardDate";
public const string Description = "Description";
}
public msAwardPeriod() : base() {
ClassType = "AwardPeriod";
}
public msAwardPeriod( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAwardPeriod FromClassMetadata(ClassMetadata meta){return new msAwardPeriod(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Award {
get { return SafeGetValue<System.String>("Award");}
set { this["Award"] = value;}
}

public System.DateTime AwardDate {
get { return SafeGetValue<System.DateTime>("AwardDate");}
set { this["AwardDate"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msAwardeeDesignation : msConfigurableType {
public new const string CLASS_NAME = "AwardeeDesignation";
public new  static class FIELDS {
}
public msAwardeeDesignation() : base() {
ClassType = "AwardeeDesignation";
}
public msAwardeeDesignation( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAwardeeDesignation FromClassMetadata(ClassMetadata meta){return new msAwardeeDesignation(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAwardType : msConfigurableType {
public new const string CLASS_NAME = "AwardType";
public new  static class FIELDS {
}
public msAwardType() : base() {
ClassType = "AwardType";
}
public msAwardType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAwardType FromClassMetadata(ClassMetadata meta){return new msAwardType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msSponsorship : msAssociationDomainObject {
public new const string CLASS_NAME = "Sponsorship";
public new  static class FIELDS {
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
public const string Sponsor = "Sponsor";
public const string Amount = "Amount";
public const string Quantity = "Quantity";
public const string Notes = "Notes";
}
public msSponsorship() : base() {
ClassType = "Sponsorship";
}
public msSponsorship( MemberSuiteObject msObj) : base(msObj) {}
public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.String Sponsor {
get { return SafeGetValue<System.String>("Sponsor");}
set { this["Sponsor"] = value;}
}

public System.Decimal Amount {
get { return SafeGetValue<System.Decimal>("Amount");}
set { this["Amount"] = value;}
}

public System.Decimal Quantity {
get { return SafeGetValue<System.Decimal>("Quantity");}
set { this["Quantity"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msCompetitionSponsorship : msSponsorship {
public new const string CLASS_NAME = "CompetitionSponsorship";
public new  static class FIELDS {
public const string Competition = "Competition";
public const string Fee = "Fee";
}
public msCompetitionSponsorship() : base() {
ClassType = "CompetitionSponsorship";
}
public msCompetitionSponsorship( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCompetitionSponsorship FromClassMetadata(ClassMetadata meta){return new msCompetitionSponsorship(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Competition {
get { return SafeGetValue<System.String>("Competition");}
set { this["Competition"] = value;}
}

public System.String Fee {
get { return SafeGetValue<System.String>("Fee");}
set { this["Fee"] = value;}
}

}
[Serializable]
public class msCompetition : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Competition";
public new  static class FIELDS {
public const string Code = "Code";
public const string Type = "Type";
public const string Description = "Description";
public const string OpenDate = "OpenDate";
public const string CloseDate = "CloseDate";
public const string PostToWeb = "PostToWeb";
public const string RemoveFromWeb = "RemoveFromWeb";
public const string MaximumNumberOfEntriesPerEntrant = "MaximumNumberOfEntriesPerEntrant";
public const string IsClosed = "IsClosed";
public const string CanSaveDraft = "CanSaveDraft";
public const string EntryFormInstructions = "EntryFormInstructions";
public const string ConfirmationEmail = "ConfirmationEmail";
public const string OtherJudgeScoreVisibilityMode = "OtherJudgeScoreVisibilityMode";
public const string JudgingInstructions = "JudgingInstructions";
public const string Event = "Event";
}
public msCompetition() : base() {
ClassType = "Competition";
}
public msCompetition( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCompetition FromClassMetadata(ClassMetadata meta){return new msCompetition(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.DateTime OpenDate {
get { return SafeGetValue<System.DateTime>("OpenDate");}
set { this["OpenDate"] = value;}
}

public System.DateTime CloseDate {
get { return SafeGetValue<System.DateTime>("CloseDate");}
set { this["CloseDate"] = value;}
}

public System.DateTime? PostToWeb {
get { return SafeGetValue<System.DateTime?>("PostToWeb");}
set { this["PostToWeb"] = value;}
}

public System.DateTime? RemoveFromWeb {
get { return SafeGetValue<System.DateTime?>("RemoveFromWeb");}
set { this["RemoveFromWeb"] = value;}
}

public System.Int32? MaximumNumberOfEntriesPerEntrant {
get { return SafeGetValue<System.Int32?>("MaximumNumberOfEntriesPerEntrant");}
set { this["MaximumNumberOfEntriesPerEntrant"] = value;}
}

public System.Boolean IsClosed {
get { return SafeGetValue<System.Boolean>("IsClosed");}
set { this["IsClosed"] = value;}
}

public System.Boolean CanSaveDraft {
get { return SafeGetValue<System.Boolean>("CanSaveDraft");}
set { this["CanSaveDraft"] = value;}
}

public System.String EntryFormInstructions {
get { return SafeGetValue<System.String>("EntryFormInstructions");}
set { this["EntryFormInstructions"] = value;}
}

public System.String ConfirmationEmail {
get { return SafeGetValue<System.String>("ConfirmationEmail");}
set { this["ConfirmationEmail"] = value;}
}

public MemberSuite.SDK.Types.JudgeScoreVisibilityMode OtherJudgeScoreVisibilityMode {
get { return SafeGetValue<MemberSuite.SDK.Types.JudgeScoreVisibilityMode>("OtherJudgeScoreVisibilityMode");}
set { this["OtherJudgeScoreVisibilityMode"] = value;}
}

public System.String JudgingInstructions {
get { return SafeGetValue<System.String>("JudgingInstructions");}
set { this["JudgingInstructions"] = value;}
}

public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

}
[Serializable]
public class msCompetitionEntry : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "CompetitionEntry";
public new  static class FIELDS {
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
public const string Competition = "Competition";
public const string Entrant = "Entrant";
public const string EntryFee = "EntryFee";
public const string Status = "Status";
public const string DateSubmitted = "DateSubmitted";
public const string JudgingRound = "JudgingRound";
public const string JudgingBucket = "JudgingBucket";
public const string Notes = "Notes";
public const string Abstract = "Abstract";
}
public msCompetitionEntry() : base() {
ClassType = "CompetitionEntry";
}
public msCompetitionEntry( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCompetitionEntry FromClassMetadata(ClassMetadata meta){return new msCompetitionEntry(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.String Competition {
get { return SafeGetValue<System.String>("Competition");}
set { this["Competition"] = value;}
}

public System.String Entrant {
get { return SafeGetValue<System.String>("Entrant");}
set { this["Entrant"] = value;}
}

public System.String EntryFee {
get { return SafeGetValue<System.String>("EntryFee");}
set { this["EntryFee"] = value;}
}

public System.String Status {
get { return SafeGetValue<System.String>("Status");}
set { this["Status"] = value;}
}

public System.DateTime? DateSubmitted {
get { return SafeGetValue<System.DateTime?>("DateSubmitted");}
set { this["DateSubmitted"] = value;}
}

public System.String JudgingRound {
get { return SafeGetValue<System.String>("JudgingRound");}
set { this["JudgingRound"] = value;}
}

public System.String JudgingBucket {
get { return SafeGetValue<System.String>("JudgingBucket");}
set { this["JudgingBucket"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.String Abstract {
get { return SafeGetValue<System.String>("Abstract");}
set { this["Abstract"] = value;}
}

}
[Serializable]
public class msCompetitionEntryFee : msProduct {
public new const string CLASS_NAME = "CompetitionEntryFee";
public new  static class FIELDS {
public const string Competition = "Competition";
}
public msCompetitionEntryFee() : base() {
ClassType = "CompetitionEntryFee";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msCompetitionEntryFee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCompetitionEntryFee FromClassMetadata(ClassMetadata meta){return new msCompetitionEntryFee(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Competition {
get { return SafeGetValue<System.String>("Competition");}
set { this["Competition"] = value;}
}

}
[Serializable]
public class msCompetitionEntryStatus : msConfigurableType {
public new const string CLASS_NAME = "CompetitionEntryStatus";
public new  static class FIELDS {
}
public msCompetitionEntryStatus() : base() {
ClassType = "CompetitionEntryStatus";
}
public msCompetitionEntryStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCompetitionEntryStatus FromClassMetadata(ClassMetadata meta){return new msCompetitionEntryStatus(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msCompetitionSponsorshipFee : msProduct {
public new const string CLASS_NAME = "CompetitionSponsorshipFee";
public new  static class FIELDS {
public const string Competition = "Competition";
}
public msCompetitionSponsorshipFee() : base() {
ClassType = "CompetitionSponsorshipFee";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msCompetitionSponsorshipFee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCompetitionSponsorshipFee FromClassMetadata(ClassMetadata meta){return new msCompetitionSponsorshipFee(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Competition {
get { return SafeGetValue<System.String>("Competition");}
set { this["Competition"] = value;}
}

}
[Serializable]
public class msCompetitionType : msConfigurableType {
public new const string CLASS_NAME = "CompetitionType";
public new  static class FIELDS {
}
public msCompetitionType() : base() {
ClassType = "CompetitionType";
}
public msCompetitionType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCompetitionType FromClassMetadata(ClassMetadata meta){return new msCompetitionType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msJudgingBucket : msAssociationDomainObject {
public new const string CLASS_NAME = "JudgingBucket";
public new  static class FIELDS {
public const string Competition = "Competition";
public const string Notes = "Notes";
}
public msJudgingBucket() : base() {
ClassType = "JudgingBucket";
}
public msJudgingBucket( MemberSuiteObject msObj) : base(msObj) {}
 public static new msJudgingBucket FromClassMetadata(ClassMetadata meta){return new msJudgingBucket(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Competition {
get { return SafeGetValue<System.String>("Competition");}
set { this["Competition"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msJudgingRound : msAssociationDomainObject {
public new const string CLASS_NAME = "JudgingRound";
public new  static class FIELDS {
public const string Competition = "Competition";
public const string RoundNumber = "RoundNumber";
public const string WinningRound = "WinningRound";
public const string JudgingBegins = "JudgingBegins";
public const string JudgingEnds = "JudgingEnds";
public const string Notes = "Notes";
}
public msJudgingRound() : base() {
ClassType = "JudgingRound";
}
public msJudgingRound( MemberSuiteObject msObj) : base(msObj) {}
 public static new msJudgingRound FromClassMetadata(ClassMetadata meta){return new msJudgingRound(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Competition {
get { return SafeGetValue<System.String>("Competition");}
set { this["Competition"] = value;}
}

public System.Int32 RoundNumber {
get { return SafeGetValue<System.Int32>("RoundNumber");}
set { this["RoundNumber"] = value;}
}

public System.Boolean WinningRound {
get { return SafeGetValue<System.Boolean>("WinningRound");}
set { this["WinningRound"] = value;}
}

public System.DateTime? JudgingBegins {
get { return SafeGetValue<System.DateTime?>("JudgingBegins");}
set { this["JudgingBegins"] = value;}
}

public System.DateTime? JudgingEnds {
get { return SafeGetValue<System.DateTime?>("JudgingEnds");}
set { this["JudgingEnds"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msJudgingTeam : msAssociationDomainObject {
public new const string CLASS_NAME = "JudgingTeam";
public new  static class FIELDS {
public const string Competition = "Competition";
public const string Members = "Members";
public const string Buckets = "Buckets";
public const string Notes = "Notes";
}
public msJudgingTeam() : base() {
ClassType = "JudgingTeam";
Members = new System.Collections.Generic.List<System.String>();
Buckets = new System.Collections.Generic.List<System.String>();
}
public msJudgingTeam( MemberSuiteObject msObj) : base(msObj) {}
 public static new msJudgingTeam FromClassMetadata(ClassMetadata meta){return new msJudgingTeam(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Competition {
get { return SafeGetValue<System.String>("Competition");}
set { this["Competition"] = value;}
}

public System.Collections.Generic.List<System.String> Members {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Members");}
set { this["Members"] = value;}
}

public System.Collections.Generic.List<System.String> Buckets {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Buckets");}
set { this["Buckets"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msScoreCard : msAssociationDomainObject {
public new const string CLASS_NAME = "ScoreCard";
public new  static class FIELDS {
public const string Judge = "Judge";
public const string Entry = "Entry";
public const string Round = "Round";
public const string Scores = "Scores";
public const string Comments = "Comments";
}
public msScoreCard() : base() {
ClassType = "ScoreCard";
Scores = new System.Collections.Generic.List<msScoreCardScore>();
}
public msScoreCard( MemberSuiteObject msObj) : base(msObj) {}
 public static new msScoreCard FromClassMetadata(ClassMetadata meta){return new msScoreCard(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Judge {
get { return SafeGetValue<System.String>("Judge");}
set { this["Judge"] = value;}
}

public System.String Entry {
get { return SafeGetValue<System.String>("Entry");}
set { this["Entry"] = value;}
}

public System.String Round {
get { return SafeGetValue<System.String>("Round");}
set { this["Round"] = value;}
}

public System.Collections.Generic.List<msScoreCardScore> Scores {
get { return SafeGetValue<System.Collections.Generic.List<msScoreCardScore>>("Scores");}
set { this["Scores"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

}
[Serializable]
public class msScoreCardScore : msAggregateChild {
public new const string CLASS_NAME = "ScoreCardScore";
public new  static class FIELDS {
public const string Criterion = "Criterion";
public const string Score = "Score";
}
public msScoreCardScore() : base() {
ClassType = "ScoreCardScore";
}
public msScoreCardScore( MemberSuiteObject msObj) : base(msObj) {}
 public static new msScoreCardScore FromClassMetadata(ClassMetadata meta){return new msScoreCardScore(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Criterion {
get { return SafeGetValue<System.String>("Criterion");}
set { this["Criterion"] = value;}
}

public System.Decimal Score {
get { return SafeGetValue<System.Decimal>("Score");}
set { this["Score"] = value;}
}

}
[Serializable]
public class msScoringCriterion : msAssociationDomainObject {
public new const string CLASS_NAME = "ScoringCriterion";
public new  static class FIELDS {
public const string Competition = "Competition";
public const string DisplayOrder = "DisplayOrder";
public const string Description = "Description";
public const string MinimumScore = "MinimumScore";
public const string MaximumScore = "MaximumScore";
public const string AllowDecimalScores = "AllowDecimalScores";
}
public msScoringCriterion() : base() {
ClassType = "ScoringCriterion";
}
public msScoringCriterion( MemberSuiteObject msObj) : base(msObj) {}
 public static new msScoringCriterion FromClassMetadata(ClassMetadata meta){return new msScoringCriterion(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Competition {
get { return SafeGetValue<System.String>("Competition");}
set { this["Competition"] = value;}
}

public System.Int32 DisplayOrder {
get { return SafeGetValue<System.Int32>("DisplayOrder");}
set { this["DisplayOrder"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Int32 MinimumScore {
get { return SafeGetValue<System.Int32>("MinimumScore");}
set { this["MinimumScore"] = value;}
}

public System.Int32 MaximumScore {
get { return SafeGetValue<System.Int32>("MaximumScore");}
set { this["MaximumScore"] = value;}
}

public System.Boolean AllowDecimalScores {
get { return SafeGetValue<System.Boolean>("AllowDecimalScores");}
set { this["AllowDecimalScores"] = value;}
}

}
[Serializable]
public class msAutomatedRecurringProcess : msAssociationDomainObject {
public new const string CLASS_NAME = "AutomatedRecurringProcess";
public new  static class FIELDS {
public const string StartDate = "StartDate";
public const string NextScheduledRun = "NextScheduledRun";
public const string DateLastRun = "DateLastRun";
public const string Suspended = "Suspended";
public const string ErrorMessage = "ErrorMessage";
public const string NumberOfTimesRun = "NumberOfTimesRun";
public const string Recurrence = "Recurrence";
public const string ExecutionSchedule = "ExecutionSchedule";
public const string ExecutionEnds = "ExecutionEnds";
public const string EmailAddresses = "EmailAddresses";
}
public msAutomatedRecurringProcess() : base() {
ClassType = "AutomatedRecurringProcess";
}
public msAutomatedRecurringProcess( MemberSuiteObject msObj) : base(msObj) {}
public System.DateTime StartDate {
get { return SafeGetValue<System.DateTime>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? NextScheduledRun {
get { return SafeGetValue<System.DateTime?>("NextScheduledRun");}
set { this["NextScheduledRun"] = value;}
}

public System.DateTime? DateLastRun {
get { return SafeGetValue<System.DateTime?>("DateLastRun");}
set { this["DateLastRun"] = value;}
}

public System.Boolean Suspended {
get { return SafeGetValue<System.Boolean>("Suspended");}
set { this["Suspended"] = value;}
}

public System.String ErrorMessage {
get { return SafeGetValue<System.String>("ErrorMessage");}
set { this["ErrorMessage"] = value;}
}

public System.Int32 NumberOfTimesRun {
get { return SafeGetValue<System.Int32>("NumberOfTimesRun");}
set { this["NumberOfTimesRun"] = value;}
}

public MemberSuite.SDK.Types.AutomatedProcessRecurrence Recurrence {
get { return SafeGetValue<MemberSuite.SDK.Types.AutomatedProcessRecurrence>("Recurrence");}
set { this["Recurrence"] = value;}
}

public System.String ExecutionSchedule {
get { return SafeGetValue<System.String>("ExecutionSchedule");}
set { this["ExecutionSchedule"] = value;}
}

public System.String ExecutionEnds {
get { return SafeGetValue<System.String>("ExecutionEnds");}
set { this["ExecutionEnds"] = value;}
}

public System.String EmailAddresses {
get { return SafeGetValue<System.String>("EmailAddresses");}
set { this["EmailAddresses"] = value;}
}

}
[Serializable]
public class msCatalogAggregate : msAggregate {
public new const string CLASS_NAME = "CatalogAggregate";
public new  static class FIELDS {
}
public msCatalogAggregate() : base() {
ClassType = "CatalogAggregate";
}
public msCatalogAggregate( MemberSuiteObject msObj) : base(msObj) {}
}
[Serializable]
public class msSystemDomainObject : msCatalogAggregate {
public new const string CLASS_NAME = "SystemDomainObject";
public new  static class FIELDS {
}
public msSystemDomainObject() : base() {
ClassType = "SystemDomainObject";
}
public msSystemDomainObject( MemberSuiteObject msObj) : base(msObj) {}
}
[Serializable]
public class msCatalogAnnouncement : msSystemDomainObject {
public new const string CLASS_NAME = "CatalogAnnouncement";
public new  static class FIELDS {
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string IsActive = "IsActive";
public const string Users = "Users";
public const string AnnouncementText = "AnnouncementText";
}
public msCatalogAnnouncement() : base() {
ClassType = "CatalogAnnouncement";
Users = new System.Collections.Generic.List<System.String>();
}
public msCatalogAnnouncement( MemberSuiteObject msObj) : base(msObj) {}
public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? EndDate {
get { return SafeGetValue<System.DateTime?>("EndDate");}
set { this["EndDate"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.Collections.Generic.List<System.String> Users {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Users");}
set { this["Users"] = value;}
}

public System.String AnnouncementText {
get { return SafeGetValue<System.String>("AnnouncementText");}
set { this["AnnouncementText"] = value;}
}

}
[Serializable]
public class msCustomerAnnouncement : msCatalogAnnouncement {
public new const string CLASS_NAME = "CustomerAnnouncement";
public new  static class FIELDS {
public const string Customer = "Customer";
}
public msCustomerAnnouncement() : base() {
ClassType = "CustomerAnnouncement";
Users = new System.Collections.Generic.List<System.String>();
}
public msCustomerAnnouncement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomerAnnouncement FromClassMetadata(ClassMetadata meta){return new msCustomerAnnouncement(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Customer {
get { return SafeGetValue<System.String>("Customer");}
set { this["Customer"] = value;}
}

}
[Serializable]
public class msInformationLink : msAssociationDomainObject {
public new const string CLASS_NAME = "InformationLink";
public new  static class FIELDS {
public const string Code = "Code";
public const string Html = "Html";
public const string IsActive = "IsActive";
public const string DisplayOrder = "DisplayOrder";
public const string MembersOnly = "MembersOnly";
}
public msInformationLink() : base() {
ClassType = "InformationLink";
}
public msInformationLink( MemberSuiteObject msObj) : base(msObj) {}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String Html {
get { return SafeGetValue<System.String>("Html");}
set { this["Html"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.Int32 DisplayOrder {
get { return SafeGetValue<System.Int32>("DisplayOrder");}
set { this["DisplayOrder"] = value;}
}

public System.Boolean MembersOnly {
get { return SafeGetValue<System.Boolean>("MembersOnly");}
set { this["MembersOnly"] = value;}
}

}
[Serializable]
public class msNetPromoterScore : msSystemDomainObject {
public new const string CLASS_NAME = "NetPromoterScore";
public new  static class FIELDS {
public const string User = "User";
public const string Customer = "Customer";
public const string Score = "Score";
public const string Comments = "Comments";
}
public msNetPromoterScore() : base() {
ClassType = "NetPromoterScore";
}
public msNetPromoterScore( MemberSuiteObject msObj) : base(msObj) {}
 public static new msNetPromoterScore FromClassMetadata(ClassMetadata meta){return new msNetPromoterScore(MemberSuiteObject.FromClassMetadata(meta));}
public System.String User {
get { return SafeGetValue<System.String>("User");}
set { this["User"] = value;}
}

public System.String Customer {
get { return SafeGetValue<System.String>("Customer");}
set { this["Customer"] = value;}
}

public System.Int16 Score {
get { return SafeGetValue<System.Int16>("Score");}
set { this["Score"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

}
[Serializable]
public class msResellerAnnouncement : msCatalogAnnouncement {
public new const string CLASS_NAME = "ResellerAnnouncement";
public new  static class FIELDS {
public const string Reseller = "Reseller";
}
public msResellerAnnouncement() : base() {
ClassType = "ResellerAnnouncement";
Users = new System.Collections.Generic.List<System.String>();
}
public msResellerAnnouncement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msResellerAnnouncement FromClassMetadata(ClassMetadata meta){return new msResellerAnnouncement(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Reseller {
get { return SafeGetValue<System.String>("Reseller");}
set { this["Reseller"] = value;}
}

}
[Serializable]
public class msSystemWideAnnouncement : msCatalogAnnouncement {
public new const string CLASS_NAME = "SystemWideAnnouncement";
public new  static class FIELDS {
}
public msSystemWideAnnouncement() : base() {
ClassType = "SystemWideAnnouncement";
Users = new System.Collections.Generic.List<System.String>();
}
public msSystemWideAnnouncement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSystemWideAnnouncement FromClassMetadata(ClassMetadata meta){return new msSystemWideAnnouncement(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msBillingCycle : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "BillingCycle";
public new  static class FIELDS {
public const string ContactRelationshipTypes = "ContactRelationshipTypes";
public const string IncludeMemberships = "IncludeMemberships";
public const string MembershipSearchToUse = "MembershipSearchToUse";
public const string MembershipCriteria = "MembershipCriteria";
public const string IncludeSubscriptions = "IncludeSubscriptions";
public const string SubscriptionSearchToUse = "SubscriptionSearchToUse";
public const string SubscriptionCriteria = "SubscriptionCriteria";
public const string Description = "Description";
public const string NewStatusForInitialBillings = "NewStatusForInitialBillings";
public const string NewStatusForFirstReminders = "NewStatusForFirstReminders";
public const string NewStatusForSecondReminders = "NewStatusForSecondReminders";
public const string NewStatusForThirdReminders = "NewStatusForThirdReminders";
public const string NewStatusForDrops = "NewStatusForDrops";
public const string TerminationReasonForDrops = "TerminationReasonForDrops";
}
public msBillingCycle() : base() {
ClassType = "BillingCycle";
ContactRelationshipTypes = new System.Collections.Generic.List<msBillingCycleContactRelationshipType>();
}
public msBillingCycle( MemberSuiteObject msObj) : base(msObj) {}
 public static new msBillingCycle FromClassMetadata(ClassMetadata meta){return new msBillingCycle(MemberSuiteObject.FromClassMetadata(meta));}
public System.Collections.Generic.List<msBillingCycleContactRelationshipType> ContactRelationshipTypes {
get { return SafeGetValue<System.Collections.Generic.List<msBillingCycleContactRelationshipType>>("ContactRelationshipTypes");}
set { this["ContactRelationshipTypes"] = value;}
}

public System.Boolean IncludeMemberships {
get { return SafeGetValue<System.Boolean>("IncludeMemberships");}
set { this["IncludeMemberships"] = value;}
}

public MemberSuite.SDK.Searching.Search MembershipSearchToUse {
get { return SafeGetValue<MemberSuite.SDK.Searching.Search>("MembershipSearchToUse");}
set { this["MembershipSearchToUse"] = value;}
}

public System.String MembershipCriteria {
get { return SafeGetValue<System.String>("MembershipCriteria");}
set { this["MembershipCriteria"] = value;}
}

public System.Boolean IncludeSubscriptions {
get { return SafeGetValue<System.Boolean>("IncludeSubscriptions");}
set { this["IncludeSubscriptions"] = value;}
}

public MemberSuite.SDK.Searching.Search SubscriptionSearchToUse {
get { return SafeGetValue<MemberSuite.SDK.Searching.Search>("SubscriptionSearchToUse");}
set { this["SubscriptionSearchToUse"] = value;}
}

public System.String SubscriptionCriteria {
get { return SafeGetValue<System.String>("SubscriptionCriteria");}
set { this["SubscriptionCriteria"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String NewStatusForInitialBillings {
get { return SafeGetValue<System.String>("NewStatusForInitialBillings");}
set { this["NewStatusForInitialBillings"] = value;}
}

public System.String NewStatusForFirstReminders {
get { return SafeGetValue<System.String>("NewStatusForFirstReminders");}
set { this["NewStatusForFirstReminders"] = value;}
}

public System.String NewStatusForSecondReminders {
get { return SafeGetValue<System.String>("NewStatusForSecondReminders");}
set { this["NewStatusForSecondReminders"] = value;}
}

public System.String NewStatusForThirdReminders {
get { return SafeGetValue<System.String>("NewStatusForThirdReminders");}
set { this["NewStatusForThirdReminders"] = value;}
}

public System.String NewStatusForDrops {
get { return SafeGetValue<System.String>("NewStatusForDrops");}
set { this["NewStatusForDrops"] = value;}
}

public System.String TerminationReasonForDrops {
get { return SafeGetValue<System.String>("TerminationReasonForDrops");}
set { this["TerminationReasonForDrops"] = value;}
}

}
[Serializable]
public class msBillingCycleContactRelationshipType : msAggregateChild {
public new const string CLASS_NAME = "BillingCycleContactRelationshipType";
public new  static class FIELDS {
public const string RelationshipType = "RelationshipType";
}
public msBillingCycleContactRelationshipType() : base() {
ClassType = "BillingCycleContactRelationshipType";
}
public msBillingCycleContactRelationshipType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msBillingCycleContactRelationshipType FromClassMetadata(ClassMetadata meta){return new msBillingCycleContactRelationshipType(MemberSuiteObject.FromClassMetadata(meta));}
public System.String RelationshipType {
get { return SafeGetValue<System.String>("RelationshipType");}
set { this["RelationshipType"] = value;}
}

}
[Serializable]
public class msBillingRun : msAssociationDomainObject {
public new const string CLASS_NAME = "BillingRun";
public new  static class FIELDS {
public const string ErrorMessage = "ErrorMessage";
public const string Status = "Status";
public const string Cycle = "Cycle";
public const string RecurringBillingRun = "RecurringBillingRun";
public const string RunDate = "RunDate";
public const string PerformInitialBilling = "PerformInitialBilling";
public const string InitialBillingRangeBegin = "InitialBillingRangeBegin";
public const string InitialBillingRangeEnd = "InitialBillingRangeEnd";
public const string GenerateFirstReminders = "GenerateFirstReminders";
public const string FirstReminderRangeBegin = "FirstReminderRangeBegin";
public const string FirstReminderRangeEnd = "FirstReminderRangeEnd";
public const string GenerateSecondReminders = "GenerateSecondReminders";
public const string SecondReminderRangeBegin = "SecondReminderRangeBegin";
public const string SecondReminderRangeEnd = "SecondReminderRangeEnd";
public const string GenerateThirdReminders = "GenerateThirdReminders";
public const string ThirdReminderRangeBegin = "ThirdReminderRangeBegin";
public const string ThirdReminderRangeEnd = "ThirdReminderRangeEnd";
public const string PerformDrops = "PerformDrops";
public const string DropDate = "DropDate";
public const string DateScheduled = "DateScheduled";
public const string DateStarted = "DateStarted";
public const string DateCompleted = "DateCompleted";
public const string Mode = "Mode";
public const string Batch = "Batch";
}
public msBillingRun() : base() {
ClassType = "BillingRun";
}
public msBillingRun( MemberSuiteObject msObj) : base(msObj) {}
 public static new msBillingRun FromClassMetadata(ClassMetadata meta){return new msBillingRun(MemberSuiteObject.FromClassMetadata(meta));}
public System.String ErrorMessage {
get { return SafeGetValue<System.String>("ErrorMessage");}
set { this["ErrorMessage"] = value;}
}

public MemberSuite.SDK.Types.BillingRunStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.BillingRunStatus>("Status");}
set { this["Status"] = value;}
}

public System.String Cycle {
get { return SafeGetValue<System.String>("Cycle");}
set { this["Cycle"] = value;}
}

public System.String RecurringBillingRun {
get { return SafeGetValue<System.String>("RecurringBillingRun");}
set { this["RecurringBillingRun"] = value;}
}

public System.DateTime RunDate {
get { return SafeGetValue<System.DateTime>("RunDate");}
set { this["RunDate"] = value;}
}

public System.Boolean PerformInitialBilling {
get { return SafeGetValue<System.Boolean>("PerformInitialBilling");}
set { this["PerformInitialBilling"] = value;}
}

public System.DateTime? InitialBillingRangeBegin {
get { return SafeGetValue<System.DateTime?>("InitialBillingRangeBegin");}
set { this["InitialBillingRangeBegin"] = value;}
}

public System.DateTime? InitialBillingRangeEnd {
get { return SafeGetValue<System.DateTime?>("InitialBillingRangeEnd");}
set { this["InitialBillingRangeEnd"] = value;}
}

public System.Boolean GenerateFirstReminders {
get { return SafeGetValue<System.Boolean>("GenerateFirstReminders");}
set { this["GenerateFirstReminders"] = value;}
}

public System.DateTime? FirstReminderRangeBegin {
get { return SafeGetValue<System.DateTime?>("FirstReminderRangeBegin");}
set { this["FirstReminderRangeBegin"] = value;}
}

public System.DateTime? FirstReminderRangeEnd {
get { return SafeGetValue<System.DateTime?>("FirstReminderRangeEnd");}
set { this["FirstReminderRangeEnd"] = value;}
}

public System.Boolean GenerateSecondReminders {
get { return SafeGetValue<System.Boolean>("GenerateSecondReminders");}
set { this["GenerateSecondReminders"] = value;}
}

public System.DateTime? SecondReminderRangeBegin {
get { return SafeGetValue<System.DateTime?>("SecondReminderRangeBegin");}
set { this["SecondReminderRangeBegin"] = value;}
}

public System.DateTime? SecondReminderRangeEnd {
get { return SafeGetValue<System.DateTime?>("SecondReminderRangeEnd");}
set { this["SecondReminderRangeEnd"] = value;}
}

public System.Boolean GenerateThirdReminders {
get { return SafeGetValue<System.Boolean>("GenerateThirdReminders");}
set { this["GenerateThirdReminders"] = value;}
}

public System.DateTime? ThirdReminderRangeBegin {
get { return SafeGetValue<System.DateTime?>("ThirdReminderRangeBegin");}
set { this["ThirdReminderRangeBegin"] = value;}
}

public System.DateTime? ThirdReminderRangeEnd {
get { return SafeGetValue<System.DateTime?>("ThirdReminderRangeEnd");}
set { this["ThirdReminderRangeEnd"] = value;}
}

public System.Boolean PerformDrops {
get { return SafeGetValue<System.Boolean>("PerformDrops");}
set { this["PerformDrops"] = value;}
}

public System.DateTime? DropDate {
get { return SafeGetValue<System.DateTime?>("DropDate");}
set { this["DropDate"] = value;}
}

public System.DateTime? DateScheduled {
get { return SafeGetValue<System.DateTime?>("DateScheduled");}
set { this["DateScheduled"] = value;}
}

public System.DateTime? DateStarted {
get { return SafeGetValue<System.DateTime?>("DateStarted");}
set { this["DateStarted"] = value;}
}

public System.DateTime? DateCompleted {
get { return SafeGetValue<System.DateTime?>("DateCompleted");}
set { this["DateCompleted"] = value;}
}

public MemberSuite.SDK.Types.BillingRunMode Mode {
get { return SafeGetValue<MemberSuite.SDK.Types.BillingRunMode>("Mode");}
set { this["Mode"] = value;}
}

public System.String Batch {
get { return SafeGetValue<System.String>("Batch");}
set { this["Batch"] = value;}
}

}
[Serializable]
public class msRecurringBillingRun : msAutomatedRecurringProcess {
public new const string CLASS_NAME = "RecurringBillingRun";
public new  static class FIELDS {
public const string Cycle = "Cycle";
public const string PerformInitialBilling = "PerformInitialBilling";
public const string RunDate = "RunDate";
public const string InitialBillingRangeBegin = "InitialBillingRangeBegin";
public const string InitialBillingRangeEnd = "InitialBillingRangeEnd";
public const string GenerateFirstReminders = "GenerateFirstReminders";
public const string FirstReminderRangeBegin = "FirstReminderRangeBegin";
public const string FirstReminderRangeEnd = "FirstReminderRangeEnd";
public const string GenerateSecondReminders = "GenerateSecondReminders";
public const string SecondReminderRangeBegin = "SecondReminderRangeBegin";
public const string SecondReminderRangeEnd = "SecondReminderRangeEnd";
public const string GenerateThirdReminders = "GenerateThirdReminders";
public const string ThirdReminderRangeBegin = "ThirdReminderRangeBegin";
public const string ThirdReminderRangeEnd = "ThirdReminderRangeEnd";
public const string PerformDrops = "PerformDrops";
public const string DropDate = "DropDate";
public const string TerminationReason = "TerminationReason";
public const string NewStatusForDroppedMembers = "NewStatusForDroppedMembers";
public const string Mode = "Mode";
}
public msRecurringBillingRun() : base() {
ClassType = "RecurringBillingRun";
}
public msRecurringBillingRun( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRecurringBillingRun FromClassMetadata(ClassMetadata meta){return new msRecurringBillingRun(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Cycle {
get { return SafeGetValue<System.String>("Cycle");}
set { this["Cycle"] = value;}
}

public System.Boolean PerformInitialBilling {
get { return SafeGetValue<System.Boolean>("PerformInitialBilling");}
set { this["PerformInitialBilling"] = value;}
}

public System.Int16 RunDate {
get { return SafeGetValue<System.Int16>("RunDate");}
set { this["RunDate"] = value;}
}

public System.Int16? InitialBillingRangeBegin {
get { return SafeGetValue<System.Int16?>("InitialBillingRangeBegin");}
set { this["InitialBillingRangeBegin"] = value;}
}

public System.Int16? InitialBillingRangeEnd {
get { return SafeGetValue<System.Int16?>("InitialBillingRangeEnd");}
set { this["InitialBillingRangeEnd"] = value;}
}

public System.Boolean GenerateFirstReminders {
get { return SafeGetValue<System.Boolean>("GenerateFirstReminders");}
set { this["GenerateFirstReminders"] = value;}
}

public System.Int16? FirstReminderRangeBegin {
get { return SafeGetValue<System.Int16?>("FirstReminderRangeBegin");}
set { this["FirstReminderRangeBegin"] = value;}
}

public System.Int16? FirstReminderRangeEnd {
get { return SafeGetValue<System.Int16?>("FirstReminderRangeEnd");}
set { this["FirstReminderRangeEnd"] = value;}
}

public System.Boolean GenerateSecondReminders {
get { return SafeGetValue<System.Boolean>("GenerateSecondReminders");}
set { this["GenerateSecondReminders"] = value;}
}

public System.Int16? SecondReminderRangeBegin {
get { return SafeGetValue<System.Int16?>("SecondReminderRangeBegin");}
set { this["SecondReminderRangeBegin"] = value;}
}

public System.Int16? SecondReminderRangeEnd {
get { return SafeGetValue<System.Int16?>("SecondReminderRangeEnd");}
set { this["SecondReminderRangeEnd"] = value;}
}

public System.Boolean GenerateThirdReminders {
get { return SafeGetValue<System.Boolean>("GenerateThirdReminders");}
set { this["GenerateThirdReminders"] = value;}
}

public System.Int16? ThirdReminderRangeBegin {
get { return SafeGetValue<System.Int16?>("ThirdReminderRangeBegin");}
set { this["ThirdReminderRangeBegin"] = value;}
}

public System.Int16? ThirdReminderRangeEnd {
get { return SafeGetValue<System.Int16?>("ThirdReminderRangeEnd");}
set { this["ThirdReminderRangeEnd"] = value;}
}

public System.Boolean PerformDrops {
get { return SafeGetValue<System.Boolean>("PerformDrops");}
set { this["PerformDrops"] = value;}
}

public System.Int16? DropDate {
get { return SafeGetValue<System.Int16?>("DropDate");}
set { this["DropDate"] = value;}
}

public System.String TerminationReason {
get { return SafeGetValue<System.String>("TerminationReason");}
set { this["TerminationReason"] = value;}
}

public System.String NewStatusForDroppedMembers {
get { return SafeGetValue<System.String>("NewStatusForDroppedMembers");}
set { this["NewStatusForDroppedMembers"] = value;}
}

public MemberSuite.SDK.Types.BillingRunMode Mode {
get { return SafeGetValue<MemberSuite.SDK.Types.BillingRunMode>("Mode");}
set { this["Mode"] = value;}
}

}
[Serializable]
public class msSavedPaymentMethod : msAssociationDomainObject {
public new const string CLASS_NAME = "SavedPaymentMethod";
public new  static class FIELDS {
public const string Type = "Type";
public const string Owner = "Owner";
}
public msSavedPaymentMethod() : base() {
ClassType = "SavedPaymentMethod";
}
public msSavedPaymentMethod( MemberSuiteObject msObj) : base(msObj) {}
public MemberSuite.SDK.Types.SavedPaymentMethodType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.SavedPaymentMethodType>("Type");}
set { this["Type"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

}
[Serializable]
public class msSavedCreditCard : msSavedPaymentMethod {
public new const string CLASS_NAME = "SavedCreditCard";
public new  static class FIELDS {
public const string Card = "Card";
public const string CardType = "CardType";
public const string CardLastFiveDigits = "CardLastFiveDigits";
}
public msSavedCreditCard() : base() {
ClassType = "SavedCreditCard";
}
public msSavedCreditCard( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSavedCreditCard FromClassMetadata(ClassMetadata meta){return new msSavedCreditCard(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.CreditCard Card {
get { return SafeGetValue<MemberSuite.SDK.Types.CreditCard>("Card");}
set { this["Card"] = value;}
}

public MemberSuite.SDK.Types.CreditCardType CardType {
get { return SafeGetValue<MemberSuite.SDK.Types.CreditCardType>("CardType");}
set { this["CardType"] = value;}
}

public System.String CardLastFiveDigits {
get { return SafeGetValue<System.String>("CardLastFiveDigits");}
set { this["CardLastFiveDigits"] = value;}
}

}
[Serializable]
public class msSavedElectronicCheck : msSavedPaymentMethod {
public new const string CLASS_NAME = "SavedElectronicCheck";
public new  static class FIELDS {
public const string Check = "Check";
}
public msSavedElectronicCheck() : base() {
ClassType = "SavedElectronicCheck";
}
public msSavedElectronicCheck( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSavedElectronicCheck FromClassMetadata(ClassMetadata meta){return new msSavedElectronicCheck(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.ElectronicCheck Check {
get { return SafeGetValue<MemberSuite.SDK.Types.ElectronicCheck>("Check");}
set { this["Check"] = value;}
}

}
[Serializable]
public class msJobPosting : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "JobPosting";
public new  static class FIELDS {
public const string Owner = "Owner";
public const string Body = "Body";
public const string CompanyName = "CompanyName";
public const string Location = "Location";
public const string InternalReferenceCode = "InternalReferenceCode";
public const string Division = "Division";
public const string AllowOnlineResumeSubmission = "AllowOnlineResumeSubmission";
public const string ResumeEmail = "ResumeEmail";
public const string IsApproved = "IsApproved";
public const string Status = "Status";
public const string PostOn = "PostOn";
public const string ExpirationDate = "ExpirationDate";
public const string Order = "Order";
public const string Categories = "Categories";
}
public msJobPosting() : base() {
ClassType = "JobPosting";
Categories = new System.Collections.Generic.List<System.String>();
}
public msJobPosting( MemberSuiteObject msObj) : base(msObj) {}
 public static new msJobPosting FromClassMetadata(ClassMetadata meta){return new msJobPosting(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String Body {
get { return SafeGetValue<System.String>("Body");}
set { this["Body"] = value;}
}

public System.String CompanyName {
get { return SafeGetValue<System.String>("CompanyName");}
set { this["CompanyName"] = value;}
}

public System.String Location {
get { return SafeGetValue<System.String>("Location");}
set { this["Location"] = value;}
}

public System.String InternalReferenceCode {
get { return SafeGetValue<System.String>("InternalReferenceCode");}
set { this["InternalReferenceCode"] = value;}
}

public System.String Division {
get { return SafeGetValue<System.String>("Division");}
set { this["Division"] = value;}
}

public System.Boolean AllowOnlineResumeSubmission {
get { return SafeGetValue<System.Boolean>("AllowOnlineResumeSubmission");}
set { this["AllowOnlineResumeSubmission"] = value;}
}

public System.String ResumeEmail {
get { return SafeGetValue<System.String>("ResumeEmail");}
set { this["ResumeEmail"] = value;}
}

public System.Boolean IsApproved {
get { return SafeGetValue<System.Boolean>("IsApproved");}
set { this["IsApproved"] = value;}
}

public MemberSuite.SDK.Types.JobPostingStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.JobPostingStatus>("Status");}
set { this["Status"] = value;}
}

public System.DateTime? PostOn {
get { return SafeGetValue<System.DateTime?>("PostOn");}
set { this["PostOn"] = value;}
}

public System.DateTime? ExpirationDate {
get { return SafeGetValue<System.DateTime?>("ExpirationDate");}
set { this["ExpirationDate"] = value;}
}

public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.Collections.Generic.List<System.String> Categories {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Categories");}
set { this["Categories"] = value;}
}

}
[Serializable]
public class msJobPostingCategory : msConfigurableType {
public new const string CLASS_NAME = "JobPostingCategory";
public new  static class FIELDS {
}
public msJobPostingCategory() : base() {
ClassType = "JobPostingCategory";
}
public msJobPostingCategory( MemberSuiteObject msObj) : base(msObj) {}
 public static new msJobPostingCategory FromClassMetadata(ClassMetadata meta){return new msJobPostingCategory(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msCareerCenterProduct : msProduct {
public new const string CLASS_NAME = "CareerCenterProduct";
public new  static class FIELDS {
public const string NumberOfJobPostings = "NumberOfJobPostings";
public const string ResumeAccess = "ResumeAccess";
}
public msCareerCenterProduct() : base() {
ClassType = "CareerCenterProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msCareerCenterProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCareerCenterProduct FromClassMetadata(ClassMetadata meta){return new msCareerCenterProduct(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int32? NumberOfJobPostings {
get { return SafeGetValue<System.Int32?>("NumberOfJobPostings");}
set { this["NumberOfJobPostings"] = value;}
}

public System.Int32? ResumeAccess {
get { return SafeGetValue<System.Int32?>("ResumeAccess");}
set { this["ResumeAccess"] = value;}
}

}
[Serializable]
public class msEntitlement : msAssociationDomainObject {
public new const string CLASS_NAME = "Entitlement";
public new  static class FIELDS {
public const string Owner = "Owner";
public const string Quantity = "Quantity";
public const string QuantityAvailable = "QuantityAvailable";
public const string AvailableFrom = "AvailableFrom";
public const string AvailableUntil = "AvailableUntil";
public const string Comments = "Comments";
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
}
public msEntitlement() : base() {
ClassType = "Entitlement";
}
public msEntitlement( MemberSuiteObject msObj) : base(msObj) {}
public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.Decimal Quantity {
get { return SafeGetValue<System.Decimal>("Quantity");}
set { this["Quantity"] = value;}
}

public System.Decimal QuantityAvailable {
get { return SafeGetValue<System.Decimal>("QuantityAvailable");}
set { this["QuantityAvailable"] = value;}
}

public System.DateTime? AvailableFrom {
get { return SafeGetValue<System.DateTime?>("AvailableFrom");}
set { this["AvailableFrom"] = value;}
}

public System.DateTime? AvailableUntil {
get { return SafeGetValue<System.DateTime?>("AvailableUntil");}
set { this["AvailableUntil"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

}
[Serializable]
public class msJobPostingEntitlement : msEntitlement {
public new const string CLASS_NAME = "JobPostingEntitlement";
public new  static class FIELDS {
}
public msJobPostingEntitlement() : base() {
ClassType = "JobPostingEntitlement";
}
public msJobPostingEntitlement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msJobPostingEntitlement FromClassMetadata(ClassMetadata meta){return new msJobPostingEntitlement(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msJobPostingLocation : msConfigurableType {
public new const string CLASS_NAME = "JobPostingLocation";
public new  static class FIELDS {
}
public msJobPostingLocation() : base() {
ClassType = "JobPostingLocation";
}
public msJobPostingLocation( MemberSuiteObject msObj) : base(msObj) {}
 public static new msJobPostingLocation FromClassMetadata(ClassMetadata meta){return new msJobPostingLocation(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msResume : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "Resume";
public new  static class FIELDS {
public const string Owner = "Owner";
public const string File = "File";
public const string IsActive = "IsActive";
public const string IsApproved = "IsApproved";
}
public msResume() : base() {
ClassType = "Resume";
}
public msResume( MemberSuiteObject msObj) : base(msObj) {}
 public static new msResume FromClassMetadata(ClassMetadata meta){return new msResume(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String File {
get { return SafeGetValue<System.String>("File");}
set { this["File"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.Boolean IsApproved {
get { return SafeGetValue<System.Boolean>("IsApproved");}
set { this["IsApproved"] = value;}
}

}
[Serializable]
public class msResumeAccessEntitlement : msEntitlement {
public new const string CLASS_NAME = "ResumeAccessEntitlement";
public new  static class FIELDS {
}
public msResumeAccessEntitlement() : base() {
ClassType = "ResumeAccessEntitlement";
}
public msResumeAccessEntitlement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msResumeAccessEntitlement FromClassMetadata(ClassMetadata meta){return new msResumeAccessEntitlement(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msCertification : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Certification";
public new  static class FIELDS {
public const string Certificant = "Certificant";
public const string Program = "Program";
public const string Status = "Status";
public const string StatusReason = "StatusReason";
public const string Certified = "Certified";
public const string RequirementsMet = "RequirementsMet";
public const string PaidThruDate = "PaidThruDate";
public const string RecertificationDate = "RecertificationDate";
public const string CertificationDate = "CertificationDate";
public const string ApplicationDate = "ApplicationDate";
public const string EffectiveDate = "EffectiveDate";
public const string ExpirationDate = "ExpirationDate";
public const string CertificateSentDate = "CertificateSentDate";
public const string EnrollmentDate = "EnrollmentDate";
public const string TerminationDate = "TerminationDate";
public const string Notes = "Notes";
public const string CEUGracePeriod = "CEUGracePeriod";
}
public msCertification() : base() {
ClassType = "Certification";
}
public msCertification( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertification FromClassMetadata(ClassMetadata meta){return new msCertification(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Certificant {
get { return SafeGetValue<System.String>("Certificant");}
set { this["Certificant"] = value;}
}

public System.String Program {
get { return SafeGetValue<System.String>("Program");}
set { this["Program"] = value;}
}

public System.String Status {
get { return SafeGetValue<System.String>("Status");}
set { this["Status"] = value;}
}

public System.String StatusReason {
get { return SafeGetValue<System.String>("StatusReason");}
set { this["StatusReason"] = value;}
}

public System.Boolean Certified {
get { return SafeGetValue<System.Boolean>("Certified");}
set { this["Certified"] = value;}
}

public System.Boolean RequirementsMet {
get { return SafeGetValue<System.Boolean>("RequirementsMet");}
set { this["RequirementsMet"] = value;}
}

public System.DateTime? PaidThruDate {
get { return SafeGetValue<System.DateTime?>("PaidThruDate");}
set { this["PaidThruDate"] = value;}
}

public System.DateTime? RecertificationDate {
get { return SafeGetValue<System.DateTime?>("RecertificationDate");}
set { this["RecertificationDate"] = value;}
}

public System.DateTime? CertificationDate {
get { return SafeGetValue<System.DateTime?>("CertificationDate");}
set { this["CertificationDate"] = value;}
}

public System.DateTime? ApplicationDate {
get { return SafeGetValue<System.DateTime?>("ApplicationDate");}
set { this["ApplicationDate"] = value;}
}

public System.DateTime? EffectiveDate {
get { return SafeGetValue<System.DateTime?>("EffectiveDate");}
set { this["EffectiveDate"] = value;}
}

public System.DateTime? ExpirationDate {
get { return SafeGetValue<System.DateTime?>("ExpirationDate");}
set { this["ExpirationDate"] = value;}
}

public System.DateTime? CertificateSentDate {
get { return SafeGetValue<System.DateTime?>("CertificateSentDate");}
set { this["CertificateSentDate"] = value;}
}

public System.DateTime? EnrollmentDate {
get { return SafeGetValue<System.DateTime?>("EnrollmentDate");}
set { this["EnrollmentDate"] = value;}
}

public System.DateTime? TerminationDate {
get { return SafeGetValue<System.DateTime?>("TerminationDate");}
set { this["TerminationDate"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Int32? CEUGracePeriod {
get { return SafeGetValue<System.Int32?>("CEUGracePeriod");}
set { this["CEUGracePeriod"] = value;}
}

}
[Serializable]
public class msCertificationComponent : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "CertificationComponent";
public new  static class FIELDS {
public const string Code = "Code";
public const string Type = "Type";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string Description = "Description";
public const string AllowPartialParticipation = "AllowPartialParticipation";
public const string CEUCredits = "CEUCredits";
public const string Address = "Address";
public const string NRDSEnabled = "NRDSEnabled";
}
public msCertificationComponent() : base() {
ClassType = "CertificationComponent";
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msCertificationComponent( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertificationComponent FromClassMetadata(ClassMetadata meta){return new msCertificationComponent(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? EndDate {
get { return SafeGetValue<System.DateTime?>("EndDate");}
set { this["EndDate"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Boolean AllowPartialParticipation {
get { return SafeGetValue<System.Boolean>("AllowPartialParticipation");}
set { this["AllowPartialParticipation"] = value;}
}

public System.Collections.Generic.List<msLinkedCEUCredit> CEUCredits {
get { return SafeGetValue<System.Collections.Generic.List<msLinkedCEUCredit>>("CEUCredits");}
set { this["CEUCredits"] = value;}
}

public MemberSuite.SDK.Types.Address Address {
get { return SafeGetValue<MemberSuite.SDK.Types.Address>("Address");}
set { this["Address"] = value;}
}

public System.Boolean NRDSEnabled {
get { return SafeGetValue<System.Boolean>("NRDSEnabled");}
set { this["NRDSEnabled"] = value;}
}

}
[Serializable]
public class msCertificationComponentRegistration : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "CertificationComponentRegistration";
public new  static class FIELDS {
public const string Student = "Student";
public const string Component = "Component";
public const string Event = "Event";
public const string ParticipationPercentage = "ParticipationPercentage";
public const string DigitalSignature = "DigitalSignature";
public const string Notes = "Notes";
public const string Verified = "Verified";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
}
public msCertificationComponentRegistration() : base() {
ClassType = "CertificationComponentRegistration";
}
public msCertificationComponentRegistration( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertificationComponentRegistration FromClassMetadata(ClassMetadata meta){return new msCertificationComponentRegistration(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Student {
get { return SafeGetValue<System.String>("Student");}
set { this["Student"] = value;}
}

public System.String Component {
get { return SafeGetValue<System.String>("Component");}
set { this["Component"] = value;}
}

public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.Int32 ParticipationPercentage {
get { return SafeGetValue<System.Int32>("ParticipationPercentage");}
set { this["ParticipationPercentage"] = value;}
}

public System.String DigitalSignature {
get { return SafeGetValue<System.String>("DigitalSignature");}
set { this["DigitalSignature"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Boolean Verified {
get { return SafeGetValue<System.Boolean>("Verified");}
set { this["Verified"] = value;}
}

public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? EndDate {
get { return SafeGetValue<System.DateTime?>("EndDate");}
set { this["EndDate"] = value;}
}

}
[Serializable]
public class msCertificationComponentType : msConfigurableType {
public new const string CLASS_NAME = "CertificationComponentType";
public new  static class FIELDS {
}
public msCertificationComponentType() : base() {
ClassType = "CertificationComponentType";
}
public msCertificationComponentType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertificationComponentType FromClassMetadata(ClassMetadata meta){return new msCertificationComponentType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msCertificationExam : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "CertificationExam";
public new  static class FIELDS {
public const string Type = "Type";
public const string Certification = "Certification";
public const string Student = "Student";
public const string Score = "Score";
public const string Passed = "Passed";
public const string DateTaken = "DateTaken";
public const string ExpirationDate = "ExpirationDate";
public const string Notes = "Notes";
}
public msCertificationExam() : base() {
ClassType = "CertificationExam";
}
public msCertificationExam( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertificationExam FromClassMetadata(ClassMetadata meta){return new msCertificationExam(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Certification {
get { return SafeGetValue<System.String>("Certification");}
set { this["Certification"] = value;}
}

public System.String Student {
get { return SafeGetValue<System.String>("Student");}
set { this["Student"] = value;}
}

public System.Decimal? Score {
get { return SafeGetValue<System.Decimal?>("Score");}
set { this["Score"] = value;}
}

public System.Boolean Passed {
get { return SafeGetValue<System.Boolean>("Passed");}
set { this["Passed"] = value;}
}

public System.DateTime? DateTaken {
get { return SafeGetValue<System.DateTime?>("DateTaken");}
set { this["DateTaken"] = value;}
}

public System.DateTime? ExpirationDate {
get { return SafeGetValue<System.DateTime?>("ExpirationDate");}
set { this["ExpirationDate"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msCertificationExamType : msConfigurableType {
public new const string CLASS_NAME = "CertificationExamType";
public new  static class FIELDS {
}
public msCertificationExamType() : base() {
ClassType = "CertificationExamType";
}
public msCertificationExamType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertificationExamType FromClassMetadata(ClassMetadata meta){return new msCertificationExamType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msCertificationFee : msProduct {
public new const string CLASS_NAME = "CertificationFee";
public new  static class FIELDS {
public const string Program = "Program";
}
public msCertificationFee() : base() {
ClassType = "CertificationFee";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msCertificationFee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertificationFee FromClassMetadata(ClassMetadata meta){return new msCertificationFee(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Program {
get { return SafeGetValue<System.String>("Program");}
set { this["Program"] = value;}
}

}
[Serializable]
public class msCertificationProgram : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "CertificationProgram";
public new  static class FIELDS {
public const string Code = "Code";
public const string Type = "Type";
public const string Description = "Description";
public const string Term = "Term";
public const string Designation = "Designation";
public const string RenewalProgram = "RenewalProgram";
public const string AwardDesignation = "AwardDesignation";
public const string MembersOnly = "MembersOnly";
public const string IncludeInEntitySearch = "IncludeInEntitySearch";
public const string RecommendationRequirements = "RecommendationRequirements";
public const string CEURequirements = "CEURequirements";
public const string ExamRequirements = "ExamRequirements";
public const string TermsOfService = "TermsOfService";
}
public msCertificationProgram() : base() {
ClassType = "CertificationProgram";
RecommendationRequirements = new System.Collections.Generic.List<msRecommendationCertificationRequirement>();
CEURequirements = new System.Collections.Generic.List<msCEUCertificationRequirement>();
ExamRequirements = new System.Collections.Generic.List<msExamCertificationRequirement>();
}
public msCertificationProgram( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertificationProgram FromClassMetadata(ClassMetadata meta){return new msCertificationProgram(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public MemberSuite.SDK.Types.CertificationProgramType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.CertificationProgramType>("Type");}
set { this["Type"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Int32 Term {
get { return SafeGetValue<System.Int32>("Term");}
set { this["Term"] = value;}
}

public System.String Designation {
get { return SafeGetValue<System.String>("Designation");}
set { this["Designation"] = value;}
}

public System.String RenewalProgram {
get { return SafeGetValue<System.String>("RenewalProgram");}
set { this["RenewalProgram"] = value;}
}

public System.Boolean AwardDesignation {
get { return SafeGetValue<System.Boolean>("AwardDesignation");}
set { this["AwardDesignation"] = value;}
}

public System.Boolean MembersOnly {
get { return SafeGetValue<System.Boolean>("MembersOnly");}
set { this["MembersOnly"] = value;}
}

public System.Boolean IncludeInEntitySearch {
get { return SafeGetValue<System.Boolean>("IncludeInEntitySearch");}
set { this["IncludeInEntitySearch"] = value;}
}

public System.Collections.Generic.List<msRecommendationCertificationRequirement> RecommendationRequirements {
get { return SafeGetValue<System.Collections.Generic.List<msRecommendationCertificationRequirement>>("RecommendationRequirements");}
set { this["RecommendationRequirements"] = value;}
}

public System.Collections.Generic.List<msCEUCertificationRequirement> CEURequirements {
get { return SafeGetValue<System.Collections.Generic.List<msCEUCertificationRequirement>>("CEURequirements");}
set { this["CEURequirements"] = value;}
}

public System.Collections.Generic.List<msExamCertificationRequirement> ExamRequirements {
get { return SafeGetValue<System.Collections.Generic.List<msExamCertificationRequirement>>("ExamRequirements");}
set { this["ExamRequirements"] = value;}
}

public System.String TermsOfService {
get { return SafeGetValue<System.String>("TermsOfService");}
set { this["TermsOfService"] = value;}
}

}
[Serializable]
public class msRecommendationCertificationRequirement : msAggregateChild {
public new const string CLASS_NAME = "RecommendationCertificationRequirement";
public new  static class FIELDS {
public const string Type = "Type";
public const string NumberRequired = "NumberRequired";
}
public msRecommendationCertificationRequirement() : base() {
ClassType = "RecommendationCertificationRequirement";
}
public msRecommendationCertificationRequirement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRecommendationCertificationRequirement FromClassMetadata(ClassMetadata meta){return new msRecommendationCertificationRequirement(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.Int32 NumberRequired {
get { return SafeGetValue<System.Int32>("NumberRequired");}
set { this["NumberRequired"] = value;}
}

}
[Serializable]
public class msCEUCertificationRequirement : msAggregateChild {
public new const string CLASS_NAME = "CEUCertificationRequirement";
public new  static class FIELDS {
public const string Type = "Type";
public const string QuantityRequired = "QuantityRequired";
}
public msCEUCertificationRequirement() : base() {
ClassType = "CEUCertificationRequirement";
}
public msCEUCertificationRequirement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCEUCertificationRequirement FromClassMetadata(ClassMetadata meta){return new msCEUCertificationRequirement(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.Decimal QuantityRequired {
get { return SafeGetValue<System.Decimal>("QuantityRequired");}
set { this["QuantityRequired"] = value;}
}

}
[Serializable]
public class msExamCertificationRequirement : msAggregateChild {
public new const string CLASS_NAME = "ExamCertificationRequirement";
public new  static class FIELDS {
public const string Type = "Type";
}
public msExamCertificationRequirement() : base() {
ClassType = "ExamCertificationRequirement";
}
public msExamCertificationRequirement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExamCertificationRequirement FromClassMetadata(ClassMetadata meta){return new msExamCertificationRequirement(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

}
[Serializable]
public class msRecommendation : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Recommendation";
public new  static class FIELDS {
public const string LinkedIndividual = "LinkedIndividual";
public const string FirstName = "FirstName";
public const string LastName = "LastName";
public const string EmailAddress = "EmailAddress";
public const string PhoneNumber = "PhoneNumber";
public const string Notes = "Notes";
public const string Status = "Status";
}
public msRecommendation() : base() {
ClassType = "Recommendation";
}
public msRecommendation( MemberSuiteObject msObj) : base(msObj) {}
public System.String LinkedIndividual {
get { return SafeGetValue<System.String>("LinkedIndividual");}
set { this["LinkedIndividual"] = value;}
}

public System.String FirstName {
get { return SafeGetValue<System.String>("FirstName");}
set { this["FirstName"] = value;}
}

public System.String LastName {
get { return SafeGetValue<System.String>("LastName");}
set { this["LastName"] = value;}
}

public System.String EmailAddress {
get { return SafeGetValue<System.String>("EmailAddress");}
set { this["EmailAddress"] = value;}
}

public System.String PhoneNumber {
get { return SafeGetValue<System.String>("PhoneNumber");}
set { this["PhoneNumber"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public MemberSuite.SDK.Types.RecommendationStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.RecommendationStatus>("Status");}
set { this["Status"] = value;}
}

}
[Serializable]
public class msCertificationRecommendation : msRecommendation {
public new const string CLASS_NAME = "CertificationRecommendation";
public new  static class FIELDS {
public const string Certification = "Certification";
public const string Type = "Type";
}
public msCertificationRecommendation() : base() {
ClassType = "CertificationRecommendation";
}
public msCertificationRecommendation( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertificationRecommendation FromClassMetadata(ClassMetadata meta){return new msCertificationRecommendation(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Certification {
get { return SafeGetValue<System.String>("Certification");}
set { this["Certification"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

}
[Serializable]
public class msCertificationRecommendationType : msConfigurableType {
public new const string CLASS_NAME = "CertificationRecommendationType";
public new  static class FIELDS {
}
public msCertificationRecommendationType() : base() {
ClassType = "CertificationRecommendationType";
}
public msCertificationRecommendationType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertificationRecommendationType FromClassMetadata(ClassMetadata meta){return new msCertificationRecommendationType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msCertificationStatus : msConfigurableType {
public new const string CLASS_NAME = "CertificationStatus";
public new  static class FIELDS {
}
public msCertificationStatus() : base() {
ClassType = "CertificationStatus";
}
public msCertificationStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertificationStatus FromClassMetadata(ClassMetadata meta){return new msCertificationStatus(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msCertificationStatusReason : msConfigurableType {
public new const string CLASS_NAME = "CertificationStatusReason";
public new  static class FIELDS {
}
public msCertificationStatusReason() : base() {
ClassType = "CertificationStatusReason";
}
public msCertificationStatusReason( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertificationStatusReason FromClassMetadata(ClassMetadata meta){return new msCertificationStatusReason(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msCertificationTermsOfServiceAgreement : msTermsOfServiceAgreement {
public new const string CLASS_NAME = "CertificationTermsOfServiceAgreement";
public new  static class FIELDS {
public const string Certification = "Certification";
}
public msCertificationTermsOfServiceAgreement() : base() {
ClassType = "CertificationTermsOfServiceAgreement";
}
public msCertificationTermsOfServiceAgreement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertificationTermsOfServiceAgreement FromClassMetadata(ClassMetadata meta){return new msCertificationTermsOfServiceAgreement(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Certification {
get { return SafeGetValue<System.String>("Certification");}
set { this["Certification"] = value;}
}

}
[Serializable]
public class msCEUCredit : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "CEUCredit";
public new  static class FIELDS {
public const string Type = "Type";
public const string Owner = "Owner";
public const string CreditDate = "CreditDate";
public const string Event = "Event";
public const string Order = "Order";
public const string Registration = "Registration";
public const string ComponentRegistration = "ComponentRegistration";
public const string Product = "Product";
public const string OrderLineItemID = "OrderLineItemID";
public const string Quantity = "Quantity";
public const string Notes = "Notes";
public const string SelfReported = "SelfReported";
public const string Verified = "Verified";
public const string State = "State";
public const string Region = "Region";
public const string Country = "Country";
public const string ExpirationDate = "ExpirationDate";
}
public msCEUCredit() : base() {
ClassType = "CEUCredit";
}
public msCEUCredit( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCEUCredit FromClassMetadata(ClassMetadata meta){return new msCEUCredit(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.DateTime CreditDate {
get { return SafeGetValue<System.DateTime>("CreditDate");}
set { this["CreditDate"] = value;}
}

public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String Registration {
get { return SafeGetValue<System.String>("Registration");}
set { this["Registration"] = value;}
}

public System.String ComponentRegistration {
get { return SafeGetValue<System.String>("ComponentRegistration");}
set { this["ComponentRegistration"] = value;}
}

public System.String Product {
get { return SafeGetValue<System.String>("Product");}
set { this["Product"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.Decimal Quantity {
get { return SafeGetValue<System.Decimal>("Quantity");}
set { this["Quantity"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Boolean SelfReported {
get { return SafeGetValue<System.Boolean>("SelfReported");}
set { this["SelfReported"] = value;}
}

public System.Boolean Verified {
get { return SafeGetValue<System.Boolean>("Verified");}
set { this["Verified"] = value;}
}

public System.String State {
get { return SafeGetValue<System.String>("State");}
set { this["State"] = value;}
}

public System.String Region {
get { return SafeGetValue<System.String>("Region");}
set { this["Region"] = value;}
}

public System.String Country {
get { return SafeGetValue<System.String>("Country");}
set { this["Country"] = value;}
}

public System.DateTime? ExpirationDate {
get { return SafeGetValue<System.DateTime?>("ExpirationDate");}
set { this["ExpirationDate"] = value;}
}

}
[Serializable]
public class msCEUType : msConfigurableType {
public new const string CLASS_NAME = "CEUType";
public new  static class FIELDS {
}
public msCEUType() : base() {
ClassType = "CEUType";
}
public msCEUType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCEUType FromClassMetadata(ClassMetadata meta){return new msCEUType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msActivityStatus : msConfigurableType {
public new const string CLASS_NAME = "ActivityStatus";
public new  static class FIELDS {
public const string IsClosed = "IsClosed";
}
public msActivityStatus() : base() {
ClassType = "ActivityStatus";
}
public msActivityStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msActivityStatus FromClassMetadata(ClassMetadata meta){return new msActivityStatus(MemberSuiteObject.FromClassMetadata(meta));}
public System.Boolean IsClosed {
get { return SafeGetValue<System.Boolean>("IsClosed");}
set { this["IsClosed"] = value;}
}

}
[Serializable]
public class msCustomEntitlement : msEntitlement {
public new const string CLASS_NAME = "CustomEntitlement";
public new  static class FIELDS {
public const string CustomType = "CustomType";
}
public msCustomEntitlement() : base() {
ClassType = "CustomEntitlement";
}
public msCustomEntitlement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomEntitlement FromClassMetadata(ClassMetadata meta){return new msCustomEntitlement(MemberSuiteObject.FromClassMetadata(meta));}
public System.String CustomType {
get { return SafeGetValue<System.String>("CustomType");}
set { this["CustomType"] = value;}
}

}
[Serializable]
public class msCustomEntitlementType : msConfigurableType {
public new const string CLASS_NAME = "CustomEntitlementType";
public new  static class FIELDS {
}
public msCustomEntitlementType() : base() {
ClassType = "CustomEntitlementType";
}
public msCustomEntitlementType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomEntitlementType FromClassMetadata(ClassMetadata meta){return new msCustomEntitlementType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msMediaCode : msConfigurableType {
public new const string CLASS_NAME = "MediaCode";
public new  static class FIELDS {
}
public msMediaCode() : base() {
ClassType = "MediaCode";
}
public msMediaCode( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMediaCode FromClassMetadata(ClassMetadata meta){return new msMediaCode(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msOrganizationContactRestriction : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "OrganizationContactRestriction";
public new  static class FIELDS {
public const string EvaluationOrder = "EvaluationOrder";
public const string RelationshipType = "RelationshipType";
public const string OrganizationType = "OrganizationType";
public const string MembershipType = "MembershipType";
public const string OrganizationKeywords = "OrganizationKeywords";
public const string MaximumNumberOfContacts = "MaximumNumberOfContacts";
public const string ErrorMessage = "ErrorMessage";
public const string Notes = "Notes";
}
public msOrganizationContactRestriction() : base() {
ClassType = "OrganizationContactRestriction";
}
public msOrganizationContactRestriction( MemberSuiteObject msObj) : base(msObj) {}
 public static new msOrganizationContactRestriction FromClassMetadata(ClassMetadata meta){return new msOrganizationContactRestriction(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int32 EvaluationOrder {
get { return SafeGetValue<System.Int32>("EvaluationOrder");}
set { this["EvaluationOrder"] = value;}
}

public System.String RelationshipType {
get { return SafeGetValue<System.String>("RelationshipType");}
set { this["RelationshipType"] = value;}
}

public System.String OrganizationType {
get { return SafeGetValue<System.String>("OrganizationType");}
set { this["OrganizationType"] = value;}
}

public System.String MembershipType {
get { return SafeGetValue<System.String>("MembershipType");}
set { this["MembershipType"] = value;}
}

public System.String OrganizationKeywords {
get { return SafeGetValue<System.String>("OrganizationKeywords");}
set { this["OrganizationKeywords"] = value;}
}

public System.Int32 MaximumNumberOfContacts {
get { return SafeGetValue<System.Int32>("MaximumNumberOfContacts");}
set { this["MaximumNumberOfContacts"] = value;}
}

public System.String ErrorMessage {
get { return SafeGetValue<System.String>("ErrorMessage");}
set { this["ErrorMessage"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msPortalTermsOfServiceAgreement : msTermsOfServiceAgreement {
public new const string CLASS_NAME = "PortalTermsOfServiceAgreement";
public new  static class FIELDS {
}
public msPortalTermsOfServiceAgreement() : base() {
ClassType = "PortalTermsOfServiceAgreement";
}
public msPortalTermsOfServiceAgreement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPortalTermsOfServiceAgreement FromClassMetadata(ClassMetadata meta){return new msPortalTermsOfServiceAgreement(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msRequest : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Request";
public new  static class FIELDS {
public const string Customer = "Customer";
public const string Description = "Description";
public const string AdministrativeNotes = "AdministrativeNotes";
public const string AssignedTo = "AssignedTo";
public const string Status = "Status";
public const string Priority = "Priority";
}
public msRequest() : base() {
ClassType = "Request";
}
public msRequest( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRequest FromClassMetadata(ClassMetadata meta){return new msRequest(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Customer {
get { return SafeGetValue<System.String>("Customer");}
set { this["Customer"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String AdministrativeNotes {
get { return SafeGetValue<System.String>("AdministrativeNotes");}
set { this["AdministrativeNotes"] = value;}
}

public System.String AssignedTo {
get { return SafeGetValue<System.String>("AssignedTo");}
set { this["AssignedTo"] = value;}
}

public System.String Status {
get { return SafeGetValue<System.String>("Status");}
set { this["Status"] = value;}
}

public System.String Priority {
get { return SafeGetValue<System.String>("Priority");}
set { this["Priority"] = value;}
}

}
[Serializable]
public class msRequestPriority : msConfigurableType {
public new const string CLASS_NAME = "RequestPriority";
public new  static class FIELDS {
}
public msRequestPriority() : base() {
ClassType = "RequestPriority";
}
public msRequestPriority( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRequestPriority FromClassMetadata(ClassMetadata meta){return new msRequestPriority(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msRequestStatus : msConfigurableType {
public new const string CLASS_NAME = "RequestStatus";
public new  static class FIELDS {
public const string IndicatesClosedRequest = "IndicatesClosedRequest";
}
public msRequestStatus() : base() {
ClassType = "RequestStatus";
}
public msRequestStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRequestStatus FromClassMetadata(ClassMetadata meta){return new msRequestStatus(MemberSuiteObject.FromClassMetadata(meta));}
public System.Boolean IndicatesClosedRequest {
get { return SafeGetValue<System.Boolean>("IndicatesClosedRequest");}
set { this["IndicatesClosedRequest"] = value;}
}

}
[Serializable]
public class msSearchEntitlement : msEntitlement {
public new const string CLASS_NAME = "SearchEntitlement";
public new  static class FIELDS {
public const string Search = "Search";
}
public msSearchEntitlement() : base() {
ClassType = "SearchEntitlement";
}
public msSearchEntitlement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSearchEntitlement FromClassMetadata(ClassMetadata meta){return new msSearchEntitlement(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Search {
get { return SafeGetValue<System.String>("Search");}
set { this["Search"] = value;}
}

}
[Serializable]
public class msSourceCode : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "SourceCode";
public new  static class FIELDS {
public const string Type = "Type";
public const string Code = "Code";
public const string AvailableFrom = "AvailableFrom";
public const string AvailableThru = "AvailableThru";
}
public msSourceCode() : base() {
ClassType = "SourceCode";
}
public msSourceCode( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSourceCode FromClassMetadata(ClassMetadata meta){return new msSourceCode(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.SourceCodeType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.SourceCodeType>("Type");}
set { this["Type"] = value;}
}

public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.DateTime? AvailableFrom {
get { return SafeGetValue<System.DateTime?>("AvailableFrom");}
set { this["AvailableFrom"] = value;}
}

public System.DateTime? AvailableThru {
get { return SafeGetValue<System.DateTime?>("AvailableThru");}
set { this["AvailableThru"] = value;}
}

}
[Serializable]
public class msTermsOfService : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "TermsOfService";
public new  static class FIELDS {
public const string Description = "Description";
}
public msTermsOfService() : base() {
ClassType = "TermsOfService";
}
public msTermsOfService( MemberSuiteObject msObj) : base(msObj) {}
 public static new msTermsOfService FromClassMetadata(ClassMetadata meta){return new msTermsOfService(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msTermsOfServiceVersion : msAssociationDomainObject {
public new const string CLASS_NAME = "TermsOfServiceVersion";
public new  static class FIELDS {
public const string TermsOfService = "TermsOfService";
public const string VersionNumber = "VersionNumber";
public const string Date = "Date";
public const string ContractText = "ContractText";
}
public msTermsOfServiceVersion() : base() {
ClassType = "TermsOfServiceVersion";
}
public msTermsOfServiceVersion( MemberSuiteObject msObj) : base(msObj) {}
 public static new msTermsOfServiceVersion FromClassMetadata(ClassMetadata meta){return new msTermsOfServiceVersion(MemberSuiteObject.FromClassMetadata(meta));}
public System.String TermsOfService {
get { return SafeGetValue<System.String>("TermsOfService");}
set { this["TermsOfService"] = value;}
}

public System.Int32 VersionNumber {
get { return SafeGetValue<System.Int32>("VersionNumber");}
set { this["VersionNumber"] = value;}
}

public System.DateTime Date {
get { return SafeGetValue<System.DateTime>("Date");}
set { this["Date"] = value;}
}

public System.String ContractText {
get { return SafeGetValue<System.String>("ContractText");}
set { this["ContractText"] = value;}
}

}
[Serializable]
public class msDataImport : msAssociationDomainObject {
public new const string CLASS_NAME = "DataImport";
public new  static class FIELDS {
public const string RollbackDate = "RollbackDate";
}
public msDataImport() : base() {
ClassType = "DataImport";
}
public msDataImport( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDataImport FromClassMetadata(ClassMetadata meta){return new msDataImport(MemberSuiteObject.FromClassMetadata(meta));}
public System.DateTime? RollbackDate {
get { return SafeGetValue<System.DateTime?>("RollbackDate");}
set { this["RollbackDate"] = value;}
}

}
[Serializable]
public class msDiscussionBoard : msAssociationDomainObject {
public new const string CLASS_NAME = "DiscussionBoard";
public new  static class FIELDS {
}
public msDiscussionBoard() : base() {
ClassType = "DiscussionBoard";
}
public msDiscussionBoard( MemberSuiteObject msObj) : base(msObj) {}
}
[Serializable]
public class msAssociationDiscussionBoard : msDiscussionBoard {
public new const string CLASS_NAME = "AssociationDiscussionBoard";
public new  static class FIELDS {
}
public msAssociationDiscussionBoard() : base() {
ClassType = "AssociationDiscussionBoard";
}
public msAssociationDiscussionBoard( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAssociationDiscussionBoard FromClassMetadata(ClassMetadata meta){return new msAssociationDiscussionBoard(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msChapterDiscussionBoard : msDiscussionBoard {
public new const string CLASS_NAME = "ChapterDiscussionBoard";
public new  static class FIELDS {
public const string Chapter = "Chapter";
}
public msChapterDiscussionBoard() : base() {
ClassType = "ChapterDiscussionBoard";
}
public msChapterDiscussionBoard( MemberSuiteObject msObj) : base(msObj) {}
 public static new msChapterDiscussionBoard FromClassMetadata(ClassMetadata meta){return new msChapterDiscussionBoard(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Chapter {
get { return SafeGetValue<System.String>("Chapter");}
set { this["Chapter"] = value;}
}

}
[Serializable]
public class msSectionDiscussionBoard : msDiscussionBoard {
public new const string CLASS_NAME = "SectionDiscussionBoard";
public new  static class FIELDS {
public const string Section = "Section";
}
public msSectionDiscussionBoard() : base() {
ClassType = "SectionDiscussionBoard";
}
public msSectionDiscussionBoard( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSectionDiscussionBoard FromClassMetadata(ClassMetadata meta){return new msSectionDiscussionBoard(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Section {
get { return SafeGetValue<System.String>("Section");}
set { this["Section"] = value;}
}

}
[Serializable]
public class msCommitteeDiscussionBoard : msDiscussionBoard {
public new const string CLASS_NAME = "CommitteeDiscussionBoard";
public new  static class FIELDS {
public const string Committee = "Committee";
}
public msCommitteeDiscussionBoard() : base() {
ClassType = "CommitteeDiscussionBoard";
}
public msCommitteeDiscussionBoard( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCommitteeDiscussionBoard FromClassMetadata(ClassMetadata meta){return new msCommitteeDiscussionBoard(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Committee {
get { return SafeGetValue<System.String>("Committee");}
set { this["Committee"] = value;}
}

}
[Serializable]
public class msOrganizationalLayerDiscussionBoard : msDiscussionBoard {
public new const string CLASS_NAME = "OrganizationalLayerDiscussionBoard";
public new  static class FIELDS {
public const string OrganizationalLayer = "OrganizationalLayer";
}
public msOrganizationalLayerDiscussionBoard() : base() {
ClassType = "OrganizationalLayerDiscussionBoard";
}
public msOrganizationalLayerDiscussionBoard( MemberSuiteObject msObj) : base(msObj) {}
 public static new msOrganizationalLayerDiscussionBoard FromClassMetadata(ClassMetadata meta){return new msOrganizationalLayerDiscussionBoard(MemberSuiteObject.FromClassMetadata(meta));}
public System.String OrganizationalLayer {
get { return SafeGetValue<System.String>("OrganizationalLayer");}
set { this["OrganizationalLayer"] = value;}
}

}
[Serializable]
public class msEventDiscussionBoard : msDiscussionBoard {
public new const string CLASS_NAME = "EventDiscussionBoard";
public new  static class FIELDS {
public const string Event = "Event";
}
public msEventDiscussionBoard() : base() {
ClassType = "EventDiscussionBoard";
}
public msEventDiscussionBoard( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventDiscussionBoard FromClassMetadata(ClassMetadata meta){return new msEventDiscussionBoard(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

}
[Serializable]
public class msDiscussionPost : msAssociationDomainObject {
public new const string CLASS_NAME = "DiscussionPost";
public new  static class FIELDS {
public const string Topic = "Topic";
public const string Post = "Post";
public const string Status = "Status";
public const string PostedBy = "PostedBy";
}
public msDiscussionPost() : base() {
ClassType = "DiscussionPost";
}
public msDiscussionPost( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDiscussionPost FromClassMetadata(ClassMetadata meta){return new msDiscussionPost(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Topic {
get { return SafeGetValue<System.String>("Topic");}
set { this["Topic"] = value;}
}

public System.String Post {
get { return SafeGetValue<System.String>("Post");}
set { this["Post"] = value;}
}

public MemberSuite.SDK.Types.DiscussionPostStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.DiscussionPostStatus>("Status");}
set { this["Status"] = value;}
}

public System.String PostedBy {
get { return SafeGetValue<System.String>("PostedBy");}
set { this["PostedBy"] = value;}
}

}
[Serializable]
public class msDiscussionTopic : msAssociationDomainObject {
public new const string CLASS_NAME = "DiscussionTopic";
public new  static class FIELDS {
public const string Forum = "Forum";
public const string PostedBy = "PostedBy";
}
public msDiscussionTopic() : base() {
ClassType = "DiscussionTopic";
}
public msDiscussionTopic( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDiscussionTopic FromClassMetadata(ClassMetadata meta){return new msDiscussionTopic(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Forum {
get { return SafeGetValue<System.String>("Forum");}
set { this["Forum"] = value;}
}

public System.String PostedBy {
get { return SafeGetValue<System.String>("PostedBy");}
set { this["PostedBy"] = value;}
}

}
[Serializable]
public class msDiscussionTopicSubscription : msAssociationDomainObject {
public new const string CLASS_NAME = "DiscussionTopicSubscription";
public new  static class FIELDS {
public const string Topic = "Topic";
public const string Subscriber = "Subscriber";
}
public msDiscussionTopicSubscription() : base() {
ClassType = "DiscussionTopicSubscription";
}
public msDiscussionTopicSubscription( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDiscussionTopicSubscription FromClassMetadata(ClassMetadata meta){return new msDiscussionTopicSubscription(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Topic {
get { return SafeGetValue<System.String>("Topic");}
set { this["Topic"] = value;}
}

public System.String Subscriber {
get { return SafeGetValue<System.String>("Subscriber");}
set { this["Subscriber"] = value;}
}

}
[Serializable]
public class msForum : msAssociationDomainObject {
public new const string CLASS_NAME = "Forum";
public new  static class FIELDS {
public const string DisplayOrder = "DisplayOrder";
public const string DiscussionBoard = "DiscussionBoard";
public const string Description = "Description";
public const string GroupName = "GroupName";
public const string MembersOnly = "MembersOnly";
public const string Moderated = "Moderated";
public const string IsActive = "IsActive";
}
public msForum() : base() {
ClassType = "Forum";
}
public msForum( MemberSuiteObject msObj) : base(msObj) {}
 public static new msForum FromClassMetadata(ClassMetadata meta){return new msForum(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int32? DisplayOrder {
get { return SafeGetValue<System.Int32?>("DisplayOrder");}
set { this["DisplayOrder"] = value;}
}

public System.String DiscussionBoard {
get { return SafeGetValue<System.String>("DiscussionBoard");}
set { this["DiscussionBoard"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String GroupName {
get { return SafeGetValue<System.String>("GroupName");}
set { this["GroupName"] = value;}
}

public System.Boolean MembersOnly {
get { return SafeGetValue<System.Boolean>("MembersOnly");}
set { this["MembersOnly"] = value;}
}

public System.Boolean Moderated {
get { return SafeGetValue<System.Boolean>("Moderated");}
set { this["Moderated"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

}
[Serializable]
public class msFileCabinet : msAssociationDomainObject {
public new const string CLASS_NAME = "FileCabinet";
public new  static class FIELDS {
}
public msFileCabinet() : base() {
ClassType = "FileCabinet";
}
public msFileCabinet( MemberSuiteObject msObj) : base(msObj) {}
}
[Serializable]
public class msAssociationFileCabinet : msFileCabinet {
public new const string CLASS_NAME = "AssociationFileCabinet";
public new  static class FIELDS {
}
public msAssociationFileCabinet() : base() {
ClassType = "AssociationFileCabinet";
}
public msAssociationFileCabinet( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAssociationFileCabinet FromClassMetadata(ClassMetadata meta){return new msAssociationFileCabinet(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msChapterFileCabinet : msFileCabinet {
public new const string CLASS_NAME = "ChapterFileCabinet";
public new  static class FIELDS {
public const string Chapter = "Chapter";
}
public msChapterFileCabinet() : base() {
ClassType = "ChapterFileCabinet";
}
public msChapterFileCabinet( MemberSuiteObject msObj) : base(msObj) {}
 public static new msChapterFileCabinet FromClassMetadata(ClassMetadata meta){return new msChapterFileCabinet(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Chapter {
get { return SafeGetValue<System.String>("Chapter");}
set { this["Chapter"] = value;}
}

}
[Serializable]
public class msSectionFileCabinet : msFileCabinet {
public new const string CLASS_NAME = "SectionFileCabinet";
public new  static class FIELDS {
public const string Section = "Section";
}
public msSectionFileCabinet() : base() {
ClassType = "SectionFileCabinet";
}
public msSectionFileCabinet( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSectionFileCabinet FromClassMetadata(ClassMetadata meta){return new msSectionFileCabinet(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Section {
get { return SafeGetValue<System.String>("Section");}
set { this["Section"] = value;}
}

}
[Serializable]
public class msCommitteeFileCabinet : msFileCabinet {
public new const string CLASS_NAME = "CommitteeFileCabinet";
public new  static class FIELDS {
public const string Committee = "Committee";
}
public msCommitteeFileCabinet() : base() {
ClassType = "CommitteeFileCabinet";
}
public msCommitteeFileCabinet( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCommitteeFileCabinet FromClassMetadata(ClassMetadata meta){return new msCommitteeFileCabinet(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Committee {
get { return SafeGetValue<System.String>("Committee");}
set { this["Committee"] = value;}
}

}
[Serializable]
public class msOrganizationalLayerFileCabinet : msFileCabinet {
public new const string CLASS_NAME = "OrganizationalLayerFileCabinet";
public new  static class FIELDS {
public const string OrganizationalLayer = "OrganizationalLayer";
}
public msOrganizationalLayerFileCabinet() : base() {
ClassType = "OrganizationalLayerFileCabinet";
}
public msOrganizationalLayerFileCabinet( MemberSuiteObject msObj) : base(msObj) {}
 public static new msOrganizationalLayerFileCabinet FromClassMetadata(ClassMetadata meta){return new msOrganizationalLayerFileCabinet(MemberSuiteObject.FromClassMetadata(meta));}
public System.String OrganizationalLayer {
get { return SafeGetValue<System.String>("OrganizationalLayer");}
set { this["OrganizationalLayer"] = value;}
}

}
[Serializable]
public class msFileFolder : msAssociationDomainObject {
public new const string CLASS_NAME = "FileFolder";
public new  static class FIELDS {
public const string Type = "Type";
public const string FileCabinet = "FileCabinet";
public const string ParentFolder = "ParentFolder";
public const string IsRootFolder = "IsRootFolder";
public const string OnlyLeadersCanUploadFiles = "OnlyLeadersCanUploadFiles";
public const string Description = "Description";
}
public msFileFolder() : base() {
ClassType = "FileFolder";
}
public msFileFolder( MemberSuiteObject msObj) : base(msObj) {}
 public static new msFileFolder FromClassMetadata(ClassMetadata meta){return new msFileFolder(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.FileFolderType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.FileFolderType>("Type");}
set { this["Type"] = value;}
}

public System.String FileCabinet {
get { return SafeGetValue<System.String>("FileCabinet");}
set { this["FileCabinet"] = value;}
}

public System.String ParentFolder {
get { return SafeGetValue<System.String>("ParentFolder");}
set { this["ParentFolder"] = value;}
}

public System.Boolean IsRootFolder {
get { return SafeGetValue<System.Boolean>("IsRootFolder");}
set { this["IsRootFolder"] = value;}
}

public System.Boolean OnlyLeadersCanUploadFiles {
get { return SafeGetValue<System.Boolean>("OnlyLeadersCanUploadFiles");}
set { this["OnlyLeadersCanUploadFiles"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msFileFolderEntitlement : msEntitlement {
public new const string CLASS_NAME = "FileFolderEntitlement";
public new  static class FIELDS {
public const string FileFolder = "FileFolder";
public const string FileCabinet = "FileCabinet";
}
public msFileFolderEntitlement() : base() {
ClassType = "FileFolderEntitlement";
}
public msFileFolderEntitlement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msFileFolderEntitlement FromClassMetadata(ClassMetadata meta){return new msFileFolderEntitlement(MemberSuiteObject.FromClassMetadata(meta));}
public System.String FileFolder {
get { return SafeGetValue<System.String>("FileFolder");}
set { this["FileFolder"] = value;}
}

public System.String FileCabinet {
get { return SafeGetValue<System.String>("FileCabinet");}
set { this["FileCabinet"] = value;}
}

}
[Serializable]
public class msMessageCategory : msConfigurableType {
public new const string CLASS_NAME = "MessageCategory";
public new  static class FIELDS {
}
public msMessageCategory() : base() {
ClassType = "MessageCategory";
}
public msMessageCategory( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMessageCategory FromClassMetadata(ClassMetadata meta){return new msMessageCategory(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msRecurringEmailBlast : msAutomatedRecurringProcess {
public new const string CLASS_NAME = "RecurringEmailBlast";
public new  static class FIELDS {
public const string EmailBlast = "EmailBlast";
}
public msRecurringEmailBlast() : base() {
ClassType = "RecurringEmailBlast";
}
public msRecurringEmailBlast( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRecurringEmailBlast FromClassMetadata(ClassMetadata meta){return new msRecurringEmailBlast(MemberSuiteObject.FromClassMetadata(meta));}
public System.String EmailBlast {
get { return SafeGetValue<System.String>("EmailBlast");}
set { this["EmailBlast"] = value;}
}

}
[Serializable]
public class msEngagementLevel : msConfigurableType {
public new const string CLASS_NAME = "EngagementLevel";
public new  static class FIELDS {
public const string ScoreThreshold = "ScoreThreshold";
}
public msEngagementLevel() : base() {
ClassType = "EngagementLevel";
}
public msEngagementLevel( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEngagementLevel FromClassMetadata(ClassMetadata meta){return new msEngagementLevel(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int16 ScoreThreshold {
get { return SafeGetValue<System.Int16>("ScoreThreshold");}
set { this["ScoreThreshold"] = value;}
}

}
[Serializable]
public class msEngagementSettings : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "EngagementSettings";
public new  static class FIELDS {
public const string MembershipMultiplier = "MembershipMultiplier";
public const string CommitteeServiceMultiplier = "CommitteeServiceMultiplier";
public const string EventRegistrationMultiplier = "EventRegistrationMultiplier";
public const string EventSpeakerMultiplier = "EventSpeakerMultiplier";
public const string NumberOfAbstractSubmissionsMultiplier = "NumberOfAbstractSubmissionsMultiplier";
public const string NumberOfAbstractReviewsMultiplier = "NumberOfAbstractReviewsMultiplier";
public const string NumberOfAwardsMultiplier = "NumberOfAwardsMultiplier";
public const string NumberOfCompetitionJudgesMultiplier = "NumberOfCompetitionJudgesMultiplier";
public const string NumberOfCertificationComponentsMultiplier = "NumberOfCertificationComponentsMultiplier";
public const string NumberOfCertificationsMultiplier = "NumberOfCertificationsMultiplier";
public const string NumberOfGiftsMultiplier = "NumberOfGiftsMultiplier";
public const string ExhibitorParticipationMultiplier = "ExhibitorParticipationMultiplier";
public const string NumberOfMerchandisePurchasesMultiplier = "NumberOfMerchandisePurchasesMultiplier";
public const string DailyPortalLoginsMultiplier = "DailyPortalLoginsMultiplier";
public const string PortalInformationUpdateMultiplier = "PortalInformationUpdateMultiplier";
}
public msEngagementSettings() : base() {
ClassType = "EngagementSettings";
}
public msEngagementSettings( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEngagementSettings FromClassMetadata(ClassMetadata meta){return new msEngagementSettings(MemberSuiteObject.FromClassMetadata(meta));}
public System.Decimal MembershipMultiplier {
get { return SafeGetValue<System.Decimal>("MembershipMultiplier");}
set { this["MembershipMultiplier"] = value;}
}

public System.Decimal CommitteeServiceMultiplier {
get { return SafeGetValue<System.Decimal>("CommitteeServiceMultiplier");}
set { this["CommitteeServiceMultiplier"] = value;}
}

public System.Decimal EventRegistrationMultiplier {
get { return SafeGetValue<System.Decimal>("EventRegistrationMultiplier");}
set { this["EventRegistrationMultiplier"] = value;}
}

public System.Decimal EventSpeakerMultiplier {
get { return SafeGetValue<System.Decimal>("EventSpeakerMultiplier");}
set { this["EventSpeakerMultiplier"] = value;}
}

public System.Decimal NumberOfAbstractSubmissionsMultiplier {
get { return SafeGetValue<System.Decimal>("NumberOfAbstractSubmissionsMultiplier");}
set { this["NumberOfAbstractSubmissionsMultiplier"] = value;}
}

public System.Decimal NumberOfAbstractReviewsMultiplier {
get { return SafeGetValue<System.Decimal>("NumberOfAbstractReviewsMultiplier");}
set { this["NumberOfAbstractReviewsMultiplier"] = value;}
}

public System.Decimal NumberOfAwardsMultiplier {
get { return SafeGetValue<System.Decimal>("NumberOfAwardsMultiplier");}
set { this["NumberOfAwardsMultiplier"] = value;}
}

public System.Decimal NumberOfCompetitionJudgesMultiplier {
get { return SafeGetValue<System.Decimal>("NumberOfCompetitionJudgesMultiplier");}
set { this["NumberOfCompetitionJudgesMultiplier"] = value;}
}

public System.Decimal NumberOfCertificationComponentsMultiplier {
get { return SafeGetValue<System.Decimal>("NumberOfCertificationComponentsMultiplier");}
set { this["NumberOfCertificationComponentsMultiplier"] = value;}
}

public System.Decimal NumberOfCertificationsMultiplier {
get { return SafeGetValue<System.Decimal>("NumberOfCertificationsMultiplier");}
set { this["NumberOfCertificationsMultiplier"] = value;}
}

public System.Decimal NumberOfGiftsMultiplier {
get { return SafeGetValue<System.Decimal>("NumberOfGiftsMultiplier");}
set { this["NumberOfGiftsMultiplier"] = value;}
}

public System.Decimal ExhibitorParticipationMultiplier {
get { return SafeGetValue<System.Decimal>("ExhibitorParticipationMultiplier");}
set { this["ExhibitorParticipationMultiplier"] = value;}
}

public System.Decimal NumberOfMerchandisePurchasesMultiplier {
get { return SafeGetValue<System.Decimal>("NumberOfMerchandisePurchasesMultiplier");}
set { this["NumberOfMerchandisePurchasesMultiplier"] = value;}
}

public System.Decimal DailyPortalLoginsMultiplier {
get { return SafeGetValue<System.Decimal>("DailyPortalLoginsMultiplier");}
set { this["DailyPortalLoginsMultiplier"] = value;}
}

public System.Decimal PortalInformationUpdateMultiplier {
get { return SafeGetValue<System.Decimal>("PortalInformationUpdateMultiplier");}
set { this["PortalInformationUpdateMultiplier"] = value;}
}

}
[Serializable]
public class msEventLocationRoom : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "EventLocationRoom";
public new  static class FIELDS {
public const string Event = "Event";
public const string Number = "Number";
public const string Code = "Code";
public const string Resources = "Resources";
public const string SetupInformation = "SetupInformation";
public const string Capacity = "Capacity";
public const string Notes = "Notes";
}
public msEventLocationRoom() : base() {
ClassType = "EventLocationRoom";
Resources = new System.Collections.Generic.List<msEventLocationRoomResource>();
}
public msEventLocationRoom( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventLocationRoom FromClassMetadata(ClassMetadata meta){return new msEventLocationRoom(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.Int32 Number {
get { return SafeGetValue<System.Int32>("Number");}
set { this["Number"] = value;}
}

public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.Collections.Generic.List<msEventLocationRoomResource> Resources {
get { return SafeGetValue<System.Collections.Generic.List<msEventLocationRoomResource>>("Resources");}
set { this["Resources"] = value;}
}

public System.String SetupInformation {
get { return SafeGetValue<System.String>("SetupInformation");}
set { this["SetupInformation"] = value;}
}

public System.Int32? Capacity {
get { return SafeGetValue<System.Int32?>("Capacity");}
set { this["Capacity"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msEventLocationRoomResource : msAggregateChild {
public new const string CLASS_NAME = "EventLocationRoomResource";
public new  static class FIELDS {
public const string TimeSlot = "TimeSlot";
public const string Resource = "Resource";
}
public msEventLocationRoomResource() : base() {
ClassType = "EventLocationRoomResource";
}
public msEventLocationRoomResource( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventLocationRoomResource FromClassMetadata(ClassMetadata meta){return new msEventLocationRoomResource(MemberSuiteObject.FromClassMetadata(meta));}
public System.String TimeSlot {
get { return SafeGetValue<System.String>("TimeSlot");}
set { this["TimeSlot"] = value;}
}

public System.String Resource {
get { return SafeGetValue<System.String>("Resource");}
set { this["Resource"] = value;}
}

}
[Serializable]
public class msCourse : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "Course";
public new  static class FIELDS {
public const string Speakers = "Speakers";
public const string Prerequisites = "Prerequisites";
public const string Code = "Code";
public const string IsActive = "IsActive";
public const string Description = "Description";
}
public msCourse() : base() {
ClassType = "Course";
Speakers = new System.Collections.Generic.List<msCourseSpeaker>();
Prerequisites = new System.Collections.Generic.List<msCoursePrerequisite>();
}
public msCourse( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCourse FromClassMetadata(ClassMetadata meta){return new msCourse(MemberSuiteObject.FromClassMetadata(meta));}
public System.Collections.Generic.List<msCourseSpeaker> Speakers {
get { return SafeGetValue<System.Collections.Generic.List<msCourseSpeaker>>("Speakers");}
set { this["Speakers"] = value;}
}

public System.Collections.Generic.List<msCoursePrerequisite> Prerequisites {
get { return SafeGetValue<System.Collections.Generic.List<msCoursePrerequisite>>("Prerequisites");}
set { this["Prerequisites"] = value;}
}

public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msCourseSpeaker : msAggregateChild {
public new const string CLASS_NAME = "CourseSpeaker";
public new  static class FIELDS {
public const string Speaker = "Speaker";
}
public msCourseSpeaker() : base() {
ClassType = "CourseSpeaker";
}
public msCourseSpeaker( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCourseSpeaker FromClassMetadata(ClassMetadata meta){return new msCourseSpeaker(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Speaker {
get { return SafeGetValue<System.String>("Speaker");}
set { this["Speaker"] = value;}
}

}
[Serializable]
public class msCoursePrerequisite : msAggregateChild {
public new const string CLASS_NAME = "CoursePrerequisite";
public new  static class FIELDS {
public const string Prerequisite = "Prerequisite";
}
public msCoursePrerequisite() : base() {
ClassType = "CoursePrerequisite";
}
public msCoursePrerequisite( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCoursePrerequisite FromClassMetadata(ClassMetadata meta){return new msCoursePrerequisite(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Prerequisite {
get { return SafeGetValue<System.String>("Prerequisite");}
set { this["Prerequisite"] = value;}
}

}
[Serializable]
public class msEventBase : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "EventBase";
public new  static class FIELDS {
public const string BusinessUnit = "BusinessUnit";
public const string ConfirmationEmail = "ConfirmationEmail";
public const string WaitListEmail = "WaitListEmail";
public const string CertificationComponent = "CertificationComponent";
public const string Description = "Description";
public const string ShortSummary = "ShortSummary";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string RegistrationMode = "RegistrationMode";
public const string PreRegistrationCutOffDate = "PreRegistrationCutOffDate";
public const string EarlyRegistrationCutOffDate = "EarlyRegistrationCutOffDate";
public const string RegularRegistrationCutOffDate = "RegularRegistrationCutOffDate";
public const string LateRegistrationCutOffDate = "LateRegistrationCutOffDate";
public const string PostToWeb = "PostToWeb";
public const string RemoveFromWeb = "RemoveFromWeb";
public const string Agenda = "Agenda";
public const string Minutes = "Minutes";
public const string FeaturedPriority = "FeaturedPriority";
public const string FeaturedFrom = "FeaturedFrom";
public const string FeaturedUntil = "FeaturedUntil";
public const string VisibleInPortal = "VisibleInPortal";
public const string TimeZone = "TimeZone";
public const string ParentEvent = "ParentEvent";
public const string MustBeRegisteredForParent = "MustBeRegisteredForParent";
public const string Capacity = "Capacity";
public const string RegistrationGoal = "RegistrationGoal";
public const string RevenueGoal = "RevenueGoal";
public const string ProjectedAttendance = "ProjectedAttendance";
public const string GuaranteedAttendance = "GuaranteedAttendance";
public const string AllowWaitList = "AllowWaitList";
public const string RequiresApproval = "RequiresApproval";
public const string Url = "Url";
public const string RegistrationOpenDate = "RegistrationOpenDate";
public const string RegistrationCloseDate = "RegistrationCloseDate";
public const string Courses = "Courses";
public const string Speakers = "Speakers";
public const string RegistrationUrl = "RegistrationUrl";
}
public msEventBase() : base() {
ClassType = "EventBase";
Courses = new System.Collections.Generic.List<msSessionCourse>();
Speakers = new System.Collections.Generic.List<msSessionSpeaker>();
}
public msEventBase( MemberSuiteObject msObj) : base(msObj) {}
public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public System.String ConfirmationEmail {
get { return SafeGetValue<System.String>("ConfirmationEmail");}
set { this["ConfirmationEmail"] = value;}
}

public System.String WaitListEmail {
get { return SafeGetValue<System.String>("WaitListEmail");}
set { this["WaitListEmail"] = value;}
}

public System.String CertificationComponent {
get { return SafeGetValue<System.String>("CertificationComponent");}
set { this["CertificationComponent"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String ShortSummary {
get { return SafeGetValue<System.String>("ShortSummary");}
set { this["ShortSummary"] = value;}
}

public System.DateTime StartDate {
get { return SafeGetValue<System.DateTime>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime EndDate {
get { return SafeGetValue<System.DateTime>("EndDate");}
set { this["EndDate"] = value;}
}

public MemberSuite.SDK.Types.EventRegistrationMode RegistrationMode {
get { return SafeGetValue<MemberSuite.SDK.Types.EventRegistrationMode>("RegistrationMode");}
set { this["RegistrationMode"] = value;}
}

public System.DateTime? PreRegistrationCutOffDate {
get { return SafeGetValue<System.DateTime?>("PreRegistrationCutOffDate");}
set { this["PreRegistrationCutOffDate"] = value;}
}

public System.DateTime? EarlyRegistrationCutOffDate {
get { return SafeGetValue<System.DateTime?>("EarlyRegistrationCutOffDate");}
set { this["EarlyRegistrationCutOffDate"] = value;}
}

public System.DateTime? RegularRegistrationCutOffDate {
get { return SafeGetValue<System.DateTime?>("RegularRegistrationCutOffDate");}
set { this["RegularRegistrationCutOffDate"] = value;}
}

public System.DateTime? LateRegistrationCutOffDate {
get { return SafeGetValue<System.DateTime?>("LateRegistrationCutOffDate");}
set { this["LateRegistrationCutOffDate"] = value;}
}

public System.DateTime? PostToWeb {
get { return SafeGetValue<System.DateTime?>("PostToWeb");}
set { this["PostToWeb"] = value;}
}

public System.DateTime? RemoveFromWeb {
get { return SafeGetValue<System.DateTime?>("RemoveFromWeb");}
set { this["RemoveFromWeb"] = value;}
}

public System.String Agenda {
get { return SafeGetValue<System.String>("Agenda");}
set { this["Agenda"] = value;}
}

public System.String Minutes {
get { return SafeGetValue<System.String>("Minutes");}
set { this["Minutes"] = value;}
}

public System.Int32? FeaturedPriority {
get { return SafeGetValue<System.Int32?>("FeaturedPriority");}
set { this["FeaturedPriority"] = value;}
}

public System.DateTime? FeaturedFrom {
get { return SafeGetValue<System.DateTime?>("FeaturedFrom");}
set { this["FeaturedFrom"] = value;}
}

public System.DateTime? FeaturedUntil {
get { return SafeGetValue<System.DateTime?>("FeaturedUntil");}
set { this["FeaturedUntil"] = value;}
}

public System.Boolean VisibleInPortal {
get { return SafeGetValue<System.Boolean>("VisibleInPortal");}
set { this["VisibleInPortal"] = value;}
}

public System.String TimeZone {
get { return SafeGetValue<System.String>("TimeZone");}
set { this["TimeZone"] = value;}
}

public System.String ParentEvent {
get { return SafeGetValue<System.String>("ParentEvent");}
set { this["ParentEvent"] = value;}
}

public System.Boolean MustBeRegisteredForParent {
get { return SafeGetValue<System.Boolean>("MustBeRegisteredForParent");}
set { this["MustBeRegisteredForParent"] = value;}
}

public System.Int32? Capacity {
get { return SafeGetValue<System.Int32?>("Capacity");}
set { this["Capacity"] = value;}
}

public System.Int32 RegistrationGoal {
get { return SafeGetValue<System.Int32>("RegistrationGoal");}
set { this["RegistrationGoal"] = value;}
}

public System.Decimal RevenueGoal {
get { return SafeGetValue<System.Decimal>("RevenueGoal");}
set { this["RevenueGoal"] = value;}
}

public System.Int32? ProjectedAttendance {
get { return SafeGetValue<System.Int32?>("ProjectedAttendance");}
set { this["ProjectedAttendance"] = value;}
}

public System.Int32? GuaranteedAttendance {
get { return SafeGetValue<System.Int32?>("GuaranteedAttendance");}
set { this["GuaranteedAttendance"] = value;}
}

public System.Boolean AllowWaitList {
get { return SafeGetValue<System.Boolean>("AllowWaitList");}
set { this["AllowWaitList"] = value;}
}

public System.Boolean RequiresApproval {
get { return SafeGetValue<System.Boolean>("RequiresApproval");}
set { this["RequiresApproval"] = value;}
}

public System.String Url {
get { return SafeGetValue<System.String>("Url");}
set { this["Url"] = value;}
}

public System.DateTime? RegistrationOpenDate {
get { return SafeGetValue<System.DateTime?>("RegistrationOpenDate");}
set { this["RegistrationOpenDate"] = value;}
}

public System.DateTime? RegistrationCloseDate {
get { return SafeGetValue<System.DateTime?>("RegistrationCloseDate");}
set { this["RegistrationCloseDate"] = value;}
}

public System.Collections.Generic.List<msSessionCourse> Courses {
get { return SafeGetValue<System.Collections.Generic.List<msSessionCourse>>("Courses");}
set { this["Courses"] = value;}
}

public System.Collections.Generic.List<msSessionSpeaker> Speakers {
get { return SafeGetValue<System.Collections.Generic.List<msSessionSpeaker>>("Speakers");}
set { this["Speakers"] = value;}
}

public System.String RegistrationUrl {
get { return SafeGetValue<System.String>("RegistrationUrl");}
set { this["RegistrationUrl"] = value;}
}

}
[Serializable]
public class msSessionCourse : msAggregateChild {
public new const string CLASS_NAME = "SessionCourse";
public new  static class FIELDS {
public const string Course = "Course";
}
public msSessionCourse() : base() {
ClassType = "SessionCourse";
}
public msSessionCourse( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSessionCourse FromClassMetadata(ClassMetadata meta){return new msSessionCourse(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Course {
get { return SafeGetValue<System.String>("Course");}
set { this["Course"] = value;}
}

}
[Serializable]
public class msSessionSpeaker : msAggregateChild {
public new const string CLASS_NAME = "SessionSpeaker";
public new  static class FIELDS {
public const string Speaker = "Speaker";
}
public msSessionSpeaker() : base() {
ClassType = "SessionSpeaker";
}
public msSessionSpeaker( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSessionSpeaker FromClassMetadata(ClassMetadata meta){return new msSessionSpeaker(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Speaker {
get { return SafeGetValue<System.String>("Speaker");}
set { this["Speaker"] = value;}
}

}
[Serializable]
public class msEventCategory : msConfigurableType {
public new const string CLASS_NAME = "EventCategory";
public new  static class FIELDS {
}
public msEventCategory() : base() {
ClassType = "EventCategory";
}
public msEventCategory( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventCategory FromClassMetadata(ClassMetadata meta){return new msEventCategory(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msEventConfigurableType : msConfigurableType {
public new const string CLASS_NAME = "EventConfigurableType";
public new  static class FIELDS {
public const string Event = "Event";
}
public msEventConfigurableType() : base() {
ClassType = "EventConfigurableType";
}
public msEventConfigurableType( MemberSuiteObject msObj) : base(msObj) {}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

}
[Serializable]
public class msDiscountCode : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "DiscountCode";
public new  static class FIELDS {
public const string Code = "Code";
public const string Description = "Description";
public const string ValidFrom = "ValidFrom";
public const string ValidUntil = "ValidUntil";
public const string ApplicableProducts = "ApplicableProducts";
public const string ApplicableProductTypes = "ApplicableProductTypes";
public const string ApplicableProductCategories = "ApplicableProductCategories";
public const string MaximumNumberOfUsages = "MaximumNumberOfUsages";
public const string MaximumNumberOfUsagesPerCustomer = "MaximumNumberOfUsagesPerCustomer";
public const string EligibleCustomers = "EligibleCustomers";
public const string RestrictToEligibleProducts = "RestrictToEligibleProducts";
public const string RestrictToSpecifiedCustomers = "RestrictToSpecifiedCustomers";
public const string MaxUsagesWithinOrder = "MaxUsagesWithinOrder";
public const string Amount = "Amount";
public const string Percentage = "Percentage";
public const string DiscountProduct = "DiscountProduct";
}
public msDiscountCode() : base() {
ClassType = "DiscountCode";
ApplicableProducts = new System.Collections.Generic.List<msDiscountCodeProduct>();
ApplicableProductTypes = new System.Collections.Generic.List<msDiscountCodeProductType>();
ApplicableProductCategories = new System.Collections.Generic.List<msDiscountCodeProductCategory>();
EligibleCustomers = new System.Collections.Generic.List<msDiscountCodeCustomer>();
}
public msDiscountCode( MemberSuiteObject msObj) : base(msObj) {}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.DateTime? ValidFrom {
get { return SafeGetValue<System.DateTime?>("ValidFrom");}
set { this["ValidFrom"] = value;}
}

public System.DateTime? ValidUntil {
get { return SafeGetValue<System.DateTime?>("ValidUntil");}
set { this["ValidUntil"] = value;}
}

public System.Collections.Generic.List<msDiscountCodeProduct> ApplicableProducts {
get { return SafeGetValue<System.Collections.Generic.List<msDiscountCodeProduct>>("ApplicableProducts");}
set { this["ApplicableProducts"] = value;}
}

public System.Collections.Generic.List<msDiscountCodeProductType> ApplicableProductTypes {
get { return SafeGetValue<System.Collections.Generic.List<msDiscountCodeProductType>>("ApplicableProductTypes");}
set { this["ApplicableProductTypes"] = value;}
}

public System.Collections.Generic.List<msDiscountCodeProductCategory> ApplicableProductCategories {
get { return SafeGetValue<System.Collections.Generic.List<msDiscountCodeProductCategory>>("ApplicableProductCategories");}
set { this["ApplicableProductCategories"] = value;}
}

public System.Int32? MaximumNumberOfUsages {
get { return SafeGetValue<System.Int32?>("MaximumNumberOfUsages");}
set { this["MaximumNumberOfUsages"] = value;}
}

public System.Int32? MaximumNumberOfUsagesPerCustomer {
get { return SafeGetValue<System.Int32?>("MaximumNumberOfUsagesPerCustomer");}
set { this["MaximumNumberOfUsagesPerCustomer"] = value;}
}

public System.Collections.Generic.List<msDiscountCodeCustomer> EligibleCustomers {
get { return SafeGetValue<System.Collections.Generic.List<msDiscountCodeCustomer>>("EligibleCustomers");}
set { this["EligibleCustomers"] = value;}
}

public System.Boolean RestrictToEligibleProducts {
get { return SafeGetValue<System.Boolean>("RestrictToEligibleProducts");}
set { this["RestrictToEligibleProducts"] = value;}
}

public System.Boolean RestrictToSpecifiedCustomers {
get { return SafeGetValue<System.Boolean>("RestrictToSpecifiedCustomers");}
set { this["RestrictToSpecifiedCustomers"] = value;}
}

public System.Int32? MaxUsagesWithinOrder {
get { return SafeGetValue<System.Int32?>("MaxUsagesWithinOrder");}
set { this["MaxUsagesWithinOrder"] = value;}
}

public System.Decimal Amount {
get { return SafeGetValue<System.Decimal>("Amount");}
set { this["Amount"] = value;}
}

public System.Decimal Percentage {
get { return SafeGetValue<System.Decimal>("Percentage");}
set { this["Percentage"] = value;}
}

public System.String DiscountProduct {
get { return SafeGetValue<System.String>("DiscountProduct");}
set { this["DiscountProduct"] = value;}
}

}
[Serializable]
public class msEventDiscountCode : msDiscountCode {
public new const string CLASS_NAME = "EventDiscountCode";
public new  static class FIELDS {
public const string Event = "Event";
}
public msEventDiscountCode() : base() {
ClassType = "EventDiscountCode";
ApplicableProducts = new System.Collections.Generic.List<msDiscountCodeProduct>();
ApplicableProductTypes = new System.Collections.Generic.List<msDiscountCodeProductType>();
ApplicableProductCategories = new System.Collections.Generic.List<msDiscountCodeProductCategory>();
EligibleCustomers = new System.Collections.Generic.List<msDiscountCodeCustomer>();
}
public msEventDiscountCode( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventDiscountCode FromClassMetadata(ClassMetadata meta){return new msEventDiscountCode(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

}
[Serializable]
public class msEventInformationLink : msInformationLink {
public new const string CLASS_NAME = "EventInformationLink";
public new  static class FIELDS {
public const string Event = "Event";
}
public msEventInformationLink() : base() {
ClassType = "EventInformationLink";
}
public msEventInformationLink( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventInformationLink FromClassMetadata(ClassMetadata meta){return new msEventInformationLink(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

}
[Serializable]
public class msEventInvitee : msAssociationDomainObject {
public new const string CLASS_NAME = "EventInvitee";
public new  static class FIELDS {
public const string Event = "Event";
public const string Invitee = "Invitee";
}
public msEventInvitee() : base() {
ClassType = "EventInvitee";
}
public msEventInvitee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventInvitee FromClassMetadata(ClassMetadata meta){return new msEventInvitee(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String Invitee {
get { return SafeGetValue<System.String>("Invitee");}
set { this["Invitee"] = value;}
}

}
[Serializable]
public class msEventMerchandise : msProduct {
public new const string CLASS_NAME = "EventMerchandise";
public new  static class FIELDS {
public const string Event = "Event";
}
public msEventMerchandise() : base() {
ClassType = "EventMerchandise";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msEventMerchandise( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventMerchandise FromClassMetadata(ClassMetadata meta){return new msEventMerchandise(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

}
[Serializable]
public class msRegistrationBase : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "RegistrationBase";
public new  static class FIELDS {
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
public const string Fee = "Fee";
public const string Event = "Event";
public const string Approved = "Approved";
public const string Notes = "Notes";
public const string DateApproved = "DateApproved";
public const string HasGeneratedCEUCredits = "HasGeneratedCEUCredits";
public const string Owner = "Owner";
public const string CheckInDate = "CheckInDate";
public const string AssignedTo = "AssignedTo";
public const string OnWaitList = "OnWaitList";
public const string CancellationDate = "CancellationDate";
public const string CancellationReason = "CancellationReason";
public const string Group = "Group";
public const string OwnerPrimaryOrganization = "OwnerPrimaryOrganization";
public const string AddOns = "AddOns";
}
public msRegistrationBase() : base() {
ClassType = "RegistrationBase";
AddOns = new System.Collections.Generic.List<msRegistrationAddOn>();
}
public msRegistrationBase( MemberSuiteObject msObj) : base(msObj) {}
public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.String Fee {
get { return SafeGetValue<System.String>("Fee");}
set { this["Fee"] = value;}
}

public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.Boolean Approved {
get { return SafeGetValue<System.Boolean>("Approved");}
set { this["Approved"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.DateTime? DateApproved {
get { return SafeGetValue<System.DateTime?>("DateApproved");}
set { this["DateApproved"] = value;}
}

public System.Boolean HasGeneratedCEUCredits {
get { return SafeGetValue<System.Boolean>("HasGeneratedCEUCredits");}
set { this["HasGeneratedCEUCredits"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.DateTime? CheckInDate {
get { return SafeGetValue<System.DateTime?>("CheckInDate");}
set { this["CheckInDate"] = value;}
}

public System.String AssignedTo {
get { return SafeGetValue<System.String>("AssignedTo");}
set { this["AssignedTo"] = value;}
}

public System.Boolean OnWaitList {
get { return SafeGetValue<System.Boolean>("OnWaitList");}
set { this["OnWaitList"] = value;}
}

public System.DateTime? CancellationDate {
get { return SafeGetValue<System.DateTime?>("CancellationDate");}
set { this["CancellationDate"] = value;}
}

public System.String CancellationReason {
get { return SafeGetValue<System.String>("CancellationReason");}
set { this["CancellationReason"] = value;}
}

public System.String Group {
get { return SafeGetValue<System.String>("Group");}
set { this["Group"] = value;}
}

public System.String OwnerPrimaryOrganization {
get { return SafeGetValue<System.String>("OwnerPrimaryOrganization");}
set { this["OwnerPrimaryOrganization"] = value;}
}

public System.Collections.Generic.List<msRegistrationAddOn> AddOns {
get { return SafeGetValue<System.Collections.Generic.List<msRegistrationAddOn>>("AddOns");}
set { this["AddOns"] = value;}
}

}
[Serializable]
public class msRegistrationAddOn : msAggregateChild {
public new const string CLASS_NAME = "RegistrationAddOn";
public new  static class FIELDS {
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
public const string Merchandise = "Merchandise";
public const string Quantity = "Quantity";
public const string Price = "Price";
public const string ExpirationDate = "ExpirationDate";
public const string Comments = "Comments";
}
public msRegistrationAddOn() : base() {
ClassType = "RegistrationAddOn";
}
public msRegistrationAddOn( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRegistrationAddOn FromClassMetadata(ClassMetadata meta){return new msRegistrationAddOn(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.String Merchandise {
get { return SafeGetValue<System.String>("Merchandise");}
set { this["Merchandise"] = value;}
}

public System.Decimal? Quantity {
get { return SafeGetValue<System.Decimal?>("Quantity");}
set { this["Quantity"] = value;}
}

public System.Decimal? Price {
get { return SafeGetValue<System.Decimal?>("Price");}
set { this["Price"] = value;}
}

public System.DateTime? ExpirationDate {
get { return SafeGetValue<System.DateTime?>("ExpirationDate");}
set { this["ExpirationDate"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

}
[Serializable]
public class msEventResource : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "EventResource";
public new  static class FIELDS {
public const string Event = "Event";
public const string Room = "Room";
public const string Code = "Code";
public const string IsActive = "IsActive";
public const string NumberOfAssignments = "NumberOfAssignments";
public const string Description = "Description";
public const string Type = "Type";
}
public msEventResource() : base() {
ClassType = "EventResource";
}
public msEventResource( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventResource FromClassMetadata(ClassMetadata meta){return new msEventResource(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String Room {
get { return SafeGetValue<System.String>("Room");}
set { this["Room"] = value;}
}

public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.Int32 NumberOfAssignments {
get { return SafeGetValue<System.Int32>("NumberOfAssignments");}
set { this["NumberOfAssignments"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

}
[Serializable]
public class msEventResourceType : msConfigurableType {
public new const string CLASS_NAME = "EventResourceType";
public new  static class FIELDS {
}
public msEventResourceType() : base() {
ClassType = "EventResourceType";
}
public msEventResourceType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventResourceType FromClassMetadata(ClassMetadata meta){return new msEventResourceType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msEventTableType : msConfigurableType {
public new const string CLASS_NAME = "EventTableType";
public new  static class FIELDS {
}
public msEventTableType() : base() {
ClassType = "EventTableType";
}
public msEventTableType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventTableType FromClassMetadata(ClassMetadata meta){return new msEventTableType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msSpeaker : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "Speaker";
public new  static class FIELDS {
public const string Individual = "Individual";
public const string IsActive = "IsActive";
public const string Bio = "Bio";
}
public msSpeaker() : base() {
ClassType = "Speaker";
}
public msSpeaker( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSpeaker FromClassMetadata(ClassMetadata meta){return new msSpeaker(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Individual {
get { return SafeGetValue<System.String>("Individual");}
set { this["Individual"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.String Bio {
get { return SafeGetValue<System.String>("Bio");}
set { this["Bio"] = value;}
}

}
[Serializable]
public class msRegistrationCategory : msEventConfigurableType {
public new const string CLASS_NAME = "RegistrationCategory";
public new  static class FIELDS {
}
public msRegistrationCategory() : base() {
ClassType = "RegistrationCategory";
}
public msRegistrationCategory( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRegistrationCategory FromClassMetadata(ClassMetadata meta){return new msRegistrationCategory(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msRegistrationClass : msEventConfigurableType {
public new const string CLASS_NAME = "RegistrationClass";
public new  static class FIELDS {
}
public msRegistrationClass() : base() {
ClassType = "RegistrationClass";
}
public msRegistrationClass( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRegistrationClass FromClassMetadata(ClassMetadata meta){return new msRegistrationClass(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msRegistrationFee : msProduct {
public new const string CLASS_NAME = "RegistrationFee";
public new  static class FIELDS {
public const string IsGuestRegistration = "IsGuestRegistration";
public const string Event = "Event";
public const string CustomerType = "CustomerType";
public const string RequiresApproval = "RequiresApproval";
public const string Agenda = "Agenda";
public const string RegistrantCategory = "RegistrantCategory";
public const string RegistrantClass = "RegistrantClass";
public const string EarlyRegistrationPrice = "EarlyRegistrationPrice";
public const string LateRegistrationPrice = "LateRegistrationPrice";
public const string PreRegistrationPrice = "PreRegistrationPrice";
public const string MemberEarlyRegistrationPrice = "MemberEarlyRegistrationPrice";
public const string MemberLateRegistrationPrice = "MemberLateRegistrationPrice";
public const string MemberPreRegistrationPrice = "MemberPreRegistrationPrice";
public const string RestrictByMembershipType = "RestrictByMembershipType";
public const string MembershipTypes = "MembershipTypes";
public const string RestrictSessionsByTimeSlots = "RestrictSessionsByTimeSlots";
public const string TimeSlots = "TimeSlots";
public const string RestrictSessionsByTracks = "RestrictSessionsByTracks";
public const string Tracks = "Tracks";
public const string MaximumNumberOfSessions = "MaximumNumberOfSessions";
}
public msRegistrationFee() : base() {
ClassType = "RegistrationFee";
MembershipTypes = new System.Collections.Generic.List<System.String>();
TimeSlots = new System.Collections.Generic.List<System.String>();
Tracks = new System.Collections.Generic.List<System.String>();
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msRegistrationFee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRegistrationFee FromClassMetadata(ClassMetadata meta){return new msRegistrationFee(MemberSuiteObject.FromClassMetadata(meta));}
public System.Boolean IsGuestRegistration {
get { return SafeGetValue<System.Boolean>("IsGuestRegistration");}
set { this["IsGuestRegistration"] = value;}
}

public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public MemberSuite.SDK.Types.CustomerType CustomerType {
get { return SafeGetValue<MemberSuite.SDK.Types.CustomerType>("CustomerType");}
set { this["CustomerType"] = value;}
}

public System.Boolean RequiresApproval {
get { return SafeGetValue<System.Boolean>("RequiresApproval");}
set { this["RequiresApproval"] = value;}
}

public System.String Agenda {
get { return SafeGetValue<System.String>("Agenda");}
set { this["Agenda"] = value;}
}

public System.String RegistrantCategory {
get { return SafeGetValue<System.String>("RegistrantCategory");}
set { this["RegistrantCategory"] = value;}
}

public System.String RegistrantClass {
get { return SafeGetValue<System.String>("RegistrantClass");}
set { this["RegistrantClass"] = value;}
}

public System.Decimal? EarlyRegistrationPrice {
get { return SafeGetValue<System.Decimal?>("EarlyRegistrationPrice");}
set { this["EarlyRegistrationPrice"] = value;}
}

public System.Decimal? LateRegistrationPrice {
get { return SafeGetValue<System.Decimal?>("LateRegistrationPrice");}
set { this["LateRegistrationPrice"] = value;}
}

public System.Decimal? PreRegistrationPrice {
get { return SafeGetValue<System.Decimal?>("PreRegistrationPrice");}
set { this["PreRegistrationPrice"] = value;}
}

public System.Decimal? MemberEarlyRegistrationPrice {
get { return SafeGetValue<System.Decimal?>("MemberEarlyRegistrationPrice");}
set { this["MemberEarlyRegistrationPrice"] = value;}
}

public System.Decimal? MemberLateRegistrationPrice {
get { return SafeGetValue<System.Decimal?>("MemberLateRegistrationPrice");}
set { this["MemberLateRegistrationPrice"] = value;}
}

public System.Decimal? MemberPreRegistrationPrice {
get { return SafeGetValue<System.Decimal?>("MemberPreRegistrationPrice");}
set { this["MemberPreRegistrationPrice"] = value;}
}

public System.Boolean RestrictByMembershipType {
get { return SafeGetValue<System.Boolean>("RestrictByMembershipType");}
set { this["RestrictByMembershipType"] = value;}
}

public System.Collections.Generic.List<System.String> MembershipTypes {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("MembershipTypes");}
set { this["MembershipTypes"] = value;}
}

public System.Boolean RestrictSessionsByTimeSlots {
get { return SafeGetValue<System.Boolean>("RestrictSessionsByTimeSlots");}
set { this["RestrictSessionsByTimeSlots"] = value;}
}

public System.Collections.Generic.List<System.String> TimeSlots {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("TimeSlots");}
set { this["TimeSlots"] = value;}
}

public System.Boolean RestrictSessionsByTracks {
get { return SafeGetValue<System.Boolean>("RestrictSessionsByTracks");}
set { this["RestrictSessionsByTracks"] = value;}
}

public System.Collections.Generic.List<System.String> Tracks {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Tracks");}
set { this["Tracks"] = value;}
}

public System.Int32? MaximumNumberOfSessions {
get { return SafeGetValue<System.Int32?>("MaximumNumberOfSessions");}
set { this["MaximumNumberOfSessions"] = value;}
}

}
[Serializable]
public class msEventRibbonType : msConfigurableType {
public new const string CLASS_NAME = "EventRibbonType";
public new  static class FIELDS {
public const string Color = "Color";
}
public msEventRibbonType() : base() {
ClassType = "EventRibbonType";
}
public msEventRibbonType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventRibbonType FromClassMetadata(ClassMetadata meta){return new msEventRibbonType(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Color {
get { return SafeGetValue<System.String>("Color");}
set { this["Color"] = value;}
}

}
[Serializable]
public class msEventSponsorship : msSponsorship {
public new const string CLASS_NAME = "EventSponsorship";
public new  static class FIELDS {
public const string Event = "Event";
public const string Opportunity = "Opportunity";
}
public msEventSponsorship() : base() {
ClassType = "EventSponsorship";
}
public msEventSponsorship( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventSponsorship FromClassMetadata(ClassMetadata meta){return new msEventSponsorship(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String Opportunity {
get { return SafeGetValue<System.String>("Opportunity");}
set { this["Opportunity"] = value;}
}

}
[Serializable]
public class msEventSponsorshipFee : msProduct {
public new const string CLASS_NAME = "EventSponsorshipFee";
public new  static class FIELDS {
public const string Event = "Event";
public const string SponsorshipOpportunity = "SponsorshipOpportunity";
}
public msEventSponsorshipFee() : base() {
ClassType = "EventSponsorshipFee";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msEventSponsorshipFee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventSponsorshipFee FromClassMetadata(ClassMetadata meta){return new msEventSponsorshipFee(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String SponsorshipOpportunity {
get { return SafeGetValue<System.String>("SponsorshipOpportunity");}
set { this["SponsorshipOpportunity"] = value;}
}

}
[Serializable]
public class msEventSponsorshipOpportunity : msAssociationDomainObject {
public new const string CLASS_NAME = "EventSponsorshipOpportunity";
public new  static class FIELDS {
public const string Event = "Event";
public const string Type = "Type";
public const string Session = "Session";
public const string Track = "Track";
public const string Description = "Description";
public const string MaximumAllowed = "MaximumAllowed";
}
public msEventSponsorshipOpportunity() : base() {
ClassType = "EventSponsorshipOpportunity";
}
public msEventSponsorshipOpportunity( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventSponsorshipOpportunity FromClassMetadata(ClassMetadata meta){return new msEventSponsorshipOpportunity(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Session {
get { return SafeGetValue<System.String>("Session");}
set { this["Session"] = value;}
}

public System.String Track {
get { return SafeGetValue<System.String>("Track");}
set { this["Track"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Int32 MaximumAllowed {
get { return SafeGetValue<System.Int32>("MaximumAllowed");}
set { this["MaximumAllowed"] = value;}
}

}
[Serializable]
public class msEventSponsorshipType : msConfigurableType {
public new const string CLASS_NAME = "EventSponsorshipType";
public new  static class FIELDS {
}
public msEventSponsorshipType() : base() {
ClassType = "EventSponsorshipType";
}
public msEventSponsorshipType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventSponsorshipType FromClassMetadata(ClassMetadata meta){return new msEventSponsorshipType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msSessionRegistration : msRegistrationBase {
public new const string CLASS_NAME = "SessionRegistration";
public new  static class FIELDS {
}
public msSessionRegistration() : base() {
ClassType = "SessionRegistration";
AddOns = new System.Collections.Generic.List<msRegistrationAddOn>();
}
public msSessionRegistration( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSessionRegistration FromClassMetadata(ClassMetadata meta){return new msSessionRegistration(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msSessionTimeSlot : msAssociationDomainObject {
public new const string CLASS_NAME = "SessionTimeSlot";
public new  static class FIELDS {
public const string Event = "Event";
public const string StartTime = "StartTime";
public const string EndTime = "EndTime";
public const string AllowMultipleSessions = "AllowMultipleSessions";
}
public msSessionTimeSlot() : base() {
ClassType = "SessionTimeSlot";
}
public msSessionTimeSlot( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSessionTimeSlot FromClassMetadata(ClassMetadata meta){return new msSessionTimeSlot(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.DateTime StartTime {
get { return SafeGetValue<System.DateTime>("StartTime");}
set { this["StartTime"] = value;}
}

public System.DateTime EndTime {
get { return SafeGetValue<System.DateTime>("EndTime");}
set { this["EndTime"] = value;}
}

public System.Boolean AllowMultipleSessions {
get { return SafeGetValue<System.Boolean>("AllowMultipleSessions");}
set { this["AllowMultipleSessions"] = value;}
}

}
[Serializable]
public class msAbstract : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Abstract";
public new  static class FIELDS {
public const string Event = "Event";
public const string Owner = "Owner";
public const string Status = "Status";
public const string Description = "Description";
public const string AdministrativeNotes = "AdministrativeNotes";
public const string Scheduled = "Scheduled";
public const string ReviewedBy = "ReviewedBy";
public const string DateReviewed = "DateReviewed";
public const string Tracks = "Tracks";
public const string PresenterName = "PresenterName";
public const string PresenterBiography = "PresenterBiography";
public const string PresenterPhoneNumber = "PresenterPhoneNumber";
public const string PresenterEmailAddress = "PresenterEmailAddress";
public const string Courses = "Courses";
public const string Speakers = "Speakers";
}
public msAbstract() : base() {
ClassType = "Abstract";
Tracks = new System.Collections.Generic.List<System.String>();
Courses = new System.Collections.Generic.List<msAbstractCourse>();
Speakers = new System.Collections.Generic.List<msAbstractSpeaker>();
}
public msAbstract( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAbstract FromClassMetadata(ClassMetadata meta){return new msAbstract(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String Status {
get { return SafeGetValue<System.String>("Status");}
set { this["Status"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String AdministrativeNotes {
get { return SafeGetValue<System.String>("AdministrativeNotes");}
set { this["AdministrativeNotes"] = value;}
}

public System.Boolean Scheduled {
get { return SafeGetValue<System.Boolean>("Scheduled");}
set { this["Scheduled"] = value;}
}

public System.String ReviewedBy {
get { return SafeGetValue<System.String>("ReviewedBy");}
set { this["ReviewedBy"] = value;}
}

public System.DateTime? DateReviewed {
get { return SafeGetValue<System.DateTime?>("DateReviewed");}
set { this["DateReviewed"] = value;}
}

public System.Collections.Generic.List<System.String> Tracks {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Tracks");}
set { this["Tracks"] = value;}
}

public System.String PresenterName {
get { return SafeGetValue<System.String>("PresenterName");}
set { this["PresenterName"] = value;}
}

public System.String PresenterBiography {
get { return SafeGetValue<System.String>("PresenterBiography");}
set { this["PresenterBiography"] = value;}
}

public System.String PresenterPhoneNumber {
get { return SafeGetValue<System.String>("PresenterPhoneNumber");}
set { this["PresenterPhoneNumber"] = value;}
}

public System.String PresenterEmailAddress {
get { return SafeGetValue<System.String>("PresenterEmailAddress");}
set { this["PresenterEmailAddress"] = value;}
}

public System.Collections.Generic.List<msAbstractCourse> Courses {
get { return SafeGetValue<System.Collections.Generic.List<msAbstractCourse>>("Courses");}
set { this["Courses"] = value;}
}

public System.Collections.Generic.List<msAbstractSpeaker> Speakers {
get { return SafeGetValue<System.Collections.Generic.List<msAbstractSpeaker>>("Speakers");}
set { this["Speakers"] = value;}
}

}
[Serializable]
public class msAbstractCourse : msAggregateChild {
public new const string CLASS_NAME = "AbstractCourse";
public new  static class FIELDS {
public const string Course = "Course";
}
public msAbstractCourse() : base() {
ClassType = "AbstractCourse";
}
public msAbstractCourse( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAbstractCourse FromClassMetadata(ClassMetadata meta){return new msAbstractCourse(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Course {
get { return SafeGetValue<System.String>("Course");}
set { this["Course"] = value;}
}

}
[Serializable]
public class msAbstractSpeaker : msAggregateChild {
public new const string CLASS_NAME = "AbstractSpeaker";
public new  static class FIELDS {
public const string Speaker = "Speaker";
}
public msAbstractSpeaker() : base() {
ClassType = "AbstractSpeaker";
}
public msAbstractSpeaker( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAbstractSpeaker FromClassMetadata(ClassMetadata meta){return new msAbstractSpeaker(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Speaker {
get { return SafeGetValue<System.String>("Speaker");}
set { this["Speaker"] = value;}
}

}
[Serializable]
public class msAbstractStatus : msConfigurableType {
public new const string CLASS_NAME = "AbstractStatus";
public new  static class FIELDS {
}
public msAbstractStatus() : base() {
ClassType = "AbstractStatus";
}
public msAbstractStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAbstractStatus FromClassMetadata(ClassMetadata meta){return new msAbstractStatus(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msSpeakerEvaluation : msAssociationDomainObject {
public new const string CLASS_NAME = "SpeakerEvaluation";
public new  static class FIELDS {
public const string Speaker = "Speaker";
public const string Course = "Course";
public const string Event = "Event";
public const string Session = "Session";
public const string Score = "Score";
public const string Comments = "Comments";
}
public msSpeakerEvaluation() : base() {
ClassType = "SpeakerEvaluation";
}
public msSpeakerEvaluation( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSpeakerEvaluation FromClassMetadata(ClassMetadata meta){return new msSpeakerEvaluation(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Speaker {
get { return SafeGetValue<System.String>("Speaker");}
set { this["Speaker"] = value;}
}

public System.String Course {
get { return SafeGetValue<System.String>("Course");}
set { this["Course"] = value;}
}

public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String Session {
get { return SafeGetValue<System.String>("Session");}
set { this["Session"] = value;}
}

public System.Decimal Score {
get { return SafeGetValue<System.Decimal>("Score");}
set { this["Score"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

}
[Serializable]
public class msEventTable : msAssociationDomainObject {
public new const string CLASS_NAME = "EventTable";
public new  static class FIELDS {
public const string Type = "Type";
public const string DisplayOrder = "DisplayOrder";
public const string ReferenceCode = "ReferenceCode";
public const string Description = "Description";
public const string Event = "Event";
public const string Capacity = "Capacity";
}
public msEventTable() : base() {
ClassType = "EventTable";
}
public msEventTable( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventTable FromClassMetadata(ClassMetadata meta){return new msEventTable(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.Int32? DisplayOrder {
get { return SafeGetValue<System.Int32?>("DisplayOrder");}
set { this["DisplayOrder"] = value;}
}

public System.String ReferenceCode {
get { return SafeGetValue<System.String>("ReferenceCode");}
set { this["ReferenceCode"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.Int32 Capacity {
get { return SafeGetValue<System.Int32>("Capacity");}
set { this["Capacity"] = value;}
}

}
[Serializable]
public class msEventTableReservation : msAssociationDomainObject {
public new const string CLASS_NAME = "EventTableReservation";
public new  static class FIELDS {
public const string Event = "Event";
public const string TableType = "TableType";
public const string NumberOfSeats = "NumberOfSeats";
public const string Owner = "Owner";
public const string Occupant = "Occupant";
public const string Fee = "Fee";
public const string Table = "Table";
public const string ReferenceNumber = "ReferenceNumber";
public const string Notes = "Notes";
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
public const string CancellationDate = "CancellationDate";
public const string CheckInDate = "CheckInDate";
}
public msEventTableReservation() : base() {
ClassType = "EventTableReservation";
}
public msEventTableReservation( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventTableReservation FromClassMetadata(ClassMetadata meta){return new msEventTableReservation(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String TableType {
get { return SafeGetValue<System.String>("TableType");}
set { this["TableType"] = value;}
}

public System.Int16 NumberOfSeats {
get { return SafeGetValue<System.Int16>("NumberOfSeats");}
set { this["NumberOfSeats"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String Occupant {
get { return SafeGetValue<System.String>("Occupant");}
set { this["Occupant"] = value;}
}

public System.String Fee {
get { return SafeGetValue<System.String>("Fee");}
set { this["Fee"] = value;}
}

public System.String Table {
get { return SafeGetValue<System.String>("Table");}
set { this["Table"] = value;}
}

public System.String ReferenceNumber {
get { return SafeGetValue<System.String>("ReferenceNumber");}
set { this["ReferenceNumber"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.DateTime? CancellationDate {
get { return SafeGetValue<System.DateTime?>("CancellationDate");}
set { this["CancellationDate"] = value;}
}

public System.DateTime? CheckInDate {
get { return SafeGetValue<System.DateTime?>("CheckInDate");}
set { this["CheckInDate"] = value;}
}

}
[Serializable]
public class msEventTableFee : msProduct {
public new const string CLASS_NAME = "EventTableFee";
public new  static class FIELDS {
public const string TableType = "TableType";
public const string Event = "Event";
public const string NumberOfSeats = "NumberOfSeats";
}
public msEventTableFee() : base() {
ClassType = "EventTableFee";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msEventTableFee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventTableFee FromClassMetadata(ClassMetadata meta){return new msEventTableFee(MemberSuiteObject.FromClassMetadata(meta));}
public System.String TableType {
get { return SafeGetValue<System.String>("TableType");}
set { this["TableType"] = value;}
}

public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.Int16 NumberOfSeats {
get { return SafeGetValue<System.Int16>("NumberOfSeats");}
set { this["NumberOfSeats"] = value;}
}

}
[Serializable]
public class msWaivedRegistrationList : msAssociationDomainObject {
public new const string CLASS_NAME = "WaivedRegistrationList";
public new  static class FIELDS {
public const string Event = "Event";
public const string Notes = "Notes";
public const string IsActive = "IsActive";
public const string DiscountPercentage = "DiscountPercentage";
public const string AppliesToGuestRegistration = "AppliesToGuestRegistration";
public const string AppliesToEventMerchandise = "AppliesToEventMerchandise";
public const string AppliesToSessions = "AppliesToSessions";
public const string Members = "Members";
}
public msWaivedRegistrationList() : base() {
ClassType = "WaivedRegistrationList";
Members = new System.Collections.Generic.List<System.String>();
}
public msWaivedRegistrationList( MemberSuiteObject msObj) : base(msObj) {}
 public static new msWaivedRegistrationList FromClassMetadata(ClassMetadata meta){return new msWaivedRegistrationList(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.Decimal DiscountPercentage {
get { return SafeGetValue<System.Decimal>("DiscountPercentage");}
set { this["DiscountPercentage"] = value;}
}

public System.Boolean AppliesToGuestRegistration {
get { return SafeGetValue<System.Boolean>("AppliesToGuestRegistration");}
set { this["AppliesToGuestRegistration"] = value;}
}

public System.Boolean AppliesToEventMerchandise {
get { return SafeGetValue<System.Boolean>("AppliesToEventMerchandise");}
set { this["AppliesToEventMerchandise"] = value;}
}

public System.Boolean AppliesToSessions {
get { return SafeGetValue<System.Boolean>("AppliesToSessions");}
set { this["AppliesToSessions"] = value;}
}

public System.Collections.Generic.List<System.String> Members {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Members");}
set { this["Members"] = value;}
}

}
[Serializable]
public class msExhibitorContactRestriction : msAssociationDomainObject {
public new const string CLASS_NAME = "ExhibitorContactRestriction";
public new  static class FIELDS {
public const string Show = "Show";
public const string EvaluationOrder = "EvaluationOrder";
public const string ContactType = "ContactType";
public const string PriorityPointMinimum = "PriorityPointMinimum";
public const string PriorityPointMaximum = "PriorityPointMaximum";
public const string SquareFootageMinimum = "SquareFootageMinimum";
public const string SquareFootageMaximum = "SquareFootageMaximum";
public const string MaximumNumberOfContacts = "MaximumNumberOfContacts";
public const string BoothCategory = "BoothCategory";
public const string BoothType = "BoothType";
public const string ErrorMessage = "ErrorMessage";
public const string Notes = "Notes";
}
public msExhibitorContactRestriction() : base() {
ClassType = "ExhibitorContactRestriction";
}
public msExhibitorContactRestriction( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitorContactRestriction FromClassMetadata(ClassMetadata meta){return new msExhibitorContactRestriction(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Show {
get { return SafeGetValue<System.String>("Show");}
set { this["Show"] = value;}
}

public System.Int32 EvaluationOrder {
get { return SafeGetValue<System.Int32>("EvaluationOrder");}
set { this["EvaluationOrder"] = value;}
}

public System.String ContactType {
get { return SafeGetValue<System.String>("ContactType");}
set { this["ContactType"] = value;}
}

public System.Int32? PriorityPointMinimum {
get { return SafeGetValue<System.Int32?>("PriorityPointMinimum");}
set { this["PriorityPointMinimum"] = value;}
}

public System.Int32? PriorityPointMaximum {
get { return SafeGetValue<System.Int32?>("PriorityPointMaximum");}
set { this["PriorityPointMaximum"] = value;}
}

public System.Int32? SquareFootageMinimum {
get { return SafeGetValue<System.Int32?>("SquareFootageMinimum");}
set { this["SquareFootageMinimum"] = value;}
}

public System.Int32? SquareFootageMaximum {
get { return SafeGetValue<System.Int32?>("SquareFootageMaximum");}
set { this["SquareFootageMaximum"] = value;}
}

public System.Int32 MaximumNumberOfContacts {
get { return SafeGetValue<System.Int32>("MaximumNumberOfContacts");}
set { this["MaximumNumberOfContacts"] = value;}
}

public System.String BoothCategory {
get { return SafeGetValue<System.String>("BoothCategory");}
set { this["BoothCategory"] = value;}
}

public System.String BoothType {
get { return SafeGetValue<System.String>("BoothType");}
set { this["BoothType"] = value;}
}

public System.String ErrorMessage {
get { return SafeGetValue<System.String>("ErrorMessage");}
set { this["ErrorMessage"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msExhibitorContactType : msConfigurableType {
public new const string CLASS_NAME = "ExhibitorContactType";
public new  static class FIELDS {
}
public msExhibitorContactType() : base() {
ClassType = "ExhibitorContactType";
}
public msExhibitorContactType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitorContactType FromClassMetadata(ClassMetadata meta){return new msExhibitorContactType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msExhibitShowProduct : msProduct {
public new const string CLASS_NAME = "ExhibitShowProduct";
public new  static class FIELDS {
public const string Show = "Show";
}
public msExhibitShowProduct() : base() {
ClassType = "ExhibitShowProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msExhibitShowProduct( MemberSuiteObject msObj) : base(msObj) {}
public System.String Show {
get { return SafeGetValue<System.String>("Show");}
set { this["Show"] = value;}
}

}
[Serializable]
public class msExhibitBoothTypeProduct : msExhibitShowProduct {
public new const string CLASS_NAME = "ExhibitBoothTypeProduct";
public new  static class FIELDS {
public const string BoothType = "BoothType";
}
public msExhibitBoothTypeProduct() : base() {
ClassType = "ExhibitBoothTypeProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msExhibitBoothTypeProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitBoothTypeProduct FromClassMetadata(ClassMetadata meta){return new msExhibitBoothTypeProduct(MemberSuiteObject.FromClassMetadata(meta));}
public System.String BoothType {
get { return SafeGetValue<System.String>("BoothType");}
set { this["BoothType"] = value;}
}

}
[Serializable]
public class msExhibitorFee : msProduct {
public new const string CLASS_NAME = "ExhibitorFee";
public new  static class FIELDS {
public const string Booth = "Booth";
}
public msExhibitorFee() : base() {
ClassType = "ExhibitorFee";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msExhibitorFee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitorFee FromClassMetadata(ClassMetadata meta){return new msExhibitorFee(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Booth {
get { return SafeGetValue<System.String>("Booth");}
set { this["Booth"] = value;}
}

}
[Serializable]
public class msExhibitBoothCategory : msConfigurableType {
public new const string CLASS_NAME = "ExhibitBoothCategory";
public new  static class FIELDS {
}
public msExhibitBoothCategory() : base() {
ClassType = "ExhibitBoothCategory";
}
public msExhibitBoothCategory( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitBoothCategory FromClassMetadata(ClassMetadata meta){return new msExhibitBoothCategory(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msExhibitBoothType : msConfigurableType {
public new const string CLASS_NAME = "ExhibitBoothType";
public new  static class FIELDS {
public const string SquareFootage = "SquareFootage";
}
public msExhibitBoothType() : base() {
ClassType = "ExhibitBoothType";
}
public msExhibitBoothType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitBoothType FromClassMetadata(ClassMetadata meta){return new msExhibitBoothType(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int32 SquareFootage {
get { return SafeGetValue<System.Int32>("SquareFootage");}
set { this["SquareFootage"] = value;}
}

}
[Serializable]
public class msExhibitBooth : msAssociationDomainObject {
public new const string CLASS_NAME = "ExhibitBooth";
public new  static class FIELDS {
public const string Code = "Code";
public const string Number = "Number";
public const string Show = "Show";
public const string Category = "Category";
public const string Type = "Type";
public const string CancellationDate = "CancellationDate";
public const string PriorityPoints = "PriorityPoints";
public const string Notes = "Notes";
}
public msExhibitBooth() : base() {
ClassType = "ExhibitBooth";
}
public msExhibitBooth( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitBooth FromClassMetadata(ClassMetadata meta){return new msExhibitBooth(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.Int32 Number {
get { return SafeGetValue<System.Int32>("Number");}
set { this["Number"] = value;}
}

public System.String Show {
get { return SafeGetValue<System.String>("Show");}
set { this["Show"] = value;}
}

public System.String Category {
get { return SafeGetValue<System.String>("Category");}
set { this["Category"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.DateTime? CancellationDate {
get { return SafeGetValue<System.DateTime?>("CancellationDate");}
set { this["CancellationDate"] = value;}
}

public System.Int32 PriorityPoints {
get { return SafeGetValue<System.Int32>("PriorityPoints");}
set { this["PriorityPoints"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msExhibitor : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Exhibitor";
public new  static class FIELDS {
public const string Show = "Show";
public const string Status = "Status";
public const string Customer = "Customer";
public const string RegistrationWindow = "RegistrationWindow";
public const string ContractSendDate = "ContractSendDate";
public const string ContractReceivedDate = "ContractReceivedDate";
public const string CancellationDate = "CancellationDate";
public const string Notes = "Notes";
public const string Booths = "Booths";
public const string BoothPreferences = "BoothPreferences";
public const string Contacts = "Contacts";
public const string BoothTypes = "BoothTypes";
public const string Logo = "Logo";
public const string Bio = "Bio";
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
}
public msExhibitor() : base() {
ClassType = "Exhibitor";
Booths = new System.Collections.Generic.List<msExhibitorAssignedBooth>();
BoothPreferences = new System.Collections.Generic.List<msExhibitorAssignedBooth>();
Contacts = new System.Collections.Generic.List<msExhibitorContact>();
BoothTypes = new System.Collections.Generic.List<msExhibitorPreferredBoothType>();
}
public msExhibitor( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitor FromClassMetadata(ClassMetadata meta){return new msExhibitor(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Show {
get { return SafeGetValue<System.String>("Show");}
set { this["Show"] = value;}
}

public System.String Status {
get { return SafeGetValue<System.String>("Status");}
set { this["Status"] = value;}
}

public System.String Customer {
get { return SafeGetValue<System.String>("Customer");}
set { this["Customer"] = value;}
}

public System.String RegistrationWindow {
get { return SafeGetValue<System.String>("RegistrationWindow");}
set { this["RegistrationWindow"] = value;}
}

public System.DateTime? ContractSendDate {
get { return SafeGetValue<System.DateTime?>("ContractSendDate");}
set { this["ContractSendDate"] = value;}
}

public System.DateTime? ContractReceivedDate {
get { return SafeGetValue<System.DateTime?>("ContractReceivedDate");}
set { this["ContractReceivedDate"] = value;}
}

public System.DateTime? CancellationDate {
get { return SafeGetValue<System.DateTime?>("CancellationDate");}
set { this["CancellationDate"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Collections.Generic.List<msExhibitorAssignedBooth> Booths {
get { return SafeGetValue<System.Collections.Generic.List<msExhibitorAssignedBooth>>("Booths");}
set { this["Booths"] = value;}
}

public System.Collections.Generic.List<msExhibitorAssignedBooth> BoothPreferences {
get { return SafeGetValue<System.Collections.Generic.List<msExhibitorAssignedBooth>>("BoothPreferences");}
set { this["BoothPreferences"] = value;}
}

public System.Collections.Generic.List<msExhibitorContact> Contacts {
get { return SafeGetValue<System.Collections.Generic.List<msExhibitorContact>>("Contacts");}
set { this["Contacts"] = value;}
}

public System.Collections.Generic.List<msExhibitorPreferredBoothType> BoothTypes {
get { return SafeGetValue<System.Collections.Generic.List<msExhibitorPreferredBoothType>>("BoothTypes");}
set { this["BoothTypes"] = value;}
}

public System.String Logo {
get { return SafeGetValue<System.String>("Logo");}
set { this["Logo"] = value;}
}

public System.String Bio {
get { return SafeGetValue<System.String>("Bio");}
set { this["Bio"] = value;}
}

public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

}
[Serializable]
public class msExhibitorAssignedBooth : msAggregateChild {
public new const string CLASS_NAME = "ExhibitorAssignedBooth";
public new  static class FIELDS {
public const string Booth = "Booth";
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
}
public msExhibitorAssignedBooth() : base() {
ClassType = "ExhibitorAssignedBooth";
}
public msExhibitorAssignedBooth( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitorAssignedBooth FromClassMetadata(ClassMetadata meta){return new msExhibitorAssignedBooth(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Booth {
get { return SafeGetValue<System.String>("Booth");}
set { this["Booth"] = value;}
}

public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

}
[Serializable]
public class msExhibitorPreferredBoothType : msAggregateChild {
public new const string CLASS_NAME = "ExhibitorPreferredBoothType";
public new  static class FIELDS {
public const string Type = "Type";
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
}
public msExhibitorPreferredBoothType() : base() {
ClassType = "ExhibitorPreferredBoothType";
}
public msExhibitorPreferredBoothType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitorPreferredBoothType FromClassMetadata(ClassMetadata meta){return new msExhibitorPreferredBoothType(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

}
[Serializable]
public class msExhibitorContact : msAggregateChild {
public new const string CLASS_NAME = "ExhibitorContact";
public new  static class FIELDS {
public const string Type = "Type";
public const string Title = "Title";
public const string FirstName = "FirstName";
public const string LastName = "LastName";
public const string EmailAddress = "EmailAddress";
public const string WorkPhone = "WorkPhone";
public const string MobilePhone = "MobilePhone";
public const string Notes = "Notes";
}
public msExhibitorContact() : base() {
ClassType = "ExhibitorContact";
}
public msExhibitorContact( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitorContact FromClassMetadata(ClassMetadata meta){return new msExhibitorContact(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Title {
get { return SafeGetValue<System.String>("Title");}
set { this["Title"] = value;}
}

public System.String FirstName {
get { return SafeGetValue<System.String>("FirstName");}
set { this["FirstName"] = value;}
}

public System.String LastName {
get { return SafeGetValue<System.String>("LastName");}
set { this["LastName"] = value;}
}

public System.String EmailAddress {
get { return SafeGetValue<System.String>("EmailAddress");}
set { this["EmailAddress"] = value;}
}

public System.String WorkPhone {
get { return SafeGetValue<System.String>("WorkPhone");}
set { this["WorkPhone"] = value;}
}

public System.String MobilePhone {
get { return SafeGetValue<System.String>("MobilePhone");}
set { this["MobilePhone"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msExhibitorMerchandise : msExhibitShowProduct {
public new const string CLASS_NAME = "ExhibitorMerchandise";
public new  static class FIELDS {
}
public msExhibitorMerchandise() : base() {
ClassType = "ExhibitorMerchandise";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msExhibitorMerchandise( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitorMerchandise FromClassMetadata(ClassMetadata meta){return new msExhibitorMerchandise(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msExhibitorRegistrationWindow : msAssociationDomainObject {
public new const string CLASS_NAME = "ExhibitorRegistrationWindow";
public new  static class FIELDS {
public const string Show = "Show";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string PriorityPointMinimum = "PriorityPointMinimum";
public const string PriorityPointMaximum = "PriorityPointMaximum";
public const string RegistrationMode = "RegistrationMode";
public const string CustomerType = "CustomerType";
public const string Notes = "Notes";
public const string RegistrationInstructions = "RegistrationInstructions";
public const string RegistrationConfirmationInstructions = "RegistrationConfirmationInstructions";
}
public msExhibitorRegistrationWindow() : base() {
ClassType = "ExhibitorRegistrationWindow";
}
public msExhibitorRegistrationWindow( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitorRegistrationWindow FromClassMetadata(ClassMetadata meta){return new msExhibitorRegistrationWindow(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Show {
get { return SafeGetValue<System.String>("Show");}
set { this["Show"] = value;}
}

public System.DateTime StartDate {
get { return SafeGetValue<System.DateTime>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime EndDate {
get { return SafeGetValue<System.DateTime>("EndDate");}
set { this["EndDate"] = value;}
}

public System.Int32 PriorityPointMinimum {
get { return SafeGetValue<System.Int32>("PriorityPointMinimum");}
set { this["PriorityPointMinimum"] = value;}
}

public System.Int32 PriorityPointMaximum {
get { return SafeGetValue<System.Int32>("PriorityPointMaximum");}
set { this["PriorityPointMaximum"] = value;}
}

public MemberSuite.SDK.Types.ExhibitorRegistrationMode RegistrationMode {
get { return SafeGetValue<MemberSuite.SDK.Types.ExhibitorRegistrationMode>("RegistrationMode");}
set { this["RegistrationMode"] = value;}
}

public MemberSuite.SDK.Types.CustomerType CustomerType {
get { return SafeGetValue<MemberSuite.SDK.Types.CustomerType>("CustomerType");}
set { this["CustomerType"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.String RegistrationInstructions {
get { return SafeGetValue<System.String>("RegistrationInstructions");}
set { this["RegistrationInstructions"] = value;}
}

public System.String RegistrationConfirmationInstructions {
get { return SafeGetValue<System.String>("RegistrationConfirmationInstructions");}
set { this["RegistrationConfirmationInstructions"] = value;}
}

}
[Serializable]
public class msExhibitSponsorship : msSponsorship {
public new const string CLASS_NAME = "ExhibitSponsorship";
public new  static class FIELDS {
public const string Show = "Show";
public const string Fee = "Fee";
}
public msExhibitSponsorship() : base() {
ClassType = "ExhibitSponsorship";
}
public msExhibitSponsorship( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitSponsorship FromClassMetadata(ClassMetadata meta){return new msExhibitSponsorship(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Show {
get { return SafeGetValue<System.String>("Show");}
set { this["Show"] = value;}
}

public System.String Fee {
get { return SafeGetValue<System.String>("Fee");}
set { this["Fee"] = value;}
}

}
[Serializable]
public class msExhibitSponsorshipFee : msProduct {
public new const string CLASS_NAME = "ExhibitSponsorshipFee";
public new  static class FIELDS {
public const string Show = "Show";
}
public msExhibitSponsorshipFee() : base() {
ClassType = "ExhibitSponsorshipFee";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msExhibitSponsorshipFee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitSponsorshipFee FromClassMetadata(ClassMetadata meta){return new msExhibitSponsorshipFee(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Show {
get { return SafeGetValue<System.String>("Show");}
set { this["Show"] = value;}
}

}
[Serializable]
public class msExhibitorStatus : msConfigurableType {
public new const string CLASS_NAME = "ExhibitorStatus";
public new  static class FIELDS {
}
public msExhibitorStatus() : base() {
ClassType = "ExhibitorStatus";
}
public msExhibitorStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitorStatus FromClassMetadata(ClassMetadata meta){return new msExhibitorStatus(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msExhibitShow : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "ExhibitShow";
public new  static class FIELDS {
public const string Code = "Code";
public const string Event = "Event";
public const string Category = "Category";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string ShortSummary = "ShortSummary";
public const string PostToWeb = "PostToWeb";
public const string RemoveFromWeb = "RemoveFromWeb";
public const string VisibleInPortal = "VisibleInPortal";
public const string ShowExhibitorListInPortal = "ShowExhibitorListInPortal";
public const string PriorityPointGroup = "PriorityPointGroup";
public const string RegistrationInstructions = "RegistrationInstructions";
public const string RegistrationConfirmationInstructions = "RegistrationConfirmationInstructions";
public const string MaintainWaitList = "MaintainWaitList";
public const string Description = "Description";
public const string ShowFloor = "ShowFloor";
}
public msExhibitShow() : base() {
ClassType = "ExhibitShow";
}
public msExhibitShow( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExhibitShow FromClassMetadata(ClassMetadata meta){return new msExhibitShow(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String Category {
get { return SafeGetValue<System.String>("Category");}
set { this["Category"] = value;}
}

public System.DateTime StartDate {
get { return SafeGetValue<System.DateTime>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime EndDate {
get { return SafeGetValue<System.DateTime>("EndDate");}
set { this["EndDate"] = value;}
}

public System.String ShortSummary {
get { return SafeGetValue<System.String>("ShortSummary");}
set { this["ShortSummary"] = value;}
}

public System.DateTime? PostToWeb {
get { return SafeGetValue<System.DateTime?>("PostToWeb");}
set { this["PostToWeb"] = value;}
}

public System.DateTime? RemoveFromWeb {
get { return SafeGetValue<System.DateTime?>("RemoveFromWeb");}
set { this["RemoveFromWeb"] = value;}
}

public System.Boolean VisibleInPortal {
get { return SafeGetValue<System.Boolean>("VisibleInPortal");}
set { this["VisibleInPortal"] = value;}
}

public System.Boolean ShowExhibitorListInPortal {
get { return SafeGetValue<System.Boolean>("ShowExhibitorListInPortal");}
set { this["ShowExhibitorListInPortal"] = value;}
}

public System.String PriorityPointGroup {
get { return SafeGetValue<System.String>("PriorityPointGroup");}
set { this["PriorityPointGroup"] = value;}
}

public System.String RegistrationInstructions {
get { return SafeGetValue<System.String>("RegistrationInstructions");}
set { this["RegistrationInstructions"] = value;}
}

public System.String RegistrationConfirmationInstructions {
get { return SafeGetValue<System.String>("RegistrationConfirmationInstructions");}
set { this["RegistrationConfirmationInstructions"] = value;}
}

public System.Boolean MaintainWaitList {
get { return SafeGetValue<System.Boolean>("MaintainWaitList");}
set { this["MaintainWaitList"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String ShowFloor {
get { return SafeGetValue<System.String>("ShowFloor");}
set { this["ShowFloor"] = value;}
}

}
[Serializable]
public class msPriorityPointAssignment : msAssociationDomainObject {
public new const string CLASS_NAME = "PriorityPointAssignment";
public new  static class FIELDS {
public const string Show = "Show";
public const string Booth = "Booth";
public const string Exhibitor = "Exhibitor";
public const string Group = "Group";
public const string Type = "Type";
public const string Quantity = "Quantity";
public const string Notes = "Notes";
}
public msPriorityPointAssignment() : base() {
ClassType = "PriorityPointAssignment";
}
public msPriorityPointAssignment( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPriorityPointAssignment FromClassMetadata(ClassMetadata meta){return new msPriorityPointAssignment(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Show {
get { return SafeGetValue<System.String>("Show");}
set { this["Show"] = value;}
}

public System.String Booth {
get { return SafeGetValue<System.String>("Booth");}
set { this["Booth"] = value;}
}

public System.String Exhibitor {
get { return SafeGetValue<System.String>("Exhibitor");}
set { this["Exhibitor"] = value;}
}

public System.String Group {
get { return SafeGetValue<System.String>("Group");}
set { this["Group"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.Int32 Quantity {
get { return SafeGetValue<System.Int32>("Quantity");}
set { this["Quantity"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msPriorityPointGroup : msConfigurableType {
public new const string CLASS_NAME = "PriorityPointGroup";
public new  static class FIELDS {
}
public msPriorityPointGroup() : base() {
ClassType = "PriorityPointGroup";
}
public msPriorityPointGroup( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPriorityPointGroup FromClassMetadata(ClassMetadata meta){return new msPriorityPointGroup(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msPriorityPointType : msConfigurableType {
public new const string CLASS_NAME = "PriorityPointType";
public new  static class FIELDS {
}
public msPriorityPointType() : base() {
ClassType = "PriorityPointType";
}
public msPriorityPointType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPriorityPointType FromClassMetadata(ClassMetadata meta){return new msPriorityPointType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAppeal : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "Appeal";
public new  static class FIELDS {
public const string Code = "Code";
public const string Description = "Description";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string Goal = "Goal";
public const string Notes = "Notes";
public const string Premiums = "Premiums";
}
public msAppeal() : base() {
ClassType = "Appeal";
Premiums = new System.Collections.Generic.List<msLinkedPremium>();
}
public msAppeal( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAppeal FromClassMetadata(ClassMetadata meta){return new msAppeal(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? EndDate {
get { return SafeGetValue<System.DateTime?>("EndDate");}
set { this["EndDate"] = value;}
}

public System.Decimal? Goal {
get { return SafeGetValue<System.Decimal?>("Goal");}
set { this["Goal"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Collections.Generic.List<msLinkedPremium> Premiums {
get { return SafeGetValue<System.Collections.Generic.List<msLinkedPremium>>("Premiums");}
set { this["Premiums"] = value;}
}

}
[Serializable]
public class msFundraisingExpense : msExpense {
public new const string CLASS_NAME = "FundraisingExpense";
public new  static class FIELDS {
public const string Appeal = "Appeal";
public const string Campaign = "Campaign";
public const string Fund = "Fund";
}
public msFundraisingExpense() : base() {
ClassType = "FundraisingExpense";
}
public msFundraisingExpense( MemberSuiteObject msObj) : base(msObj) {}
 public static new msFundraisingExpense FromClassMetadata(ClassMetadata meta){return new msFundraisingExpense(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Appeal {
get { return SafeGetValue<System.String>("Appeal");}
set { this["Appeal"] = value;}
}

public System.String Campaign {
get { return SafeGetValue<System.String>("Campaign");}
set { this["Campaign"] = value;}
}

public System.String Fund {
get { return SafeGetValue<System.String>("Fund");}
set { this["Fund"] = value;}
}

}
[Serializable]
public class msGiftAttributeCategory : msConfigurableType {
public new const string CLASS_NAME = "GiftAttributeCategory";
public new  static class FIELDS {
}
public msGiftAttributeCategory() : base() {
ClassType = "GiftAttributeCategory";
}
public msGiftAttributeCategory( MemberSuiteObject msObj) : base(msObj) {}
 public static new msGiftAttributeCategory FromClassMetadata(ClassMetadata meta){return new msGiftAttributeCategory(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msMailMergeTemplateBase : msAssociationDomainObject {
public new const string CLASS_NAME = "MailMergeTemplateBase";
public new  static class FIELDS {
public const string Description = "Description";
public const string SearchType = "SearchType";
public const string Template = "Template";
}
public msMailMergeTemplateBase() : base() {
ClassType = "MailMergeTemplateBase";
}
public msMailMergeTemplateBase( MemberSuiteObject msObj) : base(msObj) {}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String SearchType {
get { return SafeGetValue<System.String>("SearchType");}
set { this["SearchType"] = value;}
}

public System.String Template {
get { return SafeGetValue<System.String>("Template");}
set { this["Template"] = value;}
}

}
[Serializable]
public class msDonorAcknowledgmentLetter : msMailMergeTemplateBase {
public new const string CLASS_NAME = "DonorAcknowledgmentLetter";
public new  static class FIELDS {
}
public msDonorAcknowledgmentLetter() : base() {
ClassType = "DonorAcknowledgmentLetter";
}
public msDonorAcknowledgmentLetter( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDonorAcknowledgmentLetter FromClassMetadata(ClassMetadata meta){return new msDonorAcknowledgmentLetter(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msDonorAcknowledgmentRule : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "DonorAcknowledgmentRule";
public new  static class FIELDS {
public const string EvaluationOrder = "EvaluationOrder";
public const string Letter = "Letter";
public const string Receipt = "Receipt";
public const string EmailTemplate = "EmailTemplate";
public const string Campaign = "Campaign";
public const string Fund = "Fund";
public const string Appeal = "Appeal";
public const string Product = "Product";
public const string MinimumGift = "MinimumGift";
public const string MaximumGift = "MaximumGift";
public const string Description = "Description";
public const string DonorType = "DonorType";
}
public msDonorAcknowledgmentRule() : base() {
ClassType = "DonorAcknowledgmentRule";
}
public msDonorAcknowledgmentRule( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDonorAcknowledgmentRule FromClassMetadata(ClassMetadata meta){return new msDonorAcknowledgmentRule(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int32 EvaluationOrder {
get { return SafeGetValue<System.Int32>("EvaluationOrder");}
set { this["EvaluationOrder"] = value;}
}

public System.String Letter {
get { return SafeGetValue<System.String>("Letter");}
set { this["Letter"] = value;}
}

public System.String Receipt {
get { return SafeGetValue<System.String>("Receipt");}
set { this["Receipt"] = value;}
}

public System.String EmailTemplate {
get { return SafeGetValue<System.String>("EmailTemplate");}
set { this["EmailTemplate"] = value;}
}

public System.String Campaign {
get { return SafeGetValue<System.String>("Campaign");}
set { this["Campaign"] = value;}
}

public System.String Fund {
get { return SafeGetValue<System.String>("Fund");}
set { this["Fund"] = value;}
}

public System.String Appeal {
get { return SafeGetValue<System.String>("Appeal");}
set { this["Appeal"] = value;}
}

public System.String Product {
get { return SafeGetValue<System.String>("Product");}
set { this["Product"] = value;}
}

public System.Decimal? MinimumGift {
get { return SafeGetValue<System.Decimal?>("MinimumGift");}
set { this["MinimumGift"] = value;}
}

public System.Decimal? MaximumGift {
get { return SafeGetValue<System.Decimal?>("MaximumGift");}
set { this["MaximumGift"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public MemberSuite.SDK.Types.CustomerType DonorType {
get { return SafeGetValue<MemberSuite.SDK.Types.CustomerType>("DonorType");}
set { this["DonorType"] = value;}
}

}
[Serializable]
public class msDonorReceipt : msMailMergeTemplateBase {
public new const string CLASS_NAME = "DonorReceipt";
public new  static class FIELDS {
}
public msDonorReceipt() : base() {
ClassType = "DonorReceipt";
}
public msDonorReceipt( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDonorReceipt FromClassMetadata(ClassMetadata meta){return new msDonorReceipt(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msGiftPackage : msConfigurableType {
public new const string CLASS_NAME = "GiftPackage";
public new  static class FIELDS {
}
public msGiftPackage() : base() {
ClassType = "GiftPackage";
}
public msGiftPackage( MemberSuiteObject msObj) : base(msObj) {}
 public static new msGiftPackage FromClassMetadata(ClassMetadata meta){return new msGiftPackage(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msGiftSubType : msConfigurableType {
public new const string CLASS_NAME = "GiftSubType";
public new  static class FIELDS {
}
public msGiftSubType() : base() {
ClassType = "GiftSubType";
}
public msGiftSubType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msGiftSubType FromClassMetadata(ClassMetadata meta){return new msGiftSubType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msPortalGiftPaymentRule : msPortalPaymentRule {
public new const string CLASS_NAME = "PortalGiftPaymentRule";
public new  static class FIELDS {
public const string Fund = "Fund";
}
public msPortalGiftPaymentRule() : base() {
ClassType = "PortalGiftPaymentRule";
}
public msPortalGiftPaymentRule( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPortalGiftPaymentRule FromClassMetadata(ClassMetadata meta){return new msPortalGiftPaymentRule(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Fund {
get { return SafeGetValue<System.String>("Fund");}
set { this["Fund"] = value;}
}

}
[Serializable]
public class msPremium : msProduct {
public new const string CLASS_NAME = "Premium";
public new  static class FIELDS {
}
public msPremium() : base() {
ClassType = "Premium";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msPremium( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPremium FromClassMetadata(ClassMetadata meta){return new msPremium(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msLinkedPremium : msAggregateChild {
public new const string CLASS_NAME = "LinkedPremium";
public new  static class FIELDS {
public const string Premium = "Premium";
public const string Quantity = "Quantity";
public const string MinimumGift = "MinimumGift";
public const string MaximumGift = "MaximumGift";
}
public msLinkedPremium() : base() {
ClassType = "LinkedPremium";
}
public msLinkedPremium( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLinkedPremium FromClassMetadata(ClassMetadata meta){return new msLinkedPremium(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Premium {
get { return SafeGetValue<System.String>("Premium");}
set { this["Premium"] = value;}
}

public System.Int32 Quantity {
get { return SafeGetValue<System.Int32>("Quantity");}
set { this["Quantity"] = value;}
}

public System.Decimal? MinimumGift {
get { return SafeGetValue<System.Decimal?>("MinimumGift");}
set { this["MinimumGift"] = value;}
}

public System.Decimal? MaximumGift {
get { return SafeGetValue<System.Decimal?>("MaximumGift");}
set { this["MaximumGift"] = value;}
}

}
[Serializable]
public class msTribute : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "Tribute";
public new  static class FIELDS {
public const string Type = "Type";
public const string Honoree = "Honoree";
public const string Notes = "Notes";
public const string DefaultFund = "DefaultFund";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string Acknowledgees = "Acknowledgees";
public const string HonoreeIsAcknowledgee = "HonoreeIsAcknowledgee";
}
public msTribute() : base() {
ClassType = "Tribute";
Acknowledgees = new System.Collections.Generic.List<msTributeAcknowledgee>();
}
public msTribute( MemberSuiteObject msObj) : base(msObj) {}
 public static new msTribute FromClassMetadata(ClassMetadata meta){return new msTribute(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Honoree {
get { return SafeGetValue<System.String>("Honoree");}
set { this["Honoree"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.String DefaultFund {
get { return SafeGetValue<System.String>("DefaultFund");}
set { this["DefaultFund"] = value;}
}

public System.DateTime StartDate {
get { return SafeGetValue<System.DateTime>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime EndDate {
get { return SafeGetValue<System.DateTime>("EndDate");}
set { this["EndDate"] = value;}
}

public System.Collections.Generic.List<msTributeAcknowledgee> Acknowledgees {
get { return SafeGetValue<System.Collections.Generic.List<msTributeAcknowledgee>>("Acknowledgees");}
set { this["Acknowledgees"] = value;}
}

public System.Boolean HonoreeIsAcknowledgee {
get { return SafeGetValue<System.Boolean>("HonoreeIsAcknowledgee");}
set { this["HonoreeIsAcknowledgee"] = value;}
}

}
[Serializable]
public class msTributeAcknowledgee : msAggregateChild {
public new const string CLASS_NAME = "TributeAcknowledgee";
public new  static class FIELDS {
public const string Acknowledgee = "Acknowledgee";
public const string Relationship = "Relationship";
public const string Reciprocal = "Reciprocal";
}
public msTributeAcknowledgee() : base() {
ClassType = "TributeAcknowledgee";
}
public msTributeAcknowledgee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msTributeAcknowledgee FromClassMetadata(ClassMetadata meta){return new msTributeAcknowledgee(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Acknowledgee {
get { return SafeGetValue<System.String>("Acknowledgee");}
set { this["Acknowledgee"] = value;}
}

public System.String Relationship {
get { return SafeGetValue<System.String>("Relationship");}
set { this["Relationship"] = value;}
}

public System.String Reciprocal {
get { return SafeGetValue<System.String>("Reciprocal");}
set { this["Reciprocal"] = value;}
}

}
[Serializable]
public class msJob : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "Job";
public new  static class FIELDS {
public const string Description = "Description";
public const string Context = "Context";
public const string Status = "Status";
public const string DateStarted = "DateStarted";
public const string DateCompleted = "DateCompleted";
public const string Log = "Log";
public const string ConfirmationEmail = "ConfirmationEmail";
}
public msJob() : base() {
ClassType = "Job";
}
public msJob( MemberSuiteObject msObj) : base(msObj) {}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String Context {
get { return SafeGetValue<System.String>("Context");}
set { this["Context"] = value;}
}

public MemberSuite.SDK.Types.JobStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.JobStatus>("Status");}
set { this["Status"] = value;}
}

public System.DateTime? DateStarted {
get { return SafeGetValue<System.DateTime?>("DateStarted");}
set { this["DateStarted"] = value;}
}

public System.DateTime? DateCompleted {
get { return SafeGetValue<System.DateTime?>("DateCompleted");}
set { this["DateCompleted"] = value;}
}

public System.String Log {
get { return SafeGetValue<System.String>("Log");}
set { this["Log"] = value;}
}

public System.String ConfirmationEmail {
get { return SafeGetValue<System.String>("ConfirmationEmail");}
set { this["ConfirmationEmail"] = value;}
}

}
[Serializable]
public class msGenericJob : msJob {
public new const string CLASS_NAME = "GenericJob";
public new  static class FIELDS {
public const string Type = "Type";
public const string Manifest = "Manifest";
public const string ListOfIDs = "ListOfIDs";
}
public msGenericJob() : base() {
ClassType = "GenericJob";
ListOfIDs = new System.Collections.Generic.List<System.String>();
}
public msGenericJob( MemberSuiteObject msObj) : base(msObj) {}
 public static new msGenericJob FromClassMetadata(ClassMetadata meta){return new msGenericJob(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.GenericJobType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.GenericJobType>("Type");}
set { this["Type"] = value;}
}

public System.String Manifest {
get { return SafeGetValue<System.String>("Manifest");}
set { this["Manifest"] = value;}
}

public System.Collections.Generic.List<System.String> ListOfIDs {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("ListOfIDs");}
set { this["ListOfIDs"] = value;}
}

}
[Serializable]
public class msLegislativeBill : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "LegislativeBill";
public new  static class FIELDS {
public const string Code = "Code";
public const string AlternativeNames = "AlternativeNames";
public const string Manager = "Manager";
public const string LegislativeBody = "LegislativeBody";
public const string Category = "Category";
public const string Status = "Status";
public const string Lobbyist = "Lobbyist";
public const string InterestGroup = "InterestGroup";
public const string Description = "Description";
public const string Author = "Author";
public const string Sponsors = "Sponsors";
public const string Issues = "Issues";
}
public msLegislativeBill() : base() {
ClassType = "LegislativeBill";
Sponsors = new System.Collections.Generic.List<msLegislativeBillSponsor>();
Issues = new System.Collections.Generic.List<msLegislativeBillIssue>();
}
public msLegislativeBill( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLegislativeBill FromClassMetadata(ClassMetadata meta){return new msLegislativeBill(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String AlternativeNames {
get { return SafeGetValue<System.String>("AlternativeNames");}
set { this["AlternativeNames"] = value;}
}

public System.String Manager {
get { return SafeGetValue<System.String>("Manager");}
set { this["Manager"] = value;}
}

public System.String LegislativeBody {
get { return SafeGetValue<System.String>("LegislativeBody");}
set { this["LegislativeBody"] = value;}
}

public System.String Category {
get { return SafeGetValue<System.String>("Category");}
set { this["Category"] = value;}
}

public System.String Status {
get { return SafeGetValue<System.String>("Status");}
set { this["Status"] = value;}
}

public System.String Lobbyist {
get { return SafeGetValue<System.String>("Lobbyist");}
set { this["Lobbyist"] = value;}
}

public System.String InterestGroup {
get { return SafeGetValue<System.String>("InterestGroup");}
set { this["InterestGroup"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String Author {
get { return SafeGetValue<System.String>("Author");}
set { this["Author"] = value;}
}

public System.Collections.Generic.List<msLegislativeBillSponsor> Sponsors {
get { return SafeGetValue<System.Collections.Generic.List<msLegislativeBillSponsor>>("Sponsors");}
set { this["Sponsors"] = value;}
}

public System.Collections.Generic.List<msLegislativeBillIssue> Issues {
get { return SafeGetValue<System.Collections.Generic.List<msLegislativeBillIssue>>("Issues");}
set { this["Issues"] = value;}
}

}
[Serializable]
public class msLegislativeBillSponsor : msAggregateChild {
public new const string CLASS_NAME = "LegislativeBillSponsor";
public new  static class FIELDS {
public const string Legislator = "Legislator";
public const string Type = "Type";
public const string Notes = "Notes";
}
public msLegislativeBillSponsor() : base() {
ClassType = "LegislativeBillSponsor";
}
public msLegislativeBillSponsor( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLegislativeBillSponsor FromClassMetadata(ClassMetadata meta){return new msLegislativeBillSponsor(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Legislator {
get { return SafeGetValue<System.String>("Legislator");}
set { this["Legislator"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msLegislativeBillIssue : msAggregateChild {
public new const string CLASS_NAME = "LegislativeBillIssue";
public new  static class FIELDS {
public const string Issue = "Issue";
}
public msLegislativeBillIssue() : base() {
ClassType = "LegislativeBillIssue";
}
public msLegislativeBillIssue( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLegislativeBillIssue FromClassMetadata(ClassMetadata meta){return new msLegislativeBillIssue(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Issue {
get { return SafeGetValue<System.String>("Issue");}
set { this["Issue"] = value;}
}

}
[Serializable]
public class msLegislativeBillCategory : msConfigurableType {
public new const string CLASS_NAME = "LegislativeBillCategory";
public new  static class FIELDS {
}
public msLegislativeBillCategory() : base() {
ClassType = "LegislativeBillCategory";
}
public msLegislativeBillCategory( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLegislativeBillCategory FromClassMetadata(ClassMetadata meta){return new msLegislativeBillCategory(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msLegislativeBillSponsorType : msConfigurableType {
public new const string CLASS_NAME = "LegislativeBillSponsorType";
public new  static class FIELDS {
}
public msLegislativeBillSponsorType() : base() {
ClassType = "LegislativeBillSponsorType";
}
public msLegislativeBillSponsorType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLegislativeBillSponsorType FromClassMetadata(ClassMetadata meta){return new msLegislativeBillSponsorType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msLegislativeBillStatus : msConfigurableType {
public new const string CLASS_NAME = "LegislativeBillStatus";
public new  static class FIELDS {
}
public msLegislativeBillStatus() : base() {
ClassType = "LegislativeBillStatus";
}
public msLegislativeBillStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLegislativeBillStatus FromClassMetadata(ClassMetadata meta){return new msLegislativeBillStatus(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msLegislativeBody : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "LegislativeBody";
public new  static class FIELDS {
public const string Address = "Address";
public const string MainPhoneNumber = "MainPhoneNumber";
public const string FaxNumber = "FaxNumber";
public const string EmailAddress = "EmailAddress";
public const string Description = "Description";
public const string IsDefault = "IsDefault";
}
public msLegislativeBody() : base() {
ClassType = "LegislativeBody";
}
public msLegislativeBody( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLegislativeBody FromClassMetadata(ClassMetadata meta){return new msLegislativeBody(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.Address Address {
get { return SafeGetValue<MemberSuite.SDK.Types.Address>("Address");}
set { this["Address"] = value;}
}

public System.String MainPhoneNumber {
get { return SafeGetValue<System.String>("MainPhoneNumber");}
set { this["MainPhoneNumber"] = value;}
}

public System.String FaxNumber {
get { return SafeGetValue<System.String>("FaxNumber");}
set { this["FaxNumber"] = value;}
}

public System.String EmailAddress {
get { return SafeGetValue<System.String>("EmailAddress");}
set { this["EmailAddress"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Boolean IsDefault {
get { return SafeGetValue<System.Boolean>("IsDefault");}
set { this["IsDefault"] = value;}
}

}
[Serializable]
public class msLegislativeDistrict : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "LegislativeDistrict";
public new  static class FIELDS {
public const string LegislativeBody = "LegislativeBody";
public const string Description = "Description";
public const string IsActive = "IsActive";
}
public msLegislativeDistrict() : base() {
ClassType = "LegislativeDistrict";
}
public msLegislativeDistrict( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLegislativeDistrict FromClassMetadata(ClassMetadata meta){return new msLegislativeDistrict(MemberSuiteObject.FromClassMetadata(meta));}
public System.String LegislativeBody {
get { return SafeGetValue<System.String>("LegislativeBody");}
set { this["LegislativeBody"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

}
[Serializable]
public class msLegislativeIssue : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "LegislativeIssue";
public new  static class FIELDS {
public const string Manager = "Manager";
public const string Description = "Description";
}
public msLegislativeIssue() : base() {
ClassType = "LegislativeIssue";
}
public msLegislativeIssue( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLegislativeIssue FromClassMetadata(ClassMetadata meta){return new msLegislativeIssue(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Manager {
get { return SafeGetValue<System.String>("Manager");}
set { this["Manager"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msLegislativeTerm : msAssociationDomainObject {
public new const string CLASS_NAME = "LegislativeTerm";
public new  static class FIELDS {
public const string LegislativeBody = "LegislativeBody";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string Description = "Description";
}
public msLegislativeTerm() : base() {
ClassType = "LegislativeTerm";
}
public msLegislativeTerm( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLegislativeTerm FromClassMetadata(ClassMetadata meta){return new msLegislativeTerm(MemberSuiteObject.FromClassMetadata(meta));}
public System.String LegislativeBody {
get { return SafeGetValue<System.String>("LegislativeBody");}
set { this["LegislativeBody"] = value;}
}

public System.DateTime StartDate {
get { return SafeGetValue<System.DateTime>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime EndDate {
get { return SafeGetValue<System.DateTime>("EndDate");}
set { this["EndDate"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msLegislativeTitle : msConfigurableType {
public new const string CLASS_NAME = "LegislativeTitle";
public new  static class FIELDS {
}
public msLegislativeTitle() : base() {
ClassType = "LegislativeTitle";
}
public msLegislativeTitle( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLegislativeTitle FromClassMetadata(ClassMetadata meta){return new msLegislativeTitle(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msLegislator : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Legislator";
public new  static class FIELDS {
public const string Priority = "Priority";
public const string Individual = "Individual";
public const string LegislativeBody = "LegislativeBody";
public const string Title = "Title";
public const string District = "District";
public const string Terms = "Terms";
public const string Notes = "Notes";
}
public msLegislator() : base() {
ClassType = "Legislator";
Terms = new System.Collections.Generic.List<msLegislatorTerm>();
}
public msLegislator( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLegislator FromClassMetadata(ClassMetadata meta){return new msLegislator(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int16? Priority {
get { return SafeGetValue<System.Int16?>("Priority");}
set { this["Priority"] = value;}
}

public System.String Individual {
get { return SafeGetValue<System.String>("Individual");}
set { this["Individual"] = value;}
}

public System.String LegislativeBody {
get { return SafeGetValue<System.String>("LegislativeBody");}
set { this["LegislativeBody"] = value;}
}

public System.String Title {
get { return SafeGetValue<System.String>("Title");}
set { this["Title"] = value;}
}

public System.String District {
get { return SafeGetValue<System.String>("District");}
set { this["District"] = value;}
}

public System.Collections.Generic.List<msLegislatorTerm> Terms {
get { return SafeGetValue<System.Collections.Generic.List<msLegislatorTerm>>("Terms");}
set { this["Terms"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msLegislatorTerm : msAggregateChild {
public new const string CLASS_NAME = "LegislatorTerm";
public new  static class FIELDS {
public const string Term = "Term";
public const string Notes = "Notes";
}
public msLegislatorTerm() : base() {
ClassType = "LegislatorTerm";
}
public msLegislatorTerm( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLegislatorTerm FromClassMetadata(ClassMetadata meta){return new msLegislatorTerm(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Term {
get { return SafeGetValue<System.String>("Term");}
set { this["Term"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msChapterPostalCodeMapping : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "ChapterPostalCodeMapping";
public new  static class FIELDS {
public const string EvaluationOrder = "EvaluationOrder";
public const string MembershipOrganization = "MembershipOrganization";
public const string PostalCodeRangeStart = "PostalCodeRangeStart";
public const string PostalCodeRangeEnd = "PostalCodeRangeEnd";
public const string Chapter = "Chapter";
public const string State = "State";
public const string Country = "Country";
public const string IsCatchAll = "IsCatchAll";
public const string InvertRuleLogic = "InvertRuleLogic";
public const string Notes = "Notes";
}
public msChapterPostalCodeMapping() : base() {
ClassType = "ChapterPostalCodeMapping";
}
public msChapterPostalCodeMapping( MemberSuiteObject msObj) : base(msObj) {}
 public static new msChapterPostalCodeMapping FromClassMetadata(ClassMetadata meta){return new msChapterPostalCodeMapping(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int32? EvaluationOrder {
get { return SafeGetValue<System.Int32?>("EvaluationOrder");}
set { this["EvaluationOrder"] = value;}
}

public System.String MembershipOrganization {
get { return SafeGetValue<System.String>("MembershipOrganization");}
set { this["MembershipOrganization"] = value;}
}

public System.String PostalCodeRangeStart {
get { return SafeGetValue<System.String>("PostalCodeRangeStart");}
set { this["PostalCodeRangeStart"] = value;}
}

public System.String PostalCodeRangeEnd {
get { return SafeGetValue<System.String>("PostalCodeRangeEnd");}
set { this["PostalCodeRangeEnd"] = value;}
}

public System.String Chapter {
get { return SafeGetValue<System.String>("Chapter");}
set { this["Chapter"] = value;}
}

public System.String State {
get { return SafeGetValue<System.String>("State");}
set { this["State"] = value;}
}

public System.String Country {
get { return SafeGetValue<System.String>("Country");}
set { this["Country"] = value;}
}

public System.Boolean IsCatchAll {
get { return SafeGetValue<System.Boolean>("IsCatchAll");}
set { this["IsCatchAll"] = value;}
}

public System.Boolean InvertRuleLogic {
get { return SafeGetValue<System.Boolean>("InvertRuleLogic");}
set { this["InvertRuleLogic"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msMembershipCardTemplate : msMailMergeTemplateBase {
public new const string CLASS_NAME = "MembershipCardTemplate";
public new  static class FIELDS {
public const string MembershipOrganization = "MembershipOrganization";
public const string IsDefault = "IsDefault";
}
public msMembershipCardTemplate() : base() {
ClassType = "MembershipCardTemplate";
}
public msMembershipCardTemplate( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipCardTemplate FromClassMetadata(ClassMetadata meta){return new msMembershipCardTemplate(MemberSuiteObject.FromClassMetadata(meta));}
public System.String MembershipOrganization {
get { return SafeGetValue<System.String>("MembershipOrganization");}
set { this["MembershipOrganization"] = value;}
}

public System.Boolean IsDefault {
get { return SafeGetValue<System.Boolean>("IsDefault");}
set { this["IsDefault"] = value;}
}

}
[Serializable]
public class msMembershipRecommendation : msRecommendation {
public new const string CLASS_NAME = "MembershipRecommendation";
public new  static class FIELDS {
public const string Membership = "Membership";
public const string Type = "Type";
}
public msMembershipRecommendation() : base() {
ClassType = "MembershipRecommendation";
}
public msMembershipRecommendation( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipRecommendation FromClassMetadata(ClassMetadata meta){return new msMembershipRecommendation(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Membership {
get { return SafeGetValue<System.String>("Membership");}
set { this["Membership"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

}
[Serializable]
public class msMembershipRecommendationType : msConfigurableType {
public new const string CLASS_NAME = "MembershipRecommendationType";
public new  static class FIELDS {
}
public msMembershipRecommendationType() : base() {
ClassType = "MembershipRecommendationType";
}
public msMembershipRecommendationType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipRecommendationType FromClassMetadata(ClassMetadata meta){return new msMembershipRecommendationType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msMembershipTermsOfServiceAgreement : msTermsOfServiceAgreement {
public new const string CLASS_NAME = "MembershipTermsOfServiceAgreement";
public new  static class FIELDS {
public const string Membership = "Membership";
}
public msMembershipTermsOfServiceAgreement() : base() {
ClassType = "MembershipTermsOfServiceAgreement";
}
public msMembershipTermsOfServiceAgreement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipTermsOfServiceAgreement FromClassMetadata(ClassMetadata meta){return new msMembershipTermsOfServiceAgreement(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Membership {
get { return SafeGetValue<System.String>("Membership");}
set { this["Membership"] = value;}
}

}
[Serializable]
public class msMetadataContainer : msAssociationDomainObject {
public new const string CLASS_NAME = "MetadataContainer";
public new  static class FIELDS {
public const string IsDefault = "IsDefault";
public const string CustomObject = "CustomObject";
public const string Description = "Description";
public const string ApplicableType = "ApplicableType";
}
public msMetadataContainer() : base() {
ClassType = "MetadataContainer";
}
public msMetadataContainer( MemberSuiteObject msObj) : base(msObj) {}
public System.Boolean IsDefault {
get { return SafeGetValue<System.Boolean>("IsDefault");}
set { this["IsDefault"] = value;}
}

public System.String CustomObject {
get { return SafeGetValue<System.String>("CustomObject");}
set { this["CustomObject"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String ApplicableType {
get { return SafeGetValue<System.String>("ApplicableType");}
set { this["ApplicableType"] = value;}
}

}
[Serializable]
public class msCustomSearchSpecification : msMetadataContainer {
public new const string CLASS_NAME = "CustomSearchSpecification";
public new  static class FIELDS {
public const string Metadata = "Metadata";
}
public msCustomSearchSpecification() : base() {
ClassType = "CustomSearchSpecification";
}
public msCustomSearchSpecification( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomSearchSpecification FromClassMetadata(ClassMetadata meta){return new msCustomSearchSpecification(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Metadata {
get { return SafeGetValue<System.String>("Metadata");}
set { this["Metadata"] = value;}
}

}
[Serializable]
public class msShippingCarrierAccount : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "ShippingCarrierAccount";
public new  static class FIELDS {
public const string Description = "Description";
public const string IsDefault = "IsDefault";
}
public msShippingCarrierAccount() : base() {
ClassType = "ShippingCarrierAccount";
}
public msShippingCarrierAccount( MemberSuiteObject msObj) : base(msObj) {}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Boolean IsDefault {
get { return SafeGetValue<System.Boolean>("IsDefault");}
set { this["IsDefault"] = value;}
}

}
[Serializable]
public class msFedexShippingCarrierAccount : msShippingCarrierAccount {
public new const string CLASS_NAME = "FedexShippingCarrierAccount";
public new  static class FIELDS {
}
public msFedexShippingCarrierAccount() : base() {
ClassType = "FedexShippingCarrierAccount";
}
public msFedexShippingCarrierAccount( MemberSuiteObject msObj) : base(msObj) {}
 public static new msFedexShippingCarrierAccount FromClassMetadata(ClassMetadata meta){return new msFedexShippingCarrierAccount(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msPortalOrderPaymentRule : msPortalPaymentRule {
public new const string CLASS_NAME = "PortalOrderPaymentRule";
public new  static class FIELDS {
public const string Products = "Products";
public const string ProductTypes = "ProductTypes";
public const string DiscountCode = "DiscountCode";
}
public msPortalOrderPaymentRule() : base() {
ClassType = "PortalOrderPaymentRule";
Products = new System.Collections.Generic.List<System.String>();
ProductTypes = new System.Collections.Generic.List<System.String>();
}
public msPortalOrderPaymentRule( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPortalOrderPaymentRule FromClassMetadata(ClassMetadata meta){return new msPortalOrderPaymentRule(MemberSuiteObject.FromClassMetadata(meta));}
public System.Collections.Generic.List<System.String> Products {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Products");}
set { this["Products"] = value;}
}

public System.Collections.Generic.List<System.String> ProductTypes {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("ProductTypes");}
set { this["ProductTypes"] = value;}
}

public System.String DiscountCode {
get { return SafeGetValue<System.String>("DiscountCode");}
set { this["DiscountCode"] = value;}
}

}
[Serializable]
public class msRealtorSubscription : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "RealtorSubscription";
public new  static class FIELDS {
public const string SavedPaymentMethod = "SavedPaymentMethod";
public const string BilledThru = "BilledThru";
public const string RemindedThru = "RemindedThru";
public const string ExpirationDate = "ExpirationDate";
public const string TerminationDate = "TerminationDate";
public const string TerminationReason = "TerminationReason";
public const string Owner = "Owner";
public const string BillTo = "BillTo";
public const string Fee = "Fee";
public const string DoNotRenew = "DoNotRenew";
public const string AutomaticallyPayForRenewal = "AutomaticallyPayForRenewal";
public const string Notes = "Notes";
public const string Membership = "Membership";
public const string AuthorizedAgents = "AuthorizedAgents";
public const string StartDate = "StartDate";
public const string IsActive = "IsActive";
public const string ParentSubscription = "ParentSubscription";
public const string Type = "Type";
}
public msRealtorSubscription() : base() {
ClassType = "RealtorSubscription";
AuthorizedAgents = new System.Collections.Generic.List<msAuthorizedSubscriptionAgent>();
}
public msRealtorSubscription( MemberSuiteObject msObj) : base(msObj) {}
public System.String SavedPaymentMethod {
get { return SafeGetValue<System.String>("SavedPaymentMethod");}
set { this["SavedPaymentMethod"] = value;}
}

public System.DateTime? BilledThru {
get { return SafeGetValue<System.DateTime?>("BilledThru");}
set { this["BilledThru"] = value;}
}

public System.DateTime? RemindedThru {
get { return SafeGetValue<System.DateTime?>("RemindedThru");}
set { this["RemindedThru"] = value;}
}

public System.DateTime? ExpirationDate {
get { return SafeGetValue<System.DateTime?>("ExpirationDate");}
set { this["ExpirationDate"] = value;}
}

public System.DateTime? TerminationDate {
get { return SafeGetValue<System.DateTime?>("TerminationDate");}
set { this["TerminationDate"] = value;}
}

public System.String TerminationReason {
get { return SafeGetValue<System.String>("TerminationReason");}
set { this["TerminationReason"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String BillTo {
get { return SafeGetValue<System.String>("BillTo");}
set { this["BillTo"] = value;}
}

public System.String Fee {
get { return SafeGetValue<System.String>("Fee");}
set { this["Fee"] = value;}
}

public System.Boolean DoNotRenew {
get { return SafeGetValue<System.Boolean>("DoNotRenew");}
set { this["DoNotRenew"] = value;}
}

public System.Boolean AutomaticallyPayForRenewal {
get { return SafeGetValue<System.Boolean>("AutomaticallyPayForRenewal");}
set { this["AutomaticallyPayForRenewal"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.String Membership {
get { return SafeGetValue<System.String>("Membership");}
set { this["Membership"] = value;}
}

public System.Collections.Generic.List<msAuthorizedSubscriptionAgent> AuthorizedAgents {
get { return SafeGetValue<System.Collections.Generic.List<msAuthorizedSubscriptionAgent>>("AuthorizedAgents");}
set { this["AuthorizedAgents"] = value;}
}

public System.DateTime StartDate {
get { return SafeGetValue<System.DateTime>("StartDate");}
set { this["StartDate"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.String ParentSubscription {
get { return SafeGetValue<System.String>("ParentSubscription");}
set { this["ParentSubscription"] = value;}
}

public MemberSuite.SDK.Types.RealtorSubscriptionType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.RealtorSubscriptionType>("Type");}
set { this["Type"] = value;}
}

}
[Serializable]
public class msCooperativeKeySubscription : msRealtorSubscription {
public new const string CLASS_NAME = "CooperativeKeySubscription";
public new  static class FIELDS {
}
public msCooperativeKeySubscription() : base() {
ClassType = "CooperativeKeySubscription";
AuthorizedAgents = new System.Collections.Generic.List<msAuthorizedSubscriptionAgent>();
}
public msCooperativeKeySubscription( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCooperativeKeySubscription FromClassMetadata(ClassMetadata meta){return new msCooperativeKeySubscription(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msNRDSRecord : msAssociationDomainObject {
public new const string CLASS_NAME = "NRDSRecord";
public new  static class FIELDS {
public const string NRDSAssociationId = "NRDSAssociationId";
}
public msNRDSRecord() : base() {
ClassType = "NRDSRecord";
}
public msNRDSRecord( MemberSuiteObject msObj) : base(msObj) {}
public System.Int32 NRDSAssociationId {
get { return SafeGetValue<System.Int32>("NRDSAssociationId");}
set { this["NRDSAssociationId"] = value;}
}

}
[Serializable]
public class msNRDSMemberRelatedRecord : msNRDSRecord {
public new const string CLASS_NAME = "NRDSMemberRelatedRecord";
public new  static class FIELDS {
public const string NRDSAssociation = "NRDSAssociation";
public const string MemberID = "MemberID";
}
public msNRDSMemberRelatedRecord() : base() {
ClassType = "NRDSMemberRelatedRecord";
}
public msNRDSMemberRelatedRecord( MemberSuiteObject msObj) : base(msObj) {}
public System.String NRDSAssociation {
get { return SafeGetValue<System.String>("NRDSAssociation");}
set { this["NRDSAssociation"] = value;}
}

public System.Int32 MemberID {
get { return SafeGetValue<System.Int32>("MemberID");}
set { this["MemberID"] = value;}
}

}
[Serializable]
public class msPhysicalKeyInsurancePolicy : msRealtorSubscription {
public new const string CLASS_NAME = "PhysicalKeyInsurancePolicy";
public new  static class FIELDS {
public const string Subscription = "Subscription";
}
public msPhysicalKeyInsurancePolicy() : base() {
ClassType = "PhysicalKeyInsurancePolicy";
AuthorizedAgents = new System.Collections.Generic.List<msAuthorizedSubscriptionAgent>();
}
public msPhysicalKeyInsurancePolicy( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPhysicalKeyInsurancePolicy FromClassMetadata(ClassMetadata meta){return new msPhysicalKeyInsurancePolicy(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Subscription {
get { return SafeGetValue<System.String>("Subscription");}
set { this["Subscription"] = value;}
}

}
[Serializable]
public class msPhysicalKeySubscription : msRealtorSubscription {
public new const string CLASS_NAME = "PhysicalKeySubscription";
public new  static class FIELDS {
}
public msPhysicalKeySubscription() : base() {
ClassType = "PhysicalKeySubscription";
AuthorizedAgents = new System.Collections.Generic.List<msAuthorizedSubscriptionAgent>();
}
public msPhysicalKeySubscription( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPhysicalKeySubscription FromClassMetadata(ClassMetadata meta){return new msPhysicalKeySubscription(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msElectronicKeyProvider : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "ElectronicKeyProvider";
public new  static class FIELDS {
public const string Type = "Type";
public const string TermsOfService = "TermsOfService";
}
public msElectronicKeyProvider() : base() {
ClassType = "ElectronicKeyProvider";
}
public msElectronicKeyProvider( MemberSuiteObject msObj) : base(msObj) {}
 public static new msElectronicKeyProvider FromClassMetadata(ClassMetadata meta){return new msElectronicKeyProvider(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.eKeyProviderType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.eKeyProviderType>("Type");}
set { this["Type"] = value;}
}

public System.String TermsOfService {
get { return SafeGetValue<System.String>("TermsOfService");}
set { this["TermsOfService"] = value;}
}

}
[Serializable]
public class msElectronicKeySubscriptionTermsOfServiceAgreement : msTermsOfServiceAgreement {
public new const string CLASS_NAME = "ElectronicKeySubscriptionTermsOfServiceAgreement";
public new  static class FIELDS {
public const string Subscription = "Subscription";
}
public msElectronicKeySubscriptionTermsOfServiceAgreement() : base() {
ClassType = "ElectronicKeySubscriptionTermsOfServiceAgreement";
}
public msElectronicKeySubscriptionTermsOfServiceAgreement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msElectronicKeySubscriptionTermsOfServiceAgreement FromClassMetadata(ClassMetadata meta){return new msElectronicKeySubscriptionTermsOfServiceAgreement(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Subscription {
get { return SafeGetValue<System.String>("Subscription");}
set { this["Subscription"] = value;}
}

}
[Serializable]
public class msElectronicKeySubscription : msRealtorSubscription {
public new const string CLASS_NAME = "ElectronicKeySubscription";
public new  static class FIELDS {
public const string KeyProvider = "KeyProvider";
}
public msElectronicKeySubscription() : base() {
ClassType = "ElectronicKeySubscription";
AuthorizedAgents = new System.Collections.Generic.List<msAuthorizedSubscriptionAgent>();
}
public msElectronicKeySubscription( MemberSuiteObject msObj) : base(msObj) {}
 public static new msElectronicKeySubscription FromClassMetadata(ClassMetadata meta){return new msElectronicKeySubscription(MemberSuiteObject.FromClassMetadata(meta));}
public System.String KeyProvider {
get { return SafeGetValue<System.String>("KeyProvider");}
set { this["KeyProvider"] = value;}
}

}
[Serializable]
public class msListingSubscription : msRealtorSubscription {
public new const string CLASS_NAME = "ListingSubscription";
public new  static class FIELDS {
public const string Provider = "Provider";
}
public msListingSubscription() : base() {
ClassType = "ListingSubscription";
AuthorizedAgents = new System.Collections.Generic.List<msAuthorizedSubscriptionAgent>();
}
public msListingSubscription( MemberSuiteObject msObj) : base(msObj) {}
 public static new msListingSubscription FromClassMetadata(ClassMetadata meta){return new msListingSubscription(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Provider {
get { return SafeGetValue<System.String>("Provider");}
set { this["Provider"] = value;}
}

}
[Serializable]
public class msListingSubscriptionProvider : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "ListingSubscriptionProvider";
public new  static class FIELDS {
public const string Type = "Type";
}
public msListingSubscriptionProvider() : base() {
ClassType = "ListingSubscriptionProvider";
}
public msListingSubscriptionProvider( MemberSuiteObject msObj) : base(msObj) {}
 public static new msListingSubscriptionProvider FromClassMetadata(ClassMetadata meta){return new msListingSubscriptionProvider(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.ListingSubscriptionProviderType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.ListingSubscriptionProviderType>("Type");}
set { this["Type"] = value;}
}

}
[Serializable]
public class msNRDSAssociationRecord : msNRDSRecord {
public new const string CLASS_NAME = "NRDSAssociationRecord";
public new  static class FIELDS {
public const string AssociationType = "AssociationType";
public const string AssociationName = "AssociationName";
public const string AssociationStreetAddress_Street1 = "AssociationStreetAddress_Street1";
public const string AssociationStreetAddress_Street2 = "AssociationStreetAddress_Street2";
public const string AssociationStreetAddress_City = "AssociationStreetAddress_City";
public const string AssociationStreetAddress_State = "AssociationStreetAddress_State";
public const string AssociationStreetAddress_Zip = "AssociationStreetAddress_Zip";
public const string AssociationStreetAddress_Zip6 = "AssociationStreetAddress_Zip6";
public const string AssociationMailAddress_Street1 = "AssociationMailAddress_Street1";
public const string AssociationMailAddress_Street2 = "AssociationMailAddress_Street2";
public const string AssociationMailAddress_City = "AssociationMailAddress_City";
public const string AssociationMailAddress_State = "AssociationMailAddress_State";
public const string AssociationMailAddress_Zip = "AssociationMailAddress_Zip";
public const string AssociationMailAddress_Zip6 = "AssociationMailAddress_Zip6";
public const string AssociationPhone_Area = "AssociationPhone_Area";
public const string AssociationPhone_Number = "AssociationPhone_Number";
public const string AssociationFax_Area = "AssociationFax_Area";
public const string AssociationFax_Number = "AssociationFax_Number";
public const string AssociationExecutiveOfficerId = "AssociationExecutiveOfficerId";
public const string AssociationEOFax_Area = "AssociationEOFax_Area";
public const string AssociationEOFax_Number = "AssociationEOFax_Number";
public const string PointOfEntry = "PointOfEntry";
public const string WebPage = "WebPage";
public const string EMail = "EMail";
public const string AssociationStatus = "AssociationStatus";
public const string AssociationDateStatusChanged = "AssociationDateStatusChanged";
public const string AssociationPrimaryStateId = "AssociationPrimaryStateId";
public const string AssociationSecondaryState1 = "AssociationSecondaryState1";
public const string AssociationSecondaryState2 = "AssociationSecondaryState2";
public const string AssociationSecondaryState3 = "AssociationSecondaryState3";
public const string AssociationLastCertificationDate = "AssociationLastCertificationDate";
public const string AssociationCurrentLeadership_PresidentId = "AssociationCurrentLeadership_PresidentId";
public const string AssociationCurrentLeadership_PresidentElectId = "AssociationCurrentLeadership_PresidentElectId";
public const string AssociationCurrentLeadership_SecretaryId = "AssociationCurrentLeadership_SecretaryId";
public const string AssociationCurrentLeadership_TreasurerId = "AssociationCurrentLeadership_TreasurerId";
public const string AssociationFutureLeadership_PresidentId = "AssociationFutureLeadership_PresidentId";
public const string AssociationFutureLeadership_PresidentElectId = "AssociationFutureLeadership_PresidentElectId";
public const string AssociationFutureLeadership_SecretaryId = "AssociationFutureLeadership_SecretaryId";
public const string AssociationFutureLeadership_TreasurerId = "AssociationFutureLeadership_TreasurerId";
public const string AssociationPriorLeadership_PresidentId = "AssociationPriorLeadership_PresidentId";
public const string AssociationPriorLeadership_PresidentElectId = "AssociationPriorLeadership_PresidentElectId";
public const string AssociationPriorLeadership_SecretaryId = "AssociationPriorLeadership_SecretaryId";
public const string AssociationPriorLeadership_TreasurerId = "AssociationPriorLeadership_TreasurerId";
public const string ElectionMonth = "ElectionMonth";
}
public msNRDSAssociationRecord() : base() {
ClassType = "NRDSAssociationRecord";
}
public msNRDSAssociationRecord( MemberSuiteObject msObj) : base(msObj) {}
 public static new msNRDSAssociationRecord FromClassMetadata(ClassMetadata meta){return new msNRDSAssociationRecord(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.NRDSAssociationType AssociationType {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSAssociationType>("AssociationType");}
set { this["AssociationType"] = value;}
}

public System.String AssociationName {
get { return SafeGetValue<System.String>("AssociationName");}
set { this["AssociationName"] = value;}
}

public System.String AssociationStreetAddress_Street1 {
get { return SafeGetValue<System.String>("AssociationStreetAddress_Street1");}
set { this["AssociationStreetAddress_Street1"] = value;}
}

public System.String AssociationStreetAddress_Street2 {
get { return SafeGetValue<System.String>("AssociationStreetAddress_Street2");}
set { this["AssociationStreetAddress_Street2"] = value;}
}

public System.String AssociationStreetAddress_City {
get { return SafeGetValue<System.String>("AssociationStreetAddress_City");}
set { this["AssociationStreetAddress_City"] = value;}
}

public System.String AssociationStreetAddress_State {
get { return SafeGetValue<System.String>("AssociationStreetAddress_State");}
set { this["AssociationStreetAddress_State"] = value;}
}

public System.String AssociationStreetAddress_Zip {
get { return SafeGetValue<System.String>("AssociationStreetAddress_Zip");}
set { this["AssociationStreetAddress_Zip"] = value;}
}

public System.String AssociationStreetAddress_Zip6 {
get { return SafeGetValue<System.String>("AssociationStreetAddress_Zip6");}
set { this["AssociationStreetAddress_Zip6"] = value;}
}

public System.String AssociationMailAddress_Street1 {
get { return SafeGetValue<System.String>("AssociationMailAddress_Street1");}
set { this["AssociationMailAddress_Street1"] = value;}
}

public System.String AssociationMailAddress_Street2 {
get { return SafeGetValue<System.String>("AssociationMailAddress_Street2");}
set { this["AssociationMailAddress_Street2"] = value;}
}

public System.String AssociationMailAddress_City {
get { return SafeGetValue<System.String>("AssociationMailAddress_City");}
set { this["AssociationMailAddress_City"] = value;}
}

public System.String AssociationMailAddress_State {
get { return SafeGetValue<System.String>("AssociationMailAddress_State");}
set { this["AssociationMailAddress_State"] = value;}
}

public System.String AssociationMailAddress_Zip {
get { return SafeGetValue<System.String>("AssociationMailAddress_Zip");}
set { this["AssociationMailAddress_Zip"] = value;}
}

public System.String AssociationMailAddress_Zip6 {
get { return SafeGetValue<System.String>("AssociationMailAddress_Zip6");}
set { this["AssociationMailAddress_Zip6"] = value;}
}

public System.Int32? AssociationPhone_Area {
get { return SafeGetValue<System.Int32?>("AssociationPhone_Area");}
set { this["AssociationPhone_Area"] = value;}
}

public System.Int32? AssociationPhone_Number {
get { return SafeGetValue<System.Int32?>("AssociationPhone_Number");}
set { this["AssociationPhone_Number"] = value;}
}

public System.Int32? AssociationFax_Area {
get { return SafeGetValue<System.Int32?>("AssociationFax_Area");}
set { this["AssociationFax_Area"] = value;}
}

public System.Int32? AssociationFax_Number {
get { return SafeGetValue<System.Int32?>("AssociationFax_Number");}
set { this["AssociationFax_Number"] = value;}
}

public System.Int32? AssociationExecutiveOfficerId {
get { return SafeGetValue<System.Int32?>("AssociationExecutiveOfficerId");}
set { this["AssociationExecutiveOfficerId"] = value;}
}

public System.Int32? AssociationEOFax_Area {
get { return SafeGetValue<System.Int32?>("AssociationEOFax_Area");}
set { this["AssociationEOFax_Area"] = value;}
}

public System.Int32? AssociationEOFax_Number {
get { return SafeGetValue<System.Int32?>("AssociationEOFax_Number");}
set { this["AssociationEOFax_Number"] = value;}
}

public System.Int32? PointOfEntry {
get { return SafeGetValue<System.Int32?>("PointOfEntry");}
set { this["PointOfEntry"] = value;}
}

public System.String WebPage {
get { return SafeGetValue<System.String>("WebPage");}
set { this["WebPage"] = value;}
}

public System.String EMail {
get { return SafeGetValue<System.String>("EMail");}
set { this["EMail"] = value;}
}

public MemberSuite.SDK.Types.NRDSAssociationStatus AssociationStatus {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSAssociationStatus>("AssociationStatus");}
set { this["AssociationStatus"] = value;}
}

public System.DateTime? AssociationDateStatusChanged {
get { return SafeGetValue<System.DateTime?>("AssociationDateStatusChanged");}
set { this["AssociationDateStatusChanged"] = value;}
}

public System.Int32? AssociationPrimaryStateId {
get { return SafeGetValue<System.Int32?>("AssociationPrimaryStateId");}
set { this["AssociationPrimaryStateId"] = value;}
}

public System.String AssociationSecondaryState1 {
get { return SafeGetValue<System.String>("AssociationSecondaryState1");}
set { this["AssociationSecondaryState1"] = value;}
}

public System.String AssociationSecondaryState2 {
get { return SafeGetValue<System.String>("AssociationSecondaryState2");}
set { this["AssociationSecondaryState2"] = value;}
}

public System.String AssociationSecondaryState3 {
get { return SafeGetValue<System.String>("AssociationSecondaryState3");}
set { this["AssociationSecondaryState3"] = value;}
}

public System.DateTime? AssociationLastCertificationDate {
get { return SafeGetValue<System.DateTime?>("AssociationLastCertificationDate");}
set { this["AssociationLastCertificationDate"] = value;}
}

public System.Int32? AssociationCurrentLeadership_PresidentId {
get { return SafeGetValue<System.Int32?>("AssociationCurrentLeadership_PresidentId");}
set { this["AssociationCurrentLeadership_PresidentId"] = value;}
}

public System.Int32? AssociationCurrentLeadership_PresidentElectId {
get { return SafeGetValue<System.Int32?>("AssociationCurrentLeadership_PresidentElectId");}
set { this["AssociationCurrentLeadership_PresidentElectId"] = value;}
}

public System.Int32? AssociationCurrentLeadership_SecretaryId {
get { return SafeGetValue<System.Int32?>("AssociationCurrentLeadership_SecretaryId");}
set { this["AssociationCurrentLeadership_SecretaryId"] = value;}
}

public System.Int32? AssociationCurrentLeadership_TreasurerId {
get { return SafeGetValue<System.Int32?>("AssociationCurrentLeadership_TreasurerId");}
set { this["AssociationCurrentLeadership_TreasurerId"] = value;}
}

public System.Int32? AssociationFutureLeadership_PresidentId {
get { return SafeGetValue<System.Int32?>("AssociationFutureLeadership_PresidentId");}
set { this["AssociationFutureLeadership_PresidentId"] = value;}
}

public System.Int32? AssociationFutureLeadership_PresidentElectId {
get { return SafeGetValue<System.Int32?>("AssociationFutureLeadership_PresidentElectId");}
set { this["AssociationFutureLeadership_PresidentElectId"] = value;}
}

public System.Int32? AssociationFutureLeadership_SecretaryId {
get { return SafeGetValue<System.Int32?>("AssociationFutureLeadership_SecretaryId");}
set { this["AssociationFutureLeadership_SecretaryId"] = value;}
}

public System.Int32? AssociationFutureLeadership_TreasurerId {
get { return SafeGetValue<System.Int32?>("AssociationFutureLeadership_TreasurerId");}
set { this["AssociationFutureLeadership_TreasurerId"] = value;}
}

public System.Int32? AssociationPriorLeadership_PresidentId {
get { return SafeGetValue<System.Int32?>("AssociationPriorLeadership_PresidentId");}
set { this["AssociationPriorLeadership_PresidentId"] = value;}
}

public System.Int32? AssociationPriorLeadership_PresidentElectId {
get { return SafeGetValue<System.Int32?>("AssociationPriorLeadership_PresidentElectId");}
set { this["AssociationPriorLeadership_PresidentElectId"] = value;}
}

public System.Int32? AssociationPriorLeadership_SecretaryId {
get { return SafeGetValue<System.Int32?>("AssociationPriorLeadership_SecretaryId");}
set { this["AssociationPriorLeadership_SecretaryId"] = value;}
}

public System.Int32? AssociationPriorLeadership_TreasurerId {
get { return SafeGetValue<System.Int32?>("AssociationPriorLeadership_TreasurerId");}
set { this["AssociationPriorLeadership_TreasurerId"] = value;}
}

public System.Int32? ElectionMonth {
get { return SafeGetValue<System.Int32?>("ElectionMonth");}
set { this["ElectionMonth"] = value;}
}

}
[Serializable]
public class msNRDSDemographicRecord : msNRDSMemberRelatedRecord {
public new const string CLASS_NAME = "NRDSDemographicRecord";
public new  static class FIELDS {
public const string Member = "Member";
public const string DemographicCategory = "DemographicCategory";
public const string GroupCode = "GroupCode";
public const string DemographicComment = "DemographicComment";
public const string DemographicStatus = "DemographicStatus";
public const string DemographicStatusDate = "DemographicStatusDate";
public const string DemographicAmount = "DemographicAmount";
public const string DemographicNumber = "DemographicNumber";
public const string PointOfEntry = "PointOfEntry";
public const string PaymentCode = "PaymentCode";
}
public msNRDSDemographicRecord() : base() {
ClassType = "NRDSDemographicRecord";
}
public msNRDSDemographicRecord( MemberSuiteObject msObj) : base(msObj) {}
 public static new msNRDSDemographicRecord FromClassMetadata(ClassMetadata meta){return new msNRDSDemographicRecord(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Member {
get { return SafeGetValue<System.String>("Member");}
set { this["Member"] = value;}
}

public System.String DemographicCategory {
get { return SafeGetValue<System.String>("DemographicCategory");}
set { this["DemographicCategory"] = value;}
}

public System.String GroupCode {
get { return SafeGetValue<System.String>("GroupCode");}
set { this["GroupCode"] = value;}
}

public System.String DemographicComment {
get { return SafeGetValue<System.String>("DemographicComment");}
set { this["DemographicComment"] = value;}
}

public System.String DemographicStatus {
get { return SafeGetValue<System.String>("DemographicStatus");}
set { this["DemographicStatus"] = value;}
}

public System.DateTime? DemographicStatusDate {
get { return SafeGetValue<System.DateTime?>("DemographicStatusDate");}
set { this["DemographicStatusDate"] = value;}
}

public System.Decimal? DemographicAmount {
get { return SafeGetValue<System.Decimal?>("DemographicAmount");}
set { this["DemographicAmount"] = value;}
}

public System.Int32? DemographicNumber {
get { return SafeGetValue<System.Int32?>("DemographicNumber");}
set { this["DemographicNumber"] = value;}
}

public System.Int32? PointOfEntry {
get { return SafeGetValue<System.Int32?>("PointOfEntry");}
set { this["PointOfEntry"] = value;}
}

public MemberSuite.SDK.Types.NRDSDemographicPaymentCodeType PaymentCode {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSDemographicPaymentCodeType>("PaymentCode");}
set { this["PaymentCode"] = value;}
}

}
[Serializable]
public class msNRDSEducationRecord : msNRDSMemberRelatedRecord {
public new const string CLASS_NAME = "NRDSEducationRecord";
public new  static class FIELDS {
public const string Member = "Member";
public const string EducationCertificateName = "EducationCertificateName";
public const string GroupCode = "GroupCode";
public const string EducationCourseCode = "EducationCourseCode";
public const string EducationCourseNumber = "EducationCourseNumber";
public const string EducationCourseDescription = "EducationCourseDescription";
public const string EducationDesignationCreditHours = "EducationDesignationCreditHours";
public const string EducationStateCEHours = "EducationStateCEHours";
public const string EducationTotalHoursEarnedToDate = "EducationTotalHoursEarnedToDate";
public const string EducationCourseStartDate = "EducationCourseStartDate";
public const string EducationCourseCompletionDate = "EducationCourseCompletionDate";
public const string EducationSponsoringAssociationId = "EducationSponsoringAssociationId";
public const string EducationHostingAssociationId = "EducationHostingAssociationId";
public const string EducationInstructor1_EducationInstructorName = "EducationInstructor1_EducationInstructorName";
public const string EducationInstructor1_EducationInstructorStateLicense = "EducationInstructor1_EducationInstructorStateLicense";
public const string EducationInstructor2_EducationInstructorName = "EducationInstructor2_EducationInstructorName";
public const string EducationInstructor2_EducationInstructorStateLicense = "EducationInstructor2_EducationInstructorStateLicense";
public const string EducationDeliveryMethod = "EducationDeliveryMethod";
public const string EducationTestScore = "EducationTestScore";
public const string EducationTestStatus = "EducationTestStatus";
public const string EducationTestScoreDateChange = "EducationTestScoreDateChange";
public const string EducationTestScoreOperator = "EducationTestScoreOperator";
public const string EducationTestMailingAddress = "EducationTestMailingAddress";
public const string EducationDateSentToStateAgency = "EducationDateSentToStateAgency";
public const string EducationStateAgencyCourseCode = "EducationStateAgencyCourseCode";
public const string EducationDateSentToLocalAssociation = "EducationDateSentToLocalAssociation";
public const string EducationDateSentToStateAssociation = "EducationDateSentToStateAssociation";
public const string EducationDateSentToNARISC = "EducationDateSentToNARISC";
public const string EducationComments = "EducationComments";
public const string PaymentCode = "PaymentCode";
public const string EducationPaymentAmount = "EducationPaymentAmount";
public const string PointOfEntry = "PointOfEntry";
}
public msNRDSEducationRecord() : base() {
ClassType = "NRDSEducationRecord";
}
public msNRDSEducationRecord( MemberSuiteObject msObj) : base(msObj) {}
 public static new msNRDSEducationRecord FromClassMetadata(ClassMetadata meta){return new msNRDSEducationRecord(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Member {
get { return SafeGetValue<System.String>("Member");}
set { this["Member"] = value;}
}

public System.String EducationCertificateName {
get { return SafeGetValue<System.String>("EducationCertificateName");}
set { this["EducationCertificateName"] = value;}
}

public System.String GroupCode {
get { return SafeGetValue<System.String>("GroupCode");}
set { this["GroupCode"] = value;}
}

public System.String EducationCourseCode {
get { return SafeGetValue<System.String>("EducationCourseCode");}
set { this["EducationCourseCode"] = value;}
}

public System.String EducationCourseNumber {
get { return SafeGetValue<System.String>("EducationCourseNumber");}
set { this["EducationCourseNumber"] = value;}
}

public System.String EducationCourseDescription {
get { return SafeGetValue<System.String>("EducationCourseDescription");}
set { this["EducationCourseDescription"] = value;}
}

public System.Double? EducationDesignationCreditHours {
get { return SafeGetValue<System.Double?>("EducationDesignationCreditHours");}
set { this["EducationDesignationCreditHours"] = value;}
}

public System.Double? EducationStateCEHours {
get { return SafeGetValue<System.Double?>("EducationStateCEHours");}
set { this["EducationStateCEHours"] = value;}
}

public System.Double? EducationTotalHoursEarnedToDate {
get { return SafeGetValue<System.Double?>("EducationTotalHoursEarnedToDate");}
set { this["EducationTotalHoursEarnedToDate"] = value;}
}

public System.DateTime? EducationCourseStartDate {
get { return SafeGetValue<System.DateTime?>("EducationCourseStartDate");}
set { this["EducationCourseStartDate"] = value;}
}

public System.DateTime? EducationCourseCompletionDate {
get { return SafeGetValue<System.DateTime?>("EducationCourseCompletionDate");}
set { this["EducationCourseCompletionDate"] = value;}
}

public System.Int32? EducationSponsoringAssociationId {
get { return SafeGetValue<System.Int32?>("EducationSponsoringAssociationId");}
set { this["EducationSponsoringAssociationId"] = value;}
}

public System.Int32? EducationHostingAssociationId {
get { return SafeGetValue<System.Int32?>("EducationHostingAssociationId");}
set { this["EducationHostingAssociationId"] = value;}
}

public System.String EducationInstructor1_EducationInstructorName {
get { return SafeGetValue<System.String>("EducationInstructor1_EducationInstructorName");}
set { this["EducationInstructor1_EducationInstructorName"] = value;}
}

public System.String EducationInstructor1_EducationInstructorStateLicense {
get { return SafeGetValue<System.String>("EducationInstructor1_EducationInstructorStateLicense");}
set { this["EducationInstructor1_EducationInstructorStateLicense"] = value;}
}

public System.String EducationInstructor2_EducationInstructorName {
get { return SafeGetValue<System.String>("EducationInstructor2_EducationInstructorName");}
set { this["EducationInstructor2_EducationInstructorName"] = value;}
}

public System.String EducationInstructor2_EducationInstructorStateLicense {
get { return SafeGetValue<System.String>("EducationInstructor2_EducationInstructorStateLicense");}
set { this["EducationInstructor2_EducationInstructorStateLicense"] = value;}
}

public MemberSuite.SDK.Types.NRDSEducationDeliveryMethodType EducationDeliveryMethod {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSEducationDeliveryMethodType>("EducationDeliveryMethod");}
set { this["EducationDeliveryMethod"] = value;}
}

public System.Int32? EducationTestScore {
get { return SafeGetValue<System.Int32?>("EducationTestScore");}
set { this["EducationTestScore"] = value;}
}

public MemberSuite.SDK.Types.NRDSEducationTestStatus EducationTestStatus {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSEducationTestStatus>("EducationTestStatus");}
set { this["EducationTestStatus"] = value;}
}

public System.DateTime? EducationTestScoreDateChange {
get { return SafeGetValue<System.DateTime?>("EducationTestScoreDateChange");}
set { this["EducationTestScoreDateChange"] = value;}
}

public System.String EducationTestScoreOperator {
get { return SafeGetValue<System.String>("EducationTestScoreOperator");}
set { this["EducationTestScoreOperator"] = value;}
}

public MemberSuite.SDK.Types.NRDSEducationTestMailingAddressType EducationTestMailingAddress {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSEducationTestMailingAddressType>("EducationTestMailingAddress");}
set { this["EducationTestMailingAddress"] = value;}
}

public System.DateTime? EducationDateSentToStateAgency {
get { return SafeGetValue<System.DateTime?>("EducationDateSentToStateAgency");}
set { this["EducationDateSentToStateAgency"] = value;}
}

public System.String EducationStateAgencyCourseCode {
get { return SafeGetValue<System.String>("EducationStateAgencyCourseCode");}
set { this["EducationStateAgencyCourseCode"] = value;}
}

public System.DateTime? EducationDateSentToLocalAssociation {
get { return SafeGetValue<System.DateTime?>("EducationDateSentToLocalAssociation");}
set { this["EducationDateSentToLocalAssociation"] = value;}
}

public System.DateTime? EducationDateSentToStateAssociation {
get { return SafeGetValue<System.DateTime?>("EducationDateSentToStateAssociation");}
set { this["EducationDateSentToStateAssociation"] = value;}
}

public System.DateTime? EducationDateSentToNARISC {
get { return SafeGetValue<System.DateTime?>("EducationDateSentToNARISC");}
set { this["EducationDateSentToNARISC"] = value;}
}

public System.String EducationComments {
get { return SafeGetValue<System.String>("EducationComments");}
set { this["EducationComments"] = value;}
}

public MemberSuite.SDK.Types.NRDSEducationPaymentCodeType PaymentCode {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSEducationPaymentCodeType>("PaymentCode");}
set { this["PaymentCode"] = value;}
}

public System.Decimal? EducationPaymentAmount {
get { return SafeGetValue<System.Decimal?>("EducationPaymentAmount");}
set { this["EducationPaymentAmount"] = value;}
}

public System.Int32? PointOfEntry {
get { return SafeGetValue<System.Int32?>("PointOfEntry");}
set { this["PointOfEntry"] = value;}
}

}
[Serializable]
public class msNRDSFinancialRecord : msNRDSMemberRelatedRecord {
public new const string CLASS_NAME = "NRDSFinancialRecord";
public new  static class FIELDS {
public const string Member = "Member";
public const string FinancialIncurringMemberId = "FinancialIncurringMemberId";
public const string Office = "Office";
public const string OfficeID = "OfficeID";
public const string FinancialPaymentType = "FinancialPaymentType";
public const string FinancialBillingYear = "FinancialBillingYear";
public const string FinancialPaymentAmount = "FinancialPaymentAmount";
public const string FinancialContributionType = "FinancialContributionType";
public const string FinancialDuesPaidDate = "FinancialDuesPaidDate";
public const string MemberSSN = "MemberSSN";
public const string PointOfEntry = "PointOfEntry";
public const string FinancialSource = "FinancialSource";
public const string PrimaryAssociationId = "PrimaryAssociationId";
public const string FinancialECControlNumber = "FinancialECControlNumber";
}
public msNRDSFinancialRecord() : base() {
ClassType = "NRDSFinancialRecord";
}
public msNRDSFinancialRecord( MemberSuiteObject msObj) : base(msObj) {}
 public static new msNRDSFinancialRecord FromClassMetadata(ClassMetadata meta){return new msNRDSFinancialRecord(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Member {
get { return SafeGetValue<System.String>("Member");}
set { this["Member"] = value;}
}

public System.Int32? FinancialIncurringMemberId {
get { return SafeGetValue<System.Int32?>("FinancialIncurringMemberId");}
set { this["FinancialIncurringMemberId"] = value;}
}

public System.String Office {
get { return SafeGetValue<System.String>("Office");}
set { this["Office"] = value;}
}

public System.Int32? OfficeID {
get { return SafeGetValue<System.Int32?>("OfficeID");}
set { this["OfficeID"] = value;}
}

public System.String FinancialPaymentType {
get { return SafeGetValue<System.String>("FinancialPaymentType");}
set { this["FinancialPaymentType"] = value;}
}

public System.DateTime? FinancialBillingYear {
get { return SafeGetValue<System.DateTime?>("FinancialBillingYear");}
set { this["FinancialBillingYear"] = value;}
}

public System.Decimal? FinancialPaymentAmount {
get { return SafeGetValue<System.Decimal?>("FinancialPaymentAmount");}
set { this["FinancialPaymentAmount"] = value;}
}

public MemberSuite.SDK.Types.NRDSFinancialContributionType FinancialContributionType {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSFinancialContributionType>("FinancialContributionType");}
set { this["FinancialContributionType"] = value;}
}

public System.DateTime? FinancialDuesPaidDate {
get { return SafeGetValue<System.DateTime?>("FinancialDuesPaidDate");}
set { this["FinancialDuesPaidDate"] = value;}
}

public System.Int32? MemberSSN {
get { return SafeGetValue<System.Int32?>("MemberSSN");}
set { this["MemberSSN"] = value;}
}

public System.Int32? PointOfEntry {
get { return SafeGetValue<System.Int32?>("PointOfEntry");}
set { this["PointOfEntry"] = value;}
}

public MemberSuite.SDK.Types.NRDSFinancialSource FinancialSource {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSFinancialSource>("FinancialSource");}
set { this["FinancialSource"] = value;}
}

public System.Int32? PrimaryAssociationId {
get { return SafeGetValue<System.Int32?>("PrimaryAssociationId");}
set { this["PrimaryAssociationId"] = value;}
}

public System.String FinancialECControlNumber {
get { return SafeGetValue<System.String>("FinancialECControlNumber");}
set { this["FinancialECControlNumber"] = value;}
}

}
[Serializable]
public class msNRDSMemberRecord : msNRDSMemberRelatedRecord {
public new const string CLASS_NAME = "NRDSMemberRecord";
public new  static class FIELDS {
public const string Owner = "Owner";
public const string Office = "Office";
public const string OfficeId = "OfficeId";
public const string MemberPrimaryStateAssociationId = "MemberPrimaryStateAssociationId";
public const string MemberMLSAssociationId = "MemberMLSAssociationId";
public const string PrimaryIndicator = "PrimaryIndicator";
public const string MemberLastName = "MemberLastName";
public const string MemberFirstName = "MemberFirstName";
public const string MemberMiddleName = "MemberMiddleName";
public const string MemberGeneration = "MemberGeneration";
public const string MemberNickname = "MemberNickname";
public const string MemberTitle = "MemberTitle";
public const string MemberSalutation = "MemberSalutation";
public const string MemberGender = "MemberGender";
public const string MemberHomeAddress_Street1 = "MemberHomeAddress_Street1";
public const string MemberHomeAddress_Street2 = "MemberHomeAddress_Street2";
public const string MemberHomeAddress_City = "MemberHomeAddress_City";
public const string MemberHomeAddress_State = "MemberHomeAddress_State";
public const string MemberHomeAddress_Zip = "MemberHomeAddress_Zip";
public const string MemberHomeAddress_Zip6 = "MemberHomeAddress_Zip6";
public const string MemberMailAddress_Street1 = "MemberMailAddress_Street1";
public const string MemberMailAddress_Street2 = "MemberMailAddress_Street2";
public const string MemberMailAddress_City = "MemberMailAddress_City";
public const string MemberMailAddress_State = "MemberMailAddress_State";
public const string MemberMailAddress_Zip = "MemberMailAddress_Zip";
public const string MemberMailAddress_Zip6 = "MemberMailAddress_Zip6";
public const string MemberPreferredMail = "MemberPreferredMail";
public const string MemberPreferredPublication = "MemberPreferredPublication";
public const string HomePhone_Area = "HomePhone_Area";
public const string HomePhone_Number = "HomePhone_Number";
public const string MemberPersonalFax_Area = "MemberPersonalFax_Area";
public const string MemberPersonalFax_Number = "MemberPersonalFax_Number";
public const string MemberCellPhone_Area = "MemberCellPhone_Area";
public const string MemberCellPhone_Number = "MemberCellPhone_Number";
public const string MemberPager_Area = "MemberPager_Area";
public const string MemberPager_Number = "MemberPager_Number";
public const string MemberPreferredPhone = "MemberPreferredPhone";
public const string MemberPreferredFax = "MemberPreferredFax";
public const string MemberType = "MemberType";
public const string JoinedDate = "JoinedDate";
public const string MemberOrientationDate = "MemberOrientationDate";
public const string MemberStatus = "MemberStatus";
public const string MemberStatusDate = "MemberStatusDate";
public const string PreviousNonMemberFlag = "PreviousNonMemberFlag";
public const string DuesWaivedLocalFlag = "DuesWaivedLocalFlag";
public const string DuesWaivedStateFlag = "DuesWaivedStateFlag";
public const string DuesWaivedNationalFlag = "DuesWaivedNationalFlag";
public const string MemberSSN = "MemberSSN";
public const string MemberRELicense = "MemberRELicense";
public const string MemberBirthDate = "MemberBirthDate";
public const string MemberLocalJoinedDate = "MemberLocalJoinedDate";
public const string StopMailFlag = "StopMailFlag";
public const string JunkMailFlag = "JunkMailFlag";
public const string OnRosterFlag = "OnRosterFlag";
public const string MemberOnlineStatus = "MemberOnlineStatus";
public const string MemberOnlineStatusDate = "MemberOnlineStatusDate";
public const string MemberDesignation = "MemberDesignation";
public const string MemberPrimaryFieldOfBusiness = "MemberPrimaryFieldOfBusiness";
public const string MemberSecondaryFieldOfBusiness1 = "MemberSecondaryFieldOfBusiness1";
public const string MemberSecondaryFieldOfBusiness2 = "MemberSecondaryFieldOfBusiness2";
public const string MemberSecondaryFieldOfBusiness3 = "MemberSecondaryFieldOfBusiness3";
public const string MemberOccupationName = "MemberOccupationName";
public const string PointOfEntry = "PointOfEntry";
public const string WebPage = "WebPage";
public const string EMail = "EMail";
public const string MLSID = "MLSID";
public const string MemberArbitrationEthicsPending = "MemberArbitrationEthicsPending";
public const string StopFaxFlag = "StopFaxFlag";
public const string MemberOfficeVoiceExtension = "MemberOfficeVoiceExtension";
public const string MemberReinstatementCode = "MemberReinstatementCode";
public const string MemberReinstatementDate = "MemberReinstatementDate";
public const string MemberNationalDuesPaidDate = "MemberNationalDuesPaidDate";
public const string MemberStateDuesPaidDate = "MemberStateDuesPaidDate";
public const string MemberSubclass = "MemberSubclass";
public const string MemberDesignatedRealtor = "MemberDesignatedRealtor";
public const string StopEMailFlag = "StopEMailFlag";
public const string MemberNRDSInsertDate = "MemberNRDSInsertDate";
}
public msNRDSMemberRecord() : base() {
ClassType = "NRDSMemberRecord";
}
public msNRDSMemberRecord( MemberSuiteObject msObj) : base(msObj) {}
 public static new msNRDSMemberRecord FromClassMetadata(ClassMetadata meta){return new msNRDSMemberRecord(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String Office {
get { return SafeGetValue<System.String>("Office");}
set { this["Office"] = value;}
}

public System.Int32? OfficeId {
get { return SafeGetValue<System.Int32?>("OfficeId");}
set { this["OfficeId"] = value;}
}

public System.Int32? MemberPrimaryStateAssociationId {
get { return SafeGetValue<System.Int32?>("MemberPrimaryStateAssociationId");}
set { this["MemberPrimaryStateAssociationId"] = value;}
}

public System.Int32? MemberMLSAssociationId {
get { return SafeGetValue<System.Int32?>("MemberMLSAssociationId");}
set { this["MemberMLSAssociationId"] = value;}
}

public MemberSuite.SDK.Types.NRDSPrimaryIndicator PrimaryIndicator {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSPrimaryIndicator>("PrimaryIndicator");}
set { this["PrimaryIndicator"] = value;}
}

public System.String MemberLastName {
get { return SafeGetValue<System.String>("MemberLastName");}
set { this["MemberLastName"] = value;}
}

public System.String MemberFirstName {
get { return SafeGetValue<System.String>("MemberFirstName");}
set { this["MemberFirstName"] = value;}
}

public System.String MemberMiddleName {
get { return SafeGetValue<System.String>("MemberMiddleName");}
set { this["MemberMiddleName"] = value;}
}

public System.String MemberGeneration {
get { return SafeGetValue<System.String>("MemberGeneration");}
set { this["MemberGeneration"] = value;}
}

public System.String MemberNickname {
get { return SafeGetValue<System.String>("MemberNickname");}
set { this["MemberNickname"] = value;}
}

public System.String MemberTitle {
get { return SafeGetValue<System.String>("MemberTitle");}
set { this["MemberTitle"] = value;}
}

public System.String MemberSalutation {
get { return SafeGetValue<System.String>("MemberSalutation");}
set { this["MemberSalutation"] = value;}
}

public MemberSuite.SDK.Types.NRDSMemberGender MemberGender {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSMemberGender>("MemberGender");}
set { this["MemberGender"] = value;}
}

public System.String MemberHomeAddress_Street1 {
get { return SafeGetValue<System.String>("MemberHomeAddress_Street1");}
set { this["MemberHomeAddress_Street1"] = value;}
}

public System.String MemberHomeAddress_Street2 {
get { return SafeGetValue<System.String>("MemberHomeAddress_Street2");}
set { this["MemberHomeAddress_Street2"] = value;}
}

public System.String MemberHomeAddress_City {
get { return SafeGetValue<System.String>("MemberHomeAddress_City");}
set { this["MemberHomeAddress_City"] = value;}
}

public System.String MemberHomeAddress_State {
get { return SafeGetValue<System.String>("MemberHomeAddress_State");}
set { this["MemberHomeAddress_State"] = value;}
}

public System.String MemberHomeAddress_Zip {
get { return SafeGetValue<System.String>("MemberHomeAddress_Zip");}
set { this["MemberHomeAddress_Zip"] = value;}
}

public System.String MemberHomeAddress_Zip6 {
get { return SafeGetValue<System.String>("MemberHomeAddress_Zip6");}
set { this["MemberHomeAddress_Zip6"] = value;}
}

public System.String MemberMailAddress_Street1 {
get { return SafeGetValue<System.String>("MemberMailAddress_Street1");}
set { this["MemberMailAddress_Street1"] = value;}
}

public System.String MemberMailAddress_Street2 {
get { return SafeGetValue<System.String>("MemberMailAddress_Street2");}
set { this["MemberMailAddress_Street2"] = value;}
}

public System.String MemberMailAddress_City {
get { return SafeGetValue<System.String>("MemberMailAddress_City");}
set { this["MemberMailAddress_City"] = value;}
}

public System.String MemberMailAddress_State {
get { return SafeGetValue<System.String>("MemberMailAddress_State");}
set { this["MemberMailAddress_State"] = value;}
}

public System.String MemberMailAddress_Zip {
get { return SafeGetValue<System.String>("MemberMailAddress_Zip");}
set { this["MemberMailAddress_Zip"] = value;}
}

public System.String MemberMailAddress_Zip6 {
get { return SafeGetValue<System.String>("MemberMailAddress_Zip6");}
set { this["MemberMailAddress_Zip6"] = value;}
}

public MemberSuite.SDK.Types.NRDSMemberAddressType MemberPreferredMail {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSMemberAddressType>("MemberPreferredMail");}
set { this["MemberPreferredMail"] = value;}
}

public MemberSuite.SDK.Types.NRDSMemberAddressType MemberPreferredPublication {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSMemberAddressType>("MemberPreferredPublication");}
set { this["MemberPreferredPublication"] = value;}
}

public System.Int32? HomePhone_Area {
get { return SafeGetValue<System.Int32?>("HomePhone_Area");}
set { this["HomePhone_Area"] = value;}
}

public System.Int32? HomePhone_Number {
get { return SafeGetValue<System.Int32?>("HomePhone_Number");}
set { this["HomePhone_Number"] = value;}
}

public System.Int32? MemberPersonalFax_Area {
get { return SafeGetValue<System.Int32?>("MemberPersonalFax_Area");}
set { this["MemberPersonalFax_Area"] = value;}
}

public System.Int32? MemberPersonalFax_Number {
get { return SafeGetValue<System.Int32?>("MemberPersonalFax_Number");}
set { this["MemberPersonalFax_Number"] = value;}
}

public System.Int32? MemberCellPhone_Area {
get { return SafeGetValue<System.Int32?>("MemberCellPhone_Area");}
set { this["MemberCellPhone_Area"] = value;}
}

public System.Int32? MemberCellPhone_Number {
get { return SafeGetValue<System.Int32?>("MemberCellPhone_Number");}
set { this["MemberCellPhone_Number"] = value;}
}

public System.Int32? MemberPager_Area {
get { return SafeGetValue<System.Int32?>("MemberPager_Area");}
set { this["MemberPager_Area"] = value;}
}

public System.Int32? MemberPager_Number {
get { return SafeGetValue<System.Int32?>("MemberPager_Number");}
set { this["MemberPager_Number"] = value;}
}

public MemberSuite.SDK.Types.NRDSMemberPreferredPhone MemberPreferredPhone {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSMemberPreferredPhone>("MemberPreferredPhone");}
set { this["MemberPreferredPhone"] = value;}
}

public MemberSuite.SDK.Types.NRDSMemberPreferredFax MemberPreferredFax {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSMemberPreferredFax>("MemberPreferredFax");}
set { this["MemberPreferredFax"] = value;}
}

public MemberSuite.SDK.Types.NRDSMemberType MemberType {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSMemberType>("MemberType");}
set { this["MemberType"] = value;}
}

public System.DateTime? JoinedDate {
get { return SafeGetValue<System.DateTime?>("JoinedDate");}
set { this["JoinedDate"] = value;}
}

public System.DateTime? MemberOrientationDate {
get { return SafeGetValue<System.DateTime?>("MemberOrientationDate");}
set { this["MemberOrientationDate"] = value;}
}

public MemberSuite.SDK.Types.NRDSMemberStatus MemberStatus {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSMemberStatus>("MemberStatus");}
set { this["MemberStatus"] = value;}
}

public System.DateTime? MemberStatusDate {
get { return SafeGetValue<System.DateTime?>("MemberStatusDate");}
set { this["MemberStatusDate"] = value;}
}

public System.Boolean PreviousNonMemberFlag {
get { return SafeGetValue<System.Boolean>("PreviousNonMemberFlag");}
set { this["PreviousNonMemberFlag"] = value;}
}

public System.Boolean DuesWaivedLocalFlag {
get { return SafeGetValue<System.Boolean>("DuesWaivedLocalFlag");}
set { this["DuesWaivedLocalFlag"] = value;}
}

public System.Boolean DuesWaivedStateFlag {
get { return SafeGetValue<System.Boolean>("DuesWaivedStateFlag");}
set { this["DuesWaivedStateFlag"] = value;}
}

public System.Boolean DuesWaivedNationalFlag {
get { return SafeGetValue<System.Boolean>("DuesWaivedNationalFlag");}
set { this["DuesWaivedNationalFlag"] = value;}
}

public System.Int32? MemberSSN {
get { return SafeGetValue<System.Int32?>("MemberSSN");}
set { this["MemberSSN"] = value;}
}

public System.String MemberRELicense {
get { return SafeGetValue<System.String>("MemberRELicense");}
set { this["MemberRELicense"] = value;}
}

public System.DateTime? MemberBirthDate {
get { return SafeGetValue<System.DateTime?>("MemberBirthDate");}
set { this["MemberBirthDate"] = value;}
}

public System.DateTime? MemberLocalJoinedDate {
get { return SafeGetValue<System.DateTime?>("MemberLocalJoinedDate");}
set { this["MemberLocalJoinedDate"] = value;}
}

public System.Boolean StopMailFlag {
get { return SafeGetValue<System.Boolean>("StopMailFlag");}
set { this["StopMailFlag"] = value;}
}

public System.Boolean JunkMailFlag {
get { return SafeGetValue<System.Boolean>("JunkMailFlag");}
set { this["JunkMailFlag"] = value;}
}

public System.Boolean OnRosterFlag {
get { return SafeGetValue<System.Boolean>("OnRosterFlag");}
set { this["OnRosterFlag"] = value;}
}

public System.Boolean MemberOnlineStatus {
get { return SafeGetValue<System.Boolean>("MemberOnlineStatus");}
set { this["MemberOnlineStatus"] = value;}
}

public System.DateTime? MemberOnlineStatusDate {
get { return SafeGetValue<System.DateTime?>("MemberOnlineStatusDate");}
set { this["MemberOnlineStatusDate"] = value;}
}

public System.String MemberDesignation {
get { return SafeGetValue<System.String>("MemberDesignation");}
set { this["MemberDesignation"] = value;}
}

public System.Int32? MemberPrimaryFieldOfBusiness {
get { return SafeGetValue<System.Int32?>("MemberPrimaryFieldOfBusiness");}
set { this["MemberPrimaryFieldOfBusiness"] = value;}
}

public System.Int32? MemberSecondaryFieldOfBusiness1 {
get { return SafeGetValue<System.Int32?>("MemberSecondaryFieldOfBusiness1");}
set { this["MemberSecondaryFieldOfBusiness1"] = value;}
}

public System.Int32? MemberSecondaryFieldOfBusiness2 {
get { return SafeGetValue<System.Int32?>("MemberSecondaryFieldOfBusiness2");}
set { this["MemberSecondaryFieldOfBusiness2"] = value;}
}

public System.Int32? MemberSecondaryFieldOfBusiness3 {
get { return SafeGetValue<System.Int32?>("MemberSecondaryFieldOfBusiness3");}
set { this["MemberSecondaryFieldOfBusiness3"] = value;}
}

public System.String MemberOccupationName {
get { return SafeGetValue<System.String>("MemberOccupationName");}
set { this["MemberOccupationName"] = value;}
}

public System.Int32? PointOfEntry {
get { return SafeGetValue<System.Int32?>("PointOfEntry");}
set { this["PointOfEntry"] = value;}
}

public System.String WebPage {
get { return SafeGetValue<System.String>("WebPage");}
set { this["WebPage"] = value;}
}

public System.String EMail {
get { return SafeGetValue<System.String>("EMail");}
set { this["EMail"] = value;}
}

public System.Int32? MLSID {
get { return SafeGetValue<System.Int32?>("MLSID");}
set { this["MLSID"] = value;}
}

public System.Boolean MemberArbitrationEthicsPending {
get { return SafeGetValue<System.Boolean>("MemberArbitrationEthicsPending");}
set { this["MemberArbitrationEthicsPending"] = value;}
}

public System.Boolean StopFaxFlag {
get { return SafeGetValue<System.Boolean>("StopFaxFlag");}
set { this["StopFaxFlag"] = value;}
}

public System.String MemberOfficeVoiceExtension {
get { return SafeGetValue<System.String>("MemberOfficeVoiceExtension");}
set { this["MemberOfficeVoiceExtension"] = value;}
}

public System.String MemberReinstatementCode {
get { return SafeGetValue<System.String>("MemberReinstatementCode");}
set { this["MemberReinstatementCode"] = value;}
}

public System.DateTime? MemberReinstatementDate {
get { return SafeGetValue<System.DateTime?>("MemberReinstatementDate");}
set { this["MemberReinstatementDate"] = value;}
}

public System.DateTime? MemberNationalDuesPaidDate {
get { return SafeGetValue<System.DateTime?>("MemberNationalDuesPaidDate");}
set { this["MemberNationalDuesPaidDate"] = value;}
}

public System.DateTime? MemberStateDuesPaidDate {
get { return SafeGetValue<System.DateTime?>("MemberStateDuesPaidDate");}
set { this["MemberStateDuesPaidDate"] = value;}
}

public System.String MemberSubclass {
get { return SafeGetValue<System.String>("MemberSubclass");}
set { this["MemberSubclass"] = value;}
}

public System.Boolean MemberDesignatedRealtor {
get { return SafeGetValue<System.Boolean>("MemberDesignatedRealtor");}
set { this["MemberDesignatedRealtor"] = value;}
}

public System.Boolean StopEMailFlag {
get { return SafeGetValue<System.Boolean>("StopEMailFlag");}
set { this["StopEMailFlag"] = value;}
}

public System.DateTime? MemberNRDSInsertDate {
get { return SafeGetValue<System.DateTime?>("MemberNRDSInsertDate");}
set { this["MemberNRDSInsertDate"] = value;}
}

}
[Serializable]
public class msNRDSMemberSupplementalRecord : msNRDSMemberRelatedRecord {
public new const string CLASS_NAME = "NRDSMemberSupplementalRecord";
public new  static class FIELDS {
public const string Member = "Member";
public const string Office = "Office";
public const string OfficeId = "OfficeId";
public const string MemberType = "MemberType";
public const string MemberRELicense = "MemberRELicense";
public const string MemberStatus = "MemberStatus";
public const string MemberStatusDate = "MemberStatusDate";
public const string MemberSubclass = "MemberSubclass";
public const string MemberLocalJoinedDate = "MemberLocalJoinedDate";
public const string DesigTBD1Flag = "DesigTBD1Flag";
}
public msNRDSMemberSupplementalRecord() : base() {
ClassType = "NRDSMemberSupplementalRecord";
}
public msNRDSMemberSupplementalRecord( MemberSuiteObject msObj) : base(msObj) {}
 public static new msNRDSMemberSupplementalRecord FromClassMetadata(ClassMetadata meta){return new msNRDSMemberSupplementalRecord(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Member {
get { return SafeGetValue<System.String>("Member");}
set { this["Member"] = value;}
}

public System.String Office {
get { return SafeGetValue<System.String>("Office");}
set { this["Office"] = value;}
}

public System.Int32? OfficeId {
get { return SafeGetValue<System.Int32?>("OfficeId");}
set { this["OfficeId"] = value;}
}

public MemberSuite.SDK.Types.NRDSMemberType MemberType {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSMemberType>("MemberType");}
set { this["MemberType"] = value;}
}

public System.String MemberRELicense {
get { return SafeGetValue<System.String>("MemberRELicense");}
set { this["MemberRELicense"] = value;}
}

public MemberSuite.SDK.Types.NRDSMemberSupplementalStatus MemberStatus {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSMemberSupplementalStatus>("MemberStatus");}
set { this["MemberStatus"] = value;}
}

public System.DateTime? MemberStatusDate {
get { return SafeGetValue<System.DateTime?>("MemberStatusDate");}
set { this["MemberStatusDate"] = value;}
}

public System.String MemberSubclass {
get { return SafeGetValue<System.String>("MemberSubclass");}
set { this["MemberSubclass"] = value;}
}

public System.DateTime? MemberLocalJoinedDate {
get { return SafeGetValue<System.DateTime?>("MemberLocalJoinedDate");}
set { this["MemberLocalJoinedDate"] = value;}
}

public System.Boolean DesigTBD1Flag {
get { return SafeGetValue<System.Boolean>("DesigTBD1Flag");}
set { this["DesigTBD1Flag"] = value;}
}

}
[Serializable]
public class msNRDSOfficeRecord : msNRDSRecord {
public new const string CLASS_NAME = "NRDSOfficeRecord";
public new  static class FIELDS {
public const string NRDSAssociation = "NRDSAssociation";
public const string Owner = "Owner";
public const string PrimaryStateCodeId = "PrimaryStateCodeId";
public const string OfficeId = "OfficeId";
public const string OfficeFranchiseId = "OfficeFranchiseId";
public const string OfficeParentCompanyId = "OfficeParentCompanyId";
public const string OfficeMainOfficeId = "OfficeMainOfficeId";
public const string OfficeBillingOfficeId = "OfficeBillingOfficeId";
public const string OfficeContactDRId = "OfficeContactDRId";
public const string OfficeContactManagerId = "OfficeContactManagerId";
public const string OfficeBusinessName = "OfficeBusinessName";
public const string OfficeCorporateName = "OfficeCorporateName";
public const string OfficeSortSequence = "OfficeSortSequence";
public const string OfficeStreetAddress_Street1 = "OfficeStreetAddress_Street1";
public const string OfficeStreetAddress_Street2 = "OfficeStreetAddress_Street2";
public const string OfficeStreetAddress_City = "OfficeStreetAddress_City";
public const string OfficeStreetAddress_State = "OfficeStreetAddress_State";
public const string OfficeStreetAddress_Zip = "OfficeStreetAddress_Zip";
public const string OfficeStreetAddress_Zip6 = "OfficeStreetAddress_Zip6";
public const string OfficeMailAddress_Street1 = "OfficeMailAddress_Street1";
public const string OfficeMailAddress_Street2 = "OfficeMailAddress_Street2";
public const string OfficeMailAddress_City = "OfficeMailAddress_City";
public const string OfficeMailAddress_State = "OfficeMailAddress_State";
public const string OfficeMailAddress_Zip = "OfficeMailAddress_Zip";
public const string OfficeMailAddress_Zip6 = "OfficeMailAddress_Zip6";
public const string OfficePhone_Area = "OfficePhone_Area";
public const string OfficePhone_Number = "OfficePhone_Number";
public const string OfficeFax_Area = "OfficeFax_Area";
public const string OfficeFax_Number = "OfficeFax_Number";
public const string OfficeAdditionalPhone_Area = "OfficeAdditionalPhone_Area";
public const string OfficeAdditionalPhone_Number = "OfficeAdditionalPhone_Number";
public const string StopFaxFlag = "StopFaxFlag";
public const string OfficeDistrict = "OfficeDistrict";
public const string OfficeType = "OfficeType";
public const string OfficeTaxId = "OfficeTaxId";
public const string OfficeCorporateLicense = "OfficeCorporateLicense";
public const string OfficeBranchType = "OfficeBranchType";
public const string OfficeContactUnlicensed = "OfficeContactUnlicensed";
public const string JoinedDate = "JoinedDate";
public const string OfficeStatus = "OfficeStatus";
public const string OfficeStatusDate = "OfficeStatusDate";
public const string OnRosterFlag = "OnRosterFlag";
public const string StopMailFlag = "StopMailFlag";
public const string OfficeNMSalespersonCount = "OfficeNMSalespersonCount";
public const string PrimaryIndicator = "PrimaryIndicator";
public const string OfficeMLSOnlineStatus = "OfficeMLSOnlineStatus";
public const string OfficeMLSOnlineStatusDate = "OfficeMLSOnlineStatusDate";
public const string PointOfEntry = "PointOfEntry";
public const string WebPage = "WebPage";
public const string EMail = "EMail";
public const string MLSID = "MLSID";
public const string JunkMailFlag = "JunkMailFlag";
public const string OfficeFormalName = "OfficeFormalName";
public const string OfficeNRDSInsertDate = "OfficeNRDSInsertDate";
}
public msNRDSOfficeRecord() : base() {
ClassType = "NRDSOfficeRecord";
}
public msNRDSOfficeRecord( MemberSuiteObject msObj) : base(msObj) {}
 public static new msNRDSOfficeRecord FromClassMetadata(ClassMetadata meta){return new msNRDSOfficeRecord(MemberSuiteObject.FromClassMetadata(meta));}
public System.String NRDSAssociation {
get { return SafeGetValue<System.String>("NRDSAssociation");}
set { this["NRDSAssociation"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.Int32? PrimaryStateCodeId {
get { return SafeGetValue<System.Int32?>("PrimaryStateCodeId");}
set { this["PrimaryStateCodeId"] = value;}
}

public System.Int32? OfficeId {
get { return SafeGetValue<System.Int32?>("OfficeId");}
set { this["OfficeId"] = value;}
}

public System.Int32? OfficeFranchiseId {
get { return SafeGetValue<System.Int32?>("OfficeFranchiseId");}
set { this["OfficeFranchiseId"] = value;}
}

public System.Int32? OfficeParentCompanyId {
get { return SafeGetValue<System.Int32?>("OfficeParentCompanyId");}
set { this["OfficeParentCompanyId"] = value;}
}

public System.Int32? OfficeMainOfficeId {
get { return SafeGetValue<System.Int32?>("OfficeMainOfficeId");}
set { this["OfficeMainOfficeId"] = value;}
}

public System.Int32? OfficeBillingOfficeId {
get { return SafeGetValue<System.Int32?>("OfficeBillingOfficeId");}
set { this["OfficeBillingOfficeId"] = value;}
}

public System.Int32? OfficeContactDRId {
get { return SafeGetValue<System.Int32?>("OfficeContactDRId");}
set { this["OfficeContactDRId"] = value;}
}

public System.Int32? OfficeContactManagerId {
get { return SafeGetValue<System.Int32?>("OfficeContactManagerId");}
set { this["OfficeContactManagerId"] = value;}
}

public System.String OfficeBusinessName {
get { return SafeGetValue<System.String>("OfficeBusinessName");}
set { this["OfficeBusinessName"] = value;}
}

public System.String OfficeCorporateName {
get { return SafeGetValue<System.String>("OfficeCorporateName");}
set { this["OfficeCorporateName"] = value;}
}

public System.String OfficeSortSequence {
get { return SafeGetValue<System.String>("OfficeSortSequence");}
set { this["OfficeSortSequence"] = value;}
}

public System.String OfficeStreetAddress_Street1 {
get { return SafeGetValue<System.String>("OfficeStreetAddress_Street1");}
set { this["OfficeStreetAddress_Street1"] = value;}
}

public System.String OfficeStreetAddress_Street2 {
get { return SafeGetValue<System.String>("OfficeStreetAddress_Street2");}
set { this["OfficeStreetAddress_Street2"] = value;}
}

public System.String OfficeStreetAddress_City {
get { return SafeGetValue<System.String>("OfficeStreetAddress_City");}
set { this["OfficeStreetAddress_City"] = value;}
}

public System.String OfficeStreetAddress_State {
get { return SafeGetValue<System.String>("OfficeStreetAddress_State");}
set { this["OfficeStreetAddress_State"] = value;}
}

public System.String OfficeStreetAddress_Zip {
get { return SafeGetValue<System.String>("OfficeStreetAddress_Zip");}
set { this["OfficeStreetAddress_Zip"] = value;}
}

public System.String OfficeStreetAddress_Zip6 {
get { return SafeGetValue<System.String>("OfficeStreetAddress_Zip6");}
set { this["OfficeStreetAddress_Zip6"] = value;}
}

public System.String OfficeMailAddress_Street1 {
get { return SafeGetValue<System.String>("OfficeMailAddress_Street1");}
set { this["OfficeMailAddress_Street1"] = value;}
}

public System.String OfficeMailAddress_Street2 {
get { return SafeGetValue<System.String>("OfficeMailAddress_Street2");}
set { this["OfficeMailAddress_Street2"] = value;}
}

public System.String OfficeMailAddress_City {
get { return SafeGetValue<System.String>("OfficeMailAddress_City");}
set { this["OfficeMailAddress_City"] = value;}
}

public System.String OfficeMailAddress_State {
get { return SafeGetValue<System.String>("OfficeMailAddress_State");}
set { this["OfficeMailAddress_State"] = value;}
}

public System.String OfficeMailAddress_Zip {
get { return SafeGetValue<System.String>("OfficeMailAddress_Zip");}
set { this["OfficeMailAddress_Zip"] = value;}
}

public System.String OfficeMailAddress_Zip6 {
get { return SafeGetValue<System.String>("OfficeMailAddress_Zip6");}
set { this["OfficeMailAddress_Zip6"] = value;}
}

public System.Int32? OfficePhone_Area {
get { return SafeGetValue<System.Int32?>("OfficePhone_Area");}
set { this["OfficePhone_Area"] = value;}
}

public System.Int32? OfficePhone_Number {
get { return SafeGetValue<System.Int32?>("OfficePhone_Number");}
set { this["OfficePhone_Number"] = value;}
}

public System.Int32? OfficeFax_Area {
get { return SafeGetValue<System.Int32?>("OfficeFax_Area");}
set { this["OfficeFax_Area"] = value;}
}

public System.Int32? OfficeFax_Number {
get { return SafeGetValue<System.Int32?>("OfficeFax_Number");}
set { this["OfficeFax_Number"] = value;}
}

public System.Int32? OfficeAdditionalPhone_Area {
get { return SafeGetValue<System.Int32?>("OfficeAdditionalPhone_Area");}
set { this["OfficeAdditionalPhone_Area"] = value;}
}

public System.Int32? OfficeAdditionalPhone_Number {
get { return SafeGetValue<System.Int32?>("OfficeAdditionalPhone_Number");}
set { this["OfficeAdditionalPhone_Number"] = value;}
}

public System.Boolean StopFaxFlag {
get { return SafeGetValue<System.Boolean>("StopFaxFlag");}
set { this["StopFaxFlag"] = value;}
}

public System.String OfficeDistrict {
get { return SafeGetValue<System.String>("OfficeDistrict");}
set { this["OfficeDistrict"] = value;}
}

public System.String OfficeType {
get { return SafeGetValue<System.String>("OfficeType");}
set { this["OfficeType"] = value;}
}

public System.String OfficeTaxId {
get { return SafeGetValue<System.String>("OfficeTaxId");}
set { this["OfficeTaxId"] = value;}
}

public System.String OfficeCorporateLicense {
get { return SafeGetValue<System.String>("OfficeCorporateLicense");}
set { this["OfficeCorporateLicense"] = value;}
}

public MemberSuite.SDK.Types.NRDSOfficeBranchType OfficeBranchType {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSOfficeBranchType>("OfficeBranchType");}
set { this["OfficeBranchType"] = value;}
}

public System.String OfficeContactUnlicensed {
get { return SafeGetValue<System.String>("OfficeContactUnlicensed");}
set { this["OfficeContactUnlicensed"] = value;}
}

public System.DateTime? JoinedDate {
get { return SafeGetValue<System.DateTime?>("JoinedDate");}
set { this["JoinedDate"] = value;}
}

public MemberSuite.SDK.Types.NRDSOfficeStatus OfficeStatus {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSOfficeStatus>("OfficeStatus");}
set { this["OfficeStatus"] = value;}
}

public System.DateTime? OfficeStatusDate {
get { return SafeGetValue<System.DateTime?>("OfficeStatusDate");}
set { this["OfficeStatusDate"] = value;}
}

public System.Boolean OnRosterFlag {
get { return SafeGetValue<System.Boolean>("OnRosterFlag");}
set { this["OnRosterFlag"] = value;}
}

public System.Boolean StopMailFlag {
get { return SafeGetValue<System.Boolean>("StopMailFlag");}
set { this["StopMailFlag"] = value;}
}

public System.Int32? OfficeNMSalespersonCount {
get { return SafeGetValue<System.Int32?>("OfficeNMSalespersonCount");}
set { this["OfficeNMSalespersonCount"] = value;}
}

public MemberSuite.SDK.Types.NRDSPrimaryIndicator PrimaryIndicator {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSPrimaryIndicator>("PrimaryIndicator");}
set { this["PrimaryIndicator"] = value;}
}

public MemberSuite.SDK.Types.NRDSOfficeStatus OfficeMLSOnlineStatus {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSOfficeStatus>("OfficeMLSOnlineStatus");}
set { this["OfficeMLSOnlineStatus"] = value;}
}

public System.DateTime? OfficeMLSOnlineStatusDate {
get { return SafeGetValue<System.DateTime?>("OfficeMLSOnlineStatusDate");}
set { this["OfficeMLSOnlineStatusDate"] = value;}
}

public System.Int32? PointOfEntry {
get { return SafeGetValue<System.Int32?>("PointOfEntry");}
set { this["PointOfEntry"] = value;}
}

public System.String WebPage {
get { return SafeGetValue<System.String>("WebPage");}
set { this["WebPage"] = value;}
}

public System.String EMail {
get { return SafeGetValue<System.String>("EMail");}
set { this["EMail"] = value;}
}

public System.Int32? MLSID {
get { return SafeGetValue<System.Int32?>("MLSID");}
set { this["MLSID"] = value;}
}

public System.Boolean JunkMailFlag {
get { return SafeGetValue<System.Boolean>("JunkMailFlag");}
set { this["JunkMailFlag"] = value;}
}

public System.String OfficeFormalName {
get { return SafeGetValue<System.String>("OfficeFormalName");}
set { this["OfficeFormalName"] = value;}
}

public System.DateTime? OfficeNRDSInsertDate {
get { return SafeGetValue<System.DateTime?>("OfficeNRDSInsertDate");}
set { this["OfficeNRDSInsertDate"] = value;}
}

}
[Serializable]
public class msNRDSOfficeSupplementalRecord : msNRDSRecord {
public new const string CLASS_NAME = "NRDSOfficeSupplementalRecord";
public new  static class FIELDS {
public const string NRDSAssociation = "NRDSAssociation";
public const string Office = "Office";
public const string OfficeID = "OfficeID";
public const string OfficeStatus = "OfficeStatus";
public const string OfficeStatusDate = "OfficeStatusDate";
public const string OfficeNMSalespersonCount = "OfficeNMSalespersonCount";
}
public msNRDSOfficeSupplementalRecord() : base() {
ClassType = "NRDSOfficeSupplementalRecord";
}
public msNRDSOfficeSupplementalRecord( MemberSuiteObject msObj) : base(msObj) {}
 public static new msNRDSOfficeSupplementalRecord FromClassMetadata(ClassMetadata meta){return new msNRDSOfficeSupplementalRecord(MemberSuiteObject.FromClassMetadata(meta));}
public System.String NRDSAssociation {
get { return SafeGetValue<System.String>("NRDSAssociation");}
set { this["NRDSAssociation"] = value;}
}

public System.String Office {
get { return SafeGetValue<System.String>("Office");}
set { this["Office"] = value;}
}

public System.Int32? OfficeID {
get { return SafeGetValue<System.Int32?>("OfficeID");}
set { this["OfficeID"] = value;}
}

public MemberSuite.SDK.Types.NRDSOfficeStatus OfficeStatus {
get { return SafeGetValue<MemberSuite.SDK.Types.NRDSOfficeStatus>("OfficeStatus");}
set { this["OfficeStatus"] = value;}
}

public System.DateTime? OfficeStatusDate {
get { return SafeGetValue<System.DateTime?>("OfficeStatusDate");}
set { this["OfficeStatusDate"] = value;}
}

public System.Int32? OfficeNMSalespersonCount {
get { return SafeGetValue<System.Int32?>("OfficeNMSalespersonCount");}
set { this["OfficeNMSalespersonCount"] = value;}
}

}
[Serializable]
public class msExpiringProduct : msProduct {
public new const string CLASS_NAME = "ExpiringProduct";
public new  static class FIELDS {
public const string ExpirationType = "ExpirationType";
public const string Availability = "Availability";
public const string StartDate = "StartDate";
public const string SellForNextYearAfter = "SellForNextYearAfter";
public const string SetDatesBasedOnPaymentDate = "SetDatesBasedOnPaymentDate";
public const string SellForNextMonthAfterDay = "SellForNextMonthAfterDay";
public const string StartDay = "StartDay";
public const string AllowMidMonthExpirations = "AllowMidMonthExpirations";
public const string TermLength = "TermLength";
public const string TermType = "TermType";
public const string UpdateDatesWhen = "UpdateDatesWhen";
public const string RequiresApproval = "RequiresApproval";
public const string RenewalTerms = "RenewalTerms";
public const string ProFormaRenewalInvoices = "ProFormaRenewalInvoices";
public const string GracePeriod = "GracePeriod";
public const string BillPrimaryOrganization = "BillPrimaryOrganization";
public const string ReinstatementPeriod = "ReinstatementPeriod";
public const string UseFreshJoinDateForReinstatedMembers = "UseFreshJoinDateForReinstatedMembers";
public const string GiveRenewalPricingDuringReinstatementPeriod = "GiveRenewalPricingDuringReinstatementPeriod";
public const string UseCurrentDateAsBasisForExpirationOfReinstatedMembership = "UseCurrentDateAsBasisForExpirationOfReinstatedMembership";
public const string InitialBillingEmail = "InitialBillingEmail";
public const string FirstReminderEmail = "FirstReminderEmail";
public const string SecondReminderEmail = "SecondReminderEmail";
public const string ThirdReminderEmail = "ThirdReminderEmail";
public const string DropEmail = "DropEmail";
public const string InvoicePercentage = "InvoicePercentage";
public const string InvoiceType = "InvoiceType";
public const string AutoRenew = "AutoRenew";
}
public msExpiringProduct() : base() {
ClassType = "ExpiringProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msExpiringProduct( MemberSuiteObject msObj) : base(msObj) {}
public MemberSuite.SDK.Types.ExpirationType ExpirationType {
get { return SafeGetValue<MemberSuite.SDK.Types.ExpirationType>("ExpirationType");}
set { this["ExpirationType"] = value;}
}

public MemberSuite.SDK.Types.RecurringProductAvailabilityType Availability {
get { return SafeGetValue<MemberSuite.SDK.Types.RecurringProductAvailabilityType>("Availability");}
set { this["Availability"] = value;}
}

public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? SellForNextYearAfter {
get { return SafeGetValue<System.DateTime?>("SellForNextYearAfter");}
set { this["SellForNextYearAfter"] = value;}
}

public System.Boolean SetDatesBasedOnPaymentDate {
get { return SafeGetValue<System.Boolean>("SetDatesBasedOnPaymentDate");}
set { this["SetDatesBasedOnPaymentDate"] = value;}
}

public System.Int32? SellForNextMonthAfterDay {
get { return SafeGetValue<System.Int32?>("SellForNextMonthAfterDay");}
set { this["SellForNextMonthAfterDay"] = value;}
}

public System.Int32? StartDay {
get { return SafeGetValue<System.Int32?>("StartDay");}
set { this["StartDay"] = value;}
}

public System.Boolean AllowMidMonthExpirations {
get { return SafeGetValue<System.Boolean>("AllowMidMonthExpirations");}
set { this["AllowMidMonthExpirations"] = value;}
}

public System.Int16 TermLength {
get { return SafeGetValue<System.Int16>("TermLength");}
set { this["TermLength"] = value;}
}

public MemberSuite.SDK.Types.TermType TermType {
get { return SafeGetValue<MemberSuite.SDK.Types.TermType>("TermType");}
set { this["TermType"] = value;}
}

public MemberSuite.SDK.Types.ActivationTerms UpdateDatesWhen {
get { return SafeGetValue<MemberSuite.SDK.Types.ActivationTerms>("UpdateDatesWhen");}
set { this["UpdateDatesWhen"] = value;}
}

public System.Boolean RequiresApproval {
get { return SafeGetValue<System.Boolean>("RequiresApproval");}
set { this["RequiresApproval"] = value;}
}

public System.String RenewalTerms {
get { return SafeGetValue<System.String>("RenewalTerms");}
set { this["RenewalTerms"] = value;}
}

public System.Boolean ProFormaRenewalInvoices {
get { return SafeGetValue<System.Boolean>("ProFormaRenewalInvoices");}
set { this["ProFormaRenewalInvoices"] = value;}
}

public System.Int32 GracePeriod {
get { return SafeGetValue<System.Int32>("GracePeriod");}
set { this["GracePeriod"] = value;}
}

public System.Boolean BillPrimaryOrganization {
get { return SafeGetValue<System.Boolean>("BillPrimaryOrganization");}
set { this["BillPrimaryOrganization"] = value;}
}

public System.Int16? ReinstatementPeriod {
get { return SafeGetValue<System.Int16?>("ReinstatementPeriod");}
set { this["ReinstatementPeriod"] = value;}
}

public System.Boolean UseFreshJoinDateForReinstatedMembers {
get { return SafeGetValue<System.Boolean>("UseFreshJoinDateForReinstatedMembers");}
set { this["UseFreshJoinDateForReinstatedMembers"] = value;}
}

public System.Boolean GiveRenewalPricingDuringReinstatementPeriod {
get { return SafeGetValue<System.Boolean>("GiveRenewalPricingDuringReinstatementPeriod");}
set { this["GiveRenewalPricingDuringReinstatementPeriod"] = value;}
}

public System.Boolean UseCurrentDateAsBasisForExpirationOfReinstatedMembership {
get { return SafeGetValue<System.Boolean>("UseCurrentDateAsBasisForExpirationOfReinstatedMembership");}
set { this["UseCurrentDateAsBasisForExpirationOfReinstatedMembership"] = value;}
}

public System.String InitialBillingEmail {
get { return SafeGetValue<System.String>("InitialBillingEmail");}
set { this["InitialBillingEmail"] = value;}
}

public System.String FirstReminderEmail {
get { return SafeGetValue<System.String>("FirstReminderEmail");}
set { this["FirstReminderEmail"] = value;}
}

public System.String SecondReminderEmail {
get { return SafeGetValue<System.String>("SecondReminderEmail");}
set { this["SecondReminderEmail"] = value;}
}

public System.String ThirdReminderEmail {
get { return SafeGetValue<System.String>("ThirdReminderEmail");}
set { this["ThirdReminderEmail"] = value;}
}

public System.String DropEmail {
get { return SafeGetValue<System.String>("DropEmail");}
set { this["DropEmail"] = value;}
}

public System.Decimal? InvoicePercentage {
get { return SafeGetValue<System.Decimal?>("InvoicePercentage");}
set { this["InvoicePercentage"] = value;}
}

public System.String InvoiceType {
get { return SafeGetValue<System.String>("InvoiceType");}
set { this["InvoiceType"] = value;}
}

public System.Boolean AutoRenew {
get { return SafeGetValue<System.Boolean>("AutoRenew");}
set { this["AutoRenew"] = value;}
}

}
[Serializable]
public class msRealtorSubscriptionFee : msExpiringProduct {
public new const string CLASS_NAME = "RealtorSubscriptionFee";
public new  static class FIELDS {
public const string Type = "Type";
}
public msRealtorSubscriptionFee() : base() {
ClassType = "RealtorSubscriptionFee";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msRealtorSubscriptionFee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRealtorSubscriptionFee FromClassMetadata(ClassMetadata meta){return new msRealtorSubscriptionFee(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.RealtorSubscriptionFeeType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.RealtorSubscriptionFeeType>("Type");}
set { this["Type"] = value;}
}

}
[Serializable]
public class msAuthorizedSubscriptionAgent : msAggregateChild {
public new const string CLASS_NAME = "AuthorizedSubscriptionAgent";
public new  static class FIELDS {
public const string Individual = "Individual";
}
public msAuthorizedSubscriptionAgent() : base() {
ClassType = "AuthorizedSubscriptionAgent";
}
public msAuthorizedSubscriptionAgent( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAuthorizedSubscriptionAgent FromClassMetadata(ClassMetadata meta){return new msAuthorizedSubscriptionAgent(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Individual {
get { return SafeGetValue<System.String>("Individual");}
set { this["Individual"] = value;}
}

}
[Serializable]
public class msUPSShippingCarrierAccount : msShippingCarrierAccount {
public new const string CLASS_NAME = "UPSShippingCarrierAccount";
public new  static class FIELDS {
public const string AccessKey = "AccessKey";
public const string AccountNumber = "AccountNumber";
public const string UserName = "UserName";
public const string Password = "Password";
public const string Server = "Server";
}
public msUPSShippingCarrierAccount() : base() {
ClassType = "UPSShippingCarrierAccount";
}
public msUPSShippingCarrierAccount( MemberSuiteObject msObj) : base(msObj) {}
 public static new msUPSShippingCarrierAccount FromClassMetadata(ClassMetadata meta){return new msUPSShippingCarrierAccount(MemberSuiteObject.FromClassMetadata(meta));}
public System.String AccessKey {
get { return SafeGetValue<System.String>("AccessKey");}
set { this["AccessKey"] = value;}
}

public System.String AccountNumber {
get { return SafeGetValue<System.String>("AccountNumber");}
set { this["AccountNumber"] = value;}
}

public System.String UserName {
get { return SafeGetValue<System.String>("UserName");}
set { this["UserName"] = value;}
}

public System.String Password {
get { return SafeGetValue<System.String>("Password");}
set { this["Password"] = value;}
}

public System.String Server {
get { return SafeGetValue<System.String>("Server");}
set { this["Server"] = value;}
}

}
[Serializable]
public class msUSPSShippingCarrierAccount : msShippingCarrierAccount {
public new const string CLASS_NAME = "USPSShippingCarrierAccount";
public new  static class FIELDS {
}
public msUSPSShippingCarrierAccount() : base() {
ClassType = "USPSShippingCarrierAccount";
}
public msUSPSShippingCarrierAccount( MemberSuiteObject msObj) : base(msObj) {}
 public static new msUSPSShippingCarrierAccount FromClassMetadata(ClassMetadata meta){return new msUSPSShippingCarrierAccount(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msCampaign : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "Campaign";
public new  static class FIELDS {
public const string Code = "Code";
public const string Description = "Description";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string Goal = "Goal";
public const string Notes = "Notes";
public const string ParentCampaign = "ParentCampaign";
public const string Premiums = "Premiums";
}
public msCampaign() : base() {
ClassType = "Campaign";
Premiums = new System.Collections.Generic.List<msLinkedPremium>();
}
public msCampaign( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCampaign FromClassMetadata(ClassMetadata meta){return new msCampaign(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? EndDate {
get { return SafeGetValue<System.DateTime?>("EndDate");}
set { this["EndDate"] = value;}
}

public System.Decimal? Goal {
get { return SafeGetValue<System.Decimal?>("Goal");}
set { this["Goal"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.String ParentCampaign {
get { return SafeGetValue<System.String>("ParentCampaign");}
set { this["ParentCampaign"] = value;}
}

public System.Collections.Generic.List<msLinkedPremium> Premiums {
get { return SafeGetValue<System.Collections.Generic.List<msLinkedPremium>>("Premiums");}
set { this["Premiums"] = value;}
}

}
[Serializable]
public class msDonorLevel : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "DonorLevel";
public new  static class FIELDS {
public const string Code = "Code";
public const string Description = "Description";
public const string DisplayOrder = "DisplayOrder";
}
public msDonorLevel() : base() {
ClassType = "DonorLevel";
}
public msDonorLevel( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDonorLevel FromClassMetadata(ClassMetadata meta){return new msDonorLevel(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Int16 DisplayOrder {
get { return SafeGetValue<System.Int16>("DisplayOrder");}
set { this["DisplayOrder"] = value;}
}

}
[Serializable]
public class msFund : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "Fund";
public new  static class FIELDS {
public const string BusinessUnit = "BusinessUnit";
public const string MerchantAccount = "MerchantAccount";
public const string Code = "Code";
public const string Description = "Description";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string Goal = "Goal";
public const string Notes = "Notes";
public const string GLAccounts = "GLAccounts";
public const string Premiums = "Premiums";
public const string RealtorCategory = "RealtorCategory";
}
public msFund() : base() {
ClassType = "Fund";
GLAccounts = new System.Collections.Generic.List<msFundGLAccount>();
Premiums = new System.Collections.Generic.List<msLinkedPremium>();
}
public msFund( MemberSuiteObject msObj) : base(msObj) {}
 public static new msFund FromClassMetadata(ClassMetadata meta){return new msFund(MemberSuiteObject.FromClassMetadata(meta));}
public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public System.String MerchantAccount {
get { return SafeGetValue<System.String>("MerchantAccount");}
set { this["MerchantAccount"] = value;}
}

public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? EndDate {
get { return SafeGetValue<System.DateTime?>("EndDate");}
set { this["EndDate"] = value;}
}

public System.Decimal? Goal {
get { return SafeGetValue<System.Decimal?>("Goal");}
set { this["Goal"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Collections.Generic.List<msFundGLAccount> GLAccounts {
get { return SafeGetValue<System.Collections.Generic.List<msFundGLAccount>>("GLAccounts");}
set { this["GLAccounts"] = value;}
}

public System.Collections.Generic.List<msLinkedPremium> Premiums {
get { return SafeGetValue<System.Collections.Generic.List<msLinkedPremium>>("Premiums");}
set { this["Premiums"] = value;}
}

public MemberSuite.SDK.Types.RealtorProductCategory RealtorCategory {
get { return SafeGetValue<MemberSuite.SDK.Types.RealtorProductCategory>("RealtorCategory");}
set { this["RealtorCategory"] = value;}
}

}
[Serializable]
public class msFundGLAccount : msAggregateChild {
public new const string CLASS_NAME = "FundGLAccount";
public new  static class FIELDS {
public const string BusinessUnit = "BusinessUnit";
public const string GiftType = "GiftType";
public const string GLAccountToDebit = "GLAccountToDebit";
public const string GLAccountToCredit = "GLAccountToCredit";
}
public msFundGLAccount() : base() {
ClassType = "FundGLAccount";
}
public msFundGLAccount( MemberSuiteObject msObj) : base(msObj) {}
 public static new msFundGLAccount FromClassMetadata(ClassMetadata meta){return new msFundGLAccount(MemberSuiteObject.FromClassMetadata(meta));}
public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public MemberSuite.SDK.Types.GiftType GiftType {
get { return SafeGetValue<MemberSuite.SDK.Types.GiftType>("GiftType");}
set { this["GiftType"] = value;}
}

public System.String GLAccountToDebit {
get { return SafeGetValue<System.String>("GLAccountToDebit");}
set { this["GLAccountToDebit"] = value;}
}

public System.String GLAccountToCredit {
get { return SafeGetValue<System.String>("GLAccountToCredit");}
set { this["GLAccountToCredit"] = value;}
}

}
[Serializable]
public class msFundraisingProduct : msProduct {
public new const string CLASS_NAME = "FundraisingProduct";
public new  static class FIELDS {
public const string Campaign = "Campaign";
public const string Appeal = "Appeal";
public const string GiftSubType = "GiftSubType";
public const string Fund = "Fund";
}
public msFundraisingProduct() : base() {
ClassType = "FundraisingProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msFundraisingProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msFundraisingProduct FromClassMetadata(ClassMetadata meta){return new msFundraisingProduct(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Campaign {
get { return SafeGetValue<System.String>("Campaign");}
set { this["Campaign"] = value;}
}

public System.String Appeal {
get { return SafeGetValue<System.String>("Appeal");}
set { this["Appeal"] = value;}
}

public System.String GiftSubType {
get { return SafeGetValue<System.String>("GiftSubType");}
set { this["GiftSubType"] = value;}
}

public System.String Fund {
get { return SafeGetValue<System.String>("Fund");}
set { this["Fund"] = value;}
}

}
[Serializable]
public class msGift : msBatchMember {
public new const string CLASS_NAME = "Gift";
public new  static class FIELDS {
public const string Type = "Type";
public const string SubType = "SubType";
public const string IsAnonymous = "IsAnonymous";
public const string Donor = "Donor";
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
public const string Product = "Product";
public const string Campaign = "Campaign";
public const string Fund = "Fund";
public const string Appeal = "Appeal";
public const string Package = "Package";
public const string MasterGift = "MasterGift";
public const string SavedPaymentMethod = "SavedPaymentMethod";
public const string DateOfInstallmentSuspension = "DateOfInstallmentSuspension";
public const string ListAs = "ListAs";
public const string Amount = "Amount";
public const string Notes = "Notes";
public const string StockSymbol = "StockSymbol";
public const string NumberOfShares = "NumberOfShares";
public const string Status = "Status";
public const string MerchantAccount = "MerchantAccount";
public const string TransactionID = "TransactionID";
public const string PledgeStartDate = "PledgeStartDate";
public const string RecurrenceTemplate = "RecurrenceTemplate";
public const string NextTransactionDue = "NextTransactionDue";
public const string NextTransactionAmount = "NextTransactionAmount";
public const string BalanceDue = "BalanceDue";
public const string InstallmentID = "InstallmentID";
public const string ReceiptStatus = "ReceiptStatus";
public const string ReceiptDate = "ReceiptDate";
public const string Receipt = "Receipt";
public const string LastInstallmentError = "LastInstallmentError";
public const string AcknowledgmentStatus = "AcknowledgmentStatus";
public const string AcknowledgmentDate = "AcknowledgmentDate";
public const string AcknowledgmentLetter = "AcknowledgmentLetter";
public const string PaymentMethod = "PaymentMethod";
public const string CreditCardType = "CreditCardType";
public const string PaymentReference = "PaymentReference";
public const string Tributes = "Tributes";
public const string Installments = "Installments";
public const string Attributes = "Attributes";
public const string Solicitors = "Solicitors";
public const string Premiums = "Premiums";
public const string Splits = "Splits";
public const string CreditCardLastFiveDigits = "CreditCardLastFiveDigits";
}
public msGift() : base() {
ClassType = "Gift";
Tributes = new System.Collections.Generic.List<msGiftTribute>();
Installments = new System.Collections.Generic.List<msGiftInstallment>();
Attributes = new System.Collections.Generic.List<msGiftAttribute>();
Solicitors = new System.Collections.Generic.List<msGiftSolicitor>();
Premiums = new System.Collections.Generic.List<msGiftPremium>();
Splits = new System.Collections.Generic.List<msGiftSplit>();
}
public msGift( MemberSuiteObject msObj) : base(msObj) {}
 public static new msGift FromClassMetadata(ClassMetadata meta){return new msGift(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.GiftType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.GiftType>("Type");}
set { this["Type"] = value;}
}

public System.String SubType {
get { return SafeGetValue<System.String>("SubType");}
set { this["SubType"] = value;}
}

public System.Boolean IsAnonymous {
get { return SafeGetValue<System.Boolean>("IsAnonymous");}
set { this["IsAnonymous"] = value;}
}

public System.String Donor {
get { return SafeGetValue<System.String>("Donor");}
set { this["Donor"] = value;}
}

public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.String Product {
get { return SafeGetValue<System.String>("Product");}
set { this["Product"] = value;}
}

public System.String Campaign {
get { return SafeGetValue<System.String>("Campaign");}
set { this["Campaign"] = value;}
}

public System.String Fund {
get { return SafeGetValue<System.String>("Fund");}
set { this["Fund"] = value;}
}

public System.String Appeal {
get { return SafeGetValue<System.String>("Appeal");}
set { this["Appeal"] = value;}
}

public System.String Package {
get { return SafeGetValue<System.String>("Package");}
set { this["Package"] = value;}
}

public System.String MasterGift {
get { return SafeGetValue<System.String>("MasterGift");}
set { this["MasterGift"] = value;}
}

public System.String SavedPaymentMethod {
get { return SafeGetValue<System.String>("SavedPaymentMethod");}
set { this["SavedPaymentMethod"] = value;}
}

public System.DateTime? DateOfInstallmentSuspension {
get { return SafeGetValue<System.DateTime?>("DateOfInstallmentSuspension");}
set { this["DateOfInstallmentSuspension"] = value;}
}

public System.String ListAs {
get { return SafeGetValue<System.String>("ListAs");}
set { this["ListAs"] = value;}
}

public System.Decimal Amount {
get { return SafeGetValue<System.Decimal>("Amount");}
set { this["Amount"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.String StockSymbol {
get { return SafeGetValue<System.String>("StockSymbol");}
set { this["StockSymbol"] = value;}
}

public System.Int32? NumberOfShares {
get { return SafeGetValue<System.Int32?>("NumberOfShares");}
set { this["NumberOfShares"] = value;}
}

public MemberSuite.SDK.Types.GiftStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.GiftStatus>("Status");}
set { this["Status"] = value;}
}

public System.String MerchantAccount {
get { return SafeGetValue<System.String>("MerchantAccount");}
set { this["MerchantAccount"] = value;}
}

public System.String TransactionID {
get { return SafeGetValue<System.String>("TransactionID");}
set { this["TransactionID"] = value;}
}

public System.DateTime? PledgeStartDate {
get { return SafeGetValue<System.DateTime?>("PledgeStartDate");}
set { this["PledgeStartDate"] = value;}
}

public MemberSuite.SDK.Types.FinancialRecurrenceTemplate RecurrenceTemplate {
get { return SafeGetValue<MemberSuite.SDK.Types.FinancialRecurrenceTemplate>("RecurrenceTemplate");}
set { this["RecurrenceTemplate"] = value;}
}

public System.DateTime? NextTransactionDue {
get { return SafeGetValue<System.DateTime?>("NextTransactionDue");}
set { this["NextTransactionDue"] = value;}
}

public System.Decimal? NextTransactionAmount {
get { return SafeGetValue<System.Decimal?>("NextTransactionAmount");}
set { this["NextTransactionAmount"] = value;}
}

public System.Decimal BalanceDue {
get { return SafeGetValue<System.Decimal>("BalanceDue");}
set { this["BalanceDue"] = value;}
}

public System.String InstallmentID {
get { return SafeGetValue<System.String>("InstallmentID");}
set { this["InstallmentID"] = value;}
}

public MemberSuite.SDK.Types.GiftReceiptStatus ReceiptStatus {
get { return SafeGetValue<MemberSuite.SDK.Types.GiftReceiptStatus>("ReceiptStatus");}
set { this["ReceiptStatus"] = value;}
}

public System.DateTime? ReceiptDate {
get { return SafeGetValue<System.DateTime?>("ReceiptDate");}
set { this["ReceiptDate"] = value;}
}

public System.String Receipt {
get { return SafeGetValue<System.String>("Receipt");}
set { this["Receipt"] = value;}
}

public System.String LastInstallmentError {
get { return SafeGetValue<System.String>("LastInstallmentError");}
set { this["LastInstallmentError"] = value;}
}

public MemberSuite.SDK.Types.GiftAcknowledgmentStatus AcknowledgmentStatus {
get { return SafeGetValue<MemberSuite.SDK.Types.GiftAcknowledgmentStatus>("AcknowledgmentStatus");}
set { this["AcknowledgmentStatus"] = value;}
}

public System.DateTime? AcknowledgmentDate {
get { return SafeGetValue<System.DateTime?>("AcknowledgmentDate");}
set { this["AcknowledgmentDate"] = value;}
}

public System.String AcknowledgmentLetter {
get { return SafeGetValue<System.String>("AcknowledgmentLetter");}
set { this["AcknowledgmentLetter"] = value;}
}

public MemberSuite.SDK.Types.PaymentMethod PaymentMethod {
get { return SafeGetValue<MemberSuite.SDK.Types.PaymentMethod>("PaymentMethod");}
set { this["PaymentMethod"] = value;}
}

public MemberSuite.SDK.Types.CreditCardType CreditCardType {
get { return SafeGetValue<MemberSuite.SDK.Types.CreditCardType>("CreditCardType");}
set { this["CreditCardType"] = value;}
}

public System.String PaymentReference {
get { return SafeGetValue<System.String>("PaymentReference");}
set { this["PaymentReference"] = value;}
}

public System.Collections.Generic.List<msGiftTribute> Tributes {
get { return SafeGetValue<System.Collections.Generic.List<msGiftTribute>>("Tributes");}
set { this["Tributes"] = value;}
}

public System.Collections.Generic.List<msGiftInstallment> Installments {
get { return SafeGetValue<System.Collections.Generic.List<msGiftInstallment>>("Installments");}
set { this["Installments"] = value;}
}

public System.Collections.Generic.List<msGiftAttribute> Attributes {
get { return SafeGetValue<System.Collections.Generic.List<msGiftAttribute>>("Attributes");}
set { this["Attributes"] = value;}
}

public System.Collections.Generic.List<msGiftSolicitor> Solicitors {
get { return SafeGetValue<System.Collections.Generic.List<msGiftSolicitor>>("Solicitors");}
set { this["Solicitors"] = value;}
}

public System.Collections.Generic.List<msGiftPremium> Premiums {
get { return SafeGetValue<System.Collections.Generic.List<msGiftPremium>>("Premiums");}
set { this["Premiums"] = value;}
}

public System.Collections.Generic.List<msGiftSplit> Splits {
get { return SafeGetValue<System.Collections.Generic.List<msGiftSplit>>("Splits");}
set { this["Splits"] = value;}
}

public System.String CreditCardLastFiveDigits {
get { return SafeGetValue<System.String>("CreditCardLastFiveDigits");}
set { this["CreditCardLastFiveDigits"] = value;}
}

}
[Serializable]
public class msGiftTribute : msAggregateChild {
public new const string CLASS_NAME = "GiftTribute";
public new  static class FIELDS {
public const string Tribute = "Tribute";
public const string Comments = "Comments";
}
public msGiftTribute() : base() {
ClassType = "GiftTribute";
}
public msGiftTribute( MemberSuiteObject msObj) : base(msObj) {}
 public static new msGiftTribute FromClassMetadata(ClassMetadata meta){return new msGiftTribute(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Tribute {
get { return SafeGetValue<System.String>("Tribute");}
set { this["Tribute"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

}
[Serializable]
public class msGiftSplit : msAggregateChild {
public new const string CLASS_NAME = "GiftSplit";
public new  static class FIELDS {
public const string Fund = "Fund";
public const string Amount = "Amount";
public const string Comments = "Comments";
}
public msGiftSplit() : base() {
ClassType = "GiftSplit";
}
public msGiftSplit( MemberSuiteObject msObj) : base(msObj) {}
 public static new msGiftSplit FromClassMetadata(ClassMetadata meta){return new msGiftSplit(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Fund {
get { return SafeGetValue<System.String>("Fund");}
set { this["Fund"] = value;}
}

public System.Decimal Amount {
get { return SafeGetValue<System.Decimal>("Amount");}
set { this["Amount"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

}
[Serializable]
public class msGiftInstallment : msAggregateChild {
public new const string CLASS_NAME = "GiftInstallment";
public new  static class FIELDS {
public const string InstallmentID = "InstallmentID";
public const string Date = "Date";
public const string Amount = "Amount";
public const string AmountPaid = "AmountPaid";
public const string Comments = "Comments";
}
public msGiftInstallment() : base() {
ClassType = "GiftInstallment";
}
public msGiftInstallment( MemberSuiteObject msObj) : base(msObj) {}
 public static new msGiftInstallment FromClassMetadata(ClassMetadata meta){return new msGiftInstallment(MemberSuiteObject.FromClassMetadata(meta));}
public System.String InstallmentID {
get { return SafeGetValue<System.String>("InstallmentID");}
set { this["InstallmentID"] = value;}
}

public System.DateTime Date {
get { return SafeGetValue<System.DateTime>("Date");}
set { this["Date"] = value;}
}

public System.Decimal Amount {
get { return SafeGetValue<System.Decimal>("Amount");}
set { this["Amount"] = value;}
}

public System.Decimal AmountPaid {
get { return SafeGetValue<System.Decimal>("AmountPaid");}
set { this["AmountPaid"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

}
[Serializable]
public class msGiftAttribute : msAggregateChild {
public new const string CLASS_NAME = "GiftAttribute";
public new  static class FIELDS {
public const string Category = "Category";
public const string Description = "Description";
public const string Date = "Date";
public const string Comments = "Comments";
}
public msGiftAttribute() : base() {
ClassType = "GiftAttribute";
}
public msGiftAttribute( MemberSuiteObject msObj) : base(msObj) {}
 public static new msGiftAttribute FromClassMetadata(ClassMetadata meta){return new msGiftAttribute(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Category {
get { return SafeGetValue<System.String>("Category");}
set { this["Category"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.DateTime? Date {
get { return SafeGetValue<System.DateTime?>("Date");}
set { this["Date"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

}
[Serializable]
public class msGiftPremium : msAggregateChild {
public new const string CLASS_NAME = "GiftPremium";
public new  static class FIELDS {
public const string Premium = "Premium";
public const string Quantity = "Quantity";
public const string FairMarketValue = "FairMarketValue";
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
public const string Comments = "Comments";
}
public msGiftPremium() : base() {
ClassType = "GiftPremium";
}
public msGiftPremium( MemberSuiteObject msObj) : base(msObj) {}
 public static new msGiftPremium FromClassMetadata(ClassMetadata meta){return new msGiftPremium(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Premium {
get { return SafeGetValue<System.String>("Premium");}
set { this["Premium"] = value;}
}

public System.Int32 Quantity {
get { return SafeGetValue<System.Int32>("Quantity");}
set { this["Quantity"] = value;}
}

public System.Decimal FairMarketValue {
get { return SafeGetValue<System.Decimal>("FairMarketValue");}
set { this["FairMarketValue"] = value;}
}

public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

}
[Serializable]
public class msGiftSolicitor : msAggregateChild {
public new const string CLASS_NAME = "GiftSolicitor";
public new  static class FIELDS {
public const string Solicitor = "Solicitor";
public const string Amount = "Amount";
public const string Comments = "Comments";
}
public msGiftSolicitor() : base() {
ClassType = "GiftSolicitor";
}
public msGiftSolicitor( MemberSuiteObject msObj) : base(msObj) {}
 public static new msGiftSolicitor FromClassMetadata(ClassMetadata meta){return new msGiftSolicitor(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Solicitor {
get { return SafeGetValue<System.String>("Solicitor");}
set { this["Solicitor"] = value;}
}

public System.Decimal Amount {
get { return SafeGetValue<System.Decimal>("Amount");}
set { this["Amount"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

}
[Serializable]
public class msTributeType : msConfigurableType {
public new const string CLASS_NAME = "TributeType";
public new  static class FIELDS {
}
public msTributeType() : base() {
ClassType = "TributeType";
}
public msTributeType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msTributeType FromClassMetadata(ClassMetadata meta){return new msTributeType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msAssociationProvisioningJob : msJob {
public new const string CLASS_NAME = "AssociationProvisioningJob";
public new  static class FIELDS {
public const string SourcePartitionKey = "SourcePartitionKey";
public const string IncludeDataInCopy = "IncludeDataInCopy";
}
public msAssociationProvisioningJob() : base() {
ClassType = "AssociationProvisioningJob";
}
public msAssociationProvisioningJob( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAssociationProvisioningJob FromClassMetadata(ClassMetadata meta){return new msAssociationProvisioningJob(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int64? SourcePartitionKey {
get { return SafeGetValue<System.Int64?>("SourcePartitionKey");}
set { this["SourcePartitionKey"] = value;}
}

public System.Boolean IncludeDataInCopy {
get { return SafeGetValue<System.Boolean>("IncludeDataInCopy");}
set { this["IncludeDataInCopy"] = value;}
}

}
[Serializable]
public class msInsertionOrderInvoiceGenerationJob : msJob {
public new const string CLASS_NAME = "InsertionOrderInvoiceGenerationJob";
public new  static class FIELDS {
public const string SendOutEmails = "SendOutEmails";
}
public msInsertionOrderInvoiceGenerationJob() : base() {
ClassType = "InsertionOrderInvoiceGenerationJob";
}
public msInsertionOrderInvoiceGenerationJob( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInsertionOrderInvoiceGenerationJob FromClassMetadata(ClassMetadata meta){return new msInsertionOrderInvoiceGenerationJob(MemberSuiteObject.FromClassMetadata(meta));}
public System.Boolean SendOutEmails {
get { return SafeGetValue<System.Boolean>("SendOutEmails");}
set { this["SendOutEmails"] = value;}
}

}
[Serializable]
public class msCustomJob : msJob {
public new const string CLASS_NAME = "CustomJob";
public new  static class FIELDS {
}
public msCustomJob() : base() {
ClassType = "CustomJob";
}
public msCustomJob( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomJob FromClassMetadata(ClassMetadata meta){return new msCustomJob(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msMoveAbstractsJob : msJob {
public new const string CLASS_NAME = "MoveAbstractsJob";
public new  static class FIELDS {
public const string Competition = "Competition";
}
public msMoveAbstractsJob() : base() {
ClassType = "MoveAbstractsJob";
}
public msMoveAbstractsJob( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMoveAbstractsJob FromClassMetadata(ClassMetadata meta){return new msMoveAbstractsJob(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Competition {
get { return SafeGetValue<System.String>("Competition");}
set { this["Competition"] = value;}
}

}
[Serializable]
public class msMessagingJob : msJob {
public new const string CLASS_NAME = "MessagingJob";
public new  static class FIELDS {
public const string IsTemplate = "IsTemplate";
public const string ParentJob = "ParentJob";
public const string RecipientType = "RecipientType";
public const string Search = "Search";
public const string Category = "Category";
public const string Subject = "Subject";
public const string AutomaticallyGenerateTextBody = "AutomaticallyGenerateTextBody";
public const string SearchCriteria = "SearchCriteria";
public const string FromName = "FromName";
public const string HtmlBody = "HtmlBody";
public const string TextBody = "TextBody";
public const string DateScheduled = "DateScheduled";
public const string EmailAddressesToSuppress = "EmailAddressesToSuppress";
public const string Bcc = "Bcc";
public const string Cc = "Cc";
public const string ReplyTo = "ReplyTo";
}
public msMessagingJob() : base() {
ClassType = "MessagingJob";
EmailAddressesToSuppress = new System.Collections.Generic.List<System.String>();
}
public msMessagingJob( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMessagingJob FromClassMetadata(ClassMetadata meta){return new msMessagingJob(MemberSuiteObject.FromClassMetadata(meta));}
public System.Boolean IsTemplate {
get { return SafeGetValue<System.Boolean>("IsTemplate");}
set { this["IsTemplate"] = value;}
}

public System.String ParentJob {
get { return SafeGetValue<System.String>("ParentJob");}
set { this["ParentJob"] = value;}
}

public System.String RecipientType {
get { return SafeGetValue<System.String>("RecipientType");}
set { this["RecipientType"] = value;}
}

public MemberSuite.SDK.Searching.Search Search {
get { return SafeGetValue<MemberSuite.SDK.Searching.Search>("Search");}
set { this["Search"] = value;}
}

public System.String Category {
get { return SafeGetValue<System.String>("Category");}
set { this["Category"] = value;}
}

public System.String Subject {
get { return SafeGetValue<System.String>("Subject");}
set { this["Subject"] = value;}
}

public System.Boolean AutomaticallyGenerateTextBody {
get { return SafeGetValue<System.Boolean>("AutomaticallyGenerateTextBody");}
set { this["AutomaticallyGenerateTextBody"] = value;}
}

public System.String SearchCriteria {
get { return SafeGetValue<System.String>("SearchCriteria");}
set { this["SearchCriteria"] = value;}
}

public System.String FromName {
get { return SafeGetValue<System.String>("FromName");}
set { this["FromName"] = value;}
}

public System.String HtmlBody {
get { return SafeGetValue<System.String>("HtmlBody");}
set { this["HtmlBody"] = value;}
}

public System.String TextBody {
get { return SafeGetValue<System.String>("TextBody");}
set { this["TextBody"] = value;}
}

public System.DateTime? DateScheduled {
get { return SafeGetValue<System.DateTime?>("DateScheduled");}
set { this["DateScheduled"] = value;}
}

public System.Collections.Generic.List<System.String> EmailAddressesToSuppress {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("EmailAddressesToSuppress");}
set { this["EmailAddressesToSuppress"] = value;}
}

public System.String Bcc {
get { return SafeGetValue<System.String>("Bcc");}
set { this["Bcc"] = value;}
}

public System.String Cc {
get { return SafeGetValue<System.String>("Cc");}
set { this["Cc"] = value;}
}

public System.String ReplyTo {
get { return SafeGetValue<System.String>("ReplyTo");}
set { this["ReplyTo"] = value;}
}

}
[Serializable]
public class msMembershipRenewalJob : msJob {
public new const string CLASS_NAME = "MembershipRenewalJob";
public new  static class FIELDS {
public const string SendOutEmails = "SendOutEmails";
}
public msMembershipRenewalJob() : base() {
ClassType = "MembershipRenewalJob";
}
public msMembershipRenewalJob( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipRenewalJob FromClassMetadata(ClassMetadata meta){return new msMembershipRenewalJob(MemberSuiteObject.FromClassMetadata(meta));}
public System.Boolean SendOutEmails {
get { return SafeGetValue<System.Boolean>("SendOutEmails");}
set { this["SendOutEmails"] = value;}
}

}
[Serializable]
public class msWriteOffInvoicesJob : msJob {
public new const string CLASS_NAME = "WriteOffInvoicesJob";
public new  static class FIELDS {
public const string Manifest = "Manifest";
public const string ListOfIDs = "ListOfIDs";
}
public msWriteOffInvoicesJob() : base() {
ClassType = "WriteOffInvoicesJob";
ListOfIDs = new System.Collections.Generic.List<System.String>();
}
public msWriteOffInvoicesJob( MemberSuiteObject msObj) : base(msObj) {}
 public static new msWriteOffInvoicesJob FromClassMetadata(ClassMetadata meta){return new msWriteOffInvoicesJob(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.WriteOffInvoicesJobManifest Manifest {
get { return SafeGetValue<MemberSuite.SDK.Types.WriteOffInvoicesJobManifest>("Manifest");}
set { this["Manifest"] = value;}
}

public System.Collections.Generic.List<System.String> ListOfIDs {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("ListOfIDs");}
set { this["ListOfIDs"] = value;}
}

}
[Serializable]
public class msChapter : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Chapter";
public new  static class FIELDS {
public const string Code = "Code";
public const string IsActive = "IsActive";
public const string MembershipOrganization = "MembershipOrganization";
public const string Type = "Type";
public const string LinkedOrganization = "LinkedOrganization";
public const string Layer = "Layer";
public const string Description = "Description";
public const string EmailAddress = "EmailAddress";
public const string Url = "Url";
public const string NewMemberConfirmationEmail = "NewMemberConfirmationEmail";
public const string RenewingMemberConfirmationEmail = "RenewingMemberConfirmationEmail";
public const string Leaders = "Leaders";
}
public msChapter() : base() {
ClassType = "Chapter";
Leaders = new System.Collections.Generic.List<msMembershipLeader>();
}
public msChapter( MemberSuiteObject msObj) : base(msObj) {}
 public static new msChapter FromClassMetadata(ClassMetadata meta){return new msChapter(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.String MembershipOrganization {
get { return SafeGetValue<System.String>("MembershipOrganization");}
set { this["MembershipOrganization"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String LinkedOrganization {
get { return SafeGetValue<System.String>("LinkedOrganization");}
set { this["LinkedOrganization"] = value;}
}

public System.String Layer {
get { return SafeGetValue<System.String>("Layer");}
set { this["Layer"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String EmailAddress {
get { return SafeGetValue<System.String>("EmailAddress");}
set { this["EmailAddress"] = value;}
}

public System.String Url {
get { return SafeGetValue<System.String>("Url");}
set { this["Url"] = value;}
}

public MemberSuite.SDK.Types.EmailTemplate NewMemberConfirmationEmail {
get { return SafeGetValue<MemberSuite.SDK.Types.EmailTemplate>("NewMemberConfirmationEmail");}
set { this["NewMemberConfirmationEmail"] = value;}
}

public MemberSuite.SDK.Types.EmailTemplate RenewingMemberConfirmationEmail {
get { return SafeGetValue<MemberSuite.SDK.Types.EmailTemplate>("RenewingMemberConfirmationEmail");}
set { this["RenewingMemberConfirmationEmail"] = value;}
}

public System.Collections.Generic.List<msMembershipLeader> Leaders {
get { return SafeGetValue<System.Collections.Generic.List<msMembershipLeader>>("Leaders");}
set { this["Leaders"] = value;}
}

}
[Serializable]
public class msPageLayoutConfigurableType : msConfigurableType {
public new const string CLASS_NAME = "PageLayoutConfigurableType";
public new  static class FIELDS {
public const string CreatePageLayout = "CreatePageLayout";
public const string EditPageLayout = "EditPageLayout";
public const string ViewPageLayout = "ViewPageLayout";
public const string PortalPageLayout = "PortalPageLayout";
}
public msPageLayoutConfigurableType() : base() {
ClassType = "PageLayoutConfigurableType";
}
public msPageLayoutConfigurableType( MemberSuiteObject msObj) : base(msObj) {}
public System.String CreatePageLayout {
get { return SafeGetValue<System.String>("CreatePageLayout");}
set { this["CreatePageLayout"] = value;}
}

public System.String EditPageLayout {
get { return SafeGetValue<System.String>("EditPageLayout");}
set { this["EditPageLayout"] = value;}
}

public System.String ViewPageLayout {
get { return SafeGetValue<System.String>("ViewPageLayout");}
set { this["ViewPageLayout"] = value;}
}

public System.String PortalPageLayout {
get { return SafeGetValue<System.String>("PortalPageLayout");}
set { this["PortalPageLayout"] = value;}
}

}
[Serializable]
public class msChapterType : msPageLayoutConfigurableType {
public new const string CLASS_NAME = "ChapterType";
public new  static class FIELDS {
public const string MembershipOrganization = "MembershipOrganization";
public const string RestrictMembershipTypes = "RestrictMembershipTypes";
public const string AllowedMembershipTypes = "AllowedMembershipTypes";
}
public msChapterType() : base() {
ClassType = "ChapterType";
AllowedMembershipTypes = new System.Collections.Generic.List<System.String>();
}
public msChapterType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msChapterType FromClassMetadata(ClassMetadata meta){return new msChapterType(MemberSuiteObject.FromClassMetadata(meta));}
public System.String MembershipOrganization {
get { return SafeGetValue<System.String>("MembershipOrganization");}
set { this["MembershipOrganization"] = value;}
}

public System.Boolean RestrictMembershipTypes {
get { return SafeGetValue<System.Boolean>("RestrictMembershipTypes");}
set { this["RestrictMembershipTypes"] = value;}
}

public System.Collections.Generic.List<System.String> AllowedMembershipTypes {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("AllowedMembershipTypes");}
set { this["AllowedMembershipTypes"] = value;}
}

}
[Serializable]
public class msMembershipProductBase : msProduct {
public new const string CLASS_NAME = "MembershipProductBase";
public new  static class FIELDS {
public const string MembershipOrganization = "MembershipOrganization";
}
public msMembershipProductBase() : base() {
ClassType = "MembershipProductBase";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msMembershipProductBase( MemberSuiteObject msObj) : base(msObj) {}
public System.String MembershipOrganization {
get { return SafeGetValue<System.String>("MembershipOrganization");}
set { this["MembershipOrganization"] = value;}
}

}
[Serializable]
public class msOrganizationalLayerDuesProduct : msMembershipProductBase {
public new const string CLASS_NAME = "OrganizationalLayerDuesProduct";
public new  static class FIELDS {
public const string OrganizationalLayer = "OrganizationalLayer";
public const string MembershipType = "MembershipType";
}
public msOrganizationalLayerDuesProduct() : base() {
ClassType = "OrganizationalLayerDuesProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msOrganizationalLayerDuesProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msOrganizationalLayerDuesProduct FromClassMetadata(ClassMetadata meta){return new msOrganizationalLayerDuesProduct(MemberSuiteObject.FromClassMetadata(meta));}
public System.String OrganizationalLayer {
get { return SafeGetValue<System.String>("OrganizationalLayer");}
set { this["OrganizationalLayer"] = value;}
}

public System.String MembershipType {
get { return SafeGetValue<System.String>("MembershipType");}
set { this["MembershipType"] = value;}
}

}
[Serializable]
public class msMembershipInformationLink : msInformationLink {
public new const string CLASS_NAME = "MembershipInformationLink";
public new  static class FIELDS {
}
public msMembershipInformationLink() : base() {
ClassType = "MembershipInformationLink";
}
public msMembershipInformationLink( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipInformationLink FromClassMetadata(ClassMetadata meta){return new msMembershipInformationLink(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msMembershipLeader : msAggregateChild {
public new const string CLASS_NAME = "MembershipLeader";
public new  static class FIELDS {
public const string Individual = "Individual";
public const string CanCreateMembers = "CanCreateMembers";
public const string CanDownloadRoster = "CanDownloadRoster";
public const string CanMakePayments = "CanMakePayments";
public const string CanManageCommittees = "CanManageCommittees";
public const string CanManageEvents = "CanManageEvents";
public const string CanManageLeaders = "CanManageLeaders";
public const string CanUpdateContactInfo = "CanUpdateContactInfo";
public const string CanUpdateInformation = "CanUpdateInformation";
public const string CanUpdateMembershipInfo = "CanUpdateMembershipInfo";
public const string CanViewAccountHistory = "CanViewAccountHistory";
public const string CanViewMembers = "CanViewMembers";
public const string CanLoginAs = "CanLoginAs";
public const string CanManageDocuments = "CanManageDocuments";
public const string CanModerateDiscussions = "CanModerateDiscussions";
}
public msMembershipLeader() : base() {
ClassType = "MembershipLeader";
}
public msMembershipLeader( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipLeader FromClassMetadata(ClassMetadata meta){return new msMembershipLeader(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Individual {
get { return SafeGetValue<System.String>("Individual");}
set { this["Individual"] = value;}
}

public System.Boolean CanCreateMembers {
get { return SafeGetValue<System.Boolean>("CanCreateMembers");}
set { this["CanCreateMembers"] = value;}
}

public System.Boolean CanDownloadRoster {
get { return SafeGetValue<System.Boolean>("CanDownloadRoster");}
set { this["CanDownloadRoster"] = value;}
}

public System.Boolean CanMakePayments {
get { return SafeGetValue<System.Boolean>("CanMakePayments");}
set { this["CanMakePayments"] = value;}
}

public System.Boolean CanManageCommittees {
get { return SafeGetValue<System.Boolean>("CanManageCommittees");}
set { this["CanManageCommittees"] = value;}
}

public System.Boolean CanManageEvents {
get { return SafeGetValue<System.Boolean>("CanManageEvents");}
set { this["CanManageEvents"] = value;}
}

public System.Boolean CanManageLeaders {
get { return SafeGetValue<System.Boolean>("CanManageLeaders");}
set { this["CanManageLeaders"] = value;}
}

public System.Boolean CanUpdateContactInfo {
get { return SafeGetValue<System.Boolean>("CanUpdateContactInfo");}
set { this["CanUpdateContactInfo"] = value;}
}

public System.Boolean CanUpdateInformation {
get { return SafeGetValue<System.Boolean>("CanUpdateInformation");}
set { this["CanUpdateInformation"] = value;}
}

public System.Boolean CanUpdateMembershipInfo {
get { return SafeGetValue<System.Boolean>("CanUpdateMembershipInfo");}
set { this["CanUpdateMembershipInfo"] = value;}
}

public System.Boolean CanViewAccountHistory {
get { return SafeGetValue<System.Boolean>("CanViewAccountHistory");}
set { this["CanViewAccountHistory"] = value;}
}

public System.Boolean CanViewMembers {
get { return SafeGetValue<System.Boolean>("CanViewMembers");}
set { this["CanViewMembers"] = value;}
}

public System.Boolean CanLoginAs {
get { return SafeGetValue<System.Boolean>("CanLoginAs");}
set { this["CanLoginAs"] = value;}
}

public System.Boolean CanManageDocuments {
get { return SafeGetValue<System.Boolean>("CanManageDocuments");}
set { this["CanManageDocuments"] = value;}
}

public System.Boolean CanModerateDiscussions {
get { return SafeGetValue<System.Boolean>("CanModerateDiscussions");}
set { this["CanModerateDiscussions"] = value;}
}

}
[Serializable]
public class msMembershipMerchandise : msMembershipProductBase {
public new const string CLASS_NAME = "MembershipMerchandise";
public new  static class FIELDS {
public const string AutoRenew = "AutoRenew";
}
public msMembershipMerchandise() : base() {
ClassType = "MembershipMerchandise";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msMembershipMerchandise( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipMerchandise FromClassMetadata(ClassMetadata meta){return new msMembershipMerchandise(MemberSuiteObject.FromClassMetadata(meta));}
public System.Boolean AutoRenew {
get { return SafeGetValue<System.Boolean>("AutoRenew");}
set { this["AutoRenew"] = value;}
}

}
[Serializable]
public class msMembershipOrganization : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "MembershipOrganization";
public new  static class FIELDS {
public const string ParentOrganization = "ParentOrganization";
public const string BusinessUnit = "BusinessUnit";
public const string IsDefault = "IsDefault";
public const string SectionMode = "SectionMode";
public const string ChapterMode = "ChapterMode";
public const string AutomaticallyUpdateChapter = "AutomaticallyUpdateChapter";
public const string NewMemberConfirmationEmail = "NewMemberConfirmationEmail";
public const string RenewingMemberConfirmationEmail = "RenewingMemberConfirmationEmail";
public const string InvoiceType = "InvoiceType";
public const string ChapterPostalCodeMappingMode = "ChapterPostalCodeMappingMode";
public const string MembersShouldInheritPreviousChapterUponRenewal = "MembersShouldInheritPreviousChapterUponRenewal";
public const string NumberOfDaysPriorToExpirationToPromptForRenewal = "NumberOfDaysPriorToExpirationToPromptForRenewal";
public const string MembersCanJoinThroughThePortal = "MembersCanJoinThroughThePortal";
public const string MembersCanRenewThroughThePortal = "MembersCanRenewThroughThePortal";
public const string LeaderSearchFields = "LeaderSearchFields";
public const string LeaderSearchResultsFields = "LeaderSearchResultsFields";
public const string ReinstatementPeriod = "ReinstatementPeriod";
public const string UseFreshJoinDateForReinstatedMembers = "UseFreshJoinDateForReinstatedMembers";
public const string GiveRenewalPricingDuringReinstatementPeriod = "GiveRenewalPricingDuringReinstatementPeriod";
public const string UseCurrentDateAsBasisForExpirationOfReinstatedMembership = "UseCurrentDateAsBasisForExpirationOfReinstatedMembership";
public const string TermsOfService = "TermsOfService";
}
public msMembershipOrganization() : base() {
ClassType = "MembershipOrganization";
LeaderSearchFields = new System.Collections.Generic.List<System.String>();
LeaderSearchResultsFields = new System.Collections.Generic.List<System.String>();
}
public msMembershipOrganization( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipOrganization FromClassMetadata(ClassMetadata meta){return new msMembershipOrganization(MemberSuiteObject.FromClassMetadata(meta));}
public System.String ParentOrganization {
get { return SafeGetValue<System.String>("ParentOrganization");}
set { this["ParentOrganization"] = value;}
}

public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public System.Boolean IsDefault {
get { return SafeGetValue<System.Boolean>("IsDefault");}
set { this["IsDefault"] = value;}
}

public MemberSuite.SDK.Types.SectionMode SectionMode {
get { return SafeGetValue<MemberSuite.SDK.Types.SectionMode>("SectionMode");}
set { this["SectionMode"] = value;}
}

public MemberSuite.SDK.Types.ChapterMode ChapterMode {
get { return SafeGetValue<MemberSuite.SDK.Types.ChapterMode>("ChapterMode");}
set { this["ChapterMode"] = value;}
}

public System.Boolean AutomaticallyUpdateChapter {
get { return SafeGetValue<System.Boolean>("AutomaticallyUpdateChapter");}
set { this["AutomaticallyUpdateChapter"] = value;}
}

public System.String NewMemberConfirmationEmail {
get { return SafeGetValue<System.String>("NewMemberConfirmationEmail");}
set { this["NewMemberConfirmationEmail"] = value;}
}

public System.String RenewingMemberConfirmationEmail {
get { return SafeGetValue<System.String>("RenewingMemberConfirmationEmail");}
set { this["RenewingMemberConfirmationEmail"] = value;}
}

public System.String InvoiceType {
get { return SafeGetValue<System.String>("InvoiceType");}
set { this["InvoiceType"] = value;}
}

public MemberSuite.SDK.Types.ChapterPostalCodeMappingMode ChapterPostalCodeMappingMode {
get { return SafeGetValue<MemberSuite.SDK.Types.ChapterPostalCodeMappingMode>("ChapterPostalCodeMappingMode");}
set { this["ChapterPostalCodeMappingMode"] = value;}
}

public System.Boolean MembersShouldInheritPreviousChapterUponRenewal {
get { return SafeGetValue<System.Boolean>("MembersShouldInheritPreviousChapterUponRenewal");}
set { this["MembersShouldInheritPreviousChapterUponRenewal"] = value;}
}

public System.Int32 NumberOfDaysPriorToExpirationToPromptForRenewal {
get { return SafeGetValue<System.Int32>("NumberOfDaysPriorToExpirationToPromptForRenewal");}
set { this["NumberOfDaysPriorToExpirationToPromptForRenewal"] = value;}
}

public System.Boolean MembersCanJoinThroughThePortal {
get { return SafeGetValue<System.Boolean>("MembersCanJoinThroughThePortal");}
set { this["MembersCanJoinThroughThePortal"] = value;}
}

public System.Boolean MembersCanRenewThroughThePortal {
get { return SafeGetValue<System.Boolean>("MembersCanRenewThroughThePortal");}
set { this["MembersCanRenewThroughThePortal"] = value;}
}

public System.Collections.Generic.List<System.String> LeaderSearchFields {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("LeaderSearchFields");}
set { this["LeaderSearchFields"] = value;}
}

public System.Collections.Generic.List<System.String> LeaderSearchResultsFields {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("LeaderSearchResultsFields");}
set { this["LeaderSearchResultsFields"] = value;}
}

public System.Int16 ReinstatementPeriod {
get { return SafeGetValue<System.Int16>("ReinstatementPeriod");}
set { this["ReinstatementPeriod"] = value;}
}

public System.Boolean UseFreshJoinDateForReinstatedMembers {
get { return SafeGetValue<System.Boolean>("UseFreshJoinDateForReinstatedMembers");}
set { this["UseFreshJoinDateForReinstatedMembers"] = value;}
}

public System.Boolean GiveRenewalPricingDuringReinstatementPeriod {
get { return SafeGetValue<System.Boolean>("GiveRenewalPricingDuringReinstatementPeriod");}
set { this["GiveRenewalPricingDuringReinstatementPeriod"] = value;}
}

public System.Boolean UseCurrentDateAsBasisForExpirationOfReinstatedMembership {
get { return SafeGetValue<System.Boolean>("UseCurrentDateAsBasisForExpirationOfReinstatedMembership");}
set { this["UseCurrentDateAsBasisForExpirationOfReinstatedMembership"] = value;}
}

public System.String TermsOfService {
get { return SafeGetValue<System.String>("TermsOfService");}
set { this["TermsOfService"] = value;}
}

}
[Serializable]
public class msMembershipRenewalBatch : msAssociationDomainObject {
public new const string CLASS_NAME = "MembershipRenewalBatch";
public new  static class FIELDS {
public const string MembershipOrganization = "MembershipOrganization";
public const string Status = "Status";
public const string CompletionDate = "CompletionDate";
public const string Batch = "Batch";
public const string SearchToUse = "SearchToUse";
}
public msMembershipRenewalBatch() : base() {
ClassType = "MembershipRenewalBatch";
}
public msMembershipRenewalBatch( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipRenewalBatch FromClassMetadata(ClassMetadata meta){return new msMembershipRenewalBatch(MemberSuiteObject.FromClassMetadata(meta));}
public System.String MembershipOrganization {
get { return SafeGetValue<System.String>("MembershipOrganization");}
set { this["MembershipOrganization"] = value;}
}

public MemberSuite.SDK.Types.JobStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.JobStatus>("Status");}
set { this["Status"] = value;}
}

public System.DateTime? CompletionDate {
get { return SafeGetValue<System.DateTime?>("CompletionDate");}
set { this["CompletionDate"] = value;}
}

public System.String Batch {
get { return SafeGetValue<System.String>("Batch");}
set { this["Batch"] = value;}
}

public MemberSuite.SDK.Searching.Search SearchToUse {
get { return SafeGetValue<MemberSuite.SDK.Searching.Search>("SearchToUse");}
set { this["SearchToUse"] = value;}
}

}
[Serializable]
public class msMembershipStatus : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "MembershipStatus";
public new  static class FIELDS {
public const string FlipStatus = "FlipStatus";
}
public msMembershipStatus() : base() {
ClassType = "MembershipStatus";
}
public msMembershipStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipStatus FromClassMetadata(ClassMetadata meta){return new msMembershipStatus(MemberSuiteObject.FromClassMetadata(meta));}
public System.String FlipStatus {
get { return SafeGetValue<System.String>("FlipStatus");}
set { this["FlipStatus"] = value;}
}

}
[Serializable]
public class msTerminationReason : msConfigurableType {
public new const string CLASS_NAME = "TerminationReason";
public new  static class FIELDS {
}
public msTerminationReason() : base() {
ClassType = "TerminationReason";
}
public msTerminationReason( MemberSuiteObject msObj) : base(msObj) {}
 public static new msTerminationReason FromClassMetadata(ClassMetadata meta){return new msTerminationReason(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msCustomReport : msMetadataContainer {
public new const string CLASS_NAME = "CustomReport";
public new  static class FIELDS {
public const string Metadata = "Metadata";
}
public msCustomReport() : base() {
ClassType = "CustomReport";
}
public msCustomReport( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomReport FromClassMetadata(ClassMetadata meta){return new msCustomReport(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Metadata {
get { return SafeGetValue<System.String>("Metadata");}
set { this["Metadata"] = value;}
}

}
[Serializable]
public class msSearchSpecificationContainer : msMetadataContainer {
public new const string CLASS_NAME = "SearchSpecificationContainer";
public new  static class FIELDS {
public const string Manifest = "Manifest";
}
public msSearchSpecificationContainer() : base() {
ClassType = "SearchSpecificationContainer";
}
public msSearchSpecificationContainer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSearchSpecificationContainer FromClassMetadata(ClassMetadata meta){return new msSearchSpecificationContainer(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.SearchSpecificationOverride Manifest {
get { return SafeGetValue<MemberSuite.SDK.Types.SearchSpecificationOverride>("Manifest");}
set { this["Manifest"] = value;}
}

}
[Serializable]
public class msDiscountProduct : msProduct {
public new const string CLASS_NAME = "DiscountProduct";
public new  static class FIELDS {
}
public msDiscountProduct() : base() {
ClassType = "DiscountProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msDiscountProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDiscountProduct FromClassMetadata(ClassMetadata meta){return new msDiscountProduct(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msFulfillmentBatch : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "FulfillmentBatch";
public new  static class FIELDS {
public const string IsClosed = "IsClosed";
public const string DateClosed = "DateClosed";
public const string ClosedBy = "ClosedBy";
public const string Notes = "Notes";
public const string LineItems = "LineItems";
}
public msFulfillmentBatch() : base() {
ClassType = "FulfillmentBatch";
LineItems = new System.Collections.Generic.List<msFulfillmentBatchLineItem>();
}
public msFulfillmentBatch( MemberSuiteObject msObj) : base(msObj) {}
 public static new msFulfillmentBatch FromClassMetadata(ClassMetadata meta){return new msFulfillmentBatch(MemberSuiteObject.FromClassMetadata(meta));}
public System.Boolean IsClosed {
get { return SafeGetValue<System.Boolean>("IsClosed");}
set { this["IsClosed"] = value;}
}

public System.DateTime? DateClosed {
get { return SafeGetValue<System.DateTime?>("DateClosed");}
set { this["DateClosed"] = value;}
}

public System.String ClosedBy {
get { return SafeGetValue<System.String>("ClosedBy");}
set { this["ClosedBy"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Collections.Generic.List<msFulfillmentBatchLineItem> LineItems {
get { return SafeGetValue<System.Collections.Generic.List<msFulfillmentBatchLineItem>>("LineItems");}
set { this["LineItems"] = value;}
}

}
[Serializable]
public class msFulfillmentBatchLineItem : msAggregateChild {
public new const string CLASS_NAME = "FulfillmentBatchLineItem";
public new  static class FIELDS {
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
public const string QuantityShipped = "QuantityShipped";
public const string TrackingNumber = "TrackingNumber";
}
public msFulfillmentBatchLineItem() : base() {
ClassType = "FulfillmentBatchLineItem";
}
public msFulfillmentBatchLineItem( MemberSuiteObject msObj) : base(msObj) {}
 public static new msFulfillmentBatchLineItem FromClassMetadata(ClassMetadata meta){return new msFulfillmentBatchLineItem(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.Decimal QuantityShipped {
get { return SafeGetValue<System.Decimal>("QuantityShipped");}
set { this["QuantityShipped"] = value;}
}

public System.String TrackingNumber {
get { return SafeGetValue<System.String>("TrackingNumber");}
set { this["TrackingNumber"] = value;}
}

}
[Serializable]
public class msMerchandise : msProduct {
public new const string CLASS_NAME = "Merchandise";
public new  static class FIELDS {
public const string ShortDescription = "ShortDescription";
}
public msMerchandise() : base() {
ClassType = "Merchandise";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msMerchandise( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMerchandise FromClassMetadata(ClassMetadata meta){return new msMerchandise(MemberSuiteObject.FromClassMetadata(meta));}
public System.String ShortDescription {
get { return SafeGetValue<System.String>("ShortDescription");}
set { this["ShortDescription"] = value;}
}

}
[Serializable]
public class msPriceOverrideReason : msConfigurableType {
public new const string CLASS_NAME = "PriceOverrideReason";
public new  static class FIELDS {
}
public msPriceOverrideReason() : base() {
ClassType = "PriceOverrideReason";
}
public msPriceOverrideReason( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPriceOverrideReason FromClassMetadata(ClassMetadata meta){return new msPriceOverrideReason(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msReturn : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "Return";
public new  static class FIELDS {
public const string Batch = "Batch";
public const string Date = "Date";
public const string Order = "Order";
public const string Reason = "Reason";
public const string Comments = "Comments";
public const string LineItems = "LineItems";
public const string Status = "Status";
public const string GenerateRefund = "GenerateRefund";
}
public msReturn() : base() {
ClassType = "Return";
LineItems = new System.Collections.Generic.List<msReturnLineItem>();
}
public msReturn( MemberSuiteObject msObj) : base(msObj) {}
 public static new msReturn FromClassMetadata(ClassMetadata meta){return new msReturn(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Batch {
get { return SafeGetValue<System.String>("Batch");}
set { this["Batch"] = value;}
}

public System.DateTime Date {
get { return SafeGetValue<System.DateTime>("Date");}
set { this["Date"] = value;}
}

public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String Reason {
get { return SafeGetValue<System.String>("Reason");}
set { this["Reason"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

public System.Collections.Generic.List<msReturnLineItem> LineItems {
get { return SafeGetValue<System.Collections.Generic.List<msReturnLineItem>>("LineItems");}
set { this["LineItems"] = value;}
}

public MemberSuite.SDK.Types.OrderStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.OrderStatus>("Status");}
set { this["Status"] = value;}
}

public System.Boolean GenerateRefund {
get { return SafeGetValue<System.Boolean>("GenerateRefund");}
set { this["GenerateRefund"] = value;}
}

}
[Serializable]
public class msReturnLineItem : msAggregateChild {
public new const string CLASS_NAME = "ReturnLineItem";
public new  static class FIELDS {
public const string OrderLineItemID = "OrderLineItemID";
public const string Product = "Product";
public const string QuantityToCancel = "QuantityToCancel";
public const string QuantityToReturn = "QuantityToReturn";
public const string AmountToCredit = "AmountToCredit";
}
public msReturnLineItem() : base() {
ClassType = "ReturnLineItem";
}
public msReturnLineItem( MemberSuiteObject msObj) : base(msObj) {}
 public static new msReturnLineItem FromClassMetadata(ClassMetadata meta){return new msReturnLineItem(MemberSuiteObject.FromClassMetadata(meta));}
public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.String Product {
get { return SafeGetValue<System.String>("Product");}
set { this["Product"] = value;}
}

public System.Decimal QuantityToCancel {
get { return SafeGetValue<System.Decimal>("QuantityToCancel");}
set { this["QuantityToCancel"] = value;}
}

public System.Decimal QuantityToReturn {
get { return SafeGetValue<System.Decimal>("QuantityToReturn");}
set { this["QuantityToReturn"] = value;}
}

public System.Decimal AmountToCredit {
get { return SafeGetValue<System.Decimal>("AmountToCredit");}
set { this["AmountToCredit"] = value;}
}

}
[Serializable]
public class msRevenueRecognitionSchedule : msFinancialSchedule {
public new const string CLASS_NAME = "RevenueRecognitionSchedule";
public new  static class FIELDS {
public const string Entries = "Entries";
public const string BusinessUnit = "BusinessUnit";
public const string Invoice = "Invoice";
public const string InvoiceLineItemID = "InvoiceLineItemID";
public const string InvoiceAdjustment = "InvoiceAdjustment";
}
public msRevenueRecognitionSchedule() : base() {
ClassType = "RevenueRecognitionSchedule";
Entries = new System.Collections.Generic.List<msRevenueRecognitionScheduleEntry>();
}
public msRevenueRecognitionSchedule( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRevenueRecognitionSchedule FromClassMetadata(ClassMetadata meta){return new msRevenueRecognitionSchedule(MemberSuiteObject.FromClassMetadata(meta));}
public System.Collections.Generic.List<msRevenueRecognitionScheduleEntry> Entries {
get { return SafeGetValue<System.Collections.Generic.List<msRevenueRecognitionScheduleEntry>>("Entries");}
set { this["Entries"] = value;}
}

public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public System.String Invoice {
get { return SafeGetValue<System.String>("Invoice");}
set { this["Invoice"] = value;}
}

public System.String InvoiceLineItemID {
get { return SafeGetValue<System.String>("InvoiceLineItemID");}
set { this["InvoiceLineItemID"] = value;}
}

public System.String InvoiceAdjustment {
get { return SafeGetValue<System.String>("InvoiceAdjustment");}
set { this["InvoiceAdjustment"] = value;}
}

}
[Serializable]
public class msRevenueRecognitionScheduleEntry : msFinancialScheduleEntry {
public new const string CLASS_NAME = "RevenueRecognitionScheduleEntry";
public new  static class FIELDS {
public const string DeferredRevenueGL = "DeferredRevenueGL";
public const string IncomeGL = "IncomeGL";
public const string SubLedgerEntry = "SubLedgerEntry";
}
public msRevenueRecognitionScheduleEntry() : base() {
ClassType = "RevenueRecognitionScheduleEntry";
}
public msRevenueRecognitionScheduleEntry( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRevenueRecognitionScheduleEntry FromClassMetadata(ClassMetadata meta){return new msRevenueRecognitionScheduleEntry(MemberSuiteObject.FromClassMetadata(meta));}
public System.String DeferredRevenueGL {
get { return SafeGetValue<System.String>("DeferredRevenueGL");}
set { this["DeferredRevenueGL"] = value;}
}

public System.String IncomeGL {
get { return SafeGetValue<System.String>("IncomeGL");}
set { this["IncomeGL"] = value;}
}

public System.String SubLedgerEntry {
get { return SafeGetValue<System.String>("SubLedgerEntry");}
set { this["SubLedgerEntry"] = value;}
}

}
[Serializable]
public class msRevenueRecognitionTemplate : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "RevenueRecognitionTemplate";
public new  static class FIELDS {
public const string Description = "Description";
public const string RecurrenceTemplate = "RecurrenceTemplate";
}
public msRevenueRecognitionTemplate() : base() {
ClassType = "RevenueRecognitionTemplate";
}
public msRevenueRecognitionTemplate( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRevenueRecognitionTemplate FromClassMetadata(ClassMetadata meta){return new msRevenueRecognitionTemplate(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public MemberSuite.SDK.Types.FinancialRecurrenceTemplate RecurrenceTemplate {
get { return SafeGetValue<MemberSuite.SDK.Types.FinancialRecurrenceTemplate>("RecurrenceTemplate");}
set { this["RecurrenceTemplate"] = value;}
}

}
[Serializable]
public class msCommitteeMeeting : msAssociationDomainObject {
public new const string CLASS_NAME = "CommitteeMeeting";
public new  static class FIELDS {
public const string Committee = "Committee";
public const string MeetingDate = "MeetingDate";
public const string Agenda = "Agenda";
public const string Minutes = "Minutes";
public const string Notes = "Notes";
}
public msCommitteeMeeting() : base() {
ClassType = "CommitteeMeeting";
}
public msCommitteeMeeting( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCommitteeMeeting FromClassMetadata(ClassMetadata meta){return new msCommitteeMeeting(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Committee {
get { return SafeGetValue<System.String>("Committee");}
set { this["Committee"] = value;}
}

public System.DateTime MeetingDate {
get { return SafeGetValue<System.DateTime>("MeetingDate");}
set { this["MeetingDate"] = value;}
}

public System.String Agenda {
get { return SafeGetValue<System.String>("Agenda");}
set { this["Agenda"] = value;}
}

public System.String Minutes {
get { return SafeGetValue<System.String>("Minutes");}
set { this["Minutes"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msCommittee : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Committee";
public new  static class FIELDS {
public const string Code = "Code";
public const string ParentCommittee = "ParentCommittee";
public const string Type = "Type";
public const string IsOpen = "IsOpen";
public const string Chapter = "Chapter";
public const string Event = "Event";
public const string OrganizationalLayer = "OrganizationalLayer";
public const string Section = "Section";
public const string Description = "Description";
public const string ShowInPortal = "ShowInPortal";
public const string RestrictByMembershipType = "RestrictByMembershipType";
public const string ApplicableOpenMembershipTypes = "ApplicableOpenMembershipTypes";
}
public msCommittee() : base() {
ClassType = "Committee";
ApplicableOpenMembershipTypes = new System.Collections.Generic.List<System.String>();
}
public msCommittee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCommittee FromClassMetadata(ClassMetadata meta){return new msCommittee(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String ParentCommittee {
get { return SafeGetValue<System.String>("ParentCommittee");}
set { this["ParentCommittee"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.Boolean IsOpen {
get { return SafeGetValue<System.Boolean>("IsOpen");}
set { this["IsOpen"] = value;}
}

public System.String Chapter {
get { return SafeGetValue<System.String>("Chapter");}
set { this["Chapter"] = value;}
}

public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String OrganizationalLayer {
get { return SafeGetValue<System.String>("OrganizationalLayer");}
set { this["OrganizationalLayer"] = value;}
}

public System.String Section {
get { return SafeGetValue<System.String>("Section");}
set { this["Section"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Boolean ShowInPortal {
get { return SafeGetValue<System.Boolean>("ShowInPortal");}
set { this["ShowInPortal"] = value;}
}

public System.Boolean RestrictByMembershipType {
get { return SafeGetValue<System.Boolean>("RestrictByMembershipType");}
set { this["RestrictByMembershipType"] = value;}
}

public System.Collections.Generic.List<System.String> ApplicableOpenMembershipTypes {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("ApplicableOpenMembershipTypes");}
set { this["ApplicableOpenMembershipTypes"] = value;}
}

}
[Serializable]
public class msCommitteeType : msPageLayoutConfigurableType {
public new const string CLASS_NAME = "CommitteeType";
public new  static class FIELDS {
public const string EngagementScoreMultiplier = "EngagementScoreMultiplier";
}
public msCommitteeType() : base() {
ClassType = "CommitteeType";
}
public msCommitteeType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCommitteeType FromClassMetadata(ClassMetadata meta){return new msCommitteeType(MemberSuiteObject.FromClassMetadata(meta));}
public System.Decimal? EngagementScoreMultiplier {
get { return SafeGetValue<System.Decimal?>("EngagementScoreMultiplier");}
set { this["EngagementScoreMultiplier"] = value;}
}

}
[Serializable]
public class msCommitteeMembership : msAssociationDomainObject {
public new const string CLASS_NAME = "CommitteeMembership";
public new  static class FIELDS {
public const string Type = "Type";
public const string Committee = "Committee";
public const string Member = "Member";
public const string GrantPortalAdministratorPrivileges = "GrantPortalAdministratorPrivileges";
public const string Term = "Term";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string Position = "Position";
public const string Notes = "Notes";
}
public msCommitteeMembership() : base() {
ClassType = "CommitteeMembership";
}
public msCommitteeMembership( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCommitteeMembership FromClassMetadata(ClassMetadata meta){return new msCommitteeMembership(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.CommitteeMembershipType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.CommitteeMembershipType>("Type");}
set { this["Type"] = value;}
}

public System.String Committee {
get { return SafeGetValue<System.String>("Committee");}
set { this["Committee"] = value;}
}

public System.String Member {
get { return SafeGetValue<System.String>("Member");}
set { this["Member"] = value;}
}

public System.Boolean GrantPortalAdministratorPrivileges {
get { return SafeGetValue<System.Boolean>("GrantPortalAdministratorPrivileges");}
set { this["GrantPortalAdministratorPrivileges"] = value;}
}

public System.String Term {
get { return SafeGetValue<System.String>("Term");}
set { this["Term"] = value;}
}

public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? EndDate {
get { return SafeGetValue<System.DateTime?>("EndDate");}
set { this["EndDate"] = value;}
}

public System.String Position {
get { return SafeGetValue<System.String>("Position");}
set { this["Position"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msCommitteePosition : msConfigurableType {
public new const string CLASS_NAME = "CommitteePosition";
public new  static class FIELDS {
public const string AppliesToChapters = "AppliesToChapters";
public const string AppliesToSections = "AppliesToSections";
public const string AppliesToOrganizationalLayers = "AppliesToOrganizationalLayers";
public const string AppliesToEvents = "AppliesToEvents";
}
public msCommitteePosition() : base() {
ClassType = "CommitteePosition";
}
public msCommitteePosition( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCommitteePosition FromClassMetadata(ClassMetadata meta){return new msCommitteePosition(MemberSuiteObject.FromClassMetadata(meta));}
public System.Boolean AppliesToChapters {
get { return SafeGetValue<System.Boolean>("AppliesToChapters");}
set { this["AppliesToChapters"] = value;}
}

public System.Boolean AppliesToSections {
get { return SafeGetValue<System.Boolean>("AppliesToSections");}
set { this["AppliesToSections"] = value;}
}

public System.Boolean AppliesToOrganizationalLayers {
get { return SafeGetValue<System.Boolean>("AppliesToOrganizationalLayers");}
set { this["AppliesToOrganizationalLayers"] = value;}
}

public System.Boolean AppliesToEvents {
get { return SafeGetValue<System.Boolean>("AppliesToEvents");}
set { this["AppliesToEvents"] = value;}
}

}
[Serializable]
public class msCommitteeTerm : msAssociationDomainObject {
public new const string CLASS_NAME = "CommitteeTerm";
public new  static class FIELDS {
public const string Committee = "Committee";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
}
public msCommitteeTerm() : base() {
ClassType = "CommitteeTerm";
}
public msCommitteeTerm( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCommitteeTerm FromClassMetadata(ClassMetadata meta){return new msCommitteeTerm(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Committee {
get { return SafeGetValue<System.String>("Committee");}
set { this["Committee"] = value;}
}

public System.DateTime StartDate {
get { return SafeGetValue<System.DateTime>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime EndDate {
get { return SafeGetValue<System.DateTime>("EndDate");}
set { this["EndDate"] = value;}
}

}
[Serializable]
public class msActivityType : msConfigurableType {
public new const string CLASS_NAME = "ActivityType";
public new  static class FIELDS {
public const string EngagementScoreMultiplier = "EngagementScoreMultiplier";
}
public msActivityType() : base() {
ClassType = "ActivityType";
}
public msActivityType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msActivityType FromClassMetadata(ClassMetadata meta){return new msActivityType(MemberSuiteObject.FromClassMetadata(meta));}
public System.Decimal? EngagementScoreMultiplier {
get { return SafeGetValue<System.Decimal?>("EngagementScoreMultiplier");}
set { this["EngagementScoreMultiplier"] = value;}
}

}
[Serializable]
public class msEvent : msEventBase {
public new const string CLASS_NAME = "Event";
public new  static class FIELDS {
public const string Code = "Code";
public const string Type = "Type";
public const string Category = "Category";
public const string EnableAbstracts = "EnableAbstracts";
public const string AllowEditAbstracts = "AllowEditAbstracts";
public const string AcceptAbstractsFrom = "AcceptAbstractsFrom";
public const string AcceptAbstractsUntil = "AcceptAbstractsUntil";
public const string Location = "Location";
public const string Chapter = "Chapter";
public const string OrganizationalLayer = "OrganizationalLayer";
public const string Section = "Section";
public const string MerchantAccount = "MerchantAccount";
public const string DefaultAgenda = "DefaultAgenda";
public const string EnableGroupRegistrations = "EnableGroupRegistrations";
public const string IncludeInEntitySearch = "IncludeInEntitySearch";
public const string InviteOnly = "InviteOnly";
public const string AllowGroupRegistrationsFrom = "AllowGroupRegistrationsFrom";
public const string AllowGroupRegistrationsUntil = "AllowGroupRegistrationsUntil";
public const string WorkshopSubmissionInstructions = "WorkshopSubmissionInstructions";
public const string WorkshopConfirmationInstructions = "WorkshopConfirmationInstructions";
public const string RegistrationTypeSelectionInstructions = "RegistrationTypeSelectionInstructions";
public const string SessionSelectionInstructions = "SessionSelectionInstructions";
public const string PreceedingEvent = "PreceedingEvent";
public const string NextEvent = "NextEvent";
public const string RegistrationFeeInstructions = "RegistrationFeeInstructions";
public const string RegistrationFormInstructions = "RegistrationFormInstructions";
public const string AcknowledgementText = "AcknowledgementText";
public const string GroupRegistrationRelationshipTypes = "GroupRegistrationRelationshipTypes";
public const string DisplayStartEndDateTimesAs = "DisplayStartEndDateTimesAs";
public const string IsClosed = "IsClosed";
}
public msEvent() : base() {
ClassType = "Event";
GroupRegistrationRelationshipTypes = new System.Collections.Generic.List<System.String>();
Courses = new System.Collections.Generic.List<msSessionCourse>();
Speakers = new System.Collections.Generic.List<msSessionSpeaker>();
}
public msEvent( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEvent FromClassMetadata(ClassMetadata meta){return new msEvent(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Category {
get { return SafeGetValue<System.String>("Category");}
set { this["Category"] = value;}
}

public System.Boolean EnableAbstracts {
get { return SafeGetValue<System.Boolean>("EnableAbstracts");}
set { this["EnableAbstracts"] = value;}
}

public System.Boolean AllowEditAbstracts {
get { return SafeGetValue<System.Boolean>("AllowEditAbstracts");}
set { this["AllowEditAbstracts"] = value;}
}

public System.DateTime? AcceptAbstractsFrom {
get { return SafeGetValue<System.DateTime?>("AcceptAbstractsFrom");}
set { this["AcceptAbstractsFrom"] = value;}
}

public System.DateTime? AcceptAbstractsUntil {
get { return SafeGetValue<System.DateTime?>("AcceptAbstractsUntil");}
set { this["AcceptAbstractsUntil"] = value;}
}

public MemberSuite.SDK.Types.Address Location {
get { return SafeGetValue<MemberSuite.SDK.Types.Address>("Location");}
set { this["Location"] = value;}
}

public System.String Chapter {
get { return SafeGetValue<System.String>("Chapter");}
set { this["Chapter"] = value;}
}

public System.String OrganizationalLayer {
get { return SafeGetValue<System.String>("OrganizationalLayer");}
set { this["OrganizationalLayer"] = value;}
}

public System.String Section {
get { return SafeGetValue<System.String>("Section");}
set { this["Section"] = value;}
}

public System.String MerchantAccount {
get { return SafeGetValue<System.String>("MerchantAccount");}
set { this["MerchantAccount"] = value;}
}

public System.String DefaultAgenda {
get { return SafeGetValue<System.String>("DefaultAgenda");}
set { this["DefaultAgenda"] = value;}
}

public System.Boolean EnableGroupRegistrations {
get { return SafeGetValue<System.Boolean>("EnableGroupRegistrations");}
set { this["EnableGroupRegistrations"] = value;}
}

public System.Boolean IncludeInEntitySearch {
get { return SafeGetValue<System.Boolean>("IncludeInEntitySearch");}
set { this["IncludeInEntitySearch"] = value;}
}

public System.Boolean InviteOnly {
get { return SafeGetValue<System.Boolean>("InviteOnly");}
set { this["InviteOnly"] = value;}
}

public System.DateTime? AllowGroupRegistrationsFrom {
get { return SafeGetValue<System.DateTime?>("AllowGroupRegistrationsFrom");}
set { this["AllowGroupRegistrationsFrom"] = value;}
}

public System.DateTime? AllowGroupRegistrationsUntil {
get { return SafeGetValue<System.DateTime?>("AllowGroupRegistrationsUntil");}
set { this["AllowGroupRegistrationsUntil"] = value;}
}

public System.String WorkshopSubmissionInstructions {
get { return SafeGetValue<System.String>("WorkshopSubmissionInstructions");}
set { this["WorkshopSubmissionInstructions"] = value;}
}

public System.String WorkshopConfirmationInstructions {
get { return SafeGetValue<System.String>("WorkshopConfirmationInstructions");}
set { this["WorkshopConfirmationInstructions"] = value;}
}

public System.String RegistrationTypeSelectionInstructions {
get { return SafeGetValue<System.String>("RegistrationTypeSelectionInstructions");}
set { this["RegistrationTypeSelectionInstructions"] = value;}
}

public System.String SessionSelectionInstructions {
get { return SafeGetValue<System.String>("SessionSelectionInstructions");}
set { this["SessionSelectionInstructions"] = value;}
}

public System.String PreceedingEvent {
get { return SafeGetValue<System.String>("PreceedingEvent");}
set { this["PreceedingEvent"] = value;}
}

public System.String NextEvent {
get { return SafeGetValue<System.String>("NextEvent");}
set { this["NextEvent"] = value;}
}

public System.String RegistrationFeeInstructions {
get { return SafeGetValue<System.String>("RegistrationFeeInstructions");}
set { this["RegistrationFeeInstructions"] = value;}
}

public System.String RegistrationFormInstructions {
get { return SafeGetValue<System.String>("RegistrationFormInstructions");}
set { this["RegistrationFormInstructions"] = value;}
}

public System.String AcknowledgementText {
get { return SafeGetValue<System.String>("AcknowledgementText");}
set { this["AcknowledgementText"] = value;}
}

public System.Collections.Generic.List<System.String> GroupRegistrationRelationshipTypes {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("GroupRegistrationRelationshipTypes");}
set { this["GroupRegistrationRelationshipTypes"] = value;}
}

public System.String DisplayStartEndDateTimesAs {
get { return SafeGetValue<System.String>("DisplayStartEndDateTimesAs");}
set { this["DisplayStartEndDateTimesAs"] = value;}
}

public System.Boolean IsClosed {
get { return SafeGetValue<System.Boolean>("IsClosed");}
set { this["IsClosed"] = value;}
}

}
[Serializable]
public class msEventRegistration : msRegistrationBase {
public new const string CLASS_NAME = "EventRegistration";
public new  static class FIELDS {
public const string BadgeName = "BadgeName";
public const string BadgeOrganization = "BadgeOrganization";
public const string BadgeTitle = "BadgeTitle";
public const string BadgeCity = "BadgeCity";
public const string BadgeState = "BadgeState";
public const string BadgeCountry = "BadgeCountry";
public const string GroupName = "GroupName";
public const string LinkedRegistration = "LinkedRegistration";
public const string Category = "Category";
public const string Class = "Class";
public const string Ribbons = "Ribbons";
}
public msEventRegistration() : base() {
ClassType = "EventRegistration";
Ribbons = new System.Collections.Generic.List<System.String>();
AddOns = new System.Collections.Generic.List<msRegistrationAddOn>();
}
public msEventRegistration( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventRegistration FromClassMetadata(ClassMetadata meta){return new msEventRegistration(MemberSuiteObject.FromClassMetadata(meta));}
public System.String BadgeName {
get { return SafeGetValue<System.String>("BadgeName");}
set { this["BadgeName"] = value;}
}

public System.String BadgeOrganization {
get { return SafeGetValue<System.String>("BadgeOrganization");}
set { this["BadgeOrganization"] = value;}
}

public System.String BadgeTitle {
get { return SafeGetValue<System.String>("BadgeTitle");}
set { this["BadgeTitle"] = value;}
}

public System.String BadgeCity {
get { return SafeGetValue<System.String>("BadgeCity");}
set { this["BadgeCity"] = value;}
}

public System.String BadgeState {
get { return SafeGetValue<System.String>("BadgeState");}
set { this["BadgeState"] = value;}
}

public System.String BadgeCountry {
get { return SafeGetValue<System.String>("BadgeCountry");}
set { this["BadgeCountry"] = value;}
}

public System.String GroupName {
get { return SafeGetValue<System.String>("GroupName");}
set { this["GroupName"] = value;}
}

public System.String LinkedRegistration {
get { return SafeGetValue<System.String>("LinkedRegistration");}
set { this["LinkedRegistration"] = value;}
}

public System.String Category {
get { return SafeGetValue<System.String>("Category");}
set { this["Category"] = value;}
}

public System.String Class {
get { return SafeGetValue<System.String>("Class");}
set { this["Class"] = value;}
}

public System.Collections.Generic.List<System.String> Ribbons {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Ribbons");}
set { this["Ribbons"] = value;}
}

}
[Serializable]
public class msEventType : msPageLayoutConfigurableType {
public new const string CLASS_NAME = "EventType";
public new  static class FIELDS {
public const string EngagementScoreMultiplier = "EngagementScoreMultiplier";
}
public msEventType() : base() {
ClassType = "EventType";
}
public msEventType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventType FromClassMetadata(ClassMetadata meta){return new msEventType(MemberSuiteObject.FromClassMetadata(meta));}
public System.Decimal? EngagementScoreMultiplier {
get { return SafeGetValue<System.Decimal?>("EngagementScoreMultiplier");}
set { this["EngagementScoreMultiplier"] = value;}
}

}
[Serializable]
public class msSession : msEventBase {
public new const string CLASS_NAME = "Session";
public new  static class FIELDS {
public const string TimeSlot = "TimeSlot";
public const string DisplayOrder = "DisplayOrder";
public const string Abstract = "Abstract";
public const string Tracks = "Tracks";
public const string Resources = "Resources";
public const string Rooms = "Rooms";
public const string PresenterName = "PresenterName";
public const string PresenterBiography = "PresenterBiography";
public const string PresenterPhoneNumber = "PresenterPhoneNumber";
public const string PresenterEmailAddress = "PresenterEmailAddress";
public const string Notes = "Notes";
}
public msSession() : base() {
ClassType = "Session";
Tracks = new System.Collections.Generic.List<System.String>();
Resources = new System.Collections.Generic.List<msSessionResource>();
Rooms = new System.Collections.Generic.List<msSessionRooms>();
Courses = new System.Collections.Generic.List<msSessionCourse>();
Speakers = new System.Collections.Generic.List<msSessionSpeaker>();
}
public msSession( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSession FromClassMetadata(ClassMetadata meta){return new msSession(MemberSuiteObject.FromClassMetadata(meta));}
public System.String TimeSlot {
get { return SafeGetValue<System.String>("TimeSlot");}
set { this["TimeSlot"] = value;}
}

public System.Int16? DisplayOrder {
get { return SafeGetValue<System.Int16?>("DisplayOrder");}
set { this["DisplayOrder"] = value;}
}

public System.String Abstract {
get { return SafeGetValue<System.String>("Abstract");}
set { this["Abstract"] = value;}
}

public System.Collections.Generic.List<System.String> Tracks {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Tracks");}
set { this["Tracks"] = value;}
}

public System.Collections.Generic.List<msSessionResource> Resources {
get { return SafeGetValue<System.Collections.Generic.List<msSessionResource>>("Resources");}
set { this["Resources"] = value;}
}

public System.Collections.Generic.List<msSessionRooms> Rooms {
get { return SafeGetValue<System.Collections.Generic.List<msSessionRooms>>("Rooms");}
set { this["Rooms"] = value;}
}

public System.String PresenterName {
get { return SafeGetValue<System.String>("PresenterName");}
set { this["PresenterName"] = value;}
}

public System.String PresenterBiography {
get { return SafeGetValue<System.String>("PresenterBiography");}
set { this["PresenterBiography"] = value;}
}

public System.String PresenterPhoneNumber {
get { return SafeGetValue<System.String>("PresenterPhoneNumber");}
set { this["PresenterPhoneNumber"] = value;}
}

public System.String PresenterEmailAddress {
get { return SafeGetValue<System.String>("PresenterEmailAddress");}
set { this["PresenterEmailAddress"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msSessionResource : msAggregateChild {
public new const string CLASS_NAME = "SessionResource";
public new  static class FIELDS {
public const string Resource = "Resource";
}
public msSessionResource() : base() {
ClassType = "SessionResource";
}
public msSessionResource( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSessionResource FromClassMetadata(ClassMetadata meta){return new msSessionResource(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Resource {
get { return SafeGetValue<System.String>("Resource");}
set { this["Resource"] = value;}
}

}
[Serializable]
public class msSessionRooms : msAggregateChild {
public new const string CLASS_NAME = "SessionRooms";
public new  static class FIELDS {
public const string Room = "Room";
}
public msSessionRooms() : base() {
ClassType = "SessionRooms";
}
public msSessionRooms( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSessionRooms FromClassMetadata(ClassMetadata meta){return new msSessionRooms(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Room {
get { return SafeGetValue<System.String>("Room");}
set { this["Room"] = value;}
}

}
[Serializable]
public class msSessionTrack : msEventConfigurableType {
public new const string CLASS_NAME = "SessionTrack";
public new  static class FIELDS {
}
public msSessionTrack() : base() {
ClassType = "SessionTrack";
}
public msSessionTrack( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSessionTrack FromClassMetadata(ClassMetadata meta){return new msSessionTrack(MemberSuiteObject.FromClassMetadata(meta));}
}

[Serializable]
public class msMembership : msCustomizableAssociationDomainObject
{
    public new const string CLASS_NAME = "Membership";
    public new static class FIELDS
    {
        public const string MembershipOrganization = "MembershipOrganization";
        public const string Order = "Order";
        public const string OrderLineItemID = "OrderLineItemID";
        public const string LastOrder = "LastOrder";
        public const string SavedPaymentMethod = "SavedPaymentMethod";
        public const string LastOrderLineItemID = "LastOrderLineItemID";
        public const string Owner = "Owner";
        public const string Type = "Type";
        public const string Status = "Status";
        public const string Product = "Product";
        public const string JoinDate = "JoinDate";
        public const string ReinstatementDate = "ReinstatementDate";
        public const string RenewalDate = "RenewalDate";
        public const string TerminationDate = "TerminationDate";
        public const string BillTo = "BillTo";
        public const string RevenueRecognitionDate = "RevenueRecognitionDate";
        public const string CurrentDuesAmount = "CurrentDuesAmount";
        public const string TerminationReason = "TerminationReason";
        public const string BilledThru = "BilledThru";
        public const string RemindedThru = "RemindedThru";
        public const string ExpirationDate = "ExpirationDate";
        public const string ReferredBy = "ReferredBy";
        public const string Approved = "Approved";
        public const string DateApproved = "DateApproved";
        public const string Chapters = "Chapters";
        public const string Sections = "Sections";
        public const string AddOns = "AddOns";
        public const string MembershipDirectoryOptOut = "MembershipDirectoryOptOut";
        public const string Notes = "Notes";
        public const string DoNotRenew = "DoNotRenew";
        public const string ReceivesMemberBenefits = "ReceivesMemberBenefits";
        public const string AutomaticallyPayForRenewal = "AutomaticallyPayForRenewal";
        public const string IsInherited = "IsInherited";
        public const string FlowDownRelationship = "FlowDownRelationship";
        public const string HasFlowDownChildren = "HasFlowDownChildren";
        public const string FlowDownDepth = "FlowDownDepth";
        public const string FlownDownEventID = "FlownDownEventID";
        public const string ParentMembership = "ParentMembership";
        public const string FlowDownDate = "FlowDownDate";
    }
    public msMembership()
        : base()
    {
        ClassType = "Membership";
        Chapters = new System.Collections.Generic.List<msChapterMembership>();
        Sections = new System.Collections.Generic.List<msSectionMembership>();
        AddOns = new System.Collections.Generic.List<msMembershipAddOn>();
    }
    public msMembership(MemberSuiteObject msObj) : base(msObj) { }
    public static new msMembership FromClassMetadata(ClassMetadata meta) { return new msMembership(MemberSuiteObject.FromClassMetadata(meta)); }
    public System.String MembershipOrganization
    {
        get { return SafeGetValue<System.String>("MembershipOrganization"); }
        set { this["MembershipOrganization"] = value; }
    }

    public System.String Order
    {
        get { return SafeGetValue<System.String>("Order"); }
        set { this["Order"] = value; }
    }

    public System.String OrderLineItemID
    {
        get { return SafeGetValue<System.String>("OrderLineItemID"); }
        set { this["OrderLineItemID"] = value; }
    }

    public System.String LastOrder
    {
        get { return SafeGetValue<System.String>("LastOrder"); }
        set { this["LastOrder"] = value; }
    }

    public System.String SavedPaymentMethod
    {
        get { return SafeGetValue<System.String>("SavedPaymentMethod"); }
        set { this["SavedPaymentMethod"] = value; }
    }

    public System.String LastOrderLineItemID
    {
        get { return SafeGetValue<System.String>("LastOrderLineItemID"); }
        set { this["LastOrderLineItemID"] = value; }
    }

    public System.String Owner
    {
        get { return SafeGetValue<System.String>("Owner"); }
        set { this["Owner"] = value; }
    }

    public System.String Type
    {
        get { return SafeGetValue<System.String>("Type"); }
        set { this["Type"] = value; }
    }

    public System.String Status
    {
        get { return SafeGetValue<System.String>("Status"); }
        set { this["Status"] = value; }
    }

    public System.String Product
    {
        get { return SafeGetValue<System.String>("Product"); }
        set { this["Product"] = value; }
    }

    public System.DateTime? JoinDate
    {
        get { return SafeGetValue<System.DateTime?>("JoinDate"); }
        set { this["JoinDate"] = value; }
    }

    public System.DateTime? ReinstatementDate
    {
        get { return SafeGetValue<System.DateTime?>("ReinstatementDate"); }
        set { this["ReinstatementDate"] = value; }
    }

    public System.DateTime? RenewalDate
    {
        get { return SafeGetValue<System.DateTime?>("RenewalDate"); }
        set { this["RenewalDate"] = value; }
    }

    public System.DateTime? TerminationDate
    {
        get { return SafeGetValue<System.DateTime?>("TerminationDate"); }
        set { this["TerminationDate"] = value; }
    }

    public System.String BillTo
    {
        get { return SafeGetValue<System.String>("BillTo"); }
        set { this["BillTo"] = value; }
    }

    public System.DateTime? RevenueRecognitionDate
    {
        get { return SafeGetValue<System.DateTime?>("RevenueRecognitionDate"); }
        set { this["RevenueRecognitionDate"] = value; }
    }

    public System.Decimal? CurrentDuesAmount
    {
        get { return SafeGetValue<System.Decimal?>("CurrentDuesAmount"); }
        set { this["CurrentDuesAmount"] = value; }
    }

    public System.String TerminationReason
    {
        get { return SafeGetValue<System.String>("TerminationReason"); }
        set { this["TerminationReason"] = value; }
    }

    public System.DateTime? BilledThru
    {
        get { return SafeGetValue<System.DateTime?>("BilledThru"); }
        set { this["BilledThru"] = value; }
    }

    public System.DateTime? RemindedThru
    {
        get { return SafeGetValue<System.DateTime?>("RemindedThru"); }
        set { this["RemindedThru"] = value; }
    }

    public System.DateTime? ExpirationDate
    {
        get { return SafeGetValue<System.DateTime?>("ExpirationDate"); }
        set { this["ExpirationDate"] = value; }
    }

    public System.String ReferredBy
    {
        get { return SafeGetValue<System.String>("ReferredBy"); }
        set { this["ReferredBy"] = value; }
    }

    public System.Boolean Approved
    {
        get { return SafeGetValue<System.Boolean>("Approved"); }
        set { this["Approved"] = value; }
    }

    public System.DateTime? DateApproved
    {
        get { return SafeGetValue<System.DateTime?>("DateApproved"); }
        set { this["DateApproved"] = value; }
    }

    public System.Collections.Generic.List<msChapterMembership> Chapters
    {
        get { return SafeGetValue<System.Collections.Generic.List<msChapterMembership>>("Chapters"); }
        set { this["Chapters"] = value; }
    }

    public System.Collections.Generic.List<msSectionMembership> Sections
    {
        get { return SafeGetValue<System.Collections.Generic.List<msSectionMembership>>("Sections"); }
        set { this["Sections"] = value; }
    }

    public System.Collections.Generic.List<msMembershipAddOn> AddOns
    {
        get { return SafeGetValue<System.Collections.Generic.List<msMembershipAddOn>>("AddOns"); }
        set { this["AddOns"] = value; }
    }

    public System.Boolean MembershipDirectoryOptOut
    {
        get { return SafeGetValue<System.Boolean>("MembershipDirectoryOptOut"); }
        set { this["MembershipDirectoryOptOut"] = value; }
    }

    public System.String Notes
    {
        get { return SafeGetValue<System.String>("Notes"); }
        set { this["Notes"] = value; }
    }

    public System.Boolean DoNotRenew
    {
        get { return SafeGetValue<System.Boolean>("DoNotRenew"); }
        set { this["DoNotRenew"] = value; }
    }

    public System.Boolean ReceivesMemberBenefits
    {
        get { return SafeGetValue<System.Boolean>("ReceivesMemberBenefits"); }
        set { this["ReceivesMemberBenefits"] = value; }
    }

    public System.Boolean AutomaticallyPayForRenewal
    {
        get { return SafeGetValue<System.Boolean>("AutomaticallyPayForRenewal"); }
        set { this["AutomaticallyPayForRenewal"] = value; }
    }

    public System.Boolean IsInherited
    {
        get { return SafeGetValue<System.Boolean>("IsInherited"); }
        set { this["IsInherited"] = value; }
    }

    public System.String FlowDownRelationship
    {
        get { return SafeGetValue<System.String>("FlowDownRelationship"); }
        set { this["FlowDownRelationship"] = value; }
    }

    public System.Boolean HasFlowDownChildren
    {
        get { return SafeGetValue<System.Boolean>("HasFlowDownChildren"); }
        set { this["HasFlowDownChildren"] = value; }
    }

    public System.Int32? FlowDownDepth
    {
        get { return SafeGetValue<System.Int32?>("FlowDownDepth"); }
        set { this["FlowDownDepth"] = value; }
    }

    public System.String FlownDownEventID
    {
        get { return SafeGetValue<System.String>("FlownDownEventID"); }
        set { this["FlownDownEventID"] = value; }
    }

    public System.String ParentMembership
    {
        get { return SafeGetValue<System.String>("ParentMembership"); }
        set { this["ParentMembership"] = value; }
    }

    public System.DateTime? FlowDownDate
    {
        get { return SafeGetValue<System.DateTime?>("FlowDownDate"); }
        set { this["FlowDownDate"] = value; }
    }

}
[Serializable]
public class msChapterMembership : msAggregateChild {
public new const string CLASS_NAME = "ChapterMembership";
public new  static class FIELDS {
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
public const string Chapter = "Chapter";
public const string JoinDate = "JoinDate";
public const string ExpirationDate = "ExpirationDate";
public const string IsPrimary = "IsPrimary";
public const string Product = "Product";
}
public msChapterMembership() : base() {
ClassType = "ChapterMembership";
}
public msChapterMembership( MemberSuiteObject msObj) : base(msObj) {}
 public static new msChapterMembership FromClassMetadata(ClassMetadata meta){return new msChapterMembership(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.String Chapter {
get { return SafeGetValue<System.String>("Chapter");}
set { this["Chapter"] = value;}
}

public System.DateTime? JoinDate {
get { return SafeGetValue<System.DateTime?>("JoinDate");}
set { this["JoinDate"] = value;}
}

public System.DateTime? ExpirationDate {
get { return SafeGetValue<System.DateTime?>("ExpirationDate");}
set { this["ExpirationDate"] = value;}
}

public System.Boolean IsPrimary {
get { return SafeGetValue<System.Boolean>("IsPrimary");}
set { this["IsPrimary"] = value;}
}

public System.String Product {
get { return SafeGetValue<System.String>("Product");}
set { this["Product"] = value;}
}

}
[Serializable]
public class msSectionMembership : msAggregateChild {
public new const string CLASS_NAME = "SectionMembership";
public new  static class FIELDS {
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
public const string Section = "Section";
public const string JoinDate = "JoinDate";
public const string ExpirationDate = "ExpirationDate";
public const string Product = "Product";
}
public msSectionMembership() : base() {
ClassType = "SectionMembership";
}
public msSectionMembership( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSectionMembership FromClassMetadata(ClassMetadata meta){return new msSectionMembership(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.String Section {
get { return SafeGetValue<System.String>("Section");}
set { this["Section"] = value;}
}

public System.DateTime? JoinDate {
get { return SafeGetValue<System.DateTime?>("JoinDate");}
set { this["JoinDate"] = value;}
}

public System.DateTime? ExpirationDate {
get { return SafeGetValue<System.DateTime?>("ExpirationDate");}
set { this["ExpirationDate"] = value;}
}

public System.String Product {
get { return SafeGetValue<System.String>("Product");}
set { this["Product"] = value;}
}

}
[Serializable]
public class msMembershipAddOn : msAggregateChild {
public new const string CLASS_NAME = "MembershipAddOn";
public new  static class FIELDS {
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
public const string Merchandise = "Merchandise";
public const string Quantity = "Quantity";
public const string UnitPrice = "UnitPrice";
public const string Price = "Price";
public const string ExpirationDate = "ExpirationDate";
public const string UnitPriceOverride = "UnitPriceOverride";
public const string PriceIncreaseCap = "PriceIncreaseCap";
public const string Comments = "Comments";
public const string Renewable = "Renewable";
}
public msMembershipAddOn() : base() {
ClassType = "MembershipAddOn";
}
public msMembershipAddOn( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipAddOn FromClassMetadata(ClassMetadata meta){return new msMembershipAddOn(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.String Merchandise {
get { return SafeGetValue<System.String>("Merchandise");}
set { this["Merchandise"] = value;}
}

public System.Decimal? Quantity {
get { return SafeGetValue<System.Decimal?>("Quantity");}
set { this["Quantity"] = value;}
}

public System.Decimal? UnitPrice {
get { return SafeGetValue<System.Decimal?>("UnitPrice");}
set { this["UnitPrice"] = value;}
}

public System.Decimal? Price {
get { return SafeGetValue<System.Decimal?>("Price");}
set { this["Price"] = value;}
}

public System.DateTime? ExpirationDate {
get { return SafeGetValue<System.DateTime?>("ExpirationDate");}
set { this["ExpirationDate"] = value;}
}

public System.Decimal? UnitPriceOverride {
get { return SafeGetValue<System.Decimal?>("UnitPriceOverride");}
set { this["UnitPriceOverride"] = value;}
}

public System.Decimal? PriceIncreaseCap {
get { return SafeGetValue<System.Decimal?>("PriceIncreaseCap");}
set { this["PriceIncreaseCap"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

public System.Boolean Renewable {
get { return SafeGetValue<System.Boolean>("Renewable");}
set { this["Renewable"] = value;}
}

}
[Serializable]
public class msMembershipDuesProduct : msExpiringProduct {
public new const string CLASS_NAME = "MembershipDuesProduct";
public new  static class FIELDS {
public const string MembershipOrganization = "MembershipOrganization";
public const string InitialStatus = "InitialStatus";
public const string DropStatus = "DropStatus";
public const string RenewsWith = "RenewsWith";
public const string MembershipType = "MembershipType";
public const string ReceivesMemberBenefits = "ReceivesMemberBenefits";
public const string ResumeMode = "ResumeMode";
public const string ChapterMode = "ChapterMode";
public const string ChapterPostalCodeMappingMode = "ChapterPostalCodeMappingMode";
public const string SectionMode = "SectionMode";
public const string AutomaticallyUpdateChapter = "AutomaticallyUpdateChapter";
}
public msMembershipDuesProduct() : base() {
ClassType = "MembershipDuesProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msMembershipDuesProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipDuesProduct FromClassMetadata(ClassMetadata meta){return new msMembershipDuesProduct(MemberSuiteObject.FromClassMetadata(meta));}
public System.String MembershipOrganization {
get { return SafeGetValue<System.String>("MembershipOrganization");}
set { this["MembershipOrganization"] = value;}
}

public System.String InitialStatus {
get { return SafeGetValue<System.String>("InitialStatus");}
set { this["InitialStatus"] = value;}
}

public System.String DropStatus {
get { return SafeGetValue<System.String>("DropStatus");}
set { this["DropStatus"] = value;}
}

public System.String RenewsWith {
get { return SafeGetValue<System.String>("RenewsWith");}
set { this["RenewsWith"] = value;}
}

public System.String MembershipType {
get { return SafeGetValue<System.String>("MembershipType");}
set { this["MembershipType"] = value;}
}

public System.Boolean ReceivesMemberBenefits {
get { return SafeGetValue<System.Boolean>("ReceivesMemberBenefits");}
set { this["ReceivesMemberBenefits"] = value;}
}

public MemberSuite.SDK.Types.ResumeCollectionMode ResumeMode {
get { return SafeGetValue<MemberSuite.SDK.Types.ResumeCollectionMode>("ResumeMode");}
set { this["ResumeMode"] = value;}
}

public MemberSuite.SDK.Types.ChapterMode ChapterMode {
get { return SafeGetValue<MemberSuite.SDK.Types.ChapterMode>("ChapterMode");}
set { this["ChapterMode"] = value;}
}

public MemberSuite.SDK.Types.ChapterPostalCodeMappingMode ChapterPostalCodeMappingMode {
get { return SafeGetValue<MemberSuite.SDK.Types.ChapterPostalCodeMappingMode>("ChapterPostalCodeMappingMode");}
set { this["ChapterPostalCodeMappingMode"] = value;}
}

public MemberSuite.SDK.Types.SectionMode SectionMode {
get { return SafeGetValue<MemberSuite.SDK.Types.SectionMode>("SectionMode");}
set { this["SectionMode"] = value;}
}

public System.Boolean AutomaticallyUpdateChapter {
get { return SafeGetValue<System.Boolean>("AutomaticallyUpdateChapter");}
set { this["AutomaticallyUpdateChapter"] = value;}
}

}
[Serializable]
public class msMembershipType : msPageLayoutConfigurableType {
public new const string CLASS_NAME = "MembershipType";
public new  static class FIELDS {
public const string MembershipOrganization = "MembershipOrganization";
public const string CustomerType = "CustomerType";
public const string SpecialInstructions = "SpecialInstructions";
public const string MembershipCardTemplate = "MembershipCardTemplate";
public const string EngagementScoreMultiplier = "EngagementScoreMultiplier";
}
public msMembershipType() : base() {
ClassType = "MembershipType";
}
public msMembershipType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipType FromClassMetadata(ClassMetadata meta){return new msMembershipType(MemberSuiteObject.FromClassMetadata(meta));}
public System.String MembershipOrganization {
get { return SafeGetValue<System.String>("MembershipOrganization");}
set { this["MembershipOrganization"] = value;}
}

public MemberSuite.SDK.Types.CustomerType CustomerType {
get { return SafeGetValue<MemberSuite.SDK.Types.CustomerType>("CustomerType");}
set { this["CustomerType"] = value;}
}

public System.String SpecialInstructions {
get { return SafeGetValue<System.String>("SpecialInstructions");}
set { this["SpecialInstructions"] = value;}
}

public System.String MembershipCardTemplate {
get { return SafeGetValue<System.String>("MembershipCardTemplate");}
set { this["MembershipCardTemplate"] = value;}
}

public System.Decimal? EngagementScoreMultiplier {
get { return SafeGetValue<System.Decimal?>("EngagementScoreMultiplier");}
set { this["EngagementScoreMultiplier"] = value;}
}

}
[Serializable]
public class msOrganizationalLayer : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "OrganizationalLayer";
public new  static class FIELDS {
public const string Code = "Code";
public const string IsActive = "IsActive";
public const string MembershipOrganization = "MembershipOrganization";
public const string Type = "Type";
public const string Description = "Description";
public const string ParentLayer = "ParentLayer";
public const string LinkedOrganization = "LinkedOrganization";
public const string Leaders = "Leaders";
}
public msOrganizationalLayer() : base() {
ClassType = "OrganizationalLayer";
Leaders = new System.Collections.Generic.List<msMembershipLeader>();
}
public msOrganizationalLayer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msOrganizationalLayer FromClassMetadata(ClassMetadata meta){return new msOrganizationalLayer(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.String MembershipOrganization {
get { return SafeGetValue<System.String>("MembershipOrganization");}
set { this["MembershipOrganization"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String ParentLayer {
get { return SafeGetValue<System.String>("ParentLayer");}
set { this["ParentLayer"] = value;}
}

public System.String LinkedOrganization {
get { return SafeGetValue<System.String>("LinkedOrganization");}
set { this["LinkedOrganization"] = value;}
}

public System.Collections.Generic.List<msMembershipLeader> Leaders {
get { return SafeGetValue<System.Collections.Generic.List<msMembershipLeader>>("Leaders");}
set { this["Leaders"] = value;}
}

}
[Serializable]
public class msChapterDuesProduct : msMembershipProductBase {
public new const string CLASS_NAME = "ChapterDuesProduct";
public new  static class FIELDS {
public const string Chapter = "Chapter";
public const string MembershipType = "MembershipType";
}
public msChapterDuesProduct() : base() {
ClassType = "ChapterDuesProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msChapterDuesProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msChapterDuesProduct FromClassMetadata(ClassMetadata meta){return new msChapterDuesProduct(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Chapter {
get { return SafeGetValue<System.String>("Chapter");}
set { this["Chapter"] = value;}
}

public System.String MembershipType {
get { return SafeGetValue<System.String>("MembershipType");}
set { this["MembershipType"] = value;}
}

}
[Serializable]
public class msOrganizationalLayerType : msPageLayoutConfigurableType {
public new const string CLASS_NAME = "OrganizationalLayerType";
public new  static class FIELDS {
public const string MembershipOrganization = "MembershipOrganization";
public const string ParentType = "ParentType";
}
public msOrganizationalLayerType() : base() {
ClassType = "OrganizationalLayerType";
}
public msOrganizationalLayerType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msOrganizationalLayerType FromClassMetadata(ClassMetadata meta){return new msOrganizationalLayerType(MemberSuiteObject.FromClassMetadata(meta));}
public System.String MembershipOrganization {
get { return SafeGetValue<System.String>("MembershipOrganization");}
set { this["MembershipOrganization"] = value;}
}

public System.String ParentType {
get { return SafeGetValue<System.String>("ParentType");}
set { this["ParentType"] = value;}
}

}
[Serializable]
public class msSection : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Section";
public new  static class FIELDS {
public const string Code = "Code";
public const string MembershipOrganization = "MembershipOrganization";
public const string Type = "Type";
public const string NewMemberConfirmationEmail = "NewMemberConfirmationEmail";
public const string RenewingMemberConfirmationEmail = "RenewingMemberConfirmationEmail";
public const string IsActive = "IsActive";
public const string LinkedOrganization = "LinkedOrganization";
public const string Leaders = "Leaders";
public const string Description = "Description";
}
public msSection() : base() {
ClassType = "Section";
Leaders = new System.Collections.Generic.List<msMembershipLeader>();
}
public msSection( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSection FromClassMetadata(ClassMetadata meta){return new msSection(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.String MembershipOrganization {
get { return SafeGetValue<System.String>("MembershipOrganization");}
set { this["MembershipOrganization"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public MemberSuite.SDK.Types.EmailTemplate NewMemberConfirmationEmail {
get { return SafeGetValue<MemberSuite.SDK.Types.EmailTemplate>("NewMemberConfirmationEmail");}
set { this["NewMemberConfirmationEmail"] = value;}
}

public MemberSuite.SDK.Types.EmailTemplate RenewingMemberConfirmationEmail {
get { return SafeGetValue<MemberSuite.SDK.Types.EmailTemplate>("RenewingMemberConfirmationEmail");}
set { this["RenewingMemberConfirmationEmail"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.String LinkedOrganization {
get { return SafeGetValue<System.String>("LinkedOrganization");}
set { this["LinkedOrganization"] = value;}
}

public System.Collections.Generic.List<msMembershipLeader> Leaders {
get { return SafeGetValue<System.Collections.Generic.List<msMembershipLeader>>("Leaders");}
set { this["Leaders"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msSectionDuesProduct : msMembershipProductBase {
public new const string CLASS_NAME = "SectionDuesProduct";
public new  static class FIELDS {
public const string Section = "Section";
public const string MembershipType = "MembershipType";
}
public msSectionDuesProduct() : base() {
ClassType = "SectionDuesProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msSectionDuesProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSectionDuesProduct FromClassMetadata(ClassMetadata meta){return new msSectionDuesProduct(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Section {
get { return SafeGetValue<System.String>("Section");}
set { this["Section"] = value;}
}

public System.String MembershipType {
get { return SafeGetValue<System.String>("MembershipType");}
set { this["MembershipType"] = value;}
}

}
[Serializable]
public class msSectionType : msPageLayoutConfigurableType {
public new const string CLASS_NAME = "SectionType";
public new  static class FIELDS {
public const string MembershipOrganization = "MembershipOrganization";
}
public msSectionType() : base() {
ClassType = "SectionType";
}
public msSectionType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSectionType FromClassMetadata(ClassMetadata meta){return new msSectionType(MemberSuiteObject.FromClassMetadata(meta));}
public System.String MembershipOrganization {
get { return SafeGetValue<System.String>("MembershipOrganization");}
set { this["MembershipOrganization"] = value;}
}

}
[Serializable]
public class msDiscountCodeProduct : msAggregateChild {
public new const string CLASS_NAME = "DiscountCodeProduct";
public new  static class FIELDS {
public const string Product = "Product";
}
public msDiscountCodeProduct() : base() {
ClassType = "DiscountCodeProduct";
}
public msDiscountCodeProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDiscountCodeProduct FromClassMetadata(ClassMetadata meta){return new msDiscountCodeProduct(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Product {
get { return SafeGetValue<System.String>("Product");}
set { this["Product"] = value;}
}

}
[Serializable]
public class msDiscountCodeProductCategory : msAggregateChild {
public new const string CLASS_NAME = "DiscountCodeProductCategory";
public new  static class FIELDS {
public const string Category = "Category";
}
public msDiscountCodeProductCategory() : base() {
ClassType = "DiscountCodeProductCategory";
}
public msDiscountCodeProductCategory( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDiscountCodeProductCategory FromClassMetadata(ClassMetadata meta){return new msDiscountCodeProductCategory(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Category {
get { return SafeGetValue<System.String>("Category");}
set { this["Category"] = value;}
}

}
[Serializable]
public class msDiscountCodeProductType : msAggregateChild {
public new const string CLASS_NAME = "DiscountCodeProductType";
public new  static class FIELDS {
public const string ProductType = "ProductType";
}
public msDiscountCodeProductType() : base() {
ClassType = "DiscountCodeProductType";
}
public msDiscountCodeProductType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDiscountCodeProductType FromClassMetadata(ClassMetadata meta){return new msDiscountCodeProductType(MemberSuiteObject.FromClassMetadata(meta));}
public System.String ProductType {
get { return SafeGetValue<System.String>("ProductType");}
set { this["ProductType"] = value;}
}

}
[Serializable]
public class msDiscountCodeCustomer : msAggregateChild {
public new const string CLASS_NAME = "DiscountCodeCustomer";
public new  static class FIELDS {
public const string Customer = "Customer";
public const string MaximumNumberOfUsages = "MaximumNumberOfUsages";
}
public msDiscountCodeCustomer() : base() {
ClassType = "DiscountCodeCustomer";
}
public msDiscountCodeCustomer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDiscountCodeCustomer FromClassMetadata(ClassMetadata meta){return new msDiscountCodeCustomer(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Customer {
get { return SafeGetValue<System.String>("Customer");}
set { this["Customer"] = value;}
}

public System.Int32? MaximumNumberOfUsages {
get { return SafeGetValue<System.Int32?>("MaximumNumberOfUsages");}
set { this["MaximumNumberOfUsages"] = value;}
}

}
[Serializable]
public class msDueToDueFromEntry : msAssociationDomainObject {
public new const string CLASS_NAME = "DueToDueFromEntry";
public new  static class FIELDS {
public const string FromBusinessUnit = "FromBusinessUnit";
public const string FromGLAccount = "FromGLAccount";
public const string ToBusinessUnit = "ToBusinessUnit";
public const string ToGLAccount = "ToGLAccount";
}
public msDueToDueFromEntry() : base() {
ClassType = "DueToDueFromEntry";
}
public msDueToDueFromEntry( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDueToDueFromEntry FromClassMetadata(ClassMetadata meta){return new msDueToDueFromEntry(MemberSuiteObject.FromClassMetadata(meta));}
public System.String FromBusinessUnit {
get { return SafeGetValue<System.String>("FromBusinessUnit");}
set { this["FromBusinessUnit"] = value;}
}

public System.String FromGLAccount {
get { return SafeGetValue<System.String>("FromGLAccount");}
set { this["FromGLAccount"] = value;}
}

public System.String ToBusinessUnit {
get { return SafeGetValue<System.String>("ToBusinessUnit");}
set { this["ToBusinessUnit"] = value;}
}

public System.String ToGLAccount {
get { return SafeGetValue<System.String>("ToGLAccount");}
set { this["ToGLAccount"] = value;}
}

}
[Serializable]
public class msGLAccount : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "GLAccount";
public new  static class FIELDS {
public const string Description = "Description";
public const string BusinessUnit = "BusinessUnit";
public const string Code = "Code";
public const string Type = "Type";
}
public msGLAccount() : base() {
ClassType = "GLAccount";
}
public msGLAccount( MemberSuiteObject msObj) : base(msObj) {}
 public static new msGLAccount FromClassMetadata(ClassMetadata meta){return new msGLAccount(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public MemberSuite.SDK.GLAccountType Type {
get { return SafeGetValue<MemberSuite.SDK.GLAccountType>("Type");}
set { this["Type"] = value;}
}

}
[Serializable]
public class msInvoice : msBatchMember {
public new const string CLASS_NAME = "Invoice";
public new  static class FIELDS {
public const string AccountsReceivableGLCode = "AccountsReceivableGLCode";
public const string DueDate = "DueDate";
public const string BillTo = "BillTo";
public const string BillingAddress = "BillingAddress";
public const string Order = "Order";
public const string BillingEmailAddress = "BillingEmailAddress";
public const string Terms = "Terms";
public const string PurchaseOrderNumber = "PurchaseOrderNumber";
public const string CustomerMessage = "CustomerMessage";
public const string Total = "Total";
public const string BalanceDue = "BalanceDue";
public const string ToBePrinted = "ToBePrinted";
public const string ToBeEmailed = "ToBeEmailed";
public const string Type = "Type";
public const string Notes = "Notes";
public const string ProForma = "ProForma";
public const string InsertionOrder = "InsertionOrder";
public const string HasMultipleARAccounts = "HasMultipleARAccounts";
public const string LineItems = "LineItems";
}
public msInvoice() : base() {
ClassType = "Invoice";
LineItems = new System.Collections.Generic.List<msInvoiceLineItem>();
}
public msInvoice( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInvoice FromClassMetadata(ClassMetadata meta){return new msInvoice(MemberSuiteObject.FromClassMetadata(meta));}
public System.String AccountsReceivableGLCode {
get { return SafeGetValue<System.String>("AccountsReceivableGLCode");}
set { this["AccountsReceivableGLCode"] = value;}
}

public System.DateTime DueDate {
get { return SafeGetValue<System.DateTime>("DueDate");}
set { this["DueDate"] = value;}
}

public System.String BillTo {
get { return SafeGetValue<System.String>("BillTo");}
set { this["BillTo"] = value;}
}

public MemberSuite.SDK.Types.Address BillingAddress {
get { return SafeGetValue<MemberSuite.SDK.Types.Address>("BillingAddress");}
set { this["BillingAddress"] = value;}
}

public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String BillingEmailAddress {
get { return SafeGetValue<System.String>("BillingEmailAddress");}
set { this["BillingEmailAddress"] = value;}
}

public System.String Terms {
get { return SafeGetValue<System.String>("Terms");}
set { this["Terms"] = value;}
}

public System.String PurchaseOrderNumber {
get { return SafeGetValue<System.String>("PurchaseOrderNumber");}
set { this["PurchaseOrderNumber"] = value;}
}

public System.String CustomerMessage {
get { return SafeGetValue<System.String>("CustomerMessage");}
set { this["CustomerMessage"] = value;}
}

public System.Decimal Total {
get { return SafeGetValue<System.Decimal>("Total");}
set { this["Total"] = value;}
}

public System.Decimal BalanceDue {
get { return SafeGetValue<System.Decimal>("BalanceDue");}
set { this["BalanceDue"] = value;}
}

public System.Boolean ToBePrinted {
get { return SafeGetValue<System.Boolean>("ToBePrinted");}
set { this["ToBePrinted"] = value;}
}

public System.Boolean ToBeEmailed {
get { return SafeGetValue<System.Boolean>("ToBeEmailed");}
set { this["ToBeEmailed"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Boolean ProForma {
get { return SafeGetValue<System.Boolean>("ProForma");}
set { this["ProForma"] = value;}
}

public System.String InsertionOrder {
get { return SafeGetValue<System.String>("InsertionOrder");}
set { this["InsertionOrder"] = value;}
}

public System.Boolean HasMultipleARAccounts {
get { return SafeGetValue<System.Boolean>("HasMultipleARAccounts");}
set { this["HasMultipleARAccounts"] = value;}
}

public System.Collections.Generic.List<msInvoiceLineItem> LineItems {
get { return SafeGetValue<System.Collections.Generic.List<msInvoiceLineItem>>("LineItems");}
set { this["LineItems"] = value;}
}

}
[Serializable]
public class msInvoiceLineItem : msSalesOrderLineItem {
public new const string CLASS_NAME = "InvoiceLineItem";
public new  static class FIELDS {
public const string InvoiceLineItemID = "InvoiceLineItemID";
public const string OrderLineItemID = "OrderLineItemID";
public const string IsVoid = "IsVoid";
public const string RevenueGLAccount = "RevenueGLAccount";
public const string HasBeenCOGSRecognized = "HasBeenCOGSRecognized";
public const string BillingScheduleEntryID = "BillingScheduleEntryID";
public const string RevenueRecognitionTemplate = "RevenueRecognitionTemplate";
}
public msInvoiceLineItem() : base() {
ClassType = "InvoiceLineItem";
}
public msInvoiceLineItem( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInvoiceLineItem FromClassMetadata(ClassMetadata meta){return new msInvoiceLineItem(MemberSuiteObject.FromClassMetadata(meta));}
public System.String InvoiceLineItemID {
get { return SafeGetValue<System.String>("InvoiceLineItemID");}
set { this["InvoiceLineItemID"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.Boolean IsVoid {
get { return SafeGetValue<System.Boolean>("IsVoid");}
set { this["IsVoid"] = value;}
}

public System.String RevenueGLAccount {
get { return SafeGetValue<System.String>("RevenueGLAccount");}
set { this["RevenueGLAccount"] = value;}
}

public System.Boolean HasBeenCOGSRecognized {
get { return SafeGetValue<System.Boolean>("HasBeenCOGSRecognized");}
set { this["HasBeenCOGSRecognized"] = value;}
}

public System.String BillingScheduleEntryID {
get { return SafeGetValue<System.String>("BillingScheduleEntryID");}
set { this["BillingScheduleEntryID"] = value;}
}

public System.String RevenueRecognitionTemplate {
get { return SafeGetValue<System.String>("RevenueRecognitionTemplate");}
set { this["RevenueRecognitionTemplate"] = value;}
}

}
[Serializable]
public class msInvoiceTerms : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "InvoiceTerms";
public new  static class FIELDS {
public const string NumberOfDays = "NumberOfDays";
public const string IsDefault = "IsDefault";
}
public msInvoiceTerms() : base() {
ClassType = "InvoiceTerms";
}
public msInvoiceTerms( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInvoiceTerms FromClassMetadata(ClassMetadata meta){return new msInvoiceTerms(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int32 NumberOfDays {
get { return SafeGetValue<System.Int32>("NumberOfDays");}
set { this["NumberOfDays"] = value;}
}

public System.Boolean IsDefault {
get { return SafeGetValue<System.Boolean>("IsDefault");}
set { this["IsDefault"] = value;}
}

}
[Serializable]
public class msPayment : msBatchMember {
public new const string CLASS_NAME = "Payment";
public new  static class FIELDS {
public const string LinkedPayment = "LinkedPayment";
public const string Owner = "Owner";
public const string Order = "Order";
public const string Total = "Total";
public const string ReferenceNumber = "ReferenceNumber";
public const string PaymentMethod = "PaymentMethod";
public const string CreditCardType = "CreditCardType";
public const string LineItems = "LineItems";
public const string Notes = "Notes";
public const string MerchantAccount = "MerchantAccount";
public const string TransactionID = "TransactionID";
public const string CreditCardLastFiveDigits = "CreditCardLastFiveDigits";
public const string WasAutomaticallyGenerated = "WasAutomaticallyGenerated";
}
public msPayment() : base() {
ClassType = "Payment";
LineItems = new System.Collections.Generic.List<msPaymentLineItem>();
}
public msPayment( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPayment FromClassMetadata(ClassMetadata meta){return new msPayment(MemberSuiteObject.FromClassMetadata(meta));}
public System.String LinkedPayment {
get { return SafeGetValue<System.String>("LinkedPayment");}
set { this["LinkedPayment"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.Decimal Total {
get { return SafeGetValue<System.Decimal>("Total");}
set { this["Total"] = value;}
}

public System.String ReferenceNumber {
get { return SafeGetValue<System.String>("ReferenceNumber");}
set { this["ReferenceNumber"] = value;}
}

public MemberSuite.SDK.Types.PaymentMethod PaymentMethod {
get { return SafeGetValue<MemberSuite.SDK.Types.PaymentMethod>("PaymentMethod");}
set { this["PaymentMethod"] = value;}
}

public MemberSuite.SDK.Types.CreditCardType CreditCardType {
get { return SafeGetValue<MemberSuite.SDK.Types.CreditCardType>("CreditCardType");}
set { this["CreditCardType"] = value;}
}

public System.Collections.Generic.List<msPaymentLineItem> LineItems {
get { return SafeGetValue<System.Collections.Generic.List<msPaymentLineItem>>("LineItems");}
set { this["LineItems"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.String MerchantAccount {
get { return SafeGetValue<System.String>("MerchantAccount");}
set { this["MerchantAccount"] = value;}
}

public System.String TransactionID {
get { return SafeGetValue<System.String>("TransactionID");}
set { this["TransactionID"] = value;}
}

public System.String CreditCardLastFiveDigits {
get { return SafeGetValue<System.String>("CreditCardLastFiveDigits");}
set { this["CreditCardLastFiveDigits"] = value;}
}

public System.Boolean WasAutomaticallyGenerated {
get { return SafeGetValue<System.Boolean>("WasAutomaticallyGenerated");}
set { this["WasAutomaticallyGenerated"] = value;}
}

}
[Serializable]
public class msPaymentLineItem : msAggregateChild {
public new const string CLASS_NAME = "PaymentLineItem";
public new  static class FIELDS {
public const string PaymentLineItemID = "PaymentLineItemID";
public const string Type = "Type";
public const string Credit = "Credit";
public const string Invoice = "Invoice";
public const string Amount = "Amount";
public const string InvoiceTotalAtTheTimeOfPayment = "InvoiceTotalAtTheTimeOfPayment";
public const string InvoiceBalanceDueAtTheTimeOfPayment = "InvoiceBalanceDueAtTheTimeOfPayment";
public const string InvoiceBalanceDueAfterPayment = "InvoiceBalanceDueAfterPayment";
}
public msPaymentLineItem() : base() {
ClassType = "PaymentLineItem";
}
public msPaymentLineItem( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPaymentLineItem FromClassMetadata(ClassMetadata meta){return new msPaymentLineItem(MemberSuiteObject.FromClassMetadata(meta));}
public System.String PaymentLineItemID {
get { return SafeGetValue<System.String>("PaymentLineItemID");}
set { this["PaymentLineItemID"] = value;}
}

public MemberSuite.SDK.Types.PaymentLineItemType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.PaymentLineItemType>("Type");}
set { this["Type"] = value;}
}

public System.String Credit {
get { return SafeGetValue<System.String>("Credit");}
set { this["Credit"] = value;}
}

public System.String Invoice {
get { return SafeGetValue<System.String>("Invoice");}
set { this["Invoice"] = value;}
}

public System.Decimal Amount {
get { return SafeGetValue<System.Decimal>("Amount");}
set { this["Amount"] = value;}
}

public System.Decimal? InvoiceTotalAtTheTimeOfPayment {
get { return SafeGetValue<System.Decimal?>("InvoiceTotalAtTheTimeOfPayment");}
set { this["InvoiceTotalAtTheTimeOfPayment"] = value;}
}

public System.Decimal? InvoiceBalanceDueAtTheTimeOfPayment {
get { return SafeGetValue<System.Decimal?>("InvoiceBalanceDueAtTheTimeOfPayment");}
set { this["InvoiceBalanceDueAtTheTimeOfPayment"] = value;}
}

public System.Decimal? InvoiceBalanceDueAfterPayment {
get { return SafeGetValue<System.Decimal?>("InvoiceBalanceDueAfterPayment");}
set { this["InvoiceBalanceDueAfterPayment"] = value;}
}

}
[Serializable]
public class msProductLinkage : msAggregateChild {
public new const string CLASS_NAME = "ProductLinkage";
public new  static class FIELDS {
public const string LinkedProduct = "LinkedProduct";
public const string Quantity = "Quantity";
public const string Type = "Type";
public const string Price = "Price";
public const string MemberPrice = "MemberPrice";
}
public msProductLinkage() : base() {
ClassType = "ProductLinkage";
}
public msProductLinkage( MemberSuiteObject msObj) : base(msObj) {}
 public static new msProductLinkage FromClassMetadata(ClassMetadata meta){return new msProductLinkage(MemberSuiteObject.FromClassMetadata(meta));}
public System.String LinkedProduct {
get { return SafeGetValue<System.String>("LinkedProduct");}
set { this["LinkedProduct"] = value;}
}

public System.Decimal? Quantity {
get { return SafeGetValue<System.Decimal?>("Quantity");}
set { this["Quantity"] = value;}
}

public MemberSuite.SDK.Types.ProductLinkageType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.ProductLinkageType>("Type");}
set { this["Type"] = value;}
}

public System.Decimal? Price {
get { return SafeGetValue<System.Decimal?>("Price");}
set { this["Price"] = value;}
}

public System.Decimal? MemberPrice {
get { return SafeGetValue<System.Decimal?>("MemberPrice");}
set { this["MemberPrice"] = value;}
}

}
[Serializable]
public class msRevenueSplit : msAggregateChild {
public new const string CLASS_NAME = "RevenueSplit";
public new  static class FIELDS {
public const string BusinessUnit = "BusinessUnit";
public const string Percentage = "Percentage";
public const string RevenueAccount = "RevenueAccount";
}
public msRevenueSplit() : base() {
ClassType = "RevenueSplit";
}
public msRevenueSplit( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRevenueSplit FromClassMetadata(ClassMetadata meta){return new msRevenueSplit(MemberSuiteObject.FromClassMetadata(meta));}
public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public System.Decimal Percentage {
get { return SafeGetValue<System.Decimal>("Percentage");}
set { this["Percentage"] = value;}
}

public System.String RevenueAccount {
get { return SafeGetValue<System.String>("RevenueAccount");}
set { this["RevenueAccount"] = value;}
}

}
[Serializable]
public class msLinkedCEUCredit : msAggregateChild {
public new const string CLASS_NAME = "LinkedCEUCredit";
public new  static class FIELDS {
public const string Type = "Type";
public const string Quantity = "Quantity";
}
public msLinkedCEUCredit() : base() {
ClassType = "LinkedCEUCredit";
}
public msLinkedCEUCredit( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLinkedCEUCredit FromClassMetadata(ClassMetadata meta){return new msLinkedCEUCredit(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.Decimal Quantity {
get { return SafeGetValue<System.Decimal>("Quantity");}
set { this["Quantity"] = value;}
}

}
[Serializable]
public class msPurchaseRestriction : msAggregateChild {
public new const string CLASS_NAME = "PurchaseRestriction";
public new  static class FIELDS {
public const string MaxQuantity = "MaxQuantity";
public const string TimePeriod = "TimePeriod";
}
public msPurchaseRestriction() : base() {
ClassType = "PurchaseRestriction";
}
public msPurchaseRestriction( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPurchaseRestriction FromClassMetadata(ClassMetadata meta){return new msPurchaseRestriction(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int32 MaxQuantity {
get { return SafeGetValue<System.Int32>("MaxQuantity");}
set { this["MaxQuantity"] = value;}
}

public System.Int32? TimePeriod {
get { return SafeGetValue<System.Int32?>("TimePeriod");}
set { this["TimePeriod"] = value;}
}

}
[Serializable]
public class msLinkedEntitlement : msAggregateChild {
public new const string CLASS_NAME = "LinkedEntitlement";
public new  static class FIELDS {
public const string Type = "Type";
public const string Context_ID = "Context_ID";
public const string Quantity = "Quantity";
public const string Expiration = "Expiration";
}
public msLinkedEntitlement() : base() {
ClassType = "LinkedEntitlement";
}
public msLinkedEntitlement( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLinkedEntitlement FromClassMetadata(ClassMetadata meta){return new msLinkedEntitlement(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Context_ID {
get { return SafeGetValue<System.String>("Context_ID");}
set { this["Context_ID"] = value;}
}

public System.Decimal? Quantity {
get { return SafeGetValue<System.Decimal?>("Quantity");}
set { this["Quantity"] = value;}
}

public System.Int32? Expiration {
get { return SafeGetValue<System.Int32?>("Expiration");}
set { this["Expiration"] = value;}
}

}
[Serializable]
public class msSubLedgerEntry : msAssociationDomainObject {
public new const string CLASS_NAME = "SubLedgerEntry";
public new  static class FIELDS {
public const string BusinessUnit = "BusinessUnit";
public const string FiscalYear = "FiscalYear";
public const string FiscalPeriod = "FiscalPeriod";
public const string Date = "Date";
public const string Batch = "Batch";
public const string Invoice = "Invoice";
public const string Payment = "Payment";
public const string Credit = "Credit";
public const string Refund = "Refund";
public const string WriteOff = "WriteOff";
public const string Gift = "Gift";
public const string InventoryReceipt = "InventoryReceipt";
public const string InvoiceAdjustment = "InvoiceAdjustment";
public const string Items = "Items";
}
public msSubLedgerEntry() : base() {
ClassType = "SubLedgerEntry";
Items = new System.Collections.Generic.List<msSubLedgerEntryItem>();
}
public msSubLedgerEntry( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSubLedgerEntry FromClassMetadata(ClassMetadata meta){return new msSubLedgerEntry(MemberSuiteObject.FromClassMetadata(meta));}
public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public System.String FiscalYear {
get { return SafeGetValue<System.String>("FiscalYear");}
set { this["FiscalYear"] = value;}
}

public System.Int32 FiscalPeriod {
get { return SafeGetValue<System.Int32>("FiscalPeriod");}
set { this["FiscalPeriod"] = value;}
}

public System.DateTime Date {
get { return SafeGetValue<System.DateTime>("Date");}
set { this["Date"] = value;}
}

public System.String Batch {
get { return SafeGetValue<System.String>("Batch");}
set { this["Batch"] = value;}
}

public System.String Invoice {
get { return SafeGetValue<System.String>("Invoice");}
set { this["Invoice"] = value;}
}

public System.String Payment {
get { return SafeGetValue<System.String>("Payment");}
set { this["Payment"] = value;}
}

public System.String Credit {
get { return SafeGetValue<System.String>("Credit");}
set { this["Credit"] = value;}
}

public System.String Refund {
get { return SafeGetValue<System.String>("Refund");}
set { this["Refund"] = value;}
}

public System.String WriteOff {
get { return SafeGetValue<System.String>("WriteOff");}
set { this["WriteOff"] = value;}
}

public System.String Gift {
get { return SafeGetValue<System.String>("Gift");}
set { this["Gift"] = value;}
}

public System.String InventoryReceipt {
get { return SafeGetValue<System.String>("InventoryReceipt");}
set { this["InventoryReceipt"] = value;}
}

public System.String InvoiceAdjustment {
get { return SafeGetValue<System.String>("InvoiceAdjustment");}
set { this["InvoiceAdjustment"] = value;}
}

public System.Collections.Generic.List<msSubLedgerEntryItem> Items {
get { return SafeGetValue<System.Collections.Generic.List<msSubLedgerEntryItem>>("Items");}
set { this["Items"] = value;}
}

}
[Serializable]
public class msSubLedgerEntryItem : msAggregateChild {
public new const string CLASS_NAME = "SubLedgerEntryItem";
public new  static class FIELDS {
public const string BusinessUnit = "BusinessUnit";
public const string InvoiceLineItemID = "InvoiceLineItemID";
public const string Type = "Type";
public const string Product = "Product";
public const string GLAccount = "GLAccount";
public const string Project = "Project";
public const string Debit = "Debit";
public const string Credit = "Credit";
}
public msSubLedgerEntryItem() : base() {
ClassType = "SubLedgerEntryItem";
}
public msSubLedgerEntryItem( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSubLedgerEntryItem FromClassMetadata(ClassMetadata meta){return new msSubLedgerEntryItem(MemberSuiteObject.FromClassMetadata(meta));}
public System.String BusinessUnit {
get { return SafeGetValue<System.String>("BusinessUnit");}
set { this["BusinessUnit"] = value;}
}

public System.String InvoiceLineItemID {
get { return SafeGetValue<System.String>("InvoiceLineItemID");}
set { this["InvoiceLineItemID"] = value;}
}

public MemberSuite.SDK.Types.SubLedgerEntryItemType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.SubLedgerEntryItemType>("Type");}
set { this["Type"] = value;}
}

public System.String Product {
get { return SafeGetValue<System.String>("Product");}
set { this["Product"] = value;}
}

public System.String GLAccount {
get { return SafeGetValue<System.String>("GLAccount");}
set { this["GLAccount"] = value;}
}

public System.String Project {
get { return SafeGetValue<System.String>("Project");}
set { this["Project"] = value;}
}

public System.Decimal Debit {
get { return SafeGetValue<System.Decimal>("Debit");}
set { this["Debit"] = value;}
}

public System.Decimal Credit {
get { return SafeGetValue<System.Decimal>("Credit");}
set { this["Credit"] = value;}
}

}
[Serializable]
public class msCustomerDomainObject : msCatalogAggregate {
public new const string CLASS_NAME = "CustomerDomainObject";
public new  static class FIELDS {
public const string Customer = "Customer";
}
public msCustomerDomainObject() : base() {
ClassType = "CustomerDomainObject";
}
public msCustomerDomainObject( MemberSuiteObject msObj) : base(msObj) {}
public System.String Customer {
get { return SafeGetValue<System.String>("Customer");}
set { this["Customer"] = value;}
}

}
[Serializable]
public class msAssociation : msCustomerDomainObject {
public new const string CLASS_NAME = "Association";
public new  static class FIELDS {
public const string Acronym = "Acronym";
public const string DatabaseServer = "DatabaseServer";
public const string BaseCurrency = "BaseCurrency";
public const string DisabledSince = "DisabledSince";
public const string TimeZone = "TimeZone";
public const string DateLastAccessed = "DateLastAccessed";
public const string LastAccessedBy = "LastAccessedBy";
public const string PortalSelfHostUri = "PortalSelfHostUri";
public const string PortalDisabled = "PortalDisabled";
public const string PartitionKey = "PartitionKey";
public const string FiscalYearEnd = "FiscalYearEnd";
public const string Mode = "Mode";
public const string Status = "Status";
public const string EnableApiAccess = "EnableApiAccess";
public const string TrialEndDate = "TrialEndDate";
public const string SalesforceID = "SalesforceID";
public const string ErrorMessage = "ErrorMessage";
public const string BillingId = "BillingId";
}
public msAssociation() : base() {
ClassType = "Association";
}
public msAssociation( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAssociation FromClassMetadata(ClassMetadata meta){return new msAssociation(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Acronym {
get { return SafeGetValue<System.String>("Acronym");}
set { this["Acronym"] = value;}
}

public System.String DatabaseServer {
get { return SafeGetValue<System.String>("DatabaseServer");}
set { this["DatabaseServer"] = value;}
}

public System.String BaseCurrency {
get { return SafeGetValue<System.String>("BaseCurrency");}
set { this["BaseCurrency"] = value;}
}

public System.DateTime? DisabledSince {
get { return SafeGetValue<System.DateTime?>("DisabledSince");}
set { this["DisabledSince"] = value;}
}

public System.String TimeZone {
get { return SafeGetValue<System.String>("TimeZone");}
set { this["TimeZone"] = value;}
}

public System.DateTime? DateLastAccessed {
get { return SafeGetValue<System.DateTime?>("DateLastAccessed");}
set { this["DateLastAccessed"] = value;}
}

public System.String LastAccessedBy {
get { return SafeGetValue<System.String>("LastAccessedBy");}
set { this["LastAccessedBy"] = value;}
}

public System.String PortalSelfHostUri {
get { return SafeGetValue<System.String>("PortalSelfHostUri");}
set { this["PortalSelfHostUri"] = value;}
}

public System.Boolean PortalDisabled {
get { return SafeGetValue<System.Boolean>("PortalDisabled");}
set { this["PortalDisabled"] = value;}
}

public System.Int64 PartitionKey {
get { return SafeGetValue<System.Int64>("PartitionKey");}
set { this["PartitionKey"] = value;}
}

public System.Int16 FiscalYearEnd {
get { return SafeGetValue<System.Int16>("FiscalYearEnd");}
set { this["FiscalYearEnd"] = value;}
}

public MemberSuite.SDK.Types.AssociationMode Mode {
get { return SafeGetValue<MemberSuite.SDK.Types.AssociationMode>("Mode");}
set { this["Mode"] = value;}
}

public MemberSuite.SDK.Types.AssociationStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.AssociationStatus>("Status");}
set { this["Status"] = value;}
}

public System.Boolean EnableApiAccess {
get { return SafeGetValue<System.Boolean>("EnableApiAccess");}
set { this["EnableApiAccess"] = value;}
}

public System.DateTime? TrialEndDate {
get { return SafeGetValue<System.DateTime?>("TrialEndDate");}
set { this["TrialEndDate"] = value;}
}

public System.String SalesforceID {
get { return SafeGetValue<System.String>("SalesforceID");}
set { this["SalesforceID"] = value;}
}

public System.String ErrorMessage {
get { return SafeGetValue<System.String>("ErrorMessage");}
set { this["ErrorMessage"] = value;}
}

public System.String BillingId {
get { return SafeGetValue<System.String>("BillingId");}
set { this["BillingId"] = value;}
}

}
[Serializable]
public class msResellerDomainObject : msCatalogAggregate {
public new const string CLASS_NAME = "ResellerDomainObject";
public new  static class FIELDS {
public const string Reseller = "Reseller";
}
public msResellerDomainObject() : base() {
ClassType = "ResellerDomainObject";
}
public msResellerDomainObject( MemberSuiteObject msObj) : base(msObj) {}
public System.String Reseller {
get { return SafeGetValue<System.String>("Reseller");}
set { this["Reseller"] = value;}
}

}
[Serializable]
public class msCustomer : msResellerDomainObject {
public new const string CLASS_NAME = "Customer";
public new  static class FIELDS {
public const string BillingId = "BillingId";
public const string SalesforceID = "SalesforceID";
public const string EnableTrainingAccess = "EnableTrainingAccess";
public const string RestrictModules = "RestrictModules";
public const string TrialExpirationDate = "TrialExpirationDate";
public const string NumberOfUsers = "NumberOfUsers";
public const string BillingGracePeriod = "BillingGracePeriod";
public const string Status = "Status";
public const string EnableParatureSso = "EnableParatureSso";
public const string TimeZone = "TimeZone";
public const string LastSuspensionDate = "LastSuspensionDate";
public const string EnableRealtorsModule = "EnableRealtorsModule";
public const string EnableEngagementModule = "EnableEngagementModule";
}
public msCustomer() : base() {
ClassType = "Customer";
RestrictModules = new System.Collections.Generic.List<System.String>();
}
public msCustomer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomer FromClassMetadata(ClassMetadata meta){return new msCustomer(MemberSuiteObject.FromClassMetadata(meta));}
public System.String BillingId {
get { return SafeGetValue<System.String>("BillingId");}
set { this["BillingId"] = value;}
}

public System.String SalesforceID {
get { return SafeGetValue<System.String>("SalesforceID");}
set { this["SalesforceID"] = value;}
}

public System.Boolean EnableTrainingAccess {
get { return SafeGetValue<System.Boolean>("EnableTrainingAccess");}
set { this["EnableTrainingAccess"] = value;}
}

public System.Collections.Generic.List<System.String> RestrictModules {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("RestrictModules");}
set { this["RestrictModules"] = value;}
}

public System.DateTime? TrialExpirationDate {
get { return SafeGetValue<System.DateTime?>("TrialExpirationDate");}
set { this["TrialExpirationDate"] = value;}
}

public System.Int32? NumberOfUsers {
get { return SafeGetValue<System.Int32?>("NumberOfUsers");}
set { this["NumberOfUsers"] = value;}
}

public System.DateTime? BillingGracePeriod {
get { return SafeGetValue<System.DateTime?>("BillingGracePeriod");}
set { this["BillingGracePeriod"] = value;}
}

public MemberSuite.SDK.Types.CustomerStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.CustomerStatus>("Status");}
set { this["Status"] = value;}
}

public System.Boolean EnableParatureSso {
get { return SafeGetValue<System.Boolean>("EnableParatureSso");}
set { this["EnableParatureSso"] = value;}
}

public System.String TimeZone {
get { return SafeGetValue<System.String>("TimeZone");}
set { this["TimeZone"] = value;}
}

public System.DateTime? LastSuspensionDate {
get { return SafeGetValue<System.DateTime?>("LastSuspensionDate");}
set { this["LastSuspensionDate"] = value;}
}

public System.Boolean EnableRealtorsModule {
get { return SafeGetValue<System.Boolean>("EnableRealtorsModule");}
set { this["EnableRealtorsModule"] = value;}
}

public System.Boolean EnableEngagementModule {
get { return SafeGetValue<System.Boolean>("EnableEngagementModule");}
set { this["EnableEngagementModule"] = value;}
}

}
[Serializable]
public class msUser : msSystemDomainObject {
public new const string CLASS_NAME = "User";
public new  static class FIELDS {
public const string FirstName = "FirstName";
public const string LastName = "LastName";
public const string EmailAddress = "EmailAddress";
public const string PasswordHash = "PasswordHash";
public const string Title = "Title";
public const string Department = "Department";
public const string IsActive = "IsActive";
public const string IsSuperUser = "IsSuperUser";
public const string TimeZone = "TimeZone";
public const string LastAssociation = "LastAssociation";
public const string LastLoggedIn = "LastLoggedIn";
public const string FirstLoginDate = "FirstLoginDate";
public const string PhoneNumber = "PhoneNumber";
public const string Notes = "Notes";
public const string SecurityQuestion = "SecurityQuestion";
public const string SecurityAnswer = "SecurityAnswer";
public const string MustChangePassword = "MustChangePassword";
public const string Locale = "Locale";
}
public msUser() : base() {
ClassType = "User";
}
public msUser( MemberSuiteObject msObj) : base(msObj) {}
public System.String FirstName {
get { return SafeGetValue<System.String>("FirstName");}
set { this["FirstName"] = value;}
}

public System.String LastName {
get { return SafeGetValue<System.String>("LastName");}
set { this["LastName"] = value;}
}

public System.String EmailAddress {
get { return SafeGetValue<System.String>("EmailAddress");}
set { this["EmailAddress"] = value;}
}

public System.String PasswordHash {
get { return SafeGetValue<System.String>("PasswordHash");}
set { this["PasswordHash"] = value;}
}

public System.String Title {
get { return SafeGetValue<System.String>("Title");}
set { this["Title"] = value;}
}

public System.String Department {
get { return SafeGetValue<System.String>("Department");}
set { this["Department"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.Boolean IsSuperUser {
get { return SafeGetValue<System.Boolean>("IsSuperUser");}
set { this["IsSuperUser"] = value;}
}

public System.String TimeZone {
get { return SafeGetValue<System.String>("TimeZone");}
set { this["TimeZone"] = value;}
}

public System.String LastAssociation {
get { return SafeGetValue<System.String>("LastAssociation");}
set { this["LastAssociation"] = value;}
}

public System.DateTime? LastLoggedIn {
get { return SafeGetValue<System.DateTime?>("LastLoggedIn");}
set { this["LastLoggedIn"] = value;}
}

public System.DateTime? FirstLoginDate {
get { return SafeGetValue<System.DateTime?>("FirstLoginDate");}
set { this["FirstLoginDate"] = value;}
}

public System.String PhoneNumber {
get { return SafeGetValue<System.String>("PhoneNumber");}
set { this["PhoneNumber"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.String SecurityQuestion {
get { return SafeGetValue<System.String>("SecurityQuestion");}
set { this["SecurityQuestion"] = value;}
}

public System.String SecurityAnswer {
get { return SafeGetValue<System.String>("SecurityAnswer");}
set { this["SecurityAnswer"] = value;}
}

public System.Boolean MustChangePassword {
get { return SafeGetValue<System.Boolean>("MustChangePassword");}
set { this["MustChangePassword"] = value;}
}

public System.String Locale {
get { return SafeGetValue<System.String>("Locale");}
set { this["Locale"] = value;}
}

}
[Serializable]
public class msCustomerUser : msUser {
public new const string CLASS_NAME = "CustomerUser";
public new  static class FIELDS {
public const string Customer = "Customer";
public const string IsAPIUser = "IsAPIUser";
public const string AccessibleAssociations = "AccessibleAssociations";
public const string SalesforceID = "SalesforceID";
public const string IsBillingContact = "IsBillingContact";
public const string IsTechnicalContact = "IsTechnicalContact";
public const string IsExecutiveContact = "IsExecutiveContact";
}
public msCustomerUser() : base() {
ClassType = "CustomerUser";
AccessibleAssociations = new System.Collections.Generic.List<System.String>();
}
public msCustomerUser( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomerUser FromClassMetadata(ClassMetadata meta){return new msCustomerUser(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Customer {
get { return SafeGetValue<System.String>("Customer");}
set { this["Customer"] = value;}
}

public System.Boolean IsAPIUser {
get { return SafeGetValue<System.Boolean>("IsAPIUser");}
set { this["IsAPIUser"] = value;}
}

public System.Collections.Generic.List<System.String> AccessibleAssociations {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("AccessibleAssociations");}
set { this["AccessibleAssociations"] = value;}
}

public System.String SalesforceID {
get { return SafeGetValue<System.String>("SalesforceID");}
set { this["SalesforceID"] = value;}
}

public System.Boolean IsBillingContact {
get { return SafeGetValue<System.Boolean>("IsBillingContact");}
set { this["IsBillingContact"] = value;}
}

public System.Boolean IsTechnicalContact {
get { return SafeGetValue<System.Boolean>("IsTechnicalContact");}
set { this["IsTechnicalContact"] = value;}
}

public System.Boolean IsExecutiveContact {
get { return SafeGetValue<System.Boolean>("IsExecutiveContact");}
set { this["IsExecutiveContact"] = value;}
}

}
[Serializable]
public class msReseller : msSystemDomainObject {
public new const string CLASS_NAME = "Reseller";
public new  static class FIELDS {
public const string CustomersRequireBillingID = "CustomersRequireBillingID";
}
public msReseller() : base() {
ClassType = "Reseller";
}
public msReseller( MemberSuiteObject msObj) : base(msObj) {}
 public static new msReseller FromClassMetadata(ClassMetadata meta){return new msReseller(MemberSuiteObject.FromClassMetadata(meta));}
public System.Boolean CustomersRequireBillingID {
get { return SafeGetValue<System.Boolean>("CustomersRequireBillingID");}
set { this["CustomersRequireBillingID"] = value;}
}

}
[Serializable]
public class msResellerUser : msUser {
public new const string CLASS_NAME = "ResellerUser";
public new  static class FIELDS {
public const string Reseller = "Reseller";
public const string AccessibleCustomers = "AccessibleCustomers";
}
public msResellerUser() : base() {
ClassType = "ResellerUser";
AccessibleCustomers = new System.Collections.Generic.List<System.String>();
}
public msResellerUser( MemberSuiteObject msObj) : base(msObj) {}
 public static new msResellerUser FromClassMetadata(ClassMetadata meta){return new msResellerUser(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Reseller {
get { return SafeGetValue<System.String>("Reseller");}
set { this["Reseller"] = value;}
}

public System.Collections.Generic.List<System.String> AccessibleCustomers {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("AccessibleCustomers");}
set { this["AccessibleCustomers"] = value;}
}

}
[Serializable]
public class msSystemWideUser : msUser {
public new const string CLASS_NAME = "SystemWideUser";
public new  static class FIELDS {
public const string AccessibleCustomers = "AccessibleCustomers";
}
public msSystemWideUser() : base() {
ClassType = "SystemWideUser";
AccessibleCustomers = new System.Collections.Generic.List<System.String>();
}
public msSystemWideUser( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSystemWideUser FromClassMetadata(ClassMetadata meta){return new msSystemWideUser(MemberSuiteObject.FromClassMetadata(meta));}
public System.Collections.Generic.List<System.String> AccessibleCustomers {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("AccessibleCustomers");}
set { this["AccessibleCustomers"] = value;}
}

}
[Serializable]
public class msActivity : msAssociationDomainObject {
public new const string CLASS_NAME = "Activity";
public new  static class FIELDS {
public const string Type = "Type";
public const string Status = "Status";
public const string Owner = "Owner";
public const string Entity = "Entity";
public const string Bill = "Bill";
public const string Legislator = "Legislator";
public const string Accreditation = "Accreditation";
public const string AccreditationAppeal = "AccreditationAppeal";
public const string AccreditationSiteVisit = "AccreditationSiteVisit";
public const string Lead = "Lead";
public const string Request = "Request";
public const string Gift = "Gift";
public const string Date = "Date";
public const string Description = "Description";
public const string Opportunity = "Opportunity";
}
public msActivity() : base() {
ClassType = "Activity";
}
public msActivity( MemberSuiteObject msObj) : base(msObj) {}
 public static new msActivity FromClassMetadata(ClassMetadata meta){return new msActivity(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Status {
get { return SafeGetValue<System.String>("Status");}
set { this["Status"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String Entity {
get { return SafeGetValue<System.String>("Entity");}
set { this["Entity"] = value;}
}

public System.String Bill {
get { return SafeGetValue<System.String>("Bill");}
set { this["Bill"] = value;}
}

public System.String Legislator {
get { return SafeGetValue<System.String>("Legislator");}
set { this["Legislator"] = value;}
}

public System.String Accreditation {
get { return SafeGetValue<System.String>("Accreditation");}
set { this["Accreditation"] = value;}
}

public System.String AccreditationAppeal {
get { return SafeGetValue<System.String>("AccreditationAppeal");}
set { this["AccreditationAppeal"] = value;}
}

public System.String AccreditationSiteVisit {
get { return SafeGetValue<System.String>("AccreditationSiteVisit");}
set { this["AccreditationSiteVisit"] = value;}
}

public System.String Lead {
get { return SafeGetValue<System.String>("Lead");}
set { this["Lead"] = value;}
}

public System.String Request {
get { return SafeGetValue<System.String>("Request");}
set { this["Request"] = value;}
}

public System.String Gift {
get { return SafeGetValue<System.String>("Gift");}
set { this["Gift"] = value;}
}

public System.DateTime Date {
get { return SafeGetValue<System.DateTime>("Date");}
set { this["Date"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String Opportunity {
get { return SafeGetValue<System.String>("Opportunity");}
set { this["Opportunity"] = value;}
}

}
[Serializable]
public class msEntityConfigurableType : msConfigurableType {
public new const string CLASS_NAME = "EntityConfigurableType";
public new  static class FIELDS {
public const string CustomerType = "CustomerType";
public const string ShowInPortal = "ShowInPortal";
public const string ShowInConsole = "ShowInConsole";
public const string RequiredInPortal = "RequiredInPortal";
}
public msEntityConfigurableType() : base() {
ClassType = "EntityConfigurableType";
}
public msEntityConfigurableType( MemberSuiteObject msObj) : base(msObj) {}
public MemberSuite.SDK.Types.CustomerType CustomerType {
get { return SafeGetValue<MemberSuite.SDK.Types.CustomerType>("CustomerType");}
set { this["CustomerType"] = value;}
}

public System.Boolean ShowInPortal {
get { return SafeGetValue<System.Boolean>("ShowInPortal");}
set { this["ShowInPortal"] = value;}
}

public System.Boolean ShowInConsole {
get { return SafeGetValue<System.Boolean>("ShowInConsole");}
set { this["ShowInConsole"] = value;}
}

public System.Boolean RequiredInPortal {
get { return SafeGetValue<System.Boolean>("RequiredInPortal");}
set { this["RequiredInPortal"] = value;}
}

}
[Serializable]
public class msAddressType : msEntityConfigurableType {
public new const string CLASS_NAME = "AddressType";
public new  static class FIELDS {
public const string IsSeasonal = "IsSeasonal";
}
public msAddressType() : base() {
ClassType = "AddressType";
}
public msAddressType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAddressType FromClassMetadata(ClassMetadata meta){return new msAddressType(MemberSuiteObject.FromClassMetadata(meta));}
public System.Boolean IsSeasonal {
get { return SafeGetValue<System.Boolean>("IsSeasonal");}
set { this["IsSeasonal"] = value;}
}

}
[Serializable]
public class msEntity : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Entity";
public new  static class FIELDS {
public const string Owner = "Owner";
public const string SortName = "SortName";
public const string EmailAddress = "EmailAddress";
public const string Addresses = "Addresses";
public const string TaxExempt = "TaxExempt";
public const string DefaultCreditTerms = "DefaultCreditTerms";
public const string PhoneNumbers = "PhoneNumbers";
public const string PreferredAddressType = "PreferredAddressType";
public const string PreferredPhoneNumberType = "PreferredPhoneNumberType";
public const string DonorLevel = "DonorLevel";
public const string SourceCode = "SourceCode";
public const string MediaCode = "MediaCode";
public const string WebSite = "WebSite";
public const string Notes = "Notes";
public const string Image = "Image";
public const string LegislativeDistricts = "LegislativeDistricts";
public const string NRDSID = "NRDSID";
}
public msEntity() : base() {
ClassType = "Entity";
Addresses = new System.Collections.Generic.List<msEntityAddress>();
PhoneNumbers = new System.Collections.Generic.List<msEntityPhoneNumber>();
LegislativeDistricts = new System.Collections.Generic.List<msEntityLegislativeDistrict>();
}
public msEntity( MemberSuiteObject msObj) : base(msObj) {}
public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String SortName {
get { return SafeGetValue<System.String>("SortName");}
set { this["SortName"] = value;}
}

public System.String EmailAddress {
get { return SafeGetValue<System.String>("EmailAddress");}
set { this["EmailAddress"] = value;}
}

public System.Collections.Generic.List<msEntityAddress> Addresses {
get { return SafeGetValue<System.Collections.Generic.List<msEntityAddress>>("Addresses");}
set { this["Addresses"] = value;}
}

public System.Boolean TaxExempt {
get { return SafeGetValue<System.Boolean>("TaxExempt");}
set { this["TaxExempt"] = value;}
}

public System.String DefaultCreditTerms {
get { return SafeGetValue<System.String>("DefaultCreditTerms");}
set { this["DefaultCreditTerms"] = value;}
}

public System.Collections.Generic.List<msEntityPhoneNumber> PhoneNumbers {
get { return SafeGetValue<System.Collections.Generic.List<msEntityPhoneNumber>>("PhoneNumbers");}
set { this["PhoneNumbers"] = value;}
}

public System.String PreferredAddressType {
get { return SafeGetValue<System.String>("PreferredAddressType");}
set { this["PreferredAddressType"] = value;}
}

public System.String PreferredPhoneNumberType {
get { return SafeGetValue<System.String>("PreferredPhoneNumberType");}
set { this["PreferredPhoneNumberType"] = value;}
}

public System.String DonorLevel {
get { return SafeGetValue<System.String>("DonorLevel");}
set { this["DonorLevel"] = value;}
}

public System.String SourceCode {
get { return SafeGetValue<System.String>("SourceCode");}
set { this["SourceCode"] = value;}
}

public System.String MediaCode {
get { return SafeGetValue<System.String>("MediaCode");}
set { this["MediaCode"] = value;}
}

public System.String WebSite {
get { return SafeGetValue<System.String>("WebSite");}
set { this["WebSite"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.String Image {
get { return SafeGetValue<System.String>("Image");}
set { this["Image"] = value;}
}

public System.Collections.Generic.List<msEntityLegislativeDistrict> LegislativeDistricts {
get { return SafeGetValue<System.Collections.Generic.List<msEntityLegislativeDistrict>>("LegislativeDistricts");}
set { this["LegislativeDistricts"] = value;}
}

public System.Int32? NRDSID {
get { return SafeGetValue<System.Int32?>("NRDSID");}
set { this["NRDSID"] = value;}
}

}
[Serializable]
public class msEntityLegislativeDistrict : msAggregateChild {
public new const string CLASS_NAME = "EntityLegislativeDistrict";
public new  static class FIELDS {
public const string District = "District";
}
public msEntityLegislativeDistrict() : base() {
ClassType = "EntityLegislativeDistrict";
}
public msEntityLegislativeDistrict( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEntityLegislativeDistrict FromClassMetadata(ClassMetadata meta){return new msEntityLegislativeDistrict(MemberSuiteObject.FromClassMetadata(meta));}
public System.String District {
get { return SafeGetValue<System.String>("District");}
set { this["District"] = value;}
}

}
[Serializable]
public class msEntityAddress : msAggregateChild {
public new const string CLASS_NAME = "EntityAddress";
public new  static class FIELDS {
public const string Type = "Type";
public const string Address = "Address";
public const string IsPreferred = "IsPreferred";
public const string IncorrectSince = "IncorrectSince";
public const string LastUpdated = "LastUpdated";
}
public msEntityAddress() : base() {
ClassType = "EntityAddress";
}
public msEntityAddress( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEntityAddress FromClassMetadata(ClassMetadata meta){return new msEntityAddress(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public MemberSuite.SDK.Types.Address Address {
get { return SafeGetValue<MemberSuite.SDK.Types.Address>("Address");}
set { this["Address"] = value;}
}

public System.Boolean IsPreferred {
get { return SafeGetValue<System.Boolean>("IsPreferred");}
set { this["IsPreferred"] = value;}
}

public System.DateTime? IncorrectSince {
get { return SafeGetValue<System.DateTime?>("IncorrectSince");}
set { this["IncorrectSince"] = value;}
}

public System.DateTime? LastUpdated {
get { return SafeGetValue<System.DateTime?>("LastUpdated");}
set { this["LastUpdated"] = value;}
}

}
[Serializable]
public class msEntityPhoneNumber : msAggregateChild {
public new const string CLASS_NAME = "EntityPhoneNumber";
public new  static class FIELDS {
public const string Type = "Type";
public const string PhoneNumber = "PhoneNumber";
public const string IsPreferred = "IsPreferred";
}
public msEntityPhoneNumber() : base() {
ClassType = "EntityPhoneNumber";
}
public msEntityPhoneNumber( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEntityPhoneNumber FromClassMetadata(ClassMetadata meta){return new msEntityPhoneNumber(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String PhoneNumber {
get { return SafeGetValue<System.String>("PhoneNumber");}
set { this["PhoneNumber"] = value;}
}

public System.Boolean IsPreferred {
get { return SafeGetValue<System.Boolean>("IsPreferred");}
set { this["IsPreferred"] = value;}
}

}
[Serializable]
public class msIndividual : msEntity {
public new const string CLASS_NAME = "Individual";
public new  static class FIELDS {
public const string FirstName = "FirstName";
public const string MiddleName = "MiddleName";
public const string LastName = "LastName";
public const string Nickname = "Nickname";
public const string DoNotEmail = "DoNotEmail";
public const string OptOuts = "OptOuts";
public const string CommunicationsLastVerified = "CommunicationsLastVerified";
public const string CommunicationsLastVerifiedFrom = "CommunicationsLastVerifiedFrom";
public const string DoNotFax = "DoNotFax";
public const string DoNotMail = "DoNotMail";
public const string Age = "Age";
public const string Type = "Type";
public const string DateOfBirth = "DateOfBirth";
public const string EmailAddress2 = "EmailAddress2";
public const string EmailAddress3 = "EmailAddress3";
public const string Title = "Title";
public const string Prefix = "Prefix";
public const string Suffix = "Suffix";
public const string Designation = "Designation";
public const string Company = "Company";
public const string SeasonalAddressStart = "SeasonalAddressStart";
public const string SeasonalAddressEnd = "SeasonalAddressEnd";
}
public msIndividual() : base() {
ClassType = "Individual";
OptOuts = new System.Collections.Generic.List<System.String>();
Addresses = new System.Collections.Generic.List<msEntityAddress>();
PhoneNumbers = new System.Collections.Generic.List<msEntityPhoneNumber>();
LegislativeDistricts = new System.Collections.Generic.List<msEntityLegislativeDistrict>();
}
public msIndividual( MemberSuiteObject msObj) : base(msObj) {}
 public static new msIndividual FromClassMetadata(ClassMetadata meta){return new msIndividual(MemberSuiteObject.FromClassMetadata(meta));}
public System.String FirstName {
get { return SafeGetValue<System.String>("FirstName");}
set { this["FirstName"] = value;}
}

public System.String MiddleName {
get { return SafeGetValue<System.String>("MiddleName");}
set { this["MiddleName"] = value;}
}

public System.String LastName {
get { return SafeGetValue<System.String>("LastName");}
set { this["LastName"] = value;}
}

public System.String Nickname {
get { return SafeGetValue<System.String>("Nickname");}
set { this["Nickname"] = value;}
}

public System.Boolean DoNotEmail {
get { return SafeGetValue<System.Boolean>("DoNotEmail");}
set { this["DoNotEmail"] = value;}
}

public System.Collections.Generic.List<System.String> OptOuts {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("OptOuts");}
set { this["OptOuts"] = value;}
}

public System.DateTime? CommunicationsLastVerified {
get { return SafeGetValue<System.DateTime?>("CommunicationsLastVerified");}
set { this["CommunicationsLastVerified"] = value;}
}

public System.String CommunicationsLastVerifiedFrom {
get { return SafeGetValue<System.String>("CommunicationsLastVerifiedFrom");}
set { this["CommunicationsLastVerifiedFrom"] = value;}
}

public System.Boolean DoNotFax {
get { return SafeGetValue<System.Boolean>("DoNotFax");}
set { this["DoNotFax"] = value;}
}

public System.Boolean DoNotMail {
get { return SafeGetValue<System.Boolean>("DoNotMail");}
set { this["DoNotMail"] = value;}
}

public System.Int32? Age {
get { return SafeGetValue<System.Int32?>("Age");}
set { this["Age"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.DateTime? DateOfBirth {
get { return SafeGetValue<System.DateTime?>("DateOfBirth");}
set { this["DateOfBirth"] = value;}
}

public System.String EmailAddress2 {
get { return SafeGetValue<System.String>("EmailAddress2");}
set { this["EmailAddress2"] = value;}
}

public System.String EmailAddress3 {
get { return SafeGetValue<System.String>("EmailAddress3");}
set { this["EmailAddress3"] = value;}
}

public System.String Title {
get { return SafeGetValue<System.String>("Title");}
set { this["Title"] = value;}
}

public System.String Prefix {
get { return SafeGetValue<System.String>("Prefix");}
set { this["Prefix"] = value;}
}

public System.String Suffix {
get { return SafeGetValue<System.String>("Suffix");}
set { this["Suffix"] = value;}
}

public System.String Designation {
get { return SafeGetValue<System.String>("Designation");}
set { this["Designation"] = value;}
}

public System.String Company {
get { return SafeGetValue<System.String>("Company");}
set { this["Company"] = value;}
}

public System.DateTime? SeasonalAddressStart {
get { return SafeGetValue<System.DateTime?>("SeasonalAddressStart");}
set { this["SeasonalAddressStart"] = value;}
}

public System.DateTime? SeasonalAddressEnd {
get { return SafeGetValue<System.DateTime?>("SeasonalAddressEnd");}
set { this["SeasonalAddressEnd"] = value;}
}

}
[Serializable]
public class msEntityType : msPageLayoutConfigurableType {
public new const string CLASS_NAME = "EntityType";
public new  static class FIELDS {
}
public msEntityType() : base() {
ClassType = "EntityType";
}
public msEntityType( MemberSuiteObject msObj) : base(msObj) {}
}
[Serializable]
public class msIndividualType : msEntityType {
public new const string CLASS_NAME = "IndividualType";
public new  static class FIELDS {
}
public msIndividualType() : base() {
ClassType = "IndividualType";
}
public msIndividualType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msIndividualType FromClassMetadata(ClassMetadata meta){return new msIndividualType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msOrganization : msEntity {
public new const string CLASS_NAME = "Organization";
public new  static class FIELDS {
public const string Type = "Type";
public const string BillingContactName = "BillingContactName";
public const string BillingContactPhoneNumber = "BillingContactPhoneNumber";
}
public msOrganization() : base() {
ClassType = "Organization";
Addresses = new System.Collections.Generic.List<msEntityAddress>();
PhoneNumbers = new System.Collections.Generic.List<msEntityPhoneNumber>();
LegislativeDistricts = new System.Collections.Generic.List<msEntityLegislativeDistrict>();
}
public msOrganization( MemberSuiteObject msObj) : base(msObj) {}
 public static new msOrganization FromClassMetadata(ClassMetadata meta){return new msOrganization(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String BillingContactName {
get { return SafeGetValue<System.String>("BillingContactName");}
set { this["BillingContactName"] = value;}
}

public System.String BillingContactPhoneNumber {
get { return SafeGetValue<System.String>("BillingContactPhoneNumber");}
set { this["BillingContactPhoneNumber"] = value;}
}

}
[Serializable]
public class msOrganizationType : msEntityType {
public new const string CLASS_NAME = "OrganizationType";
public new  static class FIELDS {
}
public msOrganizationType() : base() {
ClassType = "OrganizationType";
}
public msOrganizationType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msOrganizationType FromClassMetadata(ClassMetadata meta){return new msOrganizationType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msPhoneNumberType : msEntityConfigurableType {
public new const string CLASS_NAME = "PhoneNumberType";
public new  static class FIELDS {
}
public msPhoneNumberType() : base() {
ClassType = "PhoneNumberType";
}
public msPhoneNumberType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPhoneNumberType FromClassMetadata(ClassMetadata meta){return new msPhoneNumberType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msRelationship : msAssociationDomainObject {
public new const string CLASS_NAME = "Relationship";
public new  static class FIELDS {
public const string Type = "Type";
public const string LeftSide = "LeftSide";
public const string RightSide = "RightSide";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string SuppressAddressFlowDown = "SuppressAddressFlowDown";
public const string SuppressPhoneNumberFlowDown = "SuppressPhoneNumberFlowDown";
public const string SuppressMembershipFlowDown = "SuppressMembershipFlowDown";
public const string Description = "Description";
public const string SoftCreditLeftRightPercentage = "SoftCreditLeftRightPercentage";
public const string SoftCreditRightLeftPercentage = "SoftCreditRightLeftPercentage";
public const string IsPrimary = "IsPrimary";
}
public msRelationship() : base() {
ClassType = "Relationship";
}
public msRelationship( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRelationship FromClassMetadata(ClassMetadata meta){return new msRelationship(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String LeftSide {
get { return SafeGetValue<System.String>("LeftSide");}
set { this["LeftSide"] = value;}
}

public System.String RightSide {
get { return SafeGetValue<System.String>("RightSide");}
set { this["RightSide"] = value;}
}

public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? EndDate {
get { return SafeGetValue<System.DateTime?>("EndDate");}
set { this["EndDate"] = value;}
}

public System.Boolean SuppressAddressFlowDown {
get { return SafeGetValue<System.Boolean>("SuppressAddressFlowDown");}
set { this["SuppressAddressFlowDown"] = value;}
}

public System.Boolean SuppressPhoneNumberFlowDown {
get { return SafeGetValue<System.Boolean>("SuppressPhoneNumberFlowDown");}
set { this["SuppressPhoneNumberFlowDown"] = value;}
}

public System.Boolean SuppressMembershipFlowDown {
get { return SafeGetValue<System.Boolean>("SuppressMembershipFlowDown");}
set { this["SuppressMembershipFlowDown"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Decimal? SoftCreditLeftRightPercentage {
get { return SafeGetValue<System.Decimal?>("SoftCreditLeftRightPercentage");}
set { this["SoftCreditLeftRightPercentage"] = value;}
}

public System.Decimal? SoftCreditRightLeftPercentage {
get { return SafeGetValue<System.Decimal?>("SoftCreditRightLeftPercentage");}
set { this["SoftCreditRightLeftPercentage"] = value;}
}

public System.Boolean IsPrimary {
get { return SafeGetValue<System.Boolean>("IsPrimary");}
set { this["IsPrimary"] = value;}
}

}
[Serializable]
public class msRelationshipType : msConfigurableType {
public new const string CLASS_NAME = "RelationshipType";
public new  static class FIELDS {
public const string LeftSideType = "LeftSideType";
public const string LeftSideName = "LeftSideName";
public const string RightSideType = "RightSideType";
public const string RightSideName = "RightSideName";
public const string Multiplicity = "Multiplicity";
public const string FlowDownAddressType = "FlowDownAddressType";
public const string FlowDownPhoneNumberType = "FlowDownPhoneNumberType";
public const string EnableMembershipFlowDown = "EnableMembershipFlowDown";
public const string BillingContact = "BillingContact";
public const string BillThroughForMembership = "BillThroughForMembership";
public const string SoftCreditLeftRightPercentage = "SoftCreditLeftRightPercentage";
public const string SoftCreditRightLeftPercentage = "SoftCreditRightLeftPercentage";
public const string MessageCategories = "MessageCategories";
public const string RealtorDesignation = "RealtorDesignation";
public const string EnablePortalManagement = "EnablePortalManagement";
public const string SuppressDescription = "SuppressDescription";
public const string EligibleForPortalSignup = "EligibleForPortalSignup";
}
public msRelationshipType() : base() {
ClassType = "RelationshipType";
MessageCategories = new System.Collections.Generic.List<msRelationshipTypeMessageCategory>();
}
public msRelationshipType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRelationshipType FromClassMetadata(ClassMetadata meta){return new msRelationshipType(MemberSuiteObject.FromClassMetadata(meta));}
public System.String LeftSideType {
get { return SafeGetValue<System.String>("LeftSideType");}
set { this["LeftSideType"] = value;}
}

public System.String LeftSideName {
get { return SafeGetValue<System.String>("LeftSideName");}
set { this["LeftSideName"] = value;}
}

public System.String RightSideType {
get { return SafeGetValue<System.String>("RightSideType");}
set { this["RightSideType"] = value;}
}

public System.String RightSideName {
get { return SafeGetValue<System.String>("RightSideName");}
set { this["RightSideName"] = value;}
}

public MemberSuite.SDK.Types.RelationshipMultiplicity Multiplicity {
get { return SafeGetValue<MemberSuite.SDK.Types.RelationshipMultiplicity>("Multiplicity");}
set { this["Multiplicity"] = value;}
}

public System.String FlowDownAddressType {
get { return SafeGetValue<System.String>("FlowDownAddressType");}
set { this["FlowDownAddressType"] = value;}
}

public System.String FlowDownPhoneNumberType {
get { return SafeGetValue<System.String>("FlowDownPhoneNumberType");}
set { this["FlowDownPhoneNumberType"] = value;}
}

public System.Boolean EnableMembershipFlowDown {
get { return SafeGetValue<System.Boolean>("EnableMembershipFlowDown");}
set { this["EnableMembershipFlowDown"] = value;}
}

public System.Boolean BillingContact {
get { return SafeGetValue<System.Boolean>("BillingContact");}
set { this["BillingContact"] = value;}
}

public System.Boolean BillThroughForMembership {
get { return SafeGetValue<System.Boolean>("BillThroughForMembership");}
set { this["BillThroughForMembership"] = value;}
}

public System.Decimal? SoftCreditLeftRightPercentage {
get { return SafeGetValue<System.Decimal?>("SoftCreditLeftRightPercentage");}
set { this["SoftCreditLeftRightPercentage"] = value;}
}

public System.Decimal? SoftCreditRightLeftPercentage {
get { return SafeGetValue<System.Decimal?>("SoftCreditRightLeftPercentage");}
set { this["SoftCreditRightLeftPercentage"] = value;}
}

public System.Collections.Generic.List<msRelationshipTypeMessageCategory> MessageCategories {
get { return SafeGetValue<System.Collections.Generic.List<msRelationshipTypeMessageCategory>>("MessageCategories");}
set { this["MessageCategories"] = value;}
}

public MemberSuite.SDK.Types.RealtorRelationshipDesignation RealtorDesignation {
get { return SafeGetValue<MemberSuite.SDK.Types.RealtorRelationshipDesignation>("RealtorDesignation");}
set { this["RealtorDesignation"] = value;}
}

public System.Boolean EnablePortalManagement {
get { return SafeGetValue<System.Boolean>("EnablePortalManagement");}
set { this["EnablePortalManagement"] = value;}
}

public System.Boolean SuppressDescription {
get { return SafeGetValue<System.Boolean>("SuppressDescription");}
set { this["SuppressDescription"] = value;}
}

public System.Boolean EligibleForPortalSignup {
get { return SafeGetValue<System.Boolean>("EligibleForPortalSignup");}
set { this["EligibleForPortalSignup"] = value;}
}

}
[Serializable]
public class msRelationshipTypeMessageCategory : msAggregateChild {
public new const string CLASS_NAME = "RelationshipTypeMessageCategory";
public new  static class FIELDS {
public const string Category = "Category";
}
public msRelationshipTypeMessageCategory() : base() {
ClassType = "RelationshipTypeMessageCategory";
}
public msRelationshipTypeMessageCategory( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRelationshipTypeMessageCategory FromClassMetadata(ClassMetadata meta){return new msRelationshipTypeMessageCategory(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Category {
get { return SafeGetValue<System.String>("Category");}
set { this["Category"] = value;}
}

}
[Serializable]
public class msTask : msAssociationDomainObject {
public new const string CLASS_NAME = "Task";
public new  static class FIELDS {
public const string Description = "Description";
public const string DueDate = "DueDate";
public const string Status = "Status";
public const string Owner = "Owner";
}
public msTask() : base() {
ClassType = "Task";
}
public msTask( MemberSuiteObject msObj) : base(msObj) {}
 public static new msTask FromClassMetadata(ClassMetadata meta){return new msTask(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.DateTime? DueDate {
get { return SafeGetValue<System.DateTime?>("DueDate");}
set { this["DueDate"] = value;}
}

public MemberSuite.SDK.Types.TaskStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.TaskStatus>("Status");}
set { this["Status"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

}
[Serializable]
public class msCommandOverride : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "CommandOverride";
public new  static class FIELDS {
public const string Display = "Display";
public const string RedirectTo = "RedirectTo";
}
public msCommandOverride() : base() {
ClassType = "CommandOverride";
}
public msCommandOverride( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCommandOverride FromClassMetadata(ClassMetadata meta){return new msCommandOverride(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.DisplayTarget Display {
get { return SafeGetValue<MemberSuite.SDK.Types.DisplayTarget>("Display");}
set { this["Display"] = value;}
}

public System.String RedirectTo {
get { return SafeGetValue<System.String>("RedirectTo");}
set { this["RedirectTo"] = value;}
}

}
[Serializable]
public class msExtensionService : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "ExtensionService";
public new  static class FIELDS {
public const string Transport = "Transport";
public const string Uri = "Uri";
public const string LastAccess = "LastAccess";
public const string Faulted = "Faulted";
public const string LastErrorMessage = "LastErrorMessage";
public const string DisabledUntil = "DisabledUntil";
}
public msExtensionService() : base() {
ClassType = "ExtensionService";
}
public msExtensionService( MemberSuiteObject msObj) : base(msObj) {}
 public static new msExtensionService FromClassMetadata(ClassMetadata meta){return new msExtensionService(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.ExtensionServiceTransport Transport {
get { return SafeGetValue<MemberSuite.SDK.Types.ExtensionServiceTransport>("Transport");}
set { this["Transport"] = value;}
}

public System.String Uri {
get { return SafeGetValue<System.String>("Uri");}
set { this["Uri"] = value;}
}

public System.DateTime? LastAccess {
get { return SafeGetValue<System.DateTime?>("LastAccess");}
set { this["LastAccess"] = value;}
}

public System.Boolean Faulted {
get { return SafeGetValue<System.Boolean>("Faulted");}
set { this["Faulted"] = value;}
}

public System.String LastErrorMessage {
get { return SafeGetValue<System.String>("LastErrorMessage");}
set { this["LastErrorMessage"] = value;}
}

public System.DateTime? DisabledUntil {
get { return SafeGetValue<System.DateTime?>("DisabledUntil");}
set { this["DisabledUntil"] = value;}
}

}
[Serializable]
public class msIntegrationLink : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "IntegrationLink";
public new  static class FIELDS {
public const string Type = "Type";
public const string TargetGroup = "TargetGroup";
public const string Display = "Display";
public const string TargetName = "TargetName";
public const string Description = "Description";
public const string Link = "Link";
public const string DisplayCriteria = "DisplayCriteria";
public const string PostLoginToken = "PostLoginToken";
}
public msIntegrationLink() : base() {
ClassType = "IntegrationLink";
}
public msIntegrationLink( MemberSuiteObject msObj) : base(msObj) {}
 public static new msIntegrationLink FromClassMetadata(ClassMetadata meta){return new msIntegrationLink(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.IntegrationLinkTargetType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.IntegrationLinkTargetType>("Type");}
set { this["Type"] = value;}
}

public System.String TargetGroup {
get { return SafeGetValue<System.String>("TargetGroup");}
set { this["TargetGroup"] = value;}
}

public MemberSuite.SDK.Types.DisplayTarget Display {
get { return SafeGetValue<MemberSuite.SDK.Types.DisplayTarget>("Display");}
set { this["Display"] = value;}
}

public System.String TargetName {
get { return SafeGetValue<System.String>("TargetName");}
set { this["TargetName"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String Link {
get { return SafeGetValue<System.String>("Link");}
set { this["Link"] = value;}
}

public System.String DisplayCriteria {
get { return SafeGetValue<System.String>("DisplayCriteria");}
set { this["DisplayCriteria"] = value;}
}

public System.Boolean PostLoginToken {
get { return SafeGetValue<System.Boolean>("PostLoginToken");}
set { this["PostLoginToken"] = value;}
}

}
[Serializable]
public class msAssociationConfigurationContainer : msAssociationDomainObject {
public new const string CLASS_NAME = "AssociationConfigurationContainer";
public new  static class FIELDS {
public const string ConfigurationValues = "ConfigurationValues";
public const string DisplayAddress = "DisplayAddress";
public const string EnableApiAccess = "EnableApiAccess";
public const string Mode = "Mode";
public const string Acronym = "Acronym";
public const string Address = "Address";
public const string Logo = "Logo";
public const string Locale = "Locale";
public const string OrderReceiptReport = "OrderReceiptReport";
public const string PortalHeaderGraphic = "PortalHeaderGraphic";
public const string PortalSkin = "PortalSkin";
public const string PortalLoginScreenText = "PortalLoginScreenText";
public const string PortalDisplayBecomeMember = "PortalDisplayBecomeMember";
public const string PortalDisplayMakeDonation = "PortalDisplayMakeDonation";
public const string PortalAdditionalLinks = "PortalAdditionalLinks";
public const string ShowUpcomingEventsTabInPortal = "ShowUpcomingEventsTabInPortal";
public const string SendEmailWhenUserUpdatesInformation = "SendEmailWhenUserUpdatesInformation";
public const string PortalDisplayCreateUserAccount = "PortalDisplayCreateUserAccount";
public const string AssociationHomePageUrl = "AssociationHomePageUrl";
public const string PortalLoginRedirectURL = "PortalLoginRedirectURL";
public const string MembershipDirectoryEnabled = "MembershipDirectoryEnabled";
public const string MembershipDirectoryForMembersOnly = "MembershipDirectoryForMembersOnly";
public const string MembershipDirectorySearchFields = "MembershipDirectorySearchFields";
public const string MembershipDirectoryTabularResultsFields = "MembershipDirectoryTabularResultsFields";
public const string MembershipDirectoryDetailsFields = "MembershipDirectoryDetailsFields";
public const string PickListReport = "PickListReport";
public const string PackingListReport = "PackingListReport";
public const string OnlineStorefrontEnabled = "OnlineStorefrontEnabled";
public const string IsVerticalResponseEnabled = "IsVerticalResponseEnabled";
public const string VerticalResponseUserName = "VerticalResponseUserName";
public const string CEUSelfReportingMode = "CEUSelfReportingMode";
public const string ComponentSelfReportingMode = "ComponentSelfReportingMode";
public const string ShowCertificationsInPortal = "ShowCertificationsInPortal";
public const string ShowComponentRegistrationsInPortal = "ShowComponentRegistrationsInPortal";
public const string ShowCEUCreditsInPortal = "ShowCEUCreditsInPortal";
public const string DefaultJobPostingExpiration = "DefaultJobPostingExpiration";
public const string JobPostingAccessMode = "JobPostingAccessMode";
public const string ResumeSearchFields = "ResumeSearchFields";
public const string ResumeTabularResultsFields = "ResumeTabularResultsFields";
public const string ResumeDetailsFields = "ResumeDetailsFields";
public const string CompetitionEntryDraftStatus = "CompetitionEntryDraftStatus";
public const string CompetitionEntryPendingPaymentStatus = "CompetitionEntryPendingPaymentStatus";
public const string CompetitionEntrySubmittedStatus = "CompetitionEntrySubmittedStatus";
public const string DisableDuplicateCheckConsole = "DisableDuplicateCheckConsole";
public const string DisableDuplicateCheckPortal = "DisableDuplicateCheckPortal";
public const string PortalCSS = "PortalCSS";
public const string PortalLoginScreenTitle = "PortalLoginScreenTitle";
public const string PortalHideDropShadow = "PortalHideDropShadow";
public const string UseDropDownsForStatesAndCountries = "UseDropDownsForStatesAndCountries";
public const string ReorderPointNoficationEmail = "ReorderPointNoficationEmail";
}
public msAssociationConfigurationContainer() : base() {
ClassType = "AssociationConfigurationContainer";
ConfigurationValues = new System.Collections.Generic.List<MemberSuite.SDK.Types.NameValueStringPair>();
MembershipDirectorySearchFields = new System.Collections.Generic.List<System.String>();
MembershipDirectoryTabularResultsFields = new System.Collections.Generic.List<System.String>();
MembershipDirectoryDetailsFields = new System.Collections.Generic.List<System.String>();
ResumeSearchFields = new System.Collections.Generic.List<System.String>();
ResumeTabularResultsFields = new System.Collections.Generic.List<System.String>();
ResumeDetailsFields = new System.Collections.Generic.List<System.String>();
}
public msAssociationConfigurationContainer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAssociationConfigurationContainer FromClassMetadata(ClassMetadata meta){return new msAssociationConfigurationContainer(MemberSuiteObject.FromClassMetadata(meta));}
public System.Collections.Generic.List<MemberSuite.SDK.Types.NameValueStringPair> ConfigurationValues {
get { return SafeGetValue<System.Collections.Generic.List<MemberSuite.SDK.Types.NameValueStringPair>>("ConfigurationValues");}
set { this["ConfigurationValues"] = value;}
}

public System.String DisplayAddress {
get { return SafeGetValue<System.String>("DisplayAddress");}
set { this["DisplayAddress"] = value;}
}

public System.Boolean EnableApiAccess {
get { return SafeGetValue<System.Boolean>("EnableApiAccess");}
set { this["EnableApiAccess"] = value;}
}

public MemberSuite.SDK.Types.AssociationMode Mode {
get { return SafeGetValue<MemberSuite.SDK.Types.AssociationMode>("Mode");}
set { this["Mode"] = value;}
}

public System.String Acronym {
get { return SafeGetValue<System.String>("Acronym");}
set { this["Acronym"] = value;}
}

public MemberSuite.SDK.Types.Address Address {
get { return SafeGetValue<MemberSuite.SDK.Types.Address>("Address");}
set { this["Address"] = value;}
}

public System.String Logo {
get { return SafeGetValue<System.String>("Logo");}
set { this["Logo"] = value;}
}

public System.String Locale {
get { return SafeGetValue<System.String>("Locale");}
set { this["Locale"] = value;}
}

public System.String OrderReceiptReport {
get { return SafeGetValue<System.String>("OrderReceiptReport");}
set { this["OrderReceiptReport"] = value;}
}

public System.String PortalHeaderGraphic {
get { return SafeGetValue<System.String>("PortalHeaderGraphic");}
set { this["PortalHeaderGraphic"] = value;}
}

public System.String PortalSkin {
get { return SafeGetValue<System.String>("PortalSkin");}
set { this["PortalSkin"] = value;}
}

public System.String PortalLoginScreenText {
get { return SafeGetValue<System.String>("PortalLoginScreenText");}
set { this["PortalLoginScreenText"] = value;}
}

public System.Boolean PortalDisplayBecomeMember {
get { return SafeGetValue<System.Boolean>("PortalDisplayBecomeMember");}
set { this["PortalDisplayBecomeMember"] = value;}
}

public System.Boolean PortalDisplayMakeDonation {
get { return SafeGetValue<System.Boolean>("PortalDisplayMakeDonation");}
set { this["PortalDisplayMakeDonation"] = value;}
}

public System.String PortalAdditionalLinks {
get { return SafeGetValue<System.String>("PortalAdditionalLinks");}
set { this["PortalAdditionalLinks"] = value;}
}

public System.Boolean ShowUpcomingEventsTabInPortal {
get { return SafeGetValue<System.Boolean>("ShowUpcomingEventsTabInPortal");}
set { this["ShowUpcomingEventsTabInPortal"] = value;}
}

public System.Boolean SendEmailWhenUserUpdatesInformation {
get { return SafeGetValue<System.Boolean>("SendEmailWhenUserUpdatesInformation");}
set { this["SendEmailWhenUserUpdatesInformation"] = value;}
}

public System.Boolean PortalDisplayCreateUserAccount {
get { return SafeGetValue<System.Boolean>("PortalDisplayCreateUserAccount");}
set { this["PortalDisplayCreateUserAccount"] = value;}
}

public System.String AssociationHomePageUrl {
get { return SafeGetValue<System.String>("AssociationHomePageUrl");}
set { this["AssociationHomePageUrl"] = value;}
}

public System.String PortalLoginRedirectURL {
get { return SafeGetValue<System.String>("PortalLoginRedirectURL");}
set { this["PortalLoginRedirectURL"] = value;}
}

public System.Boolean MembershipDirectoryEnabled {
get { return SafeGetValue<System.Boolean>("MembershipDirectoryEnabled");}
set { this["MembershipDirectoryEnabled"] = value;}
}

public System.Boolean MembershipDirectoryForMembersOnly {
get { return SafeGetValue<System.Boolean>("MembershipDirectoryForMembersOnly");}
set { this["MembershipDirectoryForMembersOnly"] = value;}
}

public System.Collections.Generic.List<System.String> MembershipDirectorySearchFields {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("MembershipDirectorySearchFields");}
set { this["MembershipDirectorySearchFields"] = value;}
}

public System.Collections.Generic.List<System.String> MembershipDirectoryTabularResultsFields {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("MembershipDirectoryTabularResultsFields");}
set { this["MembershipDirectoryTabularResultsFields"] = value;}
}

public System.Collections.Generic.List<System.String> MembershipDirectoryDetailsFields {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("MembershipDirectoryDetailsFields");}
set { this["MembershipDirectoryDetailsFields"] = value;}
}

public System.String PickListReport {
get { return SafeGetValue<System.String>("PickListReport");}
set { this["PickListReport"] = value;}
}

public System.String PackingListReport {
get { return SafeGetValue<System.String>("PackingListReport");}
set { this["PackingListReport"] = value;}
}

public System.Boolean OnlineStorefrontEnabled {
get { return SafeGetValue<System.Boolean>("OnlineStorefrontEnabled");}
set { this["OnlineStorefrontEnabled"] = value;}
}

public System.Boolean IsVerticalResponseEnabled {
get { return SafeGetValue<System.Boolean>("IsVerticalResponseEnabled");}
set { this["IsVerticalResponseEnabled"] = value;}
}

public System.String VerticalResponseUserName {
get { return SafeGetValue<System.String>("VerticalResponseUserName");}
set { this["VerticalResponseUserName"] = value;}
}

public MemberSuite.SDK.Types.CertificationsSelfReportingMode CEUSelfReportingMode {
get { return SafeGetValue<MemberSuite.SDK.Types.CertificationsSelfReportingMode>("CEUSelfReportingMode");}
set { this["CEUSelfReportingMode"] = value;}
}

public MemberSuite.SDK.Types.CertificationsSelfReportingMode ComponentSelfReportingMode {
get { return SafeGetValue<MemberSuite.SDK.Types.CertificationsSelfReportingMode>("ComponentSelfReportingMode");}
set { this["ComponentSelfReportingMode"] = value;}
}

public System.Boolean ShowCertificationsInPortal {
get { return SafeGetValue<System.Boolean>("ShowCertificationsInPortal");}
set { this["ShowCertificationsInPortal"] = value;}
}

public System.Boolean ShowComponentRegistrationsInPortal {
get { return SafeGetValue<System.Boolean>("ShowComponentRegistrationsInPortal");}
set { this["ShowComponentRegistrationsInPortal"] = value;}
}

public System.Boolean ShowCEUCreditsInPortal {
get { return SafeGetValue<System.Boolean>("ShowCEUCreditsInPortal");}
set { this["ShowCEUCreditsInPortal"] = value;}
}

public System.Int16 DefaultJobPostingExpiration {
get { return SafeGetValue<System.Int16>("DefaultJobPostingExpiration");}
set { this["DefaultJobPostingExpiration"] = value;}
}

public MemberSuite.SDK.Types.JobPostingAccess JobPostingAccessMode {
get { return SafeGetValue<MemberSuite.SDK.Types.JobPostingAccess>("JobPostingAccessMode");}
set { this["JobPostingAccessMode"] = value;}
}

public System.Collections.Generic.List<System.String> ResumeSearchFields {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("ResumeSearchFields");}
set { this["ResumeSearchFields"] = value;}
}

public System.Collections.Generic.List<System.String> ResumeTabularResultsFields {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("ResumeTabularResultsFields");}
set { this["ResumeTabularResultsFields"] = value;}
}

public System.Collections.Generic.List<System.String> ResumeDetailsFields {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("ResumeDetailsFields");}
set { this["ResumeDetailsFields"] = value;}
}

public System.String CompetitionEntryDraftStatus {
get { return SafeGetValue<System.String>("CompetitionEntryDraftStatus");}
set { this["CompetitionEntryDraftStatus"] = value;}
}

public System.String CompetitionEntryPendingPaymentStatus {
get { return SafeGetValue<System.String>("CompetitionEntryPendingPaymentStatus");}
set { this["CompetitionEntryPendingPaymentStatus"] = value;}
}

public System.String CompetitionEntrySubmittedStatus {
get { return SafeGetValue<System.String>("CompetitionEntrySubmittedStatus");}
set { this["CompetitionEntrySubmittedStatus"] = value;}
}

public System.Boolean DisableDuplicateCheckConsole {
get { return SafeGetValue<System.Boolean>("DisableDuplicateCheckConsole");}
set { this["DisableDuplicateCheckConsole"] = value;}
}

public System.Boolean DisableDuplicateCheckPortal {
get { return SafeGetValue<System.Boolean>("DisableDuplicateCheckPortal");}
set { this["DisableDuplicateCheckPortal"] = value;}
}

public System.String PortalCSS {
get { return SafeGetValue<System.String>("PortalCSS");}
set { this["PortalCSS"] = value;}
}

public System.String PortalLoginScreenTitle {
get { return SafeGetValue<System.String>("PortalLoginScreenTitle");}
set { this["PortalLoginScreenTitle"] = value;}
}

public System.Boolean PortalHideDropShadow {
get { return SafeGetValue<System.Boolean>("PortalHideDropShadow");}
set { this["PortalHideDropShadow"] = value;}
}

public MemberSuite.SDK.Types.ConsolePortalOptions UseDropDownsForStatesAndCountries {
get { return SafeGetValue<MemberSuite.SDK.Types.ConsolePortalOptions>("UseDropDownsForStatesAndCountries");}
set { this["UseDropDownsForStatesAndCountries"] = value;}
}

public System.String ReorderPointNoficationEmail {
get { return SafeGetValue<System.String>("ReorderPointNoficationEmail");}
set { this["ReorderPointNoficationEmail"] = value;}
}

}
[Serializable]
public class msConsoleMetadataContainer : msMetadataContainer {
public new const string CLASS_NAME = "ConsoleMetadataContainer";
public new  static class FIELDS {
public const string Metadata = "Metadata";
}
public msConsoleMetadataContainer() : base() {
ClassType = "ConsoleMetadataContainer";
}
public msConsoleMetadataContainer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msConsoleMetadataContainer FromClassMetadata(ClassMetadata meta){return new msConsoleMetadataContainer(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Manifests.Console.ConsoleMetadata Metadata {
get { return SafeGetValue<MemberSuite.SDK.Manifests.Console.ConsoleMetadata>("Metadata");}
set { this["Metadata"] = value;}
}

}
[Serializable]
public class msCustomSearchOutput : msMetadataContainer {
public new const string CLASS_NAME = "CustomSearchOutput";
public new  static class FIELDS {
public const string Transform = "Transform";
public const string FileName = "FileName";
}
public msCustomSearchOutput() : base() {
ClassType = "CustomSearchOutput";
}
public msCustomSearchOutput( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomSearchOutput FromClassMetadata(ClassMetadata meta){return new msCustomSearchOutput(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Transform {
get { return SafeGetValue<System.String>("Transform");}
set { this["Transform"] = value;}
}

public System.String FileName {
get { return SafeGetValue<System.String>("FileName");}
set { this["FileName"] = value;}
}

}
[Serializable]
public class msPortalPageLayoutContainer : msMetadataContainer {
public new const string CLASS_NAME = "PortalPageLayoutContainer";
public new  static class FIELDS {
public const string Metadata = "Metadata";
}
public msPortalPageLayoutContainer() : base() {
ClassType = "PortalPageLayoutContainer";
}
public msPortalPageLayoutContainer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPortalPageLayoutContainer FromClassMetadata(ClassMetadata meta){return new msPortalPageLayoutContainer(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Manifests.Command.Views.DataEntryViewMetadata Metadata {
get { return SafeGetValue<MemberSuite.SDK.Manifests.Command.Views.DataEntryViewMetadata>("Metadata");}
set { this["Metadata"] = value;}
}

}
[Serializable]
public class msUserPreferencesContainer : msAssociationDomainObject {
public new const string CLASS_NAME = "UserPreferencesContainer";
public new  static class FIELDS {
public const string User = "User";
public const string RecentItems = "RecentItems";
public const string Favorites = "Favorites";
public const string Preferences = "Preferences";
}
public msUserPreferencesContainer() : base() {
ClassType = "UserPreferencesContainer";
RecentItems = new System.Collections.Generic.List<MemberSuite.SDK.Types.CommandShortcut>();
Favorites = new System.Collections.Generic.List<MemberSuite.SDK.Types.CommandShortcut>();
Preferences = new System.Collections.Generic.List<MemberSuite.SDK.Types.NameValueStringPair>();
}
public msUserPreferencesContainer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msUserPreferencesContainer FromClassMetadata(ClassMetadata meta){return new msUserPreferencesContainer(MemberSuiteObject.FromClassMetadata(meta));}
public System.String User {
get { return SafeGetValue<System.String>("User");}
set { this["User"] = value;}
}

public System.Collections.Generic.List<MemberSuite.SDK.Types.CommandShortcut> RecentItems {
get { return SafeGetValue<System.Collections.Generic.List<MemberSuite.SDK.Types.CommandShortcut>>("RecentItems");}
set { this["RecentItems"] = value;}
}

public System.Collections.Generic.List<MemberSuite.SDK.Types.CommandShortcut> Favorites {
get { return SafeGetValue<System.Collections.Generic.List<MemberSuite.SDK.Types.CommandShortcut>>("Favorites");}
set { this["Favorites"] = value;}
}

public System.Collections.Generic.List<MemberSuite.SDK.Types.NameValueStringPair> Preferences {
get { return SafeGetValue<System.Collections.Generic.List<MemberSuite.SDK.Types.NameValueStringPair>>("Preferences");}
set { this["Preferences"] = value;}
}

}
[Serializable]
public class msGeneralDiscountCode : msDiscountCode {
public new const string CLASS_NAME = "GeneralDiscountCode";
public new  static class FIELDS {
}
public msGeneralDiscountCode() : base() {
ClassType = "GeneralDiscountCode";
ApplicableProducts = new System.Collections.Generic.List<msDiscountCodeProduct>();
ApplicableProductTypes = new System.Collections.Generic.List<msDiscountCodeProductType>();
ApplicableProductCategories = new System.Collections.Generic.List<msDiscountCodeProductCategory>();
EligibleCustomers = new System.Collections.Generic.List<msDiscountCodeCustomer>();
}
public msGeneralDiscountCode( MemberSuiteObject msObj) : base(msObj) {}
 public static new msGeneralDiscountCode FromClassMetadata(ClassMetadata meta){return new msGeneralDiscountCode(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msInventoryTransaction : msAssociationDomainObject {
public new const string CLASS_NAME = "InventoryTransaction";
public new  static class FIELDS {
public const string Date = "Date";
public const string Product = "Product";
public const string Warehouse = "Warehouse";
public const string Quantity = "Quantity";
public const string InvoiceNumber = "InvoiceNumber";
public const string Notes = "Notes";
}
public msInventoryTransaction() : base() {
ClassType = "InventoryTransaction";
}
public msInventoryTransaction( MemberSuiteObject msObj) : base(msObj) {}
public System.DateTime Date {
get { return SafeGetValue<System.DateTime>("Date");}
set { this["Date"] = value;}
}

public System.String Product {
get { return SafeGetValue<System.String>("Product");}
set { this["Product"] = value;}
}

public System.String Warehouse {
get { return SafeGetValue<System.String>("Warehouse");}
set { this["Warehouse"] = value;}
}

public System.Decimal Quantity {
get { return SafeGetValue<System.Decimal>("Quantity");}
set { this["Quantity"] = value;}
}

public System.String InvoiceNumber {
get { return SafeGetValue<System.String>("InvoiceNumber");}
set { this["InvoiceNumber"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msInventoryAdjustment : msInventoryTransaction {
public new const string CLASS_NAME = "InventoryAdjustment";
public new  static class FIELDS {
}
public msInventoryAdjustment() : base() {
ClassType = "InventoryAdjustment";
}
public msInventoryAdjustment( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInventoryAdjustment FromClassMetadata(ClassMetadata meta){return new msInventoryAdjustment(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msOrderRelatedInventoryTransaction : msInventoryTransaction {
public new const string CLASS_NAME = "OrderRelatedInventoryTransaction";
public new  static class FIELDS {
public const string Order = "Order";
public const string OrderLineItemID = "OrderLineItemID";
}
public msOrderRelatedInventoryTransaction() : base() {
ClassType = "OrderRelatedInventoryTransaction";
}
public msOrderRelatedInventoryTransaction( MemberSuiteObject msObj) : base(msObj) {}
public System.String Order {
get { return SafeGetValue<System.String>("Order");}
set { this["Order"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

}
[Serializable]
public class msInventoryBackorder : msOrderRelatedInventoryTransaction {
public new const string CLASS_NAME = "InventoryBackorder";
public new  static class FIELDS {
}
public msInventoryBackorder() : base() {
ClassType = "InventoryBackorder";
}
public msInventoryBackorder( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInventoryBackorder FromClassMetadata(ClassMetadata meta){return new msInventoryBackorder(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msInventoryCommittment : msOrderRelatedInventoryTransaction {
public new const string CLASS_NAME = "InventoryCommittment";
public new  static class FIELDS {
}
public msInventoryCommittment() : base() {
ClassType = "InventoryCommittment";
}
public msInventoryCommittment( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInventoryCommittment FromClassMetadata(ClassMetadata meta){return new msInventoryCommittment(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msInventoryFulfillment : msOrderRelatedInventoryTransaction {
public new const string CLASS_NAME = "InventoryFulfillment";
public new  static class FIELDS {
}
public msInventoryFulfillment() : base() {
ClassType = "InventoryFulfillment";
}
public msInventoryFulfillment( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInventoryFulfillment FromClassMetadata(ClassMetadata meta){return new msInventoryFulfillment(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msInventoryReceipt : msInventoryTransaction {
public new const string CLASS_NAME = "InventoryReceipt";
public new  static class FIELDS {
public const string StartingQuantity = "StartingQuantity";
public const string EndingQuantity = "EndingQuantity";
public const string COGSQuantityRemaining = "COGSQuantityRemaining";
public const string UnitCost = "UnitCost";
}
public msInventoryReceipt() : base() {
ClassType = "InventoryReceipt";
}
public msInventoryReceipt( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInventoryReceipt FromClassMetadata(ClassMetadata meta){return new msInventoryReceipt(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int32? StartingQuantity {
get { return SafeGetValue<System.Int32?>("StartingQuantity");}
set { this["StartingQuantity"] = value;}
}

public System.Int32? EndingQuantity {
get { return SafeGetValue<System.Int32?>("EndingQuantity");}
set { this["EndingQuantity"] = value;}
}

public System.Int32? COGSQuantityRemaining {
get { return SafeGetValue<System.Int32?>("COGSQuantityRemaining");}
set { this["COGSQuantityRemaining"] = value;}
}

public System.Decimal UnitCost {
get { return SafeGetValue<System.Decimal>("UnitCost");}
set { this["UnitCost"] = value;}
}

}
[Serializable]
public class msInventoryReservation : msInventoryTransaction {
public new const string CLASS_NAME = "InventoryReservation";
public new  static class FIELDS {
}
public msInventoryReservation() : base() {
ClassType = "InventoryReservation";
}
public msInventoryReservation( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInventoryReservation FromClassMetadata(ClassMetadata meta){return new msInventoryReservation(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msInventoryTransfer : msInventoryTransaction {
public new const string CLASS_NAME = "InventoryTransfer";
public new  static class FIELDS {
public const string TargetWarehouse = "TargetWarehouse";
}
public msInventoryTransfer() : base() {
ClassType = "InventoryTransfer";
}
public msInventoryTransfer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msInventoryTransfer FromClassMetadata(ClassMetadata meta){return new msInventoryTransfer(MemberSuiteObject.FromClassMetadata(meta));}
public System.String TargetWarehouse {
get { return SafeGetValue<System.String>("TargetWarehouse");}
set { this["TargetWarehouse"] = value;}
}

}
[Serializable]
public class msOrder : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "Order";
public new  static class FIELDS {
public const string AmountDueNow = "AmountDueNow";
public const string HasGeneratedCEUCredits = "HasGeneratedCEUCredits";
public const string Batch = "Batch";
public const string TrackingNumber = "TrackingNumber";
public const string ShipDate = "ShipDate";
public const string CustomerNotes = "CustomerNotes";
public const string Date = "Date";
public const string SourceCode = "SourceCode";
public const string MediaCode = "MediaCode";
public const string ShipTo = "ShipTo";
public const string BillTo = "BillTo";
public const string PaymentMethod = "PaymentMethod";
public const string SavedPaymentMethod = "SavedPaymentMethod";
public const string PaymentReferenceNumber = "PaymentReferenceNumber";
public const string MerchantAccount = "MerchantAccount";
public const string CreditCardNumber = "CreditCardNumber";
public const string ACHAccountNumber = "ACHAccountNumber";
public const string ACHRoutingNumber = "ACHRoutingNumber";
public const string BillingTemplate = "BillingTemplate";
public const string CreditCardExpirationDate = "CreditCardExpirationDate";
public const string CreditCardAuthorizationID = "CreditCardAuthorizationID";
public const string CreditCardType = "CreditCardType";
public const string ProcessOrderEvenIfPaymentFails = "ProcessOrderEvenIfPaymentFails";
public const string CCVCode = "CCVCode";
public const string IgnoreMissingDemographics = "IgnoreMissingDemographics";
public const string ShippingAddress = "ShippingAddress";
public const string BillingAddress = "BillingAddress";
public const string BillingEmailAddress = "BillingEmailAddress";
public const string DiscountCodes = "DiscountCodes";
public const string Status = "Status";
public const string Discount = "Discount";
public const string Total = "Total";
public const string Notes = "Notes";
public const string InvoiceType = "InvoiceType";
public const string IsCreditCardEncrypted = "IsCreditCardEncrypted";
public const string ShippingOverride = "ShippingOverride";
public const string TaxOverride = "TaxOverride";
public const string BillingRunActivityID = "BillingRunActivityID";
public const string UseProFormaInvoices = "UseProFormaInvoices";
public const string InvoiceTerms = "InvoiceTerms";
public const string Memo = "Memo";
public const string LineItems = "LineItems";
public const string PurchaseOrderNumber = "PurchaseOrderNumber";
public const string ShippingMethod = "ShippingMethod";
public const string MembershipRenewalBatch = "MembershipRenewalBatch";
public const string WorkflowTrackingID = "WorkflowTrackingID";
public const string SavePaymentMethod = "SavePaymentMethod";
}
public msOrder() : base() {
ClassType = "Order";
DiscountCodes = new System.Collections.Generic.List<msOrderDiscountCode>();
LineItems = new System.Collections.Generic.List<msOrderLineItem>();
}
public msOrder( MemberSuiteObject msObj) : base(msObj) {}
 public static new msOrder FromClassMetadata(ClassMetadata meta){return new msOrder(MemberSuiteObject.FromClassMetadata(meta));}
public System.Decimal? AmountDueNow {
get { return SafeGetValue<System.Decimal?>("AmountDueNow");}
set { this["AmountDueNow"] = value;}
}

public System.Boolean HasGeneratedCEUCredits {
get { return SafeGetValue<System.Boolean>("HasGeneratedCEUCredits");}
set { this["HasGeneratedCEUCredits"] = value;}
}

public System.String Batch {
get { return SafeGetValue<System.String>("Batch");}
set { this["Batch"] = value;}
}

public System.String TrackingNumber {
get { return SafeGetValue<System.String>("TrackingNumber");}
set { this["TrackingNumber"] = value;}
}

public System.DateTime? ShipDate {
get { return SafeGetValue<System.DateTime?>("ShipDate");}
set { this["ShipDate"] = value;}
}

public System.String CustomerNotes {
get { return SafeGetValue<System.String>("CustomerNotes");}
set { this["CustomerNotes"] = value;}
}

public System.DateTime Date {
get { return SafeGetValue<System.DateTime>("Date");}
set { this["Date"] = value;}
}

public System.String SourceCode {
get { return SafeGetValue<System.String>("SourceCode");}
set { this["SourceCode"] = value;}
}

public System.String MediaCode {
get { return SafeGetValue<System.String>("MediaCode");}
set { this["MediaCode"] = value;}
}

public System.String ShipTo {
get { return SafeGetValue<System.String>("ShipTo");}
set { this["ShipTo"] = value;}
}

public System.String BillTo {
get { return SafeGetValue<System.String>("BillTo");}
set { this["BillTo"] = value;}
}

public MemberSuite.SDK.Types.OrderPaymentMethod PaymentMethod {
get { return SafeGetValue<MemberSuite.SDK.Types.OrderPaymentMethod>("PaymentMethod");}
set { this["PaymentMethod"] = value;}
}

public System.String SavedPaymentMethod {
get { return SafeGetValue<System.String>("SavedPaymentMethod");}
set { this["SavedPaymentMethod"] = value;}
}

public System.String PaymentReferenceNumber {
get { return SafeGetValue<System.String>("PaymentReferenceNumber");}
set { this["PaymentReferenceNumber"] = value;}
}

public System.String MerchantAccount {
get { return SafeGetValue<System.String>("MerchantAccount");}
set { this["MerchantAccount"] = value;}
}

public System.String CreditCardNumber {
get { return SafeGetValue<System.String>("CreditCardNumber");}
set { this["CreditCardNumber"] = value;}
}

public System.String ACHAccountNumber {
get { return SafeGetValue<System.String>("ACHAccountNumber");}
set { this["ACHAccountNumber"] = value;}
}

public System.String ACHRoutingNumber {
get { return SafeGetValue<System.String>("ACHRoutingNumber");}
set { this["ACHRoutingNumber"] = value;}
}

public System.String BillingTemplate {
get { return SafeGetValue<System.String>("BillingTemplate");}
set { this["BillingTemplate"] = value;}
}

public System.DateTime? CreditCardExpirationDate {
get { return SafeGetValue<System.DateTime?>("CreditCardExpirationDate");}
set { this["CreditCardExpirationDate"] = value;}
}

public System.String CreditCardAuthorizationID {
get { return SafeGetValue<System.String>("CreditCardAuthorizationID");}
set { this["CreditCardAuthorizationID"] = value;}
}

public MemberSuite.SDK.Types.CreditCardType CreditCardType {
get { return SafeGetValue<MemberSuite.SDK.Types.CreditCardType>("CreditCardType");}
set { this["CreditCardType"] = value;}
}

public System.Boolean ProcessOrderEvenIfPaymentFails {
get { return SafeGetValue<System.Boolean>("ProcessOrderEvenIfPaymentFails");}
set { this["ProcessOrderEvenIfPaymentFails"] = value;}
}

public System.String CCVCode {
get { return SafeGetValue<System.String>("CCVCode");}
set { this["CCVCode"] = value;}
}

public System.Boolean IgnoreMissingDemographics {
get { return SafeGetValue<System.Boolean>("IgnoreMissingDemographics");}
set { this["IgnoreMissingDemographics"] = value;}
}

public MemberSuite.SDK.Types.Address ShippingAddress {
get { return SafeGetValue<MemberSuite.SDK.Types.Address>("ShippingAddress");}
set { this["ShippingAddress"] = value;}
}

public MemberSuite.SDK.Types.Address BillingAddress {
get { return SafeGetValue<MemberSuite.SDK.Types.Address>("BillingAddress");}
set { this["BillingAddress"] = value;}
}

public System.String BillingEmailAddress {
get { return SafeGetValue<System.String>("BillingEmailAddress");}
set { this["BillingEmailAddress"] = value;}
}

public System.Collections.Generic.List<msOrderDiscountCode> DiscountCodes {
get { return SafeGetValue<System.Collections.Generic.List<msOrderDiscountCode>>("DiscountCodes");}
set { this["DiscountCodes"] = value;}
}

public MemberSuite.SDK.Types.OrderStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.OrderStatus>("Status");}
set { this["Status"] = value;}
}

public System.Decimal Discount {
get { return SafeGetValue<System.Decimal>("Discount");}
set { this["Discount"] = value;}
}

public System.Decimal Total {
get { return SafeGetValue<System.Decimal>("Total");}
set { this["Total"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.String InvoiceType {
get { return SafeGetValue<System.String>("InvoiceType");}
set { this["InvoiceType"] = value;}
}

public System.Boolean IsCreditCardEncrypted {
get { return SafeGetValue<System.Boolean>("IsCreditCardEncrypted");}
set { this["IsCreditCardEncrypted"] = value;}
}

public System.Boolean ShippingOverride {
get { return SafeGetValue<System.Boolean>("ShippingOverride");}
set { this["ShippingOverride"] = value;}
}

public System.Boolean TaxOverride {
get { return SafeGetValue<System.Boolean>("TaxOverride");}
set { this["TaxOverride"] = value;}
}

public System.String BillingRunActivityID {
get { return SafeGetValue<System.String>("BillingRunActivityID");}
set { this["BillingRunActivityID"] = value;}
}

public System.Boolean UseProFormaInvoices {
get { return SafeGetValue<System.Boolean>("UseProFormaInvoices");}
set { this["UseProFormaInvoices"] = value;}
}

public System.String InvoiceTerms {
get { return SafeGetValue<System.String>("InvoiceTerms");}
set { this["InvoiceTerms"] = value;}
}

public System.String Memo {
get { return SafeGetValue<System.String>("Memo");}
set { this["Memo"] = value;}
}

public System.Collections.Generic.List<msOrderLineItem> LineItems {
get { return SafeGetValue<System.Collections.Generic.List<msOrderLineItem>>("LineItems");}
set { this["LineItems"] = value;}
}

public System.String PurchaseOrderNumber {
get { return SafeGetValue<System.String>("PurchaseOrderNumber");}
set { this["PurchaseOrderNumber"] = value;}
}

public System.String ShippingMethod {
get { return SafeGetValue<System.String>("ShippingMethod");}
set { this["ShippingMethod"] = value;}
}

public System.String MembershipRenewalBatch {
get { return SafeGetValue<System.String>("MembershipRenewalBatch");}
set { this["MembershipRenewalBatch"] = value;}
}

public System.String WorkflowTrackingID {
get { return SafeGetValue<System.String>("WorkflowTrackingID");}
set { this["WorkflowTrackingID"] = value;}
}

public System.Boolean SavePaymentMethod {
get { return SafeGetValue<System.Boolean>("SavePaymentMethod");}
set { this["SavePaymentMethod"] = value;}
}

}
[Serializable]
public class msOrderDiscountCode : msAggregateChild {
public new const string CLASS_NAME = "OrderDiscountCode";
public new  static class FIELDS {
public const string DiscountCode = "DiscountCode";
public const string DiscountAmount = "DiscountAmount";
}
public msOrderDiscountCode() : base() {
ClassType = "OrderDiscountCode";
}
public msOrderDiscountCode( MemberSuiteObject msObj) : base(msObj) {}
 public static new msOrderDiscountCode FromClassMetadata(ClassMetadata meta){return new msOrderDiscountCode(MemberSuiteObject.FromClassMetadata(meta));}
public System.String DiscountCode {
get { return SafeGetValue<System.String>("DiscountCode");}
set { this["DiscountCode"] = value;}
}

public System.Decimal? DiscountAmount {
get { return SafeGetValue<System.Decimal?>("DiscountAmount");}
set { this["DiscountAmount"] = value;}
}

}
[Serializable]
public class msOrderLineItem : msSalesOrderLineItem {
public new const string CLASS_NAME = "OrderLineItem";
public new  static class FIELDS {
public const string QuantityShipped = "QuantityShipped";
public const string QuantityCancelled = "QuantityCancelled";
public const string QuantityReturned = "QuantityReturned";
public const string OverrideMemberPricingTo = "OverrideMemberPricingTo";
public const string Options = "Options";
public const string Type = "Type";
public const string PriceOverride = "PriceOverride";
public const string OverrideReason = "OverrideReason";
public const string OverrideShipTo = "OverrideShipTo";
public const string Status = "Status";
public const string BillingTemplate = "BillingTemplate";
public const string RevenueRecognitionTemplate = "RevenueRecognitionTemplate";
public const string FulfillmentDate = "FulfillmentDate";
public const string HasBeenExpanded = "HasBeenExpanded";
public const string OrderLineItemID = "OrderLineItemID";
public const string LinkedOrderLineItemID = "LinkedOrderLineItemID";
}
public msOrderLineItem() : base() {
ClassType = "OrderLineItem";
Options = new System.Collections.Generic.List<MemberSuite.SDK.Types.NameValueStringPair>();
}
public msOrderLineItem( MemberSuiteObject msObj) : base(msObj) {}
 public static new msOrderLineItem FromClassMetadata(ClassMetadata meta){return new msOrderLineItem(MemberSuiteObject.FromClassMetadata(meta));}
public System.Decimal QuantityShipped {
get { return SafeGetValue<System.Decimal>("QuantityShipped");}
set { this["QuantityShipped"] = value;}
}

public System.Decimal QuantityCancelled {
get { return SafeGetValue<System.Decimal>("QuantityCancelled");}
set { this["QuantityCancelled"] = value;}
}

public System.Decimal QuantityReturned {
get { return SafeGetValue<System.Decimal>("QuantityReturned");}
set { this["QuantityReturned"] = value;}
}

public System.String OverrideMemberPricingTo {
get { return SafeGetValue<System.String>("OverrideMemberPricingTo");}
set { this["OverrideMemberPricingTo"] = value;}
}

public System.Collections.Generic.List<MemberSuite.SDK.Types.NameValueStringPair> Options {
get { return SafeGetValue<System.Collections.Generic.List<MemberSuite.SDK.Types.NameValueStringPair>>("Options");}
set { this["Options"] = value;}
}

public MemberSuite.SDK.Types.OrderLineItemType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.OrderLineItemType>("Type");}
set { this["Type"] = value;}
}

public System.Boolean PriceOverride {
get { return SafeGetValue<System.Boolean>("PriceOverride");}
set { this["PriceOverride"] = value;}
}

public System.String OverrideReason {
get { return SafeGetValue<System.String>("OverrideReason");}
set { this["OverrideReason"] = value;}
}

public System.String OverrideShipTo {
get { return SafeGetValue<System.String>("OverrideShipTo");}
set { this["OverrideShipTo"] = value;}
}

public MemberSuite.SDK.Types.OrderStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.OrderStatus>("Status");}
set { this["Status"] = value;}
}

public System.String BillingTemplate {
get { return SafeGetValue<System.String>("BillingTemplate");}
set { this["BillingTemplate"] = value;}
}

public System.String RevenueRecognitionTemplate {
get { return SafeGetValue<System.String>("RevenueRecognitionTemplate");}
set { this["RevenueRecognitionTemplate"] = value;}
}

public System.DateTime? FulfillmentDate {
get { return SafeGetValue<System.DateTime?>("FulfillmentDate");}
set { this["FulfillmentDate"] = value;}
}

public System.Boolean HasBeenExpanded {
get { return SafeGetValue<System.Boolean>("HasBeenExpanded");}
set { this["HasBeenExpanded"] = value;}
}

public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.String LinkedOrderLineItemID {
get { return SafeGetValue<System.String>("LinkedOrderLineItemID");}
set { this["LinkedOrderLineItemID"] = value;}
}

}
[Serializable]
public class msProrationTable : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "ProrationTable";
public new  static class FIELDS {
public const string Description = "Description";
public const string Entries = "Entries";
}
public msProrationTable() : base() {
ClassType = "ProrationTable";
Entries = new System.Collections.Generic.List<msProrationTableEntry>();
}
public msProrationTable( MemberSuiteObject msObj) : base(msObj) {}
 public static new msProrationTable FromClassMetadata(ClassMetadata meta){return new msProrationTable(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Collections.Generic.List<msProrationTableEntry> Entries {
get { return SafeGetValue<System.Collections.Generic.List<msProrationTableEntry>>("Entries");}
set { this["Entries"] = value;}
}

}
[Serializable]
public class msProrationTableEntry : msAggregateChild {
public new const string CLASS_NAME = "ProrationTableEntry";
public new  static class FIELDS {
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string Proration = "Proration";
}
public msProrationTableEntry() : base() {
ClassType = "ProrationTableEntry";
}
public msProrationTableEntry( MemberSuiteObject msObj) : base(msObj) {}
 public static new msProrationTableEntry FromClassMetadata(ClassMetadata meta){return new msProrationTableEntry(MemberSuiteObject.FromClassMetadata(meta));}
public System.DateTime StartDate {
get { return SafeGetValue<System.DateTime>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime EndDate {
get { return SafeGetValue<System.DateTime>("EndDate");}
set { this["EndDate"] = value;}
}

public System.Decimal Proration {
get { return SafeGetValue<System.Decimal>("Proration");}
set { this["Proration"] = value;}
}

}
[Serializable]
public class msReturnReason : msConfigurableType {
public new const string CLASS_NAME = "ReturnReason";
public new  static class FIELDS {
}
public msReturnReason() : base() {
ClassType = "ReturnReason";
}
public msReturnReason( MemberSuiteObject msObj) : base(msObj) {}
 public static new msReturnReason FromClassMetadata(ClassMetadata meta){return new msReturnReason(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msShippingMethod : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "ShippingMethod";
public new  static class FIELDS {
public const string CalculationMethod = "CalculationMethod";
public const string ShippingCarrierAccount = "ShippingCarrierAccount";
public const string ShippingCarrierService = "ShippingCarrierService";
public const string IsDefault = "IsDefault";
public const string ShippingProduct = "ShippingProduct";
public const string Rates = "Rates";
}
public msShippingMethod() : base() {
ClassType = "ShippingMethod";
Rates = new System.Collections.Generic.List<msShippingMethodRate>();
}
public msShippingMethod( MemberSuiteObject msObj) : base(msObj) {}
 public static new msShippingMethod FromClassMetadata(ClassMetadata meta){return new msShippingMethod(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.ShippingCalculationMethod CalculationMethod {
get { return SafeGetValue<MemberSuite.SDK.Types.ShippingCalculationMethod>("CalculationMethod");}
set { this["CalculationMethod"] = value;}
}

public System.String ShippingCarrierAccount {
get { return SafeGetValue<System.String>("ShippingCarrierAccount");}
set { this["ShippingCarrierAccount"] = value;}
}

public System.Int32 ShippingCarrierService {
get { return SafeGetValue<System.Int32>("ShippingCarrierService");}
set { this["ShippingCarrierService"] = value;}
}

public System.Boolean IsDefault {
get { return SafeGetValue<System.Boolean>("IsDefault");}
set { this["IsDefault"] = value;}
}

public System.String ShippingProduct {
get { return SafeGetValue<System.String>("ShippingProduct");}
set { this["ShippingProduct"] = value;}
}

public System.Collections.Generic.List<msShippingMethodRate> Rates {
get { return SafeGetValue<System.Collections.Generic.List<msShippingMethodRate>>("Rates");}
set { this["Rates"] = value;}
}

}
[Serializable]
public class msShippingMethodRate : msAggregateChild {
public new const string CLASS_NAME = "ShippingMethodRate";
public new  static class FIELDS {
public const string ShippingZone = "ShippingZone";
public const string ValueStart = "ValueStart";
public const string ValueEnd = "ValueEnd";
public const string Cost = "Cost";
}
public msShippingMethodRate() : base() {
ClassType = "ShippingMethodRate";
}
public msShippingMethodRate( MemberSuiteObject msObj) : base(msObj) {}
 public static new msShippingMethodRate FromClassMetadata(ClassMetadata meta){return new msShippingMethodRate(MemberSuiteObject.FromClassMetadata(meta));}
public System.String ShippingZone {
get { return SafeGetValue<System.String>("ShippingZone");}
set { this["ShippingZone"] = value;}
}

public System.Decimal ValueStart {
get { return SafeGetValue<System.Decimal>("ValueStart");}
set { this["ValueStart"] = value;}
}

public System.Decimal ValueEnd {
get { return SafeGetValue<System.Decimal>("ValueEnd");}
set { this["ValueEnd"] = value;}
}

public System.Decimal Cost {
get { return SafeGetValue<System.Decimal>("Cost");}
set { this["Cost"] = value;}
}

}
[Serializable]
public class msShippingProduct : msProduct {
public new const string CLASS_NAME = "ShippingProduct";
public new  static class FIELDS {
}
public msShippingProduct() : base() {
ClassType = "ShippingProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msShippingProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msShippingProduct FromClassMetadata(ClassMetadata meta){return new msShippingProduct(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msShippingZone : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "ShippingZone";
public new  static class FIELDS {
public const string Description = "Description";
public const string PostalCodeStart = "PostalCodeStart";
public const string PostalCodeEnd = "PostalCodeEnd";
}
public msShippingZone() : base() {
ClassType = "ShippingZone";
}
public msShippingZone( MemberSuiteObject msObj) : base(msObj) {}
 public static new msShippingZone FromClassMetadata(ClassMetadata meta){return new msShippingZone(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String PostalCodeStart {
get { return SafeGetValue<System.String>("PostalCodeStart");}
set { this["PostalCodeStart"] = value;}
}

public System.String PostalCodeEnd {
get { return SafeGetValue<System.String>("PostalCodeEnd");}
set { this["PostalCodeEnd"] = value;}
}

}
[Serializable]
public class msStockItemInventory : msAssociationDomainObject {
public new const string CLASS_NAME = "StockItemInventory";
public new  static class FIELDS {
public const string Warehouse = "Warehouse";
public const string Product = "Product";
public const string QuantityOnHand = "QuantityOnHand";
public const string QuantityReserved = "QuantityReserved";
public const string QuantityAvailable = "QuantityAvailable";
public const string QuantityOnOrder = "QuantityOnOrder";
public const string ExpectedArrivalDate = "ExpectedArrivalDate";
public const string QuantityCommitted = "QuantityCommitted";
public const string QuantityBackordered = "QuantityBackordered";
public const string MinimumQuantityOnHand = "MinimumQuantityOnHand";
public const string ReorderPoint = "ReorderPoint";
public const string Notes = "Notes";
}
public msStockItemInventory() : base() {
ClassType = "StockItemInventory";
}
public msStockItemInventory( MemberSuiteObject msObj) : base(msObj) {}
 public static new msStockItemInventory FromClassMetadata(ClassMetadata meta){return new msStockItemInventory(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Warehouse {
get { return SafeGetValue<System.String>("Warehouse");}
set { this["Warehouse"] = value;}
}

public System.String Product {
get { return SafeGetValue<System.String>("Product");}
set { this["Product"] = value;}
}

public System.Decimal QuantityOnHand {
get { return SafeGetValue<System.Decimal>("QuantityOnHand");}
set { this["QuantityOnHand"] = value;}
}

public System.Decimal QuantityReserved {
get { return SafeGetValue<System.Decimal>("QuantityReserved");}
set { this["QuantityReserved"] = value;}
}

public System.Decimal QuantityAvailable {
get { return SafeGetValue<System.Decimal>("QuantityAvailable");}
set { this["QuantityAvailable"] = value;}
}

public System.Decimal QuantityOnOrder {
get { return SafeGetValue<System.Decimal>("QuantityOnOrder");}
set { this["QuantityOnOrder"] = value;}
}

public System.DateTime? ExpectedArrivalDate {
get { return SafeGetValue<System.DateTime?>("ExpectedArrivalDate");}
set { this["ExpectedArrivalDate"] = value;}
}

public System.Decimal QuantityCommitted {
get { return SafeGetValue<System.Decimal>("QuantityCommitted");}
set { this["QuantityCommitted"] = value;}
}

public System.Decimal QuantityBackordered {
get { return SafeGetValue<System.Decimal>("QuantityBackordered");}
set { this["QuantityBackordered"] = value;}
}

public System.Int32? MinimumQuantityOnHand {
get { return SafeGetValue<System.Int32?>("MinimumQuantityOnHand");}
set { this["MinimumQuantityOnHand"] = value;}
}

public System.Decimal? ReorderPoint {
get { return SafeGetValue<System.Decimal?>("ReorderPoint");}
set { this["ReorderPoint"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msTaxProduct : msProduct {
public new const string CLASS_NAME = "TaxProduct";
public new  static class FIELDS {
}
public msTaxProduct() : base() {
ClassType = "TaxProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msTaxProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msTaxProduct FromClassMetadata(ClassMetadata meta){return new msTaxProduct(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msTaxTable : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "TaxTable";
public new  static class FIELDS {
public const string Description = "Description";
public const string Entries = "Entries";
public const string IsDefault = "IsDefault";
public const string DefaultTaxRate = "DefaultTaxRate";
public const string DefaultTaxProduct = "DefaultTaxProduct";
public const string TaxCalculationMode = "TaxCalculationMode";
}
public msTaxTable() : base() {
ClassType = "TaxTable";
Entries = new System.Collections.Generic.List<msTaxTableEntry>();
}
public msTaxTable( MemberSuiteObject msObj) : base(msObj) {}
 public static new msTaxTable FromClassMetadata(ClassMetadata meta){return new msTaxTable(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Collections.Generic.List<msTaxTableEntry> Entries {
get { return SafeGetValue<System.Collections.Generic.List<msTaxTableEntry>>("Entries");}
set { this["Entries"] = value;}
}

public System.Boolean IsDefault {
get { return SafeGetValue<System.Boolean>("IsDefault");}
set { this["IsDefault"] = value;}
}

public System.Decimal? DefaultTaxRate {
get { return SafeGetValue<System.Decimal?>("DefaultTaxRate");}
set { this["DefaultTaxRate"] = value;}
}

public System.String DefaultTaxProduct {
get { return SafeGetValue<System.String>("DefaultTaxProduct");}
set { this["DefaultTaxProduct"] = value;}
}

public MemberSuite.SDK.Types.TaxCalculationMode TaxCalculationMode {
get { return SafeGetValue<MemberSuite.SDK.Types.TaxCalculationMode>("TaxCalculationMode");}
set { this["TaxCalculationMode"] = value;}
}

}
[Serializable]
public class msTaxTableEntry : msAggregateChild {
public new const string CLASS_NAME = "TaxTableEntry";
public new  static class FIELDS {
public const string TaxRate = "TaxRate";
public const string TaxProduct = "TaxProduct";
public const string State = "State";
}
public msTaxTableEntry() : base() {
ClassType = "TaxTableEntry";
}
public msTaxTableEntry( MemberSuiteObject msObj) : base(msObj) {}
 public static new msTaxTableEntry FromClassMetadata(ClassMetadata meta){return new msTaxTableEntry(MemberSuiteObject.FromClassMetadata(meta));}
public System.Decimal TaxRate {
get { return SafeGetValue<System.Decimal>("TaxRate");}
set { this["TaxRate"] = value;}
}

public System.String TaxProduct {
get { return SafeGetValue<System.String>("TaxProduct");}
set { this["TaxProduct"] = value;}
}

public System.String State {
get { return SafeGetValue<System.String>("State");}
set { this["State"] = value;}
}

}
[Serializable]
public class msVendor : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "Vendor";
public new  static class FIELDS {
public const string EmailAddress = "EmailAddress";
}
public msVendor() : base() {
ClassType = "Vendor";
}
public msVendor( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVendor FromClassMetadata(ClassMetadata meta){return new msVendor(MemberSuiteObject.FromClassMetadata(meta));}
public System.String EmailAddress {
get { return SafeGetValue<System.String>("EmailAddress");}
set { this["EmailAddress"] = value;}
}

}
[Serializable]
public class msWarehouse : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "Warehouse";
public new  static class FIELDS {
public const string Description = "Description";
public const string IsDefault = "IsDefault";
public const string DefaultReorderPoint = "DefaultReorderPoint";
}
public msWarehouse() : base() {
ClassType = "Warehouse";
}
public msWarehouse( MemberSuiteObject msObj) : base(msObj) {}
 public static new msWarehouse FromClassMetadata(ClassMetadata meta){return new msWarehouse(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Boolean IsDefault {
get { return SafeGetValue<System.Boolean>("IsDefault");}
set { this["IsDefault"] = value;}
}

public System.Decimal? DefaultReorderPoint {
get { return SafeGetValue<System.Decimal?>("DefaultReorderPoint");}
set { this["DefaultReorderPoint"] = value;}
}

}
[Serializable]
public class msCampaignMemberStatus : msConfigurableType {
public new const string CLASS_NAME = "CampaignMemberStatus";
public new  static class FIELDS {
}
public msCampaignMemberStatus() : base() {
ClassType = "CampaignMemberStatus";
}
public msCampaignMemberStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCampaignMemberStatus FromClassMetadata(ClassMetadata meta){return new msCampaignMemberStatus(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msLead : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Lead";
public new  static class FIELDS {
public const string Owner = "Owner";
public const string FirstName = "FirstName";
public const string LastName = "LastName";
public const string Organization = "Organization";
public const string Title = "Title";
public const string Phone = "Phone";
public const string Status = "Status";
public const string Type = "Type";
public const string Email = "Email";
public const string AnnualRevenue = "AnnualRevenue";
public const string Address = "Address";
public const string Description = "Description";
public const string DateConverted = "DateConverted";
public const string Opportunity = "Opportunity";
public const string Account = "Account";
public const string Contact = "Contact";
public const string Campaigns = "Campaigns";
}
public msLead() : base() {
ClassType = "Lead";
Campaigns = new System.Collections.Generic.List<msLeadCampaignMembership>();
}
public msLead( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLead FromClassMetadata(ClassMetadata meta){return new msLead(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String FirstName {
get { return SafeGetValue<System.String>("FirstName");}
set { this["FirstName"] = value;}
}

public System.String LastName {
get { return SafeGetValue<System.String>("LastName");}
set { this["LastName"] = value;}
}

public System.String Organization {
get { return SafeGetValue<System.String>("Organization");}
set { this["Organization"] = value;}
}

public System.String Title {
get { return SafeGetValue<System.String>("Title");}
set { this["Title"] = value;}
}

public System.String Phone {
get { return SafeGetValue<System.String>("Phone");}
set { this["Phone"] = value;}
}

public System.String Status {
get { return SafeGetValue<System.String>("Status");}
set { this["Status"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Email {
get { return SafeGetValue<System.String>("Email");}
set { this["Email"] = value;}
}

public System.Decimal AnnualRevenue {
get { return SafeGetValue<System.Decimal>("AnnualRevenue");}
set { this["AnnualRevenue"] = value;}
}

public MemberSuite.SDK.Types.Address Address {
get { return SafeGetValue<MemberSuite.SDK.Types.Address>("Address");}
set { this["Address"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.DateTime? DateConverted {
get { return SafeGetValue<System.DateTime?>("DateConverted");}
set { this["DateConverted"] = value;}
}

public System.String Opportunity {
get { return SafeGetValue<System.String>("Opportunity");}
set { this["Opportunity"] = value;}
}

public System.String Account {
get { return SafeGetValue<System.String>("Account");}
set { this["Account"] = value;}
}

public System.String Contact {
get { return SafeGetValue<System.String>("Contact");}
set { this["Contact"] = value;}
}

public System.Collections.Generic.List<msLeadCampaignMembership> Campaigns {
get { return SafeGetValue<System.Collections.Generic.List<msLeadCampaignMembership>>("Campaigns");}
set { this["Campaigns"] = value;}
}

}
[Serializable]
public class msLeadCampaignMembership : msAggregateChild {
public new const string CLASS_NAME = "LeadCampaignMembership";
public new  static class FIELDS {
public const string Campaign = "Campaign";
public const string Status = "Status";
}
public msLeadCampaignMembership() : base() {
ClassType = "LeadCampaignMembership";
}
public msLeadCampaignMembership( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLeadCampaignMembership FromClassMetadata(ClassMetadata meta){return new msLeadCampaignMembership(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Campaign {
get { return SafeGetValue<System.String>("Campaign");}
set { this["Campaign"] = value;}
}

public System.String Status {
get { return SafeGetValue<System.String>("Status");}
set { this["Status"] = value;}
}

}
[Serializable]
public class msLeadStatus : msConfigurableType {
public new const string CLASS_NAME = "LeadStatus";
public new  static class FIELDS {
}
public msLeadStatus() : base() {
ClassType = "LeadStatus";
}
public msLeadStatus( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLeadStatus FromClassMetadata(ClassMetadata meta){return new msLeadStatus(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msLeadType : msPageLayoutConfigurableType {
public new const string CLASS_NAME = "LeadType";
public new  static class FIELDS {
}
public msLeadType() : base() {
ClassType = "LeadType";
}
public msLeadType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLeadType FromClassMetadata(ClassMetadata meta){return new msLeadType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msOpportunity : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Opportunity";
public new  static class FIELDS {
public const string Owner = "Owner";
public const string Account = "Account";
public const string Amount = "Amount";
public const string CloseDate = "CloseDate";
public const string Type = "Type";
public const string Stage = "Stage";
public const string Probability = "Probability";
public const string Campaign = "Campaign";
public const string NextStep = "NextStep";
public const string Description = "Description";
}
public msOpportunity() : base() {
ClassType = "Opportunity";
}
public msOpportunity( MemberSuiteObject msObj) : base(msObj) {}
 public static new msOpportunity FromClassMetadata(ClassMetadata meta){return new msOpportunity(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String Account {
get { return SafeGetValue<System.String>("Account");}
set { this["Account"] = value;}
}

public System.Decimal Amount {
get { return SafeGetValue<System.Decimal>("Amount");}
set { this["Amount"] = value;}
}

public System.DateTime? CloseDate {
get { return SafeGetValue<System.DateTime?>("CloseDate");}
set { this["CloseDate"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String Stage {
get { return SafeGetValue<System.String>("Stage");}
set { this["Stage"] = value;}
}

public System.Int32 Probability {
get { return SafeGetValue<System.Int32>("Probability");}
set { this["Probability"] = value;}
}

public System.String Campaign {
get { return SafeGetValue<System.String>("Campaign");}
set { this["Campaign"] = value;}
}

public System.String NextStep {
get { return SafeGetValue<System.String>("NextStep");}
set { this["NextStep"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msOpportunityStage : msConfigurableType {
public new const string CLASS_NAME = "OpportunityStage";
public new  static class FIELDS {
public const string Type = "Type";
public const string Probability = "Probability";
}
public msOpportunityStage() : base() {
ClassType = "OpportunityStage";
}
public msOpportunityStage( MemberSuiteObject msObj) : base(msObj) {}
 public static new msOpportunityStage FromClassMetadata(ClassMetadata meta){return new msOpportunityStage(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.OpportunityStageType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.OpportunityStageType>("Type");}
set { this["Type"] = value;}
}

public System.Int16? Probability {
get { return SafeGetValue<System.Int16?>("Probability");}
set { this["Probability"] = value;}
}

}
[Serializable]
public class msOpportunityType : msPageLayoutConfigurableType {
public new const string CLASS_NAME = "OpportunityType";
public new  static class FIELDS {
}
public msOpportunityType() : base() {
ClassType = "OpportunityType";
}
public msOpportunityType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msOpportunityType FromClassMetadata(ClassMetadata meta){return new msOpportunityType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msConciergeAccessCredential : msSystemDomainObject {
public new const string CLASS_NAME = "ConciergeAccessCredential";
public new  static class FIELDS {
public const string User = "User";
public const string Disabled = "Disabled";
public const string Notes = "Notes";
}
public msConciergeAccessCredential() : base() {
ClassType = "ConciergeAccessCredential";
}
public msConciergeAccessCredential( MemberSuiteObject msObj) : base(msObj) {}
public System.String User {
get { return SafeGetValue<System.String>("User");}
set { this["User"] = value;}
}

public System.Boolean Disabled {
get { return SafeGetValue<System.Boolean>("Disabled");}
set { this["Disabled"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

}
[Serializable]
public class msCertificateAccessCredential : msConciergeAccessCredential {
public new const string CLASS_NAME = "CertificateAccessCredential";
public new  static class FIELDS {
public const string PublicKey = "PublicKey";
}
public msCertificateAccessCredential() : base() {
ClassType = "CertificateAccessCredential";
}
public msCertificateAccessCredential( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertificateAccessCredential FromClassMetadata(ClassMetadata meta){return new msCertificateAccessCredential(MemberSuiteObject.FromClassMetadata(meta));}
public System.String PublicKey {
get { return SafeGetValue<System.String>("PublicKey");}
set { this["PublicKey"] = value;}
}

}
[Serializable]
public class msSecretKeyAccessCredential : msConciergeAccessCredential {
public new const string CLASS_NAME = "SecretKeyAccessCredential";
public new  static class FIELDS {
public const string SecretKey = "SecretKey";
}
public msSecretKeyAccessCredential() : base() {
ClassType = "SecretKeyAccessCredential";
}
public msSecretKeyAccessCredential( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSecretKeyAccessCredential FromClassMetadata(ClassMetadata meta){return new msSecretKeyAccessCredential(MemberSuiteObject.FromClassMetadata(meta));}
public System.String SecretKey {
get { return SafeGetValue<System.String>("SecretKey");}
set { this["SecretKey"] = value;}
}

}
[Serializable]
public class msPortalUser : msUser {
public new const string CLASS_NAME = "PortalUser";
public new  static class FIELDS {
public const string Owner = "Owner";
public const string LastLoggedInAs = "LastLoggedInAs";
public const string SecurityLock = "SecurityLock";
}
public msPortalUser() : base() {
ClassType = "PortalUser";
}
public msPortalUser( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPortalUser FromClassMetadata(ClassMetadata meta){return new msPortalUser(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String LastLoggedInAs {
get { return SafeGetValue<System.String>("LastLoggedInAs");}
set { this["LastLoggedInAs"] = value;}
}

public MemberSuite.SDK.Types.SecurityLock SecurityLock {
get { return SafeGetValue<MemberSuite.SDK.Types.SecurityLock>("SecurityLock");}
set { this["SecurityLock"] = value;}
}

}
[Serializable]
public class msUserGroup : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "UserGroup";
public new  static class FIELDS {
public const string Description = "Description";
public const string Members = "Members";
}
public msUserGroup() : base() {
ClassType = "UserGroup";
Members = new System.Collections.Generic.List<System.String>();
}
public msUserGroup( MemberSuiteObject msObj) : base(msObj) {}
 public static new msUserGroup FromClassMetadata(ClassMetadata meta){return new msUserGroup(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Collections.Generic.List<System.String> Members {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Members");}
set { this["Members"] = value;}
}

}
[Serializable]
public class msConfigurationSetting : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "ConfigurationSetting";
public new  static class FIELDS {
public const string Namespace = "Namespace";
public const string Description = "Description";
public const string Value = "Value";
}
public msConfigurationSetting() : base() {
ClassType = "ConfigurationSetting";
}
public msConfigurationSetting( MemberSuiteObject msObj) : base(msObj) {}
public System.String Namespace {
get { return SafeGetValue<System.String>("Namespace");}
set { this["Namespace"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String Value {
get { return SafeGetValue<System.String>("Value");}
set { this["Value"] = value;}
}

}
[Serializable]
public class msGeneralConfigurationSetting : msConfigurationSetting {
public new const string CLASS_NAME = "GeneralConfigurationSetting";
public new  static class FIELDS {
}
public msGeneralConfigurationSetting() : base() {
ClassType = "GeneralConfigurationSetting";
}
public msGeneralConfigurationSetting( MemberSuiteObject msObj) : base(msObj) {}
 public static new msGeneralConfigurationSetting FromClassMetadata(ClassMetadata meta){return new msGeneralConfigurationSetting(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msProductConfigurationSetting : msConfigurationSetting {
public new const string CLASS_NAME = "ProductConfigurationSetting";
public new  static class FIELDS {
public const string Product = "Product";
}
public msProductConfigurationSetting() : base() {
ClassType = "ProductConfigurationSetting";
}
public msProductConfigurationSetting( MemberSuiteObject msObj) : base(msObj) {}
 public static new msProductConfigurationSetting FromClassMetadata(ClassMetadata meta){return new msProductConfigurationSetting(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Product {
get { return SafeGetValue<System.String>("Product");}
set { this["Product"] = value;}
}

}
[Serializable]
public class msCustomFieldConfigurationSetting : msConfigurationSetting {
public new const string CLASS_NAME = "CustomFieldConfigurationSetting";
public new  static class FIELDS {
public const string CustomField = "CustomField";
}
public msCustomFieldConfigurationSetting() : base() {
ClassType = "CustomFieldConfigurationSetting";
}
public msCustomFieldConfigurationSetting( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomFieldConfigurationSetting FromClassMetadata(ClassMetadata meta){return new msCustomFieldConfigurationSetting(MemberSuiteObject.FromClassMetadata(meta));}
public System.String CustomField {
get { return SafeGetValue<System.String>("CustomField");}
set { this["CustomField"] = value;}
}

}
[Serializable]
public class msMetadataContainerConfigurationSetting : msConfigurationSetting {
public new const string CLASS_NAME = "MetadataContainerConfigurationSetting";
public new  static class FIELDS {
public const string MetadataContainer = "MetadataContainer";
}
public msMetadataContainerConfigurationSetting() : base() {
ClassType = "MetadataContainerConfigurationSetting";
}
public msMetadataContainerConfigurationSetting( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMetadataContainerConfigurationSetting FromClassMetadata(ClassMetadata meta){return new msMetadataContainerConfigurationSetting(MemberSuiteObject.FromClassMetadata(meta));}
public System.String MetadataContainer {
get { return SafeGetValue<System.String>("MetadataContainer");}
set { this["MetadataContainer"] = value;}
}

}
[Serializable]
public class msConfigurableTypeConfigurationSetting : msConfigurationSetting {
public new const string CLASS_NAME = "ConfigurableTypeConfigurationSetting";
public new  static class FIELDS {
public const string ConfigurableType = "ConfigurableType";
}
public msConfigurableTypeConfigurationSetting() : base() {
ClassType = "ConfigurableTypeConfigurationSetting";
}
public msConfigurableTypeConfigurationSetting( MemberSuiteObject msObj) : base(msObj) {}
 public static new msConfigurableTypeConfigurationSetting FromClassMetadata(ClassMetadata meta){return new msConfigurableTypeConfigurationSetting(MemberSuiteObject.FromClassMetadata(meta));}
public System.String ConfigurableType {
get { return SafeGetValue<System.String>("ConfigurableType");}
set { this["ConfigurableType"] = value;}
}

}
[Serializable]
public class msRelationshipTypeConfigurationSetting : msConfigurationSetting {
public new const string CLASS_NAME = "RelationshipTypeConfigurationSetting";
public new  static class FIELDS {
public const string RelationshipType = "RelationshipType";
}
public msRelationshipTypeConfigurationSetting() : base() {
ClassType = "RelationshipTypeConfigurationSetting";
}
public msRelationshipTypeConfigurationSetting( MemberSuiteObject msObj) : base(msObj) {}
 public static new msRelationshipTypeConfigurationSetting FromClassMetadata(ClassMetadata meta){return new msRelationshipTypeConfigurationSetting(MemberSuiteObject.FromClassMetadata(meta));}
public System.String RelationshipType {
get { return SafeGetValue<System.String>("RelationshipType");}
set { this["RelationshipType"] = value;}
}

}
[Serializable]
public class msEventConfigurationSetting : msConfigurationSetting {
public new const string CLASS_NAME = "EventConfigurationSetting";
public new  static class FIELDS {
public const string Event = "Event";
}
public msEventConfigurationSetting() : base() {
ClassType = "EventConfigurationSetting";
}
public msEventConfigurationSetting( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEventConfigurationSetting FromClassMetadata(ClassMetadata meta){return new msEventConfigurationSetting(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

}
[Serializable]
public class msCompetitionConfigurationSetting : msConfigurationSetting {
public new const string CLASS_NAME = "CompetitionConfigurationSetting";
public new  static class FIELDS {
public const string Competition = "Competition";
}
public msCompetitionConfigurationSetting() : base() {
ClassType = "CompetitionConfigurationSetting";
}
public msCompetitionConfigurationSetting( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCompetitionConfigurationSetting FromClassMetadata(ClassMetadata meta){return new msCompetitionConfigurationSetting(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Competition {
get { return SafeGetValue<System.String>("Competition");}
set { this["Competition"] = value;}
}

}
[Serializable]
public class msCertificationProgramConfigurationSetting : msConfigurationSetting {
public new const string CLASS_NAME = "CertificationProgramConfigurationSetting";
public new  static class FIELDS {
public const string CertificationProgram = "CertificationProgram";
}
public msCertificationProgramConfigurationSetting() : base() {
ClassType = "CertificationProgramConfigurationSetting";
}
public msCertificationProgramConfigurationSetting( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCertificationProgramConfigurationSetting FromClassMetadata(ClassMetadata meta){return new msCertificationProgramConfigurationSetting(MemberSuiteObject.FromClassMetadata(meta));}
public System.String CertificationProgram {
get { return SafeGetValue<System.String>("CertificationProgram");}
set { this["CertificationProgram"] = value;}
}

}
[Serializable]
public class msPortalFormConfigurationSetting : msConfigurationSetting {
public new const string CLASS_NAME = "PortalFormConfigurationSetting";
public new  static class FIELDS {
public const string PortalForm = "PortalForm";
}
public msPortalFormConfigurationSetting() : base() {
ClassType = "PortalFormConfigurationSetting";
}
public msPortalFormConfigurationSetting( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPortalFormConfigurationSetting FromClassMetadata(ClassMetadata meta){return new msPortalFormConfigurationSetting(MemberSuiteObject.FromClassMetadata(meta));}
public System.String PortalForm {
get { return SafeGetValue<System.String>("PortalForm");}
set { this["PortalForm"] = value;}
}

}
[Serializable]
public class msMembershipStatusConfigurationSetting : msConfigurationSetting {
public new const string CLASS_NAME = "MembershipStatusConfigurationSetting";
public new  static class FIELDS {
public const string MembershipStatus = "MembershipStatus";
}
public msMembershipStatusConfigurationSetting() : base() {
ClassType = "MembershipStatusConfigurationSetting";
}
public msMembershipStatusConfigurationSetting( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMembershipStatusConfigurationSetting FromClassMetadata(ClassMetadata meta){return new msMembershipStatusConfigurationSetting(MemberSuiteObject.FromClassMetadata(meta));}
public System.String MembershipStatus {
get { return SafeGetValue<System.String>("MembershipStatus");}
set { this["MembershipStatus"] = value;}
}

}
[Serializable]
public class msCustomTrigger : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "CustomTrigger";
public new  static class FIELDS {
public const string Type = "Type";
public const string Expression = "Expression";
public const string Description = "Description";
public const string ApplicableType = "ApplicableType";
public const string ExtensionService = "ExtensionService";
}
public msCustomTrigger() : base() {
ClassType = "CustomTrigger";
}
public msCustomTrigger( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomTrigger FromClassMetadata(ClassMetadata meta){return new msCustomTrigger(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.TriggerType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.TriggerType>("Type");}
set { this["Type"] = value;}
}

public System.String Expression {
get { return SafeGetValue<System.String>("Expression");}
set { this["Expression"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String ApplicableType {
get { return SafeGetValue<System.String>("ApplicableType");}
set { this["ApplicableType"] = value;}
}

public System.String ExtensionService {
get { return SafeGetValue<System.String>("ExtensionService");}
set { this["ExtensionService"] = value;}
}

}
[Serializable]
public class msClassMetadataContainer : msMetadataContainer {
public new const string CLASS_NAME = "ClassMetadataContainer";
public new  static class FIELDS {
public const string Metadata = "Metadata";
}
public msClassMetadataContainer() : base() {
ClassType = "ClassMetadataContainer";
}
public msClassMetadataContainer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msClassMetadataContainer FromClassMetadata(ClassMetadata meta){return new msClassMetadataContainer(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.ClassMetadataOverride Metadata {
get { return SafeGetValue<MemberSuite.SDK.Types.ClassMetadataOverride>("Metadata");}
set { this["Metadata"] = value;}
}

}
[Serializable]
public class msCommandPreferencesContainer : msAssociationDomainObject {
public new const string CLASS_NAME = "CommandPreferencesContainer";
public new  static class FIELDS {
public const string User = "User";
public const string CommandPreferences = "CommandPreferences";
}
public msCommandPreferencesContainer() : base() {
ClassType = "CommandPreferencesContainer";
}
public msCommandPreferencesContainer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCommandPreferencesContainer FromClassMetadata(ClassMetadata meta){return new msCommandPreferencesContainer(MemberSuiteObject.FromClassMetadata(meta));}
public System.String User {
get { return SafeGetValue<System.String>("User");}
set { this["User"] = value;}
}

public MemberSuite.SDK.Types.CommandPreferences CommandPreferences {
get { return SafeGetValue<MemberSuite.SDK.Types.CommandPreferences>("CommandPreferences");}
set { this["CommandPreferences"] = value;}
}

}
[Serializable]
public class msCustomField : msAssociationDomainObject {
public new const string CLASS_NAME = "CustomField";
public new  static class FIELDS {
public const string ApplicableType = "ApplicableType";
public const string FieldDefinition = "FieldDefinition";
public const string Type = "Type";
public const string Event = "Event";
public const string Competition = "Competition";
public const string Product = "Product";
public const string DisplayOrder = "DisplayOrder";
public const string RestrictDisplayBasedOnFee = "RestrictDisplayBasedOnFee";
public const string ApplicableFees = "ApplicableFees";
public const string CopyFieldTo = "CopyFieldTo";
public const string CustomObject = "CustomObject";
}
public msCustomField() : base() {
ClassType = "CustomField";
ApplicableFees = new System.Collections.Generic.List<System.String>();
}
public msCustomField( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomField FromClassMetadata(ClassMetadata meta){return new msCustomField(MemberSuiteObject.FromClassMetadata(meta));}
public System.String ApplicableType {
get { return SafeGetValue<System.String>("ApplicableType");}
set { this["ApplicableType"] = value;}
}

public MemberSuite.SDK.Types.FieldMetadata FieldDefinition {
get { return SafeGetValue<MemberSuite.SDK.Types.FieldMetadata>("FieldDefinition");}
set { this["FieldDefinition"] = value;}
}

public MemberSuite.SDK.Types.CustomFieldType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.CustomFieldType>("Type");}
set { this["Type"] = value;}
}

public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String Competition {
get { return SafeGetValue<System.String>("Competition");}
set { this["Competition"] = value;}
}

public System.String Product {
get { return SafeGetValue<System.String>("Product");}
set { this["Product"] = value;}
}

public System.Int32 DisplayOrder {
get { return SafeGetValue<System.Int32>("DisplayOrder");}
set { this["DisplayOrder"] = value;}
}

public System.Boolean RestrictDisplayBasedOnFee {
get { return SafeGetValue<System.Boolean>("RestrictDisplayBasedOnFee");}
set { this["RestrictDisplayBasedOnFee"] = value;}
}

public System.Collections.Generic.List<System.String> ApplicableFees {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("ApplicableFees");}
set { this["ApplicableFees"] = value;}
}

public System.String CopyFieldTo {
get { return SafeGetValue<System.String>("CopyFieldTo");}
set { this["CopyFieldTo"] = value;}
}

public System.String CustomObject {
get { return SafeGetValue<System.String>("CustomObject");}
set { this["CustomObject"] = value;}
}

}
[Serializable]
public class msCustomFieldValueBase : msAggregateChild {
public new const string CLASS_NAME = "CustomFieldValueBase";
public new  static class FIELDS {
public const string OrderLineItemID = "OrderLineItemID";
public const string StringValue = "StringValue";
public const string IntegerValue = "IntegerValue";
public const string DecimalValue = "DecimalValue";
public const string ListValues = "ListValues";
public const string BooleanValue = "BooleanValue";
public const string DateTimeValue = "DateTimeValue";
public const string ReferenceValue = "ReferenceValue";
}
public msCustomFieldValueBase() : base() {
ClassType = "CustomFieldValueBase";
ListValues = new System.Collections.Generic.List<System.String>();
}
public msCustomFieldValueBase( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomFieldValueBase FromClassMetadata(ClassMetadata meta){return new msCustomFieldValueBase(MemberSuiteObject.FromClassMetadata(meta));}
public System.String OrderLineItemID {
get { return SafeGetValue<System.String>("OrderLineItemID");}
set { this["OrderLineItemID"] = value;}
}

public System.String StringValue {
get { return SafeGetValue<System.String>("StringValue");}
set { this["StringValue"] = value;}
}

public System.Int64 IntegerValue {
get { return SafeGetValue<System.Int64>("IntegerValue");}
set { this["IntegerValue"] = value;}
}

public System.Decimal? DecimalValue {
get { return SafeGetValue<System.Decimal?>("DecimalValue");}
set { this["DecimalValue"] = value;}
}

public System.Collections.Generic.List<System.String> ListValues {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("ListValues");}
set { this["ListValues"] = value;}
}

public System.Boolean BooleanValue {
get { return SafeGetValue<System.Boolean>("BooleanValue");}
set { this["BooleanValue"] = value;}
}

public System.DateTime? DateTimeValue {
get { return SafeGetValue<System.DateTime?>("DateTimeValue");}
set { this["DateTimeValue"] = value;}
}

public System.String ReferenceValue {
get { return SafeGetValue<System.String>("ReferenceValue");}
set { this["ReferenceValue"] = value;}
}

}
[Serializable]
public class msCustomFieldValue : msCustomFieldValueBase {
public new const string CLASS_NAME = "CustomFieldValue";
public new  static class FIELDS {
public const string CustomField = "CustomField";
}
public msCustomFieldValue() : base() {
ClassType = "CustomFieldValue";
ListValues = new System.Collections.Generic.List<System.String>();
}
public msCustomFieldValue( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomFieldValue FromClassMetadata(ClassMetadata meta){return new msCustomFieldValue(MemberSuiteObject.FromClassMetadata(meta));}
public System.String CustomField {
get { return SafeGetValue<System.String>("CustomField");}
set { this["CustomField"] = value;}
}

}
[Serializable]
public class msCustomObject : msAssociationDomainObject {
public new const string CLASS_NAME = "CustomObject";
public new  static class FIELDS {
public const string ClassDefinition = "ClassDefinition";
public const string Description = "Description";
public const string AllowCreationOnModuleHomePage = "AllowCreationOnModuleHomePage";
public const string AllowCreationFromOwnerObject = "AllowCreationFromOwnerObject";
public const string EnableQuickSearch = "EnableQuickSearch";
public const string OwnerType = "OwnerType";
public const string AllowSearchingOnModuleHomePage = "AllowSearchingOnModuleHomePage";
public const string DefaultColumnsToShowOnOwner360 = "DefaultColumnsToShowOnOwner360";
public const string DefaultQuickSearchColumns = "DefaultQuickSearchColumns";
public const string QuickSearchToOwner = "QuickSearchToOwner";
}
public msCustomObject() : base() {
ClassType = "CustomObject";
DefaultColumnsToShowOnOwner360 = new System.Collections.Generic.List<System.String>();
DefaultQuickSearchColumns = new System.Collections.Generic.List<System.String>();
}
public msCustomObject( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomObject FromClassMetadata(ClassMetadata meta){return new msCustomObject(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.ClassMetadata ClassDefinition {
get { return SafeGetValue<MemberSuite.SDK.Types.ClassMetadata>("ClassDefinition");}
set { this["ClassDefinition"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Boolean AllowCreationOnModuleHomePage {
get { return SafeGetValue<System.Boolean>("AllowCreationOnModuleHomePage");}
set { this["AllowCreationOnModuleHomePage"] = value;}
}

public System.Boolean AllowCreationFromOwnerObject {
get { return SafeGetValue<System.Boolean>("AllowCreationFromOwnerObject");}
set { this["AllowCreationFromOwnerObject"] = value;}
}

public System.Boolean EnableQuickSearch {
get { return SafeGetValue<System.Boolean>("EnableQuickSearch");}
set { this["EnableQuickSearch"] = value;}
}

public System.String OwnerType {
get { return SafeGetValue<System.String>("OwnerType");}
set { this["OwnerType"] = value;}
}

public System.Boolean AllowSearchingOnModuleHomePage {
get { return SafeGetValue<System.Boolean>("AllowSearchingOnModuleHomePage");}
set { this["AllowSearchingOnModuleHomePage"] = value;}
}

public System.Collections.Generic.List<System.String> DefaultColumnsToShowOnOwner360 {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("DefaultColumnsToShowOnOwner360");}
set { this["DefaultColumnsToShowOnOwner360"] = value;}
}

public System.Collections.Generic.List<System.String> DefaultQuickSearchColumns {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("DefaultQuickSearchColumns");}
set { this["DefaultQuickSearchColumns"] = value;}
}

public System.Boolean QuickSearchToOwner {
get { return SafeGetValue<System.Boolean>("QuickSearchToOwner");}
set { this["QuickSearchToOwner"] = value;}
}

}
[Serializable]
public class msCustomObjectInstance : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "CustomObjectInstance";
public new  static class FIELDS {
public const string CustomObject = "CustomObject";
public const string Owner = "Owner";
}
public msCustomObjectInstance() : base() {
ClassType = "CustomObjectInstance";
}
public msCustomObjectInstance( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomObjectInstance FromClassMetadata(ClassMetadata meta){return new msCustomObjectInstance(MemberSuiteObject.FromClassMetadata(meta));}
public System.String CustomObject {
get { return SafeGetValue<System.String>("CustomObject");}
set { this["CustomObject"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

}
[Serializable]
public class msDashboardContainer : msAssociationDomainObject {
public new const string CLASS_NAME = "DashboardContainer";
public new  static class FIELDS {
public const string Dashboard = "Dashboard";
public const string IsPublic = "IsPublic";
public const string Owner = "Owner";
}
public msDashboardContainer() : base() {
ClassType = "DashboardContainer";
}
public msDashboardContainer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDashboardContainer FromClassMetadata(ClassMetadata meta){return new msDashboardContainer(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Manifests.Command.Views.DashboardMetadata Dashboard {
get { return SafeGetValue<MemberSuite.SDK.Manifests.Command.Views.DashboardMetadata>("Dashboard");}
set { this["Dashboard"] = value;}
}

public System.Boolean IsPublic {
get { return SafeGetValue<System.Boolean>("IsPublic");}
set { this["IsPublic"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

}
[Serializable]
public class msData360PageLayoutContainer : msMetadataContainer {
public new const string CLASS_NAME = "Data360PageLayoutContainer";
public new  static class FIELDS {
public const string Metadata = "Metadata";
}
public msData360PageLayoutContainer() : base() {
ClassType = "Data360PageLayoutContainer";
}
public msData360PageLayoutContainer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msData360PageLayoutContainer FromClassMetadata(ClassMetadata meta){return new msData360PageLayoutContainer(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Manifests.Command.Views.Data360ViewMetadata Metadata {
get { return SafeGetValue<MemberSuite.SDK.Manifests.Command.Views.Data360ViewMetadata>("Metadata");}
set { this["Metadata"] = value;}
}

}
[Serializable]
public class msDataEntryPageLayoutContainer : msMetadataContainer {
public new const string CLASS_NAME = "DataEntryPageLayoutContainer";
public new  static class FIELDS {
public const string Metadata = "Metadata";
}
public msDataEntryPageLayoutContainer() : base() {
ClassType = "DataEntryPageLayoutContainer";
}
public msDataEntryPageLayoutContainer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDataEntryPageLayoutContainer FromClassMetadata(ClassMetadata meta){return new msDataEntryPageLayoutContainer(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Manifests.Command.Views.DataEntryViewMetadata Metadata {
get { return SafeGetValue<MemberSuite.SDK.Manifests.Command.Views.DataEntryViewMetadata>("Metadata");}
set { this["Metadata"] = value;}
}

}
[Serializable]
public class msDuplicateDetectionRuleContainer : msMetadataContainer {
public new const string CLASS_NAME = "DuplicateDetectionRuleContainer";
public new  static class FIELDS {
public const string Rule = "Rule";
}
public msDuplicateDetectionRuleContainer() : base() {
ClassType = "DuplicateDetectionRuleContainer";
}
public msDuplicateDetectionRuleContainer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msDuplicateDetectionRuleContainer FromClassMetadata(ClassMetadata meta){return new msDuplicateDetectionRuleContainer(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.DuplicateDetection.DuplicateDetectionRule Rule {
get { return SafeGetValue<MemberSuite.SDK.DuplicateDetection.DuplicateDetectionRule>("Rule");}
set { this["Rule"] = value;}
}

}
[Serializable]
public class msEmailTemplateContainer : msMetadataContainer {
public new const string CLASS_NAME = "EmailTemplateContainer";
public new  static class FIELDS {
public const string Context = "Context";
public const string Template = "Template";
}
public msEmailTemplateContainer() : base() {
ClassType = "EmailTemplateContainer";
}
public msEmailTemplateContainer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msEmailTemplateContainer FromClassMetadata(ClassMetadata meta){return new msEmailTemplateContainer(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Context {
get { return SafeGetValue<System.String>("Context");}
set { this["Context"] = value;}
}

public MemberSuite.SDK.Types.EmailTemplate Template {
get { return SafeGetValue<MemberSuite.SDK.Types.EmailTemplate>("Template");}
set { this["Template"] = value;}
}

}
[Serializable]
public class msSavedSearch : msAssociationDomainObject {
public new const string CLASS_NAME = "SavedSearch";
public new  static class FIELDS {
public const string IsPublic = "IsPublic";
public const string Search = "Search";
public const string CustomObject = "CustomObject";
public const string Description = "Description";
public const string ApplicableType = "ApplicableType";
}
public msSavedSearch() : base() {
ClassType = "SavedSearch";
}
public msSavedSearch( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSavedSearch FromClassMetadata(ClassMetadata meta){return new msSavedSearch(MemberSuiteObject.FromClassMetadata(meta));}
public System.Boolean IsPublic {
get { return SafeGetValue<System.Boolean>("IsPublic");}
set { this["IsPublic"] = value;}
}

public MemberSuite.SDK.Searching.Search Search {
get { return SafeGetValue<MemberSuite.SDK.Searching.Search>("Search");}
set { this["Search"] = value;}
}

public System.String CustomObject {
get { return SafeGetValue<System.String>("CustomObject");}
set { this["CustomObject"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String ApplicableType {
get { return SafeGetValue<System.String>("ApplicableType");}
set { this["ApplicableType"] = value;}
}

}
[Serializable]
public class msSecurityRole : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "SecurityRole";
public new  static class FIELDS {
public const string KeyChain = "KeyChain";
public const string Members = "Members";
}
public msSecurityRole() : base() {
ClassType = "SecurityRole";
Members = new System.Collections.Generic.List<System.String>();
}
public msSecurityRole( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSecurityRole FromClassMetadata(ClassMetadata meta){return new msSecurityRole(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.KeyChain KeyChain {
get { return SafeGetValue<MemberSuite.SDK.Types.KeyChain>("KeyChain");}
set { this["KeyChain"] = value;}
}

public System.Collections.Generic.List<System.String> Members {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("Members");}
set { this["Members"] = value;}
}

}
[Serializable]
public class msBackIssueProduct : msProduct {
public new const string CLASS_NAME = "BackIssueProduct";
public new  static class FIELDS {
public const string Issue = "Issue";
}
public msBackIssueProduct() : base() {
ClassType = "BackIssueProduct";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msBackIssueProduct( MemberSuiteObject msObj) : base(msObj) {}
 public static new msBackIssueProduct FromClassMetadata(ClassMetadata meta){return new msBackIssueProduct(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Issue {
get { return SafeGetValue<System.String>("Issue");}
set { this["Issue"] = value;}
}

}
[Serializable]
public class msSubscription : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Subscription";
public new  static class FIELDS {
public const string Quantity = "Quantity";
public const string Publication = "Publication";
public const string Fee = "Fee";
public const string Address = "Address";
public const string OriginalOrder = "OriginalOrder";
public const string OriginalOrderLineItemID = "OriginalOrderLineItemID";
public const string LastOrder = "LastOrder";
public const string BilledThru = "BilledThru";
public const string RemindedThru = "RemindedThru";
public const string LastOrderLineItemID = "LastOrderLineItemID";
public const string SavedPaymentMethod = "SavedPaymentMethod";
public const string Owner = "Owner";
public const string BillTo = "BillTo";
public const string OnHold = "OnHold";
public const string OverrideShipToAddress = "OverrideShipToAddress";
public const string OverrideShipToName = "OverrideShipToName";
public const string StartDate = "StartDate";
public const string TerminationDate = "TerminationDate";
public const string TerminationReason = "TerminationReason";
public const string ExpirationDate = "ExpirationDate";
public const string Notes = "Notes";
public const string DoNotRenew = "DoNotRenew";
public const string AutomaticallyPayForRenewal = "AutomaticallyPayForRenewal";
}
public msSubscription() : base() {
ClassType = "Subscription";
}
public msSubscription( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSubscription FromClassMetadata(ClassMetadata meta){return new msSubscription(MemberSuiteObject.FromClassMetadata(meta));}
public System.Int32 Quantity {
get { return SafeGetValue<System.Int32>("Quantity");}
set { this["Quantity"] = value;}
}

public System.String Publication {
get { return SafeGetValue<System.String>("Publication");}
set { this["Publication"] = value;}
}

public System.String Fee {
get { return SafeGetValue<System.String>("Fee");}
set { this["Fee"] = value;}
}

public MemberSuite.SDK.Types.Address Address {
get { return SafeGetValue<MemberSuite.SDK.Types.Address>("Address");}
set { this["Address"] = value;}
}

public System.String OriginalOrder {
get { return SafeGetValue<System.String>("OriginalOrder");}
set { this["OriginalOrder"] = value;}
}

public System.String OriginalOrderLineItemID {
get { return SafeGetValue<System.String>("OriginalOrderLineItemID");}
set { this["OriginalOrderLineItemID"] = value;}
}

public System.String LastOrder {
get { return SafeGetValue<System.String>("LastOrder");}
set { this["LastOrder"] = value;}
}

public System.DateTime? BilledThru {
get { return SafeGetValue<System.DateTime?>("BilledThru");}
set { this["BilledThru"] = value;}
}

public System.DateTime? RemindedThru {
get { return SafeGetValue<System.DateTime?>("RemindedThru");}
set { this["RemindedThru"] = value;}
}

public System.String LastOrderLineItemID {
get { return SafeGetValue<System.String>("LastOrderLineItemID");}
set { this["LastOrderLineItemID"] = value;}
}

public System.String SavedPaymentMethod {
get { return SafeGetValue<System.String>("SavedPaymentMethod");}
set { this["SavedPaymentMethod"] = value;}
}

public System.String Owner {
get { return SafeGetValue<System.String>("Owner");}
set { this["Owner"] = value;}
}

public System.String BillTo {
get { return SafeGetValue<System.String>("BillTo");}
set { this["BillTo"] = value;}
}

public System.Boolean OnHold {
get { return SafeGetValue<System.Boolean>("OnHold");}
set { this["OnHold"] = value;}
}

public System.Boolean OverrideShipToAddress {
get { return SafeGetValue<System.Boolean>("OverrideShipToAddress");}
set { this["OverrideShipToAddress"] = value;}
}

public System.String OverrideShipToName {
get { return SafeGetValue<System.String>("OverrideShipToName");}
set { this["OverrideShipToName"] = value;}
}

public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? TerminationDate {
get { return SafeGetValue<System.DateTime?>("TerminationDate");}
set { this["TerminationDate"] = value;}
}

public System.String TerminationReason {
get { return SafeGetValue<System.String>("TerminationReason");}
set { this["TerminationReason"] = value;}
}

public System.DateTime? ExpirationDate {
get { return SafeGetValue<System.DateTime?>("ExpirationDate");}
set { this["ExpirationDate"] = value;}
}

public System.String Notes {
get { return SafeGetValue<System.String>("Notes");}
set { this["Notes"] = value;}
}

public System.Boolean DoNotRenew {
get { return SafeGetValue<System.Boolean>("DoNotRenew");}
set { this["DoNotRenew"] = value;}
}

public System.Boolean AutomaticallyPayForRenewal {
get { return SafeGetValue<System.Boolean>("AutomaticallyPayForRenewal");}
set { this["AutomaticallyPayForRenewal"] = value;}
}

}
[Serializable]
public class msSubscriptionFee : msExpiringProduct {
public new const string CLASS_NAME = "SubscriptionFee";
public new  static class FIELDS {
public const string Publication = "Publication";
public const string RenewsWith = "RenewsWith";
public const string Type = "Type";
}
public msSubscriptionFee() : base() {
ClassType = "SubscriptionFee";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msSubscriptionFee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSubscriptionFee FromClassMetadata(ClassMetadata meta){return new msSubscriptionFee(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Publication {
get { return SafeGetValue<System.String>("Publication");}
set { this["Publication"] = value;}
}

public System.String RenewsWith {
get { return SafeGetValue<System.String>("RenewsWith");}
set { this["RenewsWith"] = value;}
}

public MemberSuite.SDK.Types.SubscriptionFeeType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.SubscriptionFeeType>("Type");}
set { this["Type"] = value;}
}

}
[Serializable]
public class msSubscriptionFulfillment : msAssociationDomainObject {
public new const string CLASS_NAME = "SubscriptionFulfillment";
public new  static class FIELDS {
public const string Issue = "Issue";
public const string ShipToName = "ShipToName";
public const string ShippingAddress = "ShippingAddress";
public const string Quantity = "Quantity";
public const string Status = "Status";
public const string Subscription = "Subscription";
public const string Subscriber = "Subscriber";
}
public msSubscriptionFulfillment() : base() {
ClassType = "SubscriptionFulfillment";
}
public msSubscriptionFulfillment( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSubscriptionFulfillment FromClassMetadata(ClassMetadata meta){return new msSubscriptionFulfillment(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Issue {
get { return SafeGetValue<System.String>("Issue");}
set { this["Issue"] = value;}
}

public System.String ShipToName {
get { return SafeGetValue<System.String>("ShipToName");}
set { this["ShipToName"] = value;}
}

public MemberSuite.SDK.Types.Address ShippingAddress {
get { return SafeGetValue<MemberSuite.SDK.Types.Address>("ShippingAddress");}
set { this["ShippingAddress"] = value;}
}

public System.Int32 Quantity {
get { return SafeGetValue<System.Int32>("Quantity");}
set { this["Quantity"] = value;}
}

public MemberSuite.SDK.Types.SubscriptionFulfillmentStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.SubscriptionFulfillmentStatus>("Status");}
set { this["Status"] = value;}
}

public System.String Subscription {
get { return SafeGetValue<System.String>("Subscription");}
set { this["Subscription"] = value;}
}

public System.String Subscriber {
get { return SafeGetValue<System.String>("Subscriber");}
set { this["Subscriber"] = value;}
}

}
[Serializable]
public class msAuditLog : msAssociationDomainObject {
public new const string CLASS_NAME = "AuditLog";
public new  static class FIELDS {
public const string Type = "Type";
public const string AffectedFields = "AffectedFields";
public const string Actor = "Actor";
public const string AffectedRecord_Type = "AffectedRecord_Type";
public const string AffectedRecord_ID = "AffectedRecord_ID";
public const string AffectedRecord_Name = "AffectedRecord_Name";
public const string Description = "Description";
public const string ServiceName = "ServiceName";
}
public msAuditLog() : base() {
ClassType = "AuditLog";
AffectedFields = new System.Collections.Generic.List<msAuditLogField>();
}
public msAuditLog( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAuditLog FromClassMetadata(ClassMetadata meta){return new msAuditLog(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Types.AuditLogType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.AuditLogType>("Type");}
set { this["Type"] = value;}
}

public System.Collections.Generic.List<msAuditLogField> AffectedFields {
get { return SafeGetValue<System.Collections.Generic.List<msAuditLogField>>("AffectedFields");}
set { this["AffectedFields"] = value;}
}

public System.String Actor {
get { return SafeGetValue<System.String>("Actor");}
set { this["Actor"] = value;}
}

public System.String AffectedRecord_Type {
get { return SafeGetValue<System.String>("AffectedRecord_Type");}
set { this["AffectedRecord_Type"] = value;}
}

public System.String AffectedRecord_ID {
get { return SafeGetValue<System.String>("AffectedRecord_ID");}
set { this["AffectedRecord_ID"] = value;}
}

public System.String AffectedRecord_Name {
get { return SafeGetValue<System.String>("AffectedRecord_Name");}
set { this["AffectedRecord_Name"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String ServiceName {
get { return SafeGetValue<System.String>("ServiceName");}
set { this["ServiceName"] = value;}
}

}
[Serializable]
public class msAuditLogField : msAggregateChild {
public new const string CLASS_NAME = "AuditLogField";
public new  static class FIELDS {
public const string Field = "Field";
public const string PreviousValue = "PreviousValue";
public const string NewValue = "NewValue";
}
public msAuditLogField() : base() {
ClassType = "AuditLogField";
}
public msAuditLogField( MemberSuiteObject msObj) : base(msObj) {}
 public static new msAuditLogField FromClassMetadata(ClassMetadata meta){return new msAuditLogField(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Field {
get { return SafeGetValue<System.String>("Field");}
set { this["Field"] = value;}
}

public System.String PreviousValue {
get { return SafeGetValue<System.String>("PreviousValue");}
set { this["PreviousValue"] = value;}
}

public System.String NewValue {
get { return SafeGetValue<System.String>("NewValue");}
set { this["NewValue"] = value;}
}

}
[Serializable]
public class msFile : msAssociationDomainObject {
public new const string CLASS_NAME = "File";
public new  static class FIELDS {
public const string Entity = "Entity";
public const string Opportunity = "Opportunity";
public const string Lead = "Lead";
public const string Volunteer = "Volunteer";
public const string AccreditationSiteVisit = "AccreditationSiteVisit";
public const string Accreditation = "Accreditation";
public const string Certification = "Certification";
public const string FileCabinet = "FileCabinet";
public const string FileFolder = "FileFolder";
public const string FileContents = "FileContents";
public const string Extension = "Extension";
public const string ContentLength = "ContentLength";
public const string ContentType = "ContentType";
public const string Description = "Description";
public const string IndexingHash = "IndexingHash";
public const string CopyFileFrom_ID = "CopyFileFrom_ID";
}
public msFile() : base() {
ClassType = "File";
}
public msFile( MemberSuiteObject msObj) : base(msObj) {}
 public static new msFile FromClassMetadata(ClassMetadata meta){return new msFile(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Entity {
get { return SafeGetValue<System.String>("Entity");}
set { this["Entity"] = value;}
}

public System.String Opportunity {
get { return SafeGetValue<System.String>("Opportunity");}
set { this["Opportunity"] = value;}
}

public System.String Lead {
get { return SafeGetValue<System.String>("Lead");}
set { this["Lead"] = value;}
}

public System.String Volunteer {
get { return SafeGetValue<System.String>("Volunteer");}
set { this["Volunteer"] = value;}
}

public System.String AccreditationSiteVisit {
get { return SafeGetValue<System.String>("AccreditationSiteVisit");}
set { this["AccreditationSiteVisit"] = value;}
}

public System.String Accreditation {
get { return SafeGetValue<System.String>("Accreditation");}
set { this["Accreditation"] = value;}
}

public System.String Certification {
get { return SafeGetValue<System.String>("Certification");}
set { this["Certification"] = value;}
}

public System.String FileCabinet {
get { return SafeGetValue<System.String>("FileCabinet");}
set { this["FileCabinet"] = value;}
}

public System.String FileFolder {
get { return SafeGetValue<System.String>("FileFolder");}
set { this["FileFolder"] = value;}
}

public System.String FileContents {
get { return SafeGetValue<System.String>("FileContents");}
set { this["FileContents"] = value;}
}

public System.String Extension {
get { return SafeGetValue<System.String>("Extension");}
set { this["Extension"] = value;}
}

public System.Int32 ContentLength {
get { return SafeGetValue<System.Int32>("ContentLength");}
set { this["ContentLength"] = value;}
}

public System.String ContentType {
get { return SafeGetValue<System.String>("ContentType");}
set { this["ContentType"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String IndexingHash {
get { return SafeGetValue<System.String>("IndexingHash");}
set { this["IndexingHash"] = value;}
}

public System.String CopyFileFrom_ID {
get { return SafeGetValue<System.String>("CopyFileFrom_ID");}
set { this["CopyFileFrom_ID"] = value;}
}

}
[Serializable]
public class msLookupTable : msAssociationDomainObject {
public new const string CLASS_NAME = "LookupTable";
public new  static class FIELDS {
public const string Description = "Description";
public const string Rows = "Rows";
}
public msLookupTable() : base() {
ClassType = "LookupTable";
Rows = new System.Collections.Generic.List<MemberSuite.SDK.Types.NameValueStringPair>();
}
public msLookupTable( MemberSuiteObject msObj) : base(msObj) {}
 public static new msLookupTable FromClassMetadata(ClassMetadata meta){return new msLookupTable(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Collections.Generic.List<MemberSuite.SDK.Types.NameValueStringPair> Rows {
get { return SafeGetValue<System.Collections.Generic.List<MemberSuite.SDK.Types.NameValueStringPair>>("Rows");}
set { this["Rows"] = value;}
}

}
[Serializable]
public class msMailMergeTemplate : msMailMergeTemplateBase {
public new const string CLASS_NAME = "MailMergeTemplate";
public new  static class FIELDS {
}
public msMailMergeTemplate() : base() {
ClassType = "MailMergeTemplate";
}
public msMailMergeTemplate( MemberSuiteObject msObj) : base(msObj) {}
 public static new msMailMergeTemplate FromClassMetadata(ClassMetadata meta){return new msMailMergeTemplate(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msPortalControlPropertyOverride : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "PortalControlPropertyOverride";
public new  static class FIELDS {
public const string PageName = "PageName";
public const string ControlName = "ControlName";
public const string PropertyName = "PropertyName";
public const string Value = "Value";
public const string Description = "Description";
}
public msPortalControlPropertyOverride() : base() {
ClassType = "PortalControlPropertyOverride";
}
public msPortalControlPropertyOverride( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPortalControlPropertyOverride FromClassMetadata(ClassMetadata meta){return new msPortalControlPropertyOverride(MemberSuiteObject.FromClassMetadata(meta));}
public System.String PageName {
get { return SafeGetValue<System.String>("PageName");}
set { this["PageName"] = value;}
}

public System.String ControlName {
get { return SafeGetValue<System.String>("ControlName");}
set { this["ControlName"] = value;}
}

public System.String PropertyName {
get { return SafeGetValue<System.String>("PropertyName");}
set { this["PropertyName"] = value;}
}

public System.String Value {
get { return SafeGetValue<System.String>("Value");}
set { this["Value"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msPortalForm : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "PortalForm";
public new  static class FIELDS {
public const string DisplayOrder = "DisplayOrder";
public const string LoginScreenDisplayName = "LoginScreenDisplayName";
public const string DisplayOnHomeScreen = "DisplayOnHomeScreen";
public const string HomeScreenDisplayName = "HomeScreenDisplayName";
public const string CustomerType = "CustomerType";
public const string Module = "Module";
public const string Description = "Description";
public const string ShowFrom = "ShowFrom";
public const string ShowUntil = "ShowUntil";
public const string MembersOnly = "MembersOnly";
public const string DisplayOnLoginScreen = "DisplayOnLoginScreen";
public const string ConfirmationEmail = "ConfirmationEmail";
public const string FormInstructions = "FormInstructions";
public const string EditInstructions = "EditInstructions";
public const string ConfirmationInstructions = "ConfirmationInstructions";
public const string ViewInstructions = "ViewInstructions";
public const string ManageInstructions = "ManageInstructions";
public const string PostSubmissionInstructions = "PostSubmissionInstructions";
public const string CreatePageLayout = "CreatePageLayout";
public const string EditPageLayout = "EditPageLayout";
public const string ViewPageLayout = "ViewPageLayout";
public const string ActivityType = "ActivityType";
public const string ValueAssignments = "ValueAssignments";
}
public msPortalForm() : base() {
ClassType = "PortalForm";
ValueAssignments = new System.Collections.Generic.List<msPortalFormValueAssignment>();
}
public msPortalForm( MemberSuiteObject msObj) : base(msObj) {}
public System.Int32? DisplayOrder {
get { return SafeGetValue<System.Int32?>("DisplayOrder");}
set { this["DisplayOrder"] = value;}
}

public System.String LoginScreenDisplayName {
get { return SafeGetValue<System.String>("LoginScreenDisplayName");}
set { this["LoginScreenDisplayName"] = value;}
}

public System.Boolean DisplayOnHomeScreen {
get { return SafeGetValue<System.Boolean>("DisplayOnHomeScreen");}
set { this["DisplayOnHomeScreen"] = value;}
}

public System.String HomeScreenDisplayName {
get { return SafeGetValue<System.String>("HomeScreenDisplayName");}
set { this["HomeScreenDisplayName"] = value;}
}

public MemberSuite.SDK.Types.CustomerType CustomerType {
get { return SafeGetValue<MemberSuite.SDK.Types.CustomerType>("CustomerType");}
set { this["CustomerType"] = value;}
}

public System.String Module {
get { return SafeGetValue<System.String>("Module");}
set { this["Module"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.DateTime? ShowFrom {
get { return SafeGetValue<System.DateTime?>("ShowFrom");}
set { this["ShowFrom"] = value;}
}

public System.DateTime? ShowUntil {
get { return SafeGetValue<System.DateTime?>("ShowUntil");}
set { this["ShowUntil"] = value;}
}

public System.Boolean MembersOnly {
get { return SafeGetValue<System.Boolean>("MembersOnly");}
set { this["MembersOnly"] = value;}
}

public System.Boolean DisplayOnLoginScreen {
get { return SafeGetValue<System.Boolean>("DisplayOnLoginScreen");}
set { this["DisplayOnLoginScreen"] = value;}
}

public System.String ConfirmationEmail {
get { return SafeGetValue<System.String>("ConfirmationEmail");}
set { this["ConfirmationEmail"] = value;}
}

public System.String FormInstructions {
get { return SafeGetValue<System.String>("FormInstructions");}
set { this["FormInstructions"] = value;}
}

public System.String EditInstructions {
get { return SafeGetValue<System.String>("EditInstructions");}
set { this["EditInstructions"] = value;}
}

public System.String ConfirmationInstructions {
get { return SafeGetValue<System.String>("ConfirmationInstructions");}
set { this["ConfirmationInstructions"] = value;}
}

public System.String ViewInstructions {
get { return SafeGetValue<System.String>("ViewInstructions");}
set { this["ViewInstructions"] = value;}
}

public System.String ManageInstructions {
get { return SafeGetValue<System.String>("ManageInstructions");}
set { this["ManageInstructions"] = value;}
}

public System.String PostSubmissionInstructions {
get { return SafeGetValue<System.String>("PostSubmissionInstructions");}
set { this["PostSubmissionInstructions"] = value;}
}

public System.String CreatePageLayout {
get { return SafeGetValue<System.String>("CreatePageLayout");}
set { this["CreatePageLayout"] = value;}
}

public System.String EditPageLayout {
get { return SafeGetValue<System.String>("EditPageLayout");}
set { this["EditPageLayout"] = value;}
}

public System.String ViewPageLayout {
get { return SafeGetValue<System.String>("ViewPageLayout");}
set { this["ViewPageLayout"] = value;}
}

public System.String ActivityType {
get { return SafeGetValue<System.String>("ActivityType");}
set { this["ActivityType"] = value;}
}

public System.Collections.Generic.List<msPortalFormValueAssignment> ValueAssignments {
get { return SafeGetValue<System.Collections.Generic.List<msPortalFormValueAssignment>>("ValueAssignments");}
set { this["ValueAssignments"] = value;}
}

}
[Serializable]
public class msPortalFormValueAssignment : msAggregateChild {
public new const string CLASS_NAME = "PortalFormValueAssignment";
public new  static class FIELDS {
public const string FieldName = "FieldName";
public const string ValueToSet = "ValueToSet";
public const string OnlyIfPreviouslyNull = "OnlyIfPreviouslyNull";
public const string ClearExistingValues = "ClearExistingValues";
}
public msPortalFormValueAssignment() : base() {
ClassType = "PortalFormValueAssignment";
}
public msPortalFormValueAssignment( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPortalFormValueAssignment FromClassMetadata(ClassMetadata meta){return new msPortalFormValueAssignment(MemberSuiteObject.FromClassMetadata(meta));}
public System.String FieldName {
get { return SafeGetValue<System.String>("FieldName");}
set { this["FieldName"] = value;}
}

public System.String ValueToSet {
get { return SafeGetValue<System.String>("ValueToSet");}
set { this["ValueToSet"] = value;}
}

public System.Boolean OnlyIfPreviouslyNull {
get { return SafeGetValue<System.Boolean>("OnlyIfPreviouslyNull");}
set { this["OnlyIfPreviouslyNull"] = value;}
}

public System.Boolean ClearExistingValues {
get { return SafeGetValue<System.Boolean>("ClearExistingValues");}
set { this["ClearExistingValues"] = value;}
}

}
[Serializable]
public class msCustomObjectPortalForm : msPortalForm {
public new const string CLASS_NAME = "CustomObjectPortalForm";
public new  static class FIELDS {
public const string CustomObject = "CustomObject";
public const string MaximumNumberOfSubmissions = "MaximumNumberOfSubmissions";
public const string AccessMode = "AccessMode";
public const string FormSubmissionManagementLinkText = "FormSubmissionManagementLinkText";
public const string ManagementFieldsToDisplay = "ManagementFieldsToDisplay";
public const string AllowAnonymousSubmissions = "AllowAnonymousSubmissions";
public const string AnonymousSubmissionCompletionUrl = "AnonymousSubmissionCompletionUrl";
}
public msCustomObjectPortalForm() : base() {
ClassType = "CustomObjectPortalForm";
ManagementFieldsToDisplay = new System.Collections.Generic.List<System.String>();
ValueAssignments = new System.Collections.Generic.List<msPortalFormValueAssignment>();
}
public msCustomObjectPortalForm( MemberSuiteObject msObj) : base(msObj) {}
 public static new msCustomObjectPortalForm FromClassMetadata(ClassMetadata meta){return new msCustomObjectPortalForm(MemberSuiteObject.FromClassMetadata(meta));}
public System.String CustomObject {
get { return SafeGetValue<System.String>("CustomObject");}
set { this["CustomObject"] = value;}
}

public System.Int32? MaximumNumberOfSubmissions {
get { return SafeGetValue<System.Int32?>("MaximumNumberOfSubmissions");}
set { this["MaximumNumberOfSubmissions"] = value;}
}

public MemberSuite.SDK.Types.CustomObjectPortalFormAccessMode AccessMode {
get { return SafeGetValue<MemberSuite.SDK.Types.CustomObjectPortalFormAccessMode>("AccessMode");}
set { this["AccessMode"] = value;}
}

public System.String FormSubmissionManagementLinkText {
get { return SafeGetValue<System.String>("FormSubmissionManagementLinkText");}
set { this["FormSubmissionManagementLinkText"] = value;}
}

public System.Collections.Generic.List<System.String> ManagementFieldsToDisplay {
get { return SafeGetValue<System.Collections.Generic.List<System.String>>("ManagementFieldsToDisplay");}
set { this["ManagementFieldsToDisplay"] = value;}
}

public System.Boolean AllowAnonymousSubmissions {
get { return SafeGetValue<System.Boolean>("AllowAnonymousSubmissions");}
set { this["AllowAnonymousSubmissions"] = value;}
}

public System.String AnonymousSubmissionCompletionUrl {
get { return SafeGetValue<System.String>("AnonymousSubmissionCompletionUrl");}
set { this["AnonymousSubmissionCompletionUrl"] = value;}
}

}
[Serializable]
public class msPortalLink : msInformationLink {
public new const string CLASS_NAME = "PortalLink";
public new  static class FIELDS {
public const string IsPublic = "IsPublic";
public const string Type = "Type";
public const string Event = "Event";
public const string Competition = "Competition";
public const string Url = "Url";
public const string ExpirationDate = "ExpirationDate";
}
public msPortalLink() : base() {
ClassType = "PortalLink";
}
public msPortalLink( MemberSuiteObject msObj) : base(msObj) {}
 public static new msPortalLink FromClassMetadata(ClassMetadata meta){return new msPortalLink(MemberSuiteObject.FromClassMetadata(meta));}
public System.Boolean IsPublic {
get { return SafeGetValue<System.Boolean>("IsPublic");}
set { this["IsPublic"] = value;}
}

public MemberSuite.SDK.Types.PortalLinkType Type {
get { return SafeGetValue<MemberSuite.SDK.Types.PortalLinkType>("Type");}
set { this["Type"] = value;}
}

public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String Competition {
get { return SafeGetValue<System.String>("Competition");}
set { this["Competition"] = value;}
}

public System.String Url {
get { return SafeGetValue<System.String>("Url");}
set { this["Url"] = value;}
}

public System.DateTime? ExpirationDate {
get { return SafeGetValue<System.DateTime?>("ExpirationDate");}
set { this["ExpirationDate"] = value;}
}

}
[Serializable]
public class msScheduledSearch : msAutomatedRecurringProcess {
public new const string CLASS_NAME = "ScheduledSearch";
public new  static class FIELDS {
public const string Search = "Search";
public const string SearchType = "SearchType";
public const string SearchContext = "SearchContext";
public const string DontSendEmptyReports = "DontSendEmptyReports";
public const string OutputType = "OutputType";
public const string SendImmediately = "SendImmediately";
public const string Description = "Description";
}
public msScheduledSearch() : base() {
ClassType = "ScheduledSearch";
}
public msScheduledSearch( MemberSuiteObject msObj) : base(msObj) {}
 public static new msScheduledSearch FromClassMetadata(ClassMetadata meta){return new msScheduledSearch(MemberSuiteObject.FromClassMetadata(meta));}
public MemberSuite.SDK.Searching.Search Search {
get { return SafeGetValue<MemberSuite.SDK.Searching.Search>("Search");}
set { this["Search"] = value;}
}

public System.String SearchType {
get { return SafeGetValue<System.String>("SearchType");}
set { this["SearchType"] = value;}
}

public System.String SearchContext {
get { return SafeGetValue<System.String>("SearchContext");}
set { this["SearchContext"] = value;}
}

public System.Boolean DontSendEmptyReports {
get { return SafeGetValue<System.Boolean>("DontSendEmptyReports");}
set { this["DontSendEmptyReports"] = value;}
}

public System.String OutputType {
get { return SafeGetValue<System.String>("OutputType");}
set { this["OutputType"] = value;}
}

public System.Boolean SendImmediately {
get { return SafeGetValue<System.Boolean>("SendImmediately");}
set { this["SendImmediately"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msWidget : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "Widget";
public new  static class FIELDS {
public const string Description = "Description";
}
public msWidget() : base() {
ClassType = "Widget";
}
public msWidget( MemberSuiteObject msObj) : base(msObj) {}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msSearchResultsWidget : msWidget {
public new const string CLASS_NAME = "SearchResultsWidget";
public new  static class FIELDS {
public const string Search = "Search";
public const string CacheExpiration = "CacheExpiration";
}
public msSearchResultsWidget() : base() {
ClassType = "SearchResultsWidget";
}
public msSearchResultsWidget( MemberSuiteObject msObj) : base(msObj) {}
 public static new msSearchResultsWidget FromClassMetadata(ClassMetadata meta){return new msSearchResultsWidget(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Search {
get { return SafeGetValue<System.String>("Search");}
set { this["Search"] = value;}
}

public System.Int32? CacheExpiration {
get { return SafeGetValue<System.Int32?>("CacheExpiration");}
set { this["CacheExpiration"] = value;}
}

}
[Serializable]
public class msVolunteer : msCustomizableAssociationDomainObject {
public new const string CLASS_NAME = "Volunteer";
public new  static class FIELDS {
public const string Types = "Types";
public const string Individual = "Individual";
public const string EmergencyContactName = "EmergencyContactName";
public const string EmergencyContactPhone = "EmergencyContactPhone";
public const string Sponsor = "Sponsor";
public const string Traits = "Traits";
public const string Availability = "Availability";
public const string Locations = "Locations";
public const string AvailabilityComment = "AvailabilityComment";
public const string UnavailableFrom = "UnavailableFrom";
public const string UnavailableTo = "UnavailableTo";
}
public msVolunteer() : base() {
ClassType = "Volunteer";
Types = new System.Collections.Generic.List<msVolunteerAssignedType>();
Traits = new System.Collections.Generic.List<msVolunteerTrait>();
Availability = new System.Collections.Generic.List<msVolunteerAvailability>();
Locations = new System.Collections.Generic.List<msVolunteerAssignedLocation>();
}
public msVolunteer( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteer FromClassMetadata(ClassMetadata meta){return new msVolunteer(MemberSuiteObject.FromClassMetadata(meta));}
public System.Collections.Generic.List<msVolunteerAssignedType> Types {
get { return SafeGetValue<System.Collections.Generic.List<msVolunteerAssignedType>>("Types");}
set { this["Types"] = value;}
}

public System.String Individual {
get { return SafeGetValue<System.String>("Individual");}
set { this["Individual"] = value;}
}

public System.String EmergencyContactName {
get { return SafeGetValue<System.String>("EmergencyContactName");}
set { this["EmergencyContactName"] = value;}
}

public System.String EmergencyContactPhone {
get { return SafeGetValue<System.String>("EmergencyContactPhone");}
set { this["EmergencyContactPhone"] = value;}
}

public System.String Sponsor {
get { return SafeGetValue<System.String>("Sponsor");}
set { this["Sponsor"] = value;}
}

public System.Collections.Generic.List<msVolunteerTrait> Traits {
get { return SafeGetValue<System.Collections.Generic.List<msVolunteerTrait>>("Traits");}
set { this["Traits"] = value;}
}

public System.Collections.Generic.List<msVolunteerAvailability> Availability {
get { return SafeGetValue<System.Collections.Generic.List<msVolunteerAvailability>>("Availability");}
set { this["Availability"] = value;}
}

public System.Collections.Generic.List<msVolunteerAssignedLocation> Locations {
get { return SafeGetValue<System.Collections.Generic.List<msVolunteerAssignedLocation>>("Locations");}
set { this["Locations"] = value;}
}

public System.String AvailabilityComment {
get { return SafeGetValue<System.String>("AvailabilityComment");}
set { this["AvailabilityComment"] = value;}
}

public System.DateTime? UnavailableFrom {
get { return SafeGetValue<System.DateTime?>("UnavailableFrom");}
set { this["UnavailableFrom"] = value;}
}

public System.DateTime? UnavailableTo {
get { return SafeGetValue<System.DateTime?>("UnavailableTo");}
set { this["UnavailableTo"] = value;}
}

}
[Serializable]
public class msVolunteerAssignedType : msAggregateChild {
public new const string CLASS_NAME = "VolunteerAssignedType";
public new  static class FIELDS {
public const string Type = "Type";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string Status = "Status";
}
public msVolunteerAssignedType() : base() {
ClassType = "VolunteerAssignedType";
}
public msVolunteerAssignedType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerAssignedType FromClassMetadata(ClassMetadata meta){return new msVolunteerAssignedType(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.DateTime? StartDate {
get { return SafeGetValue<System.DateTime?>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime? EndDate {
get { return SafeGetValue<System.DateTime?>("EndDate");}
set { this["EndDate"] = value;}
}

public MemberSuite.SDK.Types.VolunteerScreeningStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.VolunteerScreeningStatus>("Status");}
set { this["Status"] = value;}
}

}
[Serializable]
public class msVolunteerAssignedLocation : msAggregateChild {
public new const string CLASS_NAME = "VolunteerAssignedLocation";
public new  static class FIELDS {
public const string Location = "Location";
}
public msVolunteerAssignedLocation() : base() {
ClassType = "VolunteerAssignedLocation";
}
public msVolunteerAssignedLocation( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerAssignedLocation FromClassMetadata(ClassMetadata meta){return new msVolunteerAssignedLocation(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Location {
get { return SafeGetValue<System.String>("Location");}
set { this["Location"] = value;}
}

}
[Serializable]
public class msVolunteerAvailability : msAggregateChild {
public new const string CLASS_NAME = "VolunteerAvailability";
public new  static class FIELDS {
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string DaysOfWeek = "DaysOfWeek";
public const string StartTime = "StartTime";
public const string EndTime = "EndTime";
}
public msVolunteerAvailability() : base() {
ClassType = "VolunteerAvailability";
}
public msVolunteerAvailability( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerAvailability FromClassMetadata(ClassMetadata meta){return new msVolunteerAvailability(MemberSuiteObject.FromClassMetadata(meta));}
public System.DateTime StartDate {
get { return SafeGetValue<System.DateTime>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime EndDate {
get { return SafeGetValue<System.DateTime>("EndDate");}
set { this["EndDate"] = value;}
}

public MemberSuite.SDK.Types.DaysOfWeek DaysOfWeek {
get { return SafeGetValue<MemberSuite.SDK.Types.DaysOfWeek>("DaysOfWeek");}
set { this["DaysOfWeek"] = value;}
}

public System.DateTime? StartTime {
get { return SafeGetValue<System.DateTime?>("StartTime");}
set { this["StartTime"] = value;}
}

public System.DateTime? EndTime {
get { return SafeGetValue<System.DateTime?>("EndTime");}
set { this["EndTime"] = value;}
}

}
[Serializable]
public class msVolunteerAward : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "VolunteerAward";
public new  static class FIELDS {
public const string Volunteer = "Volunteer";
public const string Type = "Type";
public const string DateAwarded = "DateAwarded";
public const string Comments = "Comments";
}
public msVolunteerAward() : base() {
ClassType = "VolunteerAward";
}
public msVolunteerAward( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerAward FromClassMetadata(ClassMetadata meta){return new msVolunteerAward(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Volunteer {
get { return SafeGetValue<System.String>("Volunteer");}
set { this["Volunteer"] = value;}
}

public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.DateTime DateAwarded {
get { return SafeGetValue<System.DateTime>("DateAwarded");}
set { this["DateAwarded"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

}
[Serializable]
public class msVolunteerAwardType : msConfigurableType {
public new const string CLASS_NAME = "VolunteerAwardType";
public new  static class FIELDS {
}
public msVolunteerAwardType() : base() {
ClassType = "VolunteerAwardType";
}
public msVolunteerAwardType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerAwardType FromClassMetadata(ClassMetadata meta){return new msVolunteerAwardType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msVolunteerDepartment : msConfigurableType {
public new const string CLASS_NAME = "VolunteerDepartment";
public new  static class FIELDS {
}
public msVolunteerDepartment() : base() {
ClassType = "VolunteerDepartment";
}
public msVolunteerDepartment( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerDepartment FromClassMetadata(ClassMetadata meta){return new msVolunteerDepartment(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msVolunteerFee : msProduct {
public new const string CLASS_NAME = "VolunteerFee";
public new  static class FIELDS {
}
public msVolunteerFee() : base() {
ClassType = "VolunteerFee";
SpecialPrices = new System.Collections.Generic.List<msSpecialPrice>();
PurchaseRestrictions = new System.Collections.Generic.List<msPurchaseRestriction>();
LinkedProducts = new System.Collections.Generic.List<msProductLinkage>();
LinkedEntitlements = new System.Collections.Generic.List<msLinkedEntitlement>();
RevenueSplits = new System.Collections.Generic.List<msRevenueSplit>();
CEUCredits = new System.Collections.Generic.List<msLinkedCEUCredit>();
}
public msVolunteerFee( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerFee FromClassMetadata(ClassMetadata meta){return new msVolunteerFee(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msVolunteerJob : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "VolunteerJob";
public new  static class FIELDS {
public const string VolunteerType = "VolunteerType";
public const string EstimatedHourlyValue = "EstimatedHourlyValue";
public const string Site = "Site";
public const string Traits = "Traits";
public const string Description = "Description";
}
public msVolunteerJob() : base() {
ClassType = "VolunteerJob";
Traits = new System.Collections.Generic.List<msVolunteerTrait>();
}
public msVolunteerJob( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerJob FromClassMetadata(ClassMetadata meta){return new msVolunteerJob(MemberSuiteObject.FromClassMetadata(meta));}
public System.String VolunteerType {
get { return SafeGetValue<System.String>("VolunteerType");}
set { this["VolunteerType"] = value;}
}

public System.Decimal EstimatedHourlyValue {
get { return SafeGetValue<System.Decimal>("EstimatedHourlyValue");}
set { this["EstimatedHourlyValue"] = value;}
}

public System.String Site {
get { return SafeGetValue<System.String>("Site");}
set { this["Site"] = value;}
}

public System.Collections.Generic.List<msVolunteerTrait> Traits {
get { return SafeGetValue<System.Collections.Generic.List<msVolunteerTrait>>("Traits");}
set { this["Traits"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msVolunteerJobAssignment : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "VolunteerJobAssignment";
public new  static class FIELDS {
public const string JobOccurrence = "JobOccurrence";
public const string Volunteer = "Volunteer";
public const string StartDateTime = "StartDateTime";
public const string EndDateTime = "EndDateTime";
public const string Comments = "Comments";
}
public msVolunteerJobAssignment() : base() {
ClassType = "VolunteerJobAssignment";
}
public msVolunteerJobAssignment( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerJobAssignment FromClassMetadata(ClassMetadata meta){return new msVolunteerJobAssignment(MemberSuiteObject.FromClassMetadata(meta));}
public System.String JobOccurrence {
get { return SafeGetValue<System.String>("JobOccurrence");}
set { this["JobOccurrence"] = value;}
}

public System.String Volunteer {
get { return SafeGetValue<System.String>("Volunteer");}
set { this["Volunteer"] = value;}
}

public System.DateTime StartDateTime {
get { return SafeGetValue<System.DateTime>("StartDateTime");}
set { this["StartDateTime"] = value;}
}

public System.DateTime EndDateTime {
get { return SafeGetValue<System.DateTime>("EndDateTime");}
set { this["EndDateTime"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

}
[Serializable]
public class msVolunteerJobOccurrence : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "VolunteerJobOccurrence";
public new  static class FIELDS {
public const string Job = "Job";
public const string Location = "Location";
public const string Site = "Site";
public const string Event = "Event";
public const string Department = "Department";
public const string Recurrence = "Recurrence";
public const string NumberOfVolunteersNeeded = "NumberOfVolunteersNeeded";
public const string EstimatedValue = "EstimatedValue";
public const string Comments = "Comments";
public const string IsActive = "IsActive";
public const string StartDateTime = "StartDateTime";
public const string EndDateTime = "EndDateTime";
}
public msVolunteerJobOccurrence() : base() {
ClassType = "VolunteerJobOccurrence";
}
public msVolunteerJobOccurrence( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerJobOccurrence FromClassMetadata(ClassMetadata meta){return new msVolunteerJobOccurrence(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Job {
get { return SafeGetValue<System.String>("Job");}
set { this["Job"] = value;}
}

public System.String Location {
get { return SafeGetValue<System.String>("Location");}
set { this["Location"] = value;}
}

public System.String Site {
get { return SafeGetValue<System.String>("Site");}
set { this["Site"] = value;}
}

public System.String Event {
get { return SafeGetValue<System.String>("Event");}
set { this["Event"] = value;}
}

public System.String Department {
get { return SafeGetValue<System.String>("Department");}
set { this["Department"] = value;}
}

public MemberSuite.SDK.Types.AutomatedProcessRecurrence Recurrence {
get { return SafeGetValue<MemberSuite.SDK.Types.AutomatedProcessRecurrence>("Recurrence");}
set { this["Recurrence"] = value;}
}

public System.Int32 NumberOfVolunteersNeeded {
get { return SafeGetValue<System.Int32>("NumberOfVolunteersNeeded");}
set { this["NumberOfVolunteersNeeded"] = value;}
}

public System.Decimal EstimatedValue {
get { return SafeGetValue<System.Decimal>("EstimatedValue");}
set { this["EstimatedValue"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

public System.Boolean IsActive {
get { return SafeGetValue<System.Boolean>("IsActive");}
set { this["IsActive"] = value;}
}

public System.DateTime StartDateTime {
get { return SafeGetValue<System.DateTime>("StartDateTime");}
set { this["StartDateTime"] = value;}
}

public System.DateTime EndDateTime {
get { return SafeGetValue<System.DateTime>("EndDateTime");}
set { this["EndDateTime"] = value;}
}

}
[Serializable]
public class msVolunteerLocation : msConfigurableType {
public new const string CLASS_NAME = "VolunteerLocation";
public new  static class FIELDS {
}
public msVolunteerLocation() : base() {
ClassType = "VolunteerLocation";
}
public msVolunteerLocation( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerLocation FromClassMetadata(ClassMetadata meta){return new msVolunteerLocation(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msVolunteerScreening : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "VolunteerScreening";
public new  static class FIELDS {
public const string Volunteer = "Volunteer";
public const string VolunteerType = "VolunteerType";
public const string Comments = "Comments";
public const string ScreeningPlan = "ScreeningPlan";
public const string Steps = "Steps";
public const string Status = "Status";
}
public msVolunteerScreening() : base() {
ClassType = "VolunteerScreening";
Steps = new System.Collections.Generic.List<msVolunteerScreeningStep>();
}
public msVolunteerScreening( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerScreening FromClassMetadata(ClassMetadata meta){return new msVolunteerScreening(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Volunteer {
get { return SafeGetValue<System.String>("Volunteer");}
set { this["Volunteer"] = value;}
}

public System.String VolunteerType {
get { return SafeGetValue<System.String>("VolunteerType");}
set { this["VolunteerType"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

public System.String ScreeningPlan {
get { return SafeGetValue<System.String>("ScreeningPlan");}
set { this["ScreeningPlan"] = value;}
}

public System.Collections.Generic.List<msVolunteerScreeningStep> Steps {
get { return SafeGetValue<System.Collections.Generic.List<msVolunteerScreeningStep>>("Steps");}
set { this["Steps"] = value;}
}

public MemberSuite.SDK.Types.VolunteerScreeningStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.VolunteerScreeningStatus>("Status");}
set { this["Status"] = value;}
}

}
[Serializable]
public class msVolunteerScreeningStep : msAggregateChild {
public new const string CLASS_NAME = "VolunteerScreeningStep";
public new  static class FIELDS {
public const string Action = "Action";
public const string Due = "Due";
public const string CompletedOn = "CompletedOn";
public const string Status = "Status";
public const string Comments = "Comments";
}
public msVolunteerScreeningStep() : base() {
ClassType = "VolunteerScreeningStep";
}
public msVolunteerScreeningStep( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerScreeningStep FromClassMetadata(ClassMetadata meta){return new msVolunteerScreeningStep(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Action {
get { return SafeGetValue<System.String>("Action");}
set { this["Action"] = value;}
}

public System.DateTime Due {
get { return SafeGetValue<System.DateTime>("Due");}
set { this["Due"] = value;}
}

public System.DateTime? CompletedOn {
get { return SafeGetValue<System.DateTime?>("CompletedOn");}
set { this["CompletedOn"] = value;}
}

public MemberSuite.SDK.Types.VolunteerScreeningStatus Status {
get { return SafeGetValue<MemberSuite.SDK.Types.VolunteerScreeningStatus>("Status");}
set { this["Status"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

}
[Serializable]
public class msVolunteerScreeningPlan : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "VolunteerScreeningPlan";
public new  static class FIELDS {
public const string Description = "Description";
public const string Steps = "Steps";
}
public msVolunteerScreeningPlan() : base() {
ClassType = "VolunteerScreeningPlan";
Steps = new System.Collections.Generic.List<msVolunteerScreeningPlanStep>();
}
public msVolunteerScreeningPlan( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerScreeningPlan FromClassMetadata(ClassMetadata meta){return new msVolunteerScreeningPlan(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.Collections.Generic.List<msVolunteerScreeningPlanStep> Steps {
get { return SafeGetValue<System.Collections.Generic.List<msVolunteerScreeningPlanStep>>("Steps");}
set { this["Steps"] = value;}
}

}
[Serializable]
public class msVolunteerScreeningPlanStep : msAggregateChild {
public new const string CLASS_NAME = "VolunteerScreeningPlanStep";
public new  static class FIELDS {
public const string Action = "Action";
public const string DaysToComplete = "DaysToComplete";
public const string Description = "Description";
}
public msVolunteerScreeningPlanStep() : base() {
ClassType = "VolunteerScreeningPlanStep";
}
public msVolunteerScreeningPlanStep( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerScreeningPlanStep FromClassMetadata(ClassMetadata meta){return new msVolunteerScreeningPlanStep(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Action {
get { return SafeGetValue<System.String>("Action");}
set { this["Action"] = value;}
}

public System.Int32 DaysToComplete {
get { return SafeGetValue<System.Int32>("DaysToComplete");}
set { this["DaysToComplete"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

}
[Serializable]
public class msVolunteerSite : msConfigurableType {
public new const string CLASS_NAME = "VolunteerSite";
public new  static class FIELDS {
}
public msVolunteerSite() : base() {
ClassType = "VolunteerSite";
}
public msVolunteerSite( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerSite FromClassMetadata(ClassMetadata meta){return new msVolunteerSite(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msVolunteerTimesheet : msLocallyIdentifiableAssociationDomainObject {
public new const string CLASS_NAME = "VolunteerTimesheet";
public new  static class FIELDS {
public const string JobAssignment = "JobAssignment";
public const string HoursWorked = "HoursWorked";
public const string StartDate = "StartDate";
public const string EndDate = "EndDate";
public const string Comments = "Comments";
}
public msVolunteerTimesheet() : base() {
ClassType = "VolunteerTimesheet";
}
public msVolunteerTimesheet( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerTimesheet FromClassMetadata(ClassMetadata meta){return new msVolunteerTimesheet(MemberSuiteObject.FromClassMetadata(meta));}
public System.String JobAssignment {
get { return SafeGetValue<System.String>("JobAssignment");}
set { this["JobAssignment"] = value;}
}

public System.Decimal HoursWorked {
get { return SafeGetValue<System.Decimal>("HoursWorked");}
set { this["HoursWorked"] = value;}
}

public System.DateTime StartDate {
get { return SafeGetValue<System.DateTime>("StartDate");}
set { this["StartDate"] = value;}
}

public System.DateTime EndDate {
get { return SafeGetValue<System.DateTime>("EndDate");}
set { this["EndDate"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

}
[Serializable]
public class msVolunteerTrait : msAggregateChild {
public new const string CLASS_NAME = "VolunteerTrait";
public new  static class FIELDS {
public const string Type = "Type";
public const string FirstSubType = "FirstSubType";
public const string SecondSubType = "SecondSubType";
public const string TextValue = "TextValue";
public const string Comments = "Comments";
public const string ExpiresOn = "ExpiresOn";
public const string Verified = "Verified";
}
public msVolunteerTrait() : base() {
ClassType = "VolunteerTrait";
}
public msVolunteerTrait( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerTrait FromClassMetadata(ClassMetadata meta){return new msVolunteerTrait(MemberSuiteObject.FromClassMetadata(meta));}
public System.String Type {
get { return SafeGetValue<System.String>("Type");}
set { this["Type"] = value;}
}

public System.String FirstSubType {
get { return SafeGetValue<System.String>("FirstSubType");}
set { this["FirstSubType"] = value;}
}

public System.String SecondSubType {
get { return SafeGetValue<System.String>("SecondSubType");}
set { this["SecondSubType"] = value;}
}

public System.String TextValue {
get { return SafeGetValue<System.String>("TextValue");}
set { this["TextValue"] = value;}
}

public System.String Comments {
get { return SafeGetValue<System.String>("Comments");}
set { this["Comments"] = value;}
}

public System.DateTime? ExpiresOn {
get { return SafeGetValue<System.DateTime?>("ExpiresOn");}
set { this["ExpiresOn"] = value;}
}

public System.Boolean Verified {
get { return SafeGetValue<System.Boolean>("Verified");}
set { this["Verified"] = value;}
}

}
[Serializable]
public class msVolunteerTraitSubType : msConfigurationAssociationDomainObject {
public new const string CLASS_NAME = "VolunteerTraitSubType";
public new  static class FIELDS {
public const string TraitType = "TraitType";
public const string Description = "Description";
public const string Code = "Code";
public const string DisplayOrder = "DisplayOrder";
}
public msVolunteerTraitSubType() : base() {
ClassType = "VolunteerTraitSubType";
}
public msVolunteerTraitSubType( MemberSuiteObject msObj) : base(msObj) {}
public System.String TraitType {
get { return SafeGetValue<System.String>("TraitType");}
set { this["TraitType"] = value;}
}

public System.String Description {
get { return SafeGetValue<System.String>("Description");}
set { this["Description"] = value;}
}

public System.String Code {
get { return SafeGetValue<System.String>("Code");}
set { this["Code"] = value;}
}

public System.Int32? DisplayOrder {
get { return SafeGetValue<System.Int32?>("DisplayOrder");}
set { this["DisplayOrder"] = value;}
}

}
[Serializable]
public class msVolunteerTraitFirstSubType : msVolunteerTraitSubType {
public new const string CLASS_NAME = "VolunteerTraitFirstSubType";
public new  static class FIELDS {
}
public msVolunteerTraitFirstSubType() : base() {
ClassType = "VolunteerTraitFirstSubType";
}
public msVolunteerTraitFirstSubType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerTraitFirstSubType FromClassMetadata(ClassMetadata meta){return new msVolunteerTraitFirstSubType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msVolunteerTraitSecondSubType : msVolunteerTraitSubType {
public new const string CLASS_NAME = "VolunteerTraitSecondSubType";
public new  static class FIELDS {
}
public msVolunteerTraitSecondSubType() : base() {
ClassType = "VolunteerTraitSecondSubType";
}
public msVolunteerTraitSecondSubType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerTraitSecondSubType FromClassMetadata(ClassMetadata meta){return new msVolunteerTraitSecondSubType(MemberSuiteObject.FromClassMetadata(meta));}
}
[Serializable]
public class msVolunteerTraitType : msConfigurableType {
public new const string CLASS_NAME = "VolunteerTraitType";
public new  static class FIELDS {
public const string NamePlural = "NamePlural";
public const string FirstSubTypeName = "FirstSubTypeName";
public const string SecondSubTypeName = "SecondSubTypeName";
public const string FreeTextName = "FreeTextName";
public const string MatchMode = "MatchMode";
}
public msVolunteerTraitType() : base() {
ClassType = "VolunteerTraitType";
}
public msVolunteerTraitType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerTraitType FromClassMetadata(ClassMetadata meta){return new msVolunteerTraitType(MemberSuiteObject.FromClassMetadata(meta));}
public System.String NamePlural {
get { return SafeGetValue<System.String>("NamePlural");}
set { this["NamePlural"] = value;}
}

public System.String FirstSubTypeName {
get { return SafeGetValue<System.String>("FirstSubTypeName");}
set { this["FirstSubTypeName"] = value;}
}

public System.String SecondSubTypeName {
get { return SafeGetValue<System.String>("SecondSubTypeName");}
set { this["SecondSubTypeName"] = value;}
}

public System.String FreeTextName {
get { return SafeGetValue<System.String>("FreeTextName");}
set { this["FreeTextName"] = value;}
}

public MemberSuite.SDK.Types.VolunteerTraitMatchMode MatchMode {
get { return SafeGetValue<MemberSuite.SDK.Types.VolunteerTraitMatchMode>("MatchMode");}
set { this["MatchMode"] = value;}
}

}
[Serializable]
public class msVolunteerType : msConfigurableType {
public new const string CLASS_NAME = "VolunteerType";
public new  static class FIELDS {
public const string ScreeningPlan = "ScreeningPlan";
}
public msVolunteerType() : base() {
ClassType = "VolunteerType";
}
public msVolunteerType( MemberSuiteObject msObj) : base(msObj) {}
 public static new msVolunteerType FromClassMetadata(ClassMetadata meta){return new msVolunteerType(MemberSuiteObject.FromClassMetadata(meta));}
public System.String ScreeningPlan {
get { return SafeGetValue<System.String>("ScreeningPlan");}
set { this["ScreeningPlan"] = value;}
}

}
}
