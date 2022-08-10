using PublisherLib;
using PublisherLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservarPatternSln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(101,"Deepak",1000);
            acc.addNotifier(new SmsNotifier());
            acc.Deposite(2000);
            acc.Withdraw(500);
            Console.ReadKey();  
        }
    }
}
