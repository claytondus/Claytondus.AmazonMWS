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
 * Dimensions
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
    public class Dimensions : AbstractMwsObject
    {

        private decimal _length;
        private decimal _width;
        private decimal _height;
        private string _unit;

        /// <summary>
        /// Gets and sets the Length property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Length")]
        public decimal Length
        {
            get { return this._length; }
            set { this._length = value; }
        }

        /// <summary>
        /// Sets the Length property.
        /// </summary>
        /// <param name="length">Length property.</param>
        /// <returns>this instance.</returns>
        public Dimensions WithLength(decimal length)
        {
            this._length = length;
            return this;
        }

        /// <summary>
        /// Checks if Length property is set.
        /// </summary>
        /// <returns>true if Length property is set.</returns>
        public bool IsSetLength()
        {
            return this._length != null;
        }

        /// <summary>
        /// Gets and sets the Width property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Width")]
        public decimal Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        /// <summary>
        /// Sets the Width property.
        /// </summary>
        /// <param name="width">Width property.</param>
        /// <returns>this instance.</returns>
        public Dimensions WithWidth(decimal width)
        {
            this._width = width;
            return this;
        }

        /// <summary>
        /// Checks if Width property is set.
        /// </summary>
        /// <returns>true if Width property is set.</returns>
        public bool IsSetWidth()
        {
            return this._width != null;
        }

        /// <summary>
        /// Gets and sets the Height property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Height")]
        public decimal Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        /// <summary>
        /// Sets the Height property.
        /// </summary>
        /// <param name="height">Height property.</param>
        /// <returns>this instance.</returns>
        public Dimensions WithHeight(decimal height)
        {
            this._height = height;
            return this;
        }

        /// <summary>
        /// Checks if Height property is set.
        /// </summary>
        /// <returns>true if Height property is set.</returns>
        public bool IsSetHeight()
        {
            return this._height != null;
        }

        /// <summary>
        /// Gets and sets the Unit property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Unit")]
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        /// <summary>
        /// Sets the Unit property.
        /// </summary>
        /// <param name="unit">Unit property.</param>
        /// <returns>this instance.</returns>
        public Dimensions WithUnit(string unit)
        {
            this._unit = unit;
            return this;
        }

        /// <summary>
        /// Checks if Unit property is set.
        /// </summary>
        /// <returns>true if Unit property is set.</returns>
        public bool IsSetUnit()
        {
            return this._unit != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _length = reader.Read<decimal>("Length");
            _width = reader.Read<decimal>("Width");
            _height = reader.Read<decimal>("Height");
            _unit = reader.Read<string>("Unit");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Length", _length);
            writer.Write("Width", _width);
            writer.Write("Height", _height);
            writer.Write("Unit", _unit);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "Dimensions", this);
        }

    public Dimensions (decimal length,decimal width,decimal height,string unit) : base() {
        this._length = length;
        this._width = width;
        this._height = height;
        this._unit = unit;
    }

        public Dimensions() : base()
        {
        }
    }
}
