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
 * Fulfillment Preview Item
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
    public class FulfillmentPreviewItem : AbstractMwsObject
    {

        private string _sellerSKU;
        private decimal _quantity;
        private string _sellerFulfillmentOrderItemId;
        private Weight _estimatedShippingWeight;
        private string _shippingWeightCalculationMethod;

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
        public FulfillmentPreviewItem WithSellerSKU(string sellerSKU)
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
        public FulfillmentPreviewItem WithQuantity(decimal quantity)
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
        public FulfillmentPreviewItem WithSellerFulfillmentOrderItemId(string sellerFulfillmentOrderItemId)
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
        /// Gets and sets the EstimatedShippingWeight property.
        /// </summary>
        [XmlElement(ElementName = "EstimatedShippingWeight")]
        public Weight EstimatedShippingWeight
        {
            get { return this._estimatedShippingWeight; }
            set { this._estimatedShippingWeight = value; }
        }

        /// <summary>
        /// Sets the EstimatedShippingWeight property.
        /// </summary>
        /// <param name="estimatedShippingWeight">EstimatedShippingWeight property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreviewItem WithEstimatedShippingWeight(Weight estimatedShippingWeight)
        {
            this._estimatedShippingWeight = estimatedShippingWeight;
            return this;
        }

        /// <summary>
        /// Checks if EstimatedShippingWeight property is set.
        /// </summary>
        /// <returns>true if EstimatedShippingWeight property is set.</returns>
        public bool IsSetEstimatedShippingWeight()
        {
            return this._estimatedShippingWeight != null;
        }

        /// <summary>
        /// Gets and sets the ShippingWeightCalculationMethod property.
        /// </summary>
        [XmlElement(ElementName = "ShippingWeightCalculationMethod")]
        public string ShippingWeightCalculationMethod
        {
            get { return this._shippingWeightCalculationMethod; }
            set { this._shippingWeightCalculationMethod = value; }
        }

        /// <summary>
        /// Sets the ShippingWeightCalculationMethod property.
        /// </summary>
        /// <param name="shippingWeightCalculationMethod">ShippingWeightCalculationMethod property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreviewItem WithShippingWeightCalculationMethod(string shippingWeightCalculationMethod)
        {
            this._shippingWeightCalculationMethod = shippingWeightCalculationMethod;
            return this;
        }

        /// <summary>
        /// Checks if ShippingWeightCalculationMethod property is set.
        /// </summary>
        /// <returns>true if ShippingWeightCalculationMethod property is set.</returns>
        public bool IsSetShippingWeightCalculationMethod()
        {
            return this._shippingWeightCalculationMethod != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerSKU = reader.Read<string>("SellerSKU");
            _quantity = reader.Read<decimal>("Quantity");
            _sellerFulfillmentOrderItemId = reader.Read<string>("SellerFulfillmentOrderItemId");
            _estimatedShippingWeight = reader.Read<Weight>("EstimatedShippingWeight");
            _shippingWeightCalculationMethod = reader.Read<string>("ShippingWeightCalculationMethod");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerSKU", _sellerSKU);
            writer.Write("Quantity", _quantity);
            writer.Write("SellerFulfillmentOrderItemId", _sellerFulfillmentOrderItemId);
            writer.Write("EstimatedShippingWeight", _estimatedShippingWeight);
            writer.Write("ShippingWeightCalculationMethod", _shippingWeightCalculationMethod);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "FulfillmentPreviewItem", this);
        }

    public FulfillmentPreviewItem (string sellerSKU,decimal quantity,string sellerFulfillmentOrderItemId) : base() {
        this._sellerSKU = sellerSKU;
        this._quantity = quantity;
        this._sellerFulfillmentOrderItemId = sellerFulfillmentOrderItemId;
    }

        public FulfillmentPreviewItem() : base()
        {
        }
    }
}
