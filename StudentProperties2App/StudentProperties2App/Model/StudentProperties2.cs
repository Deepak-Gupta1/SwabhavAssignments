using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProperties2App.Model
{
    internal class Student
    {
        private int _roll;
        private string _name;
        private int _totalFees;
        private int _remainingFee;

        public int RollNo
        {
            get { return _roll; }

            set
            {
                if (value > 0) { _roll = value; } else { _roll = 1; }
            }
        }
        public string Name
        {
            get { return _name; }

            set
            {
                if (value.Length < 5) { _name = "Anonymous"; } else { _name = value; }
            }
        }

        public int RemainingFee
        {
            get { return _remainingFee; }
        }

        public int TotalFees
        {
            get { return _totalFees; }

            set
            {
                _totalFees = value;
            }

        }
        public void PayFees(int amt)
        {
            _remainingFee = _totalFees - amt;
            _totalFees = _remainingFee;
        }


    }
}
