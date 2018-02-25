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
   *  Marketplace Web Service Sellers CSharp Library
   *  API Version: 2011-07-01
   *  Generated: Wed Jul 06 01:50:23 GMT 2011
   *
   */

using System.Xml.Serialization;

namespace Claytondus.AmazonMWS.Sellers.Model
  {
      [XmlType(Namespace = "https://mws.amazonservices.com/Sellers/2011-07-01")]
      [XmlRootAttribute(Namespace = "https://mws.amazonservices.com/Sellers/2011-07-01", IsNullable = false)]
      public enum HasSellerSuspendedListingsEnum
      {
          Yes,
          No
      }
  }
