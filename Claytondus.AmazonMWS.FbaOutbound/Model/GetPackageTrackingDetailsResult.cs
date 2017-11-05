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
 * Get Package Tracking Details Result
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
    public class GetPackageTrackingDetailsResult : AbstractMwsObject
    {

        private decimal _packageNumber;
        private string _trackingNumber;
        private string _carrierCode;
        private string _carrierPhoneNumber;
        private string _carrierURL;
        private DateTime? _shipDate;
        private DateTime? _estimatedArrivalDate;
        private TrackingAddress _shipToAddress;
        private string _currentStatus;
        private string _signedForBy;
        private string _additionalLocationInfo;
        private TrackingEventList _trackingEvents;

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
        public GetPackageTrackingDetailsResult WithPackageNumber(decimal packageNumber)
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
        public GetPackageTrackingDetailsResult WithTrackingNumber(string trackingNumber)
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
        public GetPackageTrackingDetailsResult WithCarrierCode(string carrierCode)
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
        /// Gets and sets the CarrierPhoneNumber property.
        /// </summary>
        [XmlElement(ElementName = "CarrierPhoneNumber")]
        public string CarrierPhoneNumber
        {
            get { return this._carrierPhoneNumber; }
            set { this._carrierPhoneNumber = value; }
        }

        /// <summary>
        /// Sets the CarrierPhoneNumber property.
        /// </summary>
        /// <param name="carrierPhoneNumber">CarrierPhoneNumber property.</param>
        /// <returns>this instance.</returns>
        public GetPackageTrackingDetailsResult WithCarrierPhoneNumber(string carrierPhoneNumber)
        {
            this._carrierPhoneNumber = carrierPhoneNumber;
            return this;
        }

        /// <summary>
        /// Checks if CarrierPhoneNumber property is set.
        /// </summary>
        /// <returns>true if CarrierPhoneNumber property is set.</returns>
        public bool IsSetCarrierPhoneNumber()
        {
            return this._carrierPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the CarrierURL property.
        /// </summary>
        [XmlElement(ElementName = "CarrierURL")]
        public string CarrierURL
        {
            get { return this._carrierURL; }
            set { this._carrierURL = value; }
        }

        /// <summary>
        /// Sets the CarrierURL property.
        /// </summary>
        /// <param name="carrierURL">CarrierURL property.</param>
        /// <returns>this instance.</returns>
        public GetPackageTrackingDetailsResult WithCarrierURL(string carrierURL)
        {
            this._carrierURL = carrierURL;
            return this;
        }

        /// <summary>
        /// Checks if CarrierURL property is set.
        /// </summary>
        /// <returns>true if CarrierURL property is set.</returns>
        public bool IsSetCarrierURL()
        {
            return this._carrierURL != null;
        }

        /// <summary>
        /// Gets and sets the ShipDate property.
        /// </summary>
        [XmlElement(ElementName = "ShipDate")]
        public DateTime ShipDate
        {
            get { return this._shipDate.GetValueOrDefault(); }
            set { this._shipDate = value; }
        }

        /// <summary>
        /// Sets the ShipDate property.
        /// </summary>
        /// <param name="shipDate">ShipDate property.</param>
        /// <returns>this instance.</returns>
        public GetPackageTrackingDetailsResult WithShipDate(DateTime shipDate)
        {
            this._shipDate = shipDate;
            return this;
        }

        /// <summary>
        /// Checks if ShipDate property is set.
        /// </summary>
        /// <returns>true if ShipDate property is set.</returns>
        public bool IsSetShipDate()
        {
            return this._shipDate != null;
        }

        /// <summary>
        /// Gets and sets the EstimatedArrivalDate property.
        /// </summary>
        [XmlElement(ElementName = "EstimatedArrivalDate")]
        public DateTime EstimatedArrivalDate
        {
            get { return this._estimatedArrivalDate.GetValueOrDefault(); }
            set { this._estimatedArrivalDate = value; }
        }

        /// <summary>
        /// Sets the EstimatedArrivalDate property.
        /// </summary>
        /// <param name="estimatedArrivalDate">EstimatedArrivalDate property.</param>
        /// <returns>this instance.</returns>
        public GetPackageTrackingDetailsResult WithEstimatedArrivalDate(DateTime estimatedArrivalDate)
        {
            this._estimatedArrivalDate = estimatedArrivalDate;
            return this;
        }

        /// <summary>
        /// Checks if EstimatedArrivalDate property is set.
        /// </summary>
        /// <returns>true if EstimatedArrivalDate property is set.</returns>
        public bool IsSetEstimatedArrivalDate()
        {
            return this._estimatedArrivalDate != null;
        }

        /// <summary>
        /// Gets and sets the ShipToAddress property.
        /// </summary>
        [XmlElement(ElementName = "ShipToAddress")]
        public TrackingAddress ShipToAddress
        {
            get { return this._shipToAddress; }
            set { this._shipToAddress = value; }
        }

        /// <summary>
        /// Sets the ShipToAddress property.
        /// </summary>
        /// <param name="shipToAddress">ShipToAddress property.</param>
        /// <returns>this instance.</returns>
        public GetPackageTrackingDetailsResult WithShipToAddress(TrackingAddress shipToAddress)
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
        /// Gets and sets the CurrentStatus property.
        /// </summary>
        [XmlElement(ElementName = "CurrentStatus")]
        public string CurrentStatus
        {
            get { return this._currentStatus; }
            set { this._currentStatus = value; }
        }

        /// <summary>
        /// Sets the CurrentStatus property.
        /// </summary>
        /// <param name="currentStatus">CurrentStatus property.</param>
        /// <returns>this instance.</returns>
        public GetPackageTrackingDetailsResult WithCurrentStatus(string currentStatus)
        {
            this._currentStatus = currentStatus;
            return this;
        }

        /// <summary>
        /// Checks if CurrentStatus property is set.
        /// </summary>
        /// <returns>true if CurrentStatus property is set.</returns>
        public bool IsSetCurrentStatus()
        {
            return this._currentStatus != null;
        }

        /// <summary>
        /// Gets and sets the SignedForBy property.
        /// </summary>
        [XmlElement(ElementName = "SignedForBy")]
        public string SignedForBy
        {
            get { return this._signedForBy; }
            set { this._signedForBy = value; }
        }

        /// <summary>
        /// Sets the SignedForBy property.
        /// </summary>
        /// <param name="signedForBy">SignedForBy property.</param>
        /// <returns>this instance.</returns>
        public GetPackageTrackingDetailsResult WithSignedForBy(string signedForBy)
        {
            this._signedForBy = signedForBy;
            return this;
        }

        /// <summary>
        /// Checks if SignedForBy property is set.
        /// </summary>
        /// <returns>true if SignedForBy property is set.</returns>
        public bool IsSetSignedForBy()
        {
            return this._signedForBy != null;
        }

        /// <summary>
        /// Gets and sets the AdditionalLocationInfo property.
        /// </summary>
        [XmlElement(ElementName = "AdditionalLocationInfo")]
        public string AdditionalLocationInfo
        {
            get { return this._additionalLocationInfo; }
            set { this._additionalLocationInfo = value; }
        }

        /// <summary>
        /// Sets the AdditionalLocationInfo property.
        /// </summary>
        /// <param name="additionalLocationInfo">AdditionalLocationInfo property.</param>
        /// <returns>this instance.</returns>
        public GetPackageTrackingDetailsResult WithAdditionalLocationInfo(string additionalLocationInfo)
        {
            this._additionalLocationInfo = additionalLocationInfo;
            return this;
        }

        /// <summary>
        /// Checks if AdditionalLocationInfo property is set.
        /// </summary>
        /// <returns>true if AdditionalLocationInfo property is set.</returns>
        public bool IsSetAdditionalLocationInfo()
        {
            return this._additionalLocationInfo != null;
        }

        /// <summary>
        /// Gets and sets the TrackingEvents property.
        /// </summary>
        [XmlElement(ElementName = "TrackingEvents")]
        public TrackingEventList TrackingEvents
        {
            get { return this._trackingEvents; }
            set { this._trackingEvents = value; }
        }

        /// <summary>
        /// Sets the TrackingEvents property.
        /// </summary>
        /// <param name="trackingEvents">TrackingEvents property.</param>
        /// <returns>this instance.</returns>
        public GetPackageTrackingDetailsResult WithTrackingEvents(TrackingEventList trackingEvents)
        {
            this._trackingEvents = trackingEvents;
            return this;
        }

        /// <summary>
        /// Checks if TrackingEvents property is set.
        /// </summary>
        /// <returns>true if TrackingEvents property is set.</returns>
        public bool IsSetTrackingEvents()
        {
            return this._trackingEvents != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _packageNumber = reader.Read<decimal>("PackageNumber");
            _trackingNumber = reader.Read<string>("TrackingNumber");
            _carrierCode = reader.Read<string>("CarrierCode");
            _carrierPhoneNumber = reader.Read<string>("CarrierPhoneNumber");
            _carrierURL = reader.Read<string>("CarrierURL");
            _shipDate = reader.Read<DateTime?>("ShipDate");
            _estimatedArrivalDate = reader.Read<DateTime?>("EstimatedArrivalDate");
            _shipToAddress = reader.Read<TrackingAddress>("ShipToAddress");
            _currentStatus = reader.Read<string>("CurrentStatus");
            _signedForBy = reader.Read<string>("SignedForBy");
            _additionalLocationInfo = reader.Read<string>("AdditionalLocationInfo");
            _trackingEvents = reader.Read<TrackingEventList>("TrackingEvents");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("PackageNumber", _packageNumber);
            writer.Write("TrackingNumber", _trackingNumber);
            writer.Write("CarrierCode", _carrierCode);
            writer.Write("CarrierPhoneNumber", _carrierPhoneNumber);
            writer.Write("CarrierURL", _carrierURL);
            writer.Write("ShipDate", _shipDate);
            writer.Write("EstimatedArrivalDate", _estimatedArrivalDate);
            writer.Write("ShipToAddress", _shipToAddress);
            writer.Write("CurrentStatus", _currentStatus);
            writer.Write("SignedForBy", _signedForBy);
            writer.Write("AdditionalLocationInfo", _additionalLocationInfo);
            writer.Write("TrackingEvents", _trackingEvents);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "GetPackageTrackingDetailsResult", this);
        }

    public GetPackageTrackingDetailsResult (decimal packageNumber) : base() {
        this._packageNumber = packageNumber;
    }

        public GetPackageTrackingDetailsResult() : base()
        {
        }
    }
}
