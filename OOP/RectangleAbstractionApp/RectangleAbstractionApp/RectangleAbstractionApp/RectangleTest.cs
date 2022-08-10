using RectangleAbstractionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAbstractionApp
{
    internal class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle big = new Rectangle();

            big.width = 400;
            big.height = 600;
            Console.WriteLine("Width of BigRectangle : " + big.width);
            Console.WriteLine("Height of BigRectangle: " + big.height);
            Console.WriteLine("Area of BigRectangle : "+big.CalculateArea());
            Console.WriteLine();


            Rectangle small = new Rectangle();
            small.width = 56;
            small.height = 60;
            Console.WriteLine("Width of SmallRectangle: " + small.width);
            Console.WriteLine("Height of SmallRectangle: " + small.height);
            Console.WriteLine("Area of SmallRectangle:  " + small.CalculateArea());

            Console.WriteLine();

            Rectangle temp = small;
            Console.WriteLine("Width of temp is "+temp.width);

            temp.width += 10;
            Console.WriteLine("Width of temp is " + temp.width);
            Console.WriteLine("Width of small is " + small.width);
            Console.WriteLine();

            Console.WriteLine("Hashcode of small "+small.GetHashCode());
            Console.WriteLine("Hashcode of temp " + temp.GetHashCode());
            Console.WriteLine("Hashcode of big " + big.GetHashCode());


            Console.ReadKey();
        }

     
    }
}
