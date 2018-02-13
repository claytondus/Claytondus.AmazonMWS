/*******************************************************************************
 * Copyright 2009-2018 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * MWS Finances Service
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */

using Claytondus.AmazonMWS.Finances.Model;
using System;
using System.Collections.Generic;

namespace Claytondus.AmazonMWS.Finances.Test {

    /// <summary>
    /// Runnable sample code to demonstrate usage of the C# client.
    ///
    /// To use, import the client source as a console application,
    /// and mark this class as the startup object. Then, replace
    /// parameters below with sensible values and run.
    /// </summary>
    public class MWSFinancesServiceSample {

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
            MWSFinancesServiceConfig config = new MWSFinancesServiceConfig();
            config.ServiceURL = serviceURL;
            // Set other client connection configurations here if needed
            // Create the client itself
            MWSFinancesService client = new MWSFinancesServiceClient(accessKey, secretKey, appName, appVersion, config);

            MWSFinancesServiceSample sample = new MWSFinancesServiceSample(client);

            // Uncomment the operation you'd like to test here
            // TODO: Modify the request created in the Invoke method to be valid

            try 
            {
                IMWSResponse response = null;
                // response = sample.InvokeListFinancialEventGroups();
                // response = sample.InvokeListFinancialEventGroupsByNextToken();
                // response = sample.InvokeListFinancialEvents();
                // response = sample.InvokeListFinancialEventsByNextToken();
                // response = sample.InvokeGetServiceStatus();
                Console.WriteLine("Response:");
                ResponseHeaderMetadata rhmd = response.ResponseHeaderMetadata;
                // We recommend logging the request id and timestamp of every call.
                Console.WriteLine("RequestId: " + rhmd.RequestId);
                Console.WriteLine("Timestamp: " + rhmd.Timestamp);
                string responseXml = response.ToXML();
                Console.WriteLine(responseXml);
            }
            catch (MWSFinancesServiceException ex)
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

        private readonly MWSFinancesService client;

        public MWSFinancesServiceSample(MWSFinancesService client)
        {
            this.client = client;
        }

        public ListFinancialEventGroupsResponse InvokeListFinancialEventGroups()
        {
            // Create a request.
            ListFinancialEventGroupsRequest request = new ListFinancialEventGroupsRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            decimal maxResultsPerPage = 1;
            request.MaxResultsPerPage = maxResultsPerPage;
            DateTime financialEventGroupStartedAfter = new DateTime();
            request.FinancialEventGroupStartedAfter = financialEventGroupStartedAfter;
            DateTime financialEventGroupStartedBefore = new DateTime();
            request.FinancialEventGroupStartedBefore = financialEventGroupStartedBefore;
            return this.client.ListFinancialEventGroups(request);
        }

        public ListFinancialEventGroupsByNextTokenResponse InvokeListFinancialEventGroupsByNextToken()
        {
            // Create a request.
            ListFinancialEventGroupsByNextTokenRequest request = new ListFinancialEventGroupsByNextTokenRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string nextToken = "example";
            request.NextToken = nextToken;
            return this.client.ListFinancialEventGroupsByNextToken(request);
        }

        public ListFinancialEventsResponse InvokeListFinancialEvents()
        {
            // Create a request.
            ListFinancialEventsRequest request = new ListFinancialEventsRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            decimal maxResultsPerPage = 1;
            request.MaxResultsPerPage = maxResultsPerPage;
            string amazonOrderId = "example";
            request.AmazonOrderId = amazonOrderId;
            string financialEventGroupId = "example";
            request.FinancialEventGroupId = financialEventGroupId;
            DateTime postedAfter = new DateTime();
            request.PostedAfter = postedAfter;
            DateTime postedBefore = new DateTime();
            request.PostedBefore = postedBefore;
            return this.client.ListFinancialEvents(request);
        }

        public ListFinancialEventsByNextTokenResponse InvokeListFinancialEventsByNextToken()
        {
            // Create a request.
            ListFinancialEventsByNextTokenRequest request = new ListFinancialEventsByNextTokenRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string nextToken = "example";
            request.NextToken = nextToken;
            return this.client.ListFinancialEventsByNextToken(request);
        }

        public GetServiceStatusResponse InvokeGetServiceStatus()
        {
            // Create a request.
            GetServiceStatusRequest request = new GetServiceStatusRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            return this.client.GetServiceStatus(request);
        }


    }
}
