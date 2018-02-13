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
 * Adjustment Item
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class AdjustmentItem : AbstractMwsObject
    {

        private string _quantity;
        private Currency _perUnitAmount;
        private Currency _totalAmount;
        private string _sellerSKU;
        private string _fnSKU;
        private string _productDescription;
        private string _asin;

        /// <summary>
        /// Gets and sets the Quantity property.
        /// </summary>
        public string Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        /// <summary>
        /// Sets the Quantity property.
        /// </summary>
        /// <param name="quantity">Quantity property.</param>
        /// <returns>this instance.</returns>
        public AdjustmentItem WithQuantity(string quantity)
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
        /// Gets and sets the PerUnitAmount property.
        /// </summary>
        public Currency PerUnitAmount
        {
            get { return this._perUnitAmount; }
            set { this._perUnitAmount = value; }
        }

        /// <summary>
        /// Sets the PerUnitAmount property.
        /// </summary>
        /// <param name="perUnitAmount">PerUnitAmount property.</param>
        /// <returns>this instance.</returns>
        public AdjustmentItem WithPerUnitAmount(Currency perUnitAmount)
        {
            this._perUnitAmount = perUnitAmount;
            return this;
        }

        /// <summary>
        /// Checks if PerUnitAmount property is set.
        /// </summary>
        /// <returns>true if PerUnitAmount property is set.</returns>
        public bool IsSetPerUnitAmount()
        {
            return this._perUnitAmount != null;
        }

        /// <summary>
        /// Gets and sets the TotalAmount property.
        /// </summary>
        public Currency TotalAmount
        {
            get { return this._totalAmount; }
            set { this._totalAmount = value; }
        }

        /// <summary>
        /// Sets the TotalAmount property.
        /// </summary>
        /// <param name="totalAmount">TotalAmount property.</param>
        /// <returns>this instance.</returns>
        public AdjustmentItem WithTotalAmount(Currency totalAmount)
        {
            this._totalAmount = totalAmount;
            return this;
        }

        /// <summary>
        /// Checks if TotalAmount property is set.
        /// </summary>
        /// <returns>true if TotalAmount property is set.</returns>
        public bool IsSetTotalAmount()
        {
            return this._totalAmount != null;
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
        public AdjustmentItem WithSellerSKU(string sellerSKU)
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
        /// Gets and sets the FnSKU property.
        /// </summary>
        public string FnSKU
        {
            get { return this._fnSKU; }
            set { this._fnSKU = value; }
        }

        /// <summary>
        /// Sets the FnSKU property.
        /// </summary>
        /// <param name="fnSKU">FnSKU property.</param>
        /// <returns>this instance.</returns>
        public AdjustmentItem WithFnSKU(string fnSKU)
        {
            this._fnSKU = fnSKU;
            return this;
        }

        /// <summary>
        /// Checks if FnSKU property is set.
        /// </summary>
        /// <returns>true if FnSKU property is set.</returns>
        public bool IsSetFnSKU()
        {
            return this._fnSKU != null;
        }

        /// <summary>
        /// Gets and sets the ProductDescription property.
        /// </summary>
        public string ProductDescription
        {
            get { return this._productDescription; }
            set { this._productDescription = value; }
        }

        /// <summary>
        /// Sets the ProductDescription property.
        /// </summary>
        /// <param name="productDescription">ProductDescription property.</param>
        /// <returns>this instance.</returns>
        public AdjustmentItem WithProductDescription(string productDescription)
        {
            this._productDescription = productDescription;
            return this;
        }

        /// <summary>
        /// Checks if ProductDescription property is set.
        /// </summary>
        /// <returns>true if ProductDescription property is set.</returns>
        public bool IsSetProductDescription()
        {
            return this._productDescription != null;
        }

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
        public AdjustmentItem WithASIN(string asin)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _quantity = reader.Read<string>("Quantity");
            _perUnitAmount = reader.Read<Currency>("PerUnitAmount");
            _totalAmount = reader.Read<Currency>("TotalAmount");
            _sellerSKU = reader.Read<string>("SellerSKU");
            _fnSKU = reader.Read<string>("FnSKU");
            _productDescription = reader.Read<string>("ProductDescription");
            _asin = reader.Read<string>("ASIN");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Quantity", _quantity);
            writer.Write("PerUnitAmount", _perUnitAmount);
            writer.Write("TotalAmount", _totalAmount);
            writer.Write("SellerSKU", _sellerSKU);
            writer.Write("FnSKU", _fnSKU);
            writer.Write("ProductDescription", _productDescription);
            writer.Write("ASIN", _asin);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "AdjustmentItem", this);
        }


        public AdjustmentItem() : base()
        {
        }
    }
}
