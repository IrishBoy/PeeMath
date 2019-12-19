using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace PeeMath
{
    public class Calculations
    {
        public static double Summary(double a, double b)
        {
            return a + b;
        }

        public static double Subtraction(double a, double b)
        {
            return a - b;
        }

        public static double Multiplication(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            return a / b;
        }

        public static double Square(double a)
        {
            return a * a;
        }

        public static double Exponentiation(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double Ln(double a)
        {
            return Math.Log(a);
        }

        public static double Log(double a, double b)
        {
            return Math.Log(a, b);
        }

        public static double Sin(double a)
        {
            return Math.Sin(a * Math.PI / 180);
        }

        public static double Cos(double a)
        {
            return Math.Cos(a * Math.PI / 180);
        }

        public static double Tg(double a)
        {
            return Math.Tan(a * Math.PI / 180);
        }

        public static double Ctg(double a)
        {
            return 1.0 / Math.Tan(a * Math.PI / 180);
        }

        public static double Arcsin(double a)
        {
            return Math.Asin(a);
        }

        public static double Arccos(double a)
        {
            return Math.Acos(a);
        }

        public static double Arctg(double a)
        {
            return Math.Atan(a);
        }

        public static double Arcctg(double a)
        {
            return Math.PI / 2 - Math.Atan(a);
        }

        public static double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }

        public static double Root(double a, int b)
        {
            return Math.Pow(a, 1 / b);
        }

        

    }
}
