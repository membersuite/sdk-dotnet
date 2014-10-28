using System.Collections.Generic;
using System.Runtime.Serialization;
using MemberSuite.SDK.Concierge;

namespace MemberSuite.SDK.Results
{
    /// <summary>
    /// Base class for all return values for concierge services
    /// </summary>
    /// <remarks></remarks>
    [DataContract]
    public class ConciergeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConciergeResult"/> class.
        /// </summary>
        /// <remarks></remarks>
        public ConciergeResult()
        {
            Errors = new List<ConciergeError>();
            Success = true; // by default
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ConciergeResult"/> is success.
        /// </summary>
        /// <value><c>true</c> if success; otherwise, <c>false</c>.</value>
        /// <remarks></remarks>
        [DataMember]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ConciergeResult"/> is cacheable.
        /// </summary>
        /// <value><c>true</c> if cacheable; otherwise, <c>false</c>.</value>
        /// <remarks></remarks>
        [DataMember]
        public bool Cacheable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [not modified].
        /// </summary>
        /// <value><c>true</c> if [not modified]; otherwise, <c>false</c>.</value>
        /// If a request was sent with an IfModifiedSince header, this value is set to true to indicate
        /// that nothing has been modified.
        /// <remarks></remarks>
        [DataMember]
        public bool NotModified { get; set; }

        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        /// <value>The errors.</value>
        /// <remarks></remarks>
        [DataMember]
        public List<ConciergeError> Errors { get; set; }

        /// <summary>
        /// If the request results in a workflow being run, this is the
        /// workflow ID
        /// </summary>
         [DataMember]
        public string WorkflowExecutionID { get; set; }

        /// <summary>
        /// If the request results in a workflow being run, this is the 
        /// Run ID (a workflow may be run multiple times)
        /// </summary>
         [DataMember]
        public string WorkflowRunID { get; set; }

        /// <summary>
        /// Gets the first error message.
        /// </summary>
        /// <remarks></remarks>
        public string FirstErrorMessage
        {
            get
            {
                if (Errors.Count == 0) return null;
                return Errors[0].Message;
            }
        }

        /// <summary>
        /// Adds the error.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="msg">The MSG.</param>
        /// <remarks></remarks>
        public void AddError(ConciergeErrorCode errorCode, string msg)
        {
            AddError(errorCode, msg, null);
        }

        /// <summary>
        /// Adds the error.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="msg">The MSG.</param>
        /// <param name="offendingField">The offending field.</param>
        /// <remarks></remarks>
        public void AddError(ConciergeErrorCode errorCode, string msg, string offendingField)
       {
            Success = false;
            Errors.Add(new ConciergeError(errorCode, msg, offendingField ));
        }

        /// <summary>
        /// Adds the error.
        /// </summary>
        /// <param name="err">The err.</param>
        /// <remarks></remarks>
        public void AddError(ConciergeError err)
        {
            Success = false;
            Errors.Add(err);
        }

        /// <summary>
        /// Adds the error range.
        /// </summary>
        /// <param name="errors">The errors.</param>
        /// <remarks></remarks>
        public void AddErrorRange(IEnumerable<ConciergeError> errors )
        {
            Success = false;
            Errors.AddRange(errors);
        }
    }
}
