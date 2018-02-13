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
 * Label Customization
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class LabelCustomization : AbstractMwsObject
    {

        private string _customTextForLabel;
        private string _standardIdForLabel;

        /// <summary>
        /// Gets and sets the CustomTextForLabel property.
        /// </summary>
        public string CustomTextForLabel
        {
            get { return this._customTextForLabel; }
            set { this._customTextForLabel = value; }
        }

        /// <summary>
        /// Sets the CustomTextForLabel property.
        /// </summary>
        /// <param name="customTextForLabel">CustomTextForLabel property.</param>
        /// <returns>this instance.</returns>
        public LabelCustomization WithCustomTextForLabel(string customTextForLabel)
        {
            this._customTextForLabel = customTextForLabel;
            return this;
        }

        /// <summary>
        /// Checks if CustomTextForLabel property is set.
        /// </summary>
        /// <returns>true if CustomTextForLabel property is set.</returns>
        public bool IsSetCustomTextForLabel()
        {
            return this._customTextForLabel != null;
        }

        /// <summary>
        /// Gets and sets the StandardIdForLabel property.
        /// </summary>
        public string StandardIdForLabel
        {
            get { return this._standardIdForLabel; }
            set { this._standardIdForLabel = value; }
        }

        /// <summary>
        /// Sets the StandardIdForLabel property.
        /// </summary>
        /// <param name="standardIdForLabel">StandardIdForLabel property.</param>
        /// <returns>this instance.</returns>
        public LabelCustomization WithStandardIdForLabel(string standardIdForLabel)
        {
            this._standardIdForLabel = standardIdForLabel;
            return this;
        }

        /// <summary>
        /// Checks if StandardIdForLabel property is set.
        /// </summary>
        /// <returns>true if StandardIdForLabel property is set.</returns>
        public bool IsSetStandardIdForLabel()
        {
            return this._standardIdForLabel != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _customTextForLabel = reader.Read<string>("CustomTextForLabel");
            _standardIdForLabel = reader.Read<string>("StandardIdForLabel");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("CustomTextForLabel", _customTextForLabel);
            writer.Write("StandardIdForLabel", _standardIdForLabel);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "LabelCustomization", this);
        }


        public LabelCustomization() : base()
        {
        }
    }
}
