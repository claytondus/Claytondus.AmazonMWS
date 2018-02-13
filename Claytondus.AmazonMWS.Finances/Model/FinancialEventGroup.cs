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
 * Financial Event Group
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class FinancialEventGroup : AbstractMwsObject
    {

        private string _financialEventGroupId;
        private string _processingStatus;
        private string _fundTransferStatus;
        private Currency _originalTotal;
        private Currency _convertedTotal;
        private DateTime? _fundTransferDate;
        private string _traceId;
        private string _accountTail;
        private Currency _beginningBalance;
        private DateTime? _financialEventGroupStart;
        private DateTime? _financialEventGroupEnd;

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
        public FinancialEventGroup WithFinancialEventGroupId(string financialEventGroupId)
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
        /// Gets and sets the ProcessingStatus property.
        /// </summary>
        public string ProcessingStatus
        {
            get { return this._processingStatus; }
            set { this._processingStatus = value; }
        }

        /// <summary>
        /// Sets the ProcessingStatus property.
        /// </summary>
        /// <param name="processingStatus">ProcessingStatus property.</param>
        /// <returns>this instance.</returns>
        public FinancialEventGroup WithProcessingStatus(string processingStatus)
        {
            this._processingStatus = processingStatus;
            return this;
        }

        /// <summary>
        /// Checks if ProcessingStatus property is set.
        /// </summary>
        /// <returns>true if ProcessingStatus property is set.</returns>
        public bool IsSetProcessingStatus()
        {
            return this._processingStatus != null;
        }

        /// <summary>
        /// Gets and sets the FundTransferStatus property.
        /// </summary>
        public string FundTransferStatus
        {
            get { return this._fundTransferStatus; }
            set { this._fundTransferStatus = value; }
        }

        /// <summary>
        /// Sets the FundTransferStatus property.
        /// </summary>
        /// <param name="fundTransferStatus">FundTransferStatus property.</param>
        /// <returns>this instance.</returns>
        public FinancialEventGroup WithFundTransferStatus(string fundTransferStatus)
        {
            this._fundTransferStatus = fundTransferStatus;
            return this;
        }

        /// <summary>
        /// Checks if FundTransferStatus property is set.
        /// </summary>
        /// <returns>true if FundTransferStatus property is set.</returns>
        public bool IsSetFundTransferStatus()
        {
            return this._fundTransferStatus != null;
        }

        /// <summary>
        /// Gets and sets the OriginalTotal property.
        /// </summary>
        public Currency OriginalTotal
        {
            get { return this._originalTotal; }
            set { this._originalTotal = value; }
        }

        /// <summary>
        /// Sets the OriginalTotal property.
        /// </summary>
        /// <param name="originalTotal">OriginalTotal property.</param>
        /// <returns>this instance.</returns>
        public FinancialEventGroup WithOriginalTotal(Currency originalTotal)
        {
            this._originalTotal = originalTotal;
            return this;
        }

        /// <summary>
        /// Checks if OriginalTotal property is set.
        /// </summary>
        /// <returns>true if OriginalTotal property is set.</returns>
        public bool IsSetOriginalTotal()
        {
            return this._originalTotal != null;
        }

        /// <summary>
        /// Gets and sets the ConvertedTotal property.
        /// </summary>
        public Currency ConvertedTotal
        {
            get { return this._convertedTotal; }
            set { this._convertedTotal = value; }
        }

        /// <summary>
        /// Sets the ConvertedTotal property.
        /// </summary>
        /// <param name="convertedTotal">ConvertedTotal property.</param>
        /// <returns>this instance.</returns>
        public FinancialEventGroup WithConvertedTotal(Currency convertedTotal)
        {
            this._convertedTotal = convertedTotal;
            return this;
        }

        /// <summary>
        /// Checks if ConvertedTotal property is set.
        /// </summary>
        /// <returns>true if ConvertedTotal property is set.</returns>
        public bool IsSetConvertedTotal()
        {
            return this._convertedTotal != null;
        }

        /// <summary>
        /// Gets and sets the FundTransferDate property.
        /// </summary>
        public DateTime FundTransferDate
        {
            get { return this._fundTransferDate.GetValueOrDefault(); }
            set { this._fundTransferDate = value; }
        }

        /// <summary>
        /// Sets the FundTransferDate property.
        /// </summary>
        /// <param name="fundTransferDate">FundTransferDate property.</param>
        /// <returns>this instance.</returns>
        public FinancialEventGroup WithFundTransferDate(DateTime fundTransferDate)
        {
            this._fundTransferDate = fundTransferDate;
            return this;
        }

        /// <summary>
        /// Checks if FundTransferDate property is set.
        /// </summary>
        /// <returns>true if FundTransferDate property is set.</returns>
        public bool IsSetFundTransferDate()
        {
            return this._fundTransferDate != null;
        }

        /// <summary>
        /// Gets and sets the TraceId property.
        /// </summary>
        public string TraceId
        {
            get { return this._traceId; }
            set { this._traceId = value; }
        }

        /// <summary>
        /// Sets the TraceId property.
        /// </summary>
        /// <param name="traceId">TraceId property.</param>
        /// <returns>this instance.</returns>
        public FinancialEventGroup WithTraceId(string traceId)
        {
            this._traceId = traceId;
            return this;
        }

        /// <summary>
        /// Checks if TraceId property is set.
        /// </summary>
        /// <returns>true if TraceId property is set.</returns>
        public bool IsSetTraceId()
        {
            return this._traceId != null;
        }

        /// <summary>
        /// Gets and sets the AccountTail property.
        /// </summary>
        public string AccountTail
        {
            get { return this._accountTail; }
            set { this._accountTail = value; }
        }

        /// <summary>
        /// Sets the AccountTail property.
        /// </summary>
        /// <param name="accountTail">AccountTail property.</param>
        /// <returns>this instance.</returns>
        public FinancialEventGroup WithAccountTail(string accountTail)
        {
            this._accountTail = accountTail;
            return this;
        }

        /// <summary>
        /// Checks if AccountTail property is set.
        /// </summary>
        /// <returns>true if AccountTail property is set.</returns>
        public bool IsSetAccountTail()
        {
            return this._accountTail != null;
        }

        /// <summary>
        /// Gets and sets the BeginningBalance property.
        /// </summary>
        public Currency BeginningBalance
        {
            get { return this._beginningBalance; }
            set { this._beginningBalance = value; }
        }

        /// <summary>
        /// Sets the BeginningBalance property.
        /// </summary>
        /// <param name="beginningBalance">BeginningBalance property.</param>
        /// <returns>this instance.</returns>
        public FinancialEventGroup WithBeginningBalance(Currency beginningBalance)
        {
            this._beginningBalance = beginningBalance;
            return this;
        }

        /// <summary>
        /// Checks if BeginningBalance property is set.
        /// </summary>
        /// <returns>true if BeginningBalance property is set.</returns>
        public bool IsSetBeginningBalance()
        {
            return this._beginningBalance != null;
        }

        /// <summary>
        /// Gets and sets the FinancialEventGroupStart property.
        /// </summary>
        public DateTime FinancialEventGroupStart
        {
            get { return this._financialEventGroupStart.GetValueOrDefault(); }
            set { this._financialEventGroupStart = value; }
        }

        /// <summary>
        /// Sets the FinancialEventGroupStart property.
        /// </summary>
        /// <param name="financialEventGroupStart">FinancialEventGroupStart property.</param>
        /// <returns>this instance.</returns>
        public FinancialEventGroup WithFinancialEventGroupStart(DateTime financialEventGroupStart)
        {
            this._financialEventGroupStart = financialEventGroupStart;
            return this;
        }

        /// <summary>
        /// Checks if FinancialEventGroupStart property is set.
        /// </summary>
        /// <returns>true if FinancialEventGroupStart property is set.</returns>
        public bool IsSetFinancialEventGroupStart()
        {
            return this._financialEventGroupStart != null;
        }

        /// <summary>
        /// Gets and sets the FinancialEventGroupEnd property.
        /// </summary>
        public DateTime FinancialEventGroupEnd
        {
            get { return this._financialEventGroupEnd.GetValueOrDefault(); }
            set { this._financialEventGroupEnd = value; }
        }

        /// <summary>
        /// Sets the FinancialEventGroupEnd property.
        /// </summary>
        /// <param name="financialEventGroupEnd">FinancialEventGroupEnd property.</param>
        /// <returns>this instance.</returns>
        public FinancialEventGroup WithFinancialEventGroupEnd(DateTime financialEventGroupEnd)
        {
            this._financialEventGroupEnd = financialEventGroupEnd;
            return this;
        }

        /// <summary>
        /// Checks if FinancialEventGroupEnd property is set.
        /// </summary>
        /// <returns>true if FinancialEventGroupEnd property is set.</returns>
        public bool IsSetFinancialEventGroupEnd()
        {
            return this._financialEventGroupEnd != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _financialEventGroupId = reader.Read<string>("FinancialEventGroupId");
            _processingStatus = reader.Read<string>("ProcessingStatus");
            _fundTransferStatus = reader.Read<string>("FundTransferStatus");
            _originalTotal = reader.Read<Currency>("OriginalTotal");
            _convertedTotal = reader.Read<Currency>("ConvertedTotal");
            _fundTransferDate = reader.Read<DateTime?>("FundTransferDate");
            _traceId = reader.Read<string>("TraceId");
            _accountTail = reader.Read<string>("AccountTail");
            _beginningBalance = reader.Read<Currency>("BeginningBalance");
            _financialEventGroupStart = reader.Read<DateTime?>("FinancialEventGroupStart");
            _financialEventGroupEnd = reader.Read<DateTime?>("FinancialEventGroupEnd");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("FinancialEventGroupId", _financialEventGroupId);
            writer.Write("ProcessingStatus", _processingStatus);
            writer.Write("FundTransferStatus", _fundTransferStatus);
            writer.Write("OriginalTotal", _originalTotal);
            writer.Write("ConvertedTotal", _convertedTotal);
            writer.Write("FundTransferDate", _fundTransferDate);
            writer.Write("TraceId", _traceId);
            writer.Write("AccountTail", _accountTail);
            writer.Write("BeginningBalance", _beginningBalance);
            writer.Write("FinancialEventGroupStart", _financialEventGroupStart);
            writer.Write("FinancialEventGroupEnd", _financialEventGroupEnd);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "FinancialEventGroup", this);
        }


        public FinancialEventGroup() : base()
        {
        }
    }
}
