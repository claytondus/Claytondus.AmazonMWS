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
    public class CancelFeedSubmissionsResult
    {
    
        private Decimal? countField;

        private  List<FeedSubmissionInfo> feedSubmissionInfoField;


        /// <summary>
        /// Gets and sets the Count property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Count")]
        public Decimal Count
        {
            get { return this.countField.GetValueOrDefault() ; }
            set { this.countField= value; }
        }



        /// <summary>
        /// Sets the Count property
        /// </summary>
        /// <param name="count">Count property</param>
        /// <returns>this instance</returns>
        public CancelFeedSubmissionsResult WithCount(Decimal count)
        {
            this.countField = count;
            return this;
        }



        /// <summary>
        /// Checks if Count property is set
        /// </summary>
        /// <returns>true if Count property is set</returns>
        public Boolean IsSetCount()
        {
            return  this.countField.HasValue;

        }


        /// <summary>
        /// Gets and sets the FeedSubmissionInfo property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeedSubmissionInfo")]
        public List<FeedSubmissionInfo> FeedSubmissionInfo
        {
            get
            {
                if (this.feedSubmissionInfoField == null)
                {
                    this.feedSubmissionInfoField = new List<FeedSubmissionInfo>();
                }
                return this.feedSubmissionInfoField;
            }
            set { this.feedSubmissionInfoField =  value; }
        }



        /// <summary>
        /// Sets the FeedSubmissionInfo property
        /// </summary>
        /// <param name="list">FeedSubmissionInfo property</param>
        /// <returns>this instance</returns>
        public CancelFeedSubmissionsResult WithFeedSubmissionInfo(params FeedSubmissionInfo[] list)
        {
            foreach (FeedSubmissionInfo item in list)
            {
                FeedSubmissionInfo.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks if FeedSubmissionInfo property is set
        /// </summary>
        /// <returns>true if FeedSubmissionInfo property is set</returns>
        public Boolean IsSetFeedSubmissionInfo()
        {
            return (FeedSubmissionInfo.Count > 0);
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
            if (IsSetCount()) {
                xml.Append("<Count>");
                xml.Append(this.Count);
                xml.Append("</Count>");
            }
            List<FeedSubmissionInfo> feedSubmissionInfoList = this.FeedSubmissionInfo;
            foreach (FeedSubmissionInfo feedSubmissionInfo in feedSubmissionInfoList) {
                xml.Append("<FeedSubmissionInfo>");
                xml.Append(feedSubmissionInfo.ToXMLFragment());
                xml.Append("</FeedSubmissionInfo>");
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
