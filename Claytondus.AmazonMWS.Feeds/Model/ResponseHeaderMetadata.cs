/******************************************************************************* 
 *  Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 * 
 *  Marketplace Web Service CSharp Library
 *  API Version: 2009-01-01
 * 
 */


using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Claytondus.AmazonMWS.Feeds.Model
{
    public class ResponseHeaderMetadata
    {
        private readonly double _quotaMax;
        private readonly double _quotaRemaining;
        private readonly DateTime _quotaResetsOn;

        public ResponseHeaderMetadata()
        {
            RequestId = ResponseContext = Timestamp = null;
        }

        public ResponseHeaderMetadata(string requestId, string responseContext, string timestamp)
        {
            RequestId = requestId;
            ResponseContext = responseContext;
            Timestamp = timestamp;
        }

        public ResponseHeaderMetadata(string requestId, string responseContext, string timestamp, string quotaMax,
            string quotaRemaining, string quotaResetsOn) : this(requestId, responseContext, timestamp)
        {
            double.TryParse(quotaMax, out _quotaMax);
            double.TryParse(quotaRemaining, out _quotaRemaining);
            DateTime.TryParse(quotaResetsOn, CultureInfo.InvariantCulture, DateTimeStyles.None, out _quotaResetsOn);
        }

        public string RequestId { get; }

        public string ResponseContext { get; }

        public string Timestamp { get; }

        public double? QuotaMax => _quotaMax;

        public double? QuotaRemaining => _quotaRemaining;

        public DateTime? QuotaResetsOn => _quotaResetsOn;

        

        public override string ToString()
        {
            return "[RequestId: " + RequestId + ", ResponseContext: " + ResponseContext + ", Timestamp: " + Timestamp +
                   "]";
        }
    }
}