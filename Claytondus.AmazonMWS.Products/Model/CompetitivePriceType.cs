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
 * Competitive Price Type
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
    public class CompetitivePriceType : AbstractMwsObject
    {

        private string _competitivePriceId;
        private PriceType _price;
        private string _condition;
        private string _subcondition;
        private bool? _belongsToRequester;

        /// <summary>
        /// Gets and sets the CompetitivePriceId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CompetitivePriceId")]
        public string CompetitivePriceId
        {
            get { return this._competitivePriceId; }
            set { this._competitivePriceId = value; }
        }

        /// <summary>
        /// Sets the CompetitivePriceId property.
        /// </summary>
        /// <param name="competitivePriceId">CompetitivePriceId property.</param>
        /// <returns>this instance.</returns>
        public CompetitivePriceType WithCompetitivePriceId(string competitivePriceId)
        {
            this._competitivePriceId = competitivePriceId;
            return this;
        }

        /// <summary>
        /// Checks if CompetitivePriceId property is set.
        /// </summary>
        /// <returns>true if CompetitivePriceId property is set.</returns>
        public bool IsSetCompetitivePriceId()
        {
            return this._competitivePriceId != null;
        }

        /// <summary>
        /// Gets and sets the Price property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Price")]
        public PriceType Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        /// <summary>
        /// Sets the Price property.
        /// </summary>
        /// <param name="price">Price property.</param>
        /// <returns>this instance.</returns>
        public CompetitivePriceType WithPrice(PriceType price)
        {
            this._price = price;
            return this;
        }

        /// <summary>
        /// Checks if Price property is set.
        /// </summary>
        /// <returns>true if Price property is set.</returns>
        public bool IsSetPrice()
        {
            return this._price != null;
        }

        /// <summary>
        /// Gets and sets the condition property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "condition")]
        public string condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        /// <summary>
        /// Sets the condition property.
        /// </summary>
        /// <param name="condition">condition property.</param>
        /// <returns>this instance.</returns>
        public CompetitivePriceType Withcondition(string condition)
        {
            this._condition = condition;
            return this;
        }

        /// <summary>
        /// Checks if condition property is set.
        /// </summary>
        /// <returns>true if condition property is set.</returns>
        public bool IsSetcondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the subcondition property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "subcondition")]
        public string subcondition
        {
            get { return this._subcondition; }
            set { this._subcondition = value; }
        }

        /// <summary>
        /// Sets the subcondition property.
        /// </summary>
        /// <param name="subcondition">subcondition property.</param>
        /// <returns>this instance.</returns>
        public CompetitivePriceType Withsubcondition(string subcondition)
        {
            this._subcondition = subcondition;
            return this;
        }

        /// <summary>
        /// Checks if subcondition property is set.
        /// </summary>
        /// <returns>true if subcondition property is set.</returns>
        public bool IsSetsubcondition()
        {
            return this._subcondition != null;
        }

        /// <summary>
        /// Gets and sets the belongsToRequester property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "belongsToRequester")]
        public bool belongsToRequester
        {
            get { return this._belongsToRequester.GetValueOrDefault(); }
            set { this._belongsToRequester = value; }
        }

        /// <summary>
        /// Sets the belongsToRequester property.
        /// </summary>
        /// <param name="belongsToRequester">belongsToRequester property.</param>
        /// <returns>this instance.</returns>
        public CompetitivePriceType WithbelongsToRequester(bool belongsToRequester)
        {
            this._belongsToRequester = belongsToRequester;
            return this;
        }

        /// <summary>
        /// Checks if belongsToRequester property is set.
        /// </summary>
        /// <returns>true if belongsToRequester property is set.</returns>
        public bool IsSetbelongsToRequester()
        {
            return this._belongsToRequester != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _condition = reader.ReadAttribute<string>("condition");
            _subcondition = reader.ReadAttribute<string>("subcondition");
            _belongsToRequester = reader.ReadAttribute<bool?>("belongsToRequester");
            _competitivePriceId = reader.Read<string>("CompetitivePriceId");
            _price = reader.Read<PriceType>("Price");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteAttribute("condition",_condition);
            writer.WriteAttribute("subcondition",_subcondition);
            writer.WriteAttribute("belongsToRequester",_belongsToRequester);
            writer.Write("CompetitivePriceId", _competitivePriceId);
            writer.Write("Price", _price);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "CompetitivePriceType", this);
        }

    public CompetitivePriceType (string competitivePriceId,PriceType price) : base() {
        this._competitivePriceId = competitivePriceId;
        this._price = price;
    }

        public CompetitivePriceType() : base()
        {
        }
    }
}
