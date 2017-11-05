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
 * List All Fulfillment Orders Request
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
    public class ListAllFulfillmentOrdersRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private string _marketplace;
        private DateTime? _queryStartDateTime;
        private FulfillmentMethodList _fulfillmentMethod;

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
        public ListAllFulfillmentOrdersRequest WithSellerId(string sellerId)
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
        public ListAllFulfillmentOrdersRequest WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the Marketplace property.
        /// </summary>
        [XmlElement(ElementName = "Marketplace")]
        public string Marketplace
        {
            get { return this._marketplace; }
            set { this._marketplace = value; }
        }

        /// <summary>
        /// Sets the Marketplace property.
        /// </summary>
        /// <param name="marketplace">Marketplace property.</param>
        /// <returns>this instance.</returns>
        public ListAllFulfillmentOrdersRequest WithMarketplace(string marketplace)
        {
            this._marketplace = marketplace;
            return this;
        }

        /// <summary>
        /// Checks if Marketplace property is set.
        /// </summary>
        /// <returns>true if Marketplace property is set.</returns>
        public bool IsSetMarketplace()
        {
            return this._marketplace != null;
        }

        /// <summary>
        /// Gets and sets the QueryStartDateTime property.
        /// </summary>
        [XmlElement(ElementName = "QueryStartDateTime")]
        public DateTime QueryStartDateTime
        {
            get { return this._queryStartDateTime.GetValueOrDefault(); }
            set { this._queryStartDateTime = value; }
        }

        /// <summary>
        /// Sets the QueryStartDateTime property.
        /// </summary>
        /// <param name="queryStartDateTime">QueryStartDateTime property.</param>
        /// <returns>this instance.</returns>
        public ListAllFulfillmentOrdersRequest WithQueryStartDateTime(DateTime queryStartDateTime)
        {
            this._queryStartDateTime = queryStartDateTime;
            return this;
        }

        /// <summary>
        /// Checks if QueryStartDateTime property is set.
        /// </summary>
        /// <returns>true if QueryStartDateTime property is set.</returns>
        public bool IsSetQueryStartDateTime()
        {
            return this._queryStartDateTime != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentMethod property.
        /// </summary>
        [XmlElement(ElementName = "FulfillmentMethod")]
        public FulfillmentMethodList FulfillmentMethod
        {
            get { return this._fulfillmentMethod; }
            set { this._fulfillmentMethod = value; }
        }

        /// <summary>
        /// Sets the FulfillmentMethod property.
        /// </summary>
        /// <param name="fulfillmentMethod">FulfillmentMethod property.</param>
        /// <returns>this instance.</returns>
        public ListAllFulfillmentOrdersRequest WithFulfillmentMethod(FulfillmentMethodList fulfillmentMethod)
        {
            this._fulfillmentMethod = fulfillmentMethod;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentMethod property is set.
        /// </summary>
        /// <returns>true if FulfillmentMethod property is set.</returns>
        public bool IsSetFulfillmentMethod()
        {
            return this._fulfillmentMethod != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _marketplace = reader.Read<string>("Marketplace");
            _queryStartDateTime = reader.Read<DateTime?>("QueryStartDateTime");
            _fulfillmentMethod = reader.Read<FulfillmentMethodList>("FulfillmentMethod");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("Marketplace", _marketplace);
            writer.Write("QueryStartDateTime", _queryStartDateTime);
            writer.Write("FulfillmentMethod", _fulfillmentMethod);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentOutboundShipment/2010-10-01/", "ListAllFulfillmentOrdersRequest", this);
        }

    public ListAllFulfillmentOrdersRequest (string sellerId) : base() {
        this._sellerId = sellerId;
    }

        public ListAllFulfillmentOrdersRequest() : base()
        {
        }
    }
}
