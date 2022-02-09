using System;
using NUnit.Framework;
using CalculatorSimple;

;

namespace CalculatorSimpleUnitTest
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private Calculator uut;

        [SetUp]
        public void SetUp()
        {
            uut = new Calculator();
        }

        [TestCase(2,2,4)]
        [TestCase(0,1,1)]
        public void AddTest(double i1, double i2, double o1)
        {
            Assert.That(uut.Add(i1,i2), Is.EqualTo(o1));
        }
        [TestCase(2, 2, 0)]
        [TestCase(0, 1, -1)]
        public void SubtractTest(double i1, double i2, double o1)
        {
            Assert.That(uut.Subtract(i1, i2), Is.EqualTo(o1));
        }
        [TestCase(2, 2, 4)]
        [TestCase(0, 1, 0)]
        public void MultiplyTest(double i1, double i2, double o1)
        {
            Assert.That(uut.Multiply(i1, i2), Is.EqualTo(o1));
        }
        [TestCase(2, 2, 4)]
        [TestCase(1, 0, 1)]
        public void PowerTest(double i1, double i2, double o1)
        {
            Assert.That(uut.Power(i1, i2), Is.EqualTo(o1));
        }
    }
}