
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
    public class GetReportListByNextTokenSample
    {
    
                                                                                         
        /// <summary>
        /// retrieve the next batch of list items and if there are more items to retrieve
        /// 
        /// </summary>
        /// <param name="service">Instance of MarketplaceWebService service</param>
        /// <param name="request">GetReportListByNextTokenRequest request</param>
        public static async Task InvokeGetReportListByNextToken(MarketplaceWebService service, GetReportListByNextTokenRequest request)
        {
            try 
            {
                GetReportListByNextTokenResponse response = await service.GetReportListByNextToken(request);
                
                
                Console.WriteLine ("Service Response");
                Console.WriteLine ("=============================================================================");
                Console.WriteLine ();

                Console.WriteLine("        GetReportListByNextTokenResponse");
                if (response.IsSetGetReportListByNextTokenResult()) 
                {
                    Console.WriteLine("            GetReportListByNextTokenResult");
                    GetReportListByNextTokenResult  getReportListByNextTokenResult = response.GetReportListByNextTokenResult;
                    if (getReportListByNextTokenResult.IsSetNextToken()) 
                    {
                        Console.WriteLine("                NextToken");
                        Console.WriteLine("                    {0}", getReportListByNextTokenResult.NextToken);
                    }
                    if (getReportListByNextTokenResult.IsSetHasNext()) 
                    {
                        Console.WriteLine("                HasNext");
                        Console.WriteLine("                    {0}", getReportListByNextTokenResult.HasNext);
                    }
                    List<ReportInfo> reportInfoList = getReportListByNextTokenResult.ReportInfo;
                    foreach (ReportInfo reportInfo in reportInfoList) 
                    {
                        Console.WriteLine("                ReportInfo");
                        if (reportInfo.IsSetReportId()) 
                        {
                            Console.WriteLine("                    ReportId");
                            Console.WriteLine("                        {0}", reportInfo.ReportId);
                        }
                        if (reportInfo.IsSetReportType()) 
                        {
                            Console.WriteLine("                    ReportType");
                            Console.WriteLine("                        {0}", reportInfo.ReportType);
                        }
                        if (reportInfo.IsSetReportRequestId()) 
                        {
                            Console.WriteLine("                    ReportRequestId");
                            Console.WriteLine("                        {0}", reportInfo.ReportRequestId);
                        }
                        if (reportInfo.IsSetAvailableDate()) 
                        {
                            Console.WriteLine("                    AvailableDate");
                            Console.WriteLine("                        {0}", reportInfo.AvailableDate);
                        }
                        if (reportInfo.IsSetAcknowledged()) 
                        {
                            Console.WriteLine("                    Acknowledged");
                            Console.WriteLine("                        {0}", reportInfo.Acknowledged);
                        }
                        if (reportInfo.IsSetAcknowledgedDate()) 
                        {
                            Console.WriteLine("                    AcknowledgedDate");
                            Console.WriteLine("                        {0}", reportInfo.AcknowledgedDate);
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
