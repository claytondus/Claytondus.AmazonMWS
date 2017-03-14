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
using MarketplaceWebService.Attributes;


namespace MarketplaceWebService.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRootAttribute(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    [MarketplaceWebServiceAttribute(RequestType = RequestType.DEFAULT, ResponseType = ResponseType.DEFAULT)]
    public class GetFeedSubmissionListRequest
    {
    
        private String marketplaceField;

        private String merchantField;
        private String mwsAuthTokenField;

        private  IdList feedSubmissionIdListField;
        private Decimal? maxCountField;

        private  TypeList feedTypeListField;
        private  StatusList feedProcessingStatusListField;
        private DateTime? submittedFromDateField;

        private DateTime? submittedToDateField;


        /// <summary>
        /// Gets and sets the Marketplace property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Marketplace")]
        [System.Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility.")]
        public String Marketplace
        {
            get { return this.marketplaceField ; }
            set { this.marketplaceField= value; }
        }



        /// <summary>
        /// Sets the Marketplace property
        /// </summary>
        /// <param name="marketplace">Marketplace property</param>
        /// <returns>this instance</returns>
        [System.Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility.")]
        public GetFeedSubmissionListRequest WithMarketplace(String marketplace)
        {
            this.marketplaceField = marketplace;
            return this;
        }



        /// <summary>
        /// Checks if Marketplace property is set
        /// </summary>
        /// <returns>true if Marketplace property is set</returns>
        [System.Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility.")]
        public Boolean IsSetMarketplace()
        {
            return  this.marketplaceField != null;

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
        public GetFeedSubmissionListRequest WithMerchant(String merchant)
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
        public GetFeedSubmissionListRequest WithMWSAuthToken(String mwsAuthToken)
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
        /// Gets and sets the FeedSubmissionIdList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeedSubmissionIdList")]
        public IdList FeedSubmissionIdList
        {
            get { return this.feedSubmissionIdListField ; }
            set { this.feedSubmissionIdListField = value; }
        }



        /// <summary>
        /// Sets the FeedSubmissionIdList property
        /// </summary>
        /// <param name="feedSubmissionIdList">FeedSubmissionIdList property</param>
        /// <returns>this instance</returns>
        public GetFeedSubmissionListRequest WithFeedSubmissionIdList(IdList feedSubmissionIdList)
        {
            this.feedSubmissionIdListField = feedSubmissionIdList;
            return this;
        }



        /// <summary>
        /// Checks if FeedSubmissionIdList property is set
        /// </summary>
        /// <returns>true if FeedSubmissionIdList property is set</returns>
        public Boolean IsSetFeedSubmissionIdList()
        {
            return this.feedSubmissionIdListField != null;
        }




        /// <summary>
        /// Gets and sets the MaxCount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxCount")]
        public Decimal? MaxCount
        {
            get { return this.maxCountField ; }
            set { this.maxCountField= value; }
        }



        /// <summary>
        /// Sets the MaxCount property
        /// </summary>
        /// <param name="maxCount">MaxCount property</param>
        /// <returns>this instance</returns>
        public GetFeedSubmissionListRequest WithMaxCount(Int32? maxCount)
        {
            this.maxCountField = maxCount;
            return this;
        }



        /// <summary>
        /// Checks if MaxCount property is set
        /// </summary>
        /// <returns>true if MaxCount property is set</returns>
        public Boolean IsSetMaxCount()
        {
            return this.maxCountField != null;

        }


        /// <summary>
        /// Gets and sets the FeedTypeList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeedTypeList")]
        public TypeList FeedTypeList
        {
            get { return this.feedTypeListField ; }
            set { this.feedTypeListField = value; }
        }



        /// <summary>
        /// Sets the FeedTypeList property
        /// </summary>
        /// <param name="feedTypeList">FeedTypeList property</param>
        /// <returns>this instance</returns>
        public GetFeedSubmissionListRequest WithFeedTypeList(TypeList feedTypeList)
        {
            this.feedTypeListField = feedTypeList;
            return this;
        }



        /// <summary>
        /// Checks if FeedTypeList property is set
        /// </summary>
        /// <returns>true if FeedTypeList property is set</returns>
        public Boolean IsSetFeedTypeList()
        {
            return this.feedTypeListField != null;
        }




        /// <summary>
        /// Gets and sets the FeedProcessingStatusList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeedProcessingStatusList")]
        public StatusList FeedProcessingStatusList
        {
            get { return this.feedProcessingStatusListField ; }
            set { this.feedProcessingStatusListField = value; }
        }



        /// <summary>
        /// Sets the FeedProcessingStatusList property
        /// </summary>
        /// <param name="feedProcessingStatusList">FeedProcessingStatusList property</param>
        /// <returns>this instance</returns>
        public GetFeedSubmissionListRequest WithFeedProcessingStatusList(StatusList feedProcessingStatusList)
        {
            this.feedProcessingStatusListField = feedProcessingStatusList;
            return this;
        }



        /// <summary>
        /// Checks if FeedProcessingStatusList property is set
        /// </summary>
        /// <returns>true if FeedProcessingStatusList property is set</returns>
        public Boolean IsSetFeedProcessingStatusList()
        {
            return this.feedProcessingStatusListField != null;
        }




        /// <summary>
        /// Gets and sets the SubmittedFromDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubmittedFromDate")]
        public DateTime SubmittedFromDate
        {
            get { return this.submittedFromDateField.GetValueOrDefault() ; }
            set { this.submittedFromDateField= value; }
        }



        /// <summary>
        /// Sets the SubmittedFromDate property
        /// </summary>
        /// <param name="submittedFromDate">SubmittedFromDate property</param>
        /// <returns>this instance</returns>
        public GetFeedSubmissionListRequest WithSubmittedFromDate(DateTime submittedFromDate)
        {
            this.submittedFromDateField = submittedFromDate;
            return this;
        }



        /// <summary>
        /// Checks if SubmittedFromDate property is set
        /// </summary>
        /// <returns>true if SubmittedFromDate property is set</returns>
        public Boolean IsSetSubmittedFromDate()
        {
            return  this.submittedFromDateField.HasValue;

        }


        /// <summary>
        /// Gets and sets the SubmittedToDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubmittedToDate")]
        public DateTime SubmittedToDate
        {
            get { return this.submittedToDateField.GetValueOrDefault() ; }
            set { this.submittedToDateField= value; }
        }



        /// <summary>
        /// Sets the SubmittedToDate property
        /// </summary>
        /// <param name="submittedToDate">SubmittedToDate property</param>
        /// <returns>this instance</returns>
        public GetFeedSubmissionListRequest WithSubmittedToDate(DateTime submittedToDate)
        {
            this.submittedToDateField = submittedToDate;
            return this;
        }



        /// <summary>
        /// Checks if SubmittedToDate property is set
        /// </summary>
        /// <returns>true if SubmittedToDate property is set</returns>
        public Boolean IsSetSubmittedToDate()
        {
            return  this.submittedToDateField.HasValue;

        }





    }

}
