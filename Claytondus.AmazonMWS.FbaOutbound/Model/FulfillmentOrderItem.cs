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
 * Fulfillment Order Item
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
    public class FulfillmentOrderItem : AbstractMwsObject
    {

        private string _sellerSKU;
        private string _sellerFulfillmentOrderItemId;
        private decimal _quantity;
        private string _giftMessage;
        private string _displayableComment;
        private string _fulfillmentNetworkSKU;
        private string _orderItemDisposition;
        private decimal _cancelledQuantity;
        private decimal _unfulfillableQuantity;
        private DateTime? _estimatedShipDateTime;
        private DateTime? _estimatedArrivalDateTime;
        private Currency _perUnitPrice;
        private Currency _perUnitTax;
        private Currency _perUnitDeclaredValue;

        /// <summary>
        /// Gets and sets the SellerSKU property.
        /// </summary>
        [XmlElement(ElementName = "SellerSKU")]
        public string SellerSKU
        {
            get { return this._sellerSKU; }
            set { this._sellerSKU = value; }
        }

        /// <summary>
        /// Sets the SellerSKU property.
        /// </summary>
        /// <param name="sellerSKU">SellerSKU property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrderItem WithSellerSKU(string sellerSKU)
        {
            this._sellerSKU = sellerSKU;
            return this;
        }

        /// <summary>
        /// Checks if SellerSKU property is set.
        /// </summary>
        /// <returns>true if SellerSKU property is set.</returns>
        public bool IsSetSellerSKU()
        {
            return this._sellerSKU != null;
        }

        /// <summary>
        /// Gets and sets the SellerFulfillmentOrderItemId property.
        /// </summary>
        [XmlElement(ElementName = "SellerFulfillmentOrderItemId")]
        public string SellerFulfillmentOrderItemId
        {
            get { return this._sellerFulfillmentOrderItemId; }
            set { this._sellerFulfillmentOrderItemId = value; }
        }

        /// <summary>
        /// Sets the SellerFulfillmentOrderItemId property.
        /// </summary>
        /// <param name="sellerFulfillmentOrderItemId">SellerFulfillmentOrderItemId property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrderItem WithSellerFulfillmentOrderItemId(string sellerFulfillmentOrderItemId)
        {
            this._sellerFulfillmentOrderItemId = sellerFulfillmentOrderItemId;
            return this;
        }

        /// <summary>
        /// Checks if SellerFulfillmentOrderItemId property is set.
        /// </summary>
        /// <returns>true if SellerFulfillmentOrderItemId property is set.</returns>
        public bool IsSetSellerFulfillmentOrderItemId()
        {
            return this._sellerFulfillmentOrderItemId != null;
        }

        /// <summary>
        /// Gets and sets the Quantity property.
        /// </summary>
        [XmlElement(ElementName = "Quantity")]
        public decimal Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        /// <summary>
        /// Sets the Quantity property.
        /// </summary>
        /// <param name="quantity">Quantity property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrderItem WithQuantity(decimal quantity)
        {
            this._quantity = quantity;
            return this;
        }

        /// <summary>
        /// Checks if Quantity property is set.
        /// </summary>
        /// <returns>true if Quantity property is set.</returns>
        public bool IsSetQuantity()
        {
            return this._quantity != null;
        }

        /// <summary>
        /// Gets and sets the GiftMessage property.
        /// </summary>
        [XmlElement(ElementName = "GiftMessage")]
        public string GiftMessage
        {
            get { return this._giftMessage; }
            set { this._giftMessage = value; }
        }

        /// <summary>
        /// Sets the GiftMessage property.
        /// </summary>
        /// <param name="giftMessage">GiftMessage property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrderItem WithGiftMessage(string giftMessage)
        {
            this._giftMessage = giftMessage;
            return this;
        }

        /// <summary>
        /// Checks if GiftMessage property is set.
        /// </summary>
        /// <returns>true if GiftMessage property is set.</returns>
        public bool IsSetGiftMessage()
        {
            return this._giftMessage != null;
        }

        /// <summary>
        /// Gets and sets the DisplayableComment property.
        /// </summary>
        [XmlElement(ElementName = "DisplayableComment")]
        public string DisplayableComment
        {
            get { return this._displayableComment; }
            set { this._displayableComment = value; }
        }

        /// <summary>
        /// Sets the DisplayableComment property.
        /// </summary>
        /// <param name="displayableComment">DisplayableComment property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrderItem WithDisplayableComment(string displayableComment)
        {
            this._displayableComment = displayableComment;
            return this;
        }

        /// <summary>
        /// Checks if DisplayableComment property is set.
        /// </summary>
        /// <returns>true if DisplayableComment property is set.</returns>
        public bool IsSetDisplayableComment()
        {
            return this._displayableComment != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentNetworkSKU property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentNetworkSKU")]
        public string FulfillmentNetworkSKU
        {
            get { return this._fulfillmentNetworkSKU; }
            set { this._fulfillmentNetworkSKU = value; }
        }

        /// <summary>
        /// Sets the FulfillmentNetworkSKU property.
        /// </summary>
        /// <param name="fulfillmentNetworkSKU">FulfillmentNetworkSKU property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrderItem WithFulfillmentNetworkSKU(string fulfillmentNetworkSKU)
        {
            this._fulfillmentNetworkSKU = fulfillmentNetworkSKU;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentNetworkSKU property is set.
        /// </summary>
        /// <returns>true if FulfillmentNetworkSKU property is set.</returns>
        public bool IsSetFulfillmentNetworkSKU()
        {
            return this._fulfillmentNetworkSKU != null;
        }

        /// <summary>
        /// Gets and sets the OrderItemDisposition property.
        /// </summary>
        [XmlElement(ElementName = "OrderItemDisposition")]
        public string OrderItemDisposition
        {
            get { return this._orderItemDisposition; }
            set { this._orderItemDisposition = value; }
        }

        /// <summary>
        /// Sets the OrderItemDisposition property.
        /// </summary>
        /// <param name="orderItemDisposition">OrderItemDisposition property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrderItem WithOrderItemDisposition(string orderItemDisposition)
        {
            this._orderItemDisposition = orderItemDisposition;
            return this;
        }

        /// <summary>
        /// Checks if OrderItemDisposition property is set.
        /// </summary>
        /// <returns>true if OrderItemDisposition property is set.</returns>
        public bool IsSetOrderItemDisposition()
        {
            return this._orderItemDisposition != null;
        }

        /// <summary>
        /// Gets and sets the CancelledQuantity property.
        /// </summary>
        [XmlElement(ElementName = "CancelledQuantity")]
        public decimal CancelledQuantity
        {
            get { return this._cancelledQuantity; }
            set { this._cancelledQuantity = value; }
        }

        /// <summary>
        /// Sets the CancelledQuantity property.
        /// </summary>
        /// <param name="cancelledQuantity">CancelledQuantity property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrderItem WithCancelledQuantity(decimal cancelledQuantity)
        {
            this._cancelledQuantity = cancelledQuantity;
            return this;
        }

        /// <summary>
        /// Checks if CancelledQuantity property is set.
        /// </summary>
        /// <returns>true if CancelledQuantity property is set.</returns>
        public bool IsSetCancelledQuantity()
        {
            return this._cancelledQuantity != null;
        }

        /// <summary>
        /// Gets and sets the UnfulfillableQuantity property.
        /// </summary>
        [XmlElement(ElementName = "UnfulfillableQuantity")]
        public decimal UnfulfillableQuantity
        {
            get { return this._unfulfillableQuantity; }
            set { this._unfulfillableQuantity = value; }
        }

        /// <summary>
        /// Sets the UnfulfillableQuantity property.
        /// </summary>
        /// <param name="unfulfillableQuantity">UnfulfillableQuantity property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrderItem WithUnfulfillableQuantity(decimal unfulfillableQuantity)
        {
            this._unfulfillableQuantity = unfulfillableQuantity;
            return this;
        }

        /// <summary>
        /// Checks if UnfulfillableQuantity property is set.
        /// </summary>
        /// <returns>true if UnfulfillableQuantity property is set.</returns>
        public bool IsSetUnfulfillableQuantity()
        {
            return this._unfulfillableQuantity != null;
        }

        /// <summary>
        /// Gets and sets the EstimatedShipDateTime property.
        /// </summary>
        [XmlElement(ElementName = "EstimatedShipDateTime")]
        public DateTime EstimatedShipDateTime
        {
            get { return this._estimatedShipDateTime.GetValueOrDefault(); }
            set { this._estimatedShipDateTime = value; }
        }

        /// <summary>
        /// Sets the EstimatedShipDateTime property.
        /// </summary>
        /// <param name="estimatedShipDateTime">EstimatedShipDateTime property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrderItem WithEstimatedShipDateTime(DateTime estimatedShipDateTime)
        {
            this._estimatedShipDateTime = estimatedShipDateTime;
            return this;
        }

        /// <summary>
        /// Checks if EstimatedShipDateTime property is set.
        /// </summary>
        /// <returns>true if EstimatedShipDateTime property is set.</returns>
        public bool IsSetEstimatedShipDateTime()
        {
            return this._estimatedShipDateTime != null;
        }

        /// <summary>
        /// Gets and sets the EstimatedArrivalDateTime property.
        /// </summary>
        [XmlElement(ElementName = "EstimatedArrivalDateTime")]
        public DateTime EstimatedArrivalDateTime
        {
            get { return this._estimatedArrivalDateTime.GetValueOrDefault(); }
            set { this._estimatedArrivalDateTime = value; }
        }

        /// <summary>
        /// Sets the EstimatedArrivalDateTime property.
        /// </summary>
        /// <param name="estimatedArrivalDateTime">EstimatedArrivalDateTime property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrderItem WithEstimatedArrivalDateTime(DateTime estimatedArrivalDateTime)
        {
            this._estimatedArrivalDateTime = estimatedArrivalDateTime;
            return this;
        }

        /// <summary>
        /// Checks if EstimatedArrivalDateTime property is set.
        /// </summary>
        /// <returns>true if EstimatedArrivalDateTime property is set.</returns>
        public bool IsSetEstimatedArrivalDateTime()
        {
            return this._estimatedArrivalDateTime != null;
        }

        /// <summary>
        /// Gets and sets the PerUnitPrice property.
        /// </summary>
        [XmlElement(ElementName = "PerUnitPrice")]
        public Currency PerUnitPrice
        {
            get { return this._perUnitPrice; }
            set { this._perUnitPrice = value; }
        }

        /// <summary>
        /// Sets the PerUnitPrice property.
        /// </summary>
        /// <param name="perUnitPrice">PerUnitPrice property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrderItem WithPerUnitPrice(Currency perUnitPrice)
        {
            this._perUnitPrice = perUnitPrice;
            return this;
        }

        /// <summary>
        /// Checks if PerUnitPrice property is set.
        /// </summary>
        /// <returns>true if PerUnitPrice property is set.</returns>
        public bool IsSetPerUnitPrice()
        {
            return this._perUnitPrice != null;
        }

        /// <summary>
        /// Gets and sets the PerUnitTax property.
        /// </summary>
        [XmlElement(ElementName = "PerUnitTax")]
        public Currency PerUnitTax
        {
            get { return this._perUnitTax; }
            set { this._perUnitTax = value; }
        }

        /// <summary>
        /// Sets the PerUnitTax property.
        /// </summary>
        /// <param name="perUnitTax">PerUnitTax property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrderItem WithPerUnitTax(Currency perUnitTax)
        {
            this._perUnitTax = perUnitTax;
            return this;
        }

        /// <summary>
        /// Checks if PerUnitTax property is set.
        /// </summary>
        /// <returns>true if PerUnitTax property is set.</returns>
        public bool IsSetPerUnitTax()
        {
            return this._perUnitTax != null;
        }

        /// <summary>
        /// Gets and sets the PerUnitDeclaredValue property.
        /// </summary>
        [XmlElement(ElementName = "PerUnitDeclaredValue")]
        public Currency PerUnitDeclaredValue
        {
            get { return this._perUnitDeclaredValue; }
            set { this._perUnitDeclaredValue = value; }
        }

        /// <summary>
        /// Sets the PerUnitDeclaredValue property.
        /// </summary>
        /// <param name="perUnitDeclaredValue">PerUnitDeclaredValue property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentOrderItem WithPerUnitDeclaredValue(Currency perUnitDeclaredValue)
        {
            this._perUnitDeclaredValue = perUnitDeclaredValue;
            return this;
        }

        /// <summary>
        /// Checks if PerUnitDeclaredValue property is set.
        /// </summary>
        /// <returns>true if PerUnitDeclaredValue property is set.</returns>
        public bool IsSetPerUnitDeclaredValue()
        {
            return this._perUnitDeclaredValue != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerSKU = reader.Read<string>("SellerSKU");
            _sellerFulfillmentOrderItemId = reader.Read<string>("SellerFulfillmentOrderItemId");
            _quantity = reader.Read<decimal>("Quantity");
            _giftMessage = reader.Read<string>("GiftMessage");
            _displayableComment = reader.Read<string>("DisplayableComment");
            _fulfillmentNetworkSKU = reader.Read<string>("FulfillmentNetworkSKU");
            _orderItemDisposition = reader.Read<string>("OrderItemDisposition");
            _cancelledQuantity = reader.Read<decimal>("CancelledQuantity");
            _unfulfillableQuantity = reader.Read<decimal>("UnfulfillableQuantity");
            _estimatedShipDateTime = reader.Read<DateTime?>("EstimatedShipDateTime");
            _estimatedArrivalDateTime = reader.Read<DateTime?>("EstimatedArrivalDateTime");
            _perUnitPrice = reader.Read<Currency>("PerUnitPrice");
            _perUnitTax = reader.Read<Currency>("PerUnitTax");
            _perUnitDeclaredValue = reader.Read<Currency>("PerUnitDeclaredValue");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerSKU", _sellerSKU);
            writer.Write("SellerFulfillmentOrderItemId", _sellerFulfillmentOrderItemId);
            writer.Write("Quantity", _quantity);
            writer.Write("GiftMessage", _giftMessage);
            writer.Write("DisplayableComment", _displayableComment);
            writer.Write("FulfillmentNetworkSKU", _fulfillmentNetworkSKU);
            writer.Write("OrderItemDisposition", _orderItemDisposition);
            writer.Write("CancelledQuantity", _cancelledQuantity);
            writer.Write("UnfulfillableQuantity", _unfulfillableQuantity);
            writer.Write("EstimatedShipDateTime", _estimatedShipDateTime);
            writer.Write("EstimatedArrivalDateTime", _estimatedArrivalDateTime);
            writer.Write("PerUnitPrice", _perUnitPrice);
            writer.Write("PerUnitTax", _perUnitTax);
            writer.Write("PerUnitDeclaredValue", _perUnitDeclaredValue);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "FulfillmentOrderItem", this);
        }

    public FulfillmentOrderItem (string sellerSKU,string sellerFulfillmentOrderItemId,decimal quantity,decimal cancelledQuantity,decimal unfulfillableQuantity) : base() {
        this._sellerSKU = sellerSKU;
        this._sellerFulfillmentOrderItemId = sellerFulfillmentOrderItemId;
        this._quantity = quantity;
        this._cancelledQuantity = cancelledQuantity;
        this._unfulfillableQuantity = unfulfillableQuantity;
    }

        public FulfillmentOrderItem() : base()
        {
        }
    }
}
