using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEncap2App.Model
{
    internal class Customer
    {
        private int _id;
        private string _name;
        private int _orderCount;

        public int Id { get { return _id; } set { _id = value; } }

        public string Name { get { return _name; } set { _name = value; } }

        public int OrderCount { get { return _orderCount; } set { _orderCount=value;  } }
    }
}
