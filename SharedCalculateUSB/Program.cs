using System;
using System.ComponentModel;
using SharedCalculator;

namespace SharedCalculateUSB
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculator1 calculator1 = new Calculator1();
            Console.WriteLine("Valg: (A) Add");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar == 'A')
                {
                    
                }
            }





            Console.ReadLine();

        }
    }
}
