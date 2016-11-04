using System;
using Task3Library;


using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Task3Library.Tests
{
    [TestClass]
    public class EvklidTests
    {
        [TestMethod]
        public void Gcd_140and70_70()
        {
            long time;
            long number = Evklid.Gcd(140, 70, out time);
            Assert.AreEqual(number, 70);
            Assert.AreEqual(time, 0);
        }

        [TestMethod()]
        public void BinaryGcd_70and140_70()
        {
            //arrange
            var expected = 70L;
            var time = 0L;

            //act
            var actual = Evklid.BinaryGcd(70, 140, out time);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(0, time, 1);
        }
        [TestMethod()]
        public void BinaryGcd_10and0_10()
        {
            //arrange
            var expected = 10L;
            var time = 0L;

            //act
            var actual = Evklid.BinaryGcd(10, 0, out time);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(0, time, 1);
        }

        [TestMethod()]
        public void BinaryGcd_0and15_15()
        {
            //arrange
            var expected = 15L;
            var time = 0L;

            //act
            var actual = Evklid.BinaryGcd(0,15, out time);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(0, time, 1);
        }

        [TestMethod()]
        public void BinaryGcd_20and20_20()
        {
            //arrange
            var expected = 20L;
            var time = 0L;

            //act
            var actual = Evklid.BinaryGcd(20, 20, out time);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(0, time, 1);
        }

        [TestMethod()]
        public void BinaryGcd_1and2_1()
        {
            //arrange
            var expected = 1L;
            var time = 0L;

            //act
            var actual = Evklid.BinaryGcd(1, 2, out time);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(0, time, 1);
        }
        [TestMethod()]
        public void BinaryGcd_10and20_10()
        {
            //arrange
            var expected = 10L;
            var time = 0L;

            //act
            var actual = Evklid.BinaryGcd(10, 20, out time);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(0, time, 1);
        }

        [TestMethod()]
        public void BinaryGcd_20and7_1()
        {
            //arrange
            var expected = 1L;
            var time = 0L;

            //act
            var actual = Evklid.BinaryGcd(20, 7, out time);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(0, time, 1);
        }

        [TestMethod()]
        public void BinaryGcd_31and16_1()
        {
            //arrange
            var expected = 1L;
            var time = 0L;

            //act
            var actual = Evklid.BinaryGcd(31, 16, out time);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(0, time, 1);
        }

        [TestMethod()]
        public void BinaryGcd_minus20and31_1()
        {
            //arrange
            var expected = 1L;
            var time = 0L;

            //act
            var actual = Evklid.BinaryGcd(-20, 31, out time);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(0, time, 1);
        }

        [TestMethod()]
        public void GcdMany_10and15and20and25and50and100_5()
        {
            //arrange
            var expected = 5L;
            var time = 0L;

            //act
            var actual = Evklid.GcdMany(out time, 10, 15, 20, 25, 50, 100);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(0, time, 1);
        }

    }
}
