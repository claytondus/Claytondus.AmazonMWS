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
 * Partnered Small Parcel Data Output
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
    public class PartneredSmallParcelDataOutput : AbstractMwsObject
    {

        private PartneredSmallParcelPackageOutputList _packageList;
        private PartneredEstimate _partneredEstimate;

        /// <summary>
        /// Gets and sets the PackageList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PackageList")]
        public PartneredSmallParcelPackageOutputList PackageList
        {
            get { return this._packageList; }
            set { this._packageList = value; }
        }

        /// <summary>
        /// Sets the PackageList property.
        /// </summary>
        /// <param name="packageList">PackageList property.</param>
        /// <returns>this instance.</returns>
        public PartneredSmallParcelDataOutput WithPackageList(PartneredSmallParcelPackageOutputList packageList)
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

        /// <summary>
        /// Gets and sets the PartneredEstimate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PartneredEstimate")]
        public PartneredEstimate PartneredEstimate
        {
            get { return this._partneredEstimate; }
            set { this._partneredEstimate = value; }
        }

        /// <summary>
        /// Sets the PartneredEstimate property.
        /// </summary>
        /// <param name="partneredEstimate">PartneredEstimate property.</param>
        /// <returns>this instance.</returns>
        public PartneredSmallParcelDataOutput WithPartneredEstimate(PartneredEstimate partneredEstimate)
        {
            this._partneredEstimate = partneredEstimate;
            return this;
        }

        /// <summary>
        /// Checks if PartneredEstimate property is set.
        /// </summary>
        /// <returns>true if PartneredEstimate property is set.</returns>
        public bool IsSetPartneredEstimate()
        {
            return this._partneredEstimate != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _packageList = reader.Read<PartneredSmallParcelPackageOutputList>("PackageList");
            _partneredEstimate = reader.Read<PartneredEstimate>("PartneredEstimate");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("PackageList", _packageList);
            writer.Write("PartneredEstimate", _partneredEstimate);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "PartneredSmallParcelDataOutput", this);
        }

    public PartneredSmallParcelDataOutput (PartneredSmallParcelPackageOutputList packageList) : base() {
        this._packageList = packageList;
    }

        public PartneredSmallParcelDataOutput() : base()
        {
        }
    }
}
