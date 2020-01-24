/*******************************************************************************
 * Copyright 2009-2015 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * List Subscriptions Result
 * API Version: 2013-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:27:11 GMT 2015
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Subscriptions.Model
{
    public class ListSubscriptionsResult : AbstractMwsObject
    {

        private SubscriptionList _subscriptionList;

        /// <summary>
        /// Gets and sets the SubscriptionList property.
        /// </summary>
        public SubscriptionList SubscriptionList
        {
            get { return this._subscriptionList; }
            set { this._subscriptionList = value; }
        }

        /// <summary>
        /// Sets the SubscriptionList property.
        /// </summary>
        /// <param name="subscriptionList">SubscriptionList property.</param>
        /// <returns>this instance.</returns>
        public ListSubscriptionsResult WithSubscriptionList(SubscriptionList subscriptionList)
        {
            this._subscriptionList = subscriptionList;
            return this;
        }

        /// <summary>
        /// Checks if SubscriptionList property is set.
        /// </summary>
        /// <returns>true if SubscriptionList property is set.</returns>
        public bool IsSetSubscriptionList()
        {
            return this._subscriptionList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _subscriptionList = reader.Read<SubscriptionList>("SubscriptionList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SubscriptionList", _subscriptionList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Subscriptions/2013-07-01", "ListSubscriptionsResult", this);
        }

        public ListSubscriptionsResult() : base()
        {
        }
    }
}
