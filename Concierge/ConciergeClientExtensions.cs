using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using MemberSuite.SDK.Results;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Concierge
{
    public class ConciergeClientExtensions : IEndpointBehavior, IOperationBehavior, IClientMessageInspector,
        IParameterInspector
    {
        private static readonly StreamWriter debugWriter;

        static ConciergeClientExtensions()
        {
            var debugLogFilePath = ConfigurationManager.AppSettings["ConciergeClientExtensionsWcfLogFile"];
            if (!string.IsNullOrWhiteSpace(debugLogFilePath))
                debugWriter = new StreamWriter(debugLogFilePath);
        }

        #region IEndpointBehavior Members

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(new ConciergeClientExtensions());
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }

        #endregion

        #region IOperationBehavior Members

        public void AddBindingParameters(OperationDescription operationDescription,
            BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        {
            clientOperation.ParameterInspectors.Add(new ConciergeClientExtensions());
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
        {
        }

        public void Validate(OperationDescription operationDescription)
        {
        }

        #endregion

        #region IClientMessageInspector Members

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            var header = ConciergeResponseHeader.GetConciergeResponseHeader(reply);
            if (header != null)
            {
                ConciergeAPIProxyGenerator.SessionID = header.SessionId;

                if (
                    !string.Equals(ConciergeAPIProxyGenerator.BrowserId, header.BrowserId,
                        StringComparison.CurrentCultureIgnoreCase))
                    if (SessionExpired != null)
                        SessionExpired(this, null);
                    else throw new SecurityException("Invalid Browser ID on response");
            }

            if (debugWriter != null)
            {
                debugWriter.WriteLine("{0} - Received Response", DateTime.Now.ToString("O"));
                debugWriter.WriteLine(reply.ToString());
                debugWriter.Flush();
            }
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            var header = ConciergeAPIProxyGenerator.CreateRequestHeader(request);
            request.Headers.Add(header);

            if (OnBeforeSendRequest != null)
            {
                var args = new BeforeSendRequestArgs {Message = request, Channel = channel};
                OnBeforeSendRequest(this, args);
            }

            if (debugWriter != null)
            {
                debugWriter.WriteLine("{0} - Sending Request", DateTime.Now.ToString("O"));
                debugWriter.WriteLine(request.ToString());
                debugWriter.Flush();
            }

            return null;
        }

        public static event EventHandler<BeforeSendRequestArgs> OnBeforeSendRequest;

        public class BeforeSendRequestArgs : EventArgs
        {
            public Message Message { get; set; }
            public IChannel Channel { get; set; }
        }

        #endregion

        #region IParameterInspector Members

        public static event EventHandler SessionExpired;
        public static event EventHandler AccessKeyRejected;
        public static event EventHandler<ConciergeResultErrorArgs> OnResultError;

        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
            var lr = returnValue as ConciergeResult;

            if (lr == null || lr.Success ||
                (OnResultError == null && SessionExpired == null && AccessKeyRejected == null))
                return;

            // we need to raise an event
            var sbErrors = new StringBuilder();
            var code = ConciergeErrorCode.GeneralException;
            string errorID = null;
            if (lr.Errors != null && lr.Errors.Count > 0)
            {
                errorID = lr.Errors[0].ID;
                sbErrors.Append("We encountered a problem fulfilling your request: ");
                foreach (var err in lr.Errors)
                {
                    sbErrors.AppendFormat("{0}; ", err.Message);

                    if (err.Code == ConciergeErrorCode.SessionExpired) // ok stop - let's go to login
                    {
                        if (SessionExpired != null)
                            SessionExpired(this, null);
                        return;
                    }

                    if (err.Code == ConciergeErrorCode.InvalidAccessKey)
                        // ok stop - this is bad configuration or an expired temporary access key
                    {
                        if (AccessKeyRejected != null)
                            AccessKeyRejected(this, null);
                        return;
                    }

                    code = err.Code;
                }
            }

            if (OnResultError != null)
                OnResultError(this,
                    new ConciergeResultErrorArgs
                    {
                        Code = code,
                        Message = sbErrors.ToString().Trim().Trim(';'),
                        ErrorID = errorID
                    });
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            if (inputs == null)
                return null;

            // we need to replace any items that derive from MemberSuiteObject
            // with the clean MemberSuite object equivalents, otherwise the
            // Data Contract Serializer will freak out
            for (var i = 0; i < inputs.Length; i++)
            {
                var input = inputs[i];


                if (input == null || !typeof (MemberSuiteObject).IsAssignableFrom(input.GetType()))
                    continue;

                var mso = MemberSuiteObject.ConvertToMemberSuiteObject(((MemberSuiteObject) input));

                // remove all transient fields
                if (mso.Fields != null)
                    foreach (var keys in mso.Fields.Keys.ToList().FindAll(k => k.EndsWith("__transient")))
                        mso.Fields.Remove(keys);

                inputs[i] = mso;
            }

            return null;
        }

        #endregion

        #region Custom Header

        #endregion
    }

    public class ConciergeResultErrorArgs : EventArgs
    {
        public ConciergeErrorCode Code { get; set; }
        public string Message { get; set; }
        public string ErrorID { get; set; }
    }
}