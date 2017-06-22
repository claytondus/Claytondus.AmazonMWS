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
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Products
{

    /// <summary>
    /// MarketplaceWebServiceProductsClient is an implementation of MarketplaceWebServiceProducts
    /// </summary>
    public class MarketplaceWebServiceProductsClient : MarketplaceWebServiceProducts 
    {

        private const string libraryVersion = "2017-03-22";

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
        public MarketplaceWebServiceProductsClient(
            String applicationName, String applicationVersion, String accessKey, String secretKey,
            MarketplaceWebServiceProductsConfig config)
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
        public MarketplaceWebServiceProductsClient(String accessKey, String secretKey, MarketplaceWebServiceProductsConfig config)
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
        public MarketplaceWebServiceProductsClient(String accessKey, String secretKey)
            : this(accessKey, secretKey, new MarketplaceWebServiceProductsConfig())
        {
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        public MarketplaceWebServiceProductsClient(
            String accessKey, 
            String secretKey,
            String applicationName,
            String applicationVersion ) 
            : this(accessKey, secretKey, applicationName,
                applicationVersion, new MarketplaceWebServiceProductsConfig())
        {
        }

        public GetCompetitivePricingForASINResponse GetCompetitivePricingForASIN(GetCompetitivePricingForASINRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<GetCompetitivePricingForASINResponse>("GetCompetitivePricingForASIN", typeof(GetCompetitivePricingForASINResponse), servicePath),
                request);
        }

        public GetCompetitivePricingForSKUResponse GetCompetitivePricingForSKU(GetCompetitivePricingForSKURequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<GetCompetitivePricingForSKUResponse>("GetCompetitivePricingForSKU", typeof(GetCompetitivePricingForSKUResponse), servicePath),
                request);
        }

        public GetLowestOfferListingsForASINResponse GetLowestOfferListingsForASIN(GetLowestOfferListingsForASINRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<GetLowestOfferListingsForASINResponse>("GetLowestOfferListingsForASIN", typeof(GetLowestOfferListingsForASINResponse), servicePath),
                request);
        }

        public GetLowestOfferListingsForSKUResponse GetLowestOfferListingsForSKU(GetLowestOfferListingsForSKURequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<GetLowestOfferListingsForSKUResponse>("GetLowestOfferListingsForSKU", typeof(GetLowestOfferListingsForSKUResponse), servicePath),
                request);
        }

        public GetLowestPricedOffersForASINResponse GetLowestPricedOffersForASIN(GetLowestPricedOffersForASINRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<GetLowestPricedOffersForASINResponse>("GetLowestPricedOffersForASIN", typeof(GetLowestPricedOffersForASINResponse), servicePath),
                request);
        }

        public GetLowestPricedOffersForSKUResponse GetLowestPricedOffersForSKU(GetLowestPricedOffersForSKURequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<GetLowestPricedOffersForSKUResponse>("GetLowestPricedOffersForSKU", typeof(GetLowestPricedOffersForSKUResponse), servicePath),
                request);
        }

        public GetMatchingProductResponse GetMatchingProduct(GetMatchingProductRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<GetMatchingProductResponse>("GetMatchingProduct", typeof(GetMatchingProductResponse), servicePath),
                request);
        }

        public GetMatchingProductForIdResponse GetMatchingProductForId(GetMatchingProductForIdRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<GetMatchingProductForIdResponse>("GetMatchingProductForId", typeof(GetMatchingProductForIdResponse), servicePath),
                request);
        }

        public GetMyFeesEstimateResponse GetMyFeesEstimate(GetMyFeesEstimateRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<GetMyFeesEstimateResponse>("GetMyFeesEstimate", typeof(GetMyFeesEstimateResponse), servicePath),
                request);
        }

        public GetMyPriceForASINResponse GetMyPriceForASIN(GetMyPriceForASINRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<GetMyPriceForASINResponse>("GetMyPriceForASIN", typeof(GetMyPriceForASINResponse), servicePath),
                request);
        }

        public GetMyPriceForSKUResponse GetMyPriceForSKU(GetMyPriceForSKURequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<GetMyPriceForSKUResponse>("GetMyPriceForSKU", typeof(GetMyPriceForSKUResponse), servicePath),
                request);
        }

        public GetProductCategoriesForASINResponse GetProductCategoriesForASIN(GetProductCategoriesForASINRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<GetProductCategoriesForASINResponse>("GetProductCategoriesForASIN", typeof(GetProductCategoriesForASINResponse), servicePath),
                request);
        }

        public GetProductCategoriesForSKUResponse GetProductCategoriesForSKU(GetProductCategoriesForSKURequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<GetProductCategoriesForSKUResponse>("GetProductCategoriesForSKU", typeof(GetProductCategoriesForSKUResponse), servicePath),
                request);
        }

        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<GetServiceStatusResponse>("GetServiceStatus", typeof(GetServiceStatusResponse), servicePath),
                request);
        }

        public ListMatchingProductsResponse ListMatchingProducts(ListMatchingProductsRequest request)
        {
            return connection.Call(
                new MarketplaceWebServiceProductsClient.Request<ListMatchingProductsResponse>("ListMatchingProducts", typeof(ListMatchingProductsResponse), servicePath),
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
                return new MarketplaceWebServiceProductsException(cause);
            }

            public void SetResponseHeaderMetadata(IMwsObject response, MwsResponseHeaderMetadata rhmd) {
                ((IMWSResponse)response).ResponseHeaderMetadata = new ResponseHeaderMetadata(rhmd);
            }

        }
    }
}
