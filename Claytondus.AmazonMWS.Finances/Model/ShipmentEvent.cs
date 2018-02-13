/*******************************************************************************
 * Copyright 2009-2018 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Shipment Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class ShipmentEvent : AbstractMwsObject
    {

        private string _amazonOrderId;
        private string _sellerOrderId;
        private string _marketplaceName;
        private List<ChargeComponent> _orderChargeList;
        private List<ChargeComponent> _orderChargeAdjustmentList;
        private List<FeeComponent> _shipmentFeeList;
        private List<FeeComponent> _shipmentFeeAdjustmentList;
        private List<FeeComponent> _orderFeeList;
        private List<FeeComponent> _orderFeeAdjustmentList;
        private List<DirectPayment> _directPaymentList;
        private DateTime? _postedDate;
        private List<ShipmentItem> _shipmentItemList;
        private List<ShipmentItem> _shipmentItemAdjustmentList;

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
        public ShipmentEvent WithAmazonOrderId(string amazonOrderId)
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
        public ShipmentEvent WithSellerOrderId(string sellerOrderId)
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
        /// Gets and sets the MarketplaceName property.
        /// </summary>
        public string MarketplaceName
        {
            get { return this._marketplaceName; }
            set { this._marketplaceName = value; }
        }

        /// <summary>
        /// Sets the MarketplaceName property.
        /// </summary>
        /// <param name="marketplaceName">MarketplaceName property.</param>
        /// <returns>this instance.</returns>
        public ShipmentEvent WithMarketplaceName(string marketplaceName)
        {
            this._marketplaceName = marketplaceName;
            return this;
        }

        /// <summary>
        /// Checks if MarketplaceName property is set.
        /// </summary>
        /// <returns>true if MarketplaceName property is set.</returns>
        public bool IsSetMarketplaceName()
        {
            return this._marketplaceName != null;
        }

        /// <summary>
        /// Gets and sets the OrderChargeList property.
        /// </summary>
        public List<ChargeComponent> OrderChargeList
        {
            get
            {
                if(this._orderChargeList == null)
                {
                    this._orderChargeList = new List<ChargeComponent>();
                }
                return this._orderChargeList;
            }
            set { this._orderChargeList = value; }
        }

        /// <summary>
        /// Sets the OrderChargeList property.
        /// </summary>
        /// <param name="orderChargeList">OrderChargeList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentEvent WithOrderChargeList(ChargeComponent[] orderChargeList)
        {
            this._orderChargeList.AddRange(orderChargeList);
            return this;
        }

        /// <summary>
        /// Checks if OrderChargeList property is set.
        /// </summary>
        /// <returns>true if OrderChargeList property is set.</returns>
        public bool IsSetOrderChargeList()
        {
            return this.OrderChargeList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the OrderChargeAdjustmentList property.
        /// </summary>
        public List<ChargeComponent> OrderChargeAdjustmentList
        {
            get
            {
                if(this._orderChargeAdjustmentList == null)
                {
                    this._orderChargeAdjustmentList = new List<ChargeComponent>();
                }
                return this._orderChargeAdjustmentList;
            }
            set { this._orderChargeAdjustmentList = value; }
        }

        /// <summary>
        /// Sets the OrderChargeAdjustmentList property.
        /// </summary>
        /// <param name="orderChargeAdjustmentList">OrderChargeAdjustmentList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentEvent WithOrderChargeAdjustmentList(ChargeComponent[] orderChargeAdjustmentList)
        {
            this._orderChargeAdjustmentList.AddRange(orderChargeAdjustmentList);
            return this;
        }

        /// <summary>
        /// Checks if OrderChargeAdjustmentList property is set.
        /// </summary>
        /// <returns>true if OrderChargeAdjustmentList property is set.</returns>
        public bool IsSetOrderChargeAdjustmentList()
        {
            return this.OrderChargeAdjustmentList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the ShipmentFeeList property.
        /// </summary>
        public List<FeeComponent> ShipmentFeeList
        {
            get
            {
                if(this._shipmentFeeList == null)
                {
                    this._shipmentFeeList = new List<FeeComponent>();
                }
                return this._shipmentFeeList;
            }
            set { this._shipmentFeeList = value; }
        }

        /// <summary>
        /// Sets the ShipmentFeeList property.
        /// </summary>
        /// <param name="shipmentFeeList">ShipmentFeeList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentEvent WithShipmentFeeList(FeeComponent[] shipmentFeeList)
        {
            this._shipmentFeeList.AddRange(shipmentFeeList);
            return this;
        }

        /// <summary>
        /// Checks if ShipmentFeeList property is set.
        /// </summary>
        /// <returns>true if ShipmentFeeList property is set.</returns>
        public bool IsSetShipmentFeeList()
        {
            return this.ShipmentFeeList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the ShipmentFeeAdjustmentList property.
        /// </summary>
        public List<FeeComponent> ShipmentFeeAdjustmentList
        {
            get
            {
                if(this._shipmentFeeAdjustmentList == null)
                {
                    this._shipmentFeeAdjustmentList = new List<FeeComponent>();
                }
                return this._shipmentFeeAdjustmentList;
            }
            set { this._shipmentFeeAdjustmentList = value; }
        }

        /// <summary>
        /// Sets the ShipmentFeeAdjustmentList property.
        /// </summary>
        /// <param name="shipmentFeeAdjustmentList">ShipmentFeeAdjustmentList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentEvent WithShipmentFeeAdjustmentList(FeeComponent[] shipmentFeeAdjustmentList)
        {
            this._shipmentFeeAdjustmentList.AddRange(shipmentFeeAdjustmentList);
            return this;
        }

        /// <summary>
        /// Checks if ShipmentFeeAdjustmentList property is set.
        /// </summary>
        /// <returns>true if ShipmentFeeAdjustmentList property is set.</returns>
        public bool IsSetShipmentFeeAdjustmentList()
        {
            return this.ShipmentFeeAdjustmentList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the OrderFeeList property.
        /// </summary>
        public List<FeeComponent> OrderFeeList
        {
            get
            {
                if(this._orderFeeList == null)
                {
                    this._orderFeeList = new List<FeeComponent>();
                }
                return this._orderFeeList;
            }
            set { this._orderFeeList = value; }
        }

        /// <summary>
        /// Sets the OrderFeeList property.
        /// </summary>
        /// <param name="orderFeeList">OrderFeeList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentEvent WithOrderFeeList(FeeComponent[] orderFeeList)
        {
            this._orderFeeList.AddRange(orderFeeList);
            return this;
        }

        /// <summary>
        /// Checks if OrderFeeList property is set.
        /// </summary>
        /// <returns>true if OrderFeeList property is set.</returns>
        public bool IsSetOrderFeeList()
        {
            return this.OrderFeeList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the OrderFeeAdjustmentList property.
        /// </summary>
        public List<FeeComponent> OrderFeeAdjustmentList
        {
            get
            {
                if(this._orderFeeAdjustmentList == null)
                {
                    this._orderFeeAdjustmentList = new List<FeeComponent>();
                }
                return this._orderFeeAdjustmentList;
            }
            set { this._orderFeeAdjustmentList = value; }
        }

        /// <summary>
        /// Sets the OrderFeeAdjustmentList property.
        /// </summary>
        /// <param name="orderFeeAdjustmentList">OrderFeeAdjustmentList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentEvent WithOrderFeeAdjustmentList(FeeComponent[] orderFeeAdjustmentList)
        {
            this._orderFeeAdjustmentList.AddRange(orderFeeAdjustmentList);
            return this;
        }

        /// <summary>
        /// Checks if OrderFeeAdjustmentList property is set.
        /// </summary>
        /// <returns>true if OrderFeeAdjustmentList property is set.</returns>
        public bool IsSetOrderFeeAdjustmentList()
        {
            return this.OrderFeeAdjustmentList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the DirectPaymentList property.
        /// </summary>
        public List<DirectPayment> DirectPaymentList
        {
            get
            {
                if(this._directPaymentList == null)
                {
                    this._directPaymentList = new List<DirectPayment>();
                }
                return this._directPaymentList;
            }
            set { this._directPaymentList = value; }
        }

        /// <summary>
        /// Sets the DirectPaymentList property.
        /// </summary>
        /// <param name="directPaymentList">DirectPaymentList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentEvent WithDirectPaymentList(DirectPayment[] directPaymentList)
        {
            this._directPaymentList.AddRange(directPaymentList);
            return this;
        }

        /// <summary>
        /// Checks if DirectPaymentList property is set.
        /// </summary>
        /// <returns>true if DirectPaymentList property is set.</returns>
        public bool IsSetDirectPaymentList()
        {
            return this.DirectPaymentList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the PostedDate property.
        /// </summary>
        public DateTime PostedDate
        {
            get { return this._postedDate.GetValueOrDefault(); }
            set { this._postedDate = value; }
        }

        /// <summary>
        /// Sets the PostedDate property.
        /// </summary>
        /// <param name="postedDate">PostedDate property.</param>
        /// <returns>this instance.</returns>
        public ShipmentEvent WithPostedDate(DateTime postedDate)
        {
            this._postedDate = postedDate;
            return this;
        }

        /// <summary>
        /// Checks if PostedDate property is set.
        /// </summary>
        /// <returns>true if PostedDate property is set.</returns>
        public bool IsSetPostedDate()
        {
            return this._postedDate != null;
        }

        /// <summary>
        /// Gets and sets the ShipmentItemList property.
        /// </summary>
        public List<ShipmentItem> ShipmentItemList
        {
            get
            {
                if(this._shipmentItemList == null)
                {
                    this._shipmentItemList = new List<ShipmentItem>();
                }
                return this._shipmentItemList;
            }
            set { this._shipmentItemList = value; }
        }

        /// <summary>
        /// Sets the ShipmentItemList property.
        /// </summary>
        /// <param name="shipmentItemList">ShipmentItemList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentEvent WithShipmentItemList(ShipmentItem[] shipmentItemList)
        {
            this._shipmentItemList.AddRange(shipmentItemList);
            return this;
        }

        /// <summary>
        /// Checks if ShipmentItemList property is set.
        /// </summary>
        /// <returns>true if ShipmentItemList property is set.</returns>
        public bool IsSetShipmentItemList()
        {
            return this.ShipmentItemList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the ShipmentItemAdjustmentList property.
        /// </summary>
        public List<ShipmentItem> ShipmentItemAdjustmentList
        {
            get
            {
                if(this._shipmentItemAdjustmentList == null)
                {
                    this._shipmentItemAdjustmentList = new List<ShipmentItem>();
                }
                return this._shipmentItemAdjustmentList;
            }
            set { this._shipmentItemAdjustmentList = value; }
        }

        /// <summary>
        /// Sets the ShipmentItemAdjustmentList property.
        /// </summary>
        /// <param name="shipmentItemAdjustmentList">ShipmentItemAdjustmentList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentEvent WithShipmentItemAdjustmentList(ShipmentItem[] shipmentItemAdjustmentList)
        {
            this._shipmentItemAdjustmentList.AddRange(shipmentItemAdjustmentList);
            return this;
        }

        /// <summary>
        /// Checks if ShipmentItemAdjustmentList property is set.
        /// </summary>
        /// <returns>true if ShipmentItemAdjustmentList property is set.</returns>
        public bool IsSetShipmentItemAdjustmentList()
        {
            return this.ShipmentItemAdjustmentList.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _amazonOrderId = reader.Read<string>("AmazonOrderId");
            _sellerOrderId = reader.Read<string>("SellerOrderId");
            _marketplaceName = reader.Read<string>("MarketplaceName");
            _orderChargeList = reader.ReadList<ChargeComponent>("OrderChargeList", "ChargeComponent");
            _orderChargeAdjustmentList = reader.ReadList<ChargeComponent>("OrderChargeAdjustmentList", "ChargeComponent");
            _shipmentFeeList = reader.ReadList<FeeComponent>("ShipmentFeeList", "FeeComponent");
            _shipmentFeeAdjustmentList = reader.ReadList<FeeComponent>("ShipmentFeeAdjustmentList", "FeeComponent");
            _orderFeeList = reader.ReadList<FeeComponent>("OrderFeeList", "FeeComponent");
            _orderFeeAdjustmentList = reader.ReadList<FeeComponent>("OrderFeeAdjustmentList", "FeeComponent");
            _directPaymentList = reader.ReadList<DirectPayment>("DirectPaymentList", "DirectPayment");
            _postedDate = reader.Read<DateTime?>("PostedDate");
            _shipmentItemList = reader.ReadList<ShipmentItem>("ShipmentItemList", "ShipmentItem");
            _shipmentItemAdjustmentList = reader.ReadList<ShipmentItem>("ShipmentItemAdjustmentList", "ShipmentItem");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("AmazonOrderId", _amazonOrderId);
            writer.Write("SellerOrderId", _sellerOrderId);
            writer.Write("MarketplaceName", _marketplaceName);
            writer.WriteList("OrderChargeList", "ChargeComponent", _orderChargeList);
            writer.WriteList("OrderChargeAdjustmentList", "ChargeComponent", _orderChargeAdjustmentList);
            writer.WriteList("ShipmentFeeList", "FeeComponent", _shipmentFeeList);
            writer.WriteList("ShipmentFeeAdjustmentList", "FeeComponent", _shipmentFeeAdjustmentList);
            writer.WriteList("OrderFeeList", "FeeComponent", _orderFeeList);
            writer.WriteList("OrderFeeAdjustmentList", "FeeComponent", _orderFeeAdjustmentList);
            writer.WriteList("DirectPaymentList", "DirectPayment", _directPaymentList);
            writer.Write("PostedDate", _postedDate);
            writer.WriteList("ShipmentItemList", "ShipmentItem", _shipmentItemList);
            writer.WriteList("ShipmentItemAdjustmentList", "ShipmentItem", _shipmentItemAdjustmentList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "ShipmentEvent", this);
        }


        public ShipmentEvent() : base()
        {
        }
    }
}
