using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Data
{

    public class Order
    {
        public Order()
        {
        }

        public Order(List<Item> content, Address address, string sendingDateTime, string estimatedDelivery, OrderType type)
        {
            OrderId = "x" + Guid.NewGuid().ToString();
            Items = content;
            Address = address; 
            SendingDateTime = sendingDateTime;
            EstimatedDelivery = estimatedDelivery;
            Type = type;
            double x = 0;
            foreach (Item item in content)
            {
                x += ProductsRepository.GetProduct(item.ProductId).ProductPrice * item.Quantity;
            };
            OrderPrice = Math.Round(x, 2);
        }
        [XmlAttribute]
        public string OrderId { get; set; }
        [XmlArrayItem("Item")]
        public List<Item> Items { get; set; }
        [XmlElement]
        public Address Address { get; set; }
        public string SendingDateTime { get; set; }
        public string EstimatedDelivery { get; set; }
        [XmlAttribute("OrderType")]
        public OrderType Type { get; set; }
        public double OrderPrice { get; set; }
    }
}
