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
    /// Get Feed Submission List By Next Token  Samples
    /// </summary>
    public class GetFeedSubmissionListByNextTokenSample
    {
    
                                                 
        /// <summary>
        /// retrieve the next batch of list items and if there are more items to retrieve
        /// 
        /// </summary>
        /// <param name="service">Instance of MarketplaceWebService service</param>
        /// <param name="request">GetFeedSubmissionListByNextTokenRequest request</param>
        public static async Task InvokeGetFeedSubmissionListByNextToken(MarketplaceWebService service, GetFeedSubmissionListByNextTokenRequest request)
        {
            try 
            {
                GetFeedSubmissionListByNextTokenResponse response = await service.GetFeedSubmissionListByNextToken(request);
                
                
                Console.WriteLine ("Service Response");
                Console.WriteLine ("=============================================================================");
                Console.WriteLine ();

                Console.WriteLine("        GetFeedSubmissionListByNextTokenResponse");
                if (response.IsSetGetFeedSubmissionListByNextTokenResult()) 
                {
                    Console.WriteLine("            GetFeedSubmissionListByNextTokenResult");
                    GetFeedSubmissionListByNextTokenResult  getFeedSubmissionListByNextTokenResult = response.GetFeedSubmissionListByNextTokenResult;
                    if (getFeedSubmissionListByNextTokenResult.IsSetNextToken()) 
                    {
                        Console.WriteLine("                NextToken");
                        Console.WriteLine("                    {0}", getFeedSubmissionListByNextTokenResult.NextToken);
                    }
                    if (getFeedSubmissionListByNextTokenResult.IsSetHasNext()) 
                    {
                        Console.WriteLine("                HasNext");
                        Console.WriteLine("                    {0}", getFeedSubmissionListByNextTokenResult.HasNext);
                    }
                    List<FeedSubmissionInfo> feedSubmissionInfoList = getFeedSubmissionListByNextTokenResult.FeedSubmissionInfo;
                    foreach (FeedSubmissionInfo feedSubmissionInfo in feedSubmissionInfoList) 
                    {
                        Console.WriteLine("                FeedSubmissionInfo");
                        if (feedSubmissionInfo.IsSetFeedSubmissionId()) 
                        {
                            Console.WriteLine("                    FeedSubmissionId");
                            Console.WriteLine("                        {0}", feedSubmissionInfo.FeedSubmissionId);
                        }
                        if (feedSubmissionInfo.IsSetFeedType()) 
                        {
                            Console.WriteLine("                    FeedType");
                            Console.WriteLine("                        {0}", feedSubmissionInfo.FeedType);
                        }
                        if (feedSubmissionInfo.IsSetSubmittedDate()) 
                        {
                            Console.WriteLine("                    SubmittedDate");
                            Console.WriteLine("                        {0}", feedSubmissionInfo.SubmittedDate);
                        }
                        if (feedSubmissionInfo.IsSetFeedProcessingStatus()) 
                        {
                            Console.WriteLine("                    FeedProcessingStatus");
                            Console.WriteLine("                        {0}", feedSubmissionInfo.FeedProcessingStatus);
                        }
                        if (feedSubmissionInfo.IsSetStartedProcessingDate()) 
                        {
                            Console.WriteLine("                    StartedProcessingDate");
                            Console.WriteLine("                        {0}", feedSubmissionInfo.StartedProcessingDate);
                        }
                        if (feedSubmissionInfo.IsSetCompletedProcessingDate()) 
                        {
                            Console.WriteLine("                    CompletedProcessingDate");
                            Console.WriteLine("                        {0}", feedSubmissionInfo.CompletedProcessingDate);
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
