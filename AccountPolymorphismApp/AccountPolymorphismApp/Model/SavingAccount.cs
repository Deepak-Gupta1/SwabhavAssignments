using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    internal class SavingAccount : Account
    {
        const int MIN_BALANCE = 500;
        public SavingAccount(int accno, string name, double balance) : base(accno, name, balance)
        {
        }
        public SavingAccount(int accno, string name) : this(accno, name,1000)
        {
        }
        public override void Withdraw(double amt)
        {
            if (base.Balance <= MIN_BALANCE)
            {
                Console.WriteLine("You can't Withdraw , Insufficiant Balance!!");
                return;
            }
            base.Balance -= amt;
        }

        public override string ToString()
        {
            return "Saving Account";
        }
    }
}
