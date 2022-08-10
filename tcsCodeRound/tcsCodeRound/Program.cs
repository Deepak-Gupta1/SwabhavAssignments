using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcsCodeRound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'b', 'b', 'c', 'c', 'c', 'a', 'f', 'c' };
            char[] lower = new char[27];
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] >= 'a' && arr[i] <= 'z'))
                {
                    lower[arr[i] - 'a']++;
                }
            }
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine((int)lower[i]);
            //}

            int[] arr1 = {2,4,6,2,3,5,2,3,4,1,5,7,3,5};
            int[] count=new int[11];  
            for (int i = 0; i < arr1.Length; i++)
            {
                count[arr1[i]]++;
            }
            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine(count[i]);
            }
            //    bool flag=false;
            //    char ch = '\0';
            //for (int i = 0; i < lower.Length; i++)
            //{
            //    if (lower[arr[i] - 'a'] % 2 == 1)
            //    {
            //        ch = (char)(arr[i]);
            //        flag = true;
            //        break;
            //    }
            //}

            //if (flag)
            //{
            //    Console.WriteLine(ch);
            //}
            //else
            //{
            //    Console.WriteLine("all r even");
            //}
            Console.ReadKey();

        }
    }
}
