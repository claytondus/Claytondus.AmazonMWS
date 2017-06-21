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
 * ASIN Prep Instructions
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
    public class ASINPrepInstructions : AbstractMwsObject
    {

        private string _asin;
        private string _barcodeInstruction;
        private string _prepGuidance;
        private PrepInstructionList _prepInstructionList;

        /// <summary>
        /// Gets and sets the ASIN property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ASIN")]
        public string ASIN
        {
            get { return this._asin; }
            set { this._asin = value; }
        }

        /// <summary>
        /// Sets the ASIN property.
        /// </summary>
        /// <param name="asin">ASIN property.</param>
        /// <returns>this instance.</returns>
        public ASINPrepInstructions WithASIN(string asin)
        {
            this._asin = asin;
            return this;
        }

        /// <summary>
        /// Checks if ASIN property is set.
        /// </summary>
        /// <returns>true if ASIN property is set.</returns>
        public bool IsSetASIN()
        {
            return this._asin != null;
        }

        /// <summary>
        /// Gets and sets the BarcodeInstruction property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BarcodeInstruction")]
        public string BarcodeInstruction
        {
            get { return this._barcodeInstruction; }
            set { this._barcodeInstruction = value; }
        }

        /// <summary>
        /// Sets the BarcodeInstruction property.
        /// </summary>
        /// <param name="barcodeInstruction">BarcodeInstruction property.</param>
        /// <returns>this instance.</returns>
        public ASINPrepInstructions WithBarcodeInstruction(string barcodeInstruction)
        {
            this._barcodeInstruction = barcodeInstruction;
            return this;
        }

        /// <summary>
        /// Checks if BarcodeInstruction property is set.
        /// </summary>
        /// <returns>true if BarcodeInstruction property is set.</returns>
        public bool IsSetBarcodeInstruction()
        {
            return this._barcodeInstruction != null;
        }

        /// <summary>
        /// Gets and sets the PrepGuidance property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrepGuidance")]
        public string PrepGuidance
        {
            get { return this._prepGuidance; }
            set { this._prepGuidance = value; }
        }

        /// <summary>
        /// Sets the PrepGuidance property.
        /// </summary>
        /// <param name="prepGuidance">PrepGuidance property.</param>
        /// <returns>this instance.</returns>
        public ASINPrepInstructions WithPrepGuidance(string prepGuidance)
        {
            this._prepGuidance = prepGuidance;
            return this;
        }

        /// <summary>
        /// Checks if PrepGuidance property is set.
        /// </summary>
        /// <returns>true if PrepGuidance property is set.</returns>
        public bool IsSetPrepGuidance()
        {
            return this._prepGuidance != null;
        }

        /// <summary>
        /// Gets and sets the PrepInstructionList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrepInstructionList")]
        public PrepInstructionList PrepInstructionList
        {
            get { return this._prepInstructionList; }
            set { this._prepInstructionList = value; }
        }

        /// <summary>
        /// Sets the PrepInstructionList property.
        /// </summary>
        /// <param name="prepInstructionList">PrepInstructionList property.</param>
        /// <returns>this instance.</returns>
        public ASINPrepInstructions WithPrepInstructionList(PrepInstructionList prepInstructionList)
        {
            this._prepInstructionList = prepInstructionList;
            return this;
        }

        /// <summary>
        /// Checks if PrepInstructionList property is set.
        /// </summary>
        /// <returns>true if PrepInstructionList property is set.</returns>
        public bool IsSetPrepInstructionList()
        {
            return this._prepInstructionList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _asin = reader.Read<string>("ASIN");
            _barcodeInstruction = reader.Read<string>("BarcodeInstruction");
            _prepGuidance = reader.Read<string>("PrepGuidance");
            _prepInstructionList = reader.Read<PrepInstructionList>("PrepInstructionList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ASIN", _asin);
            writer.Write("BarcodeInstruction", _barcodeInstruction);
            writer.Write("PrepGuidance", _prepGuidance);
            writer.Write("PrepInstructionList", _prepInstructionList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "ASINPrepInstructions", this);
        }


        public ASINPrepInstructions() : base()
        {
        }
    }
}
