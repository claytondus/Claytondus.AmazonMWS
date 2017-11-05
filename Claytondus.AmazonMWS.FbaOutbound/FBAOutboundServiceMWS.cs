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

using Claytondus.AmazonMWS.FbaOutbound.Model;

namespace Claytondus.AmazonMWS.FbaOutbound
{

    /// <summary>
    /// Outbound fulfillment service
    /// </summary>
    public interface FBAOutboundServiceMWS 
    {

        /// <summary>
        /// Cancel Fulfillment Order
        /// </summary>
        /// <param name="request">CancelFulfillmentOrderRequest request.</param>
        /// <returns>CancelFulfillmentOrderResponse response</returns>
        /// <remarks>
        /// Request for Amazon to no longer attempt to fulfill an existing
        ///   fulfillment order. Amazon will attempt to stop fulfillment of all
        ///   items that haven't already shipped, but cannot guarantee success.
        ///   Note: Items that have already shipped cannot be cancelled.
        /// </remarks>
        CancelFulfillmentOrderResponse CancelFulfillmentOrder(CancelFulfillmentOrderRequest request);

        /// <summary>
        /// Create Fulfillment Order
        /// </summary>
        /// <param name="request">CreateFulfillmentOrderRequest request.</param>
        /// <returns>CreateFulfillmentOrderResponse response</returns>
        /// <remarks>
        /// The SellerFulfillmentOrderId must be unique for all fulfillment
        ///   orders created by the seller. If your system already has a
        ///   unique order identifier, then that may be a good value to put in
        ///   this field.
        /// 
        ///   This DisplayableOrderDateTime will appear as the "order date" in
        ///   recipient-facing materials such as the packing slip.  The format
        ///   must be timestamp.
        /// 
        /// 
        ///   The DisplayableOrderId will appear as the "order id" in those
        ///   materials, and the DisplayableOrderComment will appear as well.
        ///   
        ///   ShippingSpeedCategory is the Service Level Agreement for how long it
        ///   will take a shipment to be transported from the fulfillment center
        ///   to the recipient, once shipped. no default.
        ///   The following shipping speeds are available for US domestic:
        ///    * Standard, 3-5 business days
        ///    * Expedited, 2 business days
        ///    * Priority, 1 business day
        /// 
        ///   Shipping speeds may vary elsewhere.  Please consult your manual for published SLAs.
        /// 
        /// 
        ///   DestinationAddress is the address the items will be shipped to.
        /// 
        ///   FulfillmentPolicy indicates how unfulfillable items should be 
        ///   handled. default is FillOrKill.
        ///    * FillOrKill if any item is determined to be unfulfillable
        ///      before any items have started shipping, the entire order is
        ///      considered unfulfillable.  Once any part of the order has
        ///      started shipping, as much of the order as possible will be
        ///      shipped.
        ///    * FillAll never consider any item unfulfillable.  Items must
        ///      either be fulfilled or merchant-cancelled.
        ///    * FillAllAvailable fulfill as much of the order as possible.
        ///   
        ///   FulfillmentMethod indicates the intended recipient channel for the 
        ///   order whether it be a consumer order or inventory return.
        ///   default is Consumer.
        ///   The available methods to fulfill a given order:
        ///    * Consumer indicates a customer order, this is the default.
        ///    * Removal indicates that the inventory should be returned to the
        ///      specified destination address.
        ///   
        ///   
        ///   NotificationEmailList can be used to provide a list of e-mail 
        ///   addresses to receive ship-complete e-mail notifications. These 
        ///   e-mails are customer-facing e-mails sent by FBA on behalf of 
        ///   the seller.
        /// </remarks>
        CreateFulfillmentOrderResponse CreateFulfillmentOrder(CreateFulfillmentOrderRequest request);

