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

        public Company(List<Order> orders, List<Product> products, List<Author> authors)
        {
            Orders = orders;
            ProductsRepository = products;
            Authors = authors;
        }
        [XmlArrayItem("Author")]
        public List<Author> Authors { get; set; }
        [XmlArrayItem("Product")]
        public List<Product> ProductsRepository { get; set; }
        [XmlArrayItem("Order")]
        public List<Order> Orders { get; set; }
       
    }
}
