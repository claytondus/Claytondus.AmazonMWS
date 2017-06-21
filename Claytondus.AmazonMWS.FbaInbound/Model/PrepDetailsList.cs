/*******************************************************************************
 * Copyright 2009-2016 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Prep Details List
 * API Version: 2010-10-01
 * Library Version: 2016-10-05
 * Generated: Wed Oct 05 06:15:39 PDT 2016
 */


using System;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaInbound.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    [XmlRootAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", IsNullable = false)]
    public class PrepDetailsList : AbstractMwsObject
    {

        private List<PrepDetails> _prepDetails;

        /// <summary>
        /// Gets and sets the PrepDetails property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrepDetails")]
        public List<PrepDetails> PrepDetails
        {
            get
            {
                if(this._prepDetails == null)
                {
                    this._prepDetails = new List<PrepDetails>();
                }
                return this._prepDetails;
            }
            set { this._prepDetails = value; }
        }

        /// <summary>
        /// Sets the PrepDetails property.
        /// </summary>
        /// <param name="prepDetails">PrepDetails property.</param>
        /// <returns>this instance.</returns>
        public PrepDetailsList WithPrepDetails(PrepDetails[] prepDetails)
        {
            this._prepDetails.AddRange(prepDetails);
            return this;
        }

        /// <summary>
        /// Checks if PrepDetails property is set.
        /// </summary>
        /// <returns>true if PrepDetails property is set.</returns>
        public bool IsSetPrepDetails()
        {
            return this.PrepDetails.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _prepDetails = reader.ReadList<PrepDetails>("PrepDetails");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("PrepDetails", _prepDetails);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "PrepDetailsList", this);
        }


        public PrepDetailsList() : base()
        {
        }
    }
}
