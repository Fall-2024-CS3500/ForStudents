using System;
using Lab3;
namespace TestRational
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestStackOverflow()
        //{
        //    Rational.InfiniteRecursion();
        //}

        [TestMethod]
        public void RationalConstructorTest()
        {
            Rational z = new Rational();
            Assert.AreEqual("0", z.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RationalConstructorTest2()
        {
            Rational r = new Rational(5, 0);
        }

        [TestMethod]
        public void RationalMultiArgConstructorTest()
        {
            Rational test_rational = new Rational(1, 2);
            Assert.AreEqual("1/2", "" + test_rational);
        }

        [TestMethod]
        public void RationalElseConstructorTest()
        {
            Rational test_rational = new Rational(1, -2);
            Assert.AreEqual("-1/2", "" + test_rational);
        }

    }
}