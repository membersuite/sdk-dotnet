using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemberSuite.SDK.Constants
{
    public static class EmailTemplates
    {
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
            public const string RenewalInvoice = "BuiltIn:RenewalInvoice";
            public const string MembershipRenewalComplete = "BuiltIn:MembershipRenewalComplete";
        }

        public static class Subscriptions
        {
            public const string RenewalInvoice = "BuiltIn:SubscriptionRenewalInvoice";

        }

        public static class Events
        {
            public const string Confirmation = "BuiltIn:RegistrationConfirmation";
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
    }
}
