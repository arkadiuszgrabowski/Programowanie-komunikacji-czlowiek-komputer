using System;
using System.Collections.Generic;
using System.Linq;
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

        public Item(Product product, int quantity)
        {
            Quantity = quantity;
            ProductId = product.ProductId.ToString();
        }
        [XmlAttribute]
        public string ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
