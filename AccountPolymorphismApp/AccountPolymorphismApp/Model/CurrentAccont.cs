using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    internal class CurrentAccont :Account
    {
        const int OVER_DRAFT = -5000;
        public CurrentAccont(int accno, string name, double balance) : base(accno, name, balance)
        {
        }
        public CurrentAccont(int accno, string name) : this(accno, name, 1000)
        {
        }
        public override void Withdraw(double amt)
        {
            if(base.Balance <= OVER_DRAFT)
            {
                Console.WriteLine("You can't Withdraw , Insufficiant Balance!!");
                return;
            }
            base.Balance -= amt;
        }
        public override string ToString()
        {
            return "Current Account";
        }
    }
}
