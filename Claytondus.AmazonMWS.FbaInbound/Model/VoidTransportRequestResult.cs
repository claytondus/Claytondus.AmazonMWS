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
 * Void Transport Request Result
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
    public class VoidTransportRequestResult : AbstractMwsObject
    {

        private TransportResult _transportResult;

        /// <summary>
        /// Gets and sets the TransportResult property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransportResult")]
        public TransportResult TransportResult
        {
            get { return this._transportResult; }
            set { this._transportResult = value; }
        }

        /// <summary>
        /// Sets the TransportResult property.
        /// </summary>
        /// <param name="transportResult">TransportResult property.</param>
        /// <returns>this instance.</returns>
        public VoidTransportRequestResult WithTransportResult(TransportResult transportResult)
        {
            this._transportResult = transportResult;
            return this;
        }

        /// <summary>
        /// Checks if TransportResult property is set.
        /// </summary>
        /// <returns>true if TransportResult property is set.</returns>
        public bool IsSetTransportResult()
        {
            return this._transportResult != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _transportResult = reader.Read<TransportResult>("TransportResult");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("TransportResult", _transportResult);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "VoidTransportRequestResult", this);
        }


        public VoidTransportRequestResult() : base()
        {
        }
    }
}
