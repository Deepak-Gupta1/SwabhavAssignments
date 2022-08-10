using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp
{
    public class Invoice 
    {
        private Product _product;
        private string _invoiceDescription;
        private IDiscount discount;
        private ITaxAmount taxAmount;
        private double taxRate;
        private double discountRate;
        public Invoice(String invoiceDescription,Product product)
        {
            discountRate = discount.CalculateDiscountAmount(product);
            taxRate = taxAmount.CalculateTaxAmount(product);
            _product = product;
            _invoiceDescription = invoiceDescription;
        }
        public String InvoiceDescription { get { return _invoiceDescription; } }
        public Product Product { get { return _product; } }
       
        public double CalculateFinalAmount()
        {
            return _product.Amount - discountRate + taxRate;
        }

    }

}
