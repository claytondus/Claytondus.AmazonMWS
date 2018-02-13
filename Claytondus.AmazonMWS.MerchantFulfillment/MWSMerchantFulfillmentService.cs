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

using Claytondus.AmazonMWS.MerchantFulfillment.Model;

namespace Claytondus.AmazonMWS.MerchantFulfillment
{

    /// <summary>
    /// This is the Merchant Fulfillment API section of the Marketplace Web Service.  It allows clients to view shipping services that meet the specific criteria.  Also, it allows clients to create shipments that result in a shipping label being generated (and paid for by the seller).  Lastly, clients can cancel the label and according to different carrier rules get refunds for their unused labels.
    /// </summary>
    public interface MWSMerchantFulfillmentService 
    {

        /// <summary>
        /// Cancel Shipment
        /// </summary>
        /// <param name="request">CancelShipmentRequest request.</param>
        /// <returns>CancelShipmentResponse response</returns>
        /// <remarks>
        /// Cancels an existing shipment.  This will only succeed if the cancellation window has not passed and if the shipment
        ///     has not been cancelled already.
        /// </remarks>
        CancelShipmentResponse CancelShipment(CancelShipmentRequest request);

        /// <summary>
        /// Create Shipment
        /// </summary>
        /// <param name="request">CreateShipmentRequest request.</param>
        /// <returns>CreateShipmentResponse response</returns>
        /// <remarks>
        /// Creates a shipment for the shipping information specified.  Purchases and returns a label for the specified
        ///     shipping service or shipping service offering.
        /// </remarks>
        CreateShipmentResponse CreateShipment(CreateShipmentRequest request);

        /// <summary>
        /// Get Eligible Shipping Services
        /// </summary>
        /// <param name="request">GetEligibleShippingServicesRequest request.</param>
        /// <returns>GetEligibleShippingServicesResponse response</returns>
        /// <remarks>
        /// Gets a list of eligible shipping services for the shipment information specified.  The ShippingServiceId or
        ///     ShippingServiceOfferingId can be used in CreateShipment to specify the shipping service or the specific offer
        ///     respectively.  A list of carriers that are temporarily unavailable is also returned.
        /// </remarks>
        GetEligibleShippingServicesResponse GetEligibleShippingServices(GetEligibleShippingServicesRequest request);

        /// <summary>
        /// Get Shipment
        /// </summary>
        /// <param name="request">GetShipmentRequest request.</param>
        /// <returns>GetShipmentResponse response</returns>
        /// <remarks>
        /// Gets an existing shipment, including the label status, label content, shipping information.
        /// </remarks>
        GetShipmentResponse GetShipment(GetShipmentRequest request);

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
