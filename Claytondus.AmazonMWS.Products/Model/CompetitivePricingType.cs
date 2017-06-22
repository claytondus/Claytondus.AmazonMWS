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
 * Competitive Pricing Type
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
    public class CompetitivePricingType : AbstractMwsObject
    {

        private CompetitivePriceList _competitivePrices;
        private NumberOfOfferListingsList _numberOfOfferListings;
        private MoneyType _tradeInValue;

        /// <summary>
        /// Gets and sets the CompetitivePrices property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CompetitivePrices")]
        public CompetitivePriceList CompetitivePrices
        {
            get { return this._competitivePrices; }
            set { this._competitivePrices = value; }
        }

        /// <summary>
        /// Sets the CompetitivePrices property.
        /// </summary>
        /// <param name="competitivePrices">CompetitivePrices property.</param>
        /// <returns>this instance.</returns>
        public CompetitivePricingType WithCompetitivePrices(CompetitivePriceList competitivePrices)
        {
            this._competitivePrices = competitivePrices;
            return this;
        }

        /// <summary>
        /// Checks if CompetitivePrices property is set.
        /// </summary>
        /// <returns>true if CompetitivePrices property is set.</returns>
        public bool IsSetCompetitivePrices()
        {
            return this._competitivePrices != null;
        }

        /// <summary>
        /// Gets and sets the NumberOfOfferListings property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NumberOfOfferListings")]
        public NumberOfOfferListingsList NumberOfOfferListings
        {
            get { return this._numberOfOfferListings; }
            set { this._numberOfOfferListings = value; }
        }

        /// <summary>
        /// Sets the NumberOfOfferListings property.
        /// </summary>
        /// <param name="numberOfOfferListings">NumberOfOfferListings property.</param>
        /// <returns>this instance.</returns>
        public CompetitivePricingType WithNumberOfOfferListings(NumberOfOfferListingsList numberOfOfferListings)
        {
            this._numberOfOfferListings = numberOfOfferListings;
            return this;
        }

        /// <summary>
        /// Checks if NumberOfOfferListings property is set.
        /// </summary>
        /// <returns>true if NumberOfOfferListings property is set.</returns>
        public bool IsSetNumberOfOfferListings()
        {
            return this._numberOfOfferListings != null;
        }

        /// <summary>
        /// Gets and sets the TradeInValue property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TradeInValue")]
        public MoneyType TradeInValue
        {
            get { return this._tradeInValue; }
            set { this._tradeInValue = value; }
        }

        /// <summary>
        /// Sets the TradeInValue property.
        /// </summary>
        /// <param name="tradeInValue">TradeInValue property.</param>
        /// <returns>this instance.</returns>
        public CompetitivePricingType WithTradeInValue(MoneyType tradeInValue)
        {
            this._tradeInValue = tradeInValue;
            return this;
        }

        /// <summary>
        /// Checks if TradeInValue property is set.
        /// </summary>
        /// <returns>true if TradeInValue property is set.</returns>
        public bool IsSetTradeInValue()
        {
            return this._tradeInValue != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _competitivePrices = reader.Read<CompetitivePriceList>("CompetitivePrices");
            _numberOfOfferListings = reader.Read<NumberOfOfferListingsList>("NumberOfOfferListings");
            _tradeInValue = reader.Read<MoneyType>("TradeInValue");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("CompetitivePrices", _competitivePrices);
            writer.Write("NumberOfOfferListings", _numberOfOfferListings);
            writer.Write("TradeInValue", _tradeInValue);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "CompetitivePricingType", this);
        }

    public CompetitivePricingType (CompetitivePriceList competitivePrices,NumberOfOfferListingsList numberOfOfferListings) : base() {
        this._competitivePrices = competitivePrices;
        this._numberOfOfferListings = numberOfOfferListings;
    }

        public CompetitivePricingType() : base()
        {
        }
    }
}
