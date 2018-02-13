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
 * Direct Payment
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class DirectPayment : AbstractMwsObject
    {

        private string _directPaymentType;
        private Currency _directPaymentAmount;

        /// <summary>
        /// Gets and sets the DirectPaymentType property.
        /// </summary>
        public string DirectPaymentType
        {
            get { return this._directPaymentType; }
            set { this._directPaymentType = value; }
        }

        /// <summary>
        /// Sets the DirectPaymentType property.
        /// </summary>
        /// <param name="directPaymentType">DirectPaymentType property.</param>
        /// <returns>this instance.</returns>
        public DirectPayment WithDirectPaymentType(string directPaymentType)
        {
            this._directPaymentType = directPaymentType;
            return this;
        }

        /// <summary>
        /// Checks if DirectPaymentType property is set.
        /// </summary>
        /// <returns>true if DirectPaymentType property is set.</returns>
        public bool IsSetDirectPaymentType()
        {
            return this._directPaymentType != null;
        }

        /// <summary>
        /// Gets and sets the DirectPaymentAmount property.
        /// </summary>
        public Currency DirectPaymentAmount
        {
            get { return this._directPaymentAmount; }
            set { this._directPaymentAmount = value; }
        }

        /// <summary>
        /// Sets the DirectPaymentAmount property.
        /// </summary>
        /// <param name="directPaymentAmount">DirectPaymentAmount property.</param>
        /// <returns>this instance.</returns>
        public DirectPayment WithDirectPaymentAmount(Currency directPaymentAmount)
        {
            this._directPaymentAmount = directPaymentAmount;
            return this;
        }

        /// <summary>
        /// Checks if DirectPaymentAmount property is set.
        /// </summary>
        /// <returns>true if DirectPaymentAmount property is set.</returns>
        public bool IsSetDirectPaymentAmount()
        {
            return this._directPaymentAmount != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _directPaymentType = reader.Read<string>("DirectPaymentType");
            _directPaymentAmount = reader.Read<Currency>("DirectPaymentAmount");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("DirectPaymentType", _directPaymentType);
            writer.Write("DirectPaymentAmount", _directPaymentAmount);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "DirectPayment", this);
        }


        public DirectPayment() : base()
        {
        }
    }
}
