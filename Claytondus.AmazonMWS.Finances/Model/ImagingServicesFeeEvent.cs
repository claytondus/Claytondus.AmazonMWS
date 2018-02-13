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
 * Imaging Services Fee Event
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System;
using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class ImagingServicesFeeEvent : AbstractMwsObject
    {

        private string _imagingRequestBillingItemID;
        private string _asin;
        private DateTime? _postedDate;
        private List<FeeComponent> _feeList;

        /// <summary>
        /// Gets and sets the ImagingRequestBillingItemID property.
        /// </summary>
        public string ImagingRequestBillingItemID
        {
            get { return this._imagingRequestBillingItemID; }
            set { this._imagingRequestBillingItemID = value; }
        }

        /// <summary>
        /// Sets the ImagingRequestBillingItemID property.
        /// </summary>
        /// <param name="imagingRequestBillingItemID">ImagingRequestBillingItemID property.</param>
        /// <returns>this instance.</returns>
        public ImagingServicesFeeEvent WithImagingRequestBillingItemID(string imagingRequestBillingItemID)
        {
            this._imagingRequestBillingItemID = imagingRequestBillingItemID;
            return this;
        }

        /// <summary>
        /// Checks if ImagingRequestBillingItemID property is set.
        /// </summary>
        /// <returns>true if ImagingRequestBillingItemID property is set.</returns>
        public bool IsSetImagingRequestBillingItemID()
        {
            return this._imagingRequestBillingItemID != null;
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
        public ImagingServicesFeeEvent WithASIN(string asin)
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
        public ImagingServicesFeeEvent WithPostedDate(DateTime postedDate)
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
        public ImagingServicesFeeEvent WithFeeList(FeeComponent[] feeList)
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


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _imagingRequestBillingItemID = reader.Read<string>("ImagingRequestBillingItemID");
            _asin = reader.Read<string>("ASIN");
            _postedDate = reader.Read<DateTime?>("PostedDate");
            _feeList = reader.ReadList<FeeComponent>("FeeList", "FeeComponent");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ImagingRequestBillingItemID", _imagingRequestBillingItemID);
            writer.Write("ASIN", _asin);
            writer.Write("PostedDate", _postedDate);
            writer.WriteList("FeeList", "FeeComponent", _feeList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "ImagingServicesFeeEvent", this);
        }


        public ImagingServicesFeeEvent() : base()
        {
        }
    }
}
