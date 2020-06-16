using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace UnitTest.Concept
{
    [TestClass]
    public class GetFieldTest
    {
        private const string BOB = "Bob";
        private const string FIELD_EXAMPLE = "field example";

        [TestMethod]
        public void TestGetField() {
            Person person = new Person(5) {
                Name = BOB
            };
            Type personType = typeof(Person);
            // GetFiled uses DefaultLookup which is DefaultLookup = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;
            System.Reflection.FieldInfo fieldInfo = personType.GetField("fieldExample");
            Assert.AreEqual(FIELD_EXAMPLE, fieldInfo.GetValue(person));

            PropertyInfo propertyInfo = personType.GetProperty("Name");
            Assert.AreEqual(BOB, propertyInfo.GetValue(person));
        }

        public class MyFieldClassA
        {
            public string Field = "A Field";
        }

        public class MyFieldClassB
        {
            private string field = "B Field";
            public string Field
            {
                get
                {
                    return field;
                }
                set
                {
                    if (field != value)
                    {
                        field = value;
                    }
                }
            }
        }

        public class Person {
            public string fieldExample = FIELD_EXAMPLE;
            public Person(int id)
            {
                Id = id;
            }

            private int Id { get; set; }
            public string Name { get; set; }

        }
    }
}
