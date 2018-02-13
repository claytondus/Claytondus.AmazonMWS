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
 * Seller Deal Payment Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class SellerDealPaymentEvent : AbstractMwsObject
    {

        private DateTime? _postedDate;
        private string _dealId;
        private string _dealDescription;
        private string _eventType;
        private string _feeType;
        private Currency _feeAmount;
        private Currency _taxAmount;
        private Currency _totalAmount;

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
        public SellerDealPaymentEvent WithPostedDate(DateTime postedDate)
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
        /// Gets and sets the DealId property.
        /// </summary>
        public string DealId
        {
            get { return this._dealId; }
            set { this._dealId = value; }
        }

        /// <summary>
        /// Sets the DealId property.
        /// </summary>
        /// <param name="dealId">DealId property.</param>
        /// <returns>this instance.</returns>
        public SellerDealPaymentEvent WithDealId(string dealId)
        {
            this._dealId = dealId;
            return this;
        }

        /// <summary>
        /// Checks if DealId property is set.
        /// </summary>
        /// <returns>true if DealId property is set.</returns>
        public bool IsSetDealId()
        {
            return this._dealId != null;
        }

        /// <summary>
        /// Gets and sets the DealDescription property.
        /// </summary>
        public string DealDescription
        {
            get { return this._dealDescription; }
            set { this._dealDescription = value; }
        }

        /// <summary>
        /// Sets the DealDescription property.
        /// </summary>
        /// <param name="dealDescription">DealDescription property.</param>
        /// <returns>this instance.</returns>
        public SellerDealPaymentEvent WithDealDescription(string dealDescription)
        {
            this._dealDescription = dealDescription;
            return this;
        }

        /// <summary>
        /// Checks if DealDescription property is set.
        /// </summary>
        /// <returns>true if DealDescription property is set.</returns>
        public bool IsSetDealDescription()
        {
            return this._dealDescription != null;
        }

        /// <summary>
        /// Gets and sets the EventType property.
        /// </summary>
        public string EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        /// <summary>
        /// Sets the EventType property.
        /// </summary>
        /// <param name="eventType">EventType property.</param>
        /// <returns>this instance.</returns>
        public SellerDealPaymentEvent WithEventType(string eventType)
        {
            this._eventType = eventType;
            return this;
        }

        /// <summary>
        /// Checks if EventType property is set.
        /// </summary>
        /// <returns>true if EventType property is set.</returns>
        public bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the FeeType property.
        /// </summary>
        public string FeeType
        {
            get { return this._feeType; }
            set { this._feeType = value; }
        }

        /// <summary>
        /// Sets the FeeType property.
        /// </summary>
        /// <param name="feeType">FeeType property.</param>
        /// <returns>this instance.</returns>
        public SellerDealPaymentEvent WithFeeType(string feeType)
        {
            this._feeType = feeType;
            return this;
        }

        /// <summary>
        /// Checks if FeeType property is set.
        /// </summary>
        /// <returns>true if FeeType property is set.</returns>
        public bool IsSetFeeType()
        {
            return this._feeType != null;
        }

        /// <summary>
        /// Gets and sets the FeeAmount property.
        /// </summary>
        public Currency FeeAmount
        {
            get { return this._feeAmount; }
            set { this._feeAmount = value; }
        }

        /// <summary>
        /// Sets the FeeAmount property.
        /// </summary>
        /// <param name="feeAmount">FeeAmount property.</param>
        /// <returns>this instance.</returns>
        public SellerDealPaymentEvent WithFeeAmount(Currency feeAmount)
        {
            this._feeAmount = feeAmount;
            return this;
        }

        /// <summary>
        /// Checks if FeeAmount property is set.
        /// </summary>
        /// <returns>true if FeeAmount property is set.</returns>
        public bool IsSetFeeAmount()
        {
            return this._feeAmount != null;
        }

        /// <summary>
        /// Gets and sets the TaxAmount property.
        /// </summary>
        public Currency TaxAmount
        {
            get { return this._taxAmount; }
            set { this._taxAmount = value; }
        }

        /// <summary>
        /// Sets the TaxAmount property.
        /// </summary>
        /// <param name="taxAmount">TaxAmount property.</param>
        /// <returns>this instance.</returns>
        public SellerDealPaymentEvent WithTaxAmount(Currency taxAmount)
        {
            this._taxAmount = taxAmount;
            return this;
        }

        /// <summary>
        /// Checks if TaxAmount property is set.
        /// </summary>
        /// <returns>true if TaxAmount property is set.</returns>
        public bool IsSetTaxAmount()
        {
            return this._taxAmount != null;
        }

        /// <summary>
        /// Gets and sets the TotalAmount property.
        /// </summary>
        public Currency TotalAmount
        {
            get { return this._totalAmount; }
            set { this._totalAmount = value; }
        }

        /// <summary>
        /// Sets the TotalAmount property.
        /// </summary>
        /// <param name="totalAmount">TotalAmount property.</param>
        /// <returns>this instance.</returns>
        public SellerDealPaymentEvent WithTotalAmount(Currency totalAmount)
        {
            this._totalAmount = totalAmount;
            return this;
        }

        /// <summary>
        /// Checks if TotalAmount property is set.
        /// </summary>
        /// <returns>true if TotalAmount property is set.</returns>
        public bool IsSetTotalAmount()
        {
            return this._totalAmount != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _postedDate = reader.Read<DateTime?>("postedDate");
            _dealId = reader.Read<string>("dealId");
            _dealDescription = reader.Read<string>("dealDescription");
            _eventType = reader.Read<string>("eventType");
            _feeType = reader.Read<string>("feeType");
            _feeAmount = reader.Read<Currency>("feeAmount");
            _taxAmount = reader.Read<Currency>("taxAmount");
            _totalAmount = reader.Read<Currency>("totalAmount");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("postedDate", _postedDate);
            writer.Write("dealId", _dealId);
            writer.Write("dealDescription", _dealDescription);
            writer.Write("eventType", _eventType);
            writer.Write("feeType", _feeType);
            writer.Write("feeAmount", _feeAmount);
            writer.Write("taxAmount", _taxAmount);
            writer.Write("totalAmount", _totalAmount);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "SellerDealPaymentEvent", this);
        }


        public SellerDealPaymentEvent() : base()
        {
        }
    }
}
