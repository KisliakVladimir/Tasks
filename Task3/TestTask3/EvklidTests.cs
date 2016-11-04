using System;
using Task3Library;


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTask3
{
    [TestClass]
    public class EvklidTests
    {
        [TestMethod]
        public void TestMethod_Gcd()
        {
            long time;
            long number = Evklid.Gcd(140, 70, out time);
            Assert.AreEqual(number, 70);
            Assert.AreEqual(time, 0);
        }
    }
}
