using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data
{
    public class Product
    {
        public Product()
        {
        }

        public Product(string name, double price)
        {
            ProductId = Guid.NewGuid();
            Name = name;
            ProductPrice = price;
        }
        [XmlAttribute]
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public double ProductPrice { get; set; }
    }
}
