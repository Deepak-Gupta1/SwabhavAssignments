using DIPWithDelegateApp.HighLevelModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPWithDelegateApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator calc = new TaxCalculator((msg) => Console.WriteLine("logging in db {0}", msg));
            //TaxCalculator calc = new TaxCalculator(DoFileLogging);
            calc.Calculator(10, 0);
            Console.ReadKey();
        }
        static void DoFileLogging(string msg) { Console.WriteLine(msg); }
    }
}
