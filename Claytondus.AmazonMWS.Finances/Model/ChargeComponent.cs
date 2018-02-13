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
 * Charge Component
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class ChargeComponent : AbstractMwsObject
    {

        private string _chargeType;
        private Currency _chargeAmount;

        /// <summary>
        /// Gets and sets the ChargeType property.
        /// </summary>
        public string ChargeType
        {
            get { return this._chargeType; }
            set { this._chargeType = value; }
        }

        /// <summary>
        /// Sets the ChargeType property.
        /// </summary>
        /// <param name="chargeType">ChargeType property.</param>
        /// <returns>this instance.</returns>
        public ChargeComponent WithChargeType(string chargeType)
        {
            this._chargeType = chargeType;
            return this;
        }

        /// <summary>
        /// Checks if ChargeType property is set.
        /// </summary>
        /// <returns>true if ChargeType property is set.</returns>
        public bool IsSetChargeType()
        {
            return this._chargeType != null;
        }

        /// <summary>
        /// Gets and sets the ChargeAmount property.
        /// </summary>
        public Currency ChargeAmount
        {
            get { return this._chargeAmount; }
            set { this._chargeAmount = value; }
        }

        /// <summary>
        /// Sets the ChargeAmount property.
        /// </summary>
        /// <param name="chargeAmount">ChargeAmount property.</param>
        /// <returns>this instance.</returns>
        public ChargeComponent WithChargeAmount(Currency chargeAmount)
        {
            this._chargeAmount = chargeAmount;
            return this;
        }

        /// <summary>
        /// Checks if ChargeAmount property is set.
        /// </summary>
        /// <returns>true if ChargeAmount property is set.</returns>
        public bool IsSetChargeAmount()
        {
            return this._chargeAmount != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _chargeType = reader.Read<string>("ChargeType");
            _chargeAmount = reader.Read<Currency>("ChargeAmount");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ChargeType", _chargeType);
            writer.Write("ChargeAmount", _chargeAmount);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "ChargeComponent", this);
        }


        public ChargeComponent() : base()
        {
        }
    }
}
