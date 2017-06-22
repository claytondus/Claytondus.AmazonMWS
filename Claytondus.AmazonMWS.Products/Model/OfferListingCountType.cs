/*******************************************************************************
 * Copyright 2009-2017 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Offer Listing Count Type
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Products.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false)]
    public class OfferListingCountType : AbstractMwsObject
    {

        private decimal _value;
        private string _condition;

        /// <summary>
        /// Gets and sets the Value property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Value")]
        public decimal Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        /// <summary>
        /// Sets the Value property.
        /// </summary>
        /// <param name="value">Value property.</param>
        /// <returns>this instance.</returns>
        public OfferListingCountType WithValue(decimal value)
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
        /// Gets and sets the condition property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "condition")]
        public string condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        /// <summary>
        /// Sets the condition property.
        /// </summary>
        /// <param name="condition">condition property.</param>
        /// <returns>this instance.</returns>
        public OfferListingCountType Withcondition(string condition)
        {
            this._condition = condition;
            return this;
        }

        /// <summary>
        /// Checks if condition property is set.
        /// </summary>
        /// <returns>true if condition property is set.</returns>
        public bool IsSetcondition()
        {
            return this._condition != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _condition = reader.ReadAttribute<string>("condition");
            _value = reader.ReadValue<decimal>();
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteAttribute("condition",_condition);
            writer.WriteValue(_value);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "OfferListingCountType", this);
        }

    public OfferListingCountType (decimal value,string condition) : base() {
        this._value = value;
        this._condition = condition;
    }

        public OfferListingCountType() : base()
        {
        }
    }
}
