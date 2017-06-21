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
 * Get Transport Content Result
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
    public class GetTransportContentResult : AbstractMwsObject
    {

        private TransportContent _transportContent;

        /// <summary>
        /// Gets and sets the TransportContent property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransportContent")]
        public TransportContent TransportContent
        {
            get { return this._transportContent; }
            set { this._transportContent = value; }
        }

        /// <summary>
        /// Sets the TransportContent property.
        /// </summary>
        /// <param name="transportContent">TransportContent property.</param>
        /// <returns>this instance.</returns>
        public GetTransportContentResult WithTransportContent(TransportContent transportContent)
        {
            this._transportContent = transportContent;
            return this;
        }

        /// <summary>
        /// Checks if TransportContent property is set.
        /// </summary>
        /// <returns>true if TransportContent property is set.</returns>
        public bool IsSetTransportContent()
        {
            return this._transportContent != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _transportContent = reader.Read<TransportContent>("TransportContent");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("TransportContent", _transportContent);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "GetTransportContentResult", this);
        }


        public GetTransportContentResult() : base()
        {
        }
    }
}
