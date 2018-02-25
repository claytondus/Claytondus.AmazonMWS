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
 * Marketplace
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
    public class Marketplace : AbstractMwsObject
    {

        private string _marketplaceId;
        private string _name;
        private string _defaultCountryCode;
        private string _defaultCurrencyCode;
        private string _defaultLanguageCode;
        private string _domainName;

        /// <summary>
        /// Gets and sets the MarketplaceId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MarketplaceId")]
        public string MarketplaceId
        {
            get { return this._marketplaceId; }
            set { this._marketplaceId = value; }
        }

        /// <summary>
        /// Sets the MarketplaceId property.
        /// </summary>
        /// <param name="marketplaceId">MarketplaceId property.</param>
        /// <returns>this instance.</returns>
        public Marketplace WithMarketplaceId(string marketplaceId)
        {
            this._marketplaceId = marketplaceId;
            return this;
        }

        /// <summary>
        /// Checks if MarketplaceId property is set.
        /// </summary>
        /// <returns>true if MarketplaceId property is set.</returns>
        public bool IsSetMarketplaceId()
        {
            return this._marketplaceId != null;
        }

        /// <summary>
        /// Gets and sets the Name property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>
        /// Sets the Name property.
        /// </summary>
        /// <param name="name">Name property.</param>
        /// <returns>this instance.</returns>
        public Marketplace WithName(string name)
        {
            this._name = name;
            return this;
        }

        /// <summary>
        /// Checks if Name property is set.
        /// </summary>
        /// <returns>true if Name property is set.</returns>
        public bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the DefaultCountryCode property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DefaultCountryCode")]
        public string DefaultCountryCode
        {
            get { return this._defaultCountryCode; }
            set { this._defaultCountryCode = value; }
        }

        /// <summary>
        /// Sets the DefaultCountryCode property.
        /// </summary>
        /// <param name="defaultCountryCode">DefaultCountryCode property.</param>
        /// <returns>this instance.</returns>
        public Marketplace WithDefaultCountryCode(string defaultCountryCode)
        {
            this._defaultCountryCode = defaultCountryCode;
            return this;
        }

        /// <summary>
        /// Checks if DefaultCountryCode property is set.
        /// </summary>
        /// <returns>true if DefaultCountryCode property is set.</returns>
        public bool IsSetDefaultCountryCode()
        {
            return this._defaultCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the DefaultCurrencyCode property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DefaultCurrencyCode")]
        public string DefaultCurrencyCode
        {
            get { return this._defaultCurrencyCode; }
            set { this._defaultCurrencyCode = value; }
        }

        /// <summary>
        /// Sets the DefaultCurrencyCode property.
        /// </summary>
        /// <param name="defaultCurrencyCode">DefaultCurrencyCode property.</param>
        /// <returns>this instance.</returns>
        public Marketplace WithDefaultCurrencyCode(string defaultCurrencyCode)
        {
            this._defaultCurrencyCode = defaultCurrencyCode;
            return this;
        }

        /// <summary>
        /// Checks if DefaultCurrencyCode property is set.
        /// </summary>
        /// <returns>true if DefaultCurrencyCode property is set.</returns>
        public bool IsSetDefaultCurrencyCode()
        {
            return this._defaultCurrencyCode != null;
        }

        /// <summary>
        /// Gets and sets the DefaultLanguageCode property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DefaultLanguageCode")]
        public string DefaultLanguageCode
        {
            get { return this._defaultLanguageCode; }
            set { this._defaultLanguageCode = value; }
        }

        /// <summary>
        /// Sets the DefaultLanguageCode property.
        /// </summary>
        /// <param name="defaultLanguageCode">DefaultLanguageCode property.</param>
        /// <returns>this instance.</returns>
        public Marketplace WithDefaultLanguageCode(string defaultLanguageCode)
        {
            this._defaultLanguageCode = defaultLanguageCode;
            return this;
        }

        /// <summary>
        /// Checks if DefaultLanguageCode property is set.
        /// </summary>
        /// <returns>true if DefaultLanguageCode property is set.</returns>
        public bool IsSetDefaultLanguageCode()
        {
            return this._defaultLanguageCode != null;
        }

        /// <summary>
        /// Gets and sets the DomainName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DomainName")]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        /// <summary>
        /// Sets the DomainName property.
        /// </summary>
        /// <param name="domainName">DomainName property.</param>
        /// <returns>this instance.</returns>
        public Marketplace WithDomainName(string domainName)
        {
            this._domainName = domainName;
            return this;
        }

        /// <summary>
        /// Checks if DomainName property is set.
        /// </summary>
        /// <returns>true if DomainName property is set.</returns>
        public bool IsSetDomainName()
        {
            return this._domainName != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _name = reader.Read<string>("Name");
            _defaultCountryCode = reader.Read<string>("DefaultCountryCode");
            _defaultCurrencyCode = reader.Read<string>("DefaultCurrencyCode");
            _defaultLanguageCode = reader.Read<string>("DefaultLanguageCode");
            _domainName = reader.Read<string>("DomainName");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("Name", _name);
            writer.Write("DefaultCountryCode", _defaultCountryCode);
            writer.Write("DefaultCurrencyCode", _defaultCurrencyCode);
            writer.Write("DefaultLanguageCode", _defaultLanguageCode);
            writer.Write("DomainName", _domainName);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Sellers/2011-07-01", "Marketplace", this);
        }

        public Marketplace() : base()
        {
        }
    }
}
