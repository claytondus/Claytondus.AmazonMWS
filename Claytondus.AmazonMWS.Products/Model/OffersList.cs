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
 * Offers List
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
    public class OffersList : AbstractMwsObject
    {

        private List<OfferType> _offer;

        /// <summary>
        /// Gets and sets the Offer property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Offer")]
        public List<OfferType> Offer
        {
            get
            {
                if(this._offer == null)
                {
                    this._offer = new List<OfferType>();
                }
                return this._offer;
            }
            set { this._offer = value; }
        }

        /// <summary>
        /// Sets the Offer property.
        /// </summary>
        /// <param name="offer">Offer property.</param>
        /// <returns>this instance.</returns>
        public OffersList WithOffer(OfferType[] offer)
        {
            this._offer.AddRange(offer);
            return this;
        }

        /// <summary>
        /// Checks if Offer property is set.
        /// </summary>
        /// <returns>true if Offer property is set.</returns>
        public bool IsSetOffer()
        {
            return this.Offer.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _offer = reader.ReadList<OfferType>("Offer");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("Offer", _offer);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "OffersList", this);
        }


        public OffersList() : base()
        {
        }
    }
}
