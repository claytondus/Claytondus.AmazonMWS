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
 * Pay With Amazon Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class PayWithAmazonEvent : AbstractMwsObject
    {

        private string _sellerOrderId;
        private DateTime? _transactionPostedDate;
        private string _businessObjectType;
        private string _salesChannel;
        private ChargeComponent _charge;
        private List<FeeComponent> _feeList;
        private string _paymentAmountType;
        private string _amountDescription;
        private string _fulfillmentChannel;
        private string _storeName;

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
        public PayWithAmazonEvent WithSellerOrderId(string sellerOrderId)
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
        /// Gets and sets the TransactionPostedDate property.
        /// </summary>
        public DateTime TransactionPostedDate
        {
            get { return this._transactionPostedDate.GetValueOrDefault(); }
            set { this._transactionPostedDate = value; }
        }

        /// <summary>
        /// Sets the TransactionPostedDate property.
        /// </summary>
        /// <param name="transactionPostedDate">TransactionPostedDate property.</param>
        /// <returns>this instance.</returns>
        public PayWithAmazonEvent WithTransactionPostedDate(DateTime transactionPostedDate)
        {
            this._transactionPostedDate = transactionPostedDate;
            return this;
        }

        /// <summary>
        /// Checks if TransactionPostedDate property is set.
        /// </summary>
        /// <returns>true if TransactionPostedDate property is set.</returns>
        public bool IsSetTransactionPostedDate()
        {
            return this._transactionPostedDate != null;
        }

        /// <summary>
        /// Gets and sets the BusinessObjectType property.
        /// </summary>
        public string BusinessObjectType
        {
            get { return this._businessObjectType; }
            set { this._businessObjectType = value; }
        }

        /// <summary>
        /// Sets the BusinessObjectType property.
        /// </summary>
        /// <param name="businessObjectType">BusinessObjectType property.</param>
        /// <returns>this instance.</returns>
        public PayWithAmazonEvent WithBusinessObjectType(string businessObjectType)
        {
            this._businessObjectType = businessObjectType;
            return this;
        }

        /// <summary>
        /// Checks if BusinessObjectType property is set.
        /// </summary>
        /// <returns>true if BusinessObjectType property is set.</returns>
        public bool IsSetBusinessObjectType()
        {
            return this._businessObjectType != null;
        }

        /// <summary>
        /// Gets and sets the SalesChannel property.
        /// </summary>
        public string SalesChannel
        {
            get { return this._salesChannel; }
            set { this._salesChannel = value; }
        }

        /// <summary>
        /// Sets the SalesChannel property.
        /// </summary>
        /// <param name="salesChannel">SalesChannel property.</param>
        /// <returns>this instance.</returns>
        public PayWithAmazonEvent WithSalesChannel(string salesChannel)
        {
            this._salesChannel = salesChannel;
            return this;
        }

        /// <summary>
        /// Checks if SalesChannel property is set.
        /// </summary>
        /// <returns>true if SalesChannel property is set.</returns>
        public bool IsSetSalesChannel()
        {
            return this._salesChannel != null;
        }

        /// <summary>
        /// Gets and sets the Charge property.
        /// </summary>
        public ChargeComponent Charge
        {
            get { return this._charge; }
            set { this._charge = value; }
        }

        /// <summary>
        /// Sets the Charge property.
        /// </summary>
        /// <param name="charge">Charge property.</param>
        /// <returns>this instance.</returns>
        public PayWithAmazonEvent WithCharge(ChargeComponent charge)
        {
            this._charge = charge;
            return this;
        }

        /// <summary>
        /// Checks if Charge property is set.
        /// </summary>
        /// <returns>true if Charge property is set.</returns>
        public bool IsSetCharge()
        {
            return this._charge != null;
        }

        /// <summary>
        /// Gets and sets the FeeList property.
        /// </summary>
        public List<FeeComponent> FeeList
        {
            get
            {
                if(this._feeList == null)
                {
                    this._feeList = new List<FeeComponent>();
                }
                return this._feeList;
            }
            set { this._feeList = value; }
        }

        /// <summary>
        /// Sets the FeeList property.
        /// </summary>
        /// <param name="feeList">FeeList property.</param>
        /// <returns>this instance.</returns>
        public PayWithAmazonEvent WithFeeList(FeeComponent[] feeList)
        {
            this._feeList.AddRange(feeList);
            return this;
        }

        /// <summary>
        /// Checks if FeeList property is set.
        /// </summary>
        /// <returns>true if FeeList property is set.</returns>
        public bool IsSetFeeList()
        {
            return this.FeeList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the PaymentAmountType property.
        /// </summary>
        public string PaymentAmountType
        {
            get { return this._paymentAmountType; }
            set { this._paymentAmountType = value; }
        }

        /// <summary>
        /// Sets the PaymentAmountType property.
        /// </summary>
        /// <param name="paymentAmountType">PaymentAmountType property.</param>
        /// <returns>this instance.</returns>
        public PayWithAmazonEvent WithPaymentAmountType(string paymentAmountType)
        {
            this._paymentAmountType = paymentAmountType;
            return this;
        }

        /// <summary>
        /// Checks if PaymentAmountType property is set.
        /// </summary>
        /// <returns>true if PaymentAmountType property is set.</returns>
        public bool IsSetPaymentAmountType()
        {
            return this._paymentAmountType != null;
        }

        /// <summary>
        /// Gets and sets the AmountDescription property.
        /// </summary>
        public string AmountDescription
        {
            get { return this._amountDescription; }
            set { this._amountDescription = value; }
        }

        /// <summary>
        /// Sets the AmountDescription property.
        /// </summary>
        /// <param name="amountDescription">AmountDescription property.</param>
        /// <returns>this instance.</returns>
        public PayWithAmazonEvent WithAmountDescription(string amountDescription)
        {
            this._amountDescription = amountDescription;
            return this;
        }

        /// <summary>
        /// Checks if AmountDescription property is set.
        /// </summary>
        /// <returns>true if AmountDescription property is set.</returns>
        public bool IsSetAmountDescription()
        {
            return this._amountDescription != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentChannel property.
        /// </summary>
        public string FulfillmentChannel
        {
            get { return this._fulfillmentChannel; }
            set { this._fulfillmentChannel = value; }
        }

        /// <summary>
        /// Sets the FulfillmentChannel property.
        /// </summary>
        /// <param name="fulfillmentChannel">FulfillmentChannel property.</param>
        /// <returns>this instance.</returns>
        public PayWithAmazonEvent WithFulfillmentChannel(string fulfillmentChannel)
        {
            this._fulfillmentChannel = fulfillmentChannel;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentChannel property is set.
        /// </summary>
        /// <returns>true if FulfillmentChannel property is set.</returns>
        public bool IsSetFulfillmentChannel()
        {
            return this._fulfillmentChannel != null;
        }

        /// <summary>
        /// Gets and sets the StoreName property.
        /// </summary>
        public string StoreName
        {
            get { return this._storeName; }
            set { this._storeName = value; }
        }

        /// <summary>
        /// Sets the StoreName property.
        /// </summary>
        /// <param name="storeName">StoreName property.</param>
        /// <returns>this instance.</returns>
        public PayWithAmazonEvent WithStoreName(string storeName)
        {
            this._storeName = storeName;
            return this;
        }

        /// <summary>
        /// Checks if StoreName property is set.
        /// </summary>
        /// <returns>true if StoreName property is set.</returns>
        public bool IsSetStoreName()
        {
            return this._storeName != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerOrderId = reader.Read<string>("SellerOrderId");
            _transactionPostedDate = reader.Read<DateTime?>("TransactionPostedDate");
            _businessObjectType = reader.Read<string>("BusinessObjectType");
            _salesChannel = reader.Read<string>("SalesChannel");
            _charge = reader.Read<ChargeComponent>("Charge");
            _feeList = reader.ReadList<FeeComponent>("FeeList", "FeeComponent");
            _paymentAmountType = reader.Read<string>("PaymentAmountType");
            _amountDescription = reader.Read<string>("AmountDescription");
            _fulfillmentChannel = reader.Read<string>("FulfillmentChannel");
            _storeName = reader.Read<string>("StoreName");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerOrderId", _sellerOrderId);
            writer.Write("TransactionPostedDate", _transactionPostedDate);
            writer.Write("BusinessObjectType", _businessObjectType);
            writer.Write("SalesChannel", _salesChannel);
            writer.Write("Charge", _charge);
            writer.WriteList("FeeList", "FeeComponent", _feeList);
            writer.Write("PaymentAmountType", _paymentAmountType);
            writer.Write("AmountDescription", _amountDescription);
            writer.Write("FulfillmentChannel", _fulfillmentChannel);
            writer.Write("StoreName", _storeName);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "PayWithAmazonEvent", this);
        }


        public PayWithAmazonEvent() : base()
        {
        }
    }
}
