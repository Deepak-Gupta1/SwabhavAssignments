using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp
{
    public class Product
    {
        private string _productName;
        private double _amount;
        private float _discountPercent;
        private float _taxPercent;

        public Product(string productName, double amt, float discPer, float tacPer)
        {
            _productName = productName;
            _amount = amt;
            _discountPercent = discPer;
            _taxPercent = tacPer;
        }
        public string ProductName { get { return _productName; } }
        public double Amount { get { return _amount; } }
        public float DiscountPercent { get { return _discountPercent; } }
        public float TaxPercent { get { return _taxPercent; } }
    }
}
