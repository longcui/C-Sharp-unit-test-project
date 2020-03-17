using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        static readonly string[] Names = new string[3] {"Alice", "Bob", "Celina"};


        [TestMethod]
        public void TestMethod1()
        {
            IEnumerable<string> linqQuery = from name in Names
                where  name.StartsWith('A')
                select name;

            Assert.AreEqual(1, linqQuery.Count());
            foreach (string name in linqQuery)
            {
                Assert.AreEqual("Alice", name);
            }
        }

        //todo: any order in Take()?
        [TestMethod]
        public void TestTake()
        {
            IEnumerable<string> enumerable = from name in Names
                select name;
            
            Assert.AreEqual(2, enumerable.Take(2).Count()); 
            Assert.AreEqual(0, enumerable.Take(0).Count()); 
            Assert.AreEqual(3, enumerable.Take(5).Count()); 

        }
    }
}
