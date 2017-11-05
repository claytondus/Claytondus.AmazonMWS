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
 * Get Fulfillment Preview Result
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
    public class GetFulfillmentPreviewResult : AbstractMwsObject
    {

        private FulfillmentPreviewList _fulfillmentPreviews;

        /// <summary>
        /// Gets and sets the FulfillmentPreviews property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentPreviews")]
        public FulfillmentPreviewList FulfillmentPreviews
        {
            get { return this._fulfillmentPreviews; }
            set { this._fulfillmentPreviews = value; }
        }

        /// <summary>
        /// Sets the FulfillmentPreviews property.
        /// </summary>
        /// <param name="fulfillmentPreviews">FulfillmentPreviews property.</param>
        /// <returns>this instance.</returns>
        public GetFulfillmentPreviewResult WithFulfillmentPreviews(FulfillmentPreviewList fulfillmentPreviews)
        {
            this._fulfillmentPreviews = fulfillmentPreviews;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentPreviews property is set.
        /// </summary>
        /// <returns>true if FulfillmentPreviews property is set.</returns>
        public bool IsSetFulfillmentPreviews()
        {
            return this._fulfillmentPreviews != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _fulfillmentPreviews = reader.Read<FulfillmentPreviewList>("FulfillmentPreviews");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("FulfillmentPreviews", _fulfillmentPreviews);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "GetFulfillmentPreviewResult", this);
        }


        public GetFulfillmentPreviewResult() : base()
        {
        }
    }
}
