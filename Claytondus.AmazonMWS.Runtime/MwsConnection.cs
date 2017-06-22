/******************************************************************************* 
 * Copyright 2009-2012 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Marketplace Web Service Runtime Client Library
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Claytondus.AmazonMWS.Runtime
{
    public class MwsConnection 
    {
        #region Fields and Constructors

        private readonly object lockThis = new object();

        private string applicationName;
        private string applicationVersion;
        private string libraryVersion;
        private string userAgent;
        private Dictionary<string, string> headers;

        private string awsAccessKeyId;
        private string awsSecretKeyId;
        private string signatureVersion;
        private string signatureMethod;

        private int connectionTimeout;
        private int maxErrorRetry;

        private Uri endpoint;

        private string proxyHost;
        private int proxyPort;
        private string proxyUsername;
        private string proxyPassword;

        private volatile bool frozen;
        private Dictionary<string, ServiceEndpoint> cachedServiceMap;

        public MwsConnection()
        {
            this.cachedServiceMap = new Dictionary<string, ServiceEndpoint>();
            this.headers = new Dictionary<string, string>();

            this.frozen = false;
            this.signatureVersion = "2";
            this.signatureMethod = "HmacSHA256";
            this.connectionTimeout = 50000;
            this.maxErrorRetry = 3;
            this.libraryVersion = "1.0.0";
        }

        public MwsConnection(Uri endpoint, string applicationName, string applicationVersion, string awsAccessKeyId, string awsSecretKeyId) : this()
        {
            this.endpoint = endpoint;
            this.applicationName = applicationName;
            this.applicationVersion = applicationVersion;
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretKeyId = awsSecretKeyId;
        }

        #endregion

        private void freeze()
        {
            lock (lockThis)
            {
                if (UserAgent == null)
                {
                    SetDefaultUserAgent();
                }
                this.headers = new Dictionary<string, string>(this.headers);

                this.frozen = true;
            }
        }

        internal HttpWebRequest GetHttpClient(Uri uri)
        {
            if (this.frozen)
            {
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                //if (ProxyHost != null && ProxyPort != 0)
                //{
                //    request.Proxy = new WebProxy(this.ProxyHost, this.ProxyPort);
                //    request.Proxy.Credentials = new NetworkCredential(this.ProxyUsername, this.ProxyPassword);
                //}
                //request.UserAgent = this.UserAgent;
                request.Method = "POST";
                //request.Timeout = this.ConnectionTimeout;
                request.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
                foreach(KeyValuePair<string, string> header in this.headers)
                {
                    request.Headers[header.Key] = header.Value;
                }
                return request;
            }
            else
            {
                throw new InvalidOperationException("Must freeze properties before making HTTP requests");
            }
        }

        /// <summary>
        /// Creates a new MwsCall
        /// </summary>
        /// <param name="servicePath"></param>
        /// <param name="operationName"></param>
        /// <returns>A new request</returns>
        public IMwsCall NewCall(string servicePath, string operationName)
        {
            if (!this.frozen)
            {
                freeze();
            }

            ServiceEndpoint sep = GetServiceEndpoint(servicePath);
            return new MwsAQCall(this, sep, operationName);
        }        

        /// <summary>
        /// Creates a MwsCall and sends the request
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type"></param>
        /// <param name="requestData"></param>
        /// <returns></returns>

        public T Call<T>(IMwsRequestType<T> type,
            IMwsObject requestData) where T : IMwsObject
        {
            IMwsReader responseReader = null;
            try
            {
                string servicePath = type.ServicePath;
                string operationName = type.OperationName;
                IMwsCall mc = NewCall(servicePath, operationName);
                requestData.WriteFragmentTo(mc);
                responseReader = mc.invoke();
                MwsResponseHeaderMetadata rhmd = mc.GetResponseMetadataHeader();
                T response = MwsUtil.NewInstance<T>();
                type.SetResponseHeaderMetadata(response, rhmd);
                response.ReadFragmentFrom(responseReader);
                return response;
            }
            catch (Exception e)
            {
                throw type.WrapException(e);
            }
           
        }
        /// <summary>
        /// Clones the connection and resets the state as if it was never used
        /// </summary>
        /// <returns></returns>
        public Object Clone()
        {
            MwsConnection conn = (MwsConnection) base.MemberwiseClone();
            conn.cachedServiceMap = new Dictionary<string,ServiceEndpoint>();
            conn.frozen = false;
            return conn;
        }

        private void CheckUpdatable()
        {
            if (this.frozen)
            {
                throw new InvalidOperationException("Cannot change MwsConnection properties once connected");
            }
        }

        #region User Agent

        private void SetDefaultUserAgent()
        {
            SetUserAgent(
                MwsUtil.EscapeAppName(this.ApplicationName), 
                MwsUtil.EscapeAppVersion(this.ApplicationVersion),
                MwsUtil.EscapeAttributeValue("C#"), 
                new string[] { 
                    "CLI", "", 
                    "Platform", "", 
                    "MWSClientVersion", this.LibraryVersion 
                });
        }

        /// <summary>
        /// Construct a user agent header - synchronized
        /// </summary>
        /// <param name="applicationName">Escaped application name</param>
        /// <param name="applicationVersion">Escaped application version</param>
        /// <param name="programmingLanguage">Escaped programming language</param>
        /// <param name="additionalNameValuePairs">Raw attribute name,value pair</param>        
        public void SetUserAgent(string applicationName, string applicationVersion, string programmingLanguage, string[] additionalNameValuePairs)
        {
            lock (lockThis)
            {
                if (applicationName == null)
                {
                    throw new ArgumentNullException("applicationName", "Value cannot be null.");
                }

                if (applicationVersion == null)
                {
                    throw new ArgumentNullException("applicationVersion", "Value cannot be null.");
                }

                if (programmingLanguage == null)
                {
                    throw new ArgumentNullException("programmingLanguage", "Value cannot be null.");
                }

                if (additionalNameValuePairs.Length % 2 != 0)
                {
                    throw new ArgumentException("additionalNameValuePairs", "Every name must have a corresponding value.");
                }
                StringBuilder sb = new StringBuilder();
                sb.Append(applicationName);
                sb.Append("/");
                sb.Append(applicationVersion);
                sb.Append(" (");
                sb.Append("Language=");
                sb.Append(programmingLanguage);
                int i = 0;
                while (i < additionalNameValuePairs.Length)
                {
                    string name = additionalNameValuePairs[i];
                    string value = additionalNameValuePairs[++i];
                    sb.Append("; ");
                    sb.Append(MwsUtil.EscapeAttributeName(name));
                    sb.Append("=");
                    sb.Append(MwsUtil.EscapeAttributeValue(value));
                    i++;
                }

                sb.Append(")");
                this.userAgent = sb.ToString();
            }
        }

        public string ApplicationName
        {
            get { return this.applicationName; }
            set
            {
                CheckUpdatable();
                this.applicationName = value;
            }
        }

        public string ApplicationVersion
        {
            get { return this.applicationVersion; }
            set
            {
                CheckUpdatable();
                this.applicationVersion = value;
            }
        }

        /// <summary>
        /// Gets or sets the client library version, defaults to 1.0.0
        /// </summary>
        public string LibraryVersion
        {
            get { return this.libraryVersion; }
            set
            {
                CheckUpdatable();
                this.libraryVersion = value;
            }
        }

        public string UserAgent
        {
            get { return this.userAgent; }
            set 
            {
                CheckUpdatable();
                this.userAgent = value;
            }
        }

        #endregion

        #region Properties

        public string AwsAccessKeyId
        {
            get { return this.awsAccessKeyId; }
            set
            {
                CheckUpdatable();
                this.awsAccessKeyId = value;
            }
        }

        public string AwsSecretKeyId
        {
            get { return this.awsSecretKeyId; }
            set
            {
                CheckUpdatable();
                this.awsSecretKeyId = value;
            }
        }

        /// <summary>
        /// Get or set max number of retries - default is 3
        /// </summary>
        /// <returns></returns>
        public int MaxErrorRetry
        {
            get { return this.maxErrorRetry; }
            set
            {
                CheckUpdatable();
                this.maxErrorRetry = value;
            }
        }

        /// <summary>
        /// Get or set MWS endpoint URI
        /// </summary>
        public Uri Endpoint
        {
            get { return this.endpoint; }
            set
            {
                CheckUpdatable();
                this.endpoint = value;
            }
        }

        public ServiceEndpoint GetServiceEndpoint(string servicePath)
        {
            lock (cachedServiceMap)
            {
                if (!cachedServiceMap.ContainsKey(servicePath))
                {
                    ServiceEndpoint sep = new ServiceEndpoint(this.Endpoint, servicePath);
                    cachedServiceMap.Add(servicePath, sep);
                }
                return cachedServiceMap[servicePath];
            }
        }

        /// <summary>
        /// Get or set signature version - defaults to 2
        /// </summary>
        /// <returns></returns>
        public string SignatureVersion
        {
            get { return this.signatureVersion; }
            set
            {
                CheckUpdatable();
                this.signatureVersion = value;
            }
        }

        /// <summary>
        /// Get or set signature method - defaults to HmacSHA256
        /// </summary>
        /// <returns></returns>
        public string SignatureMethod
        {
            get { return this.signatureMethod; }
            set
            {
                CheckUpdatable();
                this.signatureMethod = value;
            }
        }

        /// <summary>
        /// Get or set connection timeout, defaults to 50000
        /// </summary>
        /// <returns></returns>
        public int ConnectionTimeout
        {
            get { return this.connectionTimeout; }
            set
            {
                CheckUpdatable();
                this.connectionTimeout = value;
            }
        }

        public string ProxyHost
        {
            get { return this.proxyHost; }
            set
            {
                CheckUpdatable();
                this.proxyHost = value;
            }
        }

        public int ProxyPort
        {
            get { return this.proxyPort; }
            set
            {
                CheckUpdatable();
                this.proxyPort = value;
            }
        }

        public string ProxyUsername
        {
            get { return this.proxyUsername; }
            set
            {
                CheckUpdatable();
                this.proxyUsername = value;
            }
        }

        public string ProxyPassword
        {
            get { return this.proxyPassword; }
            set
            {
                CheckUpdatable();
                this.proxyPassword = value;
            }
        }

        /// <summary>
        /// Sets the value of a request header to be included on every request
        /// </summary>
        /// <param name="name">the name of the header to set</param>
        /// <param name="value">value to send with header</param>
        public void IncludeRequestHeader(string name, string value)
        {
            CheckUpdatable();
            this.headers[name] = value;
        }

        /// <summary>
        /// Gets the currently set value of a request header
        /// </summary>
        /// <param name="name">the name of the header to get</param>
        /// <returns>value of specified header, or null if not defined</returns>
        public string GetRequestHeader(string name)
        {
            if (headers.ContainsKey(name))
            {
                return this.headers[name];
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region ServiceEndpoint Definition

        /// <summary>
        /// Immutable service and version URI for an endpoint
        /// </summary>
        public class ServiceEndpoint
        {

            /** The service name. */
            public readonly string service;

            /** The service and version name as service/version. */
            public readonly string servicePath;

            /** The combined uri of the connection, service name, and version. */
            public readonly Uri URI;

            /** The service version. */
            public readonly string version;

            /// <summary>
            /// Creates a new URI 
            /// </summary>
            /// <param name="baseUri"></param>
            /// <param name="servicePath"></param>
            public ServiceEndpoint(Uri baseUri, string servicePath)
            {
                if (servicePath.Length > 0)
                {
                    this.servicePath = servicePath;
                    int j = servicePath.LastIndexOf('/');
                    this.service = servicePath.Substring(0, j);
                    this.version = servicePath.Substring(j + 1);
                }
                this.URI = new Uri(baseUri, "/" + servicePath);
            }
        }

        #endregion

    }
}
