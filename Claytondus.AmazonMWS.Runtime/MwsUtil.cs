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
using System.Text.RegularExpressions;
using System.IO;
using System.Security.Cryptography;
using System.Globalization; 

namespace Claytondus.AmazonMWS.Runtime
{
    public class MwsUtil
    {
        /** Match one back-slash. */
        static readonly Regex backSlashPtn = new Regex(@"\\");

        /** Match one equal character. */
        private static readonly Regex equalPtn = new Regex(@"=");

        /** Escaped back slash character. */
        private static readonly string escBackSlash = "\\\\";

        /** Escaped equal character. */
        private static readonly string escEqual = "\\=";

        /** Escaped forward slash character. */
        private static readonly string escForwardSlash = "\\/";

        /** Escaped left parenthesis character. */
        private static readonly string escLParen = "\\(";

        /** Escaped right parenthesis character. */
        private static readonly string escRParen = "\\)";

        /** Escaped semicolon character. */
        private static readonly string escSemicolon = "\\;";

        /** Match one forward-slash. */
        private static readonly Regex forwardSlashPtn = new Regex("/");

        /** Match one right parenthesis character. */
        private static readonly Regex lParenPtn = new Regex(@"\(");

        /** Match leading and/or trailing white spaces. */
        private static readonly Regex outerWhiteSpacesPtn = new Regex(@"\A(\s)+|(\s)+\z");

        /** Match one right parenthesis character. */
        private static readonly Regex rParenPtn = new Regex(@"\)");

        /** Match one semicolon character. */
        private static readonly Regex semicolonPtn = new Regex(";");

        /** Match one or more white spaces. */
        private static readonly Regex whiteSpacesPtn = new Regex("\\s+");

        /** Default character encoding. */
        static readonly Encoding defaultEncoding = Encoding.UTF8;

        /** Match a + character. */
        private static readonly Regex plusPtn = new Regex(@"\+");

	/** Match a ! character. */
	private static readonly Regex exlamationPoint = new Regex(@"\!");

        /** Match an asterisk character. */
        private static readonly Regex asteriskPtn = new Regex(@"\*");

        /** Match "%7E". */
        private static readonly Regex pct7EPtn = new Regex("%7[e|E]");

        /** Match "%7E". */
        private static readonly Regex pctSingleQuotePtn = new Regex("'");

        /** Match "%2F". */
        private static readonly Regex pct2FPtn = new Regex("%2[f|F]");

        /** A cached simple date format for generating time-stamps. */
        private static readonly string dateFormat = "yyyy-MM-dd'T'HH:mm:ss'Z'";

        /**
         * Calculate string to Sign for SignatureVersion 0
         * 
         * @param parameters
         *            request parameters
         * @return string to Sign
         */
        private static string CalculateStringToSignV0(IDictionary<string, string> parameters)
        {
            StringBuilder data = new StringBuilder();
            data.Append(parameters["Action"]).Append(parameters["Timestamp"]);
            return data.ToString();
        }

        /**
         * Calculate string to Sign for SignatureVersion 1
         * 
         * @param parameters
         *            request parameters
         * @return String to sign
         */
        private static string CalculateStringToSignV1(IDictionary<string, string> parameters)
        {
            StringBuilder data = new StringBuilder();
            IDictionary<string, string> sorted = new SortedDictionary<string, string>(parameters, StringComparer.OrdinalIgnoreCase);
            IEnumerator<KeyValuePair<string, string>> pairs = sorted.GetEnumerator();
            while (pairs.MoveNext())
            {
                KeyValuePair<string, string> pair = pairs.Current;
                data.Append(pair.Key);
                data.Append(pair.Value);
            }
            return data.ToString();
        }

