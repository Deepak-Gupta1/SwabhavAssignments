using System;
using System.Collections;
using System.Linq;

namespace LogicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 8, 7, 3, 5, 4, 5, 3, 6 ,7}; //4,3,2,5,3,7,1,5,3,4
            Console.WriteLine("Given Money by mom per day");
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
            Array.Sort(arr);
            Console.Write(" sum Rs."+arr.Sum());
            ArrayList eldbro = new ArrayList();
            ArrayList youngbro = new ArrayList();;
            for (int i = arr.Length / 2; i < arr.Length; i++)
            {
                eldbro.Add(arr[i]);
            }
            for (int i = 0; i < arr.Length / 2; i++)
            {
                youngbro.Add(arr[i]);
            }
            Console.WriteLine();
            int el =Sumlist(eldbro);
            int yn = Sumlist(youngbro);
            while (el-yn >=4)
            {
                youngbro.Add(eldbro[0]);
                eldbro.RemoveAt(0);
                el= Sumlist(eldbro);
                yn= Sumlist(youngbro);
            }
            if (el < yn)
            {
                int k = 0;
                int temp = el;
                while (temp <yn)
                {
                    temp = el;
                    temp += (int)youngbro[k];
                    yn -= temp;
                    k++;
                }
                eldbro.Add(youngbro[k]);
                youngbro.RemoveAt(k);

                eldbro.Sort();
                youngbro.Sort();
                el = Sumlist(eldbro);
                yn = Sumlist(youngbro);
                while (el - yn >= 4)
                {
                    youngbro.Add(eldbro[0]);
                    eldbro.RemoveAt(0);
                    el = Sumlist(eldbro);
                    yn = Sumlist(youngbro);
                }
            }
            if (el == yn)
            {
                eldbro.Add(youngbro[0]);
                el += (int)youngbro[0];
                youngbro.RemoveAt(0);
            }
            Console.WriteLine("\nelder brother get Rs." + el);
            print(eldbro);
            Console.WriteLine("\nyounger brother get Rs." + yn);
            print(youngbro);
            Console.ReadKey();
        }

        static void print(ArrayList ar)
        {
            foreach (var item in ar)
            {
                Console.Write(item + " ");
            }
        }

        static int Sumlist(ArrayList ar)
        {
            int add = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                add += (int)ar[i];
            }
            return add;
        }

    }
}
