using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    // Задача B4.
    [TestClass]
    public class TaskB4
    {
        [TestMethod]
        public void Test1() => Assert.IsTrue(Homework.TaskB4.CheckBrackets("(5+5)/[4+4]*{2*2}"), "TEST ERROR");

        [TestMethod]
        public void Test2() => Assert.IsFalse(Homework.TaskB4.CheckBrackets("(3+[2*3)]"), "TEST ERROR");

        [TestMethod]
        public void Test3() => Assert.IsTrue(Homework.TaskB4.CheckBrackets("[{([[[<>]]])(<>)(){}}]"), "TEST ERROR");

        [TestMethod]
        public void Test4() => Assert.IsFalse(Homework.TaskB4.CheckBrackets("]()(){<>}[[()]]"), "TEST ERROR");

        [TestMethod]
        public void Test5() => Assert.IsTrue(Homework.TaskB4.CheckBrackets("[(sjd),\"2\"],{2:3}, [<>]"), "TEST ERROR");

        [TestMethod]
        public void Test6() => Assert.IsFalse(Homework.TaskB4.CheckBrackets("{[[[[((()))]]<]>]}"), "TEST ERROR");
    }
}
