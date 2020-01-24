/*******************************************************************************
 * Copyright 2009-2015 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Delete Subscription Input
 * API Version: 2013-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:27:11 GMT 2015
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Subscriptions.Model
{
    public class DeleteSubscriptionInput : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private string _marketplaceId;
        private string _notificationType;
        private Destination _destination;

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
        public DeleteSubscriptionInput WithSellerId(string sellerId)
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
        public DeleteSubscriptionInput WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the MarketplaceId property.
        /// </summary>
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
        public DeleteSubscriptionInput WithMarketplaceId(string marketplaceId)
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

        /// <summary>
        /// Gets and sets the NotificationType property.
        /// </summary>
        public string NotificationType
        {
            get { return this._notificationType; }
            set { this._notificationType = value; }
        }

        /// <summary>
        /// Sets the NotificationType property.
        /// </summary>
        /// <param name="notificationType">NotificationType property.</param>
        /// <returns>this instance.</returns>
        public DeleteSubscriptionInput WithNotificationType(string notificationType)
        {
            this._notificationType = notificationType;
            return this;
        }

        /// <summary>
        /// Checks if NotificationType property is set.
        /// </summary>
        /// <returns>true if NotificationType property is set.</returns>
        public bool IsSetNotificationType()
        {
            return this._notificationType != null;
        }

        /// <summary>
        /// Gets and sets the Destination property.
        /// </summary>
        public Destination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        /// <summary>
        /// Sets the Destination property.
        /// </summary>
        /// <param name="destination">Destination property.</param>
        /// <returns>this instance.</returns>
        public DeleteSubscriptionInput WithDestination(Destination destination)
        {
            this._destination = destination;
            return this;
        }

        /// <summary>
        /// Checks if Destination property is set.
        /// </summary>
        /// <returns>true if Destination property is set.</returns>
        public bool IsSetDestination()
        {
            return this._destination != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _notificationType = reader.Read<string>("NotificationType");
            _destination = reader.Read<Destination>("Destination");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("NotificationType", _notificationType);
            writer.Write("Destination", _destination);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Subscriptions/2013-07-01", "DeleteSubscriptionInput", this);
        }

        public DeleteSubscriptionInput() : base()
        {
        }
    }
}
