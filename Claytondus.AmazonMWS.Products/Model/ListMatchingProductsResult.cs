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
 * List Matching Products Result
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
    public class ListMatchingProductsResult : AbstractMwsObject
    {

        private ProductList _products;

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
        public ListMatchingProductsResult WithProducts(ProductList products)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _products = reader.Read<ProductList>("Products");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Products", _products);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "ListMatchingProductsResult", this);
        }


        public ListMatchingProductsResult() : base()
        {
        }
    }
}
