/******************************************************************************* 
 * Copyright 2009-2012 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Marketplace Web Service Runtime Client Library
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Claytondus.AmazonMWS.Runtime
{
    /// <summary>
    /// Defines metadata for an operation.
    /// <para>This includes the service, version, operation name, response object class
    /// and call parameters.</para>
    /// </summary>
    public interface IMwsRequestType <Response> where Response: IMwsObject
    {
        /// <summary>
        /// Get the class that will be thrown for an exception response.
        /// </summary>
        /// <returns></returns>
        MwsException WrapException(Exception e);

        /// <summary>
        /// Get the operation name that identifies the operation within the service
        /// </summary>
        string OperationName { get; }

        /// <summary>
        /// Get the class that will hold a successful response
        /// </summary>
        Type ResponseClass { get; }
        
        /// <summary>
        /// Get the service path string that identifies the service and version
        /// to call on the server
        /// </summary>
        string ServicePath { get; }

        /// <summary>
        /// wrap response header metadata and set into response object
        /// </summary>
        /// <param name="response"></param>
        /// <param name="rhmd"></param>
        void SetResponseHeaderMetadata(IMwsObject response, MwsResponseHeaderMetadata rhmd);
    }
}
