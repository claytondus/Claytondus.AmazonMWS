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
 * Additional Seller Input
 * API Version: 2015-06-01
 * Library Version: 2020-02-06
 * Generated: Mon Mar 02 20:07:24 UTC 2020
 */


using System;
using System.Xml;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class AdditionalSellerInput : AbstractMwsObject
    {

        private string _dataType;
        private string _valueAsString;
        private bool? _valueAsBoolean;
        private decimal? _valueAsInteger;
        private DateTime? _valueAsTimestamp;
        private Address _valueAsAddress;
        private Weight _valueAsWeight;
        private Length _valueAsDimension;
        private CurrencyAmount _valueAsCurrency;

        /// <summary>
        /// Gets and sets the DataType property.
        /// </summary>
        public string DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        /// <summary>
        /// Sets the DataType property.
        /// </summary>
        /// <param name="dataType">DataType property.</param>
        /// <returns>this instance.</returns>
        public AdditionalSellerInput WithDataType(string dataType)
        {
            this._dataType = dataType;
            return this;
        }

        /// <summary>
        /// Checks if DataType property is set.
        /// </summary>
        /// <returns>true if DataType property is set.</returns>
        public bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the ValueAsString property.
        /// </summary>
        public string ValueAsString
        {
            get { return this._valueAsString; }
            set { this._valueAsString = value; }
        }

        /// <summary>
        /// Sets the ValueAsString property.
        /// </summary>
        /// <param name="valueAsString">ValueAsString property.</param>
        /// <returns>this instance.</returns>
        public AdditionalSellerInput WithValueAsString(string valueAsString)
        {
            this._valueAsString = valueAsString;
            return this;
        }

        /// <summary>
        /// Checks if ValueAsString property is set.
        /// </summary>
        /// <returns>true if ValueAsString property is set.</returns>
        public bool IsSetValueAsString()
        {
            return this._valueAsString != null;
        }

        /// <summary>
        /// Gets and sets the ValueAsBoolean property.
        /// </summary>
        public bool ValueAsBoolean
        {
            get { return this._valueAsBoolean.GetValueOrDefault(); }
            set { this._valueAsBoolean = value; }
        }

        /// <summary>
        /// Sets the ValueAsBoolean property.
        /// </summary>
        /// <param name="valueAsBoolean">ValueAsBoolean property.</param>
        /// <returns>this instance.</returns>
        public AdditionalSellerInput WithValueAsBoolean(bool valueAsBoolean)
        {
            this._valueAsBoolean = valueAsBoolean;
            return this;
        }

        /// <summary>
        /// Checks if ValueAsBoolean property is set.
        /// </summary>
        /// <returns>true if ValueAsBoolean property is set.</returns>
        public bool IsSetValueAsBoolean()
        {
            return this._valueAsBoolean != null;
        }

        /// <summary>
        /// Gets and sets the ValueAsInteger property.
        /// </summary>
        public decimal ValueAsInteger
        {
            get { return this._valueAsInteger.GetValueOrDefault(); }
            set { this._valueAsInteger = value; }
        }

        /// <summary>
        /// Sets the ValueAsInteger property.
        /// </summary>
        /// <param name="valueAsInteger">ValueAsInteger property.</param>
        /// <returns>this instance.</returns>
        public AdditionalSellerInput WithValueAsInteger(decimal valueAsInteger)
        {
            this._valueAsInteger = valueAsInteger;
            return this;
        }

        /// <summary>
        /// Checks if ValueAsInteger property is set.
        /// </summary>
        /// <returns>true if ValueAsInteger property is set.</returns>
        public bool IsSetValueAsInteger()
        {
            return this._valueAsInteger != null;
        }

        /// <summary>
        /// Gets and sets the ValueAsTimestamp property.
        /// </summary>
        public DateTime ValueAsTimestamp
        {
            get { return this._valueAsTimestamp.GetValueOrDefault(); }
            set { this._valueAsTimestamp = value; }
        }

        /// <summary>
        /// Sets the ValueAsTimestamp property.
        /// </summary>
        /// <param name="valueAsTimestamp">ValueAsTimestamp property.</param>
        /// <returns>this instance.</returns>
        public AdditionalSellerInput WithValueAsTimestamp(DateTime valueAsTimestamp)
        {
            this._valueAsTimestamp = valueAsTimestamp;
            return this;
        }

        /// <summary>
        /// Checks if ValueAsTimestamp property is set.
        /// </summary>
        /// <returns>true if ValueAsTimestamp property is set.</returns>
        public bool IsSetValueAsTimestamp()
        {
            return this._valueAsTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the ValueAsAddress property.
        /// </summary>
        public Address ValueAsAddress
        {
            get { return this._valueAsAddress; }
            set { this._valueAsAddress = value; }
        }

        /// <summary>
        /// Sets the ValueAsAddress property.
        /// </summary>
        /// <param name="valueAsAddress">ValueAsAddress property.</param>
        /// <returns>this instance.</returns>
        public AdditionalSellerInput WithValueAsAddress(Address valueAsAddress)
        {
            this._valueAsAddress = valueAsAddress;
            return this;
        }

        /// <summary>
        /// Checks if ValueAsAddress property is set.
        /// </summary>
        /// <returns>true if ValueAsAddress property is set.</returns>
        public bool IsSetValueAsAddress()
        {
            return this._valueAsAddress != null;
        }

        /// <summary>
        /// Gets and sets the ValueAsWeight property.
        /// </summary>
        public Weight ValueAsWeight
        {
            get { return this._valueAsWeight; }
            set { this._valueAsWeight = value; }
        }

        /// <summary>
        /// Sets the ValueAsWeight property.
        /// </summary>
        /// <param name="valueAsWeight">ValueAsWeight property.</param>
        /// <returns>this instance.</returns>
        public AdditionalSellerInput WithValueAsWeight(Weight valueAsWeight)
        {
            this._valueAsWeight = valueAsWeight;
            return this;
        }

        /// <summary>
        /// Checks if ValueAsWeight property is set.
        /// </summary>
        /// <returns>true if ValueAsWeight property is set.</returns>
        public bool IsSetValueAsWeight()
        {
            return this._valueAsWeight != null;
        }

        /// <summary>
        /// Gets and sets the ValueAsDimension property.
        /// </summary>
        public Length ValueAsDimension
        {
            get { return this._valueAsDimension; }
            set { this._valueAsDimension = value; }
        }

        /// <summary>
        /// Sets the ValueAsDimension property.
        /// </summary>
        /// <param name="valueAsDimension">ValueAsDimension property.</param>
        /// <returns>this instance.</returns>
        public AdditionalSellerInput WithValueAsDimension(Length valueAsDimension)
        {
            this._valueAsDimension = valueAsDimension;
            return this;
        }

        /// <summary>
        /// Checks if ValueAsDimension property is set.
        /// </summary>
        /// <returns>true if ValueAsDimension property is set.</returns>
        public bool IsSetValueAsDimension()
        {
            return this._valueAsDimension != null;
        }

        /// <summary>
        /// Gets and sets the ValueAsCurrency property.
        /// </summary>
        public CurrencyAmount ValueAsCurrency
        {
            get { return this._valueAsCurrency; }
            set { this._valueAsCurrency = value; }
        }

        /// <summary>
        /// Sets the ValueAsCurrency property.
        /// </summary>
        /// <param name="valueAsCurrency">ValueAsCurrency property.</param>
        /// <returns>this instance.</returns>
        public AdditionalSellerInput WithValueAsCurrency(CurrencyAmount valueAsCurrency)
        {
            this._valueAsCurrency = valueAsCurrency;
            return this;
        }

        /// <summary>
        /// Checks if ValueAsCurrency property is set.
        /// </summary>
        /// <returns>true if ValueAsCurrency property is set.</returns>
        public bool IsSetValueAsCurrency()
        {
            return this._valueAsCurrency != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _dataType = reader.Read<string>("DataType");
            _valueAsString = reader.Read<string>("ValueAsString");
            _valueAsBoolean = reader.Read<bool?>("ValueAsBoolean");
            _valueAsInteger = reader.Read<decimal?>("ValueAsInteger");
            _valueAsTimestamp = reader.Read<DateTime?>("ValueAsTimestamp");
            _valueAsAddress = reader.Read<Address>("ValueAsAddress");
            _valueAsWeight = reader.Read<Weight>("ValueAsWeight");
            _valueAsDimension = reader.Read<Length>("ValueAsDimension");
            _valueAsCurrency = reader.Read<CurrencyAmount>("ValueAsCurrency");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("DataType", _dataType);
            writer.Write("ValueAsString", _valueAsString);
            writer.Write("ValueAsBoolean", _valueAsBoolean);
            writer.Write("ValueAsInteger", _valueAsInteger);
            writer.Write("ValueAsTimestamp", _valueAsTimestamp);
            writer.Write("ValueAsAddress", _valueAsAddress);
            writer.Write("ValueAsWeight", _valueAsWeight);
            writer.Write("ValueAsDimension", _valueAsDimension);
            writer.Write("ValueAsCurrency", _valueAsCurrency);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "AdditionalSellerInput", this);
        }


        public AdditionalSellerInput() : base()
        {
        }
    }
}
