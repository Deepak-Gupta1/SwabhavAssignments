using InterfaceMovableApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovablePolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imovable[] movables = new Imovable[3];
            movables[0] = new Car();
            movables[1] = new Bike();
            movables[2] = new Truck();
            Race(movables);
            Console.ReadKey();
        }
        private static void Race(Imovable[] movables)
        {
            Console.WriteLine("Starting the Race");
            foreach (Imovable item in movables)
            {
                item.Move();
            }
        }
    }
}
