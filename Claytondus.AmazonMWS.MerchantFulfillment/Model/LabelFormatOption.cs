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
 * Label Format Option
 * API Version: 2015-06-01
 * Library Version: 2020-02-06
 * Generated: Mon Mar 02 20:07:24 UTC 2020
 */


using System;
using System.Xml;
using Claytondus.AmazonMWS.Runtime;


namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class LabelFormatOption : AbstractMwsObject
    {

        private bool? _includePackingSlipWithLabel;
        private string _labelFormat;

        /// <summary>
        /// Gets and sets the IncludePackingSlipWithLabel property.
        /// </summary>
        public bool IncludePackingSlipWithLabel
        {
            get { return this._includePackingSlipWithLabel.GetValueOrDefault(); }
            set { this._includePackingSlipWithLabel = value; }
        }

        /// <summary>
        /// Sets the IncludePackingSlipWithLabel property.
        /// </summary>
        /// <param name="includePackingSlipWithLabel">IncludePackingSlipWithLabel property.</param>
        /// <returns>this instance.</returns>
        public LabelFormatOption WithIncludePackingSlipWithLabel(bool includePackingSlipWithLabel)
        {
            this._includePackingSlipWithLabel = includePackingSlipWithLabel;
            return this;
        }

        /// <summary>
        /// Checks if IncludePackingSlipWithLabel property is set.
        /// </summary>
        /// <returns>true if IncludePackingSlipWithLabel property is set.</returns>
        public bool IsSetIncludePackingSlipWithLabel()
        {
            return this._includePackingSlipWithLabel != null;
        }

        /// <summary>
        /// Gets and sets the LabelFormat property.
        /// </summary>
        public string LabelFormat
        {
            get { return this._labelFormat; }
            set { this._labelFormat = value; }
        }

        /// <summary>
        /// Sets the LabelFormat property.
        /// </summary>
        /// <param name="labelFormat">LabelFormat property.</param>
        /// <returns>this instance.</returns>
        public LabelFormatOption WithLabelFormat(string labelFormat)
        {
            this._labelFormat = labelFormat;
            return this;
        }

        /// <summary>
        /// Checks if LabelFormat property is set.
        /// </summary>
        /// <returns>true if LabelFormat property is set.</returns>
        public bool IsSetLabelFormat()
        {
            return this._labelFormat != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _includePackingSlipWithLabel = reader.Read<bool?>("IncludePackingSlipWithLabel");
            _labelFormat = reader.Read<string>("LabelFormat");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("IncludePackingSlipWithLabel", _includePackingSlipWithLabel);
            writer.Write("LabelFormat", _labelFormat);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "LabelFormatOption", this);
        }


        public LabelFormatOption() : base()
        {
        }
    }
}
