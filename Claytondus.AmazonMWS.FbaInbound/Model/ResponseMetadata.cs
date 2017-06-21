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
 * Response Metadata
 * API Version: 2010-10-01
 * Library Version: 2016-10-05
 * Generated: Wed Oct 05 06:15:39 PDT 2016
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaInbound.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    [XmlRootAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", IsNullable = false)]
    public class ResponseMetadata : AbstractMwsObject
    {

        private string _requestId;

        /// <summary>
        /// Gets and sets the RequestId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "RequestId")]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        /// <summary>
        /// Sets the RequestId property.
        /// </summary>
        /// <param name="requestId">RequestId property.</param>
        /// <returns>this instance.</returns>
        public ResponseMetadata WithRequestId(string requestId)
        {
            this._requestId = requestId;
            return this;
        }

        /// <summary>
        /// Checks if RequestId property is set.
        /// </summary>
        /// <returns>true if RequestId property is set.</returns>
        public bool IsSetRequestId()
        {
            return this._requestId != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _requestId = reader.Read<string>("RequestId");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("RequestId", _requestId);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "ResponseMetadata", this);
        }


        public ResponseMetadata() : base()
        {
        }
    }
}
