using System;
using System.ComponentModel;
using System.Data;

namespace SharedCalculator
{
    public class Calculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static double AddDouble(double a, double b)
        {
            return a + b;
        }

        public static double SubtractDouble(double a, double b)
        {
            return a - b;
        }

        public static double MultiplyDouble(double a, double b)
        {
            return a * b;
        }

        public static double DivideDouble(double a, double b)
        {
            return a / b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double TheMadness(double a, double b, double c, double d)
        {

            return a * (b % c - d);
        }

    }
}
