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
 * Address
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
    public class Address : AbstractMwsObject
    {

        private string _name;
        private string _addressLine1;
        private string _addressLine2;
        private string _districtOrCounty;
        private string _city;
        private string _stateOrProvinceCode;
        private string _countryCode;
        private string _postalCode;

        /// <summary>
        /// Gets and sets the Name property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>
        /// Sets the Name property.
        /// </summary>
        /// <param name="name">Name property.</param>
        /// <returns>this instance.</returns>
        public Address WithName(string name)
        {
            this._name = name;
            return this;
        }

        /// <summary>
        /// Checks if Name property is set.
        /// </summary>
        /// <returns>true if Name property is set.</returns>
        public bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the AddressLine1 property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AddressLine1")]
        public string AddressLine1
        {
            get { return this._addressLine1; }
            set { this._addressLine1 = value; }
        }

        /// <summary>
        /// Sets the AddressLine1 property.
        /// </summary>
        /// <param name="addressLine1">AddressLine1 property.</param>
        /// <returns>this instance.</returns>
        public Address WithAddressLine1(string addressLine1)
        {
            this._addressLine1 = addressLine1;
            return this;
        }

        /// <summary>
        /// Checks if AddressLine1 property is set.
        /// </summary>
        /// <returns>true if AddressLine1 property is set.</returns>
        public bool IsSetAddressLine1()
        {
            return this._addressLine1 != null;
        }

        /// <summary>
        /// Gets and sets the AddressLine2 property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AddressLine2")]
        public string AddressLine2
        {
            get { return this._addressLine2; }
            set { this._addressLine2 = value; }
        }

        /// <summary>
        /// Sets the AddressLine2 property.
        /// </summary>
        /// <param name="addressLine2">AddressLine2 property.</param>
        /// <returns>this instance.</returns>
        public Address WithAddressLine2(string addressLine2)
        {
            this._addressLine2 = addressLine2;
            return this;
        }

        /// <summary>
        /// Checks if AddressLine2 property is set.
        /// </summary>
        /// <returns>true if AddressLine2 property is set.</returns>
        public bool IsSetAddressLine2()
        {
            return this._addressLine2 != null;
        }

        /// <summary>
        /// Gets and sets the DistrictOrCounty property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DistrictOrCounty")]
        public string DistrictOrCounty
        {
            get { return this._districtOrCounty; }
            set { this._districtOrCounty = value; }
        }

        /// <summary>
        /// Sets the DistrictOrCounty property.
        /// </summary>
        /// <param name="districtOrCounty">DistrictOrCounty property.</param>
        /// <returns>this instance.</returns>
        public Address WithDistrictOrCounty(string districtOrCounty)
        {
            this._districtOrCounty = districtOrCounty;
            return this;
        }

        /// <summary>
        /// Checks if DistrictOrCounty property is set.
        /// </summary>
        /// <returns>true if DistrictOrCounty property is set.</returns>
        public bool IsSetDistrictOrCounty()
        {
            return this._districtOrCounty != null;
        }

        /// <summary>
        /// Gets and sets the City property.
        /// </summary>
        [XmlElementAttribute(ElementName = "City")]
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
        public Address WithCity(string city)
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
        /// Gets and sets the StateOrProvinceCode property.
        /// </summary>
        [XmlElementAttribute(ElementName = "StateOrProvinceCode")]
        public string StateOrProvinceCode
        {
            get { return this._stateOrProvinceCode; }
            set { this._stateOrProvinceCode = value; }
        }

        /// <summary>
        /// Sets the StateOrProvinceCode property.
        /// </summary>
        /// <param name="stateOrProvinceCode">StateOrProvinceCode property.</param>
        /// <returns>this instance.</returns>
        public Address WithStateOrProvinceCode(string stateOrProvinceCode)
        {
            this._stateOrProvinceCode = stateOrProvinceCode;
            return this;
        }

        /// <summary>
        /// Checks if StateOrProvinceCode property is set.
        /// </summary>
        /// <returns>true if StateOrProvinceCode property is set.</returns>
        public bool IsSetStateOrProvinceCode()
        {
            return this._stateOrProvinceCode != null;
        }

        /// <summary>
        /// Gets and sets the CountryCode property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CountryCode")]
        public string CountryCode
        {
            get { return this._countryCode; }
            set { this._countryCode = value; }
        }

        /// <summary>
        /// Sets the CountryCode property.
        /// </summary>
        /// <param name="countryCode">CountryCode property.</param>
        /// <returns>this instance.</returns>
        public Address WithCountryCode(string countryCode)
        {
            this._countryCode = countryCode;
            return this;
        }

        /// <summary>
        /// Checks if CountryCode property is set.
        /// </summary>
        /// <returns>true if CountryCode property is set.</returns>
        public bool IsSetCountryCode()
        {
            return this._countryCode != null;
        }

        /// <summary>
        /// Gets and sets the PostalCode property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PostalCode")]
        public string PostalCode
        {
            get { return this._postalCode; }
            set { this._postalCode = value; }
        }

        /// <summary>
        /// Sets the PostalCode property.
        /// </summary>
        /// <param name="postalCode">PostalCode property.</param>
        /// <returns>this instance.</returns>
        public Address WithPostalCode(string postalCode)
        {
            this._postalCode = postalCode;
            return this;
        }

        /// <summary>
        /// Checks if PostalCode property is set.
        /// </summary>
        /// <returns>true if PostalCode property is set.</returns>
        public bool IsSetPostalCode()
        {
            return this._postalCode != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _name = reader.Read<string>("Name");
            _addressLine1 = reader.Read<string>("AddressLine1");
            _addressLine2 = reader.Read<string>("AddressLine2");
            _districtOrCounty = reader.Read<string>("DistrictOrCounty");
            _city = reader.Read<string>("City");
            _stateOrProvinceCode = reader.Read<string>("StateOrProvinceCode");
            _countryCode = reader.Read<string>("CountryCode");
            _postalCode = reader.Read<string>("PostalCode");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Name", _name);
            writer.Write("AddressLine1", _addressLine1);
            writer.Write("AddressLine2", _addressLine2);
            writer.Write("DistrictOrCounty", _districtOrCounty);
            writer.Write("City", _city);
            writer.Write("StateOrProvinceCode", _stateOrProvinceCode);
            writer.Write("CountryCode", _countryCode);
            writer.Write("PostalCode", _postalCode);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "Address", this);
        }

    public Address (string name,string addressLine1,string city,string countryCode) : base() {
        this._name = name;
        this._addressLine1 = addressLine1;
        this._city = city;
        this._countryCode = countryCode;
    }

        public Address() : base()
        {
        }
    }
}
