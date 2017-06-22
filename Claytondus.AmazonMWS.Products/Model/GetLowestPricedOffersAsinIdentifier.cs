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
 * Get Lowest Priced Offers ASIN Identifier
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
    public class GetLowestPricedOffersASINIdentifier : AbstractMwsObject
    {

        private string _marketplaceId;
        private string _asin;
        private string _itemCondition;
        private DateTime? _timeOfOfferChange;

        /// <summary>
        /// Gets and sets the MarketplaceId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MarketplaceId")]
        public string MarketplaceId
        {
            get { return this._marketplaceId; }
            set { this._marketplaceId = value; }
        }

        /// <summary>
        /// Sets the MarketplaceId property.
        /// </summary>
        /// <param name="marketplaceId">MarketplaceId property.</param>
        /// <returns>this instance.</returns>
        public GetLowestPricedOffersASINIdentifier WithMarketplaceId(string marketplaceId)
        {
            this._marketplaceId = marketplaceId;
            return this;
        }

        /// <summary>
        /// Checks if MarketplaceId property is set.
        /// </summary>
        /// <returns>true if MarketplaceId property is set.</returns>
        public bool IsSetMarketplaceId()
        {
            return this._marketplaceId != null;
        }

        /// <summary>
        /// Gets and sets the ASIN property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ASIN")]
        public string ASIN
        {
            get { return this._asin; }
            set { this._asin = value; }
        }

        /// <summary>
        /// Sets the ASIN property.
        /// </summary>
        /// <param name="asin">ASIN property.</param>
        /// <returns>this instance.</returns>
        public GetLowestPricedOffersASINIdentifier WithASIN(string asin)
        {
            this._asin = asin;
            return this;
        }

        /// <summary>
        /// Checks if ASIN property is set.
        /// </summary>
        /// <returns>true if ASIN property is set.</returns>
        public bool IsSetASIN()
        {
            return this._asin != null;
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
        public GetLowestPricedOffersASINIdentifier WithItemCondition(string itemCondition)
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
        /// Gets and sets the TimeOfOfferChange property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TimeOfOfferChange")]
        public DateTime TimeOfOfferChange
        {
            get { return this._timeOfOfferChange.GetValueOrDefault(); }
            set { this._timeOfOfferChange = value; }
        }

        /// <summary>
        /// Sets the TimeOfOfferChange property.
        /// </summary>
        /// <param name="timeOfOfferChange">TimeOfOfferChange property.</param>
        /// <returns>this instance.</returns>
        public GetLowestPricedOffersASINIdentifier WithTimeOfOfferChange(DateTime timeOfOfferChange)
        {
            this._timeOfOfferChange = timeOfOfferChange;
            return this;
        }

        /// <summary>
        /// Checks if TimeOfOfferChange property is set.
        /// </summary>
        /// <returns>true if TimeOfOfferChange property is set.</returns>
        public bool IsSetTimeOfOfferChange()
        {
            return this._timeOfOfferChange != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _asin = reader.Read<string>("ASIN");
            _itemCondition = reader.Read<string>("ItemCondition");
            _timeOfOfferChange = reader.Read<DateTime?>("TimeOfOfferChange");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("ASIN", _asin);
            writer.Write("ItemCondition", _itemCondition);
            writer.Write("TimeOfOfferChange", _timeOfOfferChange);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "GetLowestPricedOffersASINIdentifier", this);
        }

    public GetLowestPricedOffersASINIdentifier (string marketplaceId,string asin,string itemCondition) : base() {
        this._marketplaceId = marketplaceId;
        this._asin = asin;
        this._itemCondition = itemCondition;
    }

        public GetLowestPricedOffersASINIdentifier() : base()
        {
        }
    }
}
