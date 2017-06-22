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
 * Fees Estimate Request List
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
    public class FeesEstimateRequestList : AbstractMwsObject
    {

        private List<FeesEstimateRequest> _feesEstimateRequest;

        /// <summary>
        /// Gets and sets the FeesEstimateRequest property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeesEstimateRequest")]
        public List<FeesEstimateRequest> FeesEstimateRequest
        {
            get
            {
                if(this._feesEstimateRequest == null)
                {
                    this._feesEstimateRequest = new List<FeesEstimateRequest>();
                }
                return this._feesEstimateRequest;
            }
            set { this._feesEstimateRequest = value; }
        }

        /// <summary>
        /// Sets the FeesEstimateRequest property.
        /// </summary>
        /// <param name="feesEstimateRequest">FeesEstimateRequest property.</param>
        /// <returns>this instance.</returns>
        public FeesEstimateRequestList WithFeesEstimateRequest(FeesEstimateRequest[] feesEstimateRequest)
        {
            this._feesEstimateRequest.AddRange(feesEstimateRequest);
            return this;
        }

        /// <summary>
        /// Checks if FeesEstimateRequest property is set.
        /// </summary>
        /// <returns>true if FeesEstimateRequest property is set.</returns>
        public bool IsSetFeesEstimateRequest()
        {
            return this.FeesEstimateRequest.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _feesEstimateRequest = reader.ReadList<FeesEstimateRequest>("FeesEstimateRequest");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("FeesEstimateRequest", _feesEstimateRequest);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "FeesEstimateRequestList", this);
        }


        public FeesEstimateRequestList() : base()
        {
        }
    }
}
