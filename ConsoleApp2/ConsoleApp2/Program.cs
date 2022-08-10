using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey this is deepak");
            int ip=Convert.ToInt32(args[0]);
            Console.WriteLine(cubeM(ip));

            Console.ReadLine();
        }
        public static int cubeM(int num)
        {
            int res = num * num * num;

            return res;

        }
    }
}
