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
 * Promotion
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class Promotion : AbstractMwsObject
    {

        private string _promotionType;
        private string _promotionId;
        private Currency _promotionAmount;

        /// <summary>
        /// Gets and sets the PromotionType property.
        /// </summary>
        public string PromotionType
        {
            get { return this._promotionType; }
            set { this._promotionType = value; }
        }

        /// <summary>
        /// Sets the PromotionType property.
        /// </summary>
        /// <param name="promotionType">PromotionType property.</param>
        /// <returns>this instance.</returns>
        public Promotion WithPromotionType(string promotionType)
        {
            this._promotionType = promotionType;
            return this;
        }

        /// <summary>
        /// Checks if PromotionType property is set.
        /// </summary>
        /// <returns>true if PromotionType property is set.</returns>
        public bool IsSetPromotionType()
        {
            return this._promotionType != null;
        }

        /// <summary>
        /// Gets and sets the PromotionId property.
        /// </summary>
        public string PromotionId
        {
            get { return this._promotionId; }
            set { this._promotionId = value; }
        }

        /// <summary>
        /// Sets the PromotionId property.
        /// </summary>
        /// <param name="promotionId">PromotionId property.</param>
        /// <returns>this instance.</returns>
        public Promotion WithPromotionId(string promotionId)
        {
            this._promotionId = promotionId;
            return this;
        }

        /// <summary>
        /// Checks if PromotionId property is set.
        /// </summary>
        /// <returns>true if PromotionId property is set.</returns>
        public bool IsSetPromotionId()
        {
            return this._promotionId != null;
        }

        /// <summary>
        /// Gets and sets the PromotionAmount property.
        /// </summary>
        public Currency PromotionAmount
        {
            get { return this._promotionAmount; }
            set { this._promotionAmount = value; }
        }

        /// <summary>
        /// Sets the PromotionAmount property.
        /// </summary>
        /// <param name="promotionAmount">PromotionAmount property.</param>
        /// <returns>this instance.</returns>
        public Promotion WithPromotionAmount(Currency promotionAmount)
        {
            this._promotionAmount = promotionAmount;
            return this;
        }

        /// <summary>
        /// Checks if PromotionAmount property is set.
        /// </summary>
        /// <returns>true if PromotionAmount property is set.</returns>
        public bool IsSetPromotionAmount()
        {
            return this._promotionAmount != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _promotionType = reader.Read<string>("PromotionType");
            _promotionId = reader.Read<string>("PromotionId");
            _promotionAmount = reader.Read<Currency>("PromotionAmount");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("PromotionType", _promotionType);
            writer.Write("PromotionId", _promotionId);
            writer.Write("PromotionAmount", _promotionAmount);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "Promotion", this);
        }


        public Promotion() : base()
        {
        }
    }
}
