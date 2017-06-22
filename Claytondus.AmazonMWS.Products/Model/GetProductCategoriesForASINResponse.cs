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
 * Get Product Categories For ASIN Response
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
    public class GetProductCategoriesForASINResponse : AbstractMwsObject, IMWSResponse
    {

        private GetProductCategoriesForASINResult _getProductCategoriesForASINResult;
        private ResponseMetadata _responseMetadata;
        private ResponseHeaderMetadata _responseHeaderMetadata;

        /// <summary>
        /// Gets and sets the GetProductCategoriesForASINResult property.
        /// </summary>
        [XmlElementAttribute(ElementName = "GetProductCategoriesForASINResult")]
        public GetProductCategoriesForASINResult GetProductCategoriesForASINResult
        {
            get { return this._getProductCategoriesForASINResult; }
            set { this._getProductCategoriesForASINResult = value; }
        }

        /// <summary>
        /// Sets the GetProductCategoriesForASINResult property.
        /// </summary>
        /// <param name="getProductCategoriesForASINResult">GetProductCategoriesForASINResult property.</param>
        /// <returns>this instance.</returns>
        public GetProductCategoriesForASINResponse WithGetProductCategoriesForASINResult(GetProductCategoriesForASINResult getProductCategoriesForASINResult)
        {
            this._getProductCategoriesForASINResult = getProductCategoriesForASINResult;
            return this;
        }

        /// <summary>
        /// Checks if GetProductCategoriesForASINResult property is set.
        /// </summary>
        /// <returns>true if GetProductCategoriesForASINResult property is set.</returns>
        public bool IsSetGetProductCategoriesForASINResult()
        {
            return this._getProductCategoriesForASINResult != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this._responseMetadata; }
            set { this._responseMetadata = value; }
        }

        /// <summary>
        /// Sets the ResponseMetadata property.
        /// </summary>
        /// <param name="responseMetadata">ResponseMetadata property.</param>
        /// <returns>this instance.</returns>
        public GetProductCategoriesForASINResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this._responseMetadata = responseMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseMetadata property is set.</returns>
        public bool IsSetResponseMetadata()
        {
            return this._responseMetadata != null;
        }

        /// <summary>
        /// Gets and sets the ResponseHeaderMetadata property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseHeaderMetadata")]
        public ResponseHeaderMetadata ResponseHeaderMetadata
        {
            get { return this._responseHeaderMetadata; }
            set { this._responseHeaderMetadata = value; }
        }

        /// <summary>
        /// Sets the ResponseHeaderMetadata property.
        /// </summary>
        /// <param name="responseHeaderMetadata">ResponseHeaderMetadata property.</param>
        /// <returns>this instance.</returns>
        public GetProductCategoriesForASINResponse WithResponseHeaderMetadata(ResponseHeaderMetadata responseHeaderMetadata)
        {
            this._responseHeaderMetadata = responseHeaderMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseHeaderMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseHeaderMetadata property is set.</returns>
        public bool IsSetResponseHeaderMetadata()
        {
            return this._responseHeaderMetadata != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _getProductCategoriesForASINResult = reader.Read<GetProductCategoriesForASINResult>("GetProductCategoriesForASINResult");
            _responseMetadata = reader.Read<ResponseMetadata>("ResponseMetadata");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("GetProductCategoriesForASINResult", _getProductCategoriesForASINResult);
            writer.Write("ResponseMetadata", _responseMetadata);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "GetProductCategoriesForASINResponse", this);
        }


        public GetProductCategoriesForASINResponse() : base()
        {
        }
    }
}
