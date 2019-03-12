using Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logic
{
    public static class XmlSerialization
    {
        public static void Serialize(Order ObjectToSerialize, string FileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Order));
            TextWriter writer = new StreamWriter(FileName);
            serializer.Serialize(writer, ObjectToSerialize);
            writer.Close();
        }
    }
}
