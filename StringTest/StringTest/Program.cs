using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sbcde SVHDIBV BBJa ahvy";
            Console.WriteLine(name.ToUpperInvariant());
            //CaseStudy();

            Console.ReadKey();
        }

        private static void CaseStudy()
        {
            string[] n = new string[3];
            n[0] = "bubrf";
            n[1] = "abcf";
            n[2] = "abcz";
            string s = "abc";
            string str = "";
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i].Contains(s))
                {
                    str = str + i + ",";
                    if (n[i].Equals(s))
                    {
                        Console.WriteLine(n[i]);
                        return;
                    }
                }
            }
            string[] arr = str.Split(',');
            for(int r = 0; r < arr.Length-1; r++)
            {
                Console.WriteLine(Convert.ToInt32(arr[r]));
            }
        }
    }
}
