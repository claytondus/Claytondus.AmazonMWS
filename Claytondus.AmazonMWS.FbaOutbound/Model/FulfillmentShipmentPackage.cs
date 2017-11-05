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
 * Fulfillment Shipment Package
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
    public class FulfillmentShipmentPackage : AbstractMwsObject
    {

        private decimal _packageNumber;
        private string _carrierCode;
        private string _trackingNumber;
        private DateTime? _estimatedArrivalDateTime;

        /// <summary>
        /// Gets and sets the PackageNumber property.
        /// </summary>
        [XmlElement(ElementName = "PackageNumber")]
        public decimal PackageNumber
        {
            get { return this._packageNumber; }
            set { this._packageNumber = value; }
        }

        /// <summary>
        /// Sets the PackageNumber property.
        /// </summary>
        /// <param name="packageNumber">PackageNumber property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentShipmentPackage WithPackageNumber(decimal packageNumber)
        {
            this._packageNumber = packageNumber;
            return this;
        }

        /// <summary>
        /// Checks if PackageNumber property is set.
        /// </summary>
        /// <returns>true if PackageNumber property is set.</returns>
        public bool IsSetPackageNumber()
        {
            return this._packageNumber != null;
        }

        /// <summary>
        /// Gets and sets the CarrierCode property.
        /// </summary>
        [XmlElement(ElementName = "CarrierCode")]
        public string CarrierCode
        {
            get { return this._carrierCode; }
            set { this._carrierCode = value; }
        }

        /// <summary>
        /// Sets the CarrierCode property.
        /// </summary>
        /// <param name="carrierCode">CarrierCode property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentShipmentPackage WithCarrierCode(string carrierCode)
        {
            this._carrierCode = carrierCode;
            return this;
        }

        /// <summary>
        /// Checks if CarrierCode property is set.
        /// </summary>
        /// <returns>true if CarrierCode property is set.</returns>
        public bool IsSetCarrierCode()
        {
            return this._carrierCode != null;
        }

        /// <summary>
        /// Gets and sets the TrackingNumber property.
        /// </summary>
        [XmlElement(ElementName = "TrackingNumber")]
        public string TrackingNumber
        {
            get { return this._trackingNumber; }
            set { this._trackingNumber = value; }
        }

        /// <summary>
        /// Sets the TrackingNumber property.
        /// </summary>
        /// <param name="trackingNumber">TrackingNumber property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentShipmentPackage WithTrackingNumber(string trackingNumber)
        {
            this._trackingNumber = trackingNumber;
            return this;
        }

        /// <summary>
        /// Checks if TrackingNumber property is set.
        /// </summary>
        /// <returns>true if TrackingNumber property is set.</returns>
        public bool IsSetTrackingNumber()
        {
            return this._trackingNumber != null;
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
        public FulfillmentShipmentPackage WithEstimatedArrivalDateTime(DateTime estimatedArrivalDateTime)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _packageNumber = reader.Read<decimal>("PackageNumber");
            _carrierCode = reader.Read<string>("CarrierCode");
            _trackingNumber = reader.Read<string>("TrackingNumber");
            _estimatedArrivalDateTime = reader.Read<DateTime?>("EstimatedArrivalDateTime");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("PackageNumber", _packageNumber);
            writer.Write("CarrierCode", _carrierCode);
            writer.Write("TrackingNumber", _trackingNumber);
            writer.Write("EstimatedArrivalDateTime", _estimatedArrivalDateTime);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "FulfillmentShipmentPackage", this);
        }

    public FulfillmentShipmentPackage (decimal packageNumber,string carrierCode) : base() {
        this._packageNumber = packageNumber;
        this._carrierCode = carrierCode;
    }

        public FulfillmentShipmentPackage() : base()
        {
        }
    }
}
