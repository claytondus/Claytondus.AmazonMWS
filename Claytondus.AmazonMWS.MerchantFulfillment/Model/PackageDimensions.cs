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
 * Package Dimensions
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class PackageDimensions : AbstractMwsObject
    {

        private decimal? _length;
        private decimal? _width;
        private decimal? _height;
        private string _unit;
        private string _predefinedPackageDimensions;

        /// <summary>
        /// Gets and sets the Length property.
        /// </summary>
        public decimal Length
        {
            get { return this._length.GetValueOrDefault(); }
            set { this._length = value; }
        }

        /// <summary>
        /// Sets the Length property.
        /// </summary>
        /// <param name="length">Length property.</param>
        /// <returns>this instance.</returns>
        public PackageDimensions WithLength(decimal length)
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
        public decimal Width
        {
            get { return this._width.GetValueOrDefault(); }
            set { this._width = value; }
        }

        /// <summary>
        /// Sets the Width property.
        /// </summary>
        /// <param name="width">Width property.</param>
        /// <returns>this instance.</returns>
        public PackageDimensions WithWidth(decimal width)
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
        public decimal Height
        {
            get { return this._height.GetValueOrDefault(); }
            set { this._height = value; }
        }

        /// <summary>
        /// Sets the Height property.
        /// </summary>
        /// <param name="height">Height property.</param>
        /// <returns>this instance.</returns>
        public PackageDimensions WithHeight(decimal height)
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
        public PackageDimensions WithUnit(string unit)
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

        /// <summary>
        /// Gets and sets the PredefinedPackageDimensions property.
        /// </summary>
        public string PredefinedPackageDimensions
        {
            get { return this._predefinedPackageDimensions; }
            set { this._predefinedPackageDimensions = value; }
        }

        /// <summary>
        /// Sets the PredefinedPackageDimensions property.
        /// </summary>
        /// <param name="predefinedPackageDimensions">PredefinedPackageDimensions property.</param>
        /// <returns>this instance.</returns>
        public PackageDimensions WithPredefinedPackageDimensions(string predefinedPackageDimensions)
        {
            this._predefinedPackageDimensions = predefinedPackageDimensions;
            return this;
        }

        /// <summary>
        /// Checks if PredefinedPackageDimensions property is set.
        /// </summary>
        /// <returns>true if PredefinedPackageDimensions property is set.</returns>
        public bool IsSetPredefinedPackageDimensions()
        {
            return this._predefinedPackageDimensions != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _length = reader.Read<decimal?>("Length");
            _width = reader.Read<decimal?>("Width");
            _height = reader.Read<decimal?>("Height");
            _unit = reader.Read<string>("Unit");
            _predefinedPackageDimensions = reader.Read<string>("PredefinedPackageDimensions");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Length", _length);
            writer.Write("Width", _width);
            writer.Write("Height", _height);
            writer.Write("Unit", _unit);
            writer.Write("PredefinedPackageDimensions", _predefinedPackageDimensions);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "PackageDimensions", this);
        }


        public PackageDimensions() : base()
        {
        }
    }
}
