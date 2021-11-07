using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    // Задача B1.
    [TestClass]
    public class TaskB1
    {
        [TestMethod]
        public void Test1() => Assert.AreEqual(9, Homework.TaskB1.MeanSquare(new List<int>() { 1, 2, 3 }, new List<int>() { 4, 5, 6 }), "TEST ERROR");

        [TestMethod]
        public void Test2() => Assert.AreEqual(16.5, Homework.TaskB1.MeanSquare(new List<int>() { 10, 20, 10, 2 }, new List<int>() { 10, 25, 5, -2 }), "TEST ERROR");

        [TestMethod]
        public void Test3() => Assert.AreEqual(1, Homework.TaskB1.MeanSquare(new List<int>() { 0, -1 }, new List<int>() { -1, 0 }), "TEST ERROR");

        [TestMethod]
        public void Test4() => Assert.AreEqual(0, Homework.TaskB1.MeanSquare(new List<int>() { 10, 10 }, new List<int>() { 10, 10 }), "TEST ERROR");
    }
}
