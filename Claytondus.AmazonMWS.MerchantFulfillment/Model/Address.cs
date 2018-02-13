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
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class Address : AbstractMwsObject
    {

        private string _name;
        private string _addressLine1;
        private string _addressLine2;
        private string _addressLine3;
        private string _districtOrCounty;
        private string _email;
        private string _city;
        private string _stateOrProvinceCode;
        private string _postalCode;
        private string _countryCode;
        private string _phone;

        /// <summary>
        /// Gets and sets the Name property.
        /// </summary>
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
        /// Gets and sets the AddressLine3 property.
        /// </summary>
        public string AddressLine3
        {
            get { return this._addressLine3; }
            set { this._addressLine3 = value; }
        }

        /// <summary>
        /// Sets the AddressLine3 property.
        /// </summary>
        /// <param name="addressLine3">AddressLine3 property.</param>
        /// <returns>this instance.</returns>
        public Address WithAddressLine3(string addressLine3)
        {
            this._addressLine3 = addressLine3;
            return this;
        }

        /// <summary>
        /// Checks if AddressLine3 property is set.
        /// </summary>
        /// <returns>true if AddressLine3 property is set.</returns>
        public bool IsSetAddressLine3()
        {
            return this._addressLine3 != null;
        }

        /// <summary>
        /// Gets and sets the DistrictOrCounty property.
        /// </summary>
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
        /// Gets and sets the Email property.
        /// </summary>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        /// <summary>
        /// Sets the Email property.
        /// </summary>
        /// <param name="email">Email property.</param>
        /// <returns>this instance.</returns>
        public Address WithEmail(string email)
        {
            this._email = email;
            return this;
        }

        /// <summary>
        /// Checks if Email property is set.
        /// </summary>
        /// <returns>true if Email property is set.</returns>
        public bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the City property.
        /// </summary>
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
        /// Gets and sets the PostalCode property.
        /// </summary>
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
        /// Gets and sets the CountryCode property.
        /// </summary>
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
        /// Gets and sets the Phone property.
        /// </summary>
        public string Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }

        /// <summary>
        /// Sets the Phone property.
        /// </summary>
        /// <param name="phone">Phone property.</param>
        /// <returns>this instance.</returns>
        public Address WithPhone(string phone)
        {
            this._phone = phone;
            return this;
        }

        /// <summary>
        /// Checks if Phone property is set.
        /// </summary>
        /// <returns>true if Phone property is set.</returns>
        public bool IsSetPhone()
        {
            return this._phone != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _name = reader.Read<string>("Name");
            _addressLine1 = reader.Read<string>("AddressLine1");
            _addressLine2 = reader.Read<string>("AddressLine2");
            _addressLine3 = reader.Read<string>("AddressLine3");
            _districtOrCounty = reader.Read<string>("DistrictOrCounty");
            _email = reader.Read<string>("Email");
            _city = reader.Read<string>("City");
            _stateOrProvinceCode = reader.Read<string>("StateOrProvinceCode");
            _postalCode = reader.Read<string>("PostalCode");
            _countryCode = reader.Read<string>("CountryCode");
            _phone = reader.Read<string>("Phone");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Name", _name);
            writer.Write("AddressLine1", _addressLine1);
            writer.Write("AddressLine2", _addressLine2);
            writer.Write("AddressLine3", _addressLine3);
            writer.Write("DistrictOrCounty", _districtOrCounty);
            writer.Write("Email", _email);
            writer.Write("City", _city);
            writer.Write("StateOrProvinceCode", _stateOrProvinceCode);
            writer.Write("PostalCode", _postalCode);
            writer.Write("CountryCode", _countryCode);
            writer.Write("Phone", _phone);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "Address", this);
        }

    public Address (string name,string addressLine1,string email,string city,string postalCode,string countryCode,string phone) : base() {
        this._name = name;
        this._addressLine1 = addressLine1;
        this._email = email;
        this._city = city;
        this._postalCode = postalCode;
        this._countryCode = countryCode;
        this._phone = phone;
    }

        public Address() : base()
        {
        }
    }
}
