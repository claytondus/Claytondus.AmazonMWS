/*******************************************************************************
 * Copyright 2009-2015 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Attribute Key Value
 * API Version: 2013-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:27:11 GMT 2015
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Subscriptions.Model
{
    public class AttributeKeyValue : AbstractMwsObject
    {

        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the Key property.
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        /// <summary>
        /// Sets the Key property.
        /// </summary>
        /// <param name="key">Key property.</param>
        /// <returns>this instance.</returns>
        public AttributeKeyValue WithKey(string key)
        {
            this._key = key;
            return this;
        }

        /// <summary>
        /// Checks if Key property is set.
        /// </summary>
        /// <returns>true if Key property is set.</returns>
        public bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the Value property.
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        /// <summary>
        /// Sets the Value property.
        /// </summary>
        /// <param name="value">Value property.</param>
        /// <returns>this instance.</returns>
        public AttributeKeyValue WithValue(string value)
        {
            this._value = value;
            return this;
        }

        /// <summary>
        /// Checks if Value property is set.
        /// </summary>
        /// <returns>true if Value property is set.</returns>
        public bool IsSetValue()
        {
            return this._value != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _key = reader.Read<string>("Key");
            _value = reader.Read<string>("Value");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Key", _key);
            writer.Write("Value", _value);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Subscriptions/2013-07-01", "AttributeKeyValue", this);
        }

        public AttributeKeyValue() : base()
        {
        }
    }
}
