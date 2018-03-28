
/******************************************************************************* 
 *  Copyright 2009 Amazon Services.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 * 
 *  Marketplace Web Service CSharp Library
 *  API Version: 2009-01-01
 *  Generated: Mon Mar 16 17:31:42 PDT 2009 
 * 
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Claytondus.AmazonMWS.Feeds.Model;

namespace Claytondus.AmazonMWS.Feeds.Test
{

    /// <summary>
    /// Get Report List By Next Token  Samples
    /// </summary>
    public class GetReportRequestListByNextTokenSample
    {
    
                                                                                         
        /// <summary>
        /// retrieve the next batch of list items and if there are more items to retrieve
        /// 
        /// </summary>
        /// <param name="service">Instance of MarketplaceWebService service</param>
        /// <param name="request">GetReportListByNextTokenRequest request</param>
        public static async Task InvokeGetReportRequestListByNextToken(MarketplaceWebService service, GetReportRequestListByNextTokenRequest request)
        {
            try 
            {
                GetReportRequestListByNextTokenResponse response = await service.GetReportRequestListByNextToken(request);
                
                
                Console.WriteLine ("Service Response");
                Console.WriteLine ("=============================================================================");
                Console.WriteLine ();

                Console.WriteLine("        GetReportRequestListByNextTokenResponse");
                if (response.IsSetGetReportRequestListByNextTokenResult()) 
                {
                    Console.WriteLine("            GetReportRequestListByNextTokenResult");
                    GetReportRequestListByNextTokenResult getReportRequestListByNextTokenResult = response.GetReportRequestListByNextTokenResult;
                    if (getReportRequestListByNextTokenResult.IsSetNextToken()) 
                    {
                        Console.WriteLine("                NextToken");
                        Console.WriteLine("                    {0}", getReportRequestListByNextTokenResult.NextToken);
                    }
                    if (getReportRequestListByNextTokenResult.IsSetHasNext()) 
                    {
                        Console.WriteLine("                HasNext");
                        Console.WriteLine("                    {0}", getReportRequestListByNextTokenResult.HasNext);
                    }
                    List<ReportRequestInfo> reportRequestInfoList = getReportRequestListByNextTokenResult.ReportRequestInfo;
                    foreach (ReportRequestInfo reportRequestInfo in reportRequestInfoList) 
                    {
                        Console.WriteLine("                ReportRequestInfo");
                        if (reportRequestInfo.IsSetReportType()) 
                        {
                            Console.WriteLine("                    ReportType");
                            Console.WriteLine("                        {0}", reportRequestInfo.ReportType);
                        }
                        if (reportRequestInfo.IsSetReportRequestId()) 
                        {
                            Console.WriteLine("                    ReportRequestId");
                            Console.WriteLine("                        {0}", reportRequestInfo.ReportRequestId);
                        }
                        if (reportRequestInfo.IsSetGeneratedReportId())
                        {
                            Console.WriteLine("                    GeneratedReportId");
                            Console.WriteLine("                        {0}", reportRequestInfo.GeneratedReportId);
                        }
                        if (reportRequestInfo.IsSetStartDate()) 
                        {
                            Console.WriteLine("                    StartDate");
                            Console.WriteLine("                        {0}", reportRequestInfo.StartDate);
                        }
                        if (reportRequestInfo.IsSetSubmittedDate()) 
                        {
                            Console.WriteLine("                    SubmittedDate");
                            Console.WriteLine("                        {0}", reportRequestInfo.SubmittedDate);
                        }
                        if (reportRequestInfo.IsSetEndDate()) 
                        {
                            Console.WriteLine("                    EndDate");
                            Console.WriteLine("                        {0}", reportRequestInfo.EndDate);
                        }
                    }
                } 
                if (response.IsSetResponseMetadata()) 
                {
                    Console.WriteLine("            ResponseMetadata");
                    ResponseMetadata  responseMetadata = response.ResponseMetadata;
                    if (responseMetadata.IsSetRequestId()) 
                    {
                        Console.WriteLine("                RequestId");
                        Console.WriteLine("                    {0}", responseMetadata.RequestId);
                    }
                } 
                
                Console.WriteLine("            ResponseHeaderMetadata");
                Console.WriteLine("                RequestId");
                Console.WriteLine("                    " + response.ResponseHeaderMetadata.RequestId);
                Console.WriteLine("                ResponseContext");
                Console.WriteLine("                    " + response.ResponseHeaderMetadata.ResponseContext);
                Console.WriteLine("                Timestamp");
                Console.WriteLine("                    " + response.ResponseHeaderMetadata.Timestamp);

            } 
            catch (MarketplaceWebServiceException ex) 
            {
                Console.WriteLine("Caught Exception: " + ex.Message);
                Console.WriteLine("Response Status Code: " + ex.StatusCode);
                Console.WriteLine("Error Code: " + ex.ErrorCode);
                Console.WriteLine("Error Type: " + ex.ErrorType);
                Console.WriteLine("Request ID: " + ex.RequestId);
                Console.WriteLine("XML: " + ex.XML);
                Console.WriteLine("ResponseHeaderMetadata: " + ex.ResponseHeaderMetadata);
            }
        }
                    }
}
