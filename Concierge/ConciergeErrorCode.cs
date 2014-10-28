    namespace MemberSuite.SDK.Concierge
{
    public enum ConciergeErrorCode
    {
        // general errors
        GeneralException,
        SessionExpired,
        InvalidAccessKey,
        UnableToLocateMetadata,
        TimestampMismatch,
        RecordNotCreateable,
        RecordNotFound,
        LanguageNotSupported,

        // Login Errors
        LoginInvalid,
        UserAccountInactive,

        /* Database Errors */
        CannotDeleteLockedRecord,
        ObjectInvalid,
        InvalidQuery,
        CannotRunSearch,

        IllegalParameter,
        AccessDenied,
        RecordAlreadyExists,
        IllegalOperation,
        CreditCardAuthorizationFailed,
        SetupRequired,
        NotLoggedInToAnAssociation,
        ProductSoldOut,
        TrialExpired,
        LicenseViolation,
        DiscountCodeNotAuthorized,
        DiscountCodeUsageLimitExceeded,
        MSQLSyntaxError,
        SimulatedException,
        PaymentDeclined
    }
}