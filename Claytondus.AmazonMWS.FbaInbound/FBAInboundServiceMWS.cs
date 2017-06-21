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
 * FBA Inbound Service MWS
 * API Version: 2010-10-01
 * Library Version: 2016-10-05
 * Generated: Wed Oct 05 06:15:39 PDT 2016
 */

using System;
using Claytondus.AmazonMWS.FbaInbound.Model;

namespace Claytondus.AmazonMWS.FbaInbound
{

    /// <summary>
    /// 
    /// </summary>
    public interface FBAInboundServiceMWS 
    {

        /// <summary>
        /// Confirm Preorder
        /// </summary>
        /// <param name="request">ConfirmPreorderRequest request.</param>
        /// <returns>ConfirmPreorderResponse response</returns>
        /// <remarks>
        /// Given a shipment id. and date as input, this API confirms a shipment as a
        /// pre-order.
        /// This date must be the same as the NeedByDate (NBD) that is returned in the
        /// GetPreorderInfo API. Any other date will result in an appropriate error code.
        /// All items in the shipment with a release date on or after the
        /// ConfirmedFulfillableDate ( also returned by the GetPreorderInfo  API) would
        /// be pre-orderable on the website and would be fulfilled without promise breaks,
        /// if the NBD is met.
        /// </remarks>
        ConfirmPreorderResponse ConfirmPreorder(ConfirmPreorderRequest request);

        /// <summary>
        /// Confirm Transport Request
        /// </summary>
        /// <param name="request">ConfirmTransportInputRequest request.</param>
        /// <returns>ConfirmTransportRequestResponse response</returns>
        /// <remarks>
        /// Confirms the estimate returned by the EstimateTransportRequest operation.
        ///     Once this operation has been called successfully, the seller agrees to allow Amazon to charge
        ///     their account the amount returned in the estimate.
        /// </remarks>
        ConfirmTransportRequestResponse ConfirmTransportRequest(ConfirmTransportInputRequest request);

        /// <summary>
        /// Create Inbound Shipment
        /// </summary>
        /// <param name="request">CreateInboundShipmentRequest request.</param>
        /// <returns>CreateInboundShipmentResponse response</returns>
        /// <remarks>
        /// Creates an inbound shipment. It may include up to 200 items. 
        /// The initial status of a shipment will be set to 'Working'.
        /// This operation will simply return a shipment Id upon success,
        /// otherwise an explicit error will be returned.
        /// More items may be added using the Update call.
        /// </remarks>
        CreateInboundShipmentResponse CreateInboundShipment(CreateInboundShipmentRequest request);

        /// <summary>
        /// Create Inbound Shipment Plan
        /// </summary>
        /// <param name="request">CreateInboundShipmentPlanRequest request.</param>
        /// <returns>CreateInboundShipmentPlanResponse response</returns>
        /// <remarks>
        /// Plans inbound shipments for a set of items.  Registers identifiers if needed,
        /// and assigns ShipmentIds for planned shipments.
        /// When all the items are not all in the same category (e.g. some sortable, some 
        /// non-sortable) it may be necessary to create multiple shipments (one for each 
        /// of the shipment groups returned).
        /// </remarks>
        CreateInboundShipmentPlanResponse CreateInboundShipmentPlan(CreateInboundShipmentPlanRequest request);

        /// <summary>
        /// Estimate Transport Request
        /// </summary>
        /// <param name="request">EstimateTransportInputRequest request.</param>
        /// <returns>EstimateTransportRequestResponse response</returns>
        /// <remarks>
        /// Initiates the process for requesting an estimated shipping cost based-on the shipment
        ///     for which the request is being made, whether or not the carrier shipment is partnered/non-partnered
        ///     and the carrier type.
        /// </remarks>
        EstimateTransportRequestResponse EstimateTransportRequest(EstimateTransportInputRequest request);

        /// <summary>
        /// Get Bill Of Lading
        /// </summary>
        /// <param name="request">GetBillOfLadingRequest request.</param>
        /// <returns>GetBillOfLadingResponse response</returns>
        /// <remarks>
        /// Retrieves the PDF-formatted BOL data for a partnered LTL shipment.
        ///     This PDF data will be ZIP'd and then it will be encoded as a Base64 string, and a
        ///     MD5 hash is included with the response to validate the BOL data which will be encoded as Base64.
        /// </remarks>
        GetBillOfLadingResponse GetBillOfLading(GetBillOfLadingRequest request);

