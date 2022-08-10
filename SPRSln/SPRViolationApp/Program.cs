using SPRViolationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("Food Invoice",1000,10,5);
            invoice.PrintInvoice();
            Console.ReadKey();
        }
    }
}
