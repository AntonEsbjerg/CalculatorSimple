using System;
using NUnit.Framework;
using CalculatorSimple;

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
            uut.Clear();
        }

        [TestCase(2,2,4)]
        [TestCase(0,1,1)]
        [TestCase(3,3,6)]
        [Category("SimpleOperationTests")]
        public void AddTest(double i1, double i2, double o1)
        {
            Assert.That(uut.Add(i1,i2), Is.EqualTo(o1));
        }
        [TestCase(2, 2, 0)]
        [TestCase(0, 1, -1)]
        [TestCase(54,23,31)]
        [Category("SimpleOperationTests")]
        public void SubtractTest(double i1, double i2, double o1)
        {
            Assert.That(uut.Subtract(i1, i2), Is.EqualTo(o1));
        }
        [TestCase(2, 2, 4)]
        [TestCase(0, 1, 0)]
        [TestCase(3,2,6)]
        [Category("ComplexOperationTests")]
        public void MultiplyTest(double i1, double i2, double o1)
        {
            Assert.That(uut.Multiply(i1, i2), Is.EqualTo(o1));
        }
        [TestCase(2, 2, 4)]
        [TestCase(1, 0, 1)]
        [Category("ComplexOperationTests")]
        public void PowerTest(double i1, double i2, double o1)
        {
            Assert.That(uut.Power(i1, i2), Is.EqualTo(o1));
        }
        [TestCase(3, 2, 1.5)]
        [TestCase(0, 1, 0)]
        [Category("ComplexOperationTests")]
        public void DivideTest(double i1, double i2, double o1)
        {
            Assert.That(uut.Divide(i1, i2), Is.EqualTo(o1));
        }



        [TestCase(2, 2, 4)]
        [TestCase(0, 1, 1)]
        [TestCase(3, 3, 6)]
        [Category("SimpleOperationTests")]
        public void AccumulatorAddTest(double i1, double i2, double o1)
        {
            uut.Add(i1);
            Assert.That(uut.Add(i2), Is.EqualTo(o1));
        }
    }
}