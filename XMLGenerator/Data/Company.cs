using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data
{
    public class Company
    {
        public Company()
        {
        }

        public Company(List<Order> orders, List<Product> products)
        {
            Orders = orders;
            ProductsRepository = products;
        }
        [XmlArrayItem("Order")]
        public List<Order> Orders { get; set; }
        [XmlArrayItem("Product")]
        public List<Product> ProductsRepository { get; set; }
    }
}
