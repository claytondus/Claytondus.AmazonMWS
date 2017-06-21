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
 * Non Partnered Small Parcel Data Input
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
    public class NonPartneredSmallParcelDataInput : AbstractMwsObject
    {

        private string _carrierName;
        private NonPartneredSmallParcelPackageInputList _packageList;

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
        public NonPartneredSmallParcelDataInput WithCarrierName(string carrierName)
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
        /// Gets and sets the PackageList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PackageList")]
        public NonPartneredSmallParcelPackageInputList PackageList
        {
            get { return this._packageList; }
            set { this._packageList = value; }
        }

        /// <summary>
        /// Sets the PackageList property.
        /// </summary>
        /// <param name="packageList">PackageList property.</param>
        /// <returns>this instance.</returns>
        public NonPartneredSmallParcelDataInput WithPackageList(NonPartneredSmallParcelPackageInputList packageList)
        {
            this._packageList = packageList;
            return this;
        }

        /// <summary>
        /// Checks if PackageList property is set.
        /// </summary>
        /// <returns>true if PackageList property is set.</returns>
        public bool IsSetPackageList()
        {
            return this._packageList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _carrierName = reader.Read<string>("CarrierName");
            _packageList = reader.Read<NonPartneredSmallParcelPackageInputList>("PackageList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("CarrierName", _carrierName);
            writer.Write("PackageList", _packageList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "NonPartneredSmallParcelDataInput", this);
        }

    public NonPartneredSmallParcelDataInput (string carrierName,NonPartneredSmallParcelPackageInputList packageList) : base() {
        this._carrierName = carrierName;
        this._packageList = packageList;
    }

        public NonPartneredSmallParcelDataInput() : base()
        {
        }
    }
}
