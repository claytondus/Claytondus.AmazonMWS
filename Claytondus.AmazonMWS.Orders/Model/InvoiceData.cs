/*******************************************************************************
 * Copyright 2009-2017 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Invoice Data
 * API Version: 2013-09-01
 * Library Version: 2017-02-22
 * Generated: Thu Mar 02 12:41:05 UTC 2017
 */


using System;
using System.Xml;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Orders.Model
{
    public class InvoiceData : AbstractMwsObject
    {

        private string _invoiceRequirement;
        private string _buyerSelectedInvoiceCategory;
        private string _invoiceTitle;
        private string _invoiceInformation;

        /// <summary>
        /// Gets and sets the InvoiceRequirement property.
        /// </summary>
        public string InvoiceRequirement
        {
            get { return this._invoiceRequirement; }
            set { this._invoiceRequirement = value; }
        }

        /// <summary>
        /// Sets the InvoiceRequirement property.
        /// </summary>
        /// <param name="invoiceRequirement">InvoiceRequirement property.</param>
        /// <returns>this instance.</returns>
        public InvoiceData WithInvoiceRequirement(string invoiceRequirement)
        {
            this._invoiceRequirement = invoiceRequirement;
            return this;
        }

        /// <summary>
        /// Checks if InvoiceRequirement property is set.
        /// </summary>
        /// <returns>true if InvoiceRequirement property is set.</returns>
        public bool IsSetInvoiceRequirement()
        {
            return this._invoiceRequirement != null;
        }

        /// <summary>
        /// Gets and sets the BuyerSelectedInvoiceCategory property.
        /// </summary>
        public string BuyerSelectedInvoiceCategory
        {
            get { return this._buyerSelectedInvoiceCategory; }
            set { this._buyerSelectedInvoiceCategory = value; }
        }

        /// <summary>
        /// Sets the BuyerSelectedInvoiceCategory property.
        /// </summary>
        /// <param name="buyerSelectedInvoiceCategory">BuyerSelectedInvoiceCategory property.</param>
        /// <returns>this instance.</returns>
        public InvoiceData WithBuyerSelectedInvoiceCategory(string buyerSelectedInvoiceCategory)
        {
            this._buyerSelectedInvoiceCategory = buyerSelectedInvoiceCategory;
            return this;
        }

        /// <summary>
        /// Checks if BuyerSelectedInvoiceCategory property is set.
        /// </summary>
        /// <returns>true if BuyerSelectedInvoiceCategory property is set.</returns>
        public bool IsSetBuyerSelectedInvoiceCategory()
        {
            return this._buyerSelectedInvoiceCategory != null;
        }

        /// <summary>
        /// Gets and sets the InvoiceTitle property.
        /// </summary>
        public string InvoiceTitle
        {
            get { return this._invoiceTitle; }
            set { this._invoiceTitle = value; }
        }

        /// <summary>
        /// Sets the InvoiceTitle property.
        /// </summary>
        /// <param name="invoiceTitle">InvoiceTitle property.</param>
        /// <returns>this instance.</returns>
        public InvoiceData WithInvoiceTitle(string invoiceTitle)
        {
            this._invoiceTitle = invoiceTitle;
            return this;
        }

        /// <summary>
        /// Checks if InvoiceTitle property is set.
        /// </summary>
        /// <returns>true if InvoiceTitle property is set.</returns>
        public bool IsSetInvoiceTitle()
        {
            return this._invoiceTitle != null;
        }

        /// <summary>
        /// Gets and sets the InvoiceInformation property.
        /// </summary>
        public string InvoiceInformation
        {
            get { return this._invoiceInformation; }
            set { this._invoiceInformation = value; }
        }

        /// <summary>
        /// Sets the InvoiceInformation property.
        /// </summary>
        /// <param name="invoiceInformation">InvoiceInformation property.</param>
        /// <returns>this instance.</returns>
        public InvoiceData WithInvoiceInformation(string invoiceInformation)
        {
            this._invoiceInformation = invoiceInformation;
            return this;
        }

        /// <summary>
        /// Checks if InvoiceInformation property is set.
        /// </summary>
        /// <returns>true if InvoiceInformation property is set.</returns>
        public bool IsSetInvoiceInformation()
        {
            return this._invoiceInformation != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _invoiceRequirement = reader.Read<string>("InvoiceRequirement");
            _buyerSelectedInvoiceCategory = reader.Read<string>("BuyerSelectedInvoiceCategory");
            _invoiceTitle = reader.Read<string>("InvoiceTitle");
            _invoiceInformation = reader.Read<string>("InvoiceInformation");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("InvoiceRequirement", _invoiceRequirement);
            writer.Write("BuyerSelectedInvoiceCategory", _buyerSelectedInvoiceCategory);
            writer.Write("InvoiceTitle", _invoiceTitle);
            writer.Write("InvoiceInformation", _invoiceInformation);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "InvoiceData", this);
        }


        public InvoiceData() : base()
        {
        }
    }
}
