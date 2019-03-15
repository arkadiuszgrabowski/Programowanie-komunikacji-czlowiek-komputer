using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class ProductsRepository
    {
        public List<Product> Products { get; set; }
        public void Add(Product product)
        {
            Products.Add(product);
        }
        public Product GetProduct(Guid guid)
        {
            return
        }
    }

}
