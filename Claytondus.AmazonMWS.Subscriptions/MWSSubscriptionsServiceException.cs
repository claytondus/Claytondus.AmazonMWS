/*******************************************************************************
 * Copyright 2009-2015 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * MWS Subscriptions Service
 * API Version: 2013-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:27:11 GMT 2015
 */

using System;
using System.Net;
using Claytondus.AmazonMWS.Runtime;
using Claytondus.AmazonMWS.Subscriptions.Model;

namespace Claytondus.AmazonMWS.Subscriptions
{

    /// <summary>
    /// Exception thrown by MWSSubscriptionsService operations
    /// </summary>
    public class MWSSubscriptionsServiceException : MwsException
    {

        public MWSSubscriptionsServiceException(string message, HttpStatusCode statusCode)
            : base((int)statusCode, message, null, null, null, null) { }

        public MWSSubscriptionsServiceException(string message)
            : base(0, message, null) { }

        public MWSSubscriptionsServiceException(string message, HttpStatusCode statusCode, ResponseHeaderMetadata rhmd)
            : base((int)statusCode, message, null, null, null, rhmd) { }

        public MWSSubscriptionsServiceException(Exception ex)
            : base(ex) { }

        public MWSSubscriptionsServiceException(string message, Exception ex)
            : base(0, message, ex) { }

        public MWSSubscriptionsServiceException(string message, HttpStatusCode statusCode, string errorCode,
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

