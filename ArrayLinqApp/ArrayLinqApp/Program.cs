using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> userName = new String[4] { "Deepak", "Vinay", "Sumeer", "abcabc" };
            //query
            //display all names in upper and lower casing functional programing
            userName.ToList().ForEach(PrintToUpper); 
            userName.ToList().ForEach((u)=>Console.WriteLine(u.ToUpper()));

            //display name with maxium character count>=6
            IEnumerable<string> longNameQuery = userName.Where(u => u.Length >= 6);
            longNameQuery.ToList().ForEach((u) => Console.WriteLine(u));
            //Deferred execution , lazy Execution
            IEnumerable<string> topLongNameQuery = longNameQuery.Take(6).ToList();
            topLongNameQuery.ToList().ForEach((u)=>Console.WriteLine(u));
            // query to display all name in ascending order of name
            IEnumerable<string>ascOrderName=userName.Select(u=>u.OrderByDescending);
        }
        static void PrintToUpper(string name)
        {
            Console.WriteLine(name.ToUpper());
        }

    }
}
