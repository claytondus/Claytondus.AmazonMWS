/*******************************************************************************
 * Copyright 2009-2018 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Product Ads Payment Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class ProductAdsPaymentEvent : AbstractMwsObject
    {

        private DateTime? _postedDate;
        private string _transactionType;
        private string _invoiceId;
        private Currency _baseValue;
        private Currency _taxValue;
        private Currency _transactionValue;

        /// <summary>
        /// Gets and sets the PostedDate property.
        /// </summary>
        public DateTime PostedDate
        {
            get { return this._postedDate.GetValueOrDefault(); }
            set { this._postedDate = value; }
        }

        /// <summary>
        /// Sets the PostedDate property.
        /// </summary>
        /// <param name="postedDate">PostedDate property.</param>
        /// <returns>this instance.</returns>
        public ProductAdsPaymentEvent WithPostedDate(DateTime postedDate)
        {
            this._postedDate = postedDate;
            return this;
        }

        /// <summary>
        /// Checks if PostedDate property is set.
        /// </summary>
        /// <returns>true if PostedDate property is set.</returns>
        public bool IsSetPostedDate()
        {
            return this._postedDate != null;
        }

        /// <summary>
        /// Gets and sets the TransactionType property.
        /// </summary>
        public string TransactionType
        {
            get { return this._transactionType; }
            set { this._transactionType = value; }
        }

        /// <summary>
        /// Sets the TransactionType property.
        /// </summary>
        /// <param name="transactionType">TransactionType property.</param>
        /// <returns>this instance.</returns>
        public ProductAdsPaymentEvent WithTransactionType(string transactionType)
        {
            this._transactionType = transactionType;
            return this;
        }

        /// <summary>
        /// Checks if TransactionType property is set.
        /// </summary>
        /// <returns>true if TransactionType property is set.</returns>
        public bool IsSetTransactionType()
        {
            return this._transactionType != null;
        }

        /// <summary>
        /// Gets and sets the InvoiceId property.
        /// </summary>
        public string InvoiceId
        {
            get { return this._invoiceId; }
            set { this._invoiceId = value; }
        }

        /// <summary>
        /// Sets the InvoiceId property.
        /// </summary>
        /// <param name="invoiceId">InvoiceId property.</param>
        /// <returns>this instance.</returns>
        public ProductAdsPaymentEvent WithInvoiceId(string invoiceId)
        {
            this._invoiceId = invoiceId;
            return this;
        }

        /// <summary>
        /// Checks if InvoiceId property is set.
        /// </summary>
        /// <returns>true if InvoiceId property is set.</returns>
        public bool IsSetInvoiceId()
        {
            return this._invoiceId != null;
        }

        /// <summary>
        /// Gets and sets the BaseValue property.
        /// </summary>
        public Currency BaseValue
        {
            get { return this._baseValue; }
            set { this._baseValue = value; }
        }

        /// <summary>
        /// Sets the BaseValue property.
        /// </summary>
        /// <param name="baseValue">BaseValue property.</param>
        /// <returns>this instance.</returns>
        public ProductAdsPaymentEvent WithBaseValue(Currency baseValue)
        {
            this._baseValue = baseValue;
            return this;
        }

        /// <summary>
        /// Checks if BaseValue property is set.
        /// </summary>
        /// <returns>true if BaseValue property is set.</returns>
        public bool IsSetBaseValue()
        {
            return this._baseValue != null;
        }

        /// <summary>
        /// Gets and sets the TaxValue property.
        /// </summary>
        public Currency TaxValue
        {
            get { return this._taxValue; }
            set { this._taxValue = value; }
        }

        /// <summary>
        /// Sets the TaxValue property.
        /// </summary>
        /// <param name="taxValue">TaxValue property.</param>
        /// <returns>this instance.</returns>
        public ProductAdsPaymentEvent WithTaxValue(Currency taxValue)
        {
            this._taxValue = taxValue;
            return this;
        }

        /// <summary>
        /// Checks if TaxValue property is set.
        /// </summary>
        /// <returns>true if TaxValue property is set.</returns>
        public bool IsSetTaxValue()
        {
            return this._taxValue != null;
        }

        /// <summary>
        /// Gets and sets the TransactionValue property.
        /// </summary>
        public Currency TransactionValue
        {
            get { return this._transactionValue; }
            set { this._transactionValue = value; }
        }

        /// <summary>
        /// Sets the TransactionValue property.
        /// </summary>
        /// <param name="transactionValue">TransactionValue property.</param>
        /// <returns>this instance.</returns>
        public ProductAdsPaymentEvent WithTransactionValue(Currency transactionValue)
        {
            this._transactionValue = transactionValue;
            return this;
        }

        /// <summary>
        /// Checks if TransactionValue property is set.
        /// </summary>
        /// <returns>true if TransactionValue property is set.</returns>
        public bool IsSetTransactionValue()
        {
            return this._transactionValue != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _postedDate = reader.Read<DateTime?>("postedDate");
            _transactionType = reader.Read<string>("transactionType");
            _invoiceId = reader.Read<string>("invoiceId");
            _baseValue = reader.Read<Currency>("baseValue");
            _taxValue = reader.Read<Currency>("taxValue");
            _transactionValue = reader.Read<Currency>("transactionValue");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("postedDate", _postedDate);
            writer.Write("transactionType", _transactionType);
            writer.Write("invoiceId", _invoiceId);
            writer.Write("baseValue", _baseValue);
            writer.Write("taxValue", _taxValue);
            writer.Write("transactionValue", _transactionValue);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "ProductAdsPaymentEvent", this);
        }


        public ProductAdsPaymentEvent() : base()
        {
        }
    }
}
