using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    internal abstract class  Account
    {
        private int _accno;
        private string _name;
        private double _balance;

        public Account(int accno,string name,double balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
        }
        public void Deposite(double amt)
        {
            _balance += amt;
        }
        public int Accno{ get { return _accno; } set { _accno = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double Balance { get { return _balance; } set { _balance = value; } }

        public abstract void Withdraw(double amt);
        
    }
}
