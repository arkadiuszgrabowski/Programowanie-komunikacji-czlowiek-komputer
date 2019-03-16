using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data
{
    public class Author
    {
        public Author()
        {
        }

        public Author(string forename, string name, string id)
        {
            Forename = forename;
            Name = name;
            AuthorId = id;
        }
        [XmlAttribute]
        public string Forename { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string AuthorId { get; set; }
    }
}
