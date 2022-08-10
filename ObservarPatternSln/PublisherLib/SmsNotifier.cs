using PublisherLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherLib
{
    public class SmsNotifier : INotifier
    {
        public void notify(Account acc,string transactionType)
        {
            Console.WriteLine("Hey! "+acc.Name+" , "+acc.TransactionAmt +" "+ transactionType+" in account no "+acc.Accno+"\n Your current balance is "+acc.Balance);
        }
    }
}
