using EmployeePolymorhismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorhismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee mg = new Manger(101, "Deepak",15000);
            PrintsDetails(mg);
            Employee dev = new Developer(202, "Rajkumar", 10000);
            PrintsDetails(dev);
            Employee tester = new Tester(303, "Virat", 20000);
            PrintsDetails(tester);

            Console.ReadKey();
        }

        private static void PrintsDetails(Employee mg)
        {
            Console.WriteLine("Employee Type: "+mg);
            Console.WriteLine("ID: "+ mg.Id+"\n"+"Name: " + mg.Name + "\nBasic Salary: " + mg.BasicSalary + 
                "\nAnnualCTC: " + mg.AnnaulCTC +"\n\n" );
        }
    }
}
