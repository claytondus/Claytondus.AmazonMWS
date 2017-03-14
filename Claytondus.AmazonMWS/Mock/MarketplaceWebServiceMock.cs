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
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using System.Threading.Tasks;
using MarketplaceWebService.Model;

namespace MarketplaceWebService.Mock
{

    /// <summary>
    /// MarketplaceWebServiceMock is the implementation of MarketplaceWebService based
    /// on the pre-populated set of XML files that serve local data. It simulates 
    /// responses from Marketplace Web Service service.
    /// </summary>
    /// <remarks>
    /// Use this to test your application without making a call to 
    /// Marketplace Web Service 
    /// 
    /// Note, current Mock Service implementation does not valiadate requests
    /// </remarks>
    public  class MarketplaceWebServiceMock : MarketplaceWebService {


		// Public API ------------------------------------------------------------//


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
		public async Task<GetReportResponse> GetReport(GetReportRequest request)
		{
			return await Invoke<GetReportResponse>("GetReportResponse.xml");
		}

		/// <summary>
		/// Get Report Schedule Count 
		/// </summary>
		/// <param name="request">Get Report Schedule Count  request</param>
		/// <returns>Get Report Schedule Count  Response from the service</returns>
		/// <remarks>
		/// returns the number of report schedules
		///   
		/// </remarks>
		public async Task<GetReportScheduleCountResponse> GetReportScheduleCount(GetReportScheduleCountRequest request)
		{
			return await Invoke<GetReportScheduleCountResponse>("GetReportScheduleCountResponse.xml");
		}

		/// <summary>
		/// Get Report Request List By Next Token 
		/// </summary>
		/// <param name="request">Get Report Request List By Next Token  request</param>
		/// <returns>Get Report Request List By Next Token  Response from the service</returns>
		/// <remarks>
		/// retrieve the next batch of list items and if there are more items to retrieve
		///   
		/// </remarks>
		public async Task<GetReportRequestListByNextTokenResponse> GetReportRequestListByNextToken(GetReportRequestListByNextTokenRequest request)
		{
			return await Invoke<GetReportRequestListByNextTokenResponse>("GetReportRequestListByNextTokenResponse.xml");
		}

		/// <summary>
		/// Update Report Acknowledgements 
		/// </summary>
		/// <param name="request">Update Report Acknowledgements  request</param>
		/// <returns>Update Report Acknowledgements  Response from the service</returns>
		/// <remarks>
		/// The UpdateReportAcknowledgements operation updates the acknowledged status of one or more reports.
		///   
		/// </remarks>
		public async Task<UpdateReportAcknowledgementsResponse> UpdateReportAcknowledgements(UpdateReportAcknowledgementsRequest request)
		{
			return await Invoke<UpdateReportAcknowledgementsResponse>("UpdateReportAcknowledgementsResponse.xml");
		}

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
		public async Task<SubmitFeedResponse> SubmitFeed(SubmitFeedRequest request)
		{
			return await Invoke<SubmitFeedResponse>("SubmitFeedResponse.xml");
		}

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
		public async Task<GetReportCountResponse> GetReportCount(GetReportCountRequest request)
		{
			return await Invoke<GetReportCountResponse>("GetReportCountResponse.xml");
		}

		/// <summary>
		/// Get Feed Submission List By Next Token 
		/// </summary>
		/// <param name="request">Get Feed Submission List By Next Token  request</param>
		/// <returns>Get Feed Submission List By Next Token  Response from the service</returns>
		/// <remarks>
		/// retrieve the next batch of list items and if there are more items to retrieve
		///   
		/// </remarks>
		public async Task<GetFeedSubmissionListByNextTokenResponse> GetFeedSubmissionListByNextToken(GetFeedSubmissionListByNextTokenRequest request)
		{
			return await Invoke<GetFeedSubmissionListByNextTokenResponse>("GetFeedSubmissionListByNextTokenResponse.xml");
		}

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
		public async Task<CancelFeedSubmissionsResponse> CancelFeedSubmissions(CancelFeedSubmissionsRequest request)
		{
			return await Invoke<CancelFeedSubmissionsResponse>("CancelFeedSubmissionsResponse.xml");
		}

		/// <summary>
		/// Request Report 
		/// </summary>
		/// <param name="request">Request Report  request</param>
		/// <returns>Request Report  Response from the service</returns>
		/// <remarks>
		/// requests the generation of a report
		///   
		/// </remarks>
		public async Task<RequestReportResponse> RequestReport(RequestReportRequest request)
		{
			return await Invoke<RequestReportResponse>("RequestReportResponse.xml");
		}

		/// <summary>
		/// Get Feed Submission Count 
		/// </summary>
		/// <param name="request">Get Feed Submission Count  request</param>
		/// <returns>Get Feed Submission Count  Response from the service</returns>
		/// <remarks>
		/// returns the number of feeds matching all of the specified criteria
		///   
		/// </remarks>
		public async Task<GetFeedSubmissionCountResponse> GetFeedSubmissionCount(GetFeedSubmissionCountRequest request)
		{
			return await Invoke<GetFeedSubmissionCountResponse>("GetFeedSubmissionCountResponse.xml");
		}

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
		public async Task<CancelReportRequestsResponse> CancelReportRequests(CancelReportRequestsRequest request)
		{
			return await Invoke<CancelReportRequestsResponse>("CancelReportRequestsResponse.xml");
		}

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
		public async Task<GetReportListResponse> GetReportList(GetReportListRequest request)
		{
			return await Invoke<GetReportListResponse>("GetReportListResponse.xml");
		}

