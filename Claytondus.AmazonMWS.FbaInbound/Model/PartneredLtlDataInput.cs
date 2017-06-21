/*******************************************************************************
 * Copyright 2009-2016 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Partnered Ltl Data Input
 * API Version: 2010-10-01
 * Library Version: 2016-10-05
 * Generated: Wed Oct 05 06:15:39 PDT 2016
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.FbaInbound.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    [XmlRootAttribute(Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", IsNullable = false)]
    public class PartneredLtlDataInput : AbstractMwsObject
    {

        private Contact _contact;
        private decimal? _boxCount;
        private string _sellerFreightClass;
        private string _freightReadyDate;
        private PalletList _palletList;
        private Weight _totalWeight;
        private Amount _sellerDeclaredValue;

        /// <summary>
        /// Gets and sets the Contact property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Contact")]
        public Contact Contact
        {
            get { return this._contact; }
            set { this._contact = value; }
        }

        /// <summary>
        /// Sets the Contact property.
        /// </summary>
        /// <param name="contact">Contact property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataInput WithContact(Contact contact)
        {
            this._contact = contact;
            return this;
        }

        /// <summary>
        /// Checks if Contact property is set.
        /// </summary>
        /// <returns>true if Contact property is set.</returns>
        public bool IsSetContact()
        {
            return this._contact != null;
        }

        /// <summary>
        /// Gets and sets the BoxCount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BoxCount")]
        public decimal BoxCount
        {
            get { return this._boxCount.GetValueOrDefault(); }
            set { this._boxCount = value; }
        }

        /// <summary>
        /// Sets the BoxCount property.
        /// </summary>
        /// <param name="boxCount">BoxCount property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataInput WithBoxCount(decimal boxCount)
        {
            this._boxCount = boxCount;
            return this;
        }

        /// <summary>
        /// Checks if BoxCount property is set.
        /// </summary>
        /// <returns>true if BoxCount property is set.</returns>
        public bool IsSetBoxCount()
        {
            return this._boxCount != null;
        }

        /// <summary>
        /// Gets and sets the SellerFreightClass property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerFreightClass")]
        public string SellerFreightClass
        {
            get { return this._sellerFreightClass; }
            set { this._sellerFreightClass = value; }
        }

        /// <summary>
        /// Sets the SellerFreightClass property.
        /// </summary>
        /// <param name="sellerFreightClass">SellerFreightClass property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataInput WithSellerFreightClass(string sellerFreightClass)
        {
            this._sellerFreightClass = sellerFreightClass;
            return this;
        }

        /// <summary>
        /// Checks if SellerFreightClass property is set.
        /// </summary>
        /// <returns>true if SellerFreightClass property is set.</returns>
        public bool IsSetSellerFreightClass()
        {
            return this._sellerFreightClass != null;
        }

        /// <summary>
        /// Gets and sets the FreightReadyDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FreightReadyDate")]
        public string FreightReadyDate
        {
            get { return this._freightReadyDate; }
            set { this._freightReadyDate = value; }
        }

        /// <summary>
        /// Sets the FreightReadyDate property.
        /// </summary>
        /// <param name="freightReadyDate">FreightReadyDate property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataInput WithFreightReadyDate(string freightReadyDate)
        {
            this._freightReadyDate = freightReadyDate;
            return this;
        }

        /// <summary>
        /// Checks if FreightReadyDate property is set.
        /// </summary>
        /// <returns>true if FreightReadyDate property is set.</returns>
        public bool IsSetFreightReadyDate()
        {
            return this._freightReadyDate != null;
        }

        /// <summary>
        /// Gets and sets the PalletList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PalletList")]
        public PalletList PalletList
        {
            get { return this._palletList; }
            set { this._palletList = value; }
        }

        /// <summary>
        /// Sets the PalletList property.
        /// </summary>
        /// <param name="palletList">PalletList property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataInput WithPalletList(PalletList palletList)
        {
            this._palletList = palletList;
            return this;
        }

        /// <summary>
        /// Checks if PalletList property is set.
        /// </summary>
        /// <returns>true if PalletList property is set.</returns>
        public bool IsSetPalletList()
        {
            return this._palletList != null;
        }

        /// <summary>
        /// Gets and sets the TotalWeight property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TotalWeight")]
        public Weight TotalWeight
        {
            get { return this._totalWeight; }
            set { this._totalWeight = value; }
        }

        /// <summary>
        /// Sets the TotalWeight property.
        /// </summary>
        /// <param name="totalWeight">TotalWeight property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataInput WithTotalWeight(Weight totalWeight)
        {
            this._totalWeight = totalWeight;
            return this;
        }

        /// <summary>
        /// Checks if TotalWeight property is set.
        /// </summary>
        /// <returns>true if TotalWeight property is set.</returns>
        public bool IsSetTotalWeight()
        {
            return this._totalWeight != null;
        }

        /// <summary>
        /// Gets and sets the SellerDeclaredValue property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerDeclaredValue")]
        public Amount SellerDeclaredValue
        {
            get { return this._sellerDeclaredValue; }
            set { this._sellerDeclaredValue = value; }
        }

        /// <summary>
        /// Sets the SellerDeclaredValue property.
        /// </summary>
        /// <param name="sellerDeclaredValue">SellerDeclaredValue property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataInput WithSellerDeclaredValue(Amount sellerDeclaredValue)
        {
            this._sellerDeclaredValue = sellerDeclaredValue;
            return this;
        }

        /// <summary>
        /// Checks if SellerDeclaredValue property is set.
        /// </summary>
        /// <returns>true if SellerDeclaredValue property is set.</returns>
        public bool IsSetSellerDeclaredValue()
        {
            return this._sellerDeclaredValue != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _contact = reader.Read<Contact>("Contact");
            _boxCount = reader.Read<decimal?>("BoxCount");
            _sellerFreightClass = reader.Read<string>("SellerFreightClass");
            _freightReadyDate = reader.Read<string>("FreightReadyDate");
            _palletList = reader.Read<PalletList>("PalletList");
            _totalWeight = reader.Read<Weight>("TotalWeight");
            _sellerDeclaredValue = reader.Read<Amount>("SellerDeclaredValue");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Contact", _contact);
            writer.Write("BoxCount", _boxCount);
            writer.Write("SellerFreightClass", _sellerFreightClass);
            writer.Write("FreightReadyDate", _freightReadyDate);
            writer.Write("PalletList", _palletList);
            writer.Write("TotalWeight", _totalWeight);
            writer.Write("SellerDeclaredValue", _sellerDeclaredValue);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "PartneredLtlDataInput", this);
        }


        public PartneredLtlDataInput() : base()
        {
        }
    }
}
