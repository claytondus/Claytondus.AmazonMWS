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
 * Marketplace Web Service Sellers
 * API Version: 2011-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 20:37:46 GMT 2015
 */

using Claytondus.AmazonMWS.Sellers.Model;

namespace Claytondus.AmazonMWS.Sellers
{

    /// <summary>
    /// This is the Sellers API section of the Marketplace Web Service.
    /// </summary>
    public interface MarketplaceWebServiceSellers 
    {

        /// <summary>
        /// Get Service Status
        /// </summary>
        /// <param name="request">GetServiceStatusRequest request.</param>
        /// <returns>GetServiceStatusResponse response</returns>
        /// <remarks>
        /// Returns the service status of a particular MWS API section. The operation
        ///         takes no input.
        ///         All API sections within the API are required to implement this operation.
        /// </remarks>
        GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request);

        /// <summary>
        /// List Marketplace Participations
        /// </summary>
        /// <param name="request">ListMarketplaceParticipationsRequest request.</param>
        /// <returns>ListMarketplaceParticipationsResponse response</returns>
        /// <remarks>
        /// Returns a list of marketplaces that the seller submitting the request can sell in, 
        ///         and a list of participations that include seller-specific information in that marketplace.
        /// </remarks>
        ListMarketplaceParticipationsResponse ListMarketplaceParticipations(ListMarketplaceParticipationsRequest request);

        /// <summary>
        /// List Marketplace Participations By Next Token
        /// </summary>
        /// <param name="request">ListMarketplaceParticipationsByNextTokenRequest request.</param>
        /// <returns>ListMarketplaceParticipationsByNextTokenResponse response</returns>
        /// <remarks>
        /// Returns the next page of marketplaces and participations using the NextToken value 
        ///         that was returned by your previous request to either ListMarketplaceParticipations or
        ///         ListMarketplaceParticipationsByNextToken.
        /// </remarks>
        ListMarketplaceParticipationsByNextTokenResponse ListMarketplaceParticipationsByNextToken(ListMarketplaceParticipationsByNextTokenRequest request);

    }
}
