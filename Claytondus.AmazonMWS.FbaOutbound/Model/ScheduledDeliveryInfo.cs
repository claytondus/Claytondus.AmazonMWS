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
 * Scheduled Delivery Info
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
    public class ScheduledDeliveryInfo : AbstractMwsObject
    {

        private string _deliveryTimeZone;
        private DeliveryWindowList _deliveryWindows;

        /// <summary>
        /// Gets and sets the DeliveryTimeZone property.
        /// </summary>
        [XmlElement(ElementName = "DeliveryTimeZone")]
        public string DeliveryTimeZone
        {
            get { return this._deliveryTimeZone; }
            set { this._deliveryTimeZone = value; }
        }

        /// <summary>
        /// Sets the DeliveryTimeZone property.
        /// </summary>
        /// <param name="deliveryTimeZone">DeliveryTimeZone property.</param>
        /// <returns>this instance.</returns>
        public ScheduledDeliveryInfo WithDeliveryTimeZone(string deliveryTimeZone)
        {
            this._deliveryTimeZone = deliveryTimeZone;
            return this;
        }

        /// <summary>
        /// Checks if DeliveryTimeZone property is set.
        /// </summary>
        /// <returns>true if DeliveryTimeZone property is set.</returns>
        public bool IsSetDeliveryTimeZone()
        {
            return this._deliveryTimeZone != null;
        }

        /// <summary>
        /// Gets and sets the DeliveryWindows property.
        /// </summary>
        [XmlElement(ElementName = "DeliveryWindows")]
        public DeliveryWindowList DeliveryWindows
        {
            get { return this._deliveryWindows; }
            set { this._deliveryWindows = value; }
        }

        /// <summary>
        /// Sets the DeliveryWindows property.
        /// </summary>
        /// <param name="deliveryWindows">DeliveryWindows property.</param>
        /// <returns>this instance.</returns>
        public ScheduledDeliveryInfo WithDeliveryWindows(DeliveryWindowList deliveryWindows)
        {
            this._deliveryWindows = deliveryWindows;
            return this;
        }

        /// <summary>
        /// Checks if DeliveryWindows property is set.
        /// </summary>
        /// <returns>true if DeliveryWindows property is set.</returns>
        public bool IsSetDeliveryWindows()
        {
            return this._deliveryWindows != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _deliveryTimeZone = reader.Read<string>("DeliveryTimeZone");
            _deliveryWindows = reader.Read<DeliveryWindowList>("DeliveryWindows");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("DeliveryTimeZone", _deliveryTimeZone);
            writer.Write("DeliveryWindows", _deliveryWindows);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "ScheduledDeliveryInfo", this);
        }


        public ScheduledDeliveryInfo() : base()
        {
        }
    }
}
