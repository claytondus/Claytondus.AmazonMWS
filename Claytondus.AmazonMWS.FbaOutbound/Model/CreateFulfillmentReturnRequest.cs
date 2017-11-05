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
 * Create Fulfillment Return Request
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
    public class CreateFulfillmentReturnRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private string _sellerFulfillmentOrderId;
        private CreateReturnItemList _items;

        /// <summary>
        /// Gets and sets the SellerId property.
        /// </summary>
        [XmlElement(ElementName = "SellerId")]
        public string SellerId
        {
            get { return this._sellerId; }
            set { this._sellerId = value; }
        }

        /// <summary>
        /// Sets the SellerId property.
        /// </summary>
        /// <param name="sellerId">SellerId property.</param>
        /// <returns>this instance.</returns>
        public CreateFulfillmentReturnRequest WithSellerId(string sellerId)
        {
            this._sellerId = sellerId;
            return this;
        }

        /// <summary>
        /// Checks if SellerId property is set.
        /// </summary>
        /// <returns>true if SellerId property is set.</returns>
        public bool IsSetSellerId()
        {
            return this._sellerId != null;
        }

        /// <summary>
        /// Gets and sets the MWSAuthToken property.
        /// </summary>
        [XmlElement(ElementName = "MWSAuthToken")]
        public string MWSAuthToken
        {
            get { return this._mwsAuthToken; }
            set { this._mwsAuthToken = value; }
        }

        /// <summary>
        /// Sets the MWSAuthToken property.
        /// </summary>
        /// <param name="mwsAuthToken">MWSAuthToken property.</param>
        /// <returns>this instance.</returns>
        public CreateFulfillmentReturnRequest WithMWSAuthToken(string mwsAuthToken)
        {
            this._mwsAuthToken = mwsAuthToken;
            return this;
        }

        /// <summary>
        /// Checks if MWSAuthToken property is set.
        /// </summary>
        /// <returns>true if MWSAuthToken property is set.</returns>
        public bool IsSetMWSAuthToken()
        {
            return this._mwsAuthToken != null;
        }

        /// <summary>
        /// Gets and sets the SellerFulfillmentOrderId property.
        /// </summary>
        [XmlElement(ElementName = "SellerFulfillmentOrderId")]
        public string SellerFulfillmentOrderId
        {
            get { return this._sellerFulfillmentOrderId; }
            set { this._sellerFulfillmentOrderId = value; }
        }

        /// <summary>
        /// Sets the SellerFulfillmentOrderId property.
        /// </summary>
        /// <param name="sellerFulfillmentOrderId">SellerFulfillmentOrderId property.</param>
        /// <returns>this instance.</returns>
        public CreateFulfillmentReturnRequest WithSellerFulfillmentOrderId(string sellerFulfillmentOrderId)
        {
            this._sellerFulfillmentOrderId = sellerFulfillmentOrderId;
            return this;
        }

        /// <summary>
        /// Checks if SellerFulfillmentOrderId property is set.
        /// </summary>
        /// <returns>true if SellerFulfillmentOrderId property is set.</returns>
        public bool IsSetSellerFulfillmentOrderId()
        {
            return this._sellerFulfillmentOrderId != null;
        }

        /// <summary>
        /// Gets and sets the Items property.
        /// </summary>
        [XmlElement(ElementName = "Items")]
        public CreateReturnItemList Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        /// <summary>
        /// Sets the Items property.
        /// </summary>
        /// <param name="items">Items property.</param>
        /// <returns>this instance.</returns>
        public CreateFulfillmentReturnRequest WithItems(CreateReturnItemList items)
        {
            this._items = items;
            return this;
        }

        /// <summary>
        /// Checks if Items property is set.
        /// </summary>
        /// <returns>true if Items property is set.</returns>
        public bool IsSetItems()
        {
            return this._items != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _sellerFulfillmentOrderId = reader.Read<string>("SellerFulfillmentOrderId");
            _items = reader.Read<CreateReturnItemList>("Items");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("SellerFulfillmentOrderId", _sellerFulfillmentOrderId);
            writer.Write("Items", _items);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "CreateFulfillmentReturnRequest", this);
        }

    public CreateFulfillmentReturnRequest (string sellerId,string sellerFulfillmentOrderId,CreateReturnItemList items) : base() {
        this._sellerId = sellerId;
        this._sellerFulfillmentOrderId = sellerFulfillmentOrderId;
        this._items = items;
    }

        public CreateFulfillmentReturnRequest() : base()
        {
        }
    }
}
