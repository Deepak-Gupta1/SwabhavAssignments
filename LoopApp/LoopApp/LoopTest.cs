using System;
namespace LoopApp
{
    internal class LoopTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print 1 To 10 by FOR LOOP");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine("");
            Console.WriteLine("\nEven Number upto 20 by While Loop");
            int k = 0;
            while (k < 11)
            {
                Console.Write(" " + 2 * k);
                k++;
            }
            Console.WriteLine("");
            Console.WriteLine("\nOdd Number upto 20 by DO While Loop");
            int x = 1;
            do
            {
                if (x % 2 != 0)
                {
                    Console.Write(" " + x);
                }
                x++;
            } while (x < 21);

            Console.ReadKey();
        }
    }
}