        /// <summary>
        /// Create Fulfillment Return
        /// </summary>
        /// <param name="request">CreateFulfillmentReturnRequest request.</param>
        /// <returns>CreateFulfillmentReturnResponse response</returns>
        /// <remarks>
        /// Requests a return of one or more items that were 
        ///   originally fulfilled by SI. The client must look at
        ///   the item/authorization list details in the response
        ///   to determine what was accepted. All accepted returned 
        ///   items will be returned as a list in ReturnItemList. 
        ///   All non-returnable items are return as a list in InvalidReturnItemList. 
        ///   Both lists will always be returned as part of the response. If all 
        ///   items are accepted for return InvalidReturnItemList will be empty. If all 
        ///   the items are invalid for a return, ReturnItemList will be empty. 
        ///   If all the items are invalid for a return, ReturnItemList will be empty.
        /// </remarks>
        CreateFulfillmentReturnResponse CreateFulfillmentReturn(CreateFulfillmentReturnRequest request);

        /// <summary>
        /// Get Fulfillment Order
        /// </summary>
        /// <param name="request">GetFulfillmentOrderRequest request.</param>
        /// <returns>GetFulfillmentOrderResponse response</returns>
        /// <remarks>
        /// Get detailed information about a FulfillmentOrder.  This includes the
        ///   original fulfillment order request, the status of the order and its
        ///   items in Amazon's fulfillment network, and the shipments that have been
        ///   generated to fulfill the order.
        /// </remarks>
        GetFulfillmentOrderResponse GetFulfillmentOrder(GetFulfillmentOrderRequest request);

        /// <summary>
        /// Get Fulfillment Preview
        /// </summary>
        /// <param name="request">GetFulfillmentPreviewRequest request.</param>
        /// <returns>GetFulfillmentPreviewResponse response</returns>
        /// <remarks>
        /// Get estimated shipping dates and fees for all 
        ///   available shipping speed given a set of seller SKUs and quantities      
        /// 
        ///   If "ShippingSpeedCategories" are inputed, only previews for those options will be returned. 
        ///   
        ///   If "ShippingSpeedCategories" are not inputed, then previews for all available options 
        ///   are returned.
        /// 
        ///   The service will return the fulfillment estimates for a set of Seller 
        ///   SKUs and quantities.
        /// </remarks>
        GetFulfillmentPreviewResponse GetFulfillmentPreview(GetFulfillmentPreviewRequest request);

        /// <summary>
        /// Get Package Tracking Details
        /// </summary>
        /// <param name="request">GetPackageTrackingDetailsRequest request.</param>
        /// <returns>GetPackageTrackingDetailsResponse response</returns>
        /// <remarks>
        /// Gets the tracking details for a shipment package.
        /// </remarks>
        GetPackageTrackingDetailsResponse GetPackageTrackingDetails(GetPackageTrackingDetailsRequest request);

        /// <summary>
        /// Get Service Status
        /// </summary>
        /// <param name="request">GetServiceStatusRequest request.</param>
        /// <returns>GetServiceStatusResponse response</returns>
        /// <remarks>
        /// Request to poll the system for availability.
        ///   Status is one of GREEN, RED representing:
        ///   GREEN: The service section is operating normally.
        ///   RED: The service section disruption.
        /// </remarks>
        GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request);

        /// <summary>
        /// List All Fulfillment Orders
        /// </summary>
        /// <param name="request">ListAllFulfillmentOrdersRequest request.</param>
        /// <returns>ListAllFulfillmentOrdersResponse response</returns>
        /// <remarks>
        /// Gets the first set of fulfillment orders that are currently being
        ///   fulfilled or that were being fulfilled at some time in the past
        ///   (as specified by the query parameters). Also returns a NextToken
        ///   which can be used iterate through the remaining fulfillment orders
        ///   (via the ListAllFulfillmentOrdersByNextToken operation).
        /// 
        ///   If a NextToken is not returned, it indicates the end-of-data.
        ///   
        ///   If the QueryStartDateTime is set, the results will include all orders
        ///   currently being fulfilled, and all orders that were being fulfilled
        ///   since that date and time.
        /// </remarks>
        ListAllFulfillmentOrdersResponse ListAllFulfillmentOrders(ListAllFulfillmentOrdersRequest request);

