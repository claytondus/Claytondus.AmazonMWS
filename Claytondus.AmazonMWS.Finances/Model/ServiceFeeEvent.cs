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
 * Service Fee Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class ServiceFeeEvent : AbstractMwsObject
    {

        private string _amazonOrderId;
        private string _feeReason;
        private List<FeeComponent> _feeList;
        private string _sellerSKU;
        private string _fnSKU;
        private string _feeDescription;
        private string _asin;

        /// <summary>
        /// Gets and sets the AmazonOrderId property.
        /// </summary>
        public string AmazonOrderId
        {
            get { return this._amazonOrderId; }
            set { this._amazonOrderId = value; }
        }

        /// <summary>
        /// Sets the AmazonOrderId property.
        /// </summary>
        /// <param name="amazonOrderId">AmazonOrderId property.</param>
        /// <returns>this instance.</returns>
        public ServiceFeeEvent WithAmazonOrderId(string amazonOrderId)
        {
            this._amazonOrderId = amazonOrderId;
            return this;
        }

        /// <summary>
        /// Checks if AmazonOrderId property is set.
        /// </summary>
        /// <returns>true if AmazonOrderId property is set.</returns>
        public bool IsSetAmazonOrderId()
        {
            return this._amazonOrderId != null;
        }

        /// <summary>
        /// Gets and sets the FeeReason property.
        /// </summary>
        public string FeeReason
        {
            get { return this._feeReason; }
            set { this._feeReason = value; }
        }

        /// <summary>
        /// Sets the FeeReason property.
        /// </summary>
        /// <param name="feeReason">FeeReason property.</param>
        /// <returns>this instance.</returns>
        public ServiceFeeEvent WithFeeReason(string feeReason)
        {
            this._feeReason = feeReason;
            return this;
        }

        /// <summary>
        /// Checks if FeeReason property is set.
        /// </summary>
        /// <returns>true if FeeReason property is set.</returns>
        public bool IsSetFeeReason()
        {
            return this._feeReason != null;
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
        public ServiceFeeEvent WithFeeList(FeeComponent[] feeList)
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
        /// Gets and sets the SellerSKU property.
        /// </summary>
        public string SellerSKU
        {
            get { return this._sellerSKU; }
            set { this._sellerSKU = value; }
        }

        /// <summary>
        /// Sets the SellerSKU property.
        /// </summary>
        /// <param name="sellerSKU">SellerSKU property.</param>
        /// <returns>this instance.</returns>
        public ServiceFeeEvent WithSellerSKU(string sellerSKU)
        {
            this._sellerSKU = sellerSKU;
            return this;
        }

        /// <summary>
        /// Checks if SellerSKU property is set.
        /// </summary>
        /// <returns>true if SellerSKU property is set.</returns>
        public bool IsSetSellerSKU()
        {
            return this._sellerSKU != null;
        }

        /// <summary>
        /// Gets and sets the FnSKU property.
        /// </summary>
        public string FnSKU
        {
            get { return this._fnSKU; }
            set { this._fnSKU = value; }
        }

        /// <summary>
        /// Sets the FnSKU property.
        /// </summary>
        /// <param name="fnSKU">FnSKU property.</param>
        /// <returns>this instance.</returns>
        public ServiceFeeEvent WithFnSKU(string fnSKU)
        {
            this._fnSKU = fnSKU;
            return this;
        }

        /// <summary>
        /// Checks if FnSKU property is set.
        /// </summary>
        /// <returns>true if FnSKU property is set.</returns>
        public bool IsSetFnSKU()
        {
            return this._fnSKU != null;
        }

        /// <summary>
        /// Gets and sets the FeeDescription property.
        /// </summary>
        public string FeeDescription
        {
            get { return this._feeDescription; }
            set { this._feeDescription = value; }
        }

        /// <summary>
        /// Sets the FeeDescription property.
        /// </summary>
        /// <param name="feeDescription">FeeDescription property.</param>
        /// <returns>this instance.</returns>
        public ServiceFeeEvent WithFeeDescription(string feeDescription)
        {
            this._feeDescription = feeDescription;
            return this;
        }

        /// <summary>
        /// Checks if FeeDescription property is set.
        /// </summary>
        /// <returns>true if FeeDescription property is set.</returns>
        public bool IsSetFeeDescription()
        {
            return this._feeDescription != null;
        }

        /// <summary>
        /// Gets and sets the ASIN property.
        /// </summary>
        public string ASIN
        {
            get { return this._asin; }
            set { this._asin = value; }
        }

        /// <summary>
        /// Sets the ASIN property.
        /// </summary>
        /// <param name="asin">ASIN property.</param>
        /// <returns>this instance.</returns>
        public ServiceFeeEvent WithASIN(string asin)
        {
            this._asin = asin;
            return this;
        }

        /// <summary>
        /// Checks if ASIN property is set.
        /// </summary>
        /// <returns>true if ASIN property is set.</returns>
        public bool IsSetASIN()
        {
            return this._asin != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _amazonOrderId = reader.Read<string>("AmazonOrderId");
            _feeReason = reader.Read<string>("FeeReason");
            _feeList = reader.ReadList<FeeComponent>("FeeList", "FeeComponent");
            _sellerSKU = reader.Read<string>("SellerSKU");
            _fnSKU = reader.Read<string>("FnSKU");
            _feeDescription = reader.Read<string>("FeeDescription");
            _asin = reader.Read<string>("ASIN");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("AmazonOrderId", _amazonOrderId);
            writer.Write("FeeReason", _feeReason);
            writer.WriteList("FeeList", "FeeComponent", _feeList);
            writer.Write("SellerSKU", _sellerSKU);
            writer.Write("FnSKU", _fnSKU);
            writer.Write("FeeDescription", _feeDescription);
            writer.Write("ASIN", _asin);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "ServiceFeeEvent", this);
        }


        public ServiceFeeEvent() : base()
        {
        }
    }
}
