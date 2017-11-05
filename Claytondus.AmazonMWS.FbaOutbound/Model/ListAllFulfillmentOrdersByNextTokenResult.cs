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
 * List All Fulfillment Orders By Next Token Result
 * API Version: 2010-10-01
 * Library Version: 2016-10-19
 * Generated: Wed Oct 19 08:37:54 PDT 2016
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaOutbound.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", IsNullable = false)]
    public class ListAllFulfillmentOrdersByNextTokenResult : AbstractMwsObject
    {

        private string _nextToken;
        private FulfillmentOrderList _fulfillmentOrders;

        /// <summary>
        /// Gets and sets the NextToken property.
        /// </summary>
        [XmlElement(ElementName = "NextToken")]
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
        public ListAllFulfillmentOrdersByNextTokenResult WithNextToken(string nextToken)
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
        /// Gets and sets the FulfillmentOrders property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentOrders")]
        public FulfillmentOrderList FulfillmentOrders
        {
            get { return this._fulfillmentOrders; }
            set { this._fulfillmentOrders = value; }
        }

        /// <summary>
        /// Sets the FulfillmentOrders property.
        /// </summary>
        /// <param name="fulfillmentOrders">FulfillmentOrders property.</param>
        /// <returns>this instance.</returns>
        public ListAllFulfillmentOrdersByNextTokenResult WithFulfillmentOrders(FulfillmentOrderList fulfillmentOrders)
        {
            this._fulfillmentOrders = fulfillmentOrders;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentOrders property is set.
        /// </summary>
        /// <returns>true if FulfillmentOrders property is set.</returns>
        public bool IsSetFulfillmentOrders()
        {
            return this._fulfillmentOrders != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _nextToken = reader.Read<string>("NextToken");
            _fulfillmentOrders = reader.Read<FulfillmentOrderList>("FulfillmentOrders");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("NextToken", _nextToken);
            writer.Write("FulfillmentOrders", _fulfillmentOrders);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "ListAllFulfillmentOrdersByNextTokenResult", this);
        }

    public ListAllFulfillmentOrdersByNextTokenResult (string nextToken) : base() {
        this._nextToken = nextToken;
    }

        public ListAllFulfillmentOrdersByNextTokenResult() : base()
        {
        }
    }
}
