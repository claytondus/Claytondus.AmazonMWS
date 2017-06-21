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
 * List Inbound Shipments Request
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
    public class ListInboundShipmentsRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private string _marketplace;
        private ShipmentStatusList _shipmentStatusList;
        private ShipmentIdList _shipmentIdList;
        private DateTime? _lastUpdatedBefore;
        private DateTime? _lastUpdatedAfter;

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
        public ListInboundShipmentsRequest WithSellerId(string sellerId)
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
        public ListInboundShipmentsRequest WithMWSAuthToken(string mwsAuthToken)
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
        public ListInboundShipmentsRequest WithMarketplace(string marketplace)
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
        /// Gets and sets the ShipmentStatusList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipmentStatusList")]
        public ShipmentStatusList ShipmentStatusList
        {
            get { return this._shipmentStatusList; }
            set { this._shipmentStatusList = value; }
        }

        /// <summary>
        /// Sets the ShipmentStatusList property.
        /// </summary>
        /// <param name="shipmentStatusList">ShipmentStatusList property.</param>
        /// <returns>this instance.</returns>
        public ListInboundShipmentsRequest WithShipmentStatusList(ShipmentStatusList shipmentStatusList)
        {
            this._shipmentStatusList = shipmentStatusList;
            return this;
        }

        /// <summary>
        /// Checks if ShipmentStatusList property is set.
        /// </summary>
        /// <returns>true if ShipmentStatusList property is set.</returns>
        public bool IsSetShipmentStatusList()
        {
            return this._shipmentStatusList != null;
        }

        /// <summary>
        /// Gets and sets the ShipmentIdList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipmentIdList")]
        public ShipmentIdList ShipmentIdList
        {
            get { return this._shipmentIdList; }
            set { this._shipmentIdList = value; }
        }

        /// <summary>
        /// Sets the ShipmentIdList property.
        /// </summary>
        /// <param name="shipmentIdList">ShipmentIdList property.</param>
        /// <returns>this instance.</returns>
        public ListInboundShipmentsRequest WithShipmentIdList(ShipmentIdList shipmentIdList)
        {
            this._shipmentIdList = shipmentIdList;
            return this;
        }

        /// <summary>
        /// Checks if ShipmentIdList property is set.
        /// </summary>
        /// <returns>true if ShipmentIdList property is set.</returns>
        public bool IsSetShipmentIdList()
        {
            return this._shipmentIdList != null;
        }

        /// <summary>
        /// Gets and sets the LastUpdatedBefore property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LastUpdatedBefore")]
        public DateTime LastUpdatedBefore
        {
            get { return this._lastUpdatedBefore.GetValueOrDefault(); }
            set { this._lastUpdatedBefore = value; }
        }

        /// <summary>
        /// Sets the LastUpdatedBefore property.
        /// </summary>
        /// <param name="lastUpdatedBefore">LastUpdatedBefore property.</param>
        /// <returns>this instance.</returns>
        public ListInboundShipmentsRequest WithLastUpdatedBefore(DateTime lastUpdatedBefore)
        {
            this._lastUpdatedBefore = lastUpdatedBefore;
            return this;
        }

        /// <summary>
        /// Checks if LastUpdatedBefore property is set.
        /// </summary>
        /// <returns>true if LastUpdatedBefore property is set.</returns>
        public bool IsSetLastUpdatedBefore()
        {
            return this._lastUpdatedBefore != null;
        }

        /// <summary>
        /// Gets and sets the LastUpdatedAfter property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LastUpdatedAfter")]
        public DateTime LastUpdatedAfter
        {
            get { return this._lastUpdatedAfter.GetValueOrDefault(); }
            set { this._lastUpdatedAfter = value; }
        }

        /// <summary>
        /// Sets the LastUpdatedAfter property.
        /// </summary>
        /// <param name="lastUpdatedAfter">LastUpdatedAfter property.</param>
        /// <returns>this instance.</returns>
        public ListInboundShipmentsRequest WithLastUpdatedAfter(DateTime lastUpdatedAfter)
        {
            this._lastUpdatedAfter = lastUpdatedAfter;
            return this;
        }

        /// <summary>
        /// Checks if LastUpdatedAfter property is set.
        /// </summary>
        /// <returns>true if LastUpdatedAfter property is set.</returns>
        public bool IsSetLastUpdatedAfter()
        {
            return this._lastUpdatedAfter != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _marketplace = reader.Read<string>("Marketplace");
            _shipmentStatusList = reader.Read<ShipmentStatusList>("ShipmentStatusList");
            _shipmentIdList = reader.Read<ShipmentIdList>("ShipmentIdList");
            _lastUpdatedBefore = reader.Read<DateTime?>("LastUpdatedBefore");
            _lastUpdatedAfter = reader.Read<DateTime?>("LastUpdatedAfter");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("Marketplace", _marketplace);
            writer.Write("ShipmentStatusList", _shipmentStatusList);
            writer.Write("ShipmentIdList", _shipmentIdList);
            writer.Write("LastUpdatedBefore", _lastUpdatedBefore);
            writer.Write("LastUpdatedAfter", _lastUpdatedAfter);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "ListInboundShipmentsRequest", this);
        }

    public ListInboundShipmentsRequest (string sellerId) : base() {
        this._sellerId = sellerId;
    }

        public ListInboundShipmentsRequest() : base()
        {
        }
    }
}
