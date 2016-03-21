namespace MemberSuite.SDK.Concierge
{
    public struct ConciergeClaimTypes
    {
        //Claims
        public const string ApiSessionClaimType = "http://api.membersuite.com/security/claim/apisession";
        public const string AssociationClaimType = "http://api.membersuite.com/security/claims/association";
        public const string CustomerClaimType = "http://api.membersuite.com/security/claims/customer";
        public const string AccessKeyClaimType = "http://api.membersuite.com/security/claims/accesskey";
        public const string ApiUserClaimType = "http://api.membersuite.com/security/claims/apiuser";
        public const string UserTypeClaimType = "http://api.membersuite.com/security/claims/usertype";
        public const string ConsoleUserClaimType = "http://api.membersuite.com/security/claims/consoleuser";
        public const string PortalUserClaimType = "http://api.membersuite.com/security/claims/portaluser";
        public const string PortalEntityClaimType = "http://api.membersuite.com/security/claims/portalentity";
        public const string RoleClaimType = "http://api.membersuite.com/security/claims/role";
        public const string BrowserClaimType = "http://api.membersuite.com/security/claims/browser";
        //Rights
        public const string ApiUserRight = "http://api.membersuite.com/security/rights/apiuser";
    }
}