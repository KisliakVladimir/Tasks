using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace Task4Tests
{
    [TestClass]
    public class Task4Tests
    {
        private static Task4.Triangle tr;
        [ClassInitialize]
        public static void ClassInitialize(TestContext testcontext)
        {
            Debug.WriteLine("class initialize");
            tr = new Task4.Triangle(0, 0, 1, 1, 0, 1);
        }
        
        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("test initialize");
            tr = new Task4.Triangle(0, 0, 1, 1, 0, 1);
        }



        [TestMethod]
        public void IsAlive_truedots_AliveTriangle()
        {
            Assert.IsTrue(tr.IsAlive());
        }

        [TestMethod]
        public void IsAlive_falsedots_NOTAliveTriangle()
        {
            tr.X1 = 0;
            tr.Y1 = 0;
            tr.X2 = 0;
            tr.Y2 = 0;
            tr.X3 = 1;
            tr.Y3 = 1;

            Assert.IsFalse(tr.IsAlive());
        }

        [TestMethod]
        public void Square_001101_05()
        {
            //arrange
            var expected = 0.5d;
            Assert.AreEqual(expected, tr.Square());
        }
        [TestMethod]
        public void Perimetr_001101_3_4142()
            {
            var expected = 3.4142d;
            Assert.AreEqual(expected, tr.Perimetr(), 0.0001);
            }
        [TestMethod]
        public void SideALength_tr_1dot4142()
        {
            var expected = 1.4142d;
            Assert.AreEqual(expected, tr.A, 0.0001);
        }
        [TestMethod]
        public void SideBLength_tr_1()
        {
            var expected = 1;
            Assert.AreEqual(expected, tr.B);
        }
        [TestMethod]
        public void SideCLength_tr_1()
        {
            var expected = 1;
            Assert.AreEqual(expected, tr.C);
        }


    }
}