        /**
         * Calculate String to Sign for SignatureVersion 2
         * 
         * @param serviceUri
         * 
         * @param parameters
         *            request parameters
         * @return String to Sign
         */
        private static string CalculateStringToSignV2(Uri serviceUri,
                IDictionary<string, string> parameters)
        {
            StringBuilder data = new StringBuilder();
            data.Append("POST");
            data.Append("\n");
            data.Append(serviceUri.Host.ToLower());
            if (!MwsUtil.HasStandardPort(serviceUri))
            {
                data.Append(":");
                data.Append(serviceUri.Port);
            }
            data.Append("\n");
            string uri = serviceUri.LocalPath;
            data.Append(UrlEncode(uri, true));
            data.Append("\n");
            //IDictionary<string, string> sorted = new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);
            IEnumerator<KeyValuePair<string, string>> pairs = parameters.GetEnumerator();
            bool isFirst = true;
            while (pairs.MoveNext())
            {
                if (isFirst)
                    isFirst = false;
                else
                    data.Append("&");
                KeyValuePair<string, string> pair = pairs.Current;
                string key = pair.Key;
                data.Append(MwsUtil.UrlEncode(key, false));
                data.Append("=");
                string value = pair.Value;
                data.Append(MwsUtil.UrlEncode(value, false));
            }
            return data.ToString();
        }

        /// <summary>
        /// Clean white space. Remove leading and trailing, and replace internal spaces
        /// with a single space character.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>The clean string</returns>
        public static string CleanWS(string s)
        {
            s = s.Trim();
            s = ReplaceAll(s, whiteSpacesPtn, " ");
            return s;
        }

        /**
         * Escape application name before using to form user agent string.
         * <p>
         * Clean up white space and then escape back slash and forward slash
         * characters.
         * 
         * @param s
         * 
         * @return The escaped app name.
         */
        public static string EscapeAppName(string s)
        {
            s = CleanWS(s);
            s = ReplaceAll(s, backSlashPtn, escBackSlash);
            s = ReplaceAll(s, forwardSlashPtn, escForwardSlash);
            return s;
        }

        /**
         * Escape an application version string.
         * 
         * @param s
         * 
         * @return The escaped app version.
         */
        public static string EscapeAppVersion(string s)
        {
            s = CleanWS(s);
            s = ReplaceAll(s, backSlashPtn, escBackSlash);
            s = ReplaceAll(s, lParenPtn, escLParen);
            return s;
        }

        /**
         * Standardize and escape an attribute name.
         * <p>
         * Clean white space. Escape back-slashes and equals-sign with a back-slash.
         * 
         * @param s
         *            The attribute name to standardize and escape.
         * 
         * @return The standardized and escaped attribute name.
         */
        public static string EscapeAttributeName(string s)
        {
            s = CleanWS(s);
            s = ReplaceAll(s, backSlashPtn, escBackSlash);
            s = ReplaceAll(s, equalPtn, escEqual);
            return s;
        }

        /**
         * Standardize and escape an attribute value.
         * <p>
         * Clean white space. Escape back-slashes, semi-colons, and right
         * parenthesis with a back-slash.
         * 
         * @param s
         *            The attribute value to standardize and escape.
         * 
         * @return The standardized and escaped attribute value.
         */
        public static string EscapeAttributeValue(string s)
        {
            s = CleanWS(s);
            s = ReplaceAll(s, backSlashPtn, escBackSlash);
            s = ReplaceAll(s, semicolonPtn, escSemicolon);
            s = ReplaceAll(s, rParenPtn, escRParen);
            return s;
        }

        /**
         * Extract the port number from an uri.
         * 
         * @param uri
         * 
         * @return The port number.
         */
        public static int ExtractPortNumber(Uri uri)
        {
            int portNumber = uri.Port;
            if (portNumber == -1)
            {
                portNumber = uri.Scheme.Equals("https") ? 443 : 80;
            }
            return portNumber;
        }

        /// <summary>
        /// Get a ISO 8601 formatted time stamp of now.
        /// </summary>
        /// <returns>The time stamp.</returns>
        public static string GetFormattedTimestamp()
        {
            return GetFormattedTimestamp(DateTime.UtcNow);
        }

        /// <summary>
        /// Format a DateTime as ISO-8601 formatted time-stamp.
        /// </summary>
        /// <returns>The time-stamp.</returns>
        public static string GetFormattedTimestamp(DateTime dateTime)
        {
            return dateTime.ToUniversalTime().ToString(dateFormat);
        }

