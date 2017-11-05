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
 * Reason Code Details List
 * API Version: 2010-10-01
 * Library Version: 2016-10-19
 * Generated: Wed Oct 19 08:37:54 PDT 2016
 */


using System;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaOutbound.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", IsNullable = false)]
    public class ReasonCodeDetailsList : AbstractMwsObject
    {

        private List<ReasonCodeDetails> _member;

        /// <summary>
        /// Gets and sets the member property.
        /// </summary>
        [XmlElement(ElementName = "member")]
        public List<ReasonCodeDetails> member
        {
            get
            {
                if(this._member == null)
                {
                    this._member = new List<ReasonCodeDetails>();
                }
                return this._member;
            }
            set { this._member = value; }
        }

        /// <summary>
        /// Sets the member property.
        /// </summary>
        /// <param name="member">member property.</param>
        /// <returns>this instance.</returns>
        public ReasonCodeDetailsList Withmember(ReasonCodeDetails[] member)
        {
            this._member.AddRange(member);
            return this;
        }

        /// <summary>
        /// Checks if member property is set.
        /// </summary>
        /// <returns>true if member property is set.</returns>
        public bool IsSetmember()
        {
            return this.member.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _member = reader.ReadList<ReasonCodeDetails>("member");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("member", _member);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "ReasonCodeDetailsList", this);
        }


        public ReasonCodeDetailsList() : base()
        {
        }
    }
}
