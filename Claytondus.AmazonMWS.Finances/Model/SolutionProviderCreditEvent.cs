/*******************************************************************************
 * Copyright 2009-2018 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Solution Provider Credit Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class SolutionProviderCreditEvent : AbstractMwsObject
    {

        private string _providerTransactionType;
        private string _sellerOrderId;
        private string _marketplaceId;
        private string _marketplaceCountryCode;
        private string _sellerId;
        private string _sellerStoreName;
        private string _providerId;
        private string _providerStoreName;
        private Currency _transactionAmount;
        private DateTime? _transactionCreationDate;

        /// <summary>
        /// Gets and sets the ProviderTransactionType property.
        /// </summary>
        public string ProviderTransactionType
        {
            get { return this._providerTransactionType; }
            set { this._providerTransactionType = value; }
        }

        /// <summary>
        /// Sets the ProviderTransactionType property.
        /// </summary>
        /// <param name="providerTransactionType">ProviderTransactionType property.</param>
        /// <returns>this instance.</returns>
        public SolutionProviderCreditEvent WithProviderTransactionType(string providerTransactionType)
        {
            this._providerTransactionType = providerTransactionType;
            return this;
        }

        /// <summary>
        /// Checks if ProviderTransactionType property is set.
        /// </summary>
        /// <returns>true if ProviderTransactionType property is set.</returns>
        public bool IsSetProviderTransactionType()
        {
            return this._providerTransactionType != null;
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
        public SolutionProviderCreditEvent WithSellerOrderId(string sellerOrderId)
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
        public SolutionProviderCreditEvent WithMarketplaceId(string marketplaceId)
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
        /// Gets and sets the MarketplaceCountryCode property.
        /// </summary>
        public string MarketplaceCountryCode
        {
            get { return this._marketplaceCountryCode; }
            set { this._marketplaceCountryCode = value; }
        }

        /// <summary>
        /// Sets the MarketplaceCountryCode property.
        /// </summary>
        /// <param name="marketplaceCountryCode">MarketplaceCountryCode property.</param>
        /// <returns>this instance.</returns>
        public SolutionProviderCreditEvent WithMarketplaceCountryCode(string marketplaceCountryCode)
        {
            this._marketplaceCountryCode = marketplaceCountryCode;
            return this;
        }

        /// <summary>
        /// Checks if MarketplaceCountryCode property is set.
        /// </summary>
        /// <returns>true if MarketplaceCountryCode property is set.</returns>
        public bool IsSetMarketplaceCountryCode()
        {
            return this._marketplaceCountryCode != null;
        }

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
        public SolutionProviderCreditEvent WithSellerId(string sellerId)
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
        /// Gets and sets the SellerStoreName property.
        /// </summary>
        public string SellerStoreName
        {
            get { return this._sellerStoreName; }
            set { this._sellerStoreName = value; }
        }

        /// <summary>
        /// Sets the SellerStoreName property.
        /// </summary>
        /// <param name="sellerStoreName">SellerStoreName property.</param>
        /// <returns>this instance.</returns>
        public SolutionProviderCreditEvent WithSellerStoreName(string sellerStoreName)
        {
            this._sellerStoreName = sellerStoreName;
            return this;
        }

        /// <summary>
        /// Checks if SellerStoreName property is set.
        /// </summary>
        /// <returns>true if SellerStoreName property is set.</returns>
        public bool IsSetSellerStoreName()
        {
            return this._sellerStoreName != null;
        }

        /// <summary>
        /// Gets and sets the ProviderId property.
        /// </summary>
        public string ProviderId
        {
            get { return this._providerId; }
            set { this._providerId = value; }
        }

        /// <summary>
        /// Sets the ProviderId property.
        /// </summary>
        /// <param name="providerId">ProviderId property.</param>
        /// <returns>this instance.</returns>
        public SolutionProviderCreditEvent WithProviderId(string providerId)
        {
            this._providerId = providerId;
            return this;
        }

        /// <summary>
        /// Checks if ProviderId property is set.
        /// </summary>
        /// <returns>true if ProviderId property is set.</returns>
        public bool IsSetProviderId()
        {
            return this._providerId != null;
        }

        /// <summary>
        /// Gets and sets the ProviderStoreName property.
        /// </summary>
        public string ProviderStoreName
        {
            get { return this._providerStoreName; }
            set { this._providerStoreName = value; }
        }

        /// <summary>
        /// Sets the ProviderStoreName property.
        /// </summary>
        /// <param name="providerStoreName">ProviderStoreName property.</param>
        /// <returns>this instance.</returns>
        public SolutionProviderCreditEvent WithProviderStoreName(string providerStoreName)
        {
            this._providerStoreName = providerStoreName;
            return this;
        }

        /// <summary>
        /// Checks if ProviderStoreName property is set.
        /// </summary>
        /// <returns>true if ProviderStoreName property is set.</returns>
        public bool IsSetProviderStoreName()
        {
            return this._providerStoreName != null;
        }

        /// <summary>
        /// Gets and sets the TransactionAmount property.
        /// </summary>
        public Currency TransactionAmount
        {
            get { return this._transactionAmount; }
            set { this._transactionAmount = value; }
        }

        /// <summary>
        /// Sets the TransactionAmount property.
        /// </summary>
        /// <param name="transactionAmount">TransactionAmount property.</param>
        /// <returns>this instance.</returns>
        public SolutionProviderCreditEvent WithTransactionAmount(Currency transactionAmount)
        {
            this._transactionAmount = transactionAmount;
            return this;
        }

        /// <summary>
        /// Checks if TransactionAmount property is set.
        /// </summary>
        /// <returns>true if TransactionAmount property is set.</returns>
        public bool IsSetTransactionAmount()
        {
            return this._transactionAmount != null;
        }

        /// <summary>
        /// Gets and sets the TransactionCreationDate property.
        /// </summary>
        public DateTime TransactionCreationDate
        {
            get { return this._transactionCreationDate.GetValueOrDefault(); }
            set { this._transactionCreationDate = value; }
        }

        /// <summary>
        /// Sets the TransactionCreationDate property.
        /// </summary>
        /// <param name="transactionCreationDate">TransactionCreationDate property.</param>
        /// <returns>this instance.</returns>
        public SolutionProviderCreditEvent WithTransactionCreationDate(DateTime transactionCreationDate)
        {
            this._transactionCreationDate = transactionCreationDate;
            return this;
        }

        /// <summary>
        /// Checks if TransactionCreationDate property is set.
        /// </summary>
        /// <returns>true if TransactionCreationDate property is set.</returns>
        public bool IsSetTransactionCreationDate()
        {
            return this._transactionCreationDate != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _providerTransactionType = reader.Read<string>("ProviderTransactionType");
            _sellerOrderId = reader.Read<string>("SellerOrderId");
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _marketplaceCountryCode = reader.Read<string>("MarketplaceCountryCode");
            _sellerId = reader.Read<string>("SellerId");
            _sellerStoreName = reader.Read<string>("SellerStoreName");
            _providerId = reader.Read<string>("ProviderId");
            _providerStoreName = reader.Read<string>("ProviderStoreName");
            _transactionAmount = reader.Read<Currency>("TransactionAmount");
            _transactionCreationDate = reader.Read<DateTime?>("TransactionCreationDate");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ProviderTransactionType", _providerTransactionType);
            writer.Write("SellerOrderId", _sellerOrderId);
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("MarketplaceCountryCode", _marketplaceCountryCode);
            writer.Write("SellerId", _sellerId);
            writer.Write("SellerStoreName", _sellerStoreName);
            writer.Write("ProviderId", _providerId);
            writer.Write("ProviderStoreName", _providerStoreName);
            writer.Write("TransactionAmount", _transactionAmount);
            writer.Write("TransactionCreationDate", _transactionCreationDate);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "SolutionProviderCreditEvent", this);
        }


        public SolutionProviderCreditEvent() : base()
        {
        }
    }
}
