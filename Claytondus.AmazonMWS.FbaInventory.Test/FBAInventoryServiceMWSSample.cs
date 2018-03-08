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

using System;
using Claytondus.AmazonMWS.FbaInventory.Model;

namespace Claytondus.AmazonMWS.FbaInventory.Test {

    /// <summary>
    /// Runnable sample code to demonstrate usage of the C# client.
    ///
    /// To use, import the client source as a console application,
    /// and mark this class as the startup object. Then, replace
    /// parameters below with sensible values and run.
    /// </summary>
    public class FBAInventoryServiceMWSSample {

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
            FBAInventoryServiceMWSConfig config = new FBAInventoryServiceMWSConfig();
            config.ServiceURL = serviceURL;
            // Set other client connection configurations here if needed
            // Create the client itself
            FBAInventoryServiceMWS client = new FBAInventoryServiceMWSClient(accessKey, secretKey, appName, appVersion, config);

            FBAInventoryServiceMWSSample sample = new FBAInventoryServiceMWSSample(client);

            // Uncomment the operation you'd like to test here
            // TODO: Modify the request created in the Invoke method to be valid

            try 
            {
                IMWSResponse response = null;
                // response = sample.InvokeGetServiceStatus();
                // response = sample.InvokeListInventorySupply();
                // response = sample.InvokeListInventorySupplyByNextToken();
                Console.WriteLine("Response:");
                ResponseHeaderMetadata rhmd = response.ResponseHeaderMetadata;
                // We recommend logging the request id and timestamp of every call.
                Console.WriteLine("RequestId: " + rhmd.RequestId);
                Console.WriteLine("Timestamp: " + rhmd.Timestamp);
                string responseXml = response.ToXML();
                Console.WriteLine(responseXml);
            }
            catch (FBAInventoryServiceMWSException ex)
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

        private readonly FBAInventoryServiceMWS client;

        public FBAInventoryServiceMWSSample(FBAInventoryServiceMWS client)
        {
            this.client = client;
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

        public ListInventorySupplyResponse InvokeListInventorySupply()
        {
            // Create a request.
            ListInventorySupplyRequest request = new ListInventorySupplyRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplace = "example";
            request.Marketplace = marketplace;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            SellerSkuList sellerSkus = new SellerSkuList();
            request.SellerSkus = sellerSkus;
            DateTime queryStartDateTime = new DateTime();
            request.QueryStartDateTime = queryStartDateTime;
            string responseGroup = "example";
            request.ResponseGroup = responseGroup;
            return this.client.ListInventorySupply(request);
        }

        public ListInventorySupplyByNextTokenResponse InvokeListInventorySupplyByNextToken()
        {
            // Create a request.
            ListInventorySupplyByNextTokenRequest request = new ListInventorySupplyByNextTokenRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplace = "example";
            request.Marketplace = marketplace;
            string nextToken = "example";
            request.NextToken = nextToken;
            return this.client.ListInventorySupplyByNextToken(request);
        }


    }
}
