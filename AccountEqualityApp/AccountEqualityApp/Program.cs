using AccountEqualityApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEqualityApp
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
            Console.ReadKey();
        }

        private static void CaseStudy1()
        {
            Account acc1 = new Account(101, "deepak", 1000);
            Console.WriteLine(acc1);
            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc1.GetType().ToString());
        }
        private static void CaseStudy2()
        {
            Account acc1 = new Account(101, "deepak", 1000);
            Account acc2 = new Account(101, "deepak", 1000);
            Console.WriteLine(acc2.Equals(acc1));
        }

        private static void CaseStudy3()
        {
            Account acc1 = new Account(101, "deepak", 1000);
            Console.WriteLine(acc1);
        }



    }
}


    