using EnumerationApp.Model;
using System;
namespace EnumerationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enumeration a1 = new Enumeration();
            a1.FindShape(Enumeration.shapes.circle);
            a1.FindShape(Enumeration.shapes.square);
            a1.FindShape(Enumeration.shapes.Triangle);
            a1.FindShape(Enumeration.shapes.Rectangle);
            Console.Read();
        }
   
    }
}
