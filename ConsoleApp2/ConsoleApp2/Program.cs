using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //delegate

        public delegate double DelegateMath(double x);
        //delegate bool OperationDelegate(int v);


        static void Main(string[] args)
        {
            DelegateMath md = Square;
            Console.WriteLine(md(2));

            DelegateMath doubleUp = DoubleUp;
            Console.WriteLine(doubleUp(4));

            Func<double, double> myFunc = DoubleUp;
            Console.WriteLine(myFunc(3));

            Display(md);

            //OperationDelegate lt = LessThan20;
            //OperationDelegate bt = BiggerThan20;
            //OperationDelegate en = EvenNumb;
            //OperationDelegate od = OddNumb;

            //Console.WriteLine(lt(13));
            //Console.WriteLine(bt(20));
            //Console.WriteLine(en(10));
            //Console.WriteLine(od(3));

            //Func<int, bool> myFunc = LessThan20;
            //Console.WriteLine(myFunc(13));

            //Predicate<int> myPredicate = v => { return OddNumb(v); };
            //Console.WriteLine(myPredicate(13));



            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 


        }

        public static void Display(DelegateMath md)
        {
            List<double> ld = new List<double>();
            ld.Add(12.5);
            ld.Add(30);
            ld.Add(10);
            ld.Add(8);

            foreach (var v in ld)
            {
                Console.WriteLine();
            }
        }

        public static double Square(double x)
        {
            return x * x;

        }

        public static double DoubleUp(double x)
        {
            return x * 2;

            //}
            //public static bool LessThan20(int v)
            //{
            //    return v < 20;

            //}

            //public static bool BiggerThan20(int v)
            //{
            //    return v >= 20;
            //}

            //public static bool EvenNumb(int v)
            //{
            //    return v % 2 == 0;

            //}

            //public static bool OddNumb(int v)
            //{
            //    return v % 2 != 0;
            //}

        }
    }
}
