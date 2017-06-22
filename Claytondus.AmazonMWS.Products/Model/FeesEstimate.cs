/*******************************************************************************
 * Copyright 2009-2017 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Fees Estimate
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Products.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false)]
    public class FeesEstimate : AbstractMwsObject
    {

        private DateTime? _timeOfFeesEstimation;
        private MoneyType _totalFeesEstimate;
        private FeeDetailList _feeDetailList;

        /// <summary>
        /// Gets and sets the TimeOfFeesEstimation property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TimeOfFeesEstimation")]
        public DateTime TimeOfFeesEstimation
        {
            get { return this._timeOfFeesEstimation.GetValueOrDefault(); }
            set { this._timeOfFeesEstimation = value; }
        }

        /// <summary>
        /// Sets the TimeOfFeesEstimation property.
        /// </summary>
        /// <param name="timeOfFeesEstimation">TimeOfFeesEstimation property.</param>
        /// <returns>this instance.</returns>
        public FeesEstimate WithTimeOfFeesEstimation(DateTime timeOfFeesEstimation)
        {
            this._timeOfFeesEstimation = timeOfFeesEstimation;
            return this;
        }

        /// <summary>
        /// Checks if TimeOfFeesEstimation property is set.
        /// </summary>
        /// <returns>true if TimeOfFeesEstimation property is set.</returns>
        public bool IsSetTimeOfFeesEstimation()
        {
            return this._timeOfFeesEstimation != null;
        }

        /// <summary>
        /// Gets and sets the TotalFeesEstimate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TotalFeesEstimate")]
        public MoneyType TotalFeesEstimate
        {
            get { return this._totalFeesEstimate; }
            set { this._totalFeesEstimate = value; }
        }

        /// <summary>
        /// Sets the TotalFeesEstimate property.
        /// </summary>
        /// <param name="totalFeesEstimate">TotalFeesEstimate property.</param>
        /// <returns>this instance.</returns>
        public FeesEstimate WithTotalFeesEstimate(MoneyType totalFeesEstimate)
        {
            this._totalFeesEstimate = totalFeesEstimate;
            return this;
        }

        /// <summary>
        /// Checks if TotalFeesEstimate property is set.
        /// </summary>
        /// <returns>true if TotalFeesEstimate property is set.</returns>
        public bool IsSetTotalFeesEstimate()
        {
            return this._totalFeesEstimate != null;
        }

        /// <summary>
        /// Gets and sets the FeeDetailList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeeDetailList")]
        public FeeDetailList FeeDetailList
        {
            get { return this._feeDetailList; }
            set { this._feeDetailList = value; }
        }

        /// <summary>
        /// Sets the FeeDetailList property.
        /// </summary>
        /// <param name="feeDetailList">FeeDetailList property.</param>
        /// <returns>this instance.</returns>
        public FeesEstimate WithFeeDetailList(FeeDetailList feeDetailList)
        {
            this._feeDetailList = feeDetailList;
            return this;
        }

        /// <summary>
        /// Checks if FeeDetailList property is set.
        /// </summary>
        /// <returns>true if FeeDetailList property is set.</returns>
        public bool IsSetFeeDetailList()
        {
            return this._feeDetailList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _timeOfFeesEstimation = reader.Read<DateTime?>("TimeOfFeesEstimation");
            _totalFeesEstimate = reader.Read<MoneyType>("TotalFeesEstimate");
            _feeDetailList = reader.Read<FeeDetailList>("FeeDetailList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("TimeOfFeesEstimation", _timeOfFeesEstimation);
            writer.Write("TotalFeesEstimate", _totalFeesEstimate);
            writer.Write("FeeDetailList", _feeDetailList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "FeesEstimate", this);
        }


        public FeesEstimate() : base()
        {
        }
    }
}