		/// <summary>
		/// Get Feed Submission Result 
		/// </summary>
		/// <param name="request">Get Feed Submission Result  request</param>
		/// <returns>Get Feed Submission Result  Response from the service</returns>
		/// <remarks>
		/// retrieves the feed processing report
		///   
		/// </remarks>
		public async Task<GetFeedSubmissionResultResponse> GetFeedSubmissionResult(GetFeedSubmissionResultRequest request)
		{
			return await Invoke<GetFeedSubmissionResultResponse>("GetFeedSubmissionResultResponse.xml");
		}

		/// <summary>
		/// Get Feed Submission List 
		/// </summary>
		/// <param name="request">Get Feed Submission List  request</param>
		/// <returns>Get Feed Submission List  Response from the service</returns>
		/// <remarks>
		/// returns a list of feed submission identifiers and their associated metadata
		///   
		/// </remarks>
		public async Task<GetFeedSubmissionListResponse> GetFeedSubmissionList(GetFeedSubmissionListRequest request)
		{
			return await Invoke<GetFeedSubmissionListResponse>("GetFeedSubmissionListResponse.xml");
		}

		/// <summary>
		/// Get Report Request List 
		/// </summary>
		/// <param name="request">Get Report Request List  request</param>
		/// <returns>Get Report Request List  Response from the service</returns>
		/// <remarks>
		/// returns a list of report requests ids and their associated metadata
		///   
		/// </remarks>
		public async Task<GetReportRequestListResponse> GetReportRequestList(GetReportRequestListRequest request)
		{
			return await Invoke<GetReportRequestListResponse>("GetReportRequestListResponse.xml");
		}

		/// <summary>
		/// Get Report Schedule List By Next Token 
		/// </summary>
		/// <param name="request">Get Report Schedule List By Next Token  request</param>
		/// <returns>Get Report Schedule List By Next Token  Response from the service</returns>
		/// <remarks>
		/// retrieve the next batch of list items and if there are more items to retrieve
		///   
		/// </remarks>
		public async Task<GetReportScheduleListByNextTokenResponse> GetReportScheduleListByNextToken(GetReportScheduleListByNextTokenRequest request)
		{
			return await Invoke<GetReportScheduleListByNextTokenResponse>("GetReportScheduleListByNextTokenResponse.xml");
		}

		/// <summary>
		/// Get Report List By Next Token 
		/// </summary>
		/// <param name="request">Get Report List By Next Token  request</param>
		/// <returns>Get Report List By Next Token  Response from the service</returns>
		/// <remarks>
		/// retrieve the next batch of list items and if there are more items to retrieve
		///   
		/// </remarks>
		public async Task<GetReportListByNextTokenResponse> GetReportListByNextToken(GetReportListByNextTokenRequest request)
		{
			return await Invoke<GetReportListByNextTokenResponse>("GetReportListByNextTokenResponse.xml");
		}

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
		public async Task<ManageReportScheduleResponse> ManageReportSchedule(ManageReportScheduleRequest request)
		{
			return await Invoke<ManageReportScheduleResponse>("ManageReportScheduleResponse.xml");
		}

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
		public async Task<GetReportRequestCountResponse> GetReportRequestCount(GetReportRequestCountRequest request)
		{
			return await Invoke<GetReportRequestCountResponse>("GetReportRequestCountResponse.xml");
		}

		/// <summary>
		/// Get Report Schedule List 
		/// </summary>
		/// <param name="request">Get Report Schedule List  request</param>
		/// <returns>Get Report Schedule List  Response from the service</returns>
		/// <remarks>
		/// returns the list of report schedules
		///   
		/// </remarks>
		public async Task<GetReportScheduleListResponse> GetReportScheduleList(GetReportScheduleListRequest request)
		{
			return await Invoke<GetReportScheduleListResponse>("GetReportScheduleListResponse.xml");
		}

		// Private API ------------------------------------------------------------//

		private async Task<T> Invoke<T>(String xmlResource)
		{
			Type typeObj = typeof(T);
			XmlSerializer serializer = new XmlSerializer(typeObj);
			Stream xmlStream = this.GetType().GetTypeInfo().Assembly.GetManifestResourceStream(xmlResource);
			T response = (T)serializer.Deserialize(xmlStream);
			AddResponseHeaderMetadata(typeObj, response);

			return response;
        }

        private void AddResponseHeaderMetadata(Type type, Object obj) 
        {
            object[] parameters = new object[] {new ResponseHeaderMetadata("5131519d-02d4-416f-8252-fe88a8b9865d",
                "1jOaKSW7LhzBEETHOVENSmWhIWw7mqbBIRTHDAYublG+zputqh0cgyVg0UmaikD761KvWxaGxNmTOT6Te4dUa8a1hBRe,qDPCFI2XSb60iVhQw+173wAVHZ2kJMfrAXxQDWNRguHZnFHHyWN1ZvDeeIxpUUkLNo3B+H9pUho=",
                "2013-12-16T14:31:45.446Z")};
            //type.InvokeMember("ResponseHeaderMetadata", BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty, Type.DefaultBinder, obj, parameters);
			var property = type.GetTypeInfo().GetDeclaredProperty("ResponseHeaderMetadata");
			property.SetValue(obj, parameters);
        
        }
    }
}
