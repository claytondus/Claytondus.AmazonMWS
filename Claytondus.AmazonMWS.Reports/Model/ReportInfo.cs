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
    public class ReportInfo
    {
    
        private String reportIdField;

        private String reportTypeField;

        private String reportRequestIdField;

        private DateTime? availableDateField;

        private Boolean? acknowledgedField;

        private DateTime? acknowledgedDateField;


        /// <summary>
        /// Gets and sets the ReportId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReportId")]
        public String ReportId
        {
            get { return this.reportIdField ; }
            set { this.reportIdField= value; }
        }



        /// <summary>
        /// Sets the ReportId property
        /// </summary>
        /// <param name="reportId">ReportId property</param>
        /// <returns>this instance</returns>
        public ReportInfo WithReportId(String reportId)
        {
            this.reportIdField = reportId;
            return this;
        }



        /// <summary>
        /// Checks if ReportId property is set
        /// </summary>
        /// <returns>true if ReportId property is set</returns>
        public Boolean IsSetReportId()
        {
            return  this.reportIdField != null;

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
        public ReportInfo WithReportType(String reportType)
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
        public ReportInfo WithReportRequestId(String reportRequestId)
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
        /// Gets and sets the AvailableDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailableDate")]
        public DateTime AvailableDate
        {
            get { return this.availableDateField.GetValueOrDefault() ; }
            set { this.availableDateField= value; }
        }



        /// <summary>
        /// Sets the AvailableDate property
        /// </summary>
        /// <param name="availableDate">AvailableDate property</param>
        /// <returns>this instance</returns>
        public ReportInfo WithAvailableDate(DateTime availableDate)
        {
            this.availableDateField = availableDate;
            return this;
        }



        /// <summary>
        /// Checks if AvailableDate property is set
        /// </summary>
        /// <returns>true if AvailableDate property is set</returns>
        public Boolean IsSetAvailableDate()
        {
            return  this.availableDateField.HasValue;

        }


        /// <summary>
        /// Gets and sets the Acknowledged property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Acknowledged")]
        public Boolean Acknowledged
        {
            get { return this.acknowledgedField.GetValueOrDefault() ; }
            set { this.acknowledgedField= value; }
        }



        /// <summary>
        /// Sets the Acknowledged property
        /// </summary>
        /// <param name="acknowledged">Acknowledged property</param>
        /// <returns>this instance</returns>
        public ReportInfo WithAcknowledged(Boolean acknowledged)
        {
            this.acknowledgedField = acknowledged;
            return this;
        }



        /// <summary>
        /// Checks if Acknowledged property is set
        /// </summary>
        /// <returns>true if Acknowledged property is set</returns>
        public Boolean IsSetAcknowledged()
        {
            return  this.acknowledgedField.HasValue;

        }


        /// <summary>
        /// Gets and sets the AcknowledgedDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AcknowledgedDate")]
        public DateTime AcknowledgedDate
        {
            get { return this.acknowledgedDateField.GetValueOrDefault() ; }
            set { this.acknowledgedDateField= value; }
        }



        /// <summary>
        /// Sets the AcknowledgedDate property
        /// </summary>
        /// <param name="acknowledgedDate">AcknowledgedDate property</param>
        /// <returns>this instance</returns>
        public ReportInfo WithAcknowledgedDate(DateTime acknowledgedDate)
        {
            this.acknowledgedDateField = acknowledgedDate;
            return this;
        }



        /// <summary>
        /// Checks if AcknowledgedDate property is set
        /// </summary>
        /// <returns>true if AcknowledgedDate property is set</returns>
        public Boolean IsSetAcknowledgedDate()
        {
            return  this.acknowledgedDateField.HasValue;

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
            if (IsSetReportId()) {
                xml.Append("<ReportId>");
                xml.Append(EscapeXML(this.ReportId));
                xml.Append("</ReportId>");
            }
            if (IsSetReportType()) {
                xml.Append("<ReportType>");
                xml.Append(EscapeXML(this.ReportType));
                xml.Append("</ReportType>");
            }
            if (IsSetReportRequestId()) {
                xml.Append("<ReportRequestId>");
                xml.Append(EscapeXML(this.ReportRequestId));
                xml.Append("</ReportRequestId>");
            }
            if (IsSetAvailableDate()) {
                xml.Append("<AvailableDate>");
                xml.Append(this.AvailableDate);
                xml.Append("</AvailableDate>");
            }
            if (IsSetAcknowledged()) {
                xml.Append("<Acknowledged>");
                xml.Append(this.Acknowledged);
                xml.Append("</Acknowledged>");
            }
            if (IsSetAcknowledgedDate()) {
                xml.Append("<AcknowledgedDate>");
                xml.Append(this.AcknowledgedDate);
                xml.Append("</AcknowledgedDate>");
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
