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
 * Fulfillment Shipment
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
    public class FulfillmentShipment : AbstractMwsObject
    {

        private string _amazonShipmentId;
        private string _fulfillmentCenterId;
        private string _fulfillmentShipmentStatus;
        private DateTime? _shippingDateTime;
        private DateTime? _estimatedArrivalDateTime;
        private FulfillmentShipmentItemList _fulfillmentShipmentItem;
        private FulfillmentShipmentPackageList _fulfillmentShipmentPackage;

        /// <summary>
        /// Gets and sets the AmazonShipmentId property.
        /// </summary>
        [XmlElement(ElementName = "AmazonShipmentId")]
        public string AmazonShipmentId
        {
            get { return this._amazonShipmentId; }
            set { this._amazonShipmentId = value; }
        }

        /// <summary>
        /// Sets the AmazonShipmentId property.
        /// </summary>
        /// <param name="amazonShipmentId">AmazonShipmentId property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentShipment WithAmazonShipmentId(string amazonShipmentId)
        {
            this._amazonShipmentId = amazonShipmentId;
            return this;
        }

        /// <summary>
        /// Checks if AmazonShipmentId property is set.
        /// </summary>
        /// <returns>true if AmazonShipmentId property is set.</returns>
        public bool IsSetAmazonShipmentId()
        {
            return this._amazonShipmentId != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentCenterId property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentCenterId")]
        public string FulfillmentCenterId
        {
            get { return this._fulfillmentCenterId; }
            set { this._fulfillmentCenterId = value; }
        }

        /// <summary>
        /// Sets the FulfillmentCenterId property.
        /// </summary>
        /// <param name="fulfillmentCenterId">FulfillmentCenterId property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentShipment WithFulfillmentCenterId(string fulfillmentCenterId)
        {
            this._fulfillmentCenterId = fulfillmentCenterId;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentCenterId property is set.
        /// </summary>
        /// <returns>true if FulfillmentCenterId property is set.</returns>
        public bool IsSetFulfillmentCenterId()
        {
            return this._fulfillmentCenterId != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentShipmentStatus property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentShipmentStatus")]
        public string FulfillmentShipmentStatus
        {
            get { return this._fulfillmentShipmentStatus; }
            set { this._fulfillmentShipmentStatus = value; }
        }

        /// <summary>
        /// Sets the FulfillmentShipmentStatus property.
        /// </summary>
        /// <param name="fulfillmentShipmentStatus">FulfillmentShipmentStatus property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentShipment WithFulfillmentShipmentStatus(string fulfillmentShipmentStatus)
        {
            this._fulfillmentShipmentStatus = fulfillmentShipmentStatus;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentShipmentStatus property is set.
        /// </summary>
        /// <returns>true if FulfillmentShipmentStatus property is set.</returns>
        public bool IsSetFulfillmentShipmentStatus()
        {
            return this._fulfillmentShipmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the ShippingDateTime property.
        /// </summary>
        [XmlElement(ElementName = "ShippingDateTime")]
        public DateTime ShippingDateTime
        {
            get { return this._shippingDateTime.GetValueOrDefault(); }
            set { this._shippingDateTime = value; }
        }

        /// <summary>
        /// Sets the ShippingDateTime property.
        /// </summary>
        /// <param name="shippingDateTime">ShippingDateTime property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentShipment WithShippingDateTime(DateTime shippingDateTime)
        {
            this._shippingDateTime = shippingDateTime;
            return this;
        }

        /// <summary>
        /// Checks if ShippingDateTime property is set.
        /// </summary>
        /// <returns>true if ShippingDateTime property is set.</returns>
        public bool IsSetShippingDateTime()
        {
            return this._shippingDateTime != null;
        }

        /// <summary>
        /// Gets and sets the EstimatedArrivalDateTime property.
        /// </summary>
        [XmlElement(ElementName = "EstimatedArrivalDateTime")]
        public DateTime EstimatedArrivalDateTime
        {
            get { return this._estimatedArrivalDateTime.GetValueOrDefault(); }
            set { this._estimatedArrivalDateTime = value; }
        }

        /// <summary>
        /// Sets the EstimatedArrivalDateTime property.
        /// </summary>
        /// <param name="estimatedArrivalDateTime">EstimatedArrivalDateTime property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentShipment WithEstimatedArrivalDateTime(DateTime estimatedArrivalDateTime)
        {
            this._estimatedArrivalDateTime = estimatedArrivalDateTime;
            return this;
        }

        /// <summary>
        /// Checks if EstimatedArrivalDateTime property is set.
        /// </summary>
        /// <returns>true if EstimatedArrivalDateTime property is set.</returns>
        public bool IsSetEstimatedArrivalDateTime()
        {
            return this._estimatedArrivalDateTime != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentShipmentItem property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentShipmentItem")]
        public FulfillmentShipmentItemList FulfillmentShipmentItem
        {
            get { return this._fulfillmentShipmentItem; }
            set { this._fulfillmentShipmentItem = value; }
        }

        /// <summary>
        /// Sets the FulfillmentShipmentItem property.
        /// </summary>
        /// <param name="fulfillmentShipmentItem">FulfillmentShipmentItem property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentShipment WithFulfillmentShipmentItem(FulfillmentShipmentItemList fulfillmentShipmentItem)
        {
            this._fulfillmentShipmentItem = fulfillmentShipmentItem;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentShipmentItem property is set.
        /// </summary>
        /// <returns>true if FulfillmentShipmentItem property is set.</returns>
        public bool IsSetFulfillmentShipmentItem()
        {
            return this._fulfillmentShipmentItem != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentShipmentPackage property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentShipmentPackage")]
        public FulfillmentShipmentPackageList FulfillmentShipmentPackage
        {
            get { return this._fulfillmentShipmentPackage; }
            set { this._fulfillmentShipmentPackage = value; }
        }

        /// <summary>
        /// Sets the FulfillmentShipmentPackage property.
        /// </summary>
        /// <param name="fulfillmentShipmentPackage">FulfillmentShipmentPackage property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentShipment WithFulfillmentShipmentPackage(FulfillmentShipmentPackageList fulfillmentShipmentPackage)
        {
            this._fulfillmentShipmentPackage = fulfillmentShipmentPackage;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentShipmentPackage property is set.
        /// </summary>
        /// <returns>true if FulfillmentShipmentPackage property is set.</returns>
        public bool IsSetFulfillmentShipmentPackage()
        {
            return this._fulfillmentShipmentPackage != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _amazonShipmentId = reader.Read<string>("AmazonShipmentId");
            _fulfillmentCenterId = reader.Read<string>("FulfillmentCenterId");
            _fulfillmentShipmentStatus = reader.Read<string>("FulfillmentShipmentStatus");
            _shippingDateTime = reader.Read<DateTime?>("ShippingDateTime");
            _estimatedArrivalDateTime = reader.Read<DateTime?>("EstimatedArrivalDateTime");
            _fulfillmentShipmentItem = reader.Read<FulfillmentShipmentItemList>("FulfillmentShipmentItem");
            _fulfillmentShipmentPackage = reader.Read<FulfillmentShipmentPackageList>("FulfillmentShipmentPackage");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("AmazonShipmentId", _amazonShipmentId);
            writer.Write("FulfillmentCenterId", _fulfillmentCenterId);
            writer.Write("FulfillmentShipmentStatus", _fulfillmentShipmentStatus);
            writer.Write("ShippingDateTime", _shippingDateTime);
            writer.Write("EstimatedArrivalDateTime", _estimatedArrivalDateTime);
            writer.Write("FulfillmentShipmentItem", _fulfillmentShipmentItem);
            writer.Write("FulfillmentShipmentPackage", _fulfillmentShipmentPackage);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "FulfillmentShipment", this);
        }

    public FulfillmentShipment (string amazonShipmentId,string fulfillmentCenterId,string fulfillmentShipmentStatus,FulfillmentShipmentItemList fulfillmentShipmentItem) : base() {
        this._amazonShipmentId = amazonShipmentId;
        this._fulfillmentCenterId = fulfillmentCenterId;
        this._fulfillmentShipmentStatus = fulfillmentShipmentStatus;
        this._fulfillmentShipmentItem = fulfillmentShipmentItem;
    }

        public FulfillmentShipment() : base()
        {
        }
    }
}
