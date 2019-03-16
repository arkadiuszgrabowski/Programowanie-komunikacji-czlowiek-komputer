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
        public static void Serialize(Company objectToSerialize, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Company));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces(
                         new[] { XmlQualifiedName.Empty });
            TextWriter writer = new StreamWriter(fileName);
            serializer.Serialize(writer, objectToSerialize, ns);
            writer.Close();
        }
    }
}
