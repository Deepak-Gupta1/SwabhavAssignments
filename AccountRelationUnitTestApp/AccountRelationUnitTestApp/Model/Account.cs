using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRelationUnitTestApp.Model
{
    public class  Account
    {
        private int _accno;
        private string _name;
        private double _balance;
        private List<Transaction>_transactions =new List<Transaction>();
        public Account(int accno,string name,double balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
            _transactions.Add(new Transaction(new DateTime(), "Deposite", balance));
           
        }
        public Account(int accno, string name):this(accno,name,1000)
        {
        }
        public void Deposite(double amt)
        {
            _balance += amt;
            _transactions.Add(new Transaction(new DateTime(), "Deposite", amt));
        }
        public int Accno{ get { return _accno; } set { _accno = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double Balance { get { return _balance; } set { _balance = value; } }

        public void Withdraw(double amt)
        {
            if (_balance-amt > 500)
            {
                _balance = _balance - amt;
                _transactions.Add(new Transaction(new DateTime(), "Withdraw", amt));
            }
            else
            {
                throw new ApplicationException("No funds to Withdraw");
            }
        }
        public int GetTransaction()
        {
            return _transactions.Count;
        }

    }
}
