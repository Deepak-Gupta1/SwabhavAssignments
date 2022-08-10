using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    internal class Customer
    {
        private  string _id;
        private string _firstName;
        private string _lastName;
        private int _orderCount;
        private static int userCount = 1;
        public Customer(string firstName ,string lastName,int orderCount)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._orderCount = orderCount;
            this._id = "C00"+userCount++;
        }
        public string Id
        {
            get { return _id; }
        }
        public string FirstName { 
            get { return _firstName; }
        
        }
        public string LastName
        {
            get { return _lastName; }
        }

        public int getOrderCount
        {
            get { return _orderCount; }
        }


    }
}
