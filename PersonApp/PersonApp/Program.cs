using PersonApp.Model;
using System;

namespace PersonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.ReadKey();
        }

        public static void CaseStudy1()
        {
            Person p1 = new Person(01, "Deepak", 21);
            PrintDetails(p1);
        }
        public static void CaseStudy2()
        {
            Person p2 = new Person(02, "Mahendra", 34, 1.80, 80);
            PrintDetails(p2);
        }
        public static void PrintDetails(Person p)
        {
            Console.WriteLine("ID "+p.Id);
            Console.WriteLine("Name "+p.Name);
            Console.WriteLine("Height " + p.Height);
            Console.WriteLine("Weight " + p.Wegith);
            Console.WriteLine("BMI Score " + p.CalcuateBmi());
            p.BmiBaseBodyType(p.CalcuateBmi());
        }

    }
}
