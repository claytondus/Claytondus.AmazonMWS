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
 * Shipment Item
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class ShipmentItem : AbstractMwsObject
    {

        private string _sellerSKU;
        private string _orderItemId;
        private string _orderAdjustmentItemId;
        private decimal? _quantityShipped;
        private List<ChargeComponent> _itemChargeList;
        private List<ChargeComponent> _itemChargeAdjustmentList;
        private List<FeeComponent> _itemFeeList;
        private List<FeeComponent> _itemFeeAdjustmentList;
        private List<TaxWithheldComponent> _itemTaxWithheldList;
        private List<Promotion> _promotionList;
        private List<Promotion> _promotionAdjustmentList;
        private Currency _costOfPointsGranted;
        private Currency _costOfPointsReturned;

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
        public ShipmentItem WithSellerSKU(string sellerSKU)
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
        public ShipmentItem WithOrderItemId(string orderItemId)
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
        /// Gets and sets the OrderAdjustmentItemId property.
        /// </summary>
        public string OrderAdjustmentItemId
        {
            get { return this._orderAdjustmentItemId; }
            set { this._orderAdjustmentItemId = value; }
        }

        /// <summary>
        /// Sets the OrderAdjustmentItemId property.
        /// </summary>
        /// <param name="orderAdjustmentItemId">OrderAdjustmentItemId property.</param>
        /// <returns>this instance.</returns>
        public ShipmentItem WithOrderAdjustmentItemId(string orderAdjustmentItemId)
        {
            this._orderAdjustmentItemId = orderAdjustmentItemId;
            return this;
        }

        /// <summary>
        /// Checks if OrderAdjustmentItemId property is set.
        /// </summary>
        /// <returns>true if OrderAdjustmentItemId property is set.</returns>
        public bool IsSetOrderAdjustmentItemId()
        {
            return this._orderAdjustmentItemId != null;
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
        public ShipmentItem WithQuantityShipped(decimal quantityShipped)
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
        /// Gets and sets the ItemChargeList property.
        /// </summary>
        public List<ChargeComponent> ItemChargeList
        {
            get
            {
                if(this._itemChargeList == null)
                {
                    this._itemChargeList = new List<ChargeComponent>();
                }
                return this._itemChargeList;
            }
            set { this._itemChargeList = value; }
        }

        /// <summary>
        /// Sets the ItemChargeList property.
        /// </summary>
        /// <param name="itemChargeList">ItemChargeList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentItem WithItemChargeList(ChargeComponent[] itemChargeList)
        {
            this._itemChargeList.AddRange(itemChargeList);
            return this;
        }

        /// <summary>
        /// Checks if ItemChargeList property is set.
        /// </summary>
        /// <returns>true if ItemChargeList property is set.</returns>
        public bool IsSetItemChargeList()
        {
            return this.ItemChargeList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the ItemChargeAdjustmentList property.
        /// </summary>
        public List<ChargeComponent> ItemChargeAdjustmentList
        {
            get
            {
                if(this._itemChargeAdjustmentList == null)
                {
                    this._itemChargeAdjustmentList = new List<ChargeComponent>();
                }
                return this._itemChargeAdjustmentList;
            }
            set { this._itemChargeAdjustmentList = value; }
        }

        /// <summary>
        /// Sets the ItemChargeAdjustmentList property.
        /// </summary>
        /// <param name="itemChargeAdjustmentList">ItemChargeAdjustmentList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentItem WithItemChargeAdjustmentList(ChargeComponent[] itemChargeAdjustmentList)
        {
            this._itemChargeAdjustmentList.AddRange(itemChargeAdjustmentList);
            return this;
        }

        /// <summary>
        /// Checks if ItemChargeAdjustmentList property is set.
        /// </summary>
        /// <returns>true if ItemChargeAdjustmentList property is set.</returns>
        public bool IsSetItemChargeAdjustmentList()
        {
            return this.ItemChargeAdjustmentList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the ItemFeeList property.
        /// </summary>
        public List<FeeComponent> ItemFeeList
        {
            get
            {
                if(this._itemFeeList == null)
                {
                    this._itemFeeList = new List<FeeComponent>();
                }
                return this._itemFeeList;
            }
            set { this._itemFeeList = value; }
        }

        /// <summary>
        /// Sets the ItemFeeList property.
        /// </summary>
        /// <param name="itemFeeList">ItemFeeList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentItem WithItemFeeList(FeeComponent[] itemFeeList)
        {
            this._itemFeeList.AddRange(itemFeeList);
            return this;
        }

        /// <summary>
        /// Checks if ItemFeeList property is set.
        /// </summary>
        /// <returns>true if ItemFeeList property is set.</returns>
        public bool IsSetItemFeeList()
        {
            return this.ItemFeeList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the ItemFeeAdjustmentList property.
        /// </summary>
        public List<FeeComponent> ItemFeeAdjustmentList
        {
            get
            {
                if(this._itemFeeAdjustmentList == null)
                {
                    this._itemFeeAdjustmentList = new List<FeeComponent>();
                }
                return this._itemFeeAdjustmentList;
            }
            set { this._itemFeeAdjustmentList = value; }
        }

        /// <summary>
        /// Sets the ItemFeeAdjustmentList property.
        /// </summary>
        /// <param name="itemFeeAdjustmentList">ItemFeeAdjustmentList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentItem WithItemFeeAdjustmentList(FeeComponent[] itemFeeAdjustmentList)
        {
            this._itemFeeAdjustmentList.AddRange(itemFeeAdjustmentList);
            return this;
        }

        /// <summary>
        /// Checks if ItemFeeAdjustmentList property is set.
        /// </summary>
        /// <returns>true if ItemFeeAdjustmentList property is set.</returns>
        public bool IsSetItemFeeAdjustmentList()
        {
            return this.ItemFeeAdjustmentList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the ItemTaxWithheldList property.
        /// </summary>
        public List<TaxWithheldComponent> ItemTaxWithheldList
        {
            get
            {
                if(this._itemTaxWithheldList == null)
                {
                    this._itemTaxWithheldList = new List<TaxWithheldComponent>();
                }
                return this._itemTaxWithheldList;
            }
            set { this._itemTaxWithheldList = value; }
        }

        /// <summary>
        /// Sets the ItemTaxWithheldList property.
        /// </summary>
        /// <param name="itemTaxWithheldList">ItemTaxWithheldList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentItem WithItemTaxWithheldList(TaxWithheldComponent[] itemTaxWithheldList)
        {
            this._itemTaxWithheldList.AddRange(itemTaxWithheldList);
            return this;
        }

        /// <summary>
        /// Checks if ItemTaxWithheldList property is set.
        /// </summary>
        /// <returns>true if ItemTaxWithheldList property is set.</returns>
        public bool IsSetItemTaxWithheldList()
        {
            return this.ItemTaxWithheldList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the PromotionList property.
        /// </summary>
        public List<Promotion> PromotionList
        {
            get
            {
                if(this._promotionList == null)
                {
                    this._promotionList = new List<Promotion>();
                }
                return this._promotionList;
            }
            set { this._promotionList = value; }
        }

        /// <summary>
        /// Sets the PromotionList property.
        /// </summary>
        /// <param name="promotionList">PromotionList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentItem WithPromotionList(Promotion[] promotionList)
        {
            this._promotionList.AddRange(promotionList);
            return this;
        }

        /// <summary>
        /// Checks if PromotionList property is set.
        /// </summary>
        /// <returns>true if PromotionList property is set.</returns>
        public bool IsSetPromotionList()
        {
            return this.PromotionList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the PromotionAdjustmentList property.
        /// </summary>
        public List<Promotion> PromotionAdjustmentList
        {
            get
            {
                if(this._promotionAdjustmentList == null)
                {
                    this._promotionAdjustmentList = new List<Promotion>();
                }
                return this._promotionAdjustmentList;
            }
            set { this._promotionAdjustmentList = value; }
        }

        /// <summary>
        /// Sets the PromotionAdjustmentList property.
        /// </summary>
        /// <param name="promotionAdjustmentList">PromotionAdjustmentList property.</param>
        /// <returns>this instance.</returns>
        public ShipmentItem WithPromotionAdjustmentList(Promotion[] promotionAdjustmentList)
        {
            this._promotionAdjustmentList.AddRange(promotionAdjustmentList);
            return this;
        }

        /// <summary>
        /// Checks if PromotionAdjustmentList property is set.
        /// </summary>
        /// <returns>true if PromotionAdjustmentList property is set.</returns>
        public bool IsSetPromotionAdjustmentList()
        {
            return this.PromotionAdjustmentList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the CostOfPointsGranted property.
        /// </summary>
        public Currency CostOfPointsGranted
        {
            get { return this._costOfPointsGranted; }
            set { this._costOfPointsGranted = value; }
        }

        /// <summary>
        /// Sets the CostOfPointsGranted property.
        /// </summary>
        /// <param name="costOfPointsGranted">CostOfPointsGranted property.</param>
        /// <returns>this instance.</returns>
        public ShipmentItem WithCostOfPointsGranted(Currency costOfPointsGranted)
        {
            this._costOfPointsGranted = costOfPointsGranted;
            return this;
        }

        /// <summary>
        /// Checks if CostOfPointsGranted property is set.
        /// </summary>
        /// <returns>true if CostOfPointsGranted property is set.</returns>
        public bool IsSetCostOfPointsGranted()
        {
            return this._costOfPointsGranted != null;
        }

        /// <summary>
        /// Gets and sets the CostOfPointsReturned property.
        /// </summary>
        public Currency CostOfPointsReturned
        {
            get { return this._costOfPointsReturned; }
            set { this._costOfPointsReturned = value; }
        }

        /// <summary>
        /// Sets the CostOfPointsReturned property.
        /// </summary>
        /// <param name="costOfPointsReturned">CostOfPointsReturned property.</param>
        /// <returns>this instance.</returns>
        public ShipmentItem WithCostOfPointsReturned(Currency costOfPointsReturned)
        {
            this._costOfPointsReturned = costOfPointsReturned;
            return this;
        }

        /// <summary>
        /// Checks if CostOfPointsReturned property is set.
        /// </summary>
        /// <returns>true if CostOfPointsReturned property is set.</returns>
        public bool IsSetCostOfPointsReturned()
        {
            return this._costOfPointsReturned != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerSKU = reader.Read<string>("SellerSKU");
            _orderItemId = reader.Read<string>("OrderItemId");
            _orderAdjustmentItemId = reader.Read<string>("OrderAdjustmentItemId");
            _quantityShipped = reader.Read<decimal?>("QuantityShipped");
            _itemChargeList = reader.ReadList<ChargeComponent>("ItemChargeList", "ChargeComponent");
            _itemChargeAdjustmentList = reader.ReadList<ChargeComponent>("ItemChargeAdjustmentList", "ChargeComponent");
            _itemFeeList = reader.ReadList<FeeComponent>("ItemFeeList", "FeeComponent");
            _itemFeeAdjustmentList = reader.ReadList<FeeComponent>("ItemFeeAdjustmentList", "FeeComponent");
            _itemTaxWithheldList = reader.ReadList<TaxWithheldComponent>("ItemTaxWithheldList", "TaxWithheldComponent");
            _promotionList = reader.ReadList<Promotion>("PromotionList", "Promotion");
            _promotionAdjustmentList = reader.ReadList<Promotion>("PromotionAdjustmentList", "Promotion");
            _costOfPointsGranted = reader.Read<Currency>("CostOfPointsGranted");
            _costOfPointsReturned = reader.Read<Currency>("CostOfPointsReturned");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerSKU", _sellerSKU);
            writer.Write("OrderItemId", _orderItemId);
            writer.Write("OrderAdjustmentItemId", _orderAdjustmentItemId);
            writer.Write("QuantityShipped", _quantityShipped);
            writer.WriteList("ItemChargeList", "ChargeComponent", _itemChargeList);
            writer.WriteList("ItemChargeAdjustmentList", "ChargeComponent", _itemChargeAdjustmentList);
            writer.WriteList("ItemFeeList", "FeeComponent", _itemFeeList);
            writer.WriteList("ItemFeeAdjustmentList", "FeeComponent", _itemFeeAdjustmentList);
            writer.WriteList("ItemTaxWithheldList", "TaxWithheldComponent", _itemTaxWithheldList);
            writer.WriteList("PromotionList", "Promotion", _promotionList);
            writer.WriteList("PromotionAdjustmentList", "Promotion", _promotionAdjustmentList);
            writer.Write("CostOfPointsGranted", _costOfPointsGranted);
            writer.Write("CostOfPointsReturned", _costOfPointsReturned);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "ShipmentItem", this);
        }


        public ShipmentItem() : base()
        {
        }
    }
}
