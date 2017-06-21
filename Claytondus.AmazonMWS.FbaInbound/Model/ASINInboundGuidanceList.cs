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
 * ASIN Inbound Guidance List
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
    public class ASINInboundGuidanceList : AbstractMwsObject
    {

        private List<ASINInboundGuidance> _asinInboundGuidance;

        /// <summary>
        /// Gets and sets the ASINInboundGuidance property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ASINInboundGuidance")]
        public List<ASINInboundGuidance> ASINInboundGuidance
        {
            get
            {
                if(this._asinInboundGuidance == null)
                {
                    this._asinInboundGuidance = new List<ASINInboundGuidance>();
                }
                return this._asinInboundGuidance;
            }
            set { this._asinInboundGuidance = value; }
        }

        /// <summary>
        /// Sets the ASINInboundGuidance property.
        /// </summary>
        /// <param name="asinInboundGuidance">ASINInboundGuidance property.</param>
        /// <returns>this instance.</returns>
        public ASINInboundGuidanceList WithASINInboundGuidance(ASINInboundGuidance[] asinInboundGuidance)
        {
            this._asinInboundGuidance.AddRange(asinInboundGuidance);
            return this;
        }

        /// <summary>
        /// Checks if ASINInboundGuidance property is set.
        /// </summary>
        /// <returns>true if ASINInboundGuidance property is set.</returns>
        public bool IsSetASINInboundGuidance()
        {
            return this.ASINInboundGuidance.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _asinInboundGuidance = reader.ReadList<ASINInboundGuidance>("ASINInboundGuidance");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("ASINInboundGuidance", _asinInboundGuidance);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "ASINInboundGuidanceList", this);
        }


        public ASINInboundGuidanceList() : base()
        {
        }
    }
}
