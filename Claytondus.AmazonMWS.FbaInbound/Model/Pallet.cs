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
 * Pallet
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
    public class Pallet : AbstractMwsObject
    {

        private Dimensions _dimensions;
        private Weight _weight;
        private bool _isStacked;

        /// <summary>
        /// Gets and sets the Dimensions property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Dimensions")]
        public Dimensions Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        /// <summary>
        /// Sets the Dimensions property.
        /// </summary>
        /// <param name="dimensions">Dimensions property.</param>
        /// <returns>this instance.</returns>
        public Pallet WithDimensions(Dimensions dimensions)
        {
            this._dimensions = dimensions;
            return this;
        }

        /// <summary>
        /// Checks if Dimensions property is set.
        /// </summary>
        /// <returns>true if Dimensions property is set.</returns>
        public bool IsSetDimensions()
        {
            return this._dimensions != null;
        }

        /// <summary>
        /// Gets and sets the Weight property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Weight")]
        public Weight Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        /// <summary>
        /// Sets the Weight property.
        /// </summary>
        /// <param name="weight">Weight property.</param>
        /// <returns>this instance.</returns>
        public Pallet WithWeight(Weight weight)
        {
            this._weight = weight;
            return this;
        }

        /// <summary>
        /// Checks if Weight property is set.
        /// </summary>
        /// <returns>true if Weight property is set.</returns>
        public bool IsSetWeight()
        {
            return this._weight != null;
        }

        /// <summary>
        /// Gets and sets the IsStacked property.
        /// </summary>
        [XmlElementAttribute(ElementName = "IsStacked")]
        public bool IsStacked
        {
            get { return this._isStacked; }
            set { this._isStacked = value; }
        }

        /// <summary>
        /// Sets the IsStacked property.
        /// </summary>
        /// <param name="isStacked">IsStacked property.</param>
        /// <returns>this instance.</returns>
        public Pallet WithIsStacked(bool isStacked)
        {
            this._isStacked = isStacked;
            return this;
        }

        /// <summary>
        /// Checks if IsStacked property is set.
        /// </summary>
        /// <returns>true if IsStacked property is set.</returns>
        public bool IsSetIsStacked()
        {
            return this._isStacked != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _dimensions = reader.Read<Dimensions>("Dimensions");
            _weight = reader.Read<Weight>("Weight");
            _isStacked = reader.Read<bool>("IsStacked");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Dimensions", _dimensions);
            writer.Write("Weight", _weight);
            writer.Write("IsStacked", _isStacked);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "Pallet", this);
        }

    public Pallet (Dimensions dimensions,bool isStacked) : base() {
        this._dimensions = dimensions;
        this._isStacked = isStacked;
    }

        public Pallet() : base()
        {
        }
    }
}
