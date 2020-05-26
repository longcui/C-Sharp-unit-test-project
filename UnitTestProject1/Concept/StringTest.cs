using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Concept
{
    [TestClass]
    public class StringTest
    {
        [TestMethod]
        public void TestString() {
            string greeting = "Hello";
            Assert.AreEqual(5, greeting.Length);
            Assert.AreEqual("HELLO", greeting.ToUpper());
            Assert.AreEqual("hello", greeting.ToLower());

            //string interpotation
            string firstName = "John";
            string lastName = "Doe";
            Assert.AreEqual("JohnDoe", String.Concat(firstName, lastName));
            string name = $"My full name is: {firstName} {lastName}";
            Assert.AreEqual("My full name is: John Doe", name);

            Console.WriteLine("I will print on a new line.");
            Console.Write("Hello World! ");
            Console.WriteLine(Convert.ToString(1));    // convert int to string
            Console.WriteLine(Convert.ToDouble(1));    // convert int to double
            Console.WriteLine(Convert.ToInt32(12d));  // convert double to int

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
