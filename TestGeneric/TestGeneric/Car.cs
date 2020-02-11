using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneric
{
    public class Car
    {
        private string _make;
        private int _year;

        public Car(string make, int year)
        {
            this._make = make;
            this._year = year;
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public override string ToString()
        {
            return "The brand of the car is:" +Make+" Year of the car" +Year;
        }

    }
}
