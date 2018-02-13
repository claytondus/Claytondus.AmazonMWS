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
 * FBA Liquidation Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class FBALiquidationEvent : AbstractMwsObject
    {

        private DateTime? _postedDate;
        private string _originalRemovalOrderId;
        private Currency _liquidationProceedsAmount;
        private Currency _liquidationFeeAmount;

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
        public FBALiquidationEvent WithPostedDate(DateTime postedDate)
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
        /// Gets and sets the OriginalRemovalOrderId property.
        /// </summary>
        public string OriginalRemovalOrderId
        {
            get { return this._originalRemovalOrderId; }
            set { this._originalRemovalOrderId = value; }
        }

        /// <summary>
        /// Sets the OriginalRemovalOrderId property.
        /// </summary>
        /// <param name="originalRemovalOrderId">OriginalRemovalOrderId property.</param>
        /// <returns>this instance.</returns>
        public FBALiquidationEvent WithOriginalRemovalOrderId(string originalRemovalOrderId)
        {
            this._originalRemovalOrderId = originalRemovalOrderId;
            return this;
        }

        /// <summary>
        /// Checks if OriginalRemovalOrderId property is set.
        /// </summary>
        /// <returns>true if OriginalRemovalOrderId property is set.</returns>
        public bool IsSetOriginalRemovalOrderId()
        {
            return this._originalRemovalOrderId != null;
        }

        /// <summary>
        /// Gets and sets the LiquidationProceedsAmount property.
        /// </summary>
        public Currency LiquidationProceedsAmount
        {
            get { return this._liquidationProceedsAmount; }
            set { this._liquidationProceedsAmount = value; }
        }

        /// <summary>
        /// Sets the LiquidationProceedsAmount property.
        /// </summary>
        /// <param name="liquidationProceedsAmount">LiquidationProceedsAmount property.</param>
        /// <returns>this instance.</returns>
        public FBALiquidationEvent WithLiquidationProceedsAmount(Currency liquidationProceedsAmount)
        {
            this._liquidationProceedsAmount = liquidationProceedsAmount;
            return this;
        }

        /// <summary>
        /// Checks if LiquidationProceedsAmount property is set.
        /// </summary>
        /// <returns>true if LiquidationProceedsAmount property is set.</returns>
        public bool IsSetLiquidationProceedsAmount()
        {
            return this._liquidationProceedsAmount != null;
        }

        /// <summary>
        /// Gets and sets the LiquidationFeeAmount property.
        /// </summary>
        public Currency LiquidationFeeAmount
        {
            get { return this._liquidationFeeAmount; }
            set { this._liquidationFeeAmount = value; }
        }

        /// <summary>
        /// Sets the LiquidationFeeAmount property.
        /// </summary>
        /// <param name="liquidationFeeAmount">LiquidationFeeAmount property.</param>
        /// <returns>this instance.</returns>
        public FBALiquidationEvent WithLiquidationFeeAmount(Currency liquidationFeeAmount)
        {
            this._liquidationFeeAmount = liquidationFeeAmount;
            return this;
        }

        /// <summary>
        /// Checks if LiquidationFeeAmount property is set.
        /// </summary>
        /// <returns>true if LiquidationFeeAmount property is set.</returns>
        public bool IsSetLiquidationFeeAmount()
        {
            return this._liquidationFeeAmount != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _postedDate = reader.Read<DateTime?>("PostedDate");
            _originalRemovalOrderId = reader.Read<string>("OriginalRemovalOrderId");
            _liquidationProceedsAmount = reader.Read<Currency>("LiquidationProceedsAmount");
            _liquidationFeeAmount = reader.Read<Currency>("LiquidationFeeAmount");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("PostedDate", _postedDate);
            writer.Write("OriginalRemovalOrderId", _originalRemovalOrderId);
            writer.Write("LiquidationProceedsAmount", _liquidationProceedsAmount);
            writer.Write("LiquidationFeeAmount", _liquidationFeeAmount);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "FBALiquidationEvent", this);
        }


        public FBALiquidationEvent() : base()
        {
        }
    }
}
