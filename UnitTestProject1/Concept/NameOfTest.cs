using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Concept
{
    [TestClass]
    public class NameofTest
    {
        [TestMethod]
        public void TestNameof() {
            Assert.AreEqual("String", nameof(System.String));

            int i = 4;
            Assert.AreEqual("i", nameof(i));

            List<int> list = new List<int>();
            Assert.AreEqual("list", nameof(list));
        }
    }
}
