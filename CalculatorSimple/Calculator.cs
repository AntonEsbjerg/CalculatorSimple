using System;
using System.Xml.XPath;
using Math = System.Math;

namespace CalculatorSimple
{
    public class Calculator
    {
        public double Accumulator { get; private set; }


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

        public double Add(double b)
        {
            var result = Accumulator + b;
            Accumulator = result;
            return result;
            
        }

        public double Subtract(double b)
        {
        var result = Accumulator - b;
            Accumulator = result;
        return result;
        }
            
        public double Multiply(double b)
        {
            var result = Accumulator * b;
        
            Accumulator = result;
            return result;
        }
        public double Divide(double b)
        {
            var result = Accumulator / b;
            Accumulator = result;
            return result;
        }

        public double Power(double exp)
        {
            var result = Math.Pow(Accumulator, exp);
            Accumulator = result;
            return result;
        }



    }
}