        /// <summary>
        /// Get Inbound Guidance For ASIN
        /// </summary>
        /// <param name="request">GetInboundGuidanceForASINRequest request.</param>
        /// <returns>GetInboundGuidanceForASINResponse response</returns>
        /// <remarks>
        /// Given a list of ASINs and shipToCountryCode, this API returns Inbound
        ///      guidance to ASINs in request with optional reason code if applicable.
        /// </remarks>
        GetInboundGuidanceForASINResponse GetInboundGuidanceForASIN(GetInboundGuidanceForASINRequest request);

        /// <summary>
        /// Get Inbound Guidance For SKU
        /// </summary>
        /// <param name="request">GetInboundGuidanceForSKURequest request.</param>
        /// <returns>GetInboundGuidanceForSKUResponse response</returns>
        /// <remarks>
        /// Given a list of SKUs and shipToCountryCode, this API returns Inbound
        ///      guidance to SKUs in request with optional reason code if applicable.
        /// </remarks>
        GetInboundGuidanceForSKUResponse GetInboundGuidanceForSKU(GetInboundGuidanceForSKURequest request);

        /// <summary>
        /// Get Package Labels
        /// </summary>
        /// <param name="request">GetPackageLabelsRequest request.</param>
        /// <returns>GetPackageLabelsResponse response</returns>
        /// <remarks>
        /// Retrieves the PDF-formatted package label data for the packages of the
        ///     shipment. These labels will include relevant data for shipments utilizing 
        ///     Amazon-partnered carriers. The PDF data will be ZIP'd and then it will be encoded as a Base64 string, and
        ///     MD5 hash is included with the response to validate the label data which will be encoded as Base64.
        ///     The language of the address and FC prep instructions sections of the labels are
        ///     determined by the marketplace in which the request is being made and the marketplace of
        ///     the destination FC, respectively.
        ///     
        ///     Only select PageTypes are supported in each marketplace. By marketplace, the
        ///     supported types are:
        ///       * US non-partnered UPS: PackageLabel_Letter_6
        ///       * US partnered-UPS: PackageLabel_Letter_2
        ///       * GB, DE, FR, IT, ES: PackageLabel_A4_4, PackageLabel_Plain_Paper
        ///       * Partnered EU: PackageLabel_A4_2
        ///       * JP/CN: PackageLabel_Plain_Paper
        /// </remarks>
        GetPackageLabelsResponse GetPackageLabels(GetPackageLabelsRequest request);

        /// <summary>
        /// Get Pallet Labels
        /// </summary>
        /// <param name="request">GetPalletLabelsRequest request.</param>
        /// <returns>GetPalletLabelsResponse response</returns>
        /// <remarks>
        /// Retrieves the PDF-formatted pallet label data for the pallets in an LTL shipment. These labels
        ///     include relevant data for shipments being sent to Amazon Fulfillment Centers. The PDF data will be 
        ///     ZIP'd and then it will be encoded as a Base64 string, and MD5 hash is included with the response to 
        ///     validate the label data which will be encoded as Base64. The language of the address and FC prep 
        ///     instructions sections of the labels are determined by the marketplace in which the request is being 
        ///     made and the marketplace of the destination FC, respectively.
        /// </remarks>
        GetPalletLabelsResponse GetPalletLabels(GetPalletLabelsRequest request);

        /// <summary>
        /// Get Preorder Info
        /// </summary>
        /// <param name="request">GetPreorderInfoRequest request.</param>
        /// <returns>GetPreorderInfoResponse response</returns>
        /// <remarks>
        /// Given a shipment id. as input, based on the release date of the items in the
        /// shipment, this API returns the suggested need By Date that the shipment items
        /// must reach Amazon FC to successfully fulfill Pre-Orders without any promise
        /// breaks.
        /// This API also returns the confirmed Fullfillable date. All items in the
        /// shipment that have a release date on or after this date would have the
        /// pre-order buy box show up on the detail page if this shipment is marked as a
        /// pre-orderable.
        /// </remarks>
        GetPreorderInfoResponse GetPreorderInfo(GetPreorderInfoRequest request);

        /// <summary>
        /// Get Prep Instructions For ASIN
        /// </summary>
        /// <param name="request">GetPrepInstructionsForASINRequest request.</param>
        /// <returns>GetPrepInstructionsForASINResponse response</returns>
        /// <remarks>
        /// Returns the required prep that must be performed for a set of items, identified
        /// by ASINs, that will be sent to Amazon. It returns guidance for the seller
        /// on how to prepare the items to be sent in to Amazon's Fulfillment Centers, and
        /// identifies the labeling required for the items, and gives the seller a list
        /// of additional required prep that must be performed.
        /// </remarks>
        GetPrepInstructionsForASINResponse GetPrepInstructionsForASIN(GetPrepInstructionsForASINRequest request);

