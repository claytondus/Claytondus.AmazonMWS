/******************************************************************************* 
 *  Copyright 2009 Amazon Services.
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
 *  Generated: Mon Mar 16 17:31:42 PDT 2009 
 * 
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MarketplaceWebService.Attributes;


namespace MarketplaceWebService.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRootAttribute(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    [MarketplaceWebService(RequestType = RequestType.STREAMING, ResponseType = ResponseType.DEFAULT)]
    public class SubmitFeedRequest
    {
    
        private String marketplaceField;

        private IdList marketplaceIdListField;

        private String merchantField;
        private String mwsAuthTokenField;

        private Stream feedContentField;

        private String feedTypeField;

        private Boolean? purgeAndReplaceField;

        private String contentMD5;

        // Default to "application/octet-stream" as a content type.
        private ContentType contentType = new ContentType(MediaType.OctetStream);

        /// <summary>
        /// Gets or sets the content type.
        /// Defaults to octet-stream, with no character or content encoding.
        /// </summary>
        public ContentType ContentType
        {
            get { return contentType; }
            set { this.contentType = value; }
        }

        [XmlElementAttribute(ElementName = "ContentMD5")]
        public String ContentMD5
        {
            get { return this.contentMD5; }
            set { this.contentMD5 = value; }
        }

        public SubmitFeedRequest WithContentMD5(String contentMD5)
        {
            this.ContentMD5 = contentMD5;
            return this;
        }

        public Boolean IsSetContentMD5()
        {
            return this.contentMD5 != null;
        }

        /// <summary>
        /// Gets and sets the Marketplace property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Marketplace")]
        [System.Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility. See MarketplaceIdList to specify a Marketplace.")]
        public String Marketplace
        {
            get { return this.marketplaceField ; }
            set { this.marketplaceField= value; }
        }

        /// <summary>
        /// Gets and sets the MarketplaceIdList property, an optional parameter for backwards compatibility. Allows you to specify the marketplaces to submit a feed to.
        /// </summary>
        [XmlElementAttribute(ElementName = "MarketplaceIdList")]
        public IdList MarketplaceIdList
        {
            get { return this.marketplaceIdListField; }
            set { this.marketplaceIdListField = value; }
        }



        /// <summary>
        /// Sets the Marketplace property
        /// </summary>
        /// <param name="marketplace">Marketplace property</param>
        /// <returns>this instance</returns>
        [System.Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility. See MarketplaceIdList to specify a Marketplace.")]
        public SubmitFeedRequest WithMarketplace(String marketplace)
        {
            this.marketplaceField = marketplace;
            return this;
        }

        /// <summary>
        /// Sets the MarketplaceIdList property, an optional parameter for backwards compatibility. Allows you to specify the marketplaces to submit a feed to.
        /// </summary>
        /// <param name="marketplaceIdList"> MarketplaceIdList property</param>
        /// <returns></returns>
        public SubmitFeedRequest WithMarketplaceIdList(IdList marketplaceIdList)
        {
            this.marketplaceIdListField = marketplaceIdList;
            return this;
        }


        /// <summary>
        /// Checks if Marketplace property is set
        /// </summary>
        /// <returns>true if Marketplace property is set</returns>
        [System.Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility. See MarketplaceIdList to specify a Marketplace.")]
        public Boolean IsSetMarketplace()
        {
            return  this.marketplaceField != null;

        }

        /// <summary>
        /// Checks if MarketplaceIdList property is set, an optional parameter for backwards compatibility. Allows you to specify the marketplaces to submit a feed to.
        /// </summary>
        /// <returns>true if MarketplaceIdList property is set</returns>
        public Boolean IsSetMarketplaceIdList()
        {
            return this.marketplaceIdListField != null;
        }


        /// <summary>
        /// Gets and sets the Merchant property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Merchant")]
        public String Merchant
        {
            get { return this.merchantField ; }
            set { this.merchantField= value; }
        }



        /// <summary>
        /// Sets the Merchant property
        /// </summary>
        /// <param name="merchant">Merchant property</param>
        /// <returns>this instance</returns>
        public SubmitFeedRequest WithMerchant(String merchant)
        {
            this.merchantField = merchant;
            return this;
        }



        /// <summary>
        /// Checks if Merchant property is set
        /// </summary>
        /// <returns>true if Merchant property is set</returns>
        public Boolean IsSetMerchant()
        {
            return  this.merchantField != null;

        }

        
        /// <summary>
        /// Gets and sets the MWSAuthToken property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MWSAuthToken")]
        public String MWSAuthToken
        {
            get { return this.mwsAuthTokenField; }
            set { this.mwsAuthTokenField = value; }
        }



        /// <summary>
        /// Sets the MWSAuthToken property
        /// </summary>
        /// <param name="mwsAuthToken">MWSAuthToken property</param>
        /// <returns>this instance</returns>
        public SubmitFeedRequest WithMWSAuthToken(String mwsAuthToken)
        {
            this.mwsAuthTokenField = mwsAuthToken;
            return this;
        }



        /// <summary>
        /// Checks if MWSAuthToken property is set
        /// </summary>
        /// <returns>true if MWSAuthToken property is set</returns>
        public Boolean IsSetMWSAuthToken()
        {
            return this.mwsAuthTokenField != null;
        }

        
        /// <summary>
        /// Gets and sets the FeedContent property.
        /// </summary>
        [MarketplaceWebServiceStream(StreamType = StreamType.REQUEST_STREAM)]
        public Stream FeedContent
        {
            get { return this.feedContentField ; }
            set { this.feedContentField= value; }
        }
        


        /// <summary>
        /// Sets the FeedContent property
        /// </summary>
        /// <param name="feedContent">FeedContent property</param>
        /// <returns>this instance</returns>
        public SubmitFeedRequest WithFeedContent(Stream feedContent)
        {
            this.feedContentField = feedContent;
            return this;
        }



        /// <summary>
        /// Checks if FeedContent property is set
        /// </summary>
        /// <returns>true if FeedContent property is set</returns>
        public Boolean IsSetFeedContent()
        {
            return  this.feedContentField != null;

        }


        /// <summary>
        /// Gets and sets the FeedType property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeedType")]
        public String FeedType
        {
            get { return this.feedTypeField ; }
            set { this.feedTypeField= value; }
        }



        /// <summary>
        /// Sets the FeedType property
        /// </summary>
        /// <param name="feedType">FeedType property</param>
        /// <returns>this instance</returns>
        public SubmitFeedRequest WithFeedType(String feedType)
        {
            this.feedTypeField = feedType;
            return this;
        }



        /// <summary>
        /// Checks if FeedType property is set
        /// </summary>
        /// <returns>true if FeedType property is set</returns>
        public Boolean IsSetFeedType()
        {
            return  this.feedTypeField != null;

        }


        /// <summary>
        /// Gets and sets the PurgeAndReplace property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PurgeAndReplace")]
        public Boolean PurgeAndReplace
        {
            get { return this.purgeAndReplaceField.GetValueOrDefault() ; }
            set { this.purgeAndReplaceField= value; }
        }



        /// <summary>
        /// Sets the PurgeAndReplace property
        /// </summary>
        /// <param name="purgeAndReplace">PurgeAndReplace property</param>
        /// <returns>this instance</returns>
        public SubmitFeedRequest WithPurgeAndReplace(Boolean purgeAndReplace)
        {
            this.purgeAndReplaceField = purgeAndReplace;
            return this;
        }



        /// <summary>
        /// Checks if PurgeAndReplace property is set
        /// </summary>
        /// <returns>true if PurgeAndReplace property is set</returns>
        public Boolean IsSetPurgeAndReplace()
        {
            return  this.purgeAndReplaceField.HasValue;

        }

    }

}
