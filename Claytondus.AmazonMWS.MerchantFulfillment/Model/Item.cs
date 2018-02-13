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
 * Item
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class Item : AbstractMwsObject
    {

        private string _orderItemId;
        private decimal _quantity;

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
        public Item WithOrderItemId(string orderItemId)
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
        /// Gets and sets the Quantity property.
        /// </summary>
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
        public Item WithQuantity(decimal quantity)
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
            _orderItemId = reader.Read<string>("OrderItemId");
            _quantity = reader.Read<decimal>("Quantity");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("OrderItemId", _orderItemId);
            writer.Write("Quantity", _quantity);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "Item", this);
        }

    public Item (string orderItemId,decimal quantity) : base() {
        this._orderItemId = orderItemId;
        this._quantity = quantity;
    }

        public Item() : base()
        {
        }
    }
}
