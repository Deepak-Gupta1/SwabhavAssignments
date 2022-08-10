using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConvertIntoLambda
{
    internal class Program
    {
        public delegate void DAlertMessage(string msg);
        static void Main(string[] args)
        {
            Alert((n) => { Console.WriteLine("Hello "+n); });
            Alert((n) => { Console.WriteLine("Hey Alter " + n); });
            Console.ReadKey();
        }
        static void Alert(DAlertMessage fn)
        {
            Random rand = new Random();
            int val=rand.Next(10);
            Console.WriteLine(val);
            if (val > 5)
            {
                fn("Deepak");
            }
        }
    }
}

