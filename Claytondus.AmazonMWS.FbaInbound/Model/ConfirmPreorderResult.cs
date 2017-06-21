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
 * Confirm Preorder Result
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
    public class ConfirmPreorderResult : AbstractMwsObject
    {

        private string _confirmedNeedByDate;
        private string _confirmedFulfillableDate;

        /// <summary>
        /// Gets and sets the ConfirmedNeedByDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ConfirmedNeedByDate")]
        public string ConfirmedNeedByDate
        {
            get { return this._confirmedNeedByDate; }
            set { this._confirmedNeedByDate = value; }
        }

        /// <summary>
        /// Sets the ConfirmedNeedByDate property.
        /// </summary>
        /// <param name="confirmedNeedByDate">ConfirmedNeedByDate property.</param>
        /// <returns>this instance.</returns>
        public ConfirmPreorderResult WithConfirmedNeedByDate(string confirmedNeedByDate)
        {
            this._confirmedNeedByDate = confirmedNeedByDate;
            return this;
        }

        /// <summary>
        /// Checks if ConfirmedNeedByDate property is set.
        /// </summary>
        /// <returns>true if ConfirmedNeedByDate property is set.</returns>
        public bool IsSetConfirmedNeedByDate()
        {
            return this._confirmedNeedByDate != null;
        }

        /// <summary>
        /// Gets and sets the ConfirmedFulfillableDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ConfirmedFulfillableDate")]
        public string ConfirmedFulfillableDate
        {
            get { return this._confirmedFulfillableDate; }
            set { this._confirmedFulfillableDate = value; }
        }

        /// <summary>
        /// Sets the ConfirmedFulfillableDate property.
        /// </summary>
        /// <param name="confirmedFulfillableDate">ConfirmedFulfillableDate property.</param>
        /// <returns>this instance.</returns>
        public ConfirmPreorderResult WithConfirmedFulfillableDate(string confirmedFulfillableDate)
        {
            this._confirmedFulfillableDate = confirmedFulfillableDate;
            return this;
        }

        /// <summary>
        /// Checks if ConfirmedFulfillableDate property is set.
        /// </summary>
        /// <returns>true if ConfirmedFulfillableDate property is set.</returns>
        public bool IsSetConfirmedFulfillableDate()
        {
            return this._confirmedFulfillableDate != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _confirmedNeedByDate = reader.Read<string>("ConfirmedNeedByDate");
            _confirmedFulfillableDate = reader.Read<string>("ConfirmedFulfillableDate");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ConfirmedNeedByDate", _confirmedNeedByDate);
            writer.Write("ConfirmedFulfillableDate", _confirmedFulfillableDate);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "ConfirmPreorderResult", this);
        }


        public ConfirmPreorderResult() : base()
        {
        }
    }
}
