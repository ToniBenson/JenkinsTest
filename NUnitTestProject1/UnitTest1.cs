using NUnit.Framework;
using JenkinsTEst.model;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddition()
        {
            MathModel oTestee = new MathModel();
            Assert.AreEqual(5, oTestee.doAddition(2, 3));

        }
    }
}