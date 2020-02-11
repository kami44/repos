using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Teacher:Person
    {
        /// <summary>
        /// Fields
        /// </summary>
        ///
        /// 
        private double _salary;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="gender"></param>
        /// <param name="salary"></param>

        public Teacher(string name, string address, Genders gender, double salary) : base(name, address, gender)
        {
            _salary = salary;
        }

        /// <summary>
        /// property
        /// </summary>

        public double Salary
        {
            get => _salary;
            set
            {
                if (value >= 0) throw new ArgumentOutOfRangeException();
                _salary = value;
            }
        }
    }
}
