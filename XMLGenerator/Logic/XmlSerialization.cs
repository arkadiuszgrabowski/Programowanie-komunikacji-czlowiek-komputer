using Data;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Logic
{
    public static class XmlSerialization
    {
        public static void Serialize(Company objectToSerialize, string fileName)
        { 
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            XmlSerializer serializer = new XmlSerializer(typeof(Company));
            using (XmlWriter w = XmlWriter.Create(fileName))
            {
                w.WriteProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" href=\"xhtml.xsl\"");
                serializer.Serialize(w, objectToSerialize, ns);
            }
        }

        public static Company Deserialize(string fileName)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Company));
            Company company;
            using (Stream reader = new FileStream(fileName, FileMode.Open))
            {
                company = (Company)deserializer.Deserialize(reader);
            }
            return company;
        }
    }
}
