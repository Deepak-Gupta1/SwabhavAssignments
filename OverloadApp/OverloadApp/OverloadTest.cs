using System;
namespace OverloadApp
{
    internal class OverloadTest
    {
        static void Main(string[] args)
        {

            PrintDetails(45);
            PrintDetails(56.4f);
            PrintDetails("Deepak");
            PrintDetails(45);
            PrintDetails(45.28);
            PrintDetails(args);
            Console.ReadKey();
        }

        static void PrintDetails(int val) {
            Console.WriteLine("It's Integer value");
            Console.WriteLine(val);
        }
        static void PrintDetails(double val)
        {
            Console.WriteLine("It's Double value");
            Console.WriteLine(val);
        }
        static void PrintDetails(float val)
        {
            Console.WriteLine("It's Float value");
            Console.WriteLine(val);
        }

        static void PrintDetails(String val)
        {
            Console.WriteLine("It's String value");
            Console.WriteLine(val);
        }
        static void PrintDetails(bool val)
        {
            Console.WriteLine("It's Boolean value");
            Console.WriteLine(val);
            // Console.WriteLine(val);

        }

        static void PrintDetails(string [] val)
        {
            Console.WriteLine("It's Command arugment array value");
            
            for (int i = 0; i < val.Length; i++) {
                Console.WriteLine(val[i]);
            }

        }

    }
}
