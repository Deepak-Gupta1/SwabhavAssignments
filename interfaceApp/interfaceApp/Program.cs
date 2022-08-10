using interfaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dogs myDog = new Dogs();  // Create a Dos class object
            myDog.animalSound();
            myDog.animalEat();
            Console.ReadKey();
        }
    }
}
