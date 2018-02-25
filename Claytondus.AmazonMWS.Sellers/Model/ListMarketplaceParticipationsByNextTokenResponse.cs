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
 * List Marketplace Participations By Next Token Response
 * API Version: 2011-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 20:37:46 GMT 2015
 */


using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Sellers.Model
{
    [XmlType(Namespace = "https://mws.amazonservices.com/Sellers/2011-07-01")]
    [XmlRootAttribute(Namespace = "https://mws.amazonservices.com/Sellers/2011-07-01", IsNullable = false)]
    public class ListMarketplaceParticipationsByNextTokenResponse : AbstractMwsObject, IMWSResponse
    {

        private ListMarketplaceParticipationsByNextTokenResult _listMarketplaceParticipationsByNextTokenResult;
        private ResponseMetadata _responseMetadata;
        private ResponseHeaderMetadata _responseHeaderMetadata;

        /// <summary>
        /// Gets and sets the ListMarketplaceParticipationsByNextTokenResult property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ListMarketplaceParticipationsByNextTokenResult")]
        public ListMarketplaceParticipationsByNextTokenResult ListMarketplaceParticipationsByNextTokenResult
        {
            get { return this._listMarketplaceParticipationsByNextTokenResult; }
            set { this._listMarketplaceParticipationsByNextTokenResult = value; }
        }

        /// <summary>
        /// Sets the ListMarketplaceParticipationsByNextTokenResult property.
        /// </summary>
        /// <param name="listMarketplaceParticipationsByNextTokenResult">ListMarketplaceParticipationsByNextTokenResult property.</param>
        /// <returns>this instance.</returns>
        public ListMarketplaceParticipationsByNextTokenResponse WithListMarketplaceParticipationsByNextTokenResult(ListMarketplaceParticipationsByNextTokenResult listMarketplaceParticipationsByNextTokenResult)
        {
            this._listMarketplaceParticipationsByNextTokenResult = listMarketplaceParticipationsByNextTokenResult;
            return this;
        }

        /// <summary>
        /// Checks if ListMarketplaceParticipationsByNextTokenResult property is set.
        /// </summary>
        /// <returns>true if ListMarketplaceParticipationsByNextTokenResult property is set.</returns>
        public bool IsSetListMarketplaceParticipationsByNextTokenResult()
        {
            return this._listMarketplaceParticipationsByNextTokenResult != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
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
        public ListMarketplaceParticipationsByNextTokenResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
        [XmlElementAttribute(ElementName = "ResponseHeaderMetadata")]
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
        public ListMarketplaceParticipationsByNextTokenResponse WithResponseHeaderMetadata(ResponseHeaderMetadata responseHeaderMetadata)
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
            _listMarketplaceParticipationsByNextTokenResult = reader.Read<ListMarketplaceParticipationsByNextTokenResult>("ListMarketplaceParticipationsByNextTokenResult");
            _responseMetadata = reader.Read<ResponseMetadata>("ResponseMetadata");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ListMarketplaceParticipationsByNextTokenResult", _listMarketplaceParticipationsByNextTokenResult);
            writer.Write("ResponseMetadata", _responseMetadata);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Sellers/2011-07-01", "ListMarketplaceParticipationsByNextTokenResponse", this);
        }

        public ListMarketplaceParticipationsByNextTokenResponse() : base()
        {
        }
    }
}
