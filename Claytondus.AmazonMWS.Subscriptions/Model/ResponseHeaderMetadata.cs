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
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:27:11 GMT 2015
 */

using System;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Subscriptions.Model
{
    public class ResponseHeaderMetadata : MwsResponseHeaderMetadata
    {
        public ResponseHeaderMetadata(string requestId, string responseContext, string timestamp, double? quotaMax, double? quotaRemaining, DateTime? quotaResetsAt)
            : base(requestId, responseContext, timestamp, quotaMax, quotaRemaining, quotaResetsAt) {}

        public ResponseHeaderMetadata()
            : base(null, "", null, null, null, null) {}

        public ResponseHeaderMetadata(MwsResponseHeaderMetadata rhmd)
            : base(rhmd) {}
    }
}
