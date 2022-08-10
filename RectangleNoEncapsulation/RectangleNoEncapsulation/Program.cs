using System;
using RectangleNoEncapsulation.Model;

namespace RectangleNoEncapsulationAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1;

            r1= new Rectangle();

            r1.width = 1000000;
            r1.height = -1000; // violation of Encapusalation

            Console.WriteLine("Area is "+r1.CalculateArea());

            Console.ReadKey();

        }
    }
}
