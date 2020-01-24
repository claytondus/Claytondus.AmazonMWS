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
 * List Registered Destinations Result
 * API Version: 2013-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:27:11 GMT 2015
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Subscriptions.Model
{
    public class ListRegisteredDestinationsResult : AbstractMwsObject
    {

        private DestinationList _destinationList;

        /// <summary>
        /// Gets and sets the DestinationList property.
        /// </summary>
        public DestinationList DestinationList
        {
            get { return this._destinationList; }
            set { this._destinationList = value; }
        }

        /// <summary>
        /// Sets the DestinationList property.
        /// </summary>
        /// <param name="destinationList">DestinationList property.</param>
        /// <returns>this instance.</returns>
        public ListRegisteredDestinationsResult WithDestinationList(DestinationList destinationList)
        {
            this._destinationList = destinationList;
            return this;
        }

        /// <summary>
        /// Checks if DestinationList property is set.
        /// </summary>
        /// <returns>true if DestinationList property is set.</returns>
        public bool IsSetDestinationList()
        {
            return this._destinationList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _destinationList = reader.Read<DestinationList>("DestinationList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("DestinationList", _destinationList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Subscriptions/2013-07-01", "ListRegisteredDestinationsResult", this);
        }

        public ListRegisteredDestinationsResult() : base()
        {
        }
    }
}
