using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumofEvenNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SumofEvenNumber.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Input1largerthaninput2()
        {
            Assert.AreEqual(28, SumofEvenNumber.SumofEvenNumberCal(11, 4));
        }

        [TestMethod]
        public void Input1smallerthaninput2()
        {
            Assert.AreEqual(28, SumofEvenNumber.SumofEvenNumberCal(4,11));
        }
        [TestMethod]
        public void NegativeNumber()
        {
            Assert.AreEqual(18, SumofEvenNumber.SumofEvenNumberCal(-7, 10));
        }
        [TestMethod]
        public void NegativeNumber2()
        {
            Assert.AreEqual(18, SumofEvenNumber.SumofEvenNumberCal(10, -7));
        }
    }
}