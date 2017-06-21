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
using System.IO;
using System.Reflection;
using Claytondus.AmazonMWS.Runtime;
using Claytondus.AmazonMWS.FbaInbound.Model;

namespace Claytondus.AmazonMWS.FbaInbound.Mock
{

    /// <summary>
    /// Claytondus.AmazonMWS.FbaInboundMock is the implementation of Claytondus.AmazonMWS.FbaInbound based
    /// on the pre-populated set of XML files that serve local data. It simulates
    /// responses from MWS.
    /// </summary>
    /// <remarks>
    /// Use this to test your application without making a call to MWS
    ///
    /// Note, current Mock Service implementation does not validate requests
    /// </remarks>
    public class Claytondus.AmazonMWS.FbaInboundMock : Claytondus.AmazonMWS.FbaInbound
    {

        public ConfirmPreorderResponse ConfirmPreorder(ConfirmPreorderRequest request)
        {
            return newResponse<ConfirmPreorderResponse>();
        }

        public ConfirmTransportRequestResponse ConfirmTransportRequest(ConfirmTransportInputRequest request)
        {
            return newResponse<ConfirmTransportRequestResponse>();
        }

        public CreateInboundShipmentResponse CreateInboundShipment(CreateInboundShipmentRequest request)
        {
            return newResponse<CreateInboundShipmentResponse>();
        }

        public CreateInboundShipmentPlanResponse CreateInboundShipmentPlan(CreateInboundShipmentPlanRequest request)
        {
            return newResponse<CreateInboundShipmentPlanResponse>();
        }

        public EstimateTransportRequestResponse EstimateTransportRequest(EstimateTransportInputRequest request)
        {
            return newResponse<EstimateTransportRequestResponse>();
        }

        public GetBillOfLadingResponse GetBillOfLading(GetBillOfLadingRequest request)
        {
            return newResponse<GetBillOfLadingResponse>();
        }

        public GetInboundGuidanceForASINResponse GetInboundGuidanceForASIN(GetInboundGuidanceForASINRequest request)
        {
            return newResponse<GetInboundGuidanceForASINResponse>();
        }

        public GetInboundGuidanceForSKUResponse GetInboundGuidanceForSKU(GetInboundGuidanceForSKURequest request)
        {
            return newResponse<GetInboundGuidanceForSKUResponse>();
        }

        public GetPackageLabelsResponse GetPackageLabels(GetPackageLabelsRequest request)
        {
            return newResponse<GetPackageLabelsResponse>();
        }

        public GetPalletLabelsResponse GetPalletLabels(GetPalletLabelsRequest request)
        {
            return newResponse<GetPalletLabelsResponse>();
        }

        public GetPreorderInfoResponse GetPreorderInfo(GetPreorderInfoRequest request)
        {
            return newResponse<GetPreorderInfoResponse>();
        }

        public GetPrepInstructionsForASINResponse GetPrepInstructionsForASIN(GetPrepInstructionsForASINRequest request)
        {
            return newResponse<GetPrepInstructionsForASINResponse>();
        }

        public GetPrepInstructionsForSKUResponse GetPrepInstructionsForSKU(GetPrepInstructionsForSKURequest request)
        {
            return newResponse<GetPrepInstructionsForSKUResponse>();
        }

        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return newResponse<GetServiceStatusResponse>();
        }

        public GetTransportContentResponse GetTransportContent(GetTransportContentRequest request)
        {
            return newResponse<GetTransportContentResponse>();
        }

        public GetUniquePackageLabelsResponse GetUniquePackageLabels(GetUniquePackageLabelsRequest request)
        {
            return newResponse<GetUniquePackageLabelsResponse>();
        }

        public ListInboundShipmentItemsResponse ListInboundShipmentItems(ListInboundShipmentItemsRequest request)
        {
            return newResponse<ListInboundShipmentItemsResponse>();
        }

        public ListInboundShipmentItemsByNextTokenResponse ListInboundShipmentItemsByNextToken(ListInboundShipmentItemsByNextTokenRequest request)
        {
            return newResponse<ListInboundShipmentItemsByNextTokenResponse>();
        }

        public ListInboundShipmentsResponse ListInboundShipments(ListInboundShipmentsRequest request)
        {
            return newResponse<ListInboundShipmentsResponse>();
        }

        public ListInboundShipmentsByNextTokenResponse ListInboundShipmentsByNextToken(ListInboundShipmentsByNextTokenRequest request)
        {
            return newResponse<ListInboundShipmentsByNextTokenResponse>();
        }

        public PutTransportContentResponse PutTransportContent(PutTransportContentRequest request)
        {
            return newResponse<PutTransportContentResponse>();
        }

        public UpdateInboundShipmentResponse UpdateInboundShipment(UpdateInboundShipmentRequest request)
        {
            return newResponse<UpdateInboundShipmentResponse>();
        }

        public VoidTransportRequestResponse VoidTransportRequest(VoidTransportInputRequest request)
        {
            return newResponse<VoidTransportRequestResponse>();
        }

        private T newResponse<T>() where T : IMWSResponse {
            Stream xmlIn = null;
            try {
                xmlIn = Assembly.GetAssembly(this.GetType()).GetManifestResourceStream(typeof(T).FullName + ".xml");
                StreamReader xmlInReader = new StreamReader(xmlIn);
                string xmlStr = xmlInReader.ReadToEnd();

                MwsXmlReader reader = new MwsXmlReader(xmlStr);
                T obj = (T) Activator.CreateInstance(typeof(T));
                obj.ReadFragmentFrom(reader);
                obj.ResponseHeaderMetadata = new ResponseHeaderMetadata("mockRequestId", "A,B,C", "mockTimestamp", 0d, 0d, new DateTime());
                return obj;
            }
            catch (Exception e)
            {
                throw MwsUtil.Wrap(e);
            }
            finally
            {
                if (xmlIn != null) { xmlIn.Close(); }
            }
        }
    }
}
