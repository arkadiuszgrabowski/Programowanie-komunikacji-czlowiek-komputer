using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            ProductID = product.Id;
        }

        public Guid ProductID { get; set; }
        public int Quantity { get; set; }

    }
}
