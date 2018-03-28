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
    public class GetFeedSubmissionListByNextTokenResult
    {
    
        private String nextTokenField;

        private Boolean? hasNextField;

        private  List<FeedSubmissionInfo> feedSubmissionInfoField;


        /// <summary>
        /// Gets and sets the NextToken property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextToken")]
        public String NextToken
        {
            get { return this.nextTokenField ; }
            set { this.nextTokenField= value; }
        }



        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">NextToken property</param>
        /// <returns>this instance</returns>
        public GetFeedSubmissionListByNextTokenResult WithNextToken(String nextToken)
        {
            this.nextTokenField = nextToken;
            return this;
        }



        /// <summary>
        /// Checks if NextToken property is set
        /// </summary>
        /// <returns>true if NextToken property is set</returns>
        public Boolean IsSetNextToken()
        {
            return  this.nextTokenField != null;

        }


        /// <summary>
        /// Gets and sets the HasNext property.
        /// </summary>
        [XmlElementAttribute(ElementName = "HasNext")]
        public Boolean HasNext
        {
            get { return this.hasNextField.GetValueOrDefault() ; }
            set { this.hasNextField= value; }
        }



        /// <summary>
        /// Sets the HasNext property
        /// </summary>
        /// <param name="hasNext">HasNext property</param>
        /// <returns>this instance</returns>
        public GetFeedSubmissionListByNextTokenResult WithHasNext(Boolean hasNext)
        {
            this.hasNextField = hasNext;
            return this;
        }



        /// <summary>
        /// Checks if HasNext property is set
        /// </summary>
        /// <returns>true if HasNext property is set</returns>
        public Boolean IsSetHasNext()
        {
            return  this.hasNextField.HasValue;

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
        public GetFeedSubmissionListByNextTokenResult WithFeedSubmissionInfo(params FeedSubmissionInfo[] list)
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
            if (IsSetNextToken()) {
                xml.Append("<NextToken>");
                xml.Append(EscapeXML(this.NextToken));
                xml.Append("</NextToken>");
            }
            if (IsSetHasNext()) {
                xml.Append("<HasNext>");
                xml.Append(this.HasNext);
                xml.Append("</HasNext>");
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
