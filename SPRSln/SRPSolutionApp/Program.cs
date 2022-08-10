using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInvoice print = new PrintInvoice(new Invoice("Food Invoice", new Product("Biryani", 800, 10, 5)));
            print.Print();
            Console.ReadKey();
        }
    }
}
