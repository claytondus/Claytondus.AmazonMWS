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
 * Performance Bond Refund Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class PerformanceBondRefundEvent : AbstractMwsObject
    {

        private string _marketplaceCountryCode;
        private Currency _amount;
        private List<string> _productGroupList;

        /// <summary>
        /// Gets and sets the MarketplaceCountryCode property.
        /// </summary>
        public string MarketplaceCountryCode
        {
            get { return this._marketplaceCountryCode; }
            set { this._marketplaceCountryCode = value; }
        }

        /// <summary>
        /// Sets the MarketplaceCountryCode property.
        /// </summary>
        /// <param name="marketplaceCountryCode">MarketplaceCountryCode property.</param>
        /// <returns>this instance.</returns>
        public PerformanceBondRefundEvent WithMarketplaceCountryCode(string marketplaceCountryCode)
        {
            this._marketplaceCountryCode = marketplaceCountryCode;
            return this;
        }

        /// <summary>
        /// Checks if MarketplaceCountryCode property is set.
        /// </summary>
        /// <returns>true if MarketplaceCountryCode property is set.</returns>
        public bool IsSetMarketplaceCountryCode()
        {
            return this._marketplaceCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the Amount property.
        /// </summary>
        public Currency Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        /// <summary>
        /// Sets the Amount property.
        /// </summary>
        /// <param name="amount">Amount property.</param>
        /// <returns>this instance.</returns>
        public PerformanceBondRefundEvent WithAmount(Currency amount)
        {
            this._amount = amount;
            return this;
        }

        /// <summary>
        /// Checks if Amount property is set.
        /// </summary>
        /// <returns>true if Amount property is set.</returns>
        public bool IsSetAmount()
        {
            return this._amount != null;
        }

        /// <summary>
        /// Gets and sets the ProductGroupList property.
        /// </summary>
        public List<string> ProductGroupList
        {
            get
            {
                if(this._productGroupList == null)
                {
                    this._productGroupList = new List<string>();
                }
                return this._productGroupList;
            }
            set { this._productGroupList = value; }
        }

        /// <summary>
        /// Sets the ProductGroupList property.
        /// </summary>
        /// <param name="productGroupList">ProductGroupList property.</param>
        /// <returns>this instance.</returns>
        public PerformanceBondRefundEvent WithProductGroupList(string[] productGroupList)
        {
            this._productGroupList.AddRange(productGroupList);
            return this;
        }

        /// <summary>
        /// Checks if ProductGroupList property is set.
        /// </summary>
        /// <returns>true if ProductGroupList property is set.</returns>
        public bool IsSetProductGroupList()
        {
            return this.ProductGroupList.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _marketplaceCountryCode = reader.Read<string>("MarketplaceCountryCode");
            _amount = reader.Read<Currency>("Amount");
            _productGroupList = reader.ReadList<string>("ProductGroupList", "ProductGroup");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("MarketplaceCountryCode", _marketplaceCountryCode);
            writer.Write("Amount", _amount);
            writer.WriteList("ProductGroupList", "ProductGroup", _productGroupList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "PerformanceBondRefundEvent", this);
        }


        public PerformanceBondRefundEvent() : base()
        {
        }
    }
}
