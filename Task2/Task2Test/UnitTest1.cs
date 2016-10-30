using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2Library;

namespace Task2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void konstryktor_Newton_Method()
        {
            var k = new NewTon(5, 1);
            double newt = k.SqrtN();
            Assert.AreEqual(newt, 5);
        }

        [TestMethod]
        public void konstryktor_Pow_Method()
        {
            var k = new NewTon(5, 1);
            double pow = k.Pow();
            Assert.AreEqual(pow, 5);
        }

        [TestMethod]
        public void Compair_Method()
        {
            var k = new NewTon(5, 1);
            Assert.AreEqual(k.CompairNewtonandPow(k.SqrtN(), k.Pow()), "равны");
        }
        [TestMethod]
        public void Compair_menshe_Method()
        {
            var k = new NewTon(10, 3);
            Assert.AreEqual(k.CompairNewtonandPow(k.SqrtN(), k.Pow()), "newton < pow");
        }
        [TestMethod]
        public void Compair_bolshe_Method()
        {
            var k = new NewTon(0.00003, 2);
            Assert.AreEqual(k.CompairNewtonandPow(k.SqrtN(), k.Pow()), "newton > pow");
        }

        [TestMethod]
        public void Binary_Method()
        {
            var k = new NewTon(5, 1);
            Assert.AreEqual(k.ToBinary("4"), "100");
        }

        [TestMethod()]
        public void Binary_Exception()
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
