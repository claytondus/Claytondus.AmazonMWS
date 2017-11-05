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
 * Fulfillment Preview
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
    public class FulfillmentPreview : AbstractMwsObject
    {

        private string _shippingSpeedCategory;
        private ScheduledDeliveryInfo _scheduledDeliveryInfo;
        private bool _isFulfillable;
        private bool? _isCODCapable;
        private Weight _estimatedShippingWeight;
        private FeeList _estimatedFees;
        private FulfillmentPreviewShipmentList _fulfillmentPreviewShipments;
        private UnfulfillablePreviewItemList _unfulfillablePreviewItems;
        private StringList _orderUnfulfillableReasons;
        private string _marketplaceId;

        /// <summary>
        /// Gets and sets the ShippingSpeedCategory property.
        /// </summary>
        [XmlElement(ElementName = "ShippingSpeedCategory")]
        public string ShippingSpeedCategory
        {
            get { return this._shippingSpeedCategory; }
            set { this._shippingSpeedCategory = value; }
        }

        /// <summary>
        /// Sets the ShippingSpeedCategory property.
        /// </summary>
        /// <param name="shippingSpeedCategory">ShippingSpeedCategory property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreview WithShippingSpeedCategory(string shippingSpeedCategory)
        {
            this._shippingSpeedCategory = shippingSpeedCategory;
            return this;
        }

        /// <summary>
        /// Checks if ShippingSpeedCategory property is set.
        /// </summary>
        /// <returns>true if ShippingSpeedCategory property is set.</returns>
        public bool IsSetShippingSpeedCategory()
        {
            return this._shippingSpeedCategory != null;
        }

        /// <summary>
        /// Gets and sets the ScheduledDeliveryInfo property.
        /// </summary>
        [XmlElement(ElementName = "ScheduledDeliveryInfo")]
        public ScheduledDeliveryInfo ScheduledDeliveryInfo
        {
            get { return this._scheduledDeliveryInfo; }
            set { this._scheduledDeliveryInfo = value; }
        }

        /// <summary>
        /// Sets the ScheduledDeliveryInfo property.
        /// </summary>
        /// <param name="scheduledDeliveryInfo">ScheduledDeliveryInfo property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreview WithScheduledDeliveryInfo(ScheduledDeliveryInfo scheduledDeliveryInfo)
        {
            this._scheduledDeliveryInfo = scheduledDeliveryInfo;
            return this;
        }

        /// <summary>
        /// Checks if ScheduledDeliveryInfo property is set.
        /// </summary>
        /// <returns>true if ScheduledDeliveryInfo property is set.</returns>
        public bool IsSetScheduledDeliveryInfo()
        {
            return this._scheduledDeliveryInfo != null;
        }

        /// <summary>
        /// Gets and sets the IsFulfillable property.
        /// </summary>
        [XmlElement(ElementName = "IsFulfillable")]
        public bool IsFulfillable
        {
            get { return this._isFulfillable; }
            set { this._isFulfillable = value; }
        }

        /// <summary>
        /// Sets the IsFulfillable property.
        /// </summary>
        /// <param name="isFulfillable">IsFulfillable property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreview WithIsFulfillable(bool isFulfillable)
        {
            this._isFulfillable = isFulfillable;
            return this;
        }

        /// <summary>
        /// Checks if IsFulfillable property is set.
        /// </summary>
        /// <returns>true if IsFulfillable property is set.</returns>
        public bool IsSetIsFulfillable()
        {
            return this._isFulfillable != null;
        }

        /// <summary>
        /// Gets and sets the IsCODCapable property.
        /// </summary>
        [XmlElement(ElementName = "IsCODCapable")]
        public bool IsCODCapable
        {
            get { return this._isCODCapable.GetValueOrDefault(); }
            set { this._isCODCapable = value; }
        }

        /// <summary>
        /// Sets the IsCODCapable property.
        /// </summary>
        /// <param name="isCODCapable">IsCODCapable property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreview WithIsCODCapable(bool isCODCapable)
        {
            this._isCODCapable = isCODCapable;
            return this;
        }

        /// <summary>
        /// Checks if IsCODCapable property is set.
        /// </summary>
        /// <returns>true if IsCODCapable property is set.</returns>
        public bool IsSetIsCODCapable()
        {
            return this._isCODCapable != null;
        }

        /// <summary>
        /// Gets and sets the EstimatedShippingWeight property.
        /// </summary>
        [XmlElement(ElementName = "EstimatedShippingWeight")]
        public Weight EstimatedShippingWeight
        {
            get { return this._estimatedShippingWeight; }
            set { this._estimatedShippingWeight = value; }
        }

        /// <summary>
        /// Sets the EstimatedShippingWeight property.
        /// </summary>
        /// <param name="estimatedShippingWeight">EstimatedShippingWeight property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreview WithEstimatedShippingWeight(Weight estimatedShippingWeight)
        {
            this._estimatedShippingWeight = estimatedShippingWeight;
            return this;
        }

        /// <summary>
        /// Checks if EstimatedShippingWeight property is set.
        /// </summary>
        /// <returns>true if EstimatedShippingWeight property is set.</returns>
        public bool IsSetEstimatedShippingWeight()
        {
            return this._estimatedShippingWeight != null;
        }

        /// <summary>
        /// Gets and sets the EstimatedFees property.
        /// </summary>
        [XmlElement(ElementName = "EstimatedFees")]
        public FeeList EstimatedFees
        {
            get { return this._estimatedFees; }
            set { this._estimatedFees = value; }
        }

        /// <summary>
        /// Sets the EstimatedFees property.
        /// </summary>
        /// <param name="estimatedFees">EstimatedFees property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreview WithEstimatedFees(FeeList estimatedFees)
        {
            this._estimatedFees = estimatedFees;
            return this;
        }

        /// <summary>
        /// Checks if EstimatedFees property is set.
        /// </summary>
        /// <returns>true if EstimatedFees property is set.</returns>
        public bool IsSetEstimatedFees()
        {
            return this._estimatedFees != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentPreviewShipments property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentPreviewShipments")]
        public FulfillmentPreviewShipmentList FulfillmentPreviewShipments
        {
            get { return this._fulfillmentPreviewShipments; }
            set { this._fulfillmentPreviewShipments = value; }
        }

        /// <summary>
        /// Sets the FulfillmentPreviewShipments property.
        /// </summary>
        /// <param name="fulfillmentPreviewShipments">FulfillmentPreviewShipments property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreview WithFulfillmentPreviewShipments(FulfillmentPreviewShipmentList fulfillmentPreviewShipments)
        {
            this._fulfillmentPreviewShipments = fulfillmentPreviewShipments;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentPreviewShipments property is set.
        /// </summary>
        /// <returns>true if FulfillmentPreviewShipments property is set.</returns>
        public bool IsSetFulfillmentPreviewShipments()
        {
            return this._fulfillmentPreviewShipments != null;
        }

        /// <summary>
        /// Gets and sets the UnfulfillablePreviewItems property.
        /// </summary>
        [XmlElement(ElementName = "UnfulfillablePreviewItems")]
        public UnfulfillablePreviewItemList UnfulfillablePreviewItems
        {
            get { return this._unfulfillablePreviewItems; }
            set { this._unfulfillablePreviewItems = value; }
        }

        /// <summary>
        /// Sets the UnfulfillablePreviewItems property.
        /// </summary>
        /// <param name="unfulfillablePreviewItems">UnfulfillablePreviewItems property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreview WithUnfulfillablePreviewItems(UnfulfillablePreviewItemList unfulfillablePreviewItems)
        {
            this._unfulfillablePreviewItems = unfulfillablePreviewItems;
            return this;
        }

        /// <summary>
        /// Checks if UnfulfillablePreviewItems property is set.
        /// </summary>
        /// <returns>true if UnfulfillablePreviewItems property is set.</returns>
        public bool IsSetUnfulfillablePreviewItems()
        {
            return this._unfulfillablePreviewItems != null;
        }

        /// <summary>
        /// Gets and sets the OrderUnfulfillableReasons property.
        /// </summary>
        [XmlElement(ElementName = "OrderUnfulfillableReasons")]
        public StringList OrderUnfulfillableReasons
        {
            get { return this._orderUnfulfillableReasons; }
            set { this._orderUnfulfillableReasons = value; }
        }

        /// <summary>
        /// Sets the OrderUnfulfillableReasons property.
        /// </summary>
        /// <param name="orderUnfulfillableReasons">OrderUnfulfillableReasons property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreview WithOrderUnfulfillableReasons(StringList orderUnfulfillableReasons)
        {
            this._orderUnfulfillableReasons = orderUnfulfillableReasons;
            return this;
        }

        /// <summary>
        /// Checks if OrderUnfulfillableReasons property is set.
        /// </summary>
        /// <returns>true if OrderUnfulfillableReasons property is set.</returns>
        public bool IsSetOrderUnfulfillableReasons()
        {
            return this._orderUnfulfillableReasons != null;
        }

        /// <summary>
        /// Gets and sets the MarketplaceId property.
        /// </summary>
        [XmlElement(ElementName = "MarketplaceId")]
        public string MarketplaceId
        {
            get { return this._marketplaceId; }
            set { this._marketplaceId = value; }
        }

        /// <summary>
        /// Sets the MarketplaceId property.
        /// </summary>
        /// <param name="marketplaceId">MarketplaceId property.</param>
        /// <returns>this instance.</returns>
        public FulfillmentPreview WithMarketplaceId(string marketplaceId)
        {
            this._marketplaceId = marketplaceId;
            return this;
        }

        /// <summary>
        /// Checks if MarketplaceId property is set.
        /// </summary>
        /// <returns>true if MarketplaceId property is set.</returns>
        public bool IsSetMarketplaceId()
        {
            return this._marketplaceId != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _shippingSpeedCategory = reader.Read<string>("ShippingSpeedCategory");
            _scheduledDeliveryInfo = reader.Read<ScheduledDeliveryInfo>("ScheduledDeliveryInfo");
            _isFulfillable = reader.Read<bool>("IsFulfillable");
            _isCODCapable = reader.Read<bool?>("IsCODCapable");
            _estimatedShippingWeight = reader.Read<Weight>("EstimatedShippingWeight");
            _estimatedFees = reader.Read<FeeList>("EstimatedFees");
            _fulfillmentPreviewShipments = reader.Read<FulfillmentPreviewShipmentList>("FulfillmentPreviewShipments");
            _unfulfillablePreviewItems = reader.Read<UnfulfillablePreviewItemList>("UnfulfillablePreviewItems");
            _orderUnfulfillableReasons = reader.Read<StringList>("OrderUnfulfillableReasons");
            _marketplaceId = reader.Read<string>("MarketplaceId");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ShippingSpeedCategory", _shippingSpeedCategory);
            writer.Write("ScheduledDeliveryInfo", _scheduledDeliveryInfo);
            writer.Write("IsFulfillable", _isFulfillable);
            writer.Write("IsCODCapable", _isCODCapable);
            writer.Write("EstimatedShippingWeight", _estimatedShippingWeight);
            writer.Write("EstimatedFees", _estimatedFees);
            writer.Write("FulfillmentPreviewShipments", _fulfillmentPreviewShipments);
            writer.Write("UnfulfillablePreviewItems", _unfulfillablePreviewItems);
            writer.Write("OrderUnfulfillableReasons", _orderUnfulfillableReasons);
            writer.Write("MarketplaceId", _marketplaceId);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "FulfillmentPreview", this);
        }

    public FulfillmentPreview (string shippingSpeedCategory,bool isFulfillable) : base() {
        this._shippingSpeedCategory = shippingSpeedCategory;
        this._isFulfillable = isFulfillable;
    }

        public FulfillmentPreview() : base()
        {
        }
    }
}
