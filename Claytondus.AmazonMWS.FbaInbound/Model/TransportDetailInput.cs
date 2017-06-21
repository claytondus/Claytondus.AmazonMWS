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
 * Transport Detail Input
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
    public class TransportDetailInput : AbstractMwsObject
    {

        private PartneredSmallParcelDataInput _partneredSmallParcelData;
        private NonPartneredSmallParcelDataInput _nonPartneredSmallParcelData;
        private PartneredLtlDataInput _partneredLtlData;
        private NonPartneredLtlDataInput _nonPartneredLtlData;

        /// <summary>
        /// Gets and sets the PartneredSmallParcelData property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PartneredSmallParcelData")]
        public PartneredSmallParcelDataInput PartneredSmallParcelData
        {
            get { return this._partneredSmallParcelData; }
            set { this._partneredSmallParcelData = value; }
        }

        /// <summary>
        /// Sets the PartneredSmallParcelData property.
        /// </summary>
        /// <param name="partneredSmallParcelData">PartneredSmallParcelData property.</param>
        /// <returns>this instance.</returns>
        public TransportDetailInput WithPartneredSmallParcelData(PartneredSmallParcelDataInput partneredSmallParcelData)
        {
            this._partneredSmallParcelData = partneredSmallParcelData;
            return this;
        }

        /// <summary>
        /// Checks if PartneredSmallParcelData property is set.
        /// </summary>
        /// <returns>true if PartneredSmallParcelData property is set.</returns>
        public bool IsSetPartneredSmallParcelData()
        {
            return this._partneredSmallParcelData != null;
        }

        /// <summary>
        /// Gets and sets the NonPartneredSmallParcelData property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NonPartneredSmallParcelData")]
        public NonPartneredSmallParcelDataInput NonPartneredSmallParcelData
        {
            get { return this._nonPartneredSmallParcelData; }
            set { this._nonPartneredSmallParcelData = value; }
        }

        /// <summary>
        /// Sets the NonPartneredSmallParcelData property.
        /// </summary>
        /// <param name="nonPartneredSmallParcelData">NonPartneredSmallParcelData property.</param>
        /// <returns>this instance.</returns>
        public TransportDetailInput WithNonPartneredSmallParcelData(NonPartneredSmallParcelDataInput nonPartneredSmallParcelData)
        {
            this._nonPartneredSmallParcelData = nonPartneredSmallParcelData;
            return this;
        }

        /// <summary>
        /// Checks if NonPartneredSmallParcelData property is set.
        /// </summary>
        /// <returns>true if NonPartneredSmallParcelData property is set.</returns>
        public bool IsSetNonPartneredSmallParcelData()
        {
            return this._nonPartneredSmallParcelData != null;
        }

        /// <summary>
        /// Gets and sets the PartneredLtlData property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PartneredLtlData")]
        public PartneredLtlDataInput PartneredLtlData
        {
            get { return this._partneredLtlData; }
            set { this._partneredLtlData = value; }
        }

        /// <summary>
        /// Sets the PartneredLtlData property.
        /// </summary>
        /// <param name="partneredLtlData">PartneredLtlData property.</param>
        /// <returns>this instance.</returns>
        public TransportDetailInput WithPartneredLtlData(PartneredLtlDataInput partneredLtlData)
        {
            this._partneredLtlData = partneredLtlData;
            return this;
        }

        /// <summary>
        /// Checks if PartneredLtlData property is set.
        /// </summary>
        /// <returns>true if PartneredLtlData property is set.</returns>
        public bool IsSetPartneredLtlData()
        {
            return this._partneredLtlData != null;
        }

        /// <summary>
        /// Gets and sets the NonPartneredLtlData property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NonPartneredLtlData")]
        public NonPartneredLtlDataInput NonPartneredLtlData
        {
            get { return this._nonPartneredLtlData; }
            set { this._nonPartneredLtlData = value; }
        }

        /// <summary>
        /// Sets the NonPartneredLtlData property.
        /// </summary>
        /// <param name="nonPartneredLtlData">NonPartneredLtlData property.</param>
        /// <returns>this instance.</returns>
        public TransportDetailInput WithNonPartneredLtlData(NonPartneredLtlDataInput nonPartneredLtlData)
        {
            this._nonPartneredLtlData = nonPartneredLtlData;
            return this;
        }

        /// <summary>
        /// Checks if NonPartneredLtlData property is set.
        /// </summary>
        /// <returns>true if NonPartneredLtlData property is set.</returns>
        public bool IsSetNonPartneredLtlData()
        {
            return this._nonPartneredLtlData != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _partneredSmallParcelData = reader.Read<PartneredSmallParcelDataInput>("PartneredSmallParcelData");
            _nonPartneredSmallParcelData = reader.Read<NonPartneredSmallParcelDataInput>("NonPartneredSmallParcelData");
            _partneredLtlData = reader.Read<PartneredLtlDataInput>("PartneredLtlData");
            _nonPartneredLtlData = reader.Read<NonPartneredLtlDataInput>("NonPartneredLtlData");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("PartneredSmallParcelData", _partneredSmallParcelData);
            writer.Write("NonPartneredSmallParcelData", _nonPartneredSmallParcelData);
            writer.Write("PartneredLtlData", _partneredLtlData);
            writer.Write("NonPartneredLtlData", _nonPartneredLtlData);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "TransportDetailInput", this);
        }


        public TransportDetailInput() : base()
        {
        }
    }
}
