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
 * MWS Subscriptions Service
 * API Version: 2013-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:27:11 GMT 2015
 */

using System;
using Claytondus.AmazonMWS.Runtime;
using Claytondus.AmazonMWS.Subscriptions.Model;

namespace Claytondus.AmazonMWS.Subscriptions
{

    /// <summary>
    /// MWSSubscriptionsServiceClient is an implementation of MWSSubscriptionsService
    /// </summary>
    public class MWSSubscriptionsServiceClient : MWSSubscriptionsService 
    {

        private const string libraryVersion = "2015-06-18";

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
        public MWSSubscriptionsServiceClient(
            string accessKey,
            string secretKey,
            string applicationName,
            string applicationVersion,
            MWSSubscriptionsServiceConfig config)
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
        public MWSSubscriptionsServiceClient(String accessKey, String secretKey, MWSSubscriptionsServiceConfig config)
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
        public MWSSubscriptionsServiceClient(String accessKey, String secretKey)
            : this(accessKey, secretKey, new MWSSubscriptionsServiceConfig())
        {
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        public MWSSubscriptionsServiceClient(
            String accessKey, 
            String secretKey,
            String applicationName,
            String applicationVersion ) 
            : this(accessKey, secretKey, applicationName,
                applicationVersion, new MWSSubscriptionsServiceConfig())
        {
        }

        public CreateSubscriptionResponse CreateSubscription(CreateSubscriptionInput request)
        {
            return connection.Call(
                new MWSSubscriptionsServiceClient.Request<CreateSubscriptionResponse>("CreateSubscription", typeof(CreateSubscriptionResponse), servicePath),
                request);
        }

        public DeleteSubscriptionResponse DeleteSubscription(DeleteSubscriptionInput request)
        {
            return connection.Call(
                new MWSSubscriptionsServiceClient.Request<DeleteSubscriptionResponse>("DeleteSubscription", typeof(DeleteSubscriptionResponse), servicePath),
                request);
        }

        public DeregisterDestinationResponse DeregisterDestination(DeregisterDestinationInput request)
        {
            return connection.Call(
                new MWSSubscriptionsServiceClient.Request<DeregisterDestinationResponse>("DeregisterDestination", typeof(DeregisterDestinationResponse), servicePath),
                request);
        }

        public GetSubscriptionResponse GetSubscription(GetSubscriptionInput request)
        {
            return connection.Call(
                new MWSSubscriptionsServiceClient.Request<GetSubscriptionResponse>("GetSubscription", typeof(GetSubscriptionResponse), servicePath),
                request);
        }

        public ListRegisteredDestinationsResponse ListRegisteredDestinations(ListRegisteredDestinationsInput request)
        {
            return connection.Call(
                new MWSSubscriptionsServiceClient.Request<ListRegisteredDestinationsResponse>("ListRegisteredDestinations", typeof(ListRegisteredDestinationsResponse), servicePath),
                request);
        }

        public ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsInput request)
        {
            return connection.Call(
                new MWSSubscriptionsServiceClient.Request<ListSubscriptionsResponse>("ListSubscriptions", typeof(ListSubscriptionsResponse), servicePath),
                request);
        }

        public RegisterDestinationResponse RegisterDestination(RegisterDestinationInput request)
        {
            return connection.Call(
                new MWSSubscriptionsServiceClient.Request<RegisterDestinationResponse>("RegisterDestination", typeof(RegisterDestinationResponse), servicePath),
                request);
        }

        public SendTestNotificationToDestinationResponse SendTestNotificationToDestination(SendTestNotificationToDestinationInput request)
        {
            return connection.Call(
                new MWSSubscriptionsServiceClient.Request<SendTestNotificationToDestinationResponse>("SendTestNotificationToDestination", typeof(SendTestNotificationToDestinationResponse), servicePath),
                request);
        }

        public UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionInput request)
        {
            return connection.Call(
                new MWSSubscriptionsServiceClient.Request<UpdateSubscriptionResponse>("UpdateSubscription", typeof(UpdateSubscriptionResponse), servicePath),
                request);
        }

        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return connection.Call(
                new MWSSubscriptionsServiceClient.Request<GetServiceStatusResponse>("GetServiceStatus", typeof(GetServiceStatusResponse), servicePath),
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
                return new MWSSubscriptionsServiceException(cause);
            }

            public void SetResponseHeaderMetadata(IMwsObject response, MwsResponseHeaderMetadata rhmd) {
                ((IMWSResponse)response).ResponseHeaderMetadata = new ResponseHeaderMetadata(rhmd);
            }

        }
    }
}
