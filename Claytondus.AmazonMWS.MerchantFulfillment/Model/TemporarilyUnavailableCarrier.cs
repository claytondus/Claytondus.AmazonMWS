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
 * Temporarily Unavailable Carrier
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class TemporarilyUnavailableCarrier : AbstractMwsObject
    {

        private string _carrierName;

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
        public TemporarilyUnavailableCarrier WithCarrierName(string carrierName)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _carrierName = reader.Read<string>("CarrierName");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("CarrierName", _carrierName);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "TemporarilyUnavailableCarrier", this);
        }

    public TemporarilyUnavailableCarrier (string carrierName) : base() {
        this._carrierName = carrierName;
    }

        public TemporarilyUnavailableCarrier() : base()
        {
        }
    }
}
