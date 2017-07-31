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
 * Message
 * API Version: 2013-09-01
 * Library Version: 2017-02-22
 * Generated: Thu Mar 02 12:41:05 UTC 2017
 */


using System;
using System.Xml;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Orders.Model
{
    public class Message : AbstractMwsObject
    {

        private string _locale;
        private string _text;

        /// <summary>
        /// Gets and sets the Locale property.
        /// </summary>
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        /// <summary>
        /// Sets the Locale property.
        /// </summary>
        /// <param name="locale">Locale property.</param>
        /// <returns>this instance.</returns>
        public Message WithLocale(string locale)
        {
            this._locale = locale;
            return this;
        }

        /// <summary>
        /// Checks if Locale property is set.
        /// </summary>
        /// <returns>true if Locale property is set.</returns>
        public bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the Text property.
        /// </summary>
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        /// <summary>
        /// Sets the Text property.
        /// </summary>
        /// <param name="text">Text property.</param>
        /// <returns>this instance.</returns>
        public Message WithText(string text)
        {
            this._text = text;
            return this;
        }

        /// <summary>
        /// Checks if Text property is set.
        /// </summary>
        /// <returns>true if Text property is set.</returns>
        public bool IsSetText()
        {
            return this._text != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _locale = reader.Read<string>("Locale");
            _text = reader.Read<string>("Text");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Locale", _locale);
            writer.Write("Text", _text);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "Message", this);
        }


        public Message() : base()
        {
        }
    }
}
