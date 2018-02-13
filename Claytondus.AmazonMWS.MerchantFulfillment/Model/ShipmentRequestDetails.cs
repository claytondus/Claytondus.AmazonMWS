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
 * Shipment Request Details
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */


using System;
using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class ShipmentRequestDetails : AbstractMwsObject
    {

        private string _amazonOrderId;
        private string _sellerOrderId;
        private List<Item> _itemList;
        private Address _shipFromAddress;
        private PackageDimensions _packageDimensions;
        private Weight _weight;
        private DateTime? _mustArriveByDate;
        private DateTime? _shipDate;
        private ShippingServiceOptions _shippingServiceOptions;
        private LabelCustomization _labelCustomization;

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
        public ShipmentRequestDetails WithAmazonOrderId(string amazonOrderId)
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
        public ShipmentRequestDetails WithSellerOrderId(string sellerOrderId)
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
        public ShipmentRequestDetails WithItemList(Item[] itemList)
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
        public ShipmentRequestDetails WithShipFromAddress(Address shipFromAddress)
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
        public ShipmentRequestDetails WithPackageDimensions(PackageDimensions packageDimensions)
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
        public ShipmentRequestDetails WithWeight(Weight weight)
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
        /// Gets and sets the MustArriveByDate property.
        /// </summary>
        public DateTime MustArriveByDate
        {
            get { return this._mustArriveByDate.GetValueOrDefault(); }
            set { this._mustArriveByDate = value; }
        }

        /// <summary>
        /// Sets the MustArriveByDate property.
        /// </summary>
        /// <param name="mustArriveByDate">MustArriveByDate property.</param>
        /// <returns>this instance.</returns>
        public ShipmentRequestDetails WithMustArriveByDate(DateTime mustArriveByDate)
        {
            this._mustArriveByDate = mustArriveByDate;
            return this;
        }

        /// <summary>
        /// Checks if MustArriveByDate property is set.
        /// </summary>
        /// <returns>true if MustArriveByDate property is set.</returns>
        public bool IsSetMustArriveByDate()
        {
            return this._mustArriveByDate != null;
        }

        /// <summary>
        /// Gets and sets the ShipDate property.
        /// </summary>
        public DateTime ShipDate
        {
            get { return this._shipDate.GetValueOrDefault(); }
            set { this._shipDate = value; }
        }

        /// <summary>
        /// Sets the ShipDate property.
        /// </summary>
        /// <param name="shipDate">ShipDate property.</param>
        /// <returns>this instance.</returns>
        public ShipmentRequestDetails WithShipDate(DateTime shipDate)
        {
            this._shipDate = shipDate;
            return this;
        }

        /// <summary>
        /// Checks if ShipDate property is set.
        /// </summary>
        /// <returns>true if ShipDate property is set.</returns>
        public bool IsSetShipDate()
        {
            return this._shipDate != null;
        }

        /// <summary>
        /// Gets and sets the ShippingServiceOptions property.
        /// </summary>
        public ShippingServiceOptions ShippingServiceOptions
        {
            get { return this._shippingServiceOptions; }
            set { this._shippingServiceOptions = value; }
        }

        /// <summary>
        /// Sets the ShippingServiceOptions property.
        /// </summary>
        /// <param name="shippingServiceOptions">ShippingServiceOptions property.</param>
        /// <returns>this instance.</returns>
        public ShipmentRequestDetails WithShippingServiceOptions(ShippingServiceOptions shippingServiceOptions)
        {
            this._shippingServiceOptions = shippingServiceOptions;
            return this;
        }

        /// <summary>
        /// Checks if ShippingServiceOptions property is set.
        /// </summary>
        /// <returns>true if ShippingServiceOptions property is set.</returns>
        public bool IsSetShippingServiceOptions()
        {
            return this._shippingServiceOptions != null;
        }

        /// <summary>
        /// Gets and sets the LabelCustomization property.
        /// </summary>
        public LabelCustomization LabelCustomization
        {
            get { return this._labelCustomization; }
            set { this._labelCustomization = value; }
        }

        /// <summary>
        /// Sets the LabelCustomization property.
        /// </summary>
        /// <param name="labelCustomization">LabelCustomization property.</param>
        /// <returns>this instance.</returns>
        public ShipmentRequestDetails WithLabelCustomization(LabelCustomization labelCustomization)
        {
            this._labelCustomization = labelCustomization;
            return this;
        }

        /// <summary>
        /// Checks if LabelCustomization property is set.
        /// </summary>
        /// <returns>true if LabelCustomization property is set.</returns>
        public bool IsSetLabelCustomization()
        {
            return this._labelCustomization != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _amazonOrderId = reader.Read<string>("AmazonOrderId");
            _sellerOrderId = reader.Read<string>("SellerOrderId");
            _itemList = reader.ReadList<Item>("ItemList", "Item");
            _shipFromAddress = reader.Read<Address>("ShipFromAddress");
            _packageDimensions = reader.Read<PackageDimensions>("PackageDimensions");
            _weight = reader.Read<Weight>("Weight");
            _mustArriveByDate = reader.Read<DateTime?>("MustArriveByDate");
            _shipDate = reader.Read<DateTime?>("ShipDate");
            _shippingServiceOptions = reader.Read<ShippingServiceOptions>("ShippingServiceOptions");
            _labelCustomization = reader.Read<LabelCustomization>("LabelCustomization");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("AmazonOrderId", _amazonOrderId);
            writer.Write("SellerOrderId", _sellerOrderId);
            writer.WriteList("ItemList", "Item", _itemList);
            writer.Write("ShipFromAddress", _shipFromAddress);
            writer.Write("PackageDimensions", _packageDimensions);
            writer.Write("Weight", _weight);
            writer.Write("MustArriveByDate", _mustArriveByDate);
            writer.Write("ShipDate", _shipDate);
            writer.Write("ShippingServiceOptions", _shippingServiceOptions);
            writer.Write("LabelCustomization", _labelCustomization);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "ShipmentRequestDetails", this);
        }

    public ShipmentRequestDetails (string amazonOrderId,List<Item> itemList,Address shipFromAddress,PackageDimensions packageDimensions,Weight weight,ShippingServiceOptions shippingServiceOptions) : base() {
        this._amazonOrderId = amazonOrderId;
        this._itemList = itemList;
        this._shipFromAddress = shipFromAddress;
        this._packageDimensions = packageDimensions;
        this._weight = weight;
        this._shippingServiceOptions = shippingServiceOptions;
    }

        public ShipmentRequestDetails() : base()
        {
        }
    }
}
