using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Concept
{
    [TestClass]
    public class StringInterpolationTest
    {
        [TestMethod]
        public void Test1() {
            var inventory = new Dictionary<string, int>()
            {
                ["hammer, ball pein"] = 18,
                ["hammer, cross pein"] = 5,
                ["screwdriver, Phillips #2"] = 14
            };

            Console.WriteLine($"Inventory on {DateTime.Now:d}");
            Console.WriteLine(" ");
            Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");
            foreach (var item in inventory)
                //Print table like output
                Console.WriteLine($"|{item.Key,-25}|{item.Value,10}|");
        }
    }
}
