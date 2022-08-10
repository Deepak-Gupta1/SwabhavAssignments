using EventAndDelegatesApp.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegatesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101,"Deepak",2000);
            acc1.OnBalanceChanged += (acc)=>Console.WriteLine("Referensh Balnce {0}",acc1.Name);
            acc1.Deposite(1000);
            Console.ReadKey();
        }

        
    }
}
