using InheritanceConstructorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FnCase2();
            //FnCase1();
            Console.ReadKey();
        }
        private static void FnCase1()
        {
            new CaseStudy1.Child();
        }

        private static void FnCase2()
        {
            CaseStudy2.Child c1 =new CaseStudy2.Child();
            Console.WriteLine(c1.Foo);
            CaseStudy2.Child c2 = new CaseStudy2.Child();
            Console.WriteLine(c2.Foo);
            CaseStudy2.Child c3 = new CaseStudy2.Child(300);
            Console.WriteLine(c3.Foo);
        }
        
    }
}
