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
    public class FeedSubmissionInfo
    {
    
        private String feedSubmissionIdField;

        private String feedTypeField;

        private String submittedDateField;

        private String feedProcessingStatusField;

        private DateTime? startedProcessingDateField;

        private DateTime? completedProcessingDateField;


        /// <summary>
        /// Gets and sets the FeedSubmissionId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeedSubmissionId")]
        public String FeedSubmissionId
        {
            get { return this.feedSubmissionIdField ; }
            set { this.feedSubmissionIdField= value; }
        }



        /// <summary>
        /// Sets the FeedSubmissionId property
        /// </summary>
        /// <param name="feedSubmissionId">FeedSubmissionId property</param>
        /// <returns>this instance</returns>
        public FeedSubmissionInfo WithFeedSubmissionId(String feedSubmissionId)
        {
            this.feedSubmissionIdField = feedSubmissionId;
            return this;
        }



        /// <summary>
        /// Checks if FeedSubmissionId property is set
        /// </summary>
        /// <returns>true if FeedSubmissionId property is set</returns>
        public Boolean IsSetFeedSubmissionId()
        {
            return  this.feedSubmissionIdField != null;

        }


        /// <summary>
        /// Gets and sets the FeedType property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeedType")]
        public String FeedType
        {
            get { return this.feedTypeField ; }
            set { this.feedTypeField= value; }
        }



        /// <summary>
        /// Sets the FeedType property
        /// </summary>
        /// <param name="feedType">FeedType property</param>
        /// <returns>this instance</returns>
        public FeedSubmissionInfo WithFeedType(String feedType)
        {
            this.feedTypeField = feedType;
            return this;
        }



        /// <summary>
        /// Checks if FeedType property is set
        /// </summary>
        /// <returns>true if FeedType property is set</returns>
        public Boolean IsSetFeedType()
        {
            return  this.feedTypeField != null;

        }


        /// <summary>
        /// Gets and sets the SubmittedDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubmittedDate")]
        public String SubmittedDate
        {
            get { return this.submittedDateField ; }
            set { this.submittedDateField= value; }
        }



        /// <summary>
        /// Sets the SubmittedDate property
        /// </summary>
        /// <param name="submittedDate">SubmittedDate property</param>
        /// <returns>this instance</returns>
        public FeedSubmissionInfo WithSubmittedDate(String submittedDate)
        {
            this.submittedDateField = submittedDate;
            return this;
        }



        /// <summary>
        /// Checks if SubmittedDate property is set
        /// </summary>
        /// <returns>true if SubmittedDate property is set</returns>
        public Boolean IsSetSubmittedDate()
        {
            return  this.submittedDateField != null;

        }


        /// <summary>
        /// Gets and sets the FeedProcessingStatus property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeedProcessingStatus")]
        public String FeedProcessingStatus
        {
            get { return this.feedProcessingStatusField ; }
            set { this.feedProcessingStatusField= value; }
        }



        /// <summary>
        /// Sets the FeedProcessingStatus property
        /// </summary>
        /// <param name="feedProcessingStatus">FeedProcessingStatus property</param>
        /// <returns>this instance</returns>
        public FeedSubmissionInfo WithFeedProcessingStatus(String feedProcessingStatus)
        {
            this.feedProcessingStatusField = feedProcessingStatus;
            return this;
        }



        /// <summary>
        /// Checks if FeedProcessingStatus property is set
        /// </summary>
        /// <returns>true if FeedProcessingStatus property is set</returns>
        public Boolean IsSetFeedProcessingStatus()
        {
            return  this.feedProcessingStatusField != null;

        }


        /// <summary>
        /// Gets and sets the StartedProcessingDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartedProcessingDate")]
        public DateTime StartedProcessingDate
        {
            get { return this.startedProcessingDateField.GetValueOrDefault() ; }
            set { this.startedProcessingDateField= value; }
        }



        /// <summary>
        /// Sets the StartedProcessingDate property
        /// </summary>
        /// <param name="startedProcessingDate">StartedProcessingDate property</param>
        /// <returns>this instance</returns>
        public FeedSubmissionInfo WithStartedProcessingDate(DateTime startedProcessingDate)
        {
            this.startedProcessingDateField = startedProcessingDate;
            return this;
        }



        /// <summary>
        /// Checks if StartedProcessingDate property is set
        /// </summary>
        /// <returns>true if StartedProcessingDate property is set</returns>
        public Boolean IsSetStartedProcessingDate()
        {
            return  this.startedProcessingDateField.HasValue;

        }


        /// <summary>
        /// Gets and sets the CompletedProcessingDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CompletedProcessingDate")]
        public DateTime CompletedProcessingDate
        {
            get { return this.completedProcessingDateField.GetValueOrDefault() ; }
            set { this.completedProcessingDateField= value; }
        }



        /// <summary>
        /// Sets the CompletedProcessingDate property
        /// </summary>
        /// <param name="completedProcessingDate">CompletedProcessingDate property</param>
        /// <returns>this instance</returns>
        public FeedSubmissionInfo WithCompletedProcessingDate(DateTime completedProcessingDate)
        {
            this.completedProcessingDateField = completedProcessingDate;
            return this;
        }



        /// <summary>
        /// Checks if CompletedProcessingDate property is set
        /// </summary>
        /// <returns>true if CompletedProcessingDate property is set</returns>
        public Boolean IsSetCompletedProcessingDate()
        {
            return  this.completedProcessingDateField.HasValue;

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
            if (IsSetFeedSubmissionId()) {
                xml.Append("<FeedSubmissionId>");
                xml.Append(EscapeXML(this.FeedSubmissionId));
                xml.Append("</FeedSubmissionId>");
            }
            if (IsSetFeedType()) {
                xml.Append("<FeedType>");
                xml.Append(EscapeXML(this.FeedType));
                xml.Append("</FeedType>");
            }
            if (IsSetSubmittedDate()) {
                xml.Append("<SubmittedDate>");
                xml.Append(EscapeXML(this.SubmittedDate));
                xml.Append("</SubmittedDate>");
            }
            if (IsSetFeedProcessingStatus()) {
                xml.Append("<FeedProcessingStatus>");
                xml.Append(EscapeXML(this.FeedProcessingStatus));
                xml.Append("</FeedProcessingStatus>");
            }
            if (IsSetStartedProcessingDate()) {
                xml.Append("<StartedProcessingDate>");
                xml.Append(this.StartedProcessingDate);
                xml.Append("</StartedProcessingDate>");
            }
            if (IsSetCompletedProcessingDate()) {
                xml.Append("<CompletedProcessingDate>");
                xml.Append(this.CompletedProcessingDate);
                xml.Append("</CompletedProcessingDate>");
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
