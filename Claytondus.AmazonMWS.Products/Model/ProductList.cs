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
 * Product List
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */


using System;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Products.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false)]
    public class ProductList : AbstractMwsObject
    {

        private List<Product> _product;

        /// <summary>
        /// Gets and sets the Product property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Product")]
        public List<Product> Product
        {
            get
            {
                if(this._product == null)
                {
                    this._product = new List<Product>();
                }
                return this._product;
            }
            set { this._product = value; }
        }

        /// <summary>
        /// Sets the Product property.
        /// </summary>
        /// <param name="product">Product property.</param>
        /// <returns>this instance.</returns>
        public ProductList WithProduct(Product[] product)
        {
            this._product.AddRange(product);
            return this;
        }

        /// <summary>
        /// Checks if Product property is set.
        /// </summary>
        /// <returns>true if Product property is set.</returns>
        public bool IsSetProduct()
        {
            return this.Product.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _product = reader.ReadList<Product>("Product");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("Product", _product);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "ProductList", this);
        }


        public ProductList() : base()
        {
        }
    }
}
