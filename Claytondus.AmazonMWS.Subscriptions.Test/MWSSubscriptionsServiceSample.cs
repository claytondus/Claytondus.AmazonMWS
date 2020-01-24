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
using System.Collections.Generic;
using Claytondus.AmazonMWS.Subscriptions.Model;

namespace Claytondus.AmazonMWS.Subscriptions.Test {

    /// <summary>
    /// Runnable sample code to demonstrate usage of the C# client.
    ///
    /// To use, import the client source as a console application,
    /// and mark this class as the startup object. Then, replace
    /// parameters below with sensible values and run.
    /// </summary>
    public class MWSSubscriptionsServiceSample {

        public static void Main(string[] args)
        {
            // TODO: Set the below configuration variables before attempting to run

            // Developer AWS access key
            string accessKey = "replaceWithAccessKey";

            // Developer AWS secret key
            string secretKey = "replaceWithSecretKey";

            // The client application name
            string appName = "CSharpSampleCode";

            // The client application version
            string appVersion = "1.0";

            // The endpoint for region service and version (see developer guide)
            // ex: https://mws.amazonservices.com
            string serviceURL = "replaceWithServiceURL";

            // Create a configuration object
            MWSSubscriptionsServiceConfig config = new MWSSubscriptionsServiceConfig();
            config.ServiceURL = serviceURL;
            // Set other client connection configurations here if needed
            // Create the client itself
            MWSSubscriptionsService client = new MWSSubscriptionsServiceClient(accessKey, secretKey, appName, appVersion, config);

            MWSSubscriptionsServiceSample sample = new MWSSubscriptionsServiceSample(client);

            // Uncomment the operation you'd like to test here
            // TODO: Modify the request created in the Invoke method to be valid

            try 
            {
                IMWSResponse response = null;
                // response = sample.InvokeCreateSubscription();
                // response = sample.InvokeDeleteSubscription();
                // response = sample.InvokeDeregisterDestination();
                // response = sample.InvokeGetSubscription();
                // response = sample.InvokeListRegisteredDestinations();
                // response = sample.InvokeListSubscriptions();
                // response = sample.InvokeRegisterDestination();
                // response = sample.InvokeSendTestNotificationToDestination();
                // response = sample.InvokeUpdateSubscription();
                // response = sample.InvokeGetServiceStatus();
                Console.WriteLine("Response:");
                ResponseHeaderMetadata rhmd = response.ResponseHeaderMetadata;
                // We recommend logging the request id and timestamp of every call.
                Console.WriteLine("RequestId: " + rhmd.RequestId);
                Console.WriteLine("Timestamp: " + rhmd.Timestamp);
                string responseXml = response.ToXML();
                Console.WriteLine(responseXml);
            }
            catch (MWSSubscriptionsServiceException ex)
            {
                // Exception properties are important for diagnostics.
                ResponseHeaderMetadata rhmd = ex.ResponseHeaderMetadata;
                Console.WriteLine("Service Exception:");
                if(rhmd != null)
                {
                    Console.WriteLine("RequestId: " + rhmd.RequestId);
                    Console.WriteLine("Timestamp: " + rhmd.Timestamp);
                }
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("StatusCode: " + ex.StatusCode);
                Console.WriteLine("ErrorCode: " + ex.ErrorCode);
                Console.WriteLine("ErrorType: " + ex.ErrorType);
                throw ex;
            }
        }

        private readonly MWSSubscriptionsService client;

        public MWSSubscriptionsServiceSample(MWSSubscriptionsService client)
        {
            this.client = client;
        }

        public CreateSubscriptionResponse InvokeCreateSubscription()
        {
            // Create a request.
            CreateSubscriptionInput request = new CreateSubscriptionInput();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            Subscription subscription = new Subscription();
            request.Subscription = subscription;
            return this.client.CreateSubscription(request);
        }

        public DeleteSubscriptionResponse InvokeDeleteSubscription()
        {
            // Create a request.
            DeleteSubscriptionInput request = new DeleteSubscriptionInput();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            string notificationType = "example";
            request.NotificationType = notificationType;
            Destination destination = new Destination();
            request.Destination = destination;
            return this.client.DeleteSubscription(request);
        }

        public DeregisterDestinationResponse InvokeDeregisterDestination()
        {
            // Create a request.
            DeregisterDestinationInput request = new DeregisterDestinationInput();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            Destination destination = new Destination();
            request.Destination = destination;
            return this.client.DeregisterDestination(request);
        }

        public GetSubscriptionResponse InvokeGetSubscription()
        {
            // Create a request.
            GetSubscriptionInput request = new GetSubscriptionInput();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            string notificationType = "example";
            request.NotificationType = notificationType;
            Destination destination = new Destination();
            request.Destination = destination;
            return this.client.GetSubscription(request);
        }

        public ListRegisteredDestinationsResponse InvokeListRegisteredDestinations()
        {
            // Create a request.
            ListRegisteredDestinationsInput request = new ListRegisteredDestinationsInput();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            return this.client.ListRegisteredDestinations(request);
        }

        public ListSubscriptionsResponse InvokeListSubscriptions()
        {
            // Create a request.
            ListSubscriptionsInput request = new ListSubscriptionsInput();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            return this.client.ListSubscriptions(request);
        }

        public RegisterDestinationResponse InvokeRegisterDestination()
        {
            // Create a request.
            RegisterDestinationInput request = new RegisterDestinationInput();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            Destination destination = new Destination();
            request.Destination = destination;
            return this.client.RegisterDestination(request);
        }

        public SendTestNotificationToDestinationResponse InvokeSendTestNotificationToDestination()
        {
            // Create a request.
            SendTestNotificationToDestinationInput request = new SendTestNotificationToDestinationInput();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            Destination destination = new Destination();
            request.Destination = destination;
            return this.client.SendTestNotificationToDestination(request);
        }

        public UpdateSubscriptionResponse InvokeUpdateSubscription()
        {
            // Create a request.
            UpdateSubscriptionInput request = new UpdateSubscriptionInput();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            Subscription subscription = new Subscription();
            request.Subscription = subscription;
            return this.client.UpdateSubscription(request);
        }

        public GetServiceStatusResponse InvokeGetServiceStatus()
        {
            // Create a request.
            GetServiceStatusRequest request = new GetServiceStatusRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            return this.client.GetServiceStatus(request);
        }


    }
}
