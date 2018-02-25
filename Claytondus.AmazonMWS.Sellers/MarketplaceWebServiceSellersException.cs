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
 * Marketplace Web Service Sellers
 * API Version: 2011-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 20:37:46 GMT 2015
 */

using System;
using System.Net;
using Claytondus.AmazonMWS.Runtime;
using Claytondus.AmazonMWS.Sellers.Model;

namespace Claytondus.AmazonMWS.Sellers
{

    /// <summary>
    /// Exception thrown by MarketplaceWebServiceSellers operations
    /// </summary>
    public class MarketplaceWebServiceSellersException : MwsException
    {

        public MarketplaceWebServiceSellersException(string message, HttpStatusCode statusCode)
            : base((int)statusCode, message, null, null, null, null) { }

        public MarketplaceWebServiceSellersException(string message)
            : base(0, message, null) { }

        public MarketplaceWebServiceSellersException(string message, HttpStatusCode statusCode, ResponseHeaderMetadata rhmd)
            : base((int)statusCode, message, null, null, null, rhmd) { }

        public MarketplaceWebServiceSellersException(Exception ex)
            : base(ex) { }

        public MarketplaceWebServiceSellersException(string message, Exception ex)
            : base(0, message, ex) { }

        public MarketplaceWebServiceSellersException(string message, HttpStatusCode statusCode, string errorCode,
            string errorType, string requestId, string xml, ResponseHeaderMetadata rhmd)
            : base((int)statusCode, message, errorCode, errorType, xml, rhmd) { }

        public MarketplaceWebServiceSellersException(string message, HttpStatusCode statusCode, string errorCode,
            string errorType, string requestId, string xml)
            : base((int)statusCode, message, errorCode, errorType, xml, null) { }

        public MarketplaceWebServiceSellersException(string message, HttpStatusCode statusCode, Exception cause, 
            string xml)
            : this(message, statusCode, null, null, null, xml, cause) { }

        public MarketplaceWebServiceSellersException(string message, HttpStatusCode statusCode, string errorCode,
            string errorType, string requestId, string xml, Exception cause)
            : base((int)statusCode, message, errorCode, errorType, xml, null, cause) { }

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

