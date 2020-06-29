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
 * Money Type
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */


using System;
using System.Globalization;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Products.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false)]
    public class MoneyType : AbstractMwsObject
    {

        private string _currencyCode;
        private decimal? _amount;

        /// <summary>
        /// Gets and sets the CurrencyCode property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CurrencyCode")]
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        /// <summary>
        /// Sets the CurrencyCode property.
        /// </summary>
        /// <param name="currencyCode">CurrencyCode property.</param>
        /// <returns>this instance.</returns>
        public MoneyType WithCurrencyCode(string currencyCode)
        {
            this._currencyCode = currencyCode;
            return this;
        }

        /// <summary>
        /// Checks if CurrencyCode property is set.
        /// </summary>
        /// <returns>true if CurrencyCode property is set.</returns>
        public bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the Amount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Amount")]
        public decimal Amount
        {
            get { return this._amount.GetValueOrDefault(); }
            set { this._amount = value; }
        }

        /// <summary>
        /// Sets the Amount property.
        /// </summary>
        /// <param name="amount">Amount property.</param>
        /// <returns>this instance.</returns>
        public MoneyType WithAmount(decimal amount)
        {
            this._amount = amount;
            return this;
        }

        /// <summary>
        /// Checks if Amount property is set.
        /// </summary>
        /// <returns>true if Amount property is set.</returns>
        public bool IsSetAmount()
        {
            return this._amount != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _currencyCode = reader.Read<string>("CurrencyCode");
            _amount = reader.Read<decimal?>("Amount");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("CurrencyCode", _currencyCode);
            writer.Write("Amount", _amount?.ToString("0.00", CultureInfo.InvariantCulture));
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "MoneyType", this);
        }


        public MoneyType() : base()
        {
        }
    }
}
