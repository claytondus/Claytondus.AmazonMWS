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
 * Return Item
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
    public class ReturnItem : AbstractMwsObject
    {

        private string _sellerReturnItemId;
        private string _sellerFulfillmentOrderItemId;
        private string _amazonShipmentId;
        private string _sellerReturnReasonCode;
        private string _returnComment;
        private string _amazonReturnReasonCode;
        private string _status;
        private DateTime? _statusChangedDate;
        private string _returnAuthorizationId;
        private string _returnReceivedCondition;
        private string _fulfillmentCenterId;

        /// <summary>
        /// Gets and sets the SellerReturnItemId property.
        /// </summary>
        [XmlElement(ElementName = "SellerReturnItemId")]
        public string SellerReturnItemId
        {
            get { return this._sellerReturnItemId; }
            set { this._sellerReturnItemId = value; }
        }

        /// <summary>
        /// Sets the SellerReturnItemId property.
        /// </summary>
        /// <param name="sellerReturnItemId">SellerReturnItemId property.</param>
        /// <returns>this instance.</returns>
        public ReturnItem WithSellerReturnItemId(string sellerReturnItemId)
        {
            this._sellerReturnItemId = sellerReturnItemId;
            return this;
        }

        /// <summary>
        /// Checks if SellerReturnItemId property is set.
        /// </summary>
        /// <returns>true if SellerReturnItemId property is set.</returns>
        public bool IsSetSellerReturnItemId()
        {
            return this._sellerReturnItemId != null;
        }

        /// <summary>
        /// Gets and sets the SellerFulfillmentOrderItemId property.
        /// </summary>
        [XmlElement(ElementName = "SellerFulfillmentOrderItemId")]
        public string SellerFulfillmentOrderItemId
        {
            get { return this._sellerFulfillmentOrderItemId; }
            set { this._sellerFulfillmentOrderItemId = value; }
        }

        /// <summary>
        /// Sets the SellerFulfillmentOrderItemId property.
        /// </summary>
        /// <param name="sellerFulfillmentOrderItemId">SellerFulfillmentOrderItemId property.</param>
        /// <returns>this instance.</returns>
        public ReturnItem WithSellerFulfillmentOrderItemId(string sellerFulfillmentOrderItemId)
        {
            this._sellerFulfillmentOrderItemId = sellerFulfillmentOrderItemId;
            return this;
        }

        /// <summary>
        /// Checks if SellerFulfillmentOrderItemId property is set.
        /// </summary>
        /// <returns>true if SellerFulfillmentOrderItemId property is set.</returns>
        public bool IsSetSellerFulfillmentOrderItemId()
        {
            return this._sellerFulfillmentOrderItemId != null;
        }

        /// <summary>
        /// Gets and sets the AmazonShipmentId property.
        /// </summary>
        [XmlElement(ElementName = "AmazonShipmentId")]
        public string AmazonShipmentId
        {
            get { return this._amazonShipmentId; }
            set { this._amazonShipmentId = value; }
        }

        /// <summary>
        /// Sets the AmazonShipmentId property.
        /// </summary>
        /// <param name="amazonShipmentId">AmazonShipmentId property.</param>
        /// <returns>this instance.</returns>
        public ReturnItem WithAmazonShipmentId(string amazonShipmentId)
        {
            this._amazonShipmentId = amazonShipmentId;
            return this;
        }

        /// <summary>
        /// Checks if AmazonShipmentId property is set.
        /// </summary>
        /// <returns>true if AmazonShipmentId property is set.</returns>
        public bool IsSetAmazonShipmentId()
        {
            return this._amazonShipmentId != null;
        }

        /// <summary>
        /// Gets and sets the SellerReturnReasonCode property.
        /// </summary>
        [XmlElement(ElementName = "SellerReturnReasonCode")]
        public string SellerReturnReasonCode
        {
            get { return this._sellerReturnReasonCode; }
            set { this._sellerReturnReasonCode = value; }
        }

        /// <summary>
        /// Sets the SellerReturnReasonCode property.
        /// </summary>
        /// <param name="sellerReturnReasonCode">SellerReturnReasonCode property.</param>
        /// <returns>this instance.</returns>
        public ReturnItem WithSellerReturnReasonCode(string sellerReturnReasonCode)
        {
            this._sellerReturnReasonCode = sellerReturnReasonCode;
            return this;
        }

        /// <summary>
        /// Checks if SellerReturnReasonCode property is set.
        /// </summary>
        /// <returns>true if SellerReturnReasonCode property is set.</returns>
        public bool IsSetSellerReturnReasonCode()
        {
            return this._sellerReturnReasonCode != null;
        }

        /// <summary>
        /// Gets and sets the ReturnComment property.
        /// </summary>
        [XmlElement(ElementName = "ReturnComment")]
        public string ReturnComment
        {
            get { return this._returnComment; }
            set { this._returnComment = value; }
        }

        /// <summary>
        /// Sets the ReturnComment property.
        /// </summary>
        /// <param name="returnComment">ReturnComment property.</param>
        /// <returns>this instance.</returns>
        public ReturnItem WithReturnComment(string returnComment)
        {
            this._returnComment = returnComment;
            return this;
        }

        /// <summary>
        /// Checks if ReturnComment property is set.
        /// </summary>
        /// <returns>true if ReturnComment property is set.</returns>
        public bool IsSetReturnComment()
        {
            return this._returnComment != null;
        }

        /// <summary>
        /// Gets and sets the AmazonReturnReasonCode property.
        /// </summary>
        [XmlElement(ElementName = "AmazonReturnReasonCode")]
        public string AmazonReturnReasonCode
        {
            get { return this._amazonReturnReasonCode; }
            set { this._amazonReturnReasonCode = value; }
        }

        /// <summary>
        /// Sets the AmazonReturnReasonCode property.
        /// </summary>
        /// <param name="amazonReturnReasonCode">AmazonReturnReasonCode property.</param>
        /// <returns>this instance.</returns>
        public ReturnItem WithAmazonReturnReasonCode(string amazonReturnReasonCode)
        {
            this._amazonReturnReasonCode = amazonReturnReasonCode;
            return this;
        }

        /// <summary>
        /// Checks if AmazonReturnReasonCode property is set.
        /// </summary>
        /// <returns>true if AmazonReturnReasonCode property is set.</returns>
        public bool IsSetAmazonReturnReasonCode()
        {
            return this._amazonReturnReasonCode != null;
        }

        /// <summary>
        /// Gets and sets the Status property.
        /// </summary>
        [XmlElement(ElementName = "Status")]
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
        public ReturnItem WithStatus(string status)
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
        /// Gets and sets the StatusChangedDate property.
        /// </summary>
        [XmlElement(ElementName = "StatusChangedDate")]
        public DateTime StatusChangedDate
        {
            get { return this._statusChangedDate.GetValueOrDefault(); }
            set { this._statusChangedDate = value; }
        }

        /// <summary>
        /// Sets the StatusChangedDate property.
        /// </summary>
        /// <param name="statusChangedDate">StatusChangedDate property.</param>
        /// <returns>this instance.</returns>
        public ReturnItem WithStatusChangedDate(DateTime statusChangedDate)
        {
            this._statusChangedDate = statusChangedDate;
            return this;
        }

        /// <summary>
        /// Checks if StatusChangedDate property is set.
        /// </summary>
        /// <returns>true if StatusChangedDate property is set.</returns>
        public bool IsSetStatusChangedDate()
        {
            return this._statusChangedDate != null;
        }

        /// <summary>
        /// Gets and sets the ReturnAuthorizationId property.
        /// </summary>
        [XmlElement(ElementName = "ReturnAuthorizationId")]
        public string ReturnAuthorizationId
        {
            get { return this._returnAuthorizationId; }
            set { this._returnAuthorizationId = value; }
        }

        /// <summary>
        /// Sets the ReturnAuthorizationId property.
        /// </summary>
        /// <param name="returnAuthorizationId">ReturnAuthorizationId property.</param>
        /// <returns>this instance.</returns>
        public ReturnItem WithReturnAuthorizationId(string returnAuthorizationId)
        {
            this._returnAuthorizationId = returnAuthorizationId;
            return this;
        }

        /// <summary>
        /// Checks if ReturnAuthorizationId property is set.
        /// </summary>
        /// <returns>true if ReturnAuthorizationId property is set.</returns>
        public bool IsSetReturnAuthorizationId()
        {
            return this._returnAuthorizationId != null;
        }

        /// <summary>
        /// Gets and sets the ReturnReceivedCondition property.
        /// </summary>
        [XmlElement(ElementName = "ReturnReceivedCondition")]
        public string ReturnReceivedCondition
        {
            get { return this._returnReceivedCondition; }
            set { this._returnReceivedCondition = value; }
        }

        /// <summary>
        /// Sets the ReturnReceivedCondition property.
        /// </summary>
        /// <param name="returnReceivedCondition">ReturnReceivedCondition property.</param>
        /// <returns>this instance.</returns>
        public ReturnItem WithReturnReceivedCondition(string returnReceivedCondition)
        {
            this._returnReceivedCondition = returnReceivedCondition;
            return this;
        }

        /// <summary>
        /// Checks if ReturnReceivedCondition property is set.
        /// </summary>
        /// <returns>true if ReturnReceivedCondition property is set.</returns>
        public bool IsSetReturnReceivedCondition()
        {
            return this._returnReceivedCondition != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentCenterId property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentCenterId")]
        public string FulfillmentCenterId
        {
            get { return this._fulfillmentCenterId; }
            set { this._fulfillmentCenterId = value; }
        }

        /// <summary>
        /// Sets the FulfillmentCenterId property.
        /// </summary>
        /// <param name="fulfillmentCenterId">FulfillmentCenterId property.</param>
        /// <returns>this instance.</returns>
        public ReturnItem WithFulfillmentCenterId(string fulfillmentCenterId)
        {
            this._fulfillmentCenterId = fulfillmentCenterId;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentCenterId property is set.
        /// </summary>
        /// <returns>true if FulfillmentCenterId property is set.</returns>
        public bool IsSetFulfillmentCenterId()
        {
            return this._fulfillmentCenterId != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerReturnItemId = reader.Read<string>("SellerReturnItemId");
            _sellerFulfillmentOrderItemId = reader.Read<string>("SellerFulfillmentOrderItemId");
            _amazonShipmentId = reader.Read<string>("AmazonShipmentId");
            _sellerReturnReasonCode = reader.Read<string>("SellerReturnReasonCode");
            _returnComment = reader.Read<string>("ReturnComment");
            _amazonReturnReasonCode = reader.Read<string>("AmazonReturnReasonCode");
            _status = reader.Read<string>("Status");
            _statusChangedDate = reader.Read<DateTime?>("StatusChangedDate");
            _returnAuthorizationId = reader.Read<string>("ReturnAuthorizationId");
            _returnReceivedCondition = reader.Read<string>("ReturnReceivedCondition");
            _fulfillmentCenterId = reader.Read<string>("FulfillmentCenterId");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerReturnItemId", _sellerReturnItemId);
            writer.Write("SellerFulfillmentOrderItemId", _sellerFulfillmentOrderItemId);
            writer.Write("AmazonShipmentId", _amazonShipmentId);
            writer.Write("SellerReturnReasonCode", _sellerReturnReasonCode);
            writer.Write("ReturnComment", _returnComment);
            writer.Write("AmazonReturnReasonCode", _amazonReturnReasonCode);
            writer.Write("Status", _status);
            writer.Write("StatusChangedDate", _statusChangedDate);
            writer.Write("ReturnAuthorizationId", _returnAuthorizationId);
            writer.Write("ReturnReceivedCondition", _returnReceivedCondition);
            writer.Write("FulfillmentCenterId", _fulfillmentCenterId);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "ReturnItem", this);
        }

    public ReturnItem (string sellerReturnItemId,string sellerFulfillmentOrderItemId,string amazonShipmentId,string sellerReturnReasonCode,string status,DateTime? statusChangedDate) : base() {
        this._sellerReturnItemId = sellerReturnItemId;
        this._sellerFulfillmentOrderItemId = sellerFulfillmentOrderItemId;
        this._amazonShipmentId = amazonShipmentId;
        this._sellerReturnReasonCode = sellerReturnReasonCode;
        this._status = status;
        this._statusChangedDate = statusChangedDate;
    }

        public ReturnItem() : base()
        {
        }
    }
}
