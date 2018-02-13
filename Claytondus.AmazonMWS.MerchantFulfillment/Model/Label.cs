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
 * Label
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class Label : AbstractMwsObject
    {

        private string _customTextForLabel;
        private LabelDimensions _dimensions;
        private FileContents _fileContents;
        private string _labelFormat;
        private string _standardIdForLabel;

        /// <summary>
        /// Gets and sets the CustomTextForLabel property.
        /// </summary>
        public string CustomTextForLabel
        {
            get { return this._customTextForLabel; }
            set { this._customTextForLabel = value; }
        }

        /// <summary>
        /// Sets the CustomTextForLabel property.
        /// </summary>
        /// <param name="customTextForLabel">CustomTextForLabel property.</param>
        /// <returns>this instance.</returns>
        public Label WithCustomTextForLabel(string customTextForLabel)
        {
            this._customTextForLabel = customTextForLabel;
            return this;
        }

        /// <summary>
        /// Checks if CustomTextForLabel property is set.
        /// </summary>
        /// <returns>true if CustomTextForLabel property is set.</returns>
        public bool IsSetCustomTextForLabel()
        {
            return this._customTextForLabel != null;
        }

        /// <summary>
        /// Gets and sets the Dimensions property.
        /// </summary>
        public LabelDimensions Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        /// <summary>
        /// Sets the Dimensions property.
        /// </summary>
        /// <param name="dimensions">Dimensions property.</param>
        /// <returns>this instance.</returns>
        public Label WithDimensions(LabelDimensions dimensions)
        {
            this._dimensions = dimensions;
            return this;
        }

        /// <summary>
        /// Checks if Dimensions property is set.
        /// </summary>
        /// <returns>true if Dimensions property is set.</returns>
        public bool IsSetDimensions()
        {
            return this._dimensions != null;
        }

        /// <summary>
        /// Gets and sets the FileContents property.
        /// </summary>
        public FileContents FileContents
        {
            get { return this._fileContents; }
            set { this._fileContents = value; }
        }

        /// <summary>
        /// Sets the FileContents property.
        /// </summary>
        /// <param name="fileContents">FileContents property.</param>
        /// <returns>this instance.</returns>
        public Label WithFileContents(FileContents fileContents)
        {
            this._fileContents = fileContents;
            return this;
        }

        /// <summary>
        /// Checks if FileContents property is set.
        /// </summary>
        /// <returns>true if FileContents property is set.</returns>
        public bool IsSetFileContents()
        {
            return this._fileContents != null;
        }

        /// <summary>
        /// Gets and sets the LabelFormat property.
        /// </summary>
        public string LabelFormat
        {
            get { return this._labelFormat; }
            set { this._labelFormat = value; }
        }

        /// <summary>
        /// Sets the LabelFormat property.
        /// </summary>
        /// <param name="labelFormat">LabelFormat property.</param>
        /// <returns>this instance.</returns>
        public Label WithLabelFormat(string labelFormat)
        {
            this._labelFormat = labelFormat;
            return this;
        }

        /// <summary>
        /// Checks if LabelFormat property is set.
        /// </summary>
        /// <returns>true if LabelFormat property is set.</returns>
        public bool IsSetLabelFormat()
        {
            return this._labelFormat != null;
        }

        /// <summary>
        /// Gets and sets the StandardIdForLabel property.
        /// </summary>
        public string StandardIdForLabel
        {
            get { return this._standardIdForLabel; }
            set { this._standardIdForLabel = value; }
        }

        /// <summary>
        /// Sets the StandardIdForLabel property.
        /// </summary>
        /// <param name="standardIdForLabel">StandardIdForLabel property.</param>
        /// <returns>this instance.</returns>
        public Label WithStandardIdForLabel(string standardIdForLabel)
        {
            this._standardIdForLabel = standardIdForLabel;
            return this;
        }

        /// <summary>
        /// Checks if StandardIdForLabel property is set.
        /// </summary>
        /// <returns>true if StandardIdForLabel property is set.</returns>
        public bool IsSetStandardIdForLabel()
        {
            return this._standardIdForLabel != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _customTextForLabel = reader.Read<string>("CustomTextForLabel");
            _dimensions = reader.Read<LabelDimensions>("Dimensions");
            _fileContents = reader.Read<FileContents>("FileContents");
            _labelFormat = reader.Read<string>("LabelFormat");
            _standardIdForLabel = reader.Read<string>("StandardIdForLabel");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("CustomTextForLabel", _customTextForLabel);
            writer.Write("Dimensions", _dimensions);
            writer.Write("FileContents", _fileContents);
            writer.Write("LabelFormat", _labelFormat);
            writer.Write("StandardIdForLabel", _standardIdForLabel);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "Label", this);
        }

    public Label (LabelDimensions dimensions,FileContents fileContents) : base() {
        this._dimensions = dimensions;
        this._fileContents = fileContents;
    }

        public Label() : base()
        {
        }
    }
}
