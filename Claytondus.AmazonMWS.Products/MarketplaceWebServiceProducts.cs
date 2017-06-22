/*******************************************************************************
 * Copyright 2009-2017 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Marketplace Web Service Products
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */

using System;
using Claytondus.AmazonMWS.Products.Model;

namespace Claytondus.AmazonMWS.Products
{

    /// <summary>
    /// This is the Products API section of the Marketplace Web Service.
    /// </summary>
    public interface MarketplaceWebServiceProducts 
    {

        /// <summary>
        /// Get Competitive Pricing For ASIN
        /// </summary>
        /// <param name="request">GetCompetitivePricingForASINRequest request.</param>
        /// <returns>GetCompetitivePricingForASINResponse response</returns>
        /// <remarks>
        /// Gets competitive pricing and related information for a product identified by
        /// the MarketplaceId and ASIN.
        /// </remarks>
        GetCompetitivePricingForASINResponse GetCompetitivePricingForASIN(GetCompetitivePricingForASINRequest request);

        /// <summary>
        /// Get Competitive Pricing For SKU
        /// </summary>
        /// <param name="request">GetCompetitivePricingForSKURequest request.</param>
        /// <returns>GetCompetitivePricingForSKUResponse response</returns>
        /// <remarks>
        /// Gets competitive pricing and related information for a product identified by
        /// the SellerId and SKU.
        /// </remarks>
        GetCompetitivePricingForSKUResponse GetCompetitivePricingForSKU(GetCompetitivePricingForSKURequest request);

        /// <summary>
        /// Get Lowest Offer Listings For ASIN
        /// </summary>
        /// <param name="request">GetLowestOfferListingsForASINRequest request.</param>
        /// <returns>GetLowestOfferListingsForASINResponse response</returns>
        /// <remarks>
        /// Gets some of the lowest prices based on the product identified by the given
        /// MarketplaceId and ASIN.
        /// </remarks>
        GetLowestOfferListingsForASINResponse GetLowestOfferListingsForASIN(GetLowestOfferListingsForASINRequest request);

        /// <summary>
        /// Get Lowest Offer Listings For SKU
        /// </summary>
        /// <param name="request">GetLowestOfferListingsForSKURequest request.</param>
        /// <returns>GetLowestOfferListingsForSKUResponse response</returns>
        /// <remarks>
        /// Gets some of the lowest prices based on the product identified by the given
        /// SellerId and SKU.
        /// </remarks>
        GetLowestOfferListingsForSKUResponse GetLowestOfferListingsForSKU(GetLowestOfferListingsForSKURequest request);

        /// <summary>
        /// Get Lowest Priced Offers For ASIN
        /// </summary>
        /// <param name="request">GetLowestPricedOffersForASINRequest request.</param>
        /// <returns>GetLowestPricedOffersForASINResponse response</returns>
        /// <remarks>
        /// Retrieves the lowest priced offers based on the product identified by the given
        ///     ASIN.
        /// </remarks>
        GetLowestPricedOffersForASINResponse GetLowestPricedOffersForASIN(GetLowestPricedOffersForASINRequest request);

        /// <summary>
        /// Get Lowest Priced Offers For SKU
        /// </summary>
        /// <param name="request">GetLowestPricedOffersForSKURequest request.</param>
        /// <returns>GetLowestPricedOffersForSKUResponse response</returns>
        /// <remarks>
        /// Retrieves the lowest priced offers based on the product identified by the given
        ///     SellerId and SKU.
        /// </remarks>
        GetLowestPricedOffersForSKUResponse GetLowestPricedOffersForSKU(GetLowestPricedOffersForSKURequest request);

        /// <summary>
        /// Get Matching Product
        /// </summary>
        /// <param name="request">GetMatchingProductRequest request.</param>
        /// <returns>GetMatchingProductResponse response</returns>
        /// <remarks>
        /// GetMatchingProduct will return the details (attributes) for the
        /// given ASIN.
        /// </remarks>
        GetMatchingProductResponse GetMatchingProduct(GetMatchingProductRequest request);

        /// <summary>
        /// Get Matching Product For Id
        /// </summary>
        /// <param name="request">GetMatchingProductForIdRequest request.</param>
        /// <returns>GetMatchingProductForIdResponse response</returns>
        /// <remarks>
        /// GetMatchingProduct will return the details (attributes) for the
        /// given Identifier list. Identifer type can be one of [SKU|ASIN|UPC|EAN|ISBN|GTIN|JAN]
        /// </remarks>
        GetMatchingProductForIdResponse GetMatchingProductForId(GetMatchingProductForIdRequest request);

        /// <summary>
        /// Get My Fees Estimate
        /// </summary>
        /// <param name="request">GetMyFeesEstimateRequest request.</param>
        /// <returns>GetMyFeesEstimateResponse response</returns>
        /// <remarks>
        /// Retrieves the fees estimate for the
        ///         products identified by the given
        ///         ASIN/SKU list.
        /// </remarks>
        GetMyFeesEstimateResponse GetMyFeesEstimate(GetMyFeesEstimateRequest request);

        /// <summary>
        /// Get My Price For ASIN
        /// </summary>
        /// <param name="request">GetMyPriceForASINRequest request.</param>
        /// <returns>GetMyPriceForASINResponse response</returns>
        /// <remarks>
        /// <!-- Wrong doc in current code -->
        /// </remarks>
        GetMyPriceForASINResponse GetMyPriceForASIN(GetMyPriceForASINRequest request);

        /// <summary>
        /// Get My Price For SKU
        /// </summary>
        /// <param name="request">GetMyPriceForSKURequest request.</param>
        /// <returns>GetMyPriceForSKUResponse response</returns>
        /// <remarks>
        /// <!-- Wrong doc in current code -->
        /// </remarks>
        GetMyPriceForSKUResponse GetMyPriceForSKU(GetMyPriceForSKURequest request);

        /// <summary>
        /// Get Product Categories For ASIN
        /// </summary>
        /// <param name="request">GetProductCategoriesForASINRequest request.</param>
        /// <returns>GetProductCategoriesForASINResponse response</returns>
        /// <remarks>
        /// Gets categories information for a product identified by
        /// the MarketplaceId and ASIN.
        /// </remarks>
        GetProductCategoriesForASINResponse GetProductCategoriesForASIN(GetProductCategoriesForASINRequest request);

        /// <summary>
        /// Get Product Categories For SKU
        /// </summary>
        /// <param name="request">GetProductCategoriesForSKURequest request.</param>
        /// <returns>GetProductCategoriesForSKUResponse response</returns>
        /// <remarks>
        /// Gets categories information for a product identified by
        /// the SellerId and SKU.
        /// </remarks>
        GetProductCategoriesForSKUResponse GetProductCategoriesForSKU(GetProductCategoriesForSKURequest request);

        /// <summary>
        /// Get Service Status
        /// </summary>
        /// <param name="request">GetServiceStatusRequest request.</param>
        /// <returns>GetServiceStatusResponse response</returns>
        /// <remarks>
        /// Returns the service status of a particular MWS API section. The operation
        /// takes no input.
        /// All API sections within the API are required to implement this operation.
        /// </remarks>
        GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request);

        /// <summary>
        /// List Matching Products
        /// </summary>
        /// <param name="request">ListMatchingProductsRequest request.</param>
        /// <returns>ListMatchingProductsResponse response</returns>
        /// <remarks>
        /// ListMatchingProducts can be used to
        /// find products that match the given criteria.
        /// </remarks>
        ListMatchingProductsResponse ListMatchingProducts(ListMatchingProductsRequest request);

    }
}
