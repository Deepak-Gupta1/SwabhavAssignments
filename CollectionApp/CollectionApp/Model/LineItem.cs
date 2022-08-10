using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp.Model
{
    public class LineItem
    {
        private int _id;
        private string _product;
        private int _quantity;
        private double _unitPrice;
        public int x;
        public int y;
        public string f;

        public LineItem(int id , string product , int quantity ,double unitPrice)
        {
            _id = id;
            _product = product;
            _quantity = quantity;
            _unitPrice = unitPrice;
        }
        public int Id { get { return _id; } }
        public string Product { get { return _product; } }
        public int Quantity { get { return _quantity; } }
        public double UnitPrice { get { return _unitPrice; } }
        public double calcuateItem()
        {
            return _quantity * _unitPrice;
        }
    }
}
