/******************************************************************************* 
 *  Copyright 2008 Amazon Services.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 * 
 *  Marketplace Web Service CSharp Library
 *  API Version: 2009-01-01
 *  Generated: Mon Mar 16 15:13:52 PDT 2009 
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MarketplaceWebService
{

    /// <summary>
    /// Configuration for accessing Marketplace Web Service  service
    /// </summary>
    public class MarketplaceWebServiceConfig
    {
    
        private String serviceVersion = "2009-01-01";
        private String serviceURL = null;
        private String userAgent = null;
        private String signatureVersion = "2";
        private String signatureMethod = "HmacSHA256";
        private String proxyHost = null;
        private int proxyPort = -1;
        private int maxErrorRetry = 3;
        private int requestTimeout = 50000;

        /// <summary>
        /// Gets and sets the request time-out value in milliseconds.
        /// </summary>
        public int RequestTimeout
        {
            get { return this.requestTimeout; }
            set { this.requestTimeout = value; }
        }

        /// <summary>
        /// Gets Service Version
        /// </summary>
        public String ServiceVersion
        {
            get { return this.serviceVersion ; }
        }
        /// <summary>
        /// Gets and sets of the signatureMethod property.
        /// </summary>
        public String SignatureMethod
        {
            get { return this.signatureMethod; }
            set { this.signatureMethod = value; }
        }

        /// <summary>
        /// Sets the SignatureMethod property
        /// </summary>
        /// <param name="signatureMethod">SignatureMethod property</param>
        /// <returns>this instance</returns>
        public MarketplaceWebServiceConfig WithSignatureMethod(String signatureMethod)
        {
            this.signatureMethod = signatureMethod;
            return this;
        }


        /// <summary>
        /// Checks if SignatureMethod property is set
        /// </summary>
        /// <returns>true if SignatureMethod property is set</returns>
        public Boolean IsSetSignatureMethod()
        {
            return this.signatureMethod != null;
        }
        /// <summary>
        /// Gets and sets of the SignatureVersion property.
        /// </summary>
        public String SignatureVersion
        {
            get { return this.signatureVersion ; }
            set { this.signatureVersion = value; }
        }

        /// <summary>
        /// Sets the SignatureVersion property
        /// </summary>
        /// <param name="signatureVersion">SignatureVersion property</param>
        /// <returns>this instance</returns>
        public MarketplaceWebServiceConfig WithSignatureVersion(String signatureVersion)
        {
            this.signatureVersion = signatureVersion;
            return this;
        }

        /// <summary>
        /// Checks if SignatureVersion property is set
        /// </summary>
        /// <returns>true if SignatureVersion property is set</returns>
        public Boolean IsSetSignatureVersion()
        {
            return this.signatureVersion != null;
        }
    
        /// <summary>
        /// Gets and sets of the UserAgent property.
        /// </summary>
        public String UserAgent
        {
            get { return this.userAgent ; }
        }

        /// <summary>
        /// Sets the UserAgent property
        /// </summary>
        /// <param name="userAgent">UserAgent property</param>
        /// <returns>this instance</returns>
        public MarketplaceWebServiceConfig WithUserAgent(String userAgent)
        {
            this.userAgent = userAgent;
            return this;
        }

        /// <summary>
        /// Checks if UserAgent property is set
        /// </summary>
        /// <returns>true if UserAgent property is set</returns>
        public Boolean IsSetUserAgent()
        {
            return this.userAgent != null;
        }

        /// <summary>
        /// Gets the ServiceURL property.
        /// </summary>
        public String ServiceURL
        {
            get { return this.serviceURL ; }
            set { this.serviceURL = value; }
        }

        /// <summary>
        /// Sets the ServiceURL property
        /// </summary>
        /// <param name="serviceURL">ServiceURL property</param>
        /// <returns>this instance</returns>
        public MarketplaceWebServiceConfig WithServiceURL(String serviceURL)
        {
            this.serviceURL = serviceURL;
            return this;
        }

        /// <summary>
        /// Checks if ServiceURL property is set
        /// </summary>
        /// <returns>true if ServiceURL property is set</returns>
        public Boolean IsSetServiceURL()
        {
            return this.serviceURL != null;
        }

        /// <summary>
        /// Gets and sets of the ProxyHost property.
        /// </summary>
        public String ProxyHost
        {
            get { return this.proxyHost; }
            set { this.proxyHost = value; }
        }

        /// <summary>
        /// Sets the ProxyHost property
        /// </summary>
        /// <param name="proxyHost">ProxyHost property</param>
        /// <returns>this instance</returns>
        public MarketplaceWebServiceConfig WithProxyHost(String proxyHost)
        {
            this.proxyHost = proxyHost;
            return this;
        }

        /// <summary>
        /// Checks if ProxyHost property is set
        /// </summary>
        /// <returns>true if ProxyHost property is set</returns>
        public Boolean IsSetProxyHost()
        {
            return this.proxyHost != null;
        }

        /// <summary>
        /// Gets and sets of the ProxyPort property.
        /// </summary>
        public int ProxyPort
        {
            get { return this.proxyPort; }
            set { this.proxyPort = value; }
        }

        /// <summary>
        /// Sets the ProxyPort property
        /// </summary>
        /// <param name="proxyPort">ProxyPort property</param>
        /// <returns>this instance</returns>
        public MarketplaceWebServiceConfig WithProxyPort(int proxyPort)
        {
            this.proxyPort = proxyPort;
            return this;
        }

        /// <summary>
        /// Checks if ProxyPort property is set
        /// </summary>
        /// <returns>true if ProxyPort property is set</returns>
        public Boolean IsSetProxyPort()
        {
            return this.proxyPort != -1;
        }

        /// <summary>
        /// Gets and sets of the MaxErrorRetry property.
        /// </summary>
        public int MaxErrorRetry
        {
            get { return this.maxErrorRetry; }
            set { this.maxErrorRetry = value; }
        }

        /// <summary>
        /// Sets the MaxErrorRetry property
        /// </summary>
        /// <param name="maxErrorRetry">MaxErrorRetry property</param>
        /// <returns>this instance</returns>
        public MarketplaceWebServiceConfig WithMaxErrorRetry(int maxErrorRetry)
        {
            this.maxErrorRetry = maxErrorRetry;
            return this;
        }

        /// <summary>
        /// Checks if MaxErrorRetry property is set
        /// </summary>
        /// <returns>true if MaxErrorRetry property is set</returns>
        public Boolean IsSetMaxErrorRetry()
        {
            return this.maxErrorRetry != -1;
        }

        public void SetUserAgentHeader(
            string applicationName,
            string applicationVersion,
            string programmingLanguage,
            params string[] additionalNameValuePairs)
        {
            if (applicationName == null)
            {
                throw new ArgumentNullException("applicationName cannot be null.");
            }

            if (applicationVersion == null)
            {
                throw new ArgumentNullException("applicationVersion cannot be null.");
            }

            if (programmingLanguage == null)
            {
                throw new ArgumentNullException("programmingLanguage cannot be null.");
            }

            if (additionalNameValuePairs.Length % 2 != 0)
            {
                throw new ArgumentException("Every name must have a corresponding value.");
            }

            StringBuilder sb = new StringBuilder();

            sb.Append(QuoteApplicationName(applicationName));
            sb.Append("/");
            sb.Append(QuoteApplicationVersion(applicationVersion));
            sb.Append(" (");
            sb.Append("Language=");
            sb.Append(QuoteAttributeValue(programmingLanguage));

            int i = 0;
            while (i < additionalNameValuePairs.Length)
            {
                string name = additionalNameValuePairs[i];
                string value = additionalNameValuePairs[++i];
                sb.Append("; ");
                sb.Append(QuoteAttributeName(name));
                sb.Append("=");
                sb.Append(QuoteAttributeValue(value));

                i++;
            }

            sb.Append(")");

            this.userAgent = sb.ToString();
        }

        /// <summary>
        /// Replace all whitespace characters by a single space.
        /// </summary>
        public static string Clean(string s)
        {
            // matched character sequences are passed to a MatchEvaluator
            // delegate. The returned string from the delegate replaces
            // the matched sequence.
            return Regex.Replace(s, @" {2,}|\s", delegate(Match m)
            {
                return  " ";
            });
        }

        /// <summary>
        /// Collapse whitespace, and escape the following characters are escaped:
        /// '\', and '/'.
        /// </summary>
        public static string QuoteApplicationName(string s)
        {
            return Clean(s).Replace(@"\", @"\\").Replace("@/", @"\/");
        }

        /// <summary>
        /// Collapse whitespace, and escape the following characters are escaped:
        /// '\', and '('.
        /// </summary>
        public static string QuoteApplicationVersion(string s)
        {
            return Clean(s).Replace(@"\", @"\\").Replace(@"(", @"\(");
        }

        /// <summary>
        /// Collapse whitespace, and escape the following characters are escaped:
        /// '\', and '='.
        /// </summary>
        public static string QuoteAttributeName(string s)
        {
            return Clean(s).Replace(@"\", @"\\").Replace(@"=", @"\=");
        }

        /// <summary>
        /// Collapse whitespace, and escape the following characters are escaped:
        /// ')', '\', and ';'.
        /// </summary>
        public static string QuoteAttributeValue(string s)
        {
            return Clean(s).Replace(@"\", @"\\").Replace(@";", @"\;").Replace(@")", @"\)");
        }
    }
}
