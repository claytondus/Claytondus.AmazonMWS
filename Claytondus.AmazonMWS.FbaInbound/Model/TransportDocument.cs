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
 * Transport Document
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
    public class TransportDocument : AbstractMwsObject
    {

        private string _pdfDocument;
        private string _checksum;

        /// <summary>
        /// Gets and sets the PdfDocument property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PdfDocument")]
        public string PdfDocument
        {
            get { return this._pdfDocument; }
            set { this._pdfDocument = value; }
        }

        /// <summary>
        /// Sets the PdfDocument property.
        /// </summary>
        /// <param name="pdfDocument">PdfDocument property.</param>
        /// <returns>this instance.</returns>
        public TransportDocument WithPdfDocument(string pdfDocument)
        {
            this._pdfDocument = pdfDocument;
            return this;
        }

        /// <summary>
        /// Checks if PdfDocument property is set.
        /// </summary>
        /// <returns>true if PdfDocument property is set.</returns>
        public bool IsSetPdfDocument()
        {
            return this._pdfDocument != null;
        }

        /// <summary>
        /// Gets and sets the Checksum property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Checksum")]
        public string Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        /// <summary>
        /// Sets the Checksum property.
        /// </summary>
        /// <param name="checksum">Checksum property.</param>
        /// <returns>this instance.</returns>
        public TransportDocument WithChecksum(string checksum)
        {
            this._checksum = checksum;
            return this;
        }

        /// <summary>
        /// Checks if Checksum property is set.
        /// </summary>
        /// <returns>true if Checksum property is set.</returns>
        public bool IsSetChecksum()
        {
            return this._checksum != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _pdfDocument = reader.Read<string>("PdfDocument");
            _checksum = reader.Read<string>("Checksum");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("PdfDocument", _pdfDocument);
            writer.Write("Checksum", _checksum);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "TransportDocument", this);
        }

    public TransportDocument (string pdfDocument,string checksum) : base() {
        this._pdfDocument = pdfDocument;
        this._checksum = checksum;
    }

        public TransportDocument() : base()
        {
        }
    }
}
