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
 * Get Prep Instructions For SKU Result
 * API Version: 2010-10-01
 * Library Version: 2016-10-05
 * Generated: Wed Oct 05 06:15:39 PDT 2016
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaInbound.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    [XmlRootAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", IsNullable = false)]
    public class GetPrepInstructionsForSKUResult : AbstractMwsObject
    {

        private SKUPrepInstructionsList _skuPrepInstructionsList;
        private InvalidSKUList _invalidSKUList;

        /// <summary>
        /// Gets and sets the SKUPrepInstructionsList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SKUPrepInstructionsList")]
        public SKUPrepInstructionsList SKUPrepInstructionsList
        {
            get { return this._skuPrepInstructionsList; }
            set { this._skuPrepInstructionsList = value; }
        }

        /// <summary>
        /// Sets the SKUPrepInstructionsList property.
        /// </summary>
        /// <param name="skuPrepInstructionsList">SKUPrepInstructionsList property.</param>
        /// <returns>this instance.</returns>
        public GetPrepInstructionsForSKUResult WithSKUPrepInstructionsList(SKUPrepInstructionsList skuPrepInstructionsList)
        {
            this._skuPrepInstructionsList = skuPrepInstructionsList;
            return this;
        }

        /// <summary>
        /// Checks if SKUPrepInstructionsList property is set.
        /// </summary>
        /// <returns>true if SKUPrepInstructionsList property is set.</returns>
        public bool IsSetSKUPrepInstructionsList()
        {
            return this._skuPrepInstructionsList != null;
        }

        /// <summary>
        /// Gets and sets the InvalidSKUList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "InvalidSKUList")]
        public InvalidSKUList InvalidSKUList
        {
            get { return this._invalidSKUList; }
            set { this._invalidSKUList = value; }
        }

        /// <summary>
        /// Sets the InvalidSKUList property.
        /// </summary>
        /// <param name="invalidSKUList">InvalidSKUList property.</param>
        /// <returns>this instance.</returns>
        public GetPrepInstructionsForSKUResult WithInvalidSKUList(InvalidSKUList invalidSKUList)
        {
            this._invalidSKUList = invalidSKUList;
            return this;
        }

        /// <summary>
        /// Checks if InvalidSKUList property is set.
        /// </summary>
        /// <returns>true if InvalidSKUList property is set.</returns>
        public bool IsSetInvalidSKUList()
        {
            return this._invalidSKUList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _skuPrepInstructionsList = reader.Read<SKUPrepInstructionsList>("SKUPrepInstructionsList");
            _invalidSKUList = reader.Read<InvalidSKUList>("InvalidSKUList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SKUPrepInstructionsList", _skuPrepInstructionsList);
            writer.Write("InvalidSKUList", _invalidSKUList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "GetPrepInstructionsForSKUResult", this);
        }


        public GetPrepInstructionsForSKUResult() : base()
        {
        }
    }
}
