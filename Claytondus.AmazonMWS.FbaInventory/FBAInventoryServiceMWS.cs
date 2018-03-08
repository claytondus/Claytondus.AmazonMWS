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

using Claytondus.AmazonMWS.FbaInventory.Model;

namespace Claytondus.AmazonMWS.FbaInventory
{

    /// <summary>
    /// The inventory service allows sellers to stay up to date on the 
    ///     status of inventory in Amazon’s fulfillment centers.
    /// 
    ///     Check Inventory Status: Sellers can discover when inventory 
    ///     items change status and get the current availability status to
    ///     keep product listing information up to date
    /// </summary>
    public interface FBAInventoryServiceMWS 
    {

        /// <summary>
        /// Get Service Status
        /// </summary>
        /// <param name="request">GetServiceStatusRequest request.</param>
        /// <returns>GetServiceStatusResponse response</returns>
        /// <remarks>
        /// Gets the status of the service.
        ///     Status is one of GREEN, RED representing:
        ///     GREEN: The service section is operating normally.
        ///     RED: The service section disruption.
        /// </remarks>
        GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request);

        /// <summary>
        /// List Inventory Supply
        /// </summary>
        /// <param name="request">ListInventorySupplyRequest request.</param>
        /// <returns>ListInventorySupplyResponse response</returns>
        /// <remarks>
        /// Get information about the supply of seller-owned inventory in
        ///     Amazon's fulfillment network. "Supply" is inventory that is available
        ///     for fulfilling (a.k.a. Multi-Channel Fulfillment) orders. In general
        ///     this includes all sellable inventory that has been received by Amazon,
        ///     that is not reserved for existing orders or for internal FC processes,
        ///     and also inventory expected to be received from inbound shipments.
        /// 
        ///     This operation provides 2 typical usages by setting different 
        ///     ListInventorySupplyRequest value:
        ///     
        ///     1. Set value to SellerSkus and not set value to QueryStartDateTime, 
        ///     this operation will return all sellable inventory that has been received 
        ///     by Amazon's fulfillment network for these SellerSkus.
        /// 
        ///     2. Not set value to SellerSkus and set value to QueryStartDateTime,
        ///     This operation will return information about the supply of all seller-owned
        ///     inventory in Amazon's fulfillment network, for inventory items that may have had
        ///     recent changes in inventory levels. It provides the most efficient mechanism 
        ///     for clients to maintain local copies of inventory supply data.
        /// 
        ///     Only 1 of these 2 parameters (SellerSkus and QueryStartDateTime) can be set value for 1 request.
        ///     If both with values or neither with values, an exception will be thrown.
        /// 
        ///     This operation is used with ListInventorySupplyByNextToken
        ///     to paginate over the resultset. Begin pagination by invoking the
        ///     ListInventorySupply operation, and retrieve the first set of
        ///     results. If more results are available,continuing iteratively requesting further 
        ///     pages results by invoking the ListInventorySupplyByNextToken operation (each time 
        ///     passing in the NextToken value from the previous result), until the returned NextToken
        ///     is null, indicating no further results are available.
        /// </remarks>
        ListInventorySupplyResponse ListInventorySupply(ListInventorySupplyRequest request);

        /// <summary>
        /// List Inventory Supply By Next Token
        /// </summary>
        /// <param name="request">ListInventorySupplyByNextTokenRequest request.</param>
        /// <returns>ListInventorySupplyByNextTokenResponse response</returns>
        /// <remarks>
        /// Continues pagination over a resultset of inventory data for inventory
        ///     items.
        ///     
        ///     This operation is used in conjunction with ListUpdatedInventorySupply.
        ///     Please refer to documentation for that operation for further details.
        /// </remarks>
        ListInventorySupplyByNextTokenResponse ListInventorySupplyByNextToken(ListInventorySupplyByNextTokenRequest request);

    }
}
