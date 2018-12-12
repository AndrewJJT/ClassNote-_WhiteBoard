using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwiceOfAge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwiceOfAge.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TwiceTest()
        {
            Assert.AreEqual(0, TwiceOfAge.Twice(20,40));
        }

        [TestMethod()]
        public void TwiceTest1()
        {
            Assert.AreEqual(18, TwiceOfAge.Twice(1, 20));
        }
   
    }
}