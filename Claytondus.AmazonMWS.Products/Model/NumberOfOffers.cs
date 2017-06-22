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
 * Number Of Offers
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
    public class NumberOfOffers : AbstractMwsObject
    {

        private List<OfferCountType> _offerCount;

        /// <summary>
        /// Gets and sets the OfferCount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "OfferCount")]
        public List<OfferCountType> OfferCount
        {
            get
            {
                if(this._offerCount == null)
                {
                    this._offerCount = new List<OfferCountType>();
                }
                return this._offerCount;
            }
            set { this._offerCount = value; }
        }

        /// <summary>
        /// Sets the OfferCount property.
        /// </summary>
        /// <param name="offerCount">OfferCount property.</param>
        /// <returns>this instance.</returns>
        public NumberOfOffers WithOfferCount(OfferCountType[] offerCount)
        {
            this._offerCount.AddRange(offerCount);
            return this;
        }

        /// <summary>
        /// Checks if OfferCount property is set.
        /// </summary>
        /// <returns>true if OfferCount property is set.</returns>
        public bool IsSetOfferCount()
        {
            return this.OfferCount.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _offerCount = reader.ReadList<OfferCountType>("OfferCount");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("OfferCount", _offerCount);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "NumberOfOffers", this);
        }


        public NumberOfOffers() : base()
        {
        }
    }
}
