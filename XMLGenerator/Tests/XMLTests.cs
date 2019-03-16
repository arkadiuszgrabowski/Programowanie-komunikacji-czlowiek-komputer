using System;
using System.Collections.Generic;
using Data;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class XMLTests
    {
        [TestMethod]
        public void GeneraterXml()
        {
            string dateTimeFormat = "yyyy-MM-dd H:mm:ss";
            string deliveryDateTimeFormat = "yyyy-MM-dd";
            #region Addresses
            Address address1 = new Address("Łódź", "Politechniki", "3a", "93-501");
            Address address2 = new Address("Łęczyca", "Belwederska", "79a", "99-100");
            Address address3 = new Address("Szczecin", "Wąska 74", "74", "71-407");
            Address address4 = new Address("Gdynia", "Sieroszewskiego Wacława", "141", "81-376");
            Address address5 = new Address("Brzeg", "Kruszyńska", "73", "49-300");
            Address address6 = new Address("Łódź", "Legionów", "114", "91-072");
            Address address7 = new Address("Sopot", "Herberta Zbigniewa", "109", "81-826");
            Address address8 = new Address("Opole", "Kielecka", "65/24", "45-401");
            Address address9 = new Address("Warszawa", "Nowy Świat", "133/67", "00-400");
            Address address10 = new Address("Białystok", "Zagórki", "106", "15-587");
            Address address11 = new Address("Łódź", "Łęczycka", "65/11", "93-193");
            Address address12 = new Address("Wrocław", "Jagiellońska", "63", "51-218");
            #endregion
            #region Products
            Product product1 = new Product("Śrubka 2x3mm", 10.50);
            Product product2 = new Product("Monitor Asus 24 cale", 1299.99);
            Product product3 = new Product("Karta graficzna GeForce RTX 2080Ti", 4699.99);
            Product product4 = new Product("Klawiatura Roccat MK Ryos", 359.90);
            Product product5 = new Product("Macbook Air 2018", 4999.99);
            Product product6 = new Product("Lenovo Y520", 3599.49);
            Product product7 = new Product("Xiaomi Redmi 4X", 5000.99);
            Product product8 = new Product("Lg G7 Thinq", 4999.99);
            Product product9 = new Product("Windows 10 Pro", 789.99);
            Product product10 = new Product("Iphone Xs", 10099.99);
            Product product11 = new Product("Pad Xbox 360", 120.99);
            Product product12 = new Product("Myszka Lenovo", 9.99);
            ProductsRepository.Add(product1);
            ProductsRepository.Add(product2);
            ProductsRepository.Add(product3);
            ProductsRepository.Add(product4);
            ProductsRepository.Add(product5);
            ProductsRepository.Add(product6);
            ProductsRepository.Add(product7);
            ProductsRepository.Add(product8);
            ProductsRepository.Add(product9);
            ProductsRepository.Add(product10);
            ProductsRepository.Add(product11);
            ProductsRepository.Add(product12);
            #endregion
            #region Items
            Item item1 = new Item(product1, 1);
            Item item2 = new Item(product2, 2);
            Item item3 = new Item(product3, 3);
            Item item4 = new Item(product4, 5);
            Item item5 = new Item(product5, 6);
            Item item6 = new Item(product6, 1);
            Item item7 = new Item(product7, 2);
            Item item8 = new Item(product8, 3);
            Item item9 = new Item(product9, 1);
            Item item10 = new Item(product10, 6);
            Item item11 = new Item(product11, 10);
            Item item12 = new Item(product12, 1);
            #endregion
            #region ListOfItems 
            List<Item> toOrder1 = new List<Item>(new Item[] { item2, item4, item7 });
            List<Item> toOrder2 = new List<Item>(new Item[] { item1, item4, item9 });
            List<Item> toOrder3 = new List<Item>(new Item[] { item4, item12 });
            List<Item> toOrder4 = new List<Item>(new Item[] { item4, item12, item6, item11 });
            List<Item> toOrder5 = new List<Item>(new Item[] { item1, item2, item3, item4 });
            List<Item> toOrder6 = new List<Item>(new Item[] { item5, item6 });
            List<Item> toOrder7 = new List<Item>(new Item[] { item8 });
            List<Item> toOrder8 = new List<Item>(new Item[] { item9, item10, item11 });
            List<Item> toOrder9 = new List<Item>(new Item[] { item12, item11 });
            List<Item> toOrder10 = new List<Item>(new Item[] { item10, item9, item8, item7, item6 });
            List<Item> toOrder11 = new List<Item>(new Item[] { item5, item4 });
            List<Item> toOrder12 = new List<Item>(new Item[] { item3, item2, item11 });
            List<Item> toOrder13 = new List<Item>(new Item[] { item2, item6, item11 });
            List<Item> toOrder14 = new List<Item>(new Item[] { item10, item6, item11 });
            List<Item> toOrder15 = new List<Item>(new Item[] { item10, item6, item5 });
            List<Item> toOrder16 = new List<Item>(new Item[] { item10, item6, item5 });
            List<Item> toOrder17 = new List<Item>(new Item[] { item2, item8, item5 });
            List<Item> toOrder18 = new List<Item>(new Item[] { item7, item4 });
            List<Item> toOrder19 = new List<Item>(new Item[] { item7, item8, item4 });
            List<Item> toOrder20 = new List<Item>(new Item[] { item7, item8, item4 });
            List<Item> toOrder21 = new List<Item>(new Item[] { item7, item8 });
            List<Item> toOrder22 = new List<Item>(new Item[] { item2, item12, item8 });
            List<Item> toOrder23 = new List<Item>(new Item[] { item12, item8 });
            #endregion
            #region Orders
            Order order1 = new Order(toOrder1, address1, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(2).ToString(deliveryDateTimeFormat), OrderType.Complete);
            Order order2 = new Order(toOrder2, address2, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(4).ToString(deliveryDateTimeFormat), OrderType.New);
            Order order3 = new Order(toOrder3, address3, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(5).ToString(deliveryDateTimeFormat), OrderType.Canceled);
            Order order4 = new Order(toOrder4, address4, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(2).ToString(deliveryDateTimeFormat), OrderType.Canceled);
            Order order5 = new Order(toOrder5, address5, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(3).ToString(deliveryDateTimeFormat), OrderType.Processing);
            Order order6 = new Order(toOrder6, address6, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(1).ToString(deliveryDateTimeFormat), OrderType.Complete);
            Order order7 = new Order(toOrder7, address7, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(6).ToString(deliveryDateTimeFormat), OrderType.Processing);
            Order order8 = new Order(toOrder8, address8, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(4).ToString(deliveryDateTimeFormat), OrderType.Canceled);
            Order order9 = new Order(toOrder9, address9, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(2).ToString(deliveryDateTimeFormat), OrderType.Complete);
            Order order10 = new Order(toOrder10, address10, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(5).ToString(deliveryDateTimeFormat), OrderType.Complete);
            Order order11 = new Order(toOrder11, address11, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(10).ToString(deliveryDateTimeFormat), OrderType.Canceled);
            Order order12 = new Order(toOrder12, address12, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(11).ToString(deliveryDateTimeFormat), OrderType.Canceled);
            Order order13 = new Order(toOrder13, address11, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(12).ToString(deliveryDateTimeFormat), OrderType.Canceled);
            Order order14 = new Order(toOrder14, address10, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(16).ToString(deliveryDateTimeFormat), OrderType.Canceled);
            Order order15 = new Order(toOrder15, address9, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(2).ToString(deliveryDateTimeFormat), OrderType.Complete);
            Order order16 = new Order(toOrder16, address8, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(4).ToString(deliveryDateTimeFormat), OrderType.Complete);
            Order order17 = new Order(toOrder17, address7, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(1).ToString(deliveryDateTimeFormat), OrderType.Complete);
            Order order18 = new Order(toOrder18, address6, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(2).ToString(deliveryDateTimeFormat), OrderType.Complete);
            Order order19 = new Order(toOrder19, address5, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(3).ToString(deliveryDateTimeFormat), OrderType.Complete);
            Order order20 = new Order(toOrder20, address4, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(6).ToString(deliveryDateTimeFormat), OrderType.Closed);
            Order order21 = new Order(toOrder21, address3, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(7).ToString(deliveryDateTimeFormat), OrderType.Closed);
            Order order22 = new Order(toOrder22, address2, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(2).ToString(deliveryDateTimeFormat), OrderType.Closed);
            Order order23 = new Order(toOrder23, address1, DateTime.Now.ToString(dateTimeFormat), DateTime.Now.AddDays(9).ToString(deliveryDateTimeFormat), OrderType.Closed);
            #endregion
            List<Order> orders = new List<Order>(new Order[] { order1, order2, order3, order4, order5, order6, order7, order8, order9, order10,
            order11, order12, order13, order14, order15, order16, order17, order18, order19, order20, order21, order22, order23});
            Company company = new Company(orders, ProductsRepository.GetAll());
            XmlSerialization.Serialize(company, "zadanie1.xml");
        }
    }
}
