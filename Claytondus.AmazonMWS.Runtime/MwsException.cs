/******************************************************************************* 
 * Copyright 2009-2012 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Marketplace Web Service Runtime Client Library
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Claytondus.AmazonMWS.Runtime
{
    /// <summary>
    /// Wrapped exception
    /// </summary>
    public class MwsException : Exception
    {
        private int statusCode;
        private string message;
        private string detail;
        private string errorCode;
        private string errorType;
        private string xml;
        private MwsResponseHeaderMetadata rhmd;

        public MwsException(Exception cause) : this(0, null, cause) { }

        /// <summary>
        /// Initializes exception with information available from the service
        /// </summary>
        /// <param name="statusCode">HTTP status code for error response (as an int)</param>
        /// <param name="message">Error message from HTTP header</param>
        /// <param name="errorCode">Error code from response XML</param>
        /// <param name="errorType">Error type from response XML</param>
        /// <param name="xml">Compete XML found in response</param>
        /// <param name="rhmd">Response header information</param>
        public MwsException(int statusCode, string message, string errorCode, string errorType, string xml, MwsResponseHeaderMetadata rhmd)
            : this(statusCode, message, errorCode, errorType, xml, rhmd, null) { }
        
        /// <summary>
        /// Initializes exception with information available from the service plus from an exception
        /// Needed for backwards compatibility
        /// </summary>
        /// <param name="statusCode">HTTP status code for error response (as an int)</param>
        /// <param name="message">Error message from HTTP header</param>
        /// <param name="errorCode">Error code from response XML</param>
        /// <param name="errorType">Error type from response XML</param>
        /// <param name="xml">Compete XML found in response</param>
        /// <param name="rhmd">Response header information</param>
        /// <param name="cause">Wrapped exception</param>
        public MwsException(int statusCode, string message, string errorCode, string errorType, string xml, MwsResponseHeaderMetadata rhmd, Exception cause)
            : base()
        {
            this.statusCode = statusCode;
            this.rhmd = rhmd;
            this.xml = xml;
            this.errorType = errorType;
            this.errorCode = errorCode;
            this.message = message;

            if (xml != null)
            {
                populateFromXML(xml);
            }
            
            if (cause is MwsException)
            {
                populateFromMWSException((MwsException)cause);
            }
        }       
        
        /// <summary>
        /// Initialize and set cause from another exception.
        /// <para>
        /// If cause is an MwsException, copies exception's attributes to this
        /// one, overwriting the statusCode and message parameters that were passed in.
        /// </para>
        /// </summary>
        /// <param name="statusCode">HTTP status code for error response.</param>
        /// <param name="message">Error message from HTTP header.</param>
        /// <param name="cause">Inner exception.</param>
        ////
        public MwsException(int statusCode, string message, Exception cause) 
            : base(message, cause)
        {
            this.statusCode = statusCode;
            this.message = message;

            if (cause is MwsException)
            {
                populateFromMWSException((MwsException)cause);
            }
        }

        /// <summary>
        /// Human-readable error message
        /// </summary>
        public override string Message
        {
            get { return message; }
        }

        /// <summary>
        /// Specific details about the error
        /// </summary>
        public string Detail
        {
            get { return detail; }
        }

        /// <summary>
        /// Consistent error code
        /// </summary>
        public string ErrorCode
        {
            get { return errorCode; }
        }

        /// <summary>
        /// Type of error, if available
        /// </summary>
        public string ErrorType
        {
            get { return errorType; }
        }

        /// <summary>
        /// ID of request returned by the service, if available
        /// </summary>
        public string RequestId
        {
            get { return ResponseHeaderMetadata != null ? ResponseHeaderMetadata.RequestId : null; }
        }

        /// <summary>
        /// HTTP Status code returned by the service, if available. 
        /// Set to HttpStatusCode.NotAcceptable if no status code available.
        /// </summary>
        public HttpStatusCode StatusCode
        {
            get 
            {
                try
                {
                    return (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), statusCode.ToString());
                }
                catch (Exception)
                {
                    return HttpStatusCode.NotAcceptable;
                }
            }
        }

        /// <summary>
        /// Raw XML returned by the service, if available
        /// </summary>
        public string XML
        {
            get { return xml; }
        }

        public virtual MwsResponseHeaderMetadata ResponseHeaderMetadata
        {
            get { return rhmd; }
        }
        
        private void populateFromMWSException( MwsException e ) {            
            if (e.StatusCode != null) this.statusCode = (int)e.StatusCode;
            if (e.Message != null) this.message = e.Message;
            if (e.errorCode != null) this.errorCode = e.ErrorCode;
            if (e.errorType != null) this.errorType = e.ErrorType;
            if (e.detail != null) this.detail = e.Detail;
            if (e.xml != null) this.xml = e.XML;
            if (e.ResponseHeaderMetadata != null) this.rhmd = e.ResponseHeaderMetadata;            
        }

        private void populateFromXML( string xml ) {
            try
            {
                MwsXmlReader r = new MwsXmlReader(xml);
                XmlMwsException parsed = r.Read<XmlMwsException>("Error");
                if (parsed.ErrorType != null) this.errorType = parsed.ErrorType;                
                if (parsed.ErrorCode != null) this.errorCode = parsed.ErrorCode;                
                if (parsed.Message != null) this.message = parsed.Message;                
                if (parsed.Detail != null) this.detail = parsed.Detail;
            }
            catch (Exception)
            {
                // Just eat it
            }        
        }
        
        internal class XmlMwsException : AbstractMwsObject {

            public string ErrorCode { get; private set; }
            public string ErrorType { get; private set; }
            public string Message { get; private set; }
            public string Detail { get; private set; }

            public override void ReadFragmentFrom(IMwsReader r) {
                this.ErrorType = r.Read<string>("Type");
                this.ErrorCode = r.Read<string>("Code");
                this.Message = r.Read<string>("Message");
                this.Detail = r.Read<string>("Detail");
            }

            public override void WriteFragmentTo(IMwsWriter w) {
                w.Write("Code", this.ErrorCode);
                w.Write("Type", this.ErrorType);
                w.Write("Message", this.Message);
                w.Write("Detail", this.Detail);
            }

            public override void WriteTo(IMwsWriter w) {
                w.Write("Error", this);
            }
        }
    }
}
