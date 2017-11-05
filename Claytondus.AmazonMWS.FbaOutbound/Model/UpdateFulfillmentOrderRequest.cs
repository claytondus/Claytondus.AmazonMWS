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
 * Update Fulfillment Order Request
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
    public class UpdateFulfillmentOrderRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private string _marketplace;
        private string _marketplaceId;
        private string _sellerFulfillmentOrderId;
        private string _displayableOrderId;
        private DateTime? _displayableOrderDateTime;
        private string _displayableOrderComment;
        private string _shippingSpeedCategory;
        private Address _destinationAddress;
        private string _fulfillmentAction;
        private string _fulfillmentPolicy;
        private string _fulfillmentMethod;
        private string _shipFromCountryCode;
        private NotificationEmailList _notificationEmailList;
        private UpdateFulfillmentOrderItemList _items;

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
        public UpdateFulfillmentOrderRequest WithSellerId(string sellerId)
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
        public UpdateFulfillmentOrderRequest WithMWSAuthToken(string mwsAuthToken)
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
        public UpdateFulfillmentOrderRequest WithMarketplace(string marketplace)
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
        public UpdateFulfillmentOrderRequest WithMarketplaceId(string marketplaceId)
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
        /// Gets and sets the SellerFulfillmentOrderId property.
        /// </summary>
        [XmlElement(ElementName = "SellerFulfillmentOrderId")]
        public string SellerFulfillmentOrderId
        {
            get { return this._sellerFulfillmentOrderId; }
            set { this._sellerFulfillmentOrderId = value; }
        }

        /// <summary>
        /// Sets the SellerFulfillmentOrderId property.
        /// </summary>
        /// <param name="sellerFulfillmentOrderId">SellerFulfillmentOrderId property.</param>
        /// <returns>this instance.</returns>
        public UpdateFulfillmentOrderRequest WithSellerFulfillmentOrderId(string sellerFulfillmentOrderId)
        {
            this._sellerFulfillmentOrderId = sellerFulfillmentOrderId;
            return this;
        }

        /// <summary>
        /// Checks if SellerFulfillmentOrderId property is set.
        /// </summary>
        /// <returns>true if SellerFulfillmentOrderId property is set.</returns>
        public bool IsSetSellerFulfillmentOrderId()
        {
            return this._sellerFulfillmentOrderId != null;
        }

        /// <summary>
        /// Gets and sets the DisplayableOrderId property.
        /// </summary>
        [XmlElement(ElementName = "DisplayableOrderId")]
        public string DisplayableOrderId
        {
            get { return this._displayableOrderId; }
            set { this._displayableOrderId = value; }
        }

        /// <summary>
        /// Sets the DisplayableOrderId property.
        /// </summary>
        /// <param name="displayableOrderId">DisplayableOrderId property.</param>
        /// <returns>this instance.</returns>
        public UpdateFulfillmentOrderRequest WithDisplayableOrderId(string displayableOrderId)
        {
            this._displayableOrderId = displayableOrderId;
            return this;
        }

        /// <summary>
        /// Checks if DisplayableOrderId property is set.
        /// </summary>
        /// <returns>true if DisplayableOrderId property is set.</returns>
        public bool IsSetDisplayableOrderId()
        {
            return this._displayableOrderId != null;
        }

        /// <summary>
        /// Gets and sets the DisplayableOrderDateTime property.
        /// </summary>
        [XmlElement(ElementName = "DisplayableOrderDateTime")]
        public DateTime DisplayableOrderDateTime
        {
            get { return this._displayableOrderDateTime.GetValueOrDefault(); }
            set { this._displayableOrderDateTime = value; }
        }

        /// <summary>
        /// Sets the DisplayableOrderDateTime property.
        /// </summary>
        /// <param name="displayableOrderDateTime">DisplayableOrderDateTime property.</param>
        /// <returns>this instance.</returns>
        public UpdateFulfillmentOrderRequest WithDisplayableOrderDateTime(DateTime displayableOrderDateTime)
        {
            this._displayableOrderDateTime = displayableOrderDateTime;
            return this;
        }

        /// <summary>
        /// Checks if DisplayableOrderDateTime property is set.
        /// </summary>
        /// <returns>true if DisplayableOrderDateTime property is set.</returns>
        public bool IsSetDisplayableOrderDateTime()
        {
            return this._displayableOrderDateTime != null;
        }

        /// <summary>
        /// Gets and sets the DisplayableOrderComment property.
        /// </summary>
        [XmlElement(ElementName = "DisplayableOrderComment")]
        public string DisplayableOrderComment
        {
            get { return this._displayableOrderComment; }
            set { this._displayableOrderComment = value; }
        }

        /// <summary>
        /// Sets the DisplayableOrderComment property.
        /// </summary>
        /// <param name="displayableOrderComment">DisplayableOrderComment property.</param>
        /// <returns>this instance.</returns>
        public UpdateFulfillmentOrderRequest WithDisplayableOrderComment(string displayableOrderComment)
        {
            this._displayableOrderComment = displayableOrderComment;
            return this;
        }

        /// <summary>
        /// Checks if DisplayableOrderComment property is set.
        /// </summary>
        /// <returns>true if DisplayableOrderComment property is set.</returns>
        public bool IsSetDisplayableOrderComment()
        {
            return this._displayableOrderComment != null;
        }

        /// <summary>
        /// Gets and sets the ShippingSpeedCategory property.
        /// </summary>
        [XmlElement(ElementName = "ShippingSpeedCategory")]
        public string ShippingSpeedCategory
        {
            get { return this._shippingSpeedCategory; }
            set { this._shippingSpeedCategory = value; }
        }

        /// <summary>
        /// Sets the ShippingSpeedCategory property.
        /// </summary>
        /// <param name="shippingSpeedCategory">ShippingSpeedCategory property.</param>
        /// <returns>this instance.</returns>
        public UpdateFulfillmentOrderRequest WithShippingSpeedCategory(string shippingSpeedCategory)
        {
            this._shippingSpeedCategory = shippingSpeedCategory;
            return this;
        }

        /// <summary>
        /// Checks if ShippingSpeedCategory property is set.
        /// </summary>
        /// <returns>true if ShippingSpeedCategory property is set.</returns>
        public bool IsSetShippingSpeedCategory()
        {
            return this._shippingSpeedCategory != null;
        }

        /// <summary>
        /// Gets and sets the DestinationAddress property.
        /// </summary>
        [XmlElement(ElementName = "DestinationAddress")]
        public Address DestinationAddress
        {
            get { return this._destinationAddress; }
            set { this._destinationAddress = value; }
        }

        /// <summary>
        /// Sets the DestinationAddress property.
        /// </summary>
        /// <param name="destinationAddress">DestinationAddress property.</param>
        /// <returns>this instance.</returns>
        public UpdateFulfillmentOrderRequest WithDestinationAddress(Address destinationAddress)
        {
            this._destinationAddress = destinationAddress;
            return this;
        }

        /// <summary>
        /// Checks if DestinationAddress property is set.
        /// </summary>
        /// <returns>true if DestinationAddress property is set.</returns>
        public bool IsSetDestinationAddress()
        {
            return this._destinationAddress != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentAction property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentAction")]
        public string FulfillmentAction
        {
            get { return this._fulfillmentAction; }
            set { this._fulfillmentAction = value; }
        }

        /// <summary>
        /// Sets the FulfillmentAction property.
        /// </summary>
        /// <param name="fulfillmentAction">FulfillmentAction property.</param>
        /// <returns>this instance.</returns>
        public UpdateFulfillmentOrderRequest WithFulfillmentAction(string fulfillmentAction)
        {
            this._fulfillmentAction = fulfillmentAction;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentAction property is set.
        /// </summary>
        /// <returns>true if FulfillmentAction property is set.</returns>
        public bool IsSetFulfillmentAction()
        {
            return this._fulfillmentAction != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentPolicy property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentPolicy")]
        public string FulfillmentPolicy
        {
            get { return this._fulfillmentPolicy; }
            set { this._fulfillmentPolicy = value; }
        }

        /// <summary>
        /// Sets the FulfillmentPolicy property.
        /// </summary>
        /// <param name="fulfillmentPolicy">FulfillmentPolicy property.</param>
        /// <returns>this instance.</returns>
        public UpdateFulfillmentOrderRequest WithFulfillmentPolicy(string fulfillmentPolicy)
        {
            this._fulfillmentPolicy = fulfillmentPolicy;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentPolicy property is set.
        /// </summary>
        /// <returns>true if FulfillmentPolicy property is set.</returns>
        public bool IsSetFulfillmentPolicy()
        {
            return this._fulfillmentPolicy != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentMethod property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentMethod")]
        public string FulfillmentMethod
        {
            get { return this._fulfillmentMethod; }
            set { this._fulfillmentMethod = value; }
        }

        /// <summary>
        /// Sets the FulfillmentMethod property.
        /// </summary>
        /// <param name="fulfillmentMethod">FulfillmentMethod property.</param>
        /// <returns>this instance.</returns>
        public UpdateFulfillmentOrderRequest WithFulfillmentMethod(string fulfillmentMethod)
        {
            this._fulfillmentMethod = fulfillmentMethod;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentMethod property is set.
        /// </summary>
        /// <returns>true if FulfillmentMethod property is set.</returns>
        public bool IsSetFulfillmentMethod()
        {
            return this._fulfillmentMethod != null;
        }

        /// <summary>
        /// Gets and sets the ShipFromCountryCode property.
        /// </summary>
        [XmlElement(ElementName = "ShipFromCountryCode")]
        public string ShipFromCountryCode
        {
            get { return this._shipFromCountryCode; }
            set { this._shipFromCountryCode = value; }
        }

        /// <summary>
        /// Sets the ShipFromCountryCode property.
        /// </summary>
        /// <param name="shipFromCountryCode">ShipFromCountryCode property.</param>
        /// <returns>this instance.</returns>
        public UpdateFulfillmentOrderRequest WithShipFromCountryCode(string shipFromCountryCode)
        {
            this._shipFromCountryCode = shipFromCountryCode;
            return this;
        }

        /// <summary>
        /// Checks if ShipFromCountryCode property is set.
        /// </summary>
        /// <returns>true if ShipFromCountryCode property is set.</returns>
        public bool IsSetShipFromCountryCode()
        {
            return this._shipFromCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the NotificationEmailList property.
        /// </summary>
        [XmlElement(ElementName = "NotificationEmailList")]
        public NotificationEmailList NotificationEmailList
        {
            get { return this._notificationEmailList; }
            set { this._notificationEmailList = value; }
        }

        /// <summary>
        /// Sets the NotificationEmailList property.
        /// </summary>
        /// <param name="notificationEmailList">NotificationEmailList property.</param>
        /// <returns>this instance.</returns>
        public UpdateFulfillmentOrderRequest WithNotificationEmailList(NotificationEmailList notificationEmailList)
        {
            this._notificationEmailList = notificationEmailList;
            return this;
        }

        /// <summary>
        /// Checks if NotificationEmailList property is set.
        /// </summary>
        /// <returns>true if NotificationEmailList property is set.</returns>
        public bool IsSetNotificationEmailList()
        {
            return this._notificationEmailList != null;
        }

        /// <summary>
        /// Gets and sets the Items property.
        /// </summary>
        [XmlElement(ElementName = "Items")]
        public UpdateFulfillmentOrderItemList Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        /// <summary>
        /// Sets the Items property.
        /// </summary>
        /// <param name="items">Items property.</param>
        /// <returns>this instance.</returns>
        public UpdateFulfillmentOrderRequest WithItems(UpdateFulfillmentOrderItemList items)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _marketplace = reader.Read<string>("Marketplace");
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _sellerFulfillmentOrderId = reader.Read<string>("SellerFulfillmentOrderId");
            _displayableOrderId = reader.Read<string>("DisplayableOrderId");
            _displayableOrderDateTime = reader.Read<DateTime?>("DisplayableOrderDateTime");
            _displayableOrderComment = reader.Read<string>("DisplayableOrderComment");
            _shippingSpeedCategory = reader.Read<string>("ShippingSpeedCategory");
            _destinationAddress = reader.Read<Address>("DestinationAddress");
            _fulfillmentAction = reader.Read<string>("FulfillmentAction");
            _fulfillmentPolicy = reader.Read<string>("FulfillmentPolicy");
            _fulfillmentMethod = reader.Read<string>("FulfillmentMethod");
            _shipFromCountryCode = reader.Read<string>("ShipFromCountryCode");
            _notificationEmailList = reader.Read<NotificationEmailList>("NotificationEmailList");
            _items = reader.Read<UpdateFulfillmentOrderItemList>("Items");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("Marketplace", _marketplace);
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("SellerFulfillmentOrderId", _sellerFulfillmentOrderId);
            writer.Write("DisplayableOrderId", _displayableOrderId);
            writer.Write("DisplayableOrderDateTime", _displayableOrderDateTime);
            writer.Write("DisplayableOrderComment", _displayableOrderComment);
            writer.Write("ShippingSpeedCategory", _shippingSpeedCategory);
            writer.Write("DestinationAddress", _destinationAddress);
            writer.Write("FulfillmentAction", _fulfillmentAction);
            writer.Write("FulfillmentPolicy", _fulfillmentPolicy);
            writer.Write("FulfillmentMethod", _fulfillmentMethod);
            writer.Write("ShipFromCountryCode", _shipFromCountryCode);
            writer.Write("NotificationEmailList", _notificationEmailList);
            writer.Write("Items", _items);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "UpdateFulfillmentOrderRequest", this);
        }

    public UpdateFulfillmentOrderRequest (string sellerId,string sellerFulfillmentOrderId) : base() {
        this._sellerId = sellerId;
        this._sellerFulfillmentOrderId = sellerFulfillmentOrderId;
    }

        public UpdateFulfillmentOrderRequest() : base()
        {
        }
    }
}
