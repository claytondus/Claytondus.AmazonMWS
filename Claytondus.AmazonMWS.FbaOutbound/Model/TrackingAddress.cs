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
 * Tracking Address
 * API Version: 2010-10-01
 * Library Version: 2016-10-19
 * Generated: Wed Oct 19 08:37:54 PDT 2016
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaOutbound.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", IsNullable = false)]
    public class TrackingAddress : AbstractMwsObject
    {

        private string _city;
        private string _state;
        private string _country;

        /// <summary>
        /// Gets and sets the City property.
        /// </summary>
        [XmlElement(ElementName = "City")]
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }

        /// <summary>
        /// Sets the City property.
        /// </summary>
        /// <param name="city">City property.</param>
        /// <returns>this instance.</returns>
        public TrackingAddress WithCity(string city)
        {
            this._city = city;
            return this;
        }

        /// <summary>
        /// Checks if City property is set.
        /// </summary>
        /// <returns>true if City property is set.</returns>
        public bool IsSetCity()
        {
            return this._city != null;
        }

        /// <summary>
        /// Gets and sets the State property.
        /// </summary>
        [XmlElement(ElementName = "State")]
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
        public TrackingAddress WithState(string state)
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
        [XmlElement(ElementName = "Country")]
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
        public TrackingAddress WithCountry(string country)
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
            _city = reader.Read<string>("City");
            _state = reader.Read<string>("State");
            _country = reader.Read<string>("Country");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("City", _city);
            writer.Write("State", _state);
            writer.Write("Country", _country);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "TrackingAddress", this);
        }


        public TrackingAddress() : base()
        {
        }
    }
}
