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
 * List Return Reason Codes Result
 * API Version: 2010-10-01
 * Library Version: 2016-10-19
 * Generated: Wed Oct 19 08:37:54 PDT 2016
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaOutbound.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", IsNullable = false)]
    public class ListReturnReasonCodesResult : AbstractMwsObject
    {

        private ReasonCodeDetailsList _reasonCodeDetailsList;

        /// <summary>
        /// Gets and sets the ReasonCodeDetailsList property.
        /// </summary>
        [XmlElement(ElementName = "ReasonCodeDetailsList")]
        public ReasonCodeDetailsList ReasonCodeDetailsList
        {
            get { return this._reasonCodeDetailsList; }
            set { this._reasonCodeDetailsList = value; }
        }

        /// <summary>
        /// Sets the ReasonCodeDetailsList property.
        /// </summary>
        /// <param name="reasonCodeDetailsList">ReasonCodeDetailsList property.</param>
        /// <returns>this instance.</returns>
        public ListReturnReasonCodesResult WithReasonCodeDetailsList(ReasonCodeDetailsList reasonCodeDetailsList)
        {
            this._reasonCodeDetailsList = reasonCodeDetailsList;
            return this;
        }

        /// <summary>
        /// Checks if ReasonCodeDetailsList property is set.
        /// </summary>
        /// <returns>true if ReasonCodeDetailsList property is set.</returns>
        public bool IsSetReasonCodeDetailsList()
        {
            return this._reasonCodeDetailsList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _reasonCodeDetailsList = reader.Read<ReasonCodeDetailsList>("ReasonCodeDetailsList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ReasonCodeDetailsList", _reasonCodeDetailsList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "ListReturnReasonCodesResult", this);
        }


        public ListReturnReasonCodesResult() : base()
        {
        }
    }
}
