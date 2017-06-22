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
 * Get My Fees Estimate Result
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Products.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false)]
    public class GetMyFeesEstimateResult : AbstractMwsObject
    {

        private FeesEstimateResultList _feesEstimateResultList;

        /// <summary>
        /// Gets and sets the FeesEstimateResultList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeesEstimateResultList")]
        public FeesEstimateResultList FeesEstimateResultList
        {
            get { return this._feesEstimateResultList; }
            set { this._feesEstimateResultList = value; }
        }

        /// <summary>
        /// Sets the FeesEstimateResultList property.
        /// </summary>
        /// <param name="feesEstimateResultList">FeesEstimateResultList property.</param>
        /// <returns>this instance.</returns>
        public GetMyFeesEstimateResult WithFeesEstimateResultList(FeesEstimateResultList feesEstimateResultList)
        {
            this._feesEstimateResultList = feesEstimateResultList;
            return this;
        }

        /// <summary>
        /// Checks if FeesEstimateResultList property is set.
        /// </summary>
        /// <returns>true if FeesEstimateResultList property is set.</returns>
        public bool IsSetFeesEstimateResultList()
        {
            return this._feesEstimateResultList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _feesEstimateResultList = reader.Read<FeesEstimateResultList>("FeesEstimateResultList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("FeesEstimateResultList", _feesEstimateResultList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "GetMyFeesEstimateResult", this);
        }


        public GetMyFeesEstimateResult() : base()
        {
        }
    }
}
