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
 * Invalid ASIN
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
    public class InvalidASIN : AbstractMwsObject
    {

        private string _asin;
        private string _errorReason;

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
        public InvalidASIN WithASIN(string asin)
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
        /// Gets and sets the ErrorReason property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ErrorReason")]
        public string ErrorReason
        {
            get { return this._errorReason; }
            set { this._errorReason = value; }
        }

        /// <summary>
        /// Sets the ErrorReason property.
        /// </summary>
        /// <param name="errorReason">ErrorReason property.</param>
        /// <returns>this instance.</returns>
        public InvalidASIN WithErrorReason(string errorReason)
        {
            this._errorReason = errorReason;
            return this;
        }

        /// <summary>
        /// Checks if ErrorReason property is set.
        /// </summary>
        /// <returns>true if ErrorReason property is set.</returns>
        public bool IsSetErrorReason()
        {
            return this._errorReason != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _asin = reader.Read<string>("ASIN");
            _errorReason = reader.Read<string>("ErrorReason");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ASIN", _asin);
            writer.Write("ErrorReason", _errorReason);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "InvalidASIN", this);
        }


        public InvalidASIN() : base()
        {
        }
    }
}
