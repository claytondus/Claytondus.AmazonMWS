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
 * SAFET Reimbursement Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class SAFETReimbursementEvent : AbstractMwsObject
    {

        private DateTime? _postedDate;
        private string _safetClaimId;
        private Currency _reimbursedAmount;
        private string _reasonCode;
        private List<SAFETReimbursementItem> _safetReimbursementItemList;

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
        public SAFETReimbursementEvent WithPostedDate(DateTime postedDate)
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
        /// Gets and sets the SAFETClaimId property.
        /// </summary>
        public string SAFETClaimId
        {
            get { return this._safetClaimId; }
            set { this._safetClaimId = value; }
        }

        /// <summary>
        /// Sets the SAFETClaimId property.
        /// </summary>
        /// <param name="safetClaimId">SAFETClaimId property.</param>
        /// <returns>this instance.</returns>
        public SAFETReimbursementEvent WithSAFETClaimId(string safetClaimId)
        {
            this._safetClaimId = safetClaimId;
            return this;
        }

        /// <summary>
        /// Checks if SAFETClaimId property is set.
        /// </summary>
        /// <returns>true if SAFETClaimId property is set.</returns>
        public bool IsSetSAFETClaimId()
        {
            return this._safetClaimId != null;
        }

        /// <summary>
        /// Gets and sets the ReimbursedAmount property.
        /// </summary>
        public Currency ReimbursedAmount
        {
            get { return this._reimbursedAmount; }
            set { this._reimbursedAmount = value; }
        }

        /// <summary>
        /// Sets the ReimbursedAmount property.
        /// </summary>
        /// <param name="reimbursedAmount">ReimbursedAmount property.</param>
        /// <returns>this instance.</returns>
        public SAFETReimbursementEvent WithReimbursedAmount(Currency reimbursedAmount)
        {
            this._reimbursedAmount = reimbursedAmount;
            return this;
        }

        /// <summary>
        /// Checks if ReimbursedAmount property is set.
        /// </summary>
        /// <returns>true if ReimbursedAmount property is set.</returns>
        public bool IsSetReimbursedAmount()
        {
            return this._reimbursedAmount != null;
        }

        /// <summary>
        /// Gets and sets the ReasonCode property.
        /// </summary>
        public string ReasonCode
        {
            get { return this._reasonCode; }
            set { this._reasonCode = value; }
        }

        /// <summary>
        /// Sets the ReasonCode property.
        /// </summary>
        /// <param name="reasonCode">ReasonCode property.</param>
        /// <returns>this instance.</returns>
        public SAFETReimbursementEvent WithReasonCode(string reasonCode)
        {
            this._reasonCode = reasonCode;
            return this;
        }

        /// <summary>
        /// Checks if ReasonCode property is set.
        /// </summary>
        /// <returns>true if ReasonCode property is set.</returns>
        public bool IsSetReasonCode()
        {
            return this._reasonCode != null;
        }

        /// <summary>
        /// Gets and sets the SAFETReimbursementItemList property.
        /// </summary>
        public List<SAFETReimbursementItem> SAFETReimbursementItemList
        {
            get
            {
                if(this._safetReimbursementItemList == null)
                {
                    this._safetReimbursementItemList = new List<SAFETReimbursementItem>();
                }
                return this._safetReimbursementItemList;
            }
            set { this._safetReimbursementItemList = value; }
        }

        /// <summary>
        /// Sets the SAFETReimbursementItemList property.
        /// </summary>
        /// <param name="safetReimbursementItemList">SAFETReimbursementItemList property.</param>
        /// <returns>this instance.</returns>
        public SAFETReimbursementEvent WithSAFETReimbursementItemList(SAFETReimbursementItem[] safetReimbursementItemList)
        {
            this._safetReimbursementItemList.AddRange(safetReimbursementItemList);
            return this;
        }

        /// <summary>
        /// Checks if SAFETReimbursementItemList property is set.
        /// </summary>
        /// <returns>true if SAFETReimbursementItemList property is set.</returns>
        public bool IsSetSAFETReimbursementItemList()
        {
            return this.SAFETReimbursementItemList.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _postedDate = reader.Read<DateTime?>("PostedDate");
            _safetClaimId = reader.Read<string>("SAFETClaimId");
            _reimbursedAmount = reader.Read<Currency>("ReimbursedAmount");
            _reasonCode = reader.Read<string>("ReasonCode");
            _safetReimbursementItemList = reader.ReadList<SAFETReimbursementItem>("SAFETReimbursementItemList", "SAFETReimbursementItem");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("PostedDate", _postedDate);
            writer.Write("SAFETClaimId", _safetClaimId);
            writer.Write("ReimbursedAmount", _reimbursedAmount);
            writer.Write("ReasonCode", _reasonCode);
            writer.WriteList("SAFETReimbursementItemList", "SAFETReimbursementItem", _safetReimbursementItemList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "SAFETReimbursementEvent", this);
        }


        public SAFETReimbursementEvent() : base()
        {
        }
    }
}
