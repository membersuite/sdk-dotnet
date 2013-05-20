using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace MemberSuite.SDK.Concierge
{
    public class ConciergeClientExtension : BehaviorExtensionElement, IClientMessageInspector, IEndpointBehavior
    {

        public override Type BehaviorType
        {
            get { return typeof(ConciergeClientExtension); }
        }

        protected override object CreateBehavior()
        {
            return new ConciergeClientExtension();
        }


        /// <summary>
        /// Gets or sets the session ID.
        /// </summary>
        /// <value>The session ID.</value>
        public string SessionID { get; set; }




        #region IClientMessageInspector Members

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
             
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            MessageHeader<string> header = new MessageHeader<string>();
            header.Actor = "Anyone";

            SessionID = "1234";
            header.Content = SessionID;
            var untypedHeader = header.GetUntypedHeader(CustomHeader.HeaderName, CustomHeader.HeaderNamespace);
            request.Headers.Add(untypedHeader);

            return null;
        }

        #endregion

      

        #region IEndpointBehavior Members

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
            
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(this);
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
           
        }

        public void Validate(ServiceEndpoint endpoint)
        {
           
        }

        #endregion
    }

    public static class CustomHeader
    {
        public const string HeaderName = "SessionID";
        public const string HeaderNamespace = "http://membersuite.com/schemas";
    }
}