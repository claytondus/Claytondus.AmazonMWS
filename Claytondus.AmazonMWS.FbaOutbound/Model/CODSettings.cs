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
 * COD Settings
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
    public class CODSettings : AbstractMwsObject
    {

        private bool _isCODRequired;
        private Currency _codCharge;
        private Currency _codChargeTax;
        private Currency _shippingCharge;
        private Currency _shippingChargeTax;

        /// <summary>
        /// Gets and sets the IsCODRequired property.
        /// </summary>
        [XmlElement(ElementName = "IsCODRequired")]
        public bool IsCODRequired
        {
            get { return this._isCODRequired; }
            set { this._isCODRequired = value; }
        }

        /// <summary>
        /// Sets the IsCODRequired property.
        /// </summary>
        /// <param name="isCODRequired">IsCODRequired property.</param>
        /// <returns>this instance.</returns>
        public CODSettings WithIsCODRequired(bool isCODRequired)
        {
            this._isCODRequired = isCODRequired;
            return this;
        }

        /// <summary>
        /// Checks if IsCODRequired property is set.
        /// </summary>
        /// <returns>true if IsCODRequired property is set.</returns>
        public bool IsSetIsCODRequired()
        {
            return this._isCODRequired != null;
        }

        /// <summary>
        /// Gets and sets the CODCharge property.
        /// </summary>
        [XmlElement(ElementName = "CODCharge")]
        public Currency CODCharge
        {
            get { return this._codCharge; }
            set { this._codCharge = value; }
        }

        /// <summary>
        /// Sets the CODCharge property.
        /// </summary>
        /// <param name="codCharge">CODCharge property.</param>
        /// <returns>this instance.</returns>
        public CODSettings WithCodCharge(Currency codCharge)
        {
            this._codCharge = codCharge;
            return this;
        }

        /// <summary>
        /// Checks if CODCharge property is set.
        /// </summary>
        /// <returns>true if CODCharge property is set.</returns>
        public bool IsSetCODCharge()
        {
            return this._codCharge != null;
        }

        /// <summary>
        /// Gets and sets the CODChargeTax property.
        /// </summary>
        [XmlElement(ElementName = "CODChargeTax")]
        public Currency CODChargeTax
        {
            get { return this._codChargeTax; }
            set { this._codChargeTax = value; }
        }

        /// <summary>
        /// Sets the CODChargeTax property.
        /// </summary>
        /// <param name="codChargeTax">CODChargeTax property.</param>
        /// <returns>this instance.</returns>
        public CODSettings WithCODChargeTax(Currency codChargeTax)
        {
            this._codChargeTax = codChargeTax;
            return this;
        }

        /// <summary>
        /// Checks if CODChargeTax property is set.
        /// </summary>
        /// <returns>true if CODChargeTax property is set.</returns>
        public bool IsSetCODChargeTax()
        {
            return this._codChargeTax != null;
        }

        /// <summary>
        /// Gets and sets the ShippingCharge property.
        /// </summary>
        [XmlElement(ElementName = "ShippingCharge")]
        public Currency ShippingCharge
        {
            get { return this._shippingCharge; }
            set { this._shippingCharge = value; }
        }

        /// <summary>
        /// Sets the ShippingCharge property.
        /// </summary>
        /// <param name="shippingCharge">ShippingCharge property.</param>
        /// <returns>this instance.</returns>
        public CODSettings WithShippingCharge(Currency shippingCharge)
        {
            this._shippingCharge = shippingCharge;
            return this;
        }

        /// <summary>
        /// Checks if ShippingCharge property is set.
        /// </summary>
        /// <returns>true if ShippingCharge property is set.</returns>
        public bool IsSetShippingCharge()
        {
            return this._shippingCharge != null;
        }

        /// <summary>
        /// Gets and sets the ShippingChargeTax property.
        /// </summary>
        [XmlElement(ElementName = "ShippingChargeTax")]
        public Currency ShippingChargeTax
        {
            get { return this._shippingChargeTax; }
            set { this._shippingChargeTax = value; }
        }

        /// <summary>
        /// Sets the ShippingChargeTax property.
        /// </summary>
        /// <param name="shippingChargeTax">ShippingChargeTax property.</param>
        /// <returns>this instance.</returns>
        public CODSettings WithShippingChargeTax(Currency shippingChargeTax)
        {
            this._shippingChargeTax = shippingChargeTax;
            return this;
        }

        /// <summary>
        /// Checks if ShippingChargeTax property is set.
        /// </summary>
        /// <returns>true if ShippingChargeTax property is set.</returns>
        public bool IsSetShippingChargeTax()
        {
            return this._shippingChargeTax != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _isCODRequired = reader.Read<bool>("IsCODRequired");
            _codCharge = reader.Read<Currency>("CODCharge");
            _codChargeTax = reader.Read<Currency>("CODChargeTax");
            _shippingCharge = reader.Read<Currency>("ShippingCharge");
            _shippingChargeTax = reader.Read<Currency>("ShippingChargeTax");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("IsCODRequired", _isCODRequired);
            writer.Write("CODCharge", _codCharge);
            writer.Write("CODChargeTax", _codChargeTax);
            writer.Write("ShippingCharge", _shippingCharge);
            writer.Write("ShippingChargeTax", _shippingChargeTax);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "CODSettings", this);
        }

    public CODSettings (bool isCODRequired) : base() {
        this._isCODRequired = isCODRequired;
    }

        public CODSettings() : base()
        {
        }
    }
}
