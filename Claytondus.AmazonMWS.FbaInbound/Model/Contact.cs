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
 * Contact
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
    public class Contact : AbstractMwsObject
    {

        private string _name;
        private string _phone;
        private string _email;
        private string _fax;

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
        public Contact WithName(string name)
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
        /// Gets and sets the Phone property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Phone")]
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
        public Contact WithPhone(string phone)
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

        /// <summary>
        /// Gets and sets the Email property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Email")]
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
        public Contact WithEmail(string email)
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
        /// Gets and sets the Fax property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Fax")]
        public string Fax
        {
            get { return this._fax; }
            set { this._fax = value; }
        }

        /// <summary>
        /// Sets the Fax property.
        /// </summary>
        /// <param name="fax">Fax property.</param>
        /// <returns>this instance.</returns>
        public Contact WithFax(string fax)
        {
            this._fax = fax;
            return this;
        }

        /// <summary>
        /// Checks if Fax property is set.
        /// </summary>
        /// <returns>true if Fax property is set.</returns>
        public bool IsSetFax()
        {
            return this._fax != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _name = reader.Read<string>("Name");
            _phone = reader.Read<string>("Phone");
            _email = reader.Read<string>("Email");
            _fax = reader.Read<string>("Fax");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Name", _name);
            writer.Write("Phone", _phone);
            writer.Write("Email", _email);
            writer.Write("Fax", _fax);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "Contact", this);
        }

    public Contact (string name,string phone,string email) : base() {
        this._name = name;
        this._phone = phone;
        this._email = email;
    }

        public Contact() : base()
        {
        }
    }
}
