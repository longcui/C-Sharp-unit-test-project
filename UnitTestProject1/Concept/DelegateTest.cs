using CSharpMain.Concept;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Concept
{
    [TestClass]
    public class DelegateTest
    {
        [TestMethod]
        public void Test() {
            DelegateExample.MathDelegate mathDelegate = DelegateExample.Sum;
            Assert.AreEqual(7, mathDelegate(2, 5));

            mathDelegate = DelegateExample.Multiplier;
            Assert.AreEqual(10, mathDelegate(2, 5));

            mathDelegate = (a, b) => a - b;
            Assert.AreEqual(-3, mathDelegate(2, 5));

            //It seems, the last result overrides the previous.
            mathDelegate = DelegateExample.Sum;
            mathDelegate += DelegateExample.Multiplier;
            Assert.AreEqual(10, mathDelegate(2, 5));
        }

        /// <summary>
        /// <code>Action</code> is a <code>delegate</code>, so does <code>Func</code>
        /// </summary>
        [TestMethod]
        public void TestActionDelegateMulticastFeature() {
            List<string> results = new List<string>();
            Action<int, int> actionDelegate = (a, b) =>
            {
                results.Add("Executing a...");
            };
            actionDelegate += (a, b) =>
            {
                results.Add("Executing b...");
            };
            actionDelegate(1, 2);
            Assert.AreEqual(2, actionDelegate.GetInvocationList().Length);
            Assert.AreEqual("Executing a..., Executing b...", String.Join(", ", results));
        }

    }
}
