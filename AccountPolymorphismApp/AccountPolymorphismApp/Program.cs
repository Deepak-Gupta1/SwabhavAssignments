using AccountPolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
            Console.ReadKey();
        }

        private static void CaseStudy3()
        {
            Account[] accounts = new Account[5];
            accounts[0] = new SavingAccount(101, "Deepak", 3000);
            accounts[1] = new CurrentAccont(201, "Shyam", 5000);
            accounts[2] = new SavingAccount(102, "Vinay", 4000);
            accounts[3] = new CurrentAccont(202, "Sumeer", 6000);
            accounts[4] = new CurrentAccont(203, "Abishek", 2400);

            Account maxBalAcct= accounts[0];

            foreach (Account account in accounts)
            {
                if (maxBalAcct.Balance < account.Balance)
                {
                    maxBalAcct = account;
                }

            }
            PrintDetails(maxBalAcct);
            
        }

        private static void CaseStudy1()
        {
            Account sa1 = new SavingAccount(1001, "Deepak", 3000);
            PrintDetails(sa1);
            Account sa2 = new SavingAccount(1001, "Deepak");
            PrintDetails(sa2);
            Account ca1 = new CurrentAccont(1001, "Sumeer");
            PrintDetails(ca1);
            Account ca2 = new CurrentAccont(1001, "Sumeer", 5000);
            PrintDetails(ca2);
        }

        private static void CaseStudy2()
        {
            Console.WriteLine("CaseStudy 2");
            Account sa1 = new SavingAccount(1001, "Deepak", 3000);
            PrintDetails(sa1);
            Account sa2 = new SavingAccount(1001, "Deepak");
            sa2.Deposite(2000);
            sa2.Withdraw(2000);
            PrintDetails(sa2);
            Account ca1 = new CurrentAccont(1001, "Sumeer");
            PrintDetails(ca1);
            Account ca2 = new CurrentAccont(1001, "Sumeer", 5000);
            ca2.Withdraw(6000);
            ca2.Withdraw(6000);
            PrintDetails(ca2);
        }

        private static void PrintDetails(Account acc)
        {
            Console.WriteLine("Account Type: " + acc.ToString());
            Console.WriteLine("Account ID: "+acc.Accno);
            Console.WriteLine("Name: " + acc.Name);
            Console.WriteLine("Balance: " + acc.Balance);
            Console.WriteLine("-------------------------");
        }
    }
}
