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
 * Inbound Shipment Header
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
    public class InboundShipmentHeader : AbstractMwsObject
    {

        private string _shipmentName;
        private Address _shipFromAddress;
        private string _destinationFulfillmentCenterId;
        private bool? _areCasesRequired;
        private string _shipmentStatus;
        private string _labelPrepPreference;
        private string _intendedBoxContentsSource;

        /// <summary>
        /// Gets and sets the ShipmentName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipmentName")]
        public string ShipmentName
        {
            get { return this._shipmentName; }
            set { this._shipmentName = value; }
        }

        /// <summary>
        /// Sets the ShipmentName property.
        /// </summary>
        /// <param name="shipmentName">ShipmentName property.</param>
        /// <returns>this instance.</returns>
        public InboundShipmentHeader WithShipmentName(string shipmentName)
        {
            this._shipmentName = shipmentName;
            return this;
        }

        /// <summary>
        /// Checks if ShipmentName property is set.
        /// </summary>
        /// <returns>true if ShipmentName property is set.</returns>
        public bool IsSetShipmentName()
        {
            return this._shipmentName != null;
        }

        /// <summary>
        /// Gets and sets the ShipFromAddress property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipFromAddress")]
        public Address ShipFromAddress
        {
            get { return this._shipFromAddress; }
            set { this._shipFromAddress = value; }
        }

        /// <summary>
        /// Sets the ShipFromAddress property.
        /// </summary>
        /// <param name="shipFromAddress">ShipFromAddress property.</param>
        /// <returns>this instance.</returns>
        public InboundShipmentHeader WithShipFromAddress(Address shipFromAddress)
        {
            this._shipFromAddress = shipFromAddress;
            return this;
        }

        /// <summary>
        /// Checks if ShipFromAddress property is set.
        /// </summary>
        /// <returns>true if ShipFromAddress property is set.</returns>
        public bool IsSetShipFromAddress()
        {
            return this._shipFromAddress != null;
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
        public InboundShipmentHeader WithDestinationFulfillmentCenterId(string destinationFulfillmentCenterId)
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
        /// Gets and sets the AreCasesRequired property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AreCasesRequired")]
        public bool AreCasesRequired
        {
            get { return this._areCasesRequired.GetValueOrDefault(); }
            set { this._areCasesRequired = value; }
        }

        /// <summary>
        /// Sets the AreCasesRequired property.
        /// </summary>
        /// <param name="areCasesRequired">AreCasesRequired property.</param>
        /// <returns>this instance.</returns>
        public InboundShipmentHeader WithAreCasesRequired(bool areCasesRequired)
        {
            this._areCasesRequired = areCasesRequired;
            return this;
        }

        /// <summary>
        /// Checks if AreCasesRequired property is set.
        /// </summary>
        /// <returns>true if AreCasesRequired property is set.</returns>
        public bool IsSetAreCasesRequired()
        {
            return this._areCasesRequired != null;
        }

        /// <summary>
        /// Gets and sets the ShipmentStatus property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipmentStatus")]
        public string ShipmentStatus
        {
            get { return this._shipmentStatus; }
            set { this._shipmentStatus = value; }
        }

        /// <summary>
        /// Sets the ShipmentStatus property.
        /// </summary>
        /// <param name="shipmentStatus">ShipmentStatus property.</param>
        /// <returns>this instance.</returns>
        public InboundShipmentHeader WithShipmentStatus(string shipmentStatus)
        {
            this._shipmentStatus = shipmentStatus;
            return this;
        }

        /// <summary>
        /// Checks if ShipmentStatus property is set.
        /// </summary>
        /// <returns>true if ShipmentStatus property is set.</returns>
        public bool IsSetShipmentStatus()
        {
            return this._shipmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the LabelPrepPreference property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LabelPrepPreference")]
        public string LabelPrepPreference
        {
            get { return this._labelPrepPreference; }
            set { this._labelPrepPreference = value; }
        }

        /// <summary>
        /// Sets the LabelPrepPreference property.
        /// </summary>
        /// <param name="labelPrepPreference">LabelPrepPreference property.</param>
        /// <returns>this instance.</returns>
        public InboundShipmentHeader WithLabelPrepPreference(string labelPrepPreference)
        {
            this._labelPrepPreference = labelPrepPreference;
            return this;
        }

        /// <summary>
        /// Checks if LabelPrepPreference property is set.
        /// </summary>
        /// <returns>true if LabelPrepPreference property is set.</returns>
        public bool IsSetLabelPrepPreference()
        {
            return this._labelPrepPreference != null;
        }

        /// <summary>
        /// Gets and sets the IntendedBoxContentsSource property.
        /// </summary>
        [XmlElementAttribute(ElementName = "IntendedBoxContentsSource")]
        public string IntendedBoxContentsSource
        {
            get { return this._intendedBoxContentsSource; }
            set { this._intendedBoxContentsSource = value; }
        }

        /// <summary>
        /// Sets the IntendedBoxContentsSource property.
        /// </summary>
        /// <param name="intendedBoxContentsSource">IntendedBoxContentsSource property.</param>
        /// <returns>this instance.</returns>
        public InboundShipmentHeader WithIntendedBoxContentsSource(string intendedBoxContentsSource)
        {
            this._intendedBoxContentsSource = intendedBoxContentsSource;
            return this;
        }

        /// <summary>
        /// Checks if IntendedBoxContentsSource property is set.
        /// </summary>
        /// <returns>true if IntendedBoxContentsSource property is set.</returns>
        public bool IsSetIntendedBoxContentsSource()
        {
            return this._intendedBoxContentsSource != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _shipmentName = reader.Read<string>("ShipmentName");
            _shipFromAddress = reader.Read<Address>("ShipFromAddress");
            _destinationFulfillmentCenterId = reader.Read<string>("DestinationFulfillmentCenterId");
            _areCasesRequired = reader.Read<bool?>("AreCasesRequired");
            _shipmentStatus = reader.Read<string>("ShipmentStatus");
            _labelPrepPreference = reader.Read<string>("LabelPrepPreference");
            _intendedBoxContentsSource = reader.Read<string>("IntendedBoxContentsSource");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ShipmentName", _shipmentName);
            writer.Write("ShipFromAddress", _shipFromAddress);
            writer.Write("DestinationFulfillmentCenterId", _destinationFulfillmentCenterId);
            writer.Write("AreCasesRequired", _areCasesRequired);
            writer.Write("ShipmentStatus", _shipmentStatus);
            writer.Write("LabelPrepPreference", _labelPrepPreference);
            writer.Write("IntendedBoxContentsSource", _intendedBoxContentsSource);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "InboundShipmentHeader", this);
        }


        public InboundShipmentHeader() : base()
        {
        }
    }
}
