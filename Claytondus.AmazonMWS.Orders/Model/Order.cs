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
 * Order
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
    public class Order : AbstractMwsObject
    {

        private string _amazonOrderId;
        private string _sellerOrderId;
        private DateTime? _purchaseDate;
        private DateTime? _lastUpdateDate;
        private string _orderStatus;
        private string _fulfillmentChannel;
        private string _salesChannel;
        private string _orderChannel;
        private string _shipServiceLevel;
        private Address _shippingAddress;
        private Money _orderTotal;
        private decimal? _numberOfItemsShipped;
        private decimal? _numberOfItemsUnshipped;
        private List<PaymentExecutionDetailItem> _paymentExecutionDetail;
        private string _paymentMethod;
        private List<string> _paymentMethodDetails;
        private string _marketplaceId;
        private string _buyerEmail;
        private string _buyerName;
        private string _buyerCounty;
        private BuyerTaxInfo _buyerTaxInfo;
        private string _shipmentServiceLevelCategory;
        private bool? _shippedByAmazonTFM;
        private string _tfmShipmentStatus;
        private string _cbaDisplayableShippingLabel;
        private string _orderType;
        private DateTime? _earliestShipDate;
        private DateTime? _latestShipDate;
        private DateTime? _earliestDeliveryDate;
        private DateTime? _latestDeliveryDate;
        private bool? _isBusinessOrder;
        private string _purchaseOrderNumber;
        private bool? _isPrime;
        private bool? _isPremiumOrder;
        private string _replacedOrderId;
        private bool? _isReplacementOrder;

        /// <summary>
        /// Gets and sets the AmazonOrderId property.
        /// </summary>
        public string AmazonOrderId
        {
            get { return this._amazonOrderId; }
            set { this._amazonOrderId = value; }
        }

        /// <summary>
        /// Sets the AmazonOrderId property.
        /// </summary>
        /// <param name="amazonOrderId">AmazonOrderId property.</param>
        /// <returns>this instance.</returns>
        public Order WithAmazonOrderId(string amazonOrderId)
        {
            this._amazonOrderId = amazonOrderId;
            return this;
        }

        /// <summary>
        /// Checks if AmazonOrderId property is set.
        /// </summary>
        /// <returns>true if AmazonOrderId property is set.</returns>
        public bool IsSetAmazonOrderId()
        {
            return this._amazonOrderId != null;
        }

        /// <summary>
        /// Gets and sets the SellerOrderId property.
        /// </summary>
        public string SellerOrderId
        {
            get { return this._sellerOrderId; }
            set { this._sellerOrderId = value; }
        }

        /// <summary>
        /// Sets the SellerOrderId property.
        /// </summary>
        /// <param name="sellerOrderId">SellerOrderId property.</param>
        /// <returns>this instance.</returns>
        public Order WithSellerOrderId(string sellerOrderId)
        {
            this._sellerOrderId = sellerOrderId;
            return this;
        }

        /// <summary>
        /// Checks if SellerOrderId property is set.
        /// </summary>
        /// <returns>true if SellerOrderId property is set.</returns>
        public bool IsSetSellerOrderId()
        {
            return this._sellerOrderId != null;
        }

        /// <summary>
        /// Gets and sets the PurchaseDate property.
        /// </summary>
        public DateTime PurchaseDate
        {
            get { return this._purchaseDate.GetValueOrDefault(); }
            set { this._purchaseDate = value; }
        }

        /// <summary>
        /// Sets the PurchaseDate property.
        /// </summary>
        /// <param name="purchaseDate">PurchaseDate property.</param>
        /// <returns>this instance.</returns>
        public Order WithPurchaseDate(DateTime purchaseDate)
        {
            this._purchaseDate = purchaseDate;
            return this;
        }

        /// <summary>
        /// Checks if PurchaseDate property is set.
        /// </summary>
        /// <returns>true if PurchaseDate property is set.</returns>
        public bool IsSetPurchaseDate()
        {
            return this._purchaseDate != null;
        }

        /// <summary>
        /// Gets and sets the LastUpdateDate property.
        /// </summary>
        public DateTime LastUpdateDate
        {
            get { return this._lastUpdateDate.GetValueOrDefault(); }
            set { this._lastUpdateDate = value; }
        }

        /// <summary>
        /// Sets the LastUpdateDate property.
        /// </summary>
        /// <param name="lastUpdateDate">LastUpdateDate property.</param>
        /// <returns>this instance.</returns>
        public Order WithLastUpdateDate(DateTime lastUpdateDate)
        {
            this._lastUpdateDate = lastUpdateDate;
            return this;
        }

        /// <summary>
        /// Checks if LastUpdateDate property is set.
        /// </summary>
        /// <returns>true if LastUpdateDate property is set.</returns>
        public bool IsSetLastUpdateDate()
        {
            return this._lastUpdateDate != null;
        }

        /// <summary>
        /// Gets and sets the OrderStatus property.
        /// </summary>
        public string OrderStatus
        {
            get { return this._orderStatus; }
            set { this._orderStatus = value; }
        }

        /// <summary>
        /// Sets the OrderStatus property.
        /// </summary>
        /// <param name="orderStatus">OrderStatus property.</param>
        /// <returns>this instance.</returns>
        public Order WithOrderStatus(string orderStatus)
        {
            this._orderStatus = orderStatus;
            return this;
        }

        /// <summary>
        /// Checks if OrderStatus property is set.
        /// </summary>
        /// <returns>true if OrderStatus property is set.</returns>
        public bool IsSetOrderStatus()
        {
            return this._orderStatus != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentChannel property.
        /// </summary>
        public string FulfillmentChannel
        {
            get { return this._fulfillmentChannel; }
            set { this._fulfillmentChannel = value; }
        }

        /// <summary>
        /// Sets the FulfillmentChannel property.
        /// </summary>
        /// <param name="fulfillmentChannel">FulfillmentChannel property.</param>
        /// <returns>this instance.</returns>
        public Order WithFulfillmentChannel(string fulfillmentChannel)
        {
            this._fulfillmentChannel = fulfillmentChannel;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentChannel property is set.
        /// </summary>
        /// <returns>true if FulfillmentChannel property is set.</returns>
        public bool IsSetFulfillmentChannel()
        {
            return this._fulfillmentChannel != null;
        }

        /// <summary>
        /// Gets and sets the SalesChannel property.
        /// </summary>
        public string SalesChannel
        {
            get { return this._salesChannel; }
            set { this._salesChannel = value; }
        }

        /// <summary>
        /// Sets the SalesChannel property.
        /// </summary>
        /// <param name="salesChannel">SalesChannel property.</param>
        /// <returns>this instance.</returns>
        public Order WithSalesChannel(string salesChannel)
        {
            this._salesChannel = salesChannel;
            return this;
        }

        /// <summary>
        /// Checks if SalesChannel property is set.
        /// </summary>
        /// <returns>true if SalesChannel property is set.</returns>
        public bool IsSetSalesChannel()
        {
            return this._salesChannel != null;
        }

        /// <summary>
        /// Gets and sets the OrderChannel property.
        /// </summary>
        public string OrderChannel
        {
            get { return this._orderChannel; }
            set { this._orderChannel = value; }
        }

        /// <summary>
        /// Sets the OrderChannel property.
        /// </summary>
        /// <param name="orderChannel">OrderChannel property.</param>
        /// <returns>this instance.</returns>
        public Order WithOrderChannel(string orderChannel)
        {
            this._orderChannel = orderChannel;
            return this;
        }

        /// <summary>
        /// Checks if OrderChannel property is set.
        /// </summary>
        /// <returns>true if OrderChannel property is set.</returns>
        public bool IsSetOrderChannel()
        {
            return this._orderChannel != null;
        }

        /// <summary>
        /// Gets and sets the ShipServiceLevel property.
        /// </summary>
        public string ShipServiceLevel
        {
            get { return this._shipServiceLevel; }
            set { this._shipServiceLevel = value; }
        }

        /// <summary>
        /// Sets the ShipServiceLevel property.
        /// </summary>
        /// <param name="shipServiceLevel">ShipServiceLevel property.</param>
        /// <returns>this instance.</returns>
        public Order WithShipServiceLevel(string shipServiceLevel)
        {
            this._shipServiceLevel = shipServiceLevel;
            return this;
        }

        /// <summary>
        /// Checks if ShipServiceLevel property is set.
        /// </summary>
        /// <returns>true if ShipServiceLevel property is set.</returns>
        public bool IsSetShipServiceLevel()
        {
            return this._shipServiceLevel != null;
        }

        /// <summary>
        /// Gets and sets the ShippingAddress property.
        /// </summary>
        public Address ShippingAddress
        {
            get { return this._shippingAddress; }
            set { this._shippingAddress = value; }
        }

        /// <summary>
        /// Sets the ShippingAddress property.
        /// </summary>
        /// <param name="shippingAddress">ShippingAddress property.</param>
        /// <returns>this instance.</returns>
        public Order WithShippingAddress(Address shippingAddress)
        {
            this._shippingAddress = shippingAddress;
            return this;
        }

        /// <summary>
        /// Checks if ShippingAddress property is set.
        /// </summary>
        /// <returns>true if ShippingAddress property is set.</returns>
        public bool IsSetShippingAddress()
        {
            return this._shippingAddress != null;
        }

        /// <summary>
        /// Gets and sets the OrderTotal property.
        /// </summary>
        public Money OrderTotal
        {
            get { return this._orderTotal; }
            set { this._orderTotal = value; }
        }

        /// <summary>
        /// Sets the OrderTotal property.
        /// </summary>
        /// <param name="orderTotal">OrderTotal property.</param>
        /// <returns>this instance.</returns>
        public Order WithOrderTotal(Money orderTotal)
        {
            this._orderTotal = orderTotal;
            return this;
        }

        /// <summary>
        /// Checks if OrderTotal property is set.
        /// </summary>
        /// <returns>true if OrderTotal property is set.</returns>
        public bool IsSetOrderTotal()
        {
            return this._orderTotal != null;
        }

        /// <summary>
        /// Gets and sets the NumberOfItemsShipped property.
        /// </summary>
        public decimal NumberOfItemsShipped
        {
            get { return this._numberOfItemsShipped.GetValueOrDefault(); }
            set { this._numberOfItemsShipped = value; }
        }

        /// <summary>
        /// Sets the NumberOfItemsShipped property.
        /// </summary>
        /// <param name="numberOfItemsShipped">NumberOfItemsShipped property.</param>
        /// <returns>this instance.</returns>
        public Order WithNumberOfItemsShipped(decimal numberOfItemsShipped)
        {
            this._numberOfItemsShipped = numberOfItemsShipped;
            return this;
        }

        /// <summary>
        /// Checks if NumberOfItemsShipped property is set.
        /// </summary>
        /// <returns>true if NumberOfItemsShipped property is set.</returns>
        public bool IsSetNumberOfItemsShipped()
        {
            return this._numberOfItemsShipped != null;
        }

        /// <summary>
        /// Gets and sets the NumberOfItemsUnshipped property.
        /// </summary>
        public decimal NumberOfItemsUnshipped
        {
            get { return this._numberOfItemsUnshipped.GetValueOrDefault(); }
            set { this._numberOfItemsUnshipped = value; }
        }

        /// <summary>
        /// Sets the NumberOfItemsUnshipped property.
        /// </summary>
        /// <param name="numberOfItemsUnshipped">NumberOfItemsUnshipped property.</param>
        /// <returns>this instance.</returns>
        public Order WithNumberOfItemsUnshipped(decimal numberOfItemsUnshipped)
        {
            this._numberOfItemsUnshipped = numberOfItemsUnshipped;
            return this;
        }

        /// <summary>
        /// Checks if NumberOfItemsUnshipped property is set.
        /// </summary>
        /// <returns>true if NumberOfItemsUnshipped property is set.</returns>
        public bool IsSetNumberOfItemsUnshipped()
        {
            return this._numberOfItemsUnshipped != null;
        }

        /// <summary>
        /// Gets and sets the PaymentExecutionDetail property.
        /// </summary>
        public List<PaymentExecutionDetailItem> PaymentExecutionDetail
        {
            get
            {
                if(this._paymentExecutionDetail == null)
                {
                    this._paymentExecutionDetail = new List<PaymentExecutionDetailItem>();
                }
                return this._paymentExecutionDetail;
            }
            set { this._paymentExecutionDetail = value; }
        }

        /// <summary>
        /// Sets the PaymentExecutionDetail property.
        /// </summary>
        /// <param name="paymentExecutionDetail">PaymentExecutionDetail property.</param>
        /// <returns>this instance.</returns>
        public Order WithPaymentExecutionDetail(PaymentExecutionDetailItem[] paymentExecutionDetail)
        {
            this._paymentExecutionDetail.AddRange(paymentExecutionDetail);
            return this;
        }

        /// <summary>
        /// Checks if PaymentExecutionDetail property is set.
        /// </summary>
        /// <returns>true if PaymentExecutionDetail property is set.</returns>
        public bool IsSetPaymentExecutionDetail()
        {
            return this.PaymentExecutionDetail.Count > 0;
        }

        /// <summary>
        /// Gets and sets the PaymentMethod property.
        /// </summary>
        public string PaymentMethod
        {
            get { return this._paymentMethod; }
            set { this._paymentMethod = value; }
        }

        /// <summary>
        /// Sets the PaymentMethod property.
        /// </summary>
        /// <param name="paymentMethod">PaymentMethod property.</param>
        /// <returns>this instance.</returns>
        public Order WithPaymentMethod(string paymentMethod)
        {
            this._paymentMethod = paymentMethod;
            return this;
        }

        /// <summary>
        /// Checks if PaymentMethod property is set.
        /// </summary>
        /// <returns>true if PaymentMethod property is set.</returns>
        public bool IsSetPaymentMethod()
        {
            return this._paymentMethod != null;
        }

        /// <summary>
        /// Gets and sets the PaymentMethodDetails property.
        /// </summary>
        public List<string> PaymentMethodDetails
        {
            get
            {
                if(this._paymentMethodDetails == null)
                {
                    this._paymentMethodDetails = new List<string>();
                }
                return this._paymentMethodDetails;
            }
            set { this._paymentMethodDetails = value; }
        }

        /// <summary>
        /// Sets the PaymentMethodDetails property.
        /// </summary>
        /// <param name="paymentMethodDetails">PaymentMethodDetails property.</param>
        /// <returns>this instance.</returns>
        public Order WithPaymentMethodDetails(string[] paymentMethodDetails)
        {
            this._paymentMethodDetails.AddRange(paymentMethodDetails);
            return this;
        }

        /// <summary>
        /// Checks if PaymentMethodDetails property is set.
        /// </summary>
        /// <returns>true if PaymentMethodDetails property is set.</returns>
        public bool IsSetPaymentMethodDetails()
        {
            return this.PaymentMethodDetails.Count > 0;
        }

        /// <summary>
        /// Gets and sets the MarketplaceId property.
        /// </summary>
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
        public Order WithMarketplaceId(string marketplaceId)
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
        /// Gets and sets the BuyerEmail property.
        /// </summary>
        public string BuyerEmail
        {
            get { return this._buyerEmail; }
            set { this._buyerEmail = value; }
        }

        /// <summary>
        /// Sets the BuyerEmail property.
        /// </summary>
        /// <param name="buyerEmail">BuyerEmail property.</param>
        /// <returns>this instance.</returns>
        public Order WithBuyerEmail(string buyerEmail)
        {
            this._buyerEmail = buyerEmail;
            return this;
        }

        /// <summary>
        /// Checks if BuyerEmail property is set.
        /// </summary>
        /// <returns>true if BuyerEmail property is set.</returns>
        public bool IsSetBuyerEmail()
        {
            return this._buyerEmail != null;
        }

        /// <summary>
        /// Gets and sets the BuyerName property.
        /// </summary>
        public string BuyerName
        {
            get { return this._buyerName; }
            set { this._buyerName = value; }
        }

        /// <summary>
        /// Sets the BuyerName property.
        /// </summary>
        /// <param name="buyerName">BuyerName property.</param>
        /// <returns>this instance.</returns>
        public Order WithBuyerName(string buyerName)
        {
            this._buyerName = buyerName;
            return this;
        }

        /// <summary>
        /// Checks if BuyerName property is set.
        /// </summary>
        /// <returns>true if BuyerName property is set.</returns>
        public bool IsSetBuyerName()
        {
            return this._buyerName != null;
        }

        /// <summary>
        /// Gets and sets the BuyerCounty property.
        /// </summary>
        public string BuyerCounty
        {
            get { return this._buyerCounty; }
            set { this._buyerCounty = value; }
        }

        /// <summary>
        /// Sets the BuyerCounty property.
        /// </summary>
        /// <param name="buyerCounty">BuyerCounty property.</param>
        /// <returns>this instance.</returns>
        public Order WithBuyerCounty(string buyerCounty)
        {
            this._buyerCounty = buyerCounty;
            return this;
        }

        /// <summary>
        /// Checks if BuyerCounty property is set.
        /// </summary>
        /// <returns>true if BuyerCounty property is set.</returns>
        public bool IsSetBuyerCounty()
        {
            return this._buyerCounty != null;
        }

        /// <summary>
        /// Gets and sets the BuyerTaxInfo property.
        /// </summary>
        public BuyerTaxInfo BuyerTaxInfo
        {
            get { return this._buyerTaxInfo; }
            set { this._buyerTaxInfo = value; }
        }

        /// <summary>
        /// Sets the BuyerTaxInfo property.
        /// </summary>
        /// <param name="buyerTaxInfo">BuyerTaxInfo property.</param>
        /// <returns>this instance.</returns>
        public Order WithBuyerTaxInfo(BuyerTaxInfo buyerTaxInfo)
        {
            this._buyerTaxInfo = buyerTaxInfo;
            return this;
        }

        /// <summary>
        /// Checks if BuyerTaxInfo property is set.
        /// </summary>
        /// <returns>true if BuyerTaxInfo property is set.</returns>
        public bool IsSetBuyerTaxInfo()
        {
            return this._buyerTaxInfo != null;
        }

        /// <summary>
        /// Gets and sets the ShipmentServiceLevelCategory property.
        /// </summary>
        public string ShipmentServiceLevelCategory
        {
            get { return this._shipmentServiceLevelCategory; }
            set { this._shipmentServiceLevelCategory = value; }
        }

        /// <summary>
        /// Sets the ShipmentServiceLevelCategory property.
        /// </summary>
        /// <param name="shipmentServiceLevelCategory">ShipmentServiceLevelCategory property.</param>
        /// <returns>this instance.</returns>
        public Order WithShipmentServiceLevelCategory(string shipmentServiceLevelCategory)
        {
            this._shipmentServiceLevelCategory = shipmentServiceLevelCategory;
            return this;
        }

        /// <summary>
        /// Checks if ShipmentServiceLevelCategory property is set.
        /// </summary>
        /// <returns>true if ShipmentServiceLevelCategory property is set.</returns>
        public bool IsSetShipmentServiceLevelCategory()
        {
            return this._shipmentServiceLevelCategory != null;
        }

        /// <summary>
        /// Gets and sets the ShippedByAmazonTFM property.
        /// </summary>
        public bool ShippedByAmazonTFM
        {
            get { return this._shippedByAmazonTFM.GetValueOrDefault(); }
            set { this._shippedByAmazonTFM = value; }
        }

        /// <summary>
        /// Sets the ShippedByAmazonTFM property.
        /// </summary>
        /// <param name="shippedByAmazonTFM">ShippedByAmazonTFM property.</param>
        /// <returns>this instance.</returns>
        public Order WithShippedByAmazonTFM(bool shippedByAmazonTFM)
        {
            this._shippedByAmazonTFM = shippedByAmazonTFM;
            return this;
        }

        /// <summary>
        /// Checks if ShippedByAmazonTFM property is set.
        /// </summary>
        /// <returns>true if ShippedByAmazonTFM property is set.</returns>
        public bool IsSetShippedByAmazonTFM()
        {
            return this._shippedByAmazonTFM != null;
        }

        /// <summary>
        /// Gets and sets the TFMShipmentStatus property.
        /// </summary>
        public string TFMShipmentStatus
        {
            get { return this._tfmShipmentStatus; }
            set { this._tfmShipmentStatus = value; }
        }

        /// <summary>
        /// Sets the TFMShipmentStatus property.
        /// </summary>
        /// <param name="tfmShipmentStatus">TFMShipmentStatus property.</param>
        /// <returns>this instance.</returns>
        public Order WithTFMShipmentStatus(string tfmShipmentStatus)
        {
            this._tfmShipmentStatus = tfmShipmentStatus;
            return this;
        }

        /// <summary>
        /// Checks if TFMShipmentStatus property is set.
        /// </summary>
        /// <returns>true if TFMShipmentStatus property is set.</returns>
        public bool IsSetTFMShipmentStatus()
        {
            return this._tfmShipmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the CbaDisplayableShippingLabel property.
        /// </summary>
        public string CbaDisplayableShippingLabel
        {
            get { return this._cbaDisplayableShippingLabel; }
            set { this._cbaDisplayableShippingLabel = value; }
        }

        /// <summary>
        /// Sets the CbaDisplayableShippingLabel property.
        /// </summary>
        /// <param name="cbaDisplayableShippingLabel">CbaDisplayableShippingLabel property.</param>
        /// <returns>this instance.</returns>
        public Order WithCbaDisplayableShippingLabel(string cbaDisplayableShippingLabel)
        {
            this._cbaDisplayableShippingLabel = cbaDisplayableShippingLabel;
            return this;
        }

        /// <summary>
        /// Checks if CbaDisplayableShippingLabel property is set.
        /// </summary>
        /// <returns>true if CbaDisplayableShippingLabel property is set.</returns>
        public bool IsSetCbaDisplayableShippingLabel()
        {
            return this._cbaDisplayableShippingLabel != null;
        }

        /// <summary>
        /// Gets and sets the OrderType property.
        /// </summary>
        public string OrderType
        {
            get { return this._orderType; }
            set { this._orderType = value; }
        }

        /// <summary>
        /// Sets the OrderType property.
        /// </summary>
        /// <param name="orderType">OrderType property.</param>
        /// <returns>this instance.</returns>
        public Order WithOrderType(string orderType)
        {
            this._orderType = orderType;
            return this;
        }

        /// <summary>
        /// Checks if OrderType property is set.
        /// </summary>
        /// <returns>true if OrderType property is set.</returns>
        public bool IsSetOrderType()
        {
            return this._orderType != null;
        }

        /// <summary>
        /// Gets and sets the EarliestShipDate property.
        /// </summary>
        public DateTime EarliestShipDate
        {
            get { return this._earliestShipDate.GetValueOrDefault(); }
            set { this._earliestShipDate = value; }
        }

        /// <summary>
        /// Sets the EarliestShipDate property.
        /// </summary>
        /// <param name="earliestShipDate">EarliestShipDate property.</param>
        /// <returns>this instance.</returns>
        public Order WithEarliestShipDate(DateTime earliestShipDate)
        {
            this._earliestShipDate = earliestShipDate;
            return this;
        }

        /// <summary>
        /// Checks if EarliestShipDate property is set.
        /// </summary>
        /// <returns>true if EarliestShipDate property is set.</returns>
        public bool IsSetEarliestShipDate()
        {
            return this._earliestShipDate != null;
        }

        /// <summary>
        /// Gets and sets the LatestShipDate property.
        /// </summary>
        public DateTime LatestShipDate
        {
            get { return this._latestShipDate.GetValueOrDefault(); }
            set { this._latestShipDate = value; }
        }

        /// <summary>
        /// Sets the LatestShipDate property.
        /// </summary>
        /// <param name="latestShipDate">LatestShipDate property.</param>
        /// <returns>this instance.</returns>
        public Order WithLatestShipDate(DateTime latestShipDate)
        {
            this._latestShipDate = latestShipDate;
            return this;
        }

        /// <summary>
        /// Checks if LatestShipDate property is set.
        /// </summary>
        /// <returns>true if LatestShipDate property is set.</returns>
        public bool IsSetLatestShipDate()
        {
            return this._latestShipDate != null;
        }

        /// <summary>
        /// Gets and sets the EarliestDeliveryDate property.
        /// </summary>
        public DateTime EarliestDeliveryDate
        {
            get { return this._earliestDeliveryDate.GetValueOrDefault(); }
            set { this._earliestDeliveryDate = value; }
        }

        /// <summary>
        /// Sets the EarliestDeliveryDate property.
        /// </summary>
        /// <param name="earliestDeliveryDate">EarliestDeliveryDate property.</param>
        /// <returns>this instance.</returns>
        public Order WithEarliestDeliveryDate(DateTime earliestDeliveryDate)
        {
            this._earliestDeliveryDate = earliestDeliveryDate;
            return this;
        }

        /// <summary>
        /// Checks if EarliestDeliveryDate property is set.
        /// </summary>
        /// <returns>true if EarliestDeliveryDate property is set.</returns>
        public bool IsSetEarliestDeliveryDate()
        {
            return this._earliestDeliveryDate != null;
        }

        /// <summary>
        /// Gets and sets the LatestDeliveryDate property.
        /// </summary>
        public DateTime LatestDeliveryDate
        {
            get { return this._latestDeliveryDate.GetValueOrDefault(); }
            set { this._latestDeliveryDate = value; }
        }

        /// <summary>
        /// Sets the LatestDeliveryDate property.
        /// </summary>
        /// <param name="latestDeliveryDate">LatestDeliveryDate property.</param>
        /// <returns>this instance.</returns>
        public Order WithLatestDeliveryDate(DateTime latestDeliveryDate)
        {
            this._latestDeliveryDate = latestDeliveryDate;
            return this;
        }

        /// <summary>
        /// Checks if LatestDeliveryDate property is set.
        /// </summary>
        /// <returns>true if LatestDeliveryDate property is set.</returns>
        public bool IsSetLatestDeliveryDate()
        {
            return this._latestDeliveryDate != null;
        }

        /// <summary>
        /// Gets and sets the IsBusinessOrder property.
        /// </summary>
        public bool IsBusinessOrder
        {
            get { return this._isBusinessOrder.GetValueOrDefault(); }
            set { this._isBusinessOrder = value; }
        }

        /// <summary>
        /// Sets the IsBusinessOrder property.
        /// </summary>
        /// <param name="isBusinessOrder">IsBusinessOrder property.</param>
        /// <returns>this instance.</returns>
        public Order WithIsBusinessOrder(bool isBusinessOrder)
        {
            this._isBusinessOrder = isBusinessOrder;
            return this;
        }

        /// <summary>
        /// Checks if IsBusinessOrder property is set.
        /// </summary>
        /// <returns>true if IsBusinessOrder property is set.</returns>
        public bool IsSetIsBusinessOrder()
        {
            return this._isBusinessOrder != null;
        }

        /// <summary>
        /// Gets and sets the PurchaseOrderNumber property.
        /// </summary>
        public string PurchaseOrderNumber
        {
            get { return this._purchaseOrderNumber; }
            set { this._purchaseOrderNumber = value; }
        }

        /// <summary>
        /// Sets the PurchaseOrderNumber property.
        /// </summary>
        /// <param name="purchaseOrderNumber">PurchaseOrderNumber property.</param>
        /// <returns>this instance.</returns>
        public Order WithPurchaseOrderNumber(string purchaseOrderNumber)
        {
            this._purchaseOrderNumber = purchaseOrderNumber;
            return this;
        }

        /// <summary>
        /// Checks if PurchaseOrderNumber property is set.
        /// </summary>
        /// <returns>true if PurchaseOrderNumber property is set.</returns>
        public bool IsSetPurchaseOrderNumber()
        {
            return this._purchaseOrderNumber != null;
        }

        /// <summary>
        /// Gets and sets the IsPrime property.
        /// </summary>
        public bool IsPrime
        {
            get { return this._isPrime.GetValueOrDefault(); }
            set { this._isPrime = value; }
        }

        /// <summary>
        /// Sets the IsPrime property.
        /// </summary>
        /// <param name="isPrime">IsPrime property.</param>
        /// <returns>this instance.</returns>
        public Order WithIsPrime(bool isPrime)
        {
            this._isPrime = isPrime;
            return this;
        }

        /// <summary>
        /// Checks if IsPrime property is set.
        /// </summary>
        /// <returns>true if IsPrime property is set.</returns>
        public bool IsSetIsPrime()
        {
            return this._isPrime != null;
        }

        /// <summary>
        /// Gets and sets the IsPremiumOrder property.
        /// </summary>
        public bool IsPremiumOrder
        {
            get { return this._isPremiumOrder.GetValueOrDefault(); }
            set { this._isPremiumOrder = value; }
        }

        /// <summary>
        /// Sets the IsPremiumOrder property.
        /// </summary>
        /// <param name="isPremiumOrder">IsPremiumOrder property.</param>
        /// <returns>this instance.</returns>
        public Order WithIsPremiumOrder(bool isPremiumOrder)
        {
            this._isPremiumOrder = isPremiumOrder;
            return this;
        }

        /// <summary>
        /// Checks if IsPremiumOrder property is set.
        /// </summary>
        /// <returns>true if IsPremiumOrder property is set.</returns>
        public bool IsSetIsPremiumOrder()
        {
            return this._isPremiumOrder != null;
        }

        /// <summary>
        /// Gets and sets the ReplacedOrderId property.
        /// </summary>
        public string ReplacedOrderId
        {
            get { return this._replacedOrderId; }
            set { this._replacedOrderId = value; }
        }

        /// <summary>
        /// Sets the ReplacedOrderId property.
        /// </summary>
        /// <param name="replacedOrderId">ReplacedOrderId property.</param>
        /// <returns>this instance.</returns>
        public Order WithReplacedOrderId(string replacedOrderId)
        {
            this._replacedOrderId = replacedOrderId;
            return this;
        }

        /// <summary>
        /// Checks if ReplacedOrderId property is set.
        /// </summary>
        /// <returns>true if ReplacedOrderId property is set.</returns>
        public bool IsSetReplacedOrderId()
        {
            return this._replacedOrderId != null;
        }

        /// <summary>
        /// Gets and sets the IsReplacementOrder property.
        /// </summary>
        public bool IsReplacementOrder
        {
            get { return this._isReplacementOrder.GetValueOrDefault(); }
            set { this._isReplacementOrder = value; }
        }

        /// <summary>
        /// Sets the IsReplacementOrder property.
        /// </summary>
        /// <param name="isReplacementOrder">IsReplacementOrder property.</param>
        /// <returns>this instance.</returns>
        public Order WithIsReplacementOrder(bool isReplacementOrder)
        {
            this._isReplacementOrder = isReplacementOrder;
            return this;
        }

        /// <summary>
        /// Checks if IsReplacementOrder property is set.
        /// </summary>
        /// <returns>true if IsReplacementOrder property is set.</returns>
        public bool IsSetIsReplacementOrder()
        {
            return this._isReplacementOrder != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _amazonOrderId = reader.Read<string>("AmazonOrderId");
            _sellerOrderId = reader.Read<string>("SellerOrderId");
            _purchaseDate = reader.Read<DateTime?>("PurchaseDate");
            _lastUpdateDate = reader.Read<DateTime?>("LastUpdateDate");
            _orderStatus = reader.Read<string>("OrderStatus");
            _fulfillmentChannel = reader.Read<string>("FulfillmentChannel");
            _salesChannel = reader.Read<string>("SalesChannel");
            _orderChannel = reader.Read<string>("OrderChannel");
            _shipServiceLevel = reader.Read<string>("ShipServiceLevel");
            _shippingAddress = reader.Read<Address>("ShippingAddress");
            _orderTotal = reader.Read<Money>("OrderTotal");
            _numberOfItemsShipped = reader.Read<decimal?>("NumberOfItemsShipped");
            _numberOfItemsUnshipped = reader.Read<decimal?>("NumberOfItemsUnshipped");
            _paymentExecutionDetail = reader.ReadList<PaymentExecutionDetailItem>("PaymentExecutionDetail", "PaymentExecutionDetailItem");
            _paymentMethod = reader.Read<string>("PaymentMethod");
            _paymentMethodDetails = reader.ReadList<string>("PaymentMethodDetails", "PaymentMethodDetail");
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _buyerEmail = reader.Read<string>("BuyerEmail");
            _buyerName = reader.Read<string>("BuyerName");
            _buyerCounty = reader.Read<string>("BuyerCounty");
            _buyerTaxInfo = reader.Read<BuyerTaxInfo>("BuyerTaxInfo");
            _shipmentServiceLevelCategory = reader.Read<string>("ShipmentServiceLevelCategory");
            _shippedByAmazonTFM = reader.Read<bool?>("ShippedByAmazonTFM");
            _tfmShipmentStatus = reader.Read<string>("TFMShipmentStatus");
            _cbaDisplayableShippingLabel = reader.Read<string>("CbaDisplayableShippingLabel");
            _orderType = reader.Read<string>("OrderType");
            _earliestShipDate = reader.Read<DateTime?>("EarliestShipDate");
            _latestShipDate = reader.Read<DateTime?>("LatestShipDate");
            _earliestDeliveryDate = reader.Read<DateTime?>("EarliestDeliveryDate");
            _latestDeliveryDate = reader.Read<DateTime?>("LatestDeliveryDate");
            _isBusinessOrder = reader.Read<bool?>("IsBusinessOrder");
            _purchaseOrderNumber = reader.Read<string>("PurchaseOrderNumber");
            _isPrime = reader.Read<bool?>("IsPrime");
            _isPremiumOrder = reader.Read<bool?>("IsPremiumOrder");
            _replacedOrderId = reader.Read<string>("ReplacedOrderId");
            _isReplacementOrder = reader.Read<bool?>("IsReplacementOrder");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("AmazonOrderId", _amazonOrderId);
            writer.Write("SellerOrderId", _sellerOrderId);
            writer.Write("PurchaseDate", _purchaseDate);
            writer.Write("LastUpdateDate", _lastUpdateDate);
            writer.Write("OrderStatus", _orderStatus);
            writer.Write("FulfillmentChannel", _fulfillmentChannel);
            writer.Write("SalesChannel", _salesChannel);
            writer.Write("OrderChannel", _orderChannel);
            writer.Write("ShipServiceLevel", _shipServiceLevel);
            writer.Write("ShippingAddress", _shippingAddress);
            writer.Write("OrderTotal", _orderTotal);
            writer.Write("NumberOfItemsShipped", _numberOfItemsShipped);
            writer.Write("NumberOfItemsUnshipped", _numberOfItemsUnshipped);
            writer.WriteList("PaymentExecutionDetail", "PaymentExecutionDetailItem", _paymentExecutionDetail);
            writer.Write("PaymentMethod", _paymentMethod);
            writer.WriteList("PaymentMethodDetails", "PaymentMethodDetail", _paymentMethodDetails);
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("BuyerEmail", _buyerEmail);
            writer.Write("BuyerName", _buyerName);
            writer.Write("BuyerCounty", _buyerCounty);
            writer.Write("BuyerTaxInfo", _buyerTaxInfo);
            writer.Write("ShipmentServiceLevelCategory", _shipmentServiceLevelCategory);
            writer.Write("ShippedByAmazonTFM", _shippedByAmazonTFM);
            writer.Write("TFMShipmentStatus", _tfmShipmentStatus);
            writer.Write("CbaDisplayableShippingLabel", _cbaDisplayableShippingLabel);
            writer.Write("OrderType", _orderType);
            writer.Write("EarliestShipDate", _earliestShipDate);
            writer.Write("LatestShipDate", _latestShipDate);
            writer.Write("EarliestDeliveryDate", _earliestDeliveryDate);
            writer.Write("LatestDeliveryDate", _latestDeliveryDate);
            writer.Write("IsBusinessOrder", _isBusinessOrder);
            writer.Write("PurchaseOrderNumber", _purchaseOrderNumber);
            writer.Write("IsPrime", _isPrime);
            writer.Write("IsPremiumOrder", _isPremiumOrder);
            writer.Write("ReplacedOrderId", _replacedOrderId);
            writer.Write("IsReplacementOrder", _isReplacementOrder);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "Order", this);
        }

    public Order (string amazonOrderId,DateTime? purchaseDate,DateTime? lastUpdateDate,string orderStatus) : base() {
        this._amazonOrderId = amazonOrderId;
        this._purchaseDate = purchaseDate;
        this._lastUpdateDate = lastUpdateDate;
        this._orderStatus = orderStatus;
    }

        public Order() : base()
        {
        }
    }
}
