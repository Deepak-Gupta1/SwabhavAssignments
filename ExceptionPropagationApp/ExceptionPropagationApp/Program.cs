using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPropagationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                M1();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.StackTrace);
            }
            Console.WriteLine("End of main ");
            Console.ReadKey();
        }

        static void M1() {
            Console.WriteLine("inside M1 ");
            M2();
        }
        static void M2() {
            Console.WriteLine("inside M2 ");
            M3();
        }
        static void M3() {
            Console.WriteLine("inside M3 ");
            Random rnd = new Random();
            int val = rnd.Next(1, 9);
            Console.WriteLine(val);
            if (val > 5)
            {
                throw new Exception("something went wrong in M2 value of " + val);
            }
        }

    }
}
