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
 * Inventory Supply Detail
 * API Version: 2010-10-01
 * Library Version: 2014-09-30
 * Generated: Mon Mar 21 09:01:30 PDT 2016
 */


using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaInventory.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/", IsNullable = false)]
    public class InventorySupplyDetail : AbstractMwsObject
    {

        private decimal? _quantity;
        private string _supplyType;
        private Timepoint _earliestAvailableToPick;
        private Timepoint _latestAvailableToPick;

        /// <summary>
        /// Gets and sets the Quantity property.
        /// </summary>
        [XmlElement(ElementName = "Quantity")]
        public decimal Quantity
        {
            get { return this._quantity.GetValueOrDefault(); }
            set { this._quantity = value; }
        }

        /// <summary>
        /// Sets the Quantity property.
        /// </summary>
        /// <param name="quantity">Quantity property.</param>
        /// <returns>this instance.</returns>
        public InventorySupplyDetail WithQuantity(decimal quantity)
        {
            this._quantity = quantity;
            return this;
        }

        /// <summary>
        /// Checks if Quantity property is set.
        /// </summary>
        /// <returns>true if Quantity property is set.</returns>
        public bool IsSetQuantity()
        {
            return this._quantity != null;
        }

        /// <summary>
        /// Gets and sets the SupplyType property.
        /// </summary>
        [XmlElement(ElementName = "SupplyType")]
        public string SupplyType
        {
            get { return this._supplyType; }
            set { this._supplyType = value; }
        }

        /// <summary>
        /// Sets the SupplyType property.
        /// </summary>
        /// <param name="supplyType">SupplyType property.</param>
        /// <returns>this instance.</returns>
        public InventorySupplyDetail WithSupplyType(string supplyType)
        {
            this._supplyType = supplyType;
            return this;
        }

        /// <summary>
        /// Checks if SupplyType property is set.
        /// </summary>
        /// <returns>true if SupplyType property is set.</returns>
        public bool IsSetSupplyType()
        {
            return this._supplyType != null;
        }

        /// <summary>
        /// Gets and sets the EarliestAvailableToPick property.
        /// </summary>
        [XmlElement(ElementName = "EarliestAvailableToPick")]
        public Timepoint EarliestAvailableToPick
        {
            get { return this._earliestAvailableToPick; }
            set { this._earliestAvailableToPick = value; }
        }

        /// <summary>
        /// Sets the EarliestAvailableToPick property.
        /// </summary>
        /// <param name="earliestAvailableToPick">EarliestAvailableToPick property.</param>
        /// <returns>this instance.</returns>
        public InventorySupplyDetail WithEarliestAvailableToPick(Timepoint earliestAvailableToPick)
        {
            this._earliestAvailableToPick = earliestAvailableToPick;
            return this;
        }

        /// <summary>
        /// Checks if EarliestAvailableToPick property is set.
        /// </summary>
        /// <returns>true if EarliestAvailableToPick property is set.</returns>
        public bool IsSetEarliestAvailableToPick()
        {
            return this._earliestAvailableToPick != null;
        }

        /// <summary>
        /// Gets and sets the LatestAvailableToPick property.
        /// </summary>
        [XmlElement(ElementName = "LatestAvailableToPick")]
        public Timepoint LatestAvailableToPick
        {
            get { return this._latestAvailableToPick; }
            set { this._latestAvailableToPick = value; }
        }

        /// <summary>
        /// Sets the LatestAvailableToPick property.
        /// </summary>
        /// <param name="latestAvailableToPick">LatestAvailableToPick property.</param>
        /// <returns>this instance.</returns>
        public InventorySupplyDetail WithLatestAvailableToPick(Timepoint latestAvailableToPick)
        {
            this._latestAvailableToPick = latestAvailableToPick;
            return this;
        }

        /// <summary>
        /// Checks if LatestAvailableToPick property is set.
        /// </summary>
        /// <returns>true if LatestAvailableToPick property is set.</returns>
        public bool IsSetLatestAvailableToPick()
        {
            return this._latestAvailableToPick != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _quantity = reader.Read<decimal?>("Quantity");
            _supplyType = reader.Read<string>("SupplyType");
            _earliestAvailableToPick = reader.Read<Timepoint>("EarliestAvailableToPick");
            _latestAvailableToPick = reader.Read<Timepoint>("LatestAvailableToPick");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Quantity", _quantity);
            writer.Write("SupplyType", _supplyType);
            writer.Write("EarliestAvailableToPick", _earliestAvailableToPick);
            writer.Write("LatestAvailableToPick", _latestAvailableToPick);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/", "InventorySupplyDetail", this);
        }

        public InventorySupplyDetail() : base()
        {
        }
    }
}
