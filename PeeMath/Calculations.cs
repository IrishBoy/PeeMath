using System;
using System.Collections.Generic;
using System.Text;

namespace PeeMath
{
    class Calculations
    {
        public double Summary(double a, double b)
        {
            return a + b;
        }

        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        public double Division(double a, double b)
        {
            return a / b;
        }

        public double Square(double a)
        {
            return a * a;
        }

        public double Exponentiation(double a, int b)
        {
            return Math.Pow(a, b);
        }

        public double Ln(double a)
        {
            return Math.Log(a);
        }

        public double Log(double a, double b)
        {
            return Math.Log(a, b);
        }

        public double Sin(double a)
        {
            return Math.Sin(a * Math.PI / 180);
        }

        public double Cos(double a)
        {
            return Math.Cos(a * Math.PI / 180);
        }

        public double Tg(double a)
        {
            return Math.Tan(a * Math.PI / 180);
        }

        public double Ctg(double a)
        {
            return 1.0 / Math.Tan(a * Math.PI / 180);
        }

        public double Arcsin(double a)
        {
            return Math.Asin(a);
        }

        public double Arccos(double a)
        {
            return Math.Acos(a);
        }

        public double Arctg(double a)
        {
            return Math.Atan(a);
        }

        public double Arcctg(double a)
        {
            return Math.PI / 2 - Math.Atan(a);
        }

        public double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }

        public double Root(double a, int b)
        {
            return Math.Pow(a, 1 / b);
        }


        
    }
}
