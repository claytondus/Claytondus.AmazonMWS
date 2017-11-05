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
 * Create Return Item
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
    public class CreateReturnItem : AbstractMwsObject
    {

        private string _sellerReturnItemId;
        private string _sellerFulfillmentOrderItemId;
        private string _amazonShipmentId;
        private string _returnReasonCode;
        private string _returnComment;

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
        public CreateReturnItem WithSellerReturnItemId(string sellerReturnItemId)
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
        public CreateReturnItem WithSellerFulfillmentOrderItemId(string sellerFulfillmentOrderItemId)
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
        public CreateReturnItem WithAmazonShipmentId(string amazonShipmentId)
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
        /// Gets and sets the ReturnReasonCode property.
        /// </summary>
        [XmlElement(ElementName = "ReturnReasonCode")]
        public string ReturnReasonCode
        {
            get { return this._returnReasonCode; }
            set { this._returnReasonCode = value; }
        }

        /// <summary>
        /// Sets the ReturnReasonCode property.
        /// </summary>
        /// <param name="returnReasonCode">ReturnReasonCode property.</param>
        /// <returns>this instance.</returns>
        public CreateReturnItem WithReturnReasonCode(string returnReasonCode)
        {
            this._returnReasonCode = returnReasonCode;
            return this;
        }

        /// <summary>
        /// Checks if ReturnReasonCode property is set.
        /// </summary>
        /// <returns>true if ReturnReasonCode property is set.</returns>
        public bool IsSetReturnReasonCode()
        {
            return this._returnReasonCode != null;
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
        public CreateReturnItem WithReturnComment(string returnComment)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerReturnItemId = reader.Read<string>("SellerReturnItemId");
            _sellerFulfillmentOrderItemId = reader.Read<string>("SellerFulfillmentOrderItemId");
            _amazonShipmentId = reader.Read<string>("AmazonShipmentId");
            _returnReasonCode = reader.Read<string>("ReturnReasonCode");
            _returnComment = reader.Read<string>("ReturnComment");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerReturnItemId", _sellerReturnItemId);
            writer.Write("SellerFulfillmentOrderItemId", _sellerFulfillmentOrderItemId);
            writer.Write("AmazonShipmentId", _amazonShipmentId);
            writer.Write("ReturnReasonCode", _returnReasonCode);
            writer.Write("ReturnComment", _returnComment);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "CreateReturnItem", this);
        }

    public CreateReturnItem (string sellerReturnItemId,string sellerFulfillmentOrderItemId,string amazonShipmentId,string returnReasonCode) : base() {
        this._sellerReturnItemId = sellerReturnItemId;
        this._sellerFulfillmentOrderItemId = sellerFulfillmentOrderItemId;
        this._amazonShipmentId = amazonShipmentId;
        this._returnReasonCode = returnReasonCode;
    }

        public CreateReturnItem() : base()
        {
        }
    }
}
