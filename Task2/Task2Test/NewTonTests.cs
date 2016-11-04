using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2Library;

namespace Task2Test
{
    [TestClass]
    public class NewTonTests
    {
        [TestMethod]
        public void SqrtN_5and1_5()
        {
            var k = new NewTon(5, 1);
            double newt = k.SqrtN();
            Assert.AreEqual(newt, 5);
        }

        [TestMethod]
        public void Pow_5and1_5()
        {
            var k = new NewTon(5, 1);
            double pow = k.Pow();
            Assert.AreEqual(pow, 5);
        }

        [TestMethod]
        public void CompairNewtonandPow_5and1_равны()
        {
            var k = new NewTon(5, 1);
            Assert.AreEqual(k.CompairNewtonandPow(k.SqrtN(), k.Pow()), "равны");
        }
        [TestMethod]
        public void CompairNewtonandPow_10and3_newtonменьшеpow()
        {
            var k = new NewTon(10, 3);
            Assert.AreEqual(k.CompairNewtonandPow(k.SqrtN(), k.Pow()), "newton < pow");
        }
        [TestMethod]
        public void CompairNewtonandPow_000003and2большеpow()
        {
            var k = new NewTon(0.00003, 2);
            Assert.AreEqual(k.CompairNewtonandPow(k.SqrtN(), k.Pow()), "newton > pow");
        }

        [TestMethod]
        public void ToBinary_4_100()
        {
            var k = new NewTon(5, 1);
            Assert.AreEqual(k.ToBinary("4"), "100");
        }

        [TestMethod()]
        public void ToBinary_minus5_FormatException()
        {

            try
            {
                var k = new NewTon(5, 1);
                k.ToBinary("-5");
            }
            catch (FormatException e)
            {
                StringAssert.Contains(e.Message, "не удается конвертировать в тип uint");
            }

        }
    }
}
