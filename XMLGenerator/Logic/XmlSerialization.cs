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
            //XmlWriterSettings settings = new XmlWriterSettings { Indent = true };
            //DataContractSerializer serializer = new DataContractSerializer(typeof(List<Order>));
            //using (XmlWriter writer = XmlWriter.Create(fileName, settings))
            //    serializer.WriteObject(writer, objectToSerialize);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            TextWriter writer = new StreamWriter(fileName);
            serializer.Serialize(writer, objectToSerialize);
            writer.Close();
        }
    }
}
