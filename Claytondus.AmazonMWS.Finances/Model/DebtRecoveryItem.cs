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
 * Debt Recovery Item
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class DebtRecoveryItem : AbstractMwsObject
    {

        private Currency _recoveryAmount;
        private Currency _originalAmount;
        private DateTime? _groupBeginDate;
        private DateTime? _groupEndDate;

        /// <summary>
        /// Gets and sets the RecoveryAmount property.
        /// </summary>
        public Currency RecoveryAmount
        {
            get { return this._recoveryAmount; }
            set { this._recoveryAmount = value; }
        }

        /// <summary>
        /// Sets the RecoveryAmount property.
        /// </summary>
        /// <param name="recoveryAmount">RecoveryAmount property.</param>
        /// <returns>this instance.</returns>
        public DebtRecoveryItem WithRecoveryAmount(Currency recoveryAmount)
        {
            this._recoveryAmount = recoveryAmount;
            return this;
        }

        /// <summary>
        /// Checks if RecoveryAmount property is set.
        /// </summary>
        /// <returns>true if RecoveryAmount property is set.</returns>
        public bool IsSetRecoveryAmount()
        {
            return this._recoveryAmount != null;
        }

        /// <summary>
        /// Gets and sets the OriginalAmount property.
        /// </summary>
        public Currency OriginalAmount
        {
            get { return this._originalAmount; }
            set { this._originalAmount = value; }
        }

        /// <summary>
        /// Sets the OriginalAmount property.
        /// </summary>
        /// <param name="originalAmount">OriginalAmount property.</param>
        /// <returns>this instance.</returns>
        public DebtRecoveryItem WithOriginalAmount(Currency originalAmount)
        {
            this._originalAmount = originalAmount;
            return this;
        }

        /// <summary>
        /// Checks if OriginalAmount property is set.
        /// </summary>
        /// <returns>true if OriginalAmount property is set.</returns>
        public bool IsSetOriginalAmount()
        {
            return this._originalAmount != null;
        }

        /// <summary>
        /// Gets and sets the GroupBeginDate property.
        /// </summary>
        public DateTime GroupBeginDate
        {
            get { return this._groupBeginDate.GetValueOrDefault(); }
            set { this._groupBeginDate = value; }
        }

        /// <summary>
        /// Sets the GroupBeginDate property.
        /// </summary>
        /// <param name="groupBeginDate">GroupBeginDate property.</param>
        /// <returns>this instance.</returns>
        public DebtRecoveryItem WithGroupBeginDate(DateTime groupBeginDate)
        {
            this._groupBeginDate = groupBeginDate;
            return this;
        }

        /// <summary>
        /// Checks if GroupBeginDate property is set.
        /// </summary>
        /// <returns>true if GroupBeginDate property is set.</returns>
        public bool IsSetGroupBeginDate()
        {
            return this._groupBeginDate != null;
        }

        /// <summary>
        /// Gets and sets the GroupEndDate property.
        /// </summary>
        public DateTime GroupEndDate
        {
            get { return this._groupEndDate.GetValueOrDefault(); }
            set { this._groupEndDate = value; }
        }

        /// <summary>
        /// Sets the GroupEndDate property.
        /// </summary>
        /// <param name="groupEndDate">GroupEndDate property.</param>
        /// <returns>this instance.</returns>
        public DebtRecoveryItem WithGroupEndDate(DateTime groupEndDate)
        {
            this._groupEndDate = groupEndDate;
            return this;
        }

        /// <summary>
        /// Checks if GroupEndDate property is set.
        /// </summary>
        /// <returns>true if GroupEndDate property is set.</returns>
        public bool IsSetGroupEndDate()
        {
            return this._groupEndDate != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _recoveryAmount = reader.Read<Currency>("RecoveryAmount");
            _originalAmount = reader.Read<Currency>("OriginalAmount");
            _groupBeginDate = reader.Read<DateTime?>("GroupBeginDate");
            _groupEndDate = reader.Read<DateTime?>("GroupEndDate");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("RecoveryAmount", _recoveryAmount);
            writer.Write("OriginalAmount", _originalAmount);
            writer.Write("GroupBeginDate", _groupBeginDate);
            writer.Write("GroupEndDate", _groupEndDate);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "DebtRecoveryItem", this);
        }


        public DebtRecoveryItem() : base()
        {
        }
    }
}
