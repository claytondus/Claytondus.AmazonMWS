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
 * Charge Instrument
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class ChargeInstrument : AbstractMwsObject
    {

        private string _description;
        private string _tail;
        private Currency _amount;

        /// <summary>
        /// Gets and sets the Description property.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        /// <summary>
        /// Sets the Description property.
        /// </summary>
        /// <param name="description">Description property.</param>
        /// <returns>this instance.</returns>
        public ChargeInstrument WithDescription(string description)
        {
            this._description = description;
            return this;
        }

        /// <summary>
        /// Checks if Description property is set.
        /// </summary>
        /// <returns>true if Description property is set.</returns>
        public bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the Tail property.
        /// </summary>
        public string Tail
        {
            get { return this._tail; }
            set { this._tail = value; }
        }

        /// <summary>
        /// Sets the Tail property.
        /// </summary>
        /// <param name="tail">Tail property.</param>
        /// <returns>this instance.</returns>
        public ChargeInstrument WithTail(string tail)
        {
            this._tail = tail;
            return this;
        }

        /// <summary>
        /// Checks if Tail property is set.
        /// </summary>
        /// <returns>true if Tail property is set.</returns>
        public bool IsSetTail()
        {
            return this._tail != null;
        }

        /// <summary>
        /// Gets and sets the Amount property.
        /// </summary>
        public Currency Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        /// <summary>
        /// Sets the Amount property.
        /// </summary>
        /// <param name="amount">Amount property.</param>
        /// <returns>this instance.</returns>
        public ChargeInstrument WithAmount(Currency amount)
        {
            this._amount = amount;
            return this;
        }

        /// <summary>
        /// Checks if Amount property is set.
        /// </summary>
        /// <returns>true if Amount property is set.</returns>
        public bool IsSetAmount()
        {
            return this._amount != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _description = reader.Read<string>("Description");
            _tail = reader.Read<string>("Tail");
            _amount = reader.Read<Currency>("Amount");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Description", _description);
            writer.Write("Tail", _tail);
            writer.Write("Amount", _amount);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "ChargeInstrument", this);
        }


        public ChargeInstrument() : base()
        {
        }
    }
}
