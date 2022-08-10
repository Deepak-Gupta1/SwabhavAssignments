using RectangleEncapsulation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();

            r1.SetWidth(50);
            r1.SetHeight(30);

            Console.WriteLine("Width " + r1.GetWidth());
            Console.WriteLine("Heigth " + r1.GetHeigh());
            Console.WriteLine("Area " + r1.CalculateArea());

            Console.ReadKey();
        }
    }
}