        /// <summary>
        /// Parse an ISO 8601 formatted timestamp
        /// </summary>
        /// <param name="timestamp">ISO 8601 formatted timestamp string</param>
        /// <returns>the parsed date</returns>
        public static DateTime ParseTimestamp(string timestamp)
        {
            return DateTime.Parse(timestamp, CultureInfo.InvariantCulture);
        }

        /**
         * Replace a pattern in a string.
         * <p>
         * Do not do recursive replacement. Return the original string if no changes
         * are required.
         * 
         * @param s
         *            The string to search.
         * 
         * @param p
         *            The pattern to search for.
         * 
         * @param r
         *            The string to replace occurrences with.
         * 
         * @return The new string.
         */
        public static string ReplaceAll(string s, Regex p, string r)
        {
            int n = s == null ? 0 : s.Length;
            if (n == 0)
            {
                return s;
            }
            Match m = p.Match(s);
            if (!m.Success)
            {
                return s;
            }
            StringBuilder buf = new StringBuilder(n + 12);
            int k = 0;
            do
            {
                buf.Append(s, k, m.Index - k);
                buf.Append(r);
                k = m.Index + m.Length;
            } while ((m = m.NextMatch()).Success);
            if (k < n)
            {
                buf.Append(s, k, n - k);
            }
            return buf.ToString();
        }

        /**
         * Computes RFC 2104-compliant HMAC signature.
         * 
         * @param data
         *            The data to sign.
         * @param key
         *            The key to use for signing.
         * 
         * @param algorithm
         *            The signing algorithm.
         * 
         * @return The signature.
         */
        public static string Sign(string data, string key, string algorithm)
        {
            try
            {
                KeyedHashAlgorithm alg = null;
                switch (algorithm)
                {
                    case "HmacSHA1":
                        alg = new HMACSHA1();
                        break;
                    case "HmacSHA256":
                        alg = new HMACSHA256();
                        break;
                    case "HmacSHA512":
                        alg = new HMACSHA512();
                        break;
                    default:
                        throw new ArgumentException("Unrecognized HMAC function", algorithm);
                }
                alg.Key = defaultEncoding.GetBytes(key);
                return Convert.ToBase64String(alg.ComputeHash(defaultEncoding.GetBytes(data.ToCharArray())));

            }
            catch (Exception e)
            {
                throw new Exception("Signature computation failed.", e);
            }
        }

        /**
         * Computes RFC 2104-compliant HMAC signature for request parameters
         * Implements AWS Signature, as per following spec:
         * 
         * If Signature Version is 0, it signs concatenated Action and Timestamp
         * 
         * If Signature Version is 1, it performs the following:
         * 
         * Sorts all parameters (including SignatureVersion and excluding Signature,
         * the value of which is being created), ignoring case.
         * 
         * Iterate over the sorted list and append the parameter name (in original
         * case) and then its value. It will not URL-encode the parameter values
         * before constructing this string. There are no separators.
         * 
         * If Signature Version is 2, string to sign is based on following:
         * 
         * 1. The HTTP Request Method followed by an ASCII newline (%0A) 2. The HTTP
         * Host header in the form of lowercase host, followed by an ASCII newline.
         * 3. The URL encoded HTTP absolute path component of the URI (up to but not
         * including the query string parameters); if this is empty use a forward
         * '/'. This parameter is followed by an ASCII newline. 4. The concatenation
         * of all query string components (names and values) as UTF-8 characters
         * which are URL encoded as per RFC 3986 (hex characters MUST be uppercase),
         * sorted using lexicographic byte ordering. Parameter names are separated
         * from their values by the '=' character (ASCII character 61), even if the
         * value is empty. Pairs of parameter and values are separated by the '&'
         * character (ASCII code 38).
         * 
         * @param serviceUri
         *              Including host, port, api name, and api version
         * @param parameters
         * @param signatureVersion
         * @param signatureMethod
         * @param awsSecretKey
         * 
         * @return The base64 encoding of the signature.
         */
        public static string SignParameters(Uri serviceUri,
                string signatureVersion, string signatureMethod,
                IDictionary<string, string> parameters, string awsSecretKey)
        {
            parameters.Add("SignatureVersion", signatureVersion);
            string algorithm = "HmacSHA1";
            string stringToSign = null;

            if ("0".Equals(signatureVersion))
            {
                stringToSign = CalculateStringToSignV0(parameters);
            }
            else if ("1".Equals(signatureVersion))
            {
                stringToSign = CalculateStringToSignV1(parameters);
            }
            else if ("2".Equals(signatureVersion))
            {
                algorithm = signatureMethod;
                parameters.Add("SignatureMethod", algorithm);
                stringToSign = CalculateStringToSignV2(serviceUri, parameters);
            }
            else
            {
                throw new ArgumentException("Invalid Signature Version specified");
            }
            return Sign(stringToSign, awsSecretKey, algorithm);
        }

