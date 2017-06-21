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
 * Get Prep Instructions For ASIN Result
 * API Version: 2010-10-01
 * Library Version: 2016-10-05
 * Generated: Wed Oct 05 06:15:39 PDT 2016
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaInbound.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    [XmlRootAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", IsNullable = false)]
    public class GetPrepInstructionsForASINResult : AbstractMwsObject
    {

        private ASINPrepInstructionsList _asinPrepInstructionsList;
        private InvalidASINList _invalidASINList;

        /// <summary>
        /// Gets and sets the ASINPrepInstructionsList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ASINPrepInstructionsList")]
        public ASINPrepInstructionsList ASINPrepInstructionsList
        {
            get { return this._asinPrepInstructionsList; }
            set { this._asinPrepInstructionsList = value; }
        }

        /// <summary>
        /// Sets the ASINPrepInstructionsList property.
        /// </summary>
        /// <param name="asinPrepInstructionsList">ASINPrepInstructionsList property.</param>
        /// <returns>this instance.</returns>
        public GetPrepInstructionsForASINResult WithASINPrepInstructionsList(ASINPrepInstructionsList asinPrepInstructionsList)
        {
            this._asinPrepInstructionsList = asinPrepInstructionsList;
            return this;
        }

        /// <summary>
        /// Checks if ASINPrepInstructionsList property is set.
        /// </summary>
        /// <returns>true if ASINPrepInstructionsList property is set.</returns>
        public bool IsSetASINPrepInstructionsList()
        {
            return this._asinPrepInstructionsList != null;
        }

        /// <summary>
        /// Gets and sets the InvalidASINList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "InvalidASINList")]
        public InvalidASINList InvalidASINList
        {
            get { return this._invalidASINList; }
            set { this._invalidASINList = value; }
        }

        /// <summary>
        /// Sets the InvalidASINList property.
        /// </summary>
        /// <param name="invalidASINList">InvalidASINList property.</param>
        /// <returns>this instance.</returns>
        public GetPrepInstructionsForASINResult WithInvalidASINList(InvalidASINList invalidASINList)
        {
            this._invalidASINList = invalidASINList;
            return this;
        }

        /// <summary>
        /// Checks if InvalidASINList property is set.
        /// </summary>
        /// <returns>true if InvalidASINList property is set.</returns>
        public bool IsSetInvalidASINList()
        {
            return this._invalidASINList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _asinPrepInstructionsList = reader.Read<ASINPrepInstructionsList>("ASINPrepInstructionsList");
            _invalidASINList = reader.Read<InvalidASINList>("InvalidASINList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ASINPrepInstructionsList", _asinPrepInstructionsList);
            writer.Write("InvalidASINList", _invalidASINList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "GetPrepInstructionsForASINResult", this);
        }


        public GetPrepInstructionsForASINResult() : base()
        {
        }
    }
}
