namespace MemberSuite.SDK.Searching
{
    /// <summary>
    ///     Used EXCLUSIVELY to render a complex search operation tree
    /// </summary>
    public class FlattenedSearchCriterion
    {
        public FlattenedSearchCriterion()
        {
            OpenParenthesesCount = 0;
            CloseParentehsesCount = 0;
        }

        public string ID { get; set; }
        public string Conjunction { get; set; }
        public int OpenParenthesesCount { get; set; }
        public string FieldLabel { get; set; }
        public string FieldOperation { get; set; }
        public string FieldValues { get; set; }
        public int CloseParentehsesCount { get; set; }
        public bool IsParameter { get; set; }
    }
}