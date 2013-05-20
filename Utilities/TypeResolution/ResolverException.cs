using System;

namespace MemberSuite.SDK.Utilities.TypeResolution
{
    public class ResolverException : Exception
    {
        public ResolverException(string msg, params object[] args) : base(string.Format(msg, args))
        {
        }
    }
}
