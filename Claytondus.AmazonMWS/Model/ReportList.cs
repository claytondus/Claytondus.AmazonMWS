/******************************************************************************* 
 *  Copyright 2008 Amazon Technologies, Inc.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 *    __  _    _  ___ 
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 * 
 *  Marketplace Web Service CSharp Library
 *  API Version: 2009-01-01
 *  Generated: Fri Feb 13 19:54:50 PST 2009 
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
    public class ReportList
    {
    
        private  List<Report> reportField;


        /// <summary>
        /// Gets and sets the Report property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Report")]
        public List<Report> Report
        {
            get
            {
                if (this.reportField == null)
                {
                    this.reportField = new List<Report>();
                }
                return this.reportField;
            }
            set { this.reportField =  value; }
        }



        /// <summary>
        /// Sets the Report property
        /// </summary>
        /// <param name="list">Report property</param>
        /// <returns>this instance</returns>
        public ReportList WithReport(params Report[] list)
        {
            foreach (Report item in list)
            {
                Report.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks if Report property is set
        /// </summary>
        /// <returns>true if Report property is set</returns>
        public Boolean IsSetReport()
        {
            return (Report.Count > 0);
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
            List<Report> reportList = this.Report;
            foreach (Report report in reportList) {
                xml.Append("<Report>");
                xml.Append(report.ToXMLFragment());
                xml.Append("</Report>");
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