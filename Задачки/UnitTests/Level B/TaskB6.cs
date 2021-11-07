using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    // Задача B6.
    [TestClass]
    public class TaskB6
    {
        [TestMethod]
        public void Test1() => Assert.AreEqual("esrever srettel", Homework.TaskB6.Reverser("reverse letters"), "TEST ERROR");

        [TestMethod]
        public void Test2() => Assert.AreEqual("A nuf elttil !egnellahc", Homework.TaskB6.Reverser("A fun little challenge!"), "TEST ERROR");

        [TestMethod]
        public void Test3() => Assert.AreEqual("  ", Homework.TaskB6.Reverser("  "), "TEST ERROR");
    }
}
