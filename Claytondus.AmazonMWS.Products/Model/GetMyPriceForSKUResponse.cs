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
 * Get My Price For SKU Response
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
    public class GetMyPriceForSKUResponse : AbstractMwsObject, IMWSResponse
    {

        private List<GetMyPriceForSKUResult> _getMyPriceForSKUResult;
        private ResponseMetadata _responseMetadata;
        private ResponseHeaderMetadata _responseHeaderMetadata;

        /// <summary>
        /// Gets and sets the GetMyPriceForSKUResult property.
        /// </summary>
        [XmlElementAttribute(ElementName = "GetMyPriceForSKUResult")]
        public List<GetMyPriceForSKUResult> GetMyPriceForSKUResult
        {
            get
            {
                if(this._getMyPriceForSKUResult == null)
                {
                    this._getMyPriceForSKUResult = new List<GetMyPriceForSKUResult>();
                }
                return this._getMyPriceForSKUResult;
            }
            set { this._getMyPriceForSKUResult = value; }
        }

        /// <summary>
        /// Sets the GetMyPriceForSKUResult property.
        /// </summary>
        /// <param name="getMyPriceForSKUResult">GetMyPriceForSKUResult property.</param>
        /// <returns>this instance.</returns>
        public GetMyPriceForSKUResponse WithGetMyPriceForSKUResult(GetMyPriceForSKUResult[] getMyPriceForSKUResult)
        {
            this._getMyPriceForSKUResult.AddRange(getMyPriceForSKUResult);
            return this;
        }

        /// <summary>
        /// Checks if GetMyPriceForSKUResult property is set.
        /// </summary>
        /// <returns>true if GetMyPriceForSKUResult property is set.</returns>
        public bool IsSetGetMyPriceForSKUResult()
        {
            return this.GetMyPriceForSKUResult.Count > 0;
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
        public GetMyPriceForSKUResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
        public GetMyPriceForSKUResponse WithResponseHeaderMetadata(ResponseHeaderMetadata responseHeaderMetadata)
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
            _getMyPriceForSKUResult = reader.ReadList<GetMyPriceForSKUResult>("GetMyPriceForSKUResult");
            _responseMetadata = reader.Read<ResponseMetadata>("ResponseMetadata");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("GetMyPriceForSKUResult", _getMyPriceForSKUResult);
            writer.Write("ResponseMetadata", _responseMetadata);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "GetMyPriceForSKUResponse", this);
        }


        public GetMyPriceForSKUResponse() : base()
        {
        }
    }
}
