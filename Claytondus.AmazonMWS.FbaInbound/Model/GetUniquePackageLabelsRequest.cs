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
 * Get Unique Package Labels Request
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
    public class GetUniquePackageLabelsRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private string _shipmentId;
        private string _pageType;
        private PackageIdentifiers _packageLabelsToPrint;

        /// <summary>
        /// Gets and sets the SellerId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerId")]
        public string SellerId
        {
            get { return this._sellerId; }
            set { this._sellerId = value; }
        }

        /// <summary>
        /// Sets the SellerId property.
        /// </summary>
        /// <param name="sellerId">SellerId property.</param>
        /// <returns>this instance.</returns>
        public GetUniquePackageLabelsRequest WithSellerId(string sellerId)
        {
            this._sellerId = sellerId;
            return this;
        }

        /// <summary>
        /// Checks if SellerId property is set.
        /// </summary>
        /// <returns>true if SellerId property is set.</returns>
        public bool IsSetSellerId()
        {
            return this._sellerId != null;
        }

        /// <summary>
        /// Gets and sets the MWSAuthToken property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MWSAuthToken")]
        public string MWSAuthToken
        {
            get { return this._mwsAuthToken; }
            set { this._mwsAuthToken = value; }
        }

        /// <summary>
        /// Sets the MWSAuthToken property.
        /// </summary>
        /// <param name="mwsAuthToken">MWSAuthToken property.</param>
        /// <returns>this instance.</returns>
        public GetUniquePackageLabelsRequest WithMWSAuthToken(string mwsAuthToken)
        {
            this._mwsAuthToken = mwsAuthToken;
            return this;
        }

        /// <summary>
        /// Checks if MWSAuthToken property is set.
        /// </summary>
        /// <returns>true if MWSAuthToken property is set.</returns>
        public bool IsSetMWSAuthToken()
        {
            return this._mwsAuthToken != null;
        }

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
        public GetUniquePackageLabelsRequest WithShipmentId(string shipmentId)
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
        /// Gets and sets the PageType property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PageType")]
        public string PageType
        {
            get { return this._pageType; }
            set { this._pageType = value; }
        }

        /// <summary>
        /// Sets the PageType property.
        /// </summary>
        /// <param name="pageType">PageType property.</param>
        /// <returns>this instance.</returns>
        public GetUniquePackageLabelsRequest WithPageType(string pageType)
        {
            this._pageType = pageType;
            return this;
        }

        /// <summary>
        /// Checks if PageType property is set.
        /// </summary>
        /// <returns>true if PageType property is set.</returns>
        public bool IsSetPageType()
        {
            return this._pageType != null;
        }

        /// <summary>
        /// Gets and sets the PackageLabelsToPrint property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PackageLabelsToPrint")]
        public PackageIdentifiers PackageLabelsToPrint
        {
            get { return this._packageLabelsToPrint; }
            set { this._packageLabelsToPrint = value; }
        }

        /// <summary>
        /// Sets the PackageLabelsToPrint property.
        /// </summary>
        /// <param name="packageLabelsToPrint">PackageLabelsToPrint property.</param>
        /// <returns>this instance.</returns>
        public GetUniquePackageLabelsRequest WithPackageLabelsToPrint(PackageIdentifiers packageLabelsToPrint)
        {
            this._packageLabelsToPrint = packageLabelsToPrint;
            return this;
        }

        /// <summary>
        /// Checks if PackageLabelsToPrint property is set.
        /// </summary>
        /// <returns>true if PackageLabelsToPrint property is set.</returns>
        public bool IsSetPackageLabelsToPrint()
        {
            return this._packageLabelsToPrint != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _shipmentId = reader.Read<string>("ShipmentId");
            _pageType = reader.Read<string>("PageType");
            _packageLabelsToPrint = reader.Read<PackageIdentifiers>("PackageLabelsToPrint");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("ShipmentId", _shipmentId);
            writer.Write("PageType", _pageType);
            writer.Write("PackageLabelsToPrint", _packageLabelsToPrint);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "GetUniquePackageLabelsRequest", this);
        }

    public GetUniquePackageLabelsRequest (string sellerId,string shipmentId,string pageType,PackageIdentifiers packageLabelsToPrint) : base() {
        this._sellerId = sellerId;
        this._shipmentId = shipmentId;
        this._pageType = pageType;
        this._packageLabelsToPrint = packageLabelsToPrint;
    }

        public GetUniquePackageLabelsRequest() : base()
        {
        }
    }
}
