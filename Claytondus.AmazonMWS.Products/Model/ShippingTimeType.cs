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
 * Shipping Time Type
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
    public class ShippingTimeType : AbstractMwsObject
    {

        private string _max;

        /// <summary>
        /// Gets and sets the Max property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Max")]
        public string Max
        {
            get { return this._max; }
            set { this._max = value; }
        }

        /// <summary>
        /// Sets the Max property.
        /// </summary>
        /// <param name="max">Max property.</param>
        /// <returns>this instance.</returns>
        public ShippingTimeType WithMax(string max)
        {
            this._max = max;
            return this;
        }

        /// <summary>
        /// Checks if Max property is set.
        /// </summary>
        /// <returns>true if Max property is set.</returns>
        public bool IsSetMax()
        {
            return this._max != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _max = reader.Read<string>("Max");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Max", _max);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "ShippingTimeType", this);
        }


        public ShippingTimeType() : base()
        {
        }
    }
}
