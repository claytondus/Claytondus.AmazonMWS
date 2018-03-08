/*******************************************************************************
 * Copyright 2009-2016 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * List Inventory Supply Request
 * API Version: 2010-10-01
 * Library Version: 2014-09-30
 * Generated: Mon Mar 21 09:01:30 PDT 2016
 */


using System;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaInventory.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/", IsNullable = false)]
    public class ListInventorySupplyRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private string _marketplace;
        private string _marketplaceId;
        private SellerSkuList _sellerSkus;
        private DateTime? _queryStartDateTime;
        private string _responseGroup;

        /// <summary>
        /// Gets and sets the SellerId property.
        /// </summary>
        [XmlElement(ElementName = "SellerId")]
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
        public ListInventorySupplyRequest WithSellerId(string sellerId)
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
        [XmlElement(ElementName = "MWSAuthToken")]
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
        public ListInventorySupplyRequest WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the Marketplace property.
        /// </summary>
        [XmlElement(ElementName = "Marketplace")]
        public string Marketplace
        {
            get { return this._marketplace; }
            set { this._marketplace = value; }
        }

        /// <summary>
        /// Sets the Marketplace property.
        /// </summary>
        /// <param name="marketplace">Marketplace property.</param>
        /// <returns>this instance.</returns>
        public ListInventorySupplyRequest WithMarketplace(string marketplace)
        {
            this._marketplace = marketplace;
            return this;
        }

        /// <summary>
        /// Checks if Marketplace property is set.
        /// </summary>
        /// <returns>true if Marketplace property is set.</returns>
        public bool IsSetMarketplace()
        {
            return this._marketplace != null;
        }

        /// <summary>
        /// Gets and sets the MarketplaceId property.
        /// </summary>
        [XmlElement(ElementName = "MarketplaceId")]
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
        public ListInventorySupplyRequest WithMarketplaceId(string marketplaceId)
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
        /// Gets and sets the SellerSkus property.
        /// </summary>
        [XmlElement(ElementName = "SellerSkus")]
        public SellerSkuList SellerSkus
        {
            get { return this._sellerSkus; }
            set { this._sellerSkus = value; }
        }

        /// <summary>
        /// Sets the SellerSkus property.
        /// </summary>
        /// <param name="sellerSkus">SellerSkus property.</param>
        /// <returns>this instance.</returns>
        public ListInventorySupplyRequest WithSellerSkus(SellerSkuList sellerSkus)
        {
            this._sellerSkus = sellerSkus;
            return this;
        }

        /// <summary>
        /// Checks if SellerSkus property is set.
        /// </summary>
        /// <returns>true if SellerSkus property is set.</returns>
        public bool IsSetSellerSkus()
        {
            return this._sellerSkus != null;
        }

        /// <summary>
        /// Gets and sets the QueryStartDateTime property.
        /// </summary>
        [XmlElement(ElementName = "QueryStartDateTime")]
        public DateTime QueryStartDateTime
        {
            get { return this._queryStartDateTime.GetValueOrDefault(); }
            set { this._queryStartDateTime = value; }
        }

        /// <summary>
        /// Sets the QueryStartDateTime property.
        /// </summary>
        /// <param name="queryStartDateTime">QueryStartDateTime property.</param>
        /// <returns>this instance.</returns>
        public ListInventorySupplyRequest WithQueryStartDateTime(DateTime queryStartDateTime)
        {
            this._queryStartDateTime = queryStartDateTime;
            return this;
        }

        /// <summary>
        /// Checks if QueryStartDateTime property is set.
        /// </summary>
        /// <returns>true if QueryStartDateTime property is set.</returns>
        public bool IsSetQueryStartDateTime()
        {
            return this._queryStartDateTime != null;
        }

        /// <summary>
        /// Gets and sets the ResponseGroup property.
        /// </summary>
        [XmlElement(ElementName = "ResponseGroup")]
        public string ResponseGroup
        {
            get { return this._responseGroup; }
            set { this._responseGroup = value; }
        }

        /// <summary>
        /// Sets the ResponseGroup property.
        /// </summary>
        /// <param name="responseGroup">ResponseGroup property.</param>
        /// <returns>this instance.</returns>
        public ListInventorySupplyRequest WithResponseGroup(string responseGroup)
        {
            this._responseGroup = responseGroup;
            return this;
        }

        /// <summary>
        /// Checks if ResponseGroup property is set.
        /// </summary>
        /// <returns>true if ResponseGroup property is set.</returns>
        public bool IsSetResponseGroup()
        {
            return this._responseGroup != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _marketplace = reader.Read<string>("Marketplace");
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _sellerSkus = reader.Read<SellerSkuList>("SellerSkus");
            _queryStartDateTime = reader.Read<DateTime?>("QueryStartDateTime");
            _responseGroup = reader.Read<string>("ResponseGroup");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("Marketplace", _marketplace);
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("SellerSkus", _sellerSkus);
            writer.Write("QueryStartDateTime", _queryStartDateTime);
            writer.Write("ResponseGroup", _responseGroup);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/", "ListInventorySupplyRequest", this);
        }

        public ListInventorySupplyRequest() : base()
        {
        }
    }
}
