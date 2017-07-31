/*******************************************************************************
 * Copyright 2009-2017 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Order Item
 * API Version: 2013-09-01
 * Library Version: 2017-02-22
 * Generated: Thu Mar 02 12:41:05 UTC 2017
 */


using System;
using System.Xml;
using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Orders.Model
{
    public class OrderItem : AbstractMwsObject
    {

        private string _asin;
        private string _sellerSKU;
        private string _orderItemId;
        private string _title;
        private decimal _quantityOrdered;
        private decimal? _quantityShipped;
        private PointsGrantedDetail _pointsGranted;
        private Money _itemPrice;
        private Money _shippingPrice;
        private Money _giftWrapPrice;
        private Money _itemTax;
        private Money _shippingTax;
        private Money _giftWrapTax;
        private Money _shippingDiscount;
        private Money _promotionDiscount;
        private List<string> _promotionIds;
        private Money _codFee;
        private Money _codFeeDiscount;
        private string _giftMessageText;
        private string _giftWrapLevel;
        private InvoiceData _invoiceData;
        private string _conditionNote;
        private string _conditionId;
        private string _conditionSubtypeId;
        private string _scheduledDeliveryStartDate;
        private string _scheduledDeliveryEndDate;
        private string _priceDesignation;
        private BuyerCustomizedInfoDetail _buyerCustomizedInfo;

        /// <summary>
        /// Gets and sets the ASIN property.
        /// </summary>
        public string ASIN
        {
            get { return this._asin; }
            set { this._asin = value; }
        }

        /// <summary>
        /// Sets the ASIN property.
        /// </summary>
        /// <param name="asin">ASIN property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithASIN(string asin)
        {
            this._asin = asin;
            return this;
        }

        /// <summary>
        /// Checks if ASIN property is set.
        /// </summary>
        /// <returns>true if ASIN property is set.</returns>
        public bool IsSetASIN()
        {
            return this._asin != null;
        }

        /// <summary>
        /// Gets and sets the SellerSKU property.
        /// </summary>
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
        public OrderItem WithSellerSKU(string sellerSKU)
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
        /// Gets and sets the OrderItemId property.
        /// </summary>
        public string OrderItemId
        {
            get { return this._orderItemId; }
            set { this._orderItemId = value; }
        }

        /// <summary>
        /// Sets the OrderItemId property.
        /// </summary>
        /// <param name="orderItemId">OrderItemId property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithOrderItemId(string orderItemId)
        {
            this._orderItemId = orderItemId;
            return this;
        }

        /// <summary>
        /// Checks if OrderItemId property is set.
        /// </summary>
        /// <returns>true if OrderItemId property is set.</returns>
        public bool IsSetOrderItemId()
        {
            return this._orderItemId != null;
        }

        /// <summary>
        /// Gets and sets the Title property.
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        /// <summary>
        /// Sets the Title property.
        /// </summary>
        /// <param name="title">Title property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithTitle(string title)
        {
            this._title = title;
            return this;
        }

        /// <summary>
        /// Checks if Title property is set.
        /// </summary>
        /// <returns>true if Title property is set.</returns>
        public bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the QuantityOrdered property.
        /// </summary>
        public decimal QuantityOrdered
        {
            get { return this._quantityOrdered; }
            set { this._quantityOrdered = value; }
        }

        /// <summary>
        /// Sets the QuantityOrdered property.
        /// </summary>
        /// <param name="quantityOrdered">QuantityOrdered property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithQuantityOrdered(decimal quantityOrdered)
        {
            this._quantityOrdered = quantityOrdered;
            return this;
        }

        /// <summary>
        /// Checks if QuantityOrdered property is set.
        /// </summary>
        /// <returns>true if QuantityOrdered property is set.</returns>
        public bool IsSetQuantityOrdered()
        {
            return this._quantityOrdered != null;
        }

        /// <summary>
        /// Gets and sets the QuantityShipped property.
        /// </summary>
        public decimal QuantityShipped
        {
            get { return this._quantityShipped.GetValueOrDefault(); }
            set { this._quantityShipped = value; }
        }

        /// <summary>
        /// Sets the QuantityShipped property.
        /// </summary>
        /// <param name="quantityShipped">QuantityShipped property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithQuantityShipped(decimal quantityShipped)
        {
            this._quantityShipped = quantityShipped;
            return this;
        }

        /// <summary>
        /// Checks if QuantityShipped property is set.
        /// </summary>
        /// <returns>true if QuantityShipped property is set.</returns>
        public bool IsSetQuantityShipped()
        {
            return this._quantityShipped != null;
        }

        /// <summary>
        /// Gets and sets the PointsGranted property.
        /// </summary>
        public PointsGrantedDetail PointsGranted
        {
            get { return this._pointsGranted; }
            set { this._pointsGranted = value; }
        }

        /// <summary>
        /// Sets the PointsGranted property.
        /// </summary>
        /// <param name="pointsGranted">PointsGranted property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithPointsGranted(PointsGrantedDetail pointsGranted)
        {
            this._pointsGranted = pointsGranted;
            return this;
        }

        /// <summary>
        /// Checks if PointsGranted property is set.
        /// </summary>
        /// <returns>true if PointsGranted property is set.</returns>
        public bool IsSetPointsGranted()
        {
            return this._pointsGranted != null;
        }

        /// <summary>
        /// Gets and sets the ItemPrice property.
        /// </summary>
        public Money ItemPrice
        {
            get { return this._itemPrice; }
            set { this._itemPrice = value; }
        }

        /// <summary>
        /// Sets the ItemPrice property.
        /// </summary>
        /// <param name="itemPrice">ItemPrice property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithItemPrice(Money itemPrice)
        {
            this._itemPrice = itemPrice;
            return this;
        }

        /// <summary>
        /// Checks if ItemPrice property is set.
        /// </summary>
        /// <returns>true if ItemPrice property is set.</returns>
        public bool IsSetItemPrice()
        {
            return this._itemPrice != null;
        }

        /// <summary>
        /// Gets and sets the ShippingPrice property.
        /// </summary>
        public Money ShippingPrice
        {
            get { return this._shippingPrice; }
            set { this._shippingPrice = value; }
        }

        /// <summary>
        /// Sets the ShippingPrice property.
        /// </summary>
        /// <param name="shippingPrice">ShippingPrice property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithShippingPrice(Money shippingPrice)
        {
            this._shippingPrice = shippingPrice;
            return this;
        }

        /// <summary>
        /// Checks if ShippingPrice property is set.
        /// </summary>
        /// <returns>true if ShippingPrice property is set.</returns>
        public bool IsSetShippingPrice()
        {
            return this._shippingPrice != null;
        }

        /// <summary>
        /// Gets and sets the GiftWrapPrice property.
        /// </summary>
        public Money GiftWrapPrice
        {
            get { return this._giftWrapPrice; }
            set { this._giftWrapPrice = value; }
        }

        /// <summary>
        /// Sets the GiftWrapPrice property.
        /// </summary>
        /// <param name="giftWrapPrice">GiftWrapPrice property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithGiftWrapPrice(Money giftWrapPrice)
        {
            this._giftWrapPrice = giftWrapPrice;
            return this;
        }

        /// <summary>
        /// Checks if GiftWrapPrice property is set.
        /// </summary>
        /// <returns>true if GiftWrapPrice property is set.</returns>
        public bool IsSetGiftWrapPrice()
        {
            return this._giftWrapPrice != null;
        }

        /// <summary>
        /// Gets and sets the ItemTax property.
        /// </summary>
        public Money ItemTax
        {
            get { return this._itemTax; }
            set { this._itemTax = value; }
        }

        /// <summary>
        /// Sets the ItemTax property.
        /// </summary>
        /// <param name="itemTax">ItemTax property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithItemTax(Money itemTax)
        {
            this._itemTax = itemTax;
            return this;
        }

        /// <summary>
        /// Checks if ItemTax property is set.
        /// </summary>
        /// <returns>true if ItemTax property is set.</returns>
        public bool IsSetItemTax()
        {
            return this._itemTax != null;
        }

        /// <summary>
        /// Gets and sets the ShippingTax property.
        /// </summary>
        public Money ShippingTax
        {
            get { return this._shippingTax; }
            set { this._shippingTax = value; }
        }

        /// <summary>
        /// Sets the ShippingTax property.
        /// </summary>
        /// <param name="shippingTax">ShippingTax property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithShippingTax(Money shippingTax)
        {
            this._shippingTax = shippingTax;
            return this;
        }

        /// <summary>
        /// Checks if ShippingTax property is set.
        /// </summary>
        /// <returns>true if ShippingTax property is set.</returns>
        public bool IsSetShippingTax()
        {
            return this._shippingTax != null;
        }

        /// <summary>
        /// Gets and sets the GiftWrapTax property.
        /// </summary>
        public Money GiftWrapTax
        {
            get { return this._giftWrapTax; }
            set { this._giftWrapTax = value; }
        }

        /// <summary>
        /// Sets the GiftWrapTax property.
        /// </summary>
        /// <param name="giftWrapTax">GiftWrapTax property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithGiftWrapTax(Money giftWrapTax)
        {
            this._giftWrapTax = giftWrapTax;
            return this;
        }

        /// <summary>
        /// Checks if GiftWrapTax property is set.
        /// </summary>
        /// <returns>true if GiftWrapTax property is set.</returns>
        public bool IsSetGiftWrapTax()
        {
            return this._giftWrapTax != null;
        }

        /// <summary>
        /// Gets and sets the ShippingDiscount property.
        /// </summary>
        public Money ShippingDiscount
        {
            get { return this._shippingDiscount; }
            set { this._shippingDiscount = value; }
        }

        /// <summary>
        /// Sets the ShippingDiscount property.
        /// </summary>
        /// <param name="shippingDiscount">ShippingDiscount property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithShippingDiscount(Money shippingDiscount)
        {
            this._shippingDiscount = shippingDiscount;
            return this;
        }

        /// <summary>
        /// Checks if ShippingDiscount property is set.
        /// </summary>
        /// <returns>true if ShippingDiscount property is set.</returns>
        public bool IsSetShippingDiscount()
        {
            return this._shippingDiscount != null;
        }

        /// <summary>
        /// Gets and sets the PromotionDiscount property.
        /// </summary>
        public Money PromotionDiscount
        {
            get { return this._promotionDiscount; }
            set { this._promotionDiscount = value; }
        }

        /// <summary>
        /// Sets the PromotionDiscount property.
        /// </summary>
        /// <param name="promotionDiscount">PromotionDiscount property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithPromotionDiscount(Money promotionDiscount)
        {
            this._promotionDiscount = promotionDiscount;
            return this;
        }

        /// <summary>
        /// Checks if PromotionDiscount property is set.
        /// </summary>
        /// <returns>true if PromotionDiscount property is set.</returns>
        public bool IsSetPromotionDiscount()
        {
            return this._promotionDiscount != null;
        }

        /// <summary>
        /// Gets and sets the PromotionIds property.
        /// </summary>
        public List<string> PromotionIds
        {
            get
            {
                if(this._promotionIds == null)
                {
                    this._promotionIds = new List<string>();
                }
                return this._promotionIds;
            }
            set { this._promotionIds = value; }
        }

        /// <summary>
        /// Sets the PromotionIds property.
        /// </summary>
        /// <param name="promotionIds">PromotionIds property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithPromotionIds(string[] promotionIds)
        {
            this._promotionIds.AddRange(promotionIds);
            return this;
        }

        /// <summary>
        /// Checks if PromotionIds property is set.
        /// </summary>
        /// <returns>true if PromotionIds property is set.</returns>
        public bool IsSetPromotionIds()
        {
            return this.PromotionIds.Count > 0;
        }

        /// <summary>
        /// Gets and sets the CODFee property.
        /// </summary>
        public Money CODFee
        {
            get { return this._codFee; }
            set { this._codFee = value; }
        }

        /// <summary>
        /// Sets the CODFee property.
        /// </summary>
        /// <param name="codFee">CODFee property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithCODFee(Money codFee)
        {
            this._codFee = codFee;
            return this;
        }

        /// <summary>
        /// Checks if CODFee property is set.
        /// </summary>
        /// <returns>true if CODFee property is set.</returns>
        public bool IsSetCODFee()
        {
            return this._codFee != null;
        }

        /// <summary>
        /// Gets and sets the CODFeeDiscount property.
        /// </summary>
        public Money CODFeeDiscount
        {
            get { return this._codFeeDiscount; }
            set { this._codFeeDiscount = value; }
        }

        /// <summary>
        /// Sets the CODFeeDiscount property.
        /// </summary>
        /// <param name="codFeeDiscount">CODFeeDiscount property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithCODFeeDiscount(Money codFeeDiscount)
        {
            this._codFeeDiscount = codFeeDiscount;
            return this;
        }

        /// <summary>
        /// Checks if CODFeeDiscount property is set.
        /// </summary>
        /// <returns>true if CODFeeDiscount property is set.</returns>
        public bool IsSetCODFeeDiscount()
        {
            return this._codFeeDiscount != null;
        }

        /// <summary>
        /// Gets and sets the GiftMessageText property.
        /// </summary>
        public string GiftMessageText
        {
            get { return this._giftMessageText; }
            set { this._giftMessageText = value; }
        }

        /// <summary>
        /// Sets the GiftMessageText property.
        /// </summary>
        /// <param name="giftMessageText">GiftMessageText property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithGiftMessageText(string giftMessageText)
        {
            this._giftMessageText = giftMessageText;
            return this;
        }

        /// <summary>
        /// Checks if GiftMessageText property is set.
        /// </summary>
        /// <returns>true if GiftMessageText property is set.</returns>
        public bool IsSetGiftMessageText()
        {
            return this._giftMessageText != null;
        }

        /// <summary>
        /// Gets and sets the GiftWrapLevel property.
        /// </summary>
        public string GiftWrapLevel
        {
            get { return this._giftWrapLevel; }
            set { this._giftWrapLevel = value; }
        }

        /// <summary>
        /// Sets the GiftWrapLevel property.
        /// </summary>
        /// <param name="giftWrapLevel">GiftWrapLevel property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithGiftWrapLevel(string giftWrapLevel)
        {
            this._giftWrapLevel = giftWrapLevel;
            return this;
        }

        /// <summary>
        /// Checks if GiftWrapLevel property is set.
        /// </summary>
        /// <returns>true if GiftWrapLevel property is set.</returns>
        public bool IsSetGiftWrapLevel()
        {
            return this._giftWrapLevel != null;
        }

        /// <summary>
        /// Gets and sets the InvoiceData property.
        /// </summary>
        public InvoiceData InvoiceData
        {
            get { return this._invoiceData; }
            set { this._invoiceData = value; }
        }

        /// <summary>
        /// Sets the InvoiceData property.
        /// </summary>
        /// <param name="invoiceData">InvoiceData property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithInvoiceData(InvoiceData invoiceData)
        {
            this._invoiceData = invoiceData;
            return this;
        }

        /// <summary>
        /// Checks if InvoiceData property is set.
        /// </summary>
        /// <returns>true if InvoiceData property is set.</returns>
        public bool IsSetInvoiceData()
        {
            return this._invoiceData != null;
        }

        /// <summary>
        /// Gets and sets the ConditionNote property.
        /// </summary>
        public string ConditionNote
        {
            get { return this._conditionNote; }
            set { this._conditionNote = value; }
        }

        /// <summary>
        /// Sets the ConditionNote property.
        /// </summary>
        /// <param name="conditionNote">ConditionNote property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithConditionNote(string conditionNote)
        {
            this._conditionNote = conditionNote;
            return this;
        }

        /// <summary>
        /// Checks if ConditionNote property is set.
        /// </summary>
        /// <returns>true if ConditionNote property is set.</returns>
        public bool IsSetConditionNote()
        {
            return this._conditionNote != null;
        }

        /// <summary>
        /// Gets and sets the ConditionId property.
        /// </summary>
        public string ConditionId
        {
            get { return this._conditionId; }
            set { this._conditionId = value; }
        }

        /// <summary>
        /// Sets the ConditionId property.
        /// </summary>
        /// <param name="conditionId">ConditionId property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithConditionId(string conditionId)
        {
            this._conditionId = conditionId;
            return this;
        }

        /// <summary>
        /// Checks if ConditionId property is set.
        /// </summary>
        /// <returns>true if ConditionId property is set.</returns>
        public bool IsSetConditionId()
        {
            return this._conditionId != null;
        }

        /// <summary>
        /// Gets and sets the ConditionSubtypeId property.
        /// </summary>
        public string ConditionSubtypeId
        {
            get { return this._conditionSubtypeId; }
            set { this._conditionSubtypeId = value; }
        }

        /// <summary>
        /// Sets the ConditionSubtypeId property.
        /// </summary>
        /// <param name="conditionSubtypeId">ConditionSubtypeId property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithConditionSubtypeId(string conditionSubtypeId)
        {
            this._conditionSubtypeId = conditionSubtypeId;
            return this;
        }

        /// <summary>
        /// Checks if ConditionSubtypeId property is set.
        /// </summary>
        /// <returns>true if ConditionSubtypeId property is set.</returns>
        public bool IsSetConditionSubtypeId()
        {
            return this._conditionSubtypeId != null;
        }

        /// <summary>
        /// Gets and sets the ScheduledDeliveryStartDate property.
        /// </summary>
        public string ScheduledDeliveryStartDate
        {
            get { return this._scheduledDeliveryStartDate; }
            set { this._scheduledDeliveryStartDate = value; }
        }

        /// <summary>
        /// Sets the ScheduledDeliveryStartDate property.
        /// </summary>
        /// <param name="scheduledDeliveryStartDate">ScheduledDeliveryStartDate property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithScheduledDeliveryStartDate(string scheduledDeliveryStartDate)
        {
            this._scheduledDeliveryStartDate = scheduledDeliveryStartDate;
            return this;
        }

        /// <summary>
        /// Checks if ScheduledDeliveryStartDate property is set.
        /// </summary>
        /// <returns>true if ScheduledDeliveryStartDate property is set.</returns>
        public bool IsSetScheduledDeliveryStartDate()
        {
            return this._scheduledDeliveryStartDate != null;
        }

        /// <summary>
        /// Gets and sets the ScheduledDeliveryEndDate property.
        /// </summary>
        public string ScheduledDeliveryEndDate
        {
            get { return this._scheduledDeliveryEndDate; }
            set { this._scheduledDeliveryEndDate = value; }
        }

        /// <summary>
        /// Sets the ScheduledDeliveryEndDate property.
        /// </summary>
        /// <param name="scheduledDeliveryEndDate">ScheduledDeliveryEndDate property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithScheduledDeliveryEndDate(string scheduledDeliveryEndDate)
        {
            this._scheduledDeliveryEndDate = scheduledDeliveryEndDate;
            return this;
        }

        /// <summary>
        /// Checks if ScheduledDeliveryEndDate property is set.
        /// </summary>
        /// <returns>true if ScheduledDeliveryEndDate property is set.</returns>
        public bool IsSetScheduledDeliveryEndDate()
        {
            return this._scheduledDeliveryEndDate != null;
        }

        /// <summary>
        /// Gets and sets the PriceDesignation property.
        /// </summary>
        public string PriceDesignation
        {
            get { return this._priceDesignation; }
            set { this._priceDesignation = value; }
        }

        /// <summary>
        /// Sets the PriceDesignation property.
        /// </summary>
        /// <param name="priceDesignation">PriceDesignation property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithPriceDesignation(string priceDesignation)
        {
            this._priceDesignation = priceDesignation;
            return this;
        }

        /// <summary>
        /// Checks if PriceDesignation property is set.
        /// </summary>
        /// <returns>true if PriceDesignation property is set.</returns>
        public bool IsSetPriceDesignation()
        {
            return this._priceDesignation != null;
        }

        /// <summary>
        /// Gets and sets the BuyerCustomizedInfo property.
        /// </summary>
        public BuyerCustomizedInfoDetail BuyerCustomizedInfo
        {
            get { return this._buyerCustomizedInfo; }
            set { this._buyerCustomizedInfo = value; }
        }

        /// <summary>
        /// Sets the BuyerCustomizedInfo property.
        /// </summary>
        /// <param name="buyerCustomizedInfo">BuyerCustomizedInfo property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithBuyerCustomizedInfo(BuyerCustomizedInfoDetail buyerCustomizedInfo)
        {
            this._buyerCustomizedInfo = buyerCustomizedInfo;
            return this;
        }

        /// <summary>
        /// Checks if BuyerCustomizedInfo property is set.
        /// </summary>
        /// <returns>true if BuyerCustomizedInfo property is set.</returns>
        public bool IsSetBuyerCustomizedInfo()
        {
            return this._buyerCustomizedInfo != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _asin = reader.Read<string>("ASIN");
            _sellerSKU = reader.Read<string>("SellerSKU");
            _orderItemId = reader.Read<string>("OrderItemId");
            _title = reader.Read<string>("Title");
            _quantityOrdered = reader.Read<decimal>("QuantityOrdered");
            _quantityShipped = reader.Read<decimal?>("QuantityShipped");
            _pointsGranted = reader.Read<PointsGrantedDetail>("PointsGranted");
            _itemPrice = reader.Read<Money>("ItemPrice");
            _shippingPrice = reader.Read<Money>("ShippingPrice");
            _giftWrapPrice = reader.Read<Money>("GiftWrapPrice");
            _itemTax = reader.Read<Money>("ItemTax");
            _shippingTax = reader.Read<Money>("ShippingTax");
            _giftWrapTax = reader.Read<Money>("GiftWrapTax");
            _shippingDiscount = reader.Read<Money>("ShippingDiscount");
            _promotionDiscount = reader.Read<Money>("PromotionDiscount");
            _promotionIds = reader.ReadList<string>("PromotionIds", "PromotionId");
            _codFee = reader.Read<Money>("CODFee");
            _codFeeDiscount = reader.Read<Money>("CODFeeDiscount");
            _giftMessageText = reader.Read<string>("GiftMessageText");
            _giftWrapLevel = reader.Read<string>("GiftWrapLevel");
            _invoiceData = reader.Read<InvoiceData>("InvoiceData");
            _conditionNote = reader.Read<string>("ConditionNote");
            _conditionId = reader.Read<string>("ConditionId");
            _conditionSubtypeId = reader.Read<string>("ConditionSubtypeId");
            _scheduledDeliveryStartDate = reader.Read<string>("ScheduledDeliveryStartDate");
            _scheduledDeliveryEndDate = reader.Read<string>("ScheduledDeliveryEndDate");
            _priceDesignation = reader.Read<string>("PriceDesignation");
            _buyerCustomizedInfo = reader.Read<BuyerCustomizedInfoDetail>("BuyerCustomizedInfo");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ASIN", _asin);
            writer.Write("SellerSKU", _sellerSKU);
            writer.Write("OrderItemId", _orderItemId);
            writer.Write("Title", _title);
            writer.Write("QuantityOrdered", _quantityOrdered);
            writer.Write("QuantityShipped", _quantityShipped);
            writer.Write("PointsGranted", _pointsGranted);
            writer.Write("ItemPrice", _itemPrice);
            writer.Write("ShippingPrice", _shippingPrice);
            writer.Write("GiftWrapPrice", _giftWrapPrice);
            writer.Write("ItemTax", _itemTax);
            writer.Write("ShippingTax", _shippingTax);
            writer.Write("GiftWrapTax", _giftWrapTax);
            writer.Write("ShippingDiscount", _shippingDiscount);
            writer.Write("PromotionDiscount", _promotionDiscount);
            writer.WriteList("PromotionIds", "PromotionId", _promotionIds);
            writer.Write("CODFee", _codFee);
            writer.Write("CODFeeDiscount", _codFeeDiscount);
            writer.Write("GiftMessageText", _giftMessageText);
            writer.Write("GiftWrapLevel", _giftWrapLevel);
            writer.Write("InvoiceData", _invoiceData);
            writer.Write("ConditionNote", _conditionNote);
            writer.Write("ConditionId", _conditionId);
            writer.Write("ConditionSubtypeId", _conditionSubtypeId);
            writer.Write("ScheduledDeliveryStartDate", _scheduledDeliveryStartDate);
            writer.Write("ScheduledDeliveryEndDate", _scheduledDeliveryEndDate);
            writer.Write("PriceDesignation", _priceDesignation);
            writer.Write("BuyerCustomizedInfo", _buyerCustomizedInfo);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "OrderItem", this);
        }

    public OrderItem (string asin,string orderItemId,decimal quantityOrdered) : base() {
        this._asin = asin;
        this._orderItemId = orderItemId;
        this._quantityOrdered = quantityOrdered;
    }

        public OrderItem() : base()
        {
        }
    }
}
