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
 * Shipment
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */


using System;
using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class Shipment : AbstractMwsObject
    {

        private string _shipmentId;
        private string _amazonOrderId;
        private string _sellerOrderId;
        private List<Item> _itemList;
        private Address _shipFromAddress;
        private Address _shipToAddress;
        private PackageDimensions _packageDimensions;
        private Weight _weight;
        private CurrencyAmount _insurance;
        private ShippingService _shippingService;
        private Label _label;
        private string _status;
        private string _trackingId;
        private DateTime? _createdDate;
        private DateTime? _lastUpdatedDate;

        /// <summary>
        /// Gets and sets the ShipmentId property.
        /// </summary>
        public string ShipmentId
        {
            get { return this._shipmentId; }
            set { this._shipmentId = value; }
        }

        /// <summary>
        /// Sets the ShipmentId property.
        /// </summary>
        /// <param name="shipmentId">ShipmentId property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithShipmentId(string shipmentId)
        {
            this._shipmentId = shipmentId;
            return this;
        }

        /// <summary>
        /// Checks if ShipmentId property is set.
        /// </summary>
        /// <returns>true if ShipmentId property is set.</returns>
        public bool IsSetShipmentId()
        {
            return this._shipmentId != null;
        }

        /// <summary>
        /// Gets and sets the AmazonOrderId property.
        /// </summary>
        public string AmazonOrderId
        {
            get { return this._amazonOrderId; }
            set { this._amazonOrderId = value; }
        }

        /// <summary>
        /// Sets the AmazonOrderId property.
        /// </summary>
        /// <param name="amazonOrderId">AmazonOrderId property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithAmazonOrderId(string amazonOrderId)
        {
            this._amazonOrderId = amazonOrderId;
            return this;
        }

        /// <summary>
        /// Checks if AmazonOrderId property is set.
        /// </summary>
        /// <returns>true if AmazonOrderId property is set.</returns>
        public bool IsSetAmazonOrderId()
        {
            return this._amazonOrderId != null;
        }

        /// <summary>
        /// Gets and sets the SellerOrderId property.
        /// </summary>
        public string SellerOrderId
        {
            get { return this._sellerOrderId; }
            set { this._sellerOrderId = value; }
        }

        /// <summary>
        /// Sets the SellerOrderId property.
        /// </summary>
        /// <param name="sellerOrderId">SellerOrderId property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithSellerOrderId(string sellerOrderId)
        {
            this._sellerOrderId = sellerOrderId;
            return this;
        }

        /// <summary>
        /// Checks if SellerOrderId property is set.
        /// </summary>
        /// <returns>true if SellerOrderId property is set.</returns>
        public bool IsSetSellerOrderId()
        {
            return this._sellerOrderId != null;
        }

        /// <summary>
        /// Gets and sets the ItemList property.
        /// </summary>
        public List<Item> ItemList
        {
            get
            {
                if(this._itemList == null)
                {
                    this._itemList = new List<Item>();
                }
                return this._itemList;
            }
            set { this._itemList = value; }
        }

        /// <summary>
        /// Sets the ItemList property.
        /// </summary>
        /// <param name="itemList">ItemList property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithItemList(Item[] itemList)
        {
            this._itemList.AddRange(itemList);
            return this;
        }

        /// <summary>
        /// Checks if ItemList property is set.
        /// </summary>
        /// <returns>true if ItemList property is set.</returns>
        public bool IsSetItemList()
        {
            return this.ItemList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the ShipFromAddress property.
        /// </summary>
        public Address ShipFromAddress
        {
            get { return this._shipFromAddress; }
            set { this._shipFromAddress = value; }
        }

        /// <summary>
        /// Sets the ShipFromAddress property.
        /// </summary>
        /// <param name="shipFromAddress">ShipFromAddress property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithShipFromAddress(Address shipFromAddress)
        {
            this._shipFromAddress = shipFromAddress;
            return this;
        }

        /// <summary>
        /// Checks if ShipFromAddress property is set.
        /// </summary>
        /// <returns>true if ShipFromAddress property is set.</returns>
        public bool IsSetShipFromAddress()
        {
            return this._shipFromAddress != null;
        }

        /// <summary>
        /// Gets and sets the ShipToAddress property.
        /// </summary>
        public Address ShipToAddress
        {
            get { return this._shipToAddress; }
            set { this._shipToAddress = value; }
        }

        /// <summary>
        /// Sets the ShipToAddress property.
        /// </summary>
        /// <param name="shipToAddress">ShipToAddress property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithShipToAddress(Address shipToAddress)
        {
            this._shipToAddress = shipToAddress;
            return this;
        }

        /// <summary>
        /// Checks if ShipToAddress property is set.
        /// </summary>
        /// <returns>true if ShipToAddress property is set.</returns>
        public bool IsSetShipToAddress()
        {
            return this._shipToAddress != null;
        }

        /// <summary>
        /// Gets and sets the PackageDimensions property.
        /// </summary>
        public PackageDimensions PackageDimensions
        {
            get { return this._packageDimensions; }
            set { this._packageDimensions = value; }
        }

        /// <summary>
        /// Sets the PackageDimensions property.
        /// </summary>
        /// <param name="packageDimensions">PackageDimensions property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithPackageDimensions(PackageDimensions packageDimensions)
        {
            this._packageDimensions = packageDimensions;
            return this;
        }

        /// <summary>
        /// Checks if PackageDimensions property is set.
        /// </summary>
        /// <returns>true if PackageDimensions property is set.</returns>
        public bool IsSetPackageDimensions()
        {
            return this._packageDimensions != null;
        }

        /// <summary>
        /// Gets and sets the Weight property.
        /// </summary>
        public Weight Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        /// <summary>
        /// Sets the Weight property.
        /// </summary>
        /// <param name="weight">Weight property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithWeight(Weight weight)
        {
            this._weight = weight;
            return this;
        }

        /// <summary>
        /// Checks if Weight property is set.
        /// </summary>
        /// <returns>true if Weight property is set.</returns>
        public bool IsSetWeight()
        {
            return this._weight != null;
        }

        /// <summary>
        /// Gets and sets the Insurance property.
        /// </summary>
        public CurrencyAmount Insurance
        {
            get { return this._insurance; }
            set { this._insurance = value; }
        }

        /// <summary>
        /// Sets the Insurance property.
        /// </summary>
        /// <param name="insurance">Insurance property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithInsurance(CurrencyAmount insurance)
        {
            this._insurance = insurance;
            return this;
        }

        /// <summary>
        /// Checks if Insurance property is set.
        /// </summary>
        /// <returns>true if Insurance property is set.</returns>
        public bool IsSetInsurance()
        {
            return this._insurance != null;
        }

        /// <summary>
        /// Gets and sets the ShippingService property.
        /// </summary>
        public ShippingService ShippingService
        {
            get { return this._shippingService; }
            set { this._shippingService = value; }
        }

        /// <summary>
        /// Sets the ShippingService property.
        /// </summary>
        /// <param name="shippingService">ShippingService property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithShippingService(ShippingService shippingService)
        {
            this._shippingService = shippingService;
            return this;
        }

        /// <summary>
        /// Checks if ShippingService property is set.
        /// </summary>
        /// <returns>true if ShippingService property is set.</returns>
        public bool IsSetShippingService()
        {
            return this._shippingService != null;
        }

        /// <summary>
        /// Gets and sets the Label property.
        /// </summary>
        public Label Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        /// <summary>
        /// Sets the Label property.
        /// </summary>
        /// <param name="label">Label property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithLabel(Label label)
        {
            this._label = label;
            return this;
        }

        /// <summary>
        /// Checks if Label property is set.
        /// </summary>
        /// <returns>true if Label property is set.</returns>
        public bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the Status property.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        /// <summary>
        /// Sets the Status property.
        /// </summary>
        /// <param name="status">Status property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithStatus(string status)
        {
            this._status = status;
            return this;
        }

        /// <summary>
        /// Checks if Status property is set.
        /// </summary>
        /// <returns>true if Status property is set.</returns>
        public bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the TrackingId property.
        /// </summary>
        public string TrackingId
        {
            get { return this._trackingId; }
            set { this._trackingId = value; }
        }

        /// <summary>
        /// Sets the TrackingId property.
        /// </summary>
        /// <param name="trackingId">TrackingId property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithTrackingId(string trackingId)
        {
            this._trackingId = trackingId;
            return this;
        }

        /// <summary>
        /// Checks if TrackingId property is set.
        /// </summary>
        /// <returns>true if TrackingId property is set.</returns>
        public bool IsSetTrackingId()
        {
            return this._trackingId != null;
        }

        /// <summary>
        /// Gets and sets the CreatedDate property.
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        /// <summary>
        /// Sets the CreatedDate property.
        /// </summary>
        /// <param name="createdDate">CreatedDate property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithCreatedDate(DateTime createdDate)
        {
            this._createdDate = createdDate;
            return this;
        }

        /// <summary>
        /// Checks if CreatedDate property is set.
        /// </summary>
        /// <returns>true if CreatedDate property is set.</returns>
        public bool IsSetCreatedDate()
        {
            return this._createdDate != null;
        }

        /// <summary>
        /// Gets and sets the LastUpdatedDate property.
        /// </summary>
        public DateTime LastUpdatedDate
        {
            get { return this._lastUpdatedDate.GetValueOrDefault(); }
            set { this._lastUpdatedDate = value; }
        }

        /// <summary>
        /// Sets the LastUpdatedDate property.
        /// </summary>
        /// <param name="lastUpdatedDate">LastUpdatedDate property.</param>
        /// <returns>this instance.</returns>
        public Shipment WithLastUpdatedDate(DateTime lastUpdatedDate)
        {
            this._lastUpdatedDate = lastUpdatedDate;
            return this;
        }

        /// <summary>
        /// Checks if LastUpdatedDate property is set.
        /// </summary>
        /// <returns>true if LastUpdatedDate property is set.</returns>
        public bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _shipmentId = reader.Read<string>("ShipmentId");
            _amazonOrderId = reader.Read<string>("AmazonOrderId");
            _sellerOrderId = reader.Read<string>("SellerOrderId");
            _itemList = reader.ReadList<Item>("ItemList", "Item");
            _shipFromAddress = reader.Read<Address>("ShipFromAddress");
            _shipToAddress = reader.Read<Address>("ShipToAddress");
            _packageDimensions = reader.Read<PackageDimensions>("PackageDimensions");
            _weight = reader.Read<Weight>("Weight");
            _insurance = reader.Read<CurrencyAmount>("Insurance");
            _shippingService = reader.Read<ShippingService>("ShippingService");
            _label = reader.Read<Label>("Label");
            _status = reader.Read<string>("Status");
            _trackingId = reader.Read<string>("TrackingId");
            _createdDate = reader.Read<DateTime?>("CreatedDate");
            _lastUpdatedDate = reader.Read<DateTime?>("LastUpdatedDate");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ShipmentId", _shipmentId);
            writer.Write("AmazonOrderId", _amazonOrderId);
            writer.Write("SellerOrderId", _sellerOrderId);
            writer.WriteList("ItemList", "Item", _itemList);
            writer.Write("ShipFromAddress", _shipFromAddress);
            writer.Write("ShipToAddress", _shipToAddress);
            writer.Write("PackageDimensions", _packageDimensions);
            writer.Write("Weight", _weight);
            writer.Write("Insurance", _insurance);
            writer.Write("ShippingService", _shippingService);
            writer.Write("Label", _label);
            writer.Write("Status", _status);
            writer.Write("TrackingId", _trackingId);
            writer.Write("CreatedDate", _createdDate);
            writer.Write("LastUpdatedDate", _lastUpdatedDate);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "Shipment", this);
        }

    public Shipment (string shipmentId,Address shipFromAddress,Address shipToAddress,PackageDimensions packageDimensions,Weight weight,ShippingService shippingService,string status,DateTime? createdDate) : base() {
        this._shipmentId = shipmentId;
        this._shipFromAddress = shipFromAddress;
        this._shipToAddress = shipToAddress;
        this._packageDimensions = packageDimensions;
        this._weight = weight;
        this._shippingService = shippingService;
        this._status = status;
        this._createdDate = createdDate;
    }

        public Shipment() : base()
        {
        }
    }
}
