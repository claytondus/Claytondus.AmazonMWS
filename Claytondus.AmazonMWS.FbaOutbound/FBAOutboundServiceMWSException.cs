/*******************************************************************************
 * Copyright 2009-2016 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * FBA Outbound Service MWS
 * API Version: 2010-10-01
 * Library Version: 2016-10-19
 * Generated: Wed Oct 19 08:37:54 PDT 2016
 */

using System;
using System.Net;
using Claytondus.AmazonMWS.FbaOutbound.Model;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaOutbound
{

    /// <summary>
    /// Exception thrown by FBAOutboundServiceMWS operations
    /// </summary>
    public class FBAOutboundServiceMWSException : MwsException
    {

        public FBAOutboundServiceMWSException(string message, HttpStatusCode statusCode)
            : base((int)statusCode, message, null, null, null, null) { }

        public FBAOutboundServiceMWSException(string message)
            : base(0, message, null) { }

        public FBAOutboundServiceMWSException(string message, HttpStatusCode statusCode, ResponseHeaderMetadata rhmd)
            : base((int)statusCode, message, null, null, null, rhmd) { }

        public FBAOutboundServiceMWSException(Exception ex)
            : base(ex) { }

        public FBAOutboundServiceMWSException(string message, Exception ex)
            : base(0, message, ex) { }

        public FBAOutboundServiceMWSException(string message, HttpStatusCode statusCode, string errorCode,
            string errorType, string requestId, string xml)
            : base((int)statusCode, message, errorCode, errorType, xml, null) { }

    public FBAOutboundServiceMWSException(string message, HttpStatusCode statusCode, string errorCode,
            string errorType, string requestId, string xml, ResponseHeaderMetadata rhmd)
            : base((int)statusCode, message, errorCode, errorType, xml, rhmd) { }

        public new ResponseHeaderMetadata ResponseHeaderMetadata
        {
            get 
            { 
                MwsResponseHeaderMetadata baseRHMD = base.ResponseHeaderMetadata;
                if(baseRHMD != null)
                {
                    return new ResponseHeaderMetadata(baseRHMD); 
                }
                else
                {
                    return null;
                }
            }
        }

    }

}

