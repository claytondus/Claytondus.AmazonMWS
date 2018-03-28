
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
using System.Threading.Tasks;
using Claytondus.AmazonMWS.Feeds.Model;

namespace Claytondus.AmazonMWS.Feeds.Test
{

    /// <summary>
    /// Get Report Count  Samples
    /// </summary>
    public class GetReportCountSample
    {
    
                                             
        /// <summary>
        /// returns a count of reports matching your criteria;
        /// by default, the number of reports generated in the last 90 days,
        /// regardless of acknowledgement status
        /// 
        /// </summary>
        /// <param name="service">Instance of MarketplaceWebService service</param>
        /// <param name="request">GetReportCountRequest request</param>
        public static async Task InvokeGetReportCount(MarketplaceWebService service, GetReportCountRequest request)
        {
            try 
            {
                GetReportCountResponse response = await service.GetReportCount(request);
                
                
                Console.WriteLine ("Service Response");
                Console.WriteLine ("=============================================================================");
                Console.WriteLine ();

                Console.WriteLine("        GetReportCountResponse");
                if (response.IsSetGetReportCountResult()) 
                {
                    Console.WriteLine("            GetReportCountResult");
                    GetReportCountResult  getReportCountResult = response.GetReportCountResult;
                    if (getReportCountResult.IsSetCount()) 
                    {
                        Console.WriteLine("                Count");
                        Console.WriteLine("                    {0}", getReportCountResult.Count);
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
