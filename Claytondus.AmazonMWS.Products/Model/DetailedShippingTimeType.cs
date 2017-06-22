/*******************************************************************************
 * Copyright 2009-2017 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Detailed Shipping Time Type
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Products.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false)]
    public class DetailedShippingTimeType : AbstractMwsObject
    {

        private decimal? _minimumHours;
        private decimal? _maximumHours;
        private DateTime? _availableDate;
        private string _availabilityType;

        /// <summary>
        /// Gets and sets the minimumHours property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "minimumHours")]
        public decimal minimumHours
        {
            get { return this._minimumHours.GetValueOrDefault(); }
            set { this._minimumHours = value; }
        }

        /// <summary>
        /// Sets the minimumHours property.
        /// </summary>
        /// <param name="minimumHours">minimumHours property.</param>
        /// <returns>this instance.</returns>
        public DetailedShippingTimeType WithminimumHours(decimal minimumHours)
        {
            this._minimumHours = minimumHours;
            return this;
        }

        /// <summary>
        /// Checks if minimumHours property is set.
        /// </summary>
        /// <returns>true if minimumHours property is set.</returns>
        public bool IsSetminimumHours()
        {
            return this._minimumHours != null;
        }

        /// <summary>
        /// Gets and sets the maximumHours property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "maximumHours")]
        public decimal maximumHours
        {
            get { return this._maximumHours.GetValueOrDefault(); }
            set { this._maximumHours = value; }
        }

        /// <summary>
        /// Sets the maximumHours property.
        /// </summary>
        /// <param name="maximumHours">maximumHours property.</param>
        /// <returns>this instance.</returns>
        public DetailedShippingTimeType WithmaximumHours(decimal maximumHours)
        {
            this._maximumHours = maximumHours;
            return this;
        }

        /// <summary>
        /// Checks if maximumHours property is set.
        /// </summary>
        /// <returns>true if maximumHours property is set.</returns>
        public bool IsSetmaximumHours()
        {
            return this._maximumHours != null;
        }

        /// <summary>
        /// Gets and sets the availableDate property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "availableDate")]
        public DateTime availableDate
        {
            get { return this._availableDate.GetValueOrDefault(); }
            set { this._availableDate = value; }
        }

        /// <summary>
        /// Sets the availableDate property.
        /// </summary>
        /// <param name="availableDate">availableDate property.</param>
        /// <returns>this instance.</returns>
        public DetailedShippingTimeType WithavailableDate(DateTime availableDate)
        {
            this._availableDate = availableDate;
            return this;
        }

        /// <summary>
        /// Checks if availableDate property is set.
        /// </summary>
        /// <returns>true if availableDate property is set.</returns>
        public bool IsSetavailableDate()
        {
            return this._availableDate != null;
        }

        /// <summary>
        /// Gets and sets the availabilityType property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "availabilityType")]
        public string availabilityType
        {
            get { return this._availabilityType; }
            set { this._availabilityType = value; }
        }

        /// <summary>
        /// Sets the availabilityType property.
        /// </summary>
        /// <param name="availabilityType">availabilityType property.</param>
        /// <returns>this instance.</returns>
        public DetailedShippingTimeType WithavailabilityType(string availabilityType)
        {
            this._availabilityType = availabilityType;
            return this;
        }

        /// <summary>
        /// Checks if availabilityType property is set.
        /// </summary>
        /// <returns>true if availabilityType property is set.</returns>
        public bool IsSetavailabilityType()
        {
            return this._availabilityType != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _minimumHours = reader.ReadAttribute<decimal?>("minimumHours");
            _maximumHours = reader.ReadAttribute<decimal?>("maximumHours");
            _availableDate = reader.ReadAttribute<DateTime?>("availableDate");
            _availabilityType = reader.ReadAttribute<string>("availabilityType");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteAttribute("minimumHours",_minimumHours);
            writer.WriteAttribute("maximumHours",_maximumHours);
            writer.WriteAttribute("availableDate",_availableDate);
            writer.WriteAttribute("availabilityType",_availabilityType);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "DetailedShippingTimeType", this);
        }


        public DetailedShippingTimeType() : base()
        {
        }
    }
}
