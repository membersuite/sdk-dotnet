// ***********************************************************************
// Assembly         : MemberSuite.SDK
// Author           : Andrew
// Created          : 09-13-2012
//
// Last Modified By : Andrew
// Last Modified On : 09-13-2012
// ***********************************************************************
// <copyright file="ConciergeAPIProxyGenerator.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Security;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using MemberSuite.SDK.Utilities;
using MemberSuite.SDK.WCF;

namespace MemberSuite.SDK.Concierge
{
    /// <summary>
    /// Class ConciergeAPIProxyGenerator
    /// </summary>
    public static class ConciergeAPIProxyGenerator
    {
        static ConciergeAPIProxyGenerator()
        {
            // let's try to pull from the app settings
            string accessKey = ConfigurationManager.AppSettings["MSAccessKey"];
            string secretKey = ConfigurationManager.AppSettings["MSSecretKey"];
            string associationID =  ConfigurationManager.AppSettings["MSAssociationID"];

            if (!string.IsNullOrWhiteSpace(accessKey)) SetAccessKeyId(accessKey);
            if (!string.IsNullOrWhiteSpace(secretKey)) SetSecretAccessKey(secretKey);
            if (!string.IsNullOrWhiteSpace(associationID)) AssociationId =  (associationID);
        }

        /// <summary>
        /// The _channel factory
        /// </summary>
        private static Dictionary<string, ChannelFactory<IConciergeAPIService>> _channelFactory =
            new Dictionary<string, ChannelFactory<IConciergeAPIService>>();

        /// <summary>
        /// Gets or sets the _session ID provider.
        /// </summary>
        /// <value>The _session ID provider.</value>
        private static IConciergeAPISessionIdProvider _sessionIDProvider { get; set; }
        /// <summary>
        /// Gets or sets the _association id provider.
        /// </summary>
        /// <value>The _association id provider.</value>
        private static IConciergeAPIAssociationIdProvider _associationIdProvider { get; set; }
        /// <summary>
        /// Gets or sets the _browser id provider.
        /// </summary>
        /// <value>The _browser id provider.</value>
        private static IConciergeAPIBrowserIdProvider _browserIdProvider { get; set; }
        /// <summary>
        /// Gets or sets the _access key id.
        /// </summary>
        /// <value>The _access key id.</value>
        private static string _accessKeyId { get; set; }

        /// <summary>
        /// The thread lock
        /// </summary>
        private static object threadLock = new object();

        /// <summary>
        /// The _mock
        /// </summary>
        [ThreadStatic]  // used for a mock service
        private static IConciergeAPIService _mock;
        /// <summary>
        /// Gets or sets the name of the configuration section to pull the
        /// API information from - otherwise, this is generated automatically.
        /// </summary>
        /// <value>The name of the configuration.</value>
        public static string ConfigurationName { get; set; }

        /// <summary>
        /// The _session ID
        /// </summary>
        [ThreadStatic]
        private static string _sessionID = null;

        /// <summary>
        /// The _association id
        /// </summary>
        [ThreadStatic]
        private static string _associationId = null;

        /// <summary>
        /// Gets or sets the session ID.
        /// </summary>
        /// <value>The session ID.</value>
        public static string SessionID
        {
            get
            {
                //First if a session id provider has been supplied try to get the session id from that
                //Typically this implementation will use HttpContext to store the session id which is preferrable to 
                //ThreadStatic especially in ASP.NET apps (that's b/c requests can start and end on different threads!!). 
                //By using the try pattern the impementation should return false if HttpContext is not available from the calling location
                string sessionId = null;

                if (_sessionIDProvider != null && _sessionIDProvider.TryGetSessionId(out sessionId))
                    return sessionId;

                //At this point either no session id provider has been supplied or the session provider
                //is unable to determine session id so fall back on using a ThreadStatic variable
                return _sessionID;
            }
            set
            {
                //First if a session id provider has been supplied try to set the session id on it
                //The provider should be using a safe implementation and simply returning false if it is unable to set the value
                //(if for instance HttpContext isn't available from the calling location)
                if (_sessionIDProvider != null)
                    _sessionIDProvider.SetSessionId(value);

                //Always set the session id on the ThreadStatic - see the Get implementation
                //If a session id provider is not provided or is unable to get the value (i.e. HttpContext is not available) 
                //it will fall back to using this variable so it should always be set
                _sessionID = value;
            }
        }

