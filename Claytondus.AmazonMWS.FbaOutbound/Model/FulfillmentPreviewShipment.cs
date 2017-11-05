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
 * Fulfillment Preview Shipment
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
    public class FulfillmentPreviewShipment : AbstractMwsObject
    {

        private DateTime? _earliestShipDate;
        private DateTime? _latestShipDate;
        private DateTime? _earliestArrivalDate;
        private DateTime? _latestArrivalDate;
        private FulfillmentPreviewItemList _fulfillmentPreviewItems;

        /// <summary>
        /// Gets and sets the EarliestShipDate property.
        /// </summary>
        [XmlElement(ElementName = "EarliestShipDate")]
        public DateTime EarliestShipDate
        {
            get { return this._earliestShipDate.GetValueOrDefault(); }
            set { this._earliestShipDate = value; }
        }

        /// <summary>
        /// Sets the EarliestShipDate property.
        /// </summary>
        /// <param name="earliestShipDate">EarliestShipDate property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreviewShipment WithEarliestShipDate(DateTime earliestShipDate)
        {
            this._earliestShipDate = earliestShipDate;
            return this;
        }

        /// <summary>
        /// Checks if EarliestShipDate property is set.
        /// </summary>
        /// <returns>true if EarliestShipDate property is set.</returns>
        public bool IsSetEarliestShipDate()
        {
            return this._earliestShipDate != null;
        }

        /// <summary>
        /// Gets and sets the LatestShipDate property.
        /// </summary>
        [XmlElement(ElementName = "LatestShipDate")]
        public DateTime LatestShipDate
        {
            get { return this._latestShipDate.GetValueOrDefault(); }
            set { this._latestShipDate = value; }
        }

        /// <summary>
        /// Sets the LatestShipDate property.
        /// </summary>
        /// <param name="latestShipDate">LatestShipDate property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreviewShipment WithLatestShipDate(DateTime latestShipDate)
        {
            this._latestShipDate = latestShipDate;
            return this;
        }

        /// <summary>
        /// Checks if LatestShipDate property is set.
        /// </summary>
        /// <returns>true if LatestShipDate property is set.</returns>
        public bool IsSetLatestShipDate()
        {
            return this._latestShipDate != null;
        }

        /// <summary>
        /// Gets and sets the EarliestArrivalDate property.
        /// </summary>
        [XmlElement(ElementName = "EarliestArrivalDate")]
        public DateTime EarliestArrivalDate
        {
            get { return this._earliestArrivalDate.GetValueOrDefault(); }
            set { this._earliestArrivalDate = value; }
        }

        /// <summary>
        /// Sets the EarliestArrivalDate property.
        /// </summary>
        /// <param name="earliestArrivalDate">EarliestArrivalDate property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreviewShipment WithEarliestArrivalDate(DateTime earliestArrivalDate)
        {
            this._earliestArrivalDate = earliestArrivalDate;
            return this;
        }

        /// <summary>
        /// Checks if EarliestArrivalDate property is set.
        /// </summary>
        /// <returns>true if EarliestArrivalDate property is set.</returns>
        public bool IsSetEarliestArrivalDate()
        {
            return this._earliestArrivalDate != null;
        }

        /// <summary>
        /// Gets and sets the LatestArrivalDate property.
        /// </summary>
        [XmlElement(ElementName = "LatestArrivalDate")]
        public DateTime LatestArrivalDate
        {
            get { return this._latestArrivalDate.GetValueOrDefault(); }
            set { this._latestArrivalDate = value; }
        }

        /// <summary>
        /// Sets the LatestArrivalDate property.
        /// </summary>
        /// <param name="latestArrivalDate">LatestArrivalDate property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreviewShipment WithLatestArrivalDate(DateTime latestArrivalDate)
        {
            this._latestArrivalDate = latestArrivalDate;
            return this;
        }

        /// <summary>
        /// Checks if LatestArrivalDate property is set.
        /// </summary>
        /// <returns>true if LatestArrivalDate property is set.</returns>
        public bool IsSetLatestArrivalDate()
        {
            return this._latestArrivalDate != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentPreviewItems property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentPreviewItems")]
        public FulfillmentPreviewItemList FulfillmentPreviewItems
        {
            get { return this._fulfillmentPreviewItems; }
            set { this._fulfillmentPreviewItems = value; }
        }

        /// <summary>
        /// Sets the FulfillmentPreviewItems property.
        /// </summary>
        /// <param name="fulfillmentPreviewItems">FulfillmentPreviewItems property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreviewShipment WithFulfillmentPreviewItems(FulfillmentPreviewItemList fulfillmentPreviewItems)
        {
            this._fulfillmentPreviewItems = fulfillmentPreviewItems;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentPreviewItems property is set.
        /// </summary>
        /// <returns>true if FulfillmentPreviewItems property is set.</returns>
        public bool IsSetFulfillmentPreviewItems()
        {
            return this._fulfillmentPreviewItems != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _earliestShipDate = reader.Read<DateTime?>("EarliestShipDate");
            _latestShipDate = reader.Read<DateTime?>("LatestShipDate");
            _earliestArrivalDate = reader.Read<DateTime?>("EarliestArrivalDate");
            _latestArrivalDate = reader.Read<DateTime?>("LatestArrivalDate");
            _fulfillmentPreviewItems = reader.Read<FulfillmentPreviewItemList>("FulfillmentPreviewItems");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("EarliestShipDate", _earliestShipDate);
            writer.Write("LatestShipDate", _latestShipDate);
            writer.Write("EarliestArrivalDate", _earliestArrivalDate);
            writer.Write("LatestArrivalDate", _latestArrivalDate);
            writer.Write("FulfillmentPreviewItems", _fulfillmentPreviewItems);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "FulfillmentPreviewShipment", this);
        }

    public FulfillmentPreviewShipment (DateTime? earliestShipDate,DateTime? latestShipDate,DateTime? earliestArrivalDate,DateTime? latestArrivalDate,FulfillmentPreviewItemList fulfillmentPreviewItems) : base() {
        this._earliestShipDate = earliestShipDate;
        this._latestShipDate = latestShipDate;
        this._earliestArrivalDate = earliestArrivalDate;
        this._latestArrivalDate = latestArrivalDate;
        this._fulfillmentPreviewItems = fulfillmentPreviewItems;
    }

        public FulfillmentPreviewShipment() : base()
        {
        }
    }
}
