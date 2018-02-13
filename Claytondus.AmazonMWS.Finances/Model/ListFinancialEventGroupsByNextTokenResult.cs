/*******************************************************************************
 * Copyright 2009-2018 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * List Financial Event Groups By Next Token Result
 * API Version: 2015-05-01
 * Library Version: 2018-02-07
 * Generated: Fri Jan 19 15:01:20 PST 2018
 */


using System.Collections.Generic;
using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Finances.Model
{
    public class ListFinancialEventGroupsByNextTokenResult : AbstractMwsObject
    {

        private string _nextToken;
        private List<FinancialEventGroup> _financialEventGroupList;

        /// <summary>
        /// Gets and sets the NextToken property.
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        /// <summary>
        /// Sets the NextToken property.
        /// </summary>
        /// <param name="nextToken">NextToken property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventGroupsByNextTokenResult WithNextToken(string nextToken)
        {
            this._nextToken = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if NextToken property is set.
        /// </summary>
        /// <returns>true if NextToken property is set.</returns>
        public bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the FinancialEventGroupList property.
        /// </summary>
        public List<FinancialEventGroup> FinancialEventGroupList
        {
            get
            {
                if(this._financialEventGroupList == null)
                {
                    this._financialEventGroupList = new List<FinancialEventGroup>();
                }
                return this._financialEventGroupList;
            }
            set { this._financialEventGroupList = value; }
        }

        /// <summary>
        /// Sets the FinancialEventGroupList property.
        /// </summary>
        /// <param name="financialEventGroupList">FinancialEventGroupList property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventGroupsByNextTokenResult WithFinancialEventGroupList(FinancialEventGroup[] financialEventGroupList)
        {
            this._financialEventGroupList.AddRange(financialEventGroupList);
            return this;
        }

        /// <summary>
        /// Checks if FinancialEventGroupList property is set.
        /// </summary>
        /// <returns>true if FinancialEventGroupList property is set.</returns>
        public bool IsSetFinancialEventGroupList()
        {
            return this.FinancialEventGroupList.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _nextToken = reader.Read<string>("NextToken");
            _financialEventGroupList = reader.ReadList<FinancialEventGroup>("FinancialEventGroupList", "FinancialEventGroup");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("NextToken", _nextToken);
            writer.WriteList("FinancialEventGroupList", "FinancialEventGroup", _financialEventGroupList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "ListFinancialEventGroupsByNextTokenResult", this);
        }


        public ListFinancialEventGroupsByNextTokenResult() : base()
        {
        }
    }
}
