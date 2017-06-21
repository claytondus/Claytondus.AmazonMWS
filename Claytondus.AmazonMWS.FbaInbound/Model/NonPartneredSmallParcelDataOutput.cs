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
 * Non Partnered Small Parcel Data Output
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
    public class NonPartneredSmallParcelDataOutput : AbstractMwsObject
    {

        private NonPartneredSmallParcelPackageOutputList _packageList;

        /// <summary>
        /// Gets and sets the PackageList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PackageList")]
        public NonPartneredSmallParcelPackageOutputList PackageList
        {
            get { return this._packageList; }
            set { this._packageList = value; }
        }

        /// <summary>
        /// Sets the PackageList property.
        /// </summary>
        /// <param name="packageList">PackageList property.</param>
        /// <returns>this instance.</returns>
        public NonPartneredSmallParcelDataOutput WithPackageList(NonPartneredSmallParcelPackageOutputList packageList)
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
            _packageList = reader.Read<NonPartneredSmallParcelPackageOutputList>("PackageList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("PackageList", _packageList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "NonPartneredSmallParcelDataOutput", this);
        }

    public NonPartneredSmallParcelDataOutput (NonPartneredSmallParcelPackageOutputList packageList) : base() {
        this._packageList = packageList;
    }

        public NonPartneredSmallParcelDataOutput() : base()
        {
        }
    }
}
