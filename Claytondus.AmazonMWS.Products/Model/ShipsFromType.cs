/*******************************************************************************
 * Copyright 2009-2017 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Ships From Type
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Products.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false)]
    public class ShipsFromType : AbstractMwsObject
    {

        private string _state;
        private string _country;

        /// <summary>
        /// Gets and sets the State property.
        /// </summary>
        [XmlElementAttribute(ElementName = "State")]
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        /// <summary>
        /// Sets the State property.
        /// </summary>
        /// <param name="state">State property.</param>
        /// <returns>this instance.</returns>
        public ShipsFromType WithState(string state)
        {
            this._state = state;
            return this;
        }

        /// <summary>
        /// Checks if State property is set.
        /// </summary>
        /// <returns>true if State property is set.</returns>
        public bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the Country property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Country")]
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        /// <summary>
        /// Sets the Country property.
        /// </summary>
        /// <param name="country">Country property.</param>
        /// <returns>this instance.</returns>
        public ShipsFromType WithCountry(string country)
        {
            this._country = country;
            return this;
        }

        /// <summary>
        /// Checks if Country property is set.
        /// </summary>
        /// <returns>true if Country property is set.</returns>
        public bool IsSetCountry()
        {
            return this._country != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _state = reader.Read<string>("State");
            _country = reader.Read<string>("Country");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("State", _state);
            writer.Write("Country", _country);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "ShipsFromType", this);
        }


        public ShipsFromType() : base()
        {
        }
    }
}
