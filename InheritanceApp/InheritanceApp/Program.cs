using InheritanceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using virtual and override keyword\n");
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
            Console.ReadKey();
        }

        private static void CaseStudy4()
        {
            Console.WriteLine("\nCase Study 4");
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Toddler());
        }

        private static void AtThePark(Man m)
        {
            Console.WriteLine("At the park");
            m.Play();
        }

        private static void CaseStudy3()
        {
            Console.WriteLine("\nCase Study 3");
            Boy x = new Boy();
            x.Play();
            x.Walk();
            x.Read();
        }

        private static void CaseStudy2()
        {
            Console.WriteLine("\nCase Study 2");
            Boy y = new Boy();
            y.Eat();
            y.Play();
            y.Read();
            y.Walk();
        }

        private static void CaseStudy1()
        {
            Console.WriteLine("Case Study 1");
            Man x = new Man();
            x.Walk();
            x.Play();
            x.Read();
        }
    }
}
