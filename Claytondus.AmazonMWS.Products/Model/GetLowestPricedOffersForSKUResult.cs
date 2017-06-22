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
 * Get Lowest Priced Offers For SKU Result
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
    public class GetLowestPricedOffersForSKUResult : AbstractMwsObject
    {

        private string _marketplaceID;
        private string _sku;
        private string _itemCondition;
        private string _status;
        private GetLowestPricedOffersSkuIdentifier _identifier;
        private Summary _summary;
        private SKUOfferDetailList _offers;

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
        public GetLowestPricedOffersForSKUResult WithMarketplaceID(string marketplaceID)
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
        /// Gets and sets the SKU property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "SKU")]
        public string SKU
        {
            get { return this._sku; }
            set { this._sku = value; }
        }

        /// <summary>
        /// Sets the SKU property.
        /// </summary>
        /// <param name="sku">SKU property.</param>
        /// <returns>this instance.</returns>
        public GetLowestPricedOffersForSKUResult WithSKU(string sku)
        {
            this._sku = sku;
            return this;
        }

        /// <summary>
        /// Checks if SKU property is set.
        /// </summary>
        /// <returns>true if SKU property is set.</returns>
        public bool IsSetSKU()
        {
            return this._sku != null;
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
        public GetLowestPricedOffersForSKUResult WithItemCondition(string itemCondition)
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
        public GetLowestPricedOffersForSKUResult Withstatus(string status)
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
        public GetLowestPricedOffersSkuIdentifier Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        /// <summary>
        /// Sets the Identifier property.
        /// </summary>
        /// <param name="identifier">Identifier property.</param>
        /// <returns>this instance.</returns>
        public GetLowestPricedOffersForSKUResult WithIdentifier(GetLowestPricedOffersSkuIdentifier identifier)
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
        public GetLowestPricedOffersForSKUResult WithSummary(Summary summary)
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
        public SKUOfferDetailList Offers
        {
            get { return this._offers; }
            set { this._offers = value; }
        }

        /// <summary>
        /// Sets the Offers property.
        /// </summary>
        /// <param name="offers">Offers property.</param>
        /// <returns>this instance.</returns>
        public GetLowestPricedOffersForSKUResult WithOffers(SKUOfferDetailList offers)
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
            _sku = reader.ReadAttribute<string>("SKU");
            _itemCondition = reader.ReadAttribute<string>("ItemCondition");
            _status = reader.ReadAttribute<string>("status");
            _identifier = reader.Read<GetLowestPricedOffersSkuIdentifier>("Identifier");
            _summary = reader.Read<Summary>("Summary");
            _offers = reader.Read<SKUOfferDetailList>("Offers");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteAttribute("MarketplaceID",_marketplaceID);
            writer.WriteAttribute("SKU",_sku);
            writer.WriteAttribute("ItemCondition",_itemCondition);
            writer.WriteAttribute("status",_status);
            writer.Write("Identifier", _identifier);
            writer.Write("Summary", _summary);
            writer.Write("Offers", _offers);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "GetLowestPricedOffersForSKUResult", this);
        }

    public GetLowestPricedOffersForSKUResult (string marketplaceID,string sku,string itemCondition,string status,GetLowestPricedOffersSkuIdentifier identifier,Summary summary,SKUOfferDetailList offers) : base() {
        this._marketplaceID = marketplaceID;
        this._sku = sku;
        this._itemCondition = itemCondition;
        this._status = status;
        this._identifier = identifier;
        this._summary = summary;
        this._offers = offers;
    }

        public GetLowestPricedOffersForSKUResult() : base()
        {
        }
    }
}