        /// <summary>
        /// List All Fulfillment Orders By Next Token
        /// </summary>
        /// <param name="request">ListAllFulfillmentOrdersByNextTokenRequest request.</param>
        /// <returns>ListAllFulfillmentOrdersByNextTokenResponse response</returns>
        /// <remarks>
        /// Gets the next set of fulfillment orders that are currently being
        ///   being fulfilled or that were being fulfilled at some time in the
        ///   past.
        /// 
        ///   If a NextToken is not returned, it indicates the end-of-data.
        /// </remarks>
        ListAllFulfillmentOrdersByNextTokenResponse ListAllFulfillmentOrdersByNextToken(ListAllFulfillmentOrdersByNextTokenRequest request);

        /// <summary>
        /// List Return Reason Codes
        /// </summary>
        /// <param name="request">ListReturnReasonCodesRequest request.</param>
        /// <returns>ListReturnReasonCodesResponse response</returns>
        /// <remarks>
        /// This operation will result in a list of eligible return reasons for
        ///   a given SKU and original ordering country. The eligible return reasons 
        ///   may vary from country to country.
        /// </remarks>
        ListReturnReasonCodesResponse ListReturnReasonCodes(ListReturnReasonCodesRequest request);

        /// <summary>
        /// Update Fulfillment Order
        /// </summary>
        /// <param name="request">UpdateFulfillmentOrderRequest request.</param>
        /// <returns>UpdateFulfillmentOrderResponse response</returns>
        /// <remarks>
        /// The SellerFulfillmentOrderId must be the order ID of the original
        ///     order that needs to be updated.
        /// 
        ///   This DisplayableOrderDateTime will appear as the "order date" in
        ///   recipient-facing materials such as the packing slip.  The format
        ///   must be timestamp.
        /// 
        ///   The DisplayableOrderId will appear as the "order id" in those
        ///   materials, and the DisplayableOrderComment will appear as well.
        ///   
        ///   ShippingSpeedCategory is the Service Level Agreement for how long it
        ///   will take a shipment to be transported from the fulfillment center
        ///   to the recipient, once shipped. no default.
        ///   The following shipping speeds are available for US domestic:
        ///    * Standard, 3-5 business days
        ///    * Expedited, 2 business days
        ///    * Priority, 1 business day
        /// 
        ///   Shipping speeds may vary elsewhere.  Please consult your manual for published SLAs.
        /// 
        /// 
        ///   DestinationAddress is the address the items will be shipped to.
        ///   
        ///   FulfillmentAction indicates whether an order will be held or shipped. 
        ///   Default is Hold. 
        ///   * Hold if the order needs to be held but does not need to be shipped. 
        ///   * Ship if the order is to be fulfilled and shipped out to the customer
        ///   immediately. 
        /// 
        ///   FulfillmentPolicy indicates how unfulfillable items should be 
        ///   handled. default is FillOrKill.
        ///    * FillOrKill if any item is determined to be unfulfillable
        ///      before any items have started shipping, the entire order is
        ///      considered unfulfillable.  Once any part of the order has
        ///      started shipping, as much of the order as possible will be
        ///      shipped.
        ///    * FillAll never consider any item unfulfillable.  Items must
        ///      either be fulfilled or merchant-cancelled.
        ///    * FillAllAvailable fulfill as much of the order as possible.
        ///   
        ///   NotificationEmailList can be used to provide a list of e-mail 
        ///   addresses to receive ship-complete e-mail notifications. These 
        ///   e-mails are customer-facing e-mails sent by FBA on behalf of 
        ///   the seller.
        /// </remarks>
        UpdateFulfillmentOrderResponse UpdateFulfillmentOrder(UpdateFulfillmentOrderRequest request);

    }
}
