using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTest.Concept
{
    [TestClass]
    public class Iteration
    {
        [TestMethod]
        public void TestAs() {
            IEnumerable<int> numbers = new[] { 10, 20, 30 };
            //below could NOT compile
            //Assert.AreEqual(40, numbers[0] + numbers[indexable.Count - 1]);

            IList<int> indexable = numbers as IList<int>;
            //Need to compare the result of the as expression with null to check if the conversion is successful
            if (indexable != null) { 
                Assert.AreEqual(40, indexable[0] + indexable[indexable.Count - 1]);
                Assert.AreEqual(40, indexable.ElementAt(0) + indexable.ElementAt(indexable.Count - 1));
            }
        }
    }
}
