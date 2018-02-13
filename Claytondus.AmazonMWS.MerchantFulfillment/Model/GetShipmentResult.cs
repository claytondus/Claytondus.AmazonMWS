/*******************************************************************************
 * Copyright 2009-2016 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Get Shipment Result
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class GetShipmentResult : AbstractMwsObject
    {

        private Shipment _shipment;

        /// <summary>
        /// Gets and sets the Shipment property.
        /// </summary>
        public Shipment Shipment
        {
            get { return this._shipment; }
            set { this._shipment = value; }
        }

        /// <summary>
        /// Sets the Shipment property.
        /// </summary>
        /// <param name="shipment">Shipment property.</param>
        /// <returns>this instance.</returns>
        public GetShipmentResult WithShipment(Shipment shipment)
        {
            this._shipment = shipment;
            return this;
        }

        /// <summary>
        /// Checks if Shipment property is set.
        /// </summary>
        /// <returns>true if Shipment property is set.</returns>
        public bool IsSetShipment()
        {
            return this._shipment != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _shipment = reader.Read<Shipment>("Shipment");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Shipment", _shipment);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "GetShipmentResult", this);
        }

    public GetShipmentResult (Shipment shipment) : base() {
        this._shipment = shipment;
    }

        public GetShipmentResult() : base()
        {
        }
    }
}
