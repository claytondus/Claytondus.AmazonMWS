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
 * Shipping Service
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */


using System;
using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class ShippingService : AbstractMwsObject
    {

        private string _shippingServiceName;
        private string _carrierName;
        private string _shippingServiceId;
        private string _shippingServiceOfferId;
        private DateTime? _shipDate;
        private DateTime? _earliestEstimatedDeliveryDate;
        private DateTime? _latestEstimatedDeliveryDate;
        private CurrencyAmount _rate;
        private ShippingServiceOptions _shippingServiceOptions;
        private List<string> _availableLabelFormats;

        /// <summary>
        /// Gets and sets the ShippingServiceName property.
        /// </summary>
        public string ShippingServiceName
        {
            get { return this._shippingServiceName; }
            set { this._shippingServiceName = value; }
        }

        /// <summary>
        /// Sets the ShippingServiceName property.
        /// </summary>
        /// <param name="shippingServiceName">ShippingServiceName property.</param>
        /// <returns>this instance.</returns>
        public ShippingService WithShippingServiceName(string shippingServiceName)
        {
            this._shippingServiceName = shippingServiceName;
            return this;
        }

        /// <summary>
        /// Checks if ShippingServiceName property is set.
        /// </summary>
        /// <returns>true if ShippingServiceName property is set.</returns>
        public bool IsSetShippingServiceName()
        {
            return this._shippingServiceName != null;
        }

        /// <summary>
        /// Gets and sets the CarrierName property.
        /// </summary>
        public string CarrierName
        {
            get { return this._carrierName; }
            set { this._carrierName = value; }
        }

        /// <summary>
        /// Sets the CarrierName property.
        /// </summary>
        /// <param name="carrierName">CarrierName property.</param>
        /// <returns>this instance.</returns>
        public ShippingService WithCarrierName(string carrierName)
        {
            this._carrierName = carrierName;
            return this;
        }

        /// <summary>
        /// Checks if CarrierName property is set.
        /// </summary>
        /// <returns>true if CarrierName property is set.</returns>
        public bool IsSetCarrierName()
        {
            return this._carrierName != null;
        }

        /// <summary>
        /// Gets and sets the ShippingServiceId property.
        /// </summary>
        public string ShippingServiceId
        {
            get { return this._shippingServiceId; }
            set { this._shippingServiceId = value; }
        }

        /// <summary>
        /// Sets the ShippingServiceId property.
        /// </summary>
        /// <param name="shippingServiceId">ShippingServiceId property.</param>
        /// <returns>this instance.</returns>
        public ShippingService WithShippingServiceId(string shippingServiceId)
        {
            this._shippingServiceId = shippingServiceId;
            return this;
        }

        /// <summary>
        /// Checks if ShippingServiceId property is set.
        /// </summary>
        /// <returns>true if ShippingServiceId property is set.</returns>
        public bool IsSetShippingServiceId()
        {
            return this._shippingServiceId != null;
        }

        /// <summary>
        /// Gets and sets the ShippingServiceOfferId property.
        /// </summary>
        public string ShippingServiceOfferId
        {
            get { return this._shippingServiceOfferId; }
            set { this._shippingServiceOfferId = value; }
        }

        /// <summary>
        /// Sets the ShippingServiceOfferId property.
        /// </summary>
        /// <param name="shippingServiceOfferId">ShippingServiceOfferId property.</param>
        /// <returns>this instance.</returns>
        public ShippingService WithShippingServiceOfferId(string shippingServiceOfferId)
        {
            this._shippingServiceOfferId = shippingServiceOfferId;
            return this;
        }

        /// <summary>
        /// Checks if ShippingServiceOfferId property is set.
        /// </summary>
        /// <returns>true if ShippingServiceOfferId property is set.</returns>
        public bool IsSetShippingServiceOfferId()
        {
            return this._shippingServiceOfferId != null;
        }

        /// <summary>
        /// Gets and sets the ShipDate property.
        /// </summary>
        public DateTime ShipDate
        {
            get { return this._shipDate.GetValueOrDefault(); }
            set { this._shipDate = value; }
        }

        /// <summary>
        /// Sets the ShipDate property.
        /// </summary>
        /// <param name="shipDate">ShipDate property.</param>
        /// <returns>this instance.</returns>
        public ShippingService WithShipDate(DateTime shipDate)
        {
            this._shipDate = shipDate;
            return this;
        }

        /// <summary>
        /// Checks if ShipDate property is set.
        /// </summary>
        /// <returns>true if ShipDate property is set.</returns>
        public bool IsSetShipDate()
        {
            return this._shipDate != null;
        }

        /// <summary>
        /// Gets and sets the EarliestEstimatedDeliveryDate property.
        /// </summary>
        public DateTime EarliestEstimatedDeliveryDate
        {
            get { return this._earliestEstimatedDeliveryDate.GetValueOrDefault(); }
            set { this._earliestEstimatedDeliveryDate = value; }
        }

        /// <summary>
        /// Sets the EarliestEstimatedDeliveryDate property.
        /// </summary>
        /// <param name="earliestEstimatedDeliveryDate">EarliestEstimatedDeliveryDate property.</param>
        /// <returns>this instance.</returns>
        public ShippingService WithEarliestEstimatedDeliveryDate(DateTime earliestEstimatedDeliveryDate)
        {
            this._earliestEstimatedDeliveryDate = earliestEstimatedDeliveryDate;
            return this;
        }

        /// <summary>
        /// Checks if EarliestEstimatedDeliveryDate property is set.
        /// </summary>
        /// <returns>true if EarliestEstimatedDeliveryDate property is set.</returns>
        public bool IsSetEarliestEstimatedDeliveryDate()
        {
            return this._earliestEstimatedDeliveryDate != null;
        }

        /// <summary>
        /// Gets and sets the LatestEstimatedDeliveryDate property.
        /// </summary>
        public DateTime LatestEstimatedDeliveryDate
        {
            get { return this._latestEstimatedDeliveryDate.GetValueOrDefault(); }
            set { this._latestEstimatedDeliveryDate = value; }
        }

        /// <summary>
        /// Sets the LatestEstimatedDeliveryDate property.
        /// </summary>
        /// <param name="latestEstimatedDeliveryDate">LatestEstimatedDeliveryDate property.</param>
        /// <returns>this instance.</returns>
        public ShippingService WithLatestEstimatedDeliveryDate(DateTime latestEstimatedDeliveryDate)
        {
            this._latestEstimatedDeliveryDate = latestEstimatedDeliveryDate;
            return this;
        }

        /// <summary>
        /// Checks if LatestEstimatedDeliveryDate property is set.
        /// </summary>
        /// <returns>true if LatestEstimatedDeliveryDate property is set.</returns>
        public bool IsSetLatestEstimatedDeliveryDate()
        {
            return this._latestEstimatedDeliveryDate != null;
        }

        /// <summary>
        /// Gets and sets the Rate property.
        /// </summary>
        public CurrencyAmount Rate
        {
            get { return this._rate; }
            set { this._rate = value; }
        }

        /// <summary>
        /// Sets the Rate property.
        /// </summary>
        /// <param name="rate">Rate property.</param>
        /// <returns>this instance.</returns>
        public ShippingService WithRate(CurrencyAmount rate)
        {
            this._rate = rate;
            return this;
        }

        /// <summary>
        /// Checks if Rate property is set.
        /// </summary>
        /// <returns>true if Rate property is set.</returns>
        public bool IsSetRate()
        {
            return this._rate != null;
        }

        /// <summary>
        /// Gets and sets the ShippingServiceOptions property.
        /// </summary>
        public ShippingServiceOptions ShippingServiceOptions
        {
            get { return this._shippingServiceOptions; }
            set { this._shippingServiceOptions = value; }
        }

        /// <summary>
        /// Sets the ShippingServiceOptions property.
        /// </summary>
        /// <param name="shippingServiceOptions">ShippingServiceOptions property.</param>
        /// <returns>this instance.</returns>
        public ShippingService WithShippingServiceOptions(ShippingServiceOptions shippingServiceOptions)
        {
            this._shippingServiceOptions = shippingServiceOptions;
            return this;
        }

        /// <summary>
        /// Checks if ShippingServiceOptions property is set.
        /// </summary>
        /// <returns>true if ShippingServiceOptions property is set.</returns>
        public bool IsSetShippingServiceOptions()
        {
            return this._shippingServiceOptions != null;
        }

        /// <summary>
        /// Gets and sets the AvailableLabelFormats property.
        /// </summary>
        public List<string> AvailableLabelFormats
        {
            get
            {
                if(this._availableLabelFormats == null)
                {
                    this._availableLabelFormats = new List<string>();
                }
                return this._availableLabelFormats;
            }
            set { this._availableLabelFormats = value; }
        }

        /// <summary>
        /// Sets the AvailableLabelFormats property.
        /// </summary>
        /// <param name="availableLabelFormats">AvailableLabelFormats property.</param>
        /// <returns>this instance.</returns>
        public ShippingService WithAvailableLabelFormats(string[] availableLabelFormats)
        {
            this._availableLabelFormats.AddRange(availableLabelFormats);
            return this;
        }

        /// <summary>
        /// Checks if AvailableLabelFormats property is set.
        /// </summary>
        /// <returns>true if AvailableLabelFormats property is set.</returns>
        public bool IsSetAvailableLabelFormats()
        {
            return this.AvailableLabelFormats.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _shippingServiceName = reader.Read<string>("ShippingServiceName");
            _carrierName = reader.Read<string>("CarrierName");
            _shippingServiceId = reader.Read<string>("ShippingServiceId");
            _shippingServiceOfferId = reader.Read<string>("ShippingServiceOfferId");
            _shipDate = reader.Read<DateTime?>("ShipDate");
            _earliestEstimatedDeliveryDate = reader.Read<DateTime?>("EarliestEstimatedDeliveryDate");
            _latestEstimatedDeliveryDate = reader.Read<DateTime?>("LatestEstimatedDeliveryDate");
            _rate = reader.Read<CurrencyAmount>("Rate");
            _shippingServiceOptions = reader.Read<ShippingServiceOptions>("ShippingServiceOptions");
            _availableLabelFormats = reader.ReadList<string>("AvailableLabelFormats", "LabelFormat");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ShippingServiceName", _shippingServiceName);
            writer.Write("CarrierName", _carrierName);
            writer.Write("ShippingServiceId", _shippingServiceId);
            writer.Write("ShippingServiceOfferId", _shippingServiceOfferId);
            writer.Write("ShipDate", _shipDate);
            writer.Write("EarliestEstimatedDeliveryDate", _earliestEstimatedDeliveryDate);
            writer.Write("LatestEstimatedDeliveryDate", _latestEstimatedDeliveryDate);
            writer.Write("Rate", _rate);
            writer.Write("ShippingServiceOptions", _shippingServiceOptions);
            writer.WriteList("AvailableLabelFormats", "LabelFormat", _availableLabelFormats);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "ShippingService", this);
        }

    public ShippingService (string shippingServiceName,string carrierName,string shippingServiceId,string shippingServiceOfferId,DateTime? shipDate,CurrencyAmount rate,ShippingServiceOptions shippingServiceOptions,List<string> availableLabelFormats) : base() {
        this._shippingServiceName = shippingServiceName;
        this._carrierName = carrierName;
        this._shippingServiceId = shippingServiceId;
        this._shippingServiceOfferId = shippingServiceOfferId;
        this._shipDate = shipDate;
        this._rate = rate;
        this._shippingServiceOptions = shippingServiceOptions;
        this._availableLabelFormats = availableLabelFormats;
    }

        public ShippingService() : base()
        {
        }
    }
}
