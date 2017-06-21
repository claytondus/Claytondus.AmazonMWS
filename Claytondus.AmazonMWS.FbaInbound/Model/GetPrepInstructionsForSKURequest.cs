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
 * Get Prep Instructions For SKU Request
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
    public class GetPrepInstructionsForSKURequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private SellerSKUList _sellerSKUList;
        private string _shipToCountryCode;

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
        public GetPrepInstructionsForSKURequest WithSellerId(string sellerId)
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
        public GetPrepInstructionsForSKURequest WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the SellerSKUList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerSKUList")]
        public SellerSKUList SellerSKUList
        {
            get { return this._sellerSKUList; }
            set { this._sellerSKUList = value; }
        }

        /// <summary>
        /// Sets the SellerSKUList property.
        /// </summary>
        /// <param name="sellerSKUList">SellerSKUList property.</param>
        /// <returns>this instance.</returns>
        public GetPrepInstructionsForSKURequest WithSellerSKUList(SellerSKUList sellerSKUList)
        {
            this._sellerSKUList = sellerSKUList;
            return this;
        }

        /// <summary>
        /// Checks if SellerSKUList property is set.
        /// </summary>
        /// <returns>true if SellerSKUList property is set.</returns>
        public bool IsSetSellerSKUList()
        {
            return this._sellerSKUList != null;
        }

        /// <summary>
        /// Gets and sets the ShipToCountryCode property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipToCountryCode")]
        public string ShipToCountryCode
        {
            get { return this._shipToCountryCode; }
            set { this._shipToCountryCode = value; }
        }

        /// <summary>
        /// Sets the ShipToCountryCode property.
        /// </summary>
        /// <param name="shipToCountryCode">ShipToCountryCode property.</param>
        /// <returns>this instance.</returns>
        public GetPrepInstructionsForSKURequest WithShipToCountryCode(string shipToCountryCode)
        {
            this._shipToCountryCode = shipToCountryCode;
            return this;
        }

        /// <summary>
        /// Checks if ShipToCountryCode property is set.
        /// </summary>
        /// <returns>true if ShipToCountryCode property is set.</returns>
        public bool IsSetShipToCountryCode()
        {
            return this._shipToCountryCode != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _sellerSKUList = reader.Read<SellerSKUList>("SellerSKUList");
            _shipToCountryCode = reader.Read<string>("ShipToCountryCode");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("SellerSKUList", _sellerSKUList);
            writer.Write("ShipToCountryCode", _shipToCountryCode);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "GetPrepInstructionsForSKURequest", this);
        }

    public GetPrepInstructionsForSKURequest (string sellerId,SellerSKUList sellerSKUList,string shipToCountryCode) : base() {
        this._sellerId = sellerId;
        this._sellerSKUList = sellerSKUList;
        this._shipToCountryCode = shipToCountryCode;
    }

        public GetPrepInstructionsForSKURequest() : base()
        {
        }
    }
}
