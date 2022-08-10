using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMathOperation
{
    internal class Program
    {
        public delegate void DMathOperation(int a, int b);
        static void Main(string[] args)
        {
            DMathOperation obj;
            obj = Add;
            obj += Sub;
            obj += Multiple;
            obj(5, 2);
            Console.ReadKey();
        }            
        public static void Add(int a , int b)
        {
            Console.WriteLine("Addition "+(a + b));
        }
        public static void Sub(int a , int b)
        {
            Console.WriteLine("Substration "+(a - b));
        }
        public static void Multiple(int a ,int b)
        {
            Console.WriteLine("Multiple "+(a * b));
        }
    }
}
