/*******************************************************************************
 * Copyright 2009-2017 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Buyer Tax Info
 * API Version: 2013-09-01
 * Library Version: 2017-02-22
 * Generated: Thu Mar 02 12:41:05 UTC 2017
 */


using System;
using System.Xml;
using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Orders.Model
{
    public class BuyerTaxInfo : AbstractMwsObject
    {

        private string _companyLegalName;
        private string _taxingRegion;
        private List<TaxClassification> _taxClassifications;

        /// <summary>
        /// Gets and sets the CompanyLegalName property.
        /// </summary>
        public string CompanyLegalName
        {
            get { return this._companyLegalName; }
            set { this._companyLegalName = value; }
        }

        /// <summary>
        /// Sets the CompanyLegalName property.
        /// </summary>
        /// <param name="companyLegalName">CompanyLegalName property.</param>
        /// <returns>this instance.</returns>
        public BuyerTaxInfo WithCompanyLegalName(string companyLegalName)
        {
            this._companyLegalName = companyLegalName;
            return this;
        }

        /// <summary>
        /// Checks if CompanyLegalName property is set.
        /// </summary>
        /// <returns>true if CompanyLegalName property is set.</returns>
        public bool IsSetCompanyLegalName()
        {
            return this._companyLegalName != null;
        }

        /// <summary>
        /// Gets and sets the TaxingRegion property.
        /// </summary>
        public string TaxingRegion
        {
            get { return this._taxingRegion; }
            set { this._taxingRegion = value; }
        }

        /// <summary>
        /// Sets the TaxingRegion property.
        /// </summary>
        /// <param name="taxingRegion">TaxingRegion property.</param>
        /// <returns>this instance.</returns>
        public BuyerTaxInfo WithTaxingRegion(string taxingRegion)
        {
            this._taxingRegion = taxingRegion;
            return this;
        }

        /// <summary>
        /// Checks if TaxingRegion property is set.
        /// </summary>
        /// <returns>true if TaxingRegion property is set.</returns>
        public bool IsSetTaxingRegion()
        {
            return this._taxingRegion != null;
        }

        /// <summary>
        /// Gets and sets the TaxClassifications property.
        /// </summary>
        public List<TaxClassification> TaxClassifications
        {
            get
            {
                if(this._taxClassifications == null)
                {
                    this._taxClassifications = new List<TaxClassification>();
                }
                return this._taxClassifications;
            }
            set { this._taxClassifications = value; }
        }

        /// <summary>
        /// Sets the TaxClassifications property.
        /// </summary>
        /// <param name="taxClassifications">TaxClassifications property.</param>
        /// <returns>this instance.</returns>
        public BuyerTaxInfo WithTaxClassifications(TaxClassification[] taxClassifications)
        {
            this._taxClassifications.AddRange(taxClassifications);
            return this;
        }

        /// <summary>
        /// Checks if TaxClassifications property is set.
        /// </summary>
        /// <returns>true if TaxClassifications property is set.</returns>
        public bool IsSetTaxClassifications()
        {
            return this.TaxClassifications.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _companyLegalName = reader.Read<string>("CompanyLegalName");
            _taxingRegion = reader.Read<string>("TaxingRegion");
            _taxClassifications = reader.ReadList<TaxClassification>("TaxClassifications", "TaxClassification");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("CompanyLegalName", _companyLegalName);
            writer.Write("TaxingRegion", _taxingRegion);
            writer.WriteList("TaxClassifications", "TaxClassification", _taxClassifications);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "BuyerTaxInfo", this);
        }


        public BuyerTaxInfo() : base()
        {
        }
    }
}
