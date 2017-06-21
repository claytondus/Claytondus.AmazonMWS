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
 * Prep Instruction List
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
    public class PrepInstructionList : AbstractMwsObject
    {

        private List<string> _prepInstruction;

        /// <summary>
        /// Gets and sets the PrepInstruction property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrepInstruction")]
        public List<string> PrepInstruction
        {
            get
            {
                if(this._prepInstruction == null)
                {
                    this._prepInstruction = new List<string>();
                }
                return this._prepInstruction;
            }
            set { this._prepInstruction = value; }
        }

        /// <summary>
        /// Sets the PrepInstruction property.
        /// </summary>
        /// <param name="prepInstruction">PrepInstruction property.</param>
        /// <returns>this instance.</returns>
        public PrepInstructionList WithPrepInstruction(string[] prepInstruction)
        {
            this._prepInstruction.AddRange(prepInstruction);
            return this;
        }

        /// <summary>
        /// Checks if PrepInstruction property is set.
        /// </summary>
        /// <returns>true if PrepInstruction property is set.</returns>
        public bool IsSetPrepInstruction()
        {
            return this.PrepInstruction.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _prepInstruction = reader.ReadList<string>("PrepInstruction");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("PrepInstruction", _prepInstruction);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "PrepInstructionList", this);
        }


        public PrepInstructionList() : base()
        {
        }
    }
}
