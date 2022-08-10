using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // assigned int value
            // 23 to num
            int num = 23;

            // Boxing converts a Value Type variable into a Reference Type variable
            object obj = num;

            // unboxing converts a Reference Type variable into Type variable
            int i = (int)obj;

            // Display result
            Console.WriteLine("Boxing POC :- Value of object is : " + obj);
            Console.WriteLine("UnBoxing POC :- Value of i is : " + i);

            Console.ReadKey();
        }
    }
}
