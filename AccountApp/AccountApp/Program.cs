using AccountApp.Model;
using System;
using System.Reflection;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            CaseStudy4();
            Console.ReadKey();
        }

        public static void CaseStudy1()
        {
            
            Account acc1 = new Account(101, "Deepak",600);
            PrintDetails(acc1);
        }
        public static void CaseStudy2()
        {
            Account acc2 = new Account(102, "Rudra");
            acc2.Deposit(1000);
            PrintDetails(acc2);
            acc2.Withdraw(1001);
            PrintDetails(acc2);
        }
        public static void CaseStudy3()
        {
            Account [] accounts = new Account[4];
            accounts[0] = new Account(103, "Virat", 6000);
            accounts[1] = new Account(104, "Faf du plessis", 2000);
            accounts[2] = new Account(105, "Harshal Patel", 3000);
            accounts[3] = new Account(106, "Siraj");
            PrintDetails(accounts);
        }

        public static void CaseStudy4()
        {
            Account acc1 = new Account(201, "Rudra");
            acc1.Deposit(5000);
            acc1.Withdraw(1000);
            acc1.Withdraw(1000);
            acc1.Deposit(4000);
            Console.WriteLine("User1 Transaction "+acc1.UserTransactionCount);
            Account acc2 = new Account(202, "Mahesh");
            acc2.Deposit(2000);
            acc2.Withdraw(1000);
            acc2.Withdraw(500);
            acc2.Deposit(4000);
            acc2.Deposit(4500);
            Console.WriteLine("User1 Transaction "+acc2.UserTransactionCount);
            Console.WriteLine("Total Transaction: " + Account.AllUserTransactionCount);
        }

        private static void PrintDetails(Account[] accounts)
        {
            foreach (Account acc in accounts)
            {
                PrintDetails(acc);
            }
        }

        public static void PrintDetails(Account accont)
        {

            Console.WriteLine("Account No :"+accont.Accno);
            Console.WriteLine("Customer Name :" + accont.Name);
            Console.WriteLine("Balane Amount :" + accont.Balance);
            Console.WriteLine();
        }
        
    }
}
