using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollektioner
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString() => $"Name:{Name}, Age{Age}";
    }
}
