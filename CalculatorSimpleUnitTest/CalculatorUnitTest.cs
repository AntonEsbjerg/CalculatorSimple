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
        [TestCase(2.3, 4.4 , 6.7)]
        [Category("SimpleOperationTests")]
        public void AddTest(double i1, double i2, double o1)
        {
            Assert.That(uut.Add(i1,i2), Is.EqualTo(o1));
        }
        [TestCase(2, 2, 0)]
        [TestCase(0, 1, -1)]
        [TestCase(54,23,31)]
        [TestCase(6.72, 3.32, 3.4)]
        [Category("SimpleOperationTests")]
        public void SubtractTest(double i1, double i2, double o1)
        {
            Assert.That(uut.Subtract(i1, i2), Is.EqualTo(o1));
        }

        [TestCase(2, 2, 4)]
        [TestCase(0, 1, 0)]
        [TestCase(3,2,6)]
        [TestCase(2.5, 3.5, 8.75)]
        [Category("ComplexOperationTests")]
        public void MultiplyTest(double i1, double i2, double o1)
        {
            Assert.That(uut.Multiply(i1, i2), Is.EqualTo(o1));
        }

        [TestCase(2, 2, 4)]
        [TestCase(1, 0, 1)]
        [TestCase(3, 3, 27)]
        [TestCase(2.5, 2, 6.25)]
        [Category("ComplexOperationTests")]
        public void PowerTest(double i1, double i2, double o1)
        {
            Assert.That(uut.Power(i1, i2), Is.EqualTo(o1));
        }

        [TestCase(-2, 2.5, "Result is complex Number")]
        [Category("ComplexOperationTests")]
        public void PowerComplexTest(double i1, double i2, string o1)
        {
            var ex =
            Assert.Catch<ArgumentException>(() => uut.Power(i1, i2));

            Assert.That(ex.Message, Is.EqualTo(o1));
        }

        [TestCase(3, 2, 1.5)]
        [TestCase(0, 1, 0)]
        [TestCase(10, 2, 5)]
        [TestCase(4.4, 2.2, 2)]
        [Category("ComplexOperationTests")]
        public void DivideTest(double i1, double i2, double o1)
        {
            Assert.That(uut.Divide(i1, i2), Is.EqualTo(o1));
        }



        [TestCase(2, 2, 4)]
        [TestCase(0, 1, 1)]
        [TestCase(3, 3, 6)]
        [TestCase(2.3, 4.4, 6.7)]
        [Category("SimpleOperationTests")]
        public void AccumulatorAddTest(double i1, double i2, double o1)
        {
            uut.Add(i1);
            Assert.That(uut.Add(i2), Is.EqualTo(o1));
        }

        [TestCase(2, 2, 0)]
        [TestCase(0, 1, -1)]
        [TestCase(54, 23, 31)]
        [TestCase(6.72, 3.32, 3.4)]
        [Category("SimpleOperationTests")]
        public void AccumulatorSubtractTest(double i1, double i2, double o1)
        {
            uut.Add(i1);
            Assert.That(uut.Subtract(i2), Is.EqualTo(o1));
        }


        [TestCase(2, 2, 4)]
        [TestCase(0, 1, 0)]
        [TestCase(3, 2, 6)]
        [TestCase(2.5, 3.5, 8.75)]
        [Category("ComplexOperationTests")]
        public void AccumulatorMuliplyTest(double i1, double i2, double o1)
        {
            uut.Add(i1);
            Assert.That(uut.Multiply(i2), Is.EqualTo(o1));
        }

        [TestCase(2, 2, 4)]
        [TestCase(1, 0, 1)]
        [TestCase(3, 3, 27)]
        [TestCase(2.5, 2, 6.25)]
        [Category("ComplexOperationTests")]
        public void AccumulatorPowerTest(double i1, double i2, double o1)
        {
            uut.Add(i1);
            Assert.That(uut.Power(i2), Is.EqualTo(o1));
        }


        [TestCase(3, 2, 1.5)]
        [TestCase(0, 1, 0)]
        [TestCase(10, 2, 5)]
        [TestCase(4.4, 2.2, 2)]
        [Category("ComplexOperationTests")]
        public void AccumulatorDivideTest(double i1, double i2, double o1)
        {
            uut.Add(i1);
            Assert.That(uut.Divide(i2), Is.EqualTo(o1));
        }

        [TestCase(-2, 2.5, "Result is complex Number")]
        [Category("ComplexOperationTests")]
        public void AccumulationPowerComplexTest(double i1, double i2, string o1)
        {
            uut.Add(i1);
            var ex =
            Assert.Catch<ArgumentException>(() => uut.Power(i2));

            Assert.That(ex.Message, Is.EqualTo(o1));
        }

        [TestCase(2)]
        [TestCase(0)]
        [TestCase(3)]
        [TestCase(33.5)]
        [Category("SimpleOperationTests")]
        public void ClearTest(double i1)
        {
            uut.Add(i1);
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }



        [TestCase(2, 1, 4, 2, 2, 8)]
        [TestCase(100, 200, 0.1, 2, 50, 2)]
        [TestCase(2, 4, 2, 3, 8, -8)]
        [TestCase(2.5, 1.25, 6, 2, 4.5, 12.5)]
        [Category("ComplexOperationTests")]
        public void AccumulatorMixTest(double i1, double i2, double i3, double i4, double i5, double o1)
        {
            uut.Add(i1);

            uut.Subtract(i2);

            uut.Multiply(i3);

            uut.Power(i4);

            uut.Divide(i5);

            Assert.That(uut.Accumulator, Is.EqualTo(o1));
        }


    }
}