using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Results
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public class AddressValidationResult : ConciergeResult<Address>
    {
        /// <summary>
        /// Gets or sets the address validation error message.
        /// </summary>
        /// <value>The address validation error message.</value>
        /// <remarks></remarks>
        public string AddressValidationErrorMessage { get; set; }
        
    }
}
