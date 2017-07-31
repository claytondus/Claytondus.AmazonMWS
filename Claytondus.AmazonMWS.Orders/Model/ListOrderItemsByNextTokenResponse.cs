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
 * List Order Items By Next Token Response
 * API Version: 2013-09-01
 * Library Version: 2017-02-22
 * Generated: Thu Mar 02 12:41:05 UTC 2017
 */


using System;
using System.Xml;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Orders.Model
{
    public class ListOrderItemsByNextTokenResponse : AbstractMwsObject, IMWSResponse
    {

        private ListOrderItemsByNextTokenResult _listOrderItemsByNextTokenResult;
        private ResponseMetadata _responseMetadata;
        private ResponseHeaderMetadata _responseHeaderMetadata;

        /// <summary>
        /// Gets and sets the ListOrderItemsByNextTokenResult property.
        /// </summary>
        public ListOrderItemsByNextTokenResult ListOrderItemsByNextTokenResult
        {
            get { return this._listOrderItemsByNextTokenResult; }
            set { this._listOrderItemsByNextTokenResult = value; }
        }

        /// <summary>
        /// Sets the ListOrderItemsByNextTokenResult property.
        /// </summary>
        /// <param name="listOrderItemsByNextTokenResult">ListOrderItemsByNextTokenResult property.</param>
        /// <returns>this instance.</returns>
        public ListOrderItemsByNextTokenResponse WithListOrderItemsByNextTokenResult(ListOrderItemsByNextTokenResult listOrderItemsByNextTokenResult)
        {
            this._listOrderItemsByNextTokenResult = listOrderItemsByNextTokenResult;
            return this;
        }

        /// <summary>
        /// Checks if ListOrderItemsByNextTokenResult property is set.
        /// </summary>
        /// <returns>true if ListOrderItemsByNextTokenResult property is set.</returns>
        public bool IsSetListOrderItemsByNextTokenResult()
        {
            return this._listOrderItemsByNextTokenResult != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        public ResponseMetadata ResponseMetadata
        {
            get { return this._responseMetadata; }
            set { this._responseMetadata = value; }
        }

        /// <summary>
        /// Sets the ResponseMetadata property.
        /// </summary>
        /// <param name="responseMetadata">ResponseMetadata property.</param>
        /// <returns>this instance.</returns>
        public ListOrderItemsByNextTokenResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this._responseMetadata = responseMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseMetadata property is set.</returns>
        public bool IsSetResponseMetadata()
        {
            return this._responseMetadata != null;
        }

        /// <summary>
        /// Gets and sets the ResponseHeaderMetadata property.
        /// </summary>
        public ResponseHeaderMetadata ResponseHeaderMetadata
        {
            get { return this._responseHeaderMetadata; }
            set { this._responseHeaderMetadata = value; }
        }

        /// <summary>
        /// Sets the ResponseHeaderMetadata property.
        /// </summary>
        /// <param name="responseHeaderMetadata">ResponseHeaderMetadata property.</param>
        /// <returns>this instance.</returns>
        public ListOrderItemsByNextTokenResponse WithResponseHeaderMetadata(ResponseHeaderMetadata responseHeaderMetadata)
        {
            this._responseHeaderMetadata = responseHeaderMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseHeaderMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseHeaderMetadata property is set.</returns>
        public bool IsSetResponseHeaderMetadata()
        {
            return this._responseHeaderMetadata != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _listOrderItemsByNextTokenResult = reader.Read<ListOrderItemsByNextTokenResult>("ListOrderItemsByNextTokenResult");
            _responseMetadata = reader.Read<ResponseMetadata>("ResponseMetadata");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ListOrderItemsByNextTokenResult", _listOrderItemsByNextTokenResult);
            writer.Write("ResponseMetadata", _responseMetadata);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "ListOrderItemsByNextTokenResponse", this);
        }


        public ListOrderItemsByNextTokenResponse() : base()
        {
        }
    }
}
