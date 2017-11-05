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
 * Get Fulfillment Preview Item
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
    public class GetFulfillmentPreviewItem : AbstractMwsObject
    {

        private string _sellerSKU;
        private decimal _quantity;
        private string _sellerFulfillmentOrderItemId;

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
        public GetFulfillmentPreviewItem WithSellerSKU(string sellerSKU)
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
        /// Gets and sets the Quantity property.
        /// </summary>
        [XmlElement(ElementName = "Quantity")]
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
        public GetFulfillmentPreviewItem WithQuantity(decimal quantity)
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
        public GetFulfillmentPreviewItem WithSellerFulfillmentOrderItemId(string sellerFulfillmentOrderItemId)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerSKU = reader.Read<string>("SellerSKU");
            _quantity = reader.Read<decimal>("Quantity");
            _sellerFulfillmentOrderItemId = reader.Read<string>("SellerFulfillmentOrderItemId");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerSKU", _sellerSKU);
            writer.Write("Quantity", _quantity);
            writer.Write("SellerFulfillmentOrderItemId", _sellerFulfillmentOrderItemId);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "GetFulfillmentPreviewItem", this);
        }

    public GetFulfillmentPreviewItem (string sellerSKU,decimal quantity,string sellerFulfillmentOrderItemId) : base() {
        this._sellerSKU = sellerSKU;
        this._quantity = quantity;
        this._sellerFulfillmentOrderItemId = sellerFulfillmentOrderItemId;
    }

        public GetFulfillmentPreviewItem() : base()
        {
        }
    }
}
