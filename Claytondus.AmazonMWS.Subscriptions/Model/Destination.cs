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
 * Destination
 * API Version: 2013-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:27:11 GMT 2015
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Subscriptions.Model
{
    public class Destination : AbstractMwsObject
    {

        private string _deliveryChannel;
        private AttributeKeyValueList _attributeList;

        /// <summary>
        /// Gets and sets the DeliveryChannel property.
        /// </summary>
        public string DeliveryChannel
        {
            get { return this._deliveryChannel; }
            set { this._deliveryChannel = value; }
        }

        /// <summary>
        /// Sets the DeliveryChannel property.
        /// </summary>
        /// <param name="deliveryChannel">DeliveryChannel property.</param>
        /// <returns>this instance.</returns>
        public Destination WithDeliveryChannel(string deliveryChannel)
        {
            this._deliveryChannel = deliveryChannel;
            return this;
        }

        /// <summary>
        /// Checks if DeliveryChannel property is set.
        /// </summary>
        /// <returns>true if DeliveryChannel property is set.</returns>
        public bool IsSetDeliveryChannel()
        {
            return this._deliveryChannel != null;
        }

        /// <summary>
        /// Gets and sets the AttributeList property.
        /// </summary>
        public AttributeKeyValueList AttributeList
        {
            get { return this._attributeList; }
            set { this._attributeList = value; }
        }

        /// <summary>
        /// Sets the AttributeList property.
        /// </summary>
        /// <param name="attributeList">AttributeList property.</param>
        /// <returns>this instance.</returns>
        public Destination WithAttributeList(AttributeKeyValueList attributeList)
        {
            this._attributeList = attributeList;
            return this;
        }

        /// <summary>
        /// Checks if AttributeList property is set.
        /// </summary>
        /// <returns>true if AttributeList property is set.</returns>
        public bool IsSetAttributeList()
        {
            return this._attributeList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _deliveryChannel = reader.Read<string>("DeliveryChannel");
            _attributeList = reader.Read<AttributeKeyValueList>("AttributeList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("DeliveryChannel", _deliveryChannel);
            writer.Write("AttributeList", _attributeList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Subscriptions/2013-07-01", "Destination", this);
        }

        public Destination() : base()
        {
        }
    }
}
