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
 * Fee Detail List
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
    public class FeeDetailList : AbstractMwsObject
    {

        private List<FeeDetail> _feeDetail;

        /// <summary>
        /// Gets and sets the FeeDetail property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeeDetail")]
        public List<FeeDetail> FeeDetail
        {
            get
            {
                if(this._feeDetail == null)
                {
                    this._feeDetail = new List<FeeDetail>();
                }
                return this._feeDetail;
            }
            set { this._feeDetail = value; }
        }

        /// <summary>
        /// Sets the FeeDetail property.
        /// </summary>
        /// <param name="feeDetail">FeeDetail property.</param>
        /// <returns>this instance.</returns>
        public FeeDetailList WithFeeDetail(FeeDetail[] feeDetail)
        {
            this._feeDetail.AddRange(feeDetail);
            return this;
        }

        /// <summary>
        /// Checks if FeeDetail property is set.
        /// </summary>
        /// <returns>true if FeeDetail property is set.</returns>
        public bool IsSetFeeDetail()
        {
            return this.FeeDetail.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _feeDetail = reader.ReadList<FeeDetail>("FeeDetail");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("FeeDetail", _feeDetail);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "FeeDetailList", this);
        }


        public FeeDetailList() : base()
        {
        }
    }
}
