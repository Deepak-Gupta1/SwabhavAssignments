using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRViolationApp.Model
{
    public class Invoice
    {
        private string _description;
        private double _amount;
        private float _discountPercent;
        private float _taxPercent;

        public Invoice(string desc, double amt, float discPer , float tacPer)
        {
            _description = desc;
            _amount = amt;
            _discountPercent = discPer;
            _taxPercent = tacPer;
        }
        public double CalculateDiscountAmount()
        {
            return _amount *_discountPercent/100;
        }
        public double CalculateTaxAmount()
        {
            return _amount * _taxPercent/100;
        }
        public double CalcualateFinalAmount()
        {
            return _amount-CalculateDiscountAmount()+CalculateTaxAmount();
        }
        public void PrintInvoice()
        {
            Console.WriteLine("Invoice Details");
            Console.WriteLine(_description);
            Console.WriteLine("Actual Cost "+_amount);
            Console.WriteLine("Discount " + _discountPercent+" %");
            Console.WriteLine("Tax Percent " + _taxPercent + " %");
            Console.WriteLine("Final Amount " + CalcualateFinalAmount());
        }
    }
}
