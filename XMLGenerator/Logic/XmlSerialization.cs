using Data;
using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Schema;
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
            CheckValidity(fileName);
        }

        public static Company Deserialize(string fileName)
        {
            CheckValidity(fileName);
            XmlSerializer deserializer = new XmlSerializer(typeof(Company));
            Company company;
            using (Stream stream = new FileStream(fileName, FileMode.Open))
            {
                company = (Company)deserializer.Deserialize(stream);
            }
            return company;
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Debug.WriteLine("Error: {0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Debug.WriteLine("Warning {0}", e.Message);
                    break;
            }

        }
        static void CheckValidity(string fileName)
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add("zam", "schema.xsd");
                settings.ValidationType = ValidationType.Schema;

                using (XmlReader reader = XmlReader.Create(fileName, settings))
                {
                    XmlDocument document = new XmlDocument();
                    document.Load(reader);

                    ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);

                    document.Validate(eventHandler);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
