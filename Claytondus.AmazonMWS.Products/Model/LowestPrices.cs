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
 * Lowest Prices
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
    public class LowestPrices : AbstractMwsObject
    {

        private List<LowestPriceType> _lowestPrice;

        /// <summary>
        /// Gets and sets the LowestPrice property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LowestPrice")]
        public List<LowestPriceType> LowestPrice
        {
            get
            {
                if(this._lowestPrice == null)
                {
                    this._lowestPrice = new List<LowestPriceType>();
                }
                return this._lowestPrice;
            }
            set { this._lowestPrice = value; }
        }

        /// <summary>
        /// Sets the LowestPrice property.
        /// </summary>
        /// <param name="lowestPrice">LowestPrice property.</param>
        /// <returns>this instance.</returns>
        public LowestPrices WithLowestPrice(LowestPriceType[] lowestPrice)
        {
            this._lowestPrice.AddRange(lowestPrice);
            return this;
        }

        /// <summary>
        /// Checks if LowestPrice property is set.
        /// </summary>
        /// <returns>true if LowestPrice property is set.</returns>
        public bool IsSetLowestPrice()
        {
            return this.LowestPrice.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _lowestPrice = reader.ReadList<LowestPriceType>("LowestPrice");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("LowestPrice", _lowestPrice);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "LowestPrices", this);
        }


        public LowestPrices() : base()
        {
        }
    }
}
