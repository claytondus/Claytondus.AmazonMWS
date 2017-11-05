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
 * Return Authorization
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
    public class ReturnAuthorization : AbstractMwsObject
    {

        private string _returnAuthorizationId;
        private string _fulfillmentCenterId;
        private Address _returnToAddress;
        private string _amazonRmaId;
        private string _rmaPageURL;

        /// <summary>
        /// Gets and sets the ReturnAuthorizationId property.
        /// </summary>
        [XmlElement(ElementName = "ReturnAuthorizationId")]
        public string ReturnAuthorizationId
        {
            get { return this._returnAuthorizationId; }
            set { this._returnAuthorizationId = value; }
        }

        /// <summary>
        /// Sets the ReturnAuthorizationId property.
        /// </summary>
        /// <param name="returnAuthorizationId">ReturnAuthorizationId property.</param>
        /// <returns>this instance.</returns>
        public ReturnAuthorization WithReturnAuthorizationId(string returnAuthorizationId)
        {
            this._returnAuthorizationId = returnAuthorizationId;
            return this;
        }

        /// <summary>
        /// Checks if ReturnAuthorizationId property is set.
        /// </summary>
        /// <returns>true if ReturnAuthorizationId property is set.</returns>
        public bool IsSetReturnAuthorizationId()
        {
            return this._returnAuthorizationId != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentCenterId property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentCenterId")]
        public string FulfillmentCenterId
        {
            get { return this._fulfillmentCenterId; }
            set { this._fulfillmentCenterId = value; }
        }

        /// <summary>
        /// Sets the FulfillmentCenterId property.
        /// </summary>
        /// <param name="fulfillmentCenterId">FulfillmentCenterId property.</param>
        /// <returns>this instance.</returns>
        public ReturnAuthorization WithFulfillmentCenterId(string fulfillmentCenterId)
        {
            this._fulfillmentCenterId = fulfillmentCenterId;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentCenterId property is set.
        /// </summary>
        /// <returns>true if FulfillmentCenterId property is set.</returns>
        public bool IsSetFulfillmentCenterId()
        {
            return this._fulfillmentCenterId != null;
        }

        /// <summary>
        /// Gets and sets the ReturnToAddress property.
        /// </summary>
        [XmlElement(ElementName = "ReturnToAddress")]
        public Address ReturnToAddress
        {
            get { return this._returnToAddress; }
            set { this._returnToAddress = value; }
        }

        /// <summary>
        /// Sets the ReturnToAddress property.
        /// </summary>
        /// <param name="returnToAddress">ReturnToAddress property.</param>
        /// <returns>this instance.</returns>
        public ReturnAuthorization WithReturnToAddress(Address returnToAddress)
        {
            this._returnToAddress = returnToAddress;
            return this;
        }

        /// <summary>
        /// Checks if ReturnToAddress property is set.
        /// </summary>
        /// <returns>true if ReturnToAddress property is set.</returns>
        public bool IsSetReturnToAddress()
        {
            return this._returnToAddress != null;
        }

        /// <summary>
        /// Gets and sets the AmazonRmaId property.
        /// </summary>
        [XmlElement(ElementName = "AmazonRmaId")]
        public string AmazonRmaId
        {
            get { return this._amazonRmaId; }
            set { this._amazonRmaId = value; }
        }

        /// <summary>
        /// Sets the AmazonRmaId property.
        /// </summary>
        /// <param name="amazonRmaId">AmazonRmaId property.</param>
        /// <returns>this instance.</returns>
        public ReturnAuthorization WithAmazonRmaId(string amazonRmaId)
        {
            this._amazonRmaId = amazonRmaId;
            return this;
        }

        /// <summary>
        /// Checks if AmazonRmaId property is set.
        /// </summary>
        /// <returns>true if AmazonRmaId property is set.</returns>
        public bool IsSetAmazonRmaId()
        {
            return this._amazonRmaId != null;
        }

        /// <summary>
        /// Gets and sets the RmaPageURL property.
        /// </summary>
        [XmlElement(ElementName = "RmaPageURL")]
        public string RmaPageURL
        {
            get { return this._rmaPageURL; }
            set { this._rmaPageURL = value; }
        }

        /// <summary>
        /// Sets the RmaPageURL property.
        /// </summary>
        /// <param name="rmaPageURL">RmaPageURL property.</param>
        /// <returns>this instance.</returns>
        public ReturnAuthorization WithRmaPageURL(string rmaPageURL)
        {
            this._rmaPageURL = rmaPageURL;
            return this;
        }

        /// <summary>
        /// Checks if RmaPageURL property is set.
        /// </summary>
        /// <returns>true if RmaPageURL property is set.</returns>
        public bool IsSetRmaPageURL()
        {
            return this._rmaPageURL != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _returnAuthorizationId = reader.Read<string>("ReturnAuthorizationId");
            _fulfillmentCenterId = reader.Read<string>("FulfillmentCenterId");
            _returnToAddress = reader.Read<Address>("ReturnToAddress");
            _amazonRmaId = reader.Read<string>("AmazonRmaId");
            _rmaPageURL = reader.Read<string>("RmaPageURL");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ReturnAuthorizationId", _returnAuthorizationId);
            writer.Write("FulfillmentCenterId", _fulfillmentCenterId);
            writer.Write("ReturnToAddress", _returnToAddress);
            writer.Write("AmazonRmaId", _amazonRmaId);
            writer.Write("RmaPageURL", _rmaPageURL);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "ReturnAuthorization", this);
        }

    public ReturnAuthorization (string returnAuthorizationId,string fulfillmentCenterId,Address returnToAddress,string amazonRmaId,string rmaPageURL) : base() {
        this._returnAuthorizationId = returnAuthorizationId;
        this._fulfillmentCenterId = fulfillmentCenterId;
        this._returnToAddress = returnToAddress;
        this._amazonRmaId = amazonRmaId;
        this._rmaPageURL = rmaPageURL;
    }

        public ReturnAuthorization() : base()
        {
        }
    }
}
