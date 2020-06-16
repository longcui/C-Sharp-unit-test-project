using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Concept.Property
{
    [TestClass]
    public class PropertyTest
    {
        [TestMethod]
        public void TestGetter() {
            Person person = new Person();
            Assert.AreNotEqual(person.DiffId, person.DiffId);
            Assert.AreEqual(person.SameId, person.SameId);
        }
        private class Person {
            public string DiffId { get => Guid.NewGuid().ToString(); }

            public string SameId { get; } = Guid.NewGuid().ToString();
        }
    }

}
