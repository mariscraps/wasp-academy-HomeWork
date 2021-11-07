using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    // Задача C3.
    [TestClass]
    public class TaskC3
    {
        [TestMethod]
        public void Test1() => Assert.AreEqual(43, Homework.TaskC3.Movie(500, 15, 0.9), "TEST ERROR");

        [TestMethod]
        public void Test2() => Assert.AreEqual(24, Homework.TaskC3.Movie(100, 10, 0.95), "TEST ERROR");
    }
}
