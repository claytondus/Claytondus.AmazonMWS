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
 * Reason Code Details
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
    public class ReasonCodeDetails : AbstractMwsObject
    {

        private string _returnReasonCode;
        private string _description;
        private string _translatedDescription;

        /// <summary>
        /// Gets and sets the ReturnReasonCode property.
        /// </summary>
        [XmlElement(ElementName = "ReturnReasonCode")]
        public string ReturnReasonCode
        {
            get { return this._returnReasonCode; }
            set { this._returnReasonCode = value; }
        }

        /// <summary>
        /// Sets the ReturnReasonCode property.
        /// </summary>
        /// <param name="returnReasonCode">ReturnReasonCode property.</param>
        /// <returns>this instance.</returns>
        public ReasonCodeDetails WithReturnReasonCode(string returnReasonCode)
        {
            this._returnReasonCode = returnReasonCode;
            return this;
        }

        /// <summary>
        /// Checks if ReturnReasonCode property is set.
        /// </summary>
        /// <returns>true if ReturnReasonCode property is set.</returns>
        public bool IsSetReturnReasonCode()
        {
            return this._returnReasonCode != null;
        }

        /// <summary>
        /// Gets and sets the Description property.
        /// </summary>
        [XmlElement(ElementName = "Description")]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        /// <summary>
        /// Sets the Description property.
        /// </summary>
        /// <param name="description">Description property.</param>
        /// <returns>this instance.</returns>
        public ReasonCodeDetails WithDescription(string description)
        {
            this._description = description;
            return this;
        }

        /// <summary>
        /// Checks if Description property is set.
        /// </summary>
        /// <returns>true if Description property is set.</returns>
        public bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the TranslatedDescription property.
        /// </summary>
        [XmlElement(ElementName = "TranslatedDescription")]
        public string TranslatedDescription
        {
            get { return this._translatedDescription; }
            set { this._translatedDescription = value; }
        }

        /// <summary>
        /// Sets the TranslatedDescription property.
        /// </summary>
        /// <param name="translatedDescription">TranslatedDescription property.</param>
        /// <returns>this instance.</returns>
        public ReasonCodeDetails WithTranslatedDescription(string translatedDescription)
        {
            this._translatedDescription = translatedDescription;
            return this;
        }

        /// <summary>
        /// Checks if TranslatedDescription property is set.
        /// </summary>
        /// <returns>true if TranslatedDescription property is set.</returns>
        public bool IsSetTranslatedDescription()
        {
            return this._translatedDescription != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _returnReasonCode = reader.Read<string>("ReturnReasonCode");
            _description = reader.Read<string>("Description");
            _translatedDescription = reader.Read<string>("TranslatedDescription");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ReturnReasonCode", _returnReasonCode);
            writer.Write("Description", _description);
            writer.Write("TranslatedDescription", _translatedDescription);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "ReasonCodeDetails", this);
        }

    public ReasonCodeDetails (string returnReasonCode,string description) : base() {
        this._returnReasonCode = returnReasonCode;
        this._description = description;
    }

        public ReasonCodeDetails() : base()
        {
        }
    }
}
