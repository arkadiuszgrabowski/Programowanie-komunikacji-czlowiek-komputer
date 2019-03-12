using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data
{
    public class Item
    {
        public Item()
        {
        }

        public Item(string name, int quantity, double price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Quantity = quantity;
            Price = price;
        }
        [XmlAttribute]
        public Guid Id { get; set; }
        public string Name { get; set; }
        [XmlAttribute]
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