        /// <summary>
        /// Gets or sets the session ID.
        /// </summary>
        /// <value>The session ID.</value>
        public static string AssociationId
        {
            get
            {
                //First if an association id provider has been supplied try to get the association id from that
                //This value may be stored in the web.config or determined by the url and stored in the session
                string associationId = null;

                if (_associationIdProvider != null && _associationIdProvider.TryGetAssociationId(out associationId))
                    return associationId;

                //At this point either no session id provider has been supplied or the session provider
                //is unable to determine session id so fall back on using a ThreadStatic variable
                return _associationId;
            }
            set
            {
                //First if an association id provider has been supplied try to set the association id on it
                //The provider should be using a safe implementation and simply returning false if it is unable to set the value
                //(if for instance HttpContext isn't available from the calling location)
                if (_associationIdProvider != null)
                    _associationIdProvider.SetAssociationId(value);

                //Always set the association id on the ThreadStatic - see the Get implementation
                //If a association id provider is not provided or is unable to get the value (i.e. HttpContext is not available) 
                //it will fall back to using this variable so it should always be set
                _associationId = value;
            }
        }

        /// <summary>
        /// Gets or sets the browser ID.
        /// </summary>
        /// <value>The session ID.</value>
        public static string BrowserId
        {
            get
            {
                string browserId = null;

                if (_browserIdProvider != null && _browserIdProvider.TryGetBrowserId(out browserId))
                    return browserId;

                return null;
            }
        }

        /// <summary>
        /// Gets or sets the default instance.
        /// </summary>
        /// <value>The default instance.</value>
        public static string DefaultInstance { get; set; }

        #region API Credentials

        /// <summary>
        /// Gets or sets the secret access key.
        /// </summary>
        /// <value>The secret access key.</value>
        private static SecureString SecretAccessKey { get; set; }

        /// <summary>
        /// Creates the request header.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>MessageHeader.</returns>
        public static MessageHeader CreateRequestHeader(Message request)
        {
            ConciergeRequestHeader headerValue = new ConciergeRequestHeader
                                                    {
                                                        AccessKeyId = _accessKeyId,
                                                        Signature = 
                                                            CryptoManager.GetMessageSignature(SecretAccessKey,
                                                                                              request.Headers.Action,
                                                                                              SessionID, AssociationId), // Sign the message using the Secret Access Key - this will eventually be in a security token along with a signature from the STS
                                                        AssociationId = AssociationId, // Add Association ID - this will eventually be moved to a claim on the security token
                                                        SessionId = SessionID,
                                                        BrowserId = BrowserId
                                                    };
            
            MessageHeader result = MessageHeader.CreateHeader(ConciergeRequestHeader.HeaderName,
                                                              ConciergeRequestHeader.HeaderNamespace, headerValue);
            return result;
        }

        /// <summary>
        /// Sets the secret access key.
        /// </summary>
        /// <param name="secretAccessKey">The secret access key.</param>
        /// <exception cref="System.ArgumentNullException">secretAccessKey</exception>
        public static void SetSecretAccessKey(string secretAccessKey)
        {
            if (secretAccessKey == null) throw new ArgumentNullException("secretAccessKey");
            lock (threadLock)
            {
                secretAccessKey = StringUtil.PadBase64String(secretAccessKey);

                SecretAccessKey = new SecureString();

                foreach (char c in secretAccessKey)
                    SecretAccessKey.AppendChar(c);

                SecretAccessKey.MakeReadOnly();
            }
        }

        /// <summary>
        /// Sets the access key id.
        /// </summary>
        /// <param name="accessKeyId">The access key id.</param>
        /// <exception cref="System.ArgumentNullException">accessKeyId</exception>
        public static void SetAccessKeyId(string accessKeyId)
        {
            if (accessKeyId == null) throw new ArgumentNullException("accessKeyId");
            lock (threadLock)
            {
                string value = StringUtil.PadBase64String(accessKeyId);
                _accessKeyId = value;
            }
        }

