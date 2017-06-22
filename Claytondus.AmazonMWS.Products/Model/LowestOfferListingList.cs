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
 * Lowest Offer Listing List
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
    public class LowestOfferListingList : AbstractMwsObject
    {

        private List<LowestOfferListingType> _lowestOfferListing;

        /// <summary>
        /// Gets and sets the LowestOfferListing property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LowestOfferListing")]
        public List<LowestOfferListingType> LowestOfferListing
        {
            get
            {
                if(this._lowestOfferListing == null)
                {
                    this._lowestOfferListing = new List<LowestOfferListingType>();
                }
                return this._lowestOfferListing;
            }
            set { this._lowestOfferListing = value; }
        }

        /// <summary>
        /// Sets the LowestOfferListing property.
        /// </summary>
        /// <param name="lowestOfferListing">LowestOfferListing property.</param>
        /// <returns>this instance.</returns>
        public LowestOfferListingList WithLowestOfferListing(LowestOfferListingType[] lowestOfferListing)
        {
            this._lowestOfferListing.AddRange(lowestOfferListing);
            return this;
        }

        /// <summary>
        /// Checks if LowestOfferListing property is set.
        /// </summary>
        /// <returns>true if LowestOfferListing property is set.</returns>
        public bool IsSetLowestOfferListing()
        {
            return this.LowestOfferListing.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _lowestOfferListing = reader.ReadList<LowestOfferListingType>("LowestOfferListing");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("LowestOfferListing", _lowestOfferListing);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "LowestOfferListingList", this);
        }


        public LowestOfferListingList() : base()
        {
        }
    }
}
