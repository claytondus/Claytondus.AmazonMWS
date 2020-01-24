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

using Claytondus.AmazonMWS.Subscriptions.Model;

namespace Claytondus.AmazonMWS.Subscriptions
{

    /// <summary>
    /// MWS Subscriptions is a service that provides MWS developers the ability to manage subscriptions that tie a destination, such as
    ///         an SQS queue, to a Notification type, such as offer listing change on Products,for a seller and marketplace.
    /// </summary>
    public interface MWSSubscriptionsService 
    {

        /// <summary>
        /// Create Subscription
        /// </summary>
        /// <param name="request">CreateSubscriptionInput request.</param>
        /// <returns>CreateSubscriptionResponse response</returns>
        /// <remarks>
        /// Create a new subscription.
        /// </remarks>
        CreateSubscriptionResponse CreateSubscription(CreateSubscriptionInput request);

        /// <summary>
        /// Delete Subscription
        /// </summary>
        /// <param name="request">DeleteSubscriptionInput request.</param>
        /// <returns>DeleteSubscriptionResponse response</returns>
        /// <remarks>
        /// Delete a subscription.
        /// </remarks>
        DeleteSubscriptionResponse DeleteSubscription(DeleteSubscriptionInput request);

        /// <summary>
        /// Deregister Destination
        /// </summary>
        /// <param name="request">DeregisterDestinationInput request.</param>
        /// <returns>DeregisterDestinationResponse response</returns>
        /// <remarks>
        /// Delete a destination.
        /// </remarks>
        DeregisterDestinationResponse DeregisterDestination(DeregisterDestinationInput request);

        /// <summary>
        /// Get Subscription
        /// </summary>
        /// <param name="request">GetSubscriptionInput request.</param>
        /// <returns>GetSubscriptionResponse response</returns>
        /// <remarks>
        /// Retrieve subscription information.
        /// </remarks>
        GetSubscriptionResponse GetSubscription(GetSubscriptionInput request);

        /// <summary>
        /// List Registered Destinations
        /// </summary>
        /// <param name="request">ListRegisteredDestinationsInput request.</param>
        /// <returns>ListRegisteredDestinationsResponse response</returns>
        /// <remarks>
        /// List all the destinations for the specified seller created by the developer.
        /// </remarks>
        ListRegisteredDestinationsResponse ListRegisteredDestinations(ListRegisteredDestinationsInput request);

        /// <summary>
        /// List Subscriptions
        /// </summary>
        /// <param name="request">ListSubscriptionsInput request.</param>
        /// <returns>ListSubscriptionsResponse response</returns>
        /// <remarks>
        /// List all the subscriptions for the specified seller created by the current developer.
        /// </remarks>
        ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsInput request);

        /// <summary>
        /// Register Destination
        /// </summary>
        /// <param name="request">RegisterDestinationInput request.</param>
        /// <returns>RegisterDestinationResponse response</returns>
        /// <remarks>
        /// Create a new destination.
        /// </remarks>
        RegisterDestinationResponse RegisterDestination(RegisterDestinationInput request);

        /// <summary>
        /// Send Test Notification To Destination
        /// </summary>
        /// <param name="request">SendTestNotificationToDestinationInput request.</param>
        /// <returns>SendTestNotificationToDestinationResponse response</returns>
        /// <remarks>
        /// Send a test Notification to the specified destination.
        /// </remarks>
        SendTestNotificationToDestinationResponse SendTestNotificationToDestination(SendTestNotificationToDestinationInput request);

        /// <summary>
        /// Update Subscription
        /// </summary>
        /// <param name="request">UpdateSubscriptionInput request.</param>
        /// <returns>UpdateSubscriptionResponse response</returns>
        /// <remarks>
        /// Update a subscription.
        /// </remarks>
        UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionInput request);

        /// <summary>
        /// Get Service Status
        /// </summary>
        /// <param name="request">GetServiceStatusRequest request.</param>
        /// <returns>GetServiceStatusResponse response</returns>
        /// <remarks>
        /// 
        /// </remarks>
        GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request);

    }
}
