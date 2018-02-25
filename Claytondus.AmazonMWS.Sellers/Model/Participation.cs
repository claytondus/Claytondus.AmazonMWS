/*******************************************************************************
 * Copyright 2009-2015 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Participation
 * API Version: 2011-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 20:37:46 GMT 2015
 */


using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Sellers.Model
{
    [XmlType(Namespace = "https://mws.amazonservices.com/Sellers/2011-07-01")]
    [XmlRootAttribute(Namespace = "https://mws.amazonservices.com/Sellers/2011-07-01", IsNullable = false)]
    public class Participation : AbstractMwsObject
    {

        private string _marketplaceId;
        private string _sellerId;
        private HasSellerSuspendedListingsEnum? _hasSellerSuspendedListings;

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
        public Participation WithMarketplaceId(string marketplaceId)
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
        public Participation WithSellerId(string sellerId)
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
        /// Gets and sets the HasSellerSuspendedListings property.
        /// </summary>
        [XmlElementAttribute(ElementName = "HasSellerSuspendedListings")]
        public HasSellerSuspendedListingsEnum HasSellerSuspendedListings
        {
            get { return this._hasSellerSuspendedListings.GetValueOrDefault(); }
            set { this._hasSellerSuspendedListings = value; }
        }

    

        /// <summary>
        /// Sets the HasSellerSuspendedListings property.
        /// </summary>
        /// <param name="hasSellerSuspendedListings">HasSellerSuspendedListings property.</param>
        /// <returns>this instance.</returns>
        public Participation WithHasSellerSuspendedListings(HasSellerSuspendedListingsEnum hasSellerSuspendedListings)
        {
            this._hasSellerSuspendedListings = hasSellerSuspendedListings;
            return this;
        }

        /// <summary>
        /// Checks if HasSellerSuspendedListings property is set.
        /// </summary>
        /// <returns>true if HasSellerSuspendedListings property is set.</returns>
        public bool IsSetHasSellerSuspendedListings()
        {
            return this._hasSellerSuspendedListings != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _sellerId = reader.Read<string>("SellerId");
            _hasSellerSuspendedListings = reader.Read<HasSellerSuspendedListingsEnum?>("HasSellerSuspendedListings");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("SellerId", _sellerId);
            writer.Write("HasSellerSuspendedListings", _hasSellerSuspendedListings);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Sellers/2011-07-01", "Participation", this);
        }

        public Participation() : base()
        {
        }
    }
}
