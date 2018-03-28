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
using System.Reflection;
using System.Web;
using System.Net;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Globalization;
using System.Xml.Serialization;
using System.Collections.Generic;
using MarketplaceWebService.Model;
using MarketplaceWebService;
using MarketplaceWebService.Attributes;
using System.Reflection;
using System.Collections.Specialized;


namespace MarketplaceWebService
{
   /**

    *
    * MarketplaceWebServiceClient is an implementation of MarketplaceWebService
    *
    */
    public class MarketplaceWebServiceClient : MarketplaceWebService
    {

        private String awsAccessKeyId = null;
        private String awsSecretAccessKey = null;
        private MarketplaceWebServiceConfig config = null;

        /// <summary>
        /// Constructs MarketplaceWebServiceClient with AWS Access Key ID and AWS Secret Key.
        /// Since the User-Agent is required for all MWS calls, this value must be set
        /// in the config.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">Custom Configuration (User-Agent is set)</param>
        public MarketplaceWebServiceClient(
           String awsAccessKeyId,
           String awsSecretAccessKey,
           MarketplaceWebServiceConfig config)
        {
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretAccessKey = awsSecretAccessKey;

            if (!config.IsSetUserAgent())
            {
                throw new MarketplaceWebServiceException("Missing required value: User-Agent.");
            }

            this.config = config;
        }

        /// <summary>
        /// Constructs MarketplaceWebServiceClient with AWS Access Key ID and AWS Secret Key
        /// an application name, and application version.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        public MarketplaceWebServiceClient(
            String awsAccessKeyId, 
            String awsSecretAccessKey,
            String applicationName,
            String applicationVersion ) 
            : this(
                awsAccessKeyId, 
                awsSecretAccessKey, 
                applicationName,
                applicationVersion,
                new MarketplaceWebServiceConfig())
        {
        }


        /// <summary>
        /// Constructs MarketplaceWebServiceClient with AWS Access Key ID and AWS Secret Key
        /// an application name, and application version.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        /// /// <param name="applicationVersion">Custom Configuration (User-Agent not set)</param>
        public MarketplaceWebServiceClient(
            String awsAccessKeyId, 
            String awsSecretAccessKey,
            String applicationName,
            String applicationVersion,
            MarketplaceWebServiceConfig config)
        {
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretAccessKey = awsSecretAccessKey;
            this.config = config;

            buildUserAgentHeader(applicationName, applicationVersion, config);
        }

        private const string mwsClientVersion = "2016-09-21";
        
