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
 * Box Contents Fee Details
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
    public class BoxContentsFeeDetails : AbstractMwsObject
    {

        private decimal? _totalUnits;
        private Amount _feePerUnit;
        private Amount _totalFee;

        /// <summary>
        /// Gets and sets the TotalUnits property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TotalUnits")]
        public decimal TotalUnits
        {
            get { return this._totalUnits.GetValueOrDefault(); }
            set { this._totalUnits = value; }
        }

        /// <summary>
        /// Sets the TotalUnits property.
        /// </summary>
        /// <param name="totalUnits">TotalUnits property.</param>
        /// <returns>this instance.</returns>
        public BoxContentsFeeDetails WithTotalUnits(decimal totalUnits)
        {
            this._totalUnits = totalUnits;
            return this;
        }

        /// <summary>
        /// Checks if TotalUnits property is set.
        /// </summary>
        /// <returns>true if TotalUnits property is set.</returns>
        public bool IsSetTotalUnits()
        {
            return this._totalUnits != null;
        }

        /// <summary>
        /// Gets and sets the FeePerUnit property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeePerUnit")]
        public Amount FeePerUnit
        {
            get { return this._feePerUnit; }
            set { this._feePerUnit = value; }
        }

        /// <summary>
        /// Sets the FeePerUnit property.
        /// </summary>
        /// <param name="feePerUnit">FeePerUnit property.</param>
        /// <returns>this instance.</returns>
        public BoxContentsFeeDetails WithFeePerUnit(Amount feePerUnit)
        {
            this._feePerUnit = feePerUnit;
            return this;
        }

        /// <summary>
        /// Checks if FeePerUnit property is set.
        /// </summary>
        /// <returns>true if FeePerUnit property is set.</returns>
        public bool IsSetFeePerUnit()
        {
            return this._feePerUnit != null;
        }

        /// <summary>
        /// Gets and sets the TotalFee property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TotalFee")]
        public Amount TotalFee
        {
            get { return this._totalFee; }
            set { this._totalFee = value; }
        }

        /// <summary>
        /// Sets the TotalFee property.
        /// </summary>
        /// <param name="totalFee">TotalFee property.</param>
        /// <returns>this instance.</returns>
        public BoxContentsFeeDetails WithTotalFee(Amount totalFee)
        {
            this._totalFee = totalFee;
            return this;
        }

        /// <summary>
        /// Checks if TotalFee property is set.
        /// </summary>
        /// <returns>true if TotalFee property is set.</returns>
        public bool IsSetTotalFee()
        {
            return this._totalFee != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _totalUnits = reader.Read<decimal?>("TotalUnits");
            _feePerUnit = reader.Read<Amount>("FeePerUnit");
            _totalFee = reader.Read<Amount>("TotalFee");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("TotalUnits", _totalUnits);
            writer.Write("FeePerUnit", _feePerUnit);
            writer.Write("TotalFee", _totalFee);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "BoxContentsFeeDetails", this);
        }


        public BoxContentsFeeDetails() : base()
        {
        }
    }
}
