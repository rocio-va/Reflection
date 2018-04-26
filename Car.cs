using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexionApp
{
    public class Car
    {
        private int Speed;

        public Car(int currentSpeed)
        {
            Speed = currentSpeed;
        }

        public void ShowSpeed()
        {
            if(Speed <= 50)
            {
                Console.WriteLine($"La velocidad es de {Speed}, vas muy lento!");
                return;
            }
            if (Speed >= 100)
            {
                Console.WriteLine($"La velocidad es de {Speed}, vas muy ráido!");
                return;
            }
            Console.WriteLine($"La velocidad es de {Speed}");
        }
    }
}
