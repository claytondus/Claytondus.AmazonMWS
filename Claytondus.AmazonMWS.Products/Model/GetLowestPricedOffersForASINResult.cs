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
 * Get Lowest Priced Offers For ASIN Result
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
    public class GetLowestPricedOffersForASINResult : AbstractMwsObject
    {

        private string _marketplaceID;
        private string _asin;
        private string _itemCondition;
        private string _status;
        private GetLowestPricedOffersASINIdentifier _identifier;
        private Summary _summary;
        private ASINOfferDetailList _offers;

        /// <summary>
        /// Gets and sets the MarketplaceID property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "MarketplaceID")]
        public string MarketplaceID
        {
            get { return this._marketplaceID; }
            set { this._marketplaceID = value; }
        }

        /// <summary>
        /// Sets the MarketplaceID property.
        /// </summary>
        /// <param name="marketplaceID">MarketplaceID property.</param>
        /// <returns>this instance.</returns>
        public GetLowestPricedOffersForASINResult WithMarketplaceID(string marketplaceID)
        {
            this._marketplaceID = marketplaceID;
            return this;
        }

        /// <summary>
        /// Checks if MarketplaceID property is set.
        /// </summary>
        /// <returns>true if MarketplaceID property is set.</returns>
        public bool IsSetMarketplaceID()
        {
            return this._marketplaceID != null;
        }

        /// <summary>
        /// Gets and sets the ASIN property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "ASIN")]
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
        public GetLowestPricedOffersForASINResult WithASIN(string asin)
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
        [XmlAttributeAttribute(AttributeName = "ItemCondition")]
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
        public GetLowestPricedOffersForASINResult WithItemCondition(string itemCondition)
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
        /// Gets and sets the status property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "status")]
        public string status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        /// <summary>
        /// Sets the status property.
        /// </summary>
        /// <param name="status">status property.</param>
        /// <returns>this instance.</returns>
        public GetLowestPricedOffersForASINResult Withstatus(string status)
        {
            this._status = status;
            return this;
        }

        /// <summary>
        /// Checks if status property is set.
        /// </summary>
        /// <returns>true if status property is set.</returns>
        public bool IsSetstatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the Identifier property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Identifier")]
        public GetLowestPricedOffersASINIdentifier Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        /// <summary>
        /// Sets the Identifier property.
        /// </summary>
        /// <param name="identifier">Identifier property.</param>
        /// <returns>this instance.</returns>
        public GetLowestPricedOffersForASINResult WithIdentifier(GetLowestPricedOffersASINIdentifier identifier)
        {
            this._identifier = identifier;
            return this;
        }

        /// <summary>
        /// Checks if Identifier property is set.
        /// </summary>
        /// <returns>true if Identifier property is set.</returns>
        public bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the Summary property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Summary")]
        public Summary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        /// <summary>
        /// Sets the Summary property.
        /// </summary>
        /// <param name="summary">Summary property.</param>
        /// <returns>this instance.</returns>
        public GetLowestPricedOffersForASINResult WithSummary(Summary summary)
        {
            this._summary = summary;
            return this;
        }

        /// <summary>
        /// Checks if Summary property is set.
        /// </summary>
        /// <returns>true if Summary property is set.</returns>
        public bool IsSetSummary()
        {
            return this._summary != null;
        }

        /// <summary>
        /// Gets and sets the Offers property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Offers")]
        public ASINOfferDetailList Offers
        {
            get { return this._offers; }
            set { this._offers = value; }
        }

        /// <summary>
        /// Sets the Offers property.
        /// </summary>
        /// <param name="offers">Offers property.</param>
        /// <returns>this instance.</returns>
        public GetLowestPricedOffersForASINResult WithOffers(ASINOfferDetailList offers)
        {
            this._offers = offers;
            return this;
        }

        /// <summary>
        /// Checks if Offers property is set.
        /// </summary>
        /// <returns>true if Offers property is set.</returns>
        public bool IsSetOffers()
        {
            return this._offers != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _marketplaceID = reader.ReadAttribute<string>("MarketplaceID");
            _asin = reader.ReadAttribute<string>("ASIN");
            _itemCondition = reader.ReadAttribute<string>("ItemCondition");
            _status = reader.ReadAttribute<string>("status");
            _identifier = reader.Read<GetLowestPricedOffersASINIdentifier>("Identifier");
            _summary = reader.Read<Summary>("Summary");
            _offers = reader.Read<ASINOfferDetailList>("Offers");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteAttribute("MarketplaceID",_marketplaceID);
            writer.WriteAttribute("ASIN",_asin);
            writer.WriteAttribute("ItemCondition",_itemCondition);
            writer.WriteAttribute("status",_status);
            writer.Write("Identifier", _identifier);
            writer.Write("Summary", _summary);
            writer.Write("Offers", _offers);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "GetLowestPricedOffersForASINResult", this);
        }

    public GetLowestPricedOffersForASINResult (string marketplaceID,string asin,string itemCondition,string status,GetLowestPricedOffersASINIdentifier identifier,Summary summary,ASINOfferDetailList offers) : base() {
        this._marketplaceID = marketplaceID;
        this._asin = asin;
        this._itemCondition = itemCondition;
        this._status = status;
        this._identifier = identifier;
        this._summary = summary;
        this._offers = offers;
    }

        public GetLowestPricedOffersForASINResult() : base()
        {
        }
    }
}
