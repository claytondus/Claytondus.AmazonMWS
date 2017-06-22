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
 * Qualifiers Type
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
    public class QualifiersType : AbstractMwsObject
    {

        private string _itemCondition;
        private string _itemSubcondition;
        private string _fulfillmentChannel;
        private string _shipsDomestically;
        private ShippingTimeType _shippingTime;
        private string _sellerPositiveFeedbackRating;

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
        public QualifiersType WithItemCondition(string itemCondition)
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
        /// Gets and sets the ItemSubcondition property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ItemSubcondition")]
        public string ItemSubcondition
        {
            get { return this._itemSubcondition; }
            set { this._itemSubcondition = value; }
        }

        /// <summary>
        /// Sets the ItemSubcondition property.
        /// </summary>
        /// <param name="itemSubcondition">ItemSubcondition property.</param>
        /// <returns>this instance.</returns>
        public QualifiersType WithItemSubcondition(string itemSubcondition)
        {
            this._itemSubcondition = itemSubcondition;
            return this;
        }

        /// <summary>
        /// Checks if ItemSubcondition property is set.
        /// </summary>
        /// <returns>true if ItemSubcondition property is set.</returns>
        public bool IsSetItemSubcondition()
        {
            return this._itemSubcondition != null;
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
        public QualifiersType WithFulfillmentChannel(string fulfillmentChannel)
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
        /// Gets and sets the ShipsDomestically property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipsDomestically")]
        public string ShipsDomestically
        {
            get { return this._shipsDomestically; }
            set { this._shipsDomestically = value; }
        }

        /// <summary>
        /// Sets the ShipsDomestically property.
        /// </summary>
        /// <param name="shipsDomestically">ShipsDomestically property.</param>
        /// <returns>this instance.</returns>
        public QualifiersType WithShipsDomestically(string shipsDomestically)
        {
            this._shipsDomestically = shipsDomestically;
            return this;
        }

        /// <summary>
        /// Checks if ShipsDomestically property is set.
        /// </summary>
        /// <returns>true if ShipsDomestically property is set.</returns>
        public bool IsSetShipsDomestically()
        {
            return this._shipsDomestically != null;
        }

        /// <summary>
        /// Gets and sets the ShippingTime property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShippingTime")]
        public ShippingTimeType ShippingTime
        {
            get { return this._shippingTime; }
            set { this._shippingTime = value; }
        }

        /// <summary>
        /// Sets the ShippingTime property.
        /// </summary>
        /// <param name="shippingTime">ShippingTime property.</param>
        /// <returns>this instance.</returns>
        public QualifiersType WithShippingTime(ShippingTimeType shippingTime)
        {
            this._shippingTime = shippingTime;
            return this;
        }

        /// <summary>
        /// Checks if ShippingTime property is set.
        /// </summary>
        /// <returns>true if ShippingTime property is set.</returns>
        public bool IsSetShippingTime()
        {
            return this._shippingTime != null;
        }

        /// <summary>
        /// Gets and sets the SellerPositiveFeedbackRating property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerPositiveFeedbackRating")]
        public string SellerPositiveFeedbackRating
        {
            get { return this._sellerPositiveFeedbackRating; }
            set { this._sellerPositiveFeedbackRating = value; }
        }

        /// <summary>
        /// Sets the SellerPositiveFeedbackRating property.
        /// </summary>
        /// <param name="sellerPositiveFeedbackRating">SellerPositiveFeedbackRating property.</param>
        /// <returns>this instance.</returns>
        public QualifiersType WithSellerPositiveFeedbackRating(string sellerPositiveFeedbackRating)
        {
            this._sellerPositiveFeedbackRating = sellerPositiveFeedbackRating;
            return this;
        }

        /// <summary>
        /// Checks if SellerPositiveFeedbackRating property is set.
        /// </summary>
        /// <returns>true if SellerPositiveFeedbackRating property is set.</returns>
        public bool IsSetSellerPositiveFeedbackRating()
        {
            return this._sellerPositiveFeedbackRating != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _itemCondition = reader.Read<string>("ItemCondition");
            _itemSubcondition = reader.Read<string>("ItemSubcondition");
            _fulfillmentChannel = reader.Read<string>("FulfillmentChannel");
            _shipsDomestically = reader.Read<string>("ShipsDomestically");
            _shippingTime = reader.Read<ShippingTimeType>("ShippingTime");
            _sellerPositiveFeedbackRating = reader.Read<string>("SellerPositiveFeedbackRating");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ItemCondition", _itemCondition);
            writer.Write("ItemSubcondition", _itemSubcondition);
            writer.Write("FulfillmentChannel", _fulfillmentChannel);
            writer.Write("ShipsDomestically", _shipsDomestically);
            writer.Write("ShippingTime", _shippingTime);
            writer.Write("SellerPositiveFeedbackRating", _sellerPositiveFeedbackRating);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "QualifiersType", this);
        }

    public QualifiersType (string itemCondition,string itemSubcondition,string fulfillmentChannel,string shipsDomestically,ShippingTimeType shippingTime,string sellerPositiveFeedbackRating) : base() {
        this._itemCondition = itemCondition;
        this._itemSubcondition = itemSubcondition;
        this._fulfillmentChannel = fulfillmentChannel;
        this._shipsDomestically = shipsDomestically;
        this._shippingTime = shippingTime;
        this._sellerPositiveFeedbackRating = sellerPositiveFeedbackRating;
    }

        public QualifiersType() : base()
        {
        }
    }
}
