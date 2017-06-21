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
 * Get Inbound Guidance For ASIN Result
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
    public class GetInboundGuidanceForASINResult : AbstractMwsObject
    {

        private ASINInboundGuidanceList _asinInboundGuidanceList;
        private InvalidASINList _invalidASINList;

        /// <summary>
        /// Gets and sets the ASINInboundGuidanceList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ASINInboundGuidanceList")]
        public ASINInboundGuidanceList ASINInboundGuidanceList
        {
            get { return this._asinInboundGuidanceList; }
            set { this._asinInboundGuidanceList = value; }
        }

        /// <summary>
        /// Sets the ASINInboundGuidanceList property.
        /// </summary>
        /// <param name="asinInboundGuidanceList">ASINInboundGuidanceList property.</param>
        /// <returns>this instance.</returns>
        public GetInboundGuidanceForASINResult WithASINInboundGuidanceList(ASINInboundGuidanceList asinInboundGuidanceList)
        {
            this._asinInboundGuidanceList = asinInboundGuidanceList;
            return this;
        }

        /// <summary>
        /// Checks if ASINInboundGuidanceList property is set.
        /// </summary>
        /// <returns>true if ASINInboundGuidanceList property is set.</returns>
        public bool IsSetASINInboundGuidanceList()
        {
            return this._asinInboundGuidanceList != null;
        }

        /// <summary>
        /// Gets and sets the InvalidASINList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "InvalidASINList")]
        public InvalidASINList InvalidASINList
        {
            get { return this._invalidASINList; }
            set { this._invalidASINList = value; }
        }

        /// <summary>
        /// Sets the InvalidASINList property.
        /// </summary>
        /// <param name="invalidASINList">InvalidASINList property.</param>
        /// <returns>this instance.</returns>
        public GetInboundGuidanceForASINResult WithInvalidASINList(InvalidASINList invalidASINList)
        {
            this._invalidASINList = invalidASINList;
            return this;
        }

        /// <summary>
        /// Checks if InvalidASINList property is set.
        /// </summary>
        /// <returns>true if InvalidASINList property is set.</returns>
        public bool IsSetInvalidASINList()
        {
            return this._invalidASINList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _asinInboundGuidanceList = reader.Read<ASINInboundGuidanceList>("ASINInboundGuidanceList");
            _invalidASINList = reader.Read<InvalidASINList>("InvalidASINList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ASINInboundGuidanceList", _asinInboundGuidanceList);
            writer.Write("InvalidASINList", _invalidASINList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "GetInboundGuidanceForASINResult", this);
        }


        public GetInboundGuidanceForASINResult() : base()
        {
        }
    }
}
