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
 * List Marketplace Participations Result
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
    public class ListMarketplaceParticipationsResult : AbstractMwsObject
    {

        private string _nextToken;
        private ListParticipations _listParticipations;
        private ListMarketplaces _listMarketplaces;

        /// <summary>
        /// Gets and sets the NextToken property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextToken")]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        /// <summary>
        /// Sets the NextToken property.
        /// </summary>
        /// <param name="nextToken">NextToken property.</param>
        /// <returns>this instance.</returns>
        public ListMarketplaceParticipationsResult WithNextToken(string nextToken)
        {
            this._nextToken = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if NextToken property is set.
        /// </summary>
        /// <returns>true if NextToken property is set.</returns>
        public bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the ListParticipations property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ListParticipations")]
        public ListParticipations ListParticipations
        {
            get { return this._listParticipations; }
            set { this._listParticipations = value; }
        }

        /// <summary>
        /// Sets the ListParticipations property.
        /// </summary>
        /// <param name="listParticipations">ListParticipations property.</param>
        /// <returns>this instance.</returns>
        public ListMarketplaceParticipationsResult WithListParticipations(ListParticipations listParticipations)
        {
            this._listParticipations = listParticipations;
            return this;
        }

        /// <summary>
        /// Checks if ListParticipations property is set.
        /// </summary>
        /// <returns>true if ListParticipations property is set.</returns>
        public bool IsSetListParticipations()
        {
            return this._listParticipations != null;
        }

        /// <summary>
        /// Gets and sets the ListMarketplaces property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ListMarketplaces")]
        public ListMarketplaces ListMarketplaces
        {
            get { return this._listMarketplaces; }
            set { this._listMarketplaces = value; }
        }

        /// <summary>
        /// Sets the ListMarketplaces property.
        /// </summary>
        /// <param name="listMarketplaces">ListMarketplaces property.</param>
        /// <returns>this instance.</returns>
        public ListMarketplaceParticipationsResult WithListMarketplaces(ListMarketplaces listMarketplaces)
        {
            this._listMarketplaces = listMarketplaces;
            return this;
        }

        /// <summary>
        /// Checks if ListMarketplaces property is set.
        /// </summary>
        /// <returns>true if ListMarketplaces property is set.</returns>
        public bool IsSetListMarketplaces()
        {
            return this._listMarketplaces != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _nextToken = reader.Read<string>("NextToken");
            _listParticipations = reader.Read<ListParticipations>("ListParticipations");
            _listMarketplaces = reader.Read<ListMarketplaces>("ListMarketplaces");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("NextToken", _nextToken);
            writer.Write("ListParticipations", _listParticipations);
            writer.Write("ListMarketplaces", _listMarketplaces);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Sellers/2011-07-01", "ListMarketplaceParticipationsResult", this);
        }

        public ListMarketplaceParticipationsResult() : base()
        {
        }
    }
}
