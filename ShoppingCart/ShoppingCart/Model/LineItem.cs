using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    public class LineItem
    {
        private int _id;
        private Product _product;
        private int _quantity;
        public LineItem(int id , Product product , int quantity )
        {
            _id = id;
            _product = product;
            _quantity = quantity;
        }
        public int Id { get { return _id; } }
        public Product Product { get { return _product; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }
        public double CalculateItemCost()
        {
            return _quantity * _product.calculateItemFinalPrice();
        }
    }
}
