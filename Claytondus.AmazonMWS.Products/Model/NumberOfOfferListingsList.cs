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
 * Number Of Offer Listings List
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
    public class NumberOfOfferListingsList : AbstractMwsObject
    {

        private List<OfferListingCountType> _offerListingCount;

        /// <summary>
        /// Gets and sets the OfferListingCount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "OfferListingCount")]
        public List<OfferListingCountType> OfferListingCount
        {
            get
            {
                if(this._offerListingCount == null)
                {
                    this._offerListingCount = new List<OfferListingCountType>();
                }
                return this._offerListingCount;
            }
            set { this._offerListingCount = value; }
        }

        /// <summary>
        /// Sets the OfferListingCount property.
        /// </summary>
        /// <param name="offerListingCount">OfferListingCount property.</param>
        /// <returns>this instance.</returns>
        public NumberOfOfferListingsList WithOfferListingCount(OfferListingCountType[] offerListingCount)
        {
            this._offerListingCount.AddRange(offerListingCount);
            return this;
        }

        /// <summary>
        /// Checks if OfferListingCount property is set.
        /// </summary>
        /// <returns>true if OfferListingCount property is set.</returns>
        public bool IsSetOfferListingCount()
        {
            return this.OfferListingCount.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _offerListingCount = reader.ReadList<OfferListingCountType>("OfferListingCount");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("OfferListingCount", _offerListingCount);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "NumberOfOfferListingsList", this);
        }


        public NumberOfOfferListingsList() : base()
        {
        }
    }
}
