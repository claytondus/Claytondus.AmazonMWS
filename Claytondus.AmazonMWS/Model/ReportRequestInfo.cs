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
    public class ReportRequestInfo
    {
    
        private String reportRequestIdField;

        private String reportTypeField;

        private DateTime? startDateField;

        private DateTime? endDateField;

        private Boolean scheduledField;

        private DateTime? submittedDateField;

        private String reportProcessingStatusField;

        private String generatedReportIdField;

        private DateTime? startedProcessingDateField;

        private DateTime? completedDateField;


        /// <summary>
        /// Gets and sets the ReportRequestId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReportRequestId")]
        public String ReportRequestId
        {
            get { return this.reportRequestIdField ; }
            set { this.reportRequestIdField= value; }
        }



        /// <summary>
        /// Sets the ReportRequestId property
        /// </summary>
        /// <param name="reportRequestId">ReportRequestId property</param>
        /// <returns>this instance</returns>
        public ReportRequestInfo WithReportRequestId(String reportRequestId)
        {
            this.reportRequestIdField = reportRequestId;
            return this;
        }



        /// <summary>
        /// Checks if ReportRequestId property is set
        /// </summary>
        /// <returns>true if ReportRequestId property is set</returns>
        public Boolean IsSetReportRequestId()
        {
            return  this.reportRequestIdField != null;

        }


        /// <summary>
        /// Gets and sets the ReportType property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReportType")]
        public String ReportType
        {
            get { return this.reportTypeField ; }
            set { this.reportTypeField= value; }
        }



        /// <summary>
        /// Sets the ReportType property
        /// </summary>
        /// <param name="reportType">ReportType property</param>
        /// <returns>this instance</returns>
        public ReportRequestInfo WithReportType(String reportType)
        {
            this.reportTypeField = reportType;
            return this;
        }



        /// <summary>
        /// Checks if ReportType property is set
        /// </summary>
        /// <returns>true if ReportType property is set</returns>
        public Boolean IsSetReportType()
        {
            return  this.reportTypeField != null;

        }


        /// <summary>
        /// Gets and sets the StartDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartDate")]
        public DateTime StartDate
        {
            get { return this.startDateField.GetValueOrDefault() ; }
            set { this.startDateField= value; }
        }



        /// <summary>
        /// Sets the StartDate property
        /// </summary>
        /// <param name="startDate">StartDate property</param>
        /// <returns>this instance</returns>
        public ReportRequestInfo WithStartDate(DateTime startDate)
        {
            this.startDateField = startDate;
            return this;
        }



        /// <summary>
        /// Checks if StartDate property is set
        /// </summary>
        /// <returns>true if StartDate property is set</returns>
        public Boolean IsSetStartDate()
        {
            return  this.startDateField.HasValue;

        }


        /// <summary>
        /// Gets and sets the EndDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "EndDate")]
        public DateTime EndDate
        {
            get { return this.endDateField.GetValueOrDefault() ; }
            set { this.endDateField= value; }
        }



        /// <summary>
        /// Sets the EndDate property
        /// </summary>
        /// <param name="endDate">EndDate property</param>
        /// <returns>this instance</returns>
        public ReportRequestInfo WithEndDate(DateTime endDate)
        {
            this.endDateField = endDate;
            return this;
        }



        /// <summary>
        /// Checks if EndDate property is set
        /// </summary>
        /// <returns>true if EndDate property is set</returns>
        public Boolean IsSetEndDate()
        {
            return  this.endDateField.HasValue;

        }


        /// <summary>
        /// Gets and sets the Scheduled property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Scheduled")]
        public Boolean Scheduled
        {
            get { return this.scheduledField; }
            set { this.scheduledField = value; }
        }



        /// <summary>
        /// Sets the Scheduled property
        /// </summary>
        /// <param name="scheduled">Scheduled property</param>
        /// <returns>this instance</returns>
        public ReportRequestInfo WithScheduled(Boolean scheduled)
        {
            this.scheduledField = scheduled;
            return this;
        }



        /// <summary>
        /// Checks if Scheduled property is set
        /// </summary>
        /// <returns>true if Scheduled property is set</returns>
        public Boolean IsSetScheduled()
        {
            return this.scheduledField != null;
        }


        /// <summary>
        /// Gets and sets the SubmittedDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubmittedDate")]
        public DateTime SubmittedDate
        {
            get { return this.submittedDateField.GetValueOrDefault() ; }
            set { this.submittedDateField= value; }
        }



        /// <summary>
        /// Sets the SubmittedDate property
        /// </summary>
        /// <param name="submittedDate">SubmittedDate property</param>
        /// <returns>this instance</returns>
        public ReportRequestInfo WithSubmittedDate(DateTime submittedDate)
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
            return  this.submittedDateField.HasValue;

        }


        /// <summary>
        /// Gets and sets the ReportProcessingStatus property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReportProcessingStatus")]
        public String ReportProcessingStatus
        {
            get { return this.reportProcessingStatusField ; }
            set { this.reportProcessingStatusField= value; }
        }



        /// <summary>
        /// Sets the ReportProcessingStatus property
        /// </summary>
        /// <param name="reportProcessingStatus">ReportProcessingStatus property</param>
        /// <returns>this instance</returns>
        public ReportRequestInfo WithReportProcessingStatus(String reportProcessingStatus)
        {
            this.reportProcessingStatusField = reportProcessingStatus;
            return this;
        }



        /// <summary>
        /// Checks if ReportProcessingStatus property is set
        /// </summary>
        /// <returns>true if ReportProcessingStatus property is set</returns>
        public Boolean IsSetReportProcessingStatus()
        {
            return  this.reportProcessingStatusField != null;

        }

        /// <summary>
        /// Gets and sets the GeneratedReportId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "GeneratedReportId")]
        public String GeneratedReportId
        {
            get { return this.generatedReportIdField; }
            set { this.generatedReportIdField = value; }
        }



        /// <summary>
        /// Sets the GeneratedReportId property
        /// </summary>
        /// <param name="reportRequestId">GeneratedReportId property</param>
        /// <returns>this instance</returns>
        public ReportRequestInfo WithGeneratedReportId(String generatedReportId)
        {
            this.generatedReportIdField = generatedReportId;
            return this;
        }


        /// <summary>
        /// Checks if GeneratedReportId property is set
        /// </summary>
        /// <returns>true if GeneratedReportId property is set</returns>
        public Boolean IsSetGeneratedReportId()
        {
            return this.generatedReportIdField != null;

        }




        /// <summary>
        /// Gets and sets the StartedProcessingDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartedProcessingDate")]
        public DateTime StartedProcessingDate
        {
            get { return this.startedProcessingDateField.GetValueOrDefault() ; }
            set { this.startedProcessingDateField = value; }
        }



        /// <summary>
        /// Sets the StartedProcessingDate property
        /// </summary>
        /// <param name="startedProcessingDate">StartedProcessingDate property</param>
        /// <returns>this instance</returns>
        public ReportRequestInfo WithStartedProcessingDate(DateTime startedProcessingDate)
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
        /// Gets and sets the CompletedDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CompletedDate")]
        public DateTime CompletedDate
        {
            get { return this.completedDateField.GetValueOrDefault() ; }
            set { this.completedDateField = value; }
        }



        /// <summary>
        /// Sets the CompletedDate property
        /// </summary>
        /// <param name="completedDate">CompletedDate property</param>
        /// <returns>this instance</returns>
        public ReportRequestInfo WithCompletedDate(DateTime completedDate)
        {
            this.completedDateField = completedDate;
            return this;
        }



        /// <summary>
        /// Checks if CompletedDate property is set
        /// </summary>
        /// <returns>true if CompletedDate property is set</returns>
        public Boolean IsSetCompletedDate()
        {
            return  this.completedDateField.HasValue;
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
            if (IsSetReportRequestId()) {
                xml.Append("<ReportRequestId>");
                xml.Append(EscapeXML(this.ReportRequestId));
                xml.Append("</ReportRequestId>");
            }
            if (IsSetReportType()) {
                xml.Append("<ReportType>");
                xml.Append(EscapeXML(this.ReportType));
                xml.Append("</ReportType>");
            }
            if (IsSetStartDate()) {
                xml.Append("<StartDate>");
                xml.Append(this.StartDate);
                xml.Append("</StartDate>");
            }
            if (IsSetEndDate()) {
                xml.Append("<EndDate>");
                xml.Append(this.EndDate);
                xml.Append("</EndDate>");
            }
            if (IsSetScheduled()) {
                xml.Append("<Scheduled>");
                xml.Append(this.Scheduled);
                xml.Append("</Scheduled>");
            }
            if (IsSetSubmittedDate()) {
                xml.Append("<SubmittedDate>");
                xml.Append(this.SubmittedDate);
                xml.Append("</SubmittedDate>");
            }
            if (IsSetReportProcessingStatus()) {
                xml.Append("<ReportProcessingStatus>");
                xml.Append(EscapeXML(this.ReportProcessingStatus));
                xml.Append("</ReportProcessingStatus>");
            }
            if (IsSetGeneratedReportId()) {
                xml.Append("<GeneratedReportId>");
                xml.Append(EscapeXML(this.GeneratedReportId));
                xml.Append("</GeneratedReportId>");
            }
            if (IsSetStartedProcessingDate()) {
                xml.Append("<StartedProcessingDate>");
                xml.Append(this.StartedProcessingDate);
                xml.Append("</StartedProcessingDate>");
            }
            if (IsSetCompletedDate()) {
                xml.Append("<CompletedDate>");
                xml.Append(this.CompletedDate);
                xml.Append("</CompletedDate>");
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
