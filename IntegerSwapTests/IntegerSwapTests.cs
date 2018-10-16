using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegerSwap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerSwap.Tests
{
    [TestClass()]
    public class IntegerSwapTests
    {
        [TestMethod()]
        public void IntSwapTest()
        {
            Assert.AreEqual("10,15", IntegerSwap.IntSwap(15, 10));

        }

        [TestMethod()]
        public void IsPrimeTest()
        {
            Assert.AreEqual(false, IntegerSwap.IsPrime(6));
        }

        [TestMethod()]
        public void IsPrimeTest1000()
        {
            Assert.IsFalse(IntegerSwap.IsPrime(1000));
        }

        [TestMethod()]
        public void IsPrimeTest97()
        {
            Assert.IsTrue(IntegerSwap.IsPrime(97));
        }
    }
}