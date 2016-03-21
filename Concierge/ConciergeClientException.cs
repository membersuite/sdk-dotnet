using System;
using MemberSuite.SDK.Utilities;

namespace MemberSuite.SDK.Concierge
{
    public class ConciergeClientException : ApplicationException
    {
        public ConciergeClientException(ConciergeErrorCode code, string msg, params object[] args)
            : base(StringUtil.SafeFormat(msg, args))
        {
            ErrorCode = code;
        }

        public ConciergeClientException(string errorID, ConciergeErrorCode code, string msg, params object[] args)
            : base(StringUtil.SafeFormat(msg, args))
        {
            ErrorCode = code;
            ErrorID = errorID;
        }

        public string ErrorID { get; set; }
        public ConciergeErrorCode ErrorCode { get; protected set; }
    }
}