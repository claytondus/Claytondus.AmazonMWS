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
 * List Financial Event Groups Request
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class ListFinancialEventGroupsRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private decimal? _maxResultsPerPage;
        private DateTime? _financialEventGroupStartedAfter;
        private DateTime? _financialEventGroupStartedBefore;

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
        public ListFinancialEventGroupsRequest WithSellerId(string sellerId)
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
        public ListFinancialEventGroupsRequest WithMWSAuthToken(string mwsAuthToken)
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
        public ListFinancialEventGroupsRequest WithMaxResultsPerPage(decimal maxResultsPerPage)
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
        /// Gets and sets the FinancialEventGroupStartedAfter property.
        /// </summary>
        public DateTime FinancialEventGroupStartedAfter
        {
            get { return this._financialEventGroupStartedAfter.GetValueOrDefault(); }
            set { this._financialEventGroupStartedAfter = value; }
        }

        /// <summary>
        /// Sets the FinancialEventGroupStartedAfter property.
        /// </summary>
        /// <param name="financialEventGroupStartedAfter">FinancialEventGroupStartedAfter property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventGroupsRequest WithFinancialEventGroupStartedAfter(DateTime financialEventGroupStartedAfter)
        {
            this._financialEventGroupStartedAfter = financialEventGroupStartedAfter;
            return this;
        }

        /// <summary>
        /// Checks if FinancialEventGroupStartedAfter property is set.
        /// </summary>
        /// <returns>true if FinancialEventGroupStartedAfter property is set.</returns>
        public bool IsSetFinancialEventGroupStartedAfter()
        {
            return this._financialEventGroupStartedAfter != null;
        }

        /// <summary>
        /// Gets and sets the FinancialEventGroupStartedBefore property.
        /// </summary>
        public DateTime FinancialEventGroupStartedBefore
        {
            get { return this._financialEventGroupStartedBefore.GetValueOrDefault(); }
            set { this._financialEventGroupStartedBefore = value; }
        }

        /// <summary>
        /// Sets the FinancialEventGroupStartedBefore property.
        /// </summary>
        /// <param name="financialEventGroupStartedBefore">FinancialEventGroupStartedBefore property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventGroupsRequest WithFinancialEventGroupStartedBefore(DateTime financialEventGroupStartedBefore)
        {
            this._financialEventGroupStartedBefore = financialEventGroupStartedBefore;
            return this;
        }

        /// <summary>
        /// Checks if FinancialEventGroupStartedBefore property is set.
        /// </summary>
        /// <returns>true if FinancialEventGroupStartedBefore property is set.</returns>
        public bool IsSetFinancialEventGroupStartedBefore()
        {
            return this._financialEventGroupStartedBefore != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _maxResultsPerPage = reader.Read<decimal?>("MaxResultsPerPage");
            _financialEventGroupStartedAfter = reader.Read<DateTime?>("FinancialEventGroupStartedAfter");
            _financialEventGroupStartedBefore = reader.Read<DateTime?>("FinancialEventGroupStartedBefore");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("MaxResultsPerPage", _maxResultsPerPage);
            writer.Write("FinancialEventGroupStartedAfter", _financialEventGroupStartedAfter);
            writer.Write("FinancialEventGroupStartedBefore", _financialEventGroupStartedBefore);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "ListFinancialEventGroupsRequest", this);
        }

    public ListFinancialEventGroupsRequest (string sellerId) : base() {
        this._sellerId = sellerId;
    }

        public ListFinancialEventGroupsRequest() : base()
        {
        }
    }
}
