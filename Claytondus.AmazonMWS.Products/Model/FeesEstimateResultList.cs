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
 * Fees Estimate Result List
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */


using System;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Products.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false)]
    public class FeesEstimateResultList : AbstractMwsObject
    {

        private List<FeesEstimateResult> _feesEstimateResult;

        /// <summary>
        /// Gets and sets the FeesEstimateResult property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeesEstimateResult")]
        public List<FeesEstimateResult> FeesEstimateResult
        {
            get
            {
                if(this._feesEstimateResult == null)
                {
                    this._feesEstimateResult = new List<FeesEstimateResult>();
                }
                return this._feesEstimateResult;
            }
            set { this._feesEstimateResult = value; }
        }

        /// <summary>
        /// Sets the FeesEstimateResult property.
        /// </summary>
        /// <param name="feesEstimateResult">FeesEstimateResult property.</param>
        /// <returns>this instance.</returns>
        public FeesEstimateResultList WithFeesEstimateResult(FeesEstimateResult[] feesEstimateResult)
        {
            this._feesEstimateResult.AddRange(feesEstimateResult);
            return this;
        }

        /// <summary>
        /// Checks if FeesEstimateResult property is set.
        /// </summary>
        /// <returns>true if FeesEstimateResult property is set.</returns>
        public bool IsSetFeesEstimateResult()
        {
            return this.FeesEstimateResult.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _feesEstimateResult = reader.ReadList<FeesEstimateResult>("FeesEstimateResult");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("FeesEstimateResult", _feesEstimateResult);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "FeesEstimateResultList", this);
        }


        public FeesEstimateResultList() : base()
        {
        }
    }
}
