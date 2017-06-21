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
 * Partnered Small Parcel Package Output
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
    public class PartneredSmallParcelPackageOutput : AbstractMwsObject
    {

        private Dimensions _dimensions;
        private Weight _weight;
        private string _carrierName;
        private string _trackingId;
        private string _packageStatus;

        /// <summary>
        /// Gets and sets the Dimensions property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Dimensions")]
        public Dimensions Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        /// <summary>
        /// Sets the Dimensions property.
        /// </summary>
        /// <param name="dimensions">Dimensions property.</param>
        /// <returns>this instance.</returns>
        public PartneredSmallParcelPackageOutput WithDimensions(Dimensions dimensions)
        {
            this._dimensions = dimensions;
            return this;
        }

        /// <summary>
        /// Checks if Dimensions property is set.
        /// </summary>
        /// <returns>true if Dimensions property is set.</returns>
        public bool IsSetDimensions()
        {
            return this._dimensions != null;
        }

        /// <summary>
        /// Gets and sets the Weight property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Weight")]
        public Weight Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        /// <summary>
        /// Sets the Weight property.
        /// </summary>
        /// <param name="weight">Weight property.</param>
        /// <returns>this instance.</returns>
        public PartneredSmallParcelPackageOutput WithWeight(Weight weight)
        {
            this._weight = weight;
            return this;
        }

        /// <summary>
        /// Checks if Weight property is set.
        /// </summary>
        /// <returns>true if Weight property is set.</returns>
        public bool IsSetWeight()
        {
            return this._weight != null;
        }

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
        public PartneredSmallParcelPackageOutput WithCarrierName(string carrierName)
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
        public PartneredSmallParcelPackageOutput WithTrackingId(string trackingId)
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
        public PartneredSmallParcelPackageOutput WithPackageStatus(string packageStatus)
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
            _dimensions = reader.Read<Dimensions>("Dimensions");
            _weight = reader.Read<Weight>("Weight");
            _carrierName = reader.Read<string>("CarrierName");
            _trackingId = reader.Read<string>("TrackingId");
            _packageStatus = reader.Read<string>("PackageStatus");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Dimensions", _dimensions);
            writer.Write("Weight", _weight);
            writer.Write("CarrierName", _carrierName);
            writer.Write("TrackingId", _trackingId);
            writer.Write("PackageStatus", _packageStatus);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "PartneredSmallParcelPackageOutput", this);
        }

    public PartneredSmallParcelPackageOutput (Dimensions dimensions,Weight weight,string carrierName,string trackingId,string packageStatus) : base() {
        this._dimensions = dimensions;
        this._weight = weight;
        this._carrierName = carrierName;
        this._trackingId = trackingId;
        this._packageStatus = packageStatus;
    }

        public PartneredSmallParcelPackageOutput() : base()
        {
        }
    }
}
