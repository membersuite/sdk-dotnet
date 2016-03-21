namespace MemberSuite.SDK.Concierge
{
    public struct ConciergeError
    {
        private ConciergeErrorCode _code;
        private string _id;
        private string _message;
        private string _offendingField;

        public ConciergeError(ConciergeErrorCode code, string msg) : this(code, msg, null)
        {
        }

        public ConciergeError(ConciergeErrorCode code, string msg, string offendingField)
        {
            _code = code;
            _message = msg;
            _offendingField = offendingField;
            _id = null;
        }

        public ConciergeErrorCode Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public string OffendingField
        {
            get { return _offendingField; }
            set { _offendingField = value; }
        }

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(OffendingField))
                return string.Format("Message: {0}; Field: {1}; Code: {2}", Message, OffendingField, Code);

            return string.Format("Message: {0}; Code: {1}", Message, Code);
        }
    }
}