using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace UnitTest.JSON
{
    [TestClass]
    public class JSONTest
    {

        [TestMethod]
        public void TestJSONArray() {
            string[] testArray = new string[] {"a", "b", "c" };
            Assert.AreEqual(@"[""a"",""b"",""c""]", JsonSerializer.Serialize(testArray));
        }

        [TestMethod]
        public void TestBuildObject() {
            var testObj = new {
                a = "3",
                b = 14
            };
            Assert.AreEqual("{\"a\":\"3\",\"b\":14}", JsonSerializer.Serialize(testObj));
        }
    }
}
