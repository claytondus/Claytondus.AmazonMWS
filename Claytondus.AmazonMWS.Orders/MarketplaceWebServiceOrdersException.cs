/*******************************************************************************
 * Copyright 2009-2017 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Marketplace Web Service Orders
 * API Version: 2013-09-01
 * Library Version: 2017-02-22
 * Generated: Thu Mar 02 12:41:05 UTC 2017
 */

using System;
using System.Net;
using Claytondus.AmazonMWS.Orders.Model;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Orders
{

    /// <summary>
    /// Exception thrown by MarketplaceWebServiceOrders operations
    /// </summary>
    public class MarketplaceWebServiceOrdersException : MwsException
    {

        public MarketplaceWebServiceOrdersException(string message, HttpStatusCode statusCode)
            : base((int)statusCode, message, null, null, null, null) { }

        public MarketplaceWebServiceOrdersException(string message)
            : base(0, message, null) { }

        public MarketplaceWebServiceOrdersException(string message, HttpStatusCode statusCode, ResponseHeaderMetadata rhmd)
            : base((int)statusCode, message, null, null, null, rhmd) { }

        public MarketplaceWebServiceOrdersException(Exception ex)
            : base(ex) { }

        public MarketplaceWebServiceOrdersException(string message, Exception ex)
            : base(0, message, ex) { }

        public MarketplaceWebServiceOrdersException(string message, HttpStatusCode statusCode, string errorCode,
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

