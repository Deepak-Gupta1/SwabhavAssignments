using System;
namespace AccountSerializationApp.Model
{
    [Serializable]
    public class Account
    {
        public int _accno;
        public string _name;
        public double _balance = 5000;
        private static int _allUserTransactionCount;
        private int _userTransactionCount;
        private const double MIN_BAL = 500;

        public int Accno
        {
            get { return _accno; }
            set { _accno = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
            if (_balance - amt < MIN_BAL)
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
