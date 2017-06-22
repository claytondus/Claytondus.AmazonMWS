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
 * Seller Feedback Type
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
    public class SellerFeedbackType : AbstractMwsObject
    {

        private decimal? _sellerPositiveFeedbackRating;
        private decimal _feedbackCount;

        /// <summary>
        /// Gets and sets the SellerPositiveFeedbackRating property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerPositiveFeedbackRating")]
        public decimal SellerPositiveFeedbackRating
        {
            get { return this._sellerPositiveFeedbackRating.GetValueOrDefault(); }
            set { this._sellerPositiveFeedbackRating = value; }
        }

        /// <summary>
        /// Sets the SellerPositiveFeedbackRating property.
        /// </summary>
        /// <param name="sellerPositiveFeedbackRating">SellerPositiveFeedbackRating property.</param>
        /// <returns>this instance.</returns>
        public SellerFeedbackType WithSellerPositiveFeedbackRating(decimal sellerPositiveFeedbackRating)
        {
            this._sellerPositiveFeedbackRating = sellerPositiveFeedbackRating;
            return this;
        }

        /// <summary>
        /// Checks if SellerPositiveFeedbackRating property is set.
        /// </summary>
        /// <returns>true if SellerPositiveFeedbackRating property is set.</returns>
        public bool IsSetSellerPositiveFeedbackRating()
        {
            return this._sellerPositiveFeedbackRating != null;
        }

        /// <summary>
        /// Gets and sets the FeedbackCount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeedbackCount")]
        public decimal FeedbackCount
        {
            get { return this._feedbackCount; }
            set { this._feedbackCount = value; }
        }

        /// <summary>
        /// Sets the FeedbackCount property.
        /// </summary>
        /// <param name="feedbackCount">FeedbackCount property.</param>
        /// <returns>this instance.</returns>
        public SellerFeedbackType WithFeedbackCount(decimal feedbackCount)
        {
            this._feedbackCount = feedbackCount;
            return this;
        }

        /// <summary>
        /// Checks if FeedbackCount property is set.
        /// </summary>
        /// <returns>true if FeedbackCount property is set.</returns>
        public bool IsSetFeedbackCount()
        {
            return this._feedbackCount != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerPositiveFeedbackRating = reader.Read<decimal?>("SellerPositiveFeedbackRating");
            _feedbackCount = reader.Read<decimal>("FeedbackCount");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerPositiveFeedbackRating", _sellerPositiveFeedbackRating);
            writer.Write("FeedbackCount", _feedbackCount);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "SellerFeedbackType", this);
        }

    public SellerFeedbackType (decimal feedbackCount) : base() {
        this._feedbackCount = feedbackCount;
    }

        public SellerFeedbackType() : base()
        {
        }
    }
}
