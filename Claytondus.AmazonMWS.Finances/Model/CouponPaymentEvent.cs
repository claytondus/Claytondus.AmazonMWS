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
 * Coupon Payment Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class CouponPaymentEvent : AbstractMwsObject
    {

        private DateTime? _postedDate;
        private string _couponId;
        private string _sellerCouponDescription;
        private decimal? _clipOrRedemptionCount;
        private string _paymentEventId;
        private FeeComponent _feeComponent;
        private ChargeComponent _chargeComponent;
        private Currency _totalAmount;

        /// <summary>
        /// Gets and sets the PostedDate property.
        /// </summary>
        public DateTime PostedDate
        {
            get { return this._postedDate.GetValueOrDefault(); }
            set { this._postedDate = value; }
        }

        /// <summary>
        /// Sets the PostedDate property.
        /// </summary>
        /// <param name="postedDate">PostedDate property.</param>
        /// <returns>this instance.</returns>
        public CouponPaymentEvent WithPostedDate(DateTime postedDate)
        {
            this._postedDate = postedDate;
            return this;
        }

        /// <summary>
        /// Checks if PostedDate property is set.
        /// </summary>
        /// <returns>true if PostedDate property is set.</returns>
        public bool IsSetPostedDate()
        {
            return this._postedDate != null;
        }

        /// <summary>
        /// Gets and sets the CouponId property.
        /// </summary>
        public string CouponId
        {
            get { return this._couponId; }
            set { this._couponId = value; }
        }

        /// <summary>
        /// Sets the CouponId property.
        /// </summary>
        /// <param name="couponId">CouponId property.</param>
        /// <returns>this instance.</returns>
        public CouponPaymentEvent WithCouponId(string couponId)
        {
            this._couponId = couponId;
            return this;
        }

        /// <summary>
        /// Checks if CouponId property is set.
        /// </summary>
        /// <returns>true if CouponId property is set.</returns>
        public bool IsSetCouponId()
        {
            return this._couponId != null;
        }

        /// <summary>
        /// Gets and sets the SellerCouponDescription property.
        /// </summary>
        public string SellerCouponDescription
        {
            get { return this._sellerCouponDescription; }
            set { this._sellerCouponDescription = value; }
        }

        /// <summary>
        /// Sets the SellerCouponDescription property.
        /// </summary>
        /// <param name="sellerCouponDescription">SellerCouponDescription property.</param>
        /// <returns>this instance.</returns>
        public CouponPaymentEvent WithSellerCouponDescription(string sellerCouponDescription)
        {
            this._sellerCouponDescription = sellerCouponDescription;
            return this;
        }

        /// <summary>
        /// Checks if SellerCouponDescription property is set.
        /// </summary>
        /// <returns>true if SellerCouponDescription property is set.</returns>
        public bool IsSetSellerCouponDescription()
        {
            return this._sellerCouponDescription != null;
        }

        /// <summary>
        /// Gets and sets the ClipOrRedemptionCount property.
        /// </summary>
        public decimal ClipOrRedemptionCount
        {
            get { return this._clipOrRedemptionCount.GetValueOrDefault(); }
            set { this._clipOrRedemptionCount = value; }
        }

        /// <summary>
        /// Sets the ClipOrRedemptionCount property.
        /// </summary>
        /// <param name="clipOrRedemptionCount">ClipOrRedemptionCount property.</param>
        /// <returns>this instance.</returns>
        public CouponPaymentEvent WithClipOrRedemptionCount(decimal clipOrRedemptionCount)
        {
            this._clipOrRedemptionCount = clipOrRedemptionCount;
            return this;
        }

        /// <summary>
        /// Checks if ClipOrRedemptionCount property is set.
        /// </summary>
        /// <returns>true if ClipOrRedemptionCount property is set.</returns>
        public bool IsSetClipOrRedemptionCount()
        {
            return this._clipOrRedemptionCount != null;
        }

        /// <summary>
        /// Gets and sets the PaymentEventId property.
        /// </summary>
        public string PaymentEventId
        {
            get { return this._paymentEventId; }
            set { this._paymentEventId = value; }
        }

        /// <summary>
        /// Sets the PaymentEventId property.
        /// </summary>
        /// <param name="paymentEventId">PaymentEventId property.</param>
        /// <returns>this instance.</returns>
        public CouponPaymentEvent WithPaymentEventId(string paymentEventId)
        {
            this._paymentEventId = paymentEventId;
            return this;
        }

        /// <summary>
        /// Checks if PaymentEventId property is set.
        /// </summary>
        /// <returns>true if PaymentEventId property is set.</returns>
        public bool IsSetPaymentEventId()
        {
            return this._paymentEventId != null;
        }

        /// <summary>
        /// Gets and sets the FeeComponent property.
        /// </summary>
        public FeeComponent FeeComponent
        {
            get { return this._feeComponent; }
            set { this._feeComponent = value; }
        }

        /// <summary>
        /// Sets the FeeComponent property.
        /// </summary>
        /// <param name="feeComponent">FeeComponent property.</param>
        /// <returns>this instance.</returns>
        public CouponPaymentEvent WithFeeComponent(FeeComponent feeComponent)
        {
            this._feeComponent = feeComponent;
            return this;
        }

        /// <summary>
        /// Checks if FeeComponent property is set.
        /// </summary>
        /// <returns>true if FeeComponent property is set.</returns>
        public bool IsSetFeeComponent()
        {
            return this._feeComponent != null;
        }

        /// <summary>
        /// Gets and sets the ChargeComponent property.
        /// </summary>
        public ChargeComponent ChargeComponent
        {
            get { return this._chargeComponent; }
            set { this._chargeComponent = value; }
        }

        /// <summary>
        /// Sets the ChargeComponent property.
        /// </summary>
        /// <param name="chargeComponent">ChargeComponent property.</param>
        /// <returns>this instance.</returns>
        public CouponPaymentEvent WithChargeComponent(ChargeComponent chargeComponent)
        {
            this._chargeComponent = chargeComponent;
            return this;
        }

        /// <summary>
        /// Checks if ChargeComponent property is set.
        /// </summary>
        /// <returns>true if ChargeComponent property is set.</returns>
        public bool IsSetChargeComponent()
        {
            return this._chargeComponent != null;
        }

        /// <summary>
        /// Gets and sets the TotalAmount property.
        /// </summary>
        public Currency TotalAmount
        {
            get { return this._totalAmount; }
            set { this._totalAmount = value; }
        }

        /// <summary>
        /// Sets the TotalAmount property.
        /// </summary>
        /// <param name="totalAmount">TotalAmount property.</param>
        /// <returns>this instance.</returns>
        public CouponPaymentEvent WithTotalAmount(Currency totalAmount)
        {
            this._totalAmount = totalAmount;
            return this;
        }

        /// <summary>
        /// Checks if TotalAmount property is set.
        /// </summary>
        /// <returns>true if TotalAmount property is set.</returns>
        public bool IsSetTotalAmount()
        {
            return this._totalAmount != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _postedDate = reader.Read<DateTime?>("PostedDate");
            _couponId = reader.Read<string>("CouponId");
            _sellerCouponDescription = reader.Read<string>("SellerCouponDescription");
            _clipOrRedemptionCount = reader.Read<decimal?>("ClipOrRedemptionCount");
            _paymentEventId = reader.Read<string>("PaymentEventId");
            _feeComponent = reader.Read<FeeComponent>("FeeComponent");
            _chargeComponent = reader.Read<ChargeComponent>("ChargeComponent");
            _totalAmount = reader.Read<Currency>("TotalAmount");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("PostedDate", _postedDate);
            writer.Write("CouponId", _couponId);
            writer.Write("SellerCouponDescription", _sellerCouponDescription);
            writer.Write("ClipOrRedemptionCount", _clipOrRedemptionCount);
            writer.Write("PaymentEventId", _paymentEventId);
            writer.Write("FeeComponent", _feeComponent);
            writer.Write("ChargeComponent", _chargeComponent);
            writer.Write("TotalAmount", _totalAmount);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "CouponPaymentEvent", this);
        }


        public CouponPaymentEvent() : base()
        {
        }
    }
}
