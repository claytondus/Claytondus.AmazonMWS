/******************************************************************************* 
 *  Copyright 2009 Amazon Services.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 * 
 *  Marketplace Web Service CSharp Library
 *  API Version: 2009-01-01
 *  Generated: Mon Mar 16 17:31:42 PDT 2009 
 * 
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;


namespace MarketplaceWebService.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRootAttribute(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    public class TypeList
    {
    
        private List<String> typeField;


        /// <summary>
        /// Gets and sets the Type property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Type")]
        public List<String> Type
        {
            get
            {
                if (this.typeField == null)
                {
                    this.typeField = new List<String>();
                }
                return this.typeField;
            }
            set { this.typeField =  value; }
        }



        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="list">Type property</param>
        /// <returns>this instance</returns>
        public TypeList WithType(params String[] list)
        {
            foreach (String item in list)
            {
                Type.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks of Type property is set
        /// </summary>
        /// <returns>true if Type property is set</returns>
        public Boolean IsSetType()
        {
            return (Type.Count > 0);
        }






        /// <summary>
        /// XML fragment representation of this object
        /// </summary>
        /// <returns>XML fragment for this object.</returns>
        /// <remarks>
        /// Name for outer tag expected to be set by calling method. 
        /// This fragment returns inner properties representation only
        /// </remarks>


        protected internal String ToXMLFragment() {
            StringBuilder xml = new StringBuilder();
            List<String> typeList  =  this.Type;
            foreach (String type in typeList) { 
                xml.Append("<Type>");
                xml.Append(EscapeXML(type));
                xml.Append("</Type>");
            }	
            return xml.ToString();
        }

        /**
         * 
         * Escape XML special characters
         */
        private String EscapeXML(String str) {
            StringBuilder sb = new StringBuilder();
            foreach (Char c in str)
            {
                switch (c) {
                case '&':
                    sb.Append("&amp;");
                    break;
                case '<':
                    sb.Append("&lt;");
                    break;
                case '>':
                    sb.Append("&gt;");
                    break;
                case '\'':
                    sb.Append("&#039;");
                    break;
                case '"':
                    sb.Append("&quot;");
                    break;
                default:
                    sb.Append(c);
                    break;
                }
            }
            return sb.ToString();
        }



    }

}
