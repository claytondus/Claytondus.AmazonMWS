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
using System.Xml;

namespace Claytondus.AmazonMWS.Runtime
{
    public interface IMwsWriter
    {
        /// <summary>
        /// Write a begin tag for an object value. Can be nested.
        /// Must follow with matching endObject call eventually. 
        /// <para>For JSON writes <code>[,]name : {</code> or <code>{</code></para>
        /// <para>For XML writes <code> &lt;name&gt; </code>
        /// </summary>
        /// <param name="name"></param>
        void BeginObject(string name);
      
        /// <summary>
        /// Close or dispose the writer
        /// </summary>
        void close();

        /// <summary>
        /// End a list. Must match previous begin list. 
        /// </summary>
        /// <param name="label"></param>
        //void EndList(string label);
        void EndObject(string name);

        /// <summary>
        /// Write out a value with proper escaping and delimiters for the context. 
        /// May be called nested in BeginList/EndList or beginObject/EndObject.
        /// The value must be one of: null, Boolean, Number, string, MwsObject.
        /// </summary>
        /// <param name="name">The label for the value.</param>
        /// <param name="value">The value to output.</param>
        void Write(string name, object value);

        /// <summary>
        /// Write out an attribute value with proper escaping and delimiters for the context. 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        void WriteAttribute(string name, object value);
        
        /// <summary>
        /// Write a list using sibling elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="list"></param>
        void WriteList<T>(string name, ICollection<T> list);

        /// <summary>
        /// Write a list using child elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="list"></param>
        void WriteList<T>(string name, string memberName, ICollection<T> list);

        /// <summary>
        /// Write out the given value as raw value at the current position
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        void WriteValue(object value);

        /// <summary>
        /// Writes out the object along with namespace. 
        /// <para>Equivalent to calling BeginObject(name);
        ///                             WriteAttribute("xmlns", namespc);
        ///                             mwsObject.WriteFragmentTo(this);
        ///                             EndObject(name);
        /// </para>
        /// </summary>
        /// <param name="namespc"></param>
        /// <param name="name"></param>
        /// <param name="mwsObject"></param>
        void Write(string namespc, string name, IMwsObject mwsObject);

        /// <summary>
        /// Write a list of arbitrary elements.
        /// </summary>
        /// <param name="elements">Collection of w3c DOM elements to write</param>
        void WriteAny(ICollection<XmlElement> elements);
    }
}
