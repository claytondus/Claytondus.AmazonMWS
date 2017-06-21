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
 * Transport Result
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
    public class TransportResult : AbstractMwsObject
    {

        private string _transportStatus;
        private string _errorCode;
        private string _errorDescription;

        /// <summary>
        /// Gets and sets the TransportStatus property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransportStatus")]
        public string TransportStatus
        {
            get { return this._transportStatus; }
            set { this._transportStatus = value; }
        }

        /// <summary>
        /// Sets the TransportStatus property.
        /// </summary>
        /// <param name="transportStatus">TransportStatus property.</param>
        /// <returns>this instance.</returns>
        public TransportResult WithTransportStatus(string transportStatus)
        {
            this._transportStatus = transportStatus;
            return this;
        }

        /// <summary>
        /// Checks if TransportStatus property is set.
        /// </summary>
        /// <returns>true if TransportStatus property is set.</returns>
        public bool IsSetTransportStatus()
        {
            return this._transportStatus != null;
        }

        /// <summary>
        /// Gets and sets the ErrorCode property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ErrorCode")]
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        /// <summary>
        /// Sets the ErrorCode property.
        /// </summary>
        /// <param name="errorCode">ErrorCode property.</param>
        /// <returns>this instance.</returns>
        public TransportResult WithErrorCode(string errorCode)
        {
            this._errorCode = errorCode;
            return this;
        }

        /// <summary>
        /// Checks if ErrorCode property is set.
        /// </summary>
        /// <returns>true if ErrorCode property is set.</returns>
        public bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the ErrorDescription property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ErrorDescription")]
        public string ErrorDescription
        {
            get { return this._errorDescription; }
            set { this._errorDescription = value; }
        }

        /// <summary>
        /// Sets the ErrorDescription property.
        /// </summary>
        /// <param name="errorDescription">ErrorDescription property.</param>
        /// <returns>this instance.</returns>
        public TransportResult WithErrorDescription(string errorDescription)
        {
            this._errorDescription = errorDescription;
            return this;
        }

        /// <summary>
        /// Checks if ErrorDescription property is set.
        /// </summary>
        /// <returns>true if ErrorDescription property is set.</returns>
        public bool IsSetErrorDescription()
        {
            return this._errorDescription != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _transportStatus = reader.Read<string>("TransportStatus");
            _errorCode = reader.Read<string>("ErrorCode");
            _errorDescription = reader.Read<string>("ErrorDescription");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("TransportStatus", _transportStatus);
            writer.Write("ErrorCode", _errorCode);
            writer.Write("ErrorDescription", _errorDescription);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "TransportResult", this);
        }

    public TransportResult (string transportStatus) : base() {
        this._transportStatus = transportStatus;
    }

        public TransportResult() : base()
        {
        }
    }
}
