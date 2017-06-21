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
 * Update Inbound Shipment Request
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
    public class UpdateInboundShipmentRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private string _marketplace;
        private string _shipmentId;
        private InboundShipmentHeader _inboundShipmentHeader;
        private InboundShipmentItemList _inboundShipmentItems;

        /// <summary>
        /// Gets and sets the SellerId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerId")]
        public string SellerId
        {
            get { return this._sellerId; }
            set { this._sellerId = value; }
        }

        /// <summary>
        /// Sets the SellerId property.
        /// </summary>
        /// <param name="sellerId">SellerId property.</param>
        /// <returns>this instance.</returns>
        public UpdateInboundShipmentRequest WithSellerId(string sellerId)
        {
            this._sellerId = sellerId;
            return this;
        }

        /// <summary>
        /// Checks if SellerId property is set.
        /// </summary>
        /// <returns>true if SellerId property is set.</returns>
        public bool IsSetSellerId()
        {
            return this._sellerId != null;
        }

        /// <summary>
        /// Gets and sets the MWSAuthToken property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MWSAuthToken")]
        public string MWSAuthToken
        {
            get { return this._mwsAuthToken; }
            set { this._mwsAuthToken = value; }
        }

        /// <summary>
        /// Sets the MWSAuthToken property.
        /// </summary>
        /// <param name="mwsAuthToken">MWSAuthToken property.</param>
        /// <returns>this instance.</returns>
        public UpdateInboundShipmentRequest WithMWSAuthToken(string mwsAuthToken)
        {
            this._mwsAuthToken = mwsAuthToken;
            return this;
        }

        /// <summary>
        /// Checks if MWSAuthToken property is set.
        /// </summary>
        /// <returns>true if MWSAuthToken property is set.</returns>
        public bool IsSetMWSAuthToken()
        {
            return this._mwsAuthToken != null;
        }

        /// <summary>
        /// Gets and sets the Marketplace property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Marketplace")]
        public string Marketplace
        {
            get { return this._marketplace; }
            set { this._marketplace = value; }
        }

        /// <summary>
        /// Sets the Marketplace property.
        /// </summary>
        /// <param name="marketplace">Marketplace property.</param>
        /// <returns>this instance.</returns>
        public UpdateInboundShipmentRequest WithMarketplace(string marketplace)
        {
            this._marketplace = marketplace;
            return this;
        }

        /// <summary>
        /// Checks if Marketplace property is set.
        /// </summary>
        /// <returns>true if Marketplace property is set.</returns>
        public bool IsSetMarketplace()
        {
            return this._marketplace != null;
        }

        /// <summary>
        /// Gets and sets the ShipmentId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipmentId")]
        public string ShipmentId
        {
            get { return this._shipmentId; }
            set { this._shipmentId = value; }
        }

        /// <summary>
        /// Sets the ShipmentId property.
        /// </summary>
        /// <param name="shipmentId">ShipmentId property.</param>
        /// <returns>this instance.</returns>
        public UpdateInboundShipmentRequest WithShipmentId(string shipmentId)
        {
            this._shipmentId = shipmentId;
            return this;
        }

        /// <summary>
        /// Checks if ShipmentId property is set.
        /// </summary>
        /// <returns>true if ShipmentId property is set.</returns>
        public bool IsSetShipmentId()
        {
            return this._shipmentId != null;
        }

        /// <summary>
        /// Gets and sets the InboundShipmentHeader property.
        /// </summary>
        [XmlElementAttribute(ElementName = "InboundShipmentHeader")]
        public InboundShipmentHeader InboundShipmentHeader
        {
            get { return this._inboundShipmentHeader; }
            set { this._inboundShipmentHeader = value; }
        }

        /// <summary>
        /// Sets the InboundShipmentHeader property.
        /// </summary>
        /// <param name="inboundShipmentHeader">InboundShipmentHeader property.</param>
        /// <returns>this instance.</returns>
        public UpdateInboundShipmentRequest WithInboundShipmentHeader(InboundShipmentHeader inboundShipmentHeader)
        {
            this._inboundShipmentHeader = inboundShipmentHeader;
            return this;
        }

        /// <summary>
        /// Checks if InboundShipmentHeader property is set.
        /// </summary>
        /// <returns>true if InboundShipmentHeader property is set.</returns>
        public bool IsSetInboundShipmentHeader()
        {
            return this._inboundShipmentHeader != null;
        }

        /// <summary>
        /// Gets and sets the InboundShipmentItems property.
        /// </summary>
        [XmlElementAttribute(ElementName = "InboundShipmentItems")]
        public InboundShipmentItemList InboundShipmentItems
        {
            get { return this._inboundShipmentItems; }
            set { this._inboundShipmentItems = value; }
        }

        /// <summary>
        /// Sets the InboundShipmentItems property.
        /// </summary>
        /// <param name="inboundShipmentItems">InboundShipmentItems property.</param>
        /// <returns>this instance.</returns>
        public UpdateInboundShipmentRequest WithInboundShipmentItems(InboundShipmentItemList inboundShipmentItems)
        {
            this._inboundShipmentItems = inboundShipmentItems;
            return this;
        }

        /// <summary>
        /// Checks if InboundShipmentItems property is set.
        /// </summary>
        /// <returns>true if InboundShipmentItems property is set.</returns>
        public bool IsSetInboundShipmentItems()
        {
            return this._inboundShipmentItems != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _marketplace = reader.Read<string>("Marketplace");
            _shipmentId = reader.Read<string>("ShipmentId");
            _inboundShipmentHeader = reader.Read<InboundShipmentHeader>("InboundShipmentHeader");
            _inboundShipmentItems = reader.Read<InboundShipmentItemList>("InboundShipmentItems");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("Marketplace", _marketplace);
            writer.Write("ShipmentId", _shipmentId);
            writer.Write("InboundShipmentHeader", _inboundShipmentHeader);
            writer.Write("InboundShipmentItems", _inboundShipmentItems);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "UpdateInboundShipmentRequest", this);
        }

    public UpdateInboundShipmentRequest (string sellerId,string shipmentId) : base() {
        this._sellerId = sellerId;
        this._shipmentId = shipmentId;
    }

        public UpdateInboundShipmentRequest() : base()
        {
        }
    }
}
