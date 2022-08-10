using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    internal class Customer
    {
        private int _id;
        private string _name;
        private List<Order> _list=new List<Order>();

        public Customer(int id , string name)
        {
            _id=id;
            _name=name;
        }
        public int Id
        {
            get { return _id; }
        }
        public string Name { get { return _name; } }
        public List<Order> OrderList { get { return _list; } }

        public void AddOrder(Order or)
        {
            _list.Add(or);
        }
        public void RemoveOrder(Order or)
        {
            _list.Remove(or);
        }

    }
}
