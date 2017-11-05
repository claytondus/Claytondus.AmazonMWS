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
 * Get Fulfillment Order Result
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
    public class GetFulfillmentOrderResult : AbstractMwsObject
    {

        private FulfillmentOrder _fulfillmentOrder;
        private FulfillmentOrderItemList _fulfillmentOrderItem;
        private FulfillmentShipmentList _fulfillmentShipment;
        private ReturnItemList _returnItemList;
        private ReturnAuthorizationList _returnAuthorizationList;

        /// <summary>
        /// Gets and sets the FulfillmentOrder property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentOrder")]
        public FulfillmentOrder FulfillmentOrder
        {
            get { return this._fulfillmentOrder; }
            set { this._fulfillmentOrder = value; }
        }

        /// <summary>
        /// Sets the FulfillmentOrder property.
        /// </summary>
        /// <param name="fulfillmentOrder">FulfillmentOrder property.</param>
        /// <returns>this instance.</returns>
        public GetFulfillmentOrderResult WithFulfillmentOrder(FulfillmentOrder fulfillmentOrder)
        {
            this._fulfillmentOrder = fulfillmentOrder;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentOrder property is set.
        /// </summary>
        /// <returns>true if FulfillmentOrder property is set.</returns>
        public bool IsSetFulfillmentOrder()
        {
            return this._fulfillmentOrder != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentOrderItem property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentOrderItem")]
        public FulfillmentOrderItemList FulfillmentOrderItem
        {
            get { return this._fulfillmentOrderItem; }
            set { this._fulfillmentOrderItem = value; }
        }

        /// <summary>
        /// Sets the FulfillmentOrderItem property.
        /// </summary>
        /// <param name="fulfillmentOrderItem">FulfillmentOrderItem property.</param>
        /// <returns>this instance.</returns>
        public GetFulfillmentOrderResult WithFulfillmentOrderItem(FulfillmentOrderItemList fulfillmentOrderItem)
        {
            this._fulfillmentOrderItem = fulfillmentOrderItem;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentOrderItem property is set.
        /// </summary>
        /// <returns>true if FulfillmentOrderItem property is set.</returns>
        public bool IsSetFulfillmentOrderItem()
        {
            return this._fulfillmentOrderItem != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentShipment property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentShipment")]
        public FulfillmentShipmentList FulfillmentShipment
        {
            get { return this._fulfillmentShipment; }
            set { this._fulfillmentShipment = value; }
        }

        /// <summary>
        /// Sets the FulfillmentShipment property.
        /// </summary>
        /// <param name="fulfillmentShipment">FulfillmentShipment property.</param>
        /// <returns>this instance.</returns>
        public GetFulfillmentOrderResult WithFulfillmentShipment(FulfillmentShipmentList fulfillmentShipment)
        {
            this._fulfillmentShipment = fulfillmentShipment;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentShipment property is set.
        /// </summary>
        /// <returns>true if FulfillmentShipment property is set.</returns>
        public bool IsSetFulfillmentShipment()
        {
            return this._fulfillmentShipment != null;
        }

        /// <summary>
        /// Gets and sets the ReturnItemList property.
        /// </summary>
        [XmlElement(ElementName = "ReturnItemList")]
        public ReturnItemList ReturnItemList
        {
            get { return this._returnItemList; }
            set { this._returnItemList = value; }
        }

        /// <summary>
        /// Sets the ReturnItemList property.
        /// </summary>
        /// <param name="returnItemList">ReturnItemList property.</param>
        /// <returns>this instance.</returns>
        public GetFulfillmentOrderResult WithReturnItemList(ReturnItemList returnItemList)
        {
            this._returnItemList = returnItemList;
            return this;
        }

        /// <summary>
        /// Checks if ReturnItemList property is set.
        /// </summary>
        /// <returns>true if ReturnItemList property is set.</returns>
        public bool IsSetReturnItemList()
        {
            return this._returnItemList != null;
        }

        /// <summary>
        /// Gets and sets the ReturnAuthorizationList property.
        /// </summary>
        [XmlElement(ElementName = "ReturnAuthorizationList")]
        public ReturnAuthorizationList ReturnAuthorizationList
        {
            get { return this._returnAuthorizationList; }
            set { this._returnAuthorizationList = value; }
        }

        /// <summary>
        /// Sets the ReturnAuthorizationList property.
        /// </summary>
        /// <param name="returnAuthorizationList">ReturnAuthorizationList property.</param>
        /// <returns>this instance.</returns>
        public GetFulfillmentOrderResult WithReturnAuthorizationList(ReturnAuthorizationList returnAuthorizationList)
        {
            this._returnAuthorizationList = returnAuthorizationList;
            return this;
        }

        /// <summary>
        /// Checks if ReturnAuthorizationList property is set.
        /// </summary>
        /// <returns>true if ReturnAuthorizationList property is set.</returns>
        public bool IsSetReturnAuthorizationList()
        {
            return this._returnAuthorizationList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _fulfillmentOrder = reader.Read<FulfillmentOrder>("FulfillmentOrder");
            _fulfillmentOrderItem = reader.Read<FulfillmentOrderItemList>("FulfillmentOrderItem");
            _fulfillmentShipment = reader.Read<FulfillmentShipmentList>("FulfillmentShipment");
            _returnItemList = reader.Read<ReturnItemList>("ReturnItemList");
            _returnAuthorizationList = reader.Read<ReturnAuthorizationList>("ReturnAuthorizationList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("FulfillmentOrder", _fulfillmentOrder);
            writer.Write("FulfillmentOrderItem", _fulfillmentOrderItem);
            writer.Write("FulfillmentShipment", _fulfillmentShipment);
            writer.Write("ReturnItemList", _returnItemList);
            writer.Write("ReturnAuthorizationList", _returnAuthorizationList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "GetFulfillmentOrderResult", this);
        }

    public GetFulfillmentOrderResult (FulfillmentOrder fulfillmentOrder,FulfillmentOrderItemList fulfillmentOrderItem,ReturnItemList returnItemList,ReturnAuthorizationList returnAuthorizationList) : base() {
        this._fulfillmentOrder = fulfillmentOrder;
        this._fulfillmentOrderItem = fulfillmentOrderItem;
        this._returnItemList = returnItemList;
        this._returnAuthorizationList = returnAuthorizationList;
    }

        public GetFulfillmentOrderResult() : base()
        {
        }
    }
}
