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
 * Amazon Prep Fees Details List
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
    public class AmazonPrepFeesDetailsList : AbstractMwsObject
    {

        private List<AmazonPrepFeesDetails> _amazonPrepFeesDetails;

        /// <summary>
        /// Gets and sets the AmazonPrepFeesDetails property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AmazonPrepFeesDetails")]
        public List<AmazonPrepFeesDetails> AmazonPrepFeesDetails
        {
            get
            {
                if(this._amazonPrepFeesDetails == null)
                {
                    this._amazonPrepFeesDetails = new List<AmazonPrepFeesDetails>();
                }
                return this._amazonPrepFeesDetails;
            }
            set { this._amazonPrepFeesDetails = value; }
        }

        /// <summary>
        /// Sets the AmazonPrepFeesDetails property.
        /// </summary>
        /// <param name="amazonPrepFeesDetails">AmazonPrepFeesDetails property.</param>
        /// <returns>this instance.</returns>
        public AmazonPrepFeesDetailsList WithAmazonPrepFeesDetails(AmazonPrepFeesDetails[] amazonPrepFeesDetails)
        {
            this._amazonPrepFeesDetails.AddRange(amazonPrepFeesDetails);
            return this;
        }

        /// <summary>
        /// Checks if AmazonPrepFeesDetails property is set.
        /// </summary>
        /// <returns>true if AmazonPrepFeesDetails property is set.</returns>
        public bool IsSetAmazonPrepFeesDetails()
        {
            return this.AmazonPrepFeesDetails.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _amazonPrepFeesDetails = reader.ReadList<AmazonPrepFeesDetails>("AmazonPrepFeesDetails");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("AmazonPrepFeesDetails", _amazonPrepFeesDetails);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "AmazonPrepFeesDetailsList", this);
        }


        public AmazonPrepFeesDetailsList() : base()
        {
        }
    }
}
