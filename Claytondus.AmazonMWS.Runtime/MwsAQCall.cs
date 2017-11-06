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
using System.Net;
using System.IO;
using System.Xml.Serialization;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Nito.AsyncEx;

namespace Claytondus.AmazonMWS.Runtime
{
    /// <summary>
    /// AWS query call implementation
    /// </summary>
    public class MwsAQCall : IMwsCall
    {

        private readonly MwsConnection connection;
        private readonly IDictionary<string, string> parameters = new SortedDictionary<string, string>(StringComparer.Ordinal);
        private MwsConnection.ServiceEndpoint serviceEndPoint;

        public HttpWebRequest request;

        private string operationName;
        private MwsResponseHeaderMetadata ResponseHeaderMetadata;

        public MwsAQCall(MwsConnection connection, MwsConnection.ServiceEndpoint serviceEndpoint, string operationName)
        {
            this.connection = connection;
            this.serviceEndPoint = serviceEndpoint;
            this.operationName = operationName;
        }

        /// <summary>
        /// Creates a request and invokes it 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="MwsException">Exceptions from invoking the request</exception>
        public IMwsReader invoke()
        {
            string responseBody;
            string message;
            HttpStatusCode statusCode = default(HttpStatusCode);
            /* Add required request parameters */
            AddRequiredParameters();
            string queryString = GetParametersAsString(parameters);
            int retries = 0;
            do
            {
                /* Submit the request and read response body */
                try
                {
                    request = connection.GetHttpClient(serviceEndPoint.URI);
                    byte[] requestData = new UTF8Encoding().GetBytes(queryString);
                    //request.ContentLength = requestData.Length;
                    using (Stream requestStream = request.GetRequestStreamAsync().Result)
                    {
                        requestStream.Write(requestData, 0, requestData.Length);
                    }
                    using (HttpWebResponse httpResponse = AsyncContext.Run(request.GetResponseAsync) as HttpWebResponse)
                    {
                        statusCode = httpResponse.StatusCode;
                        message = httpResponse.StatusDescription;
                        ResponseHeaderMetadata = GetResponseHeaderMetadata(httpResponse);
                        StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8);
                        responseBody = reader.ReadToEnd();
                    }
                    if (statusCode == HttpStatusCode.OK)
                    {
                        return new MwsXmlReader(responseBody);
                    }
                    MwsException e = new MwsException((int)statusCode, message, null, null, responseBody, ResponseHeaderMetadata);

                    if (statusCode == HttpStatusCode.InternalServerError)
                    {
                        if (PauseIfRetryNeeded(retries++))
                            continue;
                    }
                    throw e;
                }
                /* Web exception is thrown on unsuccessful responses */
                catch (WebException we)
                {
                    using (HttpWebResponse httpErrorResponse = (HttpWebResponse)we.Response as HttpWebResponse)
                    {
                        if (httpErrorResponse == null)
                        {
                            throw new MwsException(we);
                        }
                        statusCode = httpErrorResponse.StatusCode;
                        using (StreamReader reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            responseBody = reader.ReadToEnd();
                        }
                    }
                    //retry logic
                    if (PauseIfRetryNeeded(retries++))
                        continue;
                    throw new MwsException((int)statusCode, null, null, null, responseBody, null);
                }

                /* Catch other exceptions, attempt to convert to formatted exception,
                 * else rethrow wrapped exception */
                catch (Exception e)
                {
                    throw new MwsException(e);
                }
            } while (true);

        }

        /// <summary>
        /// Extracts and assigns the response header metadata
        /// </summary>
        /// <param name="httpResponse"></param>
        /// <returns></returns>
        private static MwsResponseHeaderMetadata GetResponseHeaderMetadata(HttpWebResponse httpResponse)
        {
            string requestId = httpResponse.Headers["x-mws-request-id"];
            string timestamp = httpResponse.Headers["x-mws-timestamp"];
            string contextStr = httpResponse.Headers["x-mws-response-context"];
            List<string> context = new List<string>(contextStr.Split(','));

            double? quotaMax;
            try
            {
                string quotaMaxStr = httpResponse.Headers["x-mws-quota-max"];
                quotaMax = Double.Parse(quotaMaxStr);
            }
            catch (Exception)
            {
                quotaMax = null;
            }

            double? quotaRemaining;
            try
            {
                string quotaRemainingStr = httpResponse.Headers["x-mws-quota-remaining"];
                quotaRemaining = Double.Parse(quotaRemainingStr);
            }
            catch (Exception)
            {
                quotaRemaining = null;
            }

            DateTime? quotaResetsAt;
            try
            {
                string quotaResetsAtStr = httpResponse.Headers["x-mws-quota-resetsOn"];
                quotaResetsAt = MwsUtil.ParseTimestamp(quotaResetsAtStr);
            }
            catch (Exception)
            {
                quotaResetsAt = null;
            }

            return new MwsResponseHeaderMetadata(requestId, context, timestamp, quotaMax, quotaRemaining, quotaResetsAt);
        }

