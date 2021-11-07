using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    // Задача B3.
    [TestClass]
    public class TaskB3
    {
        [TestMethod]
        public void Test1() => Assert.AreEqual("43200300000000000000000001", Homework.TaskB3.Decrypt("$aaaa#bbb*ccfff!z"), "TEST ERROR");

        [TestMethod]
        public void Test2() => Assert.AreEqual("30303000000000000000000001", Homework.TaskB3.Decrypt("z$aaa#ccc%eee1234567890"), "TEST ERROR");
    }
}
