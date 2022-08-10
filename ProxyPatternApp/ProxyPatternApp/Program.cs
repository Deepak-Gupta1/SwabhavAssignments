using ProxyPatternApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IImage img1 = new RealImage("one.png");
            //IImage img2 = new RealImage("2.png");
            //IImage img3 = new RealImage("3.png");
            //img3.display();
            IImage img1 = new ProxyImage("one.png");
            IImage img2 = new ProxyImage("2.png");
            IImage img3 = new ProxyImage("3.png");
            img3.display();

            Console.ReadLine();
        }
    }
}
