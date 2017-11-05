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
 * FBA Outbound Service MWS
 * API Version: 2010-10-01
 * Library Version: 2016-10-19
 * Generated: Wed Oct 19 08:37:54 PDT 2016
 */

using System;
using Claytondus.AmazonMWS.FbaOutbound.Model;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaOutbound
{

    /// <summary>
    /// FBAOutboundServiceMWSClient is an implementation of FBAOutboundServiceMWS
    /// </summary>
    public class FBAOutboundServiceMWSClient : FBAOutboundServiceMWS 
    {

        private const string libraryVersion = "2016-10-19";

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
        public FBAOutboundServiceMWSClient(
            string accessKey,
            string secretKey,
            string applicationName,
            string applicationVersion,
            FBAOutboundServiceMWSConfig config)
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
        public FBAOutboundServiceMWSClient(String accessKey, String secretKey, FBAOutboundServiceMWSConfig config)
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
        public FBAOutboundServiceMWSClient(String accessKey, String secretKey)
            : this(accessKey, secretKey, new FBAOutboundServiceMWSConfig())
        {
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        public FBAOutboundServiceMWSClient(
            String accessKey, 
            String secretKey,
            String applicationName,
            String applicationVersion ) 
            : this(accessKey, secretKey, applicationName,
                applicationVersion, new FBAOutboundServiceMWSConfig())
        {
        }

        public CancelFulfillmentOrderResponse CancelFulfillmentOrder(CancelFulfillmentOrderRequest request)
        {
            return connection.Call(
                new FBAOutboundServiceMWSClient.Request<CancelFulfillmentOrderResponse>("CancelFulfillmentOrder", typeof(CancelFulfillmentOrderResponse), servicePath),
                request);
        }

        public CreateFulfillmentOrderResponse CreateFulfillmentOrder(CreateFulfillmentOrderRequest request)
        {
            return connection.Call(
                new FBAOutboundServiceMWSClient.Request<CreateFulfillmentOrderResponse>("CreateFulfillmentOrder", typeof(CreateFulfillmentOrderResponse), servicePath),
                request);
        }

        public CreateFulfillmentReturnResponse CreateFulfillmentReturn(CreateFulfillmentReturnRequest request)
        {
            return connection.Call(
                new FBAOutboundServiceMWSClient.Request<CreateFulfillmentReturnResponse>("CreateFulfillmentReturn", typeof(CreateFulfillmentReturnResponse), servicePath),
                request);
        }

        public GetFulfillmentOrderResponse GetFulfillmentOrder(GetFulfillmentOrderRequest request)
        {
            return connection.Call(
                new FBAOutboundServiceMWSClient.Request<GetFulfillmentOrderResponse>("GetFulfillmentOrder", typeof(GetFulfillmentOrderResponse), servicePath),
                request);
        }

        public GetFulfillmentPreviewResponse GetFulfillmentPreview(GetFulfillmentPreviewRequest request)
        {
            return connection.Call(
                new FBAOutboundServiceMWSClient.Request<GetFulfillmentPreviewResponse>("GetFulfillmentPreview", typeof(GetFulfillmentPreviewResponse), servicePath),
                request);
        }

        public GetPackageTrackingDetailsResponse GetPackageTrackingDetails(GetPackageTrackingDetailsRequest request)
        {
            return connection.Call(
                new FBAOutboundServiceMWSClient.Request<GetPackageTrackingDetailsResponse>("GetPackageTrackingDetails", typeof(GetPackageTrackingDetailsResponse), servicePath),
                request);
        }

        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return connection.Call(
                new FBAOutboundServiceMWSClient.Request<GetServiceStatusResponse>("GetServiceStatus", typeof(GetServiceStatusResponse), servicePath),
                request);
        }

        public ListAllFulfillmentOrdersResponse ListAllFulfillmentOrders(ListAllFulfillmentOrdersRequest request)
        {
            return connection.Call(
                new FBAOutboundServiceMWSClient.Request<ListAllFulfillmentOrdersResponse>("ListAllFulfillmentOrders", typeof(ListAllFulfillmentOrdersResponse), servicePath),
                request);
        }

        public ListAllFulfillmentOrdersByNextTokenResponse ListAllFulfillmentOrdersByNextToken(ListAllFulfillmentOrdersByNextTokenRequest request)
        {
            return connection.Call(
                new FBAOutboundServiceMWSClient.Request<ListAllFulfillmentOrdersByNextTokenResponse>("ListAllFulfillmentOrdersByNextToken", typeof(ListAllFulfillmentOrdersByNextTokenResponse), servicePath),
                request);
        }

        public ListReturnReasonCodesResponse ListReturnReasonCodes(ListReturnReasonCodesRequest request)
        {
            return connection.Call(
                new FBAOutboundServiceMWSClient.Request<ListReturnReasonCodesResponse>("ListReturnReasonCodes", typeof(ListReturnReasonCodesResponse), servicePath),
                request);
        }

        public UpdateFulfillmentOrderResponse UpdateFulfillmentOrder(UpdateFulfillmentOrderRequest request)
        {
            return connection.Call(
                new FBAOutboundServiceMWSClient.Request<UpdateFulfillmentOrderResponse>("UpdateFulfillmentOrder", typeof(UpdateFulfillmentOrderResponse), servicePath),
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
                return new FBAOutboundServiceMWSException(cause);
            }

            public void SetResponseHeaderMetadata(IMwsObject response, MwsResponseHeaderMetadata rhmd) {
                ((IMWSResponse)response).ResponseHeaderMetadata = new ResponseHeaderMetadata(rhmd);
            }

        }
    }
}
