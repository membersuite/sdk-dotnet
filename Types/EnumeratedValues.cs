using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemberSuite.SDK.Types
{
    public enum AccountingMethod
    {
        Cash = 0,
        Accrual = 10
    }

    public enum AssociationMode
    {
        Normal = 0,

        Sandbox = 5 
         
    }

    public enum AssociationStatus
    {
        Active = 0, 

        Provisioning = 5,

        Moving = 10,

        FinalizingMove = 15,

        Disabled = 30
    }

    public enum TaxCalculationMode
    {
        ByShippingAddress = 0,
        ByEventAddress = 5
    }
    public enum AuditLogType
    {
        RecordCreated = 0,
        RecordUpdated = 1,
        RecordDeleted = 2,
        RecordViewed = 3,
        Error = 4,
        Login = 5,
        Logout = 6,

        /*Membership*/
        MembershipCreated=10,
        MembershipRenewed=11,
        MembershipDropped=12,
        Information = 14,
        OrderFailure = 16,
        OrderSuccess = 18,
        RegistrationTransfer = 20,
        RegistrationSubstitution = 30
        
    }

    public enum CommitteeMembershipType
    {
        Member,
        Nominated,
        Applied
    }

    public enum DiscountCodeApplication
    {
        EntireOrder = 0,
        SpecificProductsOnly = 10
    }

  

    public enum DisplayTarget
    {

        SameWindow = 0,


        NewWindow = 1,


        IFrame = 2
    }

    public enum EventRegistrationMode
    {
        Normal=0,
        Ticketed = 1,
        Disabled = 2
        
    }

    public enum ExpirationType
    {
        Calendar,
        Anniversary//,
       // Custom // Cron Expression
    }
 

    public enum ExtensionServiceTransport
    {
        Soap = 0



    }

    public enum FieldType
    {
        BuiltIn = 0,

        Custom = 1,

        Generated = 2
    }

    public enum OrderLineItemType
    {
        Regular = 0,
        PackageContents = 10,
        Taxes = 20,
        Shipping = 30,
        Discount = 40
    }

    public enum ProductLinkageType
    {
        //Upsell = 0,
         
        //Replacement = 10,
        Complementary = 15,
        Bundled = 20,
        CrossSell = 30
    }

    public enum IntegrationLinkTargetType
    {

        Home = 0,


        Data360View = 10,

        Tab = 20

    }

    [Flags]
    public enum TriggerType
    {
        RecordCreated = 1,

        RecordUpdated = 2,

        RecordDeleted = 4,

        InvoiceCreated = 8,

        PaymentProcessed = 16,

        OrderCreated = 32
    }

    public enum PackagedProductPricingMethod
    {

        Fixed = 0,
        Percentage = 5
    }

    public enum SourceCodeType
    {
        Credit = 0,
        Customer = 1,
        Event = 2,
        Invoice = 3,
        Payment = 4,
        Membership = 5
    }

    public enum InvoiceAdjustmentPaymentAction
    {
        
        Void,
        IssueCredit,
        RefundToCard
    }


    public enum ShippingCarrier
    {
        USPS = 0,
        FedEx = 5,
        UPS = 10,
        DHL = 15,
        Other = 50
    }

    public enum FinancialSoftwarePackage
    {
        None = 0,
        GreatPlains = 5,
        QuickBooks = 10,
        Peachtree = 15,
        Adagio = 20,
        QuickBooksOnlineEdition = 12,
        SageBusinessWorks = 25,
        Other = 99,
        
    }

    public enum BatchDownloadMethod
    {
        Summary = 0,
        Detail = 5
    }

    public enum CustomerType
    {
        Both = 0,
        Individual = 5,
        Organization = 10
    }

    public enum ActivationTerms
    {
        InvoicePaidInFull = 0,
        Immediately = 5,
        PercentPaid = 10,
    }

    public enum ChapterMode
    {
        ChaptersDisabled,
        MemberJoinsOneChapter,
        MemberCanJoinMultipleChapters
    }

    public enum SectionMode
    {
        SectionsDisabled,
        MemberCanJoinMultipleSections
    }

    public enum JobStatus
    {
        Open = 0,
        Draft = 3,
        Processing = 5,
        Error = 10,
        Complete = 15
    }

    public enum EventLocationRoomCategory
    {
        Meeting = 0,
        Housing = 5
    }

    public enum CustomFieldType
    {
        Field = 0,
        EventRegistration = 5,
        Competition = 10,
        Product = 15
        
    }

    public enum GiftType
    {
        Prepaid = 0,
        Cash = 3,
        MatchingCash = 4,
        Pledge = 6,
        MatchingPledge =  7,
        StockProperty=9,
        InKind=12,
        Other=15,
        Recurring=18,
        Planned=21,
        PledgePayment = 24,
        RecurringGiftPayment = 26,
        SoftGift = 29,
        Adjustment = 32
    }

    public enum GiftStatus
    {
        Completed = 0,
        Active = 5,
        Held = 10,
        Terminated = 15
    }

    /// <summary>
    /// Determines whether a field can be edited or seen in the portal
    /// </summary>
    public enum PortalAccessibility
    {
        /// <summary>
        /// 
        /// </summary>
        Full = 0,
        /// <summary>
        /// 
        /// </summary>
        ReadOnly = 1,
        /// <summary>
        /// 
        /// </summary>
        None = 2
    }

    public enum ResumeCollectionMode
    {
        DoNotAskForResume = 0,

        Optional = 5,

        Required = 10
    }

    public enum HistoricalTransactionType
    {

        Invoice = 0,
        Payment = 2,
        Order = 4,
        Credit = 6,
        Refund = 8,
        Return = 10
    }

    public enum BillingScheduleStatus
    {
        Active = 0,
        Suspended = 5,
        Completed = 10,
        Cancelled = 15,
        Error = 20
    }

    public enum JobPostingAccess
    {
        MembersOnly = 0,
        AnyRegisteredUser = 5,
        PublicAccess = 10,
    }


    public enum CertificationProgramType
    {
        Application = 0,
        Certification = 5,
        Recertification = 10
    }

    public enum JudgeScoreVisibilityMode
    {
        Never = 0,
        OnceSubmitted = 5,
        Always = 10
    }

    public enum PortalLinkType
    {
        Html = 0,
        Event = 5,
        Competition = 10,
        Link = 15
    }

    public enum RecurringProductAvailabilityType
    {
        Both = 0,
        NewMembers = 5,
        RenewingMembers = 10
    }
    public enum DuesBillingType
    {
        Membership = 0
    }

    public enum DuesCycleBatchMemberType
    {
        Initial = 0,
        Rebill = 5,
        FirstReminder = 10,
        SecondReminder = 15
    }

    public enum WriteOffMethod
    {
        Allowance = 0,
        Direct = 5
    }

    public enum SubLedgerEntryItemType
    {
        Unknown = 0,
        AccountsReceivable = 1,
        Revenue = 2,
        DeferredRevenue = 3,
        DueToDueFrom = 4,
        Cash = 5,
        InvoicePayment = 6,
        Overpayment = 7,
        CreditUsage = 8,
        CreditExpense = 9,
        CreditLiability = 10,
        WriteOffExpense = 11,
        GiftDebit = 12,
        GiftCredit = 13,
        COGSExpense = 14,
        Inventory = 15
    }

    public enum OpportunityStageType
    {
        Open = 0,
        ClosedWon = 5,
        ClosedLost = 10,
        ClosedNoDecision = 15

    }

    public enum GiftReceiptStatus
    {
        NotReceipted = 0,
        Receipted = 5,
        DoNotReceipt=10
    }

    public enum GiftAcknowledgmentStatus
    {
        NotAcknowledged = 0,
        Acknowledged = 5,
        DoNotAcknowledge = 10
    }

    public enum ExhibitorRegistrationMode
    {
        PurchaseBoothsByNumber = 0,
        PurchaseBoothsByType = 5,
        IndicateBoothPreferencesOnly = 10
    }

    public enum COGSPolicy
    {
        DoNotCalculateCOGS = 0,
        FirstInFirstOut = 5,
        LastInFirstOut = 10,
        WeightedAverage = 15
    }

    public enum ChapterPostalCodeMappingMode
    {
        Disabled = 0,
        Suggest,
        Assign
    }

    public enum SubscriptionFulfillmentStatus
    {
        Fulfilled = 0,
        AddressError = 5,
        NameError = 7,
        Held = 10
    }

    public enum GenericJobType
    {
        SubscriptionFulfillment = 0,
        SubscriptionRenewal = 1,
        //AssignEntitlements = 2
    }

    public enum VolunteerScreeningStatus
    {
        Pending = 0,
        Completed = 5,
        Failed = 10
    }


    public enum VolunteerTypeAssignmentStatus
    {
        Active = 0,
        Pending = 5,
        Unapproved = 10
    }

    [Flags]
    public enum DaysOfWeek
    {
        // CRITICAL that these are set to powers of two,
        // since we use them for multiple bindings
        Sunday = 1,
        Monday = 2,
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        Saturday = 64
    }

    public enum VolunteerTraitMatchMode
    {
        Required = 0,
        Optional = 5,
        Inverted = 10
    }

    public enum FileFolderType
    {
        Private = 0,
        Public = 5
    }

    public enum CustomObjectPortalFormAccessMode
    {
        ReviewOnly = 0,
        ReviewAndEdit = 5,
        ReviewEditAndDelete = 7,
        NoAccess = 10
    }

    public enum DiscussionPostStatus
    {
        Approved = 0,
        Pending = 5,
        Rejected = 10
    }

    public enum CertificationsSelfReportingMode
    {
        Disabled = 0,
        AllowUnverified = 5,
        AllowVerified = 10   // Meaning when they submit, it's verified
    }


    public enum RecommendationStatus
    {
        Pending = 0,
        InProgress = 5,
        Completed = 10,
        Declined = 15
    }

    public enum CustomerStatus
    {
        Active = 0,
        BillingSuspension = 5,
        Cancelled = 20
    }

    public enum ConsolePortalOptions
    {
        Never = 0,
        Console = 1,
        Portal = 2,
        Both
    }

}
