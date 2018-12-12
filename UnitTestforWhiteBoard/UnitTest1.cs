using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestforWhiteBoard
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TwiceOfAgeTest()
        {
            Assert.Equals(0, Twice(20, 40));
        }
    }
}
