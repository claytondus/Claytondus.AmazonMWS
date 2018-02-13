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
 * Adjustment Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class AdjustmentEvent : AbstractMwsObject
    {

        private string _adjustmentType;
        private DateTime? _postedDate;
        private Currency _adjustmentAmount;
        private List<AdjustmentItem> _adjustmentItemList;

        /// <summary>
        /// Gets and sets the AdjustmentType property.
        /// </summary>
        public string AdjustmentType
        {
            get { return this._adjustmentType; }
            set { this._adjustmentType = value; }
        }

        /// <summary>
        /// Sets the AdjustmentType property.
        /// </summary>
        /// <param name="adjustmentType">AdjustmentType property.</param>
        /// <returns>this instance.</returns>
        public AdjustmentEvent WithAdjustmentType(string adjustmentType)
        {
            this._adjustmentType = adjustmentType;
            return this;
        }

        /// <summary>
        /// Checks if AdjustmentType property is set.
        /// </summary>
        /// <returns>true if AdjustmentType property is set.</returns>
        public bool IsSetAdjustmentType()
        {
            return this._adjustmentType != null;
        }

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
        public AdjustmentEvent WithPostedDate(DateTime postedDate)
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
        /// Gets and sets the AdjustmentAmount property.
        /// </summary>
        public Currency AdjustmentAmount
        {
            get { return this._adjustmentAmount; }
            set { this._adjustmentAmount = value; }
        }

        /// <summary>
        /// Sets the AdjustmentAmount property.
        /// </summary>
        /// <param name="adjustmentAmount">AdjustmentAmount property.</param>
        /// <returns>this instance.</returns>
        public AdjustmentEvent WithAdjustmentAmount(Currency adjustmentAmount)
        {
            this._adjustmentAmount = adjustmentAmount;
            return this;
        }

        /// <summary>
        /// Checks if AdjustmentAmount property is set.
        /// </summary>
        /// <returns>true if AdjustmentAmount property is set.</returns>
        public bool IsSetAdjustmentAmount()
        {
            return this._adjustmentAmount != null;
        }

        /// <summary>
        /// Gets and sets the AdjustmentItemList property.
        /// </summary>
        public List<AdjustmentItem> AdjustmentItemList
        {
            get
            {
                if(this._adjustmentItemList == null)
                {
                    this._adjustmentItemList = new List<AdjustmentItem>();
                }
                return this._adjustmentItemList;
            }
            set { this._adjustmentItemList = value; }
        }

        /// <summary>
        /// Sets the AdjustmentItemList property.
        /// </summary>
        /// <param name="adjustmentItemList">AdjustmentItemList property.</param>
        /// <returns>this instance.</returns>
        public AdjustmentEvent WithAdjustmentItemList(AdjustmentItem[] adjustmentItemList)
        {
            this._adjustmentItemList.AddRange(adjustmentItemList);
            return this;
        }

        /// <summary>
        /// Checks if AdjustmentItemList property is set.
        /// </summary>
        /// <returns>true if AdjustmentItemList property is set.</returns>
        public bool IsSetAdjustmentItemList()
        {
            return this.AdjustmentItemList.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _adjustmentType = reader.Read<string>("AdjustmentType");
            _postedDate = reader.Read<DateTime?>("PostedDate");
            _adjustmentAmount = reader.Read<Currency>("AdjustmentAmount");
            _adjustmentItemList = reader.ReadList<AdjustmentItem>("AdjustmentItemList", "AdjustmentItem");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("AdjustmentType", _adjustmentType);
            writer.Write("PostedDate", _postedDate);
            writer.Write("AdjustmentAmount", _adjustmentAmount);
            writer.WriteList("AdjustmentItemList", "AdjustmentItem", _adjustmentItemList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "AdjustmentEvent", this);
        }


        public AdjustmentEvent() : base()
        {
        }
    }
}
