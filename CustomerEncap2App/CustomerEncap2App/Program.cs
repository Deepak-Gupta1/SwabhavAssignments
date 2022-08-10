using CustomerEncap2App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEncap2App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Id=1;
            c1.Name="Ajay";
            Console.WriteLine("Customer Id: " + c1.Id);
            Console.WriteLine("Customer Name: " + c1.Name);
            Console.WriteLine("Customer Placed Oder: " + c1.OrderCount);
            Console.WriteLine("\nAter Placing two Order\n");

            c1.OrderCount=2;
            Console.WriteLine("Customer Id: " + c1.Id);
            Console.WriteLine("Customer Name: " + c1.Name);
            Console.WriteLine("Customer Placed Oder: " + c1.OrderCount);

            Console.ReadKey();
        }
    }
}
