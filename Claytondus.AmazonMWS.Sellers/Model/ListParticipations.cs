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
 * List Participations
 * API Version: 2011-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 20:37:46 GMT 2015
 */


using System.Collections.Generic;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Sellers.Model
{
    [XmlType(Namespace = "https://mws.amazonservices.com/Sellers/2011-07-01")]
    [XmlRootAttribute(Namespace = "https://mws.amazonservices.com/Sellers/2011-07-01", IsNullable = false)]
    public class ListParticipations : AbstractMwsObject
    {

        private List<Participation> _participation;

        /// <summary>
        /// Gets and sets the Participation property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Participation")]
        public List<Participation> Participation
        {
            get
            {
                if(this._participation == null)
                {
                    this._participation = new List<Participation>();
                }
                return this._participation;
            }
            set { this._participation = value; }
        }

        /// <summary>
        /// Sets the Participation property.
        /// </summary>
        /// <param name="participation">Participation property.</param>
        /// <returns>this instance.</returns>
        public ListParticipations WithParticipation(Participation[] participation)
        {
            this._participation.AddRange(participation);
            return this;
        }

        /// <summary>
        /// Checks if Participation property is set.
        /// </summary>
        /// <returns>true if Participation property is set.</returns>
        public bool IsSetParticipation()
        {
            return this.Participation.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _participation = reader.ReadList<Participation>("Participation");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("Participation", _participation);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Sellers/2011-07-01", "ListParticipations", this);
        }

        public ListParticipations() : base()
        {
        }
    }
}
