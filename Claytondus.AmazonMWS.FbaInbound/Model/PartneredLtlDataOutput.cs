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
 * Partnered Ltl Data Output
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
    public class PartneredLtlDataOutput : AbstractMwsObject
    {

        private Contact _contact;
        private decimal _boxCount;
        private string _sellerFreightClass;
        private string _freightReadyDate;
        private PalletList _palletList;
        private Weight _totalWeight;
        private Amount _sellerDeclaredValue;
        private Amount _amazonCalculatedValue;
        private string _previewPickupDate;
        private string _previewDeliveryDate;
        private string _previewFreightClass;
        private string _amazonReferenceId;
        private bool _isBillOfLadingAvailable;
        private PartneredEstimate _partneredEstimate;
        private string _carrierName;

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
        public PartneredLtlDataOutput WithContact(Contact contact)
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
            get { return this._boxCount; }
            set { this._boxCount = value; }
        }

        /// <summary>
        /// Sets the BoxCount property.
        /// </summary>
        /// <param name="boxCount">BoxCount property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataOutput WithBoxCount(decimal boxCount)
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
        public PartneredLtlDataOutput WithSellerFreightClass(string sellerFreightClass)
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
        public PartneredLtlDataOutput WithFreightReadyDate(string freightReadyDate)
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
        public PartneredLtlDataOutput WithPalletList(PalletList palletList)
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
        public PartneredLtlDataOutput WithTotalWeight(Weight totalWeight)
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
        public PartneredLtlDataOutput WithSellerDeclaredValue(Amount sellerDeclaredValue)
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

        /// <summary>
        /// Gets and sets the AmazonCalculatedValue property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AmazonCalculatedValue")]
        public Amount AmazonCalculatedValue
        {
            get { return this._amazonCalculatedValue; }
            set { this._amazonCalculatedValue = value; }
        }

        /// <summary>
        /// Sets the AmazonCalculatedValue property.
        /// </summary>
        /// <param name="amazonCalculatedValue">AmazonCalculatedValue property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataOutput WithAmazonCalculatedValue(Amount amazonCalculatedValue)
        {
            this._amazonCalculatedValue = amazonCalculatedValue;
            return this;
        }

        /// <summary>
        /// Checks if AmazonCalculatedValue property is set.
        /// </summary>
        /// <returns>true if AmazonCalculatedValue property is set.</returns>
        public bool IsSetAmazonCalculatedValue()
        {
            return this._amazonCalculatedValue != null;
        }

        /// <summary>
        /// Gets and sets the PreviewPickupDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PreviewPickupDate")]
        public string PreviewPickupDate
        {
            get { return this._previewPickupDate; }
            set { this._previewPickupDate = value; }
        }

        /// <summary>
        /// Sets the PreviewPickupDate property.
        /// </summary>
        /// <param name="previewPickupDate">PreviewPickupDate property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataOutput WithPreviewPickupDate(string previewPickupDate)
        {
            this._previewPickupDate = previewPickupDate;
            return this;
        }

        /// <summary>
        /// Checks if PreviewPickupDate property is set.
        /// </summary>
        /// <returns>true if PreviewPickupDate property is set.</returns>
        public bool IsSetPreviewPickupDate()
        {
            return this._previewPickupDate != null;
        }

        /// <summary>
        /// Gets and sets the PreviewDeliveryDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PreviewDeliveryDate")]
        public string PreviewDeliveryDate
        {
            get { return this._previewDeliveryDate; }
            set { this._previewDeliveryDate = value; }
        }

        /// <summary>
        /// Sets the PreviewDeliveryDate property.
        /// </summary>
        /// <param name="previewDeliveryDate">PreviewDeliveryDate property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataOutput WithPreviewDeliveryDate(string previewDeliveryDate)
        {
            this._previewDeliveryDate = previewDeliveryDate;
            return this;
        }

        /// <summary>
        /// Checks if PreviewDeliveryDate property is set.
        /// </summary>
        /// <returns>true if PreviewDeliveryDate property is set.</returns>
        public bool IsSetPreviewDeliveryDate()
        {
            return this._previewDeliveryDate != null;
        }

        /// <summary>
        /// Gets and sets the PreviewFreightClass property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PreviewFreightClass")]
        public string PreviewFreightClass
        {
            get { return this._previewFreightClass; }
            set { this._previewFreightClass = value; }
        }

        /// <summary>
        /// Sets the PreviewFreightClass property.
        /// </summary>
        /// <param name="previewFreightClass">PreviewFreightClass property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataOutput WithPreviewFreightClass(string previewFreightClass)
        {
            this._previewFreightClass = previewFreightClass;
            return this;
        }

        /// <summary>
        /// Checks if PreviewFreightClass property is set.
        /// </summary>
        /// <returns>true if PreviewFreightClass property is set.</returns>
        public bool IsSetPreviewFreightClass()
        {
            return this._previewFreightClass != null;
        }

        /// <summary>
        /// Gets and sets the AmazonReferenceId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AmazonReferenceId")]
        public string AmazonReferenceId
        {
            get { return this._amazonReferenceId; }
            set { this._amazonReferenceId = value; }
        }

        /// <summary>
        /// Sets the AmazonReferenceId property.
        /// </summary>
        /// <param name="amazonReferenceId">AmazonReferenceId property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataOutput WithAmazonReferenceId(string amazonReferenceId)
        {
            this._amazonReferenceId = amazonReferenceId;
            return this;
        }

        /// <summary>
        /// Checks if AmazonReferenceId property is set.
        /// </summary>
        /// <returns>true if AmazonReferenceId property is set.</returns>
        public bool IsSetAmazonReferenceId()
        {
            return this._amazonReferenceId != null;
        }

        /// <summary>
        /// Gets and sets the IsBillOfLadingAvailable property.
        /// </summary>
        [XmlElementAttribute(ElementName = "IsBillOfLadingAvailable")]
        public bool IsBillOfLadingAvailable
        {
            get { return this._isBillOfLadingAvailable; }
            set { this._isBillOfLadingAvailable = value; }
        }

        /// <summary>
        /// Sets the IsBillOfLadingAvailable property.
        /// </summary>
        /// <param name="isBillOfLadingAvailable">IsBillOfLadingAvailable property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataOutput WithIsBillOfLadingAvailable(bool isBillOfLadingAvailable)
        {
            this._isBillOfLadingAvailable = isBillOfLadingAvailable;
            return this;
        }

        /// <summary>
        /// Checks if IsBillOfLadingAvailable property is set.
        /// </summary>
        /// <returns>true if IsBillOfLadingAvailable property is set.</returns>
        public bool IsSetIsBillOfLadingAvailable()
        {
            return this._isBillOfLadingAvailable != null;
        }

        /// <summary>
        /// Gets and sets the PartneredEstimate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PartneredEstimate")]
        public PartneredEstimate PartneredEstimate
        {
            get { return this._partneredEstimate; }
            set { this._partneredEstimate = value; }
        }

        /// <summary>
        /// Sets the PartneredEstimate property.
        /// </summary>
        /// <param name="partneredEstimate">PartneredEstimate property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataOutput WithPartneredEstimate(PartneredEstimate partneredEstimate)
        {
            this._partneredEstimate = partneredEstimate;
            return this;
        }

        /// <summary>
        /// Checks if PartneredEstimate property is set.
        /// </summary>
        /// <returns>true if PartneredEstimate property is set.</returns>
        public bool IsSetPartneredEstimate()
        {
            return this._partneredEstimate != null;
        }

        /// <summary>
        /// Gets and sets the CarrierName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CarrierName")]
        public string CarrierName
        {
            get { return this._carrierName; }
            set { this._carrierName = value; }
        }

        /// <summary>
        /// Sets the CarrierName property.
        /// </summary>
        /// <param name="carrierName">CarrierName property.</param>
        /// <returns>this instance.</returns>
        public PartneredLtlDataOutput WithCarrierName(string carrierName)
        {
            this._carrierName = carrierName;
            return this;
        }

        /// <summary>
        /// Checks if CarrierName property is set.
        /// </summary>
        /// <returns>true if CarrierName property is set.</returns>
        public bool IsSetCarrierName()
        {
            return this._carrierName != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _contact = reader.Read<Contact>("Contact");
            _boxCount = reader.Read<decimal>("BoxCount");
            _sellerFreightClass = reader.Read<string>("SellerFreightClass");
            _freightReadyDate = reader.Read<string>("FreightReadyDate");
            _palletList = reader.Read<PalletList>("PalletList");
            _totalWeight = reader.Read<Weight>("TotalWeight");
            _sellerDeclaredValue = reader.Read<Amount>("SellerDeclaredValue");
            _amazonCalculatedValue = reader.Read<Amount>("AmazonCalculatedValue");
            _previewPickupDate = reader.Read<string>("PreviewPickupDate");
            _previewDeliveryDate = reader.Read<string>("PreviewDeliveryDate");
            _previewFreightClass = reader.Read<string>("PreviewFreightClass");
            _amazonReferenceId = reader.Read<string>("AmazonReferenceId");
            _isBillOfLadingAvailable = reader.Read<bool>("IsBillOfLadingAvailable");
            _partneredEstimate = reader.Read<PartneredEstimate>("PartneredEstimate");
            _carrierName = reader.Read<string>("CarrierName");
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
            writer.Write("AmazonCalculatedValue", _amazonCalculatedValue);
            writer.Write("PreviewPickupDate", _previewPickupDate);
            writer.Write("PreviewDeliveryDate", _previewDeliveryDate);
            writer.Write("PreviewFreightClass", _previewFreightClass);
            writer.Write("AmazonReferenceId", _amazonReferenceId);
            writer.Write("IsBillOfLadingAvailable", _isBillOfLadingAvailable);
            writer.Write("PartneredEstimate", _partneredEstimate);
            writer.Write("CarrierName", _carrierName);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/", "PartneredLtlDataOutput", this);
        }

    public PartneredLtlDataOutput (Contact contact,decimal boxCount,string freightReadyDate,PalletList palletList,Weight totalWeight,string previewPickupDate,string previewDeliveryDate,string previewFreightClass,string amazonReferenceId,bool isBillOfLadingAvailable) : base() {
        this._contact = contact;
        this._boxCount = boxCount;
        this._freightReadyDate = freightReadyDate;
        this._palletList = palletList;
        this._totalWeight = totalWeight;
        this._previewPickupDate = previewPickupDate;
        this._previewDeliveryDate = previewDeliveryDate;
        this._previewFreightClass = previewFreightClass;
        this._amazonReferenceId = amazonReferenceId;
        this._isBillOfLadingAvailable = isBillOfLadingAvailable;
    }

        public PartneredLtlDataOutput() : base()
        {
        }
    }
}
