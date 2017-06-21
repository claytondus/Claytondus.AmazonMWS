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
 * FBA Inbound Service MWS
 * API Version: 2010-10-01
 * Library Version: 2016-10-05
 * Generated: Wed Oct 05 06:15:39 PDT 2016
 */

using System;
using Claytondus.AmazonMWS.Runtime;
using Claytondus.AmazonMWS.FbaInbound.Model;

namespace Claytondus.AmazonMWS.FbaInbound
{

    /// <summary>
    /// FBAInboundServiceMWSClient is an implementation of FBAInboundServiceMWS
    /// </summary>
    public class FBAInboundServiceMWSClient : FBAInboundServiceMWS
    {

        private const string libraryVersion = "2016-10-05";

        private string servicePath;

        private MwsConnection connection;

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        /// <param name="config">configuration</param>
        public FBAInboundServiceMWSClient(
            string accessKey,
            string secretKey,
            string applicationName,
            string applicationVersion,
            FBAInboundServiceMWSConfig config)
        {
            connection = config.CopyConnection();
            connection.AwsAccessKeyId = accessKey;
            connection.AwsSecretKeyId = secretKey;
            connection.ApplicationName = applicationName;
            connection.ApplicationVersion = applicationVersion;
            connection.LibraryVersion = libraryVersion;
            servicePath = config.ServicePath;
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="config">configuration</param>
        public FBAInboundServiceMWSClient(String accessKey, String secretKey, FBAInboundServiceMWSConfig config)
        {
            connection = config.CopyConnection();
            connection.AwsAccessKeyId = accessKey;
            connection.AwsSecretKeyId = secretKey;
            connection.LibraryVersion = libraryVersion;
            servicePath = config.ServicePath;
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        public FBAInboundServiceMWSClient(String accessKey, String secretKey)
            : this(accessKey, secretKey, new FBAInboundServiceMWSConfig())
        {
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        public FBAInboundServiceMWSClient(
            String accessKey, 
            String secretKey,
            String applicationName,
            String applicationVersion ) 
            : this(accessKey, secretKey, applicationName,
                applicationVersion, new FBAInboundServiceMWSConfig())
        {
        }

        public ConfirmPreorderResponse ConfirmPreorder(ConfirmPreorderRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<ConfirmPreorderResponse>("ConfirmPreorder", typeof(ConfirmPreorderResponse), servicePath),
                request);
        }

        public ConfirmTransportRequestResponse ConfirmTransportRequest(ConfirmTransportInputRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<ConfirmTransportRequestResponse>("ConfirmTransportRequest", typeof(ConfirmTransportRequestResponse), servicePath),
                request);
        }

        public CreateInboundShipmentResponse CreateInboundShipment(CreateInboundShipmentRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<CreateInboundShipmentResponse>("CreateInboundShipment", typeof(CreateInboundShipmentResponse), servicePath),
                request);
        }

        public CreateInboundShipmentPlanResponse CreateInboundShipmentPlan(CreateInboundShipmentPlanRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<CreateInboundShipmentPlanResponse>("CreateInboundShipmentPlan", typeof(CreateInboundShipmentPlanResponse), servicePath),
                request);
        }

