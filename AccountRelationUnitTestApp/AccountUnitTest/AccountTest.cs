using AccountRelationUnitTestApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AccountUnitTest
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void WithdrawThrowExceptionWhenTryToWithdrawInsufficaintAmount()
        {
            Account acc = new Account(101, "Deepak");
            string expectErrorMessage = "No funds to Withdraw";
            var ex = Assert.ThrowsException<ApplicationException>(() => acc.Withdraw(1600));
            Assert.AreEqual(expectErrorMessage, ex.Message);
        }
        [TestMethod]
        public void DepositeAmountShouldAddInMainBalance()
        {
            double expectBalance = 2000;
            Account acc = new Account(101, "Deepak");
            acc.Deposite(1000);
            Assert.AreEqual(expectBalance, acc.Balance);

        }
        [TestMethod]
        public void WithdrawAmountShouldDeductInMainBalance()
        {
            double expectBalance = 5000;
            Account acc = new Account(101, "Deepak",10000);
            acc.Withdraw(5000);
            Assert.AreEqual(expectBalance, acc.Balance);

        }
        [TestMethod]
        public void TransactionSholudIncreaseWhenDepositeAndWithdrawAmout()
        {
            int expectTransactionCount = 4;
            Account acc = new Account(101, "Deepak", 10000);
            acc.Withdraw(5000);
            acc.Deposite(2000);
            acc.Withdraw(1500);
            Assert.AreEqual(expectTransactionCount, acc.GetTransaction());


        }
       
    }
}
