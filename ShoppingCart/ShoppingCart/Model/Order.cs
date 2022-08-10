using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    public class Order
    {
        private int _id;
        private DateTime _date;
        private List<LineItem> _items = new List<LineItem>();
        public Order(int id, DateTime date)
        {
            _id = id;
            _date = date;
        }
        public int Id { get { return _id; } }
        public DateTime Date { get { return _date; } }

        public List<LineItem> OrderItems { get { return _items; } }

        public void Additem(LineItem item)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Product.Name.Equals(item.Product.Name))
                {
                    _items[i].Quantity+=item.Quantity;
                    return;
                }
            }
            _items.Add(item);
        }
        private double checkOutPrice = 0;
        public double CalculateCheckOutPrice()
        {
            foreach (LineItem item in _items)
            {
                checkOutPrice += item.CalculateItemCost();   
            }
            return checkOutPrice;
        }
        public void RemoveItem(LineItem item)
        {
            _items.Remove(item);
        }
        public int GetCountItem()
        {
            return _items.Count;
        }
    }
}
