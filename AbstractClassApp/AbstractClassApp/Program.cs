using AbstractClassApp.Model;
using System;

namespace AbstractClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass d = new DerivedClass();

            Console.WriteLine("Addition :{0}\nMultiplication :{1}", d.AddTwoNumbers(4, 6),d.MultiplyTwoNumbers(6, 4));

            Console.ReadKey();
        }
    }
}
