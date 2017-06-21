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
 * Inbound Shipment Plan
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
    public class InboundShipmentPlan : AbstractMwsObject
    {

        private string _shipmentId;
        private string _destinationFulfillmentCenterId;
        private Address _shipToAddress;
        private string _labelPrepType;
        private InboundShipmentPlanItemList _items;
        private BoxContentsFeeDetails _estimatedBoxContentsFee;

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
        public InboundShipmentPlan WithShipmentId(string shipmentId)
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
        /// Gets and sets the DestinationFulfillmentCenterId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationFulfillmentCenterId")]
        public string DestinationFulfillmentCenterId
        {
            get { return this._destinationFulfillmentCenterId; }
            set { this._destinationFulfillmentCenterId = value; }
        }

        /// <summary>
        /// Sets the DestinationFulfillmentCenterId property.
        /// </summary>
        /// <param name="destinationFulfillmentCenterId">DestinationFulfillmentCenterId property.</param>
        /// <returns>this instance.</returns>
        public InboundShipmentPlan WithDestinationFulfillmentCenterId(string destinationFulfillmentCenterId)
        {
            this._destinationFulfillmentCenterId = destinationFulfillmentCenterId;
            return this;
        }

        /// <summary>
        /// Checks if DestinationFulfillmentCenterId property is set.
        /// </summary>
        /// <returns>true if DestinationFulfillmentCenterId property is set.</returns>
        public bool IsSetDestinationFulfillmentCenterId()
        {
            return this._destinationFulfillmentCenterId != null;
        }

        /// <summary>
        /// Gets and sets the ShipToAddress property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipToAddress")]
        public Address ShipToAddress
        {
            get { return this._shipToAddress; }
            set { this._shipToAddress = value; }
        }

        /// <summary>
        /// Sets the ShipToAddress property.
        /// </summary>
        /// <param name="shipToAddress">ShipToAddress property.</param>
        /// <returns>this instance.</returns>
        public InboundShipmentPlan WithShipToAddress(Address shipToAddress)
        {
            this._shipToAddress = shipToAddress;
            return this;
        }

        /// <summary>
        /// Checks if ShipToAddress property is set.
        /// </summary>
        /// <returns>true if ShipToAddress property is set.</returns>
        public bool IsSetShipToAddress()
        {
            return this._shipToAddress != null;
        }

        /// <summary>
        /// Gets and sets the LabelPrepType property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LabelPrepType")]
        public string LabelPrepType
        {
            get { return this._labelPrepType; }
            set { this._labelPrepType = value; }
        }

        /// <summary>
        /// Sets the LabelPrepType property.
        /// </summary>
        /// <param name="labelPrepType">LabelPrepType property.</param>
        /// <returns>this instance.</returns>
        public InboundShipmentPlan WithLabelPrepType(string labelPrepType)
        {
            this._labelPrepType = labelPrepType;
            return this;
        }

        /// <summary>
        /// Checks if LabelPrepType property is set.
        /// </summary>
        /// <returns>true if LabelPrepType property is set.</returns>
        public bool IsSetLabelPrepType()
        {
            return this._labelPrepType != null;
        }

        /// <summary>
        /// Gets and sets the Items property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Items")]
        public InboundShipmentPlanItemList Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        /// <summary>
        /// Sets the Items property.
        /// </summary>
        /// <param name="items">Items property.</param>
        /// <returns>this instance.</returns>
        public InboundShipmentPlan WithItems(InboundShipmentPlanItemList items)
        {
            this._items = items;
            return this;
        }

        /// <summary>
        /// Checks if Items property is set.
        /// </summary>
        /// <returns>true if Items property is set.</returns>
        public bool IsSetItems()
        {
            return this._items != null;
        }

        /// <summary>
        /// Gets and sets the EstimatedBoxContentsFee property.
        /// </summary>
        [XmlElementAttribute(ElementName = "EstimatedBoxContentsFee")]
        public BoxContentsFeeDetails EstimatedBoxContentsFee
        {
            get { return this._estimatedBoxContentsFee; }
            set { this._estimatedBoxContentsFee = value; }
        }

        /// <summary>
        /// Sets the EstimatedBoxContentsFee property.
        /// </summary>
        /// <param name="estimatedBoxContentsFee">EstimatedBoxContentsFee property.</param>
        /// <returns>this instance.</returns>
        public InboundShipmentPlan WithEstimatedBoxContentsFee(BoxContentsFeeDetails estimatedBoxContentsFee)
        {
            this._estimatedBoxContentsFee = estimatedBoxContentsFee;
            return this;
        }

        /// <summary>
        /// Checks if EstimatedBoxContentsFee property is set.
        /// </summary>
        /// <returns>true if EstimatedBoxContentsFee property is set.</returns>
        public bool IsSetEstimatedBoxContentsFee()
        {
            return this._estimatedBoxContentsFee != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _shipmentId = reader.Read<string>("ShipmentId");
            _destinationFulfillmentCenterId = reader.Read<string>("DestinationFulfillmentCenterId");
            _shipToAddress = reader.Read<Address>("ShipToAddress");
            _labelPrepType = reader.Read<string>("LabelPrepType");
            _items = reader.Read<InboundShipmentPlanItemList>("Items");
            _estimatedBoxContentsFee = reader.Read<BoxContentsFeeDetails>("EstimatedBoxContentsFee");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ShipmentId", _shipmentId);
            writer.Write("DestinationFulfillmentCenterId", _destinationFulfillmentCenterId);
            writer.Write("ShipToAddress", _shipToAddress);
            writer.Write("LabelPrepType", _labelPrepType);
            writer.Write("Items", _items);
            writer.Write("EstimatedBoxContentsFee", _estimatedBoxContentsFee);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "InboundShipmentPlan", this);
        }


        public InboundShipmentPlan() : base()
        {
        }
    }
}
