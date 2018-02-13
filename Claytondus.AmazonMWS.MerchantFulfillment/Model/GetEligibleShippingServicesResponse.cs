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
 * Get Eligible Shipping Services Response
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class GetEligibleShippingServicesResponse : AbstractMwsObject, IMWSResponse
    {

        private GetEligibleShippingServicesResult _getEligibleShippingServicesResult;
        private ResponseMetadata _responseMetadata;
        private ResponseHeaderMetadata _responseHeaderMetadata;

        /// <summary>
        /// Gets and sets the GetEligibleShippingServicesResult property.
        /// </summary>
        public GetEligibleShippingServicesResult GetEligibleShippingServicesResult
        {
            get { return this._getEligibleShippingServicesResult; }
            set { this._getEligibleShippingServicesResult = value; }
        }

        /// <summary>
        /// Sets the GetEligibleShippingServicesResult property.
        /// </summary>
        /// <param name="getEligibleShippingServicesResult">GetEligibleShippingServicesResult property.</param>
        /// <returns>this instance.</returns>
        public GetEligibleShippingServicesResponse WithGetEligibleShippingServicesResult(GetEligibleShippingServicesResult getEligibleShippingServicesResult)
        {
            this._getEligibleShippingServicesResult = getEligibleShippingServicesResult;
            return this;
        }

        /// <summary>
        /// Checks if GetEligibleShippingServicesResult property is set.
        /// </summary>
        /// <returns>true if GetEligibleShippingServicesResult property is set.</returns>
        public bool IsSetGetEligibleShippingServicesResult()
        {
            return this._getEligibleShippingServicesResult != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        public ResponseMetadata ResponseMetadata
        {
            get { return this._responseMetadata; }
            set { this._responseMetadata = value; }
        }

        /// <summary>
        /// Sets the ResponseMetadata property.
        /// </summary>
        /// <param name="responseMetadata">ResponseMetadata property.</param>
        /// <returns>this instance.</returns>
        public GetEligibleShippingServicesResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this._responseMetadata = responseMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseMetadata property is set.</returns>
        public bool IsSetResponseMetadata()
        {
            return this._responseMetadata != null;
        }

        /// <summary>
        /// Gets and sets the ResponseHeaderMetadata property.
        /// </summary>
        public ResponseHeaderMetadata ResponseHeaderMetadata
        {
            get { return this._responseHeaderMetadata; }
            set { this._responseHeaderMetadata = value; }
        }

        /// <summary>
        /// Sets the ResponseHeaderMetadata property.
        /// </summary>
        /// <param name="responseHeaderMetadata">ResponseHeaderMetadata property.</param>
        /// <returns>this instance.</returns>
        public GetEligibleShippingServicesResponse WithResponseHeaderMetadata(ResponseHeaderMetadata responseHeaderMetadata)
        {
            this._responseHeaderMetadata = responseHeaderMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseHeaderMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseHeaderMetadata property is set.</returns>
        public bool IsSetResponseHeaderMetadata()
        {
            return this._responseHeaderMetadata != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _getEligibleShippingServicesResult = reader.Read<GetEligibleShippingServicesResult>("GetEligibleShippingServicesResult");
            _responseMetadata = reader.Read<ResponseMetadata>("ResponseMetadata");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("GetEligibleShippingServicesResult", _getEligibleShippingServicesResult);
            writer.Write("ResponseMetadata", _responseMetadata);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "GetEligibleShippingServicesResponse", this);
        }


        public GetEligibleShippingServicesResponse() : base()
        {
        }
    }
}
