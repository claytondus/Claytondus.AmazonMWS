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
 * Debt Recovery Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class DebtRecoveryEvent : AbstractMwsObject
    {

        private string _debtRecoveryType;
        private Currency _recoveryAmount;
        private Currency _overPaymentCredit;
        private List<DebtRecoveryItem> _debtRecoveryItemList;
        private List<ChargeInstrument> _chargeInstrumentList;

        /// <summary>
        /// Gets and sets the DebtRecoveryType property.
        /// </summary>
        public string DebtRecoveryType
        {
            get { return this._debtRecoveryType; }
            set { this._debtRecoveryType = value; }
        }

        /// <summary>
        /// Sets the DebtRecoveryType property.
        /// </summary>
        /// <param name="debtRecoveryType">DebtRecoveryType property.</param>
        /// <returns>this instance.</returns>
        public DebtRecoveryEvent WithDebtRecoveryType(string debtRecoveryType)
        {
            this._debtRecoveryType = debtRecoveryType;
            return this;
        }

        /// <summary>
        /// Checks if DebtRecoveryType property is set.
        /// </summary>
        /// <returns>true if DebtRecoveryType property is set.</returns>
        public bool IsSetDebtRecoveryType()
        {
            return this._debtRecoveryType != null;
        }

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
        public DebtRecoveryEvent WithRecoveryAmount(Currency recoveryAmount)
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
        /// Gets and sets the OverPaymentCredit property.
        /// </summary>
        public Currency OverPaymentCredit
        {
            get { return this._overPaymentCredit; }
            set { this._overPaymentCredit = value; }
        }

        /// <summary>
        /// Sets the OverPaymentCredit property.
        /// </summary>
        /// <param name="overPaymentCredit">OverPaymentCredit property.</param>
        /// <returns>this instance.</returns>
        public DebtRecoveryEvent WithOverPaymentCredit(Currency overPaymentCredit)
        {
            this._overPaymentCredit = overPaymentCredit;
            return this;
        }

        /// <summary>
        /// Checks if OverPaymentCredit property is set.
        /// </summary>
        /// <returns>true if OverPaymentCredit property is set.</returns>
        public bool IsSetOverPaymentCredit()
        {
            return this._overPaymentCredit != null;
        }

        /// <summary>
        /// Gets and sets the DebtRecoveryItemList property.
        /// </summary>
        public List<DebtRecoveryItem> DebtRecoveryItemList
        {
            get
            {
                if(this._debtRecoveryItemList == null)
                {
                    this._debtRecoveryItemList = new List<DebtRecoveryItem>();
                }
                return this._debtRecoveryItemList;
            }
            set { this._debtRecoveryItemList = value; }
        }

        /// <summary>
        /// Sets the DebtRecoveryItemList property.
        /// </summary>
        /// <param name="debtRecoveryItemList">DebtRecoveryItemList property.</param>
        /// <returns>this instance.</returns>
        public DebtRecoveryEvent WithDebtRecoveryItemList(DebtRecoveryItem[] debtRecoveryItemList)
        {
            this._debtRecoveryItemList.AddRange(debtRecoveryItemList);
            return this;
        }

        /// <summary>
        /// Checks if DebtRecoveryItemList property is set.
        /// </summary>
        /// <returns>true if DebtRecoveryItemList property is set.</returns>
        public bool IsSetDebtRecoveryItemList()
        {
            return this.DebtRecoveryItemList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the ChargeInstrumentList property.
        /// </summary>
        public List<ChargeInstrument> ChargeInstrumentList
        {
            get
            {
                if(this._chargeInstrumentList == null)
                {
                    this._chargeInstrumentList = new List<ChargeInstrument>();
                }
                return this._chargeInstrumentList;
            }
            set { this._chargeInstrumentList = value; }
        }

        /// <summary>
        /// Sets the ChargeInstrumentList property.
        /// </summary>
        /// <param name="chargeInstrumentList">ChargeInstrumentList property.</param>
        /// <returns>this instance.</returns>
        public DebtRecoveryEvent WithChargeInstrumentList(ChargeInstrument[] chargeInstrumentList)
        {
            this._chargeInstrumentList.AddRange(chargeInstrumentList);
            return this;
        }

        /// <summary>
        /// Checks if ChargeInstrumentList property is set.
        /// </summary>
        /// <returns>true if ChargeInstrumentList property is set.</returns>
        public bool IsSetChargeInstrumentList()
        {
            return this.ChargeInstrumentList.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _debtRecoveryType = reader.Read<string>("DebtRecoveryType");
            _recoveryAmount = reader.Read<Currency>("RecoveryAmount");
            _overPaymentCredit = reader.Read<Currency>("OverPaymentCredit");
            _debtRecoveryItemList = reader.ReadList<DebtRecoveryItem>("DebtRecoveryItemList", "DebtRecoveryItem");
            _chargeInstrumentList = reader.ReadList<ChargeInstrument>("ChargeInstrumentList", "ChargeInstrument");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("DebtRecoveryType", _debtRecoveryType);
            writer.Write("RecoveryAmount", _recoveryAmount);
            writer.Write("OverPaymentCredit", _overPaymentCredit);
            writer.WriteList("DebtRecoveryItemList", "DebtRecoveryItem", _debtRecoveryItemList);
            writer.WriteList("ChargeInstrumentList", "ChargeInstrument", _chargeInstrumentList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "DebtRecoveryEvent", this);
        }


        public DebtRecoveryEvent() : base()
        {
        }
    }
}
