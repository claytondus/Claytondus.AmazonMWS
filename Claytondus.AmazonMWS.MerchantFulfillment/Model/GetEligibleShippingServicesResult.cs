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
 * Get Eligible Shipping Services Result
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */


using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class GetEligibleShippingServicesResult : AbstractMwsObject
    {

        private List<ShippingService> _shippingServiceList;
        private List<TemporarilyUnavailableCarrier> _temporarilyUnavailableCarrierList;
        private List<TermsAndConditionsNotAcceptedCarrier> _termsAndConditionsNotAcceptedCarrierList;

        /// <summary>
        /// Gets and sets the ShippingServiceList property.
        /// </summary>
        public List<ShippingService> ShippingServiceList
        {
            get
            {
                if(this._shippingServiceList == null)
                {
                    this._shippingServiceList = new List<ShippingService>();
                }
                return this._shippingServiceList;
            }
            set { this._shippingServiceList = value; }
        }

        /// <summary>
        /// Sets the ShippingServiceList property.
        /// </summary>
        /// <param name="shippingServiceList">ShippingServiceList property.</param>
        /// <returns>this instance.</returns>
        public GetEligibleShippingServicesResult WithShippingServiceList(ShippingService[] shippingServiceList)
        {
            this._shippingServiceList.AddRange(shippingServiceList);
            return this;
        }

        /// <summary>
        /// Checks if ShippingServiceList property is set.
        /// </summary>
        /// <returns>true if ShippingServiceList property is set.</returns>
        public bool IsSetShippingServiceList()
        {
            return this.ShippingServiceList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the TemporarilyUnavailableCarrierList property.
        /// </summary>
        public List<TemporarilyUnavailableCarrier> TemporarilyUnavailableCarrierList
        {
            get
            {
                if(this._temporarilyUnavailableCarrierList == null)
                {
                    this._temporarilyUnavailableCarrierList = new List<TemporarilyUnavailableCarrier>();
                }
                return this._temporarilyUnavailableCarrierList;
            }
            set { this._temporarilyUnavailableCarrierList = value; }
        }

        /// <summary>
        /// Sets the TemporarilyUnavailableCarrierList property.
        /// </summary>
        /// <param name="temporarilyUnavailableCarrierList">TemporarilyUnavailableCarrierList property.</param>
        /// <returns>this instance.</returns>
        public GetEligibleShippingServicesResult WithTemporarilyUnavailableCarrierList(TemporarilyUnavailableCarrier[] temporarilyUnavailableCarrierList)
        {
            this._temporarilyUnavailableCarrierList.AddRange(temporarilyUnavailableCarrierList);
            return this;
        }

        /// <summary>
        /// Checks if TemporarilyUnavailableCarrierList property is set.
        /// </summary>
        /// <returns>true if TemporarilyUnavailableCarrierList property is set.</returns>
        public bool IsSetTemporarilyUnavailableCarrierList()
        {
            return this.TemporarilyUnavailableCarrierList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the TermsAndConditionsNotAcceptedCarrierList property.
        /// </summary>
        public List<TermsAndConditionsNotAcceptedCarrier> TermsAndConditionsNotAcceptedCarrierList
        {
            get
            {
                if(this._termsAndConditionsNotAcceptedCarrierList == null)
                {
                    this._termsAndConditionsNotAcceptedCarrierList = new List<TermsAndConditionsNotAcceptedCarrier>();
                }
                return this._termsAndConditionsNotAcceptedCarrierList;
            }
            set { this._termsAndConditionsNotAcceptedCarrierList = value; }
        }

        /// <summary>
        /// Sets the TermsAndConditionsNotAcceptedCarrierList property.
        /// </summary>
        /// <param name="termsAndConditionsNotAcceptedCarrierList">TermsAndConditionsNotAcceptedCarrierList property.</param>
        /// <returns>this instance.</returns>
        public GetEligibleShippingServicesResult WithTermsAndConditionsNotAcceptedCarrierList(TermsAndConditionsNotAcceptedCarrier[] termsAndConditionsNotAcceptedCarrierList)
        {
            this._termsAndConditionsNotAcceptedCarrierList.AddRange(termsAndConditionsNotAcceptedCarrierList);
            return this;
        }

        /// <summary>
        /// Checks if TermsAndConditionsNotAcceptedCarrierList property is set.
        /// </summary>
        /// <returns>true if TermsAndConditionsNotAcceptedCarrierList property is set.</returns>
        public bool IsSetTermsAndConditionsNotAcceptedCarrierList()
        {
            return this.TermsAndConditionsNotAcceptedCarrierList.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _shippingServiceList = reader.ReadList<ShippingService>("ShippingServiceList", "ShippingService");
            _temporarilyUnavailableCarrierList = reader.ReadList<TemporarilyUnavailableCarrier>("TemporarilyUnavailableCarrierList", "TemporarilyUnavailableCarrier");
            _termsAndConditionsNotAcceptedCarrierList = reader.ReadList<TermsAndConditionsNotAcceptedCarrier>("TermsAndConditionsNotAcceptedCarrierList", "TermsAndConditionsNotAcceptedCarrier");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("ShippingServiceList", "ShippingService", _shippingServiceList);
            writer.WriteList("TemporarilyUnavailableCarrierList", "TemporarilyUnavailableCarrier", _temporarilyUnavailableCarrierList);
            writer.WriteList("TermsAndConditionsNotAcceptedCarrierList", "TermsAndConditionsNotAcceptedCarrier", _termsAndConditionsNotAcceptedCarrierList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "GetEligibleShippingServicesResult", this);
        }

    public GetEligibleShippingServicesResult (List<ShippingService> shippingServiceList) : base() {
        this._shippingServiceList = shippingServiceList;
    }

        public GetEligibleShippingServicesResult() : base()
        {
        }
    }
}
