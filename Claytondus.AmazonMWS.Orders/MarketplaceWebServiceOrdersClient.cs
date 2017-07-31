/*******************************************************************************
 * Copyright 2009-2017 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Marketplace Web Service Orders
 * API Version: 2013-09-01
 * Library Version: 2017-02-22
 * Generated: Thu Mar 02 12:41:05 UTC 2017
 */

using System;
using Claytondus.AmazonMWS.Runtime;
using Claytondus.AmazonMWS.Orders.Model;

namespace Claytondus.AmazonMWS.Orders
{

    /// <summary>
    /// MarketplaceWebServiceOrdersClient is an implementation of MarketplaceWebServiceOrders
    /// </summary>
    public class MarketplaceWebServiceOrdersClient : MarketplaceWebServiceOrders 
    {

        private const string libraryVersion = "2017-02-22";

        private string servicePath;

        private MwsConnection connection;

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        /// <param name="config">configuration</param>
        public MarketplaceWebServiceOrdersClient(
            string accessKey,
            string secretKey,
            string applicationName,
            string applicationVersion,
            MarketplaceWebServiceOrdersConfig config)
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
        public MarketplaceWebServiceOrdersClient(String accessKey, String secretKey, MarketplaceWebServiceOrdersConfig config)
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
        public MarketplaceWebServiceOrdersClient(String accessKey, String secretKey)
            : this(accessKey, secretKey, new MarketplaceWebServiceOrdersConfig())
        {
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        public MarketplaceWebServiceOrdersClient(
            String accessKey, 
            String secretKey,
            String applicationName,
            String applicationVersion ) 
            : this(accessKey, secretKey, applicationName,
                applicationVersion, new MarketplaceWebServiceOrdersConfig())
        {
        }

        public GetOrderResponse GetOrder(GetOrderRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceOrdersClient.Request<GetOrderResponse>("GetOrder", typeof(GetOrderResponse), servicePath),
                request);
        }

        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceOrdersClient.Request<GetServiceStatusResponse>("GetServiceStatus", typeof(GetServiceStatusResponse), servicePath),
                request);
        }

        public ListOrderItemsResponse ListOrderItems(ListOrderItemsRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceOrdersClient.Request<ListOrderItemsResponse>("ListOrderItems", typeof(ListOrderItemsResponse), servicePath),
                request);
        }

        public ListOrderItemsByNextTokenResponse ListOrderItemsByNextToken(ListOrderItemsByNextTokenRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceOrdersClient.Request<ListOrderItemsByNextTokenResponse>("ListOrderItemsByNextToken", typeof(ListOrderItemsByNextTokenResponse), servicePath),
                request);
        }

        public ListOrdersResponse ListOrders(ListOrdersRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceOrdersClient.Request<ListOrdersResponse>("ListOrders", typeof(ListOrdersResponse), servicePath),
                request);
        }

        public ListOrdersByNextTokenResponse ListOrdersByNextToken(ListOrdersByNextTokenRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceOrdersClient.Request<ListOrdersByNextTokenResponse>("ListOrdersByNextToken", typeof(ListOrdersByNextTokenResponse), servicePath),
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
                return new MarketplaceWebServiceOrdersException(cause);
            }

            public void SetResponseHeaderMetadata(IMwsObject response, MwsResponseHeaderMetadata rhmd) {
                ((IMWSResponse)response).ResponseHeaderMetadata = new ResponseHeaderMetadata(rhmd);
            }

        }
    }
}
