using DIPViolationApp.HighLevelModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator calc = new TaxCalculator(LoggerType.FILE);
            Console.WriteLine(calc.Calculator(30, 0));
            Console.ReadKey();
        }
    }
}
