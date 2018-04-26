using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexionApp
{
    public class Person
    {
        private string Name;
        private int Years;

        public Person(string name, int years)
        {
            Name = name;
            Years = years;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hi! My name is {Name}");
        }

        public void SayYears()
        {
            Console.WriteLine($"I'm {Years} years old");
        }
    }
}
