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
 * Fee Detail
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Products.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false)]
    public class FeeDetail : AbstractMwsObject
    {

        private string _feeType;
        private MoneyType _feeAmount;
        private MoneyType _feePromotion;
        private MoneyType _taxAmount;
        private MoneyType _finalFee;
        private FeeDetailList _includedFeeDetailList;

        /// <summary>
        /// Gets and sets the FeeType property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeeType")]
        public string FeeType
        {
            get { return this._feeType; }
            set { this._feeType = value; }
        }

        /// <summary>
        /// Sets the FeeType property.
        /// </summary>
        /// <param name="feeType">FeeType property.</param>
        /// <returns>this instance.</returns>
        public FeeDetail WithFeeType(string feeType)
        {
            this._feeType = feeType;
            return this;
        }

        /// <summary>
        /// Checks if FeeType property is set.
        /// </summary>
        /// <returns>true if FeeType property is set.</returns>
        public bool IsSetFeeType()
        {
            return this._feeType != null;
        }

        /// <summary>
        /// Gets and sets the FeeAmount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeeAmount")]
        public MoneyType FeeAmount
        {
            get { return this._feeAmount; }
            set { this._feeAmount = value; }
        }

        /// <summary>
        /// Sets the FeeAmount property.
        /// </summary>
        /// <param name="feeAmount">FeeAmount property.</param>
        /// <returns>this instance.</returns>
        public FeeDetail WithFeeAmount(MoneyType feeAmount)
        {
            this._feeAmount = feeAmount;
            return this;
        }

        /// <summary>
        /// Checks if FeeAmount property is set.
        /// </summary>
        /// <returns>true if FeeAmount property is set.</returns>
        public bool IsSetFeeAmount()
        {
            return this._feeAmount != null;
        }

        /// <summary>
        /// Gets and sets the FeePromotion property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeePromotion")]
        public MoneyType FeePromotion
        {
            get { return this._feePromotion; }
            set { this._feePromotion = value; }
        }

        /// <summary>
        /// Sets the FeePromotion property.
        /// </summary>
        /// <param name="feePromotion">FeePromotion property.</param>
        /// <returns>this instance.</returns>
        public FeeDetail WithFeePromotion(MoneyType feePromotion)
        {
            this._feePromotion = feePromotion;
            return this;
        }

        /// <summary>
        /// Checks if FeePromotion property is set.
        /// </summary>
        /// <returns>true if FeePromotion property is set.</returns>
        public bool IsSetFeePromotion()
        {
            return this._feePromotion != null;
        }

        /// <summary>
        /// Gets and sets the TaxAmount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TaxAmount")]
        public MoneyType TaxAmount
        {
            get { return this._taxAmount; }
            set { this._taxAmount = value; }
        }

        /// <summary>
        /// Sets the TaxAmount property.
        /// </summary>
        /// <param name="taxAmount">TaxAmount property.</param>
        /// <returns>this instance.</returns>
        public FeeDetail WithTaxAmount(MoneyType taxAmount)
        {
            this._taxAmount = taxAmount;
            return this;
        }

        /// <summary>
        /// Checks if TaxAmount property is set.
        /// </summary>
        /// <returns>true if TaxAmount property is set.</returns>
        public bool IsSetTaxAmount()
        {
            return this._taxAmount != null;
        }

        /// <summary>
        /// Gets and sets the FinalFee property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FinalFee")]
        public MoneyType FinalFee
        {
            get { return this._finalFee; }
            set { this._finalFee = value; }
        }

        /// <summary>
        /// Sets the FinalFee property.
        /// </summary>
        /// <param name="finalFee">FinalFee property.</param>
        /// <returns>this instance.</returns>
        public FeeDetail WithFinalFee(MoneyType finalFee)
        {
            this._finalFee = finalFee;
            return this;
        }

        /// <summary>
        /// Checks if FinalFee property is set.
        /// </summary>
        /// <returns>true if FinalFee property is set.</returns>
        public bool IsSetFinalFee()
        {
            return this._finalFee != null;
        }

        /// <summary>
        /// Gets and sets the IncludedFeeDetailList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "IncludedFeeDetailList")]
        public FeeDetailList IncludedFeeDetailList
        {
            get { return this._includedFeeDetailList; }
            set { this._includedFeeDetailList = value; }
        }

        /// <summary>
        /// Sets the IncludedFeeDetailList property.
        /// </summary>
        /// <param name="includedFeeDetailList">IncludedFeeDetailList property.</param>
        /// <returns>this instance.</returns>
        public FeeDetail WithIncludedFeeDetailList(FeeDetailList includedFeeDetailList)
        {
            this._includedFeeDetailList = includedFeeDetailList;
            return this;
        }

        /// <summary>
        /// Checks if IncludedFeeDetailList property is set.
        /// </summary>
        /// <returns>true if IncludedFeeDetailList property is set.</returns>
        public bool IsSetIncludedFeeDetailList()
        {
            return this._includedFeeDetailList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _feeType = reader.Read<string>("FeeType");
            _feeAmount = reader.Read<MoneyType>("FeeAmount");
            _feePromotion = reader.Read<MoneyType>("FeePromotion");
            _taxAmount = reader.Read<MoneyType>("TaxAmount");
            _finalFee = reader.Read<MoneyType>("FinalFee");
            _includedFeeDetailList = reader.Read<FeeDetailList>("IncludedFeeDetailList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("FeeType", _feeType);
            writer.Write("FeeAmount", _feeAmount);
            writer.Write("FeePromotion", _feePromotion);
            writer.Write("TaxAmount", _taxAmount);
            writer.Write("FinalFee", _finalFee);
            writer.Write("IncludedFeeDetailList", _includedFeeDetailList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "FeeDetail", this);
        }


        public FeeDetail() : base()
        {
        }
    }
}
