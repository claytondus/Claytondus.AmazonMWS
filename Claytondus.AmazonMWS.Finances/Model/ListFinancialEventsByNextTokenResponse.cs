/*******************************************************************************
 * Copyright 2009-2018 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * List Financial Events By Next Token Response
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class ListFinancialEventsByNextTokenResponse : AbstractMwsObject, IMWSResponse
    {

        private ListFinancialEventsByNextTokenResult _listFinancialEventsByNextTokenResult;
        private ResponseMetadata _responseMetadata;
        private ResponseHeaderMetadata _responseHeaderMetadata;

        /// <summary>
        /// Gets and sets the ListFinancialEventsByNextTokenResult property.
        /// </summary>
        public ListFinancialEventsByNextTokenResult ListFinancialEventsByNextTokenResult
        {
            get { return this._listFinancialEventsByNextTokenResult; }
            set { this._listFinancialEventsByNextTokenResult = value; }
        }

        /// <summary>
        /// Sets the ListFinancialEventsByNextTokenResult property.
        /// </summary>
        /// <param name="listFinancialEventsByNextTokenResult">ListFinancialEventsByNextTokenResult property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventsByNextTokenResponse WithListFinancialEventsByNextTokenResult(ListFinancialEventsByNextTokenResult listFinancialEventsByNextTokenResult)
        {
            this._listFinancialEventsByNextTokenResult = listFinancialEventsByNextTokenResult;
            return this;
        }

        /// <summary>
        /// Checks if ListFinancialEventsByNextTokenResult property is set.
        /// </summary>
        /// <returns>true if ListFinancialEventsByNextTokenResult property is set.</returns>
        public bool IsSetListFinancialEventsByNextTokenResult()
        {
            return this._listFinancialEventsByNextTokenResult != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        public ResponseMetadata ResponseMetadata
        {
            get { return this._responseMetadata; }
            set { this._responseMetadata = value; }
        }

        /// <summary>
        /// Sets the ResponseMetadata property.
        /// </summary>
        /// <param name="responseMetadata">ResponseMetadata property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventsByNextTokenResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this._responseMetadata = responseMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseMetadata property is set.</returns>
        public bool IsSetResponseMetadata()
        {
            return this._responseMetadata != null;
        }

        /// <summary>
        /// Gets and sets the ResponseHeaderMetadata property.
        /// </summary>
        public ResponseHeaderMetadata ResponseHeaderMetadata
        {
            get { return this._responseHeaderMetadata; }
            set { this._responseHeaderMetadata = value; }
        }

        /// <summary>
        /// Sets the ResponseHeaderMetadata property.
        /// </summary>
        /// <param name="responseHeaderMetadata">ResponseHeaderMetadata property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventsByNextTokenResponse WithResponseHeaderMetadata(ResponseHeaderMetadata responseHeaderMetadata)
        {
            this._responseHeaderMetadata = responseHeaderMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseHeaderMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseHeaderMetadata property is set.</returns>
        public bool IsSetResponseHeaderMetadata()
        {
            return this._responseHeaderMetadata != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _listFinancialEventsByNextTokenResult = reader.Read<ListFinancialEventsByNextTokenResult>("ListFinancialEventsByNextTokenResult");
            _responseMetadata = reader.Read<ResponseMetadata>("ResponseMetadata");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ListFinancialEventsByNextTokenResult", _listFinancialEventsByNextTokenResult);
            writer.Write("ResponseMetadata", _responseMetadata);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "ListFinancialEventsByNextTokenResponse", this);
        }


        public ListFinancialEventsByNextTokenResponse() : base()
        {
        }
    }
}
