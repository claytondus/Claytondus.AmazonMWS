using System.IO;
using System.Text;
using System.Xml;
using System;

namespace Claytondus.AmazonMWS.Products.Model
{
    public class ProductsUtil
    {
        /// <summary>
        /// Formats the provided XML so it's indented and humanly-readable.
        /// </summary>
        /// <param name="inputXml">The input XML to format.</param>
        /// <returns></returns>
        public static string FormatXml(XmlElement element)
        {
            XmlDocument document = new XmlDocument();
            var node = document.ImportNode(element, true);
            document.InsertAfter(node, null);

            StringBuilder builder = new StringBuilder();
            var xmlSettings = new XmlWriterSettings
                {
                    Indent = true,
                    IndentChars = @"    ",
                    NewLineChars = Environment.NewLine,
                    NewLineHandling = NewLineHandling.Replace,
                    OmitXmlDeclaration = true,
                    Encoding = Encoding.UTF8,
                };

            using (var writer = XmlWriter.Create(builder, xmlSettings))
            {
                document.Save(writer);
            }

            return builder.ToString();
        }
    }
}
