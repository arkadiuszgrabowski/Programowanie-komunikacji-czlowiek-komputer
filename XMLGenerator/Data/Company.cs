using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data
{
    [XmlRoot(Namespace ="zam")]
    public class Company
    {

        public Company()
        {
        }

        public Company(List<Order> orders, List<Product> products, List<Author> authors, string schemaLocation)
        {
            Orders = orders;
            ProductsRepository = products;
            Authors = authors;
            SchemaLocation = schemaLocation;
        }
        [XmlArrayItem("Author")]
        public List<Author> Authors { get; set; }
        [XmlArrayItem("Product")]
        public List<Product> ProductsRepository { get; set; }
        [XmlArrayItem("Order")]
        public List<Order> Orders { get; set; }
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }
        
    }
}
