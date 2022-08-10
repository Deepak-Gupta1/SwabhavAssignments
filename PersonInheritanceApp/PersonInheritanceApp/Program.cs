using PersonInheritanceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tweeter sachin = new Tweeter("Sachin", "Tendulkar", "@sachin_crickter");
            PrintDetails(sachin);
            Console.ReadKey();
        }

        private static void PrintDetails(Tweeter sachin)
        {
            Console.WriteLine("First Name: " + sachin.FirstName);
            Console.WriteLine("Last Name: " + sachin.LastName);
            Console.WriteLine("TweeterHandle Name: " + sachin.TweeterHandle);
        }
    }
}
