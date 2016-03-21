namespace MemberSuite.SDK.Types
{
    public enum BatchStatus
    {
        Open = 0,
        Closed = 10,
        Verified = 20,
        Posting = 25,
        Posted = 30,
        Error = 35,
        Archived = 40
    }

    public enum BatchType
    {
        Regular = 0,
        Recurring = 3,
        DeferredRevenue = 5,
        COGS = 10,
        Billing = 15,
        Reconciliation = 20,
        HistoricalDeferral = 25 
    }
}