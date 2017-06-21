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
 * List Inbound Shipment Items By Next Token Result
 * API Version: 2010-10-01
 * Library Version: 2016-10-05
 * Generated: Wed Oct 05 06:15:39 PDT 2016
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaInbound.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    [XmlRootAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", IsNullable = false)]
    public class ListInboundShipmentItemsByNextTokenResult : AbstractMwsObject
    {

        private InboundShipmentItemList _itemData;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the ItemData property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ItemData")]
        public InboundShipmentItemList ItemData
        {
            get { return this._itemData; }
            set { this._itemData = value; }
        }

        /// <summary>
        /// Sets the ItemData property.
        /// </summary>
        /// <param name="itemData">ItemData property.</param>
        /// <returns>this instance.</returns>
        public ListInboundShipmentItemsByNextTokenResult WithItemData(InboundShipmentItemList itemData)
        {
            this._itemData = itemData;
            return this;
        }

        /// <summary>
        /// Checks if ItemData property is set.
        /// </summary>
        /// <returns>true if ItemData property is set.</returns>
        public bool IsSetItemData()
        {
            return this._itemData != null;
        }

        /// <summary>
        /// Gets and sets the NextToken property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextToken")]
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
        public ListInboundShipmentItemsByNextTokenResult WithNextToken(string nextToken)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _itemData = reader.Read<InboundShipmentItemList>("ItemData");
            _nextToken = reader.Read<string>("NextToken");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ItemData", _itemData);
            writer.Write("NextToken", _nextToken);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "ListInboundShipmentItemsByNextTokenResult", this);
        }


        public ListInboundShipmentItemsByNextTokenResult() : base()
        {
        }
    }
}
