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
 * Invalid Return Item
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
    public class InvalidReturnItem : AbstractMwsObject
    {

        private string _sellerReturnItemId;
        private string _sellerFulfillmentOrderItemId;
        private InvalidItemReason _invalidItemReason;

        /// <summary>
        /// Gets and sets the SellerReturnItemId property.
        /// </summary>
        [XmlElement(ElementName = "SellerReturnItemId")]
        public string SellerReturnItemId
        {
            get { return this._sellerReturnItemId; }
            set { this._sellerReturnItemId = value; }
        }

        /// <summary>
        /// Sets the SellerReturnItemId property.
        /// </summary>
        /// <param name="sellerReturnItemId">SellerReturnItemId property.</param>
        /// <returns>this instance.</returns>
        public InvalidReturnItem WithSellerReturnItemId(string sellerReturnItemId)
        {
            this._sellerReturnItemId = sellerReturnItemId;
            return this;
        }

        /// <summary>
        /// Checks if SellerReturnItemId property is set.
        /// </summary>
        /// <returns>true if SellerReturnItemId property is set.</returns>
        public bool IsSetSellerReturnItemId()
        {
            return this._sellerReturnItemId != null;
        }

        /// <summary>
        /// Gets and sets the SellerFulfillmentOrderItemId property.
        /// </summary>
        [XmlElement(ElementName = "SellerFulfillmentOrderItemId")]
        public string SellerFulfillmentOrderItemId
        {
            get { return this._sellerFulfillmentOrderItemId; }
            set { this._sellerFulfillmentOrderItemId = value; }
        }

        /// <summary>
        /// Sets the SellerFulfillmentOrderItemId property.
        /// </summary>
        /// <param name="sellerFulfillmentOrderItemId">SellerFulfillmentOrderItemId property.</param>
        /// <returns>this instance.</returns>
        public InvalidReturnItem WithSellerFulfillmentOrderItemId(string sellerFulfillmentOrderItemId)
        {
            this._sellerFulfillmentOrderItemId = sellerFulfillmentOrderItemId;
            return this;
        }

        /// <summary>
        /// Checks if SellerFulfillmentOrderItemId property is set.
        /// </summary>
        /// <returns>true if SellerFulfillmentOrderItemId property is set.</returns>
        public bool IsSetSellerFulfillmentOrderItemId()
        {
            return this._sellerFulfillmentOrderItemId != null;
        }

        /// <summary>
        /// Gets and sets the InvalidItemReason property.
        /// </summary>
        [XmlElement(ElementName = "InvalidItemReason")]
        public InvalidItemReason InvalidItemReason
        {
            get { return this._invalidItemReason; }
            set { this._invalidItemReason = value; }
        }

        /// <summary>
        /// Sets the InvalidItemReason property.
        /// </summary>
        /// <param name="invalidItemReason">InvalidItemReason property.</param>
        /// <returns>this instance.</returns>
        public InvalidReturnItem WithInvalidItemReason(InvalidItemReason invalidItemReason)
        {
            this._invalidItemReason = invalidItemReason;
            return this;
        }

        /// <summary>
        /// Checks if InvalidItemReason property is set.
        /// </summary>
        /// <returns>true if InvalidItemReason property is set.</returns>
        public bool IsSetInvalidItemReason()
        {
            return this._invalidItemReason != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerReturnItemId = reader.Read<string>("SellerReturnItemId");
            _sellerFulfillmentOrderItemId = reader.Read<string>("SellerFulfillmentOrderItemId");
            _invalidItemReason = reader.Read<InvalidItemReason>("InvalidItemReason");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerReturnItemId", _sellerReturnItemId);
            writer.Write("SellerFulfillmentOrderItemId", _sellerFulfillmentOrderItemId);
            writer.Write("InvalidItemReason", _invalidItemReason);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "InvalidReturnItem", this);
        }

    public InvalidReturnItem (string sellerReturnItemId,string sellerFulfillmentOrderItemId,InvalidItemReason invalidItemReason) : base() {
        this._sellerReturnItemId = sellerReturnItemId;
        this._sellerFulfillmentOrderItemId = sellerFulfillmentOrderItemId;
        this._invalidItemReason = invalidItemReason;
    }

        public InvalidReturnItem() : base()
        {
        }
    }
}
