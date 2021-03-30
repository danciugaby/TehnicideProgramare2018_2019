using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Arithmetics a = new Arithmetics();
            Assert.AreEqual(5, a.Multiply(2, 2));
        }
    }
}
