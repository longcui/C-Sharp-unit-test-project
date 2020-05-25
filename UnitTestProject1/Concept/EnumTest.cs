using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest.Concept
{
    [TestClass]
    public class EnumTest
    {
        [Flags]
        enum ColorsWithFlag { Red = 1, Green = 2, Blue = 4, Yellow = 8 };

        enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };

        enum SimpleColors { NotAvailable, Red, Green};


        [TestMethod]
        public void TestConversion() {
            string[] names = Enum.GetNames(typeof(ColorsWithFlag));
            Assert.AreEqual("Red, Green, Blue, Yellow", String.Join(", ", names));

            ColorsWithFlag color = (ColorsWithFlag)Enum.Parse(typeof(ColorsWithFlag), "Green");
            //Values converted to Object will never be the same. Consider using AreEqual(). 
            Assert.AreNotSame(ColorsWithFlag.Green, color);
            Assert.AreEqual(ColorsWithFlag.Green, color);
            ColorsWithFlag color2 = (ColorsWithFlag)Enum.Parse(typeof(ColorsWithFlag), "green", true);
            Assert.AreEqual(ColorsWithFlag.Green, color2);
        }

        /// <summary>
        /// Could use int to convert to Enum!!!
        /// One Enum type could contain more than 1 instance!!!
        /// </summary>
        [TestMethod]
        public void TestFlag() {
            //With Flag
            ColorsWithFlag colorsWithFlag = (ColorsWithFlag)3;
            Assert.AreEqual("Red, Green", colorsWithFlag.ToString());
            //Without Flag
            Colors colors = (Colors)3;
            Assert.AreEqual("3", colors.ToString());

            //Personally, I think below form is better presented than above
            ColorsWithFlag colorsWithFlagCombined = ColorsWithFlag.Red | ColorsWithFlag.Green;
            Assert.AreEqual(colorsWithFlagCombined, colorsWithFlag);
            Colors colorsCombined = Colors.Red | Colors.Green;
            Assert.AreEqual((Colors)3, colorsCombined);

            Assert.AreEqual(ColorsWithFlag.Red, colorsWithFlagCombined & ColorsWithFlag.Red);
        }

        [TestMethod]
        public void TestTryParse() {
            ///Return Object
            Object result = null;
            Enum.TryParse(typeof(Colors), "red", true, out result);
            Assert.AreEqual(Colors.Red, (Colors)result);

            result = null;
            Enum.TryParse(typeof(Colors), "BAD_VALUE", out result);     //return default value of Object which is null.
            Assert.AreEqual(null, result);

            ///Return Domain type
            SimpleColors result2;
            Enum.TryParse("red", true, out result2);
            Assert.AreEqual(SimpleColors.Red, result2);

            // If parsing fails(return false), the result will be default.
            //Enum could not be Null.
            result2 = default;
            Enum.TryParse("BAD_VALUE", out result2);
            Assert.AreEqual(SimpleColors.NotAvailable, result2);

        }
    }
}
