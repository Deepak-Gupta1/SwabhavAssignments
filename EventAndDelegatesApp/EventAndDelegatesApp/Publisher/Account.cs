using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegatesApp.Publisher
{
    public delegate void DBalanceChanger(Account acc);
    public class  Account
    {
        private int _accno;
        private string _name;
        private double _balance;
        public event DBalanceChanger OnBalanceChanged=null;
        public Account(int accno,string name,double balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
           
        }
        public Account(int accno, string name):this(accno,name,1000)
        {
        }
        public void Deposite(double amt)
        {
            _balance += amt;
            if (OnBalanceChanged != null) { OnBalanceChanged(this); }
        }
        public int Accno{ get { return _accno; } set { _accno = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double Balance { get { return _balance; } set { _balance = value; } }

        public void Withdraw(double amt)
        {
            if (_balance-amt > 500)
            {
                _balance = _balance - amt;
                if (OnBalanceChanged != null) { OnBalanceChanged(this); }
            }
            else
            {
                Console.WriteLine("No fund");
            }
        }

    }
}
