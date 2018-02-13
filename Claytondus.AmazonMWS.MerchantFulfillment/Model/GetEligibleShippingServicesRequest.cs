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
 * Get Eligible Shipping Services Request
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class GetEligibleShippingServicesRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private ShipmentRequestDetails _shipmentRequestDetails;

        /// <summary>
        /// Gets and sets the SellerId property.
        /// </summary>
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
        public GetEligibleShippingServicesRequest WithSellerId(string sellerId)
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
        public GetEligibleShippingServicesRequest WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the ShipmentRequestDetails property.
        /// </summary>
        public ShipmentRequestDetails ShipmentRequestDetails
        {
            get { return this._shipmentRequestDetails; }
            set { this._shipmentRequestDetails = value; }
        }

        /// <summary>
        /// Sets the ShipmentRequestDetails property.
        /// </summary>
        /// <param name="shipmentRequestDetails">ShipmentRequestDetails property.</param>
        /// <returns>this instance.</returns>
        public GetEligibleShippingServicesRequest WithShipmentRequestDetails(ShipmentRequestDetails shipmentRequestDetails)
        {
            this._shipmentRequestDetails = shipmentRequestDetails;
            return this;
        }

        /// <summary>
        /// Checks if ShipmentRequestDetails property is set.
        /// </summary>
        /// <returns>true if ShipmentRequestDetails property is set.</returns>
        public bool IsSetShipmentRequestDetails()
        {
            return this._shipmentRequestDetails != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _shipmentRequestDetails = reader.Read<ShipmentRequestDetails>("ShipmentRequestDetails");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("ShipmentRequestDetails", _shipmentRequestDetails);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "GetEligibleShippingServicesRequest", this);
        }

    public GetEligibleShippingServicesRequest (string sellerId,ShipmentRequestDetails shipmentRequestDetails) : base() {
        this._sellerId = sellerId;
        this._shipmentRequestDetails = shipmentRequestDetails;
    }

        public GetEligibleShippingServicesRequest() : base()
        {
        }
    }
}
