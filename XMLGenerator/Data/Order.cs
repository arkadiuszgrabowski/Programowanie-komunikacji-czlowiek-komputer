using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Order
    {
        private long Id { get; set; }
        //Content trzeba zrobić jako listę przedmiotów chyba to bedzie złożony typ danych
        private String Content { get; set; }
        private String Address { get; set; }
        private DateTime SendingDateTime { get; set; }
        private DateTime EstimatedDelivery { get; set; }
        private OrderType Type { get; set; }
    }
}
