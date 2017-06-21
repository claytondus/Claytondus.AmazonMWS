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
 * SKU Prep Instructions List
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
    public class SKUPrepInstructionsList : AbstractMwsObject
    {

        private List<SKUPrepInstructions> _skuPrepInstructions;

        /// <summary>
        /// Gets and sets the SKUPrepInstructions property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SKUPrepInstructions")]
        public List<SKUPrepInstructions> SKUPrepInstructions
        {
            get
            {
                if(this._skuPrepInstructions == null)
                {
                    this._skuPrepInstructions = new List<SKUPrepInstructions>();
                }
                return this._skuPrepInstructions;
            }
            set { this._skuPrepInstructions = value; }
        }

        /// <summary>
        /// Sets the SKUPrepInstructions property.
        /// </summary>
        /// <param name="skuPrepInstructions">SKUPrepInstructions property.</param>
        /// <returns>this instance.</returns>
        public SKUPrepInstructionsList WithSKUPrepInstructions(SKUPrepInstructions[] skuPrepInstructions)
        {
            this._skuPrepInstructions.AddRange(skuPrepInstructions);
            return this;
        }

        /// <summary>
        /// Checks if SKUPrepInstructions property is set.
        /// </summary>
        /// <returns>true if SKUPrepInstructions property is set.</returns>
        public bool IsSetSKUPrepInstructions()
        {
            return this.SKUPrepInstructions.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _skuPrepInstructions = reader.ReadList<SKUPrepInstructions>("SKUPrepInstructions");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("SKUPrepInstructions", _skuPrepInstructions);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "SKUPrepInstructionsList", this);
        }


        public SKUPrepInstructionsList() : base()
        {
        }
    }
}
