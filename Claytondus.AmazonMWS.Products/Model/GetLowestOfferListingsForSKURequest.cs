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
 * Get Lowest Offer Listings For SKU Request
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
    public class GetLowestOfferListingsForSKURequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private string _marketplaceId;
        private SellerSKUListType _sellerSKUList;
        private string _itemCondition;
        private bool? _excludeMe;

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
        public GetLowestOfferListingsForSKURequest WithSellerId(string sellerId)
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
        /// Gets and sets the MWSAuthToken property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MWSAuthToken")]
        public string MWSAuthToken
        {
            get { return this._mwsAuthToken; }
            set { this._mwsAuthToken = value; }
        }

        /// <summary>
        /// Sets the MWSAuthToken property.
        /// </summary>
        /// <param name="mwsAuthToken">MWSAuthToken property.</param>
        /// <returns>this instance.</returns>
        public GetLowestOfferListingsForSKURequest WithMWSAuthToken(string mwsAuthToken)
        {
            this._mwsAuthToken = mwsAuthToken;
            return this;
        }

        /// <summary>
        /// Checks if MWSAuthToken property is set.
        /// </summary>
        /// <returns>true if MWSAuthToken property is set.</returns>
        public bool IsSetMWSAuthToken()
        {
            return this._mwsAuthToken != null;
        }

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
        public GetLowestOfferListingsForSKURequest WithMarketplaceId(string marketplaceId)
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
        /// Gets and sets the SellerSKUList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerSKUList")]
        public SellerSKUListType SellerSKUList
        {
            get { return this._sellerSKUList; }
            set { this._sellerSKUList = value; }
        }

        /// <summary>
        /// Sets the SellerSKUList property.
        /// </summary>
        /// <param name="sellerSKUList">SellerSKUList property.</param>
        /// <returns>this instance.</returns>
        public GetLowestOfferListingsForSKURequest WithSellerSKUList(SellerSKUListType sellerSKUList)
        {
            this._sellerSKUList = sellerSKUList;
            return this;
        }

        /// <summary>
        /// Checks if SellerSKUList property is set.
        /// </summary>
        /// <returns>true if SellerSKUList property is set.</returns>
        public bool IsSetSellerSKUList()
        {
            return this._sellerSKUList != null;
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
        public GetLowestOfferListingsForSKURequest WithItemCondition(string itemCondition)
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
        /// Gets and sets the ExcludeMe property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ExcludeMe")]
        public bool ExcludeMe
        {
            get { return this._excludeMe.GetValueOrDefault(); }
            set { this._excludeMe = value; }
        }

        /// <summary>
        /// Sets the ExcludeMe property.
        /// </summary>
        /// <param name="excludeMe">ExcludeMe property.</param>
        /// <returns>this instance.</returns>
        public GetLowestOfferListingsForSKURequest WithExcludeMe(bool excludeMe)
        {
            this._excludeMe = excludeMe;
            return this;
        }

        /// <summary>
        /// Checks if ExcludeMe property is set.
        /// </summary>
        /// <returns>true if ExcludeMe property is set.</returns>
        public bool IsSetExcludeMe()
        {
            return this._excludeMe != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _sellerSKUList = reader.Read<SellerSKUListType>("SellerSKUList");
            _itemCondition = reader.Read<string>("ItemCondition");
            _excludeMe = reader.Read<bool?>("ExcludeMe");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("SellerSKUList", _sellerSKUList);
            writer.Write("ItemCondition", _itemCondition);
            writer.Write("ExcludeMe", _excludeMe);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "GetLowestOfferListingsForSKURequest", this);
        }

    public GetLowestOfferListingsForSKURequest (string sellerId,string marketplaceId,SellerSKUListType sellerSKUList) : base() {
        this._sellerId = sellerId;
        this._marketplaceId = marketplaceId;
        this._sellerSKUList = sellerSKUList;
    }

        public GetLowestOfferListingsForSKURequest() : base()
        {
        }
    }
}
