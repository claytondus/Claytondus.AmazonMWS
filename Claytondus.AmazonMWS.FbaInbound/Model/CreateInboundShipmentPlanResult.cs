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
 * Create Inbound Shipment Plan Result
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
    public class CreateInboundShipmentPlanResult : AbstractMwsObject
    {

        private InboundShipmentPlanList _inboundShipmentPlans;

        /// <summary>
        /// Gets and sets the InboundShipmentPlans property.
        /// </summary>
        [XmlElementAttribute(ElementName = "InboundShipmentPlans")]
        public InboundShipmentPlanList InboundShipmentPlans
        {
            get { return this._inboundShipmentPlans; }
            set { this._inboundShipmentPlans = value; }
        }

        /// <summary>
        /// Sets the InboundShipmentPlans property.
        /// </summary>
        /// <param name="inboundShipmentPlans">InboundShipmentPlans property.</param>
        /// <returns>this instance.</returns>
        public CreateInboundShipmentPlanResult WithInboundShipmentPlans(InboundShipmentPlanList inboundShipmentPlans)
        {
            this._inboundShipmentPlans = inboundShipmentPlans;
            return this;
        }

        /// <summary>
        /// Checks if InboundShipmentPlans property is set.
        /// </summary>
        /// <returns>true if InboundShipmentPlans property is set.</returns>
        public bool IsSetInboundShipmentPlans()
        {
            return this._inboundShipmentPlans != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _inboundShipmentPlans = reader.Read<InboundShipmentPlanList>("InboundShipmentPlans");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("InboundShipmentPlans", _inboundShipmentPlans);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "CreateInboundShipmentPlanResult", this);
        }


        public CreateInboundShipmentPlanResult() : base()
        {
        }
    }
}
