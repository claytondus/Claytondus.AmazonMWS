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
 * SKU Inbound Guidance List
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
    public class SKUInboundGuidanceList : AbstractMwsObject
    {

        private List<SKUInboundGuidance> _skuInboundGuidance;

        /// <summary>
        /// Gets and sets the SKUInboundGuidance property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SKUInboundGuidance")]
        public List<SKUInboundGuidance> SKUInboundGuidance
        {
            get
            {
                if(this._skuInboundGuidance == null)
                {
                    this._skuInboundGuidance = new List<SKUInboundGuidance>();
                }
                return this._skuInboundGuidance;
            }
            set { this._skuInboundGuidance = value; }
        }

        /// <summary>
        /// Sets the SKUInboundGuidance property.
        /// </summary>
        /// <param name="skuInboundGuidance">SKUInboundGuidance property.</param>
        /// <returns>this instance.</returns>
        public SKUInboundGuidanceList WithSKUInboundGuidance(SKUInboundGuidance[] skuInboundGuidance)
        {
            this._skuInboundGuidance.AddRange(skuInboundGuidance);
            return this;
        }

        /// <summary>
        /// Checks if SKUInboundGuidance property is set.
        /// </summary>
        /// <returns>true if SKUInboundGuidance property is set.</returns>
        public bool IsSetSKUInboundGuidance()
        {
            return this.SKUInboundGuidance.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _skuInboundGuidance = reader.ReadList<SKUInboundGuidance>("SKUInboundGuidance");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("SKUInboundGuidance", _skuInboundGuidance);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "SKUInboundGuidanceList", this);
        }


        public SKUInboundGuidanceList() : base()
        {
        }
    }
}