        public EstimateTransportRequestResponse EstimateTransportRequest(EstimateTransportInputRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<EstimateTransportRequestResponse>("EstimateTransportRequest", typeof(EstimateTransportRequestResponse), servicePath),
                request);
        }

        public GetBillOfLadingResponse GetBillOfLading(GetBillOfLadingRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<GetBillOfLadingResponse>("GetBillOfLading", typeof(GetBillOfLadingResponse), servicePath),
                request);
        }

        public GetInboundGuidanceForASINResponse GetInboundGuidanceForASIN(GetInboundGuidanceForASINRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<GetInboundGuidanceForASINResponse>("GetInboundGuidanceForASIN", typeof(GetInboundGuidanceForASINResponse), servicePath),
                request);
        }

        public GetInboundGuidanceForSKUResponse GetInboundGuidanceForSKU(GetInboundGuidanceForSKURequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<GetInboundGuidanceForSKUResponse>("GetInboundGuidanceForSKU", typeof(GetInboundGuidanceForSKUResponse), servicePath),
                request);
        }

        public GetPackageLabelsResponse GetPackageLabels(GetPackageLabelsRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<GetPackageLabelsResponse>("GetPackageLabels", typeof(GetPackageLabelsResponse), servicePath),
                request);
        }

        public GetPalletLabelsResponse GetPalletLabels(GetPalletLabelsRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<GetPalletLabelsResponse>("GetPalletLabels", typeof(GetPalletLabelsResponse), servicePath),
                request);
        }

        public GetPreorderInfoResponse GetPreorderInfo(GetPreorderInfoRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<GetPreorderInfoResponse>("GetPreorderInfo", typeof(GetPreorderInfoResponse), servicePath),
                request);
        }

        public GetPrepInstructionsForASINResponse GetPrepInstructionsForASIN(GetPrepInstructionsForASINRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<GetPrepInstructionsForASINResponse>("GetPrepInstructionsForASIN", typeof(GetPrepInstructionsForASINResponse), servicePath),
                request);
        }

        public GetPrepInstructionsForSKUResponse GetPrepInstructionsForSKU(GetPrepInstructionsForSKURequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<GetPrepInstructionsForSKUResponse>("GetPrepInstructionsForSKU", typeof(GetPrepInstructionsForSKUResponse), servicePath),
                request);
        }

        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<GetServiceStatusResponse>("GetServiceStatus", typeof(GetServiceStatusResponse), servicePath),
                request);
        }

        public GetTransportContentResponse GetTransportContent(GetTransportContentRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<GetTransportContentResponse>("GetTransportContent", typeof(GetTransportContentResponse), servicePath),
                request);
        }

        public GetUniquePackageLabelsResponse GetUniquePackageLabels(GetUniquePackageLabelsRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<GetUniquePackageLabelsResponse>("GetUniquePackageLabels", typeof(GetUniquePackageLabelsResponse), servicePath),
                request);
        }

        public ListInboundShipmentItemsResponse ListInboundShipmentItems(ListInboundShipmentItemsRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<ListInboundShipmentItemsResponse>("ListInboundShipmentItems", typeof(ListInboundShipmentItemsResponse), servicePath),
                request);
        }

        public ListInboundShipmentItemsByNextTokenResponse ListInboundShipmentItemsByNextToken(ListInboundShipmentItemsByNextTokenRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<ListInboundShipmentItemsByNextTokenResponse>("ListInboundShipmentItemsByNextToken", typeof(ListInboundShipmentItemsByNextTokenResponse), servicePath),
                request);
        }

        public ListInboundShipmentsResponse ListInboundShipments(ListInboundShipmentsRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<ListInboundShipmentsResponse>("ListInboundShipments", typeof(ListInboundShipmentsResponse), servicePath),
                request);
        }

        public ListInboundShipmentsByNextTokenResponse ListInboundShipmentsByNextToken(ListInboundShipmentsByNextTokenRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<ListInboundShipmentsByNextTokenResponse>("ListInboundShipmentsByNextToken", typeof(ListInboundShipmentsByNextTokenResponse), servicePath),
                request);
        }

        public PutTransportContentResponse PutTransportContent(PutTransportContentRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<PutTransportContentResponse>("PutTransportContent", typeof(PutTransportContentResponse), servicePath),
                request);
        }

        public UpdateInboundShipmentResponse UpdateInboundShipment(UpdateInboundShipmentRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<UpdateInboundShipmentResponse>("UpdateInboundShipment", typeof(UpdateInboundShipmentResponse), servicePath),
                request);
        }

        public VoidTransportRequestResponse VoidTransportRequest(VoidTransportInputRequest request)
        {
            return connection.Call(
                new FBAInboundServiceMWSClient.Request<VoidTransportRequestResponse>("VoidTransportRequest", typeof(VoidTransportRequestResponse), servicePath),
                request);
        }

        private class Request<R> : IMwsRequestType<R> where R : IMwsObject
        {
            private string operationName;
            private Type responseClass;
            private string servicePath;

            public Request(string operationName, Type responseClass, string servicePath) {
                this.operationName = operationName;
                this.responseClass = responseClass;
                this.servicePath = servicePath;
            }

            public string ServicePath
            {
                get { return servicePath; }
            }

            public string OperationName
            {
                get { return operationName; }
            }

            public Type ResponseClass
            {
                get { return responseClass; }
            }

            public MwsException WrapException(Exception cause) {
                return new FBAInboundServiceMWSException(cause);
            }

            public void SetResponseHeaderMetadata(IMwsObject response, MwsResponseHeaderMetadata rhmd) {
                ((IMWSResponse)response).ResponseHeaderMetadata = new ResponseHeaderMetadata(rhmd);
            }

        }
    }
}
