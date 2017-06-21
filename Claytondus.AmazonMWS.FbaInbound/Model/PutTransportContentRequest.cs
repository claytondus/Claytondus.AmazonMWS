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
 * Put Transport Content Request
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
    public class PutTransportContentRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private string _shipmentId;
        private bool _isPartnered;
        private string _shipmentType;
        private TransportDetailInput _transportDetails;

        /// <summary>
        /// Gets and sets the SellerId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerId")]
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
        public PutTransportContentRequest WithSellerId(string sellerId)
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
        [XmlElementAttribute(ElementName = "MWSAuthToken")]
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
        public PutTransportContentRequest WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the ShipmentId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipmentId")]
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
        public PutTransportContentRequest WithShipmentId(string shipmentId)
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
        /// Gets and sets the IsPartnered property.
        /// </summary>
        [XmlElementAttribute(ElementName = "IsPartnered")]
        public bool IsPartnered
        {
            get { return this._isPartnered; }
            set { this._isPartnered = value; }
        }

        /// <summary>
        /// Sets the IsPartnered property.
        /// </summary>
        /// <param name="isPartnered">IsPartnered property.</param>
        /// <returns>this instance.</returns>
        public PutTransportContentRequest WithIsPartnered(bool isPartnered)
        {
            this._isPartnered = isPartnered;
            return this;
        }

        /// <summary>
        /// Checks if IsPartnered property is set.
        /// </summary>
        /// <returns>true if IsPartnered property is set.</returns>
        public bool IsSetIsPartnered()
        {
            return this._isPartnered != null;
        }

        /// <summary>
        /// Gets and sets the ShipmentType property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipmentType")]
        public string ShipmentType
        {
            get { return this._shipmentType; }
            set { this._shipmentType = value; }
        }

        /// <summary>
        /// Sets the ShipmentType property.
        /// </summary>
        /// <param name="shipmentType">ShipmentType property.</param>
        /// <returns>this instance.</returns>
        public PutTransportContentRequest WithShipmentType(string shipmentType)
        {
            this._shipmentType = shipmentType;
            return this;
        }

        /// <summary>
        /// Checks if ShipmentType property is set.
        /// </summary>
        /// <returns>true if ShipmentType property is set.</returns>
        public bool IsSetShipmentType()
        {
            return this._shipmentType != null;
        }

        /// <summary>
        /// Gets and sets the TransportDetails property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransportDetails")]
        public TransportDetailInput TransportDetails
        {
            get { return this._transportDetails; }
            set { this._transportDetails = value; }
        }

        /// <summary>
        /// Sets the TransportDetails property.
        /// </summary>
        /// <param name="transportDetails">TransportDetails property.</param>
        /// <returns>this instance.</returns>
        public PutTransportContentRequest WithTransportDetails(TransportDetailInput transportDetails)
        {
            this._transportDetails = transportDetails;
            return this;
        }

        /// <summary>
        /// Checks if TransportDetails property is set.
        /// </summary>
        /// <returns>true if TransportDetails property is set.</returns>
        public bool IsSetTransportDetails()
        {
            return this._transportDetails != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _shipmentId = reader.Read<string>("ShipmentId");
            _isPartnered = reader.Read<bool>("IsPartnered");
            _shipmentType = reader.Read<string>("ShipmentType");
            _transportDetails = reader.Read<TransportDetailInput>("TransportDetails");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("ShipmentId", _shipmentId);
            writer.Write("IsPartnered", _isPartnered);
            writer.Write("ShipmentType", _shipmentType);
            writer.Write("TransportDetails", _transportDetails);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "PutTransportContentRequest", this);
        }

    public PutTransportContentRequest (string sellerId,string shipmentId,bool isPartnered,string shipmentType,TransportDetailInput transportDetails) : base() {
        this._sellerId = sellerId;
        this._shipmentId = shipmentId;
        this._isPartnered = isPartnered;
        this._shipmentType = shipmentType;
        this._transportDetails = transportDetails;
    }

        public PutTransportContentRequest() : base()
        {
        }
    }
}
