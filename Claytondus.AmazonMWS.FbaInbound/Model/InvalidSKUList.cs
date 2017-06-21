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
 * Invalid SKU List
 * API Version: 2010-10-01
 * Library Version: 2016-10-05
 * Generated: Wed Oct 05 06:15:39 PDT 2016
 */


using System;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaInbound.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    [XmlRootAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", IsNullable = false)]
    public class InvalidSKUList : AbstractMwsObject
    {

        private List<InvalidSKU> _invalidSKU;

        /// <summary>
        /// Gets and sets the InvalidSKU property.
        /// </summary>
        [XmlElementAttribute(ElementName = "InvalidSKU")]
        public List<InvalidSKU> InvalidSKU
        {
            get
            {
                if(this._invalidSKU == null)
                {
                    this._invalidSKU = new List<InvalidSKU>();
                }
                return this._invalidSKU;
            }
            set { this._invalidSKU = value; }
        }

        /// <summary>
        /// Sets the InvalidSKU property.
        /// </summary>
        /// <param name="invalidSKU">InvalidSKU property.</param>
        /// <returns>this instance.</returns>
        public InvalidSKUList WithInvalidSKU(InvalidSKU[] invalidSKU)
        {
            this._invalidSKU.AddRange(invalidSKU);
            return this;
        }

        /// <summary>
        /// Checks if InvalidSKU property is set.
        /// </summary>
        /// <returns>true if InvalidSKU property is set.</returns>
        public bool IsSetInvalidSKU()
        {
            return this.InvalidSKU.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _invalidSKU = reader.ReadList<InvalidSKU>("InvalidSKU");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("InvalidSKU", _invalidSKU);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "InvalidSKUList", this);
        }


        public InvalidSKUList() : base()
        {
        }
    }
}
