using System.Runtime.Serialization;

namespace MemberSuite.SDK.Results
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <remarks></remarks>
    [DataContract(Name = "ConciergeResultOf{0}")]
    public class ConciergeResult<T> : ConciergeResult
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ConciergeResult&lt;T&gt;" /> class.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <remarks></remarks>
        public ConciergeResult(T result)
        {
            ResultValue = result;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ConciergeResult&lt;T&gt;" /> class.
        /// </summary>
        /// <remarks></remarks>
        public ConciergeResult()
        {
        }

        /// <summary>
        ///     Gets or sets the result value.
        /// </summary>
        /// <value>The result value.</value>
        /// <remarks></remarks>
        [DataMember]
        public T ResultValue { get; set; }
    }
}