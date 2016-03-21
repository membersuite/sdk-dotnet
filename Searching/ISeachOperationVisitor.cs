using MemberSuite.SDK.Searching.Operations;

namespace MemberSuite.SDK.Searching
{
    public interface ISearchObjectVisitor
    {
        void Visit(SearchOperationGroup group);
        void Visit(Equals expr);
        void Visit(Keyword expr);
        void Visit(SpecialOperation expr);
        void Visit(Contains contains);
        void Visit(StartsWith startsWith);
        void Visit(EndsWith endsWith);
        void Visit(IsBlank isBlank);
        void Visit(IsGreaterThan isGreaterThan);
        void Visit(IsGreaterThanOrEqualTo isGreaterThanOrEqual);
        void Visit(IsBetween isBetween);
        void Visit(IsOneOfTheFollowing isOneOfTheFollowing);
        void Visit(ContainsOneOfTheFollowing containsOneOfTheFollowing);
        void Visit(StartsWithOneOfTheFollowing startsWithOneOfTheFollowing);
        void Visit(EndsWithOneOfTheFollowing endsWithOneOfTheFollowing);
        void Visit(WhereClause whereClause);
    }
}