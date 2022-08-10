using EventCalculatorApp.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(40,10);
            calc.OnClickResult+=(result)=>Console.WriteLine(result);
            calc.Add();
            calc.Subtract();
            Console.ReadKey();
        }

    }
}
