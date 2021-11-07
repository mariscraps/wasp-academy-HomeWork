using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    // Задача А4.
    [TestClass]
    public class TaskA4
    {
        [TestMethod]
        public void Test1() => CollectionAssert.AreEqual(new List<int>() { 5 }, Homework.TaskA4.ListOfSums(new List<int>() { 2, 3, 5, 6 }), "TEST ERROR");

        [TestMethod]
        public void Test2() => CollectionAssert.AreEqual(new List<int>() { 3, 6, 12, 24 }, Homework.TaskA4.ListOfSums(new List<int>() { 1, 2, 3, 6, 12, 24 }), "TEST ERROR");

        [TestMethod]
        public void Test3() => CollectionAssert.AreEqual(new List<int>() { 30, 60, 0 }, Homework.TaskA4.ListOfSums(new List<int>() { 10, 20, 30, 60, -120, 0 }), "TEST ERROR");

        [TestMethod]
        public void Test4() => CollectionAssert.AreEqual(new List<int>() { 0, 0, 0 }, Homework.TaskA4.ListOfSums(new List<int>() { 1, -1, 0, 0, 0 }), "TEST ERROR");
    }
}
