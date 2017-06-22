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
 * Sales Rank Type
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
    public class SalesRankType : AbstractMwsObject
    {

        private string _productCategoryId;
        private decimal _rank;

        /// <summary>
        /// Gets and sets the ProductCategoryId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductCategoryId")]
        public string ProductCategoryId
        {
            get { return this._productCategoryId; }
            set { this._productCategoryId = value; }
        }

        /// <summary>
        /// Sets the ProductCategoryId property.
        /// </summary>
        /// <param name="productCategoryId">ProductCategoryId property.</param>
        /// <returns>this instance.</returns>
        public SalesRankType WithProductCategoryId(string productCategoryId)
        {
            this._productCategoryId = productCategoryId;
            return this;
        }

        /// <summary>
        /// Checks if ProductCategoryId property is set.
        /// </summary>
        /// <returns>true if ProductCategoryId property is set.</returns>
        public bool IsSetProductCategoryId()
        {
            return this._productCategoryId != null;
        }

        /// <summary>
        /// Gets and sets the Rank property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Rank")]
        public decimal Rank
        {
            get { return this._rank; }
            set { this._rank = value; }
        }

        /// <summary>
        /// Sets the Rank property.
        /// </summary>
        /// <param name="rank">Rank property.</param>
        /// <returns>this instance.</returns>
        public SalesRankType WithRank(decimal rank)
        {
            this._rank = rank;
            return this;
        }

        /// <summary>
        /// Checks if Rank property is set.
        /// </summary>
        /// <returns>true if Rank property is set.</returns>
        public bool IsSetRank()
        {
            return this._rank != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _productCategoryId = reader.Read<string>("ProductCategoryId");
            _rank = reader.Read<decimal>("Rank");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ProductCategoryId", _productCategoryId);
            writer.Write("Rank", _rank);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "SalesRankType", this);
        }

    public SalesRankType (string productCategoryId,decimal rank) : base() {
        this._productCategoryId = productCategoryId;
        this._rank = rank;
    }

        public SalesRankType() : base()
        {
        }
    }
}
