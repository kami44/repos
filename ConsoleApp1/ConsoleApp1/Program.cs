using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Ford", 1992);
            Car c2 = new Car("Fiat", 1993);
            Car c3 = new Car("Opel", 1994);
            Car c4 = new Car("BWM", 1995);
            Car c5 = new Car("Skoda", 1996);
            Car c6 = new Car("Honda", 1997);
        }

        ArrayCatalog<Car> ac = new ArrayCatalog<Car>(6);

    }
}
