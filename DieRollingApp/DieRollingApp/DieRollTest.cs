using System;
namespace DieRollingApp
{
    internal class DieRollTest
    {
        static void Main(string[] args)
        {

            int[] dieArray = Roll(10);
            for (int i = 0; i < dieArray.Length; i++)
            {
                Console.WriteLine("Occurence of " + (i + 1) + " :" + dieArray[i]);
            }
            Console.ReadKey();

        }
        static int[] Roll(int rep)
        {
            int[] Die = { 0, 0, 0, 0, 0, 0 };
            Random rnd = new Random();
            int i = 0;
            while (i < rep)
            {
                int val = rnd.Next(1, 7);
                int oc = Die[val - 1];
                Die[val - 1] = oc + 1;
                i++;
            }

            return Die;
        }
    }
}