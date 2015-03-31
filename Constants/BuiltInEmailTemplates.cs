namespace MemberSuite.SDK.Constants
{
    public static class EmailTemplates
    {
        public static class Awards
        {
            public const string CompetitionEntrySubmissionConfirmation =
                "BuiltIn:CompetitionEntrySubmissionConfirmation";
        }

        public static class CRM
        {
            public const string Welcome = "BuiltIn:Welcome";
            public const string UserInformationUpdate = "BuiltIn:UserInformationUpdate";
        }

        public static class Financial
        {
            public const string Invoice = "BuiltIn:Invoice";
            public const string Payment = "BuiltIn:Payment";
            public const string RefundRequest = "BuiltIn:RefundRequest";

            public const string BillingScheduleInvoiceOnly = "BuiltIn:BillingSchedule_InvoiceOnly";
            public const string BillingScheduleInvoiceAndPayment = "BuiltIn:BillingSchedule_InvoiceAndPayment";
            public const string BillingScheduleInvoiceAndFailedPayment = "BuiltIn:BillingSchedule_InvoiceAndFailedPayment";
        }

        public static class Committees
        {
            public const string OpenCommitteeWelcome = "BuiltIn:OpenCommitteeWelcome";
        }

        public static class Membership
        {
            public const string NewMember = "BuiltIn:NewMember";
            public const string RenewingMember = "BuiltIn:RenewingMember";
            
            public const string MembershipRenewalComplete = "BuiltIn:MembershipRenewalComplete";

            public const string RenewalInvoice = "BuiltIn:RenewalInvoice";

            public const string InitialBilling = "BuiltIn:MembershipInitialBillingNotice";
            public const string FirstReminder = "BuiltIn:MembershipFirstReminder";
            public const string SecondReminder = "BuiltIn:MembershipSecondReminder";
            public const string ThirdReminder = "BuiltIn:MembershipThirdReminder";
            public const string DropNotice = "BuiltIn:MembershipDropNotice";
        }

        public static class Subscriptions
        {
            public const string InitialBilling = "BuiltIn:SubscriptionInitialBillingNotice";
            public const string RenewalInvoice = "BuiltIn:SubscriptionRenewalInvoice";
            public const string FirstReminder = "BuiltIn:SubscriptionFirstReminder";
            public const string SecondReminder = "BuiltIn:SubscriptionSecondReminder";
            public const string ThirdReminder = "BuiltIn:SubscriptionThirdReminder";
            public const string DropNotice = "BuiltIn:SubscriptionDropNotice";
        }

        public static class Events
        {
            public const string AbstractSubmission = "BuiltIn:AbstractSubmission";
            public const string Confirmation = "BuiltIn:RegistrationConfirmation";
            public const string WaitList = "BuiltIn:WaitListConfirmation";
        }

        public static class Orders
        {
            public const string OrderConfirmation = "BuiltIn:OrderConfirmation";
            public const string OrderFailure = "BuiltIn:OrderFailure";
        }

        public static class Security
        {
            public const string ResetPortalPassword = "BuiltIn:ResetPortalPassword";
            public const string WelcomePortalUser = "BuiltIn:WelcomePortalUser";
        }


        public static class Fundraising
        {
            public const string DonorThankYou = "BuiltIn:DonorThankYou";
            public const string RecurringGiftSuccess = "BuiltIn:RecurringGiftSuccess";
            public const string RecurringGiftFailure = "BuiltIn:RecurringGiftFailure";
        }

        public static class CareerCenter
        {
            public const string JobPostingResumeSubmission = "BuiltIn:JobPostingResumeSubmission";
            public const string JobPosted = "BuiltIn:JobPosted";
        }

        public static class Sales
        {
            public const string AccountAssignment = "BuiltIn:AccountAssignment";
            public const string LeadAssignment = "BuiltIn:LeadAssignment";
        }

        public static class Volunteers
        {
            public const string JobAssignmentNotification = "BuiltIn:JobAssignmentNotification";
        }

        public static class Certifications
        {
            public const string CertificationRecommendation = "BuiltIn:CertificationRecommendation";
        }

        public static class Discussions
        {
            public const string DiscussionPostApproval = "BuiltIn:DiscussionPostApproval";
            public const string DiscussionPostRejection = "BuiltIn:DiscussionPostRejection";
            public const string DiscussionTopicSubscription = "BuiltIn:DiscussionTopicSubscription";
        }
    }
}
