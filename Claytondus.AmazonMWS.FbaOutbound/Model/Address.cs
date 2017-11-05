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
    public class Address : AbstractMwsObject
    {

        private string _name;
        private string _line1;
        private string _line2;
        private string _line3;
        private string _districtOrCounty;
        private string _city;
        private string _stateOrProvinceCode;
        private string _countryCode;
        private string _postalCode;
        private string _phoneNumber;

        /// <summary>
        /// Gets and sets the Name property.
        /// </summary>
        [XmlElement(ElementName = "Name")]
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
        /// Gets and sets the Line1 property.
        /// </summary>
        [XmlElement(ElementName = "Line1")]
        public string Line1
        {
            get { return this._line1; }
            set { this._line1 = value; }
        }

        /// <summary>
        /// Sets the Line1 property.
        /// </summary>
        /// <param name="line1">Line1 property.</param>
        /// <returns>this instance.</returns>
        public Address WithLine1(string line1)
        {
            this._line1 = line1;
            return this;
        }

        /// <summary>
        /// Checks if Line1 property is set.
        /// </summary>
        /// <returns>true if Line1 property is set.</returns>
        public bool IsSetLine1()
        {
            return this._line1 != null;
        }

        /// <summary>
        /// Gets and sets the Line2 property.
        /// </summary>
        [XmlElement(ElementName = "Line2")]
        public string Line2
        {
            get { return this._line2; }
            set { this._line2 = value; }
        }

        /// <summary>
        /// Sets the Line2 property.
        /// </summary>
        /// <param name="line2">Line2 property.</param>
        /// <returns>this instance.</returns>
        public Address WithLine2(string line2)
        {
            this._line2 = line2;
            return this;
        }

        /// <summary>
        /// Checks if Line2 property is set.
        /// </summary>
        /// <returns>true if Line2 property is set.</returns>
        public bool IsSetLine2()
        {
            return this._line2 != null;
        }

        /// <summary>
        /// Gets and sets the Line3 property.
        /// </summary>
        [XmlElement(ElementName = "Line3")]
        public string Line3
        {
            get { return this._line3; }
            set { this._line3 = value; }
        }

        /// <summary>
        /// Sets the Line3 property.
        /// </summary>
        /// <param name="line3">Line3 property.</param>
        /// <returns>this instance.</returns>
        public Address WithLine3(string line3)
        {
            this._line3 = line3;
            return this;
        }

        /// <summary>
        /// Checks if Line3 property is set.
        /// </summary>
        /// <returns>true if Line3 property is set.</returns>
        public bool IsSetLine3()
        {
            return this._line3 != null;
        }

        /// <summary>
        /// Gets and sets the DistrictOrCounty property.
        /// </summary>
        [XmlElement(ElementName = "DistrictOrCounty")]
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
        [XmlElement(ElementName = "StateOrProvinceCode")]
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
        [XmlElement(ElementName = "CountryCode")]
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
        [XmlElement(ElementName = "PostalCode")]
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

        /// <summary>
        /// Gets and sets the PhoneNumber property.
        /// </summary>
        [XmlElement(ElementName = "PhoneNumber")]
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        /// <summary>
        /// Sets the PhoneNumber property.
        /// </summary>
        /// <param name="phoneNumber">PhoneNumber property.</param>
        /// <returns>this instance.</returns>
        public Address WithPhoneNumber(string phoneNumber)
        {
            this._phoneNumber = phoneNumber;
            return this;
        }

        /// <summary>
        /// Checks if PhoneNumber property is set.
        /// </summary>
        /// <returns>true if PhoneNumber property is set.</returns>
        public bool IsSetPhoneNumber()
        {
            return this._phoneNumber != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _name = reader.Read<string>("Name");
            _line1 = reader.Read<string>("Line1");
            _line2 = reader.Read<string>("Line2");
            _line3 = reader.Read<string>("Line3");
            _districtOrCounty = reader.Read<string>("DistrictOrCounty");
            _city = reader.Read<string>("City");
            _stateOrProvinceCode = reader.Read<string>("StateOrProvinceCode");
            _countryCode = reader.Read<string>("CountryCode");
            _postalCode = reader.Read<string>("PostalCode");
            _phoneNumber = reader.Read<string>("PhoneNumber");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Name", _name);
            writer.Write("Line1", _line1);
            writer.Write("Line2", _line2);
            writer.Write("Line3", _line3);
            writer.Write("DistrictOrCounty", _districtOrCounty);
            writer.Write("City", _city);
            writer.Write("StateOrProvinceCode", _stateOrProvinceCode);
            writer.Write("CountryCode", _countryCode);
            writer.Write("PostalCode", _postalCode);
            writer.Write("PhoneNumber", _phoneNumber);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "Address", this);
        }

    public Address (string name,string line1,string stateOrProvinceCode,string countryCode) : base() {
        this._name = name;
        this._line1 = line1;
        this._stateOrProvinceCode = stateOrProvinceCode;
        this._countryCode = countryCode;
    }

        public Address() : base()
        {
        }
    }
}
