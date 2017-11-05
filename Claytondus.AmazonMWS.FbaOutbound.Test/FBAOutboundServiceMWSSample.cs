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

using System;
using Claytondus.AmazonMWS.FbaOutbound.Model;

namespace Claytondus.AmazonMWS.FbaOutbound.Test {

    /// <summary>
    /// Runnable sample code to demonstrate usage of the C# client.
    ///
    /// To use, import the client source as a console application,
    /// and mark this class as the startup object. Then, replace
    /// parameters below with sensible values and run.
    /// </summary>
    public class FBAOutboundServiceMWSSample {

        public static void Main(string[] args)
        {
            // TODO: Set the below configuration variables before attempting to run

            // Developer AWS access key
            string accessKey = "";

            // Developer AWS secret key
            string secretKey = "";

            // The client application name
            string appName = "CSharpSampleCode";

            // The client application version
            string appVersion = "1.0";

            // The endpoint for region service and version (see developer guide)
            // ex: https://mws.amazonservices.com
            string serviceURL = "https://mws.amazonservices.com";

            // Create a configuration object
            FBAOutboundServiceMWSConfig config = new FBAOutboundServiceMWSConfig();
            config.ServiceURL = serviceURL;
            // Set other client connection configurations here if needed
            // Create the client itself
            FBAOutboundServiceMWS client = new FBAOutboundServiceMWSClient(accessKey, secretKey, appName, appVersion, config);

            FBAOutboundServiceMWSSample sample = new FBAOutboundServiceMWSSample(client);

            // Uncomment the operation you'd like to test here
            // TODO: Modify the request created in the Invoke method to be valid

            try 
            {
                IMWSResponse response = null;
                // response = sample.InvokeCancelFulfillmentOrder();
                // response = sample.InvokeCreateFulfillmentOrder();
                // response = sample.InvokeCreateFulfillmentReturn();
                // response = sample.InvokeGetFulfillmentOrder();
                // response = sample.InvokeGetFulfillmentPreview();
                // response = sample.InvokeGetPackageTrackingDetails();
                // response = sample.InvokeGetServiceStatus();
                // response = sample.InvokeListAllFulfillmentOrders();
                // response = sample.InvokeListAllFulfillmentOrdersByNextToken();
                // response = sample.InvokeListReturnReasonCodes();
                // response = sample.InvokeUpdateFulfillmentOrder();
                Console.WriteLine("Response:");
                ResponseHeaderMetadata rhmd = response.ResponseHeaderMetadata;
                // We recommend logging the request id and timestamp of every call.
                Console.WriteLine("RequestId: " + rhmd.RequestId);
                Console.WriteLine("Timestamp: " + rhmd.Timestamp);
                string responseXml = response.ToXML();
                Console.WriteLine(responseXml);
            }
            catch (FBAOutboundServiceMWSException ex)
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

        private readonly FBAOutboundServiceMWS client;

        public FBAOutboundServiceMWSSample(FBAOutboundServiceMWS client)
        {
            this.client = client;
        }

        public CancelFulfillmentOrderResponse InvokeCancelFulfillmentOrder()
        {
            // Create a request.
            CancelFulfillmentOrderRequest request = new CancelFulfillmentOrderRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplace = "example";
            request.Marketplace = marketplace;
            string sellerFulfillmentOrderId = "example";
            request.SellerFulfillmentOrderId = sellerFulfillmentOrderId;
            return this.client.CancelFulfillmentOrder(request);
        }

        public CreateFulfillmentOrderResponse InvokeCreateFulfillmentOrder()
        {
            // Create a request.
            CreateFulfillmentOrderRequest request = new CreateFulfillmentOrderRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplace = "example";
            request.Marketplace = marketplace;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            string sellerFulfillmentOrderId = "example";
            request.SellerFulfillmentOrderId = sellerFulfillmentOrderId;
            string displayableOrderId = "example";
            request.DisplayableOrderId = displayableOrderId;
            DateTime displayableOrderDateTime = new DateTime();
            request.DisplayableOrderDateTime = displayableOrderDateTime;
            string displayableOrderComment = "example";
            request.DisplayableOrderComment = displayableOrderComment;
            string shippingSpeedCategory = "example";
            request.ShippingSpeedCategory = shippingSpeedCategory;
            DeliveryWindow deliveryWindow = new DeliveryWindow();
            request.DeliveryWindow = deliveryWindow;
            Address destinationAddress = new Address();
            request.DestinationAddress = destinationAddress;
            string fulfillmentAction = "example";
            request.FulfillmentAction = fulfillmentAction;
            string fulfillmentPolicy = "example";
            request.FulfillmentPolicy = fulfillmentPolicy;
            string fulfillmentMethod = "example";
            request.FulfillmentMethod = fulfillmentMethod;
            CODSettings codSettings = new CODSettings();
            request.CODSettings = codSettings;
            string shipFromCountryCode = "example";
            request.ShipFromCountryCode = shipFromCountryCode;
            NotificationEmailList notificationEmailList = new NotificationEmailList();
            request.NotificationEmailList = notificationEmailList;
            CreateFulfillmentOrderItemList items = new CreateFulfillmentOrderItemList();
            request.Items = items;
            return this.client.CreateFulfillmentOrder(request);
        }

        public CreateFulfillmentReturnResponse InvokeCreateFulfillmentReturn()
        {
            // Create a request.
            CreateFulfillmentReturnRequest request = new CreateFulfillmentReturnRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string sellerFulfillmentOrderId = "example";
            request.SellerFulfillmentOrderId = sellerFulfillmentOrderId;
            CreateReturnItemList items = new CreateReturnItemList();
            request.Items = items;
            return this.client.CreateFulfillmentReturn(request);
        }

        public GetFulfillmentOrderResponse InvokeGetFulfillmentOrder()
        {
            // Create a request.
            GetFulfillmentOrderRequest request = new GetFulfillmentOrderRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplace = "example";
            request.Marketplace = marketplace;
            string sellerFulfillmentOrderId = "example";
            request.SellerFulfillmentOrderId = sellerFulfillmentOrderId;
            return this.client.GetFulfillmentOrder(request);
        }

        public GetFulfillmentPreviewResponse InvokeGetFulfillmentPreview()
        {
            // Create a request.
            GetFulfillmentPreviewRequest request = new GetFulfillmentPreviewRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplace = "example";
            request.Marketplace = marketplace;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            Address address = new Address();
            request.Address = address;
            GetFulfillmentPreviewItemList items = new GetFulfillmentPreviewItemList();
            request.Items = items;
            ShippingSpeedCategoryList shippingSpeedCategories = new ShippingSpeedCategoryList();
            request.ShippingSpeedCategories = shippingSpeedCategories;
            bool includeCODFulfillmentPreview = true;
            request.IncludeCODFulfillmentPreview = includeCODFulfillmentPreview;
            bool includeDeliveryWindows = true;
            request.IncludeDeliveryWindows = includeDeliveryWindows;
            return this.client.GetFulfillmentPreview(request);
        }

        public GetPackageTrackingDetailsResponse InvokeGetPackageTrackingDetails()
        {
            // Create a request.
            GetPackageTrackingDetailsRequest request = new GetPackageTrackingDetailsRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            decimal packageNumber = 1;
            request.PackageNumber = packageNumber;
            return this.client.GetPackageTrackingDetails(request);
        }

        public GetServiceStatusResponse InvokeGetServiceStatus()
        {
            // Create a request.
            GetServiceStatusRequest request = new GetServiceStatusRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplace = "example";
            request.Marketplace = marketplace;
            return this.client.GetServiceStatus(request);
        }

        public ListAllFulfillmentOrdersResponse InvokeListAllFulfillmentOrders()
        {
            // Create a request.
            ListAllFulfillmentOrdersRequest request = new ListAllFulfillmentOrdersRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplace = "example";
            request.Marketplace = marketplace;
            DateTime queryStartDateTime = new DateTime();
            request.QueryStartDateTime = queryStartDateTime;
            FulfillmentMethodList fulfillmentMethod = new FulfillmentMethodList();
            request.FulfillmentMethod = fulfillmentMethod;
            return this.client.ListAllFulfillmentOrders(request);
        }

        public ListAllFulfillmentOrdersByNextTokenResponse InvokeListAllFulfillmentOrdersByNextToken()
        {
            // Create a request.
            ListAllFulfillmentOrdersByNextTokenRequest request = new ListAllFulfillmentOrdersByNextTokenRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplace = "example";
            request.Marketplace = marketplace;
            string nextToken = "example";
            request.NextToken = nextToken;
            return this.client.ListAllFulfillmentOrdersByNextToken(request);
        }

        public ListReturnReasonCodesResponse InvokeListReturnReasonCodes()
        {
            // Create a request.
            ListReturnReasonCodesRequest request = new ListReturnReasonCodesRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            string sellerFulfillmentOrderId = "example";
            request.SellerFulfillmentOrderId = sellerFulfillmentOrderId;
            string sellerSKU = "example";
            request.SellerSKU = sellerSKU;
            string language = "example";
            request.Language = language;
            return this.client.ListReturnReasonCodes(request);
        }

        public UpdateFulfillmentOrderResponse InvokeUpdateFulfillmentOrder()
        {
            // Create a request.
            UpdateFulfillmentOrderRequest request = new UpdateFulfillmentOrderRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplace = "example";
            request.Marketplace = marketplace;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            string sellerFulfillmentOrderId = "example";
            request.SellerFulfillmentOrderId = sellerFulfillmentOrderId;
            string displayableOrderId = "example";
            request.DisplayableOrderId = displayableOrderId;
            DateTime displayableOrderDateTime = new DateTime();
            request.DisplayableOrderDateTime = displayableOrderDateTime;
            string displayableOrderComment = "example";
            request.DisplayableOrderComment = displayableOrderComment;
            string shippingSpeedCategory = "example";
            request.ShippingSpeedCategory = shippingSpeedCategory;
            Address destinationAddress = new Address();
            request.DestinationAddress = destinationAddress;
            string fulfillmentAction = "example";
            request.FulfillmentAction = fulfillmentAction;
            string fulfillmentPolicy = "example";
            request.FulfillmentPolicy = fulfillmentPolicy;
            string fulfillmentMethod = "example";
            request.FulfillmentMethod = fulfillmentMethod;
            string shipFromCountryCode = "example";
            request.ShipFromCountryCode = shipFromCountryCode;
            NotificationEmailList notificationEmailList = new NotificationEmailList();
            request.NotificationEmailList = notificationEmailList;
            UpdateFulfillmentOrderItemList items = new UpdateFulfillmentOrderItemList();
            request.Items = items;
            return this.client.UpdateFulfillmentOrder(request);
        }


    }
}
