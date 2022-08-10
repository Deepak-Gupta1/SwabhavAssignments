using System;
namespace FunctionApp
{
    internal class FunctionTest
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(args[0]);
            if (num % 2 == 0)
            {
                int res;
                res = FindCube(num);
                Console.WriteLine("cube of " +num +" is " + res);
            }
            else
            {
                Console.WriteLine("Given  number is odd");
            }

            Console.ReadKey();
        }
        static int FindCube(int num)
        {
            int cubenum = num * num * num;
            return cubenum;
        }

    }
}
