using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib.Model
{
    public class  Account
    {
        private int _accno;
        private string _name;
        private double _balance;
        private List<INotifier> _notifier =new List<INotifier>();
        private double _transactionAmt;
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
            _transactionAmt = amt;
            _balance += amt;
            if (_notifier != null)
            {
                foreach (INotifier notifier in _notifier)
                {
                    notifier.notify(this,"Deposite");
                }
            }
        }
        public int Accno{ get { return _accno; } set { _accno = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double Balance { get { return _balance; } set { _balance = value; } }

        public void Withdraw(double amt)
        {
            if (_balance-amt > 500)
            {
                _balance = _balance - amt;
                if (_notifier != null)
                {
                    foreach (INotifier notifier in _notifier)
                    {
                        notifier.notify(this, "Withdraw");
                    }
                }
            }
            else
            {
                throw new ApplicationException("No funds to Withdraw");
            }
        }
        public void addNotifier(INotifier notifier)
        {
            _notifier.Add(notifier);
        }
        public List<INotifier> Notifier
        {
            get { return _notifier; }
        }
        public double TransactionAmt
        {
            get { return _transactionAmt; }
        }
    }
}
