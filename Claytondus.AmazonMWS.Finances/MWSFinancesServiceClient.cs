/*******************************************************************************
 * Copyright 2009-2018 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * MWS Finances Service
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */

using System;
using Claytondus.AmazonMWS.Finances.Model;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances
{

    /// <summary>
    /// MWSFinancesServiceClient is an implementation of MWSFinancesService
    /// </summary>
    public class MWSFinancesServiceClient : MWSFinancesService 
    {

        private const string libraryVersion = "2018-02-07";

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
        public MWSFinancesServiceClient(
            string accessKey,
            string secretKey,
            string applicationName,
            string applicationVersion,
            MWSFinancesServiceConfig config)
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
        public MWSFinancesServiceClient(String accessKey, String secretKey, MWSFinancesServiceConfig config)
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
        public MWSFinancesServiceClient(String accessKey, String secretKey)
            : this(accessKey, secretKey, new MWSFinancesServiceConfig())
        {
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        public MWSFinancesServiceClient(
            String accessKey, 
            String secretKey,
            String applicationName,
            String applicationVersion ) 
            : this(accessKey, secretKey, applicationName,
                applicationVersion, new MWSFinancesServiceConfig())
        {
        }

        public ListFinancialEventGroupsResponse ListFinancialEventGroups(ListFinancialEventGroupsRequest request)
        {
            return connection.Call(
                new MWSFinancesServiceClient.Request<ListFinancialEventGroupsResponse>("ListFinancialEventGroups", typeof(ListFinancialEventGroupsResponse), servicePath),
                request);
        }

        public ListFinancialEventGroupsByNextTokenResponse ListFinancialEventGroupsByNextToken(ListFinancialEventGroupsByNextTokenRequest request)
        {
            return connection.Call(
                new MWSFinancesServiceClient.Request<ListFinancialEventGroupsByNextTokenResponse>("ListFinancialEventGroupsByNextToken", typeof(ListFinancialEventGroupsByNextTokenResponse), servicePath),
                request);
        }

        public ListFinancialEventsResponse ListFinancialEvents(ListFinancialEventsRequest request)
        {
            return connection.Call(
                new MWSFinancesServiceClient.Request<ListFinancialEventsResponse>("ListFinancialEvents", typeof(ListFinancialEventsResponse), servicePath),
                request);
        }

        public ListFinancialEventsByNextTokenResponse ListFinancialEventsByNextToken(ListFinancialEventsByNextTokenRequest request)
        {
            return connection.Call(
                new MWSFinancesServiceClient.Request<ListFinancialEventsByNextTokenResponse>("ListFinancialEventsByNextToken", typeof(ListFinancialEventsByNextTokenResponse), servicePath),
                request);
        }

        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return connection.Call(
                new MWSFinancesServiceClient.Request<GetServiceStatusResponse>("GetServiceStatus", typeof(GetServiceStatusResponse), servicePath),
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
                return new MWSFinancesServiceException(cause);
            }

            public void SetResponseHeaderMetadata(IMwsObject response, MwsResponseHeaderMetadata rhmd) {
                ((IMWSResponse)response).ResponseHeaderMetadata = new ResponseHeaderMetadata(rhmd);
            }

        }
    }
}
