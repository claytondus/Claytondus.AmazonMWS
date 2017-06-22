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
 * Buy Box Prices
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
    public class BuyBoxPrices : AbstractMwsObject
    {

        private List<BuyBoxPriceType> _buyBoxPrice;

        /// <summary>
        /// Gets and sets the BuyBoxPrice property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BuyBoxPrice")]
        public List<BuyBoxPriceType> BuyBoxPrice
        {
            get
            {
                if(this._buyBoxPrice == null)
                {
                    this._buyBoxPrice = new List<BuyBoxPriceType>();
                }
                return this._buyBoxPrice;
            }
            set { this._buyBoxPrice = value; }
        }

        /// <summary>
        /// Sets the BuyBoxPrice property.
        /// </summary>
        /// <param name="buyBoxPrice">BuyBoxPrice property.</param>
        /// <returns>this instance.</returns>
        public BuyBoxPrices WithBuyBoxPrice(BuyBoxPriceType[] buyBoxPrice)
        {
            this._buyBoxPrice.AddRange(buyBoxPrice);
            return this;
        }

        /// <summary>
        /// Checks if BuyBoxPrice property is set.
        /// </summary>
        /// <returns>true if BuyBoxPrice property is set.</returns>
        public bool IsSetBuyBoxPrice()
        {
            return this.BuyBoxPrice.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _buyBoxPrice = reader.ReadList<BuyBoxPriceType>("BuyBoxPrice");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("BuyBoxPrice", _buyBoxPrice);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "BuyBoxPrices", this);
        }


        public BuyBoxPrices() : base()
        {
        }
    }
}
