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
 * Get Lowest Offer Listings For ASIN Result
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
    public class GetLowestOfferListingsForASINResult : AbstractMwsObject
    {

        private bool? _allOfferListingsConsidered;
        private Product _product;
        private Error _error;
        private string _asin;
        private string _status;

        /// <summary>
        /// Gets and sets the AllOfferListingsConsidered property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AllOfferListingsConsidered")]
        public bool AllOfferListingsConsidered
        {
            get { return this._allOfferListingsConsidered.GetValueOrDefault(); }
            set { this._allOfferListingsConsidered = value; }
        }

        /// <summary>
        /// Sets the AllOfferListingsConsidered property.
        /// </summary>
        /// <param name="allOfferListingsConsidered">AllOfferListingsConsidered property.</param>
        /// <returns>this instance.</returns>
        public GetLowestOfferListingsForASINResult WithAllOfferListingsConsidered(bool allOfferListingsConsidered)
        {
            this._allOfferListingsConsidered = allOfferListingsConsidered;
            return this;
        }

        /// <summary>
        /// Checks if AllOfferListingsConsidered property is set.
        /// </summary>
        /// <returns>true if AllOfferListingsConsidered property is set.</returns>
        public bool IsSetAllOfferListingsConsidered()
        {
            return this._allOfferListingsConsidered != null;
        }

        /// <summary>
        /// Gets and sets the Product property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Product")]
        public Product Product
        {
            get { return this._product; }
            set { this._product = value; }
        }

        /// <summary>
        /// Sets the Product property.
        /// </summary>
        /// <param name="product">Product property.</param>
        /// <returns>this instance.</returns>
        public GetLowestOfferListingsForASINResult WithProduct(Product product)
        {
            this._product = product;
            return this;
        }

        /// <summary>
        /// Checks if Product property is set.
        /// </summary>
        /// <returns>true if Product property is set.</returns>
        public bool IsSetProduct()
        {
            return this._product != null;
        }

        /// <summary>
        /// Gets and sets the Error property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Error")]
        public Error Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        /// <summary>
        /// Sets the Error property.
        /// </summary>
        /// <param name="error">Error property.</param>
        /// <returns>this instance.</returns>
        public GetLowestOfferListingsForASINResult WithError(Error error)
        {
            this._error = error;
            return this;
        }

        /// <summary>
        /// Checks if Error property is set.
        /// </summary>
        /// <returns>true if Error property is set.</returns>
        public bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the ASIN property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "ASIN")]
        public string ASIN
        {
            get { return this._asin; }
            set { this._asin = value; }
        }

        /// <summary>
        /// Sets the ASIN property.
        /// </summary>
        /// <param name="asin">ASIN property.</param>
        /// <returns>this instance.</returns>
        public GetLowestOfferListingsForASINResult WithASIN(string asin)
        {
            this._asin = asin;
            return this;
        }

        /// <summary>
        /// Checks if ASIN property is set.
        /// </summary>
        /// <returns>true if ASIN property is set.</returns>
        public bool IsSetASIN()
        {
            return this._asin != null;
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
        public GetLowestOfferListingsForASINResult Withstatus(string status)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _asin = reader.ReadAttribute<string>("ASIN");
            _status = reader.ReadAttribute<string>("status");
            _allOfferListingsConsidered = reader.Read<bool?>("AllOfferListingsConsidered");
            _product = reader.Read<Product>("Product");
            _error = reader.Read<Error>("Error");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteAttribute("ASIN",_asin);
            writer.WriteAttribute("status",_status);
            writer.Write("AllOfferListingsConsidered", _allOfferListingsConsidered);
            writer.Write("Product", _product);
            writer.Write("Error", _error);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "GetLowestOfferListingsForASINResult", this);
        }

    public GetLowestOfferListingsForASINResult (string status) : base() {
        this._status = status;
    }

        public GetLowestOfferListingsForASINResult() : base()
        {
        }
    }
}
