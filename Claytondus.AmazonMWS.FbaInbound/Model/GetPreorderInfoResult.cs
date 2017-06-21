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
 * Get Preorder Info Result
 * API Version: 2010-10-01
 * Library Version: 2016-10-05
 * Generated: Wed Oct 05 06:15:39 PDT 2016
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaInbound.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    [XmlRootAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", IsNullable = false)]
    public class GetPreorderInfoResult : AbstractMwsObject
    {

        private bool? _shipmentContainsPreorderableItems;
        private bool? _shipmentConfirmedForPreorder;
        private string _needByDate;
        private string _confirmedFulfillableDate;

        /// <summary>
        /// Gets and sets the ShipmentContainsPreorderableItems property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipmentContainsPreorderableItems")]
        public bool ShipmentContainsPreorderableItems
        {
            get { return this._shipmentContainsPreorderableItems.GetValueOrDefault(); }
            set { this._shipmentContainsPreorderableItems = value; }
        }

        /// <summary>
        /// Sets the ShipmentContainsPreorderableItems property.
        /// </summary>
        /// <param name="shipmentContainsPreorderableItems">ShipmentContainsPreorderableItems property.</param>
        /// <returns>this instance.</returns>
        public GetPreorderInfoResult WithShipmentContainsPreorderableItems(bool shipmentContainsPreorderableItems)
        {
            this._shipmentContainsPreorderableItems = shipmentContainsPreorderableItems;
            return this;
        }

        /// <summary>
        /// Checks if ShipmentContainsPreorderableItems property is set.
        /// </summary>
        /// <returns>true if ShipmentContainsPreorderableItems property is set.</returns>
        public bool IsSetShipmentContainsPreorderableItems()
        {
            return this._shipmentContainsPreorderableItems != null;
        }

        /// <summary>
        /// Gets and sets the ShipmentConfirmedForPreorder property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipmentConfirmedForPreorder")]
        public bool ShipmentConfirmedForPreorder
        {
            get { return this._shipmentConfirmedForPreorder.GetValueOrDefault(); }
            set { this._shipmentConfirmedForPreorder = value; }
        }

        /// <summary>
        /// Sets the ShipmentConfirmedForPreorder property.
        /// </summary>
        /// <param name="shipmentConfirmedForPreorder">ShipmentConfirmedForPreorder property.</param>
        /// <returns>this instance.</returns>
        public GetPreorderInfoResult WithShipmentConfirmedForPreorder(bool shipmentConfirmedForPreorder)
        {
            this._shipmentConfirmedForPreorder = shipmentConfirmedForPreorder;
            return this;
        }

        /// <summary>
        /// Checks if ShipmentConfirmedForPreorder property is set.
        /// </summary>
        /// <returns>true if ShipmentConfirmedForPreorder property is set.</returns>
        public bool IsSetShipmentConfirmedForPreorder()
        {
            return this._shipmentConfirmedForPreorder != null;
        }

        /// <summary>
        /// Gets and sets the NeedByDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NeedByDate")]
        public string NeedByDate
        {
            get { return this._needByDate; }
            set { this._needByDate = value; }
        }

        /// <summary>
        /// Sets the NeedByDate property.
        /// </summary>
        /// <param name="needByDate">NeedByDate property.</param>
        /// <returns>this instance.</returns>
        public GetPreorderInfoResult WithNeedByDate(string needByDate)
        {
            this._needByDate = needByDate;
            return this;
        }

        /// <summary>
        /// Checks if NeedByDate property is set.
        /// </summary>
        /// <returns>true if NeedByDate property is set.</returns>
        public bool IsSetNeedByDate()
        {
            return this._needByDate != null;
        }

        /// <summary>
        /// Gets and sets the ConfirmedFulfillableDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ConfirmedFulfillableDate")]
        public string ConfirmedFulfillableDate
        {
            get { return this._confirmedFulfillableDate; }
            set { this._confirmedFulfillableDate = value; }
        }

        /// <summary>
        /// Sets the ConfirmedFulfillableDate property.
        /// </summary>
        /// <param name="confirmedFulfillableDate">ConfirmedFulfillableDate property.</param>
        /// <returns>this instance.</returns>
        public GetPreorderInfoResult WithConfirmedFulfillableDate(string confirmedFulfillableDate)
        {
            this._confirmedFulfillableDate = confirmedFulfillableDate;
            return this;
        }

        /// <summary>
        /// Checks if ConfirmedFulfillableDate property is set.
        /// </summary>
        /// <returns>true if ConfirmedFulfillableDate property is set.</returns>
        public bool IsSetConfirmedFulfillableDate()
        {
            return this._confirmedFulfillableDate != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _shipmentContainsPreorderableItems = reader.Read<bool?>("ShipmentContainsPreorderableItems");
            _shipmentConfirmedForPreorder = reader.Read<bool?>("ShipmentConfirmedForPreorder");
            _needByDate = reader.Read<string>("NeedByDate");
            _confirmedFulfillableDate = reader.Read<string>("ConfirmedFulfillableDate");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ShipmentContainsPreorderableItems", _shipmentContainsPreorderableItems);
            writer.Write("ShipmentConfirmedForPreorder", _shipmentConfirmedForPreorder);
            writer.Write("NeedByDate", _needByDate);
            writer.Write("ConfirmedFulfillableDate", _confirmedFulfillableDate);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "GetPreorderInfoResult", this);
        }


        public GetPreorderInfoResult() : base()
        {
        }
    }
}
