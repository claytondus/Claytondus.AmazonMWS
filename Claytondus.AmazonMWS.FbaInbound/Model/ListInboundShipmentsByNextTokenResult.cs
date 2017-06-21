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
 * List Inbound Shipments By Next Token Result
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
    public class ListInboundShipmentsByNextTokenResult : AbstractMwsObject
    {

        private InboundShipmentList _shipmentData;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the ShipmentData property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipmentData")]
        public InboundShipmentList ShipmentData
        {
            get { return this._shipmentData; }
            set { this._shipmentData = value; }
        }

        /// <summary>
        /// Sets the ShipmentData property.
        /// </summary>
        /// <param name="shipmentData">ShipmentData property.</param>
        /// <returns>this instance.</returns>
        public ListInboundShipmentsByNextTokenResult WithShipmentData(InboundShipmentList shipmentData)
        {
            this._shipmentData = shipmentData;
            return this;
        }

        /// <summary>
        /// Checks if ShipmentData property is set.
        /// </summary>
        /// <returns>true if ShipmentData property is set.</returns>
        public bool IsSetShipmentData()
        {
            return this._shipmentData != null;
        }

        /// <summary>
        /// Gets and sets the NextToken property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextToken")]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        /// <summary>
        /// Sets the NextToken property.
        /// </summary>
        /// <param name="nextToken">NextToken property.</param>
        /// <returns>this instance.</returns>
        public ListInboundShipmentsByNextTokenResult WithNextToken(string nextToken)
        {
            this._nextToken = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if NextToken property is set.
        /// </summary>
        /// <returns>true if NextToken property is set.</returns>
        public bool IsSetNextToken()
        {
            return this._nextToken != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _shipmentData = reader.Read<InboundShipmentList>("ShipmentData");
            _nextToken = reader.Read<string>("NextToken");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ShipmentData", _shipmentData);
            writer.Write("NextToken", _nextToken);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "ListInboundShipmentsByNextTokenResult", this);
        }


        public ListInboundShipmentsByNextTokenResult() : base()
        {
        }
    }
}