        /// <summary>
        /// Determines whether [has access key id].
        /// </summary>
        /// <returns><c>true</c> if [has access key id]; otherwise, <c>false</c>.</returns>
        public static bool HasAccessKeyId()
        {
            lock (threadLock)
            {
                return !string.IsNullOrWhiteSpace(_accessKeyId);
            }
        }

        /// <summary>
        /// Determines whether [has secret access key].
        /// </summary>
        /// <returns><c>true</c> if [has secret access key]; otherwise, <c>false</c>.</returns>
        public static bool HasSecretAccessKey()
        {
            lock (threadLock)
            {
                return SecretAccessKey != null && SecretAccessKey.Length > 0;
            }
        }

        /// <summary>
        /// Clears the access key id.
        /// </summary>
        public static void ClearAccessKeyId()
        {
            lock (threadLock)
            {
                _accessKeyId = null;
            }
        }

        /// <summary>
        /// Clears the secret access key.
        /// </summary>
        public static void ClearSecretAccessKey()
        {
            lock (threadLock)
            {
                if (SecretAccessKey != null)
                    SecretAccessKey.Dispose();

                SecretAccessKey = null;
            }
        }

        #endregion

        /// <summary>
        /// Registers the mock.
        /// </summary>
        /// <param name="mock">The mock.</param>
        public static void RegisterMock(IConciergeAPIService mock)
        {
            _mock = mock;
        }

        /// <summary>
        /// Registers the session ID provider.
        /// </summary>
        /// <param name="provider">The provider.</param>
        public static void RegisterSessionIDProvider(IConciergeAPISessionIdProvider provider)
        {
            _sessionIDProvider = provider;
        }

        /// <summary>
        /// Registers the association id provider.
        /// </summary>
        /// <param name="provider">The provider.</param>
        public static void RegisterAssociationIdProvider(IConciergeAPIAssociationIdProvider provider)
        {
            _associationIdProvider = provider;
        }

        /// <summary>
        /// Registers the browser id provider.
        /// </summary>
        /// <param name="provider">The provider.</param>
        public static void RegisterBrowserIdProvider(IConciergeAPIBrowserIdProvider provider)
        {
            _browserIdProvider = provider;
        }

        /// <summary>
        /// Generates the proxy.
        /// </summary>
        /// <returns>IConciergeAPIService.</returns>
        public static IConciergeAPIService GenerateProxy()
        {
            return GenerateProxy(DefaultInstance ?? "Default");
        }


        /// <summary>
        /// Generates the proxy.
        /// </summary>
        /// <param name="instanceName">Name of the Concierge Instance to use.</param>
        /// <returns>IConciergeAPIService.</returns>
        /// <exception cref="System.ArgumentNullException">instanceName</exception>
        public static IConciergeAPIService GenerateProxy(string instanceName)
        {
            if (instanceName == null) throw new ArgumentNullException("instanceName");

            if (_mock != null)
                return _mock;

            return GetChannelFactory(instanceName).CreateChannel();

        }



        /// <summary>
        /// Gets the channel factory.
        /// </summary>
        /// <param name="instanceName">Name of the instance.</param>
        /// <returns>ChannelFactory{IConciergeAPIService}.</returns>
        private static ChannelFactory<IConciergeAPIService> GetChannelFactory(string instanceName)
        {
            ChannelFactory<IConciergeAPIService> api;

            if (_channelFactory.TryGetValue(instanceName, out api))
                return api;

            var cf = _buildChannelFactory(instanceName);
            _channelFactory[instanceName] = cf;

            return cf;
        }


