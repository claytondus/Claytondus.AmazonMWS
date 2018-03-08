/*******************************************************************************
 * Copyright 2009-2016 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * FBA Inventory Service MWS
 * API Version: 2010-10-01
 * Library Version: 2014-09-30
 * Generated: Mon Mar 21 09:01:30 PDT 2016
 */

using System;
using Claytondus.AmazonMWS.FbaInventory.Model;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaInventory
{

    /// <summary>
    /// FBAInventoryServiceMWSClient is an implementation of FBAInventoryServiceMWS
    /// </summary>
    public class FBAInventoryServiceMWSClient : FBAInventoryServiceMWS 
    {

        private const string libraryVersion = "2014-09-30";

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
        public FBAInventoryServiceMWSClient(
            string accessKey,
            string secretKey,
            string applicationName,
            string applicationVersion,
            FBAInventoryServiceMWSConfig config)
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
        public FBAInventoryServiceMWSClient(String accessKey, String secretKey, FBAInventoryServiceMWSConfig config)
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
        public FBAInventoryServiceMWSClient(String accessKey, String secretKey)
            : this(accessKey, secretKey, new FBAInventoryServiceMWSConfig())
        {
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        public FBAInventoryServiceMWSClient(
            String accessKey, 
            String secretKey,
            String applicationName,
            String applicationVersion ) 
            : this(accessKey, secretKey, applicationName,
                applicationVersion, new FBAInventoryServiceMWSConfig())
        {
        }

        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return connection.Call(
                new FBAInventoryServiceMWSClient.Request<GetServiceStatusResponse>("GetServiceStatus", typeof(GetServiceStatusResponse), servicePath),
                request);
        }

        public ListInventorySupplyResponse ListInventorySupply(ListInventorySupplyRequest request)
        {
            return connection.Call(
                new FBAInventoryServiceMWSClient.Request<ListInventorySupplyResponse>("ListInventorySupply", typeof(ListInventorySupplyResponse), servicePath),
                request);
        }

        public ListInventorySupplyByNextTokenResponse ListInventorySupplyByNextToken(ListInventorySupplyByNextTokenRequest request)
        {
            return connection.Call(
                new FBAInventoryServiceMWSClient.Request<ListInventorySupplyByNextTokenResponse>("ListInventorySupplyByNextToken", typeof(ListInventorySupplyByNextTokenResponse), servicePath),
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
                return new FBAInventoryServiceMWSException(cause);
            }

            public void SetResponseHeaderMetadata(IMwsObject response, MwsResponseHeaderMetadata rhmd) {
                ((IMWSResponse)response).ResponseHeaderMetadata = new ResponseHeaderMetadata(rhmd);
            }

        }
    }
}
