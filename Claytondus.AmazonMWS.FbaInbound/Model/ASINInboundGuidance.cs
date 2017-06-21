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
 * ASIN Inbound Guidance
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
    public class ASINInboundGuidance : AbstractMwsObject
    {

        private string _asin;
        private string _inboundGuidance;
        private GuidanceReasonList _guidanceReasonList;

        /// <summary>
        /// Gets and sets the ASIN property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ASIN")]
        public string ASIN
        {
            get { return this._asin; }
            set { this._asin = value; }
        }

        /// <summary>
        /// Sets the ASIN property.
        /// </summary>
        /// <param name="asin">ASIN property.</param>
        /// <returns>this instance.</returns>
        public ASINInboundGuidance WithASIN(string asin)
        {
            this._asin = asin;
            return this;
        }

        /// <summary>
        /// Checks if ASIN property is set.
        /// </summary>
        /// <returns>true if ASIN property is set.</returns>
        public bool IsSetASIN()
        {
            return this._asin != null;
        }

        /// <summary>
        /// Gets and sets the InboundGuidance property.
        /// </summary>
        [XmlElementAttribute(ElementName = "InboundGuidance")]
        public string InboundGuidance
        {
            get { return this._inboundGuidance; }
            set { this._inboundGuidance = value; }
        }

        /// <summary>
        /// Sets the InboundGuidance property.
        /// </summary>
        /// <param name="inboundGuidance">InboundGuidance property.</param>
        /// <returns>this instance.</returns>
        public ASINInboundGuidance WithInboundGuidance(string inboundGuidance)
        {
            this._inboundGuidance = inboundGuidance;
            return this;
        }

        /// <summary>
        /// Checks if InboundGuidance property is set.
        /// </summary>
        /// <returns>true if InboundGuidance property is set.</returns>
        public bool IsSetInboundGuidance()
        {
            return this._inboundGuidance != null;
        }

        /// <summary>
        /// Gets and sets the GuidanceReasonList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "GuidanceReasonList")]
        public GuidanceReasonList GuidanceReasonList
        {
            get { return this._guidanceReasonList; }
            set { this._guidanceReasonList = value; }
        }

        /// <summary>
        /// Sets the GuidanceReasonList property.
        /// </summary>
        /// <param name="guidanceReasonList">GuidanceReasonList property.</param>
        /// <returns>this instance.</returns>
        public ASINInboundGuidance WithGuidanceReasonList(GuidanceReasonList guidanceReasonList)
        {
            this._guidanceReasonList = guidanceReasonList;
            return this;
        }

        /// <summary>
        /// Checks if GuidanceReasonList property is set.
        /// </summary>
        /// <returns>true if GuidanceReasonList property is set.</returns>
        public bool IsSetGuidanceReasonList()
        {
            return this._guidanceReasonList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _asin = reader.Read<string>("ASIN");
            _inboundGuidance = reader.Read<string>("InboundGuidance");
            _guidanceReasonList = reader.Read<GuidanceReasonList>("GuidanceReasonList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ASIN", _asin);
            writer.Write("InboundGuidance", _inboundGuidance);
            writer.Write("GuidanceReasonList", _guidanceReasonList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "ASINInboundGuidance", this);
        }


        public ASINInboundGuidance() : base()
        {
        }
    }
}
