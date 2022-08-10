using StudentPropertiesApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPropertiesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("Positive Test Case");
            s1.RollNo = 5;
            Console.WriteLine("Roll No: "+s1.RollNo);
            s1.Name = "DeepakGupta";
            Console.WriteLine("Name: " + s1.Name);
            Console.WriteLine("\nNegative Test Case");
            s1.RollNo = -10;
            Console.WriteLine("Roll No: " + s1.RollNo);
            s1.Name = "Abc";
            Console.WriteLine("Name: " + s1.Name);
            Console.ReadKey();
        }

    }
}
