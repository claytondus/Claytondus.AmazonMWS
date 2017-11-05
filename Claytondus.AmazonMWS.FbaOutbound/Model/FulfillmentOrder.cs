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
 * Fulfillment Order
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
    public class FulfillmentOrder : AbstractMwsObject
    {

        private string _sellerFulfillmentOrderId;
        private string _marketplaceId;
        private string _displayableOrderId;
        private DateTime? _displayableOrderDateTime;
        private string _displayableOrderComment;
        private string _shippingSpeedCategory;
        private DeliveryWindow _deliveryWindow;
        private Address _destinationAddress;
        private string _fulfillmentAction;
        private string _fulfillmentPolicy;
        private string _fulfillmentMethod;
        private CODSettings _codSettings;
        private DateTime? _receivedDateTime;
        private string _fulfillmentOrderStatus;
        private DateTime? _statusUpdatedDateTime;
        private NotificationEmailList _notificationEmailList;

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
        public FulfillmentOrder WithSellerFulfillmentOrderId(string sellerFulfillmentOrderId)
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
        public FulfillmentOrder WithMarketplaceId(string marketplaceId)
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
        public FulfillmentOrder WithDisplayableOrderId(string displayableOrderId)
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
        public FulfillmentOrder WithDisplayableOrderDateTime(DateTime displayableOrderDateTime)
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
        public FulfillmentOrder WithDisplayableOrderComment(string displayableOrderComment)
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
        public FulfillmentOrder WithShippingSpeedCategory(string shippingSpeedCategory)
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
        /// Gets and sets the DeliveryWindow property.
        /// </summary>
        [XmlElement(ElementName = "DeliveryWindow")]
        public DeliveryWindow DeliveryWindow
        {
            get { return this._deliveryWindow; }
            set { this._deliveryWindow = value; }
        }

        /// <summary>
        /// Sets the DeliveryWindow property.
        /// </summary>
        /// <param name="deliveryWindow">DeliveryWindow property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrder WithDeliveryWindow(DeliveryWindow deliveryWindow)
        {
            this._deliveryWindow = deliveryWindow;
            return this;
        }

        /// <summary>
        /// Checks if DeliveryWindow property is set.
        /// </summary>
        /// <returns>true if DeliveryWindow property is set.</returns>
        public bool IsSetDeliveryWindow()
        {
            return this._deliveryWindow != null;
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
        public FulfillmentOrder WithDestinationAddress(Address destinationAddress)
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
        public FulfillmentOrder WithFulfillmentAction(string fulfillmentAction)
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
        public FulfillmentOrder WithFulfillmentPolicy(string fulfillmentPolicy)
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
        public FulfillmentOrder WithFulfillmentMethod(string fulfillmentMethod)
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
        /// Gets and sets the CODSettings property.
        /// </summary>
        [XmlElement(ElementName = "CODSettings")]
        public CODSettings CODSettings
        {
            get { return this._codSettings; }
            set { this._codSettings = value; }
        }

        /// <summary>
        /// Sets the CODSettings property.
        /// </summary>
        /// <param name="codSettings">CODSettings property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrder WithCODSettings(CODSettings codSettings)
        {
            this._codSettings = codSettings;
            return this;
        }

        /// <summary>
        /// Checks if CODSettings property is set.
        /// </summary>
        /// <returns>true if CODSettings property is set.</returns>
        public bool IsSetCODSettings()
        {
            return this._codSettings != null;
        }

        /// <summary>
        /// Gets and sets the ReceivedDateTime property.
        /// </summary>
        [XmlElement(ElementName = "ReceivedDateTime")]
        public DateTime ReceivedDateTime
        {
            get { return this._receivedDateTime.GetValueOrDefault(); }
            set { this._receivedDateTime = value; }
        }

        /// <summary>
        /// Sets the ReceivedDateTime property.
        /// </summary>
        /// <param name="receivedDateTime">ReceivedDateTime property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrder WithReceivedDateTime(DateTime receivedDateTime)
        {
            this._receivedDateTime = receivedDateTime;
            return this;
        }

        /// <summary>
        /// Checks if ReceivedDateTime property is set.
        /// </summary>
        /// <returns>true if ReceivedDateTime property is set.</returns>
        public bool IsSetReceivedDateTime()
        {
            return this._receivedDateTime != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentOrderStatus property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentOrderStatus")]
        public string FulfillmentOrderStatus
        {
            get { return this._fulfillmentOrderStatus; }
            set { this._fulfillmentOrderStatus = value; }
        }

        /// <summary>
        /// Sets the FulfillmentOrderStatus property.
        /// </summary>
        /// <param name="fulfillmentOrderStatus">FulfillmentOrderStatus property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrder WithFulfillmentOrderStatus(string fulfillmentOrderStatus)
        {
            this._fulfillmentOrderStatus = fulfillmentOrderStatus;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentOrderStatus property is set.
        /// </summary>
        /// <returns>true if FulfillmentOrderStatus property is set.</returns>
        public bool IsSetFulfillmentOrderStatus()
        {
            return this._fulfillmentOrderStatus != null;
        }

        /// <summary>
        /// Gets and sets the StatusUpdatedDateTime property.
        /// </summary>
        [XmlElement(ElementName = "StatusUpdatedDateTime")]
        public DateTime StatusUpdatedDateTime
        {
            get { return this._statusUpdatedDateTime.GetValueOrDefault(); }
            set { this._statusUpdatedDateTime = value; }
        }

        /// <summary>
        /// Sets the StatusUpdatedDateTime property.
        /// </summary>
        /// <param name="statusUpdatedDateTime">StatusUpdatedDateTime property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrder WithStatusUpdatedDateTime(DateTime statusUpdatedDateTime)
        {
            this._statusUpdatedDateTime = statusUpdatedDateTime;
            return this;
        }

        /// <summary>
        /// Checks if StatusUpdatedDateTime property is set.
        /// </summary>
        /// <returns>true if StatusUpdatedDateTime property is set.</returns>
        public bool IsSetStatusUpdatedDateTime()
        {
            return this._statusUpdatedDateTime != null;
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
        public FulfillmentOrder WithNotificationEmailList(NotificationEmailList notificationEmailList)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerFulfillmentOrderId = reader.Read<string>("SellerFulfillmentOrderId");
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _displayableOrderId = reader.Read<string>("DisplayableOrderId");
            _displayableOrderDateTime = reader.Read<DateTime?>("DisplayableOrderDateTime");
            _displayableOrderComment = reader.Read<string>("DisplayableOrderComment");
            _shippingSpeedCategory = reader.Read<string>("ShippingSpeedCategory");
            _deliveryWindow = reader.Read<DeliveryWindow>("DeliveryWindow");
            _destinationAddress = reader.Read<Address>("DestinationAddress");
            _fulfillmentAction = reader.Read<string>("FulfillmentAction");
            _fulfillmentPolicy = reader.Read<string>("FulfillmentPolicy");
            _fulfillmentMethod = reader.Read<string>("FulfillmentMethod");
            _codSettings = reader.Read<CODSettings>("CODSettings");
            _receivedDateTime = reader.Read<DateTime?>("ReceivedDateTime");
            _fulfillmentOrderStatus = reader.Read<string>("FulfillmentOrderStatus");
            _statusUpdatedDateTime = reader.Read<DateTime?>("StatusUpdatedDateTime");
            _notificationEmailList = reader.Read<NotificationEmailList>("NotificationEmailList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerFulfillmentOrderId", _sellerFulfillmentOrderId);
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("DisplayableOrderId", _displayableOrderId);
            writer.Write("DisplayableOrderDateTime", _displayableOrderDateTime);
            writer.Write("DisplayableOrderComment", _displayableOrderComment);
            writer.Write("ShippingSpeedCategory", _shippingSpeedCategory);
            writer.Write("DeliveryWindow", _deliveryWindow);
            writer.Write("DestinationAddress", _destinationAddress);
            writer.Write("FulfillmentAction", _fulfillmentAction);
            writer.Write("FulfillmentPolicy", _fulfillmentPolicy);
            writer.Write("FulfillmentMethod", _fulfillmentMethod);
            writer.Write("CODSettings", _codSettings);
            writer.Write("ReceivedDateTime", _receivedDateTime);
            writer.Write("FulfillmentOrderStatus", _fulfillmentOrderStatus);
            writer.Write("StatusUpdatedDateTime", _statusUpdatedDateTime);
            writer.Write("NotificationEmailList", _notificationEmailList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "FulfillmentOrder", this);
        }

    public FulfillmentOrder (string sellerFulfillmentOrderId,string displayableOrderId,DateTime? displayableOrderDateTime,string displayableOrderComment,string shippingSpeedCategory,Address destinationAddress,DateTime? receivedDateTime,string fulfillmentOrderStatus,DateTime? statusUpdatedDateTime) : base() {
        this._sellerFulfillmentOrderId = sellerFulfillmentOrderId;
        this._displayableOrderId = displayableOrderId;
        this._displayableOrderDateTime = displayableOrderDateTime;
        this._displayableOrderComment = displayableOrderComment;
        this._shippingSpeedCategory = shippingSpeedCategory;
        this._destinationAddress = destinationAddress;
        this._receivedDateTime = receivedDateTime;
        this._fulfillmentOrderStatus = fulfillmentOrderStatus;
        this._statusUpdatedDateTime = statusUpdatedDateTime;
    }

        public FulfillmentOrder() : base()
        {
        }
    }
}
