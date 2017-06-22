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
 * Error
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
    public class Error : AbstractMwsObject
    {

        private string _type;
        private string _code;
        private string _message;
        private ErrorDetail _detail;

        /// <summary>
        /// Gets and sets the Type property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Type")]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        /// <summary>
        /// Sets the Type property.
        /// </summary>
        /// <param name="type">Type property.</param>
        /// <returns>this instance.</returns>
        public Error WithType(string type)
        {
            this._type = type;
            return this;
        }

        /// <summary>
        /// Checks if Type property is set.
        /// </summary>
        /// <returns>true if Type property is set.</returns>
        public bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the Code property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Code")]
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        /// <summary>
        /// Sets the Code property.
        /// </summary>
        /// <param name="code">Code property.</param>
        /// <returns>this instance.</returns>
        public Error WithCode(string code)
        {
            this._code = code;
            return this;
        }

        /// <summary>
        /// Checks if Code property is set.
        /// </summary>
        /// <returns>true if Code property is set.</returns>
        public bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the Message property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Message")]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        /// <summary>
        /// Sets the Message property.
        /// </summary>
        /// <param name="message">Message property.</param>
        /// <returns>this instance.</returns>
        public Error WithMessage(string message)
        {
            this._message = message;
            return this;
        }

        /// <summary>
        /// Checks if Message property is set.
        /// </summary>
        /// <returns>true if Message property is set.</returns>
        public bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the Detail property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Detail")]
        public ErrorDetail Detail
        {
            get { return this._detail; }
            set { this._detail = value; }
        }

        /// <summary>
        /// Sets the Detail property.
        /// </summary>
        /// <param name="detail">Detail property.</param>
        /// <returns>this instance.</returns>
        public Error WithDetail(ErrorDetail detail)
        {
            this._detail = detail;
            return this;
        }

        /// <summary>
        /// Checks if Detail property is set.
        /// </summary>
        /// <returns>true if Detail property is set.</returns>
        public bool IsSetDetail()
        {
            return this._detail != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _type = reader.Read<string>("Type");
            _code = reader.Read<string>("Code");
            _message = reader.Read<string>("Message");
            _detail = reader.Read<ErrorDetail>("Detail");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Type", _type);
            writer.Write("Code", _code);
            writer.Write("Message", _message);
            writer.Write("Detail", _detail);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "Error", this);
        }

    public Error (string type,string code,string message,ErrorDetail detail) : base() {
        this._type = type;
        this._code = code;
        this._message = message;
        this._detail = detail;
    }

        public Error() : base()
        {
        }
    }
}
