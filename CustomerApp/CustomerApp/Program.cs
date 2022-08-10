using CustomerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Deepak","Gupta",10);
            Customer c2 = new Customer("Virat", "Kohli", 50);
            Console.WriteLine(c1.FirstName + ": id " + c1.Id);
            Console.WriteLine(c2.FirstName + ": id " + c2.Id);
            Customer c3 = new Customer("Vinay", "Jain", 20);
            Console.WriteLine(c1.FirstName+": id "+c1.Id);
            Console.WriteLine(c2.FirstName + ": id " + c2.Id);
            Console.WriteLine(c3.FirstName + ": id " + c3.Id);
            Console.ReadKey();
        }
    }
}
