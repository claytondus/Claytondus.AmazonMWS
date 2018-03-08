/*******************************************************************************
 * Copyright 2009-2016 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Timepoint
 * API Version: 2010-10-01
 * Library Version: 2014-09-30
 * Generated: Mon Mar 21 09:01:30 PDT 2016
 */


using System;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaInventory.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/", IsNullable = false)]
    public class Timepoint : AbstractMwsObject
    {

        private string _timepointType;
        private DateTime? _dateTime;

        /// <summary>
        /// Gets and sets the TimepointType property.
        /// </summary>
        [XmlElement(ElementName = "TimepointType")]
        public string TimepointType
        {
            get { return this._timepointType; }
            set { this._timepointType = value; }
        }

        /// <summary>
        /// Sets the TimepointType property.
        /// </summary>
        /// <param name="timepointType">TimepointType property.</param>
        /// <returns>this instance.</returns>
        public Timepoint WithTimepointType(string timepointType)
        {
            this._timepointType = timepointType;
            return this;
        }

        /// <summary>
        /// Checks if TimepointType property is set.
        /// </summary>
        /// <returns>true if TimepointType property is set.</returns>
        public bool IsSetTimepointType()
        {
            return this._timepointType != null;
        }

        /// <summary>
        /// Gets and sets the DateTime property.
        /// </summary>
        [XmlElement(ElementName = "DateTime")]
        public DateTime DateTime
        {
            get { return this._dateTime.GetValueOrDefault(); }
            set { this._dateTime = value; }
        }

        /// <summary>
        /// Sets the DateTime property.
        /// </summary>
        /// <param name="dateTime">DateTime property.</param>
        /// <returns>this instance.</returns>
        public Timepoint WithDateTime(DateTime dateTime)
        {
            this._dateTime = dateTime;
            return this;
        }

        /// <summary>
        /// Checks if DateTime property is set.
        /// </summary>
        /// <returns>true if DateTime property is set.</returns>
        public bool IsSetDateTime()
        {
            return this._dateTime != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _timepointType = reader.Read<string>("TimepointType");
            _dateTime = reader.Read<DateTime?>("DateTime");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("TimepointType", _timepointType);
            writer.Write("DateTime", _dateTime);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/", "Timepoint", this);
        }

        public Timepoint() : base()
        {
        }
    }
}
