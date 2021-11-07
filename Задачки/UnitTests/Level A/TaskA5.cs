using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    // Задача А5.
    [TestClass]
    public class TaskA5
    {
        [TestMethod]
        public void Test1() => CollectionAssert.AreEqual(new List<int>() { 4, 42, 420 }, Homework.TaskA5.ArrayOfTiers(420), "TEST ERROR");

        [TestMethod]
        public void Test2() => CollectionAssert.AreEqual(new List<int>() { 2, 20, 202, 2021 }, Homework.TaskA5.ArrayOfTiers(2021), "TEST ERROR");

        [TestMethod]
        public void Test3() => CollectionAssert.AreEqual(new List<int>() { 8, 80, 802, 8020, 80200 }, Homework.TaskA5.ArrayOfTiers(80200), "TEST ERROR");
    }
}
