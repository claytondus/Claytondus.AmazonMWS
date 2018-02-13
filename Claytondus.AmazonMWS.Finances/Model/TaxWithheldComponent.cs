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
 * Tax Withheld Component
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class TaxWithheldComponent : AbstractMwsObject
    {

        private string _taxCollectionModel;
        private List<ChargeComponent> _taxesWithheld;

        /// <summary>
        /// Gets and sets the TaxCollectionModel property.
        /// </summary>
        public string TaxCollectionModel
        {
            get { return this._taxCollectionModel; }
            set { this._taxCollectionModel = value; }
        }

        /// <summary>
        /// Sets the TaxCollectionModel property.
        /// </summary>
        /// <param name="taxCollectionModel">TaxCollectionModel property.</param>
        /// <returns>this instance.</returns>
        public TaxWithheldComponent WithTaxCollectionModel(string taxCollectionModel)
        {
            this._taxCollectionModel = taxCollectionModel;
            return this;
        }

        /// <summary>
        /// Checks if TaxCollectionModel property is set.
        /// </summary>
        /// <returns>true if TaxCollectionModel property is set.</returns>
        public bool IsSetTaxCollectionModel()
        {
            return this._taxCollectionModel != null;
        }

        /// <summary>
        /// Gets and sets the TaxesWithheld property.
        /// </summary>
        public List<ChargeComponent> TaxesWithheld
        {
            get
            {
                if(this._taxesWithheld == null)
                {
                    this._taxesWithheld = new List<ChargeComponent>();
                }
                return this._taxesWithheld;
            }
            set { this._taxesWithheld = value; }
        }

        /// <summary>
        /// Sets the TaxesWithheld property.
        /// </summary>
        /// <param name="taxesWithheld">TaxesWithheld property.</param>
        /// <returns>this instance.</returns>
        public TaxWithheldComponent WithTaxesWithheld(ChargeComponent[] taxesWithheld)
        {
            this._taxesWithheld.AddRange(taxesWithheld);
            return this;
        }

        /// <summary>
        /// Checks if TaxesWithheld property is set.
        /// </summary>
        /// <returns>true if TaxesWithheld property is set.</returns>
        public bool IsSetTaxesWithheld()
        {
            return this.TaxesWithheld.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _taxCollectionModel = reader.Read<string>("TaxCollectionModel");
            _taxesWithheld = reader.ReadList<ChargeComponent>("TaxesWithheld", "ChargeComponent");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("TaxCollectionModel", _taxCollectionModel);
            writer.WriteList("TaxesWithheld", "ChargeComponent", _taxesWithheld);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "TaxWithheldComponent", this);
        }


        public TaxWithheldComponent() : base()
        {
        }
    }
}
