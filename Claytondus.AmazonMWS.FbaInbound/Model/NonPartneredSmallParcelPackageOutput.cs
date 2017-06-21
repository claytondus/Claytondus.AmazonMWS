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
 * Non Partnered Small Parcel Package Output
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
    public class NonPartneredSmallParcelPackageOutput : AbstractMwsObject
    {

        private string _carrierName;
        private string _trackingId;
        private string _packageStatus;

        /// <summary>
        /// Gets and sets the CarrierName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CarrierName")]
        public string CarrierName
        {
            get { return this._carrierName; }
            set { this._carrierName = value; }
        }

        /// <summary>
        /// Sets the CarrierName property.
        /// </summary>
        /// <param name="carrierName">CarrierName property.</param>
        /// <returns>this instance.</returns>
        public NonPartneredSmallParcelPackageOutput WithCarrierName(string carrierName)
        {
            this._carrierName = carrierName;
            return this;
        }

        /// <summary>
        /// Checks if CarrierName property is set.
        /// </summary>
        /// <returns>true if CarrierName property is set.</returns>
        public bool IsSetCarrierName()
        {
            return this._carrierName != null;
        }

        /// <summary>
        /// Gets and sets the TrackingId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TrackingId")]
        public string TrackingId
        {
            get { return this._trackingId; }
            set { this._trackingId = value; }
        }

        /// <summary>
        /// Sets the TrackingId property.
        /// </summary>
        /// <param name="trackingId">TrackingId property.</param>
        /// <returns>this instance.</returns>
        public NonPartneredSmallParcelPackageOutput WithTrackingId(string trackingId)
        {
            this._trackingId = trackingId;
            return this;
        }

        /// <summary>
        /// Checks if TrackingId property is set.
        /// </summary>
        /// <returns>true if TrackingId property is set.</returns>
        public bool IsSetTrackingId()
        {
            return this._trackingId != null;
        }

        /// <summary>
        /// Gets and sets the PackageStatus property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PackageStatus")]
        public string PackageStatus
        {
            get { return this._packageStatus; }
            set { this._packageStatus = value; }
        }

        /// <summary>
        /// Sets the PackageStatus property.
        /// </summary>
        /// <param name="packageStatus">PackageStatus property.</param>
        /// <returns>this instance.</returns>
        public NonPartneredSmallParcelPackageOutput WithPackageStatus(string packageStatus)
        {
            this._packageStatus = packageStatus;
            return this;
        }

        /// <summary>
        /// Checks if PackageStatus property is set.
        /// </summary>
        /// <returns>true if PackageStatus property is set.</returns>
        public bool IsSetPackageStatus()
        {
            return this._packageStatus != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _carrierName = reader.Read<string>("CarrierName");
            _trackingId = reader.Read<string>("TrackingId");
            _packageStatus = reader.Read<string>("PackageStatus");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("CarrierName", _carrierName);
            writer.Write("TrackingId", _trackingId);
            writer.Write("PackageStatus", _packageStatus);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "NonPartneredSmallParcelPackageOutput", this);
        }

    public NonPartneredSmallParcelPackageOutput (string carrierName,string trackingId,string packageStatus) : base() {
        this._carrierName = carrierName;
        this._trackingId = trackingId;
        this._packageStatus = packageStatus;
    }

        public NonPartneredSmallParcelPackageOutput() : base()
        {
        }
    }
}
