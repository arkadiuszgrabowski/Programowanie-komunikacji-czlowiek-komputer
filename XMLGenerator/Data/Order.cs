using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Id = Guid.NewGuid();
            Content = content;
            Address = address;
            SendingDateTime = sendingDateTime;
            EstimatedDelivery = estimatedDelivery;
            Type = type;
            double x = 0;
            foreach(Item item in content)
            {
                x += item.Price;
            };
            Price = Math.Round(x,2);
        }
        [XmlAttribute]
        public Guid Id { get; set; }
        [XmlArrayItem("Item")]
        public List<Item> Content { get; set; }
        [XmlElement]
        public Address Address { get; set; }
        public string SendingDateTime { get; set; }
        public string EstimatedDelivery { get; set; }
        [XmlAttribute("OrderType")]
        public OrderType Type { get; set; }
        public double Price { get; set; }
    }
}
