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
    public class UpdateReportAcknowledgementsRequest
    {
    
        private String marketplaceField;

        private String merchantField;
        private String mwsAuthTokenField;

        private  IdList reportIdListField;
        private Boolean? acknowledgedField;


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
        public UpdateReportAcknowledgementsRequest WithMarketplace(String marketplace)
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
        public UpdateReportAcknowledgementsRequest WithMerchant(String merchant)
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
        public UpdateReportAcknowledgementsRequest WithMWSAuthToken(String mwsAuthToken)
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
        /// Gets and sets the ReportIdList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReportIdList")]
        public IdList ReportIdList
        {
            get { return this.reportIdListField ; }
            set { this.reportIdListField = value; }
        }



        /// <summary>
        /// Sets the ReportIdList property
        /// </summary>
        /// <param name="reportIdList">ReportIdList property</param>
        /// <returns>this instance</returns>
        public UpdateReportAcknowledgementsRequest WithReportIdList(IdList reportIdList)
        {
            this.reportIdListField = reportIdList;
            return this;
        }



        /// <summary>
        /// Checks if ReportIdList property is set
        /// </summary>
        /// <returns>true if ReportIdList property is set</returns>
        public Boolean IsSetReportIdList()
        {
            return this.reportIdListField != null;
        }




        /// <summary>
        /// Gets and sets the Acknowledged property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Acknowledged")]
        public Boolean Acknowledged
        {
            get { return this.acknowledgedField.GetValueOrDefault() ; }
            set { this.acknowledgedField= value; }
        }



        /// <summary>
        /// Sets the Acknowledged property
        /// </summary>
        /// <param name="acknowledged">Acknowledged property</param>
        /// <returns>this instance</returns>
        public UpdateReportAcknowledgementsRequest WithAcknowledged(Boolean acknowledged)
        {
            this.acknowledgedField = acknowledged;
            return this;
        }



        /// <summary>
        /// Checks if Acknowledged property is set
        /// </summary>
        /// <returns>true if Acknowledged property is set</returns>
        public Boolean IsSetAcknowledged()
        {
            return  this.acknowledgedField.HasValue;

        }





    }

}
