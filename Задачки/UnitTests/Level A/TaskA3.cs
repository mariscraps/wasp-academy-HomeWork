using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    // Задача А3.
    [TestClass]
    public class TaskA3
    {
        [TestMethod]
        public void Test1() => Assert.AreEqual(27, Homework.TaskA3.SumCube(2, 3), "TEST ERROR");

        [TestMethod]
        public void Test2() => Assert.AreEqual(27, Homework.TaskA3.SumCube(3, 2), "TEST ERROR");

        [TestMethod]
        public void Test3() => Assert.AreEqual(100, Homework.TaskA3.SumCube(0, 4), "TEST ERROR");

        [TestMethod]
        public void Test4() => Assert.AreEqual(12384, Homework.TaskA3.SumCube(17, 14), "TEST ERROR");

        [TestMethod]
        public void Test5() => Assert.AreEqual(0, Homework.TaskA3.SumCube(9, 9), "TEST ERROR");

        [TestMethod]
        public void Test6() => Assert.AreEqual(225, Homework.TaskA3.SumCube(5, 0), "TEST ERROR");
    }
}
