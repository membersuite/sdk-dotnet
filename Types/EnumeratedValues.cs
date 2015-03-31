using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemberSuite.SDK.Types
{
    public enum AccountingMethod
    {
        
        Accrual = 10,
        Cash = 20
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

        Disabled = 30,

        Error = 40,

        QueuedForProvisioning = 50
    }

    //public enum IsolationLevel
    //{
    //    Serializable = 0,
    //    ReadCommitted = 5,
    //    ReadUncommitted = 10,
    //    RepeatableRead = 15
    //}

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
        ForcedLogout = 7,
        
        Renewal=11,
        Drop=12,
        Information = 14,
        OrderFailure = 16,
        OrderSuccess = 18,
        RegistrationTransfer = 20,
        RegistrationSubstitution = 30,
        PasswordReset = 35
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
        Disabled = 2,
        Tabled = 10
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

    public enum FinancialSoftwarePackage
    {
        None = 0,
        GreatPlains = 5,
        QuickBooks = 10,
        Peachtree = 15,
        Adagio = 20,
        QuickBooksOnlineEdition = 12,
        SageBusinessWorks = 25,
        Mas90 = 30,
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
        Complete = 15,
        Queued = 20
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
        SecurityHold = 10,
        Cancelled = 20
    }

    public enum ConsolePortalOptions
    {
        Never = 0,
        Console = 1,
        Portal = 2,
        Both
    }

    public enum IndexedQuickSearchUsage
    {
        Never = 0,
        QuickSearchesOnly = 5
       // EverywhereInTheConsole = 10
        //EverywhereInTheConsoleAndPortal = 15
        
    }

    public enum TermType
    {
        Days = 0,
        
        Months = 2,
        Years = 3
    }

    public enum SubscriptionFeeType
    {
        InitiateSubscription = 0,
        RenewSubscription = 5
    }

     public enum BillingRunMemberStatus
    {
        Pending = 0,
        Completed = 5,
        Error = 10,
        Unbilled = 15
    }

    public enum BillingRunCandidateType
    {
        InitialBill = 0,
        FirstReminder = 1,
        SecondReminder = 2,
        ThirdReminder = 3,
        Drop = 10
    }

    public enum BillingCycleProductAction
    {
        Include = 0,
        Exclude = 5
    }

    public enum BillingRunStatus
    {
        Pending = 0,
        CandidateSelection = 10,
        MemberGeneration = 20,
        MemberProcessing = 30,
        PendingActivityReview = 35,
        QeuedActivityExecution = 40,
        PendingQueuedActivityReview = 45,
        SendingEmails = 50,
        Complete = 60,
        Error = 70,
        Cancelled = 80
        
    }

    public enum BillingRunMode
    {
        Preview = 0,

        GenerateOrders = 5,

        CompleteRun = 10
    }


    public enum SavedPaymentMethodType
    {
        // means that the payment method is available for reuse
        Stored = 0,

        // for payment methods tied to orders
        Order = 5,

        Gift = 10,

        Membership = 15,

        Subscription = 20,

        Certification = 25
    }

    public enum BillingRunActivityType
    {
        ProcessOrder = 0,
        SendEmail = 5,
        DropRecord = 10,
        ChangeStatus = 15,
        FailedProcessing = 20
    }

    public enum DataExportFormat
    {
        Raw = 0,
        CsvWithHeaders = 5,
        CsvWithoutHeaders = 10
        
    }

    public enum JobPostingStatus
    {
        Pending = 0,
        Approved = 5,
        OnHold = 10,
        Rejected = 15,

        
    }

    public enum RealtorSubscriptionFeeType
    {
        MLS = 0,
        LMS = 5,
        eKey = 10,
        aKey = 15,
        aKeyInsurance = 20
    }

    public enum eKeyProviderType
    {
        Supra = 0
    }

    public enum ListingSubscriptionProviderType
    {
        Matrix = 0
    }

    public enum RealtorProductCategory
    {
        None = 0,
        NationalDues = 3,
        ImageAwarenessAssessment = 5,
        StateDues = 10,
        LegalFund=15,
        RPACContribution = 20,
        LocalDues = 25
    }

    public enum RealtorRelationshipDesignation
    {
        None = 0,

        // represents a relationship between a head broker and an office
        // Left Side = Indiv, Right Side = Org
        BrokerOffice = 5,

        // Left Side = Org, Right Side = Org
        OfficeBranch = 10,

        // Left Side = Indiv, Right Side = Indiv
        OfficeAgent = 15,

        // Left Side = Indiv, Right Side = Indiv
        AgentAssistant = 20
    }

    public enum EngagementCyclePeriodicity
    {
        Annual = 0,
        Quarterly = 5,
        BiAnnual = 10,
        Monthly = 15
    }

    public enum TenantLevel
    {
        System,
        Reseller,
        Customer,
        Association
    }

    public enum SavePaymentMethodSetting
    {
        Checked = 0,
        Unchecked = 1,
        Disabled =2
    }

    public enum NRDSAssociationStatus
    {
        A,
        I,
        D,
        C,
    }
    
    public enum NRDSAssociationType
    {
        L,   // Local
        S,   // State
        N,   //
        A,   //
        M,   // MLS

        // TODO Why is 'I' allowed in the nrds.dtd but not in Client.jar?
        ////I,
    }

    /// <summary>
    /// Used to describe the nature of a payment or status of a pledge
    /// </summary>            
    public enum NRDSDemographicPaymentCodeType
    {
        C,   // Commitment made but no payment to date                
        D,   // Deposit                
        F,  // Paid in full (as with a sponsorship or pledge)                
        P,  // Partial Payment
    }

    /// <summary>
    /// How the course was delivered
    /// </summary>
    public enum NRDSEducationDeliveryMethodType
    {
        AUDIO,   // Audio tape
        CDROM,   // Interactive Computer based
        CLASS,  // Live classroom
        ONLINE, // Online course via the Internet
        VIDCON, // Live Teleconference
        VIDEO,  // Pre-recorded video tape
    }

    /// <summary>
    /// The nature of the payment
    /// </summary>
    public enum NRDSEducationPaymentCodeType
    {
        B,   // Balance of Payment due
        D,   // Deposit
        F,  // Full Fee
        L,  // Late Fee
        P,  // Partial Payment
    }

    /// <summary>
    /// Where the member prefers test results to be sent
    /// </summary>
    public enum NRDSEducationTestMailingAddressType
    {
        H,   // Home Address
        O,   // Office Address
        M,  // Mailing address
    }

    public enum NRDSEducationTestStatus
    {
        P,  // Pass
        F,  // Fail
    }

    /// <summary>
    /// Used for PAC contributions only
    /// </summary>
    public enum NRDSFinancialContributionType
    {
        P,  // Personal
        C,  // Corporate
    }

    /// <summary>
    /// The source of this transaction. The code EC is reserved for Financial records that are 
    /// filled in automatically by the NAR EC Invoicing module. All other records should have 
    /// XT in this field.
    /// </summary>
    public enum NRDSFinancialSource
    {
        EC,
        XT,
    }

    public enum NRDSMemberGender
    {
        F,  // Female
        M,  // Male
    }

    /// <summary>
    /// Where the member prefers to receive faxes
    /// </summary>
    public enum NRDSMemberPreferredFax
    {
        H,  // Home/personal fax number
        O,  // Office fax number
    }

    /// <summary>
    /// Where the member would prefer to receive mail
    /// </summary>
    public enum NRDSMemberAddressType
    {
        H,  // Home address
        O,  // Office address
        M,  // Mail address
        F,  // Office address - mailing
    }

    /// <summary>
    /// Member’s preferred phone
    /// </summary>
    public enum NRDSMemberPreferredPhone
    {
        O,  // Office phone number
        H,  // Home phone number
        P,  // Pager number
        C,  // Cell phone number
    }

    /// <summary>
    /// Member status
    /// </summary>
    public enum NRDSMemberStatus
    {
        A,  // Active
        I,  // Inactive
        T,  // Terminated
        P,  // Provisional
        S,  // Suspend (only available 1/1 - 3/1 every 4 years)
        X,  // Deceased
    }

    /// <summary>
    /// Member status
    /// </summary>
    public enum NRDSMemberSupplementalStatus
    {
        A,   // Active
        I,   // Inactive
        T,  // Terminated
    }

    /// <summary>
    /// Type of membership
    /// </summary>
    public enum NRDSMemberType
    {
        R,      // Realtor
        RA,     // Realtor-Associate
        I,      // Institute Affiliate Member
        AFF,    // Affiliate of association
        N,      // Non-member salesperson in Realtor Broker's assessment
        S,      // Association staff person
    }

    /// <summary>
    /// Code to indicate the office branch location
    /// </summary>
    public enum NRDSOfficeBranchType
    {
        M,   // Main office
        B,   // Branch Office
        S,   // Single office - no branch locations
    }

    /// <summary>
    /// Status of the office record
    /// </summary>
    public enum NRDSOfficeStatus
    {
        A,   // Active
        I,   // Inactive
        T,   // Terminated
    }

    public enum NRDSPrimaryIndicator
    {
        P,  // Primary
        S   // Secondary
    }

    public enum RealtorSubscriptionType
    {
        Primary = 0,
        Coop = 5
    }
}

      
