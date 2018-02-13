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
 * List Financial Events Request
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class ListFinancialEventsRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private decimal? _maxResultsPerPage;
        private string _amazonOrderId;
        private string _financialEventGroupId;
        private DateTime? _postedAfter;
        private DateTime? _postedBefore;

        /// <summary>
        /// Gets and sets the SellerId property.
        /// </summary>
        public string SellerId
        {
            get { return this._sellerId; }
            set { this._sellerId = value; }
        }

        /// <summary>
        /// Sets the SellerId property.
        /// </summary>
        /// <param name="sellerId">SellerId property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventsRequest WithSellerId(string sellerId)
        {
            this._sellerId = sellerId;
            return this;
        }

        /// <summary>
        /// Checks if SellerId property is set.
        /// </summary>
        /// <returns>true if SellerId property is set.</returns>
        public bool IsSetSellerId()
        {
            return this._sellerId != null;
        }

        /// <summary>
        /// Gets and sets the MWSAuthToken property.
        /// </summary>
        public string MWSAuthToken
        {
            get { return this._mwsAuthToken; }
            set { this._mwsAuthToken = value; }
        }

        /// <summary>
        /// Sets the MWSAuthToken property.
        /// </summary>
        /// <param name="mwsAuthToken">MWSAuthToken property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventsRequest WithMWSAuthToken(string mwsAuthToken)
        {
            this._mwsAuthToken = mwsAuthToken;
            return this;
        }

        /// <summary>
        /// Checks if MWSAuthToken property is set.
        /// </summary>
        /// <returns>true if MWSAuthToken property is set.</returns>
        public bool IsSetMWSAuthToken()
        {
            return this._mwsAuthToken != null;
        }

        /// <summary>
        /// Gets and sets the MaxResultsPerPage property.
        /// </summary>
        public decimal MaxResultsPerPage
        {
            get { return this._maxResultsPerPage.GetValueOrDefault(); }
            set { this._maxResultsPerPage = value; }
        }

        /// <summary>
        /// Sets the MaxResultsPerPage property.
        /// </summary>
        /// <param name="maxResultsPerPage">MaxResultsPerPage property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventsRequest WithMaxResultsPerPage(decimal maxResultsPerPage)
        {
            this._maxResultsPerPage = maxResultsPerPage;
            return this;
        }

        /// <summary>
        /// Checks if MaxResultsPerPage property is set.
        /// </summary>
        /// <returns>true if MaxResultsPerPage property is set.</returns>
        public bool IsSetMaxResultsPerPage()
        {
            return this._maxResultsPerPage != null;
        }

        /// <summary>
        /// Gets and sets the AmazonOrderId property.
        /// </summary>
        public string AmazonOrderId
        {
            get { return this._amazonOrderId; }
            set { this._amazonOrderId = value; }
        }

        /// <summary>
        /// Sets the AmazonOrderId property.
        /// </summary>
        /// <param name="amazonOrderId">AmazonOrderId property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventsRequest WithAmazonOrderId(string amazonOrderId)
        {
            this._amazonOrderId = amazonOrderId;
            return this;
        }

        /// <summary>
        /// Checks if AmazonOrderId property is set.
        /// </summary>
        /// <returns>true if AmazonOrderId property is set.</returns>
        public bool IsSetAmazonOrderId()
        {
            return this._amazonOrderId != null;
        }

        /// <summary>
        /// Gets and sets the FinancialEventGroupId property.
        /// </summary>
        public string FinancialEventGroupId
        {
            get { return this._financialEventGroupId; }
            set { this._financialEventGroupId = value; }
        }

        /// <summary>
        /// Sets the FinancialEventGroupId property.
        /// </summary>
        /// <param name="financialEventGroupId">FinancialEventGroupId property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventsRequest WithFinancialEventGroupId(string financialEventGroupId)
        {
            this._financialEventGroupId = financialEventGroupId;
            return this;
        }

        /// <summary>
        /// Checks if FinancialEventGroupId property is set.
        /// </summary>
        /// <returns>true if FinancialEventGroupId property is set.</returns>
        public bool IsSetFinancialEventGroupId()
        {
            return this._financialEventGroupId != null;
        }

        /// <summary>
        /// Gets and sets the PostedAfter property.
        /// </summary>
        public DateTime PostedAfter
        {
            get { return this._postedAfter.GetValueOrDefault(); }
            set { this._postedAfter = value; }
        }

        /// <summary>
        /// Sets the PostedAfter property.
        /// </summary>
        /// <param name="postedAfter">PostedAfter property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventsRequest WithPostedAfter(DateTime postedAfter)
        {
            this._postedAfter = postedAfter;
            return this;
        }

        /// <summary>
        /// Checks if PostedAfter property is set.
        /// </summary>
        /// <returns>true if PostedAfter property is set.</returns>
        public bool IsSetPostedAfter()
        {
            return this._postedAfter != null;
        }

        /// <summary>
        /// Gets and sets the PostedBefore property.
        /// </summary>
        public DateTime PostedBefore
        {
            get { return this._postedBefore.GetValueOrDefault(); }
            set { this._postedBefore = value; }
        }

        /// <summary>
        /// Sets the PostedBefore property.
        /// </summary>
        /// <param name="postedBefore">PostedBefore property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventsRequest WithPostedBefore(DateTime postedBefore)
        {
            this._postedBefore = postedBefore;
            return this;
        }

        /// <summary>
        /// Checks if PostedBefore property is set.
        /// </summary>
        /// <returns>true if PostedBefore property is set.</returns>
        public bool IsSetPostedBefore()
        {
            return this._postedBefore != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _maxResultsPerPage = reader.Read<decimal?>("MaxResultsPerPage");
            _amazonOrderId = reader.Read<string>("AmazonOrderId");
            _financialEventGroupId = reader.Read<string>("FinancialEventGroupId");
            _postedAfter = reader.Read<DateTime?>("PostedAfter");
            _postedBefore = reader.Read<DateTime?>("PostedBefore");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("MaxResultsPerPage", _maxResultsPerPage);
            writer.Write("AmazonOrderId", _amazonOrderId);
            writer.Write("FinancialEventGroupId", _financialEventGroupId);
            writer.Write("PostedAfter", _postedAfter);
            writer.Write("PostedBefore", _postedBefore);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "ListFinancialEventsRequest", this);
        }

    public ListFinancialEventsRequest (string sellerId) : base() {
        this._sellerId = sellerId;
    }

        public ListFinancialEventsRequest() : base()
        {
        }
    }
}
