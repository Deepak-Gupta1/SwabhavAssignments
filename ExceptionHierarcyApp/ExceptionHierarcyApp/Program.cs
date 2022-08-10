using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHierarcyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Main(args);
            int a = Convert.ToInt32(args[0]);  // when no input given System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            //System.FormatException: 'Input string was not in a correct format.'
           
            int b = Convert.ToInt32(args[1]);  //System.OverflowException: 'Value was either too large or too small for an Int32.'
           
            int c = a / b;               //System.DivideByZeroException: 'Attempted to divide by zero.'
            
            Console.WriteLine("Result of division is {0}", c);
            Console.WriteLine("Thank you for using App");
            Console.ReadKey();
            
        }
    }
}
