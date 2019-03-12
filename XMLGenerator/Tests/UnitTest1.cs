using System;
using System.Collections.Generic;
using Data;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GeneraterXml()
        {
            Address address = new Address("Łódź", "Politechniki", "3a", "93-501");
            Item item = new Item(Guid.NewGuid(), "Item1", 2);
            List<Item> list = new List<Item>();
            list.Add(item);
            Order order = new Order(Guid.NewGuid(), list, address, DateTime.Now, DateTime.Now, OrderType.Complete);
            XmlSerialization.Serialize(order, "Xmlik.xml");
        }
    }
}