        private void buildUserAgentHeader(
            string applicationName,
            string applicationVersion,
            MarketplaceWebServiceConfig config)
        {
            config.SetUserAgentHeader(
                applicationName,
                applicationVersion,
                "C#",
                "CLI", Environment.Version.ToString(),
                "Platform", Environment.OSVersion.Platform + "/" + Environment.OSVersion.Version,
                "MWSClientVersion", mwsClientVersion );
        }



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
        public GetReportResponse GetReport(GetReportRequest request)
        {
            return Invoke<GetReportResponse, GetReportRequest>(ConvertGetReport(request), request);
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
        public GetReportScheduleCountResponse GetReportScheduleCount(GetReportScheduleCountRequest request)
        {
            return Invoke<GetReportScheduleCountResponse>(ConvertGetReportScheduleCount(request));
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
        public GetReportRequestListByNextTokenResponse GetReportRequestListByNextToken(GetReportRequestListByNextTokenRequest request)
        {
            return Invoke<GetReportRequestListByNextTokenResponse>(ConvertGetReportRequestListByNextToken(request));
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
        public UpdateReportAcknowledgementsResponse UpdateReportAcknowledgements(UpdateReportAcknowledgementsRequest request)
        {
            return Invoke<UpdateReportAcknowledgementsResponse>(ConvertUpdateReportAcknowledgements(request));
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
        public SubmitFeedResponse SubmitFeed(SubmitFeedRequest request)
        {
            return Invoke<SubmitFeedResponse,SubmitFeedRequest>(ConvertSubmitFeed(request), request);
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
        public GetReportCountResponse GetReportCount(GetReportCountRequest request)
        {
            return Invoke<GetReportCountResponse>(ConvertGetReportCount(request));
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
        public GetFeedSubmissionListByNextTokenResponse GetFeedSubmissionListByNextToken(GetFeedSubmissionListByNextTokenRequest request)
        {
            return Invoke<GetFeedSubmissionListByNextTokenResponse>(ConvertGetFeedSubmissionListByNextToken(request));
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
        public CancelFeedSubmissionsResponse CancelFeedSubmissions(CancelFeedSubmissionsRequest request)
        {
            return Invoke<CancelFeedSubmissionsResponse>(ConvertCancelFeedSubmissions(request));
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
        public RequestReportResponse RequestReport(RequestReportRequest request)
        {
            return Invoke<RequestReportResponse>(ConvertRequestReport(request));
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
        public GetFeedSubmissionCountResponse GetFeedSubmissionCount(GetFeedSubmissionCountRequest request)
        {
            return Invoke<GetFeedSubmissionCountResponse>(ConvertGetFeedSubmissionCount(request));
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
        public CancelReportRequestsResponse CancelReportRequests(CancelReportRequestsRequest request)
        {
            return Invoke<CancelReportRequestsResponse>(ConvertCancelReportRequests(request));
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
        public GetReportListResponse GetReportList(GetReportListRequest request)
        {
            return Invoke<GetReportListResponse>(ConvertGetReportList(request));
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
        public GetFeedSubmissionResultResponse GetFeedSubmissionResult(GetFeedSubmissionResultRequest request)
        {
            return Invoke<GetFeedSubmissionResultResponse, GetFeedSubmissionResultRequest>(ConvertGetFeedSubmissionResult(request), request);
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
        public GetFeedSubmissionListResponse GetFeedSubmissionList(GetFeedSubmissionListRequest request)
        {
            return Invoke<GetFeedSubmissionListResponse>(ConvertGetFeedSubmissionList(request));
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
        public GetReportRequestListResponse GetReportRequestList(GetReportRequestListRequest request)
        {
            return Invoke<GetReportRequestListResponse>(ConvertGetReportRequestList(request));
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
        public GetReportScheduleListByNextTokenResponse GetReportScheduleListByNextToken(GetReportScheduleListByNextTokenRequest request)
        {
            return Invoke<GetReportScheduleListByNextTokenResponse>(ConvertGetReportScheduleListByNextToken(request));
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
        public GetReportListByNextTokenResponse GetReportListByNextToken(GetReportListByNextTokenRequest request)
        {
            return Invoke<GetReportListByNextTokenResponse>(ConvertGetReportListByNextToken(request));
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
        public ManageReportScheduleResponse ManageReportSchedule(ManageReportScheduleRequest request)
        {
            return Invoke<ManageReportScheduleResponse>(ConvertManageReportSchedule(request));
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
        public GetReportRequestCountResponse GetReportRequestCount(GetReportRequestCountRequest request)
        {
            return Invoke<GetReportRequestCountResponse>(ConvertGetReportRequestCount(request));
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
        public GetReportScheduleListResponse GetReportScheduleList(GetReportScheduleListRequest request)
        {
            return Invoke<GetReportScheduleListResponse>(ConvertGetReportScheduleList(request));
        }

        // Private API ------------------------------------------------------------//

        private HttpWebRequest ConfigureWebRequest(String queryParameters, ContentType contentType)
        {
            string serviceUrl;
            if (config.ServiceURL.EndsWith("/"))
            {
                serviceUrl = config.ServiceURL.Substring(0, config.ServiceURL.Length - 1);
            }
            else
            {
                serviceUrl = config.ServiceURL;
            }

            HttpWebRequest request = WebRequest.Create(
                serviceUrl + "/?" + queryParameters) as HttpWebRequest;

            if (config.IsSetProxyHost())
            {
                request.Proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
            }

            request.UserAgent = config.UserAgent;

            request.Method = "POST";
            request.Timeout = config.RequestTimeout;

            request.ContentType = contentType.ToString();

            request.SendChunked = true;
            System.Net.ServicePointManager.Expect100Continue = false;

            return request;
        }

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from MarketplaceWebServiceConfig instance
         */
        private HttpWebRequest ConfigureWebRequest(int contentLength)
        {
            HttpWebRequest request = WebRequest.Create(config.ServiceURL) as HttpWebRequest;

            if (config.IsSetProxyHost())
            {
                request.Proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
            }
            request.UserAgent = config.UserAgent;
            request.Method = "POST";
            request.Timeout = 50000;
            request.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
            request.ContentLength = contentLength;

            return request;
        }

        private T Invoke<T>(IDictionary<String, String> parameters)
        {
            return Invoke<T, Object>(parameters, null);
        }

        /**
         * Invoke request and return response
         */
        private T Invoke<T, K>(IDictionary<String, String> parameters, K clazz)
        {

            String actionName = parameters["Action"];
            T response = default(T);
            String responseBody = null;
            HttpStatusCode statusCode = default(HttpStatusCode);
            ResponseHeaderMetadata rhm = null;

            // Verify service URL is set.
            if (String.IsNullOrEmpty(config.ServiceURL))
            {
                throw new MarketplaceWebServiceException(new ArgumentException(
                    "Missing serviceUrl configuration value. You may obtain a list of valid MWS URLs by consulting the MWS Developer's Guide, or reviewing the sample code published along side this library."));      
            }

            /* Add required request parameters */
            AddRequiredParameters(parameters);

            String queryString = GetParametersAsString(parameters);
            byte[] requestData = new UTF8Encoding().GetBytes(queryString);

            HttpWebRequest request;

            bool isStreamingResponse = ExpectStreamingResponse(typeof(K));

            bool shouldRetry = true;
            int retries = 0;
            do
            {
                /* Submit the request and read response body */
                try
                {
                    RequestType requestType = GetMarketplaceWebServiceRequestType(typeof(K));
                    switch (requestType)
                    {
                        case RequestType.STREAMING:
                            {
                                SubmitFeedRequest req = clazz as SubmitFeedRequest;
                                if (req != null)
                                {
                                    // SubmitFeedRequests can configure the content type.
                                    request = ConfigureWebRequest(queryString, req.ContentType);
                                }
                                else
                                {
                                    // Send request using a default content-type.
                                    request = ConfigureWebRequest(queryString, new ContentType(MediaType.OctetStream));
                                }
                            }
                            break;
                        default:
                            request = ConfigureWebRequest(requestData.Length);
                            break;
                    }

                    WebHeaderCollection headers = request.Headers;

                    using (Stream requestStream = request.GetRequestStream())
                    {
                        switch (requestType)
                        {
                            case RequestType.STREAMING:
                                Stream inputStream = GetTransferStream(clazz, StreamType.REQUEST_STREAM);
                                inputStream.Position = 0;
                                CopyStream(inputStream, requestStream);
                                break;
                            default:
                                requestStream.Write(requestData, 0, requestData.Length);
                                break;
                        }
                        requestStream.Close();
                    }

                    using (HttpWebResponse httpResponse = request.GetResponse() as HttpWebResponse)
                    {
                        statusCode = httpResponse.StatusCode;
                        rhm = new ResponseHeaderMetadata(
                            httpResponse.GetResponseHeader("x-mws-request-id"),
                            httpResponse.GetResponseHeader("x-mws-response-context"),
                            httpResponse.GetResponseHeader("x-mws-timestamp"));

                        if (isStreamingResponse && statusCode == HttpStatusCode.OK)
                        {
                            response = HandleStreamingResponse<T>(httpResponse, clazz);
                        }
                        else
                        {
                            
                            StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8);
                            responseBody = reader.ReadToEnd();
                            XmlSerializer serlizer = new XmlSerializer(typeof(T));
                            response = (T)serlizer.Deserialize(new StringReader(responseBody));
                        }

                        PropertyInfo pi = typeof(T).GetProperty("ResponseHeaderMetadata");
                        pi.SetValue(response, rhm, null);

                        shouldRetry = false;
                    }
                    
                    /* Attempt to deserialize response into <Action> Response type */
                    
                }
                /* Web exception is thrown on unsucessful responses */
                catch (WebException we)
                {
                    shouldRetry = false;
                    using (HttpWebResponse httpErrorResponse = (HttpWebResponse)we.Response as HttpWebResponse)
                    {
                        if (httpErrorResponse == null)
                        {
                            throw new MarketplaceWebServiceException(we);
                        }
                        statusCode = httpErrorResponse.StatusCode;
                        StreamReader reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8);
                        responseBody = reader.ReadToEnd();
                    }

                    /* Attempt to deserialize response into ErrorResponse type */
                    try
                    {
                        XmlSerializer serlizer = new XmlSerializer(typeof(ErrorResponse));
                        ErrorResponse errorResponse = (ErrorResponse)serlizer.Deserialize(new StringReader(responseBody));
                        Error error = errorResponse.Error[0];

                        bool retriableError = (statusCode == HttpStatusCode.InternalServerError || statusCode == HttpStatusCode.ServiceUnavailable);
                        retriableError = retriableError && error.Code != "RequestThrottled";

                        if (retriableError && retries < config.MaxErrorRetry)
                        {
                            PauseOnRetry(++retries);
                            shouldRetry = true;
                            continue;
                        }
                        else
                        {
                            shouldRetry = false;
                        }

                        /* Throw formatted exception with information available from the error response */
                        throw new MarketplaceWebServiceException(
                            error.Message,
                            statusCode,
                            error.Code,
                            error.Type,
                            errorResponse.RequestId,
                            errorResponse.ToXML(),
                            rhm);
                    }
                    /* Rethrow on deserializer error */
                    catch (Exception e)
                    {
                        if (e is MarketplaceWebServiceException)
                        {
                            throw e;
                        }
                        else
                        {
                            MarketplaceWebServiceException se = ReportAnyErrors(responseBody, statusCode, e, rhm);
                            throw se;
                        }
                    }
                }

                /* Catch other exceptions, attempt to convert to formatted exception,
                 * else rethrow wrapped exception */
                catch (Exception e)
                {
                    throw new MarketplaceWebServiceException(e);
                }
            } while (shouldRetry);

            return response;
        }

        /**
         * Examines the request type and determines if the MarketplaceWebService attribute
         * has the ResponseType set to ResponseType.STREAMING. The response from the service
         * will be written to the stream marked with the MarketplaceWebServiceStream attribute. 
         */
        private bool ExpectStreamingResponse(Type type)
        {
            if (type == null) {
                return false;
            }

            MarketplaceWebServiceAttribute attribute = (MarketplaceWebServiceAttribute)
                Attribute.GetCustomAttribute(type, typeof(MarketplaceWebServiceAttribute));

            if (attribute == null)
            {
                return false;
            }
            else
            {
                return attribute.ResponseType == ResponseType.STREAMING;
            }
        }

        /**
         * Returns the RequestType of the request, as set in the MarketplaceWebService attribute.
         * If the attribute is missing from the request, it is assumed that the request type
         * is RequestType.DEFAULT.
         */
        private RequestType GetMarketplaceWebServiceRequestType(Type type)
        {
            if (type == null || type == typeof(object))
                return RequestType.DEFAULT;

            MarketplaceWebServiceAttribute attribute = (MarketplaceWebServiceAttribute)
                Attribute.GetCustomAttribute(type, typeof(MarketplaceWebServiceAttribute));

            return attribute.RequestType;
        }

        /**
         * Based on StreamType, get a reference to a Stream set in the request instance.
         */
        private Stream GetTransferStream(object request, StreamType streamType)
        {
            if (request == null || !request.GetType().IsClass)
            {
                throw new ArgumentException("request must be a class reference");
            }

            Stream s = null;

            foreach (MethodInfo mi in request.GetType().GetMethods())
            {
                MarketplaceWebServiceStreamAttribute attribute = (MarketplaceWebServiceStreamAttribute)
                    Attribute.GetCustomAttribute(mi, typeof(MarketplaceWebServiceStreamAttribute));

                if (attribute != null && attribute.StreamType == streamType)
                {
                    s = (Stream) mi.Invoke(request, null);
                }
            }

            foreach (PropertyInfo pi in request.GetType().GetProperties())
            {
                MarketplaceWebServiceStreamAttribute attribute = (MarketplaceWebServiceStreamAttribute)
                   Attribute.GetCustomAttribute(pi, typeof(MarketplaceWebServiceStreamAttribute));

                if (attribute != null && attribute.StreamType == streamType)
                {
                    s = (Stream)pi.GetValue(request, null);
                }
            }

            return s;
        }

        /**
         * For streaming responses, the HTTP response body will not be marshaled into a
         * Response object, but rather streamed into a writable stream defined in the inital
         * request. For these response types, response metadata, RequestId and the Content-MD5 values, 
         * are sent in the HTTP header. This method constructs a psuedo response document and
         * marshals it into a Response object.
         */
        private T DeserializeStreamingResponse<T>(IDictionary<String, String> responseElements)
        {
            string responseElementBase = typeof(T).Name;
            
            if (responseElementBase.EndsWith("Response"))
            {
                responseElementBase = responseElementBase.Remove(responseElementBase.Length - "Response".Length);
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n");
            sb.Append("  <{0}Response xmlns=\"http://mws.amazonaws.com/doc/2009-01-01/\">\n");
            sb.Append("    <{0}Result>\n");
            sb.Append("      <ContentMD5>{1}</ContentMD5>\n");
            sb.Append("    </{0}Result>\n");
            sb.Append("  <ResponseMetadata>\n");
            sb.Append("    <RequestId>{2}</RequestId>\n");
            sb.Append("  </ResponseMetadata>\n");
            sb.Append("</{0}Response>\n");

            XmlSerializer serlizer = new XmlSerializer(typeof(T));

            T response = default(T);
            response = (T)serlizer.Deserialize(new StringReader(
              String.Format(
                sb.ToString(), responseElementBase, responseElements["ContentMD5"], responseElements["RequestId"])));

            return response;
        }

        /**
         * For requests that have defined a ResponseType of ResponseType.STREAMING, this 
         * method will write the HTTP response body into the stream marked with the
         * MarketplaceWebServiceStream attribute, setting the StreamType to StreamType.RECEIVE_STREAM.
         * In addition to writing the response, the Content-MD5 returned by the service
         * will be compared for equality to a locally calculated value.
         * 
         * Content-MD5 comparison failure will result in a MarketplaceWebServiceException to be
         * thrown.
         */ 
        private T HandleStreamingResponse<T>(HttpWebResponse webResponse, object clazz)
        {
            Stream receiverStream = GetTransferStream(clazz, StreamType.RECEIVE_STREAM);

            CopyStream(webResponse.GetResponseStream(), receiverStream);
            receiverStream.Position = 0;

            WebHeaderCollection headers = webResponse.Headers;
            string receivedContentMD5 = headers.Get("Content-MD5");
            string expectedContentMD5 = CalculateContentMD5(receiverStream);

            receiverStream.Position = 0;

            if (receivedContentMD5 != expectedContentMD5)
            {
                throw new MarketplaceWebServiceException(
                    "Received Content MD5 value " + receivedContentMD5 +
                    " doesn't match computed value " + expectedContentMD5 + ".");
            }

            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("RequestId", headers.Get("x-amz-request-id"));
            parameters.Add("ContentMD5", headers.Get("Content-MD5"));

            return DeserializeStreamingResponse<T>(parameters);
        }

        /**
         * Calculates the MD5 hash value.
         */
        public static string CalculateContentMD5(Stream content)
        {
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            byte[] hash = provider.ComputeHash(content);
            return Convert.ToBase64String(hash);
        }

        /**
         * Copy the contents of the from stream, into the to stream.
         * It is assumed that from has an overridden Read method, and that
         * to has an overridden Write method.
         */
        private void CopyStream(Stream from, Stream to)
        {
            if (!from.CanRead)
            {
                throw new ArgumentException("from Stream must implement the Read method.");
            }

            if (!to.CanWrite)
            {
                throw new ArgumentException("to Stream must implement the Write method.");
            }

            const int SIZE = 1024*1024;
            byte[] buffer = new byte[SIZE];

            int read = 0;
            while ((read = from.Read(buffer, 0, buffer.Length)) > 0)
            {
                to.Write(buffer, 0, read);
            }
        }

        /**
         * Look for additional error strings in the response and return formatted exception
         */
        private MarketplaceWebServiceException ReportAnyErrors(String responseBody, HttpStatusCode status, Exception e, ResponseHeaderMetadata rhm)
        {

            MarketplaceWebServiceException ex = null;

            if (responseBody != null && responseBody.StartsWith("<"))
            {
                Match errorMatcherOne = Regex.Match(responseBody, "<RequestId>(.*)</RequestId>.*<Error>" +
                        "<Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?", RegexOptions.Multiline);
                Match errorMatcherTwo = Regex.Match(responseBody, "<Error><Code>(.*)</Code><Message>(.*)" +
                        "</Message></Error>.*(<Error>)?.*<RequestID>(.*)</RequestID>", RegexOptions.Multiline);

                if (errorMatcherOne.Success)
                {
                    String requestId = errorMatcherOne.Groups[1].Value;
                    String code = errorMatcherOne.Groups[2].Value;
                    String message = errorMatcherOne.Groups[3].Value;

                    ex = new MarketplaceWebServiceException(message, status, code, "Unknown", requestId, responseBody, rhm);

                }
                else if (errorMatcherTwo.Success)
                {
                    String code = errorMatcherTwo.Groups[1].Value;
                    String message = errorMatcherTwo.Groups[2].Value;
                    String requestId = errorMatcherTwo.Groups[4].Value;

                    ex = new MarketplaceWebServiceException(message, status, code, "Unknown", requestId, responseBody, rhm);
                }
                else
                {
                    ex = new MarketplaceWebServiceException("Internal Error", status, rhm);
                }
            }
            else
            {
                ex = new MarketplaceWebServiceException("Internal Error", status, rhm);
            }
            return ex;
        }

        /**
         * Exponential sleep on failed request
         */
        private void PauseOnRetry(int retries)
        {
            int delay = (int)Math.Pow(4, retries) * 100;
            System.Threading.Thread.Sleep(delay);
        }

        /**
         * Add authentication related and version parameters
         */
        private void AddRequiredParameters(IDictionary<String, String> parameters)
        {
            parameters.Add("AWSAccessKeyId", this.awsAccessKeyId);
            parameters.Add("Timestamp", GetFormattedTimestamp(DateTime.Now));
            parameters.Add("Version", config.ServiceVersion);
            parameters.Add("SignatureVersion", config.SignatureVersion);
            parameters.Add("Signature", SignParameters(parameters, this.awsSecretAccessKey));
        }

        /**
         * Convert Dictionary of paremeters to Url encoded query string
         */
        private string GetParametersAsString(IDictionary<String, String> parameters)
        {
            StringBuilder data = new StringBuilder();
            foreach (String key in (IEnumerable<String>)parameters.Keys)
            {
                String value = parameters[key];
                if (value != null)
                {
                    data.Append(key);
                    data.Append('=');
                    data.Append(UrlEncode(value, false));
                    data.Append('&');
                }
            }
            String result = data.ToString();
            return result.Remove(result.Length - 1);
        }

        /**
         * Computes RFC 2104-compliant HMAC signature for request parameters
         * Implements AWS Signature, as per following spec:
         *
         * If Signature Version is 0, it signs concatenated Action and Timestamp
         *
         * If Signature Version is 1, it performs the following:
         *
         * Sorts all  parameters (including SignatureVersion and excluding Signature,
         * the value of which is being created), ignoring case.
         *
         * Iterate over the sorted list and append the parameter name (in original case)
         * and then its value. It will not URL-encode the parameter values before
         * constructing this string. There are no separators.
         *
         * If Signature Version is 2, string to sign is based on following:
         *
         *    1. The HTTP Request Method followed by an ASCII newline (%0A)
         *    2. The HTTP Host header in the form of lowercase host, followed by an ASCII newline.
         *    3. The URL encoded HTTP absolute path component of the URI
         *       (up to but not including the query string parameters);
         *       if this is empty use a forward '/'. This parameter is followed by an ASCII newline.
         *    4. The concatenation of all query string components (names and values)
         *       as UTF-8 characters which are URL encoded as per RFC 3986
         *       (hex characters MUST be uppercase), sorted using lexicographic byte ordering.
         *       Parameter names are separated from their values by the '=' character
         *       (ASCII character 61), even if the value is empty.
         *       Pairs of parameter and values are separated by the '&' character (ASCII code 38).
         *
         */
        private String SignParameters(IDictionary<String, String> parameters, String key)
        {
            String signatureVersion = parameters["SignatureVersion"];

            KeyedHashAlgorithm algorithm = new HMACSHA1();

            String stringToSign = null;
            if ("2".Equals(signatureVersion))
            {
                String signatureMethod = config.SignatureMethod;
                algorithm = KeyedHashAlgorithm.Create(signatureMethod.ToUpper());
                parameters.Add("SignatureMethod", signatureMethod);
                stringToSign = CalculateStringToSignV2(parameters);
            }
            else
            {
                throw new Exception("Invalid Signature Version specified");
            }

            return Sign(stringToSign, key, algorithm);
        }

        private String CalculateStringToSignV2(IDictionary<String, String> parameters)
        {
            StringBuilder data = new StringBuilder();
            IDictionary<String, String> sorted =
                  new SortedDictionary<String, String>(parameters, StringComparer.Ordinal);
            data.Append("POST");
            data.Append("\n");
            Uri endpoint = new Uri(config.ServiceURL.ToLower());

            data.Append(endpoint.Host);
            if (endpoint.Port != 443 && endpoint.Port != 80) 
            { 
              data.Append(":")
                  .Append(endpoint.Port);
            }
            data.Append("\n");
            String uri = endpoint.AbsolutePath;
            if (uri == null || uri.Length == 0)
            {
                uri = "/";
            }
            data.Append(UrlEncode(uri, true));
            data.Append("\n");
            foreach (KeyValuePair<String, String> pair in sorted)
            {
                if (pair.Value != null)
                {
                    data.Append(UrlEncode(pair.Key, false));
                    data.Append("=");
                    data.Append(UrlEncode(pair.Value, false));
                    data.Append("&");
                }

            }

            String result = data.ToString();
            return result.Remove(result.Length - 1);
        }

        private String UrlEncode(String data, bool path)
        {
            StringBuilder encoded = new StringBuilder();
            String unreservedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~" + (path ? "/" : "");

            foreach (char symbol in System.Text.Encoding.UTF8.GetBytes(data))
            {
                if (unreservedChars.IndexOf(symbol) != -1)
                {
                    encoded.Append(symbol);
            }
            else
            {
                    encoded.Append("%" + String.Format("{0:X2}", (int)symbol));
            }
            }

            return encoded.ToString();

        }

        /**
         * Computes RFC 2104-compliant HMAC signature.
         */
        private String Sign(String data, String key, KeyedHashAlgorithm algorithm)
        {
            Encoding encoding = new UTF8Encoding();
            algorithm.Key = encoding.GetBytes(key);
            return Convert.ToBase64String(algorithm.ComputeHash(
                encoding.GetBytes(data.ToCharArray())));
        }

        /**
         * Formats date as ISO 8601 timestamp
         */
        private String GetFormattedTimestamp(DateTime dt)
        {
            DateTime utcTime;
            if (dt.Kind == DateTimeKind.Local)
            {
                utcTime = new DateTime(
                    dt.Year,
                    dt.Month,
                    dt.Day,
                    dt.Hour,
                    dt.Minute,
                    dt.Second,
                    dt.Millisecond,
                    DateTimeKind.Local).ToUniversalTime();
            }
            else
            {
                // If DateTimeKind.Unspecified, assume UTC.
                utcTime = dt;

            }
            
            return utcTime.ToString("yyyy-MM-dd\\THH:mm:ss.fff\\Z", CultureInfo.InvariantCulture);
        }

        /**
         * Convert GetReportRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetReport(GetReportRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetReport");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetReportId())
            {
                parameters.Add("ReportId", request.ReportId);
            }

            return parameters;
        }
        
                                
        /**
         * Convert GetReportScheduleCountRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetReportScheduleCount(GetReportScheduleCountRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetReportScheduleCount");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetReportTypeList())
            {
                TypeList  reportTypeList = request.ReportTypeList;
                List<String> typeList  =  reportTypeList.Type;
                foreach  (String type in typeList)
                {
                    parameters.Add("ReportTypeList" + "." + "Type" + "."  + (typeList.IndexOf(type) + 1), type);
                }
            }

            return parameters;
        }
        
                                
        /**
         * Convert GetReportRequestListByNextTokenRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetReportRequestListByNextToken(GetReportRequestListByNextTokenRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetReportRequestListByNextToken");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetNextToken())
            {
                parameters.Add("NextToken", request.NextToken);
            }

            return parameters;
        }
        
                                
        /**
         * Convert UpdateReportAcknowledgementsRequest to name value pairs
         */
        private IDictionary<String, String> ConvertUpdateReportAcknowledgements(UpdateReportAcknowledgementsRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "UpdateReportAcknowledgements");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetReportIdList())
            {
                IdList  reportIdList = request.ReportIdList;
                List<String> idList  =  reportIdList.Id;
                foreach  (String id in idList)
                {
                    parameters.Add("ReportIdList" + "." + "Id" + "."  + (idList.IndexOf(id) + 1), id);
                }
            }
            if (request.IsSetAcknowledged())
            {
                parameters.Add("Acknowledged", request.Acknowledged.ToString().ToLower());
            }

            return parameters;
        }
        
                                
        /**
         * Convert SubmitFeedRequest to name value pairs
         */
        private IDictionary<String, String> ConvertSubmitFeed(SubmitFeedRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "SubmitFeed");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMarketplaceIdList())
            {
                IdList marketplaceIdList = request.MarketplaceIdList;
                List<String> idList = marketplaceIdList.Id;
                int marketplaceIdListIndex = 1;
                foreach (String id in idList)
                {
                    parameters.Add("MarketplaceIdList.Id." + marketplaceIdListIndex, id);
                    marketplaceIdListIndex++;
                }
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetFeedType())
            {
                parameters.Add("FeedType", request.FeedType);
            }
            if (request.IsSetPurgeAndReplace())
            {
                parameters.Add("PurgeAndReplace", request.PurgeAndReplace.ToString().ToLower());
            }
            if (request.IsSetContentMD5())
            {
                parameters.Add("ContentMD5Value", request.ContentMD5);
            }

            return parameters;
        }
        
                                
        /**
         * Convert GetReportCountRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetReportCount(GetReportCountRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetReportCount");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetReportTypeList())
            {
                TypeList  reportTypeList = request.ReportTypeList;
                List<String> typeList  =  reportTypeList.Type;
                foreach  (String type in typeList)
                {
                    parameters.Add("ReportTypeList" + "." + "Type" + "."  + (typeList.IndexOf(type) + 1), type);
                }
            }
            if (request.IsSetAcknowledged())
            {
                parameters.Add("Acknowledged", request.Acknowledged.ToString().ToLower());
            }
            if (request.IsSetAvailableFromDate())
            {
                parameters.Add("AvailableFromDate", GetFormattedTimestamp(request.AvailableFromDate));
            }
            if (request.IsSetAvailableToDate())
            {
                parameters.Add("AvailableToDate", GetFormattedTimestamp(request.AvailableToDate));
            }

            return parameters;
        }
        
                                
        /**
         * Convert GetFeedSubmissionListByNextTokenRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetFeedSubmissionListByNextToken(GetFeedSubmissionListByNextTokenRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetFeedSubmissionListByNextToken");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetNextToken())
            {
                parameters.Add("NextToken", request.NextToken);
            }

            return parameters;
        }
        
                                
        /**
         * Convert CancelFeedSubmissionsRequest to name value pairs
         */
        private IDictionary<String, String> ConvertCancelFeedSubmissions(CancelFeedSubmissionsRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "CancelFeedSubmissions");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetFeedSubmissionIdList())
            {
                IdList  feedSubmissionIdList = request.FeedSubmissionIdList;
                List<String> idList  =  feedSubmissionIdList.Id;
                foreach  (String id in idList)
                {
                    parameters.Add("FeedSubmissionIdList" + "." + "Id" + "."  + (idList.IndexOf(id) + 1), id);
                }
            }
            if (request.IsSetFeedTypeList())
            {
                TypeList  feedTypeList = request.FeedTypeList;
                List<String> typeList  =  feedTypeList.Type;
                foreach  (String type in typeList)
                {
                    parameters.Add("FeedTypeList" + "." + "Type" + "."  + (typeList.IndexOf(type) + 1), type);
                }
            }
            if (request.IsSetSubmittedFromDate())
            {
                parameters.Add("SubmittedFromDate", GetFormattedTimestamp(request.SubmittedFromDate));
            }
            if (request.IsSetSubmittedToDate())
            {
                parameters.Add("SubmittedToDate", GetFormattedTimestamp(request.SubmittedToDate));
            }

            return parameters;
        }
        
                                
        /**
         * Convert RequestReportRequest to name value pairs
         */
        private IDictionary<String, String> ConvertRequestReport(RequestReportRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "RequestReport");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMarketplaceIdList())
            {
                IdList marketplaceIdList = request.MarketplaceIdList;
                List<String> idList = marketplaceIdList.Id;
                int marketplaceIdListIndex = 1;
                foreach (String id in idList)
                {
                    parameters.Add("MarketplaceIdList.Id." + marketplaceIdListIndex, id);
                    marketplaceIdListIndex++;
                }
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetReportType())
            {
                parameters.Add("ReportType", request.ReportType);
            }
            if (request.IsSetStartDate())
            {
                parameters.Add("StartDate", GetFormattedTimestamp(request.StartDate));
            }
            if (request.IsSetEndDate())
            {
                parameters.Add("EndDate", GetFormattedTimestamp(request.EndDate));
            }
            if (request.IsSetReportOptions())
            {
                parameters.Add("ReportOptions", request.ReportOptions);
            }

            return parameters;
        }
        
                                
        /**
         * Convert GetFeedSubmissionCountRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetFeedSubmissionCount(GetFeedSubmissionCountRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetFeedSubmissionCount");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetFeedTypeList())
            {
                TypeList  feedTypeList = request.FeedTypeList;
                List<String> typeList  =  feedTypeList.Type;
                foreach  (String type in typeList)
                {
                    parameters.Add("FeedTypeList" + "." + "Type" + "."  + (typeList.IndexOf(type) + 1), type);
                }
            }
            if (request.IsSetFeedProcessingStatusList())
            {
                StatusList  feedProcessingStatusList = request.FeedProcessingStatusList;
                List<String> statusList  =  feedProcessingStatusList.Status;
                foreach  (String status in statusList)
                {
                    parameters.Add("FeedProcessingStatusList" + "." + "Status" + "."  + (statusList.IndexOf(status) + 1), status);
                }
            }
            if (request.IsSetSubmittedFromDate())
            {
                parameters.Add("SubmittedFromDate", GetFormattedTimestamp(request.SubmittedFromDate));
            }
            if (request.IsSetSubmittedToDate())
            {
                parameters.Add("SubmittedToDate", GetFormattedTimestamp(request.SubmittedToDate));
            }

            return parameters;
        }
        
                                
        /**
         * Convert CancelReportRequestsRequest to name value pairs
         */
        private IDictionary<String, String> ConvertCancelReportRequests(CancelReportRequestsRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "CancelReportRequests");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetReportRequestIdList())
            {
                IdList  reportRequestIdList = request.ReportRequestIdList;
                List<String> idList  =  reportRequestIdList.Id;
                foreach  (String id in idList)
                {
                    parameters.Add("ReportRequestIdList" + "." + "Id" + "."  + (idList.IndexOf(id) + 1), id);
                }
            }
            if (request.IsSetReportTypeList())
            {
                TypeList  reportTypeList = request.ReportTypeList;
                List<String> typeList  =  reportTypeList.Type;
                foreach  (String type in typeList)
                {
                    parameters.Add("ReportTypeList" + "." + "Type" + "."  + (typeList.IndexOf(type) + 1), type);
                }
            }
            if (request.IsSetReportProcessingStatusList())
            {
                StatusList  reportProcessingStatusList = request.ReportProcessingStatusList;
                List<String> statusList  =  reportProcessingStatusList.Status;
                foreach  (String status in statusList)
                {
                    parameters.Add("ReportProcessingStatusList" + "." + "Status" + "."  + (statusList.IndexOf(status) + 1), status);
                }
            }
            if (request.IsSetRequestedFromDate())
            {
                parameters.Add("RequestedFromDate", GetFormattedTimestamp(request.RequestedFromDate));
            }
            if (request.IsSetRequestedToDate())
            {
                parameters.Add("RequestedToDate", GetFormattedTimestamp(request.RequestedToDate));
            }

            return parameters;
        }
        
                                
        /**
         * Convert GetReportListRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetReportList(GetReportListRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetReportList");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetMaxCount())
            {
                parameters.Add("MaxCount", request.MaxCount + "");
            }
            if (request.IsSetReportTypeList())
            {
                TypeList  reportTypeList = request.ReportTypeList;
                List<String> typeList  =  reportTypeList.Type;
                foreach  (String type in typeList)
                {
                    parameters.Add("ReportTypeList" + "." + "Type" + "."  + (typeList.IndexOf(type) + 1), type);
                }
            }
            if (request.IsSetAcknowledged())
            {
                parameters.Add("Acknowledged", request.Acknowledged.ToString().ToLower());
            }
            if (request.IsSetAvailableFromDate())
            {
                parameters.Add("AvailableFromDate", GetFormattedTimestamp(request.AvailableFromDate));
            }
            if (request.IsSetAvailableToDate())
            {
                parameters.Add("AvailableToDate", GetFormattedTimestamp(request.AvailableToDate));
            }
            if (request.IsSetReportRequestIdList())
            {
                IdList  reportRequestIdList = request.ReportRequestIdList;
                List<String> idList  =  reportRequestIdList.Id;
                foreach  (String id in idList)
                {
                    parameters.Add("ReportRequestIdList" + "." + "Id" + "."  + (idList.IndexOf(id) + 1), id);
                }
            }

            return parameters;
        }
        
                                
        /**
         * Convert GetFeedSubmissionResultRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetFeedSubmissionResult(GetFeedSubmissionResultRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetFeedSubmissionResult");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetFeedSubmissionId())
            {
                parameters.Add("FeedSubmissionId", request.FeedSubmissionId);
            }

            return parameters;
        }
        
                                
        /**
         * Convert GetFeedSubmissionListRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetFeedSubmissionList(GetFeedSubmissionListRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetFeedSubmissionList");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetFeedSubmissionIdList())
            {
                IdList  feedSubmissionIdList = request.FeedSubmissionIdList;
                List<String> idList  =  feedSubmissionIdList.Id;
                foreach  (String id in idList)
                {
                    parameters.Add("FeedSubmissionIdList" + "." + "Id" + "."  + (idList.IndexOf(id) + 1), id);
                }
            }
            if (request.IsSetMaxCount())
            {
                parameters.Add("MaxCount", request.MaxCount + "");
            }
            if (request.IsSetFeedTypeList())
            {
                TypeList  feedTypeList = request.FeedTypeList;
                List<String> typeList  =  feedTypeList.Type;
                foreach  (String type in typeList)
                {
                    parameters.Add("FeedTypeList" + "." + "Type" + "."  + (typeList.IndexOf(type) + 1), type);
                }
            }
            if (request.IsSetFeedProcessingStatusList())
            {
                StatusList  feedProcessingStatusList = request.FeedProcessingStatusList;
                List<String> statusList  =  feedProcessingStatusList.Status;
                foreach  (String status in statusList)
                {
                    parameters.Add("FeedProcessingStatusList" + "." + "Status" + "."  + (statusList.IndexOf(status) + 1), status);
                }
            }
            if (request.IsSetSubmittedFromDate())
            {
                parameters.Add("SubmittedFromDate", GetFormattedTimestamp(request.SubmittedFromDate));
            }
            if (request.IsSetSubmittedToDate())
            {
                parameters.Add("SubmittedToDate", GetFormattedTimestamp(request.SubmittedToDate));
            }

            return parameters;
        }
        
                                
        /**
         * Convert GetReportRequestListRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetReportRequestList(GetReportRequestListRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetReportRequestList");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetReportRequestIdList())
            {
                IdList  reportRequestIdList = request.ReportRequestIdList;
                List<String> idList  =  reportRequestIdList.Id;
                foreach  (String id in idList)
                {
                    parameters.Add("ReportRequestIdList" + "." + "Id" + "."  + (idList.IndexOf(id) + 1), id);
                }
            }
            if (request.IsSetReportTypeList())
            {
                TypeList  reportTypeList = request.ReportTypeList;
                List<String> typeList  =  reportTypeList.Type;
                foreach  (String type in typeList)
                {
                    parameters.Add("ReportTypeList" + "." + "Type" + "."  + (typeList.IndexOf(type) + 1), type);
                }
            }
            if (request.IsSetReportProcessingStatusList())
            {
                StatusList  reportProcessingStatusList = request.ReportProcessingStatusList;
                List<String> statusList  =  reportProcessingStatusList.Status;
                foreach  (String status in statusList)
                {
                    parameters.Add("ReportProcessingStatusList" + "." + "Status" + "."  + (statusList.IndexOf(status) + 1), status);
                }
            }
            if (request.IsSetMaxCount())
            {
                parameters.Add("MaxCount", request.MaxCount + "");
            }
            if (request.IsSetRequestedFromDate())
            {
                parameters.Add("RequestedFromDate", GetFormattedTimestamp(request.RequestedFromDate));
            }
            if (request.IsSetRequestedToDate())
            {
                parameters.Add("RequestedToDate", GetFormattedTimestamp(request.RequestedToDate));
            }

            return parameters;
        }
        
                                
        /**
         * Convert GetReportScheduleListByNextTokenRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetReportScheduleListByNextToken(GetReportScheduleListByNextTokenRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetReportScheduleListByNextToken");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetNextToken())
            {
                parameters.Add("NextToken", request.NextToken);
            }

            return parameters;
        }
        
                                
        /**
         * Convert GetReportListByNextTokenRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetReportListByNextToken(GetReportListByNextTokenRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetReportListByNextToken");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetNextToken())
            {
                parameters.Add("NextToken", request.NextToken);
            }

            return parameters;
        }
        
                                
        /**
         * Convert ManageReportScheduleRequest to name value pairs
         */
        private IDictionary<String, String> ConvertManageReportSchedule(ManageReportScheduleRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "ManageReportSchedule");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetReportType())
            {
                parameters.Add("ReportType", request.ReportType);
            }
            if (request.IsSetSchedule())
            {
                parameters.Add("Schedule", request.Schedule);
            }
            if (request.IsSetScheduleDate())
            {
                parameters.Add("ScheduleDate", GetFormattedTimestamp(request.ScheduleDate));
            }

            return parameters;
        }
        
                                
        /**
         * Convert GetReportRequestCountRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetReportRequestCount(GetReportRequestCountRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetReportRequestCount");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetReportTypeList())
            {
                TypeList  reportTypeList = request.ReportTypeList;
                List<String> typeList  =  reportTypeList.Type;
                foreach  (String type in typeList)
                {
                    parameters.Add("ReportTypeList" + "." + "Type" + "."  + (typeList.IndexOf(type) + 1), type);
                }
            }
            if (request.IsSetReportProcessingStatusList())
            {
                StatusList  reportProcessingStatusList = request.ReportProcessingStatusList;
                List<String> statusList  =  reportProcessingStatusList.Status;
                foreach  (String status in statusList)
                {
                    parameters.Add("ReportProcessingStatusList" + "." + "Status" + "."  + (statusList.IndexOf(status) + 1), status);
                }
            }
            if (request.IsSetRequestedFromDate())
            {
                parameters.Add("RequestedFromDate", GetFormattedTimestamp(request.RequestedFromDate));
            }
            if (request.IsSetRequestedToDate())
            {
                parameters.Add("RequestedToDate", GetFormattedTimestamp(request.RequestedToDate));
            }

            return parameters;
        }
        
                                
        /**
         * Convert GetReportScheduleListRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetReportScheduleList(GetReportScheduleListRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetReportScheduleList");
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }
            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }
            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }
            if (request.IsSetReportTypeList())
            {
                TypeList  reportTypeList = request.ReportTypeList;
                List<String> typeList  =  reportTypeList.Type;
                foreach  (String type in typeList)
                {
                    parameters.Add("ReportTypeList" + "." + "Type" + "."  + (typeList.IndexOf(type) + 1), type);
                }
            }

            return parameters;
        }
        
                                                                                        
    }
}
