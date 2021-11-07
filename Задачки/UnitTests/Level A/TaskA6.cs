using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    // Задача А6.
    [TestClass]
    public class TaskA6
    {
        [TestMethod]
        public void Test1() => CollectionAssert.AreEqual(new List<int>() { 7, 9 }, Homework.TaskA6.OddNumbers(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 2), "TEST ERROR");

        [TestMethod]
        public void Test2() => CollectionAssert.AreEqual(new List<int>() { 9, -81, 7 }, Homework.TaskA6.OddNumbers(new List<int>() { -15, 3, 6, 9, 12, -24, -81, 7 }, 3), "TEST ERROR");

        [TestMethod]
        public void Test3() => CollectionAssert.AreEqual(new List<int>() { -3 }, Homework.TaskA6.OddNumbers(new List<int>() { 6, -25, 3, 7, 5, 5, 7, -3, 24 }, 1), "TEST ERROR");
    }
}
