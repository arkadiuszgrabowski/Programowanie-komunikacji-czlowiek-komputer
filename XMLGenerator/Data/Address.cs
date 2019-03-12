using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data
{
    
    public class Address
    {
        public Address()
        {
        }

        public Address(string city, string street, string property, string zipCode)
        {
            City = city;
            Street = street;
            Property = property;
            ZipCode = zipCode;
        }

        public string City { get; set; }
        public string Street { get; set; }
        public string Property { get; set; }
        [XmlAttribute]
        public string ZipCode { get; set; }
    }
}
