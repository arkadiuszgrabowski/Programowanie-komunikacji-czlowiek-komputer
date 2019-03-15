using System;
using System.Collections.Generic;

namespace Data
{
    public class ProductsRepository
    {
        private static List<Product> Products = new List<Product>();
        public static void Add(Product product)
        {
            Products.Add(product);
        }
        public static Product GetProduct(Guid guid)
        {
            foreach(Product product in Products)
            {
                if(product.Id == guid)
                {
                    return product;
                }
            }
            return null;
        }
        public static List<Product> GetAll()
        {
            return Products;
        }
    }

}
