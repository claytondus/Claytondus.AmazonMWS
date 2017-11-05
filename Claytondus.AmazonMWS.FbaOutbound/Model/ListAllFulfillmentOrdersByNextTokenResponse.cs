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
 * List All Fulfillment Orders By Next Token Response
 * API Version: 2010-10-01
 * Library Version: 2016-10-19
 * Generated: Wed Oct 19 08:37:54 PDT 2016
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaOutbound.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", IsNullable = false)]
    public class ListAllFulfillmentOrdersByNextTokenResponse : AbstractMwsObject, IMWSResponse
    {

        private ListAllFulfillmentOrdersByNextTokenResult _listAllFulfillmentOrdersByNextTokenResult;
        private ResponseMetadata _responseMetadata;
        private ResponseHeaderMetadata _responseHeaderMetadata;

        /// <summary>
        /// Gets and sets the ListAllFulfillmentOrdersByNextTokenResult property.
        /// </summary>
        [XmlElement(ElementName = "ListAllFulfillmentOrdersByNextTokenResult")]
        public ListAllFulfillmentOrdersByNextTokenResult ListAllFulfillmentOrdersByNextTokenResult
        {
            get { return this._listAllFulfillmentOrdersByNextTokenResult; }
            set { this._listAllFulfillmentOrdersByNextTokenResult = value; }
        }

        /// <summary>
        /// Sets the ListAllFulfillmentOrdersByNextTokenResult property.
        /// </summary>
        /// <param name="listAllFulfillmentOrdersByNextTokenResult">ListAllFulfillmentOrdersByNextTokenResult property.</param>
        /// <returns>this instance.</returns>
        public ListAllFulfillmentOrdersByNextTokenResponse WithListAllFulfillmentOrdersByNextTokenResult(ListAllFulfillmentOrdersByNextTokenResult listAllFulfillmentOrdersByNextTokenResult)
        {
            this._listAllFulfillmentOrdersByNextTokenResult = listAllFulfillmentOrdersByNextTokenResult;
            return this;
        }

        /// <summary>
        /// Checks if ListAllFulfillmentOrdersByNextTokenResult property is set.
        /// </summary>
        /// <returns>true if ListAllFulfillmentOrdersByNextTokenResult property is set.</returns>
        public bool IsSetListAllFulfillmentOrdersByNextTokenResult()
        {
            return this._listAllFulfillmentOrdersByNextTokenResult != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        [XmlElement(ElementName = "ResponseMetadata")]
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
        public ListAllFulfillmentOrdersByNextTokenResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
        [XmlElement(ElementName = "ResponseHeaderMetadata")]
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
        public ListAllFulfillmentOrdersByNextTokenResponse WithResponseHeaderMetadata(ResponseHeaderMetadata responseHeaderMetadata)
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
            _listAllFulfillmentOrdersByNextTokenResult = reader.Read<ListAllFulfillmentOrdersByNextTokenResult>("ListAllFulfillmentOrdersByNextTokenResult");
            _responseMetadata = reader.Read<ResponseMetadata>("ResponseMetadata");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ListAllFulfillmentOrdersByNextTokenResult", _listAllFulfillmentOrdersByNextTokenResult);
            writer.Write("ResponseMetadata", _responseMetadata);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "ListAllFulfillmentOrdersByNextTokenResponse", this);
        }


        public ListAllFulfillmentOrdersByNextTokenResponse() : base()
        {
        }
    }
}
