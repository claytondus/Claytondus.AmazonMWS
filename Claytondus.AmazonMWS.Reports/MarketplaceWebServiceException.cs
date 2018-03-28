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
using System.Net;
using MarketplaceWebService;
using MarketplaceWebService.Model;

namespace MarketplaceWebService
{
    /// <summary>
    /// Marketplace Web Service  Exception provides details of errors 
    /// returned by Marketplace Web Service  service
    /// </summary>
    public class MarketplaceWebServiceException : Exception 
    {
    
        private String message = null;
        private HttpStatusCode statusCode = default(HttpStatusCode);
        private String errorCode = null;
        private String errorType = null;
        private String requestId = null;
        private String xml = null;
        private ResponseHeaderMetadata responseHeaderMetadata = null;
    

        /// <summary>
        /// Constructs MarketplaceWebServiceException with message
        /// </summary>
        /// <param name="message">Overview of error</param>
        public MarketplaceWebServiceException(String message) {
            this.message = message;
        }
    
        /// <summary>
        /// Constructs MarketplaceWebServiceException with message and status code
        /// </summary>
        /// <param name="message">Overview of error</param>
        /// <param name="statusCode">HTTP status code for error response</param>
        /// <param name="rhm">Response Header Metadata</param>
        public MarketplaceWebServiceException(String message, HttpStatusCode statusCode, ResponseHeaderMetadata rhm) : this (message)
        {
            this.statusCode = statusCode;
            this.responseHeaderMetadata = rhm;
        }
    

        /// <summary>
        /// Constructs MarketplaceWebServiceException with wrapped exception
        /// </summary>
        /// <param name="t">Wrapped exception</param>
        public MarketplaceWebServiceException(Exception t) : this (t.Message, t) {

        }
    
        /// <summary>
        /// Constructs MarketplaceWebServiceException with message and wrapped exception
        /// </summary>
        /// <param name="message">Overview of error</param>
        /// <param name="t">Wrapped exception</param>
        public MarketplaceWebServiceException(String message, Exception t) : base (message, t) {
            this.message = message;
            if (t is MarketplaceWebServiceException)
            {
                MarketplaceWebServiceException ex = (MarketplaceWebServiceException)t;
                this.statusCode = ex.StatusCode;
                this.errorCode = ex.ErrorCode;
                this.errorType = ex.ErrorType;
                this.requestId = ex.RequestId;
                this.xml = ex.XML;
                this.responseHeaderMetadata = ex.ResponseHeaderMetadata;
            }
        }
    

        /// <summary>
        /// Constructs MarketplaceWebServiceException with information available from service
        /// </summary>
        /// <param name="message">Overview of error</param>
        /// <param name="statusCode">HTTP status code for error response</param>
        /// <param name="errorCode">Error Code returned by the service</param>
        /// <param name="errorType">Error type. Possible types:  Sender, Receiver or Unknown</param>
        /// <param name="requestId">Request ID returned by the service</param>
        /// <param name="xml">Compete xml found in response</param>
        /// <param name="rhm">Response Header Metadata</param>
        public MarketplaceWebServiceException(String message, HttpStatusCode statusCode, String errorCode, String errorType, String requestId, String xml, ResponseHeaderMetadata rhm) : this (message, statusCode, rhm)
        {
            this.errorCode = errorCode;
            this.errorType = errorType;
            this.requestId = requestId;
            this.xml = xml;
            this.responseHeaderMetadata = rhm;
        }
    
        /// <summary>
        /// Gets and sets of the ErrorCode property.
        /// </summary>
        public String ErrorCode
        {
            get { return this.errorCode; }
        }

        /// <summary>
        /// Gets and sets of the ErrorType property.
        /// </summary>
        public String ErrorType
        {
            get { return this.errorType; }
        }

        /// <summary>
        /// Gets error message
        /// </summary>
        public override String Message
        {
            get { return this.message; }
        }
    
 
        /// <summary>
        /// Gets status code returned by the service if available. If status
        /// code is set to -1, it means that status code was unavailable at the
        /// time exception was thrown
        /// </summary>
        public HttpStatusCode StatusCode
        {
            get { return this.statusCode; }
        }

        /// <summary>
        /// Gets XML returned by the service if available.
        /// </summary>
        public String XML
        {
            get { return this.xml; }
        }
 
        /// <summary>
        /// Gets Request ID returned by the service if available.
        /// </summary>
        public String RequestId
        {
            get { return this.requestId; }
        }

        public ResponseHeaderMetadata ResponseHeaderMetadata
        {
            get { return this.responseHeaderMetadata; }
        }
    
    }
}
