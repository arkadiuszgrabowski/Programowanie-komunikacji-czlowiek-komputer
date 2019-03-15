using Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace Logic
{
    public static class XmlSerialization
    {
        public static void Serialize(List<Order> objectToSerialize, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces(
                         new[] { XmlQualifiedName.Empty });
            TextWriter writer = new StreamWriter(fileName);
            serializer.Serialize(writer, objectToSerialize, ns);
            writer.Close();
        }

        public static void AppendProducts(List<Product> products)
        {
            string fileName = "zadanie1.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true
            };
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces(
                         new[] { XmlQualifiedName.Empty });
            using (StreamWriter stream = File.AppendText(fileName))
            using (XmlWriter writer = XmlWriter.Create(stream, settings))
            {
                stream.Write("\n");
                serializer.Serialize(writer, products, ns);
            }
        }
    }
}
