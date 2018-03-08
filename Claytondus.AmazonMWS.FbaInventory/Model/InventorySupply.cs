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
 * Inventory Supply
 * API Version: 2010-10-01
 * Library Version: 2014-09-30
 * Generated: Mon Mar 21 09:01:30 PDT 2016
 */


using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaInventory.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/", IsNullable = false)]
    public class InventorySupply : AbstractMwsObject
    {

        private string _sellerSKU;
        private string _fnsku;
        private string _asin;
        private string _condition;
        private decimal? _totalSupplyQuantity;
        private decimal? _inStockSupplyQuantity;
        private Timepoint _earliestAvailability;
        private InventorySupplyDetailList _supplyDetail;

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
        public InventorySupply WithSellerSKU(string sellerSKU)
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
        /// Gets and sets the FNSKU property.
        /// </summary>
        [XmlElement(ElementName = "FNSKU")]
        public string FNSKU
        {
            get { return this._fnsku; }
            set { this._fnsku = value; }
        }

        /// <summary>
        /// Sets the FNSKU property.
        /// </summary>
        /// <param name="fnsku">FNSKU property.</param>
        /// <returns>this instance.</returns>
        public InventorySupply WithFNSKU(string fnsku)
        {
            this._fnsku = fnsku;
            return this;
        }

        /// <summary>
        /// Checks if FNSKU property is set.
        /// </summary>
        /// <returns>true if FNSKU property is set.</returns>
        public bool IsSetFNSKU()
        {
            return this._fnsku != null;
        }

        /// <summary>
        /// Gets and sets the ASIN property.
        /// </summary>
        [XmlElement(ElementName = "ASIN")]
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
        public InventorySupply WithASIN(string asin)
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
        /// Gets and sets the Condition property.
        /// </summary>
        [XmlElement(ElementName = "Condition")]
        public string Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        /// <summary>
        /// Sets the Condition property.
        /// </summary>
        /// <param name="condition">Condition property.</param>
        /// <returns>this instance.</returns>
        public InventorySupply WithCondition(string condition)
        {
            this._condition = condition;
            return this;
        }

        /// <summary>
        /// Checks if Condition property is set.
        /// </summary>
        /// <returns>true if Condition property is set.</returns>
        public bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the TotalSupplyQuantity property.
        /// </summary>
        [XmlElement(ElementName = "TotalSupplyQuantity")]
        public decimal TotalSupplyQuantity
        {
            get { return this._totalSupplyQuantity.GetValueOrDefault(); }
            set { this._totalSupplyQuantity = value; }
        }

        /// <summary>
        /// Sets the TotalSupplyQuantity property.
        /// </summary>
        /// <param name="totalSupplyQuantity">TotalSupplyQuantity property.</param>
        /// <returns>this instance.</returns>
        public InventorySupply WithTotalSupplyQuantity(decimal totalSupplyQuantity)
        {
            this._totalSupplyQuantity = totalSupplyQuantity;
            return this;
        }

        /// <summary>
        /// Checks if TotalSupplyQuantity property is set.
        /// </summary>
        /// <returns>true if TotalSupplyQuantity property is set.</returns>
        public bool IsSetTotalSupplyQuantity()
        {
            return this._totalSupplyQuantity != null;
        }

        /// <summary>
        /// Gets and sets the InStockSupplyQuantity property.
        /// </summary>
        [XmlElement(ElementName = "InStockSupplyQuantity")]
        public decimal InStockSupplyQuantity
        {
            get { return this._inStockSupplyQuantity.GetValueOrDefault(); }
            set { this._inStockSupplyQuantity = value; }
        }

        /// <summary>
        /// Sets the InStockSupplyQuantity property.
        /// </summary>
        /// <param name="inStockSupplyQuantity">InStockSupplyQuantity property.</param>
        /// <returns>this instance.</returns>
        public InventorySupply WithInStockSupplyQuantity(decimal inStockSupplyQuantity)
        {
            this._inStockSupplyQuantity = inStockSupplyQuantity;
            return this;
        }

        /// <summary>
        /// Checks if InStockSupplyQuantity property is set.
        /// </summary>
        /// <returns>true if InStockSupplyQuantity property is set.</returns>
        public bool IsSetInStockSupplyQuantity()
        {
            return this._inStockSupplyQuantity != null;
        }

        /// <summary>
        /// Gets and sets the EarliestAvailability property.
        /// </summary>
        [XmlElement(ElementName = "EarliestAvailability")]
        public Timepoint EarliestAvailability
        {
            get { return this._earliestAvailability; }
            set { this._earliestAvailability = value; }
        }

        /// <summary>
        /// Sets the EarliestAvailability property.
        /// </summary>
        /// <param name="earliestAvailability">EarliestAvailability property.</param>
        /// <returns>this instance.</returns>
        public InventorySupply WithEarliestAvailability(Timepoint earliestAvailability)
        {
            this._earliestAvailability = earliestAvailability;
            return this;
        }

        /// <summary>
        /// Checks if EarliestAvailability property is set.
        /// </summary>
        /// <returns>true if EarliestAvailability property is set.</returns>
        public bool IsSetEarliestAvailability()
        {
            return this._earliestAvailability != null;
        }

        /// <summary>
        /// Gets and sets the SupplyDetail property.
        /// </summary>
        [XmlElement(ElementName = "SupplyDetail")]
        public InventorySupplyDetailList SupplyDetail
        {
            get { return this._supplyDetail; }
            set { this._supplyDetail = value; }
        }

        /// <summary>
        /// Sets the SupplyDetail property.
        /// </summary>
        /// <param name="supplyDetail">SupplyDetail property.</param>
        /// <returns>this instance.</returns>
        public InventorySupply WithSupplyDetail(InventorySupplyDetailList supplyDetail)
        {
            this._supplyDetail = supplyDetail;
            return this;
        }

        /// <summary>
        /// Checks if SupplyDetail property is set.
        /// </summary>
        /// <returns>true if SupplyDetail property is set.</returns>
        public bool IsSetSupplyDetail()
        {
            return this._supplyDetail != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerSKU = reader.Read<string>("SellerSKU");
            _fnsku = reader.Read<string>("FNSKU");
            _asin = reader.Read<string>("ASIN");
            _condition = reader.Read<string>("Condition");
            _totalSupplyQuantity = reader.Read<decimal?>("TotalSupplyQuantity");
            _inStockSupplyQuantity = reader.Read<decimal?>("InStockSupplyQuantity");
            _earliestAvailability = reader.Read<Timepoint>("EarliestAvailability");
            _supplyDetail = reader.Read<InventorySupplyDetailList>("SupplyDetail");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerSKU", _sellerSKU);
            writer.Write("FNSKU", _fnsku);
            writer.Write("ASIN", _asin);
            writer.Write("Condition", _condition);
            writer.Write("TotalSupplyQuantity", _totalSupplyQuantity);
            writer.Write("InStockSupplyQuantity", _inStockSupplyQuantity);
            writer.Write("EarliestAvailability", _earliestAvailability);
            writer.Write("SupplyDetail", _supplyDetail);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/", "InventorySupply", this);
        }

        public InventorySupply() : base()
        {
        }
    }
}
