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
 * Delivery Window
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
    public class DeliveryWindow : AbstractMwsObject
    {

        private DateTime? _startDateTime;
        private DateTime? _endDateTime;

        /// <summary>
        /// Gets and sets the StartDateTime property.
        /// </summary>
        [XmlElement(ElementName = "StartDateTime")]
        public DateTime StartDateTime
        {
            get { return this._startDateTime.GetValueOrDefault(); }
            set { this._startDateTime = value; }
        }

        /// <summary>
        /// Sets the StartDateTime property.
        /// </summary>
        /// <param name="startDateTime">StartDateTime property.</param>
        /// <returns>this instance.</returns>
        public DeliveryWindow WithStartDateTime(DateTime startDateTime)
        {
            this._startDateTime = startDateTime;
            return this;
        }

        /// <summary>
        /// Checks if StartDateTime property is set.
        /// </summary>
        /// <returns>true if StartDateTime property is set.</returns>
        public bool IsSetStartDateTime()
        {
            return this._startDateTime != null;
        }

        /// <summary>
        /// Gets and sets the EndDateTime property.
        /// </summary>
        [XmlElement(ElementName = "EndDateTime")]
        public DateTime EndDateTime
        {
            get { return this._endDateTime.GetValueOrDefault(); }
            set { this._endDateTime = value; }
        }

        /// <summary>
        /// Sets the EndDateTime property.
        /// </summary>
        /// <param name="endDateTime">EndDateTime property.</param>
        /// <returns>this instance.</returns>
        public DeliveryWindow WithEndDateTime(DateTime endDateTime)
        {
            this._endDateTime = endDateTime;
            return this;
        }

        /// <summary>
        /// Checks if EndDateTime property is set.
        /// </summary>
        /// <returns>true if EndDateTime property is set.</returns>
        public bool IsSetEndDateTime()
        {
            return this._endDateTime != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _startDateTime = reader.Read<DateTime?>("StartDateTime");
            _endDateTime = reader.Read<DateTime?>("EndDateTime");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("StartDateTime", _startDateTime);
            writer.Write("EndDateTime", _endDateTime);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "DeliveryWindow", this);
        }

    public DeliveryWindow (DateTime? startDateTime,DateTime? endDateTime) : base() {
        this._startDateTime = startDateTime;
        this._endDateTime = endDateTime;
    }

        public DeliveryWindow() : base()
        {
        }
    }
}
