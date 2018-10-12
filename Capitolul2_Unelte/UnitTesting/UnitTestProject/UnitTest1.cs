using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodLogin()
        {
            MainWindow m = new MainWindow();
            //m.ShowDialog();
            //could check the values in the GUI
            //or set it manually
            m.InitControls();

            Assert.IsTrue(m.Validate("me", "mypass"));
        }
        [TestMethod]
        public void TestMethodSum()
        {
            Arithmetics a = new Arithmetics();

            //a test composed out of two subtests

            Assert.AreEqual(23.5, a.Sum(13.5, 10));

            Assert.AreEqual(23, a.Sum(13, 10));
        }
        [TestMethod]
        public void TestAgainMethodSum()
        {
            Arithmetics a = new Arithmetics();

            
            Assert.AreEqual(15, a.Sum(new int[] { 1,2,3,4,5}));

            
        }
    }
}
