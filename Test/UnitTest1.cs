using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ExamenZlobinov;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        Program program = new Program();

        [TestMethod]
        public void TestMethod1()
        {
            int a = 2;
            int b = 2;
            int otv = 4;
            Assert.AreEqual(program.sum(a, b), otv);
        }
    }
}
