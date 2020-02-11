using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneric
{
    public class Dogs
    {
        private int _weight;
        private int _age;
        private string _name;

        public Dogs(int weight, int age, string name)
        {
            _weight = weight;
            _age = age;
            _name = name;
        }

        public int Weight { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return "The dogs name is" + Name +"its age" + Age + "Weight on the animal:"+Weight;
        }
    }
}
