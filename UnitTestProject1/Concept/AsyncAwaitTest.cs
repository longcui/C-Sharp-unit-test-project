using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTest.Concept
{
    [TestClass]
    public class AsyncAwaitTest
    {
        /// <summary>
        /// Result is:  1 2 3 4
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task TestWithAwaitAsync() {
            Console.WriteLine("1");
            await Test1InnerAsync();
            Console.WriteLine("4");
        }


        [TestMethod]
        public void Test1WithoutAwait() {
            Console.WriteLine("1");
            Test1InnerAsync();
            Console.WriteLine("4");
            Thread.Sleep(20);       //Without waiting, Test1InnerAsync() will not have enough time to execute.
        } 
        

        private async Task Test1InnerAsync() {
            Console.WriteLine("2");
            await Task.Delay(5);
            Console.WriteLine("3");
        }
    }
}
