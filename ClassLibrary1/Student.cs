using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Student:Person
    {
        /// <summary>
        /// Fields
        /// </summary>

        private int _semester;

        /// <summary>
        /// Constructor
        /// </summary>

        public Student(string name, string address, Genders gender, int semester) : base(name, address, gender)
        {
            _semester = semester;
        }
        /// <summary>
        /// property 
        /// </summary>
        /// 
        public int Semester
        {
            get => _semester;
            set
            {
                if (value > 1 || value < 8)
                    if (value >= 1 && value <= 8) throw new ArgumentOutOfRangeException();
                _semester = value;
            }

        }

    }
}
