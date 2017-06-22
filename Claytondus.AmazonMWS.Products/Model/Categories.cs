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
 * Categories
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
    public class Categories : AbstractMwsObject
    {

        private string _productCategoryId;
        private string _productCategoryName;
        private Categories _parent;

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
        public Categories WithProductCategoryId(string productCategoryId)
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
        /// Gets and sets the ProductCategoryName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductCategoryName")]
        public string ProductCategoryName
        {
            get { return this._productCategoryName; }
            set { this._productCategoryName = value; }
        }

        /// <summary>
        /// Sets the ProductCategoryName property.
        /// </summary>
        /// <param name="productCategoryName">ProductCategoryName property.</param>
        /// <returns>this instance.</returns>
        public Categories WithProductCategoryName(string productCategoryName)
        {
            this._productCategoryName = productCategoryName;
            return this;
        }

        /// <summary>
        /// Checks if ProductCategoryName property is set.
        /// </summary>
        /// <returns>true if ProductCategoryName property is set.</returns>
        public bool IsSetProductCategoryName()
        {
            return this._productCategoryName != null;
        }

        /// <summary>
        /// Gets and sets the Parent property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Parent")]
        public Categories Parent
        {
            get { return this._parent; }
            set { this._parent = value; }
        }

        /// <summary>
        /// Sets the Parent property.
        /// </summary>
        /// <param name="parent">Parent property.</param>
        /// <returns>this instance.</returns>
        public Categories WithParent(Categories parent)
        {
            this._parent = parent;
            return this;
        }

        /// <summary>
        /// Checks if Parent property is set.
        /// </summary>
        /// <returns>true if Parent property is set.</returns>
        public bool IsSetParent()
        {
            return this._parent != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _productCategoryId = reader.Read<string>("ProductCategoryId");
            _productCategoryName = reader.Read<string>("ProductCategoryName");
            _parent = reader.Read<Categories>("Parent");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ProductCategoryId", _productCategoryId);
            writer.Write("ProductCategoryName", _productCategoryName);
            writer.Write("Parent", _parent);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "Categories", this);
        }


        public Categories() : base()
        {
        }
    }
}
