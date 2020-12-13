using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Integral.Classes;

namespace Integral.Tests
{
    [TestClass]
    public class Integral
    {
        [TestMethod]
        public void S_xx_0_10()
        {
            //arrange
            double expected = 333.333;
            double a = 0;
            double b = 10;
            int n = 10000;
            ICalculator calcul = new Simpson();

            //act
            double actual = calcul.CalculateParallel(a, b, n, x => x * x);

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void S_xx_Negative_Step()
        {
            //arrange
            double expected = 333.333;
            double a = 0;
            double b = 10;
            int n = -10000;
            ICalculator calcul = new Simpson();

            //act
            double actual = calcul.CalculateParallel(a, b, n, x => x * x);

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void S_xx_Odd_Step()
        {
            //arrange
            double expected = 333.333;
            double a = 0;
            double b = 10;
            int n = 1001;
            ICalculator calcul = new Simpson();

            //act
            double actual = calcul.CalculateParallel(a, b, n, x => x * x);

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void S_xx_10_0()
        {
            //arrange
            double expected = -333.333;
            double a = 10;
            double b = 0;
            int n = 10000;
            ICalculator calcul = new Simpson();

            //act
            double actual = calcul.Calculate(a, b, n, x => x * x);

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void S_Step_0()
        {
            //arrange
            double expected = 0;
            double a = 10;
            double b = 10;
            int n = 10000;
            ICalculator calcul = new Simpson();

            //act
            double actual = calcul.CalculateParallel(a, b, n, x => x * x);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
