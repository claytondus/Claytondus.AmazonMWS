/******************************************************************************* 
 * Copyright 2009-2012 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Marketplace Web Service Runtime Client Library
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Claytondus.AmazonMWS.Runtime
{
    /// <summary>
    /// Abstract implementation of MwsObject
    /// </summary>
    public abstract class AbstractMwsObject : IMwsObject
    {

        public string ToXML()
        {
            IMwsWriter writer = new MwsXmlBuilder();
            this.WriteTo(writer);
            return writer.ToString();
        }

        public string ToXMLFragment()
        {
            IMwsWriter writer = new MwsXmlBuilder(false, System.Xml.ConformanceLevel.Fragment);
            this.WriteFragmentTo(writer);
            return writer.ToString();
        }

        public abstract void ReadFragmentFrom(IMwsReader r);

        public abstract void WriteFragmentTo(IMwsWriter w);

        public abstract void WriteTo(IMwsWriter w);
       
    }
}
