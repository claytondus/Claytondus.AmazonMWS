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
 * Lowest Offer Listing Type
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
    public class LowestOfferListingType : AbstractMwsObject
    {

        private QualifiersType _qualifiers;
        private decimal? _numberOfOfferListingsConsidered;
        private decimal _sellerFeedbackCount;
        private PriceType _price;
        private string _multipleOffersAtLowestPrice;

        /// <summary>
        /// Gets and sets the Qualifiers property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Qualifiers")]
        public QualifiersType Qualifiers
        {
            get { return this._qualifiers; }
            set { this._qualifiers = value; }
        }

        /// <summary>
        /// Sets the Qualifiers property.
        /// </summary>
        /// <param name="qualifiers">Qualifiers property.</param>
        /// <returns>this instance.</returns>
        public LowestOfferListingType WithQualifiers(QualifiersType qualifiers)
        {
            this._qualifiers = qualifiers;
            return this;
        }

        /// <summary>
        /// Checks if Qualifiers property is set.
        /// </summary>
        /// <returns>true if Qualifiers property is set.</returns>
        public bool IsSetQualifiers()
        {
            return this._qualifiers != null;
        }

        /// <summary>
        /// Gets and sets the NumberOfOfferListingsConsidered property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NumberOfOfferListingsConsidered")]
        public decimal NumberOfOfferListingsConsidered
        {
            get { return this._numberOfOfferListingsConsidered.GetValueOrDefault(); }
            set { this._numberOfOfferListingsConsidered = value; }
        }

        /// <summary>
        /// Sets the NumberOfOfferListingsConsidered property.
        /// </summary>
        /// <param name="numberOfOfferListingsConsidered">NumberOfOfferListingsConsidered property.</param>
        /// <returns>this instance.</returns>
        public LowestOfferListingType WithNumberOfOfferListingsConsidered(decimal numberOfOfferListingsConsidered)
        {
            this._numberOfOfferListingsConsidered = numberOfOfferListingsConsidered;
            return this;
        }

        /// <summary>
        /// Checks if NumberOfOfferListingsConsidered property is set.
        /// </summary>
        /// <returns>true if NumberOfOfferListingsConsidered property is set.</returns>
        public bool IsSetNumberOfOfferListingsConsidered()
        {
            return this._numberOfOfferListingsConsidered != null;
        }

        /// <summary>
        /// Gets and sets the SellerFeedbackCount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerFeedbackCount")]
        public decimal SellerFeedbackCount
        {
            get { return this._sellerFeedbackCount; }
            set { this._sellerFeedbackCount = value; }
        }

        /// <summary>
        /// Sets the SellerFeedbackCount property.
        /// </summary>
        /// <param name="sellerFeedbackCount">SellerFeedbackCount property.</param>
        /// <returns>this instance.</returns>
        public LowestOfferListingType WithSellerFeedbackCount(decimal sellerFeedbackCount)
        {
            this._sellerFeedbackCount = sellerFeedbackCount;
            return this;
        }

        /// <summary>
        /// Checks if SellerFeedbackCount property is set.
        /// </summary>
        /// <returns>true if SellerFeedbackCount property is set.</returns>
        public bool IsSetSellerFeedbackCount()
        {
            return this._sellerFeedbackCount != null;
        }

        /// <summary>
        /// Gets and sets the Price property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Price")]
        public PriceType Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        /// <summary>
        /// Sets the Price property.
        /// </summary>
        /// <param name="price">Price property.</param>
        /// <returns>this instance.</returns>
        public LowestOfferListingType WithPrice(PriceType price)
        {
            this._price = price;
            return this;
        }

        /// <summary>
        /// Checks if Price property is set.
        /// </summary>
        /// <returns>true if Price property is set.</returns>
        public bool IsSetPrice()
        {
            return this._price != null;
        }

        /// <summary>
        /// Gets and sets the MultipleOffersAtLowestPrice property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MultipleOffersAtLowestPrice")]
        public string MultipleOffersAtLowestPrice
        {
            get { return this._multipleOffersAtLowestPrice; }
            set { this._multipleOffersAtLowestPrice = value; }
        }

        /// <summary>
        /// Sets the MultipleOffersAtLowestPrice property.
        /// </summary>
        /// <param name="multipleOffersAtLowestPrice">MultipleOffersAtLowestPrice property.</param>
        /// <returns>this instance.</returns>
        public LowestOfferListingType WithMultipleOffersAtLowestPrice(string multipleOffersAtLowestPrice)
        {
            this._multipleOffersAtLowestPrice = multipleOffersAtLowestPrice;
            return this;
        }

        /// <summary>
        /// Checks if MultipleOffersAtLowestPrice property is set.
        /// </summary>
        /// <returns>true if MultipleOffersAtLowestPrice property is set.</returns>
        public bool IsSetMultipleOffersAtLowestPrice()
        {
            return this._multipleOffersAtLowestPrice != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _qualifiers = reader.Read<QualifiersType>("Qualifiers");
            _numberOfOfferListingsConsidered = reader.Read<decimal?>("NumberOfOfferListingsConsidered");
            _sellerFeedbackCount = reader.Read<decimal>("SellerFeedbackCount");
            _price = reader.Read<PriceType>("Price");
            _multipleOffersAtLowestPrice = reader.Read<string>("MultipleOffersAtLowestPrice");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Qualifiers", _qualifiers);
            writer.Write("NumberOfOfferListingsConsidered", _numberOfOfferListingsConsidered);
            writer.Write("SellerFeedbackCount", _sellerFeedbackCount);
            writer.Write("Price", _price);
            writer.Write("MultipleOffersAtLowestPrice", _multipleOffersAtLowestPrice);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "LowestOfferListingType", this);
        }

    public LowestOfferListingType (QualifiersType qualifiers,decimal sellerFeedbackCount,PriceType price,string multipleOffersAtLowestPrice) : base() {
        this._qualifiers = qualifiers;
        this._sellerFeedbackCount = sellerFeedbackCount;
        this._price = price;
        this._multipleOffersAtLowestPrice = multipleOffersAtLowestPrice;
    }

        public LowestOfferListingType() : base()
        {
        }
    }
}
