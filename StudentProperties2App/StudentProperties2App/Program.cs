using StudentProperties2App.Model;
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
            Console.WriteLine("Roll No: " + s1.RollNo);
            s1.Name = "DeepakGupta";
            Console.WriteLine("Name: " + s1.Name);
            s1.TotalFees = 100000;
            Console.WriteLine("Total Fees: " + s1.TotalFees);
            s1.PayFees(20000);
            Console.WriteLine("Ater Paying 20k");
            Console.WriteLine("Remaining Fees: " + s1.RemainingFee);
            s1.PayFees(70000);
            Console.WriteLine("Ater Paying 70k");
            Console.WriteLine("Remaining Fees: " + s1.RemainingFee);
            Console.WriteLine("\nNegative Test Case");
            s1.RollNo = -10;
            Console.WriteLine("Roll No: " + s1.RollNo);
            s1.Name = "Abc";
            Console.WriteLine("Name: " + s1.Name);
            Console.ReadKey();
        }

    }
}
