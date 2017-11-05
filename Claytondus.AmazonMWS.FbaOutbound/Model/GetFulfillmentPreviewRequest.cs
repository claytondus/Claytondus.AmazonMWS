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
 * Get Fulfillment Preview Request
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
    public class GetFulfillmentPreviewRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private string _marketplace;
        private string _marketplaceId;
        private Address _address;
        private GetFulfillmentPreviewItemList _items;
        private ShippingSpeedCategoryList _shippingSpeedCategories;
        private bool? _includeCODFulfillmentPreview;
        private bool? _includeDeliveryWindows;

        /// <summary>
        /// Gets and sets the SellerId property.
        /// </summary>
        [XmlElement(ElementName = "SellerId")]
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
        public GetFulfillmentPreviewRequest WithSellerId(string sellerId)
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
        [XmlElement(ElementName = "MWSAuthToken")]
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
        public GetFulfillmentPreviewRequest WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the Marketplace property.
        /// </summary>
        [XmlElement(ElementName = "Marketplace")]
        public string Marketplace
        {
            get { return this._marketplace; }
            set { this._marketplace = value; }
        }

        /// <summary>
        /// Sets the Marketplace property.
        /// </summary>
        /// <param name="marketplace">Marketplace property.</param>
        /// <returns>this instance.</returns>
        public GetFulfillmentPreviewRequest WithMarketplace(string marketplace)
        {
            this._marketplace = marketplace;
            return this;
        }

        /// <summary>
        /// Checks if Marketplace property is set.
        /// </summary>
        /// <returns>true if Marketplace property is set.</returns>
        public bool IsSetMarketplace()
        {
            return this._marketplace != null;
        }

        /// <summary>
        /// Gets and sets the MarketplaceId property.
        /// </summary>
        [XmlElement(ElementName = "MarketplaceId")]
        public string MarketplaceId
        {
            get { return this._marketplaceId; }
            set { this._marketplaceId = value; }
        }

        /// <summary>
        /// Sets the MarketplaceId property.
        /// </summary>
        /// <param name="marketplaceId">MarketplaceId property.</param>
        /// <returns>this instance.</returns>
        public GetFulfillmentPreviewRequest WithMarketplaceId(string marketplaceId)
        {
            this._marketplaceId = marketplaceId;
            return this;
        }

        /// <summary>
        /// Checks if MarketplaceId property is set.
        /// </summary>
        /// <returns>true if MarketplaceId property is set.</returns>
        public bool IsSetMarketplaceId()
        {
            return this._marketplaceId != null;
        }

        /// <summary>
        /// Gets and sets the Address property.
        /// </summary>
        [XmlElement(ElementName = "Address")]
        public Address Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        /// <summary>
        /// Sets the Address property.
        /// </summary>
        /// <param name="address">Address property.</param>
        /// <returns>this instance.</returns>
        public GetFulfillmentPreviewRequest WithAddress(Address address)
        {
            this._address = address;
            return this;
        }

        /// <summary>
        /// Checks if Address property is set.
        /// </summary>
        /// <returns>true if Address property is set.</returns>
        public bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the Items property.
        /// </summary>
        [XmlElement(ElementName = "Items")]
        public GetFulfillmentPreviewItemList Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        /// <summary>
        /// Sets the Items property.
        /// </summary>
        /// <param name="items">Items property.</param>
        /// <returns>this instance.</returns>
        public GetFulfillmentPreviewRequest WithItems(GetFulfillmentPreviewItemList items)
        {
            this._items = items;
            return this;
        }

        /// <summary>
        /// Checks if Items property is set.
        /// </summary>
        /// <returns>true if Items property is set.</returns>
        public bool IsSetItems()
        {
            return this._items != null;
        }

        /// <summary>
        /// Gets and sets the ShippingSpeedCategories property.
        /// </summary>
        [XmlElement(ElementName = "ShippingSpeedCategories")]
        public ShippingSpeedCategoryList ShippingSpeedCategories
        {
            get { return this._shippingSpeedCategories; }
            set { this._shippingSpeedCategories = value; }
        }

        /// <summary>
        /// Sets the ShippingSpeedCategories property.
        /// </summary>
        /// <param name="shippingSpeedCategories">ShippingSpeedCategories property.</param>
        /// <returns>this instance.</returns>
        public GetFulfillmentPreviewRequest WithShippingSpeedCategories(ShippingSpeedCategoryList shippingSpeedCategories)
        {
            this._shippingSpeedCategories = shippingSpeedCategories;
            return this;
        }

        /// <summary>
        /// Checks if ShippingSpeedCategories property is set.
        /// </summary>
        /// <returns>true if ShippingSpeedCategories property is set.</returns>
        public bool IsSetShippingSpeedCategories()
        {
            return this._shippingSpeedCategories != null;
        }

        /// <summary>
        /// Gets and sets the IncludeCODFulfillmentPreview property.
        /// </summary>
        [XmlElement(ElementName = "IncludeCODFulfillmentPreview")]
        public bool IncludeCODFulfillmentPreview
        {
            get { return this._includeCODFulfillmentPreview.GetValueOrDefault(); }
            set { this._includeCODFulfillmentPreview = value; }
        }

        /// <summary>
        /// Sets the IncludeCODFulfillmentPreview property.
        /// </summary>
        /// <param name="includeCODFulfillmentPreview">IncludeCODFulfillmentPreview property.</param>
        /// <returns>this instance.</returns>
        public GetFulfillmentPreviewRequest WithIncludeCODFulfillmentPreview(bool includeCODFulfillmentPreview)
        {
            this._includeCODFulfillmentPreview = includeCODFulfillmentPreview;
            return this;
        }

        /// <summary>
        /// Checks if IncludeCODFulfillmentPreview property is set.
        /// </summary>
        /// <returns>true if IncludeCODFulfillmentPreview property is set.</returns>
        public bool IsSetIncludeCODFulfillmentPreview()
        {
            return this._includeCODFulfillmentPreview != null;
        }

        /// This method is deprecated, please use: public bool IncludeCODFulfillmentPreview
        /// <summary>
        /// Gets and sets the IncludeCODFulfillmentPreview property.
        /// </summary>
        [XmlElement(ElementName = "IncludeCODFulfilmentPreview")]
        public bool IncludeCODFulfilmentPreview
        {
            get { return this._includeCODFulfillmentPreview.GetValueOrDefault(); }
            set { this._includeCODFulfillmentPreview = value; }
        }

        /// This method is deprecated, please use: public GetFulfillmentPreviewRequest WithIncludeCODFulfillmentPreview(bool includeCODFulfillmentPreview)
        /// <summary>
        /// Sets the IncludeCODFulfillmentPreview property.
        /// </summary>
        /// <param name="includeCODFulfillmentPreview">IncludeCODFulfillmentPreview property.</param>
        /// <returns>this instance.</returns>
        public GetFulfillmentPreviewRequest WithIncludeCODFulfilmentPreview(bool includeCODFulfillmentPreview)
        {
            this._includeCODFulfillmentPreview = includeCODFulfillmentPreview;
            return this;
        }

        /// This method is deprecated, please use: public bool IsSetIncludeCODFulfillmentPreview()
        /// <summary>
        /// Checks if IncludeCODFulfillmentPreview property is set.
        /// </summary>
        /// <returns>true if IncludeCODFulfillmentPreview property is set.</returns>
        public bool IsSetIncludeCODFulfilmentPreview()
        {
            return this._includeCODFulfillmentPreview != null;
        }

    /// <summary>
        /// Gets and sets the IncludeDeliveryWindows property.
        /// </summary>
        [XmlElement(ElementName = "IncludeDeliveryWindows")]
        public bool IncludeDeliveryWindows
        {
            get { return this._includeDeliveryWindows.GetValueOrDefault(); }
            set { this._includeDeliveryWindows = value; }
        }

        /// <summary>
        /// Sets the IncludeDeliveryWindows property.
        /// </summary>
        /// <param name="includeDeliveryWindows">IncludeDeliveryWindows property.</param>
        /// <returns>this instance.</returns>
        public GetFulfillmentPreviewRequest WithIncludeDeliveryWindows(bool includeDeliveryWindows)
        {
            this._includeDeliveryWindows = includeDeliveryWindows;
            return this;
        }

        /// <summary>
        /// Checks if IncludeDeliveryWindows property is set.
        /// </summary>
        /// <returns>true if IncludeDeliveryWindows property is set.</returns>
        public bool IsSetIncludeDeliveryWindows()
        {
            return this._includeDeliveryWindows != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _marketplace = reader.Read<string>("Marketplace");
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _address = reader.Read<Address>("Address");
            _items = reader.Read<GetFulfillmentPreviewItemList>("Items");
            _shippingSpeedCategories = reader.Read<ShippingSpeedCategoryList>("ShippingSpeedCategories");
            _includeCODFulfillmentPreview = reader.Read<bool?>("IncludeCODFulfillmentPreview");
            _includeDeliveryWindows = reader.Read<bool?>("IncludeDeliveryWindows");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("Marketplace", _marketplace);
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("Address", _address);
            writer.Write("Items", _items);
            writer.Write("ShippingSpeedCategories", _shippingSpeedCategories);
            writer.Write("IncludeCODFulfillmentPreview", _includeCODFulfillmentPreview);
            writer.Write("IncludeDeliveryWindows", _includeDeliveryWindows);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "GetFulfillmentPreviewRequest", this);
        }

    public GetFulfillmentPreviewRequest (string sellerId,Address address,GetFulfillmentPreviewItemList items) : base() {
        this._sellerId = sellerId;
        this._address = address;
        this._items = items;
    }

        public GetFulfillmentPreviewRequest() : base()
        {
        }
    }
}
