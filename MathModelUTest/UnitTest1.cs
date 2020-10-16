using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsTEst.model;

namespace MathModelUTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //public void TestAddition()
        public void TestAddition()
        {
            MathModel oTestee = new MathModel();
            Assert.AreEqual(51, oTestee.doAddition(20, 31));
        }

        [TestMethod]
        public void Test_Subtraktion()
        {
            MathModel oTestee = new MathModel();
            Assert.AreEqual(4, oTestee.doSubtraktion(7, 3));
        }

        [TestMethod]
        public void TestMultiplikation()
        {
            MathModel oTestee = new MathModel();
            Assert.AreEqual(6, oTestee.doMultiplikation(2, 3));

        }

        [TestMethod]
        public void TestDivision()
        {
            MathModel oTestee = new MathModel();
            Assert.AreEqual(2, oTestee.doDivision(16, 8));

        }
    }
}
