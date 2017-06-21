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
    ///  An object that can read/write from MwsReader/MwsWriter
    /// </summary>
    public interface IMwsObject
    {
        /// <summary>
        /// Read from a reader not including any enclosing tags/markers.
        /// <para>
        /// For XML reads inner tags for elements but not the enclosing tag. This
        /// method will read attributes if the reader is positioned on a start tag
        /// otherwise it will not act as if no attributes were present.
        /// </summary>
        /// <param name="r">The reader to read from.</param>
        void ReadFragmentFrom(IMwsReader r);

        /// <summary>
        /// Write self to an XML object representation
        /// This includes begin tag, attributes, inner tags, and end tag.
        /// </summary>
        /// <returns>The XML representation</returns>
        string ToXML();
        
        /// <summary>
        /// Render self to an XML fragment.
        /// This includes the inner tags of the full XML representation, but not the outer tag or any attributes
        /// </summary>
        /// <returns>The XML fragment</returns>
        string ToXMLFragment();

        /// <summary>
        /// Write the inner contents to a writer. 
        /// Attributes are only written if the writer is positioned to accept attributes. 
        /// Then the inner values are written. No begin or end markers are written.
        /// </summary>
        /// <param name="w">The writer to write to</param>
        void WriteFragmentTo(IMwsWriter w);

        /// <summary>
        /// Write the entire object to a writer.
        /// This includes the beginning marker, attribute values, inner contents, and ending marker.
        /// </summary>
        /// <param name="s">The writer to write to</param>
        void WriteTo(IMwsWriter w);
    }
}
