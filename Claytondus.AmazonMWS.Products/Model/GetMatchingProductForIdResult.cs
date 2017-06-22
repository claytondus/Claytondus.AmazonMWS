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
 * Get Matching Product For Id Result
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
    public class GetMatchingProductForIdResult : AbstractMwsObject
    {

        private ProductList _products;
        private Error _error;
        private string _id;
        private string _idType;
        private string _status;

        /// <summary>
        /// Gets and sets the Products property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Products")]
        public ProductList Products
        {
            get { return this._products; }
            set { this._products = value; }
        }

        /// <summary>
        /// Sets the Products property.
        /// </summary>
        /// <param name="products">Products property.</param>
        /// <returns>this instance.</returns>
        public GetMatchingProductForIdResult WithProducts(ProductList products)
        {
            this._products = products;
            return this;
        }

        /// <summary>
        /// Checks if Products property is set.
        /// </summary>
        /// <returns>true if Products property is set.</returns>
        public bool IsSetProducts()
        {
            return this._products != null;
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
        public GetMatchingProductForIdResult WithError(Error error)
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
        /// Gets and sets the Id property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "Id")]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        /// <summary>
        /// Sets the Id property.
        /// </summary>
        /// <param name="id">Id property.</param>
        /// <returns>this instance.</returns>
        public GetMatchingProductForIdResult WithId(string id)
        {
            this._id = id;
            return this;
        }

        /// <summary>
        /// Checks if Id property is set.
        /// </summary>
        /// <returns>true if Id property is set.</returns>
        public bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the IdType property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "IdType")]
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
        public GetMatchingProductForIdResult WithIdType(string idType)
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
        public GetMatchingProductForIdResult Withstatus(string status)
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
            _id = reader.ReadAttribute<string>("Id");
            _idType = reader.ReadAttribute<string>("IdType");
            _status = reader.ReadAttribute<string>("status");
            _products = reader.Read<ProductList>("Products");
            _error = reader.Read<Error>("Error");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteAttribute("Id",_id);
            writer.WriteAttribute("IdType",_idType);
            writer.WriteAttribute("status",_status);
            writer.Write("Products", _products);
            writer.Write("Error", _error);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "GetMatchingProductForIdResult", this);
        }

    public GetMatchingProductForIdResult (string status) : base() {
        this._status = status;
    }

        public GetMatchingProductForIdResult() : base()
        {
        }
    }
}
