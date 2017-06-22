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
 * Fees Estimate Request
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
    public class FeesEstimateRequest : AbstractMwsObject
    {

        private string _marketplaceId;
        private string _idType;
        private string _idValue;
        private bool? _isAmazonFulfilled;
        private PriceToEstimateFees _priceToEstimateFees;
        private string _identifier;

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
        public FeesEstimateRequest WithMarketplaceId(string marketplaceId)
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
        /// Gets and sets the IdType property.
        /// </summary>
        [XmlElementAttribute(ElementName = "IdType")]
        public string IdType
        {
            get { return this._idType; }
            set { this._idType = value; }
        }

        /// <summary>
        /// Sets the IdType property.
        /// </summary>
        /// <param name="idType">IdType property.</param>
        /// <returns>this instance.</returns>
        public FeesEstimateRequest WithIdType(string idType)
        {
            this._idType = idType;
            return this;
        }

        /// <summary>
        /// Checks if IdType property is set.
        /// </summary>
        /// <returns>true if IdType property is set.</returns>
        public bool IsSetIdType()
        {
            return this._idType != null;
        }

        /// <summary>
        /// Gets and sets the IdValue property.
        /// </summary>
        [XmlElementAttribute(ElementName = "IdValue")]
        public string IdValue
        {
            get { return this._idValue; }
            set { this._idValue = value; }
        }

        /// <summary>
        /// Sets the IdValue property.
        /// </summary>
        /// <param name="idValue">IdValue property.</param>
        /// <returns>this instance.</returns>
        public FeesEstimateRequest WithIdValue(string idValue)
        {
            this._idValue = idValue;
            return this;
        }

        /// <summary>
        /// Checks if IdValue property is set.
        /// </summary>
        /// <returns>true if IdValue property is set.</returns>
        public bool IsSetIdValue()
        {
            return this._idValue != null;
        }

        /// <summary>
        /// Gets and sets the IsAmazonFulfilled property.
        /// </summary>
        [XmlElementAttribute(ElementName = "IsAmazonFulfilled")]
        public bool IsAmazonFulfilled
        {
            get { return this._isAmazonFulfilled.GetValueOrDefault(); }
            set { this._isAmazonFulfilled = value; }
        }

        /// <summary>
        /// Sets the IsAmazonFulfilled property.
        /// </summary>
        /// <param name="isAmazonFulfilled">IsAmazonFulfilled property.</param>
        /// <returns>this instance.</returns>
        public FeesEstimateRequest WithIsAmazonFulfilled(bool isAmazonFulfilled)
        {
            this._isAmazonFulfilled = isAmazonFulfilled;
            return this;
        }

        /// <summary>
        /// Checks if IsAmazonFulfilled property is set.
        /// </summary>
        /// <returns>true if IsAmazonFulfilled property is set.</returns>
        public bool IsSetIsAmazonFulfilled()
        {
            return this._isAmazonFulfilled != null;
        }

        /// <summary>
        /// Gets and sets the PriceToEstimateFees property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PriceToEstimateFees")]
        public PriceToEstimateFees PriceToEstimateFees
        {
            get { return this._priceToEstimateFees; }
            set { this._priceToEstimateFees = value; }
        }

        /// <summary>
        /// Sets the PriceToEstimateFees property.
        /// </summary>
        /// <param name="priceToEstimateFees">PriceToEstimateFees property.</param>
        /// <returns>this instance.</returns>
        public FeesEstimateRequest WithPriceToEstimateFees(PriceToEstimateFees priceToEstimateFees)
        {
            this._priceToEstimateFees = priceToEstimateFees;
            return this;
        }

        /// <summary>
        /// Checks if PriceToEstimateFees property is set.
        /// </summary>
        /// <returns>true if PriceToEstimateFees property is set.</returns>
        public bool IsSetPriceToEstimateFees()
        {
            return this._priceToEstimateFees != null;
        }

        /// <summary>
        /// Gets and sets the Identifier property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Identifier")]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        /// <summary>
        /// Sets the Identifier property.
        /// </summary>
        /// <param name="identifier">Identifier property.</param>
        /// <returns>this instance.</returns>
        public FeesEstimateRequest WithIdentifier(string identifier)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _idType = reader.Read<string>("IdType");
            _idValue = reader.Read<string>("IdValue");
            _isAmazonFulfilled = reader.Read<bool?>("IsAmazonFulfilled");
            _priceToEstimateFees = reader.Read<PriceToEstimateFees>("PriceToEstimateFees");
            _identifier = reader.Read<string>("Identifier");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("IdType", _idType);
            writer.Write("IdValue", _idValue);
            writer.Write("IsAmazonFulfilled", _isAmazonFulfilled);
            writer.Write("PriceToEstimateFees", _priceToEstimateFees);
            writer.Write("Identifier", _identifier);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "FeesEstimateRequest", this);
        }

    public FeesEstimateRequest (string marketplaceId,string idType,string idValue,PriceToEstimateFees priceToEstimateFees,string identifier) : base() {
        this._marketplaceId = marketplaceId;
        this._idType = idType;
        this._idValue = idValue;
        this._priceToEstimateFees = priceToEstimateFees;
        this._identifier = identifier;
    }

        public FeesEstimateRequest() : base()
        {
        }
    }
}
