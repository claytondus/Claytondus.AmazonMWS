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
 * Buyer Customized Info Detail
 * API Version: 2013-09-01
 * Library Version: 2017-02-22
 * Generated: Thu Mar 02 12:41:05 UTC 2017
 */


using System;
using System.Xml;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Orders.Model
{
    public class BuyerCustomizedInfoDetail : AbstractMwsObject
    {

        private string _customizedURL;

        /// <summary>
        /// Gets and sets the CustomizedURL property.
        /// </summary>
        public string CustomizedURL
        {
            get { return this._customizedURL; }
            set { this._customizedURL = value; }
        }

        /// <summary>
        /// Sets the CustomizedURL property.
        /// </summary>
        /// <param name="customizedURL">CustomizedURL property.</param>
        /// <returns>this instance.</returns>
        public BuyerCustomizedInfoDetail WithCustomizedURL(string customizedURL)
        {
            this._customizedURL = customizedURL;
            return this;
        }

        /// <summary>
        /// Checks if CustomizedURL property is set.
        /// </summary>
        /// <returns>true if CustomizedURL property is set.</returns>
        public bool IsSetCustomizedURL()
        {
            return this._customizedURL != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _customizedURL = reader.Read<string>("CustomizedURL");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("CustomizedURL", _customizedURL);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "BuyerCustomizedInfoDetail", this);
        }


        public BuyerCustomizedInfoDetail() : base()
        {
        }
    }
}
