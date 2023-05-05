using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BasicMath;

namespace BasicMathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            Class1 bm = new Class1();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {

            Class1 bm = new Class1();
            double res = bm.Substract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {

            Class1 bm = new Class1();
            double res = bm.divide(10, 5);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {

            Class1 bm = new Class1();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }

    }
}
