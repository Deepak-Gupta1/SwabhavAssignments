using OddEvenApp.Model;
using System;

namespace OddEvenApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OddEven num = new OddEven(21);
            CaseStudy1(num);
            CaseStudy2(num);
            Console.ReadKey();
        }

        public static void CaseStudy1(OddEven num)
        {
            int[] EvenNos = num.Evens;
            PrintDetails(EvenNos);
        }
        public static void CaseStudy2(OddEven num)
        {
            int[] OddNos = num.Odds;
            PrintDetails(OddNos);
        }
        public static void PrintDetails(int [] Nums)
        {
            foreach (int i in Nums)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

        }
    }
}
