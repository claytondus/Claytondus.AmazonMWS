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
 * Transport Content
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
    public class TransportContent : AbstractMwsObject
    {

        private TransportHeader _transportHeader;
        private TransportDetailOutput _transportDetails;
        private TransportResult _transportResult;

        /// <summary>
        /// Gets and sets the TransportHeader property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransportHeader")]
        public TransportHeader TransportHeader
        {
            get { return this._transportHeader; }
            set { this._transportHeader = value; }
        }

        /// <summary>
        /// Sets the TransportHeader property.
        /// </summary>
        /// <param name="transportHeader">TransportHeader property.</param>
        /// <returns>this instance.</returns>
        public TransportContent WithTransportHeader(TransportHeader transportHeader)
        {
            this._transportHeader = transportHeader;
            return this;
        }

        /// <summary>
        /// Checks if TransportHeader property is set.
        /// </summary>
        /// <returns>true if TransportHeader property is set.</returns>
        public bool IsSetTransportHeader()
        {
            return this._transportHeader != null;
        }

        /// <summary>
        /// Gets and sets the TransportDetails property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransportDetails")]
        public TransportDetailOutput TransportDetails
        {
            get { return this._transportDetails; }
            set { this._transportDetails = value; }
        }

        /// <summary>
        /// Sets the TransportDetails property.
        /// </summary>
        /// <param name="transportDetails">TransportDetails property.</param>
        /// <returns>this instance.</returns>
        public TransportContent WithTransportDetails(TransportDetailOutput transportDetails)
        {
            this._transportDetails = transportDetails;
            return this;
        }

        /// <summary>
        /// Checks if TransportDetails property is set.
        /// </summary>
        /// <returns>true if TransportDetails property is set.</returns>
        public bool IsSetTransportDetails()
        {
            return this._transportDetails != null;
        }

        /// <summary>
        /// Gets and sets the TransportResult property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransportResult")]
        public TransportResult TransportResult
        {
            get { return this._transportResult; }
            set { this._transportResult = value; }
        }

        /// <summary>
        /// Sets the TransportResult property.
        /// </summary>
        /// <param name="transportResult">TransportResult property.</param>
        /// <returns>this instance.</returns>
        public TransportContent WithTransportResult(TransportResult transportResult)
        {
            this._transportResult = transportResult;
            return this;
        }

        /// <summary>
        /// Checks if TransportResult property is set.
        /// </summary>
        /// <returns>true if TransportResult property is set.</returns>
        public bool IsSetTransportResult()
        {
            return this._transportResult != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _transportHeader = reader.Read<TransportHeader>("TransportHeader");
            _transportDetails = reader.Read<TransportDetailOutput>("TransportDetails");
            _transportResult = reader.Read<TransportResult>("TransportResult");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("TransportHeader", _transportHeader);
            writer.Write("TransportDetails", _transportDetails);
            writer.Write("TransportResult", _transportResult);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "TransportContent", this);
        }

    public TransportContent (TransportHeader transportHeader,TransportDetailOutput transportDetails,TransportResult transportResult) : base() {
        this._transportHeader = transportHeader;
        this._transportDetails = transportDetails;
        this._transportResult = transportResult;
    }

        public TransportContent() : base()
        {
        }
    }
}
