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
 * List Inventory Supply By Next Token Response
 * API Version: 2010-10-01
 * Library Version: 2014-09-30
 * Generated: Mon Mar 21 09:01:30 PDT 2016
 */


using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaInventory.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/", IsNullable = false)]
    public class ListInventorySupplyByNextTokenResponse : AbstractMwsObject, IMWSResponse
    {

        private ListInventorySupplyByNextTokenResult _listInventorySupplyByNextTokenResult;
        private ResponseMetadata _responseMetadata;
        private ResponseHeaderMetadata _responseHeaderMetadata;

        /// <summary>
        /// Gets and sets the ListInventorySupplyByNextTokenResult property.
        /// </summary>
        [XmlElement(ElementName = "ListInventorySupplyByNextTokenResult")]
        public ListInventorySupplyByNextTokenResult ListInventorySupplyByNextTokenResult
        {
            get { return this._listInventorySupplyByNextTokenResult; }
            set { this._listInventorySupplyByNextTokenResult = value; }
        }

        /// <summary>
        /// Sets the ListInventorySupplyByNextTokenResult property.
        /// </summary>
        /// <param name="listInventorySupplyByNextTokenResult">ListInventorySupplyByNextTokenResult property.</param>
        /// <returns>this instance.</returns>
        public ListInventorySupplyByNextTokenResponse WithListInventorySupplyByNextTokenResult(ListInventorySupplyByNextTokenResult listInventorySupplyByNextTokenResult)
        {
            this._listInventorySupplyByNextTokenResult = listInventorySupplyByNextTokenResult;
            return this;
        }

        /// <summary>
        /// Checks if ListInventorySupplyByNextTokenResult property is set.
        /// </summary>
        /// <returns>true if ListInventorySupplyByNextTokenResult property is set.</returns>
        public bool IsSetListInventorySupplyByNextTokenResult()
        {
            return this._listInventorySupplyByNextTokenResult != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        [XmlElement(ElementName = "ResponseMetadata")]
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
        public ListInventorySupplyByNextTokenResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
        [XmlElement(ElementName = "ResponseHeaderMetadata")]
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
        public ListInventorySupplyByNextTokenResponse WithResponseHeaderMetadata(ResponseHeaderMetadata responseHeaderMetadata)
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
            _listInventorySupplyByNextTokenResult = reader.Read<ListInventorySupplyByNextTokenResult>("ListInventorySupplyByNextTokenResult");
            _responseMetadata = reader.Read<ResponseMetadata>("ResponseMetadata");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ListInventorySupplyByNextTokenResult", _listInventorySupplyByNextTokenResult);
            writer.Write("ResponseMetadata", _responseMetadata);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/", "ListInventorySupplyByNextTokenResponse", this);
        }

        public ListInventorySupplyByNextTokenResponse() : base()
        {
        }
    }
}
