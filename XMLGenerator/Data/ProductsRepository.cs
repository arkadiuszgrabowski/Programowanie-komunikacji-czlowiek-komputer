using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Data
{
    public class ProductsRepository
    {
        private static List<Product> Products = new List<Product>();
        public static void Add(Product product)
        {
            Products.Add(product);
        }
        public static Product GetProduct(string guid)
        {
            foreach(Product product in Products)
            {
                if(string.Equals(product.ProductId, guid))
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
