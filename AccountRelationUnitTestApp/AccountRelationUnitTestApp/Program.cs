using AccountRelationUnitTestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRelationUnitTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(101, "Deepak");
            acc.Withdraw(1600);
            Console.ReadKey();
        }
    }
}
