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
 * Retrocharge Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class RetrochargeEvent : AbstractMwsObject
    {

        private string _retrochargeEventType;
        private string _amazonOrderId;
        private DateTime? _postedDate;
        private Currency _baseTax;
        private Currency _shippingTax;
        private string _marketplaceName;

        /// <summary>
        /// Gets and sets the RetrochargeEventType property.
        /// </summary>
        public string RetrochargeEventType
        {
            get { return this._retrochargeEventType; }
            set { this._retrochargeEventType = value; }
        }

        /// <summary>
        /// Sets the RetrochargeEventType property.
        /// </summary>
        /// <param name="retrochargeEventType">RetrochargeEventType property.</param>
        /// <returns>this instance.</returns>
        public RetrochargeEvent WithRetrochargeEventType(string retrochargeEventType)
        {
            this._retrochargeEventType = retrochargeEventType;
            return this;
        }

        /// <summary>
        /// Checks if RetrochargeEventType property is set.
        /// </summary>
        /// <returns>true if RetrochargeEventType property is set.</returns>
        public bool IsSetRetrochargeEventType()
        {
            return this._retrochargeEventType != null;
        }

        /// <summary>
        /// Gets and sets the AmazonOrderId property.
        /// </summary>
        public string AmazonOrderId
        {
            get { return this._amazonOrderId; }
            set { this._amazonOrderId = value; }
        }

        /// <summary>
        /// Sets the AmazonOrderId property.
        /// </summary>
        /// <param name="amazonOrderId">AmazonOrderId property.</param>
        /// <returns>this instance.</returns>
        public RetrochargeEvent WithAmazonOrderId(string amazonOrderId)
        {
            this._amazonOrderId = amazonOrderId;
            return this;
        }

        /// <summary>
        /// Checks if AmazonOrderId property is set.
        /// </summary>
        /// <returns>true if AmazonOrderId property is set.</returns>
        public bool IsSetAmazonOrderId()
        {
            return this._amazonOrderId != null;
        }

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
        public RetrochargeEvent WithPostedDate(DateTime postedDate)
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
        /// Gets and sets the BaseTax property.
        /// </summary>
        public Currency BaseTax
        {
            get { return this._baseTax; }
            set { this._baseTax = value; }
        }

        /// <summary>
        /// Sets the BaseTax property.
        /// </summary>
        /// <param name="baseTax">BaseTax property.</param>
        /// <returns>this instance.</returns>
        public RetrochargeEvent WithBaseTax(Currency baseTax)
        {
            this._baseTax = baseTax;
            return this;
        }

        /// <summary>
        /// Checks if BaseTax property is set.
        /// </summary>
        /// <returns>true if BaseTax property is set.</returns>
        public bool IsSetBaseTax()
        {
            return this._baseTax != null;
        }

        /// <summary>
        /// Gets and sets the ShippingTax property.
        /// </summary>
        public Currency ShippingTax
        {
            get { return this._shippingTax; }
            set { this._shippingTax = value; }
        }

        /// <summary>
        /// Sets the ShippingTax property.
        /// </summary>
        /// <param name="shippingTax">ShippingTax property.</param>
        /// <returns>this instance.</returns>
        public RetrochargeEvent WithShippingTax(Currency shippingTax)
        {
            this._shippingTax = shippingTax;
            return this;
        }

        /// <summary>
        /// Checks if ShippingTax property is set.
        /// </summary>
        /// <returns>true if ShippingTax property is set.</returns>
        public bool IsSetShippingTax()
        {
            return this._shippingTax != null;
        }

        /// <summary>
        /// Gets and sets the MarketplaceName property.
        /// </summary>
        public string MarketplaceName
        {
            get { return this._marketplaceName; }
            set { this._marketplaceName = value; }
        }

        /// <summary>
        /// Sets the MarketplaceName property.
        /// </summary>
        /// <param name="marketplaceName">MarketplaceName property.</param>
        /// <returns>this instance.</returns>
        public RetrochargeEvent WithMarketplaceName(string marketplaceName)
        {
            this._marketplaceName = marketplaceName;
            return this;
        }

        /// <summary>
        /// Checks if MarketplaceName property is set.
        /// </summary>
        /// <returns>true if MarketplaceName property is set.</returns>
        public bool IsSetMarketplaceName()
        {
            return this._marketplaceName != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _retrochargeEventType = reader.Read<string>("RetrochargeEventType");
            _amazonOrderId = reader.Read<string>("AmazonOrderId");
            _postedDate = reader.Read<DateTime?>("PostedDate");
            _baseTax = reader.Read<Currency>("BaseTax");
            _shippingTax = reader.Read<Currency>("ShippingTax");
            _marketplaceName = reader.Read<string>("MarketplaceName");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("RetrochargeEventType", _retrochargeEventType);
            writer.Write("AmazonOrderId", _amazonOrderId);
            writer.Write("PostedDate", _postedDate);
            writer.Write("BaseTax", _baseTax);
            writer.Write("ShippingTax", _shippingTax);
            writer.Write("MarketplaceName", _marketplaceName);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "RetrochargeEvent", this);
        }


        public RetrochargeEvent() : base()
        {
        }
    }
}
