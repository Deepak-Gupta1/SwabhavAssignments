using CustomerEncapApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEncapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.SetId(1);
            c1.SetName("Ajay"); 
            Console.WriteLine("Customer Id: " + c1.GetId());
            Console.WriteLine("Customer Name: " + c1.GetName());
            Console.WriteLine("Customer Placed Oder: " + c1.GetOrderCount());
            Console.WriteLine("\nAter Placing Order\n");
            c1.PlaceOder();
            Console.WriteLine("Customer Id: " + c1.GetId());
            Console.WriteLine("Customer Name: " + c1.GetName());
            Console.WriteLine("Customer Placed Oder: " + c1.GetOrderCount());

            Console.ReadKey();

        }
    }
}
