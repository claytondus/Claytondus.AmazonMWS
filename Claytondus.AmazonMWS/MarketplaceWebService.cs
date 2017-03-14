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
using System.Xml.Serialization;
using System.Collections.Generic;
using MarketplaceWebService.Model;

namespace MarketplaceWebService
{


    /// <summary>
    /// The Amazon Marketplace Web Service contain APIs for inventory and order management.
    /// 
    /// </summary>
    public interface  MarketplaceWebService {
    
                
        /// <summary>
        /// Get Report 
        /// </summary>
        /// <param name="request">Get Report  request</param>
        /// <returns>Get Report  Response from the service</returns>
        /// <remarks>
        /// The GetReport operation returns the contents of a report. Reports can potentially be
        /// very large (>100MB) which is why we only return one report at a time, and in a
        /// streaming fashion.
        ///   
        /// </remarks>
        GetReportResponse GetReport(GetReportRequest request);

                
        /// <summary>
        /// Get Report Schedule Count 
        /// </summary>
        /// <param name="request">Get Report Schedule Count  request</param>
        /// <returns>Get Report Schedule Count  Response from the service</returns>
        /// <remarks>
        /// returns the number of report schedules
        ///   
        /// </remarks>
        GetReportScheduleCountResponse GetReportScheduleCount(GetReportScheduleCountRequest request);

                
        /// <summary>
        /// Get Report Request List By Next Token 
        /// </summary>
        /// <param name="request">Get Report Request List By Next Token  request</param>
        /// <returns>Get Report Request List By Next Token  Response from the service</returns>
        /// <remarks>
        /// retrieve the next batch of list items and if there are more items to retrieve
        ///   
        /// </remarks>
        GetReportRequestListByNextTokenResponse GetReportRequestListByNextToken(GetReportRequestListByNextTokenRequest request);

                
        /// <summary>
        /// Update Report Acknowledgements 
        /// </summary>
        /// <param name="request">Update Report Acknowledgements  request</param>
        /// <returns>Update Report Acknowledgements  Response from the service</returns>
        /// <remarks>
        /// The UpdateReportAcknowledgements operation updates the acknowledged status of one or more reports.
        ///   
        /// </remarks>
        UpdateReportAcknowledgementsResponse UpdateReportAcknowledgements(UpdateReportAcknowledgementsRequest request);

                
        /// <summary>
        /// Submit Feed 
        /// </summary>
        /// <param name="request">Submit Feed  request</param>
        /// <returns>Submit Feed  Response from the service</returns>
        /// <remarks>
        /// Uploads a file for processing together with the necessary
        /// metadata to process the file, such as which type of feed it is.
        /// PurgeAndReplace if true means that your existing e.g. inventory is
        /// wiped out and replace with the contents of this feed - use with
        /// caution (the default is false).
        ///   
        /// </remarks>
        SubmitFeedResponse SubmitFeed(SubmitFeedRequest request);

                
        /// <summary>
        /// Get Report Count 
        /// </summary>
        /// <param name="request">Get Report Count  request</param>
        /// <returns>Get Report Count  Response from the service</returns>
        /// <remarks>
        /// returns a count of reports matching your criteria;
        /// by default, the number of reports generated in the last 90 days,
        /// regardless of acknowledgement status
        ///   
        /// </remarks>
        GetReportCountResponse GetReportCount(GetReportCountRequest request);

                
        /// <summary>
        /// Get Feed Submission List By Next Token 
        /// </summary>
        /// <param name="request">Get Feed Submission List By Next Token  request</param>
        /// <returns>Get Feed Submission List By Next Token  Response from the service</returns>
        /// <remarks>
        /// retrieve the next batch of list items and if there are more items to retrieve
        ///   
        /// </remarks>
        GetFeedSubmissionListByNextTokenResponse GetFeedSubmissionListByNextToken(GetFeedSubmissionListByNextTokenRequest request);

                
        /// <summary>
        /// Cancel Feed Submissions 
        /// </summary>
        /// <param name="request">Cancel Feed Submissions  request</param>
        /// <returns>Cancel Feed Submissions  Response from the service</returns>
        /// <remarks>
        /// cancels feed submissions - by default all of the submissions of the
        /// last 30 days that have not started processing
        ///   
        /// </remarks>
        CancelFeedSubmissionsResponse CancelFeedSubmissions(CancelFeedSubmissionsRequest request);

                
        /// <summary>
        /// Request Report 
        /// </summary>
        /// <param name="request">Request Report  request</param>
        /// <returns>Request Report  Response from the service</returns>
        /// <remarks>
        /// requests the generation of a report
        ///   
        /// </remarks>
        RequestReportResponse RequestReport(RequestReportRequest request);

                
        /// <summary>
        /// Get Feed Submission Count 
        /// </summary>
        /// <param name="request">Get Feed Submission Count  request</param>
        /// <returns>Get Feed Submission Count  Response from the service</returns>
        /// <remarks>
        /// returns the number of feeds matching all of the specified criteria
        ///   
        /// </remarks>
        GetFeedSubmissionCountResponse GetFeedSubmissionCount(GetFeedSubmissionCountRequest request);

                
        /// <summary>
        /// Cancel Report Requests 
        /// </summary>
        /// <param name="request">Cancel Report Requests  request</param>
        /// <returns>Cancel Report Requests  Response from the service</returns>
        /// <remarks>
        /// cancels report requests that have not yet started processing,
        /// by default all those within the last 90 days
        ///   
        /// </remarks>
        CancelReportRequestsResponse CancelReportRequests(CancelReportRequestsRequest request);

                
        /// <summary>
        /// Get Report List 
        /// </summary>
        /// <param name="request">Get Report List  request</param>
        /// <returns>Get Report List  Response from the service</returns>
        /// <remarks>
        /// returns a list of reports; by default the most recent ten reports,
        /// regardless of their acknowledgement status
        ///   
        /// </remarks>
        GetReportListResponse GetReportList(GetReportListRequest request);

                
        /// <summary>
        /// Get Feed Submission Result 
        /// </summary>
        /// <param name="request">Get Feed Submission Result  request</param>
        /// <returns>Get Feed Submission Result  Response from the service</returns>
        /// <remarks>
        /// retrieves the feed processing report
        ///   
        /// </remarks>
        GetFeedSubmissionResultResponse GetFeedSubmissionResult(GetFeedSubmissionResultRequest request);

                
        /// <summary>
        /// Get Feed Submission List 
        /// </summary>
        /// <param name="request">Get Feed Submission List  request</param>
        /// <returns>Get Feed Submission List  Response from the service</returns>
        /// <remarks>
        /// returns a list of feed submission identifiers and their associated metadata
        ///   
        /// </remarks>
        GetFeedSubmissionListResponse GetFeedSubmissionList(GetFeedSubmissionListRequest request);

                
        /// <summary>
        /// Get Report Request List 
        /// </summary>
        /// <param name="request">Get Report Request List  request</param>
        /// <returns>Get Report Request List  Response from the service</returns>
        /// <remarks>
        /// returns a list of report requests ids and their associated metadata
        ///   
        /// </remarks>
        GetReportRequestListResponse GetReportRequestList(GetReportRequestListRequest request);

                
        /// <summary>
        /// Get Report Schedule List By Next Token 
        /// </summary>
        /// <param name="request">Get Report Schedule List By Next Token  request</param>
        /// <returns>Get Report Schedule List By Next Token  Response from the service</returns>
        /// <remarks>
        /// retrieve the next batch of list items and if there are more items to retrieve
        ///   
        /// </remarks>
        GetReportScheduleListByNextTokenResponse GetReportScheduleListByNextToken(GetReportScheduleListByNextTokenRequest request);

                
        /// <summary>
        /// Get Report List By Next Token 
        /// </summary>
        /// <param name="request">Get Report List By Next Token  request</param>
        /// <returns>Get Report List By Next Token  Response from the service</returns>
        /// <remarks>
        /// retrieve the next batch of list items and if there are more items to retrieve
        ///   
        /// </remarks>
        GetReportListByNextTokenResponse GetReportListByNextToken(GetReportListByNextTokenRequest request);

                
        /// <summary>
        /// Manage Report Schedule 
        /// </summary>
        /// <param name="request">Manage Report Schedule  request</param>
        /// <returns>Manage Report Schedule  Response from the service</returns>
        /// <remarks>
        /// Creates, updates, or deletes a report schedule
        /// for a given report type, such as order reports in particular.
        ///   
        /// </remarks>
        ManageReportScheduleResponse ManageReportSchedule(ManageReportScheduleRequest request);

                
        /// <summary>
        /// Get Report Request Count 
        /// </summary>
        /// <param name="request">Get Report Request Count  request</param>
        /// <returns>Get Report Request Count  Response from the service</returns>
        /// <remarks>
        /// returns a count of report requests; by default all the report
        /// requests in the last 90 days
        ///   
        /// </remarks>
        GetReportRequestCountResponse GetReportRequestCount(GetReportRequestCountRequest request);

                
        /// <summary>
        /// Get Report Schedule List 
        /// </summary>
        /// <param name="request">Get Report Schedule List  request</param>
        /// <returns>Get Report Schedule List  Response from the service</returns>
        /// <remarks>
        /// returns the list of report schedules
        ///   
        /// </remarks>
        GetReportScheduleListResponse GetReportScheduleList(GetReportScheduleListRequest request);

    }
}
