using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{

    public class Order
    {
        public Order()
        {
        }

        public Order(Guid id, List<Item> content, Address address, DateTime sendingDateTime, DateTime estimatedDelivery, OrderType type)
        {
            Id = id;
            Content = content;
            Address = address;
            SendingDateTime = sendingDateTime;
            EstimatedDelivery = estimatedDelivery;
            Type = type;
        }

        public Guid Id { get; set; }
        public List<Item> Content { get; set; }
        public Address Address { get; set; }
        public DateTime SendingDateTime { get; set; }
        public DateTime EstimatedDelivery { get; set; }
        public OrderType Type { get; set; }
    }
}
