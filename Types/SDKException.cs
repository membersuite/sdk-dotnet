using System;

namespace MemberSuite.SDK.Types
{
    public class SDKException : Exception
    {
        public SDKException()
        {
        }

        public SDKException(string msg, params object[] args)
            : base(string.Format(msg, args))
        {
        }
    }
}
