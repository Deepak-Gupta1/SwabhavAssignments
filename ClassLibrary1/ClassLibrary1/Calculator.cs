using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ClassLibrary1.Model
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CaseStudy 3 Class Library");
            Console.WriteLine("Enter Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter one Operator (Add + /Sub - /Mul * /Div /): ");
            var op = Console.ReadLine();
            // Create a class library object and call the Calculate method  
            MathClass math = new MathClass();
            double result = math.Calculate(num1, num2, op);
            Console.WriteLine("Result: {0}", result);
            Console.ReadKey();
        }
    }
}

