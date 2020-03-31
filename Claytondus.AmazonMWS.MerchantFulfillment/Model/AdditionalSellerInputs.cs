/*******************************************************************************
 * Copyright 2009-2020 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Additional Seller Inputs
 * API Version: 2015-06-01
 * Library Version: 2020-02-06
 * Generated: Mon Mar 02 20:07:24 UTC 2020
 */


using System;
using System.Xml;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class AdditionalSellerInputs : AbstractMwsObject
    {

        private string _additionalInputFieldName;
        private AdditionalSellerInput _additionalSellerInput;

        /// <summary>
        /// Gets and sets the AdditionalInputFieldName property.
        /// </summary>
        public string AdditionalInputFieldName
        {
            get { return this._additionalInputFieldName; }
            set { this._additionalInputFieldName = value; }
        }

        /// <summary>
        /// Sets the AdditionalInputFieldName property.
        /// </summary>
        /// <param name="additionalInputFieldName">AdditionalInputFieldName property.</param>
        /// <returns>this instance.</returns>
        public AdditionalSellerInputs WithAdditionalInputFieldName(string additionalInputFieldName)
        {
            this._additionalInputFieldName = additionalInputFieldName;
            return this;
        }

        /// <summary>
        /// Checks if AdditionalInputFieldName property is set.
        /// </summary>
        /// <returns>true if AdditionalInputFieldName property is set.</returns>
        public bool IsSetAdditionalInputFieldName()
        {
            return this._additionalInputFieldName != null;
        }

        /// <summary>
        /// Gets and sets the AdditionalSellerInput property.
        /// </summary>
        public AdditionalSellerInput AdditionalSellerInput
        {
            get { return this._additionalSellerInput; }
            set { this._additionalSellerInput = value; }
        }

        /// <summary>
        /// Sets the AdditionalSellerInput property.
        /// </summary>
        /// <param name="additionalSellerInput">AdditionalSellerInput property.</param>
        /// <returns>this instance.</returns>
        public AdditionalSellerInputs WithAdditionalSellerInput(AdditionalSellerInput additionalSellerInput)
        {
            this._additionalSellerInput = additionalSellerInput;
            return this;
        }

        /// <summary>
        /// Checks if AdditionalSellerInput property is set.
        /// </summary>
        /// <returns>true if AdditionalSellerInput property is set.</returns>
        public bool IsSetAdditionalSellerInput()
        {
            return this._additionalSellerInput != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _additionalInputFieldName = reader.Read<string>("AdditionalInputFieldName");
            _additionalSellerInput = reader.Read<AdditionalSellerInput>("AdditionalSellerInput");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("AdditionalInputFieldName", _additionalInputFieldName);
            writer.Write("AdditionalSellerInput", _additionalSellerInput);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "AdditionalSellerInputs", this);
        }

    public AdditionalSellerInputs (string additionalInputFieldName,AdditionalSellerInput additionalSellerInput) : base() {
        this._additionalInputFieldName = additionalInputFieldName;
        this._additionalSellerInput = additionalSellerInput;
    }

        public AdditionalSellerInputs() : base()
        {
        }
    }
}
