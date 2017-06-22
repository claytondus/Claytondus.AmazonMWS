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
 * Summary
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
    public class Summary : AbstractMwsObject
    {

        private decimal _totalOfferCount;
        private NumberOfOffers _numberOfOffers;
        private LowestPrices _lowestPrices;
        private BuyBoxPrices _buyBoxPrices;
        private MoneyType _listPrice;
        private MoneyType _suggestedLowerPricePlusShipping;
        private BuyBoxEligibleOffers _buyBoxEligibleOffers;
        private DateTime? _offersAvailableTime;

        /// <summary>
        /// Gets and sets the TotalOfferCount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TotalOfferCount")]
        public decimal TotalOfferCount
        {
            get { return this._totalOfferCount; }
            set { this._totalOfferCount = value; }
        }

        /// <summary>
        /// Sets the TotalOfferCount property.
        /// </summary>
        /// <param name="totalOfferCount">TotalOfferCount property.</param>
        /// <returns>this instance.</returns>
        public Summary WithTotalOfferCount(decimal totalOfferCount)
        {
            this._totalOfferCount = totalOfferCount;
            return this;
        }

        /// <summary>
        /// Checks if TotalOfferCount property is set.
        /// </summary>
        /// <returns>true if TotalOfferCount property is set.</returns>
        public bool IsSetTotalOfferCount()
        {
            return this._totalOfferCount != null;
        }

        /// <summary>
        /// Gets and sets the NumberOfOffers property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NumberOfOffers")]
        public NumberOfOffers NumberOfOffers
        {
            get { return this._numberOfOffers; }
            set { this._numberOfOffers = value; }
        }

        /// <summary>
        /// Sets the NumberOfOffers property.
        /// </summary>
        /// <param name="numberOfOffers">NumberOfOffers property.</param>
        /// <returns>this instance.</returns>
        public Summary WithNumberOfOffers(NumberOfOffers numberOfOffers)
        {
            this._numberOfOffers = numberOfOffers;
            return this;
        }

        /// <summary>
        /// Checks if NumberOfOffers property is set.
        /// </summary>
        /// <returns>true if NumberOfOffers property is set.</returns>
        public bool IsSetNumberOfOffers()
        {
            return this._numberOfOffers != null;
        }

        /// <summary>
        /// Gets and sets the LowestPrices property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LowestPrices")]
        public LowestPrices LowestPrices
        {
            get { return this._lowestPrices; }
            set { this._lowestPrices = value; }
        }

        /// <summary>
        /// Sets the LowestPrices property.
        /// </summary>
        /// <param name="lowestPrices">LowestPrices property.</param>
        /// <returns>this instance.</returns>
        public Summary WithLowestPrices(LowestPrices lowestPrices)
        {
            this._lowestPrices = lowestPrices;
            return this;
        }

        /// <summary>
        /// Checks if LowestPrices property is set.
        /// </summary>
        /// <returns>true if LowestPrices property is set.</returns>
        public bool IsSetLowestPrices()
        {
            return this._lowestPrices != null;
        }

        /// <summary>
        /// Gets and sets the BuyBoxPrices property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BuyBoxPrices")]
        public BuyBoxPrices BuyBoxPrices
        {
            get { return this._buyBoxPrices; }
            set { this._buyBoxPrices = value; }
        }

        /// <summary>
        /// Sets the BuyBoxPrices property.
        /// </summary>
        /// <param name="buyBoxPrices">BuyBoxPrices property.</param>
        /// <returns>this instance.</returns>
        public Summary WithBuyBoxPrices(BuyBoxPrices buyBoxPrices)
        {
            this._buyBoxPrices = buyBoxPrices;
            return this;
        }

        /// <summary>
        /// Checks if BuyBoxPrices property is set.
        /// </summary>
        /// <returns>true if BuyBoxPrices property is set.</returns>
        public bool IsSetBuyBoxPrices()
        {
            return this._buyBoxPrices != null;
        }

        /// <summary>
        /// Gets and sets the ListPrice property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ListPrice")]
        public MoneyType ListPrice
        {
            get { return this._listPrice; }
            set { this._listPrice = value; }
        }

        /// <summary>
        /// Sets the ListPrice property.
        /// </summary>
        /// <param name="listPrice">ListPrice property.</param>
        /// <returns>this instance.</returns>
        public Summary WithListPrice(MoneyType listPrice)
        {
            this._listPrice = listPrice;
            return this;
        }

        /// <summary>
        /// Checks if ListPrice property is set.
        /// </summary>
        /// <returns>true if ListPrice property is set.</returns>
        public bool IsSetListPrice()
        {
            return this._listPrice != null;
        }

        /// <summary>
        /// Gets and sets the SuggestedLowerPricePlusShipping property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SuggestedLowerPricePlusShipping")]
        public MoneyType SuggestedLowerPricePlusShipping
        {
            get { return this._suggestedLowerPricePlusShipping; }
            set { this._suggestedLowerPricePlusShipping = value; }
        }

        /// <summary>
        /// Sets the SuggestedLowerPricePlusShipping property.
        /// </summary>
        /// <param name="suggestedLowerPricePlusShipping">SuggestedLowerPricePlusShipping property.</param>
        /// <returns>this instance.</returns>
        public Summary WithSuggestedLowerPricePlusShipping(MoneyType suggestedLowerPricePlusShipping)
        {
            this._suggestedLowerPricePlusShipping = suggestedLowerPricePlusShipping;
            return this;
        }

        /// <summary>
        /// Checks if SuggestedLowerPricePlusShipping property is set.
        /// </summary>
        /// <returns>true if SuggestedLowerPricePlusShipping property is set.</returns>
        public bool IsSetSuggestedLowerPricePlusShipping()
        {
            return this._suggestedLowerPricePlusShipping != null;
        }

        /// <summary>
        /// Gets and sets the BuyBoxEligibleOffers property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BuyBoxEligibleOffers")]
        public BuyBoxEligibleOffers BuyBoxEligibleOffers
        {
            get { return this._buyBoxEligibleOffers; }
            set { this._buyBoxEligibleOffers = value; }
        }

        /// <summary>
        /// Sets the BuyBoxEligibleOffers property.
        /// </summary>
        /// <param name="buyBoxEligibleOffers">BuyBoxEligibleOffers property.</param>
        /// <returns>this instance.</returns>
        public Summary WithBuyBoxEligibleOffers(BuyBoxEligibleOffers buyBoxEligibleOffers)
        {
            this._buyBoxEligibleOffers = buyBoxEligibleOffers;
            return this;
        }

        /// <summary>
        /// Checks if BuyBoxEligibleOffers property is set.
        /// </summary>
        /// <returns>true if BuyBoxEligibleOffers property is set.</returns>
        public bool IsSetBuyBoxEligibleOffers()
        {
            return this._buyBoxEligibleOffers != null;
        }

        /// <summary>
        /// Gets and sets the OffersAvailableTime property.
        /// </summary>
        [XmlElementAttribute(ElementName = "OffersAvailableTime")]
        public DateTime OffersAvailableTime
        {
            get { return this._offersAvailableTime.GetValueOrDefault(); }
            set { this._offersAvailableTime = value; }
        }

        /// <summary>
        /// Sets the OffersAvailableTime property.
        /// </summary>
        /// <param name="offersAvailableTime">OffersAvailableTime property.</param>
        /// <returns>this instance.</returns>
        public Summary WithOffersAvailableTime(DateTime offersAvailableTime)
        {
            this._offersAvailableTime = offersAvailableTime;
            return this;
        }

        /// <summary>
        /// Checks if OffersAvailableTime property is set.
        /// </summary>
        /// <returns>true if OffersAvailableTime property is set.</returns>
        public bool IsSetOffersAvailableTime()
        {
            return this._offersAvailableTime != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _totalOfferCount = reader.Read<decimal>("TotalOfferCount");
            _numberOfOffers = reader.Read<NumberOfOffers>("NumberOfOffers");
            _lowestPrices = reader.Read<LowestPrices>("LowestPrices");
            _buyBoxPrices = reader.Read<BuyBoxPrices>("BuyBoxPrices");
            _listPrice = reader.Read<MoneyType>("ListPrice");
            _suggestedLowerPricePlusShipping = reader.Read<MoneyType>("SuggestedLowerPricePlusShipping");
            _buyBoxEligibleOffers = reader.Read<BuyBoxEligibleOffers>("BuyBoxEligibleOffers");
            _offersAvailableTime = reader.Read<DateTime?>("OffersAvailableTime");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("TotalOfferCount", _totalOfferCount);
            writer.Write("NumberOfOffers", _numberOfOffers);
            writer.Write("LowestPrices", _lowestPrices);
            writer.Write("BuyBoxPrices", _buyBoxPrices);
            writer.Write("ListPrice", _listPrice);
            writer.Write("SuggestedLowerPricePlusShipping", _suggestedLowerPricePlusShipping);
            writer.Write("BuyBoxEligibleOffers", _buyBoxEligibleOffers);
            writer.Write("OffersAvailableTime", _offersAvailableTime);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "Summary", this);
        }

    public Summary (decimal totalOfferCount) : base() {
        this._totalOfferCount = totalOfferCount;
    }

        public Summary() : base()
        {
        }
    }
}
