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
 * Attribute Key Value List
 * API Version: 2013-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:27:11 GMT 2015
 */


using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Subscriptions.Model
{
    public class AttributeKeyValueList : AbstractMwsObject
    {

        private List<AttributeKeyValue> _member;

        /// <summary>
        /// Gets and sets the Member property.
        /// </summary>
        public List<AttributeKeyValue> Member
        {
            get
            {
                if(this._member == null)
                {
                    this._member = new List<AttributeKeyValue>();
                }
                return this._member;
            }
            set { this._member = value; }
        }

        /// <summary>
        /// Sets the Member property.
        /// </summary>
        /// <param name="member">Member property.</param>
        /// <returns>this instance.</returns>
        public AttributeKeyValueList WithMember(AttributeKeyValue[] member)
        {
            this._member.AddRange(member);
            return this;
        }

        /// <summary>
        /// Checks if Member property is set.
        /// </summary>
        /// <returns>true if Member property is set.</returns>
        public bool IsSetMember()
        {
            return this.Member.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _member = reader.ReadList<AttributeKeyValue>("member");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("member", _member);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Subscriptions/2013-07-01", "AttributeKeyValueList", this);
        }

        public AttributeKeyValueList() : base()
        {
        }
    }
}
