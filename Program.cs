using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Instancer<Person>();
            person.GetMethodsForExe();

            var car = new Instancer<Car>();
            car.GetMethodsForExe();
        }
    }
}
