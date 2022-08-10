using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRelationUnitTestApp.Model
{
    public class Transaction
    {
        private DateTime _date;
        private string _type;
        private double _amount;
        public Transaction(DateTime date ,string type ,double amount)
        {
            _date = date;
            _type = type;
            _amount = amount;
        }
        public DateTime Date
        {
            get { return _date; }
        }
        public string Type { 
               get { return _type; }
        }
        public double Amount
        {
            get { return _amount; }
        }
    }
}
