namespace MemberSuite.SDK.Types
{
    public enum TaskStatus
    {
        NotStarted = 0,
        InProgress = 5,
        Completed = 10,
        WaitingOnSomeoneElse = 15,
        Deferred = 20
    }
}