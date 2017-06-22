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
 * List Matching Products Request
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
    public class ListMatchingProductsRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private string _marketplaceId;
        private string _query;
        private string _queryContextId;

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
        public ListMatchingProductsRequest WithSellerId(string sellerId)
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
        public ListMatchingProductsRequest WithMWSAuthToken(string mwsAuthToken)
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
        public ListMatchingProductsRequest WithMarketplaceId(string marketplaceId)
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
        /// Gets and sets the Query property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Query")]
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        /// <summary>
        /// Sets the Query property.
        /// </summary>
        /// <param name="query">Query property.</param>
        /// <returns>this instance.</returns>
        public ListMatchingProductsRequest WithQuery(string query)
        {
            this._query = query;
            return this;
        }

        /// <summary>
        /// Checks if Query property is set.
        /// </summary>
        /// <returns>true if Query property is set.</returns>
        public bool IsSetQuery()
        {
            return this._query != null;
        }

        /// <summary>
        /// Gets and sets the QueryContextId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "QueryContextId")]
        public string QueryContextId
        {
            get { return this._queryContextId; }
            set { this._queryContextId = value; }
        }

        /// <summary>
        /// Sets the QueryContextId property.
        /// </summary>
        /// <param name="queryContextId">QueryContextId property.</param>
        /// <returns>this instance.</returns>
        public ListMatchingProductsRequest WithQueryContextId(string queryContextId)
        {
            this._queryContextId = queryContextId;
            return this;
        }

        /// <summary>
        /// Checks if QueryContextId property is set.
        /// </summary>
        /// <returns>true if QueryContextId property is set.</returns>
        public bool IsSetQueryContextId()
        {
            return this._queryContextId != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _query = reader.Read<string>("Query");
            _queryContextId = reader.Read<string>("QueryContextId");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("Query", _query);
            writer.Write("QueryContextId", _queryContextId);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "ListMatchingProductsRequest", this);
        }

    public ListMatchingProductsRequest (string sellerId,string marketplaceId,string query) : base() {
        this._sellerId = sellerId;
        this._marketplaceId = marketplaceId;
        this._query = query;
    }

        public ListMatchingProductsRequest() : base()
        {
        }
    }
}
