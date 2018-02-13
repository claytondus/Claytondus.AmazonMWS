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
 * Fee Component
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class FeeComponent : AbstractMwsObject
    {

        private string _feeType;
        private Currency _feeAmount;

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
        public FeeComponent WithFeeType(string feeType)
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
        public FeeComponent WithFeeAmount(Currency feeAmount)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _feeType = reader.Read<string>("FeeType");
            _feeAmount = reader.Read<Currency>("FeeAmount");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("FeeType", _feeType);
            writer.Write("FeeAmount", _feeAmount);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "FeeComponent", this);
        }


        public FeeComponent() : base()
        {
        }
    }
}
