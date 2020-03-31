/*******************************************************************************
 * Copyright 2009-2020 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Length
 * API Version: 2015-06-01
 * Library Version: 2020-02-06
 * Generated: Mon Mar 02 20:07:24 UTC 2020
 */


using System;
using System.Xml;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class Length : AbstractMwsObject
    {

        private decimal? _value;
        private string _unit;

        /// <summary>
        /// Gets and sets the Value property.
        /// </summary>
        public decimal Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        /// <summary>
        /// Sets the Value property.
        /// </summary>
        /// <param name="value">Value property.</param>
        /// <returns>this instance.</returns>
        public Length WithValue(decimal value)
        {
            this._value = value;
            return this;
        }

        /// <summary>
        /// Checks if Value property is set.
        /// </summary>
        /// <returns>true if Value property is set.</returns>
        public bool IsSetValue()
        {
            return this._value != null;
        }

        /// <summary>
        /// Gets and sets the Unit property.
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        /// <summary>
        /// Sets the Unit property.
        /// </summary>
        /// <param name="unit">Unit property.</param>
        /// <returns>this instance.</returns>
        public Length WithUnit(string unit)
        {
            this._unit = unit;
            return this;
        }

        /// <summary>
        /// Checks if Unit property is set.
        /// </summary>
        /// <returns>true if Unit property is set.</returns>
        public bool IsSetUnit()
        {
            return this._unit != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _value = reader.Read<decimal?>("value");
            _unit = reader.Read<string>("unit");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("value", _value);
            writer.Write("unit", _unit);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "Length", this);
        }


        public Length() : base()
        {
        }
    }
}
