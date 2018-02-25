/*******************************************************************************
 * Copyright 2009-2015 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Marketplace Web Service Sellers
 * API Version: 2011-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 20:37:46 GMT 2015
 */

using System;
using Claytondus.AmazonMWS.Runtime;
using Claytondus.AmazonMWS.Sellers.Model;

namespace Claytondus.AmazonMWS.Sellers
{

    /// <summary>
    /// MarketplaceWebServiceSellersClient is an implementation of MarketplaceWebServiceSellers
    /// </summary>
    public class MarketplaceWebServiceSellersClient : MarketplaceWebServiceSellers 
    {

        private const string libraryVersion = "2015-06-18";

        private string servicePath;

        private MwsConnection connection;

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>        
        /// <param name="accessKey">Access Key</param>  
        /// <param name="secretKey">Secret Key</param>
        /// <param name="config">configuration</param>
        public MarketplaceWebServiceSellersClient(
            string applicationName,
            string applicationVersion,
            string accessKey,
            string secretKey,            
            MarketplaceWebServiceSellersConfig config)

    
        {
            connection = config.CopyConnection();
            connection.AwsAccessKeyId = accessKey;
            connection.AwsSecretKeyId = secretKey;
            connection.ApplicationName = applicationName;
            connection.ApplicationVersion = applicationVersion;
            connection.LibraryVersion = libraryVersion;
            servicePath = config.ServicePath;
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="config">configuration</param>
        public MarketplaceWebServiceSellersClient(String accessKey, String secretKey, MarketplaceWebServiceSellersConfig config)
        {
            connection = config.CopyConnection();
            connection.AwsAccessKeyId = accessKey;
            connection.AwsSecretKeyId = secretKey;
            connection.LibraryVersion = libraryVersion;
            servicePath = config.ServicePath;
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        public MarketplaceWebServiceSellersClient(String accessKey, String secretKey)
            : this(accessKey, secretKey, new MarketplaceWebServiceSellersConfig())
        {
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        public MarketplaceWebServiceSellersClient(
            String accessKey, 
            String secretKey,
            String applicationName,
            String applicationVersion ) 
            : this(accessKey, secretKey, applicationName,
                applicationVersion, new MarketplaceWebServiceSellersConfig())
        {
        }

        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceSellersClient.Request<GetServiceStatusResponse>("GetServiceStatus", typeof(GetServiceStatusResponse), servicePath),
                request);
        }

        public ListMarketplaceParticipationsResponse ListMarketplaceParticipations(ListMarketplaceParticipationsRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceSellersClient.Request<ListMarketplaceParticipationsResponse>("ListMarketplaceParticipations", typeof(ListMarketplaceParticipationsResponse), servicePath),
                request);
        }

        public ListMarketplaceParticipationsByNextTokenResponse ListMarketplaceParticipationsByNextToken(ListMarketplaceParticipationsByNextTokenRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceSellersClient.Request<ListMarketplaceParticipationsByNextTokenResponse>("ListMarketplaceParticipationsByNextToken", typeof(ListMarketplaceParticipationsByNextTokenResponse), servicePath),
                request);
        }

        private class Request<R> : IMwsRequestType<R> where R : IMwsObject
        {
            private string operationName;
            private Type responseClass;
            private string servicePath;

            public Request(string operationName, Type responseClass, string servicePath) {
                this.operationName = operationName;
                this.responseClass = responseClass;
                this.servicePath = servicePath;
            }

            public string ServicePath
            {
                get { return servicePath; }
            }

            public string OperationName
            {
                get { return operationName; }
            }

            public Type ResponseClass
            {
                get { return responseClass; }
            }

            public MwsException WrapException(Exception cause) {
                return new MarketplaceWebServiceSellersException(cause);
            }

            public void SetResponseHeaderMetadata(IMwsObject response, MwsResponseHeaderMetadata rhmd) {
                ((IMWSResponse)response).ResponseHeaderMetadata = new ResponseHeaderMetadata(rhmd);
            }

        }
    }
}
