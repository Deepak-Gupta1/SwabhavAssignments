using System;
namespace StatisticsApp
{
    internal class StatisticsTest
    {
        static void Main(string[] arg)
        {
            int sum = 0;
            int k = Convert.ToInt32(arg[0]);
            int Max_num = Convert.ToInt32(arg[0]); ;

            for (int i = 0; i < arg.Length; i++)
            {
                int num = Convert.ToInt32(arg[i]);
                Console.Write(num+" ");
                k = Math.Min(k, num);
                Max_num = Math.Max(Max_num, num);
                sum += num;
            }    
            Console.WriteLine("\n"+"Count : " + arg.Length);
            Console.WriteLine("Sum " + sum);
            int avg = sum / arg.Length;
            Console.WriteLine("Average : " + avg);

            Console.WriteLine("Minimum Number  :" + k);
            Console.WriteLine("Maximum Number :" + Max_num);
            Console.ReadKey();
            
        }
        
    }
}