        /// <summary>
        /// Get Prep Instructions For SKU
        /// </summary>
        /// <param name="request">GetPrepInstructionsForSKURequest request.</param>
        /// <returns>GetPrepInstructionsForSKUResponse response</returns>
        /// <remarks>
        /// Returns the required prep that must be performed for a set of items, identified
        /// by SellerSKUs, that will be sent to Amazon. It returns guidance for the seller
        /// on how to prepare the items to be sent in to Amazon's Fulfillment Centers, and
        /// identifies the labeling required for the items, and gives the seller a list
        /// of additional required prep that must be performed.
        /// </remarks>
        GetPrepInstructionsForSKUResponse GetPrepInstructionsForSKU(GetPrepInstructionsForSKURequest request);

        /// <summary>
        /// Get Service Status
        /// </summary>
        /// <param name="request">GetServiceStatusRequest request.</param>
        /// <returns>GetServiceStatusResponse response</returns>
        /// <remarks>
        /// Gets the status of the service.
        ///   Status is one of GREEN, RED representing:
        ///   GREEN: The service section is operating normally.
        ///   RED: The service section disruption.
        /// </remarks>
        GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request);

        /// <summary>
        /// Get Transport Content
        /// </summary>
        /// <param name="request">GetTransportContentRequest request.</param>
        /// <returns>GetTransportContentResponse response</returns>
        /// <remarks>
        /// A read-only operation which sellers use to retrieve the current
        ///     details about the transportation of an inbound shipment, including status of the
        ///     partnered carrier workflow and status of individual packages when they arrive at our FCs.
        /// </remarks>
        GetTransportContentResponse GetTransportContent(GetTransportContentRequest request);

        /// <summary>
        /// Get Unique Package Labels
        /// </summary>
        /// <param name="request">GetUniquePackageLabelsRequest request.</param>
        /// <returns>GetUniquePackageLabelsResponse response</returns>
        /// <remarks>
        /// Retrieves the PDF-formatted package label data for the packages of the
        ///     shipment. These labels will include relevant data for shipments utilizing 
        ///     Amazon-partnered carriers. Each label contains a unique package identifier that represents the mapping between
        ///     physical and virtual packages. This API requires that Carton Information has been provided for all packages in the
        ///     shipment. The PDF data will be ZIP'd and then it will be encoded as a Base64 string, and
        ///     MD5 hash is included with the response to validate the label data which will be encoded as Base64.
        ///     The language of the address and FC prep instructions sections of the labels are
        ///     determined by the marketplace in which the request is being made and the marketplace of
        ///     the destination FC, respectively.
        ///     
        ///     Only select PageTypes are supported in each marketplace. By marketplace, the
        ///     supported types are:
        ///       * US non-partnered UPS: PackageLabel_Letter_6
        ///       * US partnered-UPS: PackageLabel_Letter_2
        ///       * GB, DE, FR, IT, ES: PackageLabel_A4_4, PackageLabel_Plain_Paper
        ///       * Partnered EU: PackageLabel_A4_2
        ///       * JP/CN: PackageLabel_Plain_Paper
        /// </remarks>
        GetUniquePackageLabelsResponse GetUniquePackageLabels(GetUniquePackageLabelsRequest request);

        /// <summary>
        /// List Inbound Shipment Items
        /// </summary>
        /// <param name="request">ListInboundShipmentItemsRequest request.</param>
        /// <returns>ListInboundShipmentItemsResponse response</returns>
        /// <remarks>
        /// Gets the first set of inbound shipment items for the given ShipmentId or 
        /// all inbound shipment items updated between the given date range. 
        /// A NextToken is also returned to further iterate through the Seller's 
        /// remaining inbound shipment items. To get the next set of inbound 
        /// shipment items, you must call ListInboundShipmentItemsByNextToken and 
        /// pass in the 'NextToken' this call returned. If a NextToken is not 
        /// returned, it indicates the end-of-data. Use LastUpdatedBefore 
        /// and LastUpdatedAfter to filter results based on last updated time. 
        /// Either the ShipmentId or a pair of LastUpdatedBefore and LastUpdatedAfter 
        /// must be passed in. if ShipmentId is set, the LastUpdatedBefore and 
        /// LastUpdatedAfter will be ignored.
        /// </remarks>
        ListInboundShipmentItemsResponse ListInboundShipmentItems(ListInboundShipmentItemsRequest request);

