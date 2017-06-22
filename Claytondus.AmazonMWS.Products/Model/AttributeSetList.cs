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
 * Attribute Set List
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */


using System;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Products.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false)]
    public class AttributeSetList : AbstractMwsObject
    {

        private List<Object> _any;

        /// <summary>
        /// Gets and sets the Any property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Any")]
        public List<Object> Any
        {
            get
            {
                if(this._any == null)
                {
                    this._any = new List<Object>();
                }
                return this._any;
            }
            set { this._any = value; }
        }

        /// <summary>
        /// Sets the Any property.
        /// </summary>
        /// <param name="any">Any property.</param>
        /// <returns>this instance.</returns>
        public AttributeSetList WithAny(Object[] any)
        {
            this._any.AddRange(any);
            return this;
        }

        /// <summary>
        /// Checks if Any property is set.
        /// </summary>
        /// <returns>true if Any property is set.</returns>
        public bool IsSetAny()
        {
            return this.Any.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _any = new List<object>();
            foreach (XmlElement element in reader.ReadAny())
            {
                _any.Add(element);
            }
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            List<XmlElement> temp = new List<XmlElement>();
            foreach (object element in _any)
            {
                temp.Add((XmlElement)element);
            }
            writer.WriteAny(temp);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "AttributeSetList", this);
        }


        public AttributeSetList() : base()
        {
        }
    }
}
