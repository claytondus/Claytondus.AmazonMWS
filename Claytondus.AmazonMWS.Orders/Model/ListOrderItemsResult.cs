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
 * List Order Items Result
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
    public class ListOrderItemsResult : AbstractMwsObject
    {

        private string _nextToken;
        private string _amazonOrderId;
        private List<OrderItem> _orderItems;

        /// <summary>
        /// Gets and sets the NextToken property.
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        /// <summary>
        /// Sets the NextToken property.
        /// </summary>
        /// <param name="nextToken">NextToken property.</param>
        /// <returns>this instance.</returns>
        public ListOrderItemsResult WithNextToken(string nextToken)
        {
            this._nextToken = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if NextToken property is set.
        /// </summary>
        /// <returns>true if NextToken property is set.</returns>
        public bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

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
        public ListOrderItemsResult WithAmazonOrderId(string amazonOrderId)
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
        /// Gets and sets the OrderItems property.
        /// </summary>
        public List<OrderItem> OrderItems
        {
            get
            {
                if(this._orderItems == null)
                {
                    this._orderItems = new List<OrderItem>();
                }
                return this._orderItems;
            }
            set { this._orderItems = value; }
        }

        /// <summary>
        /// Sets the OrderItems property.
        /// </summary>
        /// <param name="orderItems">OrderItems property.</param>
        /// <returns>this instance.</returns>
        public ListOrderItemsResult WithOrderItems(OrderItem[] orderItems)
        {
            this._orderItems.AddRange(orderItems);
            return this;
        }

        /// <summary>
        /// Checks if OrderItems property is set.
        /// </summary>
        /// <returns>true if OrderItems property is set.</returns>
        public bool IsSetOrderItems()
        {
            return this.OrderItems.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _nextToken = reader.Read<string>("NextToken");
            _amazonOrderId = reader.Read<string>("AmazonOrderId");
            _orderItems = reader.ReadList<OrderItem>("OrderItems", "OrderItem");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("NextToken", _nextToken);
            writer.Write("AmazonOrderId", _amazonOrderId);
            writer.WriteList("OrderItems", "OrderItem", _orderItems);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "ListOrderItemsResult", this);
        }

    public ListOrderItemsResult (string amazonOrderId) : base() {
        this._amazonOrderId = amazonOrderId;
    }

        public ListOrderItemsResult() : base()
        {
        }
    }
}
