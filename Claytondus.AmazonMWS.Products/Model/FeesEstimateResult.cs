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
 * Fees Estimate Result
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
    public class FeesEstimateResult : AbstractMwsObject
    {

        private string _status;
        private FeesEstimateIdentifier _feesEstimateIdentifier;
        private FeesEstimate _feesEstimate;
        private Error _error;

        /// <summary>
        /// Gets and sets the Status property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        /// <summary>
        /// Sets the Status property.
        /// </summary>
        /// <param name="status">Status property.</param>
        /// <returns>this instance.</returns>
        public FeesEstimateResult WithStatus(string status)
        {
            this._status = status;
            return this;
        }

        /// <summary>
        /// Checks if Status property is set.
        /// </summary>
        /// <returns>true if Status property is set.</returns>
        public bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the FeesEstimateIdentifier property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeesEstimateIdentifier")]
        public FeesEstimateIdentifier FeesEstimateIdentifier
        {
            get { return this._feesEstimateIdentifier; }
            set { this._feesEstimateIdentifier = value; }
        }

        /// <summary>
        /// Sets the FeesEstimateIdentifier property.
        /// </summary>
        /// <param name="feesEstimateIdentifier">FeesEstimateIdentifier property.</param>
        /// <returns>this instance.</returns>
        public FeesEstimateResult WithFeesEstimateIdentifier(FeesEstimateIdentifier feesEstimateIdentifier)
        {
            this._feesEstimateIdentifier = feesEstimateIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if FeesEstimateIdentifier property is set.
        /// </summary>
        /// <returns>true if FeesEstimateIdentifier property is set.</returns>
        public bool IsSetFeesEstimateIdentifier()
        {
            return this._feesEstimateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the FeesEstimate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeesEstimate")]
        public FeesEstimate FeesEstimate
        {
            get { return this._feesEstimate; }
            set { this._feesEstimate = value; }
        }

        /// <summary>
        /// Sets the FeesEstimate property.
        /// </summary>
        /// <param name="feesEstimate">FeesEstimate property.</param>
        /// <returns>this instance.</returns>
        public FeesEstimateResult WithFeesEstimate(FeesEstimate feesEstimate)
        {
            this._feesEstimate = feesEstimate;
            return this;
        }

        /// <summary>
        /// Checks if FeesEstimate property is set.
        /// </summary>
        /// <returns>true if FeesEstimate property is set.</returns>
        public bool IsSetFeesEstimate()
        {
            return this._feesEstimate != null;
        }

        /// <summary>
        /// Gets and sets the Error property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Error")]
        public Error Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        /// <summary>
        /// Sets the Error property.
        /// </summary>
        /// <param name="error">Error property.</param>
        /// <returns>this instance.</returns>
        public FeesEstimateResult WithError(Error error)
        {
            this._error = error;
            return this;
        }

        /// <summary>
        /// Checks if Error property is set.
        /// </summary>
        /// <returns>true if Error property is set.</returns>
        public bool IsSetError()
        {
            return this._error != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _status = reader.Read<string>("Status");
            _feesEstimateIdentifier = reader.Read<FeesEstimateIdentifier>("FeesEstimateIdentifier");
            _feesEstimate = reader.Read<FeesEstimate>("FeesEstimate");
            _error = reader.Read<Error>("Error");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Status", _status);
            writer.Write("FeesEstimateIdentifier", _feesEstimateIdentifier);
            writer.Write("FeesEstimate", _feesEstimate);
            writer.Write("Error", _error);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "FeesEstimateResult", this);
        }


        public FeesEstimateResult() : base()
        {
        }
    }
}