        /// <summary>
        /// List Inbound Shipment Items By Next Token
        /// </summary>
        /// <param name="request">ListInboundShipmentItemsByNextTokenRequest request.</param>
        /// <returns>ListInboundShipmentItemsByNextTokenResponse response</returns>
        /// <remarks>
        /// Gets the next set of inbound shipment items with the NextToken 
        /// which can be used to iterate through the remaining inbound shipment 
        /// items. If a NextToken is not returned, it indicates the end-of-data. 
        /// You must first call ListInboundShipmentItems to get a 'NextToken'.
        /// </remarks>
        ListInboundShipmentItemsByNextTokenResponse ListInboundShipmentItemsByNextToken(ListInboundShipmentItemsByNextTokenRequest request);

        /// <summary>
        /// List Inbound Shipments
        /// </summary>
        /// <param name="request">ListInboundShipmentsRequest request.</param>
        /// <returns>ListInboundShipmentsResponse response</returns>
        /// <remarks>
        /// Get the first set of inbound shipments created by a Seller according to 
        /// the specified shipment status or the specified shipment Id. A NextToken 
        /// is also returned to further iterate through the Seller's remaining 
        /// shipments. If a NextToken is not returned, it indicates the end-of-data.
        /// At least one of ShipmentStatusList and ShipmentIdList must be passed in. 
        /// if both are passed in, then only shipments that match the specified 
        /// shipment Id and specified shipment status will be returned.
        /// the LastUpdatedBefore and LastUpdatedAfter are optional, they are used 
        /// to filter results based on last update time of the shipment.
        /// </remarks>
        ListInboundShipmentsResponse ListInboundShipments(ListInboundShipmentsRequest request);

        /// <summary>
        /// List Inbound Shipments By Next Token
        /// </summary>
        /// <param name="request">ListInboundShipmentsByNextTokenRequest request.</param>
        /// <returns>ListInboundShipmentsByNextTokenResponse response</returns>
        /// <remarks>
        /// Gets the next set of inbound shipments created by a Seller with the 
        /// NextToken which can be used to iterate through the remaining inbound 
        /// shipments. If a NextToken is not returned, it indicates the end-of-data.
        /// </remarks>
        ListInboundShipmentsByNextTokenResponse ListInboundShipmentsByNextToken(ListInboundShipmentsByNextTokenRequest request);

        /// <summary>
        /// Put Transport Content
        /// </summary>
        /// <param name="request">PutTransportContentRequest request.</param>
        /// <returns>PutTransportContentResponse response</returns>
        /// <remarks>
        /// A write operation which sellers use to provide transportation details regarding
        ///     how an inbound shipment will arrive at Amazon's Fulfillment Centers.
        /// </remarks>
        PutTransportContentResponse PutTransportContent(PutTransportContentRequest request);

        /// <summary>
        /// Update Inbound Shipment
        /// </summary>
        /// <param name="request">UpdateInboundShipmentRequest request.</param>
        /// <returns>UpdateInboundShipmentResponse response</returns>
        /// <remarks>
        /// Updates an pre-existing inbound shipment specified by the 
        /// ShipmentId. It may include up to 200 items.
        /// If InboundShipmentHeader is set. it replaces the header information 
        /// for the given shipment.
        /// If InboundShipmentItems is set. it adds, replaces and removes 
        /// the line time to inbound shipment.
        /// For non-existing item, it will add the item for new line item; 
        /// For existing line items, it will replace the QuantityShipped for the item.
        /// For QuantityShipped = 0, it indicates the item should be removed from the shipment
        /// 
        /// This operation will simply return a shipment Id upon success,
        /// otherwise an explicit error will be returned.
        /// </remarks>
        UpdateInboundShipmentResponse UpdateInboundShipment(UpdateInboundShipmentRequest request);

        /// <summary>
        /// Void Transport Request
        /// </summary>
        /// <param name="request">VoidTransportInputRequest request.</param>
        /// <returns>VoidTransportRequestResponse response</returns>
        /// <remarks>
        /// Voids a previously-confirmed transport request. It only succeeds for requests
        ///     made by the VoidDeadline provided in the PartneredEstimate component of the
        ///     response of the GetTransportContent operation for a shipment. Currently this
        ///     deadline is 24 hours after confirming a transport request for a partnered small parcel
        ///     request and 1 hour after confirming a transport request for a partnered LTL/TL
        ///     request, though this is subject to change at any time without notice.
        /// </remarks>
        VoidTransportRequestResponse VoidTransportRequest(VoidTransportInputRequest request);

    }
}
