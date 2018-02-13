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
 * Loan Servicing Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class LoanServicingEvent : AbstractMwsObject
    {

        private Currency _loanAmount;
        private string _sourceBusinessEventType;

        /// <summary>
        /// Gets and sets the LoanAmount property.
        /// </summary>
        public Currency LoanAmount
        {
            get { return this._loanAmount; }
            set { this._loanAmount = value; }
        }

        /// <summary>
        /// Sets the LoanAmount property.
        /// </summary>
        /// <param name="loanAmount">LoanAmount property.</param>
        /// <returns>this instance.</returns>
        public LoanServicingEvent WithLoanAmount(Currency loanAmount)
        {
            this._loanAmount = loanAmount;
            return this;
        }

        /// <summary>
        /// Checks if LoanAmount property is set.
        /// </summary>
        /// <returns>true if LoanAmount property is set.</returns>
        public bool IsSetLoanAmount()
        {
            return this._loanAmount != null;
        }

        /// <summary>
        /// Gets and sets the SourceBusinessEventType property.
        /// </summary>
        public string SourceBusinessEventType
        {
            get { return this._sourceBusinessEventType; }
            set { this._sourceBusinessEventType = value; }
        }

        /// <summary>
        /// Sets the SourceBusinessEventType property.
        /// </summary>
        /// <param name="sourceBusinessEventType">SourceBusinessEventType property.</param>
        /// <returns>this instance.</returns>
        public LoanServicingEvent WithSourceBusinessEventType(string sourceBusinessEventType)
        {
            this._sourceBusinessEventType = sourceBusinessEventType;
            return this;
        }

        /// <summary>
        /// Checks if SourceBusinessEventType property is set.
        /// </summary>
        /// <returns>true if SourceBusinessEventType property is set.</returns>
        public bool IsSetSourceBusinessEventType()
        {
            return this._sourceBusinessEventType != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _loanAmount = reader.Read<Currency>("LoanAmount");
            _sourceBusinessEventType = reader.Read<string>("SourceBusinessEventType");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("LoanAmount", _loanAmount);
            writer.Write("SourceBusinessEventType", _sourceBusinessEventType);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "LoanServicingEvent", this);
        }


        public LoanServicingEvent() : base()
        {
        }
    }
}
