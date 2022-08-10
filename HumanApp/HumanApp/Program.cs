using HumanApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor= ConsoleColor.Black;
            Console.ForegroundColor= ConsoleColor.Red;
            CaseStudy1();
            CaseStudy2();
            Console.ReadLine();
        }

        private  static void CaseStudy1()
        {
            Human h1 = new Human("Deepak", 50, 5);
            PrintDetails(h1);
        }

        private static void CaseStudy2()
        {
            Human h2 = new Human("Annu", 60, 6, Human.GenderCategory.Female);
            PrintDetails(h2);

            h2.Eat();
            Console.WriteLine("After Eating");
            PrintDetails(h2);

            h2.WorkOut();
            Console.WriteLine("After Doing WorkOut");
            PrintDetails(h2);
        }

        private static void PrintDetails(Human h)
        {
            Console.WriteLine("Name "+h.Name);
            Console.WriteLine("Gender "+h.Gender);
            Console.WriteLine("Height "+h.Height);
            Console.WriteLine("Weight "+h.Weight);
            Console.WriteLine();
        }
    }
}
