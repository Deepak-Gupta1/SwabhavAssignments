using RectangleConstructorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 ;
            r1 = new Rectangle(30,50);
            PrintDetails(r1,"Details of First Constructor with two parameters");

            Rectangle r2 =new Rectangle();
            r2.BorderColor = "BluE";
            r2.BorderColor = "GreeN";
            r2 = new Rectangle(30,50,r2.FillColor, r2.BorderColor);
            PrintDetails(r2, "\nDetails of Second Constructor with four parameters");

            PrintDetails(new Rectangle(5, 10, "BLUE", "GREEN"), "\nDetails ofAnonymous Constructor ");

            Console.ReadKey();
            
        }
        public static void PrintDetails(Rectangle rectangle, string info)
        {
            Console.WriteLine(info);
            Console.WriteLine("Width =" + rectangle.Width);
            Console.WriteLine("Heigth =" + rectangle.Height);
            Console.WriteLine("Area =" + rectangle.Area);
            Console.WriteLine("Boader Color =" + rectangle.BorderColor);
            Console.WriteLine("Fill Color =" + rectangle.FillColor);
        }

    }
}
