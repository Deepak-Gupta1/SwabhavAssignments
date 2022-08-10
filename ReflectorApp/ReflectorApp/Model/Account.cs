using System;
namespace ReflectorApp.Model
{
    internal class Account
    {
        private int _accno;
        private string _name;
        private double _balance;
        private static int _allUserTransactionCount;
        private int _userTransactionCount;
        private const double MIN_BAL = 500;
        public Account(int accno ,string name ,double balance)
        {
            _accno= accno;
            _name= name;
            _balance= balance;
        }

        public Account(int accno ,string name):this(accno,name,MIN_BAL)
        {
        }
        public int Accno
        {
            get { return _accno; }
        }
        public string Name
        {
            get { return _name; }
        }
        public double Balance
        {
            get { return _balance; }
        }
        public int UserTransactionCount
        {
            get { return _userTransactionCount; }
        }
        public static int AllUserTransactionCount
        {
            get { return _allUserTransactionCount; }
        }
        public void Deposit(double amt)
        {
            _balance = _balance + amt;
            _userTransactionCount++;
            _allUserTransactionCount++;
        }

        public void Withdraw(double amt)
        {
            if (_balance - amt <  MIN_BAL)
            {
                Console.WriteLine("You are trying to withdraw Insuficiant Amount!!");
                return;
            }
            _balance -= amt;
            _userTransactionCount++;
            _allUserTransactionCount++;

        }

    }
}
