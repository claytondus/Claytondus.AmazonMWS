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
 * File Contents
 * API Version: 2015-06-01
 * Library Version: 2016-03-30
 * Generated: Fri Nov 11 06:01:15 PST 2016
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.MerchantFulfillment.Model
{
    public class FileContents : AbstractMwsObject
    {

        private string _contents;
        private string _fileType;
        private string _checksum;

        /// <summary>
        /// Gets and sets the Contents property.
        /// </summary>
        public string Contents
        {
            get { return this._contents; }
            set { this._contents = value; }
        }

        /// <summary>
        /// Sets the Contents property.
        /// </summary>
        /// <param name="contents">Contents property.</param>
        /// <returns>this instance.</returns>
        public FileContents WithContents(string contents)
        {
            this._contents = contents;
            return this;
        }

        /// <summary>
        /// Checks if Contents property is set.
        /// </summary>
        /// <returns>true if Contents property is set.</returns>
        public bool IsSetContents()
        {
            return this._contents != null;
        }

        /// <summary>
        /// Gets and sets the FileType property.
        /// </summary>
        public string FileType
        {
            get { return this._fileType; }
            set { this._fileType = value; }
        }

        /// <summary>
        /// Sets the FileType property.
        /// </summary>
        /// <param name="fileType">FileType property.</param>
        /// <returns>this instance.</returns>
        public FileContents WithFileType(string fileType)
        {
            this._fileType = fileType;
            return this;
        }

        /// <summary>
        /// Checks if FileType property is set.
        /// </summary>
        /// <returns>true if FileType property is set.</returns>
        public bool IsSetFileType()
        {
            return this._fileType != null;
        }

        /// <summary>
        /// Gets and sets the Checksum property.
        /// </summary>
        public string Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        /// <summary>
        /// Sets the Checksum property.
        /// </summary>
        /// <param name="checksum">Checksum property.</param>
        /// <returns>this instance.</returns>
        public FileContents WithChecksum(string checksum)
        {
            this._checksum = checksum;
            return this;
        }

        /// <summary>
        /// Checks if Checksum property is set.
        /// </summary>
        /// <returns>true if Checksum property is set.</returns>
        public bool IsSetChecksum()
        {
            return this._checksum != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _contents = reader.Read<string>("Contents");
            _fileType = reader.Read<string>("FileType");
            _checksum = reader.Read<string>("Checksum");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Contents", _contents);
            writer.Write("FileType", _fileType);
            writer.Write("Checksum", _checksum);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/MerchantFulfillment/2015-06-01", "FileContents", this);
        }

    public FileContents (string contents,string fileType,string checksum) : base() {
        this._contents = contents;
        this._fileType = fileType;
        this._checksum = checksum;
    }

        public FileContents() : base()
        {
        }
    }
}