        /**
         * URL encode a value.
         * 
         * @param value
         * 
         * @param path
         *            true if is a path and '/' should not be encoded.
         * 
         * @return The encoded string.
         */
        public static string UrlEncode(string value, bool path)
        {
            try
            {
                // HttpUtility.UrlEncode returns lower case values though it does not escape tilda
                // Therefore using EscapeDataString since it encodes to Utf-8 and also returns escaped values in upper case, i.e., %3A vs %3a for :
                // ARS only supports uppercase and RFC 3986 says it should be upper case.
                // Highly unlikely but should the default encoding ever change, this will need change
                value = Uri.EscapeDataString(value);
            }
            catch (NotSupportedException e)
            {
                throw new Exception("Unsupported encoding", e);
            }
            value = ReplaceAll(value, asteriskPtn, "%2A");
            value = ReplaceAll(value, pct7EPtn, "~");
            value = ReplaceAll(value, pctSingleQuotePtn, "%27"); 
            value = ReplaceAll(value, exlamationPoint, "%21");
            value = ReplaceAll(value, lParenPtn, "%28");
            value = ReplaceAll(value, rParenPtn, "%29");
            if (path)
            {
                value = ReplaceAll(value, pct2FPtn, "/");
            }
            return value;
        }

        /**
         * Determine if a uri uses https.
         * 
         * @param uri
         * 
         * @return true if uses https.
         */
        public static bool HasHttps(Uri uri)
        {
            return uri.Scheme.Equals("https");
        }

        /**
         * Determine if a url uses the standard port.
         * <p>
         * Port 80 for http, 443 for https.
         * 
         * @param uri
         * 
         * @return true if standard port is used.
         */
        public static bool HasStandardPort(Uri uri)
        {
            int portNumber = uri.Port;
            if (portNumber == -1)
            {
                return true;
            }
            string schema = uri.Scheme;
            int standardPort = schema.Equals("https") ? 443 : 80;
            return portNumber == standardPort;
        }

        /// <summary>
        /// Creates a new instance of the given type
        /// </summary>
        /// <typeparam name="T">Type to cast to</typeparam>
        /// <param name="type">Type to instantiate</param>
        /// <returns>Instantiated new type</returns>
        public static T NewInstance<T>()
        {
            return (T) Activator.CreateInstance(typeof(T));
        }

        /// <summary>
        /// Wrap checked exceptions in system exception.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static Exception Wrap(Exception e)
        {
            if (e is Exception)
            {
                return (Exception)e;
            }
            return new Exception(e.Message, e);
        }

        /// <summary>
        /// Gets an enum instance from the enum class and name.
        /// 
        /// If enum has an Other entry it will be returned instead of null 
        /// when no match is found.
        /// </summary>
        /// <param name="enumType">Type of enum</param>
        /// <param name="name">Enum member to get</param>
        /// <returns>The enum value matching the name</returns>
        public static object GetEnumValue(Type enumType, String name)
        {
            try
            {
                return Enum.Parse(enumType, name, true);
            }
            catch (Exception)
            {
                try
                {
                    return Enum.Parse(enumType, "Other", true);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

    }
}
