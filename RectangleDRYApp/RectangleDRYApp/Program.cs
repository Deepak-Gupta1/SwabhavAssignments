using RectangleDRYApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleDRYApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.ReadKey();
        }

        public static void CaseStudy2() {
            Rectangle rect = new Rectangle();
            rect.Width = 20;
            rect.Height = 30;
            rect.BorderColor = "BluE";
            rect.FillColor = "GreeN";
            PrintDetails(rect, "\nDisplaying CaseStudy2 details");
        }

        public static void CaseStudy1() {
            Rectangle small = new Rectangle();
            small.Width = 10;
            small.Height = 5;
            PrintDetails(small, "\nDisplaying small details");
            Rectangle big = new Rectangle();
            big.Width = 100;
            big.Height = 200;
            big.BorderColor = "BluE";
            PrintDetails(big, "\nDisplaying big details");
        }

        public static void PrintDetails(Rectangle rectangle , string info)
        {
            Console.WriteLine(info);
            Console.WriteLine("hashcode of object is "+rectangle.GetHashCode());
            Console.WriteLine("Width =" + rectangle.Width);
            Console.WriteLine("Heigth =" + rectangle.Height);
            Console.WriteLine("Area ="+rectangle.Area);
            Console.WriteLine("Boader Color =" + rectangle.BorderColor);
            Console.WriteLine("Fill Color =" + rectangle.FillColor);
        }
    }
}
