using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    // Задача B5.
    [TestClass]
    public class TaskB5
    {
        [TestMethod]
        public void Test1() => Assert.AreEqual("~~~~~~~~~\n~ Small ~\n~ text  ~\n~ frame ~\n~~~~~~~~~",
           Homework.TaskB5.Frame(new List<string>() { "Small", "text", "frame" }, '~'), "TEST ERROR");

        [TestMethod]
        public void Test2() => Assert.AreEqual("------------------------------------\n- This is a very long single frame -\n------------------------------------",
            Homework.TaskB5.Frame(new List<string>() { "This is a very long single frame" }, '-'), "TEST ERROR");
    }
}
