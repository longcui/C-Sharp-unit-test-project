using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestProject1;

namespace UnitTest.LINQ
{
    [TestClass]
    public class GroupByLINQTest : LINQTest
    {
        readonly IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 },
                new Student() { StudentID = 2, StudentName = "Steve", Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 },
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 },
                new Student() { StudentID = 5, StudentName = "Abram", Age = 21 }
            };


        [TestMethod]
        public void TestGroupBy()
        {
            IEnumerable<IGrouping<int, Student>> groupedResult = studentList.GroupBy(s => s.Age);
            //iterate each group        
            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key (Age in this example)

                foreach (Student s in ageGroup) // Each group has inner collection
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }

        }

        [TestMethod]
        public void TestOrderBy()
        {
            IOrderedEnumerable<Student> orderedEnumerable = studentList.OrderBy(s => s.Age);
            Assert.AreEqual(18, orderedEnumerable.First().Age);
        }


        private class Student
        {
            public int StudentID, Age;
            public string StudentName { get; set; }
        }
    }
}
