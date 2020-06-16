using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTest.Concept.Threading
{
    /// <summary>
    /// To be continued
    /// </summary>
    [TestClass]
    public class ThreadingExample
    {
        [TestMethod]
        public async Task TestAsync() {
            Console.WriteLine(SynchronizationContext.Current);
            await Task.Delay(10);
            Console.WriteLine(SynchronizationContext.Current == null);
        }

        [TestMethod]
        public async Task TestAsyncConfigureAwait()
        {
            for (int i = 0; i < 1990; i++) {
                Console.WriteLine(SynchronizationContext.Current);
                //await Task.Delay(10).ConfigureAwait(false);
                await Task.Delay(10);
                Console.WriteLine(SynchronizationContext.Current);
                //Assert.IsFalse(SynchronizationContext.Current == null);
            }
        }
    }
}
