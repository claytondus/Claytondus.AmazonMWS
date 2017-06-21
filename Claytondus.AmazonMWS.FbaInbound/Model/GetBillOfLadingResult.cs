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
 * Get Bill Of Lading Result
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
    public class GetBillOfLadingResult : AbstractMwsObject
    {

        private TransportDocument _transportDocument;

        /// <summary>
        /// Gets and sets the TransportDocument property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransportDocument")]
        public TransportDocument TransportDocument
        {
            get { return this._transportDocument; }
            set { this._transportDocument = value; }
        }

        /// <summary>
        /// Sets the TransportDocument property.
        /// </summary>
        /// <param name="transportDocument">TransportDocument property.</param>
        /// <returns>this instance.</returns>
        public GetBillOfLadingResult WithTransportDocument(TransportDocument transportDocument)
        {
            this._transportDocument = transportDocument;
            return this;
        }

        /// <summary>
        /// Checks if TransportDocument property is set.
        /// </summary>
        /// <returns>true if TransportDocument property is set.</returns>
        public bool IsSetTransportDocument()
        {
            return this._transportDocument != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _transportDocument = reader.Read<TransportDocument>("TransportDocument");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("TransportDocument", _transportDocument);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "GetBillOfLadingResult", this);
        }


        public GetBillOfLadingResult() : base()
        {
        }
    }
}
