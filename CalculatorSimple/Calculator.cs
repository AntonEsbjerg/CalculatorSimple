using System;
using System.Xml.XPath;
using Math = System.Math;

namespace CalculatorSimple
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            var result = a + b;
            return result;
        }
        public double Subtract(double a, double b)
        {
            var result = a - b;
            return result;
        }
        public double Multiply(double a, double b)
        {
            var result = a * b;
            return result;
        }
        public double Power(double x, double exp)
        {
            var result = Math.Pow(x, exp);
            return result;
        }

        public double Divide(double a, double b)
        {
            var result = a / b;
            return result;
        }
    }
}