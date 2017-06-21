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
 * Partnered Estimate
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
    public class PartneredEstimate : AbstractMwsObject
    {

        private Amount _amount;
        private string _confirmDeadline;
        private string _voidDeadline;

        /// <summary>
        /// Gets and sets the Amount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Amount")]
        public Amount Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        /// <summary>
        /// Sets the Amount property.
        /// </summary>
        /// <param name="amount">Amount property.</param>
        /// <returns>this instance.</returns>
        public PartneredEstimate WithAmount(Amount amount)
        {
            this._amount = amount;
            return this;
        }

        /// <summary>
        /// Checks if Amount property is set.
        /// </summary>
        /// <returns>true if Amount property is set.</returns>
        public bool IsSetAmount()
        {
            return this._amount != null;
        }

        /// <summary>
        /// Gets and sets the ConfirmDeadline property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ConfirmDeadline")]
        public string ConfirmDeadline
        {
            get { return this._confirmDeadline; }
            set { this._confirmDeadline = value; }
        }

        /// <summary>
        /// Sets the ConfirmDeadline property.
        /// </summary>
        /// <param name="confirmDeadline">ConfirmDeadline property.</param>
        /// <returns>this instance.</returns>
        public PartneredEstimate WithConfirmDeadline(string confirmDeadline)
        {
            this._confirmDeadline = confirmDeadline;
            return this;
        }

        /// <summary>
        /// Checks if ConfirmDeadline property is set.
        /// </summary>
        /// <returns>true if ConfirmDeadline property is set.</returns>
        public bool IsSetConfirmDeadline()
        {
            return this._confirmDeadline != null;
        }

        /// <summary>
        /// Gets and sets the VoidDeadline property.
        /// </summary>
        [XmlElementAttribute(ElementName = "VoidDeadline")]
        public string VoidDeadline
        {
            get { return this._voidDeadline; }
            set { this._voidDeadline = value; }
        }

        /// <summary>
        /// Sets the VoidDeadline property.
        /// </summary>
        /// <param name="voidDeadline">VoidDeadline property.</param>
        /// <returns>this instance.</returns>
        public PartneredEstimate WithVoidDeadline(string voidDeadline)
        {
            this._voidDeadline = voidDeadline;
            return this;
        }

        /// <summary>
        /// Checks if VoidDeadline property is set.
        /// </summary>
        /// <returns>true if VoidDeadline property is set.</returns>
        public bool IsSetVoidDeadline()
        {
            return this._voidDeadline != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _amount = reader.Read<Amount>("Amount");
            _confirmDeadline = reader.Read<string>("ConfirmDeadline");
            _voidDeadline = reader.Read<string>("VoidDeadline");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Amount", _amount);
            writer.Write("ConfirmDeadline", _confirmDeadline);
            writer.Write("VoidDeadline", _voidDeadline);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "PartneredEstimate", this);
        }

    public PartneredEstimate (Amount amount) : base() {
        this._amount = amount;
    }

        public PartneredEstimate() : base()
        {
        }
    }
}
