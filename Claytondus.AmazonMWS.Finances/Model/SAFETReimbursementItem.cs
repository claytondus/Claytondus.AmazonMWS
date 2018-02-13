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
 * SAFET Reimbursement Item
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class SAFETReimbursementItem : AbstractMwsObject
    {

        private List<ChargeComponent> _itemChargeList;
        private string _productDescription;
        private string _quantity;

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
        public SAFETReimbursementItem WithItemChargeList(ChargeComponent[] itemChargeList)
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
        public SAFETReimbursementItem WithProductDescription(string productDescription)
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
        public SAFETReimbursementItem WithQuantity(string quantity)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _itemChargeList = reader.ReadList<ChargeComponent>("itemChargeList", "ChargeComponent");
            _productDescription = reader.Read<string>("productDescription");
            _quantity = reader.Read<string>("quantity");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("itemChargeList", "ChargeComponent", _itemChargeList);
            writer.Write("productDescription", _productDescription);
            writer.Write("quantity", _quantity);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "SAFETReimbursementItem", this);
        }


        public SAFETReimbursementItem() : base()
        {
        }
    }
}
