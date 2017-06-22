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
 * Marketplace Web Service Products
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */

using System;
using System.Net;
using Claytondus.AmazonMWS.Products.Model;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Products
{

    /// <summary>
    /// Exception thrown by MarketplaceWebServiceProducts operations
    /// </summary>
    public class MarketplaceWebServiceProductsException : MwsException
    {

        public MarketplaceWebServiceProductsException(string message, HttpStatusCode statusCode)
            : base((int)statusCode, message, null, null, null, null) { }

        public MarketplaceWebServiceProductsException(string message)
            : base(0, message, null) { }

        public MarketplaceWebServiceProductsException(string message, HttpStatusCode statusCode, ResponseHeaderMetadata rhmd)
            : base((int)statusCode, message, null, null, null, rhmd) { }

        public MarketplaceWebServiceProductsException(Exception ex)
            : base(ex) { }

        public MarketplaceWebServiceProductsException(string message, Exception ex)
            : base(0, message, ex) { }

        public MarketplaceWebServiceProductsException(string message, HttpStatusCode statusCode, string errorCode,
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

