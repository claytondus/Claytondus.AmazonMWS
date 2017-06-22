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
 * Offer Type
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Products.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false)]
    public class OfferType : AbstractMwsObject
    {

        private PriceType _buyingPrice;
        private MoneyType _regularPrice;
        private string _fulfillmentChannel;
        private string _itemCondition;
        private string _itemSubCondition;
        private string _sellerId;
        private string _sellerSKU;

        /// <summary>
        /// Gets and sets the BuyingPrice property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BuyingPrice")]
        public PriceType BuyingPrice
        {
            get { return this._buyingPrice; }
            set { this._buyingPrice = value; }
        }

        /// <summary>
        /// Sets the BuyingPrice property.
        /// </summary>
        /// <param name="buyingPrice">BuyingPrice property.</param>
        /// <returns>this instance.</returns>
        public OfferType WithBuyingPrice(PriceType buyingPrice)
        {
            this._buyingPrice = buyingPrice;
            return this;
        }

        /// <summary>
        /// Checks if BuyingPrice property is set.
        /// </summary>
        /// <returns>true if BuyingPrice property is set.</returns>
        public bool IsSetBuyingPrice()
        {
            return this._buyingPrice != null;
        }

        /// <summary>
        /// Gets and sets the RegularPrice property.
        /// </summary>
        [XmlElementAttribute(ElementName = "RegularPrice")]
        public MoneyType RegularPrice
        {
            get { return this._regularPrice; }
            set { this._regularPrice = value; }
        }

        /// <summary>
        /// Sets the RegularPrice property.
        /// </summary>
        /// <param name="regularPrice">RegularPrice property.</param>
        /// <returns>this instance.</returns>
        public OfferType WithRegularPrice(MoneyType regularPrice)
        {
            this._regularPrice = regularPrice;
            return this;
        }

        /// <summary>
        /// Checks if RegularPrice property is set.
        /// </summary>
        /// <returns>true if RegularPrice property is set.</returns>
        public bool IsSetRegularPrice()
        {
            return this._regularPrice != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentChannel property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FulfillmentChannel")]
        public string FulfillmentChannel
        {
            get { return this._fulfillmentChannel; }
            set { this._fulfillmentChannel = value; }
        }

        /// <summary>
        /// Sets the FulfillmentChannel property.
        /// </summary>
        /// <param name="fulfillmentChannel">FulfillmentChannel property.</param>
        /// <returns>this instance.</returns>
        public OfferType WithFulfillmentChannel(string fulfillmentChannel)
        {
            this._fulfillmentChannel = fulfillmentChannel;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentChannel property is set.
        /// </summary>
        /// <returns>true if FulfillmentChannel property is set.</returns>
        public bool IsSetFulfillmentChannel()
        {
            return this._fulfillmentChannel != null;
        }

        /// <summary>
        /// Gets and sets the ItemCondition property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ItemCondition")]
        public string ItemCondition
        {
            get { return this._itemCondition; }
            set { this._itemCondition = value; }
        }

        /// <summary>
        /// Sets the ItemCondition property.
        /// </summary>
        /// <param name="itemCondition">ItemCondition property.</param>
        /// <returns>this instance.</returns>
        public OfferType WithItemCondition(string itemCondition)
        {
            this._itemCondition = itemCondition;
            return this;
        }

        /// <summary>
        /// Checks if ItemCondition property is set.
        /// </summary>
        /// <returns>true if ItemCondition property is set.</returns>
        public bool IsSetItemCondition()
        {
            return this._itemCondition != null;
        }

        /// <summary>
        /// Gets and sets the ItemSubCondition property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ItemSubCondition")]
        public string ItemSubCondition
        {
            get { return this._itemSubCondition; }
            set { this._itemSubCondition = value; }
        }

        /// <summary>
        /// Sets the ItemSubCondition property.
        /// </summary>
        /// <param name="itemSubCondition">ItemSubCondition property.</param>
        /// <returns>this instance.</returns>
        public OfferType WithItemSubCondition(string itemSubCondition)
        {
            this._itemSubCondition = itemSubCondition;
            return this;
        }

        /// <summary>
        /// Checks if ItemSubCondition property is set.
        /// </summary>
        /// <returns>true if ItemSubCondition property is set.</returns>
        public bool IsSetItemSubCondition()
        {
            return this._itemSubCondition != null;
        }

        /// <summary>
        /// Gets and sets the SellerId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerId")]
        public string SellerId
        {
            get { return this._sellerId; }
            set { this._sellerId = value; }
        }

        /// <summary>
        /// Sets the SellerId property.
        /// </summary>
        /// <param name="sellerId">SellerId property.</param>
        /// <returns>this instance.</returns>
        public OfferType WithSellerId(string sellerId)
        {
            this._sellerId = sellerId;
            return this;
        }

        /// <summary>
        /// Checks if SellerId property is set.
        /// </summary>
        /// <returns>true if SellerId property is set.</returns>
        public bool IsSetSellerId()
        {
            return this._sellerId != null;
        }

        /// <summary>
        /// Gets and sets the SellerSKU property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerSKU")]
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
        public OfferType WithSellerSKU(string sellerSKU)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _buyingPrice = reader.Read<PriceType>("BuyingPrice");
            _regularPrice = reader.Read<MoneyType>("RegularPrice");
            _fulfillmentChannel = reader.Read<string>("FulfillmentChannel");
            _itemCondition = reader.Read<string>("ItemCondition");
            _itemSubCondition = reader.Read<string>("ItemSubCondition");
            _sellerId = reader.Read<string>("SellerId");
            _sellerSKU = reader.Read<string>("SellerSKU");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("BuyingPrice", _buyingPrice);
            writer.Write("RegularPrice", _regularPrice);
            writer.Write("FulfillmentChannel", _fulfillmentChannel);
            writer.Write("ItemCondition", _itemCondition);
            writer.Write("ItemSubCondition", _itemSubCondition);
            writer.Write("SellerId", _sellerId);
            writer.Write("SellerSKU", _sellerSKU);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "OfferType", this);
        }

    public OfferType (PriceType buyingPrice,MoneyType regularPrice,string fulfillmentChannel,string itemCondition,string itemSubCondition,string sellerId,string sellerSKU) : base() {
        this._buyingPrice = buyingPrice;
        this._regularPrice = regularPrice;
        this._fulfillmentChannel = fulfillmentChannel;
        this._itemCondition = itemCondition;
        this._itemSubCondition = itemSubCondition;
        this._sellerId = sellerId;
        this._sellerSKU = sellerSKU;
    }

        public OfferType() : base()
        {
        }
    }
}
