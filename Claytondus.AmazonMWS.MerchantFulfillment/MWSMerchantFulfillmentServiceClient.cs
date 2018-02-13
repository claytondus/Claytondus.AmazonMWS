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
 * MWS Merchant Fulfillment Service
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */

using System;
using Claytondus.AmazonMWS.MerchantFulfillment.Model;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment
{

    /// <summary>
    /// MWSMerchantFulfillmentServiceClient is an implementation of MWSMerchantFulfillmentService
    /// </summary>
    public class MWSMerchantFulfillmentServiceClient : MWSMerchantFulfillmentService 
    {

        private const string libraryVersion = "2016-03-30";

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
        public MWSMerchantFulfillmentServiceClient(
            string accessKey,
            string secretKey,
            string applicationName,
            string applicationVersion,
            MWSMerchantFulfillmentServiceConfig config)
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
        public MWSMerchantFulfillmentServiceClient(String accessKey, String secretKey, MWSMerchantFulfillmentServiceConfig config)
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
        public MWSMerchantFulfillmentServiceClient(String accessKey, String secretKey)
            : this(accessKey, secretKey, new MWSMerchantFulfillmentServiceConfig())
        {
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        public MWSMerchantFulfillmentServiceClient(
            String accessKey, 
            String secretKey,
            String applicationName,
            String applicationVersion ) 
            : this(accessKey, secretKey, applicationName,
                applicationVersion, new MWSMerchantFulfillmentServiceConfig())
        {
        }

        public CancelShipmentResponse CancelShipment(CancelShipmentRequest request)
        {
            return connection.Call(
                new MWSMerchantFulfillmentServiceClient.Request<CancelShipmentResponse>("CancelShipment", typeof(CancelShipmentResponse), servicePath),
                request);
        }

        public CreateShipmentResponse CreateShipment(CreateShipmentRequest request)
        {
            return connection.Call(
                new MWSMerchantFulfillmentServiceClient.Request<CreateShipmentResponse>("CreateShipment", typeof(CreateShipmentResponse), servicePath),
                request);
        }

        public GetEligibleShippingServicesResponse GetEligibleShippingServices(GetEligibleShippingServicesRequest request)
        {
            return connection.Call(
                new MWSMerchantFulfillmentServiceClient.Request<GetEligibleShippingServicesResponse>("GetEligibleShippingServices", typeof(GetEligibleShippingServicesResponse), servicePath),
                request);
        }

        public GetShipmentResponse GetShipment(GetShipmentRequest request)
        {
            return connection.Call(
                new MWSMerchantFulfillmentServiceClient.Request<GetShipmentResponse>("GetShipment", typeof(GetShipmentResponse), servicePath),
                request);
        }

        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return connection.Call(
                new MWSMerchantFulfillmentServiceClient.Request<GetServiceStatusResponse>("GetServiceStatus", typeof(GetServiceStatusResponse), servicePath),
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
                return new MWSMerchantFulfillmentServiceException(cause);
            }

            public void SetResponseHeaderMetadata(IMwsObject response, MwsResponseHeaderMetadata rhmd) {
                ((IMWSResponse)response).ResponseHeaderMetadata = new ResponseHeaderMetadata(rhmd);
            }

        }
    }
}