        /// <summary>
        /// _builds the channel factory.
        /// </summary>
        /// <param name="instanceName">Name of the instance.</param>
        /// <returns>ChannelFactory{IConciergeAPIService}.</returns>
        private static ChannelFactory<IConciergeAPIService> _buildChannelFactory(string instanceName)
        {
            ChannelFactory<IConciergeAPIService> cf;

            if (ConfigurationName != null)
                cf = new ChannelFactory<IConciergeAPIService>(ConfigurationName);
            else
            {
                cf = new ChannelFactory<IConciergeAPIService>();

                string ConciergeUri = ConfigurationManager.AppSettings[instanceName + "_ConciergeUri"];
                if (ConciergeUri == null)
                    ConciergeUri = "https://api.membersuite.com";

                // we have to build it up - hard coded here
                EndpointAddress ea = new EndpointAddress(ConciergeUri);

                cf.Endpoint.Address = ea;
                Binding binding = generateBindingFor(ConciergeUri);
                cf.Endpoint.Binding = binding;
                cf.Endpoint.Contract.ContractType = typeof(IConciergeAPIService);

            }
            cf.Endpoint.Behaviors.Add(new ConciergeClientExtensions());
            foreach (var op in cf.Endpoint.Contract.Operations)
                op.Behaviors.Add(new ConciergeClientExtensions());

            foreach (OperationDescription op in cf.Endpoint.Contract.Operations)
            {
                DataContractSerializerOperationBehavior dataContractBehavior = op.Behaviors.Find<DataContractSerializerOperationBehavior>();
                if (dataContractBehavior != null)
                {
                    dataContractBehavior.MaxItemsInObjectGraph = 2096912;
                }
            }


            return cf;
        }

        /// <summary>
        /// Generates the binding for.
        /// </summary>
        /// <param name="conciergeUri">The concierge URI.</param>
        /// <returns>Binding.</returns>
        private static Binding generateBindingFor(string conciergeUri)
        {
            if (conciergeUri == null) return null;

            if (conciergeUri.StartsWith("net.tcp"))
                return generateTcpBinding();

            return generateBasicHttpBinding();
        }

        /// <summary>
        /// Generates the TCP binding.
        /// </summary>
        /// <returns>Binding.</returns>
        private static Binding generateTcpBinding()
        {
            var b = new NetTcpBinding();
            b.MaxReceivedMessageSize = 65536000;
            b.ReaderQuotas.MaxStringContentLength = 88880000;
            b.ReliableSession.InactivityTimeout = TimeSpan.FromHours(1);
            b.Security.Mode = SecurityMode.None;
            return b;

        }

        /// <summary>
        /// Generates the basic HTTP binding.
        /// </summary>
        /// <returns>Binding.</returns>
        private static Binding generateBasicHttpBinding()
        {
            var b = new BasicHttpBinding();
            b.MaxReceivedMessageSize = 65536000;
            b.ReaderQuotas.MaxStringContentLength = 88880000;
            b.Security.Mode = BasicHttpSecurityMode.Transport;

            return b;
        }
    }

    /// <summary>
    /// This is a generalized interface used when outside classes are responsible for
    /// resolving the current SessionID. For instance - a web application may store
    /// session ID in Session state - they would use this interface to respond to the current session.
    /// </summary>
    public interface IConciergeAPISessionIdProvider
    {
        /// <summary>
        /// Tries the get session id.
        /// </summary>
        /// <param name="sessionId">The session id.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        bool TryGetSessionId(out string sessionId);
        /// <summary>
        /// Sets the session id.
        /// </summary>
        /// <param name="sessionId">The session id.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        bool SetSessionId(string sessionId);
    }

    /// <summary>
    /// Interface IConciergeAPIAssociationIdProvider
    /// </summary>
    public interface IConciergeAPIAssociationIdProvider
    {
        /// <summary>
        /// Tries the get association id.
        /// </summary>
        /// <param name="associationId">The association id.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        bool TryGetAssociationId(out string associationId);
        /// <summary>
        /// Sets the association id.
        /// </summary>
        /// <param name="associationId">The association id.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        bool SetAssociationId(string associationId);
    }

    /// <summary>
    /// Interface IConciergeAPIBrowserIdProvider
    /// </summary>
    public interface IConciergeAPIBrowserIdProvider
    {
        /// <summary>
        /// Tries the get browser id.
        /// </summary>
        /// <param name="browserId">The browser id.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        bool TryGetBrowserId(out string browserId);
    }
}