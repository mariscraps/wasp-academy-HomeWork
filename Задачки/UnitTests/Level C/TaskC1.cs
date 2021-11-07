using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    // Задача C1.
    [TestClass]
    public class TaskC1
    {
        [TestMethod]
        public void Test1() => CollectionAssert.AreEqual(new List<int>() { 0, 0, 0, 0, 0, 1 }, Homework.TaskC1.AppleShare(1), "TEST ERROR");

        [TestMethod]
        public void Test2() => CollectionAssert.AreEqual(new List<int>() { 0, 0, 1, 1, 1, 1 }, Homework.TaskC1.AppleShare(4), "TEST ERROR");

        [TestMethod]
        public void Test3() => CollectionAssert.AreEqual(new List<int>() { 0, 1, 1, 2, 3, 3 }, Homework.TaskC1.AppleShare(10), "TEST ERROR");

        [TestMethod]
        public void Test4() => CollectionAssert.AreEqual(new List<int>() { 2, 5, 7, 10, 12, 14 }, Homework.TaskC1.AppleShare(50), "TEST ERROR");
    }
}
