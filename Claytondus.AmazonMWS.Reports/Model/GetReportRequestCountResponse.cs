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
    public class GetReportRequestCountResponse
    {
    
        private  GetReportRequestCountResult getReportRequestCountResultField;
        private  ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the GetReportRequestCountResult property.
        /// </summary>
        [XmlElementAttribute(ElementName = "GetReportRequestCountResult")]
        public GetReportRequestCountResult GetReportRequestCountResult
        {
            get { return this.getReportRequestCountResultField ; }
            set { this.getReportRequestCountResultField = value; }
        }



        /// <summary>
        /// Sets the GetReportRequestCountResult property
        /// </summary>
        /// <param name="getReportRequestCountResult">GetReportRequestCountResult property</param>
        /// <returns>this instance</returns>
        public GetReportRequestCountResponse WithGetReportRequestCountResult(GetReportRequestCountResult getReportRequestCountResult)
        {
            this.getReportRequestCountResultField = getReportRequestCountResult;
            return this;
        }



        /// <summary>
        /// Checks if GetReportRequestCountResult property is set
        /// </summary>
        /// <returns>true if GetReportRequestCountResult property is set</returns>
        public Boolean IsSetGetReportRequestCountResult()
        {
            return this.getReportRequestCountResultField != null;
        }




        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this.responseMetadataField ; }
            set { this.responseMetadataField = value; }
        }



        /// <summary>
        /// Sets the ResponseMetadata property
        /// </summary>
        /// <param name="responseMetadata">ResponseMetadata property</param>
        /// <returns>this instance</returns>
        public GetReportRequestCountResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this.responseMetadataField = responseMetadata;
            return this;
        }



        /// <summary>
        /// Checks if ResponseMetadata property is set
        /// </summary>
        /// <returns>true if ResponseMetadata property is set</returns>
        public Boolean IsSetResponseMetadata()
        {
            return this.responseMetadataField != null;
        }






        /// <summary>
        /// XML Representation for this object
        /// </summary>
        /// <returns>XML String</returns>

        public String ToXML() {
            StringBuilder xml = new StringBuilder();
            xml.Append("<GetReportRequestCountResponse xmlns=\"http://mws.amazonaws.com/doc/2009-01-01/\">");
            if (IsSetGetReportRequestCountResult()) {
                GetReportRequestCountResult  getReportRequestCountResult = this.GetReportRequestCountResult;
                xml.Append("<GetReportRequestCountResult>");
                xml.Append(getReportRequestCountResult.ToXMLFragment());
                xml.Append("</GetReportRequestCountResult>");
            } 
            if (IsSetResponseMetadata()) {
                ResponseMetadata  responseMetadata = this.ResponseMetadata;
                xml.Append("<ResponseMetadata>");
                xml.Append(responseMetadata.ToXMLFragment());
                xml.Append("</ResponseMetadata>");
            } 
            xml.Append("</GetReportRequestCountResponse>");
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

        private ResponseHeaderMetadata responseHeaderMetadata;

        public ResponseHeaderMetadata ResponseHeaderMetadata
        {
          get { return responseHeaderMetadata; }
          set { this.responseHeaderMetadata = value; }
        }


    }

}
