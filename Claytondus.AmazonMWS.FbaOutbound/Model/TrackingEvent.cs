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
 * Tracking Event
 * API Version: 2010-10-01
 * Library Version: 2016-10-19
 * Generated: Wed Oct 19 08:37:54 PDT 2016
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaOutbound.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", IsNullable = false)]
    public class TrackingEvent : AbstractMwsObject
    {

        private DateTime? _eventDate;
        private TrackingAddress _eventAddress;
        private string _eventCode;

        /// <summary>
        /// Gets and sets the EventDate property.
        /// </summary>
        [XmlElement(ElementName = "EventDate")]
        public DateTime EventDate
        {
            get { return this._eventDate.GetValueOrDefault(); }
            set { this._eventDate = value; }
        }

        /// <summary>
        /// Sets the EventDate property.
        /// </summary>
        /// <param name="eventDate">EventDate property.</param>
        /// <returns>this instance.</returns>
        public TrackingEvent WithEventDate(DateTime eventDate)
        {
            this._eventDate = eventDate;
            return this;
        }

        /// <summary>
        /// Checks if EventDate property is set.
        /// </summary>
        /// <returns>true if EventDate property is set.</returns>
        public bool IsSetEventDate()
        {
            return this._eventDate != null;
        }

        /// <summary>
        /// Gets and sets the EventAddress property.
        /// </summary>
        [XmlElement(ElementName = "EventAddress")]
        public TrackingAddress EventAddress
        {
            get { return this._eventAddress; }
            set { this._eventAddress = value; }
        }

        /// <summary>
        /// Sets the EventAddress property.
        /// </summary>
        /// <param name="eventAddress">EventAddress property.</param>
        /// <returns>this instance.</returns>
        public TrackingEvent WithEventAddress(TrackingAddress eventAddress)
        {
            this._eventAddress = eventAddress;
            return this;
        }

        /// <summary>
        /// Checks if EventAddress property is set.
        /// </summary>
        /// <returns>true if EventAddress property is set.</returns>
        public bool IsSetEventAddress()
        {
            return this._eventAddress != null;
        }

        /// <summary>
        /// Gets and sets the EventCode property.
        /// </summary>
        [XmlElement(ElementName = "EventCode")]
        public string EventCode
        {
            get { return this._eventCode; }
            set { this._eventCode = value; }
        }

        /// <summary>
        /// Sets the EventCode property.
        /// </summary>
        /// <param name="eventCode">EventCode property.</param>
        /// <returns>this instance.</returns>
        public TrackingEvent WithEventCode(string eventCode)
        {
            this._eventCode = eventCode;
            return this;
        }

        /// <summary>
        /// Checks if EventCode property is set.
        /// </summary>
        /// <returns>true if EventCode property is set.</returns>
        public bool IsSetEventCode()
        {
            return this._eventCode != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _eventDate = reader.Read<DateTime?>("EventDate");
            _eventAddress = reader.Read<TrackingAddress>("EventAddress");
            _eventCode = reader.Read<string>("EventCode");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("EventDate", _eventDate);
            writer.Write("EventAddress", _eventAddress);
            writer.Write("EventCode", _eventCode);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "TrackingEvent", this);
        }


        public TrackingEvent() : base()
        {
        }
    }
}
