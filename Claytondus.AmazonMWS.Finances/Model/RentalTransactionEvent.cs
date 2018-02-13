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
 * Rental Transaction Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class RentalTransactionEvent : AbstractMwsObject
    {

        private string _amazonOrderId;
        private string _rentalEventType;
        private decimal? _extensionLength;
        private DateTime? _postedDate;
        private List<ChargeComponent> _rentalChargeList;
        private List<FeeComponent> _rentalFeeList;
        private string _marketplaceName;
        private Currency _rentalInitialValue;
        private Currency _rentalReimbursement;

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
        public RentalTransactionEvent WithAmazonOrderId(string amazonOrderId)
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
        /// Gets and sets the RentalEventType property.
        /// </summary>
        public string RentalEventType
        {
            get { return this._rentalEventType; }
            set { this._rentalEventType = value; }
        }

        /// <summary>
        /// Sets the RentalEventType property.
        /// </summary>
        /// <param name="rentalEventType">RentalEventType property.</param>
        /// <returns>this instance.</returns>
        public RentalTransactionEvent WithRentalEventType(string rentalEventType)
        {
            this._rentalEventType = rentalEventType;
            return this;
        }

        /// <summary>
        /// Checks if RentalEventType property is set.
        /// </summary>
        /// <returns>true if RentalEventType property is set.</returns>
        public bool IsSetRentalEventType()
        {
            return this._rentalEventType != null;
        }

        /// <summary>
        /// Gets and sets the ExtensionLength property.
        /// </summary>
        public decimal ExtensionLength
        {
            get { return this._extensionLength.GetValueOrDefault(); }
            set { this._extensionLength = value; }
        }

        /// <summary>
        /// Sets the ExtensionLength property.
        /// </summary>
        /// <param name="extensionLength">ExtensionLength property.</param>
        /// <returns>this instance.</returns>
        public RentalTransactionEvent WithExtensionLength(decimal extensionLength)
        {
            this._extensionLength = extensionLength;
            return this;
        }

        /// <summary>
        /// Checks if ExtensionLength property is set.
        /// </summary>
        /// <returns>true if ExtensionLength property is set.</returns>
        public bool IsSetExtensionLength()
        {
            return this._extensionLength != null;
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
        public RentalTransactionEvent WithPostedDate(DateTime postedDate)
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
        /// Gets and sets the RentalChargeList property.
        /// </summary>
        public List<ChargeComponent> RentalChargeList
        {
            get
            {
                if(this._rentalChargeList == null)
                {
                    this._rentalChargeList = new List<ChargeComponent>();
                }
                return this._rentalChargeList;
            }
            set { this._rentalChargeList = value; }
        }

        /// <summary>
        /// Sets the RentalChargeList property.
        /// </summary>
        /// <param name="rentalChargeList">RentalChargeList property.</param>
        /// <returns>this instance.</returns>
        public RentalTransactionEvent WithRentalChargeList(ChargeComponent[] rentalChargeList)
        {
            this._rentalChargeList.AddRange(rentalChargeList);
            return this;
        }

        /// <summary>
        /// Checks if RentalChargeList property is set.
        /// </summary>
        /// <returns>true if RentalChargeList property is set.</returns>
        public bool IsSetRentalChargeList()
        {
            return this.RentalChargeList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the RentalFeeList property.
        /// </summary>
        public List<FeeComponent> RentalFeeList
        {
            get
            {
                if(this._rentalFeeList == null)
                {
                    this._rentalFeeList = new List<FeeComponent>();
                }
                return this._rentalFeeList;
            }
            set { this._rentalFeeList = value; }
        }

        /// <summary>
        /// Sets the RentalFeeList property.
        /// </summary>
        /// <param name="rentalFeeList">RentalFeeList property.</param>
        /// <returns>this instance.</returns>
        public RentalTransactionEvent WithRentalFeeList(FeeComponent[] rentalFeeList)
        {
            this._rentalFeeList.AddRange(rentalFeeList);
            return this;
        }

        /// <summary>
        /// Checks if RentalFeeList property is set.
        /// </summary>
        /// <returns>true if RentalFeeList property is set.</returns>
        public bool IsSetRentalFeeList()
        {
            return this.RentalFeeList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the MarketplaceName property.
        /// </summary>
        public string MarketplaceName
        {
            get { return this._marketplaceName; }
            set { this._marketplaceName = value; }
        }

        /// <summary>
        /// Sets the MarketplaceName property.
        /// </summary>
        /// <param name="marketplaceName">MarketplaceName property.</param>
        /// <returns>this instance.</returns>
        public RentalTransactionEvent WithMarketplaceName(string marketplaceName)
        {
            this._marketplaceName = marketplaceName;
            return this;
        }

        /// <summary>
        /// Checks if MarketplaceName property is set.
        /// </summary>
        /// <returns>true if MarketplaceName property is set.</returns>
        public bool IsSetMarketplaceName()
        {
            return this._marketplaceName != null;
        }

        /// <summary>
        /// Gets and sets the RentalInitialValue property.
        /// </summary>
        public Currency RentalInitialValue
        {
            get { return this._rentalInitialValue; }
            set { this._rentalInitialValue = value; }
        }

        /// <summary>
        /// Sets the RentalInitialValue property.
        /// </summary>
        /// <param name="rentalInitialValue">RentalInitialValue property.</param>
        /// <returns>this instance.</returns>
        public RentalTransactionEvent WithRentalInitialValue(Currency rentalInitialValue)
        {
            this._rentalInitialValue = rentalInitialValue;
            return this;
        }

        /// <summary>
        /// Checks if RentalInitialValue property is set.
        /// </summary>
        /// <returns>true if RentalInitialValue property is set.</returns>
        public bool IsSetRentalInitialValue()
        {
            return this._rentalInitialValue != null;
        }

        /// <summary>
        /// Gets and sets the RentalReimbursement property.
        /// </summary>
        public Currency RentalReimbursement
        {
            get { return this._rentalReimbursement; }
            set { this._rentalReimbursement = value; }
        }

        /// <summary>
        /// Sets the RentalReimbursement property.
        /// </summary>
        /// <param name="rentalReimbursement">RentalReimbursement property.</param>
        /// <returns>this instance.</returns>
        public RentalTransactionEvent WithRentalReimbursement(Currency rentalReimbursement)
        {
            this._rentalReimbursement = rentalReimbursement;
            return this;
        }

        /// <summary>
        /// Checks if RentalReimbursement property is set.
        /// </summary>
        /// <returns>true if RentalReimbursement property is set.</returns>
        public bool IsSetRentalReimbursement()
        {
            return this._rentalReimbursement != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _amazonOrderId = reader.Read<string>("AmazonOrderId");
            _rentalEventType = reader.Read<string>("RentalEventType");
            _extensionLength = reader.Read<decimal?>("ExtensionLength");
            _postedDate = reader.Read<DateTime?>("PostedDate");
            _rentalChargeList = reader.ReadList<ChargeComponent>("RentalChargeList", "ChargeComponent");
            _rentalFeeList = reader.ReadList<FeeComponent>("RentalFeeList", "FeeComponent");
            _marketplaceName = reader.Read<string>("MarketplaceName");
            _rentalInitialValue = reader.Read<Currency>("RentalInitialValue");
            _rentalReimbursement = reader.Read<Currency>("RentalReimbursement");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("AmazonOrderId", _amazonOrderId);
            writer.Write("RentalEventType", _rentalEventType);
            writer.Write("ExtensionLength", _extensionLength);
            writer.Write("PostedDate", _postedDate);
            writer.WriteList("RentalChargeList", "ChargeComponent", _rentalChargeList);
            writer.WriteList("RentalFeeList", "FeeComponent", _rentalFeeList);
            writer.Write("MarketplaceName", _marketplaceName);
            writer.Write("RentalInitialValue", _rentalInitialValue);
            writer.Write("RentalReimbursement", _rentalReimbursement);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "RentalTransactionEvent", this);
        }


        public RentalTransactionEvent() : base()
        {
        }
    }
}