        /// <summary>
        /// Pauses for a while before retry. 
        /// <para>The amount of pause depends on the index of retry, the higher number of retry the longer the pause</para>
        /// </summary>
        /// <param name="retries"></param>
        /// <returns></returns>
        private bool PauseIfRetryNeeded(int retries)
        {
            if (retries == connection.MaxErrorRetry)
            {
                return false;
            }
            int delay = (int)(Math.Pow(4, retries) * 125);
            try
            {
                Thread.Sleep(delay);
            }
            catch (Exception e)
            {
                throw new Exception("Error checking if retry is needed", e);
            }
            return true;
        }

        /// <summary>
        /// Constructs the parameters as string 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private string GetParametersAsString(IDictionary<string, string> parameters)
        {
            StringBuilder data = new StringBuilder();
            foreach (string key in (IEnumerable<string>)parameters.Keys)
            {
                string value = parameters[key];
                if (value != null)
                {
                    data.Append(key);
                    data.Append('=');
                    data.Append(MwsUtil.UrlEncode(value, false));
                    data.Append('&');
                }
            }
            string result = data.ToString();
            return result.Remove(result.Length - 1);
        }

        /// <summary>
        /// Add authentication related and version parameters
        /// </summary>
        /// <param name="parameters"></param>         
        private void AddRequiredParameters()
        {
            parameters.Add("AWSAccessKeyId", connection.AwsAccessKeyId);
            parameters.Add("Action", operationName);
            parameters.Add("Timestamp", MwsUtil.GetFormattedTimestamp());
            parameters.Add("Version", serviceEndPoint.version);
            string signature = MwsUtil.SignParameters(serviceEndPoint.URI, connection.SignatureVersion, connection.SignatureMethod, parameters, connection.AwsSecretKeyId);
            parameters.Add("Signature", signature);
        }

        private void putValue(object value) 
        {
            if (value==null)
            {
                return;
            }
            if (value is IMwsObject)
            {
                parameterPrefix.Append('.');
                (value as IMwsObject).WriteFragmentTo(this);
                return;
            }
            string name = parameterPrefix.ToString();
            if (value is DateTime)
            {
                parameters.Add(name, MwsUtil.GetFormattedTimestamp((DateTime)value));
                return;
            }
            string valueStr = value.ToString();
            if (valueStr==null || valueStr.Length==0) 
            {
                return;
            }
            if (value is bool)
            {
                 valueStr = valueStr.ToLower();
            }
            parameters.Add(name, valueStr);
        }

        public MwsResponseHeaderMetadata GetResponseMetadataHeader()
        {
            return ResponseHeaderMetadata;
        }

        /** The parameter prefix */
        private StringBuilder parameterPrefix = new StringBuilder();

        public void Write(string name,object value)
        {
            int holdParameterPrefixLen = parameterPrefix.Length;
            parameterPrefix.Append(name);
            putValue(value);
            parameterPrefix.Length = holdParameterPrefixLen;
        }

        public void Write(string xmlNamespace, string name, IMwsObject value)
        {
            if (value != null)
            {
                value.WriteFragmentTo(this);
            }
        }

        public void WriteAttribute(string name, object value)
        {
            Write(name, value);
        }

        public void WriteList<T>(string name, string memberName, ICollection<T> list)
        {
            if (list == null)
            {
                return;
            }
            if (name==null && memberName==null) 
            {
               throw new ArgumentNullException("Both name and memberName cannot be null.");
            }
            int holdParameterPrefixLen = parameterPrefix.Length;
            if (name!=null) 
            {
                parameterPrefix.Append(name);
            }
            if (name!=null && memberName!=null) 
            {
                parameterPrefix.Append('.');
            }
            if (memberName!=null) 
            {
                parameterPrefix.Append(memberName);
            }
            parameterPrefix.Append('.');
            int dotLen = parameterPrefix.Length;
            int i = 1;
            foreach (Object v in list)
            {
                parameterPrefix.Length = dotLen;
                parameterPrefix.Append(i);
                putValue(v);
                i++;
            }
            parameterPrefix.Length = holdParameterPrefixLen;
        }

        public void WriteList<T>(string name, ICollection<T> list)
        {
            WriteList<T>(null, name, list);
        }

        public void WriteAny(ICollection<XmlElement> elements)
        {
            throw new NotSupportedException("WriteAny not supported");
        }

        public void WriteValue(object value)
        {
            throw new NotSupportedException("WriteValue not supported");
        }

        public void BeginObject(string name)
        {
            throw new NotSupportedException("Complex object writing not supported");
        }

        public void close()
        {
            //nothing to do
        }

        public void EndObject(string name)
        {
            throw new NotSupportedException("Complex object writing not supported");
        }

    }
}
