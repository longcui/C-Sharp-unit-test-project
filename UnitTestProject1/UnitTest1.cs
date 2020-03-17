using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] names = new string[3] {"Alice", "Bob", "Celina"};
            IEnumerable<string> linqQuery = from name in names
                where  name.StartsWith('A')
                select name;

            Assert.AreEqual(1, linqQuery.Count());
            foreach (string name in linqQuery)
            {
                Assert.AreEqual("Alice", name);
            }
        }
    }
}
