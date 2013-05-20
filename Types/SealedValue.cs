using System;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    /// Represents a value of a record that is locked
    /// </summary>
    [Serializable]
    public struct SealedValue
    {
        public override string ToString()
        {
            return "[LOCKED]";
        }
    }
}
