using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEncapApp.Model
{
    internal class Customer
    {
       private int _id;
       private string _name;
       private int _orderCount;

       public int GetId()
        {
            return _id;
        }

       public void SetId(int id)
        {
            _id = id;

        }

        public String GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void PlaceOder()
        {
            _orderCount ++;
        }
        public int GetOrderCount()
        {
            return _orderCount;
        }
    }

}
