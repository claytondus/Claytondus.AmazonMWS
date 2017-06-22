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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;

namespace Claytondus.AmazonMWS.Runtime
{

    public class MwsXmlReader : IMwsReader
    {

        private XmlDocument doc;
        private XmlNode currentElement;
        private XmlNode currentChild;

        readonly static TypeCode[] numericTypes = { TypeCode.Double, TypeCode.Int16, TypeCode.Int32, TypeCode.Int64 };

        /// <summary>
        /// Load the xml file and initialize <code>current</code> and <code>currentChild</code>
        /// </summary>
        /// <param name="xmlValue">xml content as string</param>
        public MwsXmlReader(string xmlValue)
        {
            doc = new XmlDocument();
            doc.LoadXml(xmlValue);
            //initialize current node to root
            currentElement = doc.DocumentElement;
            currentChild = currentElement.FirstChild;
        }

        // methods
        public T Read<T>(string name)
        {
            T value = default(T);
            XmlNode startChild = currentChild;
            if (currentElement.ChildNodes.Count == 0)
            {
                return value;
            }
            do
            {

                if (currentChild.Name.Equals(name))
                {
                    if (currentChild is XmlAttribute)
                    {
                        value = ConvertValue<T>(currentChild.Value);
                    }
                    else
                    {
                        value = ReadObject<T>(currentChild);
                    }
                    currentChild = currentChild.NextSibling;
                    if (currentChild == null)
                        currentChild = currentElement.FirstChild;
                    if (currentChild == startChild)
                        currentChild = startChild.NextSibling != null ? startChild.NextSibling : currentElement.FirstChild;
                    return value;
                }
                currentChild = currentChild.NextSibling;
                if (currentChild == null)
                    currentChild = currentElement.FirstChild;
            } while (currentChild != startChild);
            currentChild = startChild.NextSibling != null ? startChild.NextSibling : currentElement.FirstChild;
            return value;
        }

        public List<T> ReadList<T>(string name)
        {
            List<T> list = new List<T>();
            XmlNode startChild = currentChild;
            if (currentElement.ChildNodes.Count == 0)
            {
                return null;
            }
            do
            {
                if (currentChild.Name.Equals(name) && currentChild is XmlElement)
                {
                    list.Add(ReadObject<T>(currentChild));
                }
                currentChild = currentChild.NextSibling;
                if (currentChild == null)
                    currentChild = currentElement.FirstChild;
            } while (currentChild != startChild);
            currentChild = startChild.NextSibling != null ? startChild.NextSibling : currentElement.FirstChild;
            return list;
        }

        public List<T> ReadList<T>(string name, string memberName)
        {
            List<T> list = new List<T>();
            XmlNode startChild = currentChild;
            if (currentElement.ChildNodes.Count == 0)
            {
                return null;
            }
            do
            {
                if (currentChild.Name.Equals(name) && currentChild is XmlElement)
                {
                    BeginObject(currentChild);
                    List<T> innerList = ReadList<T>(memberName);
                    if (innerList!=null) {
                        list.AddRange(innerList);
                    }
                    EndObject();
                }
                currentChild = currentChild.NextSibling;
                if (currentChild == null)
                    currentChild = currentElement.FirstChild;
            } while (currentChild != startChild);
            currentChild = startChild.NextSibling != null ? startChild.NextSibling : currentElement.FirstChild;
            return list;
        }

        public List<XmlElement> ReadAny()
        {
            List<XmlElement> elements = new List<XmlElement>();
            foreach (XmlNode node in currentElement.ChildNodes)
            {
                if (node.NodeType == XmlNodeType.Element)
                {
                    elements.Add((XmlElement)node);
                }
            }
            return elements;
        }

        public T ReadAttribute<T>(string name)
        {
            XmlAttribute node = currentElement.Attributes[name];
            if (node != null && node.Value != null)
            {
                return ConvertValue<T>(node.Value);
            }
            else
            {
                Type type = typeof(T);
                if(Nullable.GetUnderlyingType(type) != null)
                {
                    return default(T);
                }
                else
                {
                    throw new Exception("Non-null Attribute \'" + name + "\' does not exist.");;
                }
            }
        }

        public T ReadValue<T>()
        {
            if (currentChild == null || currentChild.NodeType != XmlNodeType.Text)
            {
                throw new Exception("Cannot read current value");
            }
            else
            {
                return ConvertValue<T>(currentChild.Value);
            }
        }

        private void BeginObject(XmlNode node)
        {
            if (node == null)
                throw new Exception("Cannot read null node");
            //move to child node for complex object reading
            currentElement = node;
            currentChild = node.FirstChild;
           
        }

        private void EndObject()
        {
            //move the child pointer back to the parent node (BeginObject should have been called)
            currentChild = currentElement;
            currentElement = currentElement.ParentNode;
        }

       private T ConvertValue<T>(string str)
        {
            Type type = typeof(T);

            if (type == typeof(string))
            {
                return (T)(object)str;
            }
            else if (type == typeof(decimal)) 
            {
                return (T)(object)convertToDecimal(str);
            }
            else if(typeof(Enum).IsAssignableFrom(type))
            {
                return (T)MwsUtil.GetEnumValue(type, str);
            }
            else if (typeof(IConvertible).IsAssignableFrom(type))
            {
                return (T)Convert.ChangeType(str, type, CultureInfo.InvariantCulture);
            } 
            else if(Nullable.GetUnderlyingType(type) != null)
            {
                return convertNullableType<T>(str);
            }
            else
            {
                throw new InvalidDataException("Unsupported type for conversion from string: " + type.FullName);
            }
        }
        
       private decimal convertToDecimal(string str) {
             return Decimal.Parse(str,
                    System.Globalization.NumberStyles.Float, 
                    CultureInfo.InvariantCulture);
        }

        private T convertNullableType<T>(string str) 
        {
            // Nullable types don't pass through Convert correctly
            if(String.IsNullOrEmpty(str))
            {
                return default(T);
            }
            else 
            {
                Type type = typeof(T);

                // First, get the type that is nullable
                Type valueType = Nullable.GetUnderlyingType(type);
                // Recurse using the actual value type: ConvertValue<valueType> (must use reflection since we are generic)
                MethodInfo recursiveMethod = this.GetType().GetMethod("ConvertValue", BindingFlags.NonPublic | BindingFlags.Instance);
                var value = recursiveMethod.MakeGenericMethod(valueType).Invoke(this, new object[] { str });
                // Return a new Nullable<valueType> (which is T) using the value we converted
                return (T) Activator.CreateInstance(type, new object[] { value });
            }
        }
        
        /// <summary>
        /// Read element value
        /// </summary>
        /// <param name="t">Expected type of the element</param>
        /// <param name="node">XmlNode to be read from</param>
        /// <returns>Value of element</returns>
        private T ReadObject<T>(XmlNode node)
        {
            Type type = typeof(T);

            if (typeof(IMwsObject).IsAssignableFrom(type))
            {
                T mwsObject = MwsUtil.NewInstance<T>();
                BeginObject(node);
                (mwsObject as IMwsObject).ReadFragmentFrom(this);
                EndObject();
                return mwsObject;
            }
            else if (type == typeof(object))
            {
                return (T) (object) node;
            }
            else
            {
                return ConvertValue<T>(node.InnerText);
            }
        }
              

        private bool IsNumberType(Type type)
        {
            return numericTypes.Contains(Type.GetTypeCode(type));
        }        
    }
}
