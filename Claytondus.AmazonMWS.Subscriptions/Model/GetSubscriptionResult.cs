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
 * Get Subscription Result
 * API Version: 2013-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:27:11 GMT 2015
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Subscriptions.Model
{
    public class GetSubscriptionResult : AbstractMwsObject
    {

        private Subscription _subscription;

        /// <summary>
        /// Gets and sets the Subscription property.
        /// </summary>
        public Subscription Subscription
        {
            get { return this._subscription; }
            set { this._subscription = value; }
        }

        /// <summary>
        /// Sets the Subscription property.
        /// </summary>
        /// <param name="subscription">Subscription property.</param>
        /// <returns>this instance.</returns>
        public GetSubscriptionResult WithSubscription(Subscription subscription)
        {
            this._subscription = subscription;
            return this;
        }

        /// <summary>
        /// Checks if Subscription property is set.
        /// </summary>
        /// <returns>true if Subscription property is set.</returns>
        public bool IsSetSubscription()
        {
            return this._subscription != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _subscription = reader.Read<Subscription>("Subscription");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Subscription", _subscription);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Subscriptions/2013-07-01", "GetSubscriptionResult", this);
        }

        public GetSubscriptionResult() : base()
        {
        }
    }
}
