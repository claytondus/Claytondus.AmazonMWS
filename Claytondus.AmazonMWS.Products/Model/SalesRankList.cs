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
 * Sales Rank List
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
    public class SalesRankList : AbstractMwsObject
    {

        private List<SalesRankType> _salesRank;

        /// <summary>
        /// Gets and sets the SalesRank property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SalesRank")]
        public List<SalesRankType> SalesRank
        {
            get
            {
                if(this._salesRank == null)
                {
                    this._salesRank = new List<SalesRankType>();
                }
                return this._salesRank;
            }
            set { this._salesRank = value; }
        }

        /// <summary>
        /// Sets the SalesRank property.
        /// </summary>
        /// <param name="salesRank">SalesRank property.</param>
        /// <returns>this instance.</returns>
        public SalesRankList WithSalesRank(SalesRankType[] salesRank)
        {
            this._salesRank.AddRange(salesRank);
            return this;
        }

        /// <summary>
        /// Checks if SalesRank property is set.
        /// </summary>
        /// <returns>true if SalesRank property is set.</returns>
        public bool IsSetSalesRank()
        {
            return this.SalesRank.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _salesRank = reader.ReadList<SalesRankType>("SalesRank");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("SalesRank", _salesRank);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "SalesRankList", this);
        }


        public SalesRankList() : base()
        {
        }
    }
}
