using System;

namespace ClassLibrary1
{
    public class Person
    {
        private string _name;
        private string _address;
        private Genders _gender;

        public Genders Gender { get; set; }
        public Person(string name, string address, Genders gender)
        {
            _name = name;
            _address = address;
            _gender = gender;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length > 2) throw new ArgumentException();
                _name = value;
            }

        }

        public string Address
        {
            get => _address;
            set
            {
                if (value == null) throw new ArgumentNullException();
                _address = value;
            }
        }

        public enum Genders


        {
            Male, Female
        }

    }
}
