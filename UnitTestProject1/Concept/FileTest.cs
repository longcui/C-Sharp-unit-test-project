using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace UnitTest.Concept
{
    [TestClass]
    public class FileTest
    {
        [TestMethod]
        public void RetriveFileNames() {
            string[] fileNames = Directory.GetFiles("c:\\Users");
            foreach (string filename in fileNames) {
                Assert.IsTrue(filename.StartsWith("c:\\Users\\"));
            }
        }

        [TestMethod]
        public void GetCurrentDirectory() {
            //same Result for below. eg: C:\Users\longc\source\repos\UnitTestProject1\UnitTestProject1\bin\Debug\netcoreapp3.1
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine(Environment.CurrentDirectory);
        }

        [TestMethod]
        public void ProcessFile() {
            //need to set the csv file property: Build Action -> Embedded Resource
            Assembly assembly = Assembly.GetExecutingAssembly();
            string[] resourceNames = assembly.GetManifestResourceNames();
            Console.WriteLine(String.Join("\n", resourceNames));
            Assert.IsTrue(resourceNames.Length == 1);
            Assert.AreEqual("UnitTest.Resources.MOCK_PERSON_DATA.csv", resourceNames[0]);

            Stream stream = assembly.GetManifestResourceStream(resourceNames[0]);
            StreamReader streamReader = new StreamReader(stream);
            Console.WriteLine("1: " + streamReader.ReadLine()); //read one line
            Console.WriteLine("2: " + streamReader.ReadLine()); //read another line

            string allRest = streamReader.ReadToEnd();
            //Environment.NewLine is "\r\n" which is Windows.
            //string[] lines = allRest.Split(Environment.NewLine);    
            //The file is using "\n"
            string[] lines = allRest.Split("\n");
            Assert.AreEqual(1000, lines.Length);
        }
    }
}